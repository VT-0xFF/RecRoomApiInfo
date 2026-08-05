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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7884460", Offset = "0x7882E60", VA = "0x187884460")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MNBGMPLLEAO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> FNADNDCCNCA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> JCOEAFKAAHP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> MIOOIJNAPLI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> ABCEGHILOFH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string CDPKAEFKMKN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string JEKFGPIBPJK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string INBPGCKFAGI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7881090", Offset = "0x787FA90", VA = "0x187881090")]
	public static bool AKFCIELJDOO(Guid JHAGFIHKFHF, int IDNNBHJAGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7881190", Offset = "0x787FB90", VA = "0x187881190")]
	public static bool FODEGLOFNHM(Guid JHAGFIHKFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7880A10", Offset = "0x787F410", VA = "0x187880A10")]
	public static string AIIFMBIKALM(Guid BIGAPECKJPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MOKKKLPGDOK]
public enum INKAHEHKDEH
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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7880980", Offset = "0x787F380", VA = "0x187880980", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NOOODEMBAPL
{
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid BBJGPECBBNF;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid KFEMNJOCNKO;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid JOFFEJGPDDM;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid APBDAEBGLBC;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid BNNFPAJBIPB;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid KOBEKEANFNH;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid PDLIJHCLGFK;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid PJPHDGGDJMD;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid POMJCPEAIFJ;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid CJFNIJCINHG;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid KNNHPDBBFNI;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid CHLCAJJMLIE;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid IIIDDLJLEBE;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid PMDGJOMHMAF;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid MFKMCBAHJMM;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid CPEHNOAFIIN;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid FPBPBHMIPBB;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid GMLJJPAMHMO;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid MFHFHIMDCOH;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid DNAMFJOCDLE;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid JKGMBJJMEBB;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid DCCELNJGMHO;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid LJBLMBBMIEM;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid FBAHPLPJDJG;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid FNEIONEPOBM;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid HAMPHELBLCH;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid FCLAPLMHKEB;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid DAENIHIEPGF;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid GPCPFKBGBME;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid IIFOIEFOGPN;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid GHPDPJPPBEM;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid JCAHNBEHBGA;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid JIPIGPKAIBO;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid CDABEOJMFOM;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid NPHGNPIJBFF;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid IODIHLNLLCM;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid ALHICADCABM;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid JJAMKKIFGIA;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid NELBOHGKCPC;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid JMFIHKLCKFK;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid JGCAENMOBNE;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid BAJGKGAMLCJ;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid LKIOCFKJCMA;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid MINMBNMLFGF;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid HEIMKGLEHBO;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid LOCHABMHBBP;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid LFBNFKPJGMF;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid JPEOMECGIKN;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid DIJEMGJFGHE;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid JENEBPKNIJL;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid CIOGBCLCPEO;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid GGPEFLFBCIM;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid APNNCDMPLOB;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid OCGOLEPBLFF;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid LBPMJKBLAGE;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid JNNOIGBEIDP;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid KNBCEKGDJGN;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid KAHJPBEJKFG;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid PDJOAEGEGIH;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid BMCEDENGPGE;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid FDPAGAJMNKL;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid EMBCBIADGHC;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid NBCCMPJHINP;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid ECJLJHLNHDL;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid NELIGAEDCDI;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid DLDCAOCOJDJ;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid OJCLKPPINEK;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid LHMEHJJCNBN;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid EFEDLBAEDOB;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid NJAOHIMJLIF;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid EAHFNMCABFA;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid FKGIFJIKJJK;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid HCGMOFOMAJP;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid OHLDFCGIPPI;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid HCMNJAJOIKA;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid IBNFPLIFBEB;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid AAPJGDAHKMJ;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid GIEFHDJFBCB;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid JIIKNFCHPOC;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid KPIBJKMIJCN;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid DMEIPMIMNHK;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid BAMBOMCIMEG;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid IKDEIAKJAIC;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid NFHLGPHFBOB;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid EOPGHGHAPPE;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid OHOPDOFEOEI;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid NMENGGOHEHE;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid LFNJMEDFGFO;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid CGEIDGDDFFC;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid KFFECEEAFAG;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid LIIGPGOAKKD;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid OIMMMLGMLNL;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid KANCDNCDMIJ;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid EAJMJGOHPII;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid DAIFCHMBNOH;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid MKPDBJPOCFN;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid CPLJBNBBAJN;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid BBLOHIIBNAM;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid GBJFEDKLKEF;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid HNIPEKJNHKP;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid LFEBEIJGJOF;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid DAILJGDABKD;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid AALGOJMCIIO;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid PLPFHBCMMBG;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FPDMKKEBDNE;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid NOFAJPBNBEC;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid KOALKAJDMCN;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid GIPEJIBBCKD;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid MKACDOOFODO;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid EEKLAJEMDII;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid HAHECMNAAAM;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid KIBHFEPJJFA;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid EJJENNPMDNP;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid IDHLLEFBPHO;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid PLDAOEJJGNJ;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid KMDJDFEMEEA;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid BCDEKILNNHE;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid EHBLPLMEIHP;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid PGOBMIGPEEJ;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid KFBANPCOPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid PPGCBKHACIM;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid FCEGKNCDDOD;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid PAKGAILFFKI;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid JEJNJCHNMGE;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid PAKOHMOALFA;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid KIPMOCMBKDI;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid GOKCHBACBCJ;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid PNOLCEGLGIE;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid EDIEEOMEFNO;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid IFFHMMNPDJH;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid KKAONBGCHNB;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid AAFFEGMINDI;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid LGMPNEFPNGC;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid PPKALDNNMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid FIMKMJMFHME;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid KGHECCFOIMC;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid KODLBKLJMKG;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid JAMOABDKNMB;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid NDMEPGGOFHO;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid COPFPHEBCMK;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid PLMMHPILEGD;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid MLAOBKFGNEG;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid GEFHFJDIDAL;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid FNLHPIKHIAI;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid IDPCHIAIBJE;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid AHNBJKPKNLD;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid JCNAABDJLEO;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid BIMKBDJFAJO;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid ACNDJAEMJGO;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid FADHCHEOJIM;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid HHBHLBOOPFH;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid IGJHLMOLFLD;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid CHOHBINPJGM;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid IJGNDKILNLP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid ACOCBMHNOOI;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid LACDPGIJBPN;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid PBEDFBBPCKE;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid JBJKBLOHNAC;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid PJKCADIHLMA;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid BBIOMFCDIAB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid EKMLIKCAEKH;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid FBKFPDPENFA;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid EOLKJPCFOHK;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid JOPJKILBJHD;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid BNFDCDKDFAL;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid LDHJCNABCCA;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid AIMBMAMCGNB;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid IGIFEBNFDKF;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid MNNGKBAFDLM;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid MCPKAKEJGLL;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid HAELHEDIPLL;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid NOLHOMAEKLL;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid IHIGHOKMAGC;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid BJPBDMONGAA;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid HIGFGGOCGMM;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid EJFLGFPANAK;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid DGMFBDDMNEL;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid LNJFGEANPDM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid KKDPCCLLHBK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid OMIKFMCHLPF;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid MKLKPEADFBA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid BKNOGDJOJHO;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid OLGLGBCCJDL;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid JCHLMMHPJLO;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid HDAFGKGPHAO;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid OBIMIJBNNDG;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid JNMLACBKIKD;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid CGHBGCMJLDB;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid CFBMCEGBLOC;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid LIICKKIBMMP;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid FDPMAHNBBKI;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid IOGMGBOCHMA;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid CJDMONEMBEI;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid HNCAEGDDEHG;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid LKFCBMMLOMM;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid NMFOFOAJPOK;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid JCDIBGJHNNL;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid MICKCJMCLPK;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid CACEPPCJNIE;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid OHAGHCJHMPF;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CBEECPOINDM;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid AKCLFJBLLOE;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid KEGIDLOBMPM;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid CMKPNMLPDGF;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid IAEKIJCADCO;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid OJKDJMKOPCO;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid IGAHGMFPFPE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid MLKNGKJHADN;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid AEOHNHGPPOP;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid DCLGFCGNJLO;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid CMGFGFALHNP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid CCMPMEBNIDC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid LFMFPFGMCKO;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid KKDDHEFBEIO;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid PPMOHCMNILA;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid HOCAMJPCLMH;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid JCBGODENAMD;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid HKFNIAMDBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid FLMBLCIHJCJ;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid LKJAPAPPJJL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid FLCAFBFKPKE;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid CBDLANMGMPO;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid MNEAPOONEFG;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid CBIJFCHPCOL;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid MIINPHDDEEK;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid KCDFIOGFMCM;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid NCEAKALALEO;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid NIOGILOGOME;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid PJGBJMJLPBG;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid CBKMJHHCFJO;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid HCCGHGFKDIB;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid EHFMLHNMFHG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid FOKAFEFLGEB;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid NHJBBCPLJAE;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid JMNDHIDELCJ;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid JNCMFGLDHIE;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid PEEGKHBPHOJ;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid BHCJAOBCNBG;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid AAKKCMNPCLE;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid JPJLDCMEGKM;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid HNDNIGDHCCB;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid BHEAJOJMMFB;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid DDJGNLEFOBA;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid KNPGDFKIFCP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid LFHHNLCDKIE;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid DFOBKEAIJFF;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid AKLIGGHNAIO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid HGPLMLJLJEC;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid EAHPFOBDCJK;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid HPFNIOEFFAF;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid JOGLEJCGHEH;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid ONCFMFKKMGB;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid DKEIEMKEJLO;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid PLBOCCGABKE;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid GODKNEKPIHM;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid EIBLOOOGHFD;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid MKKINJGBNBA;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid BGGFMLHLJFM;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid HBDKBGBEGPJ;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid PEIAAPAIMDP;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid DAGHMGHCJHL;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid LDDMDKECDLH;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid CIANJHBCPGM;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid EIAMOBKAACA;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid LAHFOBACCOK;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid CDHDGCPPJIK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid PGGBCLDKMPC;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid PJIPEBDHEBO;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid HDAHFPOHGAK;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid GPKEJCGGOJA;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid MCIBFEEGFGP;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid OILMMBPOPIC;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid HHPJLMBAJAH;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid CODGGAPDIOM;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid NKGIDFHPGIG;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid HIHNFPEHNGL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid PPDGJPAIDBC;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid EANLABAJGMA;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid AFNEDEJBJNB;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid PEOBODGNJGB;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid CGJBMIFHCFN;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid FOJECNPCKLG;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid EHGPLMANHPO;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid INHDKAMHJLJ;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid NKABFKOKALL;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid HNJOIOAJIEF;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid HNMOKMCDHEC;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid IMFOAIONLGA;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid PEHBEDJKBHK;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid DDICCDFADLA;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid HPKHHALCKPK;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid MOAFJEOKPFH;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid HLOCOIKNOGC;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid DGGADKKFDGN;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid NONAPBLFMOC;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid IFJMDBGLKBD;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid DCCIFHIMNMI;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid ODPEOJBIDKD;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid PDFGCGINKMC;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid CDPMDMLCLKA;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid BMMLKOHPBHF;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid JBMJDJEPJGC;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid IPGPMBCFHHP;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid NJAMHIBFCFJ;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid PCFNILHLIEO;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid MOOKKLDPEIO;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid AEIPMDMHMOI;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid KAKALEJDEFB;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid KFNMOKEAMCE;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid IGCDOCJDKEM;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid BHCOACONMEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid FFMGJJKILKL;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid DEOGNCOKJCA;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid EHLMJFMKGBK;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid LAFNHNKDBNE;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid OAPOFDLNLOA;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid OLBDOMPHIAK;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid NKDGJBOCEOC;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid HPAPMJMIDDJ;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid KJPDFHHBOCB;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid EKEGLBNCHBA;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid DMMBLLLLMCN;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid MIFAAGFGCAP;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid CJHILPEEBNL;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid NEPGJGNKOIB;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid OAEIANKEODB;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid APHFBJEJPIA;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid ABECALAFEKB;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid FFJNFMEEKNB;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid FBBLPGLBNPG;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid AGOOKFCJKOM;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid PLIIKOFAKHK;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid PCPHCKCBEDA;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid HFLAKBKOIPF;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid FCEMDFLIOFL;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid BNHJDHNMEGO;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid LJMDBHKOLJI;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid PNEINFJDLGH;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid GDMGOIPLAMC;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid DMGHBJGFKFN;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid EKPLGHCFGML;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid LJAAIFLFALC;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid CHBKIIBNLAD;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid GJPDMGKPLEH;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid MIBFDLEMBED;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid EKOFFDBCIBA;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid JGEKMDGHNOP;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid MLICGEJBKCL;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid JHNJGEPJPAO;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid LOKKJMHJJLH;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid DKFNMNEICFO;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid GHBPMIIFAJC;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid GJKKCELMHNA;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid EEPOLBNLFJK;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid KBDNGONGLEK;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid FHCOLMACJLI;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid EINPNBLFMNH;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid EOOECMPANCP;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid NIJJMDNBJAO;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid JOMDCGJDGOK;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid DKJLKFPLEGM;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid MJMFEMPHJLC;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid NDONPJFBDDP;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid OFGFPADAKEB;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid ENFKOLOFDIE;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid DNGFLEJLOGC;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid EDKBDANELDG;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid ACGMHCADDCB;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid JIBOPPADEGD;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid DHDNAAJCENF;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid LLNMOPOIHOE;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid JJCNPOAKCMO;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid HPFBBEIJHMG;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid OLIENAODFMF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid ENCPCBHLLJL;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid LKEOOFJHCFC;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid INMBLBFIDPN;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid LONINKPHFKC;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid FLFNKLJNJDP;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid KGKBLMOBKGB;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid MFIPNNEAFEB;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid CHGNEIDOGFP;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid FIGMGAKGEAP;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid JEAEHOFKNEE;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid DOAAGJCJFHI;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid CFFFMFLCDCG;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid PNIKCMMAJAJ;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid BJOCBNFLGDB;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid ENMNGKNAOCG;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid GEMIPEIKBIG;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid BEAMGFCMPJA;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid MALDDADNIKF;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid IIOPKEPGIPE;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid PCLILEAFLMM;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid OFDLIJHHFNC;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid JIIJAHDAJDN;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BMPMOENEPKG;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid FFKAHJCNPPI;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid ONMPIILOHEL;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid BBMGLILKOFL;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid NBNKABJKOAH;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid MJKHNBLOKPA;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid NPBMKLNDFEF;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid PFLHMAJHLNA;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid HALLOBKMIOL;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid FPHKLFKGFCN;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid BAKJCJCGLPA;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid PHGLEGHJGGL;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid HLOBEPBDFND;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid EFKEFJJNCHF;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid FPAGOAIBFKM;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid ACPBEMNPHON;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid MBNBPFELCAO;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid GFHBGNAHEAL;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid JGLOJCEAGFO;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid ALJEKDLGMLK;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid HJEIMDMDMLA;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid FPPBKJLNMGH;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid GBBIIBIAJJF;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid HHLACILOGMP;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid DCCPHHKJMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid ONOGKFBAFAF;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid LBANMCPOLFI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid GIFCKGBNMOD;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid HDEKDGFNGIP;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid DADHPHEKKBA;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid BEFNHOFPGIH;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid OPMNPNKOCDL;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid KONFPJJLFHA;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid DIMDFNHGABP;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid JBMKALOILEK;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid EGIIHGPKLII;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid CCPBCPCJFPG;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid PNNCAAFNOKP;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid JAOAAHFPPCA;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid PGPMFCNCEIL;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid ICICEEKJCGA;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid DBFOCDMFCGN;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid MDLALLIODDM;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid CKAHHCJANNI;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid HOMDBMJLIOH;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid PMLCHLPMAMN;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid KCGLBDDBFJI;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid AAGDBJAEIOM;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid OOOAADNMDGI;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid COHCOIDMFJJ;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid NHDFOPEPGOB;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid OECIFBLCFGE;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid NDDDDHBKMCL;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid PGMMHDFNKDJ;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid EGJBCJDDPOD;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid BOBBFFOMCMF;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid EFCHANMJIKP;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid LMONLEIJAAI;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid MJDJGHHKDCN;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid GDEGPIIPGNI;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MMMBFDCGIKB;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid BGBOJGKNHAC;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DBCMEGDBPLJ;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid CAKBIMHDJNP;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid APKAHBMMKML;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid AJNAMACICOP;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid BOKHKBLMANE;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid HBFOLEJMAHE;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid NNGKELOKONA;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid CMGDGPMCBIH;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid CFOJDJFLFOJ;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid IOCFNIFLHGL;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid MCFHLDDDGEG;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid LKAPIAJFJLH;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid CIOILKGLFIJ;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid EFHILKPJDPM;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LNLPHPLLADP;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid ANIMJDNAGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid MOENIMPCEEE;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid KCLFDGIIKMJ;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid BMNLPAEIBBF;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid IMJGDANICAB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid PHELPIFCFBF;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid KJEHEKNPCEC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid GBJMLNKANCD;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid CABADDBMAGD;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid KKIEEAAFDEH;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid LIANKAJEJOC;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid MJGNBODPPHO;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MBLJHCFOJOC;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid LFMBHJOIAKL;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid FOOBIHBJIHM;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid FOFMMIMLAAI;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid EJKLEMCJDGL;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid DCLMMMMBAPO;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid GKODGMNOJCB;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid EIAMHBAMDHI;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FFHBJHOJDFO;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid JAKGFHMEPAF;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid PDKECHJDECO;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid CBIELLJPCLP;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid MOGAJGCBPCC;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid OJKCKNPAOHJ;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid ADENFLDEKAA;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid PJBFLGPEBIC;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid KIAKKGIKPMG;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid HIOABOFLLOE;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid MFGFDGDLMEI;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid PNDNCGAMLAO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid MDPKNDGEGKN;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid PEIPIGGGOBO;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid NDCLPGCMDPD;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid ENIOHPIACHJ;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid HHCCOFFJHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid GHFMEJOEDAG;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid FHLKMDFKIME;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid DKHAOKELCIO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid LPCKPFLANAL;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid JOEDOBFDCMD;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid CPDJIEGKEFG;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid FOCKCMFNNPH;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid KKAAKEGKLJM;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid KIBOEBPPMFB;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid CFMIDPPKOBL;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid HDDKOEINGNJ;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid IJFLAKBOJJG;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid MCDEGHGIBGG;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid NNOPIOLONCG;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid HLPAKFDDFEG;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid FPKHICEOLKG;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid GCEBAHBKONC;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid JJJFHIBACLF;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid DDPCPPNHGCN;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid GBEBKADPMPE;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid IHENEPPCNLJ;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid HGCAKOJDJFG;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid CEADCMNIGBM;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid CIFEPFFGLPL;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid CMCCMOKDJDH;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid AFJMMPEPJDG;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid LBLDEBHHBMC;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid LKIHMBELNHI;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid KBGMMJALMKJ;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid JHNLMGEMDMA;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid PKJDGHNJAHL;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid COGFILPKKCC;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid JJKJHNJNPKN;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid HHLLBBFMGOD;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid OECHJMMNFAN;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid DBMABABDEFN;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid PBNDJPGNIBH;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid BAIJHOBBJAK;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid GFJFCCHKEHP;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid KLGCIMFIGLP;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid JHCHIINHIBG;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid DGIACNAJBLG;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid KLHIOMECAOA;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid LDOBCMLIIDG;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid JLNHPLPANGK;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid IGJOKIBCFMM;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid GFIAJPBCPHD;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid GJNOFMLIOCE;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid DABCEOMPKPF;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid NHNJELMMIMB;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid NKLCCNPFEEC;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid FKBBCEBELFG;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid HDDHPKHJCGG;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid LFEPGJCNAFD;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid IKIELFCGJHF;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid BMNBPPKMLBJ;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid LMDHHMKEMOO;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid ABOOFMNFPHD;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid EBBLBMJNGCK;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid FCJJENGKPOG;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid PDCEJENJPBI;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid LDFBMIOJAFE;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid IAEKJNIGNMC;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid CKNKDPNJPFC;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid OEKKODJIAED;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid POFIFKOMBEJ;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid OGJMIJFAOCN;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid DMKECCNPLKP;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid DDCDJHPKDLI;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid GCJLBJAPIGJ;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid IDKEMALIJAJ;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid OOJEKFDJDDP;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid NIAIDIPJFIH;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid FBFEMMPJDAL;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid BJJJGBAIEOF;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid GLEEHONPIHP;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid NBAIAAPACLC;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid GMEFKOJECOM;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid DFNKHHKFABI;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid IAMEIMGINHL;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid NBMLKBDGMCO;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid NPLBDCHAEKP;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid NLFAMPAPJCA;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid HIILABLMKKM;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid BLAHPKIILAJ;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid JGNIDALPKIL;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid CDHOGBBEEKI;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid FEIPJEFJPOM;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid LKDECDIIMGC;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid HPFAIBGCKBA;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid GMHHBECPFBO;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid IGDLEINCCAJ;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid KAEHBGBEGED;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid EMFLDOLONKA;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid IDBELCCFAFH;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid GOGKNEIJPKH;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid LCPNNJINJDJ;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid ONIBENKJFPD;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid PLPKDAJDMGA;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid BGCPPOPAPJH;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid EBJGGDJFAPG;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid IGHNBIHHMLO;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid GNCIIJDLDFJ;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid INJMPNCHBHN;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid DGJIGLDOCJP;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid GMAJIPLBJNA;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid GCLEFJKOEPL;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid MNDNPPMPIHB;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid KIOCCJKANHL;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid HLACANINFHH;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid FMJBLAEGINP;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid LICMJBEMNMA;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid BLDGNKKONBC;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid KFGIFKEOAFG;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid DOEJEFOBOJK;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid HEJCIBNPGHK;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid BLGKBPHCLNA;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid PIACOFDFBBA;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid FANAPENCGPM;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid GKCEBJGDJLP;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid JLGMGMOCJED;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid HAMEDJEABAH;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid MACHOMFDFJK;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid DBIHOKELPID;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid JCPINDJNFIF;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid EAEOMCKIHBK;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid NGOJKOHKGBG;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid KIBEGBNKCFD;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid DLGGOMEGABG;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid OOAKIEMHOCD;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly Dictionary<Guid, INKAHEHKDEH> PLHJHHHFCML;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private static readonly Dictionary<INKAHEHKDEH, Guid> BDIPHIPBHEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, INKAHEHKDEH> EKPBJBIMOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7884410", Offset = "0x7882E10", VA = "0x187884410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<INKAHEHKDEH, Guid> DPPFFGLDLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78843C0", Offset = "0x7882DC0", VA = "0x1878843C0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JAMJIOOOKBM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x78805A0", Offset = "0x787EFA0", VA = "0x1878805A0")]
	public static bool NELEKLANIDK(KOGJIEHIEMO JJFGHIBJMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x78805D0", Offset = "0x787EFD0", VA = "0x1878805D0")]
	private static bool NELEKLANIDK(CPOHCFHANCE HPKAFPMNGAI, KOGJIEHIEMO JJFGHIBJMAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MAHCPDOBGNK
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(AEGDOOOIADA DFPGGEDGGGN, [Out] Dictionary<int, int> AILLBBGNMPC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(JEFPFBDEHJG JJNCFGIEGMI, NPPAALNONOH PMGKOPHFEJP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct NMININLADDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public readonly CKJKJGAEKNE CIAOGKHMHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public readonly IEnumerable<FDOLPBGFEHG> AEIKJKEIOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly IReadOnlyList<FDOLPBGFEHG> PDBMNBHEKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly NBPBIJJFIMI<IHOCDEAAOKH> LGMABAJNGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly IReadOnlyList<ONJBBFDPPLI<EAOBDBIODMJ>> KOKMAADMCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly DNJEDACMEPF BAJCDKECFAB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HGCAFJICHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7884350", Offset = "0x7882D50", VA = "0x187884350")]
	public NMININLADDO(CKJKJGAEKNE LKAEOCKNCEG, IEnumerable<FDOLPBGFEHG> DBAGDLKIHLO, IReadOnlyList<FDOLPBGFEHG> EPKIMBHEDBM, NBPBIJJFIMI<IHOCDEAAOKH> OMAMBNBOHBN, IReadOnlyList<ONJBBFDPPLI<EAOBDBIODMJ>> BBBBFJBLGDM, DNJEDACMEPF GIMONOAACAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DDEIBEGNOAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly CKJKJGAEKNE CIAOGKHMHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly IReadOnlyList<FDOLPBGFEHG> KJNENIOJAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly NBPBIJJFIMI<IHOCDEAAOKH> LGMABAJNGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly IReadOnlyList<ONJBBFDPPLI<EAOBDBIODMJ>> KOKMAADMCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly ByteString HPAFFEHAHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly DNJEDACMEPF BAJCDKECFAB;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x786FB10", Offset = "0x786E510", VA = "0x18786FB10")]
	public DDEIBEGNOAC(CKJKJGAEKNE LKAEOCKNCEG, NBPBIJJFIMI<IHOCDEAAOKH> OMAMBNBOHBN, IReadOnlyList<ONJBBFDPPLI<EAOBDBIODMJ>> BBBBFJBLGDM, ByteString OAJMFPJFILI, IReadOnlyList<FDOLPBGFEHG> MMKMMOLLGNG, DNJEDACMEPF GIMONOAACAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PLALJOICCPM : DHFOCPKOKGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly Guid HDCOHCCFGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private readonly Dictionary<Guid, Guid> NCNKGDJFDBF;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x475F360", Offset = "0x475DD60", VA = "0x18475F360")]
	private PLALJOICCPM(Guid CIPFDHMGNOB, Dictionary<Guid, Guid> NCNKGDJFDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7884880", Offset = "0x7883280", VA = "0x187884880")]
	public static PLALJOICCPM DDDHPONDPCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x78844E0", Offset = "0x7882EE0", VA = "0x1878844E0")]
	private static Dictionary<Guid, Guid> CJEEFIMPAGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7884DA0", Offset = "0x78837A0", VA = "0x187884DA0")]
	public static PLALJOICCPM KKIHDHADJOO(IReadOnlyDictionary<Guid, Guid> KKMIKMKCMKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7884590", Offset = "0x7882F90", VA = "0x187884590")]
	public static PLALJOICCPM CLBNLCHMPKK(IEnumerable<KeyValuePair<Guid, Guid>> KKMIKMKCMKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7884A30", Offset = "0x7883430", VA = "0x187884A30")]
	public Dictionary<Guid, Guid> ICINOCCHOJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
	public Dictionary<Guid, Guid> KONGLBDBBAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x78849B0", Offset = "0x78833B0", VA = "0x1878849B0")]
	public void HEHCILJMFIP(Guid KKMIKMKCMKE, Guid GNMBGILIMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7884B20", Offset = "0x7883520", VA = "0x187884B20")]
	public void IPKLDCODOBN(IReadOnlyDictionary<Guid, Guid> LGODFHJMOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7884DB0", Offset = "0x78837B0", VA = "0x187884DB0")]
	public Guid KPPIBHOPLDI([In] Guid KKMIKMKCMKE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7884910", Offset = "0x7883310", VA = "0x187884910")]
	public Guid ECIGFMPCCOA([In] Guid KKMIKMKCMKE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7884AB0", Offset = "0x78834B0", VA = "0x187884AB0")]
	public bool IFHBDFLEPBB([In] Guid KKMIKMKCMKE, [Out] Guid GNMBGILIMLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7884AB0", Offset = "0x78834B0", VA = "0x187884AB0", Slot = "4")]
	private bool PGJBEMPBOGG([In] Guid KKMIKMKCMKE, [Out] Guid GNMBGILIMLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HMPMABCPGKI
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
public sealed class FEHAFNIMFLE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CINGNCHLAKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public CKJKJGAEKNE staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CINGNCHLAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x786FAA0", Offset = "0x786E4A0", VA = "0x18786FAA0")]
		internal NBPBIJJFIMI<JLCNBOMJGDP> LDNIONLHHMF((NBPBIJJFIMI<IHOCDEAAOKH> GraphId, NBPBIJJFIMI<EAOBDBIODMJ> NodeId) i)
		{
			return default(NBPBIJJFIMI<JLCNBOMJGDP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private static readonly OLEFDBMKBOK<JLCNBOMJGDP, int?> AFAMDMIJDEJ;

	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly long EFBECAEONKC;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7872F00", Offset = "0x7871900", VA = "0x187872F00")]
	public static (long, long) DJGBPEOMOLI(CKJKJGAEKNE GFMLLNCGLAE, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<EAOBDBIODMJ> EGEPAJMBPNL)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7873330", Offset = "0x7871D30", VA = "0x187873330")]
	public static long MAKDDEBNCNC([In] ReadOnlySpan<NBPBIJJFIMI<JLCNBOMJGDP>> NGKABGGKGAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7873450", Offset = "0x7871E50", VA = "0x187873450")]
	private static long MBNGJPKGALJ()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class APMBPAJDEKC
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public static readonly HashSet<INKAHEHKDEH> JODCDHEAFMB;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DEECHMHCDJF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class OMMLOBJCMHF : IEnumerable<FDOLPBGFEHG>, IEnumerable, IEnumerator<FDOLPBGFEHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private FDOLPBGFEHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private PMAJAMFAIND spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public PMAJAMFAIND <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private INMOPGCJFEK spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public INMOPGCJFEK <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FDOLPBGFEHG System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public OMMLOBJCMHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x788FDA0", Offset = "0x788E7A0", VA = "0x18788FDA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7890020", Offset = "0x788EA20", VA = "0x187890020", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x788FEB0", Offset = "0x788E8B0", VA = "0x18788FEB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FDOLPBGFEHG> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x788FEB0", Offset = "0x788E8B0", VA = "0x18788FEB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7872760", Offset = "0x7871160", VA = "0x187872760")]
	public static PMAJAMFAIND PHFNIBKAEHC([In] DDEIBEGNOAC JLHHOLIABOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x78728D0", Offset = "0x78712D0", VA = "0x1878728D0")]
	public static PMAJAMFAIND PHFNIBKAEHC([In] NMININLADDO JLHHOLIABOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7871950", Offset = "0x7870350", VA = "0x187871950")]
	private static HashSet<ONJBBFDPPLI<DFLMFCNCCPI>> HFCMLBNBFIB(IReadOnlyList<FDOLPBGFEHG> EJEPCBHACLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x786FF70", Offset = "0x786E970", VA = "0x18786FF70")]
	private static void BJCFDBMDJLO(PMAJAMFAIND FMEHPLKGOLA, [In] NMININLADDO DDKALFNKHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x78705D0", Offset = "0x786EFD0", VA = "0x1878705D0")]
	public static CEGCKGHHPPP<PLALJOICCPM, NPELABPLDOB> GOALFBNHNJN(PMAJAMFAIND FMEHPLKGOLA, INMOPGCJFEK JJECOFKOELE, PLALJOICCPM? PIMKDGPDNON, bool BAHAFMNOLOF)
	{
		return default(CEGCKGHHPPP<PLALJOICCPM, NPELABPLDOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x786FE60", Offset = "0x786E860", VA = "0x18786FE60")]
	[IteratorStateMachine(typeof(OMMLOBJCMHF))]
	private static IEnumerable<FDOLPBGFEHG> BAEJDJFLIOC(PMAJAMFAIND FMEHPLKGOLA, INMOPGCJFEK JJECOFKOELE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7871FC0", Offset = "0x78709C0", VA = "0x187871FC0")]
	private static void IJFEAGHMFCP(PMAJAMFAIND FMEHPLKGOLA, INMOPGCJFEK JJECOFKOELE, IReadOnlyCollection<ByteString>? COHLGEOBLLA, IReadOnlyCollection<ByteString>? EOINBKPHPPI, IReadOnlyCollection<ByteString>? LKHOBLEFAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x78720C0", Offset = "0x7870AC0", VA = "0x1878720C0")]
	private static bool KFNKLEPPAEO(PMAJAMFAIND FMEHPLKGOLA, JEFPFBDEHJG JJNCFGIEGMI, INMOPGCJFEK JJECOFKOELE, [Out][NotNullWhen(false)] string? LPNLOGECJBM, [Out] Dictionary<int, int> AILLBBGNMPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x786FB80", Offset = "0x786E580", VA = "0x18786FB80")]
	private static Dictionary<Guid, CPOHCFHANCE> ACABCEOCBGG(PMAJAMFAIND FMEHPLKGOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7872030", Offset = "0x7870A30", VA = "0x187872030")]
	private static void JHLMKKGBNAN(bool EKGJFIJLKIC, FDOLPBGFEHG JDJGOBEPLEN, PLALJOICCPM INGAOCHLELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7871CF0", Offset = "0x78706F0", VA = "0x187871CF0")]
	private static void HFDFPMMEHMF(FDOLPBGFEHG JDJGOBEPLEN, Guid HGHGJGKJMGN, OPBGOAEJLGP? BKGEDBGKIMF, Dictionary<Guid, CPOHCFHANCE> KEHJNFGNHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7872A50", Offset = "0x7871450", VA = "0x187872A50")]
	private static void PNCFMCNOIGL(IEnumerable<FDOLPBGFEHG> GGMFHAJKNCB, IReadOnlyCollection<ByteString> COHLGEOBLLA, IReadOnlyCollection<ByteString> EOINBKPHPPI, IReadOnlyCollection<ByteString> LKHOBLEFAMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct INMOPGCJFEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public bool EKGJFIJLKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public DNJEDACMEPF GIMONOAACAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public OPBGOAEJLGP? BKGEDBGKIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public OPBGOAEJLGP? MDNCBPNOIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public CKJKJGAEKNE OKMJDGHJPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public HMPMABCPGKI IEFBFLBGHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public MAHCPDOBGNK PNCDCBCNNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ONJBBFDPPLI<IHOCDEAAOKH> AKACAPDJBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public AJFICCPHEAJ JLAKJDIHJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public List<FDOLPBGFEHG> BHBMCFHBPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public PDJBLPFEHEB EPAABBIFLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public EEPIHJECMEJ CLJIEOEGNMK;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OPBGOAEJLGP
{
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private const float CDOKCLHGBAA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Vector3 KKIJMCHODGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public Quaternion KONJHPLFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public float GFDDEGDNEEN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 BKIFNHCKCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7890070", Offset = "0x788EA70", VA = "0x187890070")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS GIDKBMOAHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7890460", Offset = "0x788EE60", VA = "0x187890460")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x12C7E80", Offset = "0x12C6880", VA = "0x1812C7E80")]
	public OPBGOAEJLGP(Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME, float GFDDEGDNEEN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7890840", Offset = "0x788F240", VA = "0x187890840")]
	public OPBGOAEJLGP(UniformTRS LDJNMLONPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x78901E0", Offset = "0x788EBE0", VA = "0x1878901E0")]
	public static OPBGOAEJLGP FGJIBKFFJHC(OPBGOAEJLGP HGBJMKAPAJA, OPBGOAEJLGP FPMPJIPGGAO)
	{
		return default(OPBGOAEJLGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7890790", Offset = "0x788F190", VA = "0x187890790")]
	public static OPBGOAEJLGP MEHFEEABIDG((Vector3, Quaternion, float) DFPGGEDGGGN)
	{
		return default(OPBGOAEJLGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7890610", Offset = "0x788F010", VA = "0x187890610")]
	public static OPBGOAEJLGP MEHFEEABIDG(Matrix4x4 FOECBPCGOAC)
	{
		return default(OPBGOAEJLGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x78907B0", Offset = "0x788F1B0", VA = "0x1878907B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x78904A0", Offset = "0x788EEA0", VA = "0x1878904A0")]
	public OPBGOAEJLGP GDJDGOMBPDH(Matrix4x4 GBIMAJCBFCJ)
	{
		return default(OPBGOAEJLGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7890170", Offset = "0x788EB70", VA = "0x187890170")]
	public static OPBGOAEJLGP EHGDIIHGEDK(Vector3 KKIJMCHODGC)
	{
		return default(OPBGOAEJLGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7890580", Offset = "0x788EF80", VA = "0x187890580")]
	public readonly FKLAPOHONBG KLJKLKGBNBP()
	{
		return default(FKLAPOHONBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FPADOFOALGP
{
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct NPELABPLDOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public readonly PCHGKEHELGO BNOOAOPEKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly ACEELKDBFDK BDPGIPDPEHL;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1581470", Offset = "0x157FE70", VA = "0x181581470")]
	private NPELABPLDOB(PCHGKEHELGO OAIBEKCJMGA, ACEELKDBFDK DOKEFGKNLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x788C240", Offset = "0x788AC40", VA = "0x18788C240")]
	public IJONLINDONG HJIIFJEKMMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x788C020", Offset = "0x788AA20", VA = "0x18788C020")]
	public static CEGCKGHHPPP<PLALJOICCPM, NPELABPLDOB> DDDHPONDPCL(NHEEHIFKDCE<HGCBNLHKPOI> DOKEFGKNLPI)
	{
		return default(CEGCKGHHPPP<PLALJOICCPM, NPELABPLDOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x788C0D0", Offset = "0x788AAD0", VA = "0x18788C0D0")]
	public static CEGCKGHHPPP<PLALJOICCPM, NPELABPLDOB> DDDHPONDPCL(IJONLINDONG DOKEFGKNLPI)
	{
		return default(CEGCKGHHPPP<PLALJOICCPM, NPELABPLDOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x788C180", Offset = "0x788AB80", VA = "0x18788C180")]
	public static CEGCKGHHPPP<PLALJOICCPM, NPELABPLDOB> DDDHPONDPCL(string AINOJMLJJJO)
	{
		return default(CEGCKGHHPPP<PLALJOICCPM, NPELABPLDOB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum PCHGKEHELGO
{
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HMEECABLEAA : IDisposable, KMCFMGGIDLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private NativeList<CEGHMCHEJIL> CMOAACGHPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private float KENADGHPFEK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FFELHMGLKAD GKALKMPIJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
		[CompilerGenerated]
		get
		{
			return default(FFELHMGLKAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NKPEPLHFJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6811600", Offset = "0x6810000", VA = "0x186811600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool HCNJFILILDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6811610", Offset = "0x6810010", VA = "0x186811610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<EGCGLAMGJLN> JLNECJPHHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LJEEPKKHAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7889D90", Offset = "0x7888790", VA = "0x187889D90", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float EOKKBHJGLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7887880", Offset = "0x7886280", VA = "0x187887880")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7889DD0", Offset = "0x78887D0", VA = "0x187889DD0")]
	public HMEECABLEAA(FFELHMGLKAD BNNEEGIINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7887B70", Offset = "0x7886570", VA = "0x187887B70", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7889770", Offset = "0x7888170", VA = "0x187889770")]
	public Vector3 NNIOIOJNEIG(int AIBKCJCMBBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7888660", Offset = "0x7887060", VA = "0x187888660", Slot = "6")]
	public Quaternion HLADAPMOJPG(int AIBKCJCMBBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7888D80", Offset = "0x7887780", VA = "0x187888D80", Slot = "5")]
	public Vector3 KIAOEEIGGKK(int AIBKCJCMBBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x78875F0", Offset = "0x7885FF0", VA = "0x1878875F0", Slot = "7")]
	public float ABJDAFCCBDE(int AIBKCJCMBBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7887D50", Offset = "0x7886750", VA = "0x187887D50")]
	public void EPFDEACODFL(Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME, float OAIHKLDEKFL, bool KNNDDPJBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7887820", Offset = "0x7886220", VA = "0x187887820")]
	private bool CLECOCAPHDN(int NKMELFKMIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7887BD0", Offset = "0x78865D0", VA = "0x187887BD0")]
	public void EGFNFPIHIAP(Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME, float OAIHKLDEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7887650", Offset = "0x7886050", VA = "0x187887650")]
	public void AHJLGCDOHKG(int NKMELFKMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7889C40", Offset = "0x7888640", VA = "0x187889C40")]
	public void OHLOFNMFAIP(int NKMELFKMIDD, Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME, float OAIHKLDEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x78879C0", Offset = "0x78863C0", VA = "0x1878879C0")]
	public void DOMKGJJNBEI(int NKMELFKMIDD, float3 KKIJMCHODGC, quaternion KONJHPLFEME, float OAIHKLDEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7888E20", Offset = "0x7887820", VA = "0x187888E20")]
	public void LHFEDAEOCLJ(int NKMELFKMIDD, Vector3 KKIJMCHODGC, float OAIHKLDEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7888C20", Offset = "0x7887620", VA = "0x187888C20")]
	public void KDOIBCNGFAB(int NKMELFKMIDD, Vector3 MDIKGGEOGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7888F70", Offset = "0x7887970", VA = "0x187888F70")]
	public static Quaternion MKJDAOPDDBH(Quaternion ADLPINICHDN, int NKMELFKMIDD, float KHGGOPJDFPI, KMCFMGGIDLM CDCBPHLPNJO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7888790", Offset = "0x7887190", VA = "0x187888790")]
	public Bounds IHKPCLLEOOE(Transform GBIMAJCBFCJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x78876E0", Offset = "0x78860E0", VA = "0x1878876E0", Slot = "10")]
	public virtual void CDDNOGMINID(bool INJHEPOKBOB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7887750", Offset = "0x7886150", VA = "0x187887750")]
	public NativeList<CEGHMCHEJIL> CEEEJGJPJDB(float MONDOOGEEEA = 1f)
	{
		return default(NativeList<CEGHMCHEJIL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EGCGLAMGJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public float3 NHAANPHMDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public float OLOBPPGFKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public quaternion CBONECLGDLP;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7885CD0", Offset = "0x78846D0", VA = "0x187885CD0")]
	public EGCGLAMGJLN(Vector3 OBJAOKLALFD, Quaternion ADLPINICHDN, float OAIHKLDEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7885C10", Offset = "0x7884610", VA = "0x187885C10")]
	public Quaternion IKPEKHMILAG(Vector3 BJECPMGLFMN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7885780", Offset = "0x7884180", VA = "0x187885780")]
	public EGCGLAMGJLN DLFANLPAOOJ(Vector3 KFFDIPLICGF, Vector3 PMNMGMHNNKM, Vector3 GBCDIEINIEG)
	{
		return default(EGCGLAMGJLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7885A70", Offset = "0x7884470", VA = "0x187885A70")]
	public ADFCKAGAOLH GFKOIKCOEKJ(Vector3 BJECPMGLFMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class OACGFAPGJCF : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x788C2B0", Offset = "0x788ACB0", VA = "0x18788C2B0", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x788C330", Offset = "0x788AD30", VA = "0x18788C330")]
	private void LEOHKJKKLCH(Dictionary<Guid, Guid> JNGOPCDMPDH, EDIHLKCGOKA EHMIOPNHBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x788C910", Offset = "0x788B310", VA = "0x18788C910")]
	private void LEOHKJKKLCH(Dictionary<Guid, Guid> JNGOPCDMPDH, NFBFPFHGFON PKABDKINMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x788C970", Offset = "0x788B370", VA = "0x18788C970")]
	private void LEOHKJKKLCH(Dictionary<Guid, Guid> JNGOPCDMPDH, EGBONJLHILH ALLFHFPMHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public OACGFAPGJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class EKLIAEGNKIG : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x78860B0", Offset = "0x7884AB0", VA = "0x1878860B0", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public EKLIAEGNKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class KEAODLPEJEH : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x788B8A0", Offset = "0x788A2A0", VA = "0x18788B8A0", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public KEAODLPEJEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class CLKMNDAFEIF : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x78853E0", Offset = "0x7883DE0", VA = "0x1878853E0", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public CLKMNDAFEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class EIOHJHOFBOL : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7885D50", Offset = "0x7884750", VA = "0x187885D50", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public EIOHJHOFBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class EKIGAEEJDPO : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7885F70", Offset = "0x7884970", VA = "0x187885F70", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public EKIGAEEJDPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class CJNJHAAHGDF : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7885250", Offset = "0x7883C50", VA = "0x187885250", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public CJNJHAAHGDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PDDJNOIHIDP : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7890910", Offset = "0x788F310", VA = "0x187890910", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public PDDJNOIHIDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class ENDCCNEMBAB : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7886160", Offset = "0x7884B60", VA = "0x187886160", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public ENDCCNEMBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BCIPDNMJBOK : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x78850A0", Offset = "0x7883AA0", VA = "0x1878850A0", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public BCIPDNMJBOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class OEBDMBHPADB : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x788CBF0", Offset = "0x788B5F0", VA = "0x18788CBF0", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public OEBDMBHPADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class FOLFFBBPMIH : DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public static readonly MBEKPPFNIBO NMEEIEHBPHM;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7886310", Offset = "0x7884D10", VA = "0x187886310", Slot = "4")]
	public void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public FOLFFBBPMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct KOGJIEHIEMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public JEFPFBDEHJG AIBPOENNNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public HBPNKIEKBJJ DBAECGAGCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public Dictionary<int, int> FHBDHOHPLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public Dictionary<Guid, Guid> PHHPOMHKPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public EEPIHJECMEJ CLJIEOEGNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public bool BAHAFMNOLOF;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DGJADHDNMNG
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IADFBNIIDDM(KKJOLAGNFDO CMFOAHOAEDI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JEACKLBCKJI
{
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private static readonly DGJADHDNMNG[] PKGKKEBFLMJ;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x788AA10", Offset = "0x7889410", VA = "0x18788AA10")]
	public static void GKGCCGHAEJH(FDOLPBGFEHG DFPGGEDGGGN, PLALJOICCPM NFIIJLNOELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x788A780", Offset = "0x7889180", VA = "0x18788A780")]
	public static void ELLPNIEFIBB(FDOLPBGFEHG? DFPGGEDGGGN, PLALJOICCPM MLHIDCLJLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x788AC90", Offset = "0x7889690", VA = "0x18788AC90")]
	public static void KOGJPPDIPDC(FDOLPBGFEHG? DFPGGEDGGGN, PLALJOICCPM INGAOCHLELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x788AF00", Offset = "0x7889900", VA = "0x18788AF00")]
	public static void NELEKLANIDK(KKJOLAGNFDO CMFOAHOAEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KKJOLAGNFDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public JEFPFBDEHJG IMIFAHAEGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public FDOLPBGFEHG JDJGOBEPLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public Dictionary<int, int> FHBDHOHPLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public Dictionary<Guid, Guid> PHHPOMHKPDI;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x788BA00", Offset = "0x788A400", VA = "0x18788BA00")]
	public Guid JIBBHGHEKEB(Guid BIGAPECKJPI)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EEPIHJECMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int AHEDOMAFPKK, [Out] Guid JDBOCGLNDKN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class OMCEIBGBPDO
{
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private static readonly ProfilerMarker AMFAFELDPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private readonly HashSet<string> HAEKCJCLGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly Dictionary<long, int> OFEGJDBEBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private readonly HashSet<Guid> CCHGGBACCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private readonly HashSet<Guid> HLBBLKPCDPE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> IPCMEEOMICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> GEHDNANAEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> ONJDBPJOMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x788EBE0", Offset = "0x788D5E0", VA = "0x18788EBE0")]
	public static void JFLEFFDLDFK(PMAJAMFAIND BNDFANACDDH, DLBHPPFHEAE ICLPDLMCACK, PLALJOICCPM KKGAJACPAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x788F930", Offset = "0x788E330", VA = "0x18788F930")]
	public static OMCEIBGBPDO OGKINODNPLH(ENCFJAGIPBN COLBDAEGKBA, [Optional] DLBHPPFHEAE? ICLPDLMCACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x788F8B0", Offset = "0x788E2B0", VA = "0x18788F8B0")]
	public static OMCEIBGBPDO OGBCANEGOJA(PMAJAMFAIND EMINLAGMHDE, [Optional] DLBHPPFHEAE? ICLPDLMCACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x788F530", Offset = "0x788DF30", VA = "0x18788F530")]
	public static OMCEIBGBPDO LKCPJDHEKPF(IEnumerable<string> HAEKCJCLGOD, IDictionary<long, int> JLLFPEGOKMK, IReadOnlyCollection<Guid> HLBBLKPCDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x788FA70", Offset = "0x788E470", VA = "0x18788FA70")]
	private OMCEIBGBPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x788FBD0", Offset = "0x788E5D0", VA = "0x18788FBD0")]
	private OMCEIBGBPDO(IEnumerable<string> HAEKCJCLGOD, IDictionary<long, int> JLLFPEGOKMK, IReadOnlyCollection<Guid> HLBBLKPCDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x788D980", Offset = "0x788C380", VA = "0x18788D980")]
	private void GLJDIOGKPLC(ENCFJAGIPBN COLBDAEGKBA, DLBHPPFHEAE? ICLPDLMCACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x788DDB0", Offset = "0x788C7B0", VA = "0x18788DDB0")]
	private void GLJDIOGKPLC(PMAJAMFAIND EMINLAGMHDE, DLBHPPFHEAE? ICLPDLMCACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x788CCF0", Offset = "0x788B6F0", VA = "0x18788CCF0")]
	private void AGNELFPOOPL(ByteString? OAJMFPJFILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x788D240", Offset = "0x788BC40", VA = "0x18788D240")]
	private void GLJDIOGKPLC(LINCBANILCA? MHHKOMDGDID, DLBHPPFHEAE? ICLPDLMCACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x788E5F0", Offset = "0x788CFF0", VA = "0x18788E5F0")]
	private static void JFLEFFDLDFK(LINCBANILCA? MHHKOMDGDID, DLBHPPFHEAE ICLPDLMCACK, PLALJOICCPM KKGAJACPAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x788E970", Offset = "0x788D370", VA = "0x18788E970")]
	private static void JFLEFFDLDFK(DHCNMLBALCC? ABACLNNLPOO, DLBHPPFHEAE ICLPDLMCACK, PLALJOICCPM KKGAJACPAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x788DBA0", Offset = "0x788C5A0", VA = "0x18788DBA0")]
	private void GLJDIOGKPLC(DHCNMLBALCC? ABACLNNLPOO, DLBHPPFHEAE? ICLPDLMCACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x788DFD0", Offset = "0x788C9D0", VA = "0x18788DFD0")]
	private void JEPHIAAIEHK(Guid? BIGAPECKJPI, DLBHPPFHEAE? ICLPDLMCACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x788D580", Offset = "0x788BF80", VA = "0x18788D580")]
	private void GLJDIOGKPLC(FDOLPBGFEHG? JDJGOBEPLEN, DLBHPPFHEAE? ICLPDLMCACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x788E1B0", Offset = "0x788CBB0", VA = "0x18788E1B0")]
	private static void JFLEFFDLDFK(FDOLPBGFEHG? JDJGOBEPLEN, DLBHPPFHEAE ICLPDLMCACK, PLALJOICCPM KKGAJACPAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x788D1D0", Offset = "0x788BBD0", VA = "0x18788D1D0")]
	private void DCEFLLGNNAH(string? PFOHKAFLDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x788F730", Offset = "0x788E130", VA = "0x18788F730")]
	private void OEMEOMENDGH(long NIFPOEHKIAM, Guid IIJDFPOELMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x788F800", Offset = "0x788E200", VA = "0x18788F800")]
	private void OEMEOMENDGH(FGEIANBHEDE? ANIIPCMHOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x788F850", Offset = "0x788E250", VA = "0x18788F850")]
	private void OEMEOMENDGH(HGOOCIJLGNB? ANIIPCMHOEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct HENKHECBGDD
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class NFFGGKLFOFG : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private readonly IEnumerator<DictionaryEntry> EEBIIAOHCCB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry HKEHCIPGCCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x788BE00", Offset = "0x788A800", VA = "0x18788BE00", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object BKFIOJPHBFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x788BEC0", Offset = "0x788A8C0", VA = "0x18788BEC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object ABKPALEDJBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x788BF70", Offset = "0x788A970", VA = "0x18788BF70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x788BD20", Offset = "0x788A720", VA = "0x18788BD20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
		public NFFGGKLFOFG(IEnumerator<DictionaryEntry> EEBIIAOHCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x788BC80", Offset = "0x788A680", VA = "0x18788BC80", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x788BCD0", Offset = "0x788A6D0", VA = "0x18788BCD0", Slot = "9")]
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
		private sealed class ADGCDINCEBN : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xB9B420", Offset = "0xB99E20", VA = "0x180B9B420", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7885050", Offset = "0x7883A50", VA = "0x187885050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
			[DebuggerHidden]
			public ADGCDINCEBN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7884F00", Offset = "0x7883900", VA = "0x187884F00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7885000", Offset = "0x7883A00", VA = "0x187885000", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7890FD0", Offset = "0x788F9D0", VA = "0x187890FD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object NJBPFCDJFGD]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7890EE0", Offset = "0x788F8E0", VA = "0x187890EE0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x78910B0", Offset = "0x788FAB0", VA = "0x1878910B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7890E20", Offset = "0x788F820", VA = "0x187890E20", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7890E80", Offset = "0x788F880", VA = "0x187890E80", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7891050", Offset = "0x788FA50", VA = "0x187891050", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7890AE0", Offset = "0x788F4E0", VA = "0x187890AE0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7890B40", Offset = "0x788F540", VA = "0x187890B40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7890BA0", Offset = "0x788F5A0", VA = "0x187890BA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA471F0", VA = "0x180A487F0")]
		public RoomObjectCounts(Dictionary<int, int> NPFILNLEPCD, [Optional] Dictionary<int, int> HLOFNJLNEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7890A00", Offset = "0x788F400", VA = "0x187890A00")]
		[IteratorStateMachine(typeof(ADGCDINCEBN))]
		private IEnumerator<DictionaryEntry> JIJELDJPECK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7891100", Offset = "0x788FB00", VA = "0x187891100", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7890D20", Offset = "0x788F720", VA = "0x187890D20", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7890C00", Offset = "0x788F600", VA = "0x187890C00", Slot = "9")]
		void IDictionary.Add(object NJBPFCDJFGD, object PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7890C60", Offset = "0x788F660", VA = "0x187890C60", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7890CC0", Offset = "0x788F6C0", VA = "0x187890CC0", Slot = "8")]
		bool IDictionary.Contains(object NJBPFCDJFGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7890DC0", Offset = "0x788F7C0", VA = "0x187890DC0", Slot = "14")]
		void IDictionary.Remove(object NJBPFCDJFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7890A80", Offset = "0x788F480", VA = "0x187890A80", Slot = "15")]
		void ICollection.CopyTo(Array NAKGFAINKPB, int DOAKEFBOPIA)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class LJLMLELPFJP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xB9B420", Offset = "0xB99E20", VA = "0x180B9B420", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x788BC30", Offset = "0x788A630", VA = "0x18788BC30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
			[DebuggerHidden]
			public LJLMLELPFJP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x788BAA0", Offset = "0x788A4A0", VA = "0x18788BAA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x788BBE0", Offset = "0x788A5E0", VA = "0x18788BBE0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x788A4A0", Offset = "0x7888EA0", VA = "0x18788A4A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object NJBPFCDJFGD]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x788A370", Offset = "0x7888D70", VA = "0x18788A370", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x788A550", Offset = "0x7888F50", VA = "0x18788A550", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x788A2B0", Offset = "0x7888CB0", VA = "0x18788A2B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x788A310", Offset = "0x7888D10", VA = "0x18788A310", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x788A4F0", Offset = "0x7888EF0", VA = "0x18788A4F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7889F30", Offset = "0x7888930", VA = "0x187889F30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7889F90", Offset = "0x7888990", VA = "0x187889F90", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7889FF0", Offset = "0x78889F0", VA = "0x187889FF0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x268C390", Offset = "0x268AD90", VA = "0x18268C390")]
		public Invention(long ICHIIHCEGJD, int PGJKBFGEJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7889E60", Offset = "0x7888860", VA = "0x187889E60")]
		[IteratorStateMachine(typeof(LJLMLELPFJP))]
		private IEnumerator<DictionaryEntry> JIJELDJPECK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x788A5A0", Offset = "0x7888FA0", VA = "0x18788A5A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x788A170", Offset = "0x7888B70", VA = "0x18788A170", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x788A050", Offset = "0x7888A50", VA = "0x18788A050", Slot = "9")]
		void IDictionary.Add(object NJBPFCDJFGD, object PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x788A0B0", Offset = "0x7888AB0", VA = "0x18788A0B0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x788A110", Offset = "0x7888B10", VA = "0x18788A110", Slot = "8")]
		bool IDictionary.Contains(object NJBPFCDJFGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x788A250", Offset = "0x7888C50", VA = "0x18788A250", Slot = "14")]
		void IDictionary.Remove(object NJBPFCDJFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7889ED0", Offset = "0x78888D0", VA = "0x187889ED0", Slot = "15")]
		void ICollection.CopyTo(Array NAKGFAINKPB, int DOAKEFBOPIA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> OMEFAJNIKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	public readonly IReadOnlyList<Invention> CADFPPJBGIG;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA471F0", VA = "0x180A487F0")]
	public HENKHECBGDD(IReadOnlyDictionary<Guid, RoomObjectCounts> BAMDFHBDPJI, IReadOnlyList<Invention> AJIOPGFEHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7886C10", Offset = "0x7885610", VA = "0x187886C10")]
	public static HENKHECBGDD OGKINODNPLH(ENCFJAGIPBN COLBDAEGKBA)
	{
		return default(HENKHECBGDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7886440", Offset = "0x7884E40", VA = "0x187886440")]
	[CompilerGenerated]
	internal static int ADBBHLIPGME([In] IReadOnlyDictionary<long, int> DPLGOEDJEIG, long? NIFPOEHKIAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7886560", Offset = "0x7884F60", VA = "0x187886560")]
	[CompilerGenerated]
	internal static void LHNMOCJBOOO(int HOHHKJKNGBC, [In] LINCBANILCA EGFMJLFDFDC, [In] Dictionary<long, int> DPLGOEDJEIG, [In] Dictionary<Guid, RoomObjectCounts> BAMDFHBDPJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class DLBHPPFHEAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private readonly PLALJOICCPM IHLPBGCEIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private readonly Dictionary<Guid, IReadOnlyList<Guid>> FDFPCMCNEHL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public PLALJOICCPM IGJPINNJNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7885630", Offset = "0x7884030", VA = "0x187885630")]
	public void HEHCILJMFIP(Guid BIEPOHAFEEC, Guid NANDDACJJDD, IReadOnlyList<Guid> CKPIGHHLPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7885540", Offset = "0x7883F40", VA = "0x187885540")]
	public bool DJKEOAAAAJJ(Guid PIPGIJFLAKP, [Out] IReadOnlyList<Guid> HLBBLKPCDPE, [Out] bool LEBHLBBACDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x78856E0", Offset = "0x78840E0", VA = "0x1878856E0")]
	public DLBHPPFHEAE()
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
