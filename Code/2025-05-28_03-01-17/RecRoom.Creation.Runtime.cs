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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D16BD0", Offset = "0x7D159D0", VA = "0x187D16BD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HJPECMGPFPP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> GCBGLFPPNBC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> KAALNFOGDJB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> INCOKBPMPAA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> CAOLEHMGNKO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string NICMKIIOPIC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string LHJCIOODIEA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string MKENOAGPALP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D0FA50", Offset = "0x7D0E850", VA = "0x187D0FA50")]
	public static bool FLGBJEGDFEF(Guid KIAGNAEJJDD, int KJFIIMJFPBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F9C0", Offset = "0x7D0E7C0", VA = "0x187D0F9C0")]
	public static bool FFPBFOOHMLH(Guid KIAGNAEJJDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D0FB50", Offset = "0x7D0E950", VA = "0x187D0FB50")]
	public static string LCNICACKBKN(Guid PDFBNFKDLAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NMNDMAHGNOA]
public enum MNPFLDLFKPG
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
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D13740", Offset = "0x7D12540", VA = "0x187D13740", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OMIGEGJAPHO
{
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid NCJEBHPFMFM;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid KLMDCIMIGHP;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid CDHFELMNOLM;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid MGJJMAOKCKJ;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid PCNPKENLDJM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid GGKHPIDINLO;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid KCIDEAJNCBC;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid JNFEMNAAINM;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid LBOLIMCEPOA;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid AAJEOHHIINB;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid KJOAKDBCEIH;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid OIPIPNKNKKG;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid CCHOBHIDKBP;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid MLFKBCMHPAO;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid CHBLOHMCPPF;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid BMJBHGDONPA;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid KMBNLMHOECB;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid BOJJKFOKIHB;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid FLGEDJCIDPB;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid HKDHBPOECGP;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid GANJJKGBNMJ;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid MAGHIGEOJNB;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid NFKMICCEGCJ;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid GHNHHMAGMFH;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid PMGHBKFMNOB;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid OBAMFPAGAOI;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid PPEJLDNHAEG;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid EBDDFCMKNKJ;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid HGOCBOLKBEL;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid IMNNLBDFKAM;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid GGOPHIPHAMJ;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid HMBEPJHMBMA;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid OODFGGCKACE;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid NPOEHNHEAFO;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid GJJPOENODPB;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid AJPNPBDNJNN;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid BEJPHHFPAJE;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid KOFCMMHNEEN;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid APGKONAEPAM;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid JGJKNDLCOBG;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid COHHDCJDOFH;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid KDKIPKNNFFL;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid AHAFGBMFMPM;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid ODKPPBBJJOF;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid ENDNKNBKHOD;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid JKNBCPKKEIP;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid BGIHFFFMJDN;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid HHJKFOKMMKE;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid JKEDBAKJEKI;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MGOGIGFILML;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid EKODFCBFMIA;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid DDMNPLGGOOF;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid GHKJMDNACNP;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid OIKFIALPNBI;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid HNKGJCOKHHI;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid OHGNEFEJHEE;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid EBPCFCBHGJG;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid BLGLNPGNKDO;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid FAGFCHCOMJH;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid LGPMJHCGKOH;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid IJBCJKENHCA;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid NIFBCNGPFHC;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid GMMICEKGOGK;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid AJHGGFCGPKM;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid OJNENNMDMCC;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid DKPBFFBIGNP;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid HKLMCPPHGDN;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid NPGGIKOGFGE;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid DINEGPPEBAK;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid BMCCAEHMJHK;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid EOGBHLOKMAN;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid LBJCHOKBLBA;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid FILIIPBIPBK;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid IAPHNKOJHHA;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid EFHMPHMNFKM;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid FEAAPEPFOAI;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid MPNOICJAEBH;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid HKLNDKLJKHK;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid MJLJHBOPBHB;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid IDFGAPBIFOH;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid ONJDAHGLNOK;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid KANKIBEDHHJ;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid OFIGNBDGCOD;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid AAKPMGEFENK;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid EFLHBLHCFLL;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid NCPFACNIAFD;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid PLCGDGIOICG;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid JCMPBOIIJLL;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid MOCNAAPMCDJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid FLOJCOCBJDC;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid LONGOPEOLLC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid FGCKHIFIICO;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid MOIGJDMEKLB;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid KHPNDIFPJMI;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid BFNOIPDDFHP;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid BBHCBCFHKDJ;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid KBCLKHLOFFI;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid HKEOBLFEOGG;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid NIHGAGPDFMG;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid CLPOFPEADFA;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid OOKJFDPFBEB;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid GGDHJMPKEJD;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid LJJEJBPANPA;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid BFPEHLMGIMP;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid BMNCKINPALI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid GNKOOIKMLLE;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid LEHDPADAMJC;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid MDHBCHGOPFD;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid NKBGJDMJNMM;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid MOONJONGABB;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid JAFILLOMGMJ;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid IJJLKLJKMPM;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid BLHNNHIKJPP;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid DMGFCLIKOPF;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid NNKJFFABIDO;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid MMCOJCPCJFG;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid ANEKNGKHIMF;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid HFCKPLHENGL;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid CGGHFLGOGJF;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid MDBANABILJJ;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid HMFBOPIMIFO;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid KCBIADNIOEN;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid DCHKPHEAJGF;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid AEJOMMNGPEK;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid FDDIHMICCLB;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid OPHDCACPAMD;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid NCOMHLLFKFF;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid KFCDNBHMACF;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid JGHIDAEIGOG;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid KLLMOHAIIKG;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid MNBBMAPPHMC;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid IPMCJPKEGAO;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid FJFJJHIIGNH;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid MLFNAJAJEGH;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid EMIOFGJPHNP;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid EMMDCFFAAMB;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid CKHNLGEGEAJ;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid HGENOLHIMAJ;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid FKCLDLJINDG;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid EEEKIPFFGFD;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid ELIOHGGKNBG;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid PDIFNBNCCJB;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JHLEPNBBMOG;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid MCIBKIAILNC;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid PCPOCEDAFFH;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid HPAMFHADAPN;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid BCOMMALKPNI;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid AEPJAKIBIAC;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid GBIKKBKIOPI;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid DGJOLEDLKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid GBCPIKOLJIN;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid EGEJOCDHJNF;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid OGHBMMNKKIH;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid KPOEFEPHLJA;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid JAGEPHNPOBB;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid HLGINAAJNNN;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid LEKBFGKCNMI;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid ILIFDHLIOOC;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid EFKNMEADMOL;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid MHIGCOAOENK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid MJCBPJKLEIK;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid JCCKIIDMBCJ;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid LDBKPHMFMEG;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid MBNFJKLEHND;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid INMNMKBMHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid MIOBBIJICLP;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid DFKGPMIMHFP;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid NHBPFLFEDPE;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid LDDMIBCKDBP;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid OOOGJKKHLCI;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid EFJOEPOJOIH;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid CKFHEBMGOBF;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid OIINNJJLJGI;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid MEGMCFBCGLL;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid FKAOOLJGJIC;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid BMHGILFNMJM;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid LILPOAFAENA;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid GHGMDOJOELI;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid FOFHEFGMIGO;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid CEMOGGBNJFD;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid JCINAPJDOIL;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid BGCFBIHKHEE;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid JCKEPHEHLOM;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid NBDLOMJNAFI;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid GEIBMDHIACG;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid KABIFGDBPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid JKFIEAIJIOC;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid CMIFEOBGDPO;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid PBGKNHGKDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid ONKNOEIFGAD;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid INAMLGNBHIJ;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid OFJCCMKHBFB;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid BADMFKIEEIL;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid IBHBBDJIFKC;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid MOODKCNDHFH;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid GPDAPEMJIFB;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid CGFJALNBDJP;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid LDKKFDODELE;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid AHCCONKOPHB;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid IKGJGALNDGG;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid DGKCFJEJFPG;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid CAABMCGAAGI;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid PLAOCJOPOJO;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid LPBEHGPNBDP;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid CAPJOIJAIPM;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid BDDNPHFJOEI;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid EOHLKNNFDBJ;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid EJIHEFPPPEB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid FGKGOIOKHIF;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid LGDPNPAGCIH;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid EHLIDCLLGCO;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid KKBBKJAEBKG;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid FICNMGFKAKD;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid DHGDFDFJIEG;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid FGCDHAPCODI;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid BIIADCPKDLI;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid DKCIMJBLNNN;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid GLBGLFBLCKC;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid AAMLPHFFIGL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid CFKBEHMJDHC;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid IAKMCDKAECG;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid AANNFJHDAJK;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid KFCOCDDHAHA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid DLLHFCPNKHA;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid NELDDOBKCEE;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid FKDAIGJAPEO;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid KLLINCPCCLB;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid GMGLCGADGGN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid BGDCBCDAPIN;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid OPPJFNLOCPL;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid ENAHMFCIKIF;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid JPEOKCOIDKA;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid GLMPEPBLBIM;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid CDEFLMBILHL;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid OGIICEIGBNG;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid MIEMBAPBIFA;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid IKNMEOCANEG;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid OJJKNDCEHJB;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid KJCKHIKDCEP;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid GADFJFAKBHI;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid BMONMEGCICL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid DAGFKCMOFMF;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid BDCLPFLLPJL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid MOAGGADFIBE;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid KKEICEEFBFM;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid MGPJLPFAEPH;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid JJPJFLKDMLB;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid JMKPENDMLJL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid FFGPBIDGMHK;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid CHOHFMOKBPE;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid IMABIHFDEDJ;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid DBGKDPKHFBP;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid IAPCIFMMMOL;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid JEBJAEPAHEI;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid DNOKEHOMBIL;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid CFPIEEDDNKP;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid COANKKEIBMF;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid LKIODFEKGBO;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid CHNBHLFBCDC;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid KBKCKIIONHN;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid HPOIHLALONB;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid ANGKLNDCCEK;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid IGILBFEMBPD;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid LFHPLMNPEDD;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid MAAJOGPPEJE;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid BNFKGABAOAI;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid KBEIGEJDLEC;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid AEJBJJPLDFD;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid NKFICJFJGJO;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid FDCNOFAHGEE;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid CINBINAKEDC;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid FMGGFMENNAK;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid GKDEBFBJCCI;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid BCEDBJKIAEK;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid BJJFCNMKNFD;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid DNJPBGEDKAM;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid LPIPCDOFPJN;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid CIAALGACEAJ;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid EOCDJPLPECO;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid OMMJOFPKHFK;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid GOKPKONOPCI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid OJLLMLFNMAL;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid IDHENEDJANM;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid GLIPGDNENEE;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid LMFNGDKGCGC;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid LJLBIACLBHA;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid LEECPMLKOPB;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid CEFPEPKAOPK;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid DIGDGFGEDBG;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AJBIAMDLAFF;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid LCFHDGAKMPI;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid NMDMPEFPPPF;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid JDIFOALJDAO;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid ANCLMAAIJHM;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid JLJJDDKOGAD;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid CHHDBECJJFH;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid CDHMDABHNHH;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid NIOBCIPDOAM;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid HGFGENKDDBF;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid FNMEKAPEHKA;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid ENCMOHKMPHI;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid PMJJBEBFBGD;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid IKDDEBIJIJE;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid FABOILFABPO;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid CAJHPFEHBOF;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid MCDABGLIOEO;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid FFMBMPNHNKD;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid BJNFOAPECDN;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid AMLCKDPHDCB;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid HEBCEKKIFGE;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid DDDHKCCMFDA;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid BEJEOFJLDIH;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid KEIOOEENJGD;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid JGIDNBLJBKI;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid DIEHABGCKKN;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid GJPDAEKCOEB;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid HJBMECPHHFE;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid HGFJADJDNDH;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid HNDCJECDCPO;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid DAPEPMJHMOK;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid IHLLKFPFICB;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid HOIJBPLDJDG;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid OGBMGLGDOLM;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid PFAMFJNADCF;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid HKOCPNIKAFE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid JLAAKPFFNNP;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid IFLLADBKHKN;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid GIBIGCEHJNF;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid MAKHNPBEFNO;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid MGDMIBDMAJH;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid BHMAMCONPGP;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid JHEBPMCPIEL;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid EJFIIGLMNIG;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid HIEKAMLPKHF;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid NKBEEIGOJMG;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid BGBIGGKJLBN;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid JHFKJENMHBF;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid GDMKDLGEMEL;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid JPNEABHFAIK;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid DHAMJDNPMGP;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid LHDPOBLOKBC;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid IJBCLBFBLCJ;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OLBOIHGNALG;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid OBPDONMLPIC;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid AEKEIPFAJOK;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid MNMFMNEABOG;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid LCAABJHGPGC;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid HNJKOOJGCMD;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid JKONFGFMFPB;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid LKJHFDNJLIJ;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid AEDMMMNGAAD;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid PPAAIJAENAL;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid LKNGCHHILOB;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid AAPCGHLEOJM;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid NNMGHOOJMBG;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid LPIFKCJFCHM;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid DEOGDHGMKJP;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid HBAEGLCABHK;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid CGPKNEDEMKC;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid JOCOKGLBONA;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid AJONPCMLHME;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid IADIBKHHDCB;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BEOLEEGPLJK;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid HMHKHDMDOIO;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid DMPFCEIICAK;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid PHPAGDPMHGO;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid LMEOGILFFAJ;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HJBMDMFHIJK;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid OKDJEFDMNCK;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid BNOLMLGFFOH;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid PNAAOIGEKCL;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid JPDIHDCHNBN;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid OGBNADCLNHK;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid GDNIMPLNNGL;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid DBEGMJJKCLD;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid JMINABIBNAL;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid MGONFEKPAKA;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid EABNHNMDBNM;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid KNNFICOACLF;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid OLDJJEHNMCL;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid CBIGOOCLEJA;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid FABHNLNFJPL;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid DKAOCPHHDAF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid DBGJBLJPHBD;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid IDHKGPMMDPD;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid ECNPPMPMJJD;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid BCFHCDIBICP;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid DBLLMELMMMH;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid KOFFPGKABOO;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid LLLOPKPOPLA;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid EOFJOAEMFBM;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid ONIGAIPGIJI;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid MEKBDNPJAIK;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid IHCFGAHLGPE;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid NGCNGEELLKH;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BPGNNJHJPLB;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid PEDNELCBBDF;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid BBOANCKEALM;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid PGMMJDOCLPJ;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid CMKNBEMLEFG;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid BDDNDPPBHDL;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid BKCPAMLLDIN;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid FENCPKHELHM;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid PIPCMABFEGF;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid GPMEEFPPJMM;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid PDNEIHHBEDO;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid DDEPIEPHPEL;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid AKAGBBBNPDA;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid OFMLJBCEHIB;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid IKMMAPIHLBH;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid HOFAKJDEOJC;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid CHLIDHIABLE;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid GCFIIEGGJFL;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid NBLNMDPNKGN;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid NNHEGLNOOBF;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid JLGLDKCLDMM;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid MIPICGMOCNC;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid NNJAJFCKHGP;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid ABCODKCKDAF;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid FOLCFHKPGAI;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid GKJFDJEHICD;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid KMBHHMMANGE;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid FDLJGIAPKAN;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid AILDGPNEJNI;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid MOHEJJNEPJN;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid DEOENEJMCMC;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid GNMLCIBJFLD;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid PAJLJNCLMBN;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid NHOLCDAPFIG;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid IGDDEADPJPE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid DJPGCOICGIK;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid DFMEFHEDFGL;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid MALLMGIHPBD;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid ILMHABEGMOC;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid PHMHFDFJHPO;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid IHEBFOJJAPK;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid NNAKJJLMBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid JBGDNPJNLHD;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MLIBDEPNIBL;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid GDGAKLAHDPB;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid KEMPIDDMBAB;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid PJJJIHMAOKE;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid ABMBOMJNKCE;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid GBHPNKHGHFM;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid MIAOJABAKDM;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid MJIAJOIMNDM;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid LGAJIJIENLF;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MKBNOKLGKKP;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid GFOJGCPMIEA;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CDPIPNGEELC;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid DNOHIFIPDEA;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid BNLPLKHCLGM;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid OJJOFKLDLKP;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid GJHLHLFFADH;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid LLDKCIPIFBM;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid JCNBHKCGGIC;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid AHMJAGJINCI;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid GCEJPIIPKHN;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid PLNJMNLPFJO;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid CJIIMDDBGOL;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid JADHKOONAKA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid JGNPEONFPNM;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid CCCAHABBEKA;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid PKHKCKAMKFH;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid JKIOJCLMMKD;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HFOFMCHFNDJ;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid MEGJEBMMNNH;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid EJLCGMILHKC;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid HOBPPCEOJLK;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid CGBJEADDPFD;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid KJENNLPHCPJ;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid FJBMEDPNGFL;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid PMGIGMFOENE;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid AAOODFDPFAD;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid OAADPHIILPN;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid FPOILJOKJOD;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid HADKBDPBFDB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid EBKGCDMFJHI;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid BHMMFCFFBAC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid FBDJGEGOKHI;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid FIMFCAFKEBF;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid OABCPKMCNGN;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid LJBAKMPGNDB;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid DKNBHDOBPED;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MEGPIJHACGF;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid KEMBOGPCOHF;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid MNBIJFEGPBF;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid IAEOBMEIJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid CLMINFNHGCI;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid LPNEMOAMOMF;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid ODLEDEOOGKP;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid NCOFILDNHDI;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid LBANLMMHMIE;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid GPPFHKHHKOB;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid HEGGNBBBNEG;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid HIMFNGBCEBA;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid CLBJLHFPIGO;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid BFMANACNHJJ;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid KPDCKPNOILD;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid NKLFCEHMLJK;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid POKJDOJKCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid MKHKGGHELGN;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid ODLGCBIIMBL;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MDGPIKCGLPO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid IJAJDFKPILH;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid EPCMBJFAPAL;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid BNAFCJOIJBG;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid MPCFKKFEBCO;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid HPKIGKKIOPK;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid ODHCINCNIFA;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid EIICNHMFGBJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid GLIHNNCMKKJ;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid KEOMILBEEML;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid CLBPAMJKBIK;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid FFOANLDPLFL;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid HNPKLPJMFFK;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid KMPPGPAJBND;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid PFNKOGMBKHC;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid DLCHJFCBEEB;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid EDMLMIJBDAM;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid OJBMKMFMELP;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid IICNNCKODLM;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid LHCEMPLHJJP;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid NAMBOEAEPBI;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid MFKOPFCPGFH;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid GMFPKDGDHBK;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid OHKDPBJFGPC;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid JJHEBJBGMKM;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid LDDLLKMIKFG;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid IINHIHPFPOK;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid JAPOHCLNHOD;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid FHBNICKGAHL;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid PLOOOIFJKIM;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid OHECBENPOBB;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid NHPKNEJFPBM;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid CMBPINABHGA;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid ACNENAGLPDH;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid OMLEAOKBMNN;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid AHNMIAFMOBD;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid DMCCCAMPGJO;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid KNJAIGIMIIB;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid BDPKBFCJEOK;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid BNPCCEKMJIK;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid HKPFKPDLDOE;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid HMNEBGDDJDD;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid FHIEMBOKABE;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid KAOJDCDPEIP;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid MHDDBFKIKHP;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid PJDPAIPEGFF;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid PEHBDKPEADL;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid MNBMCDNLPHG;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid BOPJKDDNEKJ;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid EDIAPEPNGFH;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid PJELEIJLGPA;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid JANGPGLNEDN;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid GIEEBBFJMOE;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid ALHMFNBFCGN;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid AANHMFFFHJC;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid DKENLOBFNGB;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid CEKHMBBHPKJ;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid CNDJKOIDHOO;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid IKKKBJECGDD;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid DMPLGHCJELO;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid MDBIDMMKAAC;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid NHBEILOOFDA;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid IDNFIKEKMBI;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid NGDKBEFACBO;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid DKCDGJPIENC;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid LLCHKAGBNHN;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid EHEEOFMNOBD;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid PMGGAPDJOAG;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid HHLFEODBHNE;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid ENEOMCJELKL;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid AFIMJLKNDHO;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid NIKFDMKDGDO;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid EGANBACNDKG;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid LIJCDFEBELA;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid FJKGGLGNHPP;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid BPMBMJHIHLO;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid GINCKPMMKDN;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid IJNOCHDGDGK;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid EGEKPLJPKLI;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid NOINCHKFAHJ;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid EDLLBIAKOHG;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid LPEFAJOBKIL;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid IKNLAPLGAJB;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid BEMHKNJJMAA;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid GJPPNDCMMDA;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid OJHJIJOFADB;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid EEKJCLGOAAD;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid GPIIFDJBLEK;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid PFMOMMKOLGD;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid IMPEIAGFHCB;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid CPPKPCODCCP;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid APDDAOFHCIH;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid PCBLADNMJNK;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid OGGADDLBDKI;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid BAPNBMIHAGM;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid MDEGIIIOGNO;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid OJNIKPIKADH;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid GNMOIGFDNDH;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid KACEMBELHDI;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid CHADNEPBKJI;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid CIOHNKDOGPJ;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid BOEKKIMICHM;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid LEBDBLHNAOI;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid PBNMALHKACN;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid EDENMDGKIPK;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid HNLPNODEMPL;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid JLBEIHCHHMP;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid EGAKNAKANIG;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid BMEPIBOFOOO;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid LJEELPAJBLF;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid JJPIIFMIFFI;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid ANCDJEJGOCL;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid GKOCOADDEAD;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid JNMOHECFNPO;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid CJKIAEGMAHC;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid IEPMDFMFAMN;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid NKJKFENFIPG;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid JFGMJPPBBCK;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid ABAGGKCCIPC;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid PBAHHHOBBAK;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid AMIMMDKCNFO;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid GNNKCOLEDBF;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid PKBBMKMDEAB;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid CFNEGPCMNHK;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid BGHOPDFJBKM;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid FCCHKHMIADN;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid DCFCEFAJEFO;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid ANNCBBMOFGG;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid AMAOAGCDBAF;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid BAKNCPPLAEE;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid JBOIEFIPBJC;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid ADBMIJILAGD;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid HIDPDLKBBBC;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid ACIMHCEFCEG;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid OIAEJEDDBMP;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid IFABAIAGBJB;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid LACCLDNHMCJ;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid KHDJFOGKBDM;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private static readonly Dictionary<Guid, MNPFLDLFKPG> LOJFONEAKPH;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private static readonly Dictionary<MNPFLDLFKPG, Guid> DDEDKNLLGJJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, MNPFLDLFKPG> DCLLINBOFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D16CB0", Offset = "0x7D15AB0", VA = "0x187D16CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<MNPFLDLFKPG, Guid> JCEEOGIDDBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D16C50", Offset = "0x7D15A50", VA = "0x187D16C50")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HGJOJIJFMIB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EBC0", Offset = "0x7D0D9C0", VA = "0x187D0EBC0")]
	public static bool INHEJCEIPHJ(EGLFCNPOKGJ GCGCEADAIKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EBF0", Offset = "0x7D0D9F0", VA = "0x187D0EBF0")]
	private static bool INHEJCEIPHJ(OPHHACDDLLH DCBFDJKHMOJ, EGLFCNPOKGJ GCGCEADAIKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MBBEPPCICGI
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(DAAFOPOAFFM FFEMKICJPKP, [Out] Dictionary<int, int> PLOIIGHPOAE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(OBHJNBIABOM JIAOEOOKDGO, ANIGKFPNJNC EAHOAAFDFAI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct MPHEPHDPHFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly CNOGAFAGIEK DCNLFMKNGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly IEnumerable<HDCAPCJGFLN> JLDLIAJGPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly IReadOnlyList<HDCAPCJGFLN> PMOFLLALPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly BIHBDMOHDCK<HJIDLNADIFB> GCKBAJADNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly IReadOnlyList<KOIDEEJEAKA<KCAEAGPDLDO>> EOKBJKBOAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly IJJFOFKKKJK HCOGPPMNNDJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LDJFJCKNFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D16B60", Offset = "0x7D15960", VA = "0x187D16B60")]
	public MPHEPHDPHFI(CNOGAFAGIEK AFANCFDMPHL, IEnumerable<HDCAPCJGFLN> IHBAHMJHKEL, IReadOnlyList<HDCAPCJGFLN> GNBKPDMBBOF, BIHBDMOHDCK<HJIDLNADIFB> GBMPLCJAMFH, IReadOnlyList<KOIDEEJEAKA<KCAEAGPDLDO>> EHJOOAAKOAF, IJJFOFKKKJK PFAHPNGOBCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GDMNBOLNENE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly CNOGAFAGIEK DCNLFMKNGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly IReadOnlyList<HDCAPCJGFLN> MDEAPPOGJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly BIHBDMOHDCK<HJIDLNADIFB> GCKBAJADNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly IReadOnlyList<KOIDEEJEAKA<KCAEAGPDLDO>> EOKBJKBOAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly ByteString NLCDEIKMIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public readonly IJJFOFKKKJK HCOGPPMNNDJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EB50", Offset = "0x7D0D950", VA = "0x187D0EB50")]
	public GDMNBOLNENE(CNOGAFAGIEK AFANCFDMPHL, BIHBDMOHDCK<HJIDLNADIFB> GBMPLCJAMFH, IReadOnlyList<KOIDEEJEAKA<KCAEAGPDLDO>> EHJOOAAKOAF, ByteString MJJKIDBMBLF, IReadOnlyList<HDCAPCJGFLN> PJKCCHGOODF, IJJFOFKKKJK PFAHPNGOBCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HIKDLDBHEND : HKPIHOPDPCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly Guid DNGKAGJEJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private readonly Dictionary<Guid, Guid> MNMCPCDGAHI;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4A3DC50", Offset = "0x4A3CA50", VA = "0x184A3DC50")]
	private HIKDLDBHEND(Guid AIOOGEGHJGD, Dictionary<Guid, Guid> MNMCPCDGAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F630", Offset = "0x7D0E430", VA = "0x187D0F630")]
	public static HIKDLDBHEND NBEICDCLFEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F4D0", Offset = "0x7D0E2D0", VA = "0x187D0F4D0")]
	private static Dictionary<Guid, Guid> GDKPBOPLFBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F620", Offset = "0x7D0E420", VA = "0x187D0F620")]
	public static HIKDLDBHEND MKOEKOKKCKB(IReadOnlyDictionary<Guid, Guid> KHJEADFMOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F020", Offset = "0x7D0DE20", VA = "0x187D0F020")]
	public static HIKDLDBHEND AINCKNMMKPD(IEnumerable<KeyValuePair<Guid, Guid>> KHJEADFMOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F940", Offset = "0x7D0E740", VA = "0x187D0F940")]
	public Dictionary<Guid, Guid> PEMHBCICDIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
	public Dictionary<Guid, Guid> IFIBEMFOONA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EFA0", Offset = "0x7D0DDA0", VA = "0x187D0EFA0")]
	public void AIKICPLLADB(Guid KHJEADFMOJM, Guid BHBDEJBFADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F6C0", Offset = "0x7D0E4C0", VA = "0x187D0F6C0")]
	public void OHKILICGAME(IReadOnlyDictionary<Guid, Guid> BHBNFMFHIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F380", Offset = "0x7D0E180", VA = "0x187D0F380")]
	public Guid EPEMEGAMIBP([In] Guid KHJEADFMOJM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F580", Offset = "0x7D0E380", VA = "0x187D0F580")]
	public Guid MANBEHHHOPM([In] Guid KHJEADFMOJM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F310", Offset = "0x7D0E110", VA = "0x187D0F310")]
	public bool DIDAMJJGKFA([In] Guid KHJEADFMOJM, [Out] Guid BHBDEJBFADC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F310", Offset = "0x7D0E110", VA = "0x187D0F310", Slot = "4")]
	private bool IHOCGPEKPKJ([In] Guid KHJEADFMOJM, [Out] Guid BHBDEJBFADC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LHIAMADJHDG
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
public sealed class DOMEKAPLNFB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DFBIMLBOJKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CNOGAFAGIEK staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public DFBIMLBOJKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7D01430", Offset = "0x7D00230", VA = "0x187D01430")]
		internal BIHBDMOHDCK<JBGDHIBENNA> AOIPNPPALOD((BIHBDMOHDCK<HJIDLNADIFB> GraphId, BIHBDMOHDCK<KCAEAGPDLDO> NodeId) i)
		{
			return default(BIHBDMOHDCK<JBGDHIBENNA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private static readonly JIAMCAFPHLG<JBGDHIBENNA, int?> IEKEDIOCEKB;

	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private static readonly long DNFGMGPNODF;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D015D0", Offset = "0x7D003D0", VA = "0x187D015D0")]
	public static (long, long) LIKPKINLIBE(CNOGAFAGIEK NEGDHBDOMJG, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D014A0", Offset = "0x7D002A0", VA = "0x187D014A0")]
	public static long IGIAEOIEEGM([In] ReadOnlySpan<BIHBDMOHDCK<JBGDHIBENNA>> HEEKNKLGKIH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D01A00", Offset = "0x7D00800", VA = "0x187D01A00")]
	private static long MGOPOEIPJMH()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ABDKFOBIHHC
{
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public static readonly HashSet<MNPFLDLFKPG> GJOAPJAHIMH;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MGLFDLMHMEF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PFDPFAELOBG : IEnumerable<HDCAPCJGFLN>, IEnumerable, IEnumerator<HDCAPCJGFLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private HDCAPCJGFLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private PHGKPLGIFII spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public PHGKPLGIFII <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private PDLKAODOPAB spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public PDLKAODOPAB <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HDCAPCJGFLN System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public PFDPFAELOBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7D22AD0", Offset = "0x7D218D0", VA = "0x187D22AD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7D22D50", Offset = "0x7D21B50", VA = "0x187D22D50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7D22BE0", Offset = "0x7D219E0", VA = "0x187D22BE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HDCAPCJGFLN> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7D22BE0", Offset = "0x7D219E0", VA = "0x187D22BE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D14580", Offset = "0x7D13380", VA = "0x187D14580")]
	public static PHGKPLGIFII IFHAFPOIDKO([In] GDMNBOLNENE MJOBODPLCOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D14700", Offset = "0x7D13500", VA = "0x187D14700")]
	public static PHGKPLGIFII IFHAFPOIDKO([In] MPHEPHDPHFI MJOBODPLCOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D137D0", Offset = "0x7D125D0", VA = "0x187D137D0")]
	private static HashSet<KOIDEEJEAKA<NDGLMIGFFOL>> CKGBEDBCHKK(IReadOnlyList<HDCAPCJGFLN> OAGFADOJLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D14880", Offset = "0x7D13680", VA = "0x187D14880")]
	private static void JEMAMPMDONL(PHGKPLGIFII KHNPAPOAIMM, [In] MPHEPHDPHFI MHOIGAHHNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D15220", Offset = "0x7D14020", VA = "0x187D15220")]
	public static JKEBLLKKBOM<HIKDLDBHEND, FDFHBLPFLMI> NGGECPHBDJB(PHGKPLGIFII KHNPAPOAIMM, PDLKAODOPAB KGOHOKDNHKJ, HIKDLDBHEND? MCNGADCONBM, bool MPONGKDCCKF)
	{
		return default(JKEBLLKKBOM<HIKDLDBHEND, FDFHBLPFLMI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D16A50", Offset = "0x7D15850", VA = "0x187D16A50")]
	[IteratorStateMachine(typeof(PFDPFAELOBG))]
	private static IEnumerable<HDCAPCJGFLN> PEKKLDCPNFA(PHGKPLGIFII KHNPAPOAIMM, PDLKAODOPAB KGOHOKDNHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D151B0", Offset = "0x7D13FB0", VA = "0x187D151B0")]
	private static void MKCALAIKNON(PHGKPLGIFII KHNPAPOAIMM, PDLKAODOPAB KGOHOKDNHKJ, IReadOnlyCollection<ByteString>? DPBOPBIEOFJ, IReadOnlyCollection<ByteString>? JOGNCAOCMFC, IReadOnlyCollection<ByteString>? GJFHNMOBGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D13E50", Offset = "0x7D12C50", VA = "0x187D13E50")]
	private static bool DBDAIJIMANL(PHGKPLGIFII KHNPAPOAIMM, OBHJNBIABOM JIAOEOOKDGO, PDLKAODOPAB KGOHOKDNHKJ, [Out][NotNullWhen(false)] string? NGENEEODOJL, [Out] Dictionary<int, int> PLOIIGHPOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D13B70", Offset = "0x7D12970", VA = "0x187D13B70")]
	private static Dictionary<Guid, OPHHACDDLLH> COEFEKJKEPE(PHGKPLGIFII KHNPAPOAIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D144F0", Offset = "0x7D132F0", VA = "0x187D144F0")]
	private static void DNILDCHOOHC(bool HHFLHHPIIKB, HDCAPCJGFLN KBPNMENODAC, HIKDLDBHEND GIMBMOGIFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D14EE0", Offset = "0x7D13CE0", VA = "0x187D14EE0")]
	private static void LODFEJFAFBO(HDCAPCJGFLN KBPNMENODAC, Guid MLMMNGNEKMO, DCMJPNFMAJD? BJEAALKPHEK, Dictionary<Guid, OPHHACDDLLH> IEEBMMEBNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D165A0", Offset = "0x7D153A0", VA = "0x187D165A0")]
	private static void OPNKEHFOHPH(IEnumerable<HDCAPCJGFLN> FOMKDPOPALB, IReadOnlyCollection<ByteString> DPBOPBIEOFJ, IReadOnlyCollection<ByteString> JOGNCAOCMFC, IReadOnlyCollection<ByteString> GJFHNMOBGLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct PDLKAODOPAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public bool HHFLHHPIIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public IJJFOFKKKJK PFAHPNGOBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public DCMJPNFMAJD? BJEAALKPHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public DCMJPNFMAJD? BPDDAOBEOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public CNOGAFAGIEK JMFKJIPKKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public LHIAMADJHDG GIHJJBIGJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public MBBEPPCICGI GBGEFCOPPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public KOIDEEJEAKA<HJIDLNADIFB> NEPLJEOFELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public MJGAJOPCPPN AECLDECLNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public List<HDCAPCJGFLN> BPFNGFKFNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public IKHGLHKGDCI AHNOGPGBINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public CDOEOPHCKHM BNHMABPCBBB;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DCMJPNFMAJD
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private const float OONNFPEBIFK = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public Vector3 NPJPCFKLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Quaternion LJIHJJKHDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public float JCGDFDLNFJA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 GHKPOGBOOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B5A0", Offset = "0x7D1A3A0", VA = "0x187D1B5A0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS FIKJMKJPCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B6B0", Offset = "0x7D1A4B0", VA = "0x187D1B6B0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x13E67B0", Offset = "0x13E55B0", VA = "0x1813E67B0")]
	public DCMJPNFMAJD(Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float JCGDFDLNFJA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B780", Offset = "0x7D1A580", VA = "0x187D1B780")]
	public DCMJPNFMAJD(UniformTRS PGCPDKPOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D1AFA0", Offset = "0x7D19DA0", VA = "0x187D1AFA0")]
	public static DCMJPNFMAJD BFLPECBINDL(DCMJPNFMAJD BOGJJGPKPIJ, DCMJPNFMAJD PLMPECPBMPD)
	{
		return default(DCMJPNFMAJD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B4A0", Offset = "0x7D1A2A0", VA = "0x187D1B4A0")]
	public static DCMJPNFMAJD HEKJAOMNHLJ((Vector3, Quaternion, float) FFEMKICJPKP)
	{
		return default(DCMJPNFMAJD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B320", Offset = "0x7D1A120", VA = "0x187D1B320")]
	public static DCMJPNFMAJD HEKJAOMNHLJ(Matrix4x4 GICEEOAOOOG)
	{
		return default(DCMJPNFMAJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B6F0", Offset = "0x7D1A4F0", VA = "0x187D1B6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B4C0", Offset = "0x7D1A2C0", VA = "0x187D1B4C0")]
	public DCMJPNFMAJD IJIIEJBAGCN(Matrix4x4 MAAFBDAKBJA)
	{
		return default(DCMJPNFMAJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B220", Offset = "0x7D1A020", VA = "0x187D1B220")]
	public static DCMJPNFMAJD FMOHAEHKDMG(Vector3 NPJPCFKLMHD)
	{
		return default(DCMJPNFMAJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B290", Offset = "0x7D1A090", VA = "0x187D1B290")]
	public readonly BHMLNBEKKIC HDMCNPDDEHP()
	{
		return default(BHMLNBEKKIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum MJJEMKNDIDF
{
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct FDFHBLPFLMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public readonly MINKIPGABAB OAKEFDPCEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly LPPJEHMJDEA LMCHAHNJDPI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x16B0730", Offset = "0x16AF530", VA = "0x1816B0730")]
	private FDFHBLPFLMI(MINKIPGABAB OEFNLALAAAN, LPPJEHMJDEA FGPOGIGNCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BCF0", Offset = "0x7D1AAF0", VA = "0x187D1BCF0")]
	public CACBPFJIIIM JPECFNNEGOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BED0", Offset = "0x7D1ACD0", VA = "0x187D1BED0")]
	public static JKEBLLKKBOM<HIKDLDBHEND, FDFHBLPFLMI> NBEICDCLFEE(AKBPKLBDLGF<NICNPLCGCEF> FGPOGIGNCKH)
	{
		return default(JKEBLLKKBOM<HIKDLDBHEND, FDFHBLPFLMI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BD60", Offset = "0x7D1AB60", VA = "0x187D1BD60")]
	public static JKEBLLKKBOM<HIKDLDBHEND, FDFHBLPFLMI> NBEICDCLFEE(CACBPFJIIIM FGPOGIGNCKH)
	{
		return default(JKEBLLKKBOM<HIKDLDBHEND, FDFHBLPFLMI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BE10", Offset = "0x7D1AC10", VA = "0x187D1BE10")]
	public static JKEBLLKKBOM<HIKDLDBHEND, FDFHBLPFLMI> NBEICDCLFEE(string KPEJJLKCIIM)
	{
		return default(JKEBLLKKBOM<HIKDLDBHEND, FDFHBLPFLMI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MINKIPGABAB
{
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MHJBBFIGEEA : IDisposable, IEAOPNPEIDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private NativeList<CCHLCODHAON> BKMMPHCNDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private float KJDAAIEHNMH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PGGJHKNGOPJ FGMBINPLOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(PGGJHKNGOPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EJAHBPFHEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C40690", Offset = "0x6C3F490", VA = "0x186C40690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool GJMFOEEOPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6C406A0", Offset = "0x6C3F4A0", VA = "0x186C406A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<DBJNEDIPLPA> ANCEIMMOCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OKLKEEHKKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F450", Offset = "0x7D1E250", VA = "0x187D1F450", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float HFDMKGJKBKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7D202B0", Offset = "0x7D1F0B0", VA = "0x187D202B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D21780", Offset = "0x7D20580", VA = "0x187D21780")]
	public MHJBBFIGEEA(PGGJHKNGOPJ KKBDAOHAGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F7A0", Offset = "0x7D1E5A0", VA = "0x187D1F7A0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1EF80", Offset = "0x7D1DD80", VA = "0x187D1EF80")]
	public Vector3 ALBOOIKIDIM(int KILCKNBNPEG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D20E40", Offset = "0x7D1FC40", VA = "0x187D20E40", Slot = "6")]
	public Quaternion OHELCOIBEHN(int KILCKNBNPEG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FA10", Offset = "0x7D1E810", VA = "0x187D1FA10", Slot = "5")]
	public Vector3 HAJDHAFPCHP(int KILCKNBNPEG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F9B0", Offset = "0x7D1E7B0", VA = "0x187D1F9B0", Slot = "7")]
	public float HAGKCEGKFBF(int KILCKNBNPEG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D203F0", Offset = "0x7D1F1F0", VA = "0x187D203F0")]
	public void NCFPHJEOFIK(Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float MEHMJKKFJEH, bool GGMBFPBEADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F800", Offset = "0x7D1E600", VA = "0x187D1F800")]
	private bool FEEJPMAMMBL(int OKEOFCFHJPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FC00", Offset = "0x7D1EA00", VA = "0x187D1FC00")]
	public void IMDLPJCHOGH(Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float MEHMJKKFJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FD80", Offset = "0x7D1EB80", VA = "0x187D1FD80")]
	public void KBFFIDAMKED(int OKEOFCFHJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FAB0", Offset = "0x7D1E8B0", VA = "0x187D1FAB0")]
	public void HBHNBPPBHJE(int OKEOFCFHJPL, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float MEHMJKKFJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F490", Offset = "0x7D1E290", VA = "0x187D1F490")]
	public void BGOJKLOJOIJ(int OKEOFCFHJPL, float3 NPJPCFKLMHD, quaternion LJIHJJKHDDH, float MEHMJKKFJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F860", Offset = "0x7D1E660", VA = "0x187D1F860")]
	public void FGDBBHLEIHO(int OKEOFCFHJPL, Vector3 NPJPCFKLMHD, float MEHMJKKFJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F640", Offset = "0x7D1E440", VA = "0x187D1F640")]
	public void BHIPNFDIFJH(int OKEOFCFHJPL, Vector3 KODPDAPHGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D20F70", Offset = "0x7D1FD70", VA = "0x187D20F70")]
	public static Quaternion OKHEMICHHCI(Quaternion NHBCDKIJGAO, int OKEOFCFHJPL, float NHFGOJJJAOO, IEAOPNPEIDM PGHEJOMPKCP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FE10", Offset = "0x7D1EC10", VA = "0x187D1FE10")]
	public Bounds KEMIIGKPDLH(Transform MAAFBDAKBJA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D20D00", Offset = "0x7D1FB00", VA = "0x187D20D00", Slot = "10")]
	public virtual void NKPEDEOMFGB(bool DDBGNCBHPMM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D20D70", Offset = "0x7D1FB70", VA = "0x187D20D70")]
	public NativeList<CCHLCODHAON> NLKJJLCNKNK(float FLFAHPODEKL = 1f)
	{
		return default(NativeList<CCHLCODHAON>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DBJNEDIPLPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public float3 HKMBNCFKKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public float LLINGMLBPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public quaternion LLFFLHBOCBG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1AF20", Offset = "0x7D19D20", VA = "0x187D1AF20")]
	public DBJNEDIPLPA(Vector3 HAMOKFILEGG, Quaternion NHBCDKIJGAO, float MEHMJKKFJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A9D0", Offset = "0x7D197D0", VA = "0x187D1A9D0")]
	public Quaternion EFNPJJABCCI(Vector3 MACLBEFOGKL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1AA90", Offset = "0x7D19890", VA = "0x187D1AA90")]
	public DBJNEDIPLPA JACAEEJOELB(Vector3 DAFPHKHGCHG, Vector3 MDNPMAALHAJ, Vector3 JLMJHBPCIHI)
	{
		return default(DBJNEDIPLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7D1AD80", Offset = "0x7D19B80", VA = "0x187D1AD80")]
	public IEGNODMAIIB NOPCOOJDAOF(Vector3 MACLBEFOGKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class MMHDOJFBENB : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7D21970", Offset = "0x7D20770", VA = "0x187D21970", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D21CD0", Offset = "0x7D20AD0", VA = "0x187D21CD0")]
	private void OHLMHCFEGHK(Dictionary<Guid, Guid> EIEKKCNNMGD, IGABFPKBBIO NGFEDPIONOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D219F0", Offset = "0x7D207F0", VA = "0x187D219F0")]
	private void OHLMHCFEGHK(Dictionary<Guid, Guid> EIEKKCNNMGD, AJHGMDOPPME PBGJJOBABDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7D21A50", Offset = "0x7D20850", VA = "0x187D21A50")]
	private void OHLMHCFEGHK(Dictionary<Guid, Guid> EIEKKCNNMGD, JCGJEIPDFKO NHGLLABMMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MMHDOJFBENB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class PEFNODCFDNK : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D22A20", Offset = "0x7D21820", VA = "0x187D22A20", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PEFNODCFDNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class CPOBIGGLLPF : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A6B0", Offset = "0x7D194B0", VA = "0x187D1A6B0", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CPOBIGGLLPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class MJDAOFKKEOC : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7D21810", Offset = "0x7D20610", VA = "0x187D21810", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MJDAOFKKEOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class BKIEAEKNOIF : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7D16EF0", Offset = "0x7D15CF0", VA = "0x187D16EF0", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BKIEAEKNOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class IMAMEMFPBMC : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C140", Offset = "0x7D1AF40", VA = "0x187D1C140", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IMAMEMFPBMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OAEOCPFDMKD : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7D222B0", Offset = "0x7D210B0", VA = "0x187D222B0", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OAEOCPFDMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EFOLIFELNKJ : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BC00", Offset = "0x7D1AA00", VA = "0x187D1BC00", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public EFOLIFELNKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DALJEONFONL : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A810", Offset = "0x7D19610", VA = "0x187D1A810", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public DALJEONFONL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class HBAMBIKGIHB : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BF80", Offset = "0x7D1AD80", VA = "0x187D1BF80", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HBAMBIKGIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class PDKECEOMDOE : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7D22920", Offset = "0x7D21720", VA = "0x187D22920", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PDKECEOMDOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class ODPGBFHNIBM : FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public static readonly AMIFNINIMEH CLKMDHNJGDK;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7D227F0", Offset = "0x7D215F0", VA = "0x187D227F0", Slot = "4")]
	public void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public ODPGBFHNIBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct EGLFCNPOKGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public OBHJNBIABOM MFIBIFPFGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public HFFEILKEBJG AOMLNICLGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public Dictionary<int, int> CFIOACGBNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public Dictionary<Guid, Guid> HKKCIJCKDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public CDOEOPHCKHM BNHMABPCBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public bool MPONGKDCCKF;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FAECBGBHAIK
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIDKKLNBKDE(JOEDMIOJDGE OOKELODKLHP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JAEGAGOOCOA
{
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private static readonly FAECBGBHAIK[] CLDAJFDBFEI;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CE20", Offset = "0x7D1BC20", VA = "0x187D1CE20")]
	public static void CLKEFJOLACA(HDCAPCJGFLN FFEMKICJPKP, HIKDLDBHEND BKCAFHMHGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D470", Offset = "0x7D1C270", VA = "0x187D1D470")]
	public static void MAJBKINHDCD(HDCAPCJGFLN? FFEMKICJPKP, HIKDLDBHEND GGIMJDAGNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CBA0", Offset = "0x7D1B9A0", VA = "0x187D1CBA0")]
	public static void CGJNOKMKFGA(HDCAPCJGFLN? FFEMKICJPKP, HIKDLDBHEND GIMBMOGIFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D0A0", Offset = "0x7D1BEA0", VA = "0x187D1D0A0")]
	public static void INHEJCEIPHJ(JOEDMIOJDGE OOKELODKLHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct JOEDMIOJDGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public OBHJNBIABOM FCMHMPIKELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public HDCAPCJGFLN KBPNMENODAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public Dictionary<int, int> CFIOACGBNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	public Dictionary<Guid, Guid> HKKCIJCKDNA;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DCE0", Offset = "0x7D1CAE0", VA = "0x187D1DCE0")]
	public Guid MOKPDBBEAPN(Guid PDFBNFKDLAH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CDOEOPHCKHM
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KFIAMAJIHGM, [Out] Guid OAHAMMEKMHN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class BOGEAFJJIPM
{
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private static readonly ProfilerMarker GDBGPJACLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private readonly HashSet<string> DCOBNNPPGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private readonly Dictionary<long, int> AGBAGKEHGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	private readonly HashSet<Guid> BAIJKAJOHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private readonly HashSet<Guid> MPOLPBLFNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	private readonly HashSet<Guid> JLEFIJLEGHC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> PNNIOANOGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> CCOIBIPMKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyCollection<Guid> JBBNIFJBLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<long, int> NHMEOOMLAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7D17110", Offset = "0x7D15F10", VA = "0x187D17110")]
	public static void ABEILCBDLFO(PHGKPLGIFII BPNOEPABNLA, ODKLBJOEAND EKHCDJEHMDA, HIKDLDBHEND NJKOAEGKMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7D19FC0", Offset = "0x7D18DC0", VA = "0x187D19FC0")]
	public static BOGEAFJJIPM NEJIIHEJIJE(IEHAENGDKAI MLFFBNNKHKH, ODKLBJOEAND? EKHCDJEHMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7D18750", Offset = "0x7D17550", VA = "0x187D18750")]
	public static BOGEAFJJIPM BBLKFENFJKD(PHGKPLGIFII HFPIFEMGIJK, ODKLBJOEAND? EKHCDJEHMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A040", Offset = "0x7D18E40", VA = "0x187D1A040")]
	public static BOGEAFJJIPM NGOICAAIFKP(DKCBLOOENML EAHOAAFDFAI, ODKLBJOEAND? EKHCDJEHMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7D186C0", Offset = "0x7D174C0", VA = "0x187D186C0")]
	public static BOGEAFJJIPM AMBGNLCBAFH(IEnumerable<string> DCOBNNPPGGJ, IReadOnlyDictionary<long, int> KCOAHNJALIC, IReadOnlyCollection<Guid> JLEFIJLEGHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A380", Offset = "0x7D19180", VA = "0x187D1A380")]
	private BOGEAFJJIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A180", Offset = "0x7D18F80", VA = "0x187D1A180")]
	private BOGEAFJJIPM(IEnumerable<string> DCOBNNPPGGJ, IReadOnlyDictionary<long, int> KCOAHNJALIC, IReadOnlyCollection<Guid> JLEFIJLEGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D19210", Offset = "0x7D18010", VA = "0x187D19210")]
	private void JGHFMKEDAGI(IEHAENGDKAI MLFFBNNKHKH, ODKLBJOEAND? EKHCDJEHMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D19430", Offset = "0x7D18230", VA = "0x187D19430")]
	private void JGHFMKEDAGI(PHGKPLGIFII HFPIFEMGIJK, ODKLBJOEAND? EKHCDJEHMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D189C0", Offset = "0x7D177C0", VA = "0x187D189C0")]
	private void GOIGOLGGGME(ByteString? MJJKIDBMBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D19A50", Offset = "0x7D18850", VA = "0x187D19A50")]
	private void JGHFMKEDAGI(DKCBLOOENML? IPCOMOHMNHK, ODKLBJOEAND? EKHCDJEHMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D17EC0", Offset = "0x7D16CC0", VA = "0x187D17EC0")]
	private static void ABEILCBDLFO(DKCBLOOENML? IPCOMOHMNHK, ODKLBJOEAND EKHCDJEHMDA, HIKDLDBHEND NJKOAEGKMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D18260", Offset = "0x7D17060", VA = "0x187D18260")]
	private static void ABEILCBDLFO(EIPFIANKEMH? BINEDJHADMC, ODKLBJOEAND EKHCDJEHMDA, HIKDLDBHEND NJKOAEGKMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D18F80", Offset = "0x7D17D80", VA = "0x187D18F80")]
	private void JGHFMKEDAGI(EIPFIANKEMH? BINEDJHADMC, ODKLBJOEAND? EKHCDJEHMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D19DB0", Offset = "0x7D18BB0", VA = "0x187D19DB0")]
	private void MNINDHKKJGJ(Guid? PDFBNFKDLAH, ODKLBJOEAND? EKHCDJEHMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D19650", Offset = "0x7D18450", VA = "0x187D19650")]
	private void JGHFMKEDAGI(HDCAPCJGFLN? KBPNMENODAC, ODKLBJOEAND? EKHCDJEHMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D17A70", Offset = "0x7D16870", VA = "0x187D17A70")]
	private static void ABEILCBDLFO(HDCAPCJGFLN? KBPNMENODAC, ODKLBJOEAND EKHCDJEHMDA, HIKDLDBHEND NJKOAEGKMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D18950", Offset = "0x7D17750", VA = "0x187D18950")]
	private void GKMGDEMDDKB(string? HBNCFGDFCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D18880", Offset = "0x7D17680", VA = "0x187D18880")]
	private void DKMLFDMOPEF(long COECJEJOOKF, Guid ADFEGBCJFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D187D0", Offset = "0x7D175D0", VA = "0x187D187D0")]
	private void DKMLFDMOPEF(PLFNICIDHCL? INNLFPGIIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D18820", Offset = "0x7D17620", VA = "0x187D18820")]
	private void DKMLFDMOPEF(FEIPEJBHKOO? INNLFPGIIAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LJNAKMMEMHL
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class DEHBPIIKHNA : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private readonly IEnumerator<DictionaryEntry> BMMKBOAHBPI;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DictionaryEntry CAFBAAOHBLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7D1B9D0", Offset = "0x7D1A7D0", VA = "0x187D1B9D0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7D1BAA0", Offset = "0x7D1A8A0", VA = "0x187D1BAA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object COJGBJGNJFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7D1BB50", Offset = "0x7D1A950", VA = "0x187D1BB50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7D1B8F0", Offset = "0x7D1A6F0", VA = "0x187D1B8F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
		public DEHBPIIKHNA(IEnumerator<DictionaryEntry> BMMKBOAHBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B850", Offset = "0x7D1A650", VA = "0x187D1B850", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B8A0", Offset = "0x7D1A6A0", VA = "0x187D1B8A0", Slot = "9")]
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
		private sealed class CJDGOJCHOPF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x7D1A660", Offset = "0x7D19460", VA = "0x187D1A660", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public CJDGOJCHOPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7D1A510", Offset = "0x7D19310", VA = "0x187D1A510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7D1A610", Offset = "0x7D19410", VA = "0x187D1A610", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7D233D0", Offset = "0x7D221D0", VA = "0x187D233D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IDictionary.this[object MAKJJJECHHB]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7D232E0", Offset = "0x7D220E0", VA = "0x187D232E0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7D234C0", Offset = "0x7D222C0", VA = "0x187D234C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7D23220", Offset = "0x7D22020", VA = "0x187D23220", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7D23280", Offset = "0x7D22080", VA = "0x187D23280", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7D23460", Offset = "0x7D22260", VA = "0x187D23460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7D22EE0", Offset = "0x7D21CE0", VA = "0x187D22EE0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7D22F40", Offset = "0x7D21D40", VA = "0x187D22F40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7D22FA0", Offset = "0x7D21DA0", VA = "0x187D22FA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
		public RoomObjectCounts(Dictionary<int, int> KDLGLEENKMO, [Optional] Dictionary<int, int> HNCHOEKNHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7D22E00", Offset = "0x7D21C00", VA = "0x187D22E00")]
		[IteratorStateMachine(typeof(CJDGOJCHOPF))]
		private IEnumerator<DictionaryEntry> CHDFKAKGGFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D23510", Offset = "0x7D22310", VA = "0x187D23510", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D23120", Offset = "0x7D21F20", VA = "0x187D23120", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7D23000", Offset = "0x7D21E00", VA = "0x187D23000", Slot = "9")]
		void IDictionary.Add(object MAKJJJECHHB, object OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7D23060", Offset = "0x7D21E60", VA = "0x187D23060", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D230C0", Offset = "0x7D21EC0", VA = "0x187D230C0", Slot = "8")]
		bool IDictionary.Contains(object MAKJJJECHHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D231C0", Offset = "0x7D21FC0", VA = "0x187D231C0", Slot = "14")]
		void IDictionary.Remove(object MAKJJJECHHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D22E80", Offset = "0x7D21C80", VA = "0x187D22E80", Slot = "15")]
		void ICollection.CopyTo(Array KNDCNOIHMGO, int GLAOLHCPLLG)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class AOCGIPKOPCA : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x7D16EA0", Offset = "0x7D15CA0", VA = "0x187D16EA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public AOCGIPKOPCA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7D16D10", Offset = "0x7D15B10", VA = "0x187D16D10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7D16E50", Offset = "0x7D15C50", VA = "0x187D16E50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7D1C8C0", Offset = "0x7D1B6C0", VA = "0x187D1C8C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IDictionary.this[object MAKJJJECHHB]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7D1C790", Offset = "0x7D1B590", VA = "0x187D1C790", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7D1C970", Offset = "0x7D1B770", VA = "0x187D1C970", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7D1C6D0", Offset = "0x7D1B4D0", VA = "0x187D1C6D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7D1C730", Offset = "0x7D1B530", VA = "0x187D1C730", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7D1C910", Offset = "0x7D1B710", VA = "0x187D1C910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7D1C350", Offset = "0x7D1B150", VA = "0x187D1C350", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7D1C3B0", Offset = "0x7D1B1B0", VA = "0x187D1C3B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7D1C410", Offset = "0x7D1B210", VA = "0x187D1C410", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2811560", Offset = "0x2810360", VA = "0x182811560")]
		public Invention(long FONJFDCCINO, int ALFGNAHPKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C280", Offset = "0x7D1B080", VA = "0x187D1C280")]
		[IteratorStateMachine(typeof(AOCGIPKOPCA))]
		private IEnumerator<DictionaryEntry> CHDFKAKGGFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C9C0", Offset = "0x7D1B7C0", VA = "0x187D1C9C0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C590", Offset = "0x7D1B390", VA = "0x187D1C590", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C470", Offset = "0x7D1B270", VA = "0x187D1C470", Slot = "9")]
		void IDictionary.Add(object MAKJJJECHHB, object OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C4D0", Offset = "0x7D1B2D0", VA = "0x187D1C4D0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C530", Offset = "0x7D1B330", VA = "0x187D1C530", Slot = "8")]
		bool IDictionary.Contains(object MAKJJJECHHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C670", Offset = "0x7D1B470", VA = "0x187D1C670", Slot = "14")]
		void IDictionary.Remove(object MAKJJJECHHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C2F0", Offset = "0x7D1B0F0", VA = "0x187D1C2F0", Slot = "15")]
		void ICollection.CopyTo(Array KNDCNOIHMGO, int GLAOLHCPLLG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> HOMGODBAEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	public readonly IReadOnlyList<Invention> GADNONNHCNC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
	public LJNAKMMEMHL(IReadOnlyDictionary<Guid, RoomObjectCounts> CJNFLKGLDPO, IReadOnlyList<Invention> PLLHENJHDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E570", Offset = "0x7D1D370", VA = "0x187D1E570")]
	public static LJNAKMMEMHL NEJIIHEJIJE(IEHAENGDKAI MLFFBNNKHKH)
	{
		return default(LJNAKMMEMHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E450", Offset = "0x7D1D250", VA = "0x187D1E450")]
	[CompilerGenerated]
	internal static int MHMPDNABGKB([In] IReadOnlyDictionary<long, int> PDIGOMCPHIK, long? COECJEJOOKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DD90", Offset = "0x7D1CB90", VA = "0x187D1DD90")]
	[CompilerGenerated]
	internal static void GIALACLBBGH(int PMFMIFEIMKH, [In] DKCBLOOENML KMDHPPCOEFG, [In] Dictionary<long, int> PDIGOMCPHIK, [In] Dictionary<Guid, RoomObjectCounts> CJNFLKGLDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum EAPJEEPAOBC
{
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	Projectile
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class ODKLBJOEAND
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class POENLNHIDDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public readonly Guid JHILAODNCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public readonly IReadOnlyList<Guid> CCOIBIPMKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public readonly EAPJEEPAOBC OAKEFDPCEMD;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D22DA0", Offset = "0x7D21BA0", VA = "0x187D22DA0")]
		public POENLNHIDDE(Guid DGIHKBKLLKL, IReadOnlyList<Guid> JLEFIJLEGHC, EAPJEEPAOBC OEFNLALAAAN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private readonly HIKDLDBHEND KFCIGPAGJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private readonly Dictionary<Guid, POENLNHIDDE> LBHOBMJKHEL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HIKDLDBHEND EAKBBAIGBHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D22450", Offset = "0x7D21250", VA = "0x187D22450")]
	public void AIKICPLLADB(Guid NKMLDDFNBFF, Guid JNJJJELGKGJ, IReadOnlyList<Guid> GGGHOIHJPOK, EAPJEEPAOBC OEFNLALAAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D22660", Offset = "0x7D21460", VA = "0x187D22660")]
	public bool FCNMPJOJFEB(Guid DICIGALDDCI, [Out] POENLNHIDDE JLBIAANELCD, [Out] bool IMCGEMDOPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D22750", Offset = "0x7D21550", VA = "0x187D22750")]
	public ODKLBJOEAND()
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
