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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x6985010", Offset = "0x6983610", VA = "0x186985010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KDDHHKEBFDF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> PADOGMLINEI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> GGKNLMDIKDA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> BGCCOJFIFIL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string EBJAMOEOPAO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string IGLAFEGMCPD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string FLLLMLOLBFD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6983DB0", Offset = "0x69823B0", VA = "0x186983DB0")]
	public static bool JPLGPNDPKNG(Guid EOONJLBIANJ, int PGBNGNNAJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6983650", Offset = "0x6981C50", VA = "0x186983650")]
	public static bool FICBDPHGJAE(Guid EOONJLBIANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69836E0", Offset = "0x6981CE0", VA = "0x1869836E0")]
	public static string JODAOHGBOKN(Guid IJNLNGBKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LOGEFBPPJOO]
public enum NPMIKLOHHOM
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
public static class DCLJELHDLOA
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid LKJOBOJGIPK;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid DKFHNHBJPLJ;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid DIMKBGLNCHM;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid LEFFCGLAONA;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid HAIHFIDJPIC;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid KJIEFIHIDEK;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid JOODEKMLMKH;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid FPFFNODDCPP;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid CJAHLECGFKI;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid OJLFCCJEKKN;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid DNEBFEGJCPA;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid AJIGPEGEFOH;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid FMPPPGIIDJN;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid LIGLIMOANGF;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid LEFDKLIFJFO;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid NMMEJHMGFDO;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid OKHCMIJPHHA;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid FJIIFNJDGPP;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid FEFPHAFODPG;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid PALGJINEOBL;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid NNDGEFJGNBB;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid MLLNOALNJHK;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid GEACAPJLIII;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid FLHFPFPPPJC;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid GKFODFAGLEA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid HECLKHNNCIC;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid OAMIKFCELKN;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid EECMPPJJJJA;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid NNBIFONNAFC;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid DGMNOOCBMAD;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid ACAJLFJFBDC;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid LNBHMBLJFKH;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid HBOPIJAOPHI;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid KCIKFHGMKNL;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid OCAAKIMPBGN;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid POPKBJHOAJB;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid LOGMBPGOOMJ;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid ELGKDIOHDAM;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid APJPANCJCMC;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid GKCBLIEJBMP;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid DGFMKALKMIM;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid MHPBIHJMAIG;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid PBPDLDJDHDI;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid OALMJBJPKGK;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid FDADGDAKOCP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid BCBPDDMBFHH;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid HFHHNBMFKEF;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid NLECBCDFKBA;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid EHDHGPJFLJE;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid IKCLJHIGODH;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CCBMNHGDMLH;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid ODAMCCHLBPJ;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid OKICGAIFHJM;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid ACHNKFMBBOE;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid PACGANPHIIC;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid EGGMFELLGAB;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid PPPCAODMONP;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid IGDGLDDDIFF;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid GOHANIMFGNM;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid KHGMJFIMGOO;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid PBFENJKGHAL;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid LCKHFIMLAMM;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid EFPGBNLJCAL;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid BJJILCJNILJ;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid JDFPCFILPDP;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid ACPHMPOJKOI;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid AIGKBMMLEJL;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid PGHPEJIPCDF;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid IBCKFFGMIEH;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EMEAHKEANCL;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid PHLACKJHFJP;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid ICGDMAEEJLB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid APNLHDNPGOG;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid OCMIENLDPEN;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid CHNKEONCPDC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid FBOKGEPEOLA;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid HLHCGJOIGEI;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid BGLLBDNKMKC;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid PKHLBICKAPD;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid JFKFEALKKGF;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid KLKACLDHONB;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid NOOCOIKPNAD;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid PFEKBJOCOAF;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid BLOFGBIPDAK;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid FODKHKBIDBE;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid OLICNAFICPJ;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid GIPBBGHGKOD;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid KOONJEAFCBJ;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid MKFIFJHHPEH;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid NACJIAPIPEJ;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid BNJDPHMHJBH;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid NHFLCAFKKKA;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid LDFPIFAODHM;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid CEDBCHLAKNC;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid KONGGKCPIOH;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid KEIEFPEOPNI;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid EJMCIMIMEHB;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid AGOIHABDLJK;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid NFDEODPLMAG;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid PEPIAGKIPLL;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid CGEIFPIBGOD;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid KPJLPLCCMIA;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid CNAEONBHAIC;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid DECNEJOGDMP;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid JDGMBKALPHM;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid FGBPBCPDJLE;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid KBFICKKPPPE;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid KHOAMEAPDJD;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid GEACFEDALGP;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid DNFKNFPCNNM;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid IJPBLDBFMEE;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid JABHONEEOFD;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid OFABPOPFMCG;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid NJOLENPFKII;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid NPFJMFNNHLN;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid LOMAEPMGEJK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid GBLFLGAIOIP;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid IKOIPIHCJDP;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid AIHDBEOCGML;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid HCBEEDCBMNH;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid OGKOGMKEBNC;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid EFPPKBMGCGD;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid HCMBKLOBMAC;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid ICNOPCHCPPI;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid JGKKJKKCMFD;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid EKHEMKFGOPI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid FLPJJLCDOOK;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid DLHIIILICOE;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid JNPGHNIIHDO;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid NNJKEIEPBAI;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid DAMMBLKINMB;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid IJFODCBKGIC;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid AONNCABACFE;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid AJMGPIGLLAA;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid EMPAHBLMLFH;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid BBMEHMOFMFD;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid DPDKNGMHKHO;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid HFNFKKCLJDC;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid LJBFEDNCMFL;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid DAFMCAGJNNA;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid DABNLCBNPCP;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid NIAODMCADKE;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid DHDAPNGHCCC;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid NNJLHOPKLKL;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid JLJEIGJJAID;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid MNMIPIIFAEB;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid AABPEGFPPLP;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid JNCPKPLGCAD;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid DNILJJOHBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid AOHBHHDAHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid JIGNPGJPGPA;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid LINHCFGOOFJ;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid HBFFOPOMGGE;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid FIDLAPMEHPK;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid MKBHLNMEPPE;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid DIHMAJAGHMH;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid NLJIPDABLFG;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid BBOKKNFNHMP;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid NOKHNDALDOB;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid POBNFDDNMBN;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid KFLHFJOEEPJ;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid NFOLFMOCLHM;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid LLCDDGHBKNO;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid ADELKKMJHCC;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid BBPLBJCFICF;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid GLNJDDEKLNP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid JGMMDHAIFGA;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid BOEMNPIFOEL;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid DLAJOLPFDLM;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid IKIKKOBFCBN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid NNDACHKJDHM;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid LPIOKAEAHLE;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MLPLOOJENOE;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid LAOLPCPOAEO;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid DNFKHKNHNDC;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid KHHKILMDCAP;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid GMMACOMCEBM;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid PMGHEDCKHIL;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid CNNKEKHJDKA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid LEIBMKHGPEH;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid GEGJNANPOIM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid KCGFNCHDFAH;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid GIHJIGAFPCO;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid LIMFDNHHNGJ;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid NBFJNILJGPO;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid GGFNJNHALFO;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid EMJMAIIJDCF;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid KCIBPJDOAGH;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid DLLBJDOMMOD;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid HDHDDCMGIGF;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid AIEKNKJDNOA;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid KBKEGGIJNJJ;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid IGPONCEFHEP;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid PCKJGBNGMLM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid AHAAJKKAEIH;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid DEFHPGNCBCD;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid BCHGMABOIHB;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid PIHIKKPDKEI;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid NOLBIJHBLCI;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid EBHAOOFHALF;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid GBOLJMODFGB;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid FJHPCDHPBMF;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid BNBPDPFFEPA;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid EHAOKBCHBPF;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid KHHIEDPEMML;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid HNMEFCOKBHL;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid DBMDLJNDFPI;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid HMNKPCACAKI;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid BBOPJOPHBDL;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid MLKKFFFPHKG;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid MLPIIENADLM;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid GHMPJFPDDME;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid MJEBGDBJMCE;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid EALJPFPHGDF;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid MNMJBBBKAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid JLFMABMNLGO;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid KKNJMJNHKII;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid CNJJMBGJFLK;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid BADDHGOPEID;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid NMHPCJOHLDG;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid OLNHFMPDLBM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid PAOAKCBIKHB;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid AOEPMNLIBMO;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid EKDGJHBGOJN;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid HHCBAGAGEEO;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid IENFONGFMKE;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid BJDHFFGMBKN;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid LJKJNKBAANB;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid JNHNEALMDCI;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid EJDKBKKHDEC;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid ODKOEAFDMJP;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid DFMFPDOPPBN;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid LDJAJOLOFMP;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid AMAEEFJNDAK;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid EOFMOHLDLHI;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid JJLLGCGIDOI;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid AKGDKGAOLPA;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid KONHEBJLIHK;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid AOLLEJFBJMB;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid EOMHPDGFDOH;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid JPKEPJAMEJM;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid OECHMNEHCEL;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid BNKMBIEHFKK;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid MOIEBKEAPMN;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid DJMGMKMMJBC;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid FBKKKCLCOED;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid POOLLCCDMCN;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid EAGOCMHOIOG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid JJNNHOLADEK;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid OOOOFINGJGK;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid EEAMNJACOFE;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid AHCHDIDHBEH;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid BGEGELGFJGJ;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid MKHDJICGMEL;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid DBBLMKGALGH;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid NJBIJPBEBDK;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid HAGGMBBNNCD;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid EBCBGPCAAHJ;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid JFKBLHDAFNC;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid EFDKLPOGHJN;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid ILACDEPMFFH;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid AFIJGLALNJF;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid AMBJOHIJFFJ;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid EMGIPEINNGO;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid PGEMDNOFIPE;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid MJCMJKJONGC;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid FHHNOCFOACM;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid JOOPDHHKIEA;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid JNMMLOJPNJL;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid NMKBPMGPCAE;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid BFIKPNJJFLB;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid AJIJGNAEBHH;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid JGAKPOFDBEE;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid FJKNJKKAKMG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid MCJJLPAKJOI;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MKKHEIEHLEF;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid ABHJKMIHLAA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid HCFEAFBFGIH;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid KHMGGOJOJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid HEKCLLLKNBF;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid OIDDHBFBOAF;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid AAILCOLEICG;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid KIMFHPMNMAG;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid BPJFGCECMOJ;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid IIHDBKKCOAO;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid ICNIEFGHMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid CDAFMLIHFCF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid EPIGMCOAPKD;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid JPOKGCJNNDC;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid GAJNDALFMLI;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid CDBHBKDOOBP;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid MFIALEHBEDB;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid EBDFOIGCILC;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid NEMFLDOOGNO;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid NBDOOPJGGPH;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid AMAANEPPHIA;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid JIEJHIKNIIK;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid MMMGEPFEFPD;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid FBIILNIDOPG;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid FEGPEEBEIKP;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid AIFFJHJKPEL;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid HNCMBBDIEIO;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid PEFEEPCHFFO;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid AMACPEKIHBK;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid OKBCAFBELMH;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid FCDNJNJCNGF;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid JHKPAAJHDJC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid NLECPGDPBJI;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid BGGGEPHPHHN;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid NMGHOFDMPLE;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid IHCBMCGMMEM;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid MKPMPCLMEHD;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid KAIKGDOJMDP;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid AAEDNHKJGGN;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid GPFAEKNHKPE;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid CCEFKJEGDKD;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid LKHNELKGICA;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid JJBPCPCJOLP;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid EGLMCMIEKAH;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid JEBIGHJJLOI;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid LGOMFOLLLLL;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid BGIFBHPBBPA;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid DPDAAPCEAEM;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid AGOELLMPAAE;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid JFOLMMLIPHL;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid HCLCGFKCBNJ;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JMEDHBJJEGH;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid LCMFBHGCPFK;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid LMGMGFFHONM;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BCFJLJCLPAD;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid HJGCBFDJKAH;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid OMJFHPJJONO;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid IBOEPCPNCEA;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid EIENCLOFMIF;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid OHPPNDPFMHM;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid ILBLLBEKHKA;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid OGLDKPHODJE;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid LBGOCHLKKDM;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid FOLPKLLCKDA;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid DIJMHACGDMG;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid AKGFIICIKHC;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid AMPDDPKMGNK;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid CGLEDLCDAKO;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid LGDGIOBLMCJ;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid LOAEIBCKBBN;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid JOLIBCHDFOM;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid DHKPPCKGFLE;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid IJIAMCFAHED;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid GCOPLMJHNHA;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid FOEHDFLEINO;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid JHOEENGPGKG;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid MKMIPAPLJDP;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid DHINMKDNFBH;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid CMPNLJIOJOB;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid CAAJDEKHEPG;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid DCAOAGAMHNC;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid GBNKMIEINBB;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid CMDAKINACBF;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid OPDCOBPEGJO;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid PEILKGNIAHJ;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid DKFIKHPHFIA;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid KMGBNPHOBDK;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid FCAJEFBAPIL;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid ONKFLGJFEBI;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid PPCJMMIPHEA;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid ALKLCHMCAAI;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid AKMLAJJEOIG;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid LHAHMGEIEMD;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid PIBMMEHCONK;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid NILEIGFMOKP;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid FCLKLDGGGHA;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid MFCKKHOEJHO;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid IOEAMNFOPEP;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid DLAELPGGPAD;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid PNCFFFMJNMG;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid BNPOJLCGILC;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid BHJBGFHOBJE;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid MLBKBIGKFKN;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid FFIHLLHOFCD;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BEDHDCCNKPI;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid IPFOJKLNJFE;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid OPHDADPACMN;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid DBHBMLEKFBF;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid PFDBKJNEPIH;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HOCIDLLINGN;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid AFGMADCBPBB;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid DHNPHGOGAMD;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid HJMAHBLKGDP;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid IFINKFAHBKD;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid HOCBBGOJLLB;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid OJFJJALIFNP;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid APBOFCOHPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid KPIFAAKKGHC;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid EDCKDFPDFAL;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid GJKLNKLBPIO;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid GIBPCKCAAIF;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid ADFDJJPEJPC;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid FDPOLCIDDDN;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid JFCPKCOJFFN;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid MKKFDPFMILC;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid GJHPCCNPCAJ;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid IBGAEBFHJGB;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid GAMFANDIJEA;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid BGJOKEFIHDF;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid HLHPMDINKKE;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid MBCHAJJOPKI;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid KPPOGHLCIJB;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid IPLJDFNBFKL;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid DBMOCLHPBPM;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid GJEBODBLICK;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid OEDIGALEJJE;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid KLNKJOCDHFC;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid FPCDNIFBDIG;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid NDEEIKCLPBG;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid DGOLBLHDMAO;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid BCDEEBOIPLO;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid FOMAJNDAJFB;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid PJHNAKHELFA;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid GIEDEPPLFCO;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid PAABJDJOCJK;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid NCFNGAILPPD;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid LHGPHKDJCMK;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid JCDGMBKKIIN;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid KGDNIBLMMFF;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid IFEBFOGCEIP;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid JGBAKCGJPJB;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid ODMENDINFJO;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid AIMEDIHMEIH;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid CLMEKJFKEEI;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid FCOOOOKBKFN;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid JGNAPDCKPIF;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid LPBGNLIECMJ;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid IOGEPCELAEN;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid HGADJFPDCMF;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DOADLDJHGKI;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid BJDIDBBOHDK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid PEMILFOIGMH;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid CJHLCCAIOCH;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid MBKNIGEOFNG;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid MBALBLJJCMH;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid PEDOLKGCCFE;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid POLGFAJOOMG;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid GFFEICFBCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid BBCEGHAFNIP;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid LJJNMEGMFIO;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid HPDBKFDFEEG;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid PCOLAIDEHAA;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid IOOBFEMLHLN;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid JIKHLMHDHFM;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid DDKMHMLMCCI;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid PHELOONJFJA;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid HOOCIHHBGDP;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid LCLBBDBIOOM;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid MHOLCJKOKKK;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid KPJIHEELHDE;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MMAACHKLJEC;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid MCDDHNGKLLP;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid IDBOGBMPCJC;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid DOAMMEAAJPF;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid JIPGICMFOII;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid ELHCPHMGHLI;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid IJAKBOFLLCI;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid CGICGMCLNEN;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid GMCDHGAPOOH;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid BJDOPKJHDMF;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid BJJCKNPIELN;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CIINGNEHBAK;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid GLGIPHOABLN;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid CJFFKCBOEBE;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid CEABFGKAEAB;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid PAEBEPGHJIM;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid COABFHIKAFL;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid CIFFFKCAEBF;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid GGKHGIAOPPP;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid KDEIDOPBGGI;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid GNFLHFOLKCC;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OEJOGMMALNP;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid BEOOIOJHKFH;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid MHNFEPHELNP;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid KIOJAIADBKG;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid JLHGDIKHINE;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid PBONPMMIIDP;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid MLODBOCKLJH;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid JIMOGFIAHPB;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid BDCKEIAHFLM;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid LPNHPLKLEMO;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid JFDELJMNLOC;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid NJNHFKNDKEA;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid OJCGLFJLNCC;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid MKPAKDDHMKC;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid LGKCFNKCDNB;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid COCEBMEAOHG;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid PKADIOJHGIA;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid FEJHGIALGBM;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid KHHMMCEMPIB;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid BEKLNILHIKH;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid PPOHKAFBDNP;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid BCEFFHIEPGK;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid CGKIAJDOMMM;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid JPDKENGPLCJ;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid OLOMHPDAMDE;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid EICDKIOPMMG;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid NDCEIHPKNJN;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid BAGKCCPBJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid EHAFLMKDAJF;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid AOMCAFAMICE;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid KEBBKNCEHAP;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid HEHKPBPLMGG;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid DCIKIDDMJLL;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid JIEGFDMKDDG;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid FBOMNENGGCK;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid IPEIMIPCKAA;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid DAENLCFNGBP;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid PKJOEJDNGMK;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid LGOKKOPNBLM;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid GEJMFFCCIPK;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid KDBEGHMFPDI;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid NKDBEJHNDDF;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid ENFEKAJMBMF;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid ODPJEDEPNCI;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid HMKAFMLNCBG;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid JHNKFOEHMAI;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid JFNMMPNNKDD;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid ECBEAEBNADK;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid JIJENANMKJG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid JMCDFFGJJPI;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid BKNJCBNFBAD;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid JMPENKNCKCK;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid FKMFIBMMKCI;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid CLCNKCGPOAH;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid GLOEAAFHCAN;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid EHOECGPMOGE;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid NAEDHOGFCFN;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid MMMHJPJEOMP;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid EGEILLIDAMK;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid IFKNIKLLEBK;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid BFPHMPLJLFF;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid IAFNHGHODMB;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid PIDNJKANBMN;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid OCEKMAMFFOE;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid NHNBNDLJMNE;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid EHLMCKNIFJP;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid PCLHIOJDGMC;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid JHLBODFKIPL;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid LBHFNJADCKO;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid DFPEDLDMNNF;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid DEANKBJBNMB;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid FGNBHIDACIE;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid HGHCEMBCGGF;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid PGAEDNEAODJ;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid FLCJIPNIJKM;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid GIFFMKNNKKL;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid PKIPJBPHAMK;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid FAPHLHDPGKM;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid DCBBJOFJBGA;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid GLPBMBGEFOH;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid OBGHEFIEJGB;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid OKILMBJJCBB;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid NDIBFFOIOEF;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid OOAIGEEJDKK;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid AGJBMFIHFIH;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid NIIHJJFIPJF;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid OFBGPMCHMLF;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid FLGIOGKHNLP;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid DOCNHCHALFI;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid FHJODMBGCBF;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid JHLDDOPMJGE;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid HFGHPPGGGEG;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid JBMPGCBLOHL;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid HHHDNINCFFG;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid PNGLOCCAHKG;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid PGIFJLLPMMN;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid DKCBGJBACMD;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid DPPODKFODHB;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid LEBMEGFFAOL;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid GJGIKEOLMDN;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid EKDCPPPBJGL;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid CBNJFEBHLFL;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid KIMGLMDOFEE;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid OCHOCOPILDM;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid PFDMEDKJDGO;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid GEBKHIAHFBA;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid JOADGBFIIBB;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid BFKNGJIFFFA;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid GOLIBMCLEOB;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid FJEGBEFCPBF;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid BEFGEBCNFBI;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid GMCOFDIMLDN;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid OMKPENLCKMH;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid AAOFGLCHFMK;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid LHDAMECLICP;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid LNLELCODAMF;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid CMHIECAGFBC;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid CFCKIKGMONM;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid EBPBBBBINMH;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid MIGJCNIHHMD;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid OFCGHBLGLCO;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid LPONHLKKJNI;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid IPJADDICLMD;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid DBOEINHMGEC;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid IBBBGBICCHI;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid JLJAJNNMECG;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid DAOLNOGKHFC;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid PDMNFMOKPEJ;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid NFMPEHDHEAK;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid NONEIKHPIOM;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid IBNDCDBEKEH;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid DGNMMKGBDBI;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid MAPDIFGPCMB;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid BGACNAEOMCP;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid MJDKBMIKADO;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid NCDPKPFEFAL;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid HIPIFCIADLN;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid LEOFKGHGNJI;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid KCNGIGOOBMN;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid NIFEIBJJMIJ;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid CJPGFCLCDDC;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid MFOHOBLGAJB;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid PPHEAOGAPBE;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid OJKHJIALFBG;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid JCKEKABIADJ;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid LCIIAPBFBKI;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid FLMMIJKJJPA;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid OPGDCCFIKDE;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid NDBAFJLDJCM;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, NPMIKLOHHOM> OLCFJIIHDLD;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<NPMIKLOHHOM, Guid> AGDHDHNBIOP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, NPMIKLOHHOM> ANKANBIACEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x697CFA0", Offset = "0x697B5A0", VA = "0x18697CFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<NPMIKLOHHOM, Guid> NKOCKDDDFCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x697CF40", Offset = "0x697B540", VA = "0x18697CF40")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EKKBILKGJHG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x697FBA0", Offset = "0x697E1A0", VA = "0x18697FBA0")]
	public static bool OKINPNOEIOH(MCPIOOMJMKC JCHJDNEKAMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x697F7F0", Offset = "0x697DDF0", VA = "0x18697F7F0")]
	private static bool OKINPNOEIOH(NMHNDBAHODE LFGGKMKJGKE, MCPIOOMJMKC JCHJDNEKAMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct PMJNAFPBMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly LCKLOOAKLPO HIFCLNMBFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<LDEHKHFLDMK> MOFKODGPJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<LDEHKHFLDMK> PEBEFEKGPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> MFKLPAFBNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<HBIPEINCKFG<JBMJEMLAFJB>> FNIOOFGBAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString HDBGEPIMKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly GECOPOBPOFG APKCNJPAOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool FLCDLNLKEFA;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6999490", Offset = "0x6997A90", VA = "0x186999490")]
	public PMJNAFPBMMA(LCKLOOAKLPO BFHJKOKDCKP, IEnumerable<LDEHKHFLDMK> GEIBOHFEECI, IReadOnlyList<LDEHKHFLDMK> EBKNPLNCOAA, CGBGMGFBCKF<NPIPKFBHIBO> BOCKLOLBFPI, IReadOnlyList<HBIPEINCKFG<JBMJEMLAFJB>> DANPBKMJCLJ, ByteString DPDGJIFDLKH, GECOPOBPOFG JJCNIIKKOMD, bool GBLJJAHFJEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GPLNLBKKJGH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(BNJNLKHIFCH MMDLBEBNCGC, [Out] Dictionary<int, int> KJJINPBGOCN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(ELBNLBENCKK NLACBNPLLKI, FIICDDMOEBD NKKMGLFCAJC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FJPPDHHMEMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid HNAOIJBEHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> KGPNNIMCFHA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> EDLAKIIPJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x39AE8D0", Offset = "0x39ACED0", VA = "0x1839AE8D0")]
	private FJPPDHHMEMK([In] Guid NMGKIEIBLEJ, Dictionary<Guid, Guid> ILEECPNNLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69801D0", Offset = "0x697E7D0", VA = "0x1869801D0")]
	public static FJPPDHHMEMK PAOLDMMNJDI(IReadOnlyDictionary<Guid, Guid> NDBPJCLKHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x697FBF0", Offset = "0x697E1F0", VA = "0x18697FBF0")]
	public static FJPPDHHMEMK BAKHBJAPFNE(IEnumerable<KeyValuePair<Guid, Guid>> NDBPJCLKHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6980010", Offset = "0x697E610", VA = "0x186980010")]
	private static Dictionary<Guid, Guid> DHPIMJMFCPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69800C0", Offset = "0x697E6C0", VA = "0x1869800C0")]
	public Guid GCBBIJPBBME([In] Guid IJNLNGBKEAC, bool PADKKFIJEDN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x697FFA0", Offset = "0x697E5A0", VA = "0x18697FFA0")]
	public bool BCIFMPPLAKP([In] Guid DAIJJLLIENA, [Out] Guid KHOLIMGIAAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LMPHFGFHGIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FKKNICKBACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJPHNAHFOOE(ByteString EABGAFLLHMP, FJPPDHHMEMK PEKBLOCNDEK, [In] UniformTRS BIFFPOEGKHL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NCHAGMHOAGN
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
public class FJMFGPELJEF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1533670", Offset = "0x1531C70", VA = "0x181533670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long GBFKNLKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x104D6A0", Offset = "0x104BCA0", VA = "0x18104D6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long HOKHOFPEEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x697FBD0", Offset = "0x697E1D0", VA = "0x18697FBD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6676180", Offset = "0x6674780", VA = "0x186676180")]
	public FJMFGPELJEF(long BMKFLHFENBJ, long BPPEEGNPDIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PCCCAIMJLPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, FJMFGPELJEF> NNBIDAJCOMB;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> PGFLJNNGMPD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long HLHFHJPGMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x104D6A0", Offset = "0x104BCA0", VA = "0x18104D6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long GECOEMNCLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10B3F10", Offset = "0x10B2510", VA = "0x1810B3F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6985120", Offset = "0x6983720", VA = "0x186985120")]
	public static PCCCAIMJLPL IAIDEKBEMPP(LCKLOOAKLPO IDEADFGFBBH, HBIPEINCKFG<NPIPKFBHIBO> HJJJMADCELE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6985790", Offset = "0x6983D90", VA = "0x186985790")]
	private void OPKBIHIIAPD(INBEHHBGGBG EMDFCFPCFGG, long EODOICBIONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6999400", Offset = "0x6997A00", VA = "0x186999400")]
	public PCCCAIMJLPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KDMLKIJEEKG
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<NPMIKLOHHOM> EAHJFEHKDFI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class KHOPCPBIAPE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> NEKNMCMOENA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> DMEDBAACBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x872E80", Offset = "0x871480", VA = "0x180872E80")]
	public KHOPCPBIAPE(IReadOnlyDictionary<Guid, Guid> CODIDEHMJOA, IReadOnlyDictionary<Guid, Guid> LDNPIMGHGFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JNEDFBFNHKE
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69801E0", Offset = "0x697E7E0", VA = "0x1869801E0")]
	public static DILLDOHMMJP AELGDIOCHFN([In] PMJNAFPBMMA OCJMAKCOJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6982FF0", Offset = "0x69815F0", VA = "0x186982FF0")]
	private static void MEJEEDFJDIE(DILLDOHMMJP GHEBGEHBBIG, [In] PMJNAFPBMMA OCDMIHEMMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6980690", Offset = "0x697EC90", VA = "0x186980690")]
	public static CBDPDIPONCF<KHOPCPBIAPE, AEFONANNJHG> ANGLOMPHCHK(DILLDOHMMJP GHEBGEHBBIG, DBJNBEEMHMI NJFALHNCEAP, FJPPDHHMEMK? JJAHBLFHGPI)
	{
		return default(CBDPDIPONCF<KHOPCPBIAPE, AEFONANNJHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69821A0", Offset = "0x69807A0", VA = "0x1869821A0")]
	private static void CIBOGICCKFB(DILLDOHMMJP GHEBGEHBBIG, FJPPDHHMEMK? PBCBMDJMJMK, DBJNBEEMHMI NJFALHNCEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6982F80", Offset = "0x6981580", VA = "0x186982F80")]
	private static void LCEKOBKEGBK(DILLDOHMMJP GHEBGEHBBIG, DBJNBEEMHMI NJFALHNCEAP, IReadOnlyCollection<ByteString>? LMOHEOJCKNJ, IReadOnlyCollection<ByteString>? OKJKIIMIGOO, IReadOnlyCollection<ByteString>? PLCMNBNNGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6982430", Offset = "0x6980A30", VA = "0x186982430")]
	private static bool HBGLEAEPFII(DILLDOHMMJP GHEBGEHBBIG, ELBNLBENCKK NLACBNPLLKI, DBJNBEEMHMI NJFALHNCEAP, [Out][NotNullWhen(false)] string? ENLEFDLBBGG, [Out] Dictionary<int, int> KJJINPBGOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6981EC0", Offset = "0x69804C0", VA = "0x186981EC0")]
	private static Dictionary<Guid, NMHNDBAHODE> CGJNCLAOOJA(DILLDOHMMJP GHEBGEHBBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6980360", Offset = "0x697E960", VA = "0x186980360")]
	private static void AHNDJNOAAAG(bool CEPCJFJPBLI, LDEHKHFLDMK FJBKCCGEENF, Dictionary<Guid, Guid> KHKEJCFAEOD, FJPPDHHMEMK KJALPENJDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6980400", Offset = "0x697EA00", VA = "0x186980400")]
	private static void ANEMIIFCJIK(LDEHKHFLDMK FJBKCCGEENF, Guid GMHLAINELFE, CKOOEIIDEHN? FBACPGIEAPC, Dictionary<Guid, NMHNDBAHODE> NCAHFIHBNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6982AD0", Offset = "0x69810D0", VA = "0x186982AD0")]
	private static void KIIHHEEAKGN(IEnumerable<LDEHKHFLDMK> CKADHEBJFPE, IReadOnlyCollection<ByteString> LMOHEOJCKNJ, IReadOnlyCollection<ByteString> OKJKIIMIGOO, IReadOnlyCollection<ByteString> PLCMNBNNGGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DBJNBEEMHMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool CEPCJFJPBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public GECOPOBPOFG JJCNIIKKOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public CKOOEIIDEHN? FBACPGIEAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public CKOOEIIDEHN? JNBCBPCPNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public LCKLOOAKLPO BJCOMJIJNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public NCHAGMHOAGN OBBGLPEJLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public GPLNLBKKJGH JKNAGMEAFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public LMPHFGFHGIM EFLCMFJENFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public HBIPEINCKFG<NPIPKFBHIBO> JFLKCPBODMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public BGIBPOPOOLN JEEIFHJDMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<LDEHKHFLDMK> NINPIPOHKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> GCLBPNBDEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public MCNHAODPHFE MJMBGEHPCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool MBNABGMJCOI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool MLEECIAJAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x697CEF0", Offset = "0x697B4F0", VA = "0x18697CEF0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CKOOEIIDEHN
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float FOIJHNLLAEN = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 MCPNOOFMAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion GLKHDAMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float ICLEOPHCOMM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 AOALDIFKIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x697C5C0", Offset = "0x697ABC0", VA = "0x18697C5C0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS BPIBGHCIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x697C580", Offset = "0x697AB80", VA = "0x18697C580")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB62EF0", Offset = "0xB614F0", VA = "0x180B62EF0")]
	public CKOOEIIDEHN(Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, float ICLEOPHCOMM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x697CE20", Offset = "0x697B420", VA = "0x18697CE20")]
	public CKOOEIIDEHN(UniformTRS HCJKONDOFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x697CB10", Offset = "0x697B110", VA = "0x18697CB10")]
	public static CKOOEIIDEHN OGGFEMIKHLE(CKOOEIIDEHN PPEEAFEPIIK, CKOOEIIDEHN COIOKLEDKHP)
	{
		return default(CKOOEIIDEHN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x697C8C0", Offset = "0x697AEC0", VA = "0x18697C8C0")]
	public static CKOOEIIDEHN HDKGBCFDEBL((Vector3, Quaternion, float) MMDLBEBNCGC)
	{
		return default(CKOOEIIDEHN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x697C740", Offset = "0x697AD40", VA = "0x18697C740")]
	public static CKOOEIIDEHN HDKGBCFDEBL(Matrix4x4 JAFOIIPJPEB)
	{
		return default(CKOOEIIDEHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x697CD90", Offset = "0x697B390", VA = "0x18697CD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x697C8E0", Offset = "0x697AEE0", VA = "0x18697C8E0")]
	public CKOOEIIDEHN NLJDAILEENN(Matrix4x4 AFJHLFMCCIJ)
	{
		return default(CKOOEIIDEHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x697C6D0", Offset = "0x697ACD0", VA = "0x18697C6D0")]
	public static CKOOEIIDEHN GPFKHFGHMNC(Vector3 MCPNOOFMAHG)
	{
		return default(CKOOEIIDEHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x697C4F0", Offset = "0x697AAF0", VA = "0x18697C4F0")]
	public readonly KAFMIGBJCLH CDCNIFIHLDI()
	{
		return default(KAFMIGBJCLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OLHIGLNMOEI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6985090", Offset = "0x6983690", VA = "0x186985090")]
	public static CKOOEIIDEHN HGEHKHIGKDJ([In] this KAFMIGBJCLH HLIDMKMINHN)
	{
		return default(CKOOEIIDEHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum GJJFFHCHHGB
{
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct AEFONANNJHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly GACPEHAEABE IBPIHMNGPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private readonly GJMJCOBOHDO POEEJACEFHK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xDF1F20", Offset = "0xDF0520", VA = "0x180DF1F20")]
	private AEFONANNJHG(GACPEHAEABE GNLDGJDNMDL, GJMJCOBOHDO COBDOHAPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x697C480", Offset = "0x697AA80", VA = "0x18697C480")]
	public GGDFCMAGDGD MEPDHNJOOPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x697C320", Offset = "0x697A920", VA = "0x18697C320")]
	public static CBDPDIPONCF<KHOPCPBIAPE, AEFONANNJHG> ENFOKLPNHAF(MMCMEEHMPDE<COKMANPFJNC> COBDOHAPBGO)
	{
		return default(CBDPDIPONCF<KHOPCPBIAPE, AEFONANNJHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x697C3D0", Offset = "0x697A9D0", VA = "0x18697C3D0")]
	public static CBDPDIPONCF<KHOPCPBIAPE, AEFONANNJHG> ENFOKLPNHAF(GGDFCMAGDGD COBDOHAPBGO)
	{
		return default(CBDPDIPONCF<KHOPCPBIAPE, AEFONANNJHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x697C260", Offset = "0x697A860", VA = "0x18697C260")]
	public static CBDPDIPONCF<KHOPCPBIAPE, AEFONANNJHG> ENFOKLPNHAF(string OJHOPJNOCOK)
	{
		return default(CBDPDIPONCF<KHOPCPBIAPE, AEFONANNJHG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum GACPEHAEABE
{
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DGIBBHKKCLP : IDisposable, NMIKCMNNCCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private NativeList<CPDENJNCAAG> NIIEKCONAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private float HAMMDALLPNP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PPJODBBIPDM MHHKMDMDNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
		[CompilerGenerated]
		get
		{
			return default(PPJODBBIPDM);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x871860", Offset = "0x86FE60", VA = "0x180871860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool CBJEEMNCIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x697DA20", Offset = "0x697C020", VA = "0x18697DA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool ENLPJLNNNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x697DC80", Offset = "0x697C280", VA = "0x18697DC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<GILGLNGMBEA> GOAGAOLGLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HCKJFCGIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x697E920", Offset = "0x697CF20", VA = "0x18697E920", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float LCIBLFGCBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x697F620", Offset = "0x697DC20", VA = "0x18697F620")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x697F760", Offset = "0x697DD60", VA = "0x18697F760")]
	public DGIBBHKKCLP(PPJODBBIPDM MCGGLIKAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x697DA30", Offset = "0x697C030", VA = "0x18697DA30", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x697DD00", Offset = "0x697C300", VA = "0x18697DD00")]
	public Vector3 JHEBGJKMIKK(int EAHBLIIOOON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x697D000", Offset = "0x697B600", VA = "0x18697D000", Slot = "6")]
	public Quaternion AJMDBOKBNJM(int EAHBLIIOOON)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x697DA90", Offset = "0x697C090", VA = "0x18697DA90", Slot = "5")]
	public Vector3 FHFOJNNCGON(int EAHBLIIOOON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x697E420", Offset = "0x697CA20", VA = "0x18697E420", Slot = "7")]
	public float LCOBKLLFAJM(int EAHBLIIOOON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x697ED30", Offset = "0x697D330", VA = "0x18697ED30")]
	public void ONLNAALEFOH(Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, float PKDKCKJPOHP, bool OMLNBLEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x697E3C0", Offset = "0x697C9C0", VA = "0x18697E3C0")]
	private bool KKKGCBAKEAG(int IGJNLDFHEJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x697D0D0", Offset = "0x697B6D0", VA = "0x18697D0D0")]
	public void BHEPJJACMDJ(Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, float PKDKCKJPOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x697E330", Offset = "0x697C930", VA = "0x18697E330")]
	public void KCHIHGFIGCB(int IGJNLDFHEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x697DB30", Offset = "0x697C130", VA = "0x18697DB30")]
	public void GFEEDCHPKOG(int IGJNLDFHEJH, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, float PKDKCKJPOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x697EB80", Offset = "0x697D180", VA = "0x18697EB80")]
	public void OCOJPKLCMOG(int IGJNLDFHEJH, float3 MCPNOOFMAHG, quaternion GLKHDAMNPBA, float PKDKCKJPOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x697E960", Offset = "0x697CF60", VA = "0x18697E960")]
	public void NAEGFELIFOA(int IGJNLDFHEJH, Vector3 MCPNOOFMAHG, float PKDKCKJPOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x697E1D0", Offset = "0x697C7D0", VA = "0x18697E1D0")]
	public void JHFDEIKDKDE(int IGJNLDFHEJH, Vector3 MHHLIPGJMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x697D230", Offset = "0x697B830", VA = "0x18697D230")]
	public static Quaternion BOJPBJBCIFB(Quaternion HPAIEAFGHDJ, int IGJNLDFHEJH, float NNGLPCHNLHE, NMIKCMNNCCC LECMHIHADPE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x697E480", Offset = "0x697CA80", VA = "0x18697E480")]
	public Bounds LLACKCIMCNB(Transform AFJHLFMCCIJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x697DC90", Offset = "0x697C290", VA = "0x18697DC90", Slot = "10")]
	public virtual void IJHNODKBGKD(bool EEJLEAMBJHL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x697EAB0", Offset = "0x697D0B0", VA = "0x18697EAB0")]
	public NativeList<CPDENJNCAAG> NHHACLMLCNG(float CPBMPMMIDIM = 1f)
	{
		return default(NativeList<CPDENJNCAAG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GILGLNGMBEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public float3 GJMAELHLBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public float PHILPKFOFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public quaternion DCBACMCIJKC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x699BAD0", Offset = "0x699A0D0", VA = "0x18699BAD0")]
	public GILGLNGMBEA(Vector3 KIPJBGAHLFJ, Quaternion HPAIEAFGHDJ, float PKDKCKJPOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x699BA10", Offset = "0x699A010", VA = "0x18699BA10")]
	public Quaternion OJGMMEIACOF(Vector3 GKDEFPHJFPJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x699B560", Offset = "0x6999B60", VA = "0x18699B560")]
	public GILGLNGMBEA CHIDAJNKCOE(Vector3 MJAKLHCOKII, Vector3 FBOODEKKKFM, Vector3 FEOEBAGBFMO)
	{
		return default(GILGLNGMBEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x699B860", Offset = "0x6999E60", VA = "0x18699B860")]
	public COOBDCGCKEO CKAHFBLJPGI(Vector3 GKDEFPHJFPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class MPCCMALALMM : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x699D690", Offset = "0x699BC90", VA = "0x18699D690", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x699CDD0", Offset = "0x699B3D0", VA = "0x18699CDD0")]
	private void CJOBNIAFPEL(Dictionary<Guid, Guid> HAHFFDPNMOO, CBFLHPGADMO ECJLMJBKAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x699D3B0", Offset = "0x699B9B0", VA = "0x18699D3B0")]
	private void CJOBNIAFPEL(Dictionary<Guid, Guid> HAHFFDPNMOO, ENOKMLKBMJK EIMKOCBEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x699D410", Offset = "0x699BA10", VA = "0x18699D410")]
	private void CJOBNIAFPEL(Dictionary<Guid, Guid> HAHFFDPNMOO, HAHBFOLCGJO IDDPDBGPMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public MPCCMALALMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class EIEFNHLIEIB : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x699B0F0", Offset = "0x69996F0", VA = "0x18699B0F0", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public EIEFNHLIEIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class KJDNPODFLHF : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x699C960", Offset = "0x699AF60", VA = "0x18699C960", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public KJDNPODFLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KNGAJDPBJOM : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x699CAC0", Offset = "0x699B0C0", VA = "0x18699CAC0", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public KNGAJDPBJOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class EIHPNODBCHM : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x699B1A0", Offset = "0x69997A0", VA = "0x18699B1A0", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public EIHPNODBCHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class PFDIIOEBKKD : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x699FAF0", Offset = "0x699E0F0", VA = "0x18699FAF0", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public PFDIIOEBKKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class FGMFOLICFIL : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x699B3C0", Offset = "0x69999C0", VA = "0x18699B3C0", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public FGMFOLICFIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class IGLPAGNFLOF : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x699BB50", Offset = "0x699A150", VA = "0x18699BB50", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public IGLPAGNFLOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JPJLHOEKKFO : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x699C670", Offset = "0x699AC70", VA = "0x18699C670", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public JPJLHOEKKFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MBAFKKNLFNO : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x699CC10", Offset = "0x699B210", VA = "0x18699CC10", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public MBAFKKNLFNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JFHJEBEOANN : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x699C570", Offset = "0x699AB70", VA = "0x18699C570", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public JFHJEBEOANN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KALPGEJBBAP : MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public static readonly LBAPCNMOIHJ HKDCCGPIHMD;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x699C830", Offset = "0x699AE30", VA = "0x18699C830", Slot = "4")]
	public void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public KALPGEJBBAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MCPIOOMJMKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public ELBNLBENCKK CICFELNCFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public GDIIPENBABF FNCFGPKLFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public Dictionary<int, int> GJLMFCCLPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public Dictionary<Guid, Guid> LJJHIFENPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public MCNHAODPHFE MJMBGEHPCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public bool BJPJHFIPEHA;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MOEPGOLDOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAAIHONPMHI(OIEEHDLNBDL GPAAIKCJAMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OONHHNDCFHF
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private static readonly MOEPGOLDOEC[] IAJLGHKDAMB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x699E990", Offset = "0x699CF90", VA = "0x18699E990")]
	public static void BMAOLMCFGGL(LDEHKHFLDMK MMDLBEBNCGC, Dictionary<Guid, Guid> HFALPLCOEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x699EC20", Offset = "0x699D220", VA = "0x18699EC20")]
	public static void LAHMLHOJGLL(LDEHKHFLDMK? MMDLBEBNCGC, FJPPDHHMEMK INBFBDODOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x699EEB0", Offset = "0x699D4B0", VA = "0x18699EEB0")]
	public static void OIMJPIEKGCC(LDEHKHFLDMK? MMDLBEBNCGC, FJPPDHHMEMK KJALPENJDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x699F130", Offset = "0x699D730", VA = "0x18699F130")]
	public static void OKINPNOEIOH(OIEEHDLNBDL GPAAIKCJAMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct OIEEHDLNBDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public ELBNLBENCKK DIIMMNLOHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public LDEHKHFLDMK FJBKCCGEENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public Dictionary<int, int> GJLMFCCLPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<Guid, Guid> LJJHIFENPCM;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x699E8E0", Offset = "0x699CEE0", VA = "0x18699E8E0")]
	public Guid KBCEMLGCNDJ(Guid IJNLNGBKEAC)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MCNHAODPHFE
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KKMFLBPKILM, [Out] Guid MJEKCKFFLEL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class AFEBNMIJKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private readonly HashSet<string> JFIGOBIMDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private readonly Dictionary<long, int> IFGNGCKKEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private readonly HashSet<Guid> PJCCFCLMPGM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<string> EFJCKHGHIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyDictionary<long, int> JCOLIEAFBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x699A2C0", Offset = "0x69988C0", VA = "0x18699A2C0")]
	public static AFEBNMIJKPK FGDHBMNAEGO(PIMCJABKION FPDNBDDHMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x699A680", Offset = "0x6998C80", VA = "0x18699A680")]
	public static AFEBNMIJKPK HNOPCOMDKDK(DILLDOHMMJP JEGOMFHNKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x699A500", Offset = "0x6998B00", VA = "0x18699A500")]
	public static AFEBNMIJKPK HAOMMHOCLII(IEnumerable<string> JFIGOBIMDKP, IDictionary<long, int> MEPDKHHOOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x699A760", Offset = "0x6998D60", VA = "0x18699A760")]
	private AFEBNMIJKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x699A880", Offset = "0x6998E80", VA = "0x18699A880")]
	private AFEBNMIJKPK(IEnumerable<string> JFIGOBIMDKP, IDictionary<long, int> MEPDKHHOOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6999B00", Offset = "0x6998100", VA = "0x186999B00")]
	private void DADDGJDKGHO(PIMCJABKION FPDNBDDHMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69995D0", Offset = "0x6997BD0", VA = "0x1869995D0")]
	private void DADDGJDKGHO(DILLDOHMMJP JEGOMFHNKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x69997C0", Offset = "0x6997DC0", VA = "0x1869997C0")]
	private void DADDGJDKGHO(EGGNHEHGNIN? OPJBDKMKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x699A0F0", Offset = "0x69986F0", VA = "0x18699A0F0")]
	private void DADDGJDKGHO(IKGHPMJOIBK? EMDFCFPCFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6999D00", Offset = "0x6998300", VA = "0x186999D00")]
	private void DADDGJDKGHO(LDEHKHFLDMK? FJBKCCGEENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x699A6F0", Offset = "0x6998CF0", VA = "0x18699A6F0")]
	private void JHCLBNKDDDJ(string? JIECKKHOAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x699A420", Offset = "0x6998A20", VA = "0x18699A420")]
	private void FHMMGHCFBCB(ILONKDFGNGH? AACFFNGOHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x699A330", Offset = "0x6998930", VA = "0x18699A330")]
	private void FHMMGHCFBCB(APJKOFHNBLG? AACFFNGOHAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NICOCGDNAEN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class BLFNHDALOOK : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private readonly IEnumerator<DictionaryEntry> JGMPEELHOOB;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DictionaryEntry HGFNAJAPAOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x699ACE0", Offset = "0x69992E0", VA = "0x18699ACE0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x699ADB0", Offset = "0x69993B0", VA = "0x18699ADB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object FJLALGMPANI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x699AE60", Offset = "0x6999460", VA = "0x18699AE60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x699AC00", Offset = "0x6999200", VA = "0x18699AC00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
		public BLFNHDALOOK(IEnumerator<DictionaryEntry> JGMPEELHOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x699AB60", Offset = "0x6999160", VA = "0x18699AB60", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x699ABB0", Offset = "0x69991B0", VA = "0x18699ABB0", Slot = "9")]
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
		private sealed class BBOIIKIOCAB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xC70640", Offset = "0xC6EC40", VA = "0x180C70640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x699AB10", Offset = "0x6999110", VA = "0x18699AB10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
			[DebuggerHidden]
			public BBOIIKIOCAB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x699A9C0", Offset = "0x6998FC0", VA = "0x18699A9C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x699AAC0", Offset = "0x69990C0", VA = "0x18699AAC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x69A0200", Offset = "0x699E800", VA = "0x1869A0200", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IDictionary.this[object IBBDLGCDELM]
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x69A0110", Offset = "0x699E710", VA = "0x1869A0110", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x69A02F0", Offset = "0x699E8F0", VA = "0x1869A02F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x69A0050", Offset = "0x699E650", VA = "0x1869A0050", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x69A00B0", Offset = "0x699E6B0", VA = "0x1869A00B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x69A0290", Offset = "0x699E890", VA = "0x1869A0290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x699FD10", Offset = "0x699E310", VA = "0x18699FD10", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x699FD70", Offset = "0x699E370", VA = "0x18699FD70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x699FDD0", Offset = "0x699E3D0", VA = "0x18699FDD0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
		public RoomObjectCounts(Dictionary<int, int> EFDKJDGDBJH, [Optional] Dictionary<int, int> FFCPFCCFHIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x699FC30", Offset = "0x699E230", VA = "0x18699FC30")]
		[IteratorStateMachine(typeof(BBOIIKIOCAB))]
		private IEnumerator<DictionaryEntry> CNJGOJPNLFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x69A0340", Offset = "0x699E940", VA = "0x1869A0340", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x699FF50", Offset = "0x699E550", VA = "0x18699FF50", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x699FE30", Offset = "0x699E430", VA = "0x18699FE30", Slot = "9")]
		void IDictionary.Add(object IBBDLGCDELM, object DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x699FE90", Offset = "0x699E490", VA = "0x18699FE90", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x699FEF0", Offset = "0x699E4F0", VA = "0x18699FEF0", Slot = "8")]
		bool IDictionary.Contains(object IBBDLGCDELM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x699FFF0", Offset = "0x699E5F0", VA = "0x18699FFF0", Slot = "14")]
		void IDictionary.Remove(object IBBDLGCDELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x699FCB0", Offset = "0x699E2B0", VA = "0x18699FCB0", Slot = "15")]
		void ICollection.CopyTo(Array FAJBEEIFFCK, int PDMMEDBMFPP)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class CJOOJFPCNND : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0xC70640", Offset = "0xC6EC40", VA = "0x180C70640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x699B0A0", Offset = "0x69996A0", VA = "0x18699B0A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
			[DebuggerHidden]
			public CJOOJFPCNND(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x699AF10", Offset = "0x6999510", VA = "0x18699AF10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x699B050", Offset = "0x6999650", VA = "0x18699B050", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x699C280", Offset = "0x699A880", VA = "0x18699C280", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IDictionary.this[object IBBDLGCDELM]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x699C150", Offset = "0x699A750", VA = "0x18699C150", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x699C330", Offset = "0x699A930", VA = "0x18699C330", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x699C090", Offset = "0x699A690", VA = "0x18699C090", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x699C0F0", Offset = "0x699A6F0", VA = "0x18699C0F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x699C2D0", Offset = "0x699A8D0", VA = "0x18699C2D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x699BD10", Offset = "0x699A310", VA = "0x18699BD10", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x699BD70", Offset = "0x699A370", VA = "0x18699BD70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x699BDD0", Offset = "0x699A3D0", VA = "0x18699BDD0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6370", Offset = "0x1FE4970", VA = "0x181FE6370")]
		public Invention(long DAIJJLLIENA, int BMKFLHFENBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x699BC40", Offset = "0x699A240", VA = "0x18699BC40")]
		[IteratorStateMachine(typeof(CJOOJFPCNND))]
		private IEnumerator<DictionaryEntry> CNJGOJPNLFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x699C380", Offset = "0x699A980", VA = "0x18699C380", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x699BF50", Offset = "0x699A550", VA = "0x18699BF50", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x699BE30", Offset = "0x699A430", VA = "0x18699BE30", Slot = "9")]
		void IDictionary.Add(object IBBDLGCDELM, object DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x699BE90", Offset = "0x699A490", VA = "0x18699BE90", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x699BEF0", Offset = "0x699A4F0", VA = "0x18699BEF0", Slot = "8")]
		bool IDictionary.Contains(object IBBDLGCDELM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x699C030", Offset = "0x699A630", VA = "0x18699C030", Slot = "14")]
		void IDictionary.Remove(object IBBDLGCDELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x699BCB0", Offset = "0x699A2B0", VA = "0x18699BCB0", Slot = "15")]
		void ICollection.CopyTo(Array FAJBEEIFFCK, int PDMMEDBMFPP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> DLCGFEHMHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public readonly IReadOnlyList<Invention> OEEODLAHFHM;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
	public NICOCGDNAEN(IReadOnlyDictionary<Guid, RoomObjectCounts> ODBGBDOFOEF, IReadOnlyList<Invention> LPFNNLMDHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x699DDD0", Offset = "0x699C3D0", VA = "0x18699DDD0")]
	public static NICOCGDNAEN FGDHBMNAEGO(PIMCJABKION FPDNBDDHMAO)
	{
		return default(NICOCGDNAEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x699E7C0", Offset = "0x699CDC0", VA = "0x18699E7C0")]
	[CompilerGenerated]
	internal static int JBFMGFCDNJL([In] IReadOnlyDictionary<long, int> EGDPHAMIJJM, long? FOGINBIBBFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x699D710", Offset = "0x699BD10", VA = "0x18699D710")]
	[CompilerGenerated]
	internal static void BKPHPEIBHOA(int NGNLJOFNJLF, [In] EGGNHEHGNIN HFDNMNFEPKO, [In] Dictionary<long, int> EGDPHAMIJJM, [In] Dictionary<Guid, RoomObjectCounts> ODBGBDOFOEF)
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
