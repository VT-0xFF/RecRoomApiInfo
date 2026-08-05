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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x756A770", Offset = "0x7569B70", VA = "0x18756A770")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HOOOMLNBMLG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> NLDPKNKGIIM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> OJEPPPHDJCK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> AMLJKJPIPEN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> APNGEEJAAFP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string NKENLIAOGKN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string OJCGHBJLJHD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string CHIHBJEJKEH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x755B320", Offset = "0x755A720", VA = "0x18755B320")]
	public static bool LNKPCHILOMF(Guid JMEKHMAIBNE, int FNODDPGHMDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x755B420", Offset = "0x755A820", VA = "0x18755B420")]
	public static bool MEMLHMNGOHG(Guid JMEKHMAIBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x755B4B0", Offset = "0x755A8B0", VA = "0x18755B4B0")]
	public static string OFJOOKBCDMK(Guid BCIHOIBCNMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HHKHHPEBNFJ]
public enum JPMEJKALDHD
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
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x756A450", Offset = "0x7569850", VA = "0x18756A450", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GNAFNEEHKPK
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid JAJIIOCLOOI;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid KKHODDPGLPO;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid MLLGEBCLKKM;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid AOOEOOCBANB;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid NHJMLGABCJN;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid JGLDDBDHAHP;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid KLLNBKPBDCI;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid IIDJGEHIOBD;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid EJCDPDKIODB;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid FHOKNAFLDGC;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid GJPGOHOAJIC;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid AOCNEGGIOHK;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid JANKMOJDEHP;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid AFDEKLMJIFD;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid LIMFKAHDHJC;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid MMJNGPEHBIJ;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid NFEEEAJHHNP;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid COGAFDODDAB;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid DJKJLKJMPIC;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid FFKHIBCGEHD;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid IGHCGMJBFEG;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid AEJIBMBIGOM;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid PAPKGNMGLNC;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid CFEFKJGPMKL;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid MCKNNABENAL;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid JJLPPCMPILC;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid GOHNFDAHEKN;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid EIOIPOIEKCM;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid ADGGNBGJLKO;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid HOBDGKJALMH;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid BCPLJOMNJAI;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid MLLAEBKMNAJ;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid ELFBKMEMBKF;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid GBCKHGCMMOK;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid FPCMECPEOPH;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid OIJOANHBDPH;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid DLGBGAKHJHM;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid AEPJEHPHKBN;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid MPHCKJJOJJL;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid OIPLNODMBGB;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid JJJCIEICNLH;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid KCEIIMEJOOP;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid EFODPFNCDDB;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid LAPFJEIBIIG;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid GEJJDOAICBM;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid CJKALJBGKKA;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid MFFOOPEDLIO;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid KKFHNABKHHC;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid BLGMOEBEOJF;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid LBHAEHACMOO;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid JNKCJNKIDON;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid IKJPDCMNIJI;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid PFLNFGAHFJA;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid JIAMIEOCHCO;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid AKGOAJHIJNL;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid KCILFKKABBH;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid CHDMJDGLBMM;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid LCHBMAINIJN;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid MGMEEPIPGFF;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid HPKPCMIICKO;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid CFMMICDKPLB;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid GBHDGMFAOHB;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid LNHGIMBKDLP;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid CMGAKFFHAIA;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid PLFAOBLEGDD;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid NBJGDMBCEML;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid HGIGLANMIKF;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid CIKIIIMFMJL;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid GDKEJHHPONG;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid HNJLJGDJHIG;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid OLOLIEIFHBP;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid HFDFOEKAPIM;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid MDCAFIABBOG;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid HGPMGFCAAPN;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid FOOMBCLALHB;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid IHEIIFDMMDA;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid CBMGMOBEJAJ;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid KEBOJAAOCKM;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid OHECNJJBDEM;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid NKGCKBOEGCB;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid HBIDFBDNHLI;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid CMHKIICFPHG;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid HANBFGPKOKH;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid JGPDJAPIJMM;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid KANKGDMLAOP;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid HGFANBACDAP;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid KPNCGDNDHKP;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid BGCMFDGPLLP;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid GDAHLFFPKEM;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid HLOKNHHMNMF;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid EMKOAHPEFNP;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid MPHFIIKANND;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid JBAOOBOGJIE;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid PAJJONAGLPP;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid LKAAAJHJEAO;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid CNBIELHCBKH;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid HNHNEOGAKDL;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid INMMMOOEBDB;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid KDCIHLMNEDG;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid KILNEEJGEAF;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid PBLJKHFDMGO;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid INLHOIFDPKC;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid GMLPAAPPPGB;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid KEJNKGGHFLL;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid GMMAEMADOOG;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid JAOGMLEHMEG;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid MACOFCKPJCG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid AOEMFEKJFCM;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid CKFBHENGOII;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid MHPNBLPMOIJ;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid IGBMPFBJFCN;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid GLHABHIBIFK;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid EPEBDFODCCH;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid HHMIMDHCMCA;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid EBFFDFIEEOE;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid IDIHOHEFCGI;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid HNHNINCKALJ;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid ELDHNABIGPL;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid LEIOLOMBHEG;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid PGIEDKODCJH;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid LHKGGAICLLN;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid LGOEKAOFENB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid LEDCFDJEFKG;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid NFPNNNICNNH;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid MLJMMNGGJKL;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid JOHHMFPNOIM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid OHICCJOLOFP;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid FKPPEHPCNCG;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid HGDDKBPPACN;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid JDCDPJPPCNE;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid MCHGNMPFDGM;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid KKDNHCENOAO;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid IIHNKLHBBMN;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid PKFMGCNPGJN;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid DLJLJPCICMJ;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid EIIEIIEDJEE;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid EEGHIPMKLJO;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid LMFNMHOAMCL;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid GCDEHJADMAC;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid LIHIMOAOAKI;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid ICOGBMBJHLD;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid BLLHPDAILLP;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid FBNJABPIIMH;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid ICLDHIGDAJK;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid BBICIHEFCNO;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid FPIJABFNBEJ;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid BKFHDHAMANA;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid DDMIKHEBKLB;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid CPFLJDBCLAM;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid BJGKGFKKMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid EHEJFADONGD;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid IHLGJJHAOGP;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid MNGHDGDLIFP;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid JFOPNMCOCDH;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid CGDMCIGMMDC;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid LNGLBIIEFED;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid MGIFCKPNDFK;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid BIJIDIHKPAH;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid EPDLCKFAIHB;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid FCGNCJENPAF;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid MNKEKHIPIOK;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid IOHDNLFNOGP;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid PBBEMDJJOJC;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid HOHCDDMHAPO;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid CAICIKNJEPD;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid GGCJOAPMLIH;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid AMANOOFDIHI;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid EOAMLDGEFFP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid PNIPGOEPFMH;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid PCLBIFBLNJF;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid FECKCHNLGJE;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid OIJLAMALGLB;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid KEFCAOICGLH;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FMFPAOMKJPA;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid FKIIFGLBNND;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid ANMFJPKBBMH;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid FBOBKMEIDDN;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid JADOLPLFOPC;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid IBOGOKGKCPF;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid CJLPGKBDDJC;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid PJAAEKOMEAP;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid OKIFDPGFOMI;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid LEKBEMKHPGO;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid HFDLEMFEFCG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid PHFFEFGFLBA;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid CIAGAKHKNMG;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid HLLOGDMCGFI;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid JLNPIOOIFBL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid HIOOIFEAMFC;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid PMJDANKBEOE;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid BOEEDJKDDLO;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid BPCLPEDMBKG;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid GGGIDNHMLLI;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid CLKPPNOCHLE;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid KOHBPKHAGBA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid PNJDDEGKHHB;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid ICOLHKFONDC;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid IEGDMCDINHL;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid BICAIOKNIML;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid KMKFDKPBFNA;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid KGAJEGKCHHL;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid DJKHHJPEKCE;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid IKJBLNAPEHN;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid AMFAOFDLIHC;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid CHBJNJDFHEM;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid JDHBNBJABAK;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid PPEGMEOLGNN;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid KNMAAIPBJDE;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid EPECBJLEMFA;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid EEOJEIDPIFN;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid CNPPOKAJDJD;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid EKLKHADCHPC;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid IMNIDMOJJCM;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid FFHBKKNPBDG;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid ACIABFPANKN;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid JLIAEDLMBIH;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid MIOBPHPOBCL;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid NONHFJNAKKP;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid EEFPJKLNKOE;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid JPJAOJJOMJG;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid FMGFOPABABO;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid DGLAONEFELO;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid LNDBIOAKCDF;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid MJHBPJJMPON;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid OGIJOBMAJCF;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid JCMDACNMIDM;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid IMDPNEEDKBD;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid NPKLFANIIGJ;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid LGJEAOEJCND;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid KAHIHECIMIC;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid ANMBKDNMGFI;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid KMEFBJKPDCH;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid FHGDJLBNEKP;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid CMOJGIFOGDL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid PBLMAIJBMEA;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid PAIPHGDNIHC;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid PCLMCIPNMNN;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid EAJMKMHHMDL;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid FJHLKJNPGLE;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid NBCIAJMJAPO;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid ADGAHEOGJHG;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid LFJBBPMGHDN;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid GKCOJGEODCN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid MOMEMCDENPO;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid KILCIKBBCHO;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid KKEEFNKMAFN;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid KDMJNFMDNAJ;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid GKPILAHFMCP;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid KGLNFMDMJNH;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid NHPEPGDKOGE;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid AKHOFDFECNC;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid NBCBNCJBHMG;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid PDGBDOFMFGJ;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid JOPHHKKEFLG;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid KFEKEHJMPNE;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid CJCGMMFILKM;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid BGBEFMEGPMG;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid GAEAAAABGBC;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid HJFGMIFBFLL;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid JFFILJNCPJD;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid OPNMGJACLPO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid DJIOECNPNOD;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid NFNNDNFJPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid HHLCDPGBLIN;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid OFOOBFJFDJM;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid FEIOLOEPKPD;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid CINHHEFBJBO;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid MMMHMLLBBJI;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid IMEKCFEINKN;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid LHBMDIABJCO;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid NAHOEGELCNM;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid GMIEJBBOKLG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid KANDIFKCDPD;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid LIPIPCHMBEB;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid MOPILDHNFGK;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid FBLHPFJJKAC;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid KKEAMEGOIDM;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid FKDOPNIJDPJ;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid LJNLNAKLJDC;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid DLAMCMEKJMB;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid HLDKINMKKGL;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid GMAFLDEDFDC;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid LCOLEGFHNNB;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid MJELCDHJFOI;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid DLLAFGAHOCD;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid DOGMENMBMJI;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid PDPFCECOFCO;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid DOCENEMGIBB;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid NNLMLIGOKGK;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid NHFAJNMJMOF;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid FGKHMONFPOG;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid DJAHIKNBLDK;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid JEKHFBLKIHH;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid HMFIGNEPEGL;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid BLHMDJDFHIP;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid LFNAGDDJPEA;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid AGGJOAGEHFL;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid KJLJBMDAMCB;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FKDCMALPGOA;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid EDOJFIHCGBG;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid OOPGGKBIAPO;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid EMOAFKIKPLC;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid HIJMMNAGKFN;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid IABACIHFCIG;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid FKFMHPLJHPI;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid HOHCPAMGFIG;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid BOCILHJAFDD;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid MHPGNJONFAD;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid KOPIENIJAIO;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid MJKLDENAAOP;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid HMJDKGMGBMG;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid PBGJMIELHOA;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid MNNEHGKFPMA;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid JOPGIGJDOBG;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid INMEOFNIDEN;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid CCMAIAPHJFJ;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid NFBILOHDJJF;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid PNFEJPHKDHK;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid BFEGCHFPJDB;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid EFKNFBOOEBP;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid OIAGAPLJGDM;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid LJHFABDLPHN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid GFKNFALALGI;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid BEEPOPODEAN;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JOLCPBBMNNI;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid ABDCAJKOMOC;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid CPCDEBBBMDG;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BLLGFCIKFNE;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid GNONLAMAKLN;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid IPKAMJEFIOH;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid JEDKIGPHHIH;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid PEEKDLCFFID;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid LEIDDNENPAL;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid NHEHLCNEHFF;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid NGIABLEKHBG;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid NACCHNBNNBG;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid ALDALPFDIJK;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid JCHDAPMKHAA;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid IIADKPOFKIE;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid HFJBIKMJLBE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid HKBNIIBENAL;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid OGGPAPKKCJK;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid ANMKAFOHAJB;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid ALJFOLNFOBG;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid DCDAFLHJJDL;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid PNNFBMCEAOG;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid DLCOKDLDGOK;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid DKAJIOIJDOO;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid JBANJHLOMLB;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid CEANONDKKGJ;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid OPCAFLLHFGA;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid OLKCKFPCJOM;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid IANCGDFKECG;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid HFOMOKILDOH;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid CLGEMODFHNO;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid FIMGIPNFFKK;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid LLODMCJBIMN;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid MIJGCGBAMGK;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid NJOKAIECNOA;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid AFFCHLEODLK;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid LEDCEJMHDFH;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid OOKFKGANGOF;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid NDJNIIFIAPH;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid ENIGFGPLBDN;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid JKCHKNMLPOG;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid KNNNJAOAKNC;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid MPEJIFKAMIO;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid LGPIPOPPCGI;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid HMPIBDLBIAL;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid KFLOOBHKFHC;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid ENJLMNHDKLG;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid AEAGDDHCCEG;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid KGJPJCBOHAO;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid PFALKHEIONE;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid GLCOLDKJCKB;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid DIBJOCIGDFO;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid ACOCJBFGHNC;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid KKKLIAEDEPN;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid JFAJKAMOFGF;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid OOAPJCHABIL;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid NAIAONOMOIP;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid FFDBAOLDFLP;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid KPMBCPPNHCG;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid CLBBDLPKOGN;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid CHLANCDONHE;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid NLGEFLBEEKD;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid EGJJBIJPLAJ;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid KPNGHHOLKEH;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid ELFFCDOCNHH;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid FDKGNJICELJ;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid GOHPDKBJBDD;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid CFMIAHPICPL;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid IHNLBACLBAJ;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid MOFOHDLGNJN;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid JNNDBDNFJAH;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid JGJJKFDHNAH;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid PLHDGBKABDA;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid DICCEPDHAOO;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid IGHFCJOPAJG;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid AABFGJDNOJJ;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid FMMKMCBNPNL;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid DNPJNILFHAK;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid FJFANCPCMHL;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid COOMEJBEECA;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid HHMDLFHJHOE;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid CDIKCMLAPIO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid IIONHNNAAIL;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid AELFHBBMCPL;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid GPEFABHIOCA;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid JPFFONHNGON;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid JDIPDGIFHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid JHDLGNIBMFP;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid FAMKACEIGIE;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid PFGNALDDNMA;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid FGNEFMJKBFP;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid OGLFEJLPICN;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid MAAOCGLEAAP;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid NAMIPPCFNNF;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid AHHBJMFFGEI;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid JMJFOOFPLBB;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GLJNHMBEPFM;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid BFKDDFDEIOH;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid GAFBABINLEI;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid GJJLICOOHCP;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid HCCHAPMPEPH;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid DJKOLEAGMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid COJCPLEOBCN;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid KPOFPMGHMKM;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid CDKMOLFPIIJ;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid BJIJDKPEKPO;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid KAFFELHLGBO;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid EBCHGHKPDIB;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid LEOGJLCBCKG;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid KONBPGFADPP;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid ABAEEEPCFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid LIGLNPKPBON;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid GIBLFBIBJNO;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid JLHBAAPJEEG;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid ODPFAGLJPNA;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid KMBLFJAFHCB;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid JNGEENMEELL;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid GKCJAFJPLDA;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid EDLLPIJKPEN;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid JGNJIMDLLHM;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid JHBNAEEEMAK;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid MDFKNGJIJBF;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid LELJFMAINNL;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid LEAPNFEFNLF;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid JFCEOJFHKHM;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid EAKBMMOCPHK;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid MNCMHJOIFOP;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid DKKMHOCHPHP;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid OBIPMKNLJLB;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid BPHFLFGHPDF;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid NBKGPLJHPDP;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid KPKBPHCFPDO;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid IHHOKHPHHOI;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid IKBKHFJPAAI;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid JGIJPHEAIMC;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid MFFLGHPHIND;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid CCEAKPALIDN;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid IODPGGFKGPO;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid PJBJHDBHCMK;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid PFICADNLHLM;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid OAANGBINOGB;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid CDHNNDEPKLF;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid DEEFCCNAILD;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid PLEPHBCFNMD;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid BDBKBIKIJEN;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid GFFPCLOAHHJ;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid IMKJJFKCBGH;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid DLJOHPGMHEP;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid OAAGAKIMKGM;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid IPAIPJAPDCB;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid JMCCGFLJFOH;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid HBCPBCJHGFP;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid EAFOCEEGIPN;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid JNMNICLNBFL;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid IICJAJJMALJ;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid BJFPACPNICA;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid DEJPNHPLOAP;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid OCIHBMOBBNI;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid PGIIKPEMBGK;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid GCOLNPMAKND;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid MPHAJLJMECJ;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LKEINPHPICJ;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid IKIACCIKGNH;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid DLPJEGDBPNN;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid ENDMJGMDKIO;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid JNHLFCDOLKB;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid INLDBNNHBPG;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid AFCGFKCCPLB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid HNONHGGJHNN;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid KGJLBOAJNGG;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid BDGKLCMBGNL;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid GNOLCJKHEEF;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid GCIDDGPJOJM;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid FHIICFMKPKJ;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid HABCKPNCMPB;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid FHCKLLJJPHP;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid HGAGFKDFJIO;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid OPMNAEGLMCH;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid GHNJHIIIGNF;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid MNPPFPALHNB;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid PIBOGGMKPEA;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BMLFOPIOJOI;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid CGCLGAJIIOD;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid ALCADAKOBMF;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid KKCHBKLDAKN;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid ODGNJOLLJKE;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid GJHHKFIKHJC;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid EDALLPIILEM;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid JDNKNAHOGLM;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid NNJPBLEBNMO;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid JIMNOCMBIFJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid IAFLJOJNMHE;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid FFLHNJCBEOC;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid PJPOFPPGBFC;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MHLOGKEIDCJ;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid BKOLHFKGPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid FAGBLLFPJPB;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid AJEAMKBMHNH;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid HCKGNMEBNAM;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid ICNBEFPEGGC;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid HLCNAKLHAFM;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid DLMBFBFNIDB;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid DOKHOKIDBIC;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid AJBIHOLKGBM;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid LBJHOKJMCIP;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid DIBJLGIHNCH;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid MJEDIAOOKEL;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid EINMLJEJPHE;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid HAIGPOGPGMO;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid PJHLEMKKLKP;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid DAPIECBPOME;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid CENIGOPEEHB;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid AEPIHCDDLDE;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid GBLPHMHFLJG;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid ANDHAKJODFL;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid GGENLCCADMO;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid CKCHEAJFHIA;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid OKOFDNKDMCI;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid PGEMBCNHKBB;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid GBKHGANGBCK;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid NOBBGMLKDAH;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid OPCJENPGCCK;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid PGLPBOGHGEN;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid OKBAIPLIHOI;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid FGELGHOCGKA;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid DFHLIOCJEAC;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid DNJKBHBOGFM;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid PAKCOCDDAEO;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid JHNJDGNEGDB;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid LGKDPMBAEKI;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid KMOHBFBEDNC;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid HGMNPDNCOOK;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid OAHEPMOPALA;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid HNAOBLBGPBJ;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid JELMOMMKEPL;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid PDIKFBFKOEJ;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid PJNOIIDLDBG;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid MPIPJDLNILN;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid PBBBOONLAGK;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid PFOMACGDMIP;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid BFMOCJJEDKI;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid MNALFLOHAHO;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid BIEEOIAAHHI;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid IMGEENBAMKN;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid EHEEGAHJAAA;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid AJPEFOOAPHF;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid DKNLIEMEDHJ;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid HFGHEOHFPHH;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid MDMMLBOFENF;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid PKAEMBFCPIJ;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid HMPPNCEOFPI;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid PLCDFEEIBFJ;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid JMAJKFKALHP;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid FPEMCIOCHFF;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid NPDIAFIDIPE;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid IEAJPPKJNKK;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid IBPDHJNEECK;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid BBAJHCJHPIK;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid INDDIOMKEDO;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid KOCEAMJKCIA;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid FJGGOKMDAKM;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid OLHLINCODGI;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid MOBJIMMKNBG;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid AAPDOAMCPCP;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid JBCNFHLLBBL;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid NCCLFLGCIIF;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid GCAGAMGOBIG;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid CHMPKLOHNFK;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid NIMBHOFMJNA;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid PHCAEFGCFNI;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid LLCFGMABLPF;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid PLILJNIJPPD;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid MEAIODKJHOC;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid NJLKHHDNAMH;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid KLCKIOKNFMD;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid FPFGEGKOACM;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid PKPKHNADLJO;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid HGKAHNJJPKB;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid PPLOGONFIIL;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid LNDFCFPAKHA;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid DNJNDFBJCGD;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid GAGKGFOPNPH;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid OECCFIALCLM;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid AHNOMDPIOGO;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid FOEAEFNBLON;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid HNDMIKNEEIJ;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid LDMGAHNDEKC;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid HJGBAPCGMLB;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid ADLJIBAKBJG;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid NHLDGAIKDFP;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid IMHHIEDAFIC;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid JOBOKIKEIOC;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid KPGNPOBEEPC;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid MKHAEKEIDHK;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid PGGMGIJNAKE;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid MMGHHJJIMGH;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid GGLPPEOHKEF;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid BHNAOLFIGNI;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid JNJGMJLBOJN;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid GEFFCIIFPMH;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid KMIMIPEKHJI;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid EEPOBCDCCNO;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, JPMEJKALDHD> JBKHCPMKGMP;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<JPMEJKALDHD, Guid> FHKMHPDEHPG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, JPMEJKALDHD> CKMNCGAFCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7557CB0", Offset = "0x75570B0", VA = "0x187557CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<JPMEJKALDHD, Guid> ONLEKDONENC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7557C60", Offset = "0x7557060", VA = "0x187557C60")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EPDCDHJHEJJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7557670", Offset = "0x7556A70", VA = "0x187557670")]
	public static bool KJNAGBJKJHH(JLOBOBCKHKN ABIMKFPNBIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75576A0", Offset = "0x7556AA0", VA = "0x1875576A0")]
	private static bool KJNAGBJKJHH(IMOGLCFALMH HGLMIIIBLAB, JLOBOBCKHKN ABIMKFPNBIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JFGOCOJKODK
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(PLFBPNFCLJI MJFOKKFMONL, [Out] Dictionary<int, int> GOMIBKOHCKP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(AHDANNFMFFK GINLNLAGECB, MNLHGPBGAHJ IDAKNGPIKKD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct AEOBFCCEAGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly HCCJEMAFJIA LAIMEKEPKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<FMDAPGFGAFB> IOOKOIBMNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<FMDAPGFGAFB> NCEEACLIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly DDIPAIMAGGM<HFJKEPEKFIF> DGFKJLBNJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<IIIMCLEJECC<MJBBEHHNFNA>> ONFLPPANNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly PPACMFCOMCD AKCDBFBIIDF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BDOPIOMHKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7553A90", Offset = "0x7552E90", VA = "0x187553A90")]
	public AEOBFCCEAGP(HCCJEMAFJIA FINOBGDPFGI, IEnumerable<FMDAPGFGAFB> GIODPLCOFGH, IReadOnlyList<FMDAPGFGAFB> OPPMNPNABNP, DDIPAIMAGGM<HFJKEPEKFIF> PANNLOGHBIH, IReadOnlyList<IIIMCLEJECC<MJBBEHHNFNA>> BAAHBIOILME, PPACMFCOMCD OMJNDKMFMJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BAMFNLLDOFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly HCCJEMAFJIA LAIMEKEPKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly IReadOnlyList<FMDAPGFGAFB> CKELMBGGMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly DDIPAIMAGGM<HFJKEPEKFIF> DGFKJLBNJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public readonly IReadOnlyList<IIIMCLEJECC<MJBBEHHNFNA>> ONFLPPANNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public readonly ByteString FPCDDAJGIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public readonly PPACMFCOMCD AKCDBFBIIDF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7553B00", Offset = "0x7552F00", VA = "0x187553B00")]
	public BAMFNLLDOFG(HCCJEMAFJIA FINOBGDPFGI, DDIPAIMAGGM<HFJKEPEKFIF> PANNLOGHBIH, IReadOnlyList<IIIMCLEJECC<MJBBEHHNFNA>> BAAHBIOILME, ByteString JHNHJDPLMLL, IReadOnlyList<FMDAPGFGAFB> BCNDJBHLMNN, PPACMFCOMCD OMJNDKMFMJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CFEBICAMPCN : NPEAGLBBNHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public readonly Guid NHDEBGFNJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly Dictionary<Guid, Guid> MHJIECJLKAG;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45A9580", Offset = "0x45A8980", VA = "0x1845A9580")]
	private CFEBICAMPCN(Guid BNOBLCJLAGL, Dictionary<Guid, Guid> MHJIECJLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75575E0", Offset = "0x75569E0", VA = "0x1875575E0")]
	public static CFEBICAMPCN KMDIICJFNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x75571C0", Offset = "0x75565C0", VA = "0x1875571C0")]
	private static Dictionary<Guid, Guid> HGCNLMOJBOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75571B0", Offset = "0x75565B0", VA = "0x1875571B0")]
	public static CFEBICAMPCN GNMPOPOBKIP(IReadOnlyDictionary<Guid, Guid> BLMGNEDEHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75572F0", Offset = "0x75566F0", VA = "0x1875572F0")]
	public static CFEBICAMPCN KEKCIAJBNMO(IEnumerable<KeyValuePair<Guid, Guid>> BLMGNEDEHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7556CC0", Offset = "0x75560C0", VA = "0x187556CC0")]
	public Dictionary<Guid, Guid> BANFDIGCEAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
	public Dictionary<Guid, Guid> LBOAMEFNNLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7557270", Offset = "0x7556670", VA = "0x187557270")]
	public void KAAHFJDOOLK(Guid BLMGNEDEHDK, Guid EBNFGKDLPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7556D40", Offset = "0x7556140", VA = "0x187556D40")]
	public void BICCACLDLJD(IReadOnlyDictionary<Guid, Guid> BJAGKGAOGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7557060", Offset = "0x7556460", VA = "0x187557060")]
	public Guid GJOEIAEBNIG([In] Guid BLMGNEDEHDK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7556FC0", Offset = "0x75563C0", VA = "0x187556FC0")]
	public Guid GADDGNFBNNN([In] Guid BLMGNEDEHDK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7556C50", Offset = "0x7556050", VA = "0x187556C50")]
	public bool APFBNDDIAMB([In] Guid BLMGNEDEHDK, [Out] Guid EBNFGKDLPAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7556C50", Offset = "0x7556050", VA = "0x187556C50", Slot = "4")]
	private bool GEHFLPKEAMF([In] Guid BLMGNEDEHDK, [Out] Guid EBNFGKDLPAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ELFKBKHNFCF
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
public sealed class KBBNCACMBNL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BCPPMILOCLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public HCCJEMAFJIA staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public BCPPMILOCLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7556340", Offset = "0x7555740", VA = "0x187556340")]
		internal DDIPAIMAGGM<KBGLEEGJHEA> CMFOMHFFKKC((DDIPAIMAGGM<HFJKEPEKFIF> GraphId, DDIPAIMAGGM<MJBBEHHNFNA> NodeId) i)
		{
			return default(DDIPAIMAGGM<KBGLEEGJHEA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private static readonly IHDDGPKENBI<KBGLEEGJHEA, int?> ODHGOEHEIOA;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private static readonly long GBFKPKOADNP;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x755CD20", Offset = "0x755C120", VA = "0x18755CD20")]
	public static (long, long) MIDJOOPILOI(HCCJEMAFJIA FKHJJLLLBCP, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x755CAE0", Offset = "0x755BEE0", VA = "0x18755CAE0")]
	public static long GIBLOOMAAEA([In] ReadOnlySpan<DDIPAIMAGGM<KBGLEEGJHEA>> DLMPGAJAAHG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x755CC00", Offset = "0x755C000", VA = "0x18755CC00")]
	private static long LMPHBECNFKK()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FBBGODAIADL
{
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly HashSet<JPMEJKALDHD> BAFCNDEBBHC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HHAMGMAGMKC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LFCHOCPMDFO : IEnumerable<FMDAPGFGAFB>, IEnumerable, IEnumerator<FMDAPGFGAFB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private FMDAPGFGAFB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private HHAGLKEHIOP spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public HHAGLKEHIOP <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private CNGIHLGGBEB spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public CNGIHLGGBEB <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FMDAPGFGAFB System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public LFCHOCPMDFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x756A180", Offset = "0x7569580", VA = "0x18756A180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x756A400", Offset = "0x7569800", VA = "0x18756A400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x756A290", Offset = "0x7569690", VA = "0x18756A290", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FMDAPGFGAFB> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x756A290", Offset = "0x7569690", VA = "0x18756A290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x755AA10", Offset = "0x7559E10", VA = "0x18755AA10")]
	public static HHAGLKEHIOP IKBMGNBCCPG([In] BAMFNLLDOFG EPMFILKDLCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x755AB80", Offset = "0x7559F80", VA = "0x18755AB80")]
	public static HHAGLKEHIOP IKBMGNBCCPG([In] AEOBFCCEAGP EPMFILKDLCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75597F0", Offset = "0x7558BF0", VA = "0x1875597F0")]
	private static HashSet<IIIMCLEJECC<LICLOCDPKIK>> BKOMGAPDCHP(IReadOnlyList<FMDAPGFGAFB> BLJMJAOHHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7559C00", Offset = "0x7559000", VA = "0x187559C00")]
	private static void CCFMMAAIOIN(HHAGLKEHIOP MHDMHDEIKLO, [In] AEOBFCCEAGP KGFGMCKACDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7557D90", Offset = "0x7557190", VA = "0x187557D90")]
	public static PHLGGJNOBDN<CFEBICAMPCN, MOLCAAEELEA> AMBBCLFMEHM(HHAGLKEHIOP MHDMHDEIKLO, CNGIHLGGBEB GKPIAEKHDBK, CFEBICAMPCN? LOHEFFPNMAB, bool FGOFEOIGLPJ)
	{
		return default(PHLGGJNOBDN<CFEBICAMPCN, MOLCAAEELEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x755A900", Offset = "0x7559D00", VA = "0x18755A900")]
	[IteratorStateMachine(typeof(LFCHOCPMDFO))]
	private static IEnumerable<FMDAPGFGAFB> FONCIHHEKDA(HHAGLKEHIOP MHDMHDEIKLO, CNGIHLGGBEB GKPIAEKHDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7559B90", Offset = "0x7558F90", VA = "0x187559B90")]
	private static void CABJHIOOKJH(HHAGLKEHIOP MHDMHDEIKLO, CNGIHLGGBEB GKPIAEKHDBK, IReadOnlyCollection<ByteString>? KEECNKNKHHF, IReadOnlyCollection<ByteString>? FBKPPNDFDJF, IReadOnlyCollection<ByteString>? JLKINCAGEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x755A260", Offset = "0x7559660", VA = "0x18755A260")]
	private static bool DOPHHNMONDK(HHAGLKEHIOP MHDMHDEIKLO, AHDANNFMFFK GINLNLAGECB, CNGIHLGGBEB GKPIAEKHDBK, [Out][NotNullWhen(false)] string? JPAKKPAOGDF, [Out] Dictionary<int, int> GOMIBKOHCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x755B040", Offset = "0x755A440", VA = "0x18755B040")]
	private static Dictionary<Guid, IMOGLCFALMH> KLHCBIGKNND(HHAGLKEHIOP MHDMHDEIKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7557D00", Offset = "0x7557100", VA = "0x187557D00")]
	private static void AJKPNDHLBAP(bool JADLKGJEPGC, FMDAPGFGAFB MCHMPDGPNBP, CFEBICAMPCN HJJIJLJLOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x755AD00", Offset = "0x755A100", VA = "0x18755AD00")]
	private static void IPIKMECKGBJ(FMDAPGFGAFB MCHMPDGPNBP, Guid MMHINFKMJNK, CAPOKCGJHCA? KNMFMDEFDLB, Dictionary<Guid, IMOGLCFALMH> GGIDCLLENLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7559340", Offset = "0x7558740", VA = "0x187559340")]
	private static void BJGJJBGHNAJ(IEnumerable<FMDAPGFGAFB> ELEIHKHOHDD, IReadOnlyCollection<ByteString> KEECNKNKHHF, IReadOnlyCollection<ByteString> FBKPPNDFDJF, IReadOnlyCollection<ByteString> JLKINCAGEOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CNGIHLGGBEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public bool JADLKGJEPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public PPACMFCOMCD OMJNDKMFMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public CAPOKCGJHCA? KNMFMDEFDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public CAPOKCGJHCA? KDOLJCEPCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public HCCJEMAFJIA IMMLCFGBENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public ELFKBKHNFCF OBPCCCFNHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public JFGOCOJKODK OGMNHOGIJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public IIIMCLEJECC<HFJKEPEKFIF> IMEAKONDCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public DMEFLICKLLD CIIGMJECOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public List<FMDAPGFGAFB> DLALMDBBJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public ANCOAIADDGI BOBDOPODEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public IAIFDNLKLDE PMKABAFMHKP;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CAPOKCGJHCA
{
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private const float LEAFHDLFPAF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Vector3 HJBDDDIFEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public Quaternion NBFJKGINHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public float JKHHCOODJNJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 PFHIKOBGMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7556420", Offset = "0x7555820", VA = "0x187556420")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS EKPFMOGAAIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75569D0", Offset = "0x7555DD0", VA = "0x1875569D0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x120A8A0", Offset = "0x1209CA0", VA = "0x18120A8A0")]
	public CAPOKCGJHCA(Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC, float JKHHCOODJNJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7556B80", Offset = "0x7555F80", VA = "0x187556B80")]
	public CAPOKCGJHCA(UniformTRS IEAAMKLNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7556750", Offset = "0x7555B50", VA = "0x187556750")]
	public static CAPOKCGJHCA JKKAOPCCCBG(CAPOKCGJHCA HKNGNFLDPKM, CAPOKCGJHCA CEDDOLFEMHM)
	{
		return default(CAPOKCGJHCA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7556730", Offset = "0x7555B30", VA = "0x187556730")]
	public static CAPOKCGJHCA JKGHIELMIOO((Vector3, Quaternion, float) MJFOKKFMONL)
	{
		return default(CAPOKCGJHCA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x75565B0", Offset = "0x75559B0", VA = "0x1875565B0")]
	public static CAPOKCGJHCA JKGHIELMIOO(Matrix4x4 ADFJAAONGPN)
	{
		return default(CAPOKCGJHCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7556AF0", Offset = "0x7555EF0", VA = "0x187556AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7556A10", Offset = "0x7555E10", VA = "0x187556A10")]
	public CAPOKCGJHCA OLCIDKGLPNH(Matrix4x4 NCNOHDPHPJB)
	{
		return default(CAPOKCGJHCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75563B0", Offset = "0x75557B0", VA = "0x1875563B0")]
	public static CAPOKCGJHCA CELJIHNDPDN(Vector3 HJBDDDIFEBJ)
	{
		return default(CAPOKCGJHCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7556520", Offset = "0x7555920", VA = "0x187556520")]
	public readonly IJJACHJMKKP IHDKDJKHBOB()
	{
		return default(IJJACHJMKKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum GNGIAIANLFP
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct MOLCAAEELEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly KHLJAEEJCKG NMKEFHILICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private readonly MOCCGNOLGDK OMGNOGIKNHO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1495760", Offset = "0x1494B60", VA = "0x181495760")]
	private MOLCAAEELEA(KHLJAEEJCKG CALDBNGCNDJ, MOCCGNOLGDK FEDBLPEPBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x756A700", Offset = "0x7569B00", VA = "0x18756A700")]
	public ADKFHONBPGC MONNBCBMOGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x756A590", Offset = "0x7569990", VA = "0x18756A590")]
	public static PHLGGJNOBDN<CFEBICAMPCN, MOLCAAEELEA> KMDIICJFNJF(NJENMEKJKID<AOFFOIKPJDJ> FEDBLPEPBIG)
	{
		return default(PHLGGJNOBDN<CFEBICAMPCN, MOLCAAEELEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x756A4E0", Offset = "0x75698E0", VA = "0x18756A4E0")]
	public static PHLGGJNOBDN<CFEBICAMPCN, MOLCAAEELEA> KMDIICJFNJF(ADKFHONBPGC FEDBLPEPBIG)
	{
		return default(PHLGGJNOBDN<CFEBICAMPCN, MOLCAAEELEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x756A640", Offset = "0x7569A40", VA = "0x18756A640")]
	public static PHLGGJNOBDN<CFEBICAMPCN, MOLCAAEELEA> KMDIICJFNJF(string HNPADNLOJFC)
	{
		return default(PHLGGJNOBDN<CFEBICAMPCN, MOLCAAEELEA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum KHLJAEEJCKG
{
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BBCEADPAILA : IDisposable, DGNOLDGACPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private NativeList<PDDAJOGDNBJ> GJKIEADAMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private float MPHAKFLIELN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OAHBOFCALAL MFCAPBKGFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0")]
		[CompilerGenerated]
		get
		{
			return default(OAHBOFCALAL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DNDBCKGILMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6553FF0", Offset = "0x65533F0", VA = "0x186553FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool AOFBLEDDDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6554000", Offset = "0x6553400", VA = "0x186554000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<LAIKGMFKIFA> FJJFIFPGIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AJLPJLAMMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7554A30", Offset = "0x7553E30", VA = "0x187554A30", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float GOAINGPDKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7553B70", Offset = "0x7552F70", VA = "0x187553B70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x75562B0", Offset = "0x75556B0", VA = "0x1875562B0")]
	public BBCEADPAILA(OAHBOFCALAL NHJKDMPGJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75543B0", Offset = "0x75537B0", VA = "0x1875543B0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7554560", Offset = "0x7553960", VA = "0x187554560")]
	public Vector3 EDJGDKHJMBI(int HHHJLAPJJLA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x75557C0", Offset = "0x7554BC0", VA = "0x1875557C0", Slot = "6")]
	public Quaternion KJIBFGPOEJM(int HHHJLAPJJLA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7555720", Offset = "0x7554B20", VA = "0x187555720", Slot = "5")]
	public Vector3 IPFNAAMBIGH(int HHHJLAPJJLA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7554350", Offset = "0x7553750", VA = "0x187554350", Slot = "7")]
	public float DJFGKJDHDMD(int HHHJLAPJJLA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7554A70", Offset = "0x7553E70", VA = "0x187554A70")]
	public void FCBGDPFPDPI(Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC, float EJOLINDBPPE, bool KAGHLGPIKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75542F0", Offset = "0x75536F0", VA = "0x1875542F0")]
	private bool DBKAHAGJIAO(int MHOOGEECGNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7555550", Offset = "0x7554950", VA = "0x187555550")]
	public void HJBFJIFHGIM(Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC, float EJOLINDBPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x75554C0", Offset = "0x75548C0", VA = "0x1875554C0")]
	public void GCNNCOLOGBM(int MHOOGEECGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7554410", Offset = "0x7553810", VA = "0x187554410")]
	public void EDAOFIOILMB(int MHOOGEECGNC, Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC, float EJOLINDBPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7554140", Offset = "0x7553540", VA = "0x187554140")]
	public void CJKNLIDMEFI(int MHOOGEECGNC, float3 HJBDDDIFEBJ, quaternion NBFJKGINHEC, float EJOLINDBPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7556160", Offset = "0x7555560", VA = "0x187556160")]
	public void PBDPMOAOHDC(int MHOOGEECGNC, Vector3 HJBDDDIFEBJ, float EJOLINDBPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7555360", Offset = "0x7554760", VA = "0x187555360")]
	public void FEADLDOMBLL(int MHOOGEECGNC, Vector3 BLIFKOEAPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7555960", Offset = "0x7554D60", VA = "0x187555960")]
	public static Quaternion MJEEPEPPIAP(Quaternion LAOJEKJKNBH, int MHOOGEECGNC, float EJCDGHPGEOA, DGNOLDGACPB BEAPNCHBCFJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7553CB0", Offset = "0x75530B0", VA = "0x187553CB0")]
	public Bounds BEODDHKPCJL(Transform NCNOHDPHPJB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x75556B0", Offset = "0x7554AB0", VA = "0x1875556B0", Slot = "10")]
	public virtual void HMDAGLKFFJE(bool GGOEAKLFKJF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7555890", Offset = "0x7554C90", VA = "0x187555890")]
	public NativeList<PDDAJOGDNBJ> LKPGDIFCCGH(float KMJIIPIPNEE = 1f)
	{
		return default(NativeList<PDDAJOGDNBJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LAIKGMFKIFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public float3 LLLAMAJMODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public float AAEBALPFOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public quaternion PFIJIKNKGMG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75725C0", Offset = "0x75719C0", VA = "0x1875725C0")]
	public LAIKGMFKIFA(Vector3 PCEPJNOLMFA, Quaternion LAOJEKJKNBH, float EJOLINDBPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7572360", Offset = "0x7571760", VA = "0x187572360")]
	public Quaternion MNBFEKHMBGH(Vector3 HEBBPJGOPIH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7572070", Offset = "0x7571470", VA = "0x187572070")]
	public LAIKGMFKIFA EPNAOEOIBKL(Vector3 OGGHENKLCFH, Vector3 JCJKJFHLHLN, Vector3 FLJAEGMNPDC)
	{
		return default(LAIKGMFKIFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7572420", Offset = "0x7571820", VA = "0x187572420")]
	public NANKLLFFLAD PNAGGPFPAGD(Vector3 HEBBPJGOPIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class FDEDMFJEKCL : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x756C6D0", Offset = "0x756BAD0", VA = "0x18756C6D0", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x756C0F0", Offset = "0x756B4F0", VA = "0x18756C0F0")]
	private void AFGLIBGPEHD(Dictionary<Guid, Guid> HPIDCDHOAII, JNBFKDKHJFE FDHMCOPCMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x756C090", Offset = "0x756B490", VA = "0x18756C090")]
	private void AFGLIBGPEHD(Dictionary<Guid, Guid> HPIDCDHOAII, FAIAAJGAIJE AAKEFAPOGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x756BE10", Offset = "0x756B210", VA = "0x18756BE10")]
	private void AFGLIBGPEHD(Dictionary<Guid, Guid> HPIDCDHOAII, PLAJKLFPBJN LMEAGEAHAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public FDEDMFJEKCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class HHOBKKCKCII : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x756D110", Offset = "0x756C510", VA = "0x18756D110", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public HHOBKKCKCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class OFKJNMHDIMP : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7572920", Offset = "0x7571D20", VA = "0x187572920", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public OFKJNMHDIMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class JBMLKBGFELI : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x756DDC0", Offset = "0x756D1C0", VA = "0x18756DDC0", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public JBMLKBGFELI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class KNNFAKCPFKG : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7571E50", Offset = "0x7571250", VA = "0x187571E50", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public KNNFAKCPFKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class DDJJOGNGDGC : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x756AA30", Offset = "0x7569E30", VA = "0x18756AA30", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public DDJJOGNGDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class HHLAEKAOOHO : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x756CF80", Offset = "0x756C380", VA = "0x18756CF80", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public HHLAEKAOOHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DHAEMCKNKIL : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x756AB70", Offset = "0x7569F70", VA = "0x18756AB70", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public DHAEMCKNKIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LKCLOLEAKCJ : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7572640", Offset = "0x7571A40", VA = "0x187572640", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public LKCLOLEAKCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FODHHAPGFNO : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x756C750", Offset = "0x756BB50", VA = "0x18756C750", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public FODHHAPGFNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class HOBMACEJEGM : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x756D1C0", Offset = "0x756C5C0", VA = "0x18756D1C0", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public HOBMACEJEGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class NFILHBGOBEI : CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public static readonly MNKHMBNFPBA NMOFHKPABPB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x75727F0", Offset = "0x7571BF0", VA = "0x1875727F0", Slot = "4")]
	public void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public NFILHBGOBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JLOBOBCKHKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public AHDANNFMFFK IFKCKGNMHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public EECKBFDOJLE ENKMNFGJCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<int, int> KPOLFCCMBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public Dictionary<Guid, Guid> PHOCIFLCEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public IAIFDNLKLDE PMKABAFMHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public bool FGOFEOIGLPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface CNBAPCGLHAE
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCPKGBLCJHB(GALLOIOCDBP NCECBIMKMBO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KNKPNHLBBFF
{
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private static readonly CNBAPCGLHAE[] LOECOKOPGBK;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7570D30", Offset = "0x7570130", VA = "0x187570D30")]
	public static void BPGCFKNOKKG(FMDAPGFGAFB MJFOKKFMONL, CFEBICAMPCN IEGHOFIJKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7570FB0", Offset = "0x75703B0", VA = "0x187570FB0")]
	public static void HELCMHJAPNP(FMDAPGFGAFB? MJFOKKFMONL, CFEBICAMPCN AFFMJHLGPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7571240", Offset = "0x7570640", VA = "0x187571240")]
	public static void JECMJFPACFK(FMDAPGFGAFB? MJFOKKFMONL, CFEBICAMPCN HJJIJLJLOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x75714B0", Offset = "0x75708B0", VA = "0x1875714B0")]
	public static void KJNAGBJKJHH(GALLOIOCDBP NCECBIMKMBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GALLOIOCDBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public AHDANNFMFFK FLAMAFLPMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public FMDAPGFGAFB MCHMPDGPNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Dictionary<int, int> KPOLFCCMBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public Dictionary<Guid, Guid> PHOCIFLCEGH;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x756C900", Offset = "0x756BD00", VA = "0x18756C900")]
	public Guid DDDOCDALEJK(Guid BCIHOIBCNMJ)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IAIFDNLKLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int LPAMGICLDID, [Out] Guid PLADANIKKIP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class JMJEIPGADIE
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private static readonly ProfilerMarker PHIAIJLIEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private readonly HashSet<string> BDPDKBFKMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly Dictionary<long, int> LNPCPLADAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly HashSet<Guid> KMNDLELENPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<Guid> IBOHDLALFHF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> CFOPPKCOOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> BLHIGCGJLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> CFMAMHBBKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x756E5D0", Offset = "0x756D9D0", VA = "0x18756E5D0")]
	public static void AIHEMFDMODB(HHAGLKEHIOP FPBFDGJHLKO, GBPEBBDEAAB NJGNPEOHJEH, CFEBICAMPCN BPOLGBHOGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x756F930", Offset = "0x756ED30", VA = "0x18756F930")]
	public static JMJEIPGADIE IMOPHECKHCB(OIBKBLGJIPN EDHFGAMFCNC, [Optional] GBPEBBDEAAB? NJGNPEOHJEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x756F840", Offset = "0x756EC40", VA = "0x18756F840")]
	public static JMJEIPGADIE IDNNCPJNFGO(HHAGLKEHIOP HDICFKMPOFN, [Optional] GBPEBBDEAAB? NJGNPEOHJEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7570740", Offset = "0x756FB40", VA = "0x187570740")]
	public static JMJEIPGADIE KOAODCJIICG(IEnumerable<string> BDPDKBFKMPO, IDictionary<long, int> FIHDELJMJOK, IReadOnlyCollection<Guid> IBOHDLALFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7570A00", Offset = "0x756FE00", VA = "0x187570A00")]
	private JMJEIPGADIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7570B60", Offset = "0x756FF60", VA = "0x187570B60")]
	private JMJEIPGADIE(IEnumerable<string> BDPDKBFKMPO, IDictionary<long, int> FIHDELJMJOK, IReadOnlyCollection<Guid> IBOHDLALFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x756FDE0", Offset = "0x756F1E0", VA = "0x18756FDE0")]
	private void JNENENEBMMC(OIBKBLGJIPN EDHFGAMFCNC, GBPEBBDEAAB? NJGNPEOHJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x756F9B0", Offset = "0x756EDB0", VA = "0x18756F9B0")]
	private void JNENENEBMMC(HHAGLKEHIOP HDICFKMPOFN, GBPEBBDEAAB? NJGNPEOHJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x756F360", Offset = "0x756E760", VA = "0x18756F360")]
	private void HHDICLOMIHH(ByteString? JHNHJDPLMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7570400", Offset = "0x756F800", VA = "0x187570400")]
	private void JNENENEBMMC(JGPBJIMDDKJ? HAIKBOLEOOP, GBPEBBDEAAB? NJGNPEOHJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x756EC80", Offset = "0x756E080", VA = "0x18756EC80")]
	private static void AIHEMFDMODB(JGPBJIMDDKJ? HAIKBOLEOOP, GBPEBBDEAAB NJGNPEOHJEH, CFEBICAMPCN BPOLGBHOGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x756DF20", Offset = "0x756D320", VA = "0x18756DF20")]
	private static void AIHEMFDMODB(OMBGDEFIBAC? IKAPMMHHNFM, GBPEBBDEAAB NJGNPEOHJEH, CFEBICAMPCN BPOLGBHOGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x756FBD0", Offset = "0x756EFD0", VA = "0x18756FBD0")]
	private void JNENENEBMMC(OMBGDEFIBAC? IKAPMMHHNFM, GBPEBBDEAAB? NJGNPEOHJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x756F000", Offset = "0x756E400", VA = "0x18756F000")]
	private void FKEDDADLGHA(Guid? BCIHOIBCNMJ, GBPEBBDEAAB? NJGNPEOHJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7570000", Offset = "0x756F400", VA = "0x187570000")]
	private void JNENENEBMMC(FMDAPGFGAFB? MCHMPDGPNBP, GBPEBBDEAAB? NJGNPEOHJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x756E190", Offset = "0x756D590", VA = "0x18756E190")]
	private static void AIHEMFDMODB(FMDAPGFGAFB? MCHMPDGPNBP, GBPEBBDEAAB NJGNPEOHJEH, CFEBICAMPCN BPOLGBHOGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x756F8C0", Offset = "0x756ECC0", VA = "0x18756F8C0")]
	private void IEGAPIBMKAE(string? ABCAFIJPLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x756F290", Offset = "0x756E690", VA = "0x18756F290")]
	private void HFBOGCHGOBK(long JIDKJGAJEMB, Guid COOOMIOCPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x756F240", Offset = "0x756E640", VA = "0x18756F240")]
	private void HFBOGCHGOBK(PNGGKDKEGFI? OGDICAMMJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x756F1E0", Offset = "0x756E5E0", VA = "0x18756F1E0")]
	private void HFBOGCHGOBK(JNJNHFBGPBC? OGDICAMMJHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct DNCLPFGGBHH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class GMJLFMIMEIA : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private readonly IEnumerator<DictionaryEntry> MDEDOOHPCNK;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry POGCNPFLBPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x756CD60", Offset = "0x756C160", VA = "0x18756CD60", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x756CE20", Offset = "0x756C220", VA = "0x18756CE20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object KAMPPLLIEDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x756CED0", Offset = "0x756C2D0", VA = "0x18756CED0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x756CC80", Offset = "0x756C080", VA = "0x18756CC80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
		public GMJLFMIMEIA(IEnumerator<DictionaryEntry> MDEDOOHPCNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x756CBE0", Offset = "0x756BFE0", VA = "0x18756CBE0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x756CC30", Offset = "0x756C030", VA = "0x18756CC30", Slot = "9")]
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
		private sealed class AMEBKOPFLHB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0xAFAF40", Offset = "0xAFA340", VA = "0x180AFAF40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x756A9E0", Offset = "0x7569DE0", VA = "0x18756A9E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public AMEBKOPFLHB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x756A890", Offset = "0x7569C90", VA = "0x18756A890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x756A990", Offset = "0x7569D90", VA = "0x18756A990", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7573050", Offset = "0x7572450", VA = "0x187573050", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object MCNLCGLNHHO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7572F60", Offset = "0x7572360", VA = "0x187572F60", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7573130", Offset = "0x7572530", VA = "0x187573130", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7572EA0", Offset = "0x75722A0", VA = "0x187572EA0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7572F00", Offset = "0x7572300", VA = "0x187572F00", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x75730D0", Offset = "0x75724D0", VA = "0x1875730D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7572B60", Offset = "0x7571F60", VA = "0x187572B60", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7572BC0", Offset = "0x7571FC0", VA = "0x187572BC0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7572C20", Offset = "0x7572020", VA = "0x187572C20", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
		public RoomObjectCounts(Dictionary<int, int> AJNCOCIEJEJ, [Optional] Dictionary<int, int> CPEOJPPDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7572A80", Offset = "0x7571E80", VA = "0x187572A80")]
		[IteratorStateMachine(typeof(AMEBKOPFLHB))]
		private IEnumerator<DictionaryEntry> FCJEOGDMNMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7573180", Offset = "0x7572580", VA = "0x187573180", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7572DA0", Offset = "0x75721A0", VA = "0x187572DA0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7572C80", Offset = "0x7572080", VA = "0x187572C80", Slot = "9")]
		void IDictionary.Add(object MCNLCGLNHHO, object PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7572CE0", Offset = "0x75720E0", VA = "0x187572CE0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7572D40", Offset = "0x7572140", VA = "0x187572D40", Slot = "8")]
		bool IDictionary.Contains(object MCNLCGLNHHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7572E40", Offset = "0x7572240", VA = "0x187572E40", Slot = "14")]
		void IDictionary.Remove(object MCNLCGLNHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7572B00", Offset = "0x7571F00", VA = "0x187572B00", Slot = "15")]
		void ICollection.CopyTo(Array PHAPILEGACC, int FFCBHHABFJN)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class IHNGNIJJNKB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xAFAF40", Offset = "0xAFA340", VA = "0x180AFAF40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x756D450", Offset = "0x756C850", VA = "0x18756D450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public IHNGNIJJNKB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x756D2C0", Offset = "0x756C6C0", VA = "0x18756D2C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x756D400", Offset = "0x756C800", VA = "0x18756D400", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x756DAE0", Offset = "0x756CEE0", VA = "0x18756DAE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object MCNLCGLNHHO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x756D9B0", Offset = "0x756CDB0", VA = "0x18756D9B0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x756DB90", Offset = "0x756CF90", VA = "0x18756DB90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x756D8F0", Offset = "0x756CCF0", VA = "0x18756D8F0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x756D950", Offset = "0x756CD50", VA = "0x18756D950", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x756DB30", Offset = "0x756CF30", VA = "0x18756DB30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x756D570", Offset = "0x756C970", VA = "0x18756D570", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x756D5D0", Offset = "0x756C9D0", VA = "0x18756D5D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x756D630", Offset = "0x756CA30", VA = "0x18756D630", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x25AA4F0", Offset = "0x25A98F0", VA = "0x1825AA4F0")]
		public Invention(long NNKBGKICBEC, int LOHPPDCIAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x756D4A0", Offset = "0x756C8A0", VA = "0x18756D4A0")]
		[IteratorStateMachine(typeof(IHNGNIJJNKB))]
		private IEnumerator<DictionaryEntry> FCJEOGDMNMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x756DBE0", Offset = "0x756CFE0", VA = "0x18756DBE0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x756D7B0", Offset = "0x756CBB0", VA = "0x18756D7B0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x756D690", Offset = "0x756CA90", VA = "0x18756D690", Slot = "9")]
		void IDictionary.Add(object MCNLCGLNHHO, object PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x756D6F0", Offset = "0x756CAF0", VA = "0x18756D6F0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x756D750", Offset = "0x756CB50", VA = "0x18756D750", Slot = "8")]
		bool IDictionary.Contains(object MCNLCGLNHHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x756D890", Offset = "0x756CC90", VA = "0x18756D890", Slot = "14")]
		void IDictionary.Remove(object MCNLCGLNHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x756D510", Offset = "0x756C910", VA = "0x18756D510", Slot = "15")]
		void ICollection.CopyTo(Array PHAPILEGACC, int FFCBHHABFJN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> DJPHGLKAEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	public readonly IReadOnlyList<Invention> GLOIMIAEPOD;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
	public DNCLPFGGBHH(IReadOnlyDictionary<Guid, RoomObjectCounts> BNFEILJKDDM, IReadOnlyList<Invention> DBFGFCPJHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x756AC60", Offset = "0x756A060", VA = "0x18756AC60")]
	public static DNCLPFGGBHH IMOPHECKHCB(OIBKBLGJIPN EDHFGAMFCNC)
	{
		return default(DNCLPFGGBHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x756BCF0", Offset = "0x756B0F0", VA = "0x18756BCF0")]
	[CompilerGenerated]
	internal static int PNMEFOGBANB([In] IReadOnlyDictionary<long, int> NCPHBKFMCLC, long? JIDKJGAJEMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x756B640", Offset = "0x756AA40", VA = "0x18756B640")]
	[CompilerGenerated]
	internal static void PLAGEPOFPPO(int AJALIPJKIOG, [In] JGPBJIMDDKJ EBLHCLNKIEE, [In] Dictionary<long, int> NCPHBKFMCLC, [In] Dictionary<Guid, RoomObjectCounts> BNFEILJKDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class GBPEBBDEAAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private readonly CFEBICAMPCN EAPACMCLJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private readonly Dictionary<Guid, IReadOnlyList<Guid>> IEKOCCLHFBE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public CFEBICAMPCN GEGHNDAGFED
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x756CA90", Offset = "0x756BE90", VA = "0x18756CA90")]
	public void KAAHFJDOOLK(Guid GPIJIONNIFO, Guid AIPGCHGEKKI, IReadOnlyList<Guid> DIPKJBMMDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x756C9A0", Offset = "0x756BDA0", VA = "0x18756C9A0")]
	public bool FGHJHIFGOLD(Guid AAHGCAPIJIN, [Out] IReadOnlyList<Guid> IBOHDLALFHF, [Out] bool BHCKEFFGBHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x756CB40", Offset = "0x756BF40", VA = "0x18756CB40")]
	public GBPEBBDEAAB()
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
