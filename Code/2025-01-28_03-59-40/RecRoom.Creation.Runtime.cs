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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x719C6A0", Offset = "0x719B8A0", VA = "0x18719C6A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KDJLGLGPAGE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> NKCAKGNKBPN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> PHGCPAAAFGM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> LPHOLPDMAHL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> OJKEKKBCKAD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string PAFKAOLLFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string EEHKDNODMNL;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string BAGLEMNMADE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x719AE20", Offset = "0x719A020", VA = "0x18719AE20")]
	public static bool MNIKIEBFFGI(Guid JIGDEHAPMAH, int DABJJJAAOPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x719AD90", Offset = "0x7199F90", VA = "0x18719AD90")]
	public static bool COKCCBCMMPD(Guid JIGDEHAPMAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x719AF20", Offset = "0x719A120", VA = "0x18719AF20")]
	public static string PHBMLAIHLIO(Guid IBPGMNEANFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KBLNFANJMJF]
public enum PIDGCJHJOAC
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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x719C610", Offset = "0x719B810", VA = "0x18719C610", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GPEHNCLCHPP
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid AFMOMGFNLBB;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid JINABAIPEJL;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid AGFLOJJEIMO;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid GLNHFOLKFLB;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid GCCDJMHICNO;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid ELJGLMEDOFI;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid ANOBEJJJENC;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid GOJHDIPFIJP;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid MMNPLNPKEAD;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid HGBAINEFGFC;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid HJJKDGIJDCA;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid GLFKCMIOMIO;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid PICGHFDDKKK;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid GJJIJLPMBIM;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid NADFIMLAPLB;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid EHCBDLJMJCK;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid DPKKLBADLNK;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid FKMJKFMFMJL;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid CGOMLLENJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid KPHFGOGMFCI;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid DFHPANMHLNH;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid KDDNBONBEHE;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid OCDHABCMGNO;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid GMGAAHLIPEK;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid CLAIDCLGNHL;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid PCDJLJHGOHM;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid LNJIMNFIBLC;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid OKHLNKCCKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid PKLGJPLGBNA;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid IPGODCMEDCJ;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid CIDJCDLLPDJ;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid EJCECFNBDMD;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid NJEEHMNPELM;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid LKJDLBHICKI;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid OKDAOCKOKLJ;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HPAKCOOKLJO;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid ONLOOLKLMGK;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid IBMAEDGNAFJ;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid ABDJPJKFBBL;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid LLGLBMMHGOH;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid LFHIPFJILKA;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid PNLOEIHPLMG;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid IJJNGKIBDIH;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid OGIAELAGKKO;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid HJCMPLDLHOA;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid ECDCGFFLCCD;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid MACGGKMMHJB;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid KANNOFFONED;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid DLEJGPJJIFN;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid DNHHMIIPGAA;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid OPFMDJDOKBL;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid NNAJCIEPGKM;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid CPOFMIKFIEB;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid OABLFKMHCJC;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid OKOAOOBJCBE;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid BMEMGKGFLEF;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid BLDJIIKCCFG;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid HPKPKEKOOEJ;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid ONNCIGPFEHD;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid BNCJFFMBBLM;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid AAJNCHDNGJE;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid OMAFHGKGLLP;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid AFHEEAJLKNJ;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid OFGFCJBJAAB;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid FPIMPNBIEDA;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid LNDIBCPBHNO;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid OIFMKOGGGCK;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid LCOFGDNBABO;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid BEIPBOKHHHA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid NEIHAMIMCHH;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid JCFBJEMAOCB;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid MDGAPOOKOGM;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid CLFMMAJIFDC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid CCMDIALLOON;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid IMFPHJIEHKH;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid GLDFOEBOOGI;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid MPPKBGNJHKG;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid IBPHINMPKLD;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid OOFNCMKLDAN;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid IMCPFPKMCME;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid JJHJFKIEKJM;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid BAKLLDIBBPE;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid APEKLGAANNL;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid BJNDLPLOMAA;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid NMKMJMPAOAG;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid GLKBLMBMAOC;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid PDANBCLFBBL;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid FEFHGACPDDH;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid IJCPKBHLNMK;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid FDCEACGPLEA;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid PIJGPBEAFLE;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid FHGFCBJHAMF;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid FBPHGIAMJNE;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid BOGGAEOAGDL;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid HKMOCHJONPI;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid CIJLHNINFEL;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid KEJBBDFCPIK;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid HGDFIGEFJKB;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid HJLCCKFBEGN;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid BBHDAMIMOOM;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid KCHPAIHKCMF;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid HKKIHMKNKOM;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid CFEPCBAEFPJ;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid MFHCLONOIKA;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid OBCEHPFFODA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid HBHNGFBMNIF;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid NINAOCHGJJL;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid NHFDLJFMEOO;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid KAEHLODOOOK;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid PLBONJHMLLE;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid ILLLAJCOLEL;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid KOGDOLCPMGK;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid OAPBLLKEDAN;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid GPILLIBHGPA;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid MHPDODKEBEC;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid ADEKAIGLNBD;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid EPFNDJJCBKL;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid EKEKIKIHAHH;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid EGGJLJOGKJP;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid AKOELJGGKHJ;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid GDGFGBFCKMB;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid AHHDKBDJALN;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid EFPEMNKMLGH;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid HKIIGFNLMLH;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid OIPNMCEIHKL;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid HAILGNEKABI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid ILNKHGKICAI;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid HGIIOGKFDJE;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid EDHEFHOINIH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid ADBIPHBFLCC;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid BNHKJAHNMJH;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid JKEGOCIMMKP;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid AIBDNIJMFPE;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid KOGPCBDHJEO;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid AGHALHCNKBB;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid CGFMDDKHLFF;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid MJIGIIACIIB;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid HDDBDIHGIHE;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid OPEKHKJDDCG;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid EIEKAKKPANF;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid MNOGCLPLPNF;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid OABGGLKCDFE;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid MIJNHEEDDBM;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid JGNIAOEENLG;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid IFIOFAPGDDK;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid KCBAPNCJFNI;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid HGNMMLKHGBA;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid LFFEEJLFCJD;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid NHBIEGEOPJI;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid EDBADCMBDFA;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid BBNKHMJDAIP;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid OIEIHODCJFI;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid IOIHMJKNHNA;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid MLBJIGHBEFA;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid KFJBLDNMAHH;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid FFHPPKODNIE;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid LAILMJEGJJP;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JEJJALCOCHE;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid OIMMMOCAAFA;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid HEGDAFFGAEN;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid OMPHJDAHMMI;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid OPCAADPBCNE;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid CMPEILFIMPE;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid MDKNBNCCIGD;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid KHPBCNHCGCH;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid CLNNHNHNEOG;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid LLCDBNEGGLE;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid PBNCLKOEKPN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid DPKACMKGCMA;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid POOGAJJCJFA;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid BHAEDGJOGFP;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid LOOFFGMMNOG;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid FCHCHBBGJCA;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid IGDFBDFILGK;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid KNPLCDFFBID;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid FDGOLFPLPMO;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid DDCBKAHFALL;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid FPCEHPBAMMG;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid BCCEAGANDPE;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid AMDLJBKONKP;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid MCLPOFENMLC;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid DMGIEHDJPDH;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid LPHDAEKAHJC;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid OPOMIAOCNNA;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid GMPHBFOIEGL;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid EMOFCELNEGN;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid BHDNCGHIHON;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid EIAOLIMADFJ;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid ODJAADAIPPG;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid MNBPGNDHCLD;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid OGDFCBJHPMB;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid BMGKDCGMKAL;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid CCBCNGAKACB;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid PJAJJGMMLHF;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid IOHBBNNKPIC;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid MHJLHIEHLCL;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid DPEAJEDKNBN;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid BEKMOEFAGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid KEKANCPFFNJ;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid HDFJGIBJMNC;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid HIKEOMKOAOB;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid IGEBBCLKHDL;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid MDGNBBNNLLG;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid NMOJDCDHCOD;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid COHLLICNCCK;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid IPBBDPNGJLA;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid BJPLEGDHFIE;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid JCEAJMEJMOL;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid OKHPAGFKHCM;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid EIPADDNFKJB;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid EDODPEKJDHM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid HFDEOAJPCBD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid JKNDCMPGMJN;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid MHMHBDFKOOH;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid FAIBKAGCBLG;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid LGLOBOMIBKK;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid DPODPMEANDI;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid BMOPIOECFJB;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid FHOGCBHNCIB;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid ODIEFBDMJOC;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid MDPIFIONEDK;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid DHDJFAFNHBB;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid KNEDIHFILCC;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid BLJACDMFMGC;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid FHEPCCNFNPP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid ONDAGGOENKG;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid IJPDABLEKHC;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid HNPLBGJGIKA;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid JMLEPNHNPPE;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid HDCDFMOADAK;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid MKCJEJHDNHH;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid BBGJMJJAPAI;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid EGLKPBLCIDL;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid CBNDMHCGNJH;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid CCFMOIOEKIO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid ALOGJLNGIEK;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid FBOFEKHBLHN;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid JINKFOFBBOL;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid GFIBMHIDAGM;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid LOCACMBICDD;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid CGFHBOPDGNB;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid PBANNIKPKNP;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid AODINLFHLKI;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid OMIMOKHKMJI;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid CNLBJLGFBGM;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid HHKCEFLJIEG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid AGIGOOLMHIM;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid IODGBMPIMGE;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid EFKKBLILNLJ;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid CCKACFCPDBE;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid GOBDKJNFPBC;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid HNNGGFHNHKN;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid KPCMGAKAJFA;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid CEDHOFFKGNA;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid HBHGOCCOMAB;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid HDCKDCNAMGF;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid MLGIINGKDMI;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid LMMNDODJFEI;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid JMLNAKEIDKA;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid CODONEBAJJB;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid ACBAGPLGDGL;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid BGNAEDBFPCK;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid PACKBJGHMBH;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid KCNLLMCMNLL;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid KHFHIBJPNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid ODBALKOJHGD;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid FOBFEFCIHNK;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid JHLDNDANOLA;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid OJAFINFIDME;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid EMBKLMOOPOL;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid CGHELAIEOFC;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid FFMJJIMAKOG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid PNAADKLMGPB;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid EBMMCPMBFMK;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid EAJKLGJEPMN;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid GKAJJOKGEGD;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid GCBJFPEAPJF;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid BJHAHONIIED;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid CGGHCCFJLAK;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid KIIKFCIGNPP;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid PIHKLGPICEB;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid KPNFHIPFCFF;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid EPFKAHLFAKP;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid OIFBOHFHCDE;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid OHNKLAPEJGA;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid DPMOMCOCMON;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid GPMLKJAIIMB;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid JBJGGHACBEB;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid EIDACBAPNPD;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid LCLNHMFDLBK;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid BCOHLDKLLPG;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid NLJHOCDEMEE;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid JFNECIJJGOI;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid AOLAGGGKEGI;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid IGIGMMAHIPG;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid IJKOLDBCHAI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid BHFLIDHDJEN;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid OKHMDPIAFJE;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid CJNLCMCGCCB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid HACDMMDGHJK;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid KHGNIDKLKCC;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid NCHHAAAKGHC;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid IONEJLECHCO;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid DABIMOJKMCM;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid DPMPOOAFDLC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid MNGEBMOCKBD;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid CLOMDACJELP;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid LGNNPCHLGEH;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid HLACCFKNNMO;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid AKPCIIDGDEK;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid IOPJNNGOOJF;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid JLJICANMCLJ;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid OBHAEMJIDCI;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid DLPPJIOOEIA;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid GEIDHCBHJHG;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid ELBPGNGJDKB;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid MOPGDOOIGGA;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid GMNFGMBKHFP;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid BAEBHDOPFIH;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid KDIDPHHLNBF;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid IDHIIONBBPA;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid EOAPAELAKGH;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid FLNMLBEBLEG;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid JCCLPENIMAP;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid LCDCOJLLJGC;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid IKAPJKDPPII;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid JKNLBFBEEOE;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid DPFEIAPEAJF;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid MGPKIJILEOH;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid BPAPFGAKHLA;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid OPAOJBKCFEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid JEFNEKHJAHN;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid DKOBGIDNKCJ;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid LFIBBPFAMHC;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid NOKCNPOCAHI;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid CEHIFAOPIEF;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid IJIOAJPMICJ;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid OBHKDIALEEC;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid DEKNGANDFIL;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid PCOPDEGFKDP;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid HKDMMPBDAPM;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid DLKIMBFMLOJ;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid POKJGLKPDOJ;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid CDKNDHDELAE;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid DEOMAIKIODA;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid OIEPHNCGKLO;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid FJIBMMOPPKD;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid ACKFDACAKKK;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid BKKEDGJLHEE;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid DIBPGENAENK;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid MEBAMLCFFMH;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid EFICMDMDBOM;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FGPOALLJCOH;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid BLFCMPNNLPJ;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid CFMFPCDOMMI;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid CPDKELCGECJ;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid EBNAHEKPKCA;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OKHKOIAHBNL;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid FLKDAKFFNOB;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid AFBGLLNBFGB;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid MLHAAGHLCLB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid BBPNOIBEEEK;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid IBMEKPLGHCN;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid KEDNCFJBEFB;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid OABLIANOOAB;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EFKLPCGMBAH;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid BLDJCMICKHD;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid LKDAMCOEJGP;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid KKPFFHLFJIM;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid KECLMNGAOFL;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid FNODGCACNFA;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid BLLPKLMLLCM;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid IBEAJLGOCBJ;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid GALHPPJLNJF;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid PIJIDLMNEOB;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid MOAAOCKMJON;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid ECKCDHEAAJD;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BBMNGOFNECJ;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid FBKFFMIGOAP;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid PBFFHGCCAHP;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid JGEHEAPCJIP;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid DKDJMCFNFOA;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid CFDGJMIEFFL;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid BKJCHMCIMKE;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid JBBBJEHFKAP;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid BBKFIPJLPHB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid EFMAMHBKDGB;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid PEJIGFIBFMG;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid FJIAIPJMEMK;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid OPFIHEMPKHF;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid DMBHPOONJEH;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid MOLHLNFFAOD;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid BOPKGPMINFO;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid MELNJAMPPJI;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid HKJAOFJODEB;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid DFNPFBBKGPO;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid KANIELNJPPM;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid IMNKKOJIEEH;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid GCGFECLNDEM;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid EHNMAPFBIHM;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid FJNICHFFADJ;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid AEKOKNDBFOC;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid HPGLLHLMDNI;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid MIHKGPFPIBG;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid ENNMDJIPKDD;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid PLLLFEBFDOD;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid AOGDEPHKNEB;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid GIJALPIHCBD;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid DJHAKBFGMKA;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid EEPAEDALIEA;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BMIIBNAHCLF;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid AFIIFHEMCNM;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid EDGJLCIMFOI;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid OBGGKNIIFPP;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid LOHILKGEOFN;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid FONPLKADMOH;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid KKDMOBLBEEM;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid BHKDHLCOBDG;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid MMNDIDPFPGG;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid LLDKFDCKNJI;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GJEOIIHJOIA;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid JJLPBCPPKBD;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid PBLOKDBCAKD;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid BOCOIJCOADE;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid ABAPEJOKONG;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid GIKIHLBIFPF;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid ANNGKCEDKJD;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EPHFOHIMIDL;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid JJBKMNEEGKM;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid FMMIFKMDOHK;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid NGAOBLJPBBP;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid BKPOJBDNHOD;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid PCBPPCEOLOL;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid IIMPDCIPJAH;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid DDJEOMDGICN;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid DLDCJKFELEN;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid EFJPKDJNFDI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid NKJDAHFEFCI;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid DGBPAMJEGKM;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid MABJJAANNMD;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid KJOPPJJPMIB;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid JCHNBLEBBMM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid EEMIBIEEOPG;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid ILJGLFKHLDE;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid LCPNHIDAAJO;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid GKJLFBDCHBH;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid GKBBJLIEMJL;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid FKJOKIGIOFC;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid KFIEPKNEIAB;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid OPKFGOBCLLJ;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid CAONEPCCHAK;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid DHAJNDJKPFM;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid HLCMEBIJEHL;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid HFPOPNDKHDM;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid NEFJPAMAFMO;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid MMGDEKNFPGK;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid CIGCGGBFCMJ;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid FGMNAONNFNA;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid FONHFMHFAKF;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid INKPNNCJEIN;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid GGANJFGNHFK;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid CNKJCDKJBCC;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MCHAJCFKNDK;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid AECFDNGCMJI;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid NELEGACCHLL;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid DNEOAONLKIH;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid EIKFDAKJPFH;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid CCEMJEAFJLG;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid PIAIGGGEGNC;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid JJFEHEGMIBB;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid KNJLMNEIEDD;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid LGBKDPKALAP;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid MGNGFNMGDLJ;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid HLNHDBPDMPE;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid HOCHFOCAADF;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid AMHKCJDOEJA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid KPGEOPFAEME;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid MCNAMOJAIKD;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid ECHFIIMIOFI;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid GMIOPANBJBE;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid KPKFGPKKACO;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid IBDBBABECEI;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid NOAJOPMABMI;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid BAJFECOCBFM;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid HOICLGMKGDE;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LHOGACNMBNI;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid BBNGPMJLDLL;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid MGFLMABFPLM;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid IDLECPEDGCK;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid DNHBGBEAAEN;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid EHOJBHMDLAE;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid EMHNCNNIGMO;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid JBDCMCBLPDB;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid FPDCEKAOBHH;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid BMCFDKENJAI;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid BJDOFCBIILI;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid AEFCBDMOODE;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid FBOIACONOAI;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid AHMEGNGCIDE;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid PKFHLHNLNLE;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid KLDILAADDBF;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid NNPLNLJJBKL;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid JBOIHBDPKOC;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid LJKEOEMNAGE;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid CHNJMDBHAEI;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid GNPHDDMAEPO;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid HPEJEBDPMNE;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FFMHCKJLGAI;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid CFDJHCAJIJB;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid IPCFIDKCAHD;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid LKHBLNEBOIN;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid APNNEPJNKKE;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid GOIAMECLMME;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid HDEGJGDLJPC;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid NANONNIDJAC;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid OOPCHACFIHM;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid MHOPJFGBOGG;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid DCHKNFLNMAL;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid DABLNFBANEN;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid BLFAKFKOKGG;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid DGMOFLAOIGA;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid CPONMBCAHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid FDNDPKDMJKF;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid JCOFMNPGAPO;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid JFCEFMLEOJC;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid FPOGLINANAJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid NPJBJAEEBEP;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid EEGBMIJLCFA;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid KENMGPKKGAI;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid DNOKEBOLNOA;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid KHGPKGFNKFH;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid FDKJBIIFHHG;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid APAIBLDHDHM;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid NPPKDKJEKGA;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid NAOGFCMGHLI;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid EIMNAGGBADA;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid MOPGLFCMPAL;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid IPDNMIMBDJP;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid AFLHKGFKNBP;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid KBFLCNFBOCK;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid HCKJGHOPKFM;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid LHBJBJINFMH;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid HLMGBAPFAEP;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid PFPDCGHKJGO;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid OEENAODEMDB;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid CLODOLNBDBA;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid OELIBGAGIGL;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid DIFGMPJMLEN;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid ODLCOMLKAPF;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid BHDDOMLGLKF;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid NLDGADJBBGO;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid MKPADOBEAPE;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid DIIEDJFALIF;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid IEAGGGOCPAP;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid DBAOJNPLPEL;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid EBLCPPLABCD;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid IBFDPDGMAJH;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid NJLFDAPAAEM;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid KMDIMGPIPHN;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid MFOMELOFEGH;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid FPPEFPIBJAA;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid EPNOGDFACED;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid PICKOELDAJE;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid LMBAFHAIFNB;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid LKFAHFJMIHG;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid PPONLNIMFHF;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid OIDGCGIDIJE;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid CCCOKHGMCDL;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid LIGHCFMAJLD;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid KPADEDIEBCO;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid FNMDMFHCMHE;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid NJGDDFAAJNP;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid PIIHFJOEBCL;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid NGPGDFKOIPG;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid KJNLJDAGMDB;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid GCOBJJONDEA;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid BHBHDPEPGFK;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid PBHJHNFFKOL;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid MMEEMOJEGDL;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid IKPKEIMGKPK;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid MKKMONNEIDB;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid FICJNPGKEAM;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid DDAIENFGMEI;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid MEPJGJGGKJO;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid JKOKPEMPADD;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid GGGIJGPAGIB;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid GEEOOGBJOLK;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid JIDMOCCHLAG;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid HBJKHGEBHBO;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid MICELKOJIHJ;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid EKEPPDBIJCA;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid HHIMODJKHCH;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid EOMIIKFIPIK;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid ENBOHPNBFJC;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid DNFKHOLJFCD;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid GICBAIFIMBM;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid EOKPDPCNOPF;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid FBPMPONJKLF;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid DBGNLBEBDLO;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid ODBFAPEPBHA;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid HJGHCHNKIEG;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid BLDCENDAAAD;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid DCDAJIGABJD;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid FGPPIHGBEKJ;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid GDNIODCKDLG;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid JOOALGPFDLJ;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid PGLOLFIJMDG;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid HCFDOPFDAOK;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid GGFFJKCPICB;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid OCAJCKEPNGC;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid BEACDDHDFLM;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid IPPABHPACIA;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid PADDICDEBCH;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid EAIPHPBOPKG;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid EPPJODBHALL;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid IIAGOAKBDIO;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid FPHKECDIKGK;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid GEFLLMDCNEA;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid APOCGFEPNKJ;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid OKLOJLICFLH;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid ILPKAALJNKC;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid MBIJJFCBOAK;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid KIDHLHJHBOJ;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid IMIGDPLHNBC;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid HGKPDDHOGIE;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid DHLDLCFICBB;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, PIDGCJHJOAC> DCPAJCJKHJB;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<PIDGCJHJOAC, Guid> LMOKCKJHNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, PIDGCJHJOAC> KEMFEKCPPOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71949F0", Offset = "0x7193BF0", VA = "0x1871949F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<PIDGCJHJOAC, Guid> EMDOPHDCNCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7194A50", Offset = "0x7193C50", VA = "0x187194A50")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BNCIGPAPJJM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7193D70", Offset = "0x7192F70", VA = "0x187193D70")]
	public static bool IMHOHPDCKBC(HLEMJAHOFMA OHNEHMAOBDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x71939C0", Offset = "0x7192BC0", VA = "0x1871939C0")]
	private static bool IMHOHPDCKBC(AFIEKEBJKEP HLMPJHIDIOP, HLEMJAHOFMA OHNEHMAOBDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct CFMEHCFKCDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly ALBLMFHGEEB DKNGFKGLAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<INLFGDDOIPN> GILPMNKPIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<INLFGDDOIPN> GJEPHDJLIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly ANHNAJIBLBK<KJENBNHGDMG> FKPMJAEHPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<BDPEADCNJIF<COBLBOLGAKJ>> NBLEJKLFCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString BDOBLIDPDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly AOHBAKFOKKA DLALHOJJGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool PCFMKJODEFJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7193E10", Offset = "0x7193010", VA = "0x187193E10")]
	public CFMEHCFKCDL(ALBLMFHGEEB BBPIJCGBGOH, IEnumerable<INLFGDDOIPN> HENCMBBFEOD, IReadOnlyList<INLFGDDOIPN> JMKKJPIKDPJ, ANHNAJIBLBK<KJENBNHGDMG> EBGABJEGGHF, IReadOnlyList<BDPEADCNJIF<COBLBOLGAKJ>> ELIJFMOELCK, ByteString JDAKABLNFAJ, AOHBAKFOKKA EHNHCHLCCLA, bool GLGHCAEEGMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JFEGDOFCLIC
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(IMAOIIMIJJD LFDKFEEPNFP, [Out] Dictionary<int, int> PNHJCMAFPPC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(IDAGJOOOCKM ILBOMLIKIKG, BCNLMICCAGD EJFKBJBLBMH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GLNMFKJLHPO : KCPJIHCMNEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid FKLDGAPJLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> LACCJEJFCJN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> NAHNKKOKHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x431B610", Offset = "0x431A810", VA = "0x18431B610")]
	private GLNMFKJLHPO([In] Guid MLOOIDBFKIA, Dictionary<Guid, Guid> MPAEEMHFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7194960", Offset = "0x7193B60", VA = "0x187194960")]
	public static GLNMFKJLHPO PAJOIGLPBMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7194250", Offset = "0x7193450", VA = "0x187194250")]
	public static GLNMFKJLHPO GEFDIGBKCFI(IReadOnlyDictionary<Guid, Guid> PDGPCEMHABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x71943C0", Offset = "0x71935C0", VA = "0x1871943C0")]
	public static GLNMFKJLHPO IKAIHOFDGMP(IEnumerable<KeyValuePair<Guid, Guid>> PDGPCEMHABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x71941A0", Offset = "0x71933A0", VA = "0x1871941A0")]
	private static Dictionary<Guid, Guid> CENGEGLDHHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x71946E0", Offset = "0x71938E0", VA = "0x1871946E0")]
	public void MICCOCPKGBE(IReadOnlyDictionary<Guid, Guid> PDGPCEMHABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7194260", Offset = "0x7193460", VA = "0x187194260")]
	public Guid HIHMIIAOMPD([In] Guid IBPGMNEANFH, bool HACGJBDLONH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7194130", Offset = "0x7193330", VA = "0x187194130")]
	public bool JGHOIIDNOFK([In] Guid BEHEHKFONGA, [Out] Guid MEIDLKNNJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7194130", Offset = "0x7193330", VA = "0x187194130", Slot = "4")]
	private bool ACKBCLPGFDL(Guid BGKIOALJNDJ, [Out] Guid GGHDHEDBJLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EGIMLKLJGPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MEJCLCCDGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAEIJKNHIPI(ByteString IBMGILDHNGE, GLNMFKJLHPO BEBHEGILPLH, [In] UniformTRS GMJEJCPJGHO, Space KLCCJGCDOCN = Space.World);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HEFJFDDOKKF
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
public sealed class PFEHKOOCFED
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BNCIOGADCKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public ALBLMFHGEEB staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BNCIOGADCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7193DA0", Offset = "0x7192FA0", VA = "0x187193DA0")]
		internal ANHNAJIBLBK<KGOBMFADMHP> BJCPDMJMBKF((ANHNAJIBLBK<KJENBNHGDMG> GraphId, ANHNAJIBLBK<COBLBOLGAKJ> NodeId) i)
		{
			return default(ANHNAJIBLBK<KGOBMFADMHP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private static readonly PIGMDFNHJOI<KGOBMFADMHP, int?> CBFHDGOPJCE;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private static readonly long NABDFDFGBPA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x719C970", Offset = "0x719BB70", VA = "0x18719C970")]
	public static (long, long) HMACNLNHBBM(ALBLMFHGEEB PBIHLCBAANL, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x719C840", Offset = "0x719BA40", VA = "0x18719C840")]
	public static long FBKFPJPOIJE([In] ReadOnlySpan<ANHNAJIBLBK<KGOBMFADMHP>> EHPIJDKEGIH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x719C720", Offset = "0x719B920", VA = "0x18719C720")]
	private static long DANDKAHFLCD()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BLIOKIBNKLJ
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<PIDGCJHJOAC> INEHHICMJEN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ILBABAEOCHK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> JDHKFPBEPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> NJMBEMMCLME
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
	public ILBABAEOCHK(IReadOnlyDictionary<Guid, Guid> DPFDFKGJDGJ, IReadOnlyDictionary<Guid, Guid> EJNBBBHBPMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ICCLCGLFOJO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HGAAJFJEKCO : IEnumerable<INLFGDDOIPN>, IEnumerable, IEnumerator<INLFGDDOIPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private INLFGDDOIPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private HFFMBPMKFCK spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public HFFMBPMKFCK <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private ICBGPAFMEGB spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public ICBGPAFMEGB <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private INLFGDDOIPN System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public HGAAJFJEKCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7194AB0", Offset = "0x7193CB0", VA = "0x187194AB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7194D60", Offset = "0x7193F60", VA = "0x187194D60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7194BC0", Offset = "0x7193DC0", VA = "0x187194BC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<INLFGDDOIPN> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7194BC0", Offset = "0x7193DC0", VA = "0x187194BC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x71950E0", Offset = "0x71942E0", VA = "0x1871950E0")]
	public static HFFMBPMKFCK CBECFJBGOFK([In] CFMEHCFKCDL IOGPLELGGDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7197890", Offset = "0x7196A90", VA = "0x187197890")]
	private static void KAGAIMIEPGD(HFFMBPMKFCK DKJABFPOANO, [In] CFMEHCFKCDL GLOGKJANNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7195800", Offset = "0x7194A00", VA = "0x187195800")]
	public static EBOICGKKPAM<ILBABAEOCHK, GCOKNJGEKHD> HCDOGNNBEAI(HFFMBPMKFCK DKJABFPOANO, ICBGPAFMEGB LNELDGGAGKO, GLNMFKJLHPO? JCELMHNJOGH)
	{
		return default(EBOICGKKPAM<ILBABAEOCHK, GCOKNJGEKHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7195700", Offset = "0x7194900", VA = "0x187195700")]
	[IteratorStateMachine(typeof(HGAAJFJEKCO))]
	private static IEnumerable<INLFGDDOIPN> FCMABBBLBPK(HFFMBPMKFCK DKJABFPOANO, ICBGPAFMEGB LNELDGGAGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7197F90", Offset = "0x7197190", VA = "0x187197F90")]
	private static void NEAKJOCKAPD(HFFMBPMKFCK DKJABFPOANO, GLNMFKJLHPO? JCELMHNJOGH, ICBGPAFMEGB LNELDGGAGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7198510", Offset = "0x7197710", VA = "0x187198510")]
	private static void PDAPMDCAPGB(HFFMBPMKFCK DKJABFPOANO, ICBGPAFMEGB LNELDGGAGKO, IReadOnlyCollection<ByteString>? NAHPJPHGPIM, IReadOnlyCollection<ByteString>? MKNGMJAMHFO, IReadOnlyCollection<ByteString>? HANJAHEJMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7197200", Offset = "0x7196400", VA = "0x187197200")]
	private static bool JGPGCOANDEJ(HFFMBPMKFCK DKJABFPOANO, IDAGJOOOCKM ILBOMLIKIKG, ICBGPAFMEGB LNELDGGAGKO, [Out][NotNullWhen(false)] string? GILNIHGCEJO, [Out] Dictionary<int, int> PNHJCMAFPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7194E00", Offset = "0x7194000", VA = "0x187194E00")]
	private static Dictionary<Guid, AFIEKEBJKEP> BOPNNDPBIIA(HFFMBPMKFCK DKJABFPOANO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7197EF0", Offset = "0x71970F0", VA = "0x187197EF0")]
	private static void LDLEHBJGLOC(bool ANNGLNBKOCN, INLFGDDOIPN HMHIBHFIJPG, Dictionary<Guid, Guid> CAODNFKMPAG, GLNMFKJLHPO JCELMHNJOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x71981D0", Offset = "0x71973D0", VA = "0x1871981D0")]
	private static void NGBCGCDMENH(INLFGDDOIPN HMHIBHFIJPG, Guid FIIDDOPMGLB, AJGNDAPNNGK? FHICJBMNNHG, Dictionary<Guid, AFIEKEBJKEP> HMEBOOPCOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7195250", Offset = "0x7194450", VA = "0x187195250")]
	private static void DBLHGJJKBPG(IEnumerable<INLFGDDOIPN> PJBANLGAFDM, IReadOnlyCollection<ByteString> NAHPJPHGPIM, IReadOnlyCollection<ByteString> MKNGMJAMHFO, IReadOnlyCollection<ByteString> HANJAHEJMEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ICBGPAFMEGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public bool ANNGLNBKOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public AOHBAKFOKKA EHNHCHLCCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public AJGNDAPNNGK? FHICJBMNNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public AJGNDAPNNGK? MNKNAOMGCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public ALBLMFHGEEB NBJGGNBPBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public HEFJFDDOKKF JGADJGHGCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public JFEGDOFCLIC LLNGPBKCIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public EGIMLKLJGPA BBMPKCOBGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public BDPEADCNJIF<KJENBNHGDMG> ALMMNANMBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public DNEKCIMOOPN JMANFDHIJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public List<INLFGDDOIPN> EJAFMKBGHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public Dictionary<string, object> LFJHKLOMDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public AMIDIPMAKKM KNBKKPFEFHG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JHPAIOLJHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7194DB0", Offset = "0x7193FB0", VA = "0x187194DB0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AJGNDAPNNGK
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private const float NOBFCMIABKD = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Vector3 FCKJMOMOHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Quaternion EGIHDGHICMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public float KGBNKPFPEFM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Matrix4x4 HIHDKANPBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71934D0", Offset = "0x71926D0", VA = "0x1871934D0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public UniformTRS EJOFELAFOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7192F90", Offset = "0x7192190", VA = "0x187192F90")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1198240", Offset = "0x1197440", VA = "0x181198240")]
	public AJGNDAPNNGK(Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, float KGBNKPFPEFM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71936E0", Offset = "0x71928E0", VA = "0x1871936E0")]
	public AJGNDAPNNGK(UniformTRS AFFHJOGELLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7193250", Offset = "0x7192450", VA = "0x187193250")]
	public static AJGNDAPNNGK LPDJMDIAEAI(AJGNDAPNNGK DBEHKFODEEL, AJGNDAPNNGK LABKDPCAHPD)
	{
		return default(AJGNDAPNNGK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7193230", Offset = "0x7192430", VA = "0x187193230")]
	public static AJGNDAPNNGK KEDBNOKLEHE((Vector3, Quaternion, float) LFDKFEEPNFP)
	{
		return default(AJGNDAPNNGK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71930B0", Offset = "0x71922B0", VA = "0x1871930B0")]
	public static AJGNDAPNNGK KEDBNOKLEHE(Matrix4x4 MMFPHBHJGPG)
	{
		return default(AJGNDAPNNGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7193650", Offset = "0x7192850", VA = "0x187193650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7192FD0", Offset = "0x71921D0", VA = "0x187192FD0")]
	public AJGNDAPNNGK FGHAPIAIFKA(Matrix4x4 MCPAEAAAAAM)
	{
		return default(AJGNDAPNNGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x71935E0", Offset = "0x71927E0", VA = "0x1871935E0")]
	public static AJGNDAPNNGK PAIONLONMPH(Vector3 FCKJMOMOHAE)
	{
		return default(AJGNDAPNNGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7192F00", Offset = "0x7192100", VA = "0x187192F00")]
	public readonly PDAHHPHGJBJ DIIONNDAAGD()
	{
		return default(PDAHHPHGJBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum PHBBCJJJBMB
{
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct GCOKNJGEKHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly GGBBAPNLOHD BGMNFNIOAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private readonly MNCKOMAJMKB IIDLCGGAALH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x140D3B0", Offset = "0x140C5B0", VA = "0x18140D3B0")]
	private GCOKNJGEKHD(GGBBAPNLOHD BGJHPMCGJDB, MNCKOMAJMKB FMJCBEONGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7193EA0", Offset = "0x71930A0", VA = "0x187193EA0")]
	public CKNADPBHIII OJDLEFKEIDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7194080", Offset = "0x7193280", VA = "0x187194080")]
	public static EBOICGKKPAM<ILBABAEOCHK, GCOKNJGEKHD> PAJOIGLPBMN(DMLGANIFPBB<HEGEDEFNLEJ> FMJCBEONGKO)
	{
		return default(EBOICGKKPAM<ILBABAEOCHK, GCOKNJGEKHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7193F10", Offset = "0x7193110", VA = "0x187193F10")]
	public static EBOICGKKPAM<ILBABAEOCHK, GCOKNJGEKHD> PAJOIGLPBMN(CKNADPBHIII FMJCBEONGKO)
	{
		return default(EBOICGKKPAM<ILBABAEOCHK, GCOKNJGEKHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7193FC0", Offset = "0x71931C0", VA = "0x187193FC0")]
	public static EBOICGKKPAM<ILBABAEOCHK, GCOKNJGEKHD> PAJOIGLPBMN(string FDHNIFPBPGL)
	{
		return default(EBOICGKKPAM<ILBABAEOCHK, GCOKNJGEKHD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum GGBBAPNLOHD
{
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JGCPDHAOFEP : IDisposable, CEJNEKCLMGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private NativeList<CHNNPJCIGPE> DMPLILNJAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private float AIIJLENCKPI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GCEHINAIMFJ DBHPKMFMDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0")]
		[CompilerGenerated]
		get
		{
			return default(GCEHINAIMFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8FEBC0", Offset = "0x8FDDC0", VA = "0x1808FEBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool KDJPKPNPCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x719AAE0", Offset = "0x7199CE0", VA = "0x18719AAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool HPLJBDFFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7199950", Offset = "0x7198B50", VA = "0x187199950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public List<POKJLLHBIBP> OGPFHEMDIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BMLCPCDBDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x719A940", Offset = "0x7199B40", VA = "0x18719A940", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float KNDKKIHNOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7199B50", Offset = "0x7198D50", VA = "0x187199B50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x719AD00", Offset = "0x7199F00", VA = "0x18719AD00")]
	public JGCPDHAOFEP(GCEHINAIMFJ HPIEALDMKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7198D60", Offset = "0x7197F60", VA = "0x187198D60", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7198740", Offset = "0x7197940", VA = "0x187198740")]
	public Vector3 CHFJKDOBBFH(int ODMGJHMGBIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x71996B0", Offset = "0x71988B0", VA = "0x1871996B0", Slot = "6")]
	public Quaternion FKOHIEFJEJL(int ODMGJHMGBIJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7199850", Offset = "0x7198A50", VA = "0x187199850", Slot = "5")]
	public Vector3 GPEGFDEOPBM(int ODMGJHMGBIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x719ACA0", Offset = "0x7199EA0", VA = "0x18719ACA0", Slot = "7")]
	public float PIJDBJIFDEL(int ODMGJHMGBIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7198DC0", Offset = "0x7197FC0", VA = "0x187198DC0")]
	public void EKCHGFGPAHL(Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, float COBBNHPDFBH, bool AEGNIMIPPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x71998F0", Offset = "0x7198AF0", VA = "0x1871998F0")]
	private bool IFDFJLMPONL(int IMDINGNMFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x719A980", Offset = "0x7199B80", VA = "0x18719A980")]
	public void NGMFEIHAEJA(Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, float COBBNHPDFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7199AC0", Offset = "0x7198CC0", VA = "0x187199AC0")]
	public void JFCFINLLOJG(int IMDINGNMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7198C10", Offset = "0x7197E10", VA = "0x187198C10")]
	public void DHGIFOPCKIA(int IMDINGNMFKE, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, float COBBNHPDFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x719AAF0", Offset = "0x7199CF0", VA = "0x18719AAF0")]
	public void PADGOGKOABK(int IMDINGNMFKE, float3 FCKJMOMOHAE, quaternion EGIHDGHICMO, float COBBNHPDFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7198580", Offset = "0x7197780", VA = "0x187198580")]
	public void AELCPLNNBAN(int IMDINGNMFKE, Vector3 FCKJMOMOHAE, float COBBNHPDFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7199960", Offset = "0x7198B60", VA = "0x187199960")]
	public void JCKOPNPOGHL(int IMDINGNMFKE, Vector3 LAOLFCMCDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7199C90", Offset = "0x7198E90", VA = "0x187199C90")]
	public static Quaternion MIAEHPCNMPM(Quaternion EBCDHKCKBJF, int IMDINGNMFKE, float KFCOHFHJJKK, CEJNEKCLMGD FJHGHPCGFNP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x719A4A0", Offset = "0x71996A0", VA = "0x18719A4A0")]
	public Bounds NCCNKKNBOBD(Transform MCPAEAAAAAM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x71986D0", Offset = "0x71978D0", VA = "0x1871986D0", Slot = "10")]
	public virtual void BNPONNLOLCP(bool MBKJKCJOPAE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7199780", Offset = "0x7198980", VA = "0x187199780")]
	public NativeList<CHNNPJCIGPE> GKDCNNJHEIG(float BFMBHJGHBHF = 1f)
	{
		return default(NativeList<CHNNPJCIGPE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct POKJLLHBIBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public float3 FJKLEJNIMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public float LCLNBBEBIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public quaternion HOCMNPBBFHF;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x71B0920", Offset = "0x71AFB20", VA = "0x1871B0920")]
	public POKJLLHBIBP(Vector3 DLAJPPBHBJG, Quaternion EBCDHKCKBJF, float COBBNHPDFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x71B0570", Offset = "0x71AF770", VA = "0x1871B0570")]
	public Quaternion JINGBADJEGA(Vector3 BDIPLNMOFCC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x71B0630", Offset = "0x71AF830", VA = "0x1871B0630")]
	public POKJLLHBIBP KNADFLPJFKF(Vector3 HPABIGJHBAP, Vector3 FLDBGBFOAHM, Vector3 HKHBCPEAGBD)
	{
		return default(POKJLLHBIBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71B03D0", Offset = "0x71AF5D0", VA = "0x1871B03D0")]
	public GKELNODACJA EOLEMNAICEA(Vector3 BDIPLNMOFCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class NKOAKICEFEI : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x71AFDB0", Offset = "0x71AEFB0", VA = "0x1871AFDB0", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x71AF560", Offset = "0x71AE760", VA = "0x1871AF560")]
	private void KGIDNNIJEHJ(Dictionary<Guid, Guid> MOHCKKCAMJN, CMLIMJLPJOI OKFFLPOJHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x71AF500", Offset = "0x71AE700", VA = "0x1871AF500")]
	private void KGIDNNIJEHJ(Dictionary<Guid, Guid> MOHCKKCAMJN, EBEIEGFACDP MHPIJECCGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x71AFB30", Offset = "0x71AED30", VA = "0x1871AFB30")]
	private void KGIDNNIJEHJ(Dictionary<Guid, Guid> MOHCKKCAMJN, MNAKKECCIAI KJFDLABMLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public NKOAKICEFEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class JFKBAGIIHAL : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71AC740", Offset = "0x71AB940", VA = "0x1871AC740", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public JFKBAGIIHAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class AGACFNFJGPJ : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x71A9E80", Offset = "0x71A9080", VA = "0x1871A9E80", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public AGACFNFJGPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class CADKJDLAEDM : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x71A9FE0", Offset = "0x71A91E0", VA = "0x1871A9FE0", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public CADKJDLAEDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class KGLNHGAIFBK : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x71AC7F0", Offset = "0x71AB9F0", VA = "0x1871AC7F0", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public KGLNHGAIFBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class JDOLEKOLOMC : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x71AC600", Offset = "0x71AB800", VA = "0x1871AC600", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public JDOLEKOLOMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HNGKGCGPJMN : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x71AA960", Offset = "0x71A9B60", VA = "0x1871AA960", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public HNGKGCGPJMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PDOKKIGKBAG : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x71AFFF0", Offset = "0x71AF1F0", VA = "0x1871AFFF0", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public PDOKKIGKBAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class PHGCPGCLHJM : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x71B00E0", Offset = "0x71AF2E0", VA = "0x1871B00E0", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public PHGCPGCLHJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class OCDEECLNHFF : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71AFE30", Offset = "0x71AF030", VA = "0x1871AFE30", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OCDEECLNHFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class FDDPINCAJAC : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x71AA680", Offset = "0x71A9880", VA = "0x1871AA680", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public FDDPINCAJAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class PHPBALGNIGB : KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public static readonly MIBNLHIAMDL ONIAJGNALHI;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x71B02A0", Offset = "0x71AF4A0", VA = "0x1871B02A0", Slot = "4")]
	public void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public PHPBALGNIGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct HLEMJAHOFMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public IDAGJOOOCKM LNKNPHKNIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public OKPJMNODPLB KDHLCJOCKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public Dictionary<int, int> EIKDFFMOFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<Guid, Guid> GJDOOMGIEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public AMIDIPMAKKM KNBKKPFEFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public bool GNCDPNENPOJ;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KMBLNMJKIJL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGOJFABOIII(NIPKGCLBPHC PJODEJDGMEK);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NALDLMBLBBD
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly KMBLNMJKIJL[] CCGEABENAFO;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x71AE590", Offset = "0x71AD790", VA = "0x1871AE590")]
	public static void HKOELIAIPFH(INLFGDDOIPN LFDKFEEPNFP, Dictionary<Guid, Guid> LIJHINLEJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x71AEBF0", Offset = "0x71ADDF0", VA = "0x1871AEBF0")]
	public static void PKJNABGLMKO(INLFGDDOIPN? LFDKFEEPNFP, GLNMFKJLHPO OIELFEAHJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x71AE310", Offset = "0x71AD510", VA = "0x1871AE310")]
	public static void ENMMHGOLFJD(INLFGDDOIPN? LFDKFEEPNFP, GLNMFKJLHPO JCELMHNJOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x71AE820", Offset = "0x71ADA20", VA = "0x1871AE820")]
	public static void IMHOHPDCKBC(NIPKGCLBPHC PJODEJDGMEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct NIPKGCLBPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public IDAGJOOOCKM CGOBJNBOKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public INLFGDDOIPN HMHIBHFIJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public Dictionary<int, int> EIKDFFMOFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Dictionary<Guid, Guid> GJDOOMGIEPC;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x71AF450", Offset = "0x71AE650", VA = "0x1871AF450")]
	public Guid JNGOPDBPDOC(Guid IBPGMNEANFH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface AMIDIPMAKKM
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int MNNPDBAAOAM, [Out] Guid GLDKINJJOMI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class MMKDBMIBDJL
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly ProfilerMarker FDIHDGCINND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private readonly HashSet<string> DOLMMENHAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private readonly Dictionary<long, int> NOICAEKGNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly HashSet<Guid> CLIIKOMKLDD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IReadOnlyCollection<string> APLKCIAPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IReadOnlyDictionary<long, int> OHJHALPEBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x71ADEA0", Offset = "0x71AD0A0", VA = "0x1871ADEA0")]
	public static MMKDBMIBDJL GKHCNMHHPIL(LJJCDEANBLH JPGPNLNCOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x71ADF80", Offset = "0x71AD180", VA = "0x1871ADF80")]
	public static MMKDBMIBDJL MDKMOFMADHM(HFFMBPMKFCK BFNIBDOMMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x71ADD20", Offset = "0x71ACF20", VA = "0x1871ADD20")]
	public static MMKDBMIBDJL GDOOACPGIMK(IEnumerable<string> DOLMMENHAOM, IDictionary<long, int> PHDFLOEJHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x71AE1F0", Offset = "0x71AD3F0", VA = "0x1871AE1F0")]
	private MMKDBMIBDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x71AE0B0", Offset = "0x71AD2B0", VA = "0x1871AE0B0")]
	private MMKDBMIBDJL(IEnumerable<string> DOLMMENHAOM, IDictionary<long, int> PHDFLOEJHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x71ACA10", Offset = "0x71ABC10", VA = "0x1871ACA10")]
	private void DGKKGLNFLLH(LJJCDEANBLH JPGPNLNCOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x71AD0B0", Offset = "0x71AC2B0", VA = "0x1871AD0B0")]
	private void DGKKGLNFLLH(HFFMBPMKFCK BFNIBDOMMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x71AD710", Offset = "0x71AC910", VA = "0x1871AD710")]
	private void DKPAMAAPABK(ByteString? JDAKABLNFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x71AD2B0", Offset = "0x71AC4B0", VA = "0x1871AD2B0")]
	private void DGKKGLNFLLH(HONBLNKEJDH? DONMCNODAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x71ACF70", Offset = "0x71AC170", VA = "0x1871ACF70")]
	private void DGKKGLNFLLH(PBBLFFOPPPF? NGCBLOEDNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x71ACC10", Offset = "0x71ABE10", VA = "0x1871ACC10")]
	private void DGKKGLNFLLH(INLFGDDOIPN? HMHIBHFIJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x71ADF10", Offset = "0x71AD110", VA = "0x1871ADF10")]
	private void HJJCIKDENJL(string? PNDDPMABDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x71ADC50", Offset = "0x71ACE50", VA = "0x1871ADC50")]
	private void ENKPKGKLFOF(long IEFELBDFABH, Guid OGOKGDCMCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x71ADBA0", Offset = "0x71ACDA0", VA = "0x1871ADBA0")]
	private void ENKPKGKLFOF(FBPOAGGNBNO? DKJMIPJNKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x71ADBF0", Offset = "0x71ACDF0", VA = "0x1871ADBF0")]
	private void ENKPKGKLFOF(FKPNFLABEIL? DKJMIPJNKFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct IGHNKEFGJMP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class CNEODIPJKCC : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private readonly IEnumerator<DictionaryEntry> PDIDANFNIEJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public DictionaryEntry LDFAAOAEDKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x71AA2C0", Offset = "0x71A94C0", VA = "0x1871AA2C0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x71AA380", Offset = "0x71A9580", VA = "0x1871AA380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ELOFPHHKCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x71AA430", Offset = "0x71A9630", VA = "0x1871AA430", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public object AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x71AA1E0", Offset = "0x71A93E0", VA = "0x1871AA1E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
		public CNEODIPJKCC(IEnumerator<DictionaryEntry> PDIDANFNIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x71AA140", Offset = "0x71A9340", VA = "0x1871AA140", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x71AA190", Offset = "0x71A9390", VA = "0x1871AA190", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class DCNPGMMNFIO : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xAAB970", Offset = "0xAAAB70", VA = "0x180AAB970", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x71AA630", Offset = "0x71A9830", VA = "0x1871AA630", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
			[DebuggerHidden]
			public DCNPGMMNFIO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x71AA4E0", Offset = "0x71A96E0", VA = "0x1871AA4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x71AA5E0", Offset = "0x71A97E0", VA = "0x1871AA5E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x71B0F70", Offset = "0x71B0170", VA = "0x1871B0F70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IDictionary.this[object OFPBICPHALF]
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x71B0E80", Offset = "0x71B0080", VA = "0x1871B0E80", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x71B1060", Offset = "0x71B0260", VA = "0x1871B1060", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x71B0DC0", Offset = "0x71AFFC0", VA = "0x1871B0DC0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x71B0E20", Offset = "0x71B0020", VA = "0x1871B0E20", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x71B1000", Offset = "0x71B0200", VA = "0x1871B1000", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x71B0A80", Offset = "0x71AFC80", VA = "0x1871B0A80", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x71B0AE0", Offset = "0x71AFCE0", VA = "0x1871B0AE0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x71B0B40", Offset = "0x71AFD40", VA = "0x1871B0B40", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
		public RoomObjectCounts(Dictionary<int, int> IBHEJMKBMJL, [Optional] Dictionary<int, int> JJNPNLPGGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x71B09A0", Offset = "0x71AFBA0", VA = "0x1871B09A0")]
		[IteratorStateMachine(typeof(DCNPGMMNFIO))]
		private IEnumerator<DictionaryEntry> MGOFABAIAFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x71B10B0", Offset = "0x71B02B0", VA = "0x1871B10B0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x71B0CC0", Offset = "0x71AFEC0", VA = "0x1871B0CC0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x71B0BA0", Offset = "0x71AFDA0", VA = "0x1871B0BA0", Slot = "9")]
		void IDictionary.Add(object OFPBICPHALF, object OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x71B0C00", Offset = "0x71AFE00", VA = "0x1871B0C00", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x71B0C60", Offset = "0x71AFE60", VA = "0x1871B0C60", Slot = "8")]
		bool IDictionary.Contains(object OFPBICPHALF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x71B0D60", Offset = "0x71AFF60", VA = "0x1871B0D60", Slot = "14")]
		void IDictionary.Remove(object OFPBICPHALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x71B0A20", Offset = "0x71AFC20", VA = "0x1871B0A20", Slot = "15")]
		void ICollection.CopyTo(Array HCOCCGHLKNN, int CPLNODNGKGB)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class HBDOELHJBNP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0xAAB970", Offset = "0xAAAB70", VA = "0x180AAB970", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x71AA910", Offset = "0x71A9B10", VA = "0x1871AA910", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
			[DebuggerHidden]
			public HBDOELHJBNP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x71AA780", Offset = "0x71A9980", VA = "0x1871AA780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x71AA8C0", Offset = "0x71A9AC0", VA = "0x1871AA8C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x71AC320", Offset = "0x71AB520", VA = "0x1871AC320", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IDictionary.this[object OFPBICPHALF]
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x71AC1F0", Offset = "0x71AB3F0", VA = "0x1871AC1F0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x71AC3D0", Offset = "0x71AB5D0", VA = "0x1871AC3D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x71AC130", Offset = "0x71AB330", VA = "0x1871AC130", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x71AC190", Offset = "0x71AB390", VA = "0x1871AC190", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x71AC370", Offset = "0x71AB570", VA = "0x1871AC370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x71ABDB0", Offset = "0x71AAFB0", VA = "0x1871ABDB0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x71ABE10", Offset = "0x71AB010", VA = "0x1871ABE10", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x71ABE70", Offset = "0x71AB070", VA = "0x1871ABE70", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2505820", Offset = "0x2504A20", VA = "0x182505820")]
		public Invention(long BEHEHKFONGA, int EOKNBJLIKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x71ABCE0", Offset = "0x71AAEE0", VA = "0x1871ABCE0")]
		[IteratorStateMachine(typeof(HBDOELHJBNP))]
		private IEnumerator<DictionaryEntry> MGOFABAIAFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x71AC420", Offset = "0x71AB620", VA = "0x1871AC420", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x71ABFF0", Offset = "0x71AB1F0", VA = "0x1871ABFF0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x71ABED0", Offset = "0x71AB0D0", VA = "0x1871ABED0", Slot = "9")]
		void IDictionary.Add(object OFPBICPHALF, object OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x71ABF30", Offset = "0x71AB130", VA = "0x1871ABF30", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x71ABF90", Offset = "0x71AB190", VA = "0x1871ABF90", Slot = "8")]
		bool IDictionary.Contains(object OFPBICPHALF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x71AC0D0", Offset = "0x71AB2D0", VA = "0x1871AC0D0", Slot = "14")]
		void IDictionary.Remove(object OFPBICPHALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x71ABD50", Offset = "0x71AAF50", VA = "0x1871ABD50", Slot = "15")]
		void ICollection.CopyTo(Array HCOCCGHLKNN, int CPLNODNGKGB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> JMCBAEIFLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public readonly IReadOnlyList<Invention> HNLLEOEOJFF;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
	public IGHNKEFGJMP(IReadOnlyDictionary<Guid, RoomObjectCounts> PMPKEIJLGLD, IReadOnlyList<Invention> CKPCJKHBNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x71AAC20", Offset = "0x71A9E20", VA = "0x1871AAC20")]
	public static IGHNKEFGJMP GKHCNMHHPIL(LJJCDEANBLH JPGPNLNCOHG)
	{
		return default(IGHNKEFGJMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x71AAB00", Offset = "0x71A9D00", VA = "0x1871AAB00")]
	[CompilerGenerated]
	internal static int EGLCAHNMHBF([In] IReadOnlyDictionary<long, int> ODLCBLIBJDB, long? IEFELBDFABH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x71AB630", Offset = "0x71AA830", VA = "0x1871AB630")]
	[CompilerGenerated]
	internal static void LJHJLIFEMCC(int FFDLHCDIGKO, [In] HONBLNKEJDH MPKPMPOHHGK, [In] Dictionary<long, int> ODLCBLIBJDB, [In] Dictionary<Guid, RoomObjectCounts> PMPKEIJLGLD)
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
