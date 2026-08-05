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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6903CF0", Offset = "0x6902CF0", VA = "0x186903CF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
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
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OIMDBCAPDKK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> GFFOACOODNM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> ELPJJDGMHDE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> LHPGPEGCPHA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string GLENLAKPBFC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JJGKIOOFFPG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string EJNEACCIMKA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6903E00", Offset = "0x6902E00", VA = "0x186903E00")]
	public static bool FKFGKIIAAHD(Guid NDENPPKKJJL, int PBKNJLHCFDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6903D70", Offset = "0x6902D70", VA = "0x186903D70")]
	public static bool DEHBEPOAFIH(Guid NDENPPKKJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6903F00", Offset = "0x6902F00", VA = "0x186903F00")]
	public static string JIHPJGNBPGI(Guid NNFEKLKANBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NLAOEKCOFEE]
public enum BMLEJCGBJFM
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
public static class DPLBEDKKMGD
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid MEGLFNAGLGK;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid LLKPPIABJPB;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid NPLHBLDPJBJ;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid JIMDMCBCPMH;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid LJGLPOOCGDL;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid NFPMGMKLBLF;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid CLEJJLCJFOA;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid GJMDPMFNBPD;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid PDBAGLLFEMM;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid EGMPDJMNGLE;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid HMOMCGKHGHP;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid ALDCCPNHHII;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid EANDLGLEFEO;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid AOELIDGDFON;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid JCKCJKMMFFN;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid ILLJPHPLEGG;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid JJFEODIANPM;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid HDNHJJOAMHH;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid NCFJCGMDDHN;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid DMGJHMPFHGC;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid OEIILAICHJD;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid BCEBFEFGHFJ;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid LEGBAKMIELM;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid EGDOKEFJPFL;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid NNJCADBFKJM;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid OJFMKIMNEMJ;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid HCGCJBGPGIM;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid ONEHLALPFCG;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid IDFJBBBFEPN;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid IJHONPMPJIE;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid ABAPAJFIKLO;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid KAFEBNAFDHL;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid FMKKCICBFGP;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid JGJFFOOLGJK;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid JLLMBLFFOAK;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid POJLJOGKBGD;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid FDFBJHIEBDE;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid ACKJOJDILHK;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid NDKOMLKJACB;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid KJHONECMOHH;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid EJJEIBIOJPF;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid ILMGBHGGHJO;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid GIPCJBIKOLK;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid CLIAAACNHOE;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid HMPDHJHLGEJ;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid ACOIFJABHMM;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid PGJGLPFAACD;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid NDANNKPOOAP;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid EKNIJBAFJMI;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid PKEFFJCGGKG;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CBANDAFKDCN;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid IJKNMKBIMAC;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid PGJBAANJENH;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid CGBOMAGNADF;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid HHAGPOPPFCP;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid BLKBJJEOIKI;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid OJLEODOJNAB;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid FDDGPCDNMMH;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid BLLFJCGEKLD;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid NAKMGJBOIOP;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid PFEAMJJFJML;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid NBECOAJDDCJ;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid CNKAMIKNHEO;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid JOALPJHDOKF;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid GPPONIKFILA;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid GKCGALAPAFD;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid LGHKJIFEDPB;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid JLNODPMELKE;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid NLBBBEJIJFN;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid ADGBALPKAJE;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid KHFCMDJLOJF;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid ONPDHNKFMMD;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid LNDNOOMABPN;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid LAKLCPNKEKJ;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid BJNMHIENHKP;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid MOLDLLBDLBA;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid OMPJCAPEOAI;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid MBKIPHJJIDA;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid CIAMBOMGGIC;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid PJIOCPFMFLN;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid MOMDALIDFBF;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid JIBDBANPNGK;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid IAPDPNHDHMB;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid DACBFLBHAEM;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KJBPHNDCNHP;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid MMNHDOLPCKP;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MFPDPAPCAOI;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid FHBCMKFCHKI;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid HLPPOEBKODL;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid IKKLHNMBPNM;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid EFDLFHEPLGD;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid DPPODKLHLDM;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid EKJIPLPILGK;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid NDOJEAIMPPB;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid LNHACEGHFGF;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid FHEPIMDMOEC;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid NPCNFBJKFFN;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid FHMAOAHGAIJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid JCIIMPBGANB;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid OAPNIAMOMBF;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid CPBGLMIPGAN;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid PNCEOPPDJEM;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid OLLPKDOABNN;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid HJKMAIHPIDN;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid DEAGBNNHMPI;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid LMOLHDOLBPD;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid PLMALKFIOML;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid BCOPMNENGJF;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid GKDMAPKLLBE;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid NDLPCDLKNEG;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid IAPFJFGFJFG;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid JIDBAEJFPGE;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid EIBGBGBHHCM;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid GMENGACJBCN;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid FFOHLPKFHEI;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid DIPCBCJANEK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid FNNEJBNLAPA;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid FCLBECAKHDG;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid FKEJLECHDLB;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid GMLLHNIPINN;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid PKCEGGJOJCK;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid DBDGLGLBIGF;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid FPGGCIPJJNG;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid CNLGDGENKHB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid FODBAIKBJAJ;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid DOMDICKDGHI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid MECHBAKEBFL;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid MLHEEPNAIMO;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid JGDGCOOEHDH;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid MGFNCFNCHKI;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid OEJMCENDCOD;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid HNLFKEDCKBL;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid LACBGDPAMEJ;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid GDGKMANNBFP;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid KCIKLBGMJIB;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid GAIIHFDNELP;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid MPPCOKOIEMG;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid NOLOIIFOLHM;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid DJDPJJHHPLE;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid MPDKMCLIMFC;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid KPPGDNPOPDN;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid PLHJANNNKIN;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid ECOFILCLEFD;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid COMLOKKPGBL;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid OFHHDLODJEF;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid KMKBKNMMCFL;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid LLKFFINEJMG;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid BKDIAKOEEPH;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid OMKIENAAEBL;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid HLMEMEJHHEO;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid ECMFKNHEGBP;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid DKBBLFHEMLO;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid LAKEKPNIAFM;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid CJAPFMNBHKO;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid FIMPCJLDEFD;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid CGEOKKMMCEH;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid EDFFHHJGHMO;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid JHBEDMMCJAM;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid KHIGJNCEHJJ;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HNIIPGIKIJB;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid HBOIMOAHEGN;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid CGGEIGKPNIB;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid IKAIFEJIOPG;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid DNBJENABFJI;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid BFKKMGNKCHK;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid BFJNJLFJJKH;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid EFLKNOGCHNP;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid DHCDINCNFJM;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid PCJFIBJPABB;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid GMKOBIBLIEA;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid CIHJDOJKBAK;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid OEHJJFMFBCB;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid ONKPGBKPGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid LBFPFPNOHBF;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid FFOPLBKDMNH;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid PFAJBCEEANK;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid OKCLBEALHCK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid CMHOMIPNKHI;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid GKBGNMIBDHO;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid IOAGDDLBFMH;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid ENPDBALAMHL;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid JICKOAPMKGI;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid FCKMOKMGELC;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid MBNGCBJADKL;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid GKKGBBMOKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid MMHCCKFDHKL;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid HKMJODOPMME;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid MKLJABKMDOL;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid AEKILBGMOLL;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid BAEBOJPEBEM;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid NPDBGLOHBEJ;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid MDBNCGNAJCL;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid KKFKPHEFOEK;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid ECGBCPKIJMP;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid MECHHAEHIEJ;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid LDJGIGBLAIB;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid PPFDNGECEKK;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid JJEHMELJCPK;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid CNMHGECFLBK;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid DFHOANOGDOG;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid NNPPEFOMJNI;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid FOPDBPAHFGO;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid PKLBBGOOIHN;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid NNNMECGAPNN;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid CMLCEPKGLEG;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid OIKPACEIODM;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid OLEHLLCLEKK;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid ELJDBOMCFCA;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid ONMOKCJMIFE;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid KIIFLGOBHMD;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid DBPHIGHIIJG;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid OKGMJKPHCKM;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid DJAHMOCDACO;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid HHLAGIFEAEE;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid EEAKLJNGAKM;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid HNJGNJPFHGM;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CIFOEJCJAEJ;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid OMMKNDMIOJA;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid HCLCDGKDBJE;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid ANJCBMPCPLN;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid ECGAKIOEBBN;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DGADCNMBIAI;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid MOFOHPKHHAK;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid BONFNAFPGHN;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid EFPJLCBFLBN;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid MBAKBCALMNJ;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid PCMEIFHBCKF;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid PAOFGEIADOH;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid KLOMJAJGEND;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid LCFEMPIAECI;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GMDLJMPMAHI;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid KBPGFBEACNP;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid NEKKAMDONKA;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid PDHKCKLDJIM;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid JJACIEALPNI;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid IJOHBLNDKLI;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid ONEAAMHIPAK;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid LEGGMPLDPCK;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid JCDIDLBAIBC;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid GBGNAPGLCHE;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid FOHBOICLNEK;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid NKNMOGBBJNO;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid JPJABBPGBHG;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid MOBFHHKGJHF;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid DLLMJCPGLGM;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid OAMOBNGIPPH;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid FKGCFJLNEGG;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid FJKGNBEEIEL;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid OAKIACILDIH;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid AMBFGMDNOGB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid HBKDHJCKFIE;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid PLMFJLFBOKM;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid EDMGEFFDLNJ;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid JGJHFBGICKA;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid HGLKDGHGIMD;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid EIMKOFJBBHK;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid BCDNOJAEBNE;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid KGDDNDKABCG;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid HOFBHDINNKK;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid JEHEFFNJIMN;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid CKNAHHNIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid EGPMGBDPAFD;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid MDPHAHAPBBM;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid PAIDHOFAMGA;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid JNGDNCOAINC;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid IIDEJGBAALE;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid KHDEOIAHAOH;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid JCGKAJOLPKP;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid FKCMMAJCFKG;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid CACBIJOJHCP;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid EIFMFBGBPKC;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid CFCAMNGHEGM;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid BMFFFCKLHHD;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid NFDJIBKOCFD;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid DBCOCGHNKBO;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MKJOMPAPOFJ;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid MPBACNGMLAA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid KGFHCDOIKGE;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid HEJMPKOIOEJ;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid KCFBEPJFJJD;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid HIAOANCOBNN;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid DFOGGOENDME;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid KJINOJOLPAN;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid GOCBFGKAMFH;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid CDJPLIMCPJC;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid BFOHEKHFFNC;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid EOMNACILMIA;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid IEJMOJBNIAF;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid HOPIMKCDPGF;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid FCPCJLAADMI;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid GDKPAIOHDOK;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid EBKMCHONFCP;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid DBPBLLKIHCN;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid CFDDOLICGOB;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid GMLLMDDOBPP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid FGODBIIDJEN;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid AHHCPCDGJPO;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid NIFIPJJKCCI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid GNDCLHKKMAC;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid HGPPMOOAGGC;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid OFEEALLHAJK;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid AKJNEJAPFBO;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid IOLLPJGFMAM;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid OGIDHPFFBMN;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid GLGCDJIEEEF;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid OJOIGGIMFBG;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AIOAAMFHPBC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid BKDBKPKADHN;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid NEJLIPPMDCL;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid AGBEBBPOBOK;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid JFLLBBLJJOF;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid BJFICBFENHD;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid FOBDPMJADBM;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid PALAMJCIHLH;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid JEFOAMIEBLB;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid AHBJCLKGJJK;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid EHOCOCOJFEK;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid JILBDGAAAMM;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid DLLPOFGEJDA;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid KLKBOGFEFIM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid NJMMFGDEJCP;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid GAOIPHHKCNE;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HMEMJFPCMBP;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid EIDLOEPDPJP;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid IJHNBHECBPH;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid JJFDBPLDCCD;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid DILEHFLIACH;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid COCMJEIJIJD;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid IJKGJKMIBGD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid IBNHOGBMECF;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid PLOGEJJHHDI;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid MBJFDBPPABC;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid LNMGDFDPPNH;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid OLFAEDEIFFD;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid CPABNONBAGB;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid NMDHFGHMEHB;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid NMDGPHMBEGH;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid GJOKMOOIOMK;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid ENEDAPFDEGK;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid OLJJEGINMOB;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid DOHIGNPKAMD;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid IAMJAJMOKCH;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid JMLNLHOENOD;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid EFCEHONCDHF;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid GAPCKEJGBGK;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid EBFCNNBIFGM;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid HMPIBFNJKNN;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid HJDBJNJLJJC;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid CCKAHGLJFOB;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid NFAKOKCMFKM;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid OLNALGJGLOD;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid JKEIIKAIAHA;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid PDEBCOFECIH;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid EIJCDFGFPPO;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid LEEGENKKJCO;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid NOCIHHPNAPE;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid NIOADCNKNLO;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid EIAINIBDMEI;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid FCMMBOGMDKF;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid AEBJHEIOJOC;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid MOPIHBCEBDD;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid PNAAELCJAOB;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid CGCPLAJAALB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EKPDHONDNPD;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid PJAFEPMCMFN;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid EJFAIBGMGPA;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid PDMGDNMMJPF;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid FLDODFGFHED;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid JABECHOOGCI;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid IJFHIIBHHHD;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid FPBNANCIMFL;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid EFJLACJEMIO;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid BMGOPEOAMDM;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid HMIAGIBGEKB;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid GFODFIDOJGA;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid MMLDDIJJIAP;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid NEKHNJHEHCP;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid EAHBMMNMCGD;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid NGHCPKEKODJ;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid GEILIHACCCD;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid JBJGCLKBLFG;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid KGIAKMAFGDL;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid AEIINNEDKIM;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid EEKFDILFFDI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid OKEBEINBONM;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid NAPGKMJEOED;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid HHLJLIBLCKJ;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid BINHFJOFMEJ;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid OPMFEHEDCMK;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid BHPHONJMCKK;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid IMEHFFCJEAG;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid NLOKAHHNBEA;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid BJOGHGCJHKM;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid JKPPDCCFGGN;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid NJDPLFLLPNP;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid LNEMPLJLMLP;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid MKAOLAKILCF;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid GELKEAFGIKK;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid FDGBMMCLDMP;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid ACNPOCFGOAF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid KLKFBLPFHJB;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid FABAGBMPGEN;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid NDHFABCMMOM;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid LDNKDEGEANM;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid OPCEFOAPMNA;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid FCIHGLGKALN;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid JADBLDFCIPD;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid BCNMFFJLHAL;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid HLHHPABIBKO;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid GJFCDEALKMD;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid BBCLAHPFKLK;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid ALPHPLHHMOD;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid GNBJIBKJEJG;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid PAMDENCPLGM;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid EBGFEDHIEBC;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid MELJAGBLMIK;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid AJMPKPBGCMG;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid DDPLCMBHHFF;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LDAJDJPMPOL;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid PGEHNCCPHKE;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid IKJNDFCOPJI;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid JHOFJEBBGOF;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GAJAMNKCMDB;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid CAFKMBGLFOG;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid CKILGGLAHAI;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid LPHOCGNDOGM;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid MBDHGJJHIFK;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid CEKKDBIIAJP;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid JKINELBDHFI;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid BOHIJOEIIMA;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid OLCGJPCFKFF;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid APLHHHOFOJD;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid PFBJIEPJLGI;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid ECMAIIGPCJM;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid BEBDKAPHBGD;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid NLANDLFOIJK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid BIPHDGGELNC;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid DAKFCPIJJKF;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid AIGLDDONFFE;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid KINBDGBJDBJ;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MBPPNNFCONJ;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid IDCJICBMGPA;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid KOIFDEEGJOC;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid BAGOCFEJFLJ;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid AKPLFLGJEHG;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid OEIHMMOFGCM;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid MHAOCKCNNLG;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid DDNNAIJOIHF;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid BDDAPPBJNMN;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid OKHIAPABAJH;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid DPCJJGOMAJB;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid GGJHDDHEINL;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid BDHFBJPILPH;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid MCFPBBCINEK;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid ODAFFIFAMHI;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid EBMFGANOJNK;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid PCAAKNEEIJK;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid MJLEKHCEAPG;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid CAIFMHNAKBA;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid LHNGBNNIABM;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid GGBLKIJALIF;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid NAGEJEBOGGM;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid OFPLOJEOPOH;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid MOIAMGJPCJA;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid GPCMOBDBENI;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid MLCPEIMIEGA;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid DNEKLFDEMID;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid NJJMNCPAEBL;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid GNPCEBHGMKF;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid CGICKCHKNHE;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid DOJPFHJIEKJ;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid NDBLNIHBOPA;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid AKPFOBALALD;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid LEAKHKGFINN;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid PNBKFHLOMGP;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid FDCCCFMKPBE;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid NPEJFHPDJNA;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid FDFLBNAAENL;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid CPHAPMFMNIK;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid CKPAECEPHDB;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid CGGHPHOEFEM;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid LALCIKPJIAO;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid PMNCCJLNOJE;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid MILFLJDPHJM;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid ODMCBNGINGE;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid NCOAPDFOCOP;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid FLPLNAIHDJG;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid JMAMPJGCKAP;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid FMGDEKCLLFC;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid EOOBECAGHAG;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid GFPABJPHGJI;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid ICFNMJGFBEN;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid BHPAIJKBDMA;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid FCOJJBBLAHL;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid GCMBBOBALFI;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid KGBOCPGBFOL;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid EHPFJJBOKMD;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid FGOFHDAIADM;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid AKBAKHCAFNO;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid HGIKGMCIDNM;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid BFFMMMECCEB;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid KHNFNDGMABE;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid ALDAMKBJNDL;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid LNJDFILKGAM;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid HDAKPAEHCKD;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid ENMKDBMINHJ;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid KEJCACMOPBG;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid NKCMGOAEFCN;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid GCALNDIFMAE;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid GEAMDHPNJCP;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid GGLPJBPKKCL;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid MICFJPFOCBL;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid EGOGNCEILLF;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid NFBHPBHKLFM;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid KFNNKBILNBP;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid KMJMLEALKLD;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid FIGEHCGGKLA;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid DGIGBJNJHEH;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid KCCKFODNPFA;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid KLLJGLHABAC;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid EBAJIAHIEFB;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid HNGKJPIOBHC;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid CJFDDIIBCGM;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid FONMIKLNHOL;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid HGKKGMGMHCJ;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid PFHEDCKAJCA;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid OFONDFKIJKB;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid KOBNDAPDIGL;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid LPJJOJKPFIC;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid JBLIFFJOAFE;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid LMFDGJDAILN;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid KMFLEAOMHDD;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid CNFCMAJNMKE;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid AADFCMNAFAJ;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid HGIAOBBBOEL;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid JDBGGGBLLIB;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid KNACMLHBGGN;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid MPEIEFJFHHI;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid JJBPAJJIKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid JCHEILKJIPN;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid GNCOCFNGKJP;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid BNLJGBMNNBN;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid OCOFADAFMMM;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid IGACALOHDEP;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid MHEFNAFELJD;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid LCJMDGIJJCP;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid CMBLIHLFGDM;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid MLJCNBLEBKH;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid MEDPPDKJALK;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid MOMPKIKAHDM;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid DKNCABAFBNF;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid DLDDBFKIMJG;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid EDHLACMGFDK;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid JKCHIDIFFLB;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid LGPDICMNOIP;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid JIAOMMCCMJM;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid IJIEDAAAPMN;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid JKPLENNDLDJ;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid BGOENFCHDCD;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid IIOGGADLDKM;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid PHNAINMGLKF;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid MNBAPAIILEP;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid HAJPBOPCDJA;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid CDBHMKMHLEM;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid CHJEPFPBOMH;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid HJMCDLIAGLK;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid KALOHKAIMID;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid HAFPHOCMIJF;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid NACJJDOEOIA;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid NJEJFPKJNIE;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid HEDDBCKACKL;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid GFKGMGGMMLH;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid MBOFIANAKHJ;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid MANALOHDDOP;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid NPHKOPAHKPN;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid OIMPBIEBAFK;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid CAHPEMEBEIA;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid PABPGEKCCFN;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid EGMIJDNMCGA;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid PBGJLICIHEC;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid AAPPAOFKBFB;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid KJJHOLLKDPM;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid OEFNNEIOKPF;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid JPBDNMEIMNE;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid IDPDOPNFKKA;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid NLGOJKHCBEC;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid FJFENDIOLHM;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid NAKPLNKLCGN;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid DINOLLPOENF;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid JKADHKKKJKJ;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid ACPDOGAOIJB;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid AFGMKNKEPDI;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid HNAGEEAGHAH;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid HJIMGGMBADP;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid HAEBJFHMGLH;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid PFGKFLHLAGD;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid ELIINFDIHFI;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid JEIINNOLKKC;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid BFHLCFANOHJ;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid FCPBFMEPPFJ;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid OLPCBCPMDBA;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid HNHLOGKMOIC;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid JHJNBIJDBJM;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid CBBEAEEKNEF;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid KDEIOJHGFFB;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid GNNLMJGLLCE;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid PKKNAALIMAP;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid NFICPFEELEF;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid PBHFBKAFKHA;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid OLEBMCOPNOD;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid HKCACAHLMPP;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid BMHDHIJALGC;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid DEFPABFLOAI;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid HLNNDMIFNJH;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid BLBDEODPJGN;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid LOLLGDDMACF;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid JFBHLKCIOKB;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid EMJIFOLECDI;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid NAGIEMPCNPL;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid BEOBFEJFJFM;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid PLGKKKDGBPG;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid MGDEOCGCMHH;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid KECPJGILBCL;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid JEKCKIFPIKA;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid GBCIBIFJMDB;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, BMLEJCGBJFM> FAOCEPLHHMM;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<BMLEJCGBJFM, Guid> GLEJDHBKPDF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, BMLEJCGBJFM> DOLLHFDFCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68EC060", Offset = "0x68EB060", VA = "0x1868EC060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<BMLEJCGBJFM, Guid> FPDBBFNLNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68EC000", Offset = "0x68EB000", VA = "0x1868EC000")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MALGCJAINIH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69038F0", Offset = "0x69028F0", VA = "0x1869038F0")]
	public static bool AEBHHIIGHKP(HGEFEKJNOMJ COGEBALCJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6903920", Offset = "0x6902920", VA = "0x186903920")]
	private static bool AEBHHIIGHKP(KAIPELELCHG LFGOPFNHKKH, HGEFEKJNOMJ COGEBALCJKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct DHPNINIOCFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly BGBOPJIEMLP HPJMKIIJMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<CGIDLDDLPHO> GFHPEMHACPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<CGIDLDDLPHO> BEDBBEJFJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly HBKKMIFHCOI<EKJMGNHJFDN> DMLFKIMGCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<DAMOFJGJNKL<JMIDFPKEEGG>> KLBONCCENJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString GHNKPOMHHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly ODKGEFHMPDC LIPLLMDFKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool HALOMFNPONP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68E8B00", Offset = "0x68E7B00", VA = "0x1868E8B00")]
	public DHPNINIOCFO(BGBOPJIEMLP HDMOJMNEFHN, IEnumerable<CGIDLDDLPHO> KCIKNADAAIN, IReadOnlyList<CGIDLDDLPHO> DENMEHMDKLA, HBKKMIFHCOI<EKJMGNHJFDN> MJCMBENGNAC, IReadOnlyList<DAMOFJGJNKL<JMIDFPKEEGG>> FJOGMCHBPDM, ByteString ACODPLIKOGO, ODKGEFHMPDC HEJAKDDPCGA, bool AHFBAPJFKCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HICKPMPKDHH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(AAJAFCPHOON FHNKDHIILBL, [Out] Dictionary<int, int> AALDDAOENIE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(NGPKNGOLDBM ONFIGFLCKDD, NAKJLFCCODH PMPKEMELEKE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CICFGBEJCDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid LPCMJJNDKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> OAKKDKAFIDN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> DLCAHAOJIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3989F30", Offset = "0x3988F30", VA = "0x183989F30")]
	private CICFGBEJCDK([In] Guid FFOFFDHHPLH, Dictionary<Guid, Guid> PJEFCFDGHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68E8690", Offset = "0x68E7690", VA = "0x1868E8690")]
	public static CICFGBEJCDK HHPLILCFGND(IReadOnlyDictionary<Guid, Guid> KPAIMNDBBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68E8750", Offset = "0x68E7750", VA = "0x1868E8750")]
	public static CICFGBEJCDK MMOFHMOHNIF(IEnumerable<KeyValuePair<Guid, Guid>> KPAIMNDBBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68E86A0", Offset = "0x68E76A0", VA = "0x1868E86A0")]
	private static Dictionary<Guid, Guid> KMMADIHMOHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68E8510", Offset = "0x68E7510", VA = "0x1868E8510")]
	public Guid AOFIKKPONML([In] Guid NNFEKLKANBO, bool PGLMKLMLGIE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68E8620", Offset = "0x68E7620", VA = "0x1868E8620")]
	public bool ECBJGMCMEMC([In] Guid BLCJLIJFBDL, [Out] Guid KPELOIJANDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CDBJJABDKAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AJKIJLIKGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGNOLJBBCJA(ByteString BCFBKOPNCPH, CICFGBEJCDK DLMMOCDPJNC, [In] UniformTRS IALHOCAIGBH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NHCPDNMKFKA
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
public class NBBEFLCGINI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1507B80", Offset = "0x1506B80", VA = "0x181507B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AJFAHLADNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x101E450", Offset = "0x101D450", VA = "0x18101E450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long ECLLDENJMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6903CD0", Offset = "0x6902CD0", VA = "0x186903CD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x65EB6D0", Offset = "0x65EA6D0", VA = "0x1865EB6D0")]
	public NBBEFLCGINI(long JPBPNOCHNLG, long KAKAKPLKAJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FKNMFHEEJEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, NBBEFLCGINI> AMONDHHOIFP;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> PELFBKGBBJP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long CGKCJOFODKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x101E450", Offset = "0x101D450", VA = "0x18101E450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long CFEHHILNAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1083F60", Offset = "0x1082F60", VA = "0x181083F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68ECE20", Offset = "0x68EBE20", VA = "0x1868ECE20")]
	public static FKNMFHEEJEE COEEBMEJLFO(BGBOPJIEMLP DPPFHMBECFO, DAMOFJGJNKL<EKJMGNHJFDN> MKBENILCEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68ECB50", Offset = "0x68EBB50", VA = "0x1868ECB50")]
	private void AGCODOLAAMJ(KIEKNELDHJG MPJOKOKILNG, long HECJDBGALMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6900DE0", Offset = "0x68FFDE0", VA = "0x186900DE0")]
	public FKNMFHEEJEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CEKLDAHCKIM
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<BMLEJCGBJFM> NOMJEDFOJDO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HPLCKCOFDEE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> LBACKMPJMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> IHFOGACGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86A7E0", Offset = "0x8697E0", VA = "0x18086A7E0")]
	public HPLCKCOFDEE(IReadOnlyDictionary<Guid, Guid> KJJDACEPKNA, IReadOnlyDictionary<Guid, Guid> PIIEGCBKIGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DKCCIDEEKLC
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68E97A0", Offset = "0x68E87A0", VA = "0x1868E97A0")]
	public static JFFCEHBOEME ELHNGLBAADE([In] DHPNINIOCFO NBDEHJMFEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68EB670", Offset = "0x68EA670", VA = "0x1868EB670")]
	private static void NBHMABFECFJ(JFFCEHBOEME MFMCDOHGOGD, [In] DHPNINIOCFO AOKINFJDDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68E9DD0", Offset = "0x68E8DD0", VA = "0x1868E9DD0")]
	public static PIJKHLBEMKP<HPLCKCOFDEE, FPACGEPAPEH> FFDOGOOOLME(JFFCEHBOEME MFMCDOHGOGD, CFAEHLOBLGI MAHLJEHAFJB, CICFGBEJCDK? IHDLCDDGFPE)
	{
		return default(PIJKHLBEMKP<HPLCKCOFDEE, FPACGEPAPEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68E9510", Offset = "0x68E8510", VA = "0x1868E9510")]
	private static void CCPGLLDFPNN(JFFCEHBOEME MFMCDOHGOGD, CICFGBEJCDK? OEGHNALGHJP, CFAEHLOBLGI MAHLJEHAFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68EB600", Offset = "0x68EA600", VA = "0x1868EB600")]
	private static void GCNOEKOALBN(JFFCEHBOEME MFMCDOHGOGD, CFAEHLOBLGI MAHLJEHAFJB, IReadOnlyCollection<ByteString>? CAFHLEOPIDG, IReadOnlyCollection<ByteString>? FGIEHMHFFPP, IReadOnlyCollection<ByteString>? OPGPEDBABHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68E8E70", Offset = "0x68E7E70", VA = "0x1868E8E70")]
	private static bool BEFODFAOMMC(JFFCEHBOEME MFMCDOHGOGD, NGPKNGOLDBM ONFIGFLCKDD, CFAEHLOBLGI MAHLJEHAFJB, [Out][NotNullWhen(false)] string? JCBCIJOKIDD, [Out] Dictionary<int, int> AALDDAOENIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68E8B90", Offset = "0x68E7B90", VA = "0x1868E8B90")]
	private static Dictionary<Guid, KAIPELELCHG> BBNBDMJHPGN(JFFCEHBOEME MFMCDOHGOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68EBCD0", Offset = "0x68EACD0", VA = "0x1868EBCD0")]
	private static void NHENDJKPAHE(bool OPCKIKOAGAG, CGIDLDDLPHO PKKOMHEOCPG, Dictionary<Guid, Guid> AKAEEHGBNJP, CICFGBEJCDK NMAFEEKBEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x68EBD70", Offset = "0x68EAD70", VA = "0x1868EBD70")]
	private static void OIPIFALOGDL(CGIDLDDLPHO PKKOMHEOCPG, Guid GGFDPAFAFIM, DPNJJPOBJGO? PAFCLPNPPBB, Dictionary<Guid, KAIPELELCHG> LHKAIBJCMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68E9920", Offset = "0x68E8920", VA = "0x1868E9920")]
	private static void FBFEBIBPDPC(IEnumerable<CGIDLDDLPHO> PKHHGOMJHDJ, IReadOnlyCollection<ByteString> CAFHLEOPIDG, IReadOnlyCollection<ByteString> FGIEHMHFFPP, IReadOnlyCollection<ByteString> OPGPEDBABHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct CFAEHLOBLGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool OPCKIKOAGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public ODKGEFHMPDC HEJAKDDPCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public DPNJJPOBJGO? PAFCLPNPPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public DPNJJPOBJGO? HEAAIEBNIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public BGBOPJIEMLP CJBGMAHKHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public NHCPDNMKFKA HJFPHEAODKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public HICKPMPKDHH DNNHBMPLEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public CDBJJABDKAP GLPKFEAKIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public DAMOFJGJNKL<EKJMGNHJFDN> PINDFINEKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public GPMBAPNKEOC OPPNKKFAMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<CGIDLDDLPHO> DJHCPAIONIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> OIHNMFANHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public IJCECKEHPLL ENGFPJCNBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool CDPMEGHFHAN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KCLICBLAECD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x68E84C0", Offset = "0x68E74C0", VA = "0x1868E84C0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DPNJJPOBJGO
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float OKPFEMJLLKG = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 MOIICCIPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion ADNGPFKNGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float GNMLLHFGICG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 CDLEKEKDEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68EC590", Offset = "0x68EB590", VA = "0x1868EC590")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS FLIEMKIEFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68EC6A0", Offset = "0x68EB6A0", VA = "0x1868EC6A0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB30F30", Offset = "0xB2FF30", VA = "0x180B30F30")]
	public DPNJJPOBJGO(Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, float GNMLLHFGICG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68EC9F0", Offset = "0x68EB9F0", VA = "0x1868EC9F0")]
	public DPNJJPOBJGO(UniformTRS OLKKOCNOGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68EC6E0", Offset = "0x68EB6E0", VA = "0x1868EC6E0")]
	public static DPNJJPOBJGO NIGACCCFFGM(DPNJJPOBJGO HHMPHBNGMGF, DPNJJPOBJGO ONCLPMBFLKF)
	{
		return default(DPNJJPOBJGO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68EC1C0", Offset = "0x68EB1C0", VA = "0x1868EC1C0")]
	public static DPNJJPOBJGO CPPJIHNILOM((Vector3, Quaternion, float) FHNKDHIILBL)
	{
		return default(DPNJJPOBJGO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68EC1E0", Offset = "0x68EB1E0", VA = "0x1868EC1E0")]
	public static DPNJJPOBJGO CPPJIHNILOM(Matrix4x4 PAMNOGPCJMP)
	{
		return default(DPNJJPOBJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68EC960", Offset = "0x68EB960", VA = "0x1868EC960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x68EC360", Offset = "0x68EB360", VA = "0x1868EC360")]
	public DPNJJPOBJGO JAKHLDEDEPK(Matrix4x4 DNPKMJFBJBC)
	{
		return default(DPNJJPOBJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x68EC150", Offset = "0x68EB150", VA = "0x1868EC150")]
	public static DPNJJPOBJGO CNNLBBAILPJ(Vector3 MOIICCIPACK)
	{
		return default(DPNJJPOBJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x68EC0C0", Offset = "0x68EB0C0", VA = "0x1868EC0C0")]
	public readonly DEFEBGKBMOG CCONHCEPBJC()
	{
		return default(DEFEBGKBMOG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FDDKPJMCIEH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x68ECAC0", Offset = "0x68EBAC0", VA = "0x1868ECAC0")]
	public static DPNJJPOBJGO LHOPDAGDMMP([In] this DEFEBGKBMOG OLDDCPCBGIL)
	{
		return default(DPNJJPOBJGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FPACGEPAPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly JFKOINAHOND NIAJMMEOHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private readonly PFPHCNGMPPA MNBJPOLCLPM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD91A30", Offset = "0xD90A30", VA = "0x180D91A30")]
	private FPACGEPAPEH(JFKOINAHOND JGHIAOJOLJP, PFPHCNGMPPA NJAFCIFAPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6901090", Offset = "0x6900090", VA = "0x186901090")]
	public JKFFLAEBADK IPILCILINIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6900F20", Offset = "0x68FFF20", VA = "0x186900F20")]
	public static PIJKHLBEMKP<HPLCKCOFDEE, FPACGEPAPEH> HCLFOFEHDJP(BCHLFGKJAEG<HNKFFDNJINI> NJAFCIFAPCC)
	{
		return default(PIJKHLBEMKP<HPLCKCOFDEE, FPACGEPAPEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6900E70", Offset = "0x68FFE70", VA = "0x186900E70")]
	public static PIJKHLBEMKP<HPLCKCOFDEE, FPACGEPAPEH> HCLFOFEHDJP(JKFFLAEBADK NJAFCIFAPCC)
	{
		return default(PIJKHLBEMKP<HPLCKCOFDEE, FPACGEPAPEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6900FD0", Offset = "0x68FFFD0", VA = "0x186900FD0")]
	public static PIJKHLBEMKP<HPLCKCOFDEE, FPACGEPAPEH> HCLFOFEHDJP(string CIODEPPHMLO)
	{
		return default(PIJKHLBEMKP<HPLCKCOFDEE, FPACGEPAPEH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum JFKOINAHOND
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HPPODMJCDCE : IDisposable, CGOJHJCAILM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private NativeList<FEGDHMAPLDK> GMNHGDAOJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private float HOKFGELBHNB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AKMLFMCCAKA OKEFCHCIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x8641A0", VA = "0x1808651A0")]
		[CompilerGenerated]
		get
		{
			return default(AKMLFMCCAKA);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86A850", Offset = "0x869850", VA = "0x18086A850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JJLBMCNMHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69014F0", Offset = "0x69004F0", VA = "0x1869014F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GBOEINIHLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6902A30", Offset = "0x6901A30", VA = "0x186902A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<OOGKNMCCDKI> BGFDKLCHNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x867DF0", Offset = "0x866DF0", VA = "0x180867DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int MCBCIGGGDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6901440", Offset = "0x6900440", VA = "0x186901440", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float JPFCFBJNFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6902B10", Offset = "0x6901B10", VA = "0x186902B10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6903860", Offset = "0x6902860", VA = "0x186903860")]
	public HPPODMJCDCE(AKMLFMCCAKA IDICACLIBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6901CF0", Offset = "0x6900CF0", VA = "0x186901CF0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6902C50", Offset = "0x6901C50", VA = "0x186902C50")]
	public Vector3 MJIMBBFGMEI(int JPMDPHGDIIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6902A40", Offset = "0x6901A40", VA = "0x186902A40", Slot = "6")]
	public Quaternion JDEKGBLGEJK(int JPMDPHGDIIG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69013A0", Offset = "0x69003A0", VA = "0x1869013A0", Slot = "5")]
	public Vector3 BDDBODCAECA(int JPMDPHGDIIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6903360", Offset = "0x6902360", VA = "0x186903360", Slot = "7")]
	public float PIAEDBEPNDF(int JPMDPHGDIIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6901EB0", Offset = "0x6900EB0", VA = "0x186901EB0")]
	public void GHOBOIFCPHP(Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, float AMCMIGCLHDD, bool FKLFMKLLPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69029D0", Offset = "0x69019D0", VA = "0x1869029D0")]
	private bool IJFIDGGKPLG(int DGFOKAFDBMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6902870", Offset = "0x6901870", VA = "0x186902870")]
	public void HNLJGMMLACG(Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, float AMCMIGCLHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69032D0", Offset = "0x69022D0", VA = "0x1869032D0")]
	public void OHCENKDGDDO(int DGFOKAFDBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6901250", Offset = "0x6900250", VA = "0x186901250")]
	public void APMMIIMCDNG(int DGFOKAFDBMG, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, float AMCMIGCLHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6903120", Offset = "0x6902120", VA = "0x186903120")]
	public void NGAFIFDHCKK(int DGFOKAFDBMG, float3 MOIICCIPACK, quaternion ADNGPFKNGFI, float AMCMIGCLHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6901100", Offset = "0x6900100", VA = "0x186901100")]
	public void AOHAPHGBHDA(int DGFOKAFDBMG, Vector3 MOIICCIPACK, float AMCMIGCLHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6901D50", Offset = "0x6900D50", VA = "0x186901D50")]
	public void FHLBNJHNNOK(int DGFOKAFDBMG, Vector3 FFJHDFACBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6901500", Offset = "0x6900500", VA = "0x186901500")]
	public static Quaternion DMHNNPICMII(Quaternion NACDGIDELJO, int DGFOKAFDBMG, float JOONNCAMDDI, CGOJHJCAILM OGBHHHAHPNH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x69033C0", Offset = "0x69023C0", VA = "0x1869033C0")]
	public Bounds PLCJALIOMDF(Transform DNPKMJFBJBC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6901480", Offset = "0x6900480", VA = "0x186901480", Slot = "10")]
	public virtual void DALDONCKNKC(bool BHHFDKIFKNI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69027A0", Offset = "0x69017A0", VA = "0x1869027A0")]
	public NativeList<FEGDHMAPLDK> HGALHAOGCJG(float EMCJJGCGPKB = 1f)
	{
		return default(NativeList<FEGDHMAPLDK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct OOGKNMCCDKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public float3 KBHBDHIEKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float BDPPGOAIGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public quaternion HBFCBFHLMCO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x690B960", Offset = "0x690A960", VA = "0x18690B960")]
	public OOGKNMCCDKI(Vector3 OGNOLJCMDMP, Quaternion NACDGIDELJO, float AMCMIGCLHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x690B8A0", Offset = "0x690A8A0", VA = "0x18690B8A0")]
	public Quaternion EFJJIOKHNME(Vector3 KDJEBHMIDDA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x690B5A0", Offset = "0x690A5A0", VA = "0x18690B5A0")]
	public OOGKNMCCDKI DEJFIHJAIKE(Vector3 EFBOGNILLHB, Vector3 LJEEOFDPCGF, Vector3 DKBEMCBILCE)
	{
		return default(OOGKNMCCDKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x690B3F0", Offset = "0x690A3F0", VA = "0x18690B3F0")]
	public GOILFBFELEA ACDDNOEKNAI(Vector3 KDJEBHMIDDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class FHMMMFLAJJK : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6905B10", Offset = "0x6904B10", VA = "0x186905B10", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6905B90", Offset = "0x6904B90", VA = "0x186905B90")]
	private void MLGBOPPIKCH(Dictionary<Guid, Guid> AJBBOMONIAG, NCABEELOLKC PONNIIKHBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69063F0", Offset = "0x69053F0", VA = "0x1869063F0")]
	private void MLGBOPPIKCH(Dictionary<Guid, Guid> AJBBOMONIAG, IBJHGOEELPA HNBKIHAMNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6906170", Offset = "0x6905170", VA = "0x186906170")]
	private void MLGBOPPIKCH(Dictionary<Guid, Guid> AJBBOMONIAG, IJHMJNDEILC PEODDADPNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public FHMMMFLAJJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class GNGNEKJGFMK : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6906660", Offset = "0x6905660", VA = "0x186906660", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public GNGNEKJGFMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class FLHNJOLLCPD : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6906450", Offset = "0x6905450", VA = "0x186906450", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public FLHNJOLLCPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class NEPCIEGLLID : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x690B0E0", Offset = "0x690A0E0", VA = "0x18690B0E0", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public NEPCIEGLLID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class LBODCDCJADE : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x690A9D0", Offset = "0x69099D0", VA = "0x18690A9D0", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public LBODCDCJADE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class LNCGMPDKLLB : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x690AFA0", Offset = "0x6909FA0", VA = "0x18690AFA0", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public LNCGMPDKLLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class IPAAJBDOIMK : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6907950", Offset = "0x6906950", VA = "0x186907950", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public IPAAJBDOIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class DJBPNJOHJKK : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6905710", Offset = "0x6904710", VA = "0x186905710", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public DJBPNJOHJKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ADMCEPMEEPF : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6905550", Offset = "0x6904550", VA = "0x186905550", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public ADMCEPMEEPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class OAAOCEFMKAA : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x690B230", Offset = "0x690A230", VA = "0x18690B230", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public OAAOCEFMKAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class HNBMJNNMNBF : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6906710", Offset = "0x6905710", VA = "0x186906710", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public HNBMJNNMNBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class EIGGFKMOMAJ : NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public static readonly MKNONHMFKIE LFBKCILOCBH;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69059E0", Offset = "0x69049E0", VA = "0x1869059E0", Slot = "4")]
	public void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public EIGGFKMOMAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HGEFEKJNOMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public NGPKNGOLDBM HNNOPDLCPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public FEDJAAAIKEC NNEJOJBEMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public Dictionary<int, int> KDCIEAFFLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public Dictionary<Guid, Guid> EIOGBAFNBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public IJCECKEHPLL ENGFPJCNBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public bool DBHAELEMENJ;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NMNJMIACHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMBKDMGAIED(GMDMDFBLCEN CENHCBLDMFF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IFOBNCHBBNE
{
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private static readonly NMNJMIACHFA[] NNJMPNPILMF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6906BE0", Offset = "0x6905BE0", VA = "0x186906BE0")]
	public static void CJLCCJIJHML(CGIDLDDLPHO FHNKDHIILBL, Dictionary<Guid, Guid> AEEONIIJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69070F0", Offset = "0x69060F0", VA = "0x1869070F0")]
	public static void FKDGDFBOEAF(CGIDLDDLPHO? FHNKDHIILBL, CICFGBEJCDK EMLOPJJCHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6906E70", Offset = "0x6905E70", VA = "0x186906E70")]
	public static void EAIFGDGIHFK(CGIDLDDLPHO? FHNKDHIILBL, CICFGBEJCDK NMAFEEKBEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6906810", Offset = "0x6905810", VA = "0x186906810")]
	public static void AEBHHIIGHKP(GMDMDFBLCEN CENHCBLDMFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GMDMDFBLCEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public NGPKNGOLDBM MNCFODNPNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public CGIDLDDLPHO PKKOMHEOCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public Dictionary<int, int> KDCIEAFFLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public Dictionary<Guid, Guid> EIOGBAFNBAH;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x69065B0", Offset = "0x69055B0", VA = "0x1869065B0")]
	public Guid JKNBPHCGJHC(Guid NNFEKLKANBO)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IJCECKEHPLL
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KGFGEPOKOJA, [Out] Guid OKOJLLCAEBN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class LBKFLMJBKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private readonly HashSet<string> OLFHIBJCECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private readonly Dictionary<long, int> CLHCEBHBFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private readonly HashSet<Guid> EHKKHPKLLFB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<string> ICKIHMLODGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyDictionary<long, int> GHHDCHEHCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x69095E0", Offset = "0x69085E0", VA = "0x1869095E0")]
	public static LBKFLMJBKDK AEAECJPNGAF(EIGMLKEEHNM ENLCDNNHBBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x690A3B0", Offset = "0x69093B0", VA = "0x18690A3B0")]
	public static LBKFLMJBKDK MBNAEKGFJOB(JFFCEHBOEME GHMDNPDPCFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x690A420", Offset = "0x6909420", VA = "0x18690A420")]
	public static LBKFLMJBKDK PAMEILEDHLD(IEnumerable<string> OLFHIBJCECH, IDictionary<long, int> EINIEFPMEIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x690A8B0", Offset = "0x69098B0", VA = "0x18690A8B0")]
	private LBKFLMJBKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x690A770", Offset = "0x6909770", VA = "0x18690A770")]
	private LBKFLMJBKDK(IEnumerable<string> OLFHIBJCECH, IDictionary<long, int> EINIEFPMEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6909E00", Offset = "0x6908E00", VA = "0x186909E00")]
	private void IBKBCGNGKCE(EIGMLKEEHNM ENLCDNNHBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6909C10", Offset = "0x6908C10", VA = "0x186909C10")]
	private void IBKBCGNGKCE(JFFCEHBOEME GHMDNPDPCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x690A000", Offset = "0x6909000", VA = "0x18690A000")]
	private void IBKBCGNGKCE(HAPEGCJCAFB? FMGEJNFFGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6909650", Offset = "0x6908650", VA = "0x186909650")]
	private void IBKBCGNGKCE(FLJAKMHKMAG? MPJOKOKILNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6909820", Offset = "0x6908820", VA = "0x186909820")]
	private void IBKBCGNGKCE(CGIDLDDLPHO? PKKOMHEOCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x690A340", Offset = "0x6909340", VA = "0x18690A340")]
	private void JNGLMMMIMDC(string? IALENCLHHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x690A690", Offset = "0x6909690", VA = "0x18690A690")]
	private void PFCEFAJJFBL(EHACEGHKJEJ? AJLFPJADPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x690A5A0", Offset = "0x69095A0", VA = "0x18690A5A0")]
	private void PFCEFAJJFBL(JPFGPMCPNDH? AJLFPJADPKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct JLGMBAMJBLM
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class LGBOCCBIICP : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private readonly IEnumerator<DictionaryEntry> JPEENEJPGDF;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DictionaryEntry PAIHIGEOABE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x690AD70", Offset = "0x6909D70", VA = "0x18690AD70", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x690AE40", Offset = "0x6909E40", VA = "0x18690AE40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object BLBBIKKJHJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x690AEF0", Offset = "0x6909EF0", VA = "0x18690AEF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x690AC90", Offset = "0x6909C90", VA = "0x18690AC90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
		public LGBOCCBIICP(IEnumerator<DictionaryEntry> JPEENEJPGDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x690ABF0", Offset = "0x6909BF0", VA = "0x18690ABF0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x690AC40", Offset = "0x6909C40", VA = "0x18690AC40", Slot = "9")]
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
		private sealed class PLGPHACGLNB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xC43BD0", Offset = "0xC42BD0", VA = "0x180C43BD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x690BB30", Offset = "0x690AB30", VA = "0x18690BB30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public PLGPHACGLNB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x690B9E0", Offset = "0x690A9E0", VA = "0x18690B9E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x690BAE0", Offset = "0x690AAE0", VA = "0x18690BAE0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x690C150", Offset = "0x690B150", VA = "0x18690C150", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IDictionary.this[object BHEIPBKEDLG]
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x690C060", Offset = "0x690B060", VA = "0x18690C060", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x690C240", Offset = "0x690B240", VA = "0x18690C240", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x690BFA0", Offset = "0x690AFA0", VA = "0x18690BFA0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x690C000", Offset = "0x690B000", VA = "0x18690C000", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x690C1E0", Offset = "0x690B1E0", VA = "0x18690C1E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x690BC60", Offset = "0x690AC60", VA = "0x18690BC60", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x690BCC0", Offset = "0x690ACC0", VA = "0x18690BCC0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x690BD20", Offset = "0x690AD20", VA = "0x18690BD20", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAB8760", Offset = "0xAB7760", VA = "0x180AB8760")]
		public RoomObjectCounts(Dictionary<int, int> CJGMMCELEDH, [Optional] Dictionary<int, int> AOHELDHCAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x690BB80", Offset = "0x690AB80", VA = "0x18690BB80")]
		[IteratorStateMachine(typeof(PLGPHACGLNB))]
		private IEnumerator<DictionaryEntry> CPCBLGNCFDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x690C290", Offset = "0x690B290", VA = "0x18690C290", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x690BEA0", Offset = "0x690AEA0", VA = "0x18690BEA0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x690BD80", Offset = "0x690AD80", VA = "0x18690BD80", Slot = "9")]
		void IDictionary.Add(object BHEIPBKEDLG, object CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x690BDE0", Offset = "0x690ADE0", VA = "0x18690BDE0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x690BE40", Offset = "0x690AE40", VA = "0x18690BE40", Slot = "8")]
		bool IDictionary.Contains(object BHEIPBKEDLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x690BF40", Offset = "0x690AF40", VA = "0x18690BF40", Slot = "14")]
		void IDictionary.Remove(object BHEIPBKEDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x690BC00", Offset = "0x690AC00", VA = "0x18690BC00", Slot = "15")]
		void ICollection.CopyTo(Array GGEMIJICFPG, int LLPJHIPCNFD)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class DOHOHFPFKMO : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xC43BD0", Offset = "0xC42BD0", VA = "0x180C43BD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6905990", Offset = "0x6904990", VA = "0x186905990", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public DOHOHFPFKMO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6905800", Offset = "0x6904800", VA = "0x186905800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6905940", Offset = "0x6904940", VA = "0x186905940", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6908130", Offset = "0x6907130", VA = "0x186908130", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IDictionary.this[object BHEIPBKEDLG]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6908000", Offset = "0x6907000", VA = "0x186908000", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x69081E0", Offset = "0x69071E0", VA = "0x1869081E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6907F40", Offset = "0x6906F40", VA = "0x186907F40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6907FA0", Offset = "0x6906FA0", VA = "0x186907FA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6908180", Offset = "0x6907180", VA = "0x186908180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6907BC0", Offset = "0x6906BC0", VA = "0x186907BC0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6907C20", Offset = "0x6906C20", VA = "0x186907C20", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6907C80", Offset = "0x6906C80", VA = "0x186907C80", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FB1100", Offset = "0x1FB0100", VA = "0x181FB1100")]
		public Invention(long BLCJLIJFBDL, int JPBPNOCHNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6907AF0", Offset = "0x6906AF0", VA = "0x186907AF0")]
		[IteratorStateMachine(typeof(DOHOHFPFKMO))]
		private IEnumerator<DictionaryEntry> CPCBLGNCFDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6908230", Offset = "0x6907230", VA = "0x186908230", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6907E00", Offset = "0x6906E00", VA = "0x186907E00", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6907CE0", Offset = "0x6906CE0", VA = "0x186907CE0", Slot = "9")]
		void IDictionary.Add(object BHEIPBKEDLG, object CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6907D40", Offset = "0x6906D40", VA = "0x186907D40", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6907DA0", Offset = "0x6906DA0", VA = "0x186907DA0", Slot = "8")]
		bool IDictionary.Contains(object BHEIPBKEDLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6907EE0", Offset = "0x6906EE0", VA = "0x186907EE0", Slot = "14")]
		void IDictionary.Remove(object BHEIPBKEDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6907B60", Offset = "0x6906B60", VA = "0x186907B60", Slot = "15")]
		void ICollection.CopyTo(Array GGEMIJICFPG, int LLPJHIPCNFD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> MCENFPDIMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public readonly IReadOnlyList<Invention> DEAGCLAJECB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAB8760", Offset = "0xAB7760", VA = "0x180AB8760")]
	public JLGMBAMJBLM(IReadOnlyDictionary<Guid, RoomObjectCounts> NEMOJCAJGBD, IReadOnlyList<Invention> GAECGIEEAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6908410", Offset = "0x6907410", VA = "0x186908410")]
	public static JLGMBAMJBLM AEAECJPNGAF(EIGMLKEEHNM ENLCDNNHBBD)
	{
		return default(JLGMBAMJBLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69094C0", Offset = "0x69084C0", VA = "0x1869094C0")]
	[CompilerGenerated]
	internal static int IPBOPMPIGCH([In] IReadOnlyDictionary<long, int> BGCJBCOGBCH, long? ODMJGCOLDFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6908E00", Offset = "0x6907E00", VA = "0x186908E00")]
	[CompilerGenerated]
	internal static void EJDBKLLEJHA(int MJHICHKHHCB, [In] HAPEGCJCAFB BCMLIMOADPF, [In] Dictionary<long, int> BGCJBCOGBCH, [In] Dictionary<Guid, RoomObjectCounts> NEMOJCAJGBD)
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
