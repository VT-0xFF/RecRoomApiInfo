using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83C9590", Offset = "0x83C7B90", VA = "0x1883C9590")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AFLGABFKKLA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> ADJAHJNLKLE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> PGKJMJEHIPE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> IKJHDOOHICF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> NCJPBPJEPPG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string OHHMBHJGOGH;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string DPJIKFAHDJK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string HJKNMNFCENC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83B6920", Offset = "0x83B4F20", VA = "0x1883B6920")]
	public static bool MADMKOJAHGF(Guid KHFCIOENLMP, int HFLNPHFIFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x83B61C0", Offset = "0x83B47C0", VA = "0x1883B61C0")]
	public static bool EOKECJGDKON(Guid KHFCIOENLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83B6250", Offset = "0x83B4850", VA = "0x1883B6250")]
	public static string JPPHOOBPEJG(Guid CLPJLOJHBDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[FMEECDNJMJA]
public enum MJNJDMKMNNI
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
	[Preserve]
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83C92A0", Offset = "0x83C78A0", VA = "0x1883C92A0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CLMLICMKJCG
{
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid NBFCEOHBDKE;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid MMPAGCLCNEH;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid FKDIFLBAOEG;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid KOMDKDCDIKO;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid JPAJEGJCOHD;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid KEFCCFNFAIK;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid GKMGLEMFLEN;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid CBNKHGKMODF;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid JLJAAKELEEL;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid DPLMJEJDKPH;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid PDHOOEMJGIG;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid KNKHKCDKJGM;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid AMEEKAGHBHE;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid ECANGDMAIOI;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid DGGPOHBEDFB;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid PBHIEMHJBMD;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid NFAJBAFNOHN;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid OAFNCCOCMEC;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid JIDFALIIOKG;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid CKNNKFMLLKB;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid OCIFLEEGBEO;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid ABKALMPBOBP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid PIBBHIDMMFE;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid JJLJLJGFPBP;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid AMNGPHPHMFD;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid GBBPMAGLPJP;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid JPJEFKIOIII;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid GLPAKKLLJOI;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid NIOMLEBFDJI;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid FGHOPFFJGBM;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid HIFLABKFPMC;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid LJIBJPBAGOK;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid KEEPOKCMDJH;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid HKNCGBHBJCH;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid DADNOINIHKP;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid BEPOBDENIPA;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid MEKFOJLIMIB;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid CNGKGFIIGCK;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid GGFILDAFACE;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid KCHGLBFLEKC;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid DHBJKNENMHH;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid FBFGHGFNOEM;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid NOMCEKKCGIO;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid BPPOBKGNACK;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid BEANFDLMFHH;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid MAAGNEIPJNM;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid KFMOCANHNPD;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid NNDNCIDAAAN;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid GKFJJFMGEBM;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid IGBHMBHGHPL;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid DFKGNEJHPFD;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid HCGMBNCDGKI;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid GNCKCIFFODC;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid BAALLBAOGDK;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid AKMGEMELEFB;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid FOJLHEELPJA;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid NBBDLDCKDGA;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid HHELFGPBCFM;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid CNNAMIGKAPN;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid JIIMOJCLAND;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid LOOJJENNNMA;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid NHIEOOMOJPF;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid PBNBEIGFGOL;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MIJFPHKELJH;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid CDIOBIIFFJD;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid DMGGGMGAFLI;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid BJHLIOBMJEO;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid NHMHMPAAPBM;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid DGHOIGPHBEJ;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid HDKFCIGOADO;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid ACHAINEAHMJ;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid HGCGHJJAAPE;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid ECONJFHLKKJ;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid HNDIONDJJOG;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid IIGKPDCBJKP;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid NPEPPAIEGBO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid IDPOABJHEGC;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid GPOFJKLECLG;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid OACDHKNHPJE;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid LGGLFFBCFOO;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid EMNNAPHGAJG;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid LDPLLFLKCOI;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid MCHKHDALJCI;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid LDMEEMHAALM;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid AHEHJGPNMOG;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid GPGMHLOAAGG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid FHHAGGPEHEN;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid DOENKINNJKH;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid NDHBDGMFDAE;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid NAEICLFNNAO;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid NEFLDFNAHJN;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid LJLGHLIODGJ;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid CFPLKCHMEBG;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid IMABOKLOPEI;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid HOFANPLPCCO;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid KAHCIGJPEIP;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid BJFAPHNKMJA;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid OBIEGJNDBFG;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid LNBFHFEIFKP;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid PHNGNGJGHNF;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid IEMJEELMFEB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid OCPFAFJAMND;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid PFMEFNHCPEH;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid FJMIGDMCIIP;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid MMGDDABEDOF;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid EJEGFDJHDBP;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid CBBAPOJDMCO;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid NBBLKOHCIMC;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid MPAFPOJFMAJ;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid FMCNBILOBAC;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid PKDIAALEJNM;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid OIJODDACBII;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid PKKBGLENJKP;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid APHOBIIHLNL;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid JFMHIFMBDJB;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid NECNDLKOHNI;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid DMAKJGGHPPC;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid HHACCCIEKCF;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid DCPNKPPKOLO;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid DIJBICNFCNF;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid HFOHMPCCDCA;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid BEELJGFOFBO;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid EPMCMLHIKFJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid ELNIFNHNPOJ;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid EAPLMNEGCMK;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid PLLIPDDEOCG;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid HIGOEGHKGCE;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid ECKJKJHJANJ;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid OPKJOAAJNHF;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid HJIPPAHEDHN;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid DONBJKPCPIE;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid AFFMBMCKIPH;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid BMOGBAOGJBO;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid KLIKFMAKIKD;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid LHHCOPCFEEB;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid ODOCAGFBBMN;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid AKLADNLONPO;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid JGGHBJAHIFP;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid PCIHOGFNCNK;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid EFNDBMBNMKK;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid LBJHLKJCHEA;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid LJJIALOMIFL;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid CDBFCHALEOP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid CNEKPBILKEN;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid MFPJMODFCJN;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid AMOANGCIMAE;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid BCNDBBHMMMH;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid AFEGINLFMPC;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid FDEJOPKHLIG;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid PFEIBOBCEDP;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid JGBOIIPAJIE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid MBADMJGCBKO;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FFGOEMDBBGB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid ABGAIOLNCMJ;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid NKONOAPJGGB;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid KFCJFDOFCJK;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid JMNMKAFHCJO;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid LMDCMIFEDFM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid DEBDCLPNCPB;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid DLJDIEBOLGE;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid OBGBDMIDBCF;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid LHPAHCDDEJO;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid ABHINGIFBCK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid MOBMFPOCLIN;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid PANCFJLAJCK;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid DNINIJALDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid KPEAIACEPCE;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid NJNBMKOHHHC;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid DGCBEADLODB;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid MGGANJDFNLA;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid FGJEEIOPGFC;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid CGBIBBLCBDJ;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid LEDCACBAHLK;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid PKCGGOHPBGN;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid HDJNHHEMEDE;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid OHLPFMAHOGF;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid LLDPILEONFA;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid ECNOPLLNLOK;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid LJHGDPIDMOM;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid EAOKNAENONN;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid ODHOLECKDPG;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid JBMBDHCEEIA;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid IKLNPHOHAOD;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid HFKBHBCPMEG;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid ANLIHCFMNPE;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid IHEDINHBGIK;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid FCAGGDHMGLO;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid FFGGMOLOEDC;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid AEHEMPLCMOJ;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid KMOEBBCAFDO;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid CFEMNMIPPNC;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid DNECGPFPGCM;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid IIBPJENOGPI;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid FNKEPHAKMEA;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid OHACLMKIJJI;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid OBIDPPAAIIJ;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid CJEEEMIMLCB;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid OKMICJDNIJO;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid OMLDFDALFAC;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid IIHDHJOAKOI;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid KHAJJHJGBDC;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid LNEOOPAJJIP;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid HPCGFAEMIBB;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid OMDHMBECBKF;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid KAPMOEDMHJC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid JDNNKAIKBIG;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid LCPFHGAELLB;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid CAMJNMAEAMP;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid NHAMPCEHDHO;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid KLBMBFFIPCG;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid MDLBOMBKFNO;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid FCCKOCOPHFK;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid DHJNNPGGLHL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid LHINJOHLGID;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid JHDGLKJOPKD;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid HHJEMAAOOGC;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid HALFCIICOHA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid HJEDELIPJPN;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid JBAGJGODGCI;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid AFEINLIPFIE;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid IDGFGMIJBBI;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid ALKKIGKINJN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid NNEGLLHFFLN;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid FIDKGMNMLIA;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid MPDPPBNMBNO;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid GNADLOLDFCD;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid BAOOBEJJBJP;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid EEOEBKGGMGC;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid MENALIOILIK;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid BELGLLAKIJJ;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid OINGKGBLIMA;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid JOMLBHAGKEN;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid NKKIHHCEKGC;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid GLFCMBAIIAE;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid AMICLJFILGD;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid JKACDIHBFFA;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid KGLADAEMMCM;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid NFMCMKIFFBL;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid CANKCOAGAIH;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid CPKIABLBGIB;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid IICDHADMLCP;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid FFDLEIEDJAG;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid AHADAHMIBGD;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid KENLCGAAJMG;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid BCNLOADEFHD;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid MKMCPIDMOIP;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid MKDGLDPNOAP;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid NKNIDMFFNIH;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid KEGMLKEHBPM;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid IMDOPIBAOPL;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid PDCDIOIDGFE;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid CCOLKKCFMJO;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid CKJBOBFMPAL;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid LOCBNMIKGOC;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid IJIIPMOBBKD;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid IKMJIPLICAB;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid HLNPDAELFMK;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid EIKGLCFPICG;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid DIMMPBBBJGB;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid GMKHEHCEOAF;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid DGAPCKFCNGK;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid MBKLEDGABGM;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid KPFDOBHPFGB;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid BGAKJIFAPCF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid CDBJPJOMJCJ;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid BBEDIFBIJIH;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid MOIGDBBIKNO;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid HIBMLBFDKEF;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid JEPBOJOMJDE;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid IGNFCONCPAO;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid MHFFBAJIBDP;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid IDKAKGFOPKM;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid LNKKNMOHDEO;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid MLICJOKHFBN;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid MHMAMGDFKBB;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid JGPAFHHBFCF;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid BCBMIBDLLAN;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid BJJCOLDBNCH;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid HFIABOJFCAP;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid FOOJBDLONDE;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid CPFJKJKJNMF;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid EADHFPKACHA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid MDNILGCNGOP;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid KFICLKBKPCB;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid FAOHALFELFM;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid JCGLDBJPLPM;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid LFBMKFBBLKC;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid PGPIOHGINOB;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid IAOJPIEKLBD;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid GCDJOLFAPGM;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid EIDPFGMFEMG;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid BFNPECJAJOD;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid FPPMNFIBALA;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid LHDMJAEKMGG;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid MEMBJFKCLMK;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid ADPIFPEDNAF;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid PBMBEKCBMBH;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid BDNECLPLLOD;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid MPONOIHIDOM;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid FIDLIIIDHOH;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid JJAHLADIMLO;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid LGPBHBLJHOE;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid HONNOFEECJF;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid LLHJAHPOIAO;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid PPIBLCKCBLB;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid GBJPFGFIGEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid OCLNAABICLF;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid NJEEPCIBDOB;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid HPLIHGHAMCA;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid BLCLPOAKGBI;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid AAOKOPOCDLE;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid JJLKKAFPIHG;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid LCDGEFBHOHF;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid NCGHBICNDFH;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid NFHINOOIAPO;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid AKNCPIANGOH;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid KOEKLIPMPDC;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid EOKLOINFEHM;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid DDNPBAIKENA;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid IODHLFEEIFJ;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid CLGIGCNKBLL;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid GGCGOPKKMDH;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid CMGGILLLPAB;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid FMCDOMDPGBO;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid IJJDFJEOHLD;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid PPDAHLIECEM;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid NLCOLAKKGAH;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid OICBBAMMONG;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid OBEKHGLMONF;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid FADKJBDLOFK;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid JHNMDELCMFH;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid LHPNOCAGNGK;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid GIMIKHHPMLK;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid HDLIODKEIFM;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid DPKNFFNOLCA;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid GLDOKFFMPLB;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid JPENGGLFJNG;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid HBAMAMPGHLN;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid CMCDGBBAKMN;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid BMKJDOLPFMH;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid KCHENBHNMOL;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid DDAFKFJKEFH;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid PPDJABPHCKH;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid MDKEONLAGIJ;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid BDDKLKAFDPC;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid LCLNLCBGOKK;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid MGLILKBJOPB;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid OIIELJNNLPN;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid PDIMODMFCGI;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid POEEOJDIBHD;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid BIKFABFLECK;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid DNKLMODMIFF;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid ICLPIMNKBHB;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid NFNDNGKLNKH;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid LKPBLEAGBEH;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid CGALNAPOPGA;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid APDFCFKCPJD;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid GHOHAOIFDMF;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid MIGJAPCLIIJ;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid EPLGHFMGCDH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid JFLPKCGBOKD;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid KGEECPFNJJF;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid BBMEHJGGIHC;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid KJMONNHPOFI;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid BKMIJLANJPD;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid MMGBOGFPOGO;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid MHLDCAIIOAK;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid JCKEKDPEEON;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid CEDGHOIKIHJ;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid MFPIIHNNDGJ;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid KJMFHADCLMF;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid MECFHBOJHOH;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid ECCBBNEEHKA;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid OIKBOONEGDB;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid FPNNLPJJOEA;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid JOMDMILIODE;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid NCPDOCKFODM;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid EJPFLKPHFAF;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid NMENIFBFPGI;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid EAGKOMBMOEC;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid OOMBPOKOBDL;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid LLOMEIICEDG;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid JAIDHEFCJGN;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid MJNNPMGHEDJ;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid MAOLBILEOKC;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid MMPMCHDKKHN;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid KCOIFGPEDMK;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid OCGIAOGOJIG;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid BGOJGCOOLFF;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid KDIGKIPAAAB;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid DNFCNFJPKAP;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid NFPJIKEPBIJ;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid DLBMEFEFOPG;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid JPOPDOIKLLA;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid NAPMMMEIPAA;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid FIEKOFFGHJE;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid IKHDGLFIPCF;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid IKEGJOEPOLK;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid KDHNAGPFCDL;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid EENAFJKHEAK;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid NHAEBPILMBP;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid DEJGHLADLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid NEFNLPFPNDG;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid AAJEIIFFFKA;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid EMPMIOLJFDN;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid ELMPDOBKGLE;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid AEHFEOMPOAJ;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid KKBECLHCHDM;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid LLICJICBKEF;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid FNAAOLNOIHL;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid ACJPCCIILMF;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid PGODAPEPGBP;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid DDJICCAOJAK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid GBNOECCOFBI;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid JEDPLNBBBIK;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid ECMLIFDNHJG;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid LDJBOELGHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid FIAAFJCGEJD;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid DAMDPCOIJCK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid BHHCEKNBNLF;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid CLHPADNEDLL;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid JJMOMKHOLLI;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid PBICEPBNIFD;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid FOCFGGHMOLG;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid HLINFNJPDOO;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid DFEGFBENDHE;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid HHGAKOHDKEM;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid BGNBKJBDBEI;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid IBPNJOMMBOL;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid MEFKBIPABDH;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid DGKJHIJBCOC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid KDJIEKFGGHH;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid CFBKEKJMIPH;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid IGNJGLHNJEH;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid IGOLOGFLOIO;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid BJCBPJEPPLE;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid MMCINHDEKMP;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid PKGDDKPNGCD;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid MKKFJPHGGJH;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid JOGNFDFLAAB;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid FHAFCEIEBPJ;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid IEOCIPKOHJD;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid IIALPANJMJJ;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid OKANIKDELGL;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid PBNKEGDCOKF;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid BNJIFMDOKAC;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid NALHGJGKHMH;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JCMLEGNKALE;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid IJJDCGNKLMD;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid OFCCHAKIAAI;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid AMPOOJKIEGP;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid OANHNINHIMA;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid BKHKLOBFKFG;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid PLFKNLLNPBN;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid BOKLLNNAEME;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid JFAPDFKIGCO;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid LCNCBNPDNKG;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid DKAMOPIOGPJ;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid JEJDONPPPGJ;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid AKNENIPOHKI;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid HNLPPHOLAAF;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid AHGCGOFEFCE;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid PFJOANPALBE;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid PFEAMHIEOIN;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid CJIGFKBIGNK;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid BMDDNFNMFAK;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid HGOAFEHMEJM;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid JBKLBONJKFF;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid JFLOMOCJFHP;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid JMGJILGAFEN;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid DPDOOMHPNBL;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid BIGININNDGD;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PFAOKDKHGIE;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid MKICOMHNMJO;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid JJKPIAKHONJ;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid NCJNMLJOAOB;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid MMOCNNOJJMI;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid JALHPKDMLPL;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid KMABKBNBBGN;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid FGKMHEKMGPI;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid BJBNKPOAHFM;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid LMEIEOEMJNC;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid BBMGHGAOBOJ;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid HOPILLOFFOL;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BNMOHOLEIGE;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid MICLNBLCKAH;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid ANEEOAPBHOC;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid HLBIHHEJKOK;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid GKEHKOMEJIN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid PKEIBIJJLIH;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid HIPLEFEFHBA;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid ALHGNGOHFHG;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid JIMDJMPPLDA;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid CGLMAJBFMGC;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid OCHDCPPIDCD;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid JNKCMDEFHBA;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid IHDFJMOJMML;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid NEJFLKNELNE;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid CCCDNNALKHH;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid KHMOFMMMHOC;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid LJMGHHCHFLP;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid AJJODCFDGAC;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid KMENIAFNLOB;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid BKJOKCEDGKO;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid CEOBEHOMNEN;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid OIFDKNHBGPI;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid HAMOLHCECOD;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid IKADLBGJPLB;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid KANBKALOFMK;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid PEEGLBFNGHH;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid JEOBHEHBPAG;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid MBDJNFODDFB;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid PCGLNKDCJOB;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid IIPNKONNIMH;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid GBNKJJPJFDI;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid KPEBJMKKGKH;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid HFAPKNAJBHG;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid JMNIAHIJMOB;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid DMINDKEINBP;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KIHABMCMPGF;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid JDFNPFMLJNP;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid JOLMOGDLBEG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid EPPPPOIEGOP;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid KGIALFEPOGH;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid GDKHDIIJEEI;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid MMLKDDAIFPL;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid PIOOHEBDPLP;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid KCMINIONACI;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid KIEPILMDDDL;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid OHFKKBBHFBG;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid IPNGCMICKAO;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid FJGNJNIMJNL;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid KEPHODPDALE;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid MDIJLKECDAN;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid GPEPAPNFJGA;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid BMJNHOPBACO;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid MFKPGGMOBAG;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid JJAFHAJNENA;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid OOKFLMCANKG;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid GGOOOABCECP;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid NNJNMEJLLBA;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid GFHNFIKFBPL;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid LHHDHBLHJHE;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid CIGFDEEONIJ;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid JLAKOPLMBCE;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid JCPPKIILEAE;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid OMFCIHNEKLD;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid NPGBDCHGFDE;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid BAKHHANDLHF;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid KJHKADCPIFH;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid GLOFHCPLICM;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid CFBDGBAMABJ;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid AOINOBBCGCO;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid NLAMPAFGDIL;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid DLLJGBGMFFA;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid AELNNAELKEL;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid NOLPFNFDBBA;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid CGELNKMOIOB;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid PLCFDIBNLGG;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid GIDODJHLKGH;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid HHLCFOOKNKF;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid GPOHHIEEBIN;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid KPEMHGINEKA;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid COJNKCMMMGP;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid HBIEPLGOHFJ;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid KEEBPGBNNGJ;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid BGALCEOEDBL;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid JEPOPDLHFAN;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid BAAOHDLPNEA;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid FOJKDCPPACA;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid LBLFFJPFKPE;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid OCDKEFDFFHN;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid GAIJPBGEOFE;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid HAGKHHODJPN;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid FBALLNFBNDB;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid BEMBEPKBDCK;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid MNHKIHDKIDE;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid CBGCJFGIEIN;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid EADPLGBKINF;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid DFKOCEEBOFD;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid PMHBKICBHIO;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid PMGDCHNDKBK;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid BMAOPNMPAGP;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid CLFNNCJEHAO;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid CKIPNKPOIEH;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid DMKLPACJDNJ;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid LLPOFGPALNJ;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid GPCNIAELKKO;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid MNAOHAAGPPI;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid JCAGNCIKPPB;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid OCLDPMCNIFM;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid JDEAMGEMELA;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid FELHACFDBOK;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid KPIFCANEEHF;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid BCPDEPHCPIO;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid KNIIIMBIMEM;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid OMKBHEPONAA;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid EFBCMFGONPP;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid AJNDMHEBMLI;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid FLFEHHEGAAG;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid CHFPBGJAPBJ;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid DDJKNPHPCJP;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid BAALOMBGNPL;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid OAEGJOGGAFK;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid CENGJOHJHOL;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid GMIDGCDDBJA;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid HPFFJIMKPMK;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid PEIMKOLHBOJ;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid DHFIOAOLAMK;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid FDJODCGBANK;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid KCBHDGECFIP;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid ACGGFAOFJPA;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid DNCLKOCOJJA;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid LEKENLGGCFP;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid LIPKNMFCPPD;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid OFOFDENJCOJ;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid BIMHLJEDIKF;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid NMCIJEIBFHK;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid AACANBDDIBK;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid DPHGPCAKJHJ;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid AGCBAPIMFLO;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid OLFKIEGCHIG;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid EBNEIEHCBKO;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid CCIDBHAMKPI;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid IOIGGDKJDFM;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid GLKOAFKHANJ;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid PFOGHIACHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid DNFAGHEPECJ;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid DJEBEBHEFFH;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid MMMPJIINFAI;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid NLPFDFIIOBO;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid HFNJCEHMKIG;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid JDCMABEAPOA;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid HICNLHDBDCO;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid DOMFJLNNIII;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid PLKGPKLBBGA;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid KKAPLIEGJJK;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid KFMJGDCMGOH;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid DNHIJHJFOED;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid HJNKPCPMGFH;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid ICONBJCBEKP;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly Guid BHHJDBMKHCJ;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public static readonly Guid PFJBJAJHCGN;

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly Guid PGGOFEPPPCK;

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public static readonly Guid PFCKECNPAMF;

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public static readonly Guid JHPGIGMMAPK;

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public static readonly Guid CANDJIJFBIK;

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private static readonly Dictionary<Guid, MJNJDMKMNNI> AKIINNJGDLD;

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly Dictionary<MJNJDMKMNNI, Guid> ANJGHGGHBMG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, MJNJDMKMNNI> FCIKDDKPHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83BA890", Offset = "0x83B8E90", VA = "0x1883BA890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<MJNJDMKMNNI, Guid> KCPHNDPEPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83BA8F0", Offset = "0x83B8EF0", VA = "0x1883BA8F0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KHHLIFLLFOA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x83C9200", Offset = "0x83C7800", VA = "0x1883C9200")]
	public static bool MLPMHDPLGND(BMGFIMPJMBB HPCEJDCIOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x83C8DE0", Offset = "0x83C73E0", VA = "0x1883C8DE0")]
	private static bool MLPMHDPLGND(CMAGLMFPMPA EBEOEHAALNF, BMGFIMPJMBB HPCEJDCIOLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ELMAGCDCCDA
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(ILMNJFOIIJN DAJAOHIJHHL, [Out] Dictionary<int, int> NCFBDCHMFAD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(JOBIMPNHPOH IHIDHKKIOGM, NMNENPMOANB OHPMDNPPHLN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LIHPJOPGKKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly EDGCNFKLFEP PKNLIOHGDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public readonly IEnumerable<PDJBJEFMPKL> FHOAMCDCOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public readonly IReadOnlyList<PDJBJEFMPKL> DIODJJLACEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public readonly AEOJKNGHIFP<CHKBMGKDOKI> OEIEOHGMNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly IReadOnlyList<CHNICDNFJMP<GCCEHKIFAID>> IDCKKAOJAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly GPMADDDPEHC JLCMCPIINLK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EKBMLBLHPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83C9230", Offset = "0x83C7830", VA = "0x1883C9230")]
	public LIHPJOPGKKA(EDGCNFKLFEP JIFMDBMKDHN, IEnumerable<PDJBJEFMPKL> HHLHDOFBMIP, IReadOnlyList<PDJBJEFMPKL> FLMAGJJNAPP, AEOJKNGHIFP<CHKBMGKDOKI> ANDMKLHNLNC, IReadOnlyList<CHNICDNFJMP<GCCEHKIFAID>> BIABMKOMPOP, GPMADDDPEHC EEKLJFJODEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NMJFCCHCKCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly EDGCNFKLFEP PKNLIOHGDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly IReadOnlyList<PDJBJEFMPKL> BCKEGHEIJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly AEOJKNGHIFP<CHKBMGKDOKI> OEIEOHGMNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly IReadOnlyList<CHNICDNFJMP<GCCEHKIFAID>> IDCKKAOJAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly ByteString FMOMJDHLEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public readonly GPMADDDPEHC JLCMCPIINLK;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x83C9520", Offset = "0x83C7B20", VA = "0x1883C9520")]
	public NMJFCCHCKCB(EDGCNFKLFEP JIFMDBMKDHN, AEOJKNGHIFP<CHKBMGKDOKI> ANDMKLHNLNC, IReadOnlyList<CHNICDNFJMP<GCCEHKIFAID>> BIABMKOMPOP, ByteString FONIPLDANBE, IReadOnlyList<PDJBJEFMPKL> ONONAJOEHFF, GPMADDDPEHC EEKLJFJODEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OGHMGIJABDC : DCALFBJILMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public readonly Guid ENNOLGDIMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly Dictionary<Guid, Guid> GKLIJOFCGJM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4FA7FC0", Offset = "0x4FA65C0", VA = "0x184FA7FC0")]
	private OGHMGIJABDC(Guid OMBKPIMBDFC, Dictionary<Guid, Guid> GKLIJOFCGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x83C9680", Offset = "0x83C7C80", VA = "0x1883C9680")]
	public static OGHMGIJABDC BPFPEFLIIPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x83C9E30", Offset = "0x83C8430", VA = "0x1883C9E30")]
	private static Dictionary<Guid, Guid> MANELHEIPHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83C9B20", Offset = "0x83C8120", VA = "0x1883C9B20")]
	public static OGHMGIJABDC HAFPAIIGGNH(IReadOnlyDictionary<Guid, Guid> JHGKHIGHBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x83C9830", Offset = "0x83C7E30", VA = "0x1883C9830")]
	public static OGHMGIJABDC GOFKPNLLAAM(IEnumerable<KeyValuePair<Guid, Guid>> JHGKHIGHBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x83C9710", Offset = "0x83C7D10", VA = "0x1883C9710")]
	public Dictionary<Guid, Guid> DINGEOECMOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
	public Dictionary<Guid, Guid> GPMJAEDDDFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83C9DB0", Offset = "0x83C83B0", VA = "0x1883C9DB0")]
	public void KMLBEHGKDFG(Guid JHGKHIGHBBL, Guid BDHPLBBJNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83C9B30", Offset = "0x83C8130", VA = "0x1883C9B30")]
	public void HHIDHFBKEEF(IReadOnlyDictionary<Guid, Guid> IKCKGGEANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83C9EE0", Offset = "0x83C84E0", VA = "0x1883C9EE0")]
	public Guid ODDPLPACKBH([In] Guid JHGKHIGHBBL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83C9790", Offset = "0x83C7D90", VA = "0x1883C9790")]
	public Guid GKGEBEFJHKP([In] Guid JHGKHIGHBBL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83C9610", Offset = "0x83C7C10", VA = "0x1883C9610")]
	public bool PDBDANDGHKD([In] Guid JHGKHIGHBBL, [Out] Guid BDHPLBBJNMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83C9610", Offset = "0x83C7C10", VA = "0x1883C9610", Slot = "4")]
	private bool ADHCCDIHLJK([In] Guid JHGKHIGHBBL, [Out] Guid BDHPLBBJNMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KCLAHIEJGBH
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLJBEPGJKFF(Guid CLPJLOJHBDJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLHOELIIODB(Guid CLPJLOJHBDJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FLFFJLCHMNJ
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
public abstract class AHNLOKLIPOM : KCLAHIEJGBH
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NINAPDDLOOI : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public NINAPDDLOOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83C9370", Offset = "0x83C7970", VA = "0x1883C9370", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83C94D0", Offset = "0x83C7AD0", VA = "0x1883C94D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83C9430", Offset = "0x83C7A30", VA = "0x1883C9430", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83C9430", Offset = "0x83C7A30", VA = "0x1883C9430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IGCAJPHHFHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public AHNLOKLIPOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private IEnumerator<string> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private Dictionary<string, HashSet<Guid>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private string <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter<List<Guid>?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83C8670", Offset = "0x83C6C70", VA = "0x1883C8670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83C8D80", Offset = "0x83C7380", VA = "0x1883C8D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private Dictionary<string, HashSet<Guid>>? JOLKPOMCMDN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> HOEELJGOFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83BA280", Offset = "0x83B8880", VA = "0x1883BA280")]
		[IteratorStateMachine(typeof(NINAPDDLOOI))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? JDIDIGBAAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool GKPHIAPMMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool JLMAEBFHGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> OHOHEHBIBBK(string DOCNOHALANK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x83BA2E0", Offset = "0x83B88E0", VA = "0x1883BA2E0")]
	[AsyncStateMachine(typeof(IGCAJPHHFHO))]
	public Task GFCFHFCNPFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1316140", Offset = "0x1314740", VA = "0x181316140")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83BA550", Offset = "0x83B8B50", VA = "0x1883BA550", Slot = "4")]
	public bool OLJBEPGJKFF(Guid CLPJLOJHBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83BA3C0", Offset = "0x83B89C0", VA = "0x1883BA3C0", Slot = "5")]
	public bool NLHOELIIODB(Guid CLPJLOJHBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83BA490", Offset = "0x83B8A90", VA = "0x1883BA490")]
	private bool OJINOPKKGNG(string FKGHONCDCGG, Guid CLPJLOJHBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected AHNLOKLIPOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class FHCLCGFCGNF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class GAOFKFLGDCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public EDGCNFKLFEP staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GAOFKFLGDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83D0DC0", Offset = "0x83CF3C0", VA = "0x1883D0DC0")]
		internal AEOJKNGHIFP<ELEKBLKBIPD> MOGONLOCPAL((AEOJKNGHIFP<CHKBMGKDOKI> GraphId, AEOJKNGHIFP<GCCEHKIFAID> NodeId) i)
		{
			return default(AEOJKNGHIFP<ELEKBLKBIPD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private const int ELEDLEPGOMK = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private readonly Dictionary<AEOJKNGHIFP<ELEKBLKBIPD>, IDOKPIFOEMP> DJOGDIBECAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private long OHPDKAECIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private long EAGKOLOHBLG;

	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private static readonly AOLHCLMMPFP<ELEKBLKBIPD, int?> LBOGBHJBOOG;

	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private static readonly long JAKKFDHBOKB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long JENBGAOGBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83BAA70", Offset = "0x83B9070", VA = "0x1883BAA70")]
	public static FHCLCGFCGNF KHMGLEHJKGJ(EDGCNFKLFEP GHGNBGMHFBL, CHNICDNFJMP<CHKBMGKDOKI> GDKEFONKKGM, [Optional] FHCLCGFCGNF PPPEDDMIEGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83BB110", Offset = "0x83B9710", VA = "0x1883BB110")]
	public static (long, long) OIHGDLKICAH(EDGCNFKLFEP GHGNBGMHFBL, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<GCCEHKIFAID> BHKHNPBBPIB)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83BAFE0", Offset = "0x83B95E0", VA = "0x1883BAFE0")]
	public static long MCBLHDFNCIC([In] ReadOnlySpan<AEOJKNGHIFP<ELEKBLKBIPD>> KEAFBEHFKDB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83BA950", Offset = "0x83B8F50", VA = "0x1883BA950")]
	private static long EBGOKPKILFC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83C85E0", Offset = "0x83C6BE0", VA = "0x1883C85E0")]
	public FHCLCGFCGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IDOKPIFOEMP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long JPEGFPNBPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F3D410", Offset = "0x7F3BA10", VA = "0x187F3D410")]
	public IDOKPIFOEMP(long FEEKNNBMJMM, long CCCGCMPKPCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IMFHBLBLGGE
{
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public static readonly HashSet<MJNJDMKMNNI> JNAOOMDHFBF;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KDJCEJBIOEA
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BKPFJBBJMDP : IEnumerable<PDJBJEFMPKL>, IEnumerable, IEnumerator<PDJBJEFMPKL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private PDJBJEFMPKL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private PAHCIICKGDL spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public PAHCIICKGDL <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private HIABHCBFFBG spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public HIABHCBFFBG <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private PDJBJEFMPKL System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public BKPFJBBJMDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83CA6D0", Offset = "0x83C8CD0", VA = "0x1883CA6D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x83CA950", Offset = "0x83C8F50", VA = "0x1883CA950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x83CA7E0", Offset = "0x83C8DE0", VA = "0x1883CA7E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PDJBJEFMPKL> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83CA7E0", Offset = "0x83C8DE0", VA = "0x1883CA7E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83D5B90", Offset = "0x83D4190", VA = "0x1883D5B90")]
	public static PAHCIICKGDL OGEDLAGCAAE([In] NMJFCCHCKCB MDONKBDJHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83D5D10", Offset = "0x83D4310", VA = "0x1883D5D10")]
	public static PAHCIICKGDL OGEDLAGCAAE([In] LIHPJOPGKKA MDONKBDJHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83D3010", Offset = "0x83D1610", VA = "0x1883D3010")]
	private static HashSet<CHNICDNFJMP<CAELDLKDOGC>> ADLMLNFAAHD(IReadOnlyList<PDJBJEFMPKL> FCIJCONDEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83D5530", Offset = "0x83D3B30", VA = "0x1883D5530")]
	private static void JNLEKOKFDBP(PAHCIICKGDL PMOACBFEHHP, [In] LIHPJOPGKKA NHILCPNFOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x83D3960", Offset = "0x83D1F60", VA = "0x1883D3960")]
	public static PKAAAAMEMEI<OGHMGIJABDC, PMEGBFMDCKG> DCAPEPIGLEH(PAHCIICKGDL PMOACBFEHHP, HIABHCBFFBG FDHGLOJBNEB, OGHMGIJABDC? ICIBEHKIFGK, bool HODLHFOBLDF)
	{
		return default(PKAAAAMEMEI<OGHMGIJABDC, PMEGBFMDCKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x83D4EB0", Offset = "0x83D34B0", VA = "0x1883D4EB0")]
	[IteratorStateMachine(typeof(BKPFJBBJMDP))]
	private static IEnumerable<PDJBJEFMPKL> DMHBKDPNLDO(PAHCIICKGDL PMOACBFEHHP, HIABHCBFFBG FDHGLOJBNEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x83D3440", Offset = "0x83D1A40", VA = "0x1883D3440")]
	private static void AMKEDOLPKKB(PAHCIICKGDL PMOACBFEHHP, HIABHCBFFBG FDHGLOJBNEB, IReadOnlyCollection<ByteString>? FEFPMEMNODC, IReadOnlyCollection<ByteString>? GALOBEJIKFD, IReadOnlyCollection<ByteString>? KGNPCPHJBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x83D2970", Offset = "0x83D0F70", VA = "0x1883D2970")]
	private static bool ABLOODFHJNK(PAHCIICKGDL PMOACBFEHHP, JOBIMPNHPOH IHIDHKKIOGM, HIABHCBFFBG FDHGLOJBNEB, [Out][NotNullWhen(false)] string? GJJJIJGCEEO, [Out] Dictionary<int, int> NCFBDCHMFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x83D4FC0", Offset = "0x83D35C0", VA = "0x1883D4FC0")]
	private static Dictionary<Guid, CMAGLMFPMPA> GAMNAKHOHPH(PAHCIICKGDL PMOACBFEHHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x83D33B0", Offset = "0x83D19B0", VA = "0x1883D33B0")]
	private static void AELKANMGEFL(bool LHCGHJFPHLP, PDJBJEFMPKL JIAPGANKIOL, OGHMGIJABDC EOCMAHGKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x83D52A0", Offset = "0x83D38A0", VA = "0x1883D52A0")]
	private static void JMNKKAPGMJD(PDJBJEFMPKL JIAPGANKIOL, Guid DEMDENAPFGM, FIIOGMHIPJF? JLOCFFOGMDP, Dictionary<Guid, CMAGLMFPMPA> ALNIGMAPIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x83D34B0", Offset = "0x83D1AB0", VA = "0x1883D34B0")]
	private static void BAMODHFCDBB(IEnumerable<PDJBJEFMPKL> NJBGMIGDDLE, IReadOnlyCollection<ByteString> FEFPMEMNODC, IReadOnlyCollection<ByteString> GALOBEJIKFD, IReadOnlyCollection<ByteString> KGNPCPHJBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HIABHCBFFBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public bool LHCGHJFPHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public GPMADDDPEHC EEKLJFJODEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public FIIOGMHIPJF? JLOCFFOGMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public FIIOGMHIPJF? AJNLNAIJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public EDGCNFKLFEP PONBKOFGJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public FLFFJLCHMNJ PHCFFFHAHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public ELMAGCDCCDA MIHHHLBOALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public CHNICDNFJMP<CHKBMGKDOKI> CKGEPKNAJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public EGBHLOBNMLP IPGFEIIPKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public List<PDJBJEFMPKL> FBMGKDFMOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public DDNEFPADLOB MNJNEMLJNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public HPBKGKLMOJA EBCIBCOLHNK;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FIIOGMHIPJF
{
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private const float LOAKBCGJBFA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public Vector3 AANGPKCDGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	public Quaternion NEOIPHFFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public float ILFCOODFNFF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 IPEIJGLMPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83CDE30", Offset = "0x83CC430", VA = "0x1883CDE30")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS CFEDEAIFGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x83CE3E0", Offset = "0x83CC9E0", VA = "0x1883CE3E0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x16696E0", Offset = "0x1667CE0", VA = "0x1816696E0")]
	public FIIOGMHIPJF(Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float ILFCOODFNFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x83CE4B0", Offset = "0x83CCAB0", VA = "0x1883CE4B0")]
	public FIIOGMHIPJF(UniformTRS CNCPPJCKOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x83CE160", Offset = "0x83CC760", VA = "0x1883CE160")]
	public static FIIOGMHIPJF PBMBLIPJJFM(FIIOGMHIPJF IGDHFGFJBMG, FIIOGMHIPJF HKLBHIFCPMD)
	{
		return default(FIIOGMHIPJF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x83CDC40", Offset = "0x83CC240", VA = "0x1883CDC40")]
	public static FIIOGMHIPJF HPNBGLLBBBG((Vector3, Quaternion, float) DAJAOHIJHHL)
	{
		return default(FIIOGMHIPJF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x83CDC60", Offset = "0x83CC260", VA = "0x1883CDC60")]
	public static FIIOGMHIPJF HPNBGLLBBBG(Matrix4x4 BGNPBKDNJEE)
	{
		return default(FIIOGMHIPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x83CE420", Offset = "0x83CCA20", VA = "0x1883CE420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x83CDF40", Offset = "0x83CC540", VA = "0x1883CDF40")]
	public FIIOGMHIPJF OHFGDDFMGJD(Matrix4x4 JAHKFPBBGHB)
	{
		return default(FIIOGMHIPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x83CDDC0", Offset = "0x83CC3C0", VA = "0x1883CDDC0")]
	public static FIIOGMHIPJF LKIAJJNMCNC(Vector3 AANGPKCDGHO)
	{
		return default(FIIOGMHIPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x83CDBB0", Offset = "0x83CC1B0", VA = "0x1883CDBB0")]
	public readonly OACCLMAOCGE FOHODKDEFMH()
	{
		return default(OACCLMAOCGE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum LKMJIMFKIBP
{
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct PMEGBFMDCKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public readonly ICNNKIOLDHJ MBAKIHJHDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private readonly LCPFPNABOAN MEPFPALMAPE;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1953810", Offset = "0x1951E10", VA = "0x181953810")]
	private PMEGBFMDCKG(ICNNKIOLDHJ DEKFAJBJCEK, LCPFPNABOAN BNOPEBGOJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x83DB130", Offset = "0x83D9730", VA = "0x1883DB130")]
	public NMLPOPGBFLN ECHBIGOJNNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x83DAF10", Offset = "0x83D9510", VA = "0x1883DAF10")]
	public static PKAAAAMEMEI<OGHMGIJABDC, PMEGBFMDCKG> BPFPEFLIIPC(NDBHFDEFONM<GDCHOBJFCMN> BNOPEBGOJPN)
	{
		return default(PKAAAAMEMEI<OGHMGIJABDC, PMEGBFMDCKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x83DAFC0", Offset = "0x83D95C0", VA = "0x1883DAFC0")]
	public static PKAAAAMEMEI<OGHMGIJABDC, PMEGBFMDCKG> BPFPEFLIIPC(NMLPOPGBFLN BNOPEBGOJPN)
	{
		return default(PKAAAAMEMEI<OGHMGIJABDC, PMEGBFMDCKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x83DB070", Offset = "0x83D9670", VA = "0x1883DB070")]
	public static PKAAAAMEMEI<OGHMGIJABDC, PMEGBFMDCKG> BPFPEFLIIPC(string FMDPJFPEJKB)
	{
		return default(PKAAAAMEMEI<OGHMGIJABDC, PMEGBFMDCKG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum ICNNKIOLDHJ
{
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FJPAEILFJEA : IDisposable, PPGDCNAHADK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private NativeList<ONPFMKLHPJO> GNFMGGDDAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private float KCOECIJKLKF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DFBCNJDDJPE BAICMBFMLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(DFBCNJDDJPE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KHGMMHBOEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7270960", Offset = "0x726EF60", VA = "0x187270960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MGCFNAFOFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7270970", Offset = "0x726EF70", VA = "0x187270970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<EGPPJHAGIBF> MIKJKGPBHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int EMNJLKJLEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83CE580", Offset = "0x83CCB80", VA = "0x1883CE580", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float OPGCEMLJLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83CFAC0", Offset = "0x83CE0C0", VA = "0x1883CFAC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x83D0D30", Offset = "0x83CF330", VA = "0x1883D0D30")]
	public FJPAEILFJEA(DFBCNJDDJPE OAKCIAMNOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x83CE710", Offset = "0x83CCD10", VA = "0x1883CE710", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x83CFC00", Offset = "0x83CE200", VA = "0x1883CFC00")]
	public Vector3 KDAIMKIBOJJ(int IEODBGLFEOD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x83CE860", Offset = "0x83CCE60", VA = "0x1883CE860", Slot = "6")]
	public Quaternion EFMBPFAPJAK(int IEODBGLFEOD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x83CE990", Offset = "0x83CCF90", VA = "0x1883CE990", Slot = "5")]
	public Vector3 EKPAOGNKNHD(int IEODBGLFEOD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x83CE800", Offset = "0x83CCE00", VA = "0x1883CE800", Slot = "7")]
	public float EBCCAMPBHJE(int IEODBGLFEOD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x83D0450", Offset = "0x83CEA50", VA = "0x1883D0450")]
	public void PHDLHFGKKEE(Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float OFHHJJPMNHK, bool DPJEPBOGCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x83D00D0", Offset = "0x83CE6D0", VA = "0x1883D00D0")]
	private bool LBHGJBEOMOI(int FPNKCDLMAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x83D02F0", Offset = "0x83CE8F0", VA = "0x1883D02F0")]
	public void MPHABKHJCIE(Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float OFHHJJPMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x83CE770", Offset = "0x83CCD70", VA = "0x1883CE770")]
	public void EAIHLCAJNHL(int FPNKCDLMAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x83D0130", Offset = "0x83CE730", VA = "0x1883D0130")]
	public void MFMBFIABLAH(int FPNKCDLMAEO, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float OFHHJJPMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x83CEA30", Offset = "0x83CD030", VA = "0x1883CEA30")]
	public void FBFCFFEAHDN(int FPNKCDLMAEO, float3 AANGPKCDGHO, quaternion NEOIPHFFLHF, float OFHHJJPMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x83CE5C0", Offset = "0x83CCBC0", VA = "0x1883CE5C0")]
	public void DPICJBBJMCC(int FPNKCDLMAEO, Vector3 AANGPKCDGHO, float OFHHJJPMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x83CF3F0", Offset = "0x83CD9F0", VA = "0x1883CF3F0")]
	public void GNAMHPJKHGI(int FPNKCDLMAEO, Vector3 NNMAALGIDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x83CEBE0", Offset = "0x83CD1E0", VA = "0x1883CEBE0")]
	public static Quaternion FLFLPAIOBHM(Quaternion LNFJGJBDGFN, int FPNKCDLMAEO, float BOHPPIPAKEN, PPGDCNAHADK OKHELEAHJMF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x83CF620", Offset = "0x83CDC20", VA = "0x1883CF620")]
	public Bounds GPFONDIBLDM(Transform JAHKFPBBGHB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x83D0280", Offset = "0x83CE880", VA = "0x1883D0280", Slot = "10")]
	public virtual void MNABNBPPGEE(bool IBHLDCAAALB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x83CF550", Offset = "0x83CDB50", VA = "0x1883CF550")]
	public NativeList<ONPFMKLHPJO> GNLEOACNOOC(float GCKDOKKMKKC = 1f)
	{
		return default(NativeList<ONPFMKLHPJO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct EGPPJHAGIBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public float3 IIKJNDDFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public float ELLGGJLJFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public quaternion EAPHMHOIACJ;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x83CD680", Offset = "0x83CBC80", VA = "0x1883CD680")]
	public EGPPJHAGIBF(Vector3 DPLNHDFCMOI, Quaternion LNFJGJBDGFN, float OFHHJJPMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x83CD2D0", Offset = "0x83CB8D0", VA = "0x1883CD2D0")]
	public Quaternion BLDMMEFJDMB(Vector3 FANJPCNJGDA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x83CD390", Offset = "0x83CB990", VA = "0x1883CD390")]
	public EGPPJHAGIBF GIIAKBNOEON(Vector3 JJDNNNIPGOJ, Vector3 JODDJEICCNB, Vector3 BHPBCJHFLBE)
	{
		return default(EGPPJHAGIBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x83CD130", Offset = "0x83CB730", VA = "0x1883CD130")]
	public MNOFIJAGPFH AMGMDIJODDK(Vector3 FANJPCNJGDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class IBFHOFEIALH : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x83D1C50", Offset = "0x83D0250", VA = "0x1883D1C50", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x83D1670", Offset = "0x83CFC70", VA = "0x1883D1670")]
	private void BBHGHKFLGJO(Dictionary<Guid, Guid> MOENIGJDCHB, CNCNGJKABLA JIJOLPKDGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x83D1610", Offset = "0x83CFC10", VA = "0x1883D1610")]
	private void BBHGHKFLGJO(Dictionary<Guid, Guid> MOENIGJDCHB, BMJGCEAFNNI JLMMGPMEPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x83D1390", Offset = "0x83CF990", VA = "0x1883D1390")]
	private void BBHGHKFLGJO(Dictionary<Guid, Guid> MOENIGJDCHB, MMBBOEMPBPJ PEIMIIPDHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IBFHOFEIALH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class EMHDEDHANBP : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x83CD700", Offset = "0x83CBD00", VA = "0x1883CD700", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public EMHDEDHANBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GLLLLLLJEGE : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x83D1230", Offset = "0x83CF830", VA = "0x1883D1230", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GLLLLLLJEGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IGBPLJHDIPP : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x83D1CD0", Offset = "0x83D02D0", VA = "0x1883D1CD0", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IGBPLJHDIPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OFDNCIBDLIJ : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x83DAB40", Offset = "0x83D9140", VA = "0x1883DAB40", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OFDNCIBDLIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BBJNNHMBAHJ : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x83CA590", Offset = "0x83C8B90", VA = "0x1883CA590", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BBJNNHMBAHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class BNIBCOGBIHH : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x83CA9A0", Offset = "0x83C8FA0", VA = "0x1883CA9A0", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BNIBCOGBIHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class NNOKOLBDPMD : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x83DAA50", Offset = "0x83D9050", VA = "0x1883DAA50", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NNOKOLBDPMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class AFOJPHENHEI : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x83CA1F0", Offset = "0x83C87F0", VA = "0x1883CA1F0", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public AFOJPHENHEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class ABKEBBHIABG : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x83CA030", Offset = "0x83C8630", VA = "0x1883CA030", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public ABKEBBHIABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class OGFLJFCBJBP : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x83DAD60", Offset = "0x83D9360", VA = "0x1883DAD60", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OGFLJFCBJBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class DDIDAJDNDOB : DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public static readonly PNNJGAMLIMC JAFPAHMNNFP;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x83CAB40", Offset = "0x83C9140", VA = "0x1883CAB40", Slot = "4")]
	public void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DDIDAJDNDOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct BMGFIMPJMBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	public JOBIMPNHPOH FOBPLBPGNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	public GFDCAABEMHM CGLLGLABLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	public Dictionary<int, int> DHKJAHHBBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	public Dictionary<Guid, Guid> MEMEGMOHGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	public HPBKGKLMOJA EBCIBCOLHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	public bool HODLHFOBLDF;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DDJDCOKNCEL
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEEHCLHNADH(PKONGFPKOEF KOFJLLIJAJL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DFGNJLBAPEA
{
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private static readonly DDJDCOKNCEL[] OOCJLOHBPCK;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x83CAC70", Offset = "0x83C9270", VA = "0x1883CAC70")]
	public static void GGMMGCFOOBN(PDJBJEFMPKL DAJAOHIJHHL, OGHMGIJABDC NCMBIPGPKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x83CAEF0", Offset = "0x83C94F0", VA = "0x1883CAEF0")]
	public static void GJNDHAEPDKC(PDJBJEFMPKL? DAJAOHIJHHL, OGHMGIJABDC CFNBIAEKGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x83CB180", Offset = "0x83C9780", VA = "0x1883CB180")]
	public static void MEPMDMEBBCN(PDJBJEFMPKL? DAJAOHIJHHL, OGHMGIJABDC EOCMAHGKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x83CB3F0", Offset = "0x83C99F0", VA = "0x1883CB3F0")]
	public static void MLPMHDPLGND(PKONGFPKOEF KOFJLLIJAJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct PKONGFPKOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	public JOBIMPNHPOH OIBFPLAJLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	public PDJBJEFMPKL JIAPGANKIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	public Dictionary<int, int> DHKJAHHBBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	public Dictionary<Guid, Guid> MEMEGMOHGDK;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x83DAE60", Offset = "0x83D9460", VA = "0x1883DAE60")]
	public Guid CIEJJADOBGI(Guid CLPJLOJHBDJ)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HPBKGKLMOJA
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int MMPGCDHOELA, [Out] Guid CHBOPDMEDIO);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KKCBHAICKCE
{
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private static readonly HashSet<Guid> CJJGFFOPKNE;

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private static readonly HashSet<Guid> DMCEIGIABBJ;

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private static readonly HashSet<Guid> IMLHPJNPCNB;

	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private static readonly ProfilerMarker HBOAJLPAKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private readonly HashSet<string> NMOOBAEEAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private readonly Dictionary<long, int> NLGNHFAIHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private readonly HashSet<Guid> PDDLGFILEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private readonly HashSet<Guid> NEGBMKGHJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private readonly HashSet<Guid> BCGDJBCJJKC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> BIDPKKHIFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyCollection<Guid> JFPDAAEIPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<Guid> PIFNFBEGMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IReadOnlyDictionary<long, int> NOGBHJHFJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x83D7E00", Offset = "0x83D6400", VA = "0x1883D7E00")]
	public static void JOILILMLAMH(PAHCIICKGDL GHDMMDMGGFA, GCHIIFOBGBB PKBCFLKKFBL, OGHMGIJABDC MCDCEFOJHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x83D6AC0", Offset = "0x83D50C0", VA = "0x1883D6AC0")]
	public static KKCBHAICKCE HDIGMAJMMMO(CIMPCCNCPLH CPLJEEOPGOB, GCHIIFOBGBB? PKBCFLKKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x83D8A10", Offset = "0x83D7010", VA = "0x1883D8A10")]
	public static KKCBHAICKCE OOAMNOIEKGK(PAHCIICKGDL HOKBBKFEKGK, GCHIIFOBGBB? PKBCFLKKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x83D8950", Offset = "0x83D6F50", VA = "0x1883D8950")]
	public static KKCBHAICKCE MOOGDAJFHFG(KBKOGEMONAD OHPMDNPPHLN, EFPMDPFPACL GIPMABPLBDJ, GCHIIFOBGBB? PKBCFLKKFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x83D88C0", Offset = "0x83D6EC0", VA = "0x1883D88C0")]
	public static KKCBHAICKCE KFAFLIIHCNJ(IEnumerable<string> NMOOBAEEAIK, IReadOnlyDictionary<long, int> NFMJCNNACGG, IReadOnlyCollection<Guid> BCGDJBCJJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x83DA8C0", Offset = "0x83D8EC0", VA = "0x1883DA8C0")]
	private KKCBHAICKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x83DA6C0", Offset = "0x83D8CC0", VA = "0x1883DA6C0")]
	private KKCBHAICKCE(IEnumerable<string> NMOOBAEEAIK, IReadOnlyDictionary<long, int> NFMJCNNACGG, IReadOnlyCollection<Guid> BCGDJBCJJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x83D9AF0", Offset = "0x83D80F0", VA = "0x1883D9AF0")]
	private void PJCFIBOICCH(CIMPCCNCPLH CPLJEEOPGOB, GCHIIFOBGBB? PKBCFLKKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x83D9860", Offset = "0x83D7E60", VA = "0x1883D9860")]
	private void PJCFIBOICCH(PAHCIICKGDL HOKBBKFEKGK, GCHIIFOBGBB? PKBCFLKKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x83D64D0", Offset = "0x83D4AD0", VA = "0x1883D64D0")]
	private void FDLFIEEIABA(ByteString? FONIPLDANBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x83D8A90", Offset = "0x83D7090", VA = "0x1883D8A90")]
	private void PJCFIBOICCH(KBKOGEMONAD? PPOKNBNEDHM, GCHIIFOBGBB? PKBCFLKKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x83D9D90", Offset = "0x83D8390", VA = "0x1883D9D90")]
	private void PJCFIBOICCH(EFPMDPFPACL? GIPMABPLBDJ, GCHIIFOBGBB? PKBCFLKKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x83D9E10", Offset = "0x83D8410", VA = "0x1883D9E10")]
	private void PJCFIBOICCH(NOLJICMINOF? PEFCGPKKDHH, GCHIIFOBGBB? PKBCFLKKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x83D5EA0", Offset = "0x83D44A0", VA = "0x1883D5EA0")]
	private static bool BMPIGKLLAIJ(NOLJICMINOF PEFCGPKKDHH, int LPBBFPNDAHA, [Out] string? GNEBJMAOBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x83D6110", Offset = "0x83D4710", VA = "0x1883D6110")]
	private static bool DDMNFCALIJM(NOLJICMINOF PEFCGPKKDHH, int LPBBFPNDAHA, [Out] Guid KKDCDEGMENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x83D87F0", Offset = "0x83D6DF0", VA = "0x1883D87F0")]
	private static void JOILILMLAMH(EFPMDPFPACL? PPOKNBNEDHM, GCHIIFOBGBB PKBCFLKKFBL, OGHMGIJABDC MCDCEFOJHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x83D7520", Offset = "0x83D5B20", VA = "0x1883D7520")]
	private static void JOILILMLAMH(NOLJICMINOF? PEFCGPKKDHH, GCHIIFOBGBB PKBCFLKKFBL, OGHMGIJABDC MCDCEFOJHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x83D6D50", Offset = "0x83D5350", VA = "0x1883D6D50")]
	private static void JOILILMLAMH(KBKOGEMONAD? PPOKNBNEDHM, GCHIIFOBGBB PKBCFLKKFBL, OGHMGIJABDC MCDCEFOJHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x83D77B0", Offset = "0x83D5DB0", VA = "0x1883D77B0")]
	private static void JOILILMLAMH(GEIBGBGFJHP? CFHHNIJODJI, GCHIIFOBGBB PKBCFLKKFBL, OGHMGIJABDC MCDCEFOJHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x83D9FF0", Offset = "0x83D85F0", VA = "0x1883D9FF0")]
	private void PJCFIBOICCH(GEIBGBGFJHP? CFHHNIJODJI, GCHIIFOBGBB? PKBCFLKKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x83D6B40", Offset = "0x83D5140", VA = "0x1883D6B40")]
	private void JKJLFJCFFGC(Guid? CLPJLOJHBDJ, GCHIIFOBGBB? PKBCFLKKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x83D9460", Offset = "0x83D7A60", VA = "0x1883D9460")]
	private void PJCFIBOICCH(PDJBJEFMPKL? JIAPGANKIOL, GCHIIFOBGBB? PKBCFLKKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x83D70D0", Offset = "0x83D56D0", VA = "0x1883D70D0")]
	private static void JOILILMLAMH(PDJBJEFMPKL? JIAPGANKIOL, GCHIIFOBGBB PKBCFLKKFBL, OGHMGIJABDC MCDCEFOJHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x83D60A0", Offset = "0x83D46A0", VA = "0x1883D60A0")]
	private void CCKLCDLPAFF(string? BKHFGNHLAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x83D6400", Offset = "0x83D4A00", VA = "0x1883D6400")]
	private void EEHAKJHMBPO(long CBEPDHCCOGN, Guid KGJPNPGPIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x83D63B0", Offset = "0x83D49B0", VA = "0x1883D63B0")]
	private void EEHAKJHMBPO(EEDGFMFOCPE? AOKEHFHGOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x83D6350", Offset = "0x83D4950", VA = "0x1883D6350")]
	private void EEHAKJHMBPO(FODIMCLNHMH? AOKEHFHGOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct EAKGPMAHEON
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class FEPJCAFGELH : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private readonly IEnumerator<DictionaryEntry> NNLAAMJMCJN;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public DictionaryEntry MDDDJHEJEBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x83CD930", Offset = "0x83CBF30", VA = "0x1883CD930", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object PMMIAHCCEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x83CD9F0", Offset = "0x83CBFF0", VA = "0x1883CD9F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public object FAGODIAEODP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x83CDAA0", Offset = "0x83CC0A0", VA = "0x1883CDAA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public object MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x83CD850", Offset = "0x83CBE50", VA = "0x1883CD850", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
		public FEPJCAFGELH(IEnumerator<DictionaryEntry> NNLAAMJMCJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83CD7B0", Offset = "0x83CBDB0", VA = "0x1883CD7B0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x83CD800", Offset = "0x83CBE00", VA = "0x1883CD800", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class EABDJCEBNMM : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x83CBF00", Offset = "0x83CA500", VA = "0x1883CBF00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public EABDJCEBNMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x83CBDB0", Offset = "0x83CA3B0", VA = "0x1883CBDB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x83CBEB0", Offset = "0x83CA4B0", VA = "0x1883CBEB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
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
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x83DB770", Offset = "0x83D9D70", VA = "0x1883DB770", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object HFLDIIIPBCG]
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x83DB680", Offset = "0x83D9C80", VA = "0x1883DB680", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x83DB860", Offset = "0x83D9E60", VA = "0x1883DB860", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x83DB5C0", Offset = "0x83D9BC0", VA = "0x1883DB5C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x83DB620", Offset = "0x83D9C20", VA = "0x1883DB620", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x83DB800", Offset = "0x83D9E00", VA = "0x1883DB800", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x83DB280", Offset = "0x83D9880", VA = "0x1883DB280", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x83DB2E0", Offset = "0x83D98E0", VA = "0x1883DB2E0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x83DB340", Offset = "0x83D9940", VA = "0x1883DB340", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
		public RoomObjectCounts(Dictionary<int, int> BFEKCCIFFIA, [Optional] Dictionary<int, int> IEBKKBINMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x83DB1A0", Offset = "0x83D97A0", VA = "0x1883DB1A0")]
		[IteratorStateMachine(typeof(EABDJCEBNMM))]
		private IEnumerator<DictionaryEntry> FIDLMHHGDGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x83DB8B0", Offset = "0x83D9EB0", VA = "0x1883DB8B0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x83DB4C0", Offset = "0x83D9AC0", VA = "0x1883DB4C0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x83DB3A0", Offset = "0x83D99A0", VA = "0x1883DB3A0", Slot = "9")]
		void IDictionary.Add(object HFLDIIIPBCG, object FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83DB400", Offset = "0x83D9A00", VA = "0x1883DB400", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x83DB460", Offset = "0x83D9A60", VA = "0x1883DB460", Slot = "8")]
		bool IDictionary.Contains(object HFLDIIIPBCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x83DB560", Offset = "0x83D9B60", VA = "0x1883DB560", Slot = "14")]
		void IDictionary.Remove(object HFLDIIIPBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x83DB220", Offset = "0x83D9820", VA = "0x1883DB220", Slot = "15")]
		void ICollection.CopyTo(Array OHHBFAGELLA, int LEPAEEGOBDO)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class AJGDCFPFOEK : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x83CA540", Offset = "0x83C8B40", VA = "0x1883CA540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public AJGDCFPFOEK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x83CA3B0", Offset = "0x83C89B0", VA = "0x1883CA3B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x83CA4F0", Offset = "0x83C8AF0", VA = "0x1883CA4F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
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
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x83D2680", Offset = "0x83D0C80", VA = "0x1883D2680", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IDictionary.this[object HFLDIIIPBCG]
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x83D2550", Offset = "0x83D0B50", VA = "0x1883D2550", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x83D2730", Offset = "0x83D0D30", VA = "0x1883D2730", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x83D2490", Offset = "0x83D0A90", VA = "0x1883D2490", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x83D24F0", Offset = "0x83D0AF0", VA = "0x1883D24F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x83D26D0", Offset = "0x83D0CD0", VA = "0x1883D26D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x83D2110", Offset = "0x83D0710", VA = "0x1883D2110", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x83D2170", Offset = "0x83D0770", VA = "0x1883D2170", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x83D21D0", Offset = "0x83D07D0", VA = "0x1883D21D0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAD20", Offset = "0x2AD9320", VA = "0x182ADAD20")]
		public Invention(long JIEJOKBHEMF, int FEEKNNBMJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x83D2040", Offset = "0x83D0640", VA = "0x1883D2040")]
		[IteratorStateMachine(typeof(AJGDCFPFOEK))]
		private IEnumerator<DictionaryEntry> FIDLMHHGDGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x83D2780", Offset = "0x83D0D80", VA = "0x1883D2780", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x83D2350", Offset = "0x83D0950", VA = "0x1883D2350", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x83D2230", Offset = "0x83D0830", VA = "0x1883D2230", Slot = "9")]
		void IDictionary.Add(object HFLDIIIPBCG, object FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x83D2290", Offset = "0x83D0890", VA = "0x1883D2290", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x83D22F0", Offset = "0x83D08F0", VA = "0x1883D22F0", Slot = "8")]
		bool IDictionary.Contains(object HFLDIIIPBCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83D2430", Offset = "0x83D0A30", VA = "0x1883D2430", Slot = "14")]
		void IDictionary.Remove(object HFLDIIIPBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x83D20B0", Offset = "0x83D06B0", VA = "0x1883D20B0", Slot = "15")]
		void ICollection.CopyTo(Array OHHBFAGELLA, int LEPAEEGOBDO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> HLFFGOINBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	public readonly IReadOnlyList<Invention> MJCOPFILMEG;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
	public EAKGPMAHEON(IReadOnlyDictionary<Guid, RoomObjectCounts> IMJGEHMCGDC, IReadOnlyList<Invention> FJBOELALBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x83CC720", Offset = "0x83CAD20", VA = "0x1883CC720")]
	public static EAKGPMAHEON HDIGMAJMMMO(CIMPCCNCPLH CPLJEEOPGOB)
	{
		return default(EAKGPMAHEON);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x83CBF50", Offset = "0x83CA550", VA = "0x1883CBF50")]
	[CompilerGenerated]
	internal static int BBJIFCNKABM([In] IReadOnlyDictionary<long, int> NAKFDGFBAEO, long? CBEPDHCCOGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x83CC070", Offset = "0x83CA670", VA = "0x1883CC070")]
	[CompilerGenerated]
	internal static void HBIFOPLBDDO(int FJPCLJDDOIM, [In] KBKOGEMONAD MFPOPAFEABH, [In] Dictionary<long, int> NAKFDGFBAEO, [In] Dictionary<Guid, RoomObjectCounts> IMJGEHMCGDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum CIEJIECFGII
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
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class GCHIIFOBGBB
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class FFDFNJGMLFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public readonly Guid MIGCGALIJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public readonly IReadOnlyList<Guid> JFPDAAEIPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public readonly CIEJIECFGII MBAKIHJHDMG;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x83CDB50", Offset = "0x83CC150", VA = "0x1883CDB50")]
		public FFDFNJGMLFI(Guid MPBELGOHEPD, IReadOnlyList<Guid> BCGDJBCJJKC, CIEJIECFGII DEKFAJBJCEK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly OGHMGIJABDC HHAPOKEFIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private readonly Dictionary<Guid, FFDFNJGMLFI> DIALADKOFEK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public OGHMGIJABDC OGCMNKBLHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x83D0E90", Offset = "0x83CF490", VA = "0x1883D0E90")]
	public void KMLBEHGKDFG(Guid BPKKNMBMCBK, Guid HBFBGHJLOMA, IReadOnlyList<Guid> MJANFPFKEBE, CIEJIECFGII DEKFAJBJCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x83D10A0", Offset = "0x83CF6A0", VA = "0x1883D10A0")]
	public bool MIEFOFCOOJI(Guid HKCDBPEFIAK, [Out] FFDFNJGMLFI LFLHDHAIOLG, [Out] bool AGFOBMBPKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x83D1190", Offset = "0x83CF790", VA = "0x1883D1190")]
	public GCHIIFOBGBB()
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
