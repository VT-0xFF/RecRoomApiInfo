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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x690B650", Offset = "0x690A650", VA = "0x18690B650")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EOPCAILNDKD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> MDELENJHPEB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> JCJDCJNJMNC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> PLGJDHLBMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> CKMMMHOGDLL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string KIHICMEENGD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string CBBDOPLOPGK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string LJMLLHFKLGM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6906590", Offset = "0x6905590", VA = "0x186906590")]
	public static bool EDNBHJLJAOL(Guid EKCJLNPKCFN, int GNCCCGPLKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6906690", Offset = "0x6905690", VA = "0x186906690")]
	public static bool HHBMMNOOJBL(Guid EKCJLNPKCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6906720", Offset = "0x6905720", VA = "0x186906720")]
	public static string JPKEILCKEAC(Guid CNIMPJMOLDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[EIGNAIMHALL]
public enum FFBJGPANEFJ
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
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IEEKOHHPHFM
{
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid JPGPKNENJHP;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid EOODKCMHLMC;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid PMJGHKCJHCJ;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid LDCNEDGHBFD;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid LJHMGOCHLCO;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid GHIELMOGAMG;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid GNCJNEDOJNH;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid PHGCBMAPCBC;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid OPALEFFCIMP;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid IBKLIJDIHOD;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid CNNGHGLHGPJ;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid EFIEHNCGPOE;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid IFFMKLCNOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid FKHGLHACBIE;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid IDIPCJIOJMK;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid AMDOAHGOJPD;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid KHJCHOMDGKJ;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid ANHJMNKMDKI;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid GNLKCHBJMCP;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid FLPCMLKDLNF;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid LEEDEGAAMAM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid DICLMHBABJC;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid KDOEOJAEGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid HEIAPEJPNFL;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid OKIPFAHPBBJ;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid OECEGCEGDCI;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid OOHLAAKAOLK;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid BLEKNKEJBJG;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid GIMOPCNJNND;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid COKPGOAMFBP;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid PHMOCPBIAHD;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid FMDMJPGLEMI;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid FHLLPFFGMPE;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid CEINBBKPCOK;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid IALDJFPOEII;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid ADOPIEOKCDK;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid AEDIJJDIFBC;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid HLDEEIDNGKM;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid BKMOCGEBFLL;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid KFAOAHPIOHK;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid PBHNIMELDDK;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid DCLCBGBHFPB;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid EKGPLPMLDDO;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid IHBIBCCPDLP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid HAJOLLKJBMP;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid LAHHCFPDHBJ;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid GFDCIDFKHPF;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid FCFONMGKPDB;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid NJBFECPFJNO;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid KHMNLGFLFGN;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid ONKPIOMICBB;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid LLLLNECAIMI;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid MDDPJKHGFEH;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid HOEPFOCGKEL;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid IDLGAHHNKMO;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid JIFJKKKHMGM;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid LAELPGJAONA;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid LMBGNKNMNOL;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid DJEOLOKLKFE;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid GLGOALJJMJB;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid KMIHAOFNDEG;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid ALCMIHNKPNF;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid ACAKALOMMOF;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid KKLPIJLHGMI;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid CGOINJCPLOM;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MDGHCICMMFH;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid MOOLGIANHKN;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid AMPPKOGDALF;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid JCNLDNPEHBD;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid FOFKMMCBDGD;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid BIJAGNBOLAB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid DLAGBCMPMBG;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid OGEGMPEFIBB;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid OHIEGLFAMGC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid DANNHOOLHBP;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid EEMIPLEJAJP;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid MLLGCCNMAGL;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid APIJFKDDAPA;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid EALEIPOPJAO;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid DHNEFNPLCLB;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid ANCJOMCFBMJ;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid AIOEODCCCFE;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid JPNPJDKCGLJ;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid CPDKEGONELG;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid FDFAMPAFEPO;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MOGJAOGAFOD;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid KHMOKJFCBEE;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid IPOLOIBHNEP;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid FAKHIKPAMJO;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid PHABAJGMLAB;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid IGBLNCNNMGM;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid CDKNAEANLPB;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid OFBNEGCOMCL;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid CGOLIFLCLNG;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid GKKDJDFGKDC;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid LEHCOPJGIAB;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid JMJIFHKCLHN;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid FEHPCLBMAPO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid AEELPLHGEDP;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid ALEHJKECFNG;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid ELIMKJMBJAL;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid GCEFBFHBGJM;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid MDBCDJKGBJD;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid CADIKLIIKOA;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid LNOCAKAPLFF;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid IIFKKIELOFN;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid DPCPFLICGKH;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid HIHDIADEFMM;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid ICDEFIKAPNM;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid PPCDPKIPFLN;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid OJFALJJIBHM;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid PBNBFEACFFI;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid JJNFJDFNNGJ;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid PLPMHEMFCPM;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid PEPDIKJBEIB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid FNNJNJBAEJH;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid AGOOMBLFNHG;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid LNCCNIMPKLP;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid EKIMPECKCPO;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid KFJHFIGJKHC;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid LLOEBADNOFL;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid MJFLKEJJEFL;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid GHIPEPIGENM;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid NCJPKGKFCCL;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid KBCHACMFAGN;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid LLMLEGFMMHI;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid NEAGILIIAFK;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid CLFJJHEHCNJ;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid JBLBMOONKOK;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid ELDFFMFHIBG;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid ENINCPBOMCH;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid ELEBKBGPEGP;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid EAKKJLIMLCI;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid CDNCPNNOHNM;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid IJBIBNOKOIN;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid MKJJAAJLCHP;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid AFPAIGMOGEM;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid HDGMJGLGKIF;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid CJLIMGIIKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid LKINDEJFIIC;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid MIBEELHCHFM;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid LDAOEBJMNGD;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid CNACHHHCIHK;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid APENJKMJBGA;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid KHKIACDCGKJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid OJFDGKLEHFD;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid ANKLONMDNLD;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid CFFALNGFOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid FEOOHFPIIHM;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid IODDLHPEGGL;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid KBPDKKKMEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid ALJOPOLFDLL;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid KEGIHDPPGLP;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid GMNJALPHGED;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid PJDCGKEBFDK;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid CNGGJKKCBAN;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid HBANHMPALFP;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid LLGFLKPLFGE;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HEDHDLHLNJK;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid DFGPCFMOMDG;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid EGLCLJGFJBL;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid HABOJGICEAC;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid MKNNGCJKOJB;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid DGCOMLKELAI;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid MIBHKDIOOHN;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid MKALPMPHJCE;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid JCOGDEGPEFE;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid BEBIOFFNNEG;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid GELECDLOFNN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid LHFECLFMJIK;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid FKHIFGDFDAL;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MIEKCIMLDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid OHDBPJOOLOA;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid EIIDOIFJOEF;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FJOCEDECGNH;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid HLAKNMNICDD;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid GHHCMGLMHML;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid ACOGOAEKBMN;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid MHNGNEELHEJ;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid JFCLIBNNDPJ;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid KCCHJJNLAIK;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid NINEBGDEHNC;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid GNCMFGFKBMB;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid NGPHMAOFLFJ;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid AGNKCLAEDMD;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid GMNPHJGLKBE;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid CBBCFPMDEJF;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid NCPBDNPHDPO;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid MMHEAKCIHEL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid MDNFKOBGAHL;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid KDJAKGCLBCO;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid MJLGCLIGOOM;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid GNGHBPMCAIH;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid DNBAIPLPAKB;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid BABJEGHFLJF;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid GDIHGIBDFOO;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid MNJCHJJFFKF;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid ABCJJHIHHAA;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid ALPCLOJFIGB;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid GHHGHCGBNPF;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid IMMCEIMNBCA;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid CMDCGCEDCAO;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid BKPHMFFFNNF;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid JGPBCAOMHOA;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid FEBIBAOOKNH;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid MCOHAKIDBII;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid PNBFKAOAGGK;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FAGPILNLGBN;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid CICNJNFFDCA;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid MDCIGDHBIFC;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid DFFOOCDCLAG;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid CEDFHBBIJLJ;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid HNDAFADFLKM;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid PFDNJNBPNLP;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid NGNOAAIDMJA;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid AJPALPDILMK;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid FOEOAJLPIDI;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid EIOPNGCHMEK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid MNFALCKBJBL;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid DOANLOMIBEE;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DIDNFNOBABE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid EMMFPCPHHEN;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid JABJMMFPLDL;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid HBGPMGFDBNK;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid DDBAJHLNKCI;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid EGKJNLDFEBJ;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid JMCDHGNBIAP;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid ABCODLCFDAN;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid AMJHGHBDNLE;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid JNAGLFLMCIB;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid EJKGBNIIFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid JBDLPCNKEDM;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid HKJOAMBDGOE;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid HPGPANNHNID;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid DABNIGBGNAL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid NHMCKCJDCAM;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid FBOHMLMHAPE;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid PGMDEKLNCBA;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid LAPACFDIMMK;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid EKLBBEFGOGG;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid JNHAHMBDCPH;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid DALCGCEOCMP;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid IEHNDDNDPJJ;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid HPMCLDFNAPI;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid EJDJFMBNFBP;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid BOMMEFGDONO;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid ELHEFGOCLEG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid EJDKEALCJBK;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid JPAIAHCLOCB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid CBCBOGAHGNN;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid CEEOCJBEEEL;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid FABHEPCMOLF;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid KLCDCOHHJLH;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid GDBHNMOAECP;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid BCJIPBIKAEP;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid KPLIBPNIFFG;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid OHOFOPPDCOC;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid NEGBHPCKNOE;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HACOAFOMMKH;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid FNIKOJELCCG;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid PPJLAMGCICA;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid GLFMKKJMMEP;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid MHDFBBPDCEI;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid BHFMLFLCJBG;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid LBIKAHEHEMC;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid FLDLKJIHHCC;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid PFBGNEJOLAC;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid GPCMCNJKFKN;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid OILCAHDIABF;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid AAEOGNKKNKN;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid HBOJELMJKHD;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid MIHHOEMBJII;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid JLCPMMLLBOH;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid EHIAIDBMFKI;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MAKPMLNEHPE;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid CNOJJNOPFIB;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid PNBGCLJKFCG;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid NJGHCHDIDEK;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid MKGCMNFENLE;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid LOHKMDDIJKN;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid JGKFIPJLDNO;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid FDHFBIBMCFH;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid IHIDFLJOFGE;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid KHLCPPCBFJD;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid NOMAJANHMCC;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid BBHMDIBMINL;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid FAKBDMJNHNO;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid ICDKNHDKDPJ;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid INJHCNHBONG;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid HFGCNIDHDAJ;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid JJDEJGHHMIO;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid LAPMKOEJJID;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid CABMMKLLGHM;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid KOJEJDAOLLD;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid AOCKFGFBMGE;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid BNLMJHPDHLJ;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid HELIBBNDBHM;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid JPGMPAIFPON;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid MJHLFDFGPCJ;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid ACMFABEAFJL;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid LCJGKEOPHOA;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid OCLOAIHBGEF;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid AIBPLPAPELJ;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid CBILIKPMNBH;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid OMOJIEDKHKP;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid EIBCOFFAMJD;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid NNBOKHADLDC;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid OECKEHIGGHB;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid LHKLHIOEMJC;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid AMOFGAMCIIG;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid BFJLNFPFPEL;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid OIOBOFINPJK;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid CIJIEGNLOBO;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid LPDBNNLBGMH;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid HIGOCCKMKEI;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid IMIOLDPMCBI;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid BENECMJCMGB;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid ECAOKOKJKCO;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid MLDFLICLHFG;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid EBPENAOFMKM;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid HNNFJEPKIIP;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid JPGGHIGGGKM;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid JIFHFCGOPED;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid GPAEGCIDLHI;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid CGJJEKGHEMB;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JIFAFKCIOEN;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid HLICOPJPOMK;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid OIGBPILLMJJ;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid AJEGJBECKPA;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid BDOBHAEBKNM;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid KKBGINKBBGD;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid BGDGEJFPOEF;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid KJEBKPIAOOM;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid EOFAAFKCIEL;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid FOFAMIMECDH;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid OCHLMLNELMA;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid NLPFMGIAPOD;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid DMKJPMAMKBF;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid MMPFJAOALDP;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid CEEIPFELMGI;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid GDHMDIEEEMP;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid JPNAHLGOGPI;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid BHMAOBMEKNI;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid OKCGLFKGLMK;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid HEJLDCBLNJH;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid GIGPHLCMBFL;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid FPHEGOMANGH;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid CENDCOIDGEK;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid FHOIPEMFBOL;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid HFIGEHGHAKM;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid HGDKJNBNKKL;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid BHJNNCCECHI;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid LIPAJHEAOPG;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid KHFOEKAEJJD;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid DNNIICFNKIF;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid GKOINAENHAO;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid ADDJJPKKLGO;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid OGMCAFDCKKN;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OOHEHBOKEEP;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid JMHECKECPPJ;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid CNLIDIOMIEP;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid INMLFHBDHND;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid OGIPAPKIJEA;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid IADIDJMPCND;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid BDEOADKDCHI;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid BGGDINKLKLF;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid MDIEGDJGHAI;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid OAGPBOPOMFA;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid GFGIPGJHNJI;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid LPMCKIBBFPC;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid HNNJOJEONIG;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid JMAIDBCJEOG;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid DNCBFCBMDBH;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid KOPPEKNIOOG;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid DPOFMLIDIMG;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid PGACACMIPOC;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid IOELKAABLNL;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid IJDAHNCDOIK;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid EJNIGNFEJEK;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid GJIGPOPPEEK;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid GPKPLLMAHFF;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid EFFONGGLHBK;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid BFKBGMEBMCN;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid IAJLPFNDHGP;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid EFPKNNBGGCD;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid BBGNEOIGHDL;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid IHOIDCKJBLG;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid NFCMOGPFCAH;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid AAOALDMNGJE;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid FLDIFADCBBN;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid GKFCOALMPAJ;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid CBOFBOPELCN;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid OLLMDDLDBOO;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid IPEGDKEMLOK;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid FBANPIJNAJD;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid GECPDBNIDIK;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid MJNMOKEAPJE;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid PPFPEHLLDFP;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid FJGLPOJDNDN;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid AGDEPIPNPEK;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid NGANMBDAIMC;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid IADGKBOPDCL;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid CNKPKHPHCNE;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid AFBOPLIBLBB;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid OGNKPNNPMHK;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid JGHNACHKPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid ONAEBIKGMHH;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid APIGFMMPJMD;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid MEFHMFLKMJK;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid FIKJDENGLPP;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid IKDPANOBHDO;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid KGCOPOGHDMJ;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid BBNCFGNIFGF;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid GGPAJNEOAON;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid LGNCPADDAKE;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid MOEGGOFBDMP;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid DKGAHJMMIPI;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid HCBIBBGNBAL;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid FMCNCDLPABK;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid KLDBMPJHFPM;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid OAMAJIFNCPE;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid OKFOMFMAIID;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid KAKKGAIEIFM;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid ICEAPHHOMHM;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid KEDLAPNDEME;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid CGBNJDGLHMG;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid ENOAHMFGBMK;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid GIAIGOFKIFP;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid MOAEBPBKFCG;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid ONPAOOGKDJH;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid HKDKMKEMNPF;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid OHEDHPOOGAH;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid CMCNLPAJDAL;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid COGOJMALLKP;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid MMGCEGAFKGE;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid DELCIOOIPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid PBIKJAFKEFP;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid JNICBNOAJEI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid JHMKLABNEKJ;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid AGEBDLFKEII;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid HAMOBNEDMIA;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid OOPOLFGBNIA;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid DMAJMGABGCD;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid OGOOGLAMDEP;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid FNGCMHJLOCP;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid GKDEKCKFAOD;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid FHDIEIGIFCJ;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PIEONHHFPCG;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid MKNFMPMBIGN;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid GFGNJPOMAPF;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid IAMHGBPHFKJ;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid JPABLPHJEOO;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid HACHBDBBJDB;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid BDEBEMIAHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid HLLLDAIMIHB;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid HAFJCGHLNNE;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid OCDNBHMBJEK;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid PMKGAJBLPCK;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid GLJMNNBEJFC;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid HHJLDPONHHF;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid JDDGFPANHLN;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid LLLIGNIGPKL;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid DGNKHBLAKCP;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid PAKEOPBDAHG;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid OLAIGPNLKHJ;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid PBBMDPHLPPL;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid NFIHFCBJCPB;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid BNMNOGHIFIL;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid OABPFJMJIMP;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid AEKLPEMCOLN;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid MOCNOIFICIA;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid DKKIAKJPCCD;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid IPJMFMGOODF;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid HBIDCLLCEID;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid IHPAIFIICBA;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid GPPKHIKIINL;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid AMMEPLOMPLG;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid KAFBGHGADBI;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid PLELHPEFLNE;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid PFFKHEEJECE;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid PLJNKOHGGNM;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HCJECLJAPKB;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid OBEDOJGOOGP;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid HAAGHFEEPGH;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid HPBGHOJPDLI;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid HLEJNAHGEJO;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid ALBGEOJEPIF;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid MAEOCBEDAOL;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid HBHHHFEHCAP;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid NEDPGMOMIPH;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid EBHPGGBILBP;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid HGIOCKFNPJB;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid DKDNMGFJPGG;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid PNENCBFIFHN;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid LLPEGMNMNDD;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid LHLLEIEJNIM;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid HMHGACFHFNF;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid CEKHLNACEPB;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid FELONECPNPD;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid IPKLJFECHPC;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MPHFNNLNOAC;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid AENIAMMHHKE;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid FGCGFIKLDPP;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid OAIPMNNHFIC;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid EOKPPBHPGOK;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid BPPDNMBDBHC;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid KFHEAOGAJEO;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid CCBBMHKFMGH;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FCKFFFMLPPM;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid AAGCEMMOCAC;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid OALNBJDFEPH;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid MJPIFCPGAIH;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid OAJMLCENMCI;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid JAGFENHOABM;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid CKODNDFDEDF;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid EKPNAPOEGHD;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid GOAOKNFHAPA;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid NFKLAJFGBJB;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid OMNBILBJMAD;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid GBIPHLGLAGO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid JJMHGBPNIME;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid BKMOGLHJPGB;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid PGPNHBIFNEA;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid OIOFGHEDGKI;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid NCMPBPIHNEE;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid JNKGADNDIBI;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid CPHAACMGCCN;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid FNOEDPIFHIK;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid NNEODPGJKGP;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid LFAAJPIBHEL;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid JGNFCDHGOBN;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid GKBLNIKFKJF;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid OCENHKCLPKG;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid BKDFMANNKEG;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid EFADKAFIHBC;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid NNDGBHPEDKF;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid ALBBEFHFMOC;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid JDAPEODCPCG;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid NBNOHNEEFNC;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid JCEKMPFLAEP;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid EPIOIGKKAGO;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid MNNBNCPKMPG;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid HJOFLCPHPLJ;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid FEHMIPOGNIK;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid NECJOPPAOBF;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid FNHMFJGJHPO;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid MHLKFMADJBF;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid MDNILHEKGCG;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid PIIBHHHMCGK;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid LHPMNKBNMLN;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid OMGHOJDFBCP;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid AOKCLAGKLAA;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid EFNBOFHHKPL;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid ACIFOOGPPGM;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid BPOCABMMODE;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid IONHDHJGOJJ;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid MJBIFIJAEGM;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid BFOBBBGHGIK;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid LKJJDMJCHHK;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid KJCCPEPHJCE;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid JGFMFEPJBCO;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid CBPBMDMCKMH;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid FGGILGGJODM;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid NEPEIAJBPLE;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid DKELDGJLGMD;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid KIAJCACLJBN;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid EKKKBOFPOKB;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid IPOBPMHFBDN;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid GNFIJFILHFN;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid KKPDCBDFFOE;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid AIOMCHJPHMG;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid AEIGCIHJEKK;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid BMALJDEPGID;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid NEEBFHNFKGD;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid MJPBADLJGEA;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid LEBIBNEGEMJ;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid KMPHGCFFAKJ;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid DOPMDBKLOJK;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid NAHDCPOJEHI;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid NDLKLHOLCKL;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid LNIKOPCIDHB;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid NEIPCFLPDON;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid GBLLKJDGBIG;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid NJMAAEHFAKM;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid OIAIMIGLDCN;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid LIOGKNECIKN;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid BIJAIOIJHBG;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid LOCJBFELBEC;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid PBICAIGLMED;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid JKCKJMOCFPK;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid OPNCHBKPCDL;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid LJAKJNHFKDA;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid CCEJNDHBGCE;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid AFBCELJOKOJ;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid IIJDGAGEOAP;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid FIAFKAELDNA;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid LMDMFJMCNEG;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid KLBGMKMEAGH;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid CJGBIFIMEHM;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid IJANJKIOAHB;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid ANGMLKFEDOD;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid FOANNDIBJCB;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid LENAFCLADPG;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid CEEKMFGKEGF;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid BMNDAGKCPPD;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid LPPILEIACAE;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid DHJGOHMGEOA;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid LNIECFNOHAB;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid FBGOKGPJEDO;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid BBBIFPOGINN;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid EIIBKOBOEAK;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid FAJHKOPKJEG;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid DPFEOCJKLIE;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid BLHAHMHJELL;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid PFMCFBLPCPB;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid PEJFALHFNCF;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid OIBDAOHCJDL;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid NKCHJCIGPBB;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid MFMKIKKCFBB;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid AACILLJNOBN;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid BMJPICHCNAO;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid NDIENBODFFD;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid KGONLNKOIEH;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid MGPICDMMHBB;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid FHKEFNNEOCL;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<Guid, FFBJGPANEFJ> HPDFNJFCNGK;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	private static readonly Dictionary<FFBJGPANEFJ, Guid> JLKFFMCPIKM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, FFBJGPANEFJ> LMNBIKHFDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6908160", Offset = "0x6907160", VA = "0x186908160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<FFBJGPANEFJ, Guid> LCPNFIKGFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6908100", Offset = "0x6907100", VA = "0x186908100")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DNCDBCKBJMG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69061B0", Offset = "0x69051B0", VA = "0x1869061B0")]
	public static bool KBBCMPFPEJO(GFHKPFCGMEC HNGLMOBDENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69061E0", Offset = "0x69051E0", VA = "0x1869061E0")]
	private static bool KBBCMPFPEJO(MBHEBJKPDFI CBKMIAOMAIC, GFHKPFCGMEC HNGLMOBDENA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HNKMFFHHCEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly OIBAKLEHGAH MICAJDMIPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IEnumerable<ENFIPLJHHAN> LPFHCOKPPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly IReadOnlyList<ENFIPLJHHAN> IBMFFKDFEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly BGKDPCAKPBJ<EHIJHEMDKLF> ILBMHIHMOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<MFLENLEMIJF<PMIFAKHBGDE>> EIBOMEKAIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly ByteString DLEFALLFBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IPJBDCHEGJH LKNBOGBNPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly bool DBINCADAJKJ;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6908050", Offset = "0x6907050", VA = "0x186908050")]
	public HNKMFFHHCEP(OIBAKLEHGAH FKOJJJBKLON, IEnumerable<ENFIPLJHHAN> BJFDPEFNNCL, IReadOnlyList<ENFIPLJHHAN> LCCJOOKMKAL, BGKDPCAKPBJ<EHIJHEMDKLF> NFAGKHAOKNB, IReadOnlyList<MFLENLEMIJF<PMIFAKHBGDE>> NEADOOAGBFD, ByteString NMKBKBFPCDP, IPJBDCHEGJH PCFGGPLJIPA, bool LBJDBPKDELK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MJPLKOAONMN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(EJPKKNBHNPI AHGAPHMJDIB, [Out] Dictionary<int, int> EKEOPFHKILC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(EBLAFNHPHNO KOEONKKLPMH, AJCOPDOCOFI CEJPBNENJPH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AGJPFLOMAGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly Guid MKEFNPJAPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private readonly Dictionary<Guid, Guid> NEPOHDLEAEO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> FPLGPNHCLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3981C80", Offset = "0x3980C80", VA = "0x183981C80")]
	private AGJPFLOMAGI([In] Guid PCLHDOKLKHE, Dictionary<Guid, Guid> IBDBMAFNABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68F1860", Offset = "0x68F0860", VA = "0x1868F1860")]
	public static AGJPFLOMAGI BJGNCIAAOOG(IReadOnlyDictionary<Guid, Guid> DBEDOPJHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68F1AA0", Offset = "0x68F0AA0", VA = "0x1868F1AA0")]
	public static AGJPFLOMAGI PGJIFOKHODJ(IEnumerable<KeyValuePair<Guid, Guid>> DBEDOPJHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68F1980", Offset = "0x68F0980", VA = "0x1868F1980")]
	private static Dictionary<Guid, Guid> COEBCGMIKCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68F1870", Offset = "0x68F0870", VA = "0x1868F1870")]
	public Guid CDNAFFKMGMK([In] Guid CNIMPJMOLDJ, bool DDGDAKKIKLG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68F1A30", Offset = "0x68F0A30", VA = "0x1868F1A30")]
	public bool LPJKPFDEMFJ([In] Guid KHLDDJPHOBA, [Out] Guid DEMMALNFLIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GAIGKLJBAII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MALNNBLLMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPFECFLIGJE(ByteString ADBDMGOLEGN, AGJPFLOMAGI LFCLHKOGAKM, [In] UniformTRS KNNGMLNLCGM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FMPNMGGELPP
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
public class ICDMNOEONPP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x15E8280", Offset = "0x15E7280", VA = "0x1815E8280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PEGNBOGMEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1117520", Offset = "0x1116520", VA = "0x181117520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long MILBGAMLCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69080E0", Offset = "0x69070E0", VA = "0x1869080E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x65FBDD0", Offset = "0x65FADD0", VA = "0x1865FBDD0")]
	public ICDMNOEONPP(long DOPPKGNLPAC, long LMPNAODGJHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BCPBKEBEEBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private Dictionary<Guid, ICDMNOEONPP> NMLMDBALFOK;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static Dictionary<Guid, int> HBMCFOOEPAK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long CHDMBFCDHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1117520", Offset = "0x1116520", VA = "0x181117520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long GKABKHJENGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1171890", Offset = "0x1170890", VA = "0x181171890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68F2120", Offset = "0x68F1120", VA = "0x1868F2120")]
	public static BCPBKEBEEBH LICDDPDPMPJ(OIBAKLEHGAH AKCHBKJDFOA, MFLENLEMIJF<EHIJHEMDKLF> ODBEKCINNML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68F1E50", Offset = "0x68F0E50", VA = "0x1868F1E50")]
	private void BFCOFCLBGOL(BHHANIGFAMG OHDOOCGHDGN, long KCCCBMJBIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6906120", Offset = "0x6905120", VA = "0x186906120")]
	public BCPBKEBEEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LKGIMEDKBKF
{
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly HashSet<FFBJGPANEFJ> ADBBLOOBFBC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NOKPOLHKDFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> DGKAAKJIMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> OBFBFPDMIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x857060", Offset = "0x856060", VA = "0x180857060")]
	public NOKPOLHKDFA(IReadOnlyDictionary<Guid, Guid> DBDBKNDPGBK, IReadOnlyDictionary<Guid, Guid> IICMNCEBODK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OAIBJAFHPFM
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x690D2A0", Offset = "0x690C2A0", VA = "0x18690D2A0")]
	public static FHJOLDGFPKF GGIELAJGNKP([In] HNKMFFHHCEP AGOECJPFNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x690DD50", Offset = "0x690CD50", VA = "0x18690DD50")]
	private static void LBPEMIHAFGD(FHJOLDGFPKF NEMNEONNMFG, [In] HNKMFFHHCEP MJFMJLGICBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x690BA70", Offset = "0x690AA70", VA = "0x18690BA70")]
	public static DFAHBLOKBPH<NOKPOLHKDFA, FMPHIFOKFEL> ECNKBNOOFGO(FHJOLDGFPKF NEMNEONNMFG, OIIDAFACJNH NBNDPDNLFEJ, AGJPFLOMAGI? BDBFPLFKFMK)
	{
		return default(DFAHBLOKBPH<NOKPOLHKDFA, FMPHIFOKFEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x690D420", Offset = "0x690C420", VA = "0x18690D420")]
	private static void HFOBCCDMEFL(FHJOLDGFPKF NEMNEONNMFG, AGJPFLOMAGI? FIIICKHELNP, OIIDAFACJNH NBNDPDNLFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x690BA00", Offset = "0x690AA00", VA = "0x18690BA00")]
	private static void CPNFELGHFBL(FHJOLDGFPKF NEMNEONNMFG, OIIDAFACJNH NBNDPDNLFEJ, IReadOnlyCollection<ByteString>? OKBBDLOGKOA, IReadOnlyCollection<ByteString>? AJIGIMAAIPA, IReadOnlyCollection<ByteString>? JAJDAHMPPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x690D6C0", Offset = "0x690C6C0", VA = "0x18690D6C0")]
	private static bool HGBLHFAPJIK(FHJOLDGFPKF NEMNEONNMFG, EBLAFNHPHNO KOEONKKLPMH, OIIDAFACJNH NBNDPDNLFEJ, [Out][NotNullWhen(false)] string? EHELKEOJPOO, [Out] Dictionary<int, int> EKEOPFHKILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x690E860", Offset = "0x690D860", VA = "0x18690E860")]
	private static Dictionary<Guid, MBHEBJKPDFI> PPLDFKPAIEA(FHJOLDGFPKF NEMNEONNMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x690B960", Offset = "0x690A960", VA = "0x18690B960")]
	private static void BGJLFNNCFLC(bool KDMNABFPADL, ENFIPLJHHAN HNOBJNPONNI, Dictionary<Guid, Guid> OONPEIBDMHD, AGJPFLOMAGI IGJCGGACAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x690B6D0", Offset = "0x690A6D0", VA = "0x18690B6D0")]
	private static void AIBEOGENPCK(ENFIPLJHHAN HNOBJNPONNI, Guid AGPHHBGKIJC, NHIGKLMJACG? MDNPKMNOPJB, Dictionary<Guid, MBHEBJKPDFI> EFBKECGMEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x690E3B0", Offset = "0x690D3B0", VA = "0x18690E3B0")]
	private static void OMOBICPAFLO(IEnumerable<ENFIPLJHHAN> CNDOCCMEKEN, IReadOnlyCollection<ByteString> OKBBDLOGKOA, IReadOnlyCollection<ByteString> AJIGIMAAIPA, IReadOnlyCollection<ByteString> JAJDAHMPPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OIIDAFACJNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public bool KDMNABFPADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public IPJBDCHEGJH PCFGGPLJIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public NHIGKLMJACG? MDNPKMNOPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public NHIGKLMJACG? LDMGEPLEELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public OIBAKLEHGAH EBFDHIMEBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public FMPNMGGELPP FCOHPEPMFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public MJPLKOAONMN BOHHBNPCPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public GAIGKLJBAII HALFJOADDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public MFLENLEMIJF<EHIJHEMDKLF> CHBEBDKJCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public GCFIMNCAKMI NLIMCOBIINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public List<ENFIPLJHHAN> IFOFNCFPPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public Dictionary<string, object> PGJKEEKFNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public PDMGKOHPGGE DFBKJKHBCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public bool LKPBIFOOIPB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool BDBKHBOFAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x690EB40", Offset = "0x690DB40", VA = "0x18690EB40")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NHIGKLMJACG
{
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private const float DJIECMMMJEF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Vector3 LLLHNMGEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public Quaternion BCKIPOGEHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public float FHBDGLOPEKN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 DBAGCPNLCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x690AE80", Offset = "0x6909E80", VA = "0x18690AE80")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS GGGMEAHDHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x690B4B0", Offset = "0x690A4B0", VA = "0x18690B4B0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xC26F70", Offset = "0xC25F70", VA = "0x180C26F70")]
	public NHIGKLMJACG(Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, float FHBDGLOPEKN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x690B580", Offset = "0x690A580", VA = "0x18690B580")]
	public NHIGKLMJACG(UniformTRS OEGKMJCGFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x690AF90", Offset = "0x6909F90", VA = "0x18690AF90")]
	public static NHIGKLMJACG DGICCCINIEI(NHIGKLMJACG EMOKCJBMKOL, NHIGKLMJACG FGPNIBFJHLD)
	{
		return default(NHIGKLMJACG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x690B390", Offset = "0x690A390", VA = "0x18690B390")]
	public static NHIGKLMJACG GCCHPLCKKEJ((Vector3, Quaternion, float) AHGAPHMJDIB)
	{
		return default(NHIGKLMJACG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x690B210", Offset = "0x690A210", VA = "0x18690B210")]
	public static NHIGKLMJACG GCCHPLCKKEJ(Matrix4x4 PPOLMMJLLAG)
	{
		return default(NHIGKLMJACG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x690B4F0", Offset = "0x690A4F0", VA = "0x18690B4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x690AC50", Offset = "0x6909C50", VA = "0x18690AC50")]
	public NHIGKLMJACG CDAEOCFADGB(Matrix4x4 DBCCBLKNBHK)
	{
		return default(NHIGKLMJACG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x690B440", Offset = "0x690A440", VA = "0x18690B440")]
	public static NHIGKLMJACG KNOLJHFIENG(Vector3 LLLHNMGEKPM)
	{
		return default(NHIGKLMJACG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x690B3B0", Offset = "0x690A3B0", VA = "0x18690B3B0")]
	public readonly OHGCEAGLHOO KCHHOHIGHHL()
	{
		return default(OHGCEAGLHOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LLGLOEOMIKD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69083D0", Offset = "0x69073D0", VA = "0x1869083D0")]
	public static NHIGKLMJACG EFEPFNBHHJE([In] this OHGCEAGLHOO KALCJEIICGB)
	{
		return default(NHIGKLMJACG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum EKIPENEBDBO
{
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct FMPHIFOKFEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly MALGJKKBKBE LKJKDCPLELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private readonly GFEHMFEELCO DOOPMBKNLGH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xEB7C80", Offset = "0xEB6C80", VA = "0x180EB7C80")]
	private FMPHIFOKFEL(MALGJKKBKBE GKANCDPDLNF, GFEHMFEELCO MNGDIOODEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6907FE0", Offset = "0x6906FE0", VA = "0x186907FE0")]
	public NMADAPLGOEB LHGOPLCACLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6907DC0", Offset = "0x6906DC0", VA = "0x186907DC0")]
	public static DFAHBLOKBPH<NOKPOLHKDFA, FMPHIFOKFEL> GAKCNKPJGEK(PLMMBNNPNKC<OKOMLKNINNF> MNGDIOODEJO)
	{
		return default(DFAHBLOKBPH<NOKPOLHKDFA, FMPHIFOKFEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6907F30", Offset = "0x6906F30", VA = "0x186907F30")]
	public static DFAHBLOKBPH<NOKPOLHKDFA, FMPHIFOKFEL> GAKCNKPJGEK(NMADAPLGOEB MNGDIOODEJO)
	{
		return default(DFAHBLOKBPH<NOKPOLHKDFA, FMPHIFOKFEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6907E70", Offset = "0x6906E70", VA = "0x186907E70")]
	public static DFAHBLOKBPH<NOKPOLHKDFA, FMPHIFOKFEL> GAKCNKPJGEK(string EEGEKMNABDC)
	{
		return default(DFAHBLOKBPH<NOKPOLHKDFA, FMPHIFOKFEL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MALGJKKBKBE
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MOLLAHOGAMO : IDisposable, MBKEEDMJKDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private NativeList<LIICCIDLFKB> CNEKFNPKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private float INLKDHBGOLG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PFHLCPEJGHL IBHIGOCPEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0")]
		[CompilerGenerated]
		get
		{
			return default(PFHLCPEJGHL);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x854620", Offset = "0x853620", VA = "0x180854620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BMNLNOFKDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69085B0", Offset = "0x69075B0", VA = "0x1869085B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool OFFLHGMCKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69085A0", Offset = "0x69075A0", VA = "0x1869085A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<JNFAPMAHDOB> ONODJAPIGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HBJDGHHBHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x69093B0", Offset = "0x69083B0", VA = "0x1869093B0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float PEBDGCKAPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x690A7A0", Offset = "0x69097A0", VA = "0x18690A7A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x690ABC0", Offset = "0x6909BC0", VA = "0x18690ABC0")]
	public MOLLAHOGAMO(PFHLCPEJGHL MOMOANKHLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6908EB0", Offset = "0x6907EB0", VA = "0x186908EB0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x690A2D0", Offset = "0x69092D0", VA = "0x18690A2D0")]
	public Vector3 MAGAAKCJDBH(int NHKHFGOJKIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69084D0", Offset = "0x69074D0", VA = "0x1869084D0", Slot = "6")]
	public Quaternion CBJKDPIHILE(int NHKHFGOJKIK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6909540", Offset = "0x6908540", VA = "0x186909540", Slot = "5")]
	public Vector3 FIAIPFENMDE(int NHKHFGOJKIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6909740", Offset = "0x6908740", VA = "0x186909740", Slot = "7")]
	public float HGINOKOOINF(int NHKHFGOJKIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69085C0", Offset = "0x69075C0", VA = "0x1869085C0")]
	public void DOHGIJIEHLF(Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, float EGNBICILIGE, bool AGHBJEEJFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x690A8E0", Offset = "0x69098E0", VA = "0x18690A8E0")]
	private bool MNFMIJLGLNG(int EJMHAKPANEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69095E0", Offset = "0x69085E0", VA = "0x1869095E0")]
	public void GJDHLDANNEO(Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, float EGNBICILIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x690A240", Offset = "0x6909240", VA = "0x18690A240")]
	public void KDGLFCJJCHD(int EJMHAKPANEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x690A0F0", Offset = "0x69090F0", VA = "0x18690A0F0")]
	public void JGELBKBGBEA(int EJMHAKPANEH, Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, float EGNBICILIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x690A940", Offset = "0x6909940", VA = "0x18690A940")]
	public void OHLONPJNHLC(int EJMHAKPANEH, float3 LLLHNMGEKPM, quaternion BCKIPOGEHOJ, float EGNBICILIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69093F0", Offset = "0x69083F0", VA = "0x1869093F0")]
	public void FABGHMABJHG(int EJMHAKPANEH, Vector3 LLLHNMGEKPM, float EGNBICILIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69097A0", Offset = "0x69087A0", VA = "0x1869097A0")]
	public void HICIIHEOGCK(int EJMHAKPANEH, Vector3 NJOPFIOMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6909900", Offset = "0x6908900", VA = "0x186909900")]
	public static Quaternion JBGEONMHOGP(Quaternion BDNMFDAFNND, int EJMHAKPANEH, float CGHMDIIKGGP, MBKEEDMJKDP BFPNPBNCKHL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6908F10", Offset = "0x6907F10", VA = "0x186908F10")]
	public Bounds EEGHGLMKOFD(Transform DBCCBLKNBHK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6908460", Offset = "0x6907460", VA = "0x186908460", Slot = "10")]
	public virtual void BJLNKEFFJPA(bool BIKJAOGAKFJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x690AAF0", Offset = "0x6909AF0", VA = "0x18690AAF0")]
	public NativeList<LIICCIDLFKB> POFJCLPALJI(float HAHPJFLGAHC = 1f)
	{
		return default(NativeList<LIICCIDLFKB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JNFAPMAHDOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public float3 ANCEDMGEKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public float IGMBIEBACMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public quaternion NIHNPPDKAPA;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6912AA0", Offset = "0x6911AA0", VA = "0x186912AA0")]
	public JNFAPMAHDOB(Vector3 NPKPBDEJFNH, Quaternion BDNMFDAFNND, float EGNBICILIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x69129E0", Offset = "0x69119E0", VA = "0x1869129E0")]
	public Quaternion MCGPDFCOJKG(Vector3 DJAIHLPIJBH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6912530", Offset = "0x6911530", VA = "0x186912530")]
	public JNFAPMAHDOB GIEKHFBFFFA(Vector3 LNHCLPDFOPF, Vector3 EEGMEEBHJFK, Vector3 HBDLCBKCBOE)
	{
		return default(JNFAPMAHDOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6912830", Offset = "0x6911830", VA = "0x186912830")]
	public DNELOMHMILK LNOKEJCLLPI(Vector3 DJAIHLPIJBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class NLKJGHCLIPM : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6913A70", Offset = "0x6912A70", VA = "0x186913A70", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6913220", Offset = "0x6912220", VA = "0x186913220")]
	private void BEAEFKJCMIE(Dictionary<Guid, Guid> KKHANIMHEGO, DKIAIENHMAO PMBEAMPEMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69131C0", Offset = "0x69121C0", VA = "0x1869131C0")]
	private void BEAEFKJCMIE(Dictionary<Guid, Guid> KKHANIMHEGO, NBLBPPGPNJA FKDAGFACACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69137F0", Offset = "0x69127F0", VA = "0x1869137F0")]
	private void BEAEFKJCMIE(Dictionary<Guid, Guid> KKHANIMHEGO, ANOPMNIIEOC MGIJGGOGEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public NLKJGHCLIPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class FBKLMGOCGAH : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6910180", Offset = "0x690F180", VA = "0x186910180", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public FBKLMGOCGAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class LCGIAMDKNDH : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6912BD0", Offset = "0x6911BD0", VA = "0x186912BD0", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public LCGIAMDKNDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class EKGGGLGEFOG : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6910030", Offset = "0x690F030", VA = "0x186910030", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public EKGGGLGEFOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class CJHKKAOGKFL : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x690EC40", Offset = "0x690DC40", VA = "0x18690EC40", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public CJHKKAOGKFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class JKAMCELPIEJ : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69123F0", Offset = "0x69113F0", VA = "0x1869123F0", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public JKAMCELPIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class FDFDPIMFNIN : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6910230", Offset = "0x690F230", VA = "0x186910230", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public FDFDPIMFNIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NBMGGJKAFNP : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x69130D0", Offset = "0x69120D0", VA = "0x1869130D0", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public NBMGGJKAFNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LJAIBDLCBFE : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6912D30", Offset = "0x6911D30", VA = "0x186912D30", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public LJAIBDLCBFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IIHPPFANBLE : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6911800", Offset = "0x6910800", VA = "0x186911800", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public IIHPPFANBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class IOCBPHFJHCF : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69119C0", Offset = "0x69109C0", VA = "0x1869119C0", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public IOCBPHFJHCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GMEALFJKDIC : GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public static readonly EHBFANEILIB LFHOLEJFCKM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6911530", Offset = "0x6910530", VA = "0x186911530", Slot = "4")]
	public void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public GMEALFJKDIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct GFHKPFCGMEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public EBLAFNHPHNO FFOAGBHJNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public LKBFGJGBJEC FBLAICJBBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public Dictionary<int, int> GEBLBEAEHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public Dictionary<Guid, Guid> NDJHMBANBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public PDMGKOHPGGE DFBKJKHBCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public bool LNEOHCELBPF;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GIDEIEMJJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMDBFIALIMM(JOEEKDMHBAA HHEJFPAFAJA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GFAKGBGDFEE
{
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private static readonly GIDEIEMJJDK[] PCHNHACDNKH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6910660", Offset = "0x690F660", VA = "0x186910660")]
	public static void FDMNAOEBJJG(ENFIPLJHHAN AHGAPHMJDIB, Dictionary<Guid, Guid> CBADDIBJCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69103D0", Offset = "0x690F3D0", VA = "0x1869103D0")]
	public static void DCNPMBIMDIH(ENFIPLJHHAN? AHGAPHMJDIB, AGJPFLOMAGI LDPLOJEFLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x69108F0", Offset = "0x690F8F0", VA = "0x1869108F0")]
	public static void IAIGNBFIJHJ(ENFIPLJHHAN? AHGAPHMJDIB, AGJPFLOMAGI IGJCGGACAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6910B70", Offset = "0x690FB70", VA = "0x186910B70")]
	public static void KBBCMPFPEJO(JOEEKDMHBAA HHEJFPAFAJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct JOEEKDMHBAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public EBLAFNHPHNO EIAJNMFDCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public ENFIPLJHHAN HNOBJNPONNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<int, int> GEBLBEAEHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public Dictionary<Guid, Guid> NDJHMBANBKF;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6912B20", Offset = "0x6911B20", VA = "0x186912B20")]
	public Guid HMPFMNKMADN(Guid CNIMPJMOLDJ)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PDMGKOHPGGE
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BJDEGAHEFFB, [Out] Guid MADOBFEMEEI);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class ODEJHGLDADF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private readonly HashSet<string> KDICNPCHHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private readonly Dictionary<long, int> PGLICIOMNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private readonly HashSet<Guid> CAOBFKPFCNH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<string> GMKDJINHJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyDictionary<long, int> MEACIEACGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6913AF0", Offset = "0x6912AF0", VA = "0x186913AF0")]
	public static ODEJHGLDADF DNAAPKIEDCJ(KECMDPPEFHG KBAPBJOHBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6913B60", Offset = "0x6912B60", VA = "0x186913B60")]
	public static ODEJHGLDADF DPLFNAFCBKB(FHJOLDGFPKF JNHDEIIJKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6913BD0", Offset = "0x6912BD0", VA = "0x186913BD0")]
	public static ODEJHGLDADF FBBPMFCMPMG(IEnumerable<string> KDICNPCHHIO, IDictionary<long, int> CDKAOPEBJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6914DA0", Offset = "0x6913DA0", VA = "0x186914DA0")]
	private ODEJHGLDADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6914C60", Offset = "0x6913C60", VA = "0x186914C60")]
	private ODEJHGLDADF(IEnumerable<string> KDICNPCHHIO, IDictionary<long, int> CDKAOPEBJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6914250", Offset = "0x6913250", VA = "0x186914250")]
	private void GOOFACMDKLA(KECMDPPEFHG KBAPBJOHBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6914440", Offset = "0x6913440", VA = "0x186914440")]
	private void GOOFACMDKLA(FHJOLDGFPKF JNHDEIIJKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6913F20", Offset = "0x6912F20", VA = "0x186913F20")]
	private void GOOFACMDKLA(MFPHCOJFMLN? JMCFDCHCIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6913D50", Offset = "0x6912D50", VA = "0x186913D50")]
	private void GOOFACMDKLA(LFFAJIBKBJA? OHDOOCGHDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6914630", Offset = "0x6913630", VA = "0x186914630")]
	private void GOOFACMDKLA(ENFIPLJHHAN? HNOBJNPONNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6914BF0", Offset = "0x6913BF0", VA = "0x186914BF0")]
	private void NKIGGJINNNB(string? DKKNGADBEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6914A20", Offset = "0x6913A20", VA = "0x186914A20")]
	private void NHPMEKLCHNP(HBHGJDNFBOB? LNINDMHJJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6914B00", Offset = "0x6913B00", VA = "0x186914B00")]
	private void NHPMEKLCHNP(HKIFGCBCKEE? LNINDMHJJOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct DLIJFKHNKAL
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class OJINMCAOPML : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly IEnumerator<DictionaryEntry> FONGOFJDDJB;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DictionaryEntry GFCDGOEFJFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6915040", Offset = "0x6914040", VA = "0x186915040", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6915110", Offset = "0x6914110", VA = "0x186915110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object JMEAFIDIDGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x69151C0", Offset = "0x69141C0", VA = "0x1869151C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6914F60", Offset = "0x6913F60", VA = "0x186914F60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
		public OJINMCAOPML(IEnumerator<DictionaryEntry> FONGOFJDDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6914EC0", Offset = "0x6913EC0", VA = "0x186914EC0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6914F10", Offset = "0x6913F10", VA = "0x186914F10", Slot = "9")]
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
		private sealed class HCGFMKNLCFK : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xD382A0", Offset = "0xD372A0", VA = "0x180D382A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x69117B0", Offset = "0x69107B0", VA = "0x1869117B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
			[DebuggerHidden]
			public HCGFMKNLCFK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6911660", Offset = "0x6910660", VA = "0x186911660", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6911760", Offset = "0x6910760", VA = "0x186911760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6915840", Offset = "0x6914840", VA = "0x186915840", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IDictionary.this[object GMFCIHEFPPO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6915750", Offset = "0x6914750", VA = "0x186915750", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6915930", Offset = "0x6914930", VA = "0x186915930", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6915690", Offset = "0x6914690", VA = "0x186915690", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x69156F0", Offset = "0x69146F0", VA = "0x1869156F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x69158D0", Offset = "0x69148D0", VA = "0x1869158D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6915350", Offset = "0x6914350", VA = "0x186915350", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x69153B0", Offset = "0x69143B0", VA = "0x1869153B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6915410", Offset = "0x6914410", VA = "0x186915410", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
		public RoomObjectCounts(Dictionary<int, int> FNGMJKCAIDI, [Optional] Dictionary<int, int> HDPOKJNKFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6915270", Offset = "0x6914270", VA = "0x186915270")]
		[IteratorStateMachine(typeof(HCGFMKNLCFK))]
		private IEnumerator<DictionaryEntry> HDBBOAGLINI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6915980", Offset = "0x6914980", VA = "0x186915980", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6915590", Offset = "0x6914590", VA = "0x186915590", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6915470", Offset = "0x6914470", VA = "0x186915470", Slot = "9")]
		void IDictionary.Add(object GMFCIHEFPPO, object JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x69154D0", Offset = "0x69144D0", VA = "0x1869154D0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6915530", Offset = "0x6914530", VA = "0x186915530", Slot = "8")]
		bool IDictionary.Contains(object GMFCIHEFPPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6915630", Offset = "0x6914630", VA = "0x186915630", Slot = "14")]
		void IDictionary.Remove(object GMFCIHEFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69152F0", Offset = "0x69142F0", VA = "0x1869152F0", Slot = "15")]
		void ICollection.CopyTo(Array IKONNGGNFPH, int HCALFJOJKJO)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class MGGKMGFOOCL : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0xD382A0", Offset = "0xD372A0", VA = "0x180D382A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6913080", Offset = "0x6912080", VA = "0x186913080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
			[DebuggerHidden]
			public MGGKMGFOOCL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6912EF0", Offset = "0x6911EF0", VA = "0x186912EF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6913030", Offset = "0x6912030", VA = "0x186913030", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6912100", Offset = "0x6911100", VA = "0x186912100", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IDictionary.this[object GMFCIHEFPPO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6911FD0", Offset = "0x6910FD0", VA = "0x186911FD0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x69121B0", Offset = "0x69111B0", VA = "0x1869121B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6911F10", Offset = "0x6910F10", VA = "0x186911F10", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6911F70", Offset = "0x6910F70", VA = "0x186911F70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6912150", Offset = "0x6911150", VA = "0x186912150", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6911B90", Offset = "0x6910B90", VA = "0x186911B90", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6911BF0", Offset = "0x6910BF0", VA = "0x186911BF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6911C50", Offset = "0x6910C50", VA = "0x186911C50", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2930", Offset = "0x1FF1930", VA = "0x181FF2930")]
		public Invention(long KHLDDJPHOBA, int DOPPKGNLPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6911AC0", Offset = "0x6910AC0", VA = "0x186911AC0")]
		[IteratorStateMachine(typeof(MGGKMGFOOCL))]
		private IEnumerator<DictionaryEntry> HDBBOAGLINI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6912200", Offset = "0x6911200", VA = "0x186912200", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6911DD0", Offset = "0x6910DD0", VA = "0x186911DD0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6911CB0", Offset = "0x6910CB0", VA = "0x186911CB0", Slot = "9")]
		void IDictionary.Add(object GMFCIHEFPPO, object JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6911D10", Offset = "0x6910D10", VA = "0x186911D10", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6911D70", Offset = "0x6910D70", VA = "0x186911D70", Slot = "8")]
		bool IDictionary.Contains(object GMFCIHEFPPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6911EB0", Offset = "0x6910EB0", VA = "0x186911EB0", Slot = "14")]
		void IDictionary.Remove(object GMFCIHEFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6911B30", Offset = "0x6910B30", VA = "0x186911B30", Slot = "15")]
		void ICollection.CopyTo(Array IKONNGGNFPH, int HCALFJOJKJO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> HGOFPKMENLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public readonly IReadOnlyList<Invention> EOHLKIGEBNN;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
	public DLIJFKHNKAL(IReadOnlyDictionary<Guid, RoomObjectCounts> LIKOGLDNNAE, IReadOnlyList<Invention> NFJEMHMDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x690EE60", Offset = "0x690DE60", VA = "0x18690EE60")]
	public static DLIJFKHNKAL DNAAPKIEDCJ(KECMDPPEFHG KBAPBJOHBKA)
	{
		return default(DLIJFKHNKAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x690F850", Offset = "0x690E850", VA = "0x18690F850")]
	[CompilerGenerated]
	internal static int ECKAJCKFAND([In] IReadOnlyDictionary<long, int> CIDHCFFLLIO, long? HMBAPOGAKPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x690F970", Offset = "0x690E970", VA = "0x18690F970")]
	[CompilerGenerated]
	internal static void OCLHHLGGBMH(int GIEFCIHELBF, [In] MFPHCOJFMLN HEJHLMLEMMN, [In] Dictionary<long, int> CIDHCFFLLIO, [In] Dictionary<Guid, RoomObjectCounts> LIKOGLDNNAE)
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
