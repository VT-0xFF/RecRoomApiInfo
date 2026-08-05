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
using Unity.Collections;
using Unity.Mathematics;
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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69629E0", Offset = "0x69615E0", VA = "0x1869629E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GIMGJGBFGJL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> JCIAGLPDHEI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> HOCLBLIKIKD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> GMJGMNJJMIC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string HHACBNPIOKB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string LHINIGMEJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string GMFAHFAJNHK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x695A540", Offset = "0x6959140", VA = "0x18695A540")]
	public static bool EPJEBEODMFC(Guid DHKLOFFMOMC, int KIHHDPIALHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x695A4B0", Offset = "0x69590B0", VA = "0x18695A4B0")]
	public static bool BJNHEADCGMJ(Guid DHKLOFFMOMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x695A640", Offset = "0x6959240", VA = "0x18695A640")]
	public static string NFNGLNCGDPD(Guid GBCIBJHFOHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HMOPPNGEEFK]
public enum HBGGICKEEBH
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COSTUME_DUMMY_OM,
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
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FKLPMLPABJD
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid DJGBLDBIJJP;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid DHLIELEJJNK;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid IOCMACPANDH;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid HPIIOGJFAFE;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid DGFBLFHGBOK;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid CKNCJOPBFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid LHPJNLDKNPE;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid NABACDGHEDG;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid FGKEKLIHIPM;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid NGJOAMHLGAM;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid PDGFBHLDDEC;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid BHDLALKGJEG;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid MIPGABBCJGN;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid JEOCGCBBIEN;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid MPNJJGKDJMM;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid KMHNDMOOJHD;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid NACHHEAMBMB;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid MOCDAFBIJNP;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid AHHKPLMHDNI;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid AEEHLHKBNCI;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid ICHDCLGBDFG;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid HBJJFPDFODG;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid KKNFCGBJJFM;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid NJIJHLKHJBC;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid IKKMHKPNKOK;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid LEIFKNIOMHJ;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid LKBNCFDCAOK;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid DGACMFJJJBF;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid LFEAMMOIGCC;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid GDPELGGBCPH;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid IDNLICAFMLK;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid BMGHCCCPFJM;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid DOAEGBFFKCO;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid OHMKFDNNLJC;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid LLHPHJCPACK;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid LKNINIJFJDD;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid HJIBLPGKCMI;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid EONHKDAPHPG;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid HHCAIICFENM;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid IEFAIALBPAJ;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid MBHFJMKNOJP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid IPNJFFGPKAP;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid FACMIJDHDJO;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid KKNECGKJKHB;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid PIJNKOCJAIL;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid CBMPDAAOPKM;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid NLNFFCNADCM;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid OBPEHMGGLEL;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid HHONIFEIFJJ;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid FFCMKPPDFOG;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid HHILGFHCHOB;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid KGCOPJKIOBM;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid OLPHCHPADOF;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid PFJLGHGEAMN;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid NDOLBHOODMK;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid ODHOMJCJODI;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid DADNMCEBIFM;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid OLHMFCMOBKP;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid JHIAHGJEJIP;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid PCMEDLOFOKG;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid OHMELCGHDII;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid OKEKLGDBMGC;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid CPJFHEIOAGH;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid JPNIOGKJFFD;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid LONOCOGFJIM;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid HAJDLDGFEHL;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid DFIAOFANLOF;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid KJBOJNFEAJG;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid GJIECGNKAEF;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid DENKEALHMHC;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid DHCMKALMADO;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid CENJOKBHIDF;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid KHGKLDLKJPH;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid IKIFIOPCNDH;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid AEOLHNNFKOE;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid CNBGKOEBAPJ;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid AADAMFJCCOA;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid HLKAIHGMLDH;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid HKAENKNPFJG;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid MILBPAFOLHM;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid OEOFOCJJPKO;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid NIJIFGICANJ;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid GFPMDEKIPKL;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid AJLJPNBMDEA;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid ACKIMOLAGKK;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid ELPNDINCAEE;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MNNKIJPDIBK;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid IGMHJFBANGB;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid ALLNPFNLCNF;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid DPOBBICDBIE;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid HFIMMBGBDFO;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid HFFENEIAKPK;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid EMEHMLDHLEJ;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid PKBBJKDAEGE;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid PGHFICEHBOF;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid IAJAMDJBEOO;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid GADECHKJABC;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid IEBLPCLHIBN;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid AMDHBCPDAKM;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid KNCHBNHPOKL;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid CCBIMGLLHLJ;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid NPCFHJIDHOC;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid IKBACPHFKCM;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid CGFGDCCKKCN;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid LFNIAHKOKHO;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid PLLGFJDDGMB;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid OOPHBNFCCBH;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid ANLFCHAJFOP;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid HKMCAAJCIIK;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid FLJMEGLGIOB;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid GCLEIJDFMEE;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid DGFFJLPCFHI;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid JMOMJAPPICC;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid IMPLMEJKNNE;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid ICKIHENLNJD;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid DHNKNNMBHKK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JCBICKGBKCO;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid DBAHPFDALBJ;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid JMOFEDBJLOG;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid DOPCEAEELGI;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid HOCNKNGBGFJ;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid JDGPDDLIBKJ;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid NOBNEOKPANN;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid PNAEEIILBBF;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid MDAEHKFJLMG;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid EDEFMJLFIHN;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid LJIAFIDKMMB;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid BBCIDPBGFAE;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid MMGDPHELJEJ;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid BAHLCAJHADE;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid PEIFIECEKHG;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid FJAGPKFLPNF;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid MHFMHHJCNFH;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid IGGGKCHOFCP;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid POLMBFCPOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid EDIFDEMPKFK;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid FFDINIIMMIH;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid MIIPJGBMNHC;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid OEDICNMNJCK;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid ICMLMFBMLBK;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid CCEIBADLKBD;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid FHPBFOJEEDG;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid NCJNPAHDHII;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid FJCHKIIOJMN;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid IGJBDJEELHC;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid LOEKDGHJHIL;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid DPADEDMPGGE;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid BKAHJJGAKGL;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid FIIABKPHGGO;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid GDENJLBALKE;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid FLLBJOILOHD;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid NDBLCJMJKKE;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid ABJNFPKFKAI;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid ALMEPFCEGEA;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid JHCCOLCGGAK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid PEBAMLDANLH;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid ILMKJBGMNJB;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid MLJKLKBDNON;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid KNMFOLABBNF;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JILINLBEFFI;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid JJLIPNFNFFM;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid NMGOEGAJELC;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid IPLNFDJOCHB;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid JPLFCBLPIFC;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid IKOIONLHPNF;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid OJDJCIOMOMC;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid ENJMNMOBHNB;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid LFFOKMDONMN;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid DINNPNFHBLK;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid ADBKEDAMGPN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid OELNDDLHIDP;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid CEKNPINFFJE;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid PJBLOFAINOP;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid BLMAAIMFLND;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid CNNIHMPPEEP;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid GOKENPNMNOJ;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid KPOFIIGBNBK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid BNKBJDNDKED;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid MMBOFBLJIBI;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid PBIKJKBNIGI;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid ABHPJLNEHPI;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid GMFHHNNFCCH;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid CHPOPOAKKOO;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid CHCIBGMCBCE;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid BKBAHLFBCHG;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid KKBPAADAACK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid CNEADAJEALA;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid NOMPHIMNCIA;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid DANBMPEFLHL;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid GKAPAFMPDNF;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid NCFHMMPCBNN;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid AEEDGDOABDI;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid EPBBIPDACNA;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid BEHIMCFHAEM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid HLMPHBPNMDE;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid KFDIEKIMKKO;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid DEDIBNLBFND;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid LNFNHEBHAAI;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid FMNABLNNKOF;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid FNJEIHANJLG;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid JGGCFEHKAKD;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid GELPIBOOGMG;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid NJHEFAFIDFE;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid CNLOJKBOPEH;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid ABABNMNDHDI;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid NALAIBFHJED;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid CAFCKIFEILM;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid ANNIOODHLEL;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FNHNPIBDAGE;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid MAHIGFFNCKM;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid MCIOEANDNMF;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid NBIAECNJOCJ;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid GLBCBGFEOCH;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid DKIBFPHHHHN;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid FGFPBGHGOLI;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid HBNLABHEGPA;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid GCHIKLHAKPC;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid BPDICPBGANK;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid FKKLOKPONAF;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid LLOFMPJEDIO;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid EGJNOOMJDCM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid ODEDGECCPLE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid KBIGLNNDEGN;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid DFBIKDBMLEP;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid IMDGNKOHLHB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid AGKEKIIOMCB;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid LIEBPENIPPO;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid HKJLFCMGMMB;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid GNLPCBJOJNK;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid EEHHPHHAOBO;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid ABKDOACHADM;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid AFOCAAJBCPG;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid OJJBFLNLPHE;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid ADCPFHOEDIO;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid MNKAONLIGJC;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid OLCHCNFOEIP;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid KBPBJKGOBAE;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid CBLLJPFNKFD;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid ELFIPMBJJAH;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid FBKBDPKCBFB;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid JFJCPLELCDD;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid JJLHMKIOMNE;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid GNCHOAGAKOC;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid AOKMENFNFBN;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid IBMHHNDPLLE;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid CIONFJKDNHB;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid JLEADMJLIID;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid MKCBHGEHFME;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid EHKOAIBMMDD;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid MONAPCKPBND;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid BDFPDHFAJEM;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid BPCJLPCPIHM;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid PONKFBIFCHB;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid IBADNBFMFDI;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid MGIGMOGKJGL;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid GDFHHOAKECC;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid ICHKELMGMAP;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid LPENKAPDDEL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid JHKIAIFGBOA;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid BLAFACIPKJK;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid GJGPEOEEPOP;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid AOGLCAPIOHD;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid HEEFGMCFJJB;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid IEFBKNECLBK;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid PMPBMOEHJDI;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid GIMAJJPNAMG;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid ELBNGEBJCFB;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid LPHBGBGEABG;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid JPKLECKLBOP;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid AHLHJOIOJCE;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid OIMBKNLHFAK;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid OKPHGHNFBKL;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid NDNMMOABOAI;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid OLGLMLBALJJ;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid IAIKDLMLIOF;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid BPKPCCPGKJM;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid NABEDDLKCDH;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid EPADHMNHKMF;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid AJGMOKMNCOG;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid HCHEAPPFNDF;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid PNLIJDPCLMI;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid ODJILGILIBD;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid NBPFCJBAKBI;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid CLPNCADEBIK;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid BOKHGLDMMMN;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid OJNNDPEKDFG;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid PCMMMEJKBKL;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid GMLMNPJACMI;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid CHBPENICLFI;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid BMADNHBMMGB;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid BDDGAODMCCJ;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid NANAFJJJDFL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid CFNJNBBLCEE;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid BDHDKIMEOFD;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid MMHDINCPDPJ;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid KJHAHDFDNEB;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid CGDOHOIOMEH;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid KNHPDAPBHLI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid HOOOEMGPCCM;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid BMAFEHFPJNM;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid EAHNDPOPDCJ;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid PJMEJCIAFIE;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid LHPMACINCDE;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid HBFHEGKCIJL;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid KCELNBOIMMO;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid JABBOAJIHDM;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AEHDHJFGDFH;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid OFGOALICNAE;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid ACPGNNJOPNI;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid HPGGOPBCHCE;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid DDBLIFMOHAJ;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LOFDHAPGHKM;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid NLIBJCIBNAE;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid ICLABAEOBPJ;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid NANMOINAKHB;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid ILOACCMOIPP;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid DNAALHEPFFH;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid KPIKNLPOKJH;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid PGGNALKDLHB;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid IJFAGAJJFLJ;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid DFCDDKPKPGP;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid GPCNFKIOCCI;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid OMFCNKJCIIE;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid IAALLBOECIG;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid MBODNOHDGGB;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid KNBFIKABNPO;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid HPEIPFBLMCE;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid HEBMNDOGKOF;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid GIGECIOMHAF;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid PPOLHLMCLBH;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid HIJPJPMEEPP;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid JBDJIAFDHLE;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid LNMMHKFKNOC;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid KJJBMCNNDEF;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid OILNALPMLJF;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid JKHDKNAMLLC;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid PGKHNIIOMLH;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid IEANBJKDKJK;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid HDELOODIFJN;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid FOPOPEMLPDP;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid OOCLGEBNDBE;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid BPPJNEPHEAL;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid AONMDNGFJFF;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid OJIACAGDBGK;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid NFHCMHLKOHO;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid DCCKDLLIJMC;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid KLHHBABCDFA;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid EIKNCEOPKFL;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid EJCODHJLOLH;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid LODGACGLFCL;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid KMAFGJHLDCB;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid NHPFKLEFAMN;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid CEJIGDCJEJL;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid LOABAKNHGEA;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid GHOBCPMBFJM;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid FHBAAHDKALP;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid FHLKFJMDFNN;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid HNKKFCHLFGG;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid DHMBIDKMMIP;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OLHMHIFEBML;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid LDCGGKFMNJC;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid MDPBGHGPAEH;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid ADKPNDNJKGE;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid KEIMMMAKEJF;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid OPFIGCNLNIN;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid AFICBKCOAIG;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid EINIGKEDAII;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid ELKJLKIIMFL;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid AHBHKJBBNDL;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid MCCMMJBPEOA;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid LPMDBPOBMCG;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid BIGPFEHKLAO;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid KFGJKBNHOPI;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid FMJHDGPGHKB;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid NDFFNMCKEJI;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid JAMNOCOAPEI;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid HGNMAOGKFKB;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid NIPINOEEEBE;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid KJIPAABNKGK;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid PCMKKCNADCO;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid FPHOHIFBHEJ;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid DPKGMFICBAF;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid BBNIHJNLLIJ;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid BNDNKLMEPLG;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid FGMJFEPFIHM;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid PIHFLIANOKD;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid CPPCJEBKKLE;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid BNFPADDDIFE;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid JMAOBPIHOOK;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid IALMBFNCPJO;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid LOJDGEAFGLM;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid HMJCLEGACBF;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid LPEBHAPFAHB;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid MINEKHFBOPP;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid DFALOBEEJKF;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid MJHKGPLJEEH;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid AFBNFNGAHGA;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid BEACDEHNHFJ;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid IOCPIBAMJCB;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid DAGGBJFDHMF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid OABNMLJMMAC;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid HJOFOEABMAP;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid PKDLJJEJDFA;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid GKKCOLIOHON;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid MCOOFPFMNEC;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid PCBAHKADMMD;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid LLMMKLCGNHF;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid JCABDEDIICA;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid MOHIIGPKOIA;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid DIDBACFEBPI;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid BBNPGKHNKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid FHOHGBHEBBO;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid ECDANIDOJNI;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid OENIGACDHBD;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid HPLCEJCIBFM;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid KBOEKHAACBO;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid BNOPFCCEJNE;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid PCPHPGMOFDK;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid BDDHOEKKDOD;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid KJPPJMNHLKG;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid CNKKEIIKENJ;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid OEPJPJGPNPH;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid PIMEGLIJEGI;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid PEOFEMBLMMD;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid MNAJLGJOOIN;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid NHMHFLEBHJP;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid KMIDOJCKIAK;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FKNAPODCIHB;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid IGCIHBKMKHE;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid CLMBOEDKALP;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid BIDDCNCGOAN;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid IPLEIIMHKFJ;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid EMOIDPHMPGO;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid POEEOEHICCO;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DGGPGODFEGN;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid PIFMNFKJKNK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid NKFDAAFEMGF;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid OGJJLACFKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid IEKICEAIKND;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid BCPMEMLIOBA;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid HCHKCCIDCED;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid JCPOHAGMLIL;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid CCCPACONMPO;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid KIMOHKNCPPC;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid HAAMKHEKHPO;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid JABAHIGAOGI;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid CIOIIFIHJME;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid BHPBLOMJGBD;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid OBLJJBCKMHJ;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid BEBDCIKALAI;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid DIEBMKIMFAE;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid BNJCJABHNIG;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid DLJEJMCJBCO;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid NJGNDFDPBEC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid NNMNFEIIIFN;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid NKKCEHJLDHL;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid JDBPBDBNCJP;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid HHCEIFIPDNG;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid BFMCKLGFOFE;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid KFJAGLJBPKG;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid KLBAPEMEAHI;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid MLIEHBEBFCK;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid GDMGPOABNPO;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid DOLPMHNECEB;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid KOMMFAAEEPL;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid KKDCFPBPAJA;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid BMPEONEGBGL;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid KCKBMAGOOBM;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid APCMJBJPPJN;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid ADIKGFEHKHL;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid EFAKMDLIOFD;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid DFLLHKEGKJB;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MABMONLDKBP;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid NOHFBECJINL;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid GMDALHKOPCG;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid COLGDHBILPH;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid JMBCLJNBMHC;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid IMHALAHOJJA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid GDMMPPEOEBP;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid OPOFBJLANIO;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid LBHPGPLGFLF;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid DDMGJFFDFAD;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid FDADOMILNPF;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid KBHLMHNCFNN;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid JJBNOJJGMMN;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid BHKHAHNFJAG;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid FJBCFFJGDKL;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid JPADABAJBJL;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid BEFNMOHCGMP;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid EFEAABABPMH;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid GDBFBONKGPD;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid KGENHBAPJDA;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid KEHKFNOKEIM;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid NKLHLOKHJAC;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid MPFELMGLGLN;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid FHBIJGMKOPC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid PJPDJCCFEHG;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid MKPHBJLAOJC;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid GNMEMIDHHKI;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GFCNECIHPGD;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid NIHBHJOPKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid HNOFFBHGHKP;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid AMPOPNHFKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid KJJLKGHJIIF;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid LFPAKKDNBFB;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid OGOAAPDAOOO;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid KCAGDLAKCNC;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid EMCOACPBAIM;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid ELALNNBFFPA;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid BACFLABCPNJ;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid BFHKGBKDGNJ;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid DDDJHIKDCGG;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid IKKBCALPJAO;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid DDBKGCLONMA;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid FFJPAMEPHGK;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid FDONBPDNCKI;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid IJEGENKNMNB;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid JLMJKHOOHHF;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid EDCLALDFHJM;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid BOLMBCPACNO;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid KBBONDLELCJ;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid OGHGLPBBLNM;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid GPFMDMPIOLC;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid MDKGMPKCGLE;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid HFGEFKLEOEP;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid HFMJMMNOPKI;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid HFPIFNHAFAG;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid JIAIKOMKAFK;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid ILLPBCOLMEE;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid PBKLDCLGNKJ;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid PEHKOGILDPM;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid PDFGJNCEFHJ;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid EDDAPCMKEKH;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid AACDMFMNFJB;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid EODDMBKNHNH;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid GNPGDECJGDI;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid AKFIMMGDOEP;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid GNFKJLNPBOK;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid PGLCBOPPJHE;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid ALLANEHIEOC;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid IANFDJADAJC;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid LLIIPHEFOHG;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid OMOIBEEDKCC;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid GIBALHOEBEL;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid NOAPLKOOBOP;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid AEKMCBNEABG;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid FIJMMPIDBMG;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid DGNGGJLONCI;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid IIALPHGAICD;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid PKILNAGPDJN;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid DJNJMNPBFLD;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid GBOAFGLHONE;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid HAIIGPGMPKP;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid ENDEIPGGDPE;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid JJJFCNDHMMO;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid LPEJNPAFIHB;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid OPBEFFOMOGJ;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid CINBGMJIIIF;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid MEKAJEMEPBO;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid OAJLOJCGOLB;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid CGEAOIIMFJF;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid BOIJDIPJACA;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid AOBBOLNAEIJ;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid KBEHPPKDJCG;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid BPEMBECODBF;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid OFCLHOKPCDN;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid LNHPLGFHGMM;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid GKJLLAMLFNH;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid JPGNCNCGKAD;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid JDIALEOKMDD;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid DGFKJELLDMO;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid AOFHPPLBIIJ;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid GBEMOIFLEGF;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid NGLPEEKBPAI;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid DFIIAOGAKMO;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid IJJHENEAPMA;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid OOGDHGJJOPD;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid HDNNGAACMPK;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid AJMHEMNLHFG;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid OLEOOJKNDLH;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid NCLCOBDPMGG;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid DAHAPPKJLIN;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid FPMOMPAPIHF;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid MDCIMCOGLNG;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid NNLMKFAKADL;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid OKBOOIBJAOA;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid PIDLODFEMIO;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid PNEFFFLDDKP;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid AODMEOGCDCG;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid FLMPOLOKOFI;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid FEOMBCLKDLD;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid CDGFPHDHPCK;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid CGIPMBIAMLI;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid EBDHGGIONJI;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid BHKCHAJAIPO;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid IJOEADIICMO;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid KJLNCFOBOMD;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid ODLFEMOPEBF;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid MCKPMHKLJAD;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid FCAEJECEDEK;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid CEELGAGGNNO;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid EOCIDCKGLGO;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid DMJPPNFMPOI;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid MGKKDONNONB;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid DGJEKKIGLBC;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid HDCCGMLKCPC;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid FHGNHGGCCAI;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid FHKOMPDHKBC;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid BEAIFJEJLBA;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid ELJDEDFNCOK;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid GFOAPNCNIHN;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid KACABBANAEC;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid NLFOIHNNLKB;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid HEAMFJLHFCB;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid BJDEJFHPBKE;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid LOJGOMKEOKE;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid FAECFGPFHEO;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid HLKOINBNLGC;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid OIMOHFDMBOC;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid BELMCGCLPPN;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid EIBKKCBMGCK;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid JOJBOIFEBHP;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid BJGJFJGJGLB;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid GIDBKKJMCHE;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid BMBDCNFBHFA;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, HBGGICKEEBH> EJKBNDNPJLN;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<HBGGICKEEBH, Guid> NEDIFDILDJP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, HBGGICKEEBH> NJMLFLNCPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6946150", Offset = "0x6944D50", VA = "0x186946150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<HBGGICKEEBH, Guid> NAFCDPCFDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69460F0", Offset = "0x6944CF0", VA = "0x1869460F0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HDEEECAIFFL
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x695BC30", Offset = "0x695A830", VA = "0x18695BC30")]
	public static bool DMECLCMGLGM(MNONBDJHEPE EAIDODCNHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x695BC60", Offset = "0x695A860", VA = "0x18695BC60")]
	private static bool DMECLCMGLGM(JEJKJBNBDAA OIBBHECAKMI, MNONBDJHEPE EAIDODCNHDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KLHGNCGCIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly NGAKEPLJGMP IOEMODDFGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<KPIIJEHPKNN> BAMEECLDFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<KPIIJEHPKNN> BNEEHKOKLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly JCIKKDEFAFO<LDNFOKBFEMK> AGKJBBHBPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<ABKJIOOEHEB<BKMEFFNPIFK>> DMFOFKBLMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString DNMNHNCNIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly MJOFGOEMABG NMNLOBCDJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool OKGBGFLCLNM;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x695E850", Offset = "0x695D450", VA = "0x18695E850")]
	public KLHGNCGCIIP(NGAKEPLJGMP CHLAGPFNKCB, IEnumerable<KPIIJEHPKNN> FBCBNNIIADI, IReadOnlyList<KPIIJEHPKNN> JMAGGOKBFGJ, JCIKKDEFAFO<LDNFOKBFEMK> CJMGHKPDCFB, IReadOnlyList<ABKJIOOEHEB<BKMEFFNPIFK>> INNFGGBPKAC, ByteString HODMHEBBIHH, MJOFGOEMABG FBFIEDPIHJN, bool DFIELJFAKPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OCBBHCCECKD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(KHNBFCCCFFN JGFKFMMOAJO, [Out] Dictionary<int, int> HMEFODDNGHP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(OPBPGNGHMAL BBGHDNLAMMD, GHEDPBMOEHN AJKOJLFPFBO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PLKGOKBNDBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid ADJHJPLPMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> NGACFFLFBOA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> HMMPELAAHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3950780", Offset = "0x394F380", VA = "0x183950780")]
	private PLKGOKBNDBC([In] Guid KJBFEHDOKDN, Dictionary<Guid, Guid> PEPPLNILEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6962A80", Offset = "0x6961680", VA = "0x186962A80")]
	public static PLKGOKBNDBC DCGMNNGGMMA(IReadOnlyDictionary<Guid, Guid> FHKPDAKBINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6962C50", Offset = "0x6961850", VA = "0x186962C50")]
	public static PLKGOKBNDBC OLDIFMAAOBI(IEnumerable<KeyValuePair<Guid, Guid>> FHKPDAKBINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6962BA0", Offset = "0x69617A0", VA = "0x186962BA0")]
	private static Dictionary<Guid, Guid> ODMDPLEELFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6962A90", Offset = "0x6961690", VA = "0x186962A90")]
	public Guid DDLLDICCNIG([In] Guid GBCIBJHFOHP, bool KEAKPHNCCHF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6963000", Offset = "0x6961C00", VA = "0x186963000")]
	public bool POKGNCMGGAI([In] Guid CABAGOHBNFK, [Out] Guid CGOECAFCFOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MEBCJEAODBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FOKNBPHHGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCPIDJEBGBI(ByteString HNJEGMGEKFJ, PLKGOKBNDBC FPNBIAJMBOG, [In] UniformTRS IPKEPLECNMN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EGMJNCPPCAF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OEOKLBMMDNA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x150F750", Offset = "0x150E350", VA = "0x18150F750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EFELFLCIKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1029C00", Offset = "0x1028800", VA = "0x181029C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long GHOCECCLIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6962A60", Offset = "0x6961660", VA = "0x186962A60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6646DE0", Offset = "0x66459E0", VA = "0x186646DE0")]
	public OEOKLBMMDNA(long LLHINFJPPOH, long LJHLGBMEINH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GGLJIBODPBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, OEOKLBMMDNA> KNOPDDLKOHJ;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> JJGIMDFIPLJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long BFCMOBENEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1029C00", Offset = "0x1028800", VA = "0x181029C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long FDCELELPCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1088690", Offset = "0x1087290", VA = "0x181088690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6946470", Offset = "0x6945070", VA = "0x186946470")]
	public static GGLJIBODPBC JHEDGJNDFKJ(NGAKEPLJGMP FJIPBCMNFBE, ABKJIOOEHEB<LDNFOKBFEMK> HOEAKMIOFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69461B0", Offset = "0x6944DB0", VA = "0x1869461B0")]
	private void IFLDGEAIBMD(OAAKPGFEBMO AIJMDPAKHCL, long NLGDOKCGDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x695A420", Offset = "0x6959020", VA = "0x18695A420")]
	public GGLJIBODPBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LJOLINOBHLO
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<HBGGICKEEBH> GKJAAALFJKP;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class PINKDDINNOI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> PAFDIGPLJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> JMCDGHAMKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x872290", Offset = "0x870E90", VA = "0x180872290")]
	public PINKDDINNOI(IReadOnlyDictionary<Guid, Guid> DNFGNJDPIJH, IReadOnlyDictionary<Guid, Guid> IMDNPJPKEFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MPBDPKNDKCG
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x695F590", Offset = "0x695E190", VA = "0x18695F590")]
	public static HACKKIKGCPD ALLLGKGOGEG([In] KLHGNCGCIIP GBNNGCFCKGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x695FD90", Offset = "0x695E990", VA = "0x18695FD90")]
	private static void HGFMAPOHLAO(HACKKIKGCPD OAHCPNJKHBM, [In] KLHGNCGCIIP MOPKOBAMHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6960BB0", Offset = "0x695F7B0", VA = "0x186960BB0")]
	public static NLDGPBPIIJN<PINKDDINNOI, DMIPMPAKCIG> LBLKFNMMNEL(HACKKIKGCPD OAHCPNJKHBM, KJPHGJJHMII JKJNJNJPLHF, PLKGOKBNDBC? MEMNPAMCHIL)
	{
		return default(NLDGPBPIIJN<PINKDDINNOI, DMIPMPAKCIG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6960460", Offset = "0x695F060", VA = "0x186960460")]
	private static void HJBKFEGGKNL(HACKKIKGCPD OAHCPNJKHBM, PLKGOKBNDBC? IOLDKBEMPCL, KJPHGJJHMII JKJNJNJPLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69603F0", Offset = "0x695EFF0", VA = "0x1869603F0")]
	private static void HIOCCJAIFMB(HACKKIKGCPD OAHCPNJKHBM, KJPHGJJHMII JKJNJNJPLHF, IReadOnlyCollection<ByteString>? NHKCIMEMEFD, IReadOnlyCollection<ByteString>? NFBOFAFAAKE, IReadOnlyCollection<ByteString>? NHOPEEMJIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x695F700", Offset = "0x695E300", VA = "0x18695F700")]
	private static bool CKEJAHBCELF(HACKKIKGCPD OAHCPNJKHBM, OPBPGNGHMAL BBGHDNLAMMD, KJPHGJJHMII JKJNJNJPLHF, [Out][NotNullWhen(false)] string? JMMBJIBOIFP, [Out] Dictionary<int, int> HMEFODDNGHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6962670", Offset = "0x6961270", VA = "0x186962670")]
	private static Dictionary<Guid, JEJKJBNBDAA> MOFGGMDPJGL(HACKKIKGCPD OAHCPNJKHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x695F4F0", Offset = "0x695E0F0", VA = "0x18695F4F0")]
	private static void AKLNBOILFDO(bool OAEIBMHPHON, KPIIJEHPKNN GLDBNLEBGAB, Dictionary<Guid, Guid> PJBNCGIAIGL, PLKGOKBNDBC FPHNDILFCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69623E0", Offset = "0x6960FE0", VA = "0x1869623E0")]
	private static void LNNCLEGOAMF(KPIIJEHPKNN GLDBNLEBGAB, Guid IFGIJCBHCEJ, LCCIKFEJHMP? AGGFDEEIIDN, Dictionary<Guid, JEJKJBNBDAA> BMIIENPJNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6960700", Offset = "0x695F300", VA = "0x186960700")]
	private static void LBBJEOCCHCE(IEnumerable<KPIIJEHPKNN> MGHJJBJPGME, IReadOnlyCollection<ByteString> NHKCIMEMEFD, IReadOnlyCollection<ByteString> NFBOFAFAAKE, IReadOnlyCollection<ByteString> NHOPEEMJIDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KJPHGJJHMII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool OAEIBMHPHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public MJOFGOEMABG FBFIEDPIHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public LCCIKFEJHMP? AGGFDEEIIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public LCCIKFEJHMP? KDCJCBMGOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public NGAKEPLJGMP NBJKKFKAIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public EGMJNCPPCAF FOPIIHGKNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public OCBBHCCECKD NPBLLPDONPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public MEBCJEAODBG GJCFGGNGPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public ABKJIOOEHEB<LDNFOKBFEMK> CLEDMCIKJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public MOAIGMJPFLL OFMPONPJOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<KPIIJEHPKNN> GCODJMFAABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> MIGPGNPNLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public FGEJNNJNLMJ JPGLGKHGHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool LGBMOBOHIKI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KNBJKGMLGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x695E800", Offset = "0x695D400", VA = "0x18695E800")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LCCIKFEJHMP
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float LGINBMJHKBG = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 DCDKACDAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion GPEICHFGELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float DANMJNNJDHD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 CMAKBJNFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x695EFA0", Offset = "0x695DBA0", VA = "0x18695EFA0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS GEKGNNDFCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x695F0B0", Offset = "0x695DCB0", VA = "0x18695F0B0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB355D0", Offset = "0xB341D0", VA = "0x180B355D0")]
	public LCCIKFEJHMP(Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, float DANMJNNJDHD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x695F210", Offset = "0x695DE10", VA = "0x18695F210")]
	public LCCIKFEJHMP(UniformTRS OFCGNIENHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x695EA80", Offset = "0x695D680", VA = "0x18695EA80")]
	public static LCCIKFEJHMP EAFHKCPIFJO(LCCIKFEJHMP DELFIACNBGK, LCCIKFEJHMP LAOCEBFNPMP)
	{
		return default(LCCIKFEJHMP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x695EA60", Offset = "0x695D660", VA = "0x18695EA60")]
	public static LCCIKFEJHMP ANHILFPCAJJ((Vector3, Quaternion, float) JGFKFMMOAJO)
	{
		return default(LCCIKFEJHMP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x695E8E0", Offset = "0x695D4E0", VA = "0x18695E8E0")]
	public static LCCIKFEJHMP ANHILFPCAJJ(Matrix4x4 AEANLAKOGGC)
	{
		return default(LCCIKFEJHMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x695F180", Offset = "0x695DD80", VA = "0x18695F180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x695ED70", Offset = "0x695D970", VA = "0x18695ED70")]
	public LCCIKFEJHMP GCMJEKANGEH(Matrix4x4 MENBKJEFCNP)
	{
		return default(LCCIKFEJHMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x695ED00", Offset = "0x695D900", VA = "0x18695ED00")]
	public static LCCIKFEJHMP EKCANJOKIGB(Vector3 DCDKACDAEIJ)
	{
		return default(LCCIKFEJHMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x695F0F0", Offset = "0x695DCF0", VA = "0x18695F0F0")]
	public readonly MDCJCJDDPLM PNKGDDGDPPM()
	{
		return default(MDCJCJDDPLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NOFMGEBFECH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6962950", Offset = "0x6961550", VA = "0x186962950")]
	public static LCCIKFEJHMP DJIPGLNFDPL([In] this MDCJCJDDPLM ENEDBNLKLJL)
	{
		return default(LCCIKFEJHMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DMIPMPAKCIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly OOGNBBOAMJA JJFCLNLGJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private readonly MLPOHKBMKMA ILGKOAMILJM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD98E30", Offset = "0xD97A30", VA = "0x180D98E30")]
	private DMIPMPAKCIG(OOGNBBOAMJA DEJLCIIFBAN, MLPOHKBMKMA BILIACFCJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6946080", Offset = "0x6944C80", VA = "0x186946080")]
	public DLHJBPGLGBA KJBBJLHDJGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6945F20", Offset = "0x6944B20", VA = "0x186945F20")]
	public static NLDGPBPIIJN<PINKDDINNOI, DMIPMPAKCIG> FCDPFGJNKNI(ENKCDBGGHHO<HGAAMJINHPI> BILIACFCJIG)
	{
		return default(NLDGPBPIIJN<PINKDDINNOI, DMIPMPAKCIG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6945FD0", Offset = "0x6944BD0", VA = "0x186945FD0")]
	public static NLDGPBPIIJN<PINKDDINNOI, DMIPMPAKCIG> FCDPFGJNKNI(DLHJBPGLGBA BILIACFCJIG)
	{
		return default(NLDGPBPIIJN<PINKDDINNOI, DMIPMPAKCIG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6945E60", Offset = "0x6944A60", VA = "0x186945E60")]
	public static NLDGPBPIIJN<PINKDDINNOI, DMIPMPAKCIG> FCDPFGJNKNI(string CLPEBOBHGPG)
	{
		return default(NLDGPBPIIJN<PINKDDINNOI, DMIPMPAKCIG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum OOGNBBOAMJA
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JMHIGLPIAIC : IDisposable, AHGFGGECIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private NativeList<KHHNONIILDN> IPJFAKGKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private float NEICCINOMAE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PDCECJCBAEH GCNGGKNOOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0")]
		[CompilerGenerated]
		get
		{
			return default(PDCECJCBAEH);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x868D10", Offset = "0x867910", VA = "0x180868D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool FILJBAHKGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x695C5D0", Offset = "0x695B1D0", VA = "0x18695C5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BDAOEFBDPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x695CC30", Offset = "0x695B830", VA = "0x18695CC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<APBGIMGOLBN> CPJDKMFNNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int KDPMJNPAICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x695CDE0", Offset = "0x695B9E0", VA = "0x18695CDE0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float DHNCFKFGBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x695D9D0", Offset = "0x695C5D0", VA = "0x18695D9D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x695E770", Offset = "0x695D370", VA = "0x18695E770")]
	public JMHIGLPIAIC(PDCECJCBAEH DKIOAOHDADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x695C730", Offset = "0x695B330", VA = "0x18695C730", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x695C010", Offset = "0x695AC10", VA = "0x18695C010")]
	public Vector3 APOKGBBDKEC(int BBKKKIFBKCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x695CD10", Offset = "0x695B910", VA = "0x18695CD10", Slot = "6")]
	public Quaternion FGGKHOMKMEO(int BBKKKIFBKCP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x695D760", Offset = "0x695C360", VA = "0x18695D760", Slot = "5")]
	public Vector3 KDEBKMNOHNC(int BBKKKIFBKCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x695DC70", Offset = "0x695C870", VA = "0x18695DC70", Slot = "7")]
	public float NEPMDANNCEK(int BBKKKIFBKCP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x695DE80", Offset = "0x695CA80", VA = "0x18695DE80")]
	public void PBLHEIHFNKG(Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, float KBOADMDLFLD, bool CNAKBIEBDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x695C570", Offset = "0x695B170", VA = "0x18695C570")]
	private bool BLDFKBDBFDM(int BLINHINCLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x695DB10", Offset = "0x695C710", VA = "0x18695DB10")]
	public void MPJNEHDOFDC(Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, float KBOADMDLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x695C4E0", Offset = "0x695B0E0", VA = "0x18695C4E0")]
	public void BACLOECENAB(int BLINHINCLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x695CE20", Offset = "0x695BA20", VA = "0x18695CE20")]
	public void HKEFELNLKHP(int BLINHINCLGO, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, float KBOADMDLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x695DCD0", Offset = "0x695C8D0", VA = "0x18695DCD0")]
	public void NOOJIAAELEL(int BLINHINCLGO, float3 DCDKACDAEIJ, quaternion GPEICHFGELO, float KBOADMDLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x695C5E0", Offset = "0x695B1E0", VA = "0x18695C5E0")]
	public void DLMEGFDGCEJ(int BLINHINCLGO, Vector3 DCDKACDAEIJ, float KBOADMDLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x695D870", Offset = "0x695C470", VA = "0x18695D870")]
	public void KOBNICIHHNH(int BLINHINCLGO, Vector3 BCLJLGDCOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x695CF70", Offset = "0x695BB70", VA = "0x18695CF70")]
	public static Quaternion IDDILOGBHDA(Quaternion CPJEMABJFPA, int BLINHINCLGO, float KHCNOGHPFIA, AHGFGGECIMI CFDFNHIJLNJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x695C790", Offset = "0x695B390", VA = "0x18695C790")]
	public Bounds EDLADMMNHKE(Transform MENBKJEFCNP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x695D800", Offset = "0x695C400", VA = "0x18695D800", Slot = "10")]
	public virtual void KLKLIMIKDHA(bool MEDNFJHBOMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x695CC40", Offset = "0x695B840", VA = "0x18695CC40")]
	public NativeList<KHHNONIILDN> EKDBBPGFPFM(float LALFLILCLMI = 1f)
	{
		return default(NativeList<KHHNONIILDN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct APBGIMGOLBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public float3 MMKDAECKHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float NLMAFIOPDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public quaternion PIOLKMJHDLL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6964500", Offset = "0x6963100", VA = "0x186964500")]
	public APBGIMGOLBN(Vector3 DEKDOALHJMJ, Quaternion CPJEMABJFPA, float KBOADMDLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6963F90", Offset = "0x6962B90", VA = "0x186963F90")]
	public Quaternion CJGICMPJHBN(Vector3 MLCEOGMBLFG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6964050", Offset = "0x6962C50", VA = "0x186964050")]
	public APBGIMGOLBN FBGEEBGHCBN(Vector3 PHFKAMJPJOO, Vector3 EPLLBALCELE, Vector3 OFJAMIIBGDP)
	{
		return default(APBGIMGOLBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6964350", Offset = "0x6962F50", VA = "0x186964350")]
	public EECKPBHFBKN OKBHCJPKEDB(Vector3 MLCEOGMBLFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class ACDDCLCFAOD : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6963120", Offset = "0x6961D20", VA = "0x186963120", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6963420", Offset = "0x6962020", VA = "0x186963420")]
	private void PJBHCPBBLGH(Dictionary<Guid, Guid> OPLLHEBOCKD, HJDFEDOKDEK JAHINHNFDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69639F0", Offset = "0x69625F0", VA = "0x1869639F0")]
	private void PJBHCPBBLGH(Dictionary<Guid, Guid> OPLLHEBOCKD, PDDHPKLDLCD ICHOMGJABNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69631A0", Offset = "0x6961DA0", VA = "0x1869631A0")]
	private void PJBHCPBBLGH(Dictionary<Guid, Guid> OPLLHEBOCKD, LAJILFIMKKD HOONMCLAPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public ACDDCLCFAOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class IJKKFEPBLIB : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69685B0", Offset = "0x69671B0", VA = "0x1869685B0", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public IJKKFEPBLIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class EFJHMJHACCO : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6965DD0", Offset = "0x69649D0", VA = "0x186965DD0", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public EFJHMJHACCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class OFKIMLAFPJA : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69694D0", Offset = "0x69680D0", VA = "0x1869694D0", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public OFKIMLAFPJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class HEINPFAALKA : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6968390", Offset = "0x6966F90", VA = "0x186968390", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public HEINPFAALKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class GMPOOKIHGOC : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6968250", Offset = "0x6966E50", VA = "0x186968250", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public GMPOOKIHGOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class AJLHEOCHGHK : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6963A50", Offset = "0x6962650", VA = "0x186963A50", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public AJLHEOCHGHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class CHBAPMOBEAN : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6964920", Offset = "0x6963520", VA = "0x186964920", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public CHBAPMOBEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JMDNBNBKNBK : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6968F90", Offset = "0x6967B90", VA = "0x186968F90", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public JMDNBNBKNBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BJCLFFPDLAB : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6964580", Offset = "0x6963180", VA = "0x186964580", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public BJCLFFPDLAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OMFBFLPBEFB : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6969620", Offset = "0x6968220", VA = "0x186969620", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public OMFBFLPBEFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class NIHMDMBCJKJ : KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public static readonly GNIFEJHJCNJ LNLMJBIFANK;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69693A0", Offset = "0x6967FA0", VA = "0x1869693A0", Slot = "4")]
	public void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public NIHMDMBCJKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MNONBDJHEPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public OPBPGNGHMAL FAEMFOKJHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public NFCEPBPGNEP CKEBIMOPLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public Dictionary<int, int> LLJFAGPJAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public Dictionary<Guid, Guid> OGABEEGNKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public FGEJNNJNLMJ JPGLGKHGHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public bool JPPJBALBCNC;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KLAAAJCDFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNEDMGFDEPK(MJLENNJAAFC JCCNGOINEFC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FKBBCOCNLIA
{
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private static readonly KLAAAJCDFOF[] KOMENDAOMCD;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6965F30", Offset = "0x6964B30", VA = "0x186965F30")]
	public static void DABFONHBMCF(KPIIJEHPKNN JGFKFMMOAJO, Dictionary<Guid, Guid> FBEDEBKHHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69661C0", Offset = "0x6964DC0", VA = "0x1869661C0")]
	public static void DBPIFMPAIHL(KPIIJEHPKNN? JGFKFMMOAJO, PLKGOKBNDBC AJDOLCLABJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6966820", Offset = "0x6965420", VA = "0x186966820")]
	public static void OIENFILLIMN(KPIIJEHPKNN? JGFKFMMOAJO, PLKGOKBNDBC FPHNDILFCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6966450", Offset = "0x6965050", VA = "0x186966450")]
	public static void DMECLCMGLGM(MJLENNJAAFC JCCNGOINEFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct MJLENNJAAFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public OPBPGNGHMAL OMHFJMBDMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public KPIIJEHPKNN GLDBNLEBGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public Dictionary<int, int> LLJFAGPJAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public Dictionary<Guid, Guid> OGABEEGNKCO;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x69692F0", Offset = "0x6967EF0", VA = "0x1869692F0")]
	public Guid EFCJNDOAFJO(Guid GBCIBJHFOHP)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FGEJNNJNLMJ
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int FGKPFMNKLBP, [Out] Guid EPFJGOBNJMF);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class DDAFNPBNNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private readonly HashSet<string> ABADPINMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private readonly Dictionary<long, int> AFOJCMFOJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private readonly HashSet<Guid> KIPLJOAAMFN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<string> GAOMPJNBMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyDictionary<long, int> GONDFHOJKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6964A80", Offset = "0x6963680", VA = "0x186964A80")]
	public static DDAFNPBNNBK HKMEBBCGBBO(KDDAPCIFEMM ABJNEIDNHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6964A10", Offset = "0x6963610", VA = "0x186964A10")]
	public static DDAFNPBNNBK EFBGIJKKDAH(HACKKIKGCPD JLKNGHDBHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6964B60", Offset = "0x6963760", VA = "0x186964B60")]
	public static DDAFNPBNNBK JAGDBBBOFPF(IEnumerable<string> ABADPINMPPP, IDictionary<long, int> EMPBCNPOCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6965CB0", Offset = "0x69648B0", VA = "0x186965CB0")]
	private DDAFNPBNNBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6965B70", Offset = "0x6964770", VA = "0x186965B70")]
	private DDAFNPBNNBK(IEnumerable<string> ABADPINMPPP, IDictionary<long, int> EMPBCNPOCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x69652A0", Offset = "0x6963EA0", VA = "0x1869652A0")]
	private void MBJNDPNFLEA(KDDAPCIFEMM ABJNEIDNHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69657B0", Offset = "0x69643B0", VA = "0x1869657B0")]
	private void MBJNDPNFLEA(HACKKIKGCPD JLKNGHDBHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6965490", Offset = "0x6964090", VA = "0x186965490")]
	private void MBJNDPNFLEA(MABCOEEFHJO? LNPGMAMPBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x69659A0", Offset = "0x69645A0", VA = "0x1869659A0")]
	private void MBJNDPNFLEA(DDGJDHMFBKG? AIJMDPAKHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6964EB0", Offset = "0x6963AB0", VA = "0x186964EB0")]
	private void MBJNDPNFLEA(KPIIJEHPKNN? GLDBNLEBGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6964AF0", Offset = "0x69636F0", VA = "0x186964AF0")]
	private void IFBIBIIOJJF(string? EEIMJAMNKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6964DD0", Offset = "0x69639D0", VA = "0x186964DD0")]
	private void LKAIGIIHHDM(DHPECOBHCAM? JLNABBOCNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6964CE0", Offset = "0x69638E0", VA = "0x186964CE0")]
	private void LKAIGIIHHDM(FEEMJHKMOKM? JLNABBOCNIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct GJICMAANHOE
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class AOLDPKACNMH : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private readonly IEnumerator<DictionaryEntry> CHFIEPEFDPA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DictionaryEntry DNDOIMBFNAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6963D70", Offset = "0x6962970", VA = "0x186963D70", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6963E30", Offset = "0x6962A30", VA = "0x186963E30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object JCMGPEFMEMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6963EE0", Offset = "0x6962AE0", VA = "0x186963EE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6963C90", Offset = "0x6962890", VA = "0x186963C90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
		public AOLDPKACNMH(IEnumerator<DictionaryEntry> CHFIEPEFDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6963BF0", Offset = "0x69627F0", VA = "0x186963BF0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6963C40", Offset = "0x6962840", VA = "0x186963C40", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class LJPGBFMIBNF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xC487C0", Offset = "0xC473C0", VA = "0x180C487C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x69692A0", Offset = "0x6967EA0", VA = "0x1869692A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
			[DebuggerHidden]
			public LJPGBFMIBNF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6969150", Offset = "0x6967D50", VA = "0x186969150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6969250", Offset = "0x6967E50", VA = "0x186969250", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6969CF0", Offset = "0x69688F0", VA = "0x186969CF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IDictionary.this[object NCMHANGAILD]
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6969C00", Offset = "0x6968800", VA = "0x186969C00", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6969DE0", Offset = "0x69689E0", VA = "0x186969DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6969B40", Offset = "0x6968740", VA = "0x186969B40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6969BA0", Offset = "0x69687A0", VA = "0x186969BA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6969D80", Offset = "0x6968980", VA = "0x186969D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6969800", Offset = "0x6968400", VA = "0x186969800", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6969860", Offset = "0x6968460", VA = "0x186969860", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x69698C0", Offset = "0x69684C0", VA = "0x1869698C0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
		public RoomObjectCounts(Dictionary<int, int> EOHPEMGMKDC, [Optional] Dictionary<int, int> IEBHJHMNPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6969720", Offset = "0x6968320", VA = "0x186969720")]
		[IteratorStateMachine(typeof(LJPGBFMIBNF))]
		private IEnumerator<DictionaryEntry> ALFEABBCALL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6969E30", Offset = "0x6968A30", VA = "0x186969E30", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6969A40", Offset = "0x6968640", VA = "0x186969A40", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6969920", Offset = "0x6968520", VA = "0x186969920", Slot = "9")]
		void IDictionary.Add(object NCMHANGAILD, object IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6969980", Offset = "0x6968580", VA = "0x186969980", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x69699E0", Offset = "0x69685E0", VA = "0x1869699E0", Slot = "8")]
		bool IDictionary.Contains(object NCMHANGAILD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6969AE0", Offset = "0x69686E0", VA = "0x186969AE0", Slot = "14")]
		void IDictionary.Remove(object NCMHANGAILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69697A0", Offset = "0x69683A0", VA = "0x1869697A0", Slot = "15")]
		void ICollection.CopyTo(Array DKCMKELIAPN, int BAEBMIBABAE)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class CGCNKMBIOEP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0xC487C0", Offset = "0xC473C0", VA = "0x180C487C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x69648D0", Offset = "0x69634D0", VA = "0x1869648D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
			[DebuggerHidden]
			public CGCNKMBIOEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6964740", Offset = "0x6963340", VA = "0x186964740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6964880", Offset = "0x6963480", VA = "0x186964880", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6968CA0", Offset = "0x69678A0", VA = "0x186968CA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IDictionary.this[object NCMHANGAILD]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6968B70", Offset = "0x6967770", VA = "0x186968B70", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6968D50", Offset = "0x6967950", VA = "0x186968D50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6968AB0", Offset = "0x69676B0", VA = "0x186968AB0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6968B10", Offset = "0x6967710", VA = "0x186968B10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6968CF0", Offset = "0x69678F0", VA = "0x186968CF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6968730", Offset = "0x6967330", VA = "0x186968730", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6968790", Offset = "0x6967390", VA = "0x186968790", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x69687F0", Offset = "0x69673F0", VA = "0x1869687F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FC02B0", Offset = "0x1FBEEB0", VA = "0x181FC02B0")]
		public Invention(long CABAGOHBNFK, int LLHINFJPPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6968660", Offset = "0x6967260", VA = "0x186968660")]
		[IteratorStateMachine(typeof(CGCNKMBIOEP))]
		private IEnumerator<DictionaryEntry> ALFEABBCALL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6968DA0", Offset = "0x69679A0", VA = "0x186968DA0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6968970", Offset = "0x6967570", VA = "0x186968970", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6968850", Offset = "0x6967450", VA = "0x186968850", Slot = "9")]
		void IDictionary.Add(object NCMHANGAILD, object IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x69688B0", Offset = "0x69674B0", VA = "0x1869688B0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6968910", Offset = "0x6967510", VA = "0x186968910", Slot = "8")]
		bool IDictionary.Contains(object NCMHANGAILD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6968A50", Offset = "0x6967650", VA = "0x186968A50", Slot = "14")]
		void IDictionary.Remove(object NCMHANGAILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x69686D0", Offset = "0x69672D0", VA = "0x1869686D0", Slot = "15")]
		void ICollection.CopyTo(Array DKCMKELIAPN, int BAEBMIBABAE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> ALBBAMEMAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public readonly IReadOnlyList<Invention> HKADDKNIJBA;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
	public GJICMAANHOE(IReadOnlyDictionary<Guid, RoomObjectCounts> NDDJBIDELBB, IReadOnlyList<Invention> BJJLNFGNAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6967090", Offset = "0x6965C90", VA = "0x186967090")]
	public static GJICMAANHOE HKMEBBCGBBO(KDDAPCIFEMM ABJNEIDNHBL)
	{
		return default(GJICMAANHOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6968130", Offset = "0x6966D30", VA = "0x186968130")]
	[CompilerGenerated]
	internal static int LNEBHGICANB([In] IReadOnlyDictionary<long, int> NIBNHADHEMP, long? AIJEHKPBNKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6967A80", Offset = "0x6966680", VA = "0x186967A80")]
	[CompilerGenerated]
	internal static void JBJBIDKFCKD(int EMPBGBENFJD, [In] MABCOEEFHJO GPCIAGBDNLM, [In] Dictionary<long, int> NIBNHADHEMP, [In] Dictionary<Guid, RoomObjectCounts> NDDJBIDELBB)
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
