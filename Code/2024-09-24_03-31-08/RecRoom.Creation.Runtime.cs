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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B140A0", Offset = "0x6B12AA0", VA = "0x186B140A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IKCECKJGDHH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> BGCOPHOFKPC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> MHDHELHBMKF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> DABJBLHLMOO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> AJKGMNCFJJB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JIBEGLBKECM;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string DFPGGBILIMN;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string NOJGKGIFKFM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B12410", Offset = "0x6B10E10", VA = "0x186B12410")]
	public static bool MAINJHMPGHM(Guid KEMPCBHBOAG, int CLIEDCKBDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B12380", Offset = "0x6B10D80", VA = "0x186B12380")]
	public static bool FPNPFJOBFGL(Guid KEMPCBHBOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B12510", Offset = "0x6B10F10", VA = "0x186B12510")]
	public static string MEGKPIAAFJP(Guid OKMPNEEAGBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PFLKDOBLPMC]
public enum LEBCKDNBOMK
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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B14010", Offset = "0x6B12A10", VA = "0x186B14010", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CCELKHHFLFN
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid DFAFMNIPONF;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid BMMPHOCGKBA;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid OOJCEGCAJPO;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid NEDANFOMFPL;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid GPDHPNHDBOE;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid PIBJDEOGAFG;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid OOBIIIPDFFI;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid NIEKPDMBKKK;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid BBLHKFBAGPH;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid NNAECMPKKGC;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid FHFINMPJDAB;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid HOJIGPJGPAP;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid AKMIOGIOPMN;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid KONKOIKMMGG;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid HBEFMKNCCKO;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid KJGABLNJEAN;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid CMBMDEACCOM;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid IEECBIFIFND;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid EFEHBJANNNK;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid EPMBJOGGBOM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid PIKEMCIELJG;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid CJMPEOBOMBC;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid AGBIKEEACHB;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid POKJCCLBLHP;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid NNLOFDEEHHB;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid DNCPBNPDPJD;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid AECBJEHKFPE;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid LKPJBGGEDCO;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid PMKLHOAHOFG;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid OJOAPJEENPB;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid IMKEPDOFAIM;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid FLAGFLONNBO;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid DDNIDLLLEHJ;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid CMJENILEKKG;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid BPOLLBHGLGP;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid LOLIIPGAIII;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid MFCLNIFPLKI;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid MKCNLBMPPJO;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid BJBOIDELNCD;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid PMIGGBALDNF;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid MINPDBKCDOI;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid MFAKEABGHKE;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid GKEBFMAALCP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid CMFCHBCIDOO;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid KEBFPDGFINB;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid NKHKMHGCHNP;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid LGEAECKIIFJ;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid DFGHCMEHLIL;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid KPOPNCFAOFP;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid GFBGMOABJIG;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid KJGHMFMFNBK;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid EIKOLDIMHGG;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid EGJAPGJMEIM;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid OGOCANEDJNG;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid IPFDIJJADKF;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid DAKOHPFLKDN;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid PGLJEHINFHJ;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid KKFMLHIPEHO;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid OKMNDMOMGEF;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CNKGLHMOOJI;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid PGDEFCAJDIB;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid PJHJIILKOOH;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid BGOCBAIMLPE;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid GNBJIEMKLHL;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid AGCCECKEOLE;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid OAMHNGMBAEF;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid IOCKKGIOECN;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid ABFOKKPOADE;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid EBAPFPFAOKN;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid AMEAAPCLIGJ;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid LIFHOBCKLOL;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid NMNHDKONKIO;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid MOJHLDBCMML;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid EFMLAIJNLPN;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid BLOJNMGLEGB;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid IHDJNCCENMJ;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid MAIDGIMKION;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid NJKJJPAMFAM;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid IBBEDGNDCKF;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid GJMKPELPMOB;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid BJEJIIDHPFG;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid NMHLHNNLGIN;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid NKPINKNLJMB;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid IBEOMIKPJPK;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid LOAELFNMMPF;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid BELAPIPLPLB;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid IPCLIBJLHKE;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid LAMLMEHNOLB;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid CNADCIFGEEI;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid APBGLDINBIG;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid HFKNLALPEPA;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid GBNFOECJLDJ;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid LPBMEMCAODG;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid JJAMMNGNIKM;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid AEIGNOJFDKG;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid FKHLCGAOHOL;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid IKLABEMBOFE;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid JJPKKCCALMK;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid BPNHEPEGAPL;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid PMPGDNCJGFP;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid FEPFMNJMJFJ;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid FOHLLDPEJBC;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid BGFPFOAMELC;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid JIDGJAMLCND;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid IDPBJMBLAIL;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid NNHCNDOCFDO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid KCEAMOBIIGG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid FFLMEKOKIJL;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid HFJCNPCAHLK;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid MKMBOCIAHJJ;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid IFKCBLCAJNL;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid EAPDKNOLODE;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid NGEHGHNPCEO;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid JKIADLLPELE;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid BDPNKGINGEF;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid HJEICBCCBNA;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid AHOOKLKOMCC;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid FBODEHGJKHP;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid DHFIHMKCION;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid JKBINEKLCIN;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid KOHJGAKEMFC;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid LBDKDNHKCHF;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid ABOJJEHAJBP;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid JBIFNLNHIHM;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid GFELLIKCGGI;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid ALDDIAFJGAP;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid MKIBEIAKBJK;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid COCLAIIPPMA;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid ACIIMDGPMJN;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid JDENPCKOINP;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid EBCGPJPAKFA;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid EEOJPILJCKL;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid GIHGPNAIDBN;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid BKIIIAHCBKM;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid KNHLOBAGHCE;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid FAJFLMEGPMM;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid PBDIIFPJPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid EOKEPALNDDF;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid JIEFAAMNOCI;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid FCDBDBEENOA;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid AGKEEIKPNKP;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid MEDIEFNHCGA;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid OGNLLMGJFJL;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid NKGPFCMEHCC;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid FIODIKFHEAK;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid MJKGBIHCIHA;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid EKANGOICHLA;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid HHOAPCOFDCE;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid JECPHIIIHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid PKPHLJNOJPG;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid FJNCLGOEFOH;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid OJCOBEALFGA;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid OKELACCCDBL;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid LPJJPKCCFHB;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid HCANMCICICP;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid CJDPICJJHOP;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid POBCBFMFKBJ;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid CHHNLMEONNJ;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid HEFHGHCDPDK;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid HOBOIKMMJIA;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid FPOBMOEGLHF;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid NMEJADALIPL;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid KOMJNPENEFP;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid MFJEDGEFJDM;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid HEKPCDKMBPA;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid BOOKCLAMEFM;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid LBHHEGEKDEM;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid PAOPCADMMJE;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid LLOMDFCPLEM;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid FMNBNOFKFPL;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid PACGDBBBOHA;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid FDLAHHKCEJD;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid PKNKLABMHPD;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid GLDCDKDNPIA;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid CBAAADCLFBC;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid JEPENCEPCFK;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid JDKGGKADAMA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid NKDDHDPCMCE;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid ANHGEHCEDOH;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid DCMLCNNPFOE;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid OIELDDPMMNK;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid BDEMPKGAAPG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid CHFOLNDJOKN;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid FJFABFAKAFG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid MOALPNMPAAC;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid LHJAAJOJFNH;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid CJCELNPFDJG;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid EJMHAGAHLAL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid LDGFLBFNOBC;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid COKGBOFIKKN;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid JHPELENPALC;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid LKDADCPPEOC;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid GBMAJKKMBCE;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid AGAGBINKDOK;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid LGJLPPECDME;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid GFLIDIGFOPF;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid ILPKAAEAEAL;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid MDLCGOPOFOA;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid MLEHMLLMOHA;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid FAMALACJLCA;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid NGHHGBGFFNG;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid IKFPGNCAGDJ;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid PPPICPHGBHO;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid LAMHBGIDCEM;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid NICDJEDJANN;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid KIHKIJJGGIJ;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FMKBLDIKFOI;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid BNCKBELMOKH;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid FJDMDHGHEIL;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid MKBCOHFEFPI;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid LJCBOELHOAP;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid DFPHEPPOPOH;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid ENNKAPHKFKA;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid EMNDMCLNDLD;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CMMNOFCECGB;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid MBEANBOHFEL;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid JNFBNDFNKJP;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid KBHHOCEDPHN;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid MMEMBDIHPKK;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid KLPLFOHFEEG;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid OBMLPAIDHFK;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid PAIPKADGKIF;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid KBCHGBJGKLI;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid JPLNDHELMBK;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid NELJLLLJDAM;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid BNILGAIHMPM;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid BGMNCLELHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid EJDDPMHICHB;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid HHPPKKNELJH;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid IHLNPBICAAN;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid JBJHPOPNLDD;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid NCOMINPJLLC;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid IIPLGAJOJLJ;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid KKBBEHJJEAP;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid KHHKAOAGPND;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid LLCDEPGILGG;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid HIGACBGMBEI;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid HACBIGLLKOD;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid CGDLMLNEANJ;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid ALJOMOEHJAM;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid GJACDNDEOHC;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid IBOANHMEFHO;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid DOJCPFBELJF;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid JMIKABINMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid CCBNNMOEPEM;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid LDLKAHIDMNC;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid NLBOECBCKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid LCHDFBPHBFE;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid CJFDCDNIPEH;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid MJCKINDPJJK;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid NENMAHNKHMC;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid AFCJENKBOBN;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid CNICDPKLDGM;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid JMJNGEAMDGE;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid JJAPNJLIILB;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid PPHLDPEJKKH;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid EFMGOBDKIJA;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HDAINGGGGDI;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid IPJFFCIGMGO;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid AGFEJFOMCLJ;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid IABJAGDHEGB;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid ELOFCHGDJHN;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid OJDGHNJMGAE;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid BNNLIPIPDGB;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid BCAOKAHJBFI;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid KLFNEKEKAON;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid JPHLLIBPACO;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid MHLCGKLEJPE;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid CMBKKONHIIP;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid CDPHGAKJLMJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid PFPIBCDCPMM;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid DOPNCBNIHOC;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid MCAEGBBBFDD;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid HHHFHEDMAGG;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid CNLNNDKNHFJ;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid OHPKMENPAIL;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid CNJDNJPAHOC;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid OHAOKFGPFPK;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid NHENAIDOKJM;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid PKJOJHBLEBL;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid DIBFHACPNBC;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid IBAEGDKHDBB;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid CBJLINGBENK;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid HJGNGAINEGL;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid HEDCABKCLMH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid NKIHLMFCDLI;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid AKEPABLFJMD;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid KKOPKNINKFE;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid IPACPMBHOKJ;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid OMEDPABAFAJ;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid GELGMIEADCN;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid NCDOBPDILNF;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid EJNAPGFHPBI;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid ICLCHIPMDBH;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid PLMMEJEBDBI;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid CGEEEAKHLLM;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid KLNJNBKBDAF;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid CANADJNDCBE;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid BALGANFFMPA;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid DMLFMHCMGED;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid MLHENOPIEOI;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MHIIJFOOMOJ;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid DKIBHDANAJD;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid NJGLOCJJLEO;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid BHAKFHNLOLI;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid MOHPECJDOEL;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid NALGNFEIOCN;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid NMFKLHHDIPE;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid AELKDMPEIPM;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid AKCFLOCAMDI;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid BAFMKLFFLPJ;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid EJKHOCCBAGD;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid EKKIOGLANEI;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid HDEOLBPOOJG;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid JMJNKMOGPBB;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid AEGEBECMCEM;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid PFNPBAHJKGH;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid JANAFOHFBOI;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid KBNBDMMNGIH;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid DAPBGPHLPJL;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid DKIIFAKPPLO;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid EGJDMLEOEHB;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid JOBODAJAANE;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid GDAMDLPIAPC;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid OOKDAHOGAOL;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid GDOFFJJNLBE;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid DPDNGOAKHND;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid MBEDIIKAFEG;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid NBJAFHFKBHE;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid DBAFCJADMPJ;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid FKFEFDHEGBH;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid ODOCAJHEPIB;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid AJGKKMACHAG;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid BBHMIMCILDG;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid EGHEOKDKMLI;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid LKIGMOACHLN;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid FBBONCOKJLD;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid AAOONFJKEPK;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid LFJCOAIGPNH;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid CBMPCEFILHF;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid ILONJKNPLNN;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid EBAPEFDKNBB;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid NLFGOHAPNJI;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid HKIPOBJFCGF;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid NPNCNBOOHEJ;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid IHHGNECFOBD;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid EALLCAEDBKI;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid HDOEECADNMG;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid DPHFAEKPHGH;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid GAHJBGMCHJO;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid LCNEFLDNAMP;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid AMKKJHGDFNM;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid NDJFEPJADOL;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid GKJPNIIEMHM;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid PLHDLJAAPIP;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid DMNHKCDMFPE;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid ODEFGJGOBAF;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid JGIIDEMPFLM;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid BDHIOBLPFOA;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid LNPHKONIOOJ;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid IOEDCKIABCC;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid MGNAJNFBPNG;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid HOIGGCCBHHG;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid HFCALKIOEGJ;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid JCNLEIIOIKN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid CJGOJIAONNH;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid MANLDDAHEFO;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid PMCLAOFJAIK;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid LBKNKMNCIPH;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid OACMPJFALDI;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid JHLEELLFBPH;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid BHCIPDCINBJ;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid OEFMHLKIDHG;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid LDEKPENLGLK;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid HJCEMFPFJIN;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid GPDLFFLJLPP;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid JOMMFJLIMLF;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid FJBIAIEOFCN;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid CBFLBDJNEEH;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid HKEPHGFMHBO;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid OPLGGADCENB;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid OLDBJHNMBOF;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid IMEDMLAKAHH;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid JLJGKBBJNMH;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid LOGMFIDHEEJ;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid COCKOAJBCLA;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid IBDNNNLCMHD;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid PJBCMGKJNJD;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid MKINHOGCPEG;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid KJPDIHGLAEK;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid IIGGDNKBGCA;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid LKMPCNKHECP;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid GHAMCIFKMGB;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid GBEIPFNCFCJ;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid LLEEMFNOKIL;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid KLPLCDHBOLK;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid JAODFPCEOPK;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid PIIEMNFKOAA;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid KAMDOIOJLGF;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid EMDIMPCGBNI;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid CDFNJGNCABP;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid MGPKMINJAAI;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid KOANCHCMEHL;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid BEOJJLJKBEO;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid EAMFDIBGPKD;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid FKHMLILDFFO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid OIMIBDHDFJI;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid ANAJABFMJIM;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid KOJBBDHKHOE;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid DAFBGPHHMOM;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid MOFJHMOGHIA;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid PCEJBCIKNJC;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid HJONOLHBOCD;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid IHBBNMKIBIF;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid JLGFDCEIDBN;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid CJKHDAALDKE;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid EKEGNLECMFP;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid KCIDBLKPGLM;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid NGOAMLMKGFE;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid EGOCAKLHEIP;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GIDOAKCEMEG;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid IIIKPBCKHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid PAMFKPNGIOL;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MGDBAIFADCE;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid AIEMDFBNMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FDLAOANBKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid AGGGKPCFIBM;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EPGPFLKIOBA;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid EDPAHOGNBKP;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid GIMFGJIMKKL;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid OFHLBCAACHD;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid EJLBAKBLJMG;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DPHFMDOPIDE;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid IBKPOPFFJKI;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid LIOHEDOGPKM;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid CPFCAOOKEGM;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid EALLILBFJDI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid EFALICKKCGP;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid DDFCOIOKFON;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid AHHJLICNOIM;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid AJPFGDACEPF;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid MJMDNMNOEPO;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid EHNMAJEAGFH;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid IBODCHPMCML;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid GCBPNKKAGCH;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid GPLOJILGGJI;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PMFJFCKALKO;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid HNICMPCLBMI;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid AIACDKKCLDG;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid NEBBDPKKANB;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid ALPNIAAFLMK;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid BLMNHLJGMBN;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid OPFAPBCEGNL;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid OHAMMLPHDIM;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid AAPPCICBCOF;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid BMNCOJPMGDG;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid BGHFCFOFKAL;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid CNDMNMMKNIH;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid CNFMPMGIDAO;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid MKPEDGMEPLC;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid JHDELFEBHCL;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid KNLOPEGPDHE;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid ABMCPIJDKEI;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid EGOPPIFFODG;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid ICAMMCBHNHB;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid HBBJOGDNKMC;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid OFPFPGDNNAF;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid OLENKEJENOA;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid OEPJIAOFENM;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid PDFPDKCODOL;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid BEBLELIEOOA;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid CPDBBIFDJCM;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid NJOAFBEJIJA;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid BGFMHCKNIDP;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OCLMOOFPBDP;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid NMCPHAOKGGO;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid BHDKGLBJGDG;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid EHADMBHPGHH;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid GKNFNCJEAPJ;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid KKOAEGCCMML;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HDJHDBHHEBD;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid LMPMBBKJLOC;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid MLMOFKIJIHA;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid FDNENBPEHED;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid KHDEOAPNEFL;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LGKIFJJCGNG;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid HBGJBLLPCEN;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid AKKAGBFGHCK;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid HAFLDANHFKL;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid OIKBIKDPGHB;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid KIPALIENAKM;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid CIFLMBIIOMI;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid HANDNKANPCJ;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid ECCMKBEEOEP;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid BJHONOEHACP;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid HPNCKGMBNPJ;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid EJCBFEDMFHN;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid JBFIJMHMIEN;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid DDPOAPPONMB;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid IKPFPOFNLMD;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid HNGEIFNMLMH;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid BBIEGELFNCO;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid FPBFNHEHAGJ;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid ALBNOEIEIDG;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid DHNLPCFMJJL;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid FFBKEHMDGPC;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid ENLJJKGBNJM;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid EBDMDDFJENP;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid MOHNJHDAGJO;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid KJGGPKFAOBN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid MBIOAHHCKLP;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid BOCCDPHPEEA;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid GGGNIBMFEMC;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid IKMKECKODDE;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid CFNGADIMLCJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid OKMBEDJAEMK;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid BDHJGDKDNPL;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid JKLAAIJOFAK;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MHLJJNPCLIN;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid LEHGHDBCGFB;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid AKABOHKDMKF;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid HGECPDELFHM;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid OHDHALIAOAE;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid PIAPOHBOIGO;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid OHMILJENLNC;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid JGBKEHPGKBM;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid BPMHONHDABC;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid IGFLIMFFIEM;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid POMKNIPCFLF;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid PMKHIIIBCOL;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid PCKOPOHLPGO;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid ABNBCAHFCHL;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid IDPEAFAKAEF;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid GKEHOEPMCAJ;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid DBBMILHGMDH;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid NPPBJAPJCDE;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid JHMOFMJABEO;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid BNCICGJODLG;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid GECHFLMDIAK;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid IPNFAALKPCG;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid HOPCHJEPNIO;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid OEOPNGIFIOP;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid MDBGKOBNDAM;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid HCNACBGOAEE;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid LNLBEFFLMBF;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid JADDFANPDIB;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid MMHOMHKHJAL;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid KNOLKLBOPCG;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid NABILEHPFCL;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid PHBNKNOEJJB;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid MFMACPKHGLK;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid DLHJNKFOIOP;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid LBJKPGJJJAJ;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid NCNNCIGLLIP;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid BCOLLHBGIOO;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid JJOJPGPFKOM;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid IPFBAKKFKNJ;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid IPEHDMDHFCF;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid LPCFFMBLNKB;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid OBOLNHKACAD;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid POLAEGGEABL;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid DDHFOFPDBFM;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid AIHJOJPGGGP;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid PEMDDHKAKOH;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid JALMHJPCBEO;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid MNECAPEIFCO;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid OAIFOKPJAPN;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid IJNOHJJBPML;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid IKLGNDJFKDL;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid BBFJAICBOJK;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid EACKJJMANEG;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid EAOICMOJAIG;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid AFCPAGHECDO;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid DEPFKLEOAKC;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid DCCKEBKAOFB;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid EGLBDCDMAIO;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid KOGOBMMPFNO;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid MIBBNIGPIPE;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid NGFOJMBNICG;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid CFIGJEMFFCN;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid LODENMKHGHE;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid HLEJIOGIGBB;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid EPHILLNGPHH;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid ACBPBGAEEDH;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid IDPCKNOECFD;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid CEALNJHAFAH;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid CJFBJKLOHND;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid CFBNPILJIBI;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid KPGEPIPIHEN;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid FHGDCOKEMDO;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid DMCCOJLJHPN;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid KCOBOKJEGOE;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid KCJEAKKOHCK;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid PJGPCGDLEGB;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid HJKEMCMFFGE;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid ILBDOHLCEBB;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid FKHNMGKFIPI;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid KHANNLJBFLI;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid GPCLHIJLEDK;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid GDMGPDIIJKO;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid HOMBGEKGHNE;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid BENHIBFLHEE;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid MIBEMDBOFIJ;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid BFLGKIJIHOI;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid LDIKNLIPCGH;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid DGOACCPDBAB;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid OKFEAPGAFOK;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid DDMJLLMOFAG;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid PCEFLPJGPNK;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid JIADBEHPBMP;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid IOPIFJBMDOM;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid LOBOAOFKMHN;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid GFEIBCBEGGC;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid KPHELMMOILP;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid LECGAGFHCAL;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid IGAJHDPNCHL;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid OOLGMJHGIMN;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid BJEPDJLNPMO;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid BGFMOLNGAMN;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid JCAOLIACJEM;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid PEGPCPKLDOI;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid AODHAEOACBE;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid AALFKGKJPKB;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid GHCIBECHNAN;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid FGJGCMEDMKH;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid KDPPCBLHLGG;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, LEBCKDNBOMK> MONCCIGNOBD;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<LEBCKDNBOMK, Guid> EHNKCFJOEOI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, LEBCKDNBOMK> AJKCKGKPJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E700", Offset = "0x6B0D100", VA = "0x186B0E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<LEBCKDNBOMK, Guid> LMIMAKJBOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E6B0", Offset = "0x6B0D0B0", VA = "0x186B0E6B0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DHNOMCKIJND
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EB00", Offset = "0x6B0D500", VA = "0x186B0EB00")]
	public static bool HNBFPGKBMPM(ABDIJKIBEKN KGANIPKDNGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E750", Offset = "0x6B0D150", VA = "0x186B0E750")]
	private static bool HNBFPGKBMPM(IFMGLINAGKP EDAMHICEDPD, ABDIJKIBEKN KGANIPKDNGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KICNKCDFNBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly IAAIBGHJPDJ FNMGDPFIGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<OEAGPMFPCEL> NOOPEEOKGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<OEAGPMFPCEL> EAECNFMIJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly OPGJAFEOJCM<BLMFKKELJGG> FFLPBNCHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<GBPONPDANLH<BOAKMKENONJ>> JELJBPILAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString HNHOLNJJOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly NMMDMJGAOGB DJABOCANDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool HPOMAJHOBKF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B13C60", Offset = "0x6B12660", VA = "0x186B13C60")]
	public KICNKCDFNBL(IAAIBGHJPDJ PMCBNJFIAFB, IEnumerable<OEAGPMFPCEL> JEEJGNKFMDN, IReadOnlyList<OEAGPMFPCEL> FMHCBBOKACG, OPGJAFEOJCM<BLMFKKELJGG> BKFAMEGJCEJ, IReadOnlyList<GBPONPDANLH<BOAKMKENONJ>> JBLKCHLDGPN, ByteString KPDMDKGEHEH, NMMDMJGAOGB LPIAAJLJDLN, bool MHPINKENCKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JILIKIPPEPC
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(MMJMLCDMGBC LNCKNHNHHDF, [Out] Dictionary<int, int> BOMPIHDNBIF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(OEONGJBPPJN MEDLHMBICLK, IPBCILLHPCF FFPKOLKNMKB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BNOOMMFACNI : FNNLJJENCBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid IFEEJCKNDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> ICAFKIFIBEA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> DEMCJKPJLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C19BC0", Offset = "0x3C185C0", VA = "0x183C19BC0")]
	private BNOOMMFACNI([In] Guid PIKFFGILHPA, Dictionary<Guid, Guid> GIGIICPDNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E620", Offset = "0x6B0D020", VA = "0x186B0E620")]
	public static BNOOMMFACNI OOAFHJGKFEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E1D0", Offset = "0x6B0CBD0", VA = "0x186B0E1D0")]
	public static BNOOMMFACNI HCDAEKFNNEH(IReadOnlyDictionary<Guid, Guid> KNNDFOLKJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DE40", Offset = "0x6B0C840", VA = "0x186B0DE40")]
	public static BNOOMMFACNI ALEBAKOGCBG(IEnumerable<KeyValuePair<Guid, Guid>> KNNDFOLKJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E570", Offset = "0x6B0CF70", VA = "0x186B0E570")]
	private static Dictionary<Guid, Guid> NFMBAOCNOOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E1E0", Offset = "0x6B0CBE0", VA = "0x186B0E1E0")]
	public void HCLGGOMGKKG(IReadOnlyDictionary<Guid, Guid> KNNDFOLKJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E460", Offset = "0x6B0CE60", VA = "0x186B0E460")]
	public Guid IIGHBDNNFDH([In] Guid OKMPNEEAGBI, bool GCNBNDEGDHE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E160", Offset = "0x6B0CB60", VA = "0x186B0E160")]
	public bool HNOOFOJOJNO([In] Guid DNICIAANFHD, [Out] Guid EAEAGEIKLJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E160", Offset = "0x6B0CB60", VA = "0x186B0E160", Slot = "4")]
	private bool HAHBBBPICIA(Guid EEBGELKKKEJ, [Out] Guid NMMHFBINDGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OMCPLDCBEMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LPLMCBCEJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPIHBHFBPAP(ByteString INKPEPIELNA, BNOOMMFACNI IAFEGGNKDNP, [In] UniformTRS CPBBGDLEDEO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NCFHNJEGJNA
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
public class IFMOAIHALGA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x903080", Offset = "0x901A80", VA = "0x180903080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long BMKGDNONJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1270100", Offset = "0x126EB00", VA = "0x181270100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long LDDMHJKELJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6B12360", Offset = "0x6B10D60", VA = "0x186B12360")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x680B220", Offset = "0x6809C20", VA = "0x18680B220")]
	public IFMOAIHALGA(long CMNDBGDABDM, long DHJKHACIKKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PMAHOKNNEOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, IFMOAIHALGA> DPFDDJGEHGF;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> KKJFAMPADKO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long LPDFAKODCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1270100", Offset = "0x126EB00", VA = "0x181270100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long NCMDMNINKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x92A990", Offset = "0x929390", VA = "0x18092A990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B143F0", Offset = "0x6B12DF0", VA = "0x186B143F0")]
	public static PMAHOKNNEOK LDEMFLOEDNK(IAAIBGHJPDJ NJEJJEGFFOG, GBPONPDANLH<BLMFKKELJGG> MOMPFKBDGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B14120", Offset = "0x6B12B20", VA = "0x186B14120")]
	private void BHODBNLJEGJ(DKCJHFLDAAD AOOGCKADIHP, long BPCIPIGHCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B283F0", Offset = "0x6B26DF0", VA = "0x186B283F0")]
	public PMAHOKNNEOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JGEHEBJHOMP
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<LEBCKDNBOMK> KLFHBDDLJBN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class GGAHLJNLOPE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> GKBLMDGCCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> JJKIEHOILIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x887590", Offset = "0x885F90", VA = "0x180887590")]
	public GGAHLJNLOPE(IReadOnlyDictionary<Guid, Guid> AGLNHDLGNEF, IReadOnlyDictionary<Guid, Guid> CIHDLNPEEND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GDLLMLPFONF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LABGJAEJHOG : IEnumerable<OEAGPMFPCEL>, IEnumerable, IEnumerator<OEAGPMFPCEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private OEAGPMFPCEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private PAHJFKLNJGA spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public PAHJFKLNJGA <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private PPOKFMDBAJO spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public PPOKFMDBAJO <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private OEAGPMFPCEL System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public LABGJAEJHOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6B13CF0", Offset = "0x6B126F0", VA = "0x186B13CF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B13FC0", Offset = "0x6B129C0", VA = "0x186B13FC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B13E00", Offset = "0x6B12800", VA = "0x186B13E00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OEAGPMFPCEL> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B13E00", Offset = "0x6B12800", VA = "0x186B13E00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F390", Offset = "0x6B0DD90", VA = "0x186B0F390")]
	public static PAHJFKLNJGA EPNDCPOILEA([In] KICNKCDFNBL EAHBEILJMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F580", Offset = "0x6B0DF80", VA = "0x186B0F580")]
	private static void IJCJJCNPFID(PAHJFKLNJGA MNJPHDCFGAB, [In] KICNKCDFNBL GLEMHMGBACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B10890", Offset = "0x6B0F290", VA = "0x186B10890")]
	public static CDOLGFBAJII<GGAHLJNLOPE, KDDMIDKHACH> MJGCNFHOAIC(PAHJFKLNJGA MNJPHDCFGAB, PPOKFMDBAJO BIILEINIHCO, BNOOMMFACNI? FMGOLLHOICC)
	{
		return default(CDOLGFBAJII<GGAHLJNLOPE, KDDMIDKHACH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EDD0", Offset = "0x6B0D7D0", VA = "0x186B0EDD0")]
	[IteratorStateMachine(typeof(LABGJAEJHOG))]
	private static IEnumerable<OEAGPMFPCEL> BBEKEJEHPME(PAHJFKLNJGA MNJPHDCFGAB, PPOKFMDBAJO BIILEINIHCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EB30", Offset = "0x6B0D530", VA = "0x186B0EB30")]
	private static void ALJDPDBBLBJ(PAHJFKLNJGA MNJPHDCFGAB, BNOOMMFACNI? FMGOLLHOICC, PPOKFMDBAJO BIILEINIHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F510", Offset = "0x6B0DF10", VA = "0x186B0F510")]
	private static void HOAOGCFOKJM(PAHJFKLNJGA MNJPHDCFGAB, PPOKFMDBAJO BIILEINIHCO, IReadOnlyCollection<ByteString>? FBBAMJGPGDD, IReadOnlyCollection<ByteString>? NBIHGBLJMAF, IReadOnlyCollection<ByteString>? MHALFNMDDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FF20", Offset = "0x6B0E920", VA = "0x186B0FF20")]
	private static bool JGDIBOEDFNJ(PAHJFKLNJGA MNJPHDCFGAB, OEONGJBPPJN MEDLHMBICLK, PPOKFMDBAJO BIILEINIHCO, [Out][NotNullWhen(false)] string? EJIIMGEBDBD, [Out] Dictionary<int, int> BOMPIHDNBIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B105B0", Offset = "0x6B0EFB0", VA = "0x186B105B0")]
	private static Dictionary<Guid, IFMGLINAGKP> KHCNGDBCNAJ(PAHJFKLNJGA MNJPHDCFGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B122C0", Offset = "0x6B10CC0", VA = "0x186B122C0")]
	private static void MKKOKOPBMAE(bool KJPLOCMGHPA, OEAGPMFPCEL OKFKNACKKGK, Dictionary<Guid, Guid> NOOJBGCMDLA, BNOOMMFACNI FMGOLLHOICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FBE0", Offset = "0x6B0E5E0", VA = "0x186B0FBE0")]
	private static void IOHJOFEOGHM(OEAGPMFPCEL OKFKNACKKGK, Guid HEMEIDBLMMF, BCCPEHCHACO? EHAALIIKBMF, Dictionary<Guid, IFMGLINAGKP> PHBDFNBPCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EEE0", Offset = "0x6B0D8E0", VA = "0x186B0EEE0")]
	private static void EOBNHCFFLAH(IEnumerable<OEAGPMFPCEL> OKDHELGIMJD, IReadOnlyCollection<ByteString> FBBAMJGPGDD, IReadOnlyCollection<ByteString> NBIHGBLJMAF, IReadOnlyCollection<ByteString> MHALFNMDDDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PPOKFMDBAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool KJPLOCMGHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public NMMDMJGAOGB LPIAAJLJDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public BCCPEHCHACO? EHAALIIKBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public BCCPEHCHACO? MHCJEHDHDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public IAAIBGHJPDJ BILIHKLPMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public NCFHNJEGJNA DBCPFOMCBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public JILIKIPPEPC FIGOPENDOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public OMCPLDCBEMK GDDEOLMAAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public GBPONPDANLH<BLMFKKELJGG> GKGLCFADDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public LGAFBGLPDCL GJFDDHAAJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<OEAGPMFPCEL> CDAILMPJDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> LAOANIIPEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public BDJFIFGDPJB JPEFBLBGFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool LNDAHPAMJJP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool BOOAFNEPLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B28480", Offset = "0x6B26E80", VA = "0x186B28480")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BCCPEHCHACO
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private const float ILOINLABOPH = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Vector3 EJEBFMEPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Quaternion PCIAHIPKDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float FCFDEHNOPJK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 CAJABBJDNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DB70", Offset = "0x6B0C570", VA = "0x186B0DB70")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS AKHOKNHGIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DB30", Offset = "0x6B0C530", VA = "0x186B0DB30")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xD84F50", Offset = "0xD83950", VA = "0x180D84F50")]
	public BCCPEHCHACO(Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, float FCFDEHNOPJK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DD70", Offset = "0x6B0C770", VA = "0x186B0DD70")]
	public BCCPEHCHACO(UniformTRS GIILFFLGGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D820", Offset = "0x6B0C220", VA = "0x186B0D820")]
	public static BCCPEHCHACO EEFKLEJPLPI(BCCPEHCHACO KMAENCDMJDN, BCCPEHCHACO LOFABDLPHIE)
	{
		return default(BCCPEHCHACO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D5A0", Offset = "0x6B0BFA0", VA = "0x186B0D5A0")]
	public static BCCPEHCHACO DBMBPMAANBF((Vector3, Quaternion, float) LNCKNHNHHDF)
	{
		return default(BCCPEHCHACO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D5C0", Offset = "0x6B0BFC0", VA = "0x186B0D5C0")]
	public static BCCPEHCHACO DBMBPMAANBF(Matrix4x4 PKEDODFODMJ)
	{
		return default(BCCPEHCHACO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DCE0", Offset = "0x6B0C6E0", VA = "0x186B0DCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D740", Offset = "0x6B0C140", VA = "0x186B0D740")]
	public BCCPEHCHACO DCGICKALGJJ(Matrix4x4 ICGEMCDDICC)
	{
		return default(BCCPEHCHACO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DC70", Offset = "0x6B0C670", VA = "0x186B0DC70")]
	public static BCCPEHCHACO NJHHMPJOPCJ(Vector3 EJEBFMEPKGF)
	{
		return default(BCCPEHCHACO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DAA0", Offset = "0x6B0C4A0", VA = "0x186B0DAA0")]
	public readonly NFCBEHPCJJE FHEFLLNDDHM()
	{
		return default(NFCBEHPCJJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EDIAGPLCOPD
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B29540", Offset = "0x6B27F40", VA = "0x186B29540")]
	public static BCCPEHCHACO ELMEMIIIIOG([In] this NFCBEHPCJJE NKCEKILMAAM)
	{
		return default(BCCPEHCHACO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum GHOEBJOMJPM
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct KDDMIDKHACH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly KLEDGAINCPK KHMHENJHBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private readonly NEIFONLMJBM GLJDPEDIOLC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xFFE660", Offset = "0xFFD060", VA = "0x180FFE660")]
	private KDDMIDKHACH(KLEDGAINCPK CJJFHMMBLHB, NEIFONLMJBM LBLKBALBFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B840", Offset = "0x6B2A240", VA = "0x186B2B840")]
	public CLNHCBPGBDN GLAOIFFOFLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B8B0", Offset = "0x6B2A2B0", VA = "0x186B2B8B0")]
	public static CDOLGFBAJII<GGAHLJNLOPE, KDDMIDKHACH> OOAFHJGKFEK(GJBKLDBLKEL<AJBBHDJGBPP> LBLKBALBFNO)
	{
		return default(CDOLGFBAJII<GGAHLJNLOPE, KDDMIDKHACH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B960", Offset = "0x6B2A360", VA = "0x186B2B960")]
	public static CDOLGFBAJII<GGAHLJNLOPE, KDDMIDKHACH> OOAFHJGKFEK(CLNHCBPGBDN LBLKBALBFNO)
	{
		return default(CDOLGFBAJII<GGAHLJNLOPE, KDDMIDKHACH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BA10", Offset = "0x6B2A410", VA = "0x186B2BA10")]
	public static CDOLGFBAJII<GGAHLJNLOPE, KDDMIDKHACH> OOAFHJGKFEK(string HMGNLNFBHIB)
	{
		return default(CDOLGFBAJII<GGAHLJNLOPE, KDDMIDKHACH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum KLEDGAINCPK
{
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PLLJBOCMMMG : IDisposable, LJEMIAKCBLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private NativeList<GIIFOCGKODC> FEOOCIJHICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private float HMNPJDMJMKF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NLDPOFDOMMH LJICIACMLME
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		[CompilerGenerated]
		get
		{
			return default(NLDPOFDOMMH);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x889F40", Offset = "0x888940", VA = "0x180889F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MDDFCHGHEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B30220", Offset = "0x6B2EC20", VA = "0x186B30220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PKFIAGLNODL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6B308C0", Offset = "0x6B2F2C0", VA = "0x186B308C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<PMFDCBAJLCE> AHNJPMGDIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int ONCNEAAIIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B301E0", Offset = "0x6B2EBE0", VA = "0x186B301E0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float HKOIAJEPCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6B314C0", Offset = "0x6B2FEC0", VA = "0x186B314C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B31650", Offset = "0x6B30050", VA = "0x186B31650")]
	public PLLJBOCMMMG(NLDPOFDOMMH DLDAJAKJJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F570", Offset = "0x6B2DF70", VA = "0x186B2F570", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B303F0", Offset = "0x6B2EDF0", VA = "0x186B303F0")]
	public Vector3 LCFGPACIMNO(int PMJJDLNJJBC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B308D0", Offset = "0x6B2F2D0", VA = "0x186B308D0", Slot = "6")]
	public Quaternion MPJKFNKMHOG(int PMJJDLNJJBC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B312D0", Offset = "0x6B2FCD0", VA = "0x186B312D0", Slot = "5")]
	public Vector3 NPPMHMEIMFF(int PMJJDLNJJBC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B30290", Offset = "0x6B2EC90", VA = "0x186B30290", Slot = "7")]
	public float KDCAHINOBCH(int PMJJDLNJJBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F720", Offset = "0x6B2E120", VA = "0x186B2F720")]
	public void GDNJDLIFAHH(Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, float KGJKNMNONHN, bool AMPCKCBFJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B30230", Offset = "0x6B2EC30", VA = "0x186B30230")]
	private bool IMLLDIKEJMF(int BHMFLLJKBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EE00", Offset = "0x6B2D800", VA = "0x186B2EE00")]
	public void AILPLOHPCBJ(Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, float KGJKNMNONHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B302F0", Offset = "0x6B2ECF0", VA = "0x186B302F0")]
	public void KICIMCLCDKN(int BHMFLLJKBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F5D0", Offset = "0x6B2DFD0", VA = "0x186B2F5D0")]
	public void FAHMOAEDKPM(int BHMFLLJKBGI, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, float KGJKNMNONHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B30030", Offset = "0x6B2EA30", VA = "0x186B30030")]
	public void GJOLEPJACDH(int BHMFLLJKBGI, float3 EJEBFMEPKGF, quaternion PCIAHIPKDFG, float KGJKNMNONHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6B31370", Offset = "0x6B2FD70", VA = "0x186B31370")]
	public void OAFNDMAOOAJ(int BHMFLLJKBGI, Vector3 EJEBFMEPKGF, float KGJKNMNONHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EF80", Offset = "0x6B2D980", VA = "0x186B2EF80")]
	public void CFBMKJMGLGB(int BHMFLLJKBGI, Vector3 MLNCIIKLLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B30A00", Offset = "0x6B2F400", VA = "0x186B30A00")]
	public static Quaternion NCAMKLNLEFE(Quaternion GNJAOBEFJHH, int BHMFLLJKBGI, float JBAIIILOEMN, LJEMIAKCBLA CDNGDGIHDCC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F0E0", Offset = "0x6B2DAE0", VA = "0x186B2F0E0")]
	public Bounds CJPIKLFPBEG(Transform ICGEMCDDICC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B30380", Offset = "0x6B2ED80", VA = "0x186B30380", Slot = "10")]
	public virtual void KMCOOBFDPKN(bool LAMOPLKCCKN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B31200", Offset = "0x6B2FC00", VA = "0x186B31200")]
	public NativeList<GIIFOCGKODC> NFLHNDOBBMN(float MFEDBKHBMMP = 1f)
	{
		return default(NativeList<GIIFOCGKODC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PMFDCBAJLCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float3 EDBNILFNKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public float PNLDMHIFGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public quaternion IEFPFHMDFEH;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B31C30", Offset = "0x6B30630", VA = "0x186B31C30")]
	public PMFDCBAJLCE(Vector3 BJFHPDFPFFI, Quaternion GNJAOBEFJHH, float KGJKNMNONHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B316E0", Offset = "0x6B300E0", VA = "0x186B316E0")]
	public Quaternion FBMEOPEGADA(Vector3 FJODMBFILLK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B31940", Offset = "0x6B30340", VA = "0x186B31940")]
	public PMFDCBAJLCE JNNGJDGOOPN(Vector3 HIKPIHOFEML, Vector3 BGEAHBEJEMA, Vector3 NBIDBAFJHLN)
	{
		return default(PMFDCBAJLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B317A0", Offset = "0x6B301A0", VA = "0x186B317A0")]
	public NEFLPPPCOIF JEPAMOIFOIC(Vector3 FJODMBFILLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class COIJOENGKGN : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B28C10", Offset = "0x6B27610", VA = "0x186B28C10", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6B28F70", Offset = "0x6B27970", VA = "0x186B28F70")]
	private void EGOBIGPJOFE(Dictionary<Guid, Guid> HLLJKNEGMON, BCEDHAMNLAB CPAPNDBMAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B28C90", Offset = "0x6B27690", VA = "0x186B28C90")]
	private void EGOBIGPJOFE(Dictionary<Guid, Guid> HLLJKNEGMON, DIHAMAKMCOB ODFKJCMDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B28CF0", Offset = "0x6B276F0", VA = "0x186B28CF0")]
	private void EGOBIGPJOFE(Dictionary<Guid, Guid> HLLJKNEGMON, JKCKNBPINPB GLKHFDBLHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public COIJOENGKGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class HPMHLFIEKOB : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A8A0", Offset = "0x6B292A0", VA = "0x186B2A8A0", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public HPMHLFIEKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class HBIJPNAPACJ : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A740", Offset = "0x6B29140", VA = "0x186B2A740", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public HBIJPNAPACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MNBOLCEMOPE : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EB60", Offset = "0x6B2D560", VA = "0x186B2EB60", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public MNBOLCEMOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class JHAOAEDLCDL : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B620", Offset = "0x6B2A020", VA = "0x186B2B620", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public JHAOAEDLCDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NDMHNGFLKEP : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B2ECC0", Offset = "0x6B2D6C0", VA = "0x186B2ECC0", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public NDMHNGFLKEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CJBGIIIGPDM : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B288A0", Offset = "0x6B272A0", VA = "0x186B288A0", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public CJBGIIIGPDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BFIIIIKIALO : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B28710", Offset = "0x6B27110", VA = "0x186B28710", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public BFIIIIKIALO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class LLGGNHNNOEK : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CF40", Offset = "0x6B2B940", VA = "0x186B2CF40", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public LLGGNHNNOEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KFIBCJIIMKE : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BAD0", Offset = "0x6B2A4D0", VA = "0x186B2BAD0", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public KFIBCJIIMKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class LJEIBJAFDKB : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CE40", Offset = "0x6B2B840", VA = "0x186B2CE40", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public LJEIBJAFDKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class MBECOBEGHPJ : BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public static readonly IAJNMCAKGAN DECOAOHGNGF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D0F0", Offset = "0x6B2BAF0", VA = "0x186B2D0F0", Slot = "4")]
	public void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public MBECOBEGHPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct ABDIJKIBEKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public OEONGJBPPJN MOOGIOAAOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public GCODPBGGDIB OEHBAGJFMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<int, int> OMJKBHONCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public Dictionary<Guid, Guid> KOGFJLPJFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public BDJFIFGDPJB JPEFBLBGFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public bool PJCMNKAAOIH;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BKAPNFHCBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHCABJPFPAH(BLLMCIEIGDL NAPKIJCBKGH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class EOLBKCFHKOA
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly BKAPNFHCBFF[] KGGEIBALKEL;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6B29600", Offset = "0x6B28000", VA = "0x186B29600")]
	public static void BEHKAFBCGBJ(OEAGPMFPCEL LNCKNHNHHDF, Dictionary<Guid, Guid> OAKBJFAANED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B29EE0", Offset = "0x6B288E0", VA = "0x186B29EE0")]
	public static void PGEGHIGLNJM(OEAGPMFPCEL? LNCKNHNHHDF, BNOOMMFACNI ADDHEBAGJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6B29C60", Offset = "0x6B28660", VA = "0x186B29C60")]
	public static void NGDGOCADCPK(OEAGPMFPCEL? LNCKNHNHHDF, BNOOMMFACNI FMGOLLHOICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6B29890", Offset = "0x6B28290", VA = "0x186B29890")]
	public static void HNBFPGKBMPM(BLLMCIEIGDL NAPKIJCBKGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct BLLMCIEIGDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public OEONGJBPPJN HOKBFOELEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public OEAGPMFPCEL OKFKNACKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<int, int> OMJKBHONCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public Dictionary<Guid, Guid> KOGFJLPJFBN;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6B28800", Offset = "0x6B27200", VA = "0x186B28800")]
	public Guid JJJFHGLDJMI(Guid OKMPNEEAGBI)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface BDJFIFGDPJB
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int JEPGELAHFFF, [Out] Guid BLNMKBJOHDG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class MFEIMCNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private static readonly ProfilerMarker CIHMFPLCMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<string> ILMEEOBLNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly Dictionary<long, int> OINPIIBGAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly HashSet<Guid> NCPIBJNHFCG;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> LKOGCIJNCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> IGJCOAABCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D860", Offset = "0x6B2C260", VA = "0x186B2D860")]
	public static MFEIMCNAPBK DPCBNKCNKLB(EGDKLHCLIKL HCKNFILJEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D8D0", Offset = "0x6B2C2D0", VA = "0x186B2D8D0")]
	public static MFEIMCNAPBK EBEFGAIKPOC(PAHJFKLNJGA EKDMAOLJGLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D9B0", Offset = "0x6B2C3B0", VA = "0x186B2D9B0")]
	public static MFEIMCNAPBK JDGBEFCCJFN(IEnumerable<string> ILMEEOBLNLB, IDictionary<long, int> FPCCEGDKCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EA40", Offset = "0x6B2D440", VA = "0x186B2EA40")]
	private MFEIMCNAPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E900", Offset = "0x6B2D300", VA = "0x186B2E900")]
	private MFEIMCNAPBK(IEnumerable<string> ILMEEOBLNLB, IDictionary<long, int> FPCCEGDKCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E640", Offset = "0x6B2D040", VA = "0x186B2E640")]
	private void LMFPDAIIEKE(EGDKLHCLIKL HCKNFILJEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DFD0", Offset = "0x6B2C9D0", VA = "0x186B2DFD0")]
	private void LMFPDAIIEKE(PAHJFKLNJGA EKDMAOLJGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D220", Offset = "0x6B2BC20", VA = "0x186B2D220")]
	private void CNAKECMEFPN(ByteString? KPDMDKGEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E1D0", Offset = "0x6B2CBD0", VA = "0x186B2E1D0")]
	private void LMFPDAIIEKE(HLMIBCLLBGJ? BAFHJDFHJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DE90", Offset = "0x6B2C890", VA = "0x186B2DE90")]
	private void LMFPDAIIEKE(FLBNNHOHAHM? AOOGCKADIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DB30", Offset = "0x6B2C530", VA = "0x186B2DB30")]
	private void LMFPDAIIEKE(OEAGPMFPCEL? OKFKNACKKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D940", Offset = "0x6B2C340", VA = "0x186B2D940")]
	private void GCGPAPBBAJF(string? PLNBFCHOFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D790", Offset = "0x6B2C190", VA = "0x186B2D790")]
	private void COIPEOJBAHG(long ABEKDMBCADJ, Guid PPABIGODAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D740", Offset = "0x6B2C140", VA = "0x186B2D740")]
	private void COIPEOJBAHG(PALCDMNLJMG? CNGDENEEENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D6E0", Offset = "0x6B2C0E0", VA = "0x186B2D6E0")]
	private void COIPEOJBAHG(PBPPIOBJIDN? CNGDENEEENE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct KMFIPAODNMB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class IMOIFJPBGJG : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly IEnumerator<DictionaryEntry> BJLCJBDKLFF;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry KGMHPEAAHML
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6B2AAD0", Offset = "0x6B294D0", VA = "0x186B2AAD0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6B2ABA0", Offset = "0x6B295A0", VA = "0x186B2ABA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object ADJCIFCGLHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6B2AC50", Offset = "0x6B29650", VA = "0x186B2AC50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6B2A9F0", Offset = "0x6B293F0", VA = "0x186B2A9F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
		public IMOIFJPBGJG(IEnumerator<DictionaryEntry> BJLCJBDKLFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6B2A950", Offset = "0x6B29350", VA = "0x186B2A950", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6B2A9A0", Offset = "0x6B293A0", VA = "0x186B2A9A0", Slot = "9")]
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
		private sealed class BABJHFCKHAA : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xE738F0", Offset = "0xE722F0", VA = "0x180E738F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B286C0", Offset = "0x6B270C0", VA = "0x186B286C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
			[DebuggerHidden]
			public BABJHFCKHAA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6B28570", Offset = "0x6B26F70", VA = "0x186B28570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6B28670", Offset = "0x6B27070", VA = "0x186B28670", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B32280", Offset = "0x6B30C80", VA = "0x186B32280", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object COMNIKKFEEB]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6B32190", Offset = "0x6B30B90", VA = "0x186B32190", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6B32360", Offset = "0x6B30D60", VA = "0x186B32360", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6B320D0", Offset = "0x6B30AD0", VA = "0x186B320D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6B32130", Offset = "0x6B30B30", VA = "0x186B32130", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6B32300", Offset = "0x6B30D00", VA = "0x186B32300", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6B31D90", Offset = "0x6B30790", VA = "0x186B31D90", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6B31DF0", Offset = "0x6B307F0", VA = "0x186B31DF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6B31E50", Offset = "0x6B30850", VA = "0x186B31E50", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
		public RoomObjectCounts(Dictionary<int, int> DKEMJBKJLLA, [Optional] Dictionary<int, int> GIPFMOGIGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B31CB0", Offset = "0x6B306B0", VA = "0x186B31CB0")]
		[IteratorStateMachine(typeof(BABJHFCKHAA))]
		private IEnumerator<DictionaryEntry> MCHHOKDAFOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B323B0", Offset = "0x6B30DB0", VA = "0x186B323B0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B31FD0", Offset = "0x6B309D0", VA = "0x186B31FD0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6B31EB0", Offset = "0x6B308B0", VA = "0x186B31EB0", Slot = "9")]
		void IDictionary.Add(object COMNIKKFEEB, object IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6B31F10", Offset = "0x6B30910", VA = "0x186B31F10", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6B31F70", Offset = "0x6B30970", VA = "0x186B31F70", Slot = "8")]
		bool IDictionary.Contains(object COMNIKKFEEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B32070", Offset = "0x6B30A70", VA = "0x186B32070", Slot = "14")]
		void IDictionary.Remove(object COMNIKKFEEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6B31D30", Offset = "0x6B30730", VA = "0x186B31D30", Slot = "15")]
		void ICollection.CopyTo(Array FEMJEOMOEIN, int ENMILGHAHOM)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class CNOFLNNJDHG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xE738F0", Offset = "0xE722F0", VA = "0x180E738F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B28BC0", Offset = "0x6B275C0", VA = "0x186B28BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
			[DebuggerHidden]
			public CNOFLNNJDHG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6B28A30", Offset = "0x6B27430", VA = "0x186B28A30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6B28B70", Offset = "0x6B27570", VA = "0x186B28B70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B2B340", Offset = "0x6B29D40", VA = "0x186B2B340", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object COMNIKKFEEB]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6B2B210", Offset = "0x6B29C10", VA = "0x186B2B210", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6B2B3F0", Offset = "0x6B29DF0", VA = "0x186B2B3F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6B2B150", Offset = "0x6B29B50", VA = "0x186B2B150", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6B2B1B0", Offset = "0x6B29BB0", VA = "0x186B2B1B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6B2B390", Offset = "0x6B29D90", VA = "0x186B2B390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6B2ADD0", Offset = "0x6B297D0", VA = "0x186B2ADD0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6B2AE30", Offset = "0x6B29830", VA = "0x186B2AE30", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6B2AE90", Offset = "0x6B29890", VA = "0x186B2AE90", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x212C0C0", Offset = "0x212AAC0", VA = "0x18212C0C0")]
		public Invention(long DNICIAANFHD, int CMNDBGDABDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AD00", Offset = "0x6B29700", VA = "0x186B2AD00")]
		[IteratorStateMachine(typeof(CNOFLNNJDHG))]
		private IEnumerator<DictionaryEntry> MCHHOKDAFOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B440", Offset = "0x6B29E40", VA = "0x186B2B440", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B010", Offset = "0x6B29A10", VA = "0x186B2B010", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AEF0", Offset = "0x6B298F0", VA = "0x186B2AEF0", Slot = "9")]
		void IDictionary.Add(object COMNIKKFEEB, object IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AF50", Offset = "0x6B29950", VA = "0x186B2AF50", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AFB0", Offset = "0x6B299B0", VA = "0x186B2AFB0", Slot = "8")]
		bool IDictionary.Contains(object COMNIKKFEEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B0F0", Offset = "0x6B29AF0", VA = "0x186B2B0F0", Slot = "14")]
		void IDictionary.Remove(object COMNIKKFEEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AD70", Offset = "0x6B29770", VA = "0x186B2AD70", Slot = "15")]
		void ICollection.CopyTo(Array FEMJEOMOEIN, int ENMILGHAHOM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> KDFEJGNMDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public readonly IReadOnlyList<Invention> BFFIDMECIHP;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
	public KMFIPAODNMB(IReadOnlyDictionary<Guid, RoomObjectCounts> CNCHNJGIAGL, IReadOnlyList<Invention> BPMPACAKNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BDA0", Offset = "0x6B2A7A0", VA = "0x186B2BDA0")]
	public static KMFIPAODNMB DPCBNKCNKLB(EGDKLHCLIKL HCKNFILJEND)
	{
		return default(KMFIPAODNMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BC80", Offset = "0x6B2A680", VA = "0x186B2BC80")]
	[CompilerGenerated]
	internal static int BDGKJMCCCEA([In] IReadOnlyDictionary<long, int> INHDJJOFHAA, long? ABEKDMBCADJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C780", Offset = "0x6B2B180", VA = "0x186B2C780")]
	[CompilerGenerated]
	internal static void ELGDGKJADIH(int OKGFANEDEMF, [In] HLMIBCLLBGJ NAIKIBCDGKG, [In] Dictionary<long, int> INHDJJOFHAA, [In] Dictionary<Guid, RoomObjectCounts> CNCHNJGIAGL)
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
