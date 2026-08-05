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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B39030", Offset = "0x6B37A30", VA = "0x186B39030")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PNCOFIMCOMO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> HHGNGHCBKGH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> JDFPAKMIJEE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> IPCKAEJKOBC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> BLADBHFCLIM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string LAKKGONGMDI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string CGGLAJABNJN;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string HJLMNAGCOML;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B39AE0", Offset = "0x6B384E0", VA = "0x186B39AE0")]
	public static bool LOIMCOFPLIH(Guid HDLJLCOENHA, int ENAGPIMOBHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B393D0", Offset = "0x6B37DD0", VA = "0x186B393D0")]
	public static bool CLGCBINBLNO(Guid HDLJLCOENHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B39460", Offset = "0x6B37E60", VA = "0x186B39460")]
	public static string JNBBKOHFNEK(Guid HLIKNGLOMIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PGBEANFPKIL]
public enum HPNIBICDOEC
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
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B38F80", Offset = "0x6B37980", VA = "0x186B38F80", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CEJNCOBMKEB
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid GDPEIKMOAJG;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid APBONAKHBEG;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid DEBMNGHNHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid KNHAEOBHNIP;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid JJADPHHBPKM;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid KODONPIDLHD;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid GKHHHBPNGMA;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid JMIMOFBMJMK;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid ECDOFPEDFLE;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid NOEENMNEBHA;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid DMFHCGCBDLB;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid PHJLGKGCCFC;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid DPNNECGPEKE;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid JLCNJIFGJMP;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid MJHAOGIBKHE;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid JNDCIHHCDHC;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid KFMFEKIHPLB;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid LBAPJCNGMKB;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid CCNLBOAFNHC;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid OJJCPMIDIHO;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid FJNKBIDLMPC;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid JOCCMGBLGEB;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid JMCGMAELPKB;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid FPJCOBILGNB;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid BEPNFININJA;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid HNKLHEPONHD;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid OEBFFHDJHOG;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid DHKMBMLDFOL;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid OAKONEPCOHE;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid JGOIBDGEAPO;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid PMCHNPNFHGK;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid LHKNNKBGBBM;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid KIGHDOCANEB;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid MNKGMHGADEI;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid DJNLDGKMFLN;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HIDNFPLDNEE;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid JPAMHLBMIOH;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid PFKKIALBEPO;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid NIBOAMLKDDP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid DFILBBLNOAA;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid NCADNCHEHIH;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid DJLMBGPBONA;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid FAIKEDNOMMF;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid AHIGFJJGEBG;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid NGGCELDHPPJ;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid EDPBALGMAIB;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid CHOAICLBIBM;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid GEHHPFOJJNF;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid FHMFGEILDLB;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid GJMEBEOINGI;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid CHIIKAHEDDH;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid GONCBHDENBM;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid OCINIJJPMOP;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid HMIHJLBBJGC;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid OJILCNJFNND;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid KAIDCCENGED;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid AGLHLPPBJMD;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid JPEILPGKGNB;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid BBBKCEMFFFF;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid BEDEANNNLIO;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid IODOLBGDNFM;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid NEKOFEABKNP;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid NEHNDFCIOGJ;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid LFLFEEKBGBA;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid KEGCKOEFELD;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid KLIEPAEGGAA;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid LKNAICBCFHA;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid BFPADGLNEMK;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid GMFDMHOALMJ;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid EBIHDEHACOL;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid MHLMAFCHPEJ;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid FEIGNPKFAOH;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid HEHGHIGKPON;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid PLCNPPKFPOM;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid MEIOHJADGGJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid EKNHFCMEHGH;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid OMJJFNINHEB;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid FBFONDPCBGL;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid FICKGJLJLAF;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid KBIEBEEBEOM;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid AFDCNGFCHIA;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid LBHGJBEJEDI;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid GFOOKOOKBJF;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid PIDFFHABHDM;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MBAKIPJMODA;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid HIALMFMPOGI;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid AIAPOMKHHHD;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid KIIEDKKAMJO;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid BFPAHJFCCHP;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid AHBPMBPOALH;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid MEKKLKGLOJK;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid NOBLFLIACBP;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid KKOPHOAKABM;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid JFGJFFMLBAO;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid MBEDOAHBPLB;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid DDJMCIFBGPD;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid JMICCNPDIOK;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid KIKOIIIHKPJ;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid ALPPOKMGKAF;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid FDGBHLOPMOO;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid JDFOCGBEICE;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid IBHMJIFACME;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid KHHOLLGIBJB;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid OIBLDHMNEGG;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid FIIMMNFDIGC;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid FCHJILGJDEO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid MEECGFADIBP;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid POIJAHABKAL;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid FFIIBANLNEL;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid IKIACCLEGFM;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid PKODKDMLDHB;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid HPGHFJELGKC;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid NGDJGNBMBOL;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid ICJDDOIDAKI;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid KLAPBJMJFCD;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid DFMCEKPKBCC;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid MPEMDHCBEBH;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid LFNMLNNBNOO;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid GHELHEMLPGP;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid HMJOFNJMHFI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid JKIPNDNEKGJ;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid IJFKBOEPKLM;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid MEMIHIMBNOL;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid DNAPNMLGCNM;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid HJDANDFLMLO;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid CDDILNDGLCF;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid JKGDGNJEPCJ;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid FCKCNAPJBNB;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid OPJECLOJALM;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid EMECANFOOCA;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid OEAINNPEIGM;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid HEMHKBJPBME;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid APJPCFOBFJI;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid JPPOIENPMEH;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid CPHBLBEDLNP;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid NIALMGEINFH;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid EKCPKGDGJFK;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid DNNEJCLICPJ;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid GFHPPBNGPAE;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid AJLINJKEHIP;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid OJEGJEOHKEC;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid OHEOKFHLPLG;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid NAPPKGNBJAE;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid AKOONIJEECE;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid EIBLFOAFMNI;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid PHIOCMJPGFB;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid IPNCDEJBMJA;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid LCEDIHEKFEK;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid IHNGCOHIIAC;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid IJCLONJJBDF;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid KFCHGLLOHEA;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid AHANMEGNKMF;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid JGNHLEJKHBH;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid GJNLCFMKGPP;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid AIEJMDDLALC;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid EICAJKELEFH;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid KCBADACHOHH;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid IDKOAOALLGG;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid IOMEFLCEJAB;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid AHEPALDLCLD;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid NAFKCHCJLJC;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid AGGJJOOKPAG;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid CPDDJLFPJAH;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid LINKEGCOJGH;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid BOECJNFGEAI;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid IOIAKIMOECI;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid BPBEPIPMMAA;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid IOJDMDLHNMD;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid CAOKNHGNDOB;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid JDEIIFIOMPD;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid IHJAPKOKDJM;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid BNMGMEGDNJF;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid LFNFMMJPFLF;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid PENCCNLHPMI;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid NHCIBMMHBGD;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid JPLMBMDMECB;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid APFBDCFHIIM;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid CLJPNIMJMKD;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid ECIFNMFJNIC;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid NOGEIGBFLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid PPINHFFIMJN;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid LOMINJBOBAI;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid ODOCMNHCLHN;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid GKDMHIHDAAF;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid NPGADEAOMBI;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid OCEKOOLHFBK;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid ONCMDKGIDEL;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid IELCKCKAIJL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid HAODCNNNNNJ;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid MLHHNCHPFLK;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid EAALHKANPGO;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid AGNGCNBNDCE;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid JCJOOLFJMNH;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid DKJDJHHGJNE;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid IMPOHENINFG;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid DPAMEMJHNKG;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid GOBMJIKLKFM;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid BHPOGIBOANP;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid JPFLKCGLKPO;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid BGCOMKFOCHL;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid CHGFIIHPHCA;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid PIFKHDHNELD;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid BCNNALMEINA;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid NBOCEMNGIBH;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid IKPKEGOIDOO;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid BPCMFMBAFKA;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid IGABLJIKFIG;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid KGDCDNMMDEH;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid OKHBAEPFKJO;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid DKEKFHDAJID;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid PMANOJOKPMM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid GGKPPPFDNPL;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid HALPBKCHFDD;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid NGDHLGOLFHK;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid BAPADLNCPJD;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid PFGBCKKOOLJ;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid KHKJKLIDHHA;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid EIKONEMBNFO;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid GHKOJGEHBOM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid HJJJDLKLCFO;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid JACPHKEANEP;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid NIAPNPFBCHP;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid KEKNJHNHAOE;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid DHKCMJJPMNP;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid NMIOFMJGIAH;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid GLMIMFEJOHP;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid OGCDNFDLKMF;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid ALHCIBGMDAA;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid PNABECCCONB;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid EIEFOGOBJPA;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid IGLAHBFDIGB;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid DJEECNIGABJ;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid BKOEJOOOPGB;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid GPAOONLGEBH;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid AFLMGHHCKFK;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid OJBCMEGJAHI;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid IMGANIDJJDI;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid FBECCPMICEA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid ABJGGHHLJED;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid DMHHBLAPCMC;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid LLPIOMHAOLC;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid HMPAHLLFOOO;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid KLBEJGDHKKD;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid PHFEOFHIPBL;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid HPJNHPILELD;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid LPPFHELCOJF;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid DMLCMIDONFJ;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid MGAMEPJOHNL;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid DHPDHFEGDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid CHPAIMPAGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid GNHIMFBHIPK;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid IELLGJKJIAM;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid HOCJKOOEGNK;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid KEHFMHPCNME;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid EKNAILOMAHE;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid CMGOCLGGNGH;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid HOFINAKFMJE;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid CEKLPPABMCO;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid AKCMCPIANAE;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid CFOEGJKNCIC;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid INCGJCBBOPP;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid KKKOMIIGMJA;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid DNCHFJIJODL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid GCCFBBKOJFL;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid DLBDKDCMCCL;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid AJNOFAIBEIJ;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid CHMIAGCKDBD;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid GIHCMNNGFAM;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid LMKJNOPFDFK;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid COBJJPNIGLJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid FCPLMBGPFJO;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid GHJBOHGKICI;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid BBIABPMMLKN;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid FOGEGGBBCJF;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid BHNFEKPBCGO;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid KAJMDLFMOOM;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid OLFIGAKGJMH;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid GLHECPOHNCI;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid ICLPEBLMNLO;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid OPIOOHEDIGI;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid ENGLFDEEKAF;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid DEGFNHCEHIA;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid MMDFLGJINNH;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid OELIKKBIFGE;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid KIHJMPBLPJJ;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid PJEFGLFPAEL;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid LNIAIDCBGFJ;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid POMHENBHOBD;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid HFECBGHJFDD;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid MCFGFJLMKEH;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid OHNCFMKKDPK;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid LKEIMCIAHDI;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid GHFCBDNJFMA;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid BMMAMCMMJMO;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid ICMMPAHJILI;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid LJELCDHMCNM;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid JEJNMBKLJMA;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid EBENIIPDNIP;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid CGOLGENLOCH;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid NIOLMBMOCPM;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid PDNJLBFKAOL;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid PJKKGMOHCLL;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid LFHAFFCIBIA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid AEFBBNCLFKM;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid KIEPPIDAIHM;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid NLMJNBPAPHA;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid PDOCGKKGHPP;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid KCLLFCCPKII;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid FDIPHMMBBCD;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid BDJIHDDILHN;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid FFDDKEDMLGI;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid LKBDDPONBAP;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid BFEJLICDPDH;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid IGDIACDNGGD;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid OFDHEOBFAMM;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid IIGBPKCIDMB;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid NKKJKFMBJDK;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid HLLAAGGDCHP;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid MLHLMJLACMB;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid IOOHBGPACLA;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid OHIEDBOLECI;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid KLDFFELMKCE;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid CFNBLKFDPJJ;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid LOLJCGLHGCH;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid DMPLGBLKCLJ;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid ACJKMDIHPFH;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid IFHGCGJDLCD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BMNOOOEHODJ;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid AOPMNJJIDFO;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid EILDOGEOPGJ;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid LDNBKLFPLAP;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid LCIEONGPOBK;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid MOOAGEMMNIH;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid CPDHBHGHPGO;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid PGOIHLNHEMH;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid DMDFMGLCDEH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid BIHBOIEIMBG;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid NAIJKKMOLFC;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid DNLEHFLJPOC;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid JJOEHDFPMED;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid APCNBAHKCJP;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid JDLFFGGENGB;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid PMGLFDBHFIB;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid FGGIDLCIGFM;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid NPLCABHOENM;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid NNGHPFFCKJE;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid LKAMNDAABNL;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid MOOHAPKJCJM;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid NOGDLJOCDCD;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid INIKHFDBGCE;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid GKGKKOEHOOP;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid GEDJMPLIIKO;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid HPBPMHPNABB;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid PAKNAEPFMLN;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid NJLBAALEHDJ;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid GPOEINGMGFL;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid AKLOOELDJLB;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OMBIGBJGCOH;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid CIEMNCJAIKK;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid EIINEBNMDGL;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid MCCGIJPJHPC;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid CHFFPNFLFLK;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid OMMFBHGPFKB;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid IPBIAIBAJME;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid BMBDMGKLBLN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid OKOKBOLLMAE;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid GFKBKFPPFCP;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid IKHICBOADMK;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid BINKBBEHPAE;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid AEMJLFKPEFB;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid OOBHCCOHHID;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid GJEDLPFMDJL;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid JNPLOMPNEJF;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid FMKKIKABHKJ;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid OCEFPJJNAFF;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid PNAFCDGGCAD;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid MINAAKDONPE;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BGHIAMMIPNM;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid NCPODMDPHAL;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid AELHJOBBFEJ;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid DFGAGJCIAEB;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid JKIMEOBFGAF;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid LAELAGGLGCO;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid CACHMIFHHAP;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid FAPOMHFDHGI;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid MHLOKHPHBID;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid PGMKDPBKNLH;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid ANNLNFICOAD;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid JHEAPEKMAKI;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid DHMMBMAHGEO;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid AKLIHDDDGOH;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid IJHGOCLHOCB;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid ODPMOADKDCM;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid OKBPJIIPNPN;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid CGEAAMELKDE;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid NLBACCCLFJD;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid AJLOFPAGNAK;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid ECHGMIMEFII;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid CAMMHNMGNAE;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid JAPLHKOHBMO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid HGLPHPDLHIK;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid NMMCDLIIOOA;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid GFEHNFOMJPO;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid DEFEIJHAKAD;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid ELAEANHJCCH;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid IFBBPPPHFMK;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid GOBCIKKBKML;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid LOOPEMOHFCC;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid CNDNJCDAIND;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid ELPBNDKGEHD;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid DDBNDFMAILI;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid NNEHMKLBABM;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid MEEDINMHAGI;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid DMHDNIKNFNO;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid DELFGBEMGIN;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid AINCHLGOMIN;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid FBGHAKCDPIG;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid MBLLPJNPLAG;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid MEGCIGNCMCF;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid BPHMPLKKMDN;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid HKJEHEDLLMH;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid NHAKFDFPEPA;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid HGCPIINHMJN;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid OKNBCMDLCJN;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid EIDJANPCDCO;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid CPFKDHKJFNH;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid DFKPNGIIPED;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid FBFPFDOHNMA;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid KMGEABINJFB;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid HMJAFPEHIDN;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid MENHIDFMNFA;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid OBDBBCENCNK;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DEMBDHKICNO;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid LNCAHEMOHFC;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid LILABEMKIIC;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid ADMOPDKCFIB;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid MOJOBLCHBNN;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid EAEKLIPDKLH;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid APNOMHCHLLI;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid HFAFMNFBFHG;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid ONEEICFMCKM;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid DEMNMBGPBIC;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid BMDGJIEBOJG;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid AOBEGDKAIMP;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid PGBICNILOHA;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid EDJGIENDDLG;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid NHMPEBDHFGJ;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid CPDEMIKCGNM;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid CAAJKFCMBED;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid MKHLEJNMPDA;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid LNBEHKNKMLE;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid CPHAENCACOG;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid EEAIGHEJLND;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid DHALBDMOKIO;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid JKPPOMOEEOI;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid IOPKPPPOJOE;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid BOCPAEDMFFD;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid CKIDIDHLIBH;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid OLKAGIGCAHA;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid IOOLFPAPBEL;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid MLFOBLLLHNE;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid AFDODCFJOAP;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid DLGOGCGEJEG;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid MNIHBOIKIFP;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid FJOBFMDECIN;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid IFBMPJLCLON;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid BALPDNLMGCI;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid JAJJAFJCPGD;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid PKDNAFJAKDG;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid MNHDKIPAKAL;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MLMGJFOHAJG;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid PMKADMPEFMB;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid PJELKLLGCFG;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid GJCHMPDNDMF;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OOIHPKINOHK;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid JJGHGABIEPG;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid EEPFMGNBMNP;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid MBCKAAGCJGA;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid IEEEKFKCANP;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid CMNDAFHPKHN;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HDDKGHOLCOL;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid IJICMCNBAJH;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid CHPKJLNNFJO;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid KDKJCKOAKPE;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid IOABJGHKHIO;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid BADMBAKHAGO;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid HJAEKNAEPPO;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid EFICHINCNEN;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid FIBFCKPJDBE;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid IPIOAHNALKA;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid OCOJJEBPJGD;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid KJABBIMEOPF;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid GGFKACNHBGH;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid KNOBHEOLFGJ;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid IKJPJOJCBBP;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid PIHALJDIHBI;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid KIAJMBNBNAC;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid HEJECCFLPEN;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid IMCJAHPHPLP;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MJBANNHFFLH;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid GENPIPAEBJG;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid CHFFJNNHGGB;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid AHKCJGHBCIF;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid HPFDDCCDMDP;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid DCDHFCCDDEB;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid OLLDBECJCLJ;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid AOFOICAJMOO;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FJDECHKCGGD;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid FNBLCDJPAHJ;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid AFCIOPKPHLF;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid AEAJOALNGJH;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid EKDGFOFBALO;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid MHJLHNFOPKD;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid BDICIPFCJDC;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid MFLFLOGCLKL;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid MOKINKMLFJB;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid BPCNNGCGMOG;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid BPOAPGIGDFB;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid CLDIAIAABNO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid FOCIKEJFBIB;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid CHDEEAKHGEF;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid PPCKDJHLALM;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid FDCBPNJCFFB;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid FEKOHGPNKEM;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid PJJHFDOENDG;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid KEILICFDPHM;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid PLGIGBAPCHA;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid KDAAKOIPFBF;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid IFPAOFIJBKO;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid KNKFMKPIENF;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid FOLJPLKDEEE;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid BBPEBOINGKM;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid GMDJMNDMJNH;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid EKNAMLNBMGK;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid EKGJACEFIIJ;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid GGHJMLHHHPE;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid EIKIOMPFECK;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid GAAKKCEIGAE;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid FCIJFJFGIGA;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid JNIDGKMKIFH;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid DBLPJGPEBHK;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid LCJOBMGCHGJ;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid EBAEKGLLJGA;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid GNOHAFIPMEF;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid LOMBMLIAFJM;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid CALIHFOCEGC;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid GIJKGOGCAHA;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid OJPOFEBDBHH;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid ABAIJGEDKMI;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid ILFPMLDOLCI;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid GFKLKOOALJF;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid DHLLCCMOIOE;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid IBAOBEBPCHO;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid GBFKPKAHPDH;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid BGJDKFCJCNI;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid OALNPIKIPNK;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid OIEGGJPIBNO;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid FMDDKAEBKND;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid PJFBJEHBCNH;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid GIHMJABKLII;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid ICMJBDJKJLN;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid OGOAIDHBFNE;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid JNAGOFLHOOA;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid FMIHFCEAABG;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid KBMDJHMKNHG;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid JJJIGKLAKGC;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid KIPAJIBGJAI;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid HLAJJKOGJPA;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid PGJKLFOAAAK;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid BKIAFMDPPGE;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid PBGICADEJKI;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid COCAIFBOPHM;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid DCADKGGOMBI;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid EPCJMGFECAB;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid MKPAIDHFNHB;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid LDKBLOLDHHA;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid DOPDELJLJKP;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid FOAMGCGPBGI;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid HODHJEOGMMD;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid IALBNIKMDON;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid LLJPKDCCJPP;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid BGJMPHKPPGG;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid APCLIEBKLMO;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid EOMBKOJDHNA;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid IGMNAEMMBID;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid KIHFAJMCNFH;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid KAACGENKEAB;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid ILECKAEBCJC;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid HDAEHHNGDOB;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid KGFILMLFGIK;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid NFIPMEJGCOH;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid CIEDNACDABO;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid AMAKNOFKKAE;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid CAJMHOFKHOK;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid IAPNHGEDJML;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid FFPBFFLGNJH;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid AFHLFPOBKCB;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid KBGLOEIILPI;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid OLKIGMKHMKF;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid BPGNNNHBAPD;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid KCDPMKOHLMJ;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid PGCBAHDBLBB;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid AEOPEAGNNKH;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid KGHJBBODMLC;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid GOMGICPKMAC;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid DFFOGFANNFB;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid MKNIEBKGGEA;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid LIOMGIFJCHK;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid JNPOMPBFGAN;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid KFLIMLFALEA;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid CCKEMFIFBHC;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid ABJGDKKAIHK;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid GCMNNAPGKPG;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid CAPOLIACNCA;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid AOHHCGABBHM;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid IFOFMAKPDPM;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid PCGAEHGOJMK;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid LKDOJDGLFHJ;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid APPBKOLKNJA;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid ONKJCEHJFOD;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid IHACFPJAEMD;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid FMCKBBDHDNP;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid AIKGKFFHGEG;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid OLFKOOMJGOC;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid NDKKKGJJHOI;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid BDCPMNJPGID;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, HPNIBICDOEC> FAOFJBJFCME;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<HPNIBICDOEC, Guid> OOHIJMLMADO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, HPNIBICDOEC> PAJGIGCOBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1FBA0", Offset = "0x6B1E5A0", VA = "0x186B1FBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<HPNIBICDOEC, Guid> NHFMFGPHHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1FBF0", Offset = "0x6B1E5F0", VA = "0x186B1FBF0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HGIDIEGJCAJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6B34DD0", Offset = "0x6B337D0", VA = "0x186B34DD0")]
	public static bool AKGIMJGOHJL(JFOLNHNBEKP HFMPGIEODAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B34A20", Offset = "0x6B33420", VA = "0x186B34A20")]
	private static bool AKGIMJGOHJL(LPIGJBOLMFE CMEDJJCHDOH, JFOLNHNBEKP HFMPGIEODAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BIJIMJEJOLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly FKLLFJIANML FNGIBKFIFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<HCMMMILGLPC> KOLDNAKHOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<HCMMMILGLPC> MHIGGOLLKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly MLGFJIHMDCD<BLDJADOAIME> AHMFMBKDMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<DKFKDKPPDAA<COGPDFLIJHB>> EFFBGIOEHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString AMEDOOCDKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly NLBHPJJNALL FHFEEAHNOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool FHKLCCAPJAG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FB10", Offset = "0x6B1E510", VA = "0x186B1FB10")]
	public BIJIMJEJOLH(FKLLFJIANML KHLCHHOHANE, IEnumerable<HCMMMILGLPC> BBMHNPDNFDC, IReadOnlyList<HCMMMILGLPC> JIDAGAKOOFH, MLGFJIHMDCD<BLDJADOAIME> EOGKNMHPMEG, IReadOnlyList<DKFKDKPPDAA<COGPDFLIJHB>> FICLOINAGDD, ByteString HNPFMFEODPP, NLBHPJJNALL BLBDPKLHAII, bool FBHHFDKDBEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BGHODAKIGEB
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(KGGKLBCKHND OIGMDCDEKEG, [Out] Dictionary<int, int> LIKBJKPMJEL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(BHIFCADPHPN JDKOOFEPAHH, FGBHMAGOPLP NNIFOOGGEAN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EFJICBJJKDC : GBFLONDPFPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid LMFIDFMELIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> HJGAKIDEJDJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> KMMNGLAOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A96C30", Offset = "0x3A95630", VA = "0x183A96C30")]
	private EFJICBJJKDC([In] Guid OCEAIHGACJC, Dictionary<Guid, Guid> BNALPFJHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B201A0", Offset = "0x6B1EBA0", VA = "0x186B201A0")]
	public static EFJICBJJKDC MMKGNMBHOIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FFD0", Offset = "0x6B1E9D0", VA = "0x186B1FFD0")]
	public static EFJICBJJKDC HLDKPENHBCN(IReadOnlyDictionary<Guid, Guid> OFNGDPLEJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FC40", Offset = "0x6B1E640", VA = "0x186B1FC40")]
	public static EFJICBJJKDC FGOFDEDKBPI(IEnumerable<KeyValuePair<Guid, Guid>> OFNGDPLEJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FFE0", Offset = "0x6B1E9E0", VA = "0x186B1FFE0")]
	private static Dictionary<Guid, Guid> JEHJJCKJDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B20230", Offset = "0x6B1EC30", VA = "0x186B20230")]
	public void OACGPGNDDAE(IReadOnlyDictionary<Guid, Guid> OFNGDPLEJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6B20090", Offset = "0x6B1EA90", VA = "0x186B20090")]
	public Guid LICBGACCEKF([In] Guid HLIKNGLOMIK, bool NDHGIABPCFK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FF60", Offset = "0x6B1E960", VA = "0x186B1FF60")]
	public bool FMCMEELEGPJ([In] Guid KFBALBFDDFF, [Out] Guid KAJINELHAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FF60", Offset = "0x6B1E960", VA = "0x186B1FF60", Slot = "4")]
	private bool HMAKLKPMMME(Guid CDNMICCKGIM, [Out] Guid FHIOPODCIDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KGLMPEDKPPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LOBPMBCKJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILDFGHALABA(ByteString CMLPOCNMNKL, EFJICBJJKDC HHHDNOAOIFN, [In] UniformTRS BGAKIOFNMLD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NBMNBFDFHGB
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NKCKNEOBBAB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x171BA00", Offset = "0x171A400", VA = "0x18171BA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long FBKAFEFMLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x11DFE70", Offset = "0x11DE870", VA = "0x1811DFE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long IJMLDFOBDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6B39010", Offset = "0x6B37A10", VA = "0x186B39010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6824AE0", Offset = "0x68234E0", VA = "0x186824AE0")]
	public NKCKNEOBBAB(long KFBJHPBJLOG, long ICFBGONMIFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GFPKBNJPINI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, NKCKNEOBBAB> KJEJGBIKBNM;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> NKGDJOCLBFC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long KMICFIGHIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x11DFE70", Offset = "0x11DE870", VA = "0x1811DFE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long LHHKHPILBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x120D590", Offset = "0x120BF90", VA = "0x18120D590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B20780", Offset = "0x6B1F180", VA = "0x186B20780")]
	public static GFPKBNJPINI PDMEJKPGKBB(FKLLFJIANML KKBCHCFELDO, DKFKDKPPDAA<BLDJADOAIME> HIPOGGKNGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B204B0", Offset = "0x6B1EEB0", VA = "0x186B204B0")]
	private void GHBJIEKNDEO(JINHCMKFECA AJIEBFICGCI, long BIKMGKGHBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B34780", Offset = "0x6B33180", VA = "0x186B34780")]
	public GFPKBNJPINI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HEGBCFFJAJI
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<HPNIBICDOEC> HOMDGACEJNI;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class DPKGJOGEKOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> EDOLHCFNGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> CICEOPNAPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x88B090", Offset = "0x889A90", VA = "0x18088B090")]
	public DPKGJOGEKOJ(IReadOnlyDictionary<Guid, Guid> OGPJGBECPLC, IReadOnlyDictionary<Guid, Guid> DGFKGFMEIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KIKOCFHCEGD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class OLFMJMEHNHO : IEnumerable<HCMMMILGLPC>, IEnumerable, IEnumerator<HCMMMILGLPC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private HCMMMILGLPC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private HEMEGFJECML spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public HEMEGFJECML <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private AJLKKIGIBGN spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public AJLKKIGIBGN <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private HCMMMILGLPC System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x94CA60", Offset = "0x94B460", VA = "0x18094CA60")]
		[DebuggerHidden]
		public OLFMJMEHNHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6B390B0", Offset = "0x6B37AB0", VA = "0x186B390B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B39380", Offset = "0x6B37D80", VA = "0x186B39380", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B391C0", Offset = "0x6B37BC0", VA = "0x186B391C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCMMMILGLPC> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B391C0", Offset = "0x6B37BC0", VA = "0x186B391C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B38250", Offset = "0x6B36C50", VA = "0x186B38250")]
	public static HEMEGFJECML KAGLPHOPLHB([In] BIJIMJEJOLH LNBAILHOLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B38880", Offset = "0x6B37280", VA = "0x186B38880")]
	private static void NDIFOBACEAM(HEMEGFJECML CGHECCFGNIJ, [In] BIJIMJEJOLH LCCAMLAGHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B36590", Offset = "0x6B34F90", VA = "0x186B36590")]
	public static MOKFKOEPKDB<DPKGJOGEKOJ, GODBPAICAJJ> GMOJBJELDPH(HEMEGFJECML CGHECCFGNIJ, AJLKKIGIBGN OCPBCCBEILJ, EFJICBJJKDC? PMPGKBADOKA)
	{
		return default(MOKFKOEPKDB<DPKGJOGEKOJ, GODBPAICAJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B35E90", Offset = "0x6B34890", VA = "0x186B35E90")]
	[IteratorStateMachine(typeof(OLFMJMEHNHO))]
	private static IEnumerable<HCMMMILGLPC> DKIKIMBCFJK(HEMEGFJECML CGHECCFGNIJ, AJLKKIGIBGN OCPBCCBEILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B35FA0", Offset = "0x6B349A0", VA = "0x186B35FA0")]
	private static void DOMIIEDFDBP(HEMEGFJECML CGHECCFGNIJ, EFJICBJJKDC? PMPGKBADOKA, AJLKKIGIBGN OCPBCCBEILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B36240", Offset = "0x6B34C40", VA = "0x186B36240")]
	private static void GEOCMONCDOI(HEMEGFJECML CGHECCFGNIJ, AJLKKIGIBGN OCPBCCBEILJ, IReadOnlyCollection<ByteString>? MMNNAIOMECL, IReadOnlyCollection<ByteString>? CFFAFLIOCII, IReadOnlyCollection<ByteString>? IHKADABFPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B35800", Offset = "0x6B34200", VA = "0x186B35800")]
	private static bool BGJNLLIDBLK(HEMEGFJECML CGHECCFGNIJ, BHIFCADPHPN JDKOOFEPAHH, AJLKKIGIBGN OCPBCCBEILJ, [Out][NotNullWhen(false)] string? DMBOCOKFCJF, [Out] Dictionary<int, int> LIKBJKPMJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B362B0", Offset = "0x6B34CB0", VA = "0x186B362B0")]
	private static Dictionary<Guid, LPIGJBOLMFE> GFAPJDBGBFM(HEMEGFJECML CGHECCFGNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B38EE0", Offset = "0x6B378E0", VA = "0x186B38EE0")]
	private static void OBAMPHFMOGM(bool ILIDEJJDOGN, HCMMMILGLPC GANFOOKIDIA, Dictionary<Guid, Guid> FMINPHHHNHG, EFJICBJJKDC PMPGKBADOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B37FC0", Offset = "0x6B369C0", VA = "0x186B37FC0")]
	private static void HOPGCCIIPOI(HCMMMILGLPC GANFOOKIDIA, Guid LLACDCKMCGB, IEAICFBMINL? FKBLPDCNCBK, Dictionary<Guid, LPIGJBOLMFE> IGBELADEBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B383D0", Offset = "0x6B36DD0", VA = "0x186B383D0")]
	private static void LDDADEPGDAD(IEnumerable<HCMMMILGLPC> OMFNHLICDHH, IReadOnlyCollection<ByteString> MMNNAIOMECL, IReadOnlyCollection<ByteString> CFFAFLIOCII, IReadOnlyCollection<ByteString> IHKADABFPEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct AJLKKIGIBGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool ILIDEJJDOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public NLBHPJJNALL BLBDPKLHAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public IEAICFBMINL? FKBLPDCNCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public IEAICFBMINL? GADHHCOEPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public FKLLFJIANML GGDLFNOMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public NBMNBFDFHGB PPDKHFMHOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public BGHODAKIGEB PNLMNPHEAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public KGLMPEDKPPO NMANFOFHJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public DKFKDKPPDAA<BLDJADOAIME> KNAIGINJHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public IDNMHIFJHOJ PPPLLABIIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<HCMMMILGLPC> HJBJEDLJLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> ALAMDDBLIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public JKIPLMICEOG HENIMMICGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool FGJLMEPEHCI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FNPGLBIIDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B1FAC0", Offset = "0x6B1E4C0", VA = "0x186B1FAC0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IEAICFBMINL
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private const float PJEOCMJGAMF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Vector3 BJDHDJCINFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Quaternion FJFNLINEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float ADJNFMJNIAA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 KODAEPOMIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B352B0", Offset = "0x6B33CB0", VA = "0x186B352B0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS AGJBKBMNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6B354C0", Offset = "0x6B33EC0", VA = "0x186B354C0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xCCFD30", Offset = "0xCCE730", VA = "0x180CCFD30")]
	public IEAICFBMINL(Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, float ADJNFMJNIAA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6B35730", Offset = "0x6B34130", VA = "0x186B35730")]
	public IEAICFBMINL(UniformTRS GEIDKFHOPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6B34E00", Offset = "0x6B33800", VA = "0x186B34E00")]
	public static IEAICFBMINL ADCJMODKNAJ(IEAICFBMINL DLPGBMPJIIG, IEAICFBMINL ANBBHNDBCCA)
	{
		return default(IEAICFBMINL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B35680", Offset = "0x6B34080", VA = "0x186B35680")]
	public static IEAICFBMINL PFMAFNCLKDD((Vector3, Quaternion, float) OIGMDCDEKEG)
	{
		return default(IEAICFBMINL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6B35500", Offset = "0x6B33F00", VA = "0x186B35500")]
	public static IEAICFBMINL PFMAFNCLKDD(Matrix4x4 BBNPOGHGGPP)
	{
		return default(IEAICFBMINL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B356A0", Offset = "0x6B340A0", VA = "0x186B356A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6B35080", Offset = "0x6B33A80", VA = "0x186B35080")]
	public IEAICFBMINL BFKGCLEIIIP(Matrix4x4 JKDLLOIHFGK)
	{
		return default(IEAICFBMINL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6B353C0", Offset = "0x6B33DC0", VA = "0x186B353C0")]
	public static IEAICFBMINL IFDDNDIPONG(Vector3 BJDHDJCINFH)
	{
		return default(IEAICFBMINL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6B35430", Offset = "0x6B33E30", VA = "0x186B35430")]
	public readonly JGEFDJEOPKG KOIBOGKKBBI()
	{
		return default(JGEFDJEOPKG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IHKIONJEHNP
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B401E0", Offset = "0x6B3EBE0", VA = "0x186B401E0")]
	public static IEAICFBMINL JOEMFPEDBFC([In] this JGEFDJEOPKG PECHDAFMNOO)
	{
		return default(IEAICFBMINL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum JBECIFJENEH
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct GODBPAICAJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly GDLDAHLKHAN DHMOHOICOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private readonly NLHAIFJDFEL GKJFNKFGFNH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xF46960", Offset = "0xF45360", VA = "0x180F46960")]
	private GODBPAICAJJ(GDLDAHLKHAN OIKBGDLAKHG, NLHAIFJDFEL GBCICLAAIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D740", Offset = "0x6B3C140", VA = "0x186B3D740")]
	public HDCNBLKJONM PMGNHFHDOIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D520", Offset = "0x6B3BF20", VA = "0x186B3D520")]
	public static MOKFKOEPKDB<DPKGJOGEKOJ, GODBPAICAJJ> MMKGNMBHOIH(AHEADBPPHGE<IEPJDCHMGFO> GBCICLAAIAM)
	{
		return default(MOKFKOEPKDB<DPKGJOGEKOJ, GODBPAICAJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D690", Offset = "0x6B3C090", VA = "0x186B3D690")]
	public static MOKFKOEPKDB<DPKGJOGEKOJ, GODBPAICAJJ> MMKGNMBHOIH(HDCNBLKJONM GBCICLAAIAM)
	{
		return default(MOKFKOEPKDB<DPKGJOGEKOJ, GODBPAICAJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D5D0", Offset = "0x6B3BFD0", VA = "0x186B3D5D0")]
	public static MOKFKOEPKDB<DPKGJOGEKOJ, GODBPAICAJJ> MMKGNMBHOIH(string DFFPLEPPIBK)
	{
		return default(MOKFKOEPKDB<DPKGJOGEKOJ, GODBPAICAJJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GDLDAHLKHAN
{
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HGBOBNMIAFL : IDisposable, HEOFEOJFEHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private NativeList<JMCOJBGJDJJ> MHLBLOMJHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private float PJLCBAFMMBK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MAFMGBEJBCE ENNCOHAJFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		[CompilerGenerated]
		get
		{
			return default(MAFMGBEJBCE);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88E020", Offset = "0x88CA20", VA = "0x18088E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool NPCIALLKHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DB50", Offset = "0x6B3C550", VA = "0x186B3DB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NOGJJNKIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DB40", Offset = "0x6B3C540", VA = "0x186B3DB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<EMOFANGKEPP> HOILPPHMHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MKNMANDONFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DA40", Offset = "0x6B3C440", VA = "0x186B3DA40", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float GHBPIMIDNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6B3FE60", Offset = "0x6B3E860", VA = "0x186B3FE60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B3FFF0", Offset = "0x6B3E9F0", VA = "0x186B3FFF0")]
	public HGBOBNMIAFL(MAFMGBEJBCE JOPMDPIIDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DAE0", Offset = "0x6B3C4E0", VA = "0x186B3DAE0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DB60", Offset = "0x6B3C560", VA = "0x186B3DB60")]
	public Vector3 HAJDFEOICHJ(int PEMICEPHOKB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F8A0", Offset = "0x6B3E2A0", VA = "0x186B3F8A0", Slot = "6")]
	public Quaternion OFPIFPOJAEO(int PEMICEPHOKB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EF80", Offset = "0x6B3D980", VA = "0x186B3EF80", Slot = "5")]
	public Vector3 MABECBCBCHB(int PEMICEPHOKB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D9E0", Offset = "0x6B3C3E0", VA = "0x186B3D9E0", Slot = "7")]
	public float CKCJAKJLIDN(int PEMICEPHOKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E030", Offset = "0x6B3CA30", VA = "0x186B3E030")]
	public void HHFIIJPGCCP(Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, float MNBMJJFKKCE, bool AJEHODNOKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DA80", Offset = "0x6B3C480", VA = "0x186B3DA80")]
	private bool DNEDGEIBKOL(int FMEKOOHDKMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E9B0", Offset = "0x6B3D3B0", VA = "0x186B3E9B0")]
	public void IMLGIKNHJML(Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, float MNBMJJFKKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F810", Offset = "0x6B3E210", VA = "0x186B3F810")]
	public void NECHDFNCCHD(int FMEKOOHDKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EE30", Offset = "0x6B3D830", VA = "0x186B3EE30")]
	public void KNLJODCFLCF(int FMEKOOHDKMM, Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, float MNBMJJFKKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EB30", Offset = "0x6B3D530", VA = "0x186B3EB30")]
	public void JOKCBBELEDN(int FMEKOOHDKMM, float3 BJDHDJCINFH, quaternion FJFNLINEAKI, float MNBMJJFKKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ECE0", Offset = "0x6B3D6E0", VA = "0x186B3ECE0")]
	public void KAKLBAIBLOH(int FMEKOOHDKMM, Vector3 BJDHDJCINFH, float MNBMJJFKKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D880", Offset = "0x6B3C280", VA = "0x186B3D880")]
	public void BHPGIJNBCJM(int FMEKOOHDKMM, Vector3 BELBOBCMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F020", Offset = "0x6B3DA20", VA = "0x186B3F020")]
	public static Quaternion NDKBPBEHMFP(Quaternion CJJEGFAGPAN, int FMEKOOHDKMM, float OIKOJPFBBBO, HEOFEOJFEHK PFALJNCKCKF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F9D0", Offset = "0x6B3E3D0", VA = "0x186B3F9D0")]
	public Bounds PAJOFFMAFBP(Transform JKDLLOIHFGK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E940", Offset = "0x6B3D340", VA = "0x186B3E940", Slot = "10")]
	public virtual void HKJGPEKGCLG(bool GBGONNGBNML = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D7B0", Offset = "0x6B3C1B0", VA = "0x186B3D7B0")]
	public NativeList<JMCOJBGJDJJ> BBDLOECJBLG(float NLHKDKLOILJ = 1f)
	{
		return default(NativeList<JMCOJBGJDJJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EMOFANGKEPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float3 FDBNADNMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public float IJFGAPPPCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public quaternion BMCHIIDKAJF;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D4A0", Offset = "0x6B3BEA0", VA = "0x186B3D4A0")]
	public EMOFANGKEPP(Vector3 OADBGCPFPOE, Quaternion CJJEGFAGPAN, float MNBMJJFKKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D3E0", Offset = "0x6B3BDE0", VA = "0x186B3D3E0")]
	public Quaternion PGOPCBEIHIG(Vector3 IMGPFEFAFKM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D0E0", Offset = "0x6B3BAE0", VA = "0x186B3D0E0")]
	public EMOFANGKEPP OJCFFJIKMAJ(Vector3 OPOFBJCKHKK, Vector3 POEGFMGJALO, Vector3 JABBHBBBNEA)
	{
		return default(EMOFANGKEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B3CF30", Offset = "0x6B3B930", VA = "0x186B3CF30")]
	public CBGPCAPODMB DCCKDPMIFNP(Vector3 IMGPFEFAFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class PCCMKIFJNEL : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B43880", Offset = "0x6B42280", VA = "0x186B43880", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6B43900", Offset = "0x6B42300", VA = "0x186B43900")]
	private void GNGAIJHHNHD(Dictionary<Guid, Guid> IDDHELEEAEP, GMGKCKFIHNF AHFKIMBEMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B44150", Offset = "0x6B42B50", VA = "0x186B44150")]
	private void GNGAIJHHNHD(Dictionary<Guid, Guid> IDDHELEEAEP, CGMJPPCKNGO LCMENBFBJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B43ED0", Offset = "0x6B428D0", VA = "0x186B43ED0")]
	private void GNGAIJHHNHD(Dictionary<Guid, Guid> IDDHELEEAEP, PNDJNDADLBD CEPKEAEDKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public PCCMKIFJNEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class BKEFDNODCIC : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6B3C5B0", Offset = "0x6B3AFB0", VA = "0x186B3C5B0", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public BKEFDNODCIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class IAJIACBDLEC : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B40080", Offset = "0x6B3EA80", VA = "0x186B40080", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public IAJIACBDLEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class ELBCHEFFKBO : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B3CDE0", Offset = "0x6B3B7E0", VA = "0x186B3CDE0", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public ELBCHEFFKBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class EHJGIFKCPGG : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B3CBC0", Offset = "0x6B3B5C0", VA = "0x186B3CBC0", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public EHJGIFKCPGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OBOLNFIJPKA : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B43740", Offset = "0x6B42140", VA = "0x186B43740", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public OBOLNFIJPKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NHOBLNCILLG : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B435B0", Offset = "0x6B41FB0", VA = "0x186B435B0", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public NHOBLNCILLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class PGKCLHLJOAA : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B441B0", Offset = "0x6B42BB0", VA = "0x186B441B0", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public PGKCLHLJOAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class EFPKCLLJCGC : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3CA10", Offset = "0x6B3B410", VA = "0x186B3CA10", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public EFPKCLLJCGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KHPJEAPBLLO : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6B40E40", Offset = "0x6B3F840", VA = "0x186B40E40", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public KHPJEAPBLLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class LCHECCPHECG : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B42350", Offset = "0x6B40D50", VA = "0x186B42350", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public LCHECCPHECG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class BCDHEMEPIIP : OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public static readonly GBLBJECCDPA KDDHELPCABF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AB40", Offset = "0x6B39540", VA = "0x186B3AB40", Slot = "4")]
	public void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public BCDHEMEPIIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct JFOLNHNBEKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public BHIFCADPHPN DHAIIPINBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public MOMGAGDFFOG PNFKJPECPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<int, int> LFHLOACBPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public Dictionary<Guid, Guid> IJLKFALGIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public JKIPLMICEOG HENIMMICGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public bool KCJPACILNMJ;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OLDJNGKNMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCKFIMAHKBC(JOBKDCBEJDO AJGBGAJPCFL);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NFJICLFJEIK
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly OLDJNGKNMDB[] KBPIBDPOCKP;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6B42820", Offset = "0x6B41220", VA = "0x186B42820")]
	public static void DJHHEDHPKOA(HCMMMILGLPC OIGMDCDEKEG, Dictionary<Guid, Guid> NBJFOFCIKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B42D30", Offset = "0x6B41730", VA = "0x186B42D30")]
	public static void PPHABNAFODK(HCMMMILGLPC? OIGMDCDEKEG, EFJICBJJKDC AGEAIANGHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6B42AB0", Offset = "0x6B414B0", VA = "0x186B42AB0")]
	public static void FIFLFKLPIDN(HCMMMILGLPC? OIGMDCDEKEG, EFJICBJJKDC PMPGKBADOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6B42450", Offset = "0x6B40E50", VA = "0x186B42450")]
	public static void AKGIMJGOHJL(JOBKDCBEJDO AJGBGAJPCFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JOBKDCBEJDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public BHIFCADPHPN OCIDNFFHCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public HCMMMILGLPC GANFOOKIDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<int, int> LFHLOACBPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public Dictionary<Guid, Guid> IJLKFALGIKG;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6B40BC0", Offset = "0x6B3F5C0", VA = "0x186B40BC0")]
	public Guid NJPOKOLADJI(Guid HLIKNGLOMIK)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface JKIPLMICEOG
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int NCBIJLNGDDN, [Out] Guid FOKJEDPKMPM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class BDMKNFPIOLA
{
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private static readonly ProfilerMarker PFDALBMBCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<string> DMLAHKJPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly Dictionary<long, int> BEAEBMIAPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly HashSet<Guid> BPPDNJKDIBC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> ABIABMPFMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> PKFALPIGKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B3BD60", Offset = "0x6B3A760", VA = "0x186B3BD60")]
	public static BDMKNFPIOLA ODEHLDEFIDB(PCBLLGHKJMO HMIHKJIKEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B3BCF0", Offset = "0x6B3A6F0", VA = "0x186B3BCF0")]
	public static BDMKNFPIOLA MLHIPBMJHKE(HEMEGFJECML OOFANAHDMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AC70", Offset = "0x6B39670", VA = "0x186B3AC70")]
	public static BDMKNFPIOLA CDLIKJIIEKK(IEnumerable<string> DMLAHKJPFKO, IDictionary<long, int> JJLAOGPPCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B3C350", Offset = "0x6B3AD50", VA = "0x186B3C350")]
	private BDMKNFPIOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B3C470", Offset = "0x6B3AE70", VA = "0x186B3C470")]
	private BDMKNFPIOLA(IEnumerable<string> DMLAHKJPFKO, IDictionary<long, int> JJLAOGPPCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B9B0", Offset = "0x6B3A3B0", VA = "0x186B3B9B0")]
	private void JBOIFDFHNAF(PCBLLGHKJMO HMIHKJIKEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B7B0", Offset = "0x6B3A1B0", VA = "0x186B3B7B0")]
	private void JBOIFDFHNAF(HEMEGFJECML OOFANAHDMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B3BDD0", Offset = "0x6B3A7D0", VA = "0x186B3BDD0")]
	private void OMNHKHCNEEC(ByteString? HNPFMFEODPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B340", Offset = "0x6B39D40", VA = "0x186B3B340")]
	private void JBOIFDFHNAF(EFHLEDMBAEL? MGPJOGDJPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B3BBB0", Offset = "0x6B3A5B0", VA = "0x186B3BBB0")]
	private void JBOIFDFHNAF(JOCELFKFLIO? AJIEBFICGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AFE0", Offset = "0x6B399E0", VA = "0x186B3AFE0")]
	private void JBOIFDFHNAF(HCMMMILGLPC? GANFOOKIDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ADF0", Offset = "0x6B397F0", VA = "0x186B3ADF0")]
	private void EKNOIGDMBPL(string? FKNAGNLGDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AE60", Offset = "0x6B39860", VA = "0x186B3AE60")]
	private void FAKNHLLKCHL(long GDDNKICGJLM, Guid LLJFHBKLHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AF90", Offset = "0x6B39990", VA = "0x186B3AF90")]
	private void FAKNHLLKCHL(AHJJNGEAEMM? EDLOFMBEGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AF30", Offset = "0x6B39930", VA = "0x186B3AF30")]
	private void FAKNHLLKCHL(CHILININOMF? EDLOFMBEGPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct KOCLFFILOPP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class COFDLIAGELH : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly IEnumerator<DictionaryEntry> ANMEDFHNEAJ;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry PCKJJLCPGCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C7E0", Offset = "0x6B3B1E0", VA = "0x186B3C7E0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C8B0", Offset = "0x6B3B2B0", VA = "0x186B3C8B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object GJBIHCLEEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C960", Offset = "0x6B3B360", VA = "0x186B3C960", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C700", Offset = "0x6B3B100", VA = "0x186B3C700", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
		public COFDLIAGELH(IEnumerator<DictionaryEntry> ANMEDFHNEAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C660", Offset = "0x6B3B060", VA = "0x186B3C660", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C6B0", Offset = "0x6B3B0B0", VA = "0x186B3C6B0", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class LBFHILGOCOB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0xDCD700", Offset = "0xDCC100", VA = "0x180DCD700", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0x6B42300", Offset = "0x6B40D00", VA = "0x186B42300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public LBFHILGOCOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6B421B0", Offset = "0x6B40BB0", VA = "0x186B421B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6B422B0", Offset = "0x6B40CB0", VA = "0x186B422B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6B44870", Offset = "0x6B43270", VA = "0x186B44870", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object JODEIIFHAPK]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6B44780", Offset = "0x6B43180", VA = "0x186B44780", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6B44950", Offset = "0x6B43350", VA = "0x186B44950", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6B446C0", Offset = "0x6B430C0", VA = "0x186B446C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6B44720", Offset = "0x6B43120", VA = "0x186B44720", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6B448F0", Offset = "0x6B432F0", VA = "0x186B448F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6B44380", Offset = "0x6B42D80", VA = "0x186B44380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6B443E0", Offset = "0x6B42DE0", VA = "0x186B443E0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6B44440", Offset = "0x6B42E40", VA = "0x186B44440", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
		public RoomObjectCounts(Dictionary<int, int> GOBAGNCBLJL, [Optional] Dictionary<int, int> MGBPAJMHAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B442A0", Offset = "0x6B42CA0", VA = "0x186B442A0")]
		[IteratorStateMachine(typeof(LBFHILGOCOB))]
		private IEnumerator<DictionaryEntry> EBJDHOIHAFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B449A0", Offset = "0x6B433A0", VA = "0x186B449A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B445C0", Offset = "0x6B42FC0", VA = "0x186B445C0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6B444A0", Offset = "0x6B42EA0", VA = "0x186B444A0", Slot = "9")]
		void IDictionary.Add(object JODEIIFHAPK, object CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6B44500", Offset = "0x6B42F00", VA = "0x186B44500", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6B44560", Offset = "0x6B42F60", VA = "0x186B44560", Slot = "8")]
		bool IDictionary.Contains(object JODEIIFHAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B44660", Offset = "0x6B43060", VA = "0x186B44660", Slot = "14")]
		void IDictionary.Remove(object JODEIIFHAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6B44320", Offset = "0x6B42D20", VA = "0x186B44320", Slot = "15")]
		void ICollection.CopyTo(Array FNCIFDCGDBA, int EBDDHAPIAHH)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class KHBHCALFDDF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0xDCD700", Offset = "0xDCC100", VA = "0x180DCD700", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x6B40DF0", Offset = "0x6B3F7F0", VA = "0x186B40DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public KHBHCALFDDF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6B40C60", Offset = "0x6B3F660", VA = "0x186B40C60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6B40DA0", Offset = "0x6B3F7A0", VA = "0x186B40DA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6B408E0", Offset = "0x6B3F2E0", VA = "0x186B408E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object JODEIIFHAPK]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6B407B0", Offset = "0x6B3F1B0", VA = "0x186B407B0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6B40990", Offset = "0x6B3F390", VA = "0x186B40990", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6B406F0", Offset = "0x6B3F0F0", VA = "0x186B406F0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6B40750", Offset = "0x6B3F150", VA = "0x186B40750", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6B40930", Offset = "0x6B3F330", VA = "0x186B40930", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6B40370", Offset = "0x6B3ED70", VA = "0x186B40370", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6B403D0", Offset = "0x6B3EDD0", VA = "0x186B403D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6B40430", Offset = "0x6B3EE30", VA = "0x186B40430", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x209D800", Offset = "0x209C200", VA = "0x18209D800")]
		public Invention(long KFBALBFDDFF, int KFBJHPBJLOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6B402A0", Offset = "0x6B3ECA0", VA = "0x186B402A0")]
		[IteratorStateMachine(typeof(KHBHCALFDDF))]
		private IEnumerator<DictionaryEntry> EBJDHOIHAFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6B409E0", Offset = "0x6B3F3E0", VA = "0x186B409E0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6B405B0", Offset = "0x6B3EFB0", VA = "0x186B405B0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B40490", Offset = "0x6B3EE90", VA = "0x186B40490", Slot = "9")]
		void IDictionary.Add(object JODEIIFHAPK, object CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B404F0", Offset = "0x6B3EEF0", VA = "0x186B404F0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B40550", Offset = "0x6B3EF50", VA = "0x186B40550", Slot = "8")]
		bool IDictionary.Contains(object JODEIIFHAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B40690", Offset = "0x6B3F090", VA = "0x186B40690", Slot = "14")]
		void IDictionary.Remove(object JODEIIFHAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B40310", Offset = "0x6B3ED10", VA = "0x186B40310", Slot = "15")]
		void ICollection.CopyTo(Array FNCIFDCGDBA, int EBDDHAPIAHH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> PMLJDLEPJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public readonly IReadOnlyList<Invention> DMKBGNIMEGP;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
	public KOCLFFILOPP(IReadOnlyDictionary<Guid, RoomObjectCounts> IPPDDJLFLAE, IReadOnlyList<Invention> HFNAKCEKNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B417D0", Offset = "0x6B401D0", VA = "0x186B417D0")]
	public static KOCLFFILOPP ODEHLDEFIDB(PCBLLGHKJMO HMIHKJIKEGE)
	{
		return default(KOCLFFILOPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B40FF0", Offset = "0x6B3F9F0", VA = "0x186B40FF0")]
	[CompilerGenerated]
	internal static int HBOLDLDIFOJ([In] IReadOnlyDictionary<long, int> OKMIHNOMHJI, long? GDDNKICGJLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B41110", Offset = "0x6B3FB10", VA = "0x186B41110")]
	[CompilerGenerated]
	internal static void LCOIEONCOLJ(int HGDEJEBKJGH, [In] EFHLEDMBAEL KABJACDBEFA, [In] Dictionary<long, int> OKMIHNOMHJI, [In] Dictionary<Guid, RoomObjectCounts> IPPDDJLFLAE)
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
