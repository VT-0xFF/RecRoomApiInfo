using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Mathematics;
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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67ED4B0", Offset = "0x67EBCB0", VA = "0x1867ED4B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GFFFNCEHGAB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> LEILBCLMJNP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> FPCHKCNIBBL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> GICLLHJPGKE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string MNLKEEBEAHK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string GNFLNLIADCB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string MBBKNGKCDHO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67D3340", Offset = "0x67D1B40", VA = "0x1867D3340")]
	public static bool AFCOBGLOBIL(Guid JIFEJCAHOLI, int JBPDKGKBJIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67D3440", Offset = "0x67D1C40", VA = "0x1867D3440")]
	public static bool DBDGPMEOKCL(Guid JIFEJCAHOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67D34D0", Offset = "0x67D1CD0", VA = "0x1867D34D0")]
	public static string JHGOFCLIIOB(Guid PGOHCHKMLGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GPLMNAOFLDO]
public enum FCBCPIKPPFH
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
public static class OINKLCKHLJL
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid NODGBHFOENO;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid JKPBIKJFADH;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid FHNEFHOEMLN;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid IGDIGMPPGHA;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid INCDEDOPEKI;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid GPKGCCAJHCP;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid ELLEAEJCIHK;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid MFCPGFAMMJM;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid NMNHFPMBKIH;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid LBHIEILKNID;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid KNOCINOJBDP;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid GPCDHAKIDAL;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid AMLEPHADPHK;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid MJBENDDMHIK;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid BBLMFINFLEC;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid PIBFLAJJAAN;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid PPLFDKEGIEL;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid KCAAHILLBFI;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid ADJDLHOHDOP;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid GKKBOCOIFIH;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid FFLAJHHCIHK;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid LHAKGEEJFKB;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid PAKICAGENCJ;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid OHFNFMHKKGC;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid BOEOACGKHHA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid EDJHOHPDNCG;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid IJDPAMBELFH;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid HFFMFGOEPHF;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid BPENKNOECNF;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid EMDACOJNPIK;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid NPAJJJCOPPO;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid KINJJCDKAOD;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid OIFDLPDABJM;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid BDKMKJBIFCG;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid BLNMMDPPMPK;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid POABMONBJOE;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid LDDHEDLFGJB;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid FJEAPIIKFLJ;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid OLKKLCBLLAP;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid LIDGIBEKGBF;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid GIJPBGPGNBB;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid ALOOKPEGCFJ;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid HEJJMFAEPAO;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid DBJICDDIGJH;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid IJKLBMFBLPE;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid APLONCAOJDP;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid NFNJHMDGKIO;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid KNFDLPFMKIE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid HCOBEEJKBFL;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid MNFGCHOAFPP;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid HAGLLKKBGBK;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid MMCBKNOAILN;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid JLNDGGLILKD;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid FLJPCBABAPA;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid LDFFGAJFBJD;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid BBJBPFAEPEA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid MGEDMLIFLIG;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid ODOGKLLECHM;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid FHKNPCJPDII;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid BODOLPMOCAK;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid MNDEDEJKFBL;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid EFJDICBIFDB;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid FHOHEJLNGFP;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid FILBFNBIJFJ;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid EMACBDMPLJP;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid DHDKMIBIEHE;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid CPDMNNIDKNN;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid BCOPNLCEIOG;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid MHCMOGMKGIJ;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid NCEEKEFIHLL;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid HOHENAIEAAG;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid FNBJAKIMKJH;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid OLHNOHAEEMN;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid JHFPHEPJJJJ;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid ELPLHFDBIIK;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid PIDECOAEAMM;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid LPCGKHHKPBJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid HKJKEHIBJDE;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid AGMNMNMMEFN;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid PGCABHGJANB;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid EEBGGBJKIGH;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid OBLBAKDFBAH;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid JNAJAHIKLKL;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid LBGDIDJFAHB;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid NHOLFMOHGNF;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid BEEHKPJGBMH;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid PJPDJGGBKNI;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid BCAGDFLPEHJ;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid MGCJIINBODP;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid KKKCCHHPPAJ;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid JKELCJDFEGA;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid EBJJNIOMIDG;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid GHLFHIEDOJE;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid IKOCKECOPBD;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid JEEIAAAPFJE;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid IFJKEPILGFN;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid OHKDBHCIBDA;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid CCPNDBDLMGH;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid AOMOBKDDINH;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid MPHIBKMJKKN;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid OPPEJCJGJAD;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid APPJLIJGNDH;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid HFJGHKHDOMH;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid GIFBGPMDMOC;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid GAKIIPPPOAM;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid JKBEHAONCFM;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid AKMGCDOEPPN;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid EDNNLHAHJAB;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DHNFPCLABND;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid IHINNJEDJPE;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid HDMBOCGEGAE;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid AIIKJFHGGCJ;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid HODPIPPDEBB;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid DKLNKKAHLCI;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid JCCIGMPFLLJ;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid NLAJICFLIFP;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JJIAFKCAALG;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid AJGPPGDJMGM;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid NBKACGDOEBN;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid FKDJAOBNFOG;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid LBILGPMGIIG;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid JIPGBNHEDKB;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid MOPKKMGJHBG;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid NINDCCBGBDB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid EOPJHMDHLLI;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid BNKIOCIPCHC;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid LPELBKFDPLD;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid LELCEEIBGBI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid MPDFODFFEGO;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid JPILMBLJPGO;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid IBEKCKDKILF;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid NEKCHOOCMLD;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid EHABPBCBIEK;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid AEOABHFBIMB;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid NIJAOGPEIDN;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid DCIIMOBPAMK;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid PBIBMLGFPEE;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid IAOFPBMEJKE;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid CFONDCIEKIO;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid GPKCDGAPGNC;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid HFAOGEEJIFJ;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid IEBFPFKENKC;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid ODCAIANCKGJ;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid ILLJKHMHFNM;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid AMMLCCBCKFA;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid CEHALJJODIE;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid CCOKIJJJDBH;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid JOFJCGPMKKD;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid ENMAGJOEEEM;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid MFCLFGNFIHF;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid IBKOHMMGFHM;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid GLIOOBFGFII;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid CJPANFAKOOB;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid LGPCLEJDOGL;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid IKADMELAFJG;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid LIJAHPAALDL;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid MMCIPODCNME;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid EMIKEJLOKCJ;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid GEBFAGBKHBD;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid NJBFMPOLKBD;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid HFDJABMINFI;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid IDCLOOKNIIE;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid KOLHELNAOIL;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid GNHPNMBLANL;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid ILFMMNNPLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid CEHCDDEPDDP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid BDMGADCKFDM;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid MALKDKDAGGN;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid DAEOEMCMJMA;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid COBMJIKBLPI;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid KBGKFOFPKJE;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid DBABFCIBFLG;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid GMFIKJJDDBH;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid PMEKFPCFDEI;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid FLOAAMAHJCA;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid LFAODFFIMGI;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid JBADFMHJLIA;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid BABCAAPMPDK;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid KDFNMPKHBEC;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid GGFJBIBFBLO;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid PCNBFNGEBJI;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid EDGLIOOAMMK;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid BPMMGNFKCLP;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid HBLBLELGDJG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid ACODBOPFOKG;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid LBMKDNFEGBF;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid PIHMDCFGDGB;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid MFOIPAAJIBC;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid GGIENJCONPK;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid HLJIDIALDBA;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid CMADELABPAP;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid DIINGNOGEME;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid PEHHHBJEPEP;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid NOLFFDKDEIL;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid ENLGKNJMFDN;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid DPBLHKLNNJC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid LLFNNADGLHG;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid CMHFIGEEHKC;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid KHODIHGGPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid INFKAMALDMG;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid MMLHFENOCMK;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid AHOAENEHMJN;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid NBDAGHLPPIJ;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid IBIAFPJONDB;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid PPIPDDHOOLM;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid AIIIOLGAJEA;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid NEJCDAMHJJE;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid IOKIGNHBHOF;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid EKPHJDLPKAA;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid IEHHEMODDHD;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid MJFKFBJPKLG;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid KBHPDFJGHAP;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid OEKINOAIEGF;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid JAOLHBECEGD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid LAPAHBNODHO;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid POOBONKLABL;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid IDAMAAFGDDB;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid FLGPGMHJOEC;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid KCIHILKDBIF;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid LOCMAOMMFKJ;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid BECPPJOLMFH;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid CFDMJMFDLCF;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid HLGNFKPFKNH;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid EDIGOPKIMEF;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid PKFJAICBBGL;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid AOEFPPCANDC;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid POLGKDJHMAA;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid NGJOHGNCPKM;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid CCOPOMKKPGJ;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid NEFLIKPGADP;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GHPGHBFNMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid EEMAJLJEHFK;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid PLJJMIMFHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid NCBHJHFKFIF;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid HOOKNFONEBN;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid FPJHAFIJJFK;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid LBMGHGMDGLF;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid AFGHICIICNH;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid DODAIJMGGPI;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid MFFPKNFODEK;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid DIBECMPEPPB;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid CIDKFEDIINA;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KMGBCHDFELP;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid OBNOBLAKJNH;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid IHNONCFGMLN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid JCEFJPKBFEA;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid CMIDJKJJACO;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid HDOHFBLKNMD;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid MAHNCHDBOAL;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid ENBENEACEKM;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid KCLFDOHIEFC;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid KBDIGJHKBCB;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid PFDGBJMLNCM;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid JODGFOJHEKK;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FPKBGJJFIGD;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid MCJDJDOCEIC;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid NBJKICKMENA;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid ACMFIHFFPOI;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid IFNAHLCDMCJ;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid NGMPOBHAJJP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid FGJKEKNHIND;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid KLBCHJOJDFH;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid JBAOOECBFAI;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid EJHENNPAPOA;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid GNAOICDNPCP;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid OFIECNCGCBN;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid KGMLBGJCPNC;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid HDGCNPFBIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid PGCNOOIOCMK;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid BDENKKEKLPD;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid JFJOPELBOIO;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid EDGBJPJCOGD;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid BKELGKBFNLA;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid GKPBEGOCHAA;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid PEPGJPNHHEH;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid EMEDBPHAHHA;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid ODHIMOEJEDB;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid KNHCCJFJBMP;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid MNKHBOPNOPA;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid FCEMAGCFBEI;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid DOECAPEBCFH;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid MPAJDHKNIEP;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid JLCELJJDOGC;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid AFKHOIPHOBL;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid BDEAFOHDBHN;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid BJPFEFAMIJG;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid HAFDKIIPEHN;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid PJNJJKLBCCN;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid KIPHOOJCJMC;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid PGOPMEICFBI;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid GCEKELGIFKI;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid NJKJPJFOBBA;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid NJMDFLJEPIP;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid IJHLENEDLMB;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid GLBCDEFEIAE;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid EOOMHBPACFI;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid GFCJIILMHIH;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid FDGMIPOFBFF;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid ELKCFBFBIAB;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid JOPJHEBCLEK;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FBOEACMDPCP;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid FFMDIAOPCIE;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid LFGKNKAHFGB;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid DDMDNICKODA;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid HHDALGLJDPM;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid PPOHEODOOLP;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid BOOBPJGDJCO;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid HGDIFLJMIBA;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid FFOHMCFNMEC;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid AOOFOLACAPJ;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid NBFHOKABBHP;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid EEJICLABBNM;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid KPMFHOHEJHB;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid KAIOKMBABIM;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid HILOEDMEPFF;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid DOOHDLLPEHF;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid LAHMMOCCAPF;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid LLNMNIGJCKM;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid KAPMPJHNFNJ;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid ELILCEGJEFJ;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid BEPNOALCMPN;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid LPGKOCGIJMJ;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid MCJKMGIDJEI;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid ILDJAHJGIHI;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid JHJFNAIMOBK;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid PLMKDNOHIJG;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid KOIDLGLBKHI;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid DLANBKJJHCD;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid HDKCMFEMMGG;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid NABEIKMJIOK;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid DPLLAEDJBFG;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid AGAMDBDBGJC;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid FNCDBFJNFLE;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid CCIGEOBCKAP;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid ABKLGKIMCNJ;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid FLKLNLIDMDO;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid FOLELJIHGFB;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid KPIBIDGDPLB;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid OCDDNCOKBFH;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid JFNGHKNPHPD;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid BCJMOLNCOPA;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid ENNHDEHCGHP;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid AMPIPDMBBFG;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid GHPKPHLALCE;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid BBJNHNKBPFH;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid KFCDKFEMJGI;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid KPGLHMEEMEH;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid GOPLDEOOAIA;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid GCJPKOFEPMK;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid OAAAAMAPHEI;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid JPNCOCFLADB;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid DIFEIOCFMOD;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid LKEAHKBAFHB;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid MKGJBNHOJAN;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid NHJOCACJPHP;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid MBHMMKIDMPP;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid JKCLOKJOPDG;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid FLMNBDKFOMF;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid CMIFHBHIEHM;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid MNHFKHAPOGD;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid LPLBAILKCHH;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid FKBJFEFOJAL;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid BPHGCJBAIHF;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid AKHOEGIJJDA;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid FPBIBLIKKKE;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid HOHAHGPABAF;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid PPIMCJEMGNM;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid AKCHLPFOEPO;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid CJPOACJBMMK;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid ILGKHMBDPKB;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid AECODCNDPJH;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid DFLHBFJFJOC;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid FCBLKAAEAEJ;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid GOAIOFBDIMB;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid NMDOFPCJEJO;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid ICNBENENMDN;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid AOCMCJLAPLO;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid LCBKLFOPKLP;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid ODIHPIJELBK;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid AAFLBNCMEHF;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid FGJBEBIHJAF;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid EHDJOPDHBCN;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid CHLCIPFJGAB;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid HKEMPNNKNAI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid MAOFAHHNPDN;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid MKLJCHHJLCN;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid NJPBHBMBOLJ;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid CGNDPLBJIJM;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid LCOAOJCBLEL;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid DKMPKIBKMOM;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid PPBNAFKBMJC;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid NPILDALLEGE;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid CCEFGHBBHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid EMIBEHDGPNL;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid JBIBBGBNPPA;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid PNLGENHDDPB;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid IIFFKKHIHPH;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid PNFMMPBMOHP;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid GIEOCCBOBCI;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid EHAGPHGDCCH;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid BFBKNJBCPGH;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid NDCNHAAECEI;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid NHPCPAEEHND;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid CNNCPAPAEGA;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid FKOANOEPLEK;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid HJKADAMENAP;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid BOLKJIFIBEC;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid NMBKNNELMKB;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid KGFDLEMCHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid NONEFPOKCKO;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid NMJJIJGFMLB;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid ECCGPAKMAKL;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BLBIGDJNNIL;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid EMMLILAEDLA;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid DKDAJKLJBLF;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid IFFPCECGDEL;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid IGNPJNNFMNL;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid ODDAKNHHJEI;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid AGPJBOGGEOO;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid NAHNGBNJAKE;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid EKKEFGLMAEH;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid IOMEOOPDJMD;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid DEEFLIEMIDL;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid IJLNKLJCFDG;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid HNINLCLHGOO;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid BJOCDOKIAKA;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid CMHPKNPIMJN;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid OKMIELHFHGF;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid IPAJLMFEHHF;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid MMBFMBAIIHC;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid NGKMNMDLDBF;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid POPNBNOPNGH;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid LNBPLIBLBEH;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid KEJCPOCPENL;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid LGHMFOAJLND;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid FBJEECBGNJJ;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid EAABFFBFEGO;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid PCGPJPEHHHL;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid LAFEFBPBAHG;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid FPENKOEJBCH;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid JIOMEADIIKC;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid PLFPHLGAHBE;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid EPIAONPDMNF;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid HOLLBKOJKLI;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid NONGOBFIDNL;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid JLJAGDODFMA;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid IDCMCEFMDLO;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid DDFPKKFMBHJ;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PCGAKKHHKJM;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid EHCOPLCNLOI;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid NEELKGKDEOD;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid GFOBLBMMBPF;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid NJKGCBAELLH;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid GAMFCMOJKPK;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid JEKDGGIKNCA;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MOHGBGPMGCG;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid OMIIMNFLBJB;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid LKJHPFNNMHE;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid LCKMOPFNCMF;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid OHIJHHCBDON;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid DFMPEKIFMFL;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid JMCFDIDNDDK;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid NDBCBLBDLAA;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid LHBMDJHKMAE;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid GEKCFLFJIGK;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid BGNEGLBHHDL;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid HONAHNMAJDN;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid JHNILONLOPD;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid OMJJPCAPNLE;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid GNLOKGOLMAI;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid IGKONFGMOJN;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid BKEGALEDPHB;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid HHHPDAFOECD;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid CNBFDLAIBEE;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid JNCPNBCDNCD;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid FHKBGLMNHPM;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OCHKACAOLFK;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid NDMGFLDLMHO;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid AJDGGHEGHJC;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid CFHOJKPIELI;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid PNMHLFAHLEO;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid NKJBHKGPELG;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid BOGLGNCNCNG;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid JJIKIMNJLLA;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid GGMLLHHGPDJ;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid EGCMKBKINDG;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid JNMECJEBHBO;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LLGJHFFKEND;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid OANPCFGBEDE;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid NGPPJJIKMOF;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid IELMOBLDHMA;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid BCLDENNFLGB;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid GCAMJJIGCKF;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid PKJNLOCJCPP;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid MCEJMPDFKBG;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid AALGIAJPNGG;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid GMNGLONENOH;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid CLKLAMJMLLJ;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid CJCDGFHLECN;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid CHFBLGIALPK;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid PGODNPJIEIB;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid CHGCODEEMIF;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid NPNEMGIDHNN;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid KBPMHDDNMKM;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid FDHIADJINKJ;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid KMFFOJBLPBH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid HIEPFGDHHIE;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid IBIFFMGCOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid MLBEALEODCH;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid DCJIOFKGBAF;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid KKGILFJKBII;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid BCCFGPOAAOF;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid ECHKDJEKBCF;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid GEGPNCAJEKN;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid MDKFFMABPKK;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid FOFBMLBGKAO;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid MHLNJCGHBOG;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid GJIGLAJJNAM;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid NCACBHDHFGM;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid HNLOBPEMLFJ;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid GDAFEMIGGCA;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid BIDEPKBGCJH;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid MIMOFFCCBNG;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid LAKNCEHOCJJ;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid FKPMCGOANFA;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid BHLIBGMBIJM;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid EAJBHHENNPE;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid EPGCKDJJEKI;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid HBEJILFCNLO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid KDDOJDCGOIB;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid KPLNOGDDGJD;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid FMEOLPFDAGE;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid BGOBJHFAEDO;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid CDANEMLAMPO;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid KNNFNOOAGMF;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid KDMKCIAMDBP;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid EOCECHKOBGO;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid BKNHPMKBJKO;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid AGGKBCEKNKP;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid IAILDJDHDEE;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid CLLKGBHMENN;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid IPMNHLIOMPG;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid NLKCPFCKGCF;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid MBAAPLDCHAE;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid JIEJFFAJLOH;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid JIFLLFMEHFF;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid PBNIMNEJAPE;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid DOLOEJENJFL;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid CBOGGIFKEMF;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid POFONOKMIJL;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid HAIOPOGPAMJ;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid PMLMFPABCKG;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid PJIANLOOCPJ;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid HGPDEDLJPHK;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid CFFLPOEJDEB;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid OBMDPIKJGCC;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid FJGKLCKIPLM;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid CKGNNFHIHIP;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid FGLEMBNMCBD;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid DLPDNELBCEM;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid CNNEMFHJCII;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid DMOINOPGLIC;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid OEBAAIBMCBM;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid GCFEPEDJFON;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid IPEAOPPFFAC;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid COJEGOAKCNM;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid EPHGKOCBKGN;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid ALLNBLKPBDO;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid KLCEBGGPNNO;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid BDNDOMFGKKI;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid GHCGBBIOIJP;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid PELFJKJOOPA;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid MOJNNCFDEMO;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid CONDKMLHGEP;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid BPPEMPACKDF;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid DMJIPHFNJBM;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid ICFNFGNGNKG;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid GMAADENHOAI;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid OCIKNIDJDKC;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid CCEAAMMPCDO;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid GKLJBHEKEJP;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid COHPPJCMKPC;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid EBAJHEDENLO;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid OBFOFDIAKKM;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid DFACINNMCAB;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid MGICKDCGJPL;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid AOBJBFNIFJP;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid FEOAGPDMABG;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid ANAICIDPGPF;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid JJEHKBCMCEP;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid BBEAAMBBJBL;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid HBFPCJEAPDA;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid POKKBIPOHMI;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid MCEKDDNAMKO;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid HIPKPMEKBKE;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid IGIBMPDNCFK;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid FGPGHIIPMGB;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid JHNENBFAHOI;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid IPKFPKNDJHI;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid ICBAJKDEKMD;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid PLDONMBIPBF;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid JNBDLKHHEMC;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid PNLKNCBEMLB;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid OCCONFFFFCL;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid GBENOLLNPHB;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid HMELBOLMBAK;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid BFKPBDNGDBE;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid KJMCFAFGHEO;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid AKKGBNPMKAE;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid KJBGNFMKKLO;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid LFOKBAGPOEI;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid KGMCENIMPNJ;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid GMCJPHDLMFN;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid IKCHBIEMGDF;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid MFGHPNGCCEI;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid JKMAOBBFBNP;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid ECJFJOPLIBP;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid JBPOCFINKKP;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid PDOLMOAJJNH;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid AGNBHGKPPOG;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid BNFOALMHLEI;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid NANGJOLFLPA;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid HDMGNCNFLBB;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid LJJAKHBOKCK;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid ICMEJBMAJMC;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, FCBCPIKPPFH> FBEENBOGDBP;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<FCBCPIKPPFH, Guid> GGGFGHIKCGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, FCBCPIKPPFH> NJAPJEDMCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67ED580", Offset = "0x67EBD80", VA = "0x1867ED580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<FCBCPIKPPFH, Guid> CIDHMCJONEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67ED530", Offset = "0x67EBD30", VA = "0x1867ED530")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KNNPDAKGDOE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67EC910", Offset = "0x67EB110", VA = "0x1867EC910")]
	public static bool KHKIIOMLHAI(HJFJIPGFDID CFGCNPGHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67EC560", Offset = "0x67EAD60", VA = "0x1867EC560")]
	private static bool KHKIIOMLHAI(AHHNIAPMJCH JDHFDNPAKDL, HJFJIPGFDID CFGCNPGHFKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JLFPCMNEMHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly CJADAAFBGMJ KOMDKEKOKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<FHCGEGKCGMN> PJMKHGGJGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<FHCGEGKCGMN> ADAOHFIHGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IKEJNODLDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<EOFGJNJAJLP<GHBFIOLFDBB>> DJEDBMOBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString JDCFPALPAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly EGNELGNFODM LNEPDJKHOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool KAOPENKCCPG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67E91A0", Offset = "0x67E79A0", VA = "0x1867E91A0")]
	public JLFPCMNEMHM(CJADAAFBGMJ ABACPADKLPB, IEnumerable<FHCGEGKCGMN> JDMOMCFHMKL, IReadOnlyList<FHCGEGKCGMN> FIMNJNPCEBD, KPFGDODNFBO<GPCAGFNHADK> MAOCFENGGHE, IReadOnlyList<EOFGJNJAJLP<GHBFIOLFDBB>> FHAAJKEDOCB, ByteString FGNEBANJCKB, EGNELGNFODM EPBCFCEKFLM, bool HHNEALLHAEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EHAJGOGBEDA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(NKGGJHKCAPD MLKNGAFFKGE, [Out] Dictionary<int, int> FOFOPLILBNG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(NLENJFNFFEI DHADGELAIIB, AECFLMLJDII BKLDGKPCFKM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HJDEGOELPNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid MAFHAHEJIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> JHJPPAHCMIH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> FGNKPOHENBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x39FBC50", Offset = "0x39FA450", VA = "0x1839FBC50")]
	private HJDEGOELPNH([In] Guid CPIHLMJNHLF, Dictionary<Guid, Guid> DMCELDLGNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x67E9120", Offset = "0x67E7920", VA = "0x1867E9120")]
	public static HJDEGOELPNH MCNLDBLCLED(IReadOnlyDictionary<Guid, Guid> EIELFFEMOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67E8D70", Offset = "0x67E7570", VA = "0x1867E8D70")]
	public static HJDEGOELPNH LFCFCGAACNH(IEnumerable<KeyValuePair<Guid, Guid>> EIELFFEMOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67E8BB0", Offset = "0x67E73B0", VA = "0x1867E8BB0")]
	private static Dictionary<Guid, Guid> CCIIKHLEPKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x67E8C60", Offset = "0x67E7460", VA = "0x1867E8C60")]
	public Guid JBMJMMCNCJJ([In] Guid PGOHCHKMLGH, bool JGHDEEIJOPA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x67E9130", Offset = "0x67E7930", VA = "0x1867E9130")]
	public bool PHELBPJCLNA([In] Guid EGNLNANJFMI, [Out] Guid EHDJGDOIOCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MGGMLNICMLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FBKFCHCPOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKPMANIAHDL(ByteString LPKKJDFMNJA, HJDEGOELPNH BOPKANGKMFK, [In] UniformTRS GLJCBFLFMEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IJPEBHKBDGO
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
public class NDHFHJDNNHM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x14A6C30", Offset = "0x14A5430", VA = "0x1814A6C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EMKGIBPHFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xFC8530", Offset = "0xFC6D30", VA = "0x180FC8530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long JHMDIOEKAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67ED490", Offset = "0x67EBC90", VA = "0x1867ED490")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x64F3640", Offset = "0x64F1E40", VA = "0x1864F3640")]
	public NDHFHJDNNHM(long POAAACAIHKJ, long OELBPALMFPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GHHCPBCLMBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, NDHFHJDNNHM> MBBNNBLLJKG;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> LPCILFJPLNA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long AGFEIMAENEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xFC8530", Offset = "0xFC6D30", VA = "0x180FC8530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long JDOGHFOKDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10266D0", Offset = "0x1024ED0", VA = "0x1810266D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67D4B70", Offset = "0x67D3370", VA = "0x1867D4B70")]
	public static GHHCPBCLMBG HAJHDDBIDOL(CJADAAFBGMJ PODMMCINPOP, EOFGJNJAJLP<GPCAGFNHADK> DFBFBBDPKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67D48A0", Offset = "0x67D30A0", VA = "0x1867D48A0")]
	private void BJIEBOFDOPN(NOABPNGHFKH DDLCNKGIKEK, long MIOKPJEMGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x67E8B20", Offset = "0x67E7320", VA = "0x1867E8B20")]
	public GHHCPBCLMBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NCBPCNELLJH
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<FCBCPIKPPFH> FGIAGMBNIHM;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LADMBLBPPPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> FDBDIDIJBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> AOEOPEDHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
	public LADMBLBPPPP(IReadOnlyDictionary<Guid, Guid> JOPNGMFEGJC, IReadOnlyDictionary<Guid, Guid> LKJFDCEGILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KBCFHENHLCG
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x67E9840", Offset = "0x67E8040", VA = "0x1867E9840")]
	public static KEIGDMPNBOB FNFLHNNBALP([In] JLFPCMNEMHM HIPIKKGFDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67EB2F0", Offset = "0x67E9AF0", VA = "0x1867EB2F0")]
	private static void LCIIHOHEAKO(KEIGDMPNBOB MLCLBJOCOKL, [In] JLFPCMNEMHM EJEKFPFBLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67E99C0", Offset = "0x67E81C0", VA = "0x1867E99C0")]
	public static bool GGPJNFMHAOM(KEIGDMPNBOB MLCLBJOCOKL, KGEDOBHFBOJ FOPBKLLOELK, HJDEGOELPNH? OJPAAJINHHB, [Out] LADMBLBPPPP? DMCELDLGNHA, [Out] string? EBFMCGAMIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67E92D0", Offset = "0x67E7AD0", VA = "0x1867E92D0")]
	private static void EECOAHPINNE(KEIGDMPNBOB MLCLBJOCOKL, HJDEGOELPNH? NKPOCAOGCDH, KGEDOBHFBOJ FOPBKLLOELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67EC4A0", Offset = "0x67EACA0", VA = "0x1867EC4A0")]
	private static void NPKAKLLIFJN(KEIGDMPNBOB MLCLBJOCOKL, KGEDOBHFBOJ FOPBKLLOELK, IReadOnlyCollection<ByteString>? KNKIKAHIKLB, IReadOnlyCollection<ByteString>? EMODDNONBHG, IReadOnlyCollection<ByteString>? EOLGJCENCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x67EBE00", Offset = "0x67EA600", VA = "0x1867EBE00")]
	private static bool NAPKHHAGPEK(KEIGDMPNBOB MLCLBJOCOKL, NLENJFNFFEI DHADGELAIIB, KGEDOBHFBOJ FOPBKLLOELK, [Out] string EBFMCGAMIGF, [Out] Dictionary<int, int> FOFOPLILBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x67E9560", Offset = "0x67E7D60", VA = "0x1867E9560")]
	private static Dictionary<Guid, AHHNIAPMJCH> EIMCFKDHOON(KEIGDMPNBOB MLCLBJOCOKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x67E9230", Offset = "0x67E7A30", VA = "0x1867E9230")]
	private static void ACBOGODJFGH(bool IFIKJLHEEEA, FHCGEGKCGMN FJLLLIBFOLI, Dictionary<Guid, Guid> BMBFCHDPKAG, HJDEGOELPNH MMPGNFKEKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67EB060", Offset = "0x67E9860", VA = "0x1867EB060")]
	private static void JGMAACNOBGJ(FHCGEGKCGMN FJLLLIBFOLI, Guid AHILGPMIPGO, EDBDBDOAOOL? LIPLBLCMLDE, Dictionary<Guid, AHHNIAPMJCH> KBALNLFLMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67EB950", Offset = "0x67EA150", VA = "0x1867EB950")]
	private static void LIFFNOEKIGH(IEnumerable<FHCGEGKCGMN> GGEGDIKNHMB, IReadOnlyCollection<ByteString> KNKIKAHIKLB, IReadOnlyCollection<ByteString> EMODDNONBHG, IReadOnlyCollection<ByteString> EOLGJCENCGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KGEDOBHFBOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool IFIKJLHEEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public EGNELGNFODM EPBCFCEKFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public EDBDBDOAOOL? LIPLBLCMLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public EDBDBDOAOOL? HGLEFPOPLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public CJADAAFBGMJ FAOIGPKJJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public IJPEBHKBDGO LIIPMJAFMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public EHAJGOGBEDA KBAANDMMAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public MGGMLNICMLE GNEGODGMCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public EOFGJNJAJLP<GPCAGFNHADK> LAGLADJCPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public DIOAIIMAGGE AKILJCODNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<FHCGEGKCGMN> JPDFJKDHLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> KIKDFHHNNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public MGMNADEMONL LLNLLPNOPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool PGBCBDGLIGF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool IBIGBFGPDGC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x67EC510", Offset = "0x67EAD10", VA = "0x1867EC510")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EDBDBDOAOOL
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float PAAPPBCPGHO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 GBKEBGLIOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion LOMIHBHMPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float KEONANJCBKH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 LPHALNEMBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67D30D0", Offset = "0x67D18D0", VA = "0x1867D30D0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS JGOEDLGKENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x67D2940", Offset = "0x67D1140", VA = "0x1867D2940")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xAE2E80", Offset = "0xAE1680", VA = "0x180AE2E80")]
	public EDBDBDOAOOL(Vector3 GBKEBGLIOFD, Quaternion LOMIHBHMPMH, float KEONANJCBKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67D3270", Offset = "0x67D1A70", VA = "0x1867D3270")]
	public EDBDBDOAOOL(UniformTRS HBAOGCGDNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67D2980", Offset = "0x67D1180", VA = "0x1867D2980")]
	public static EDBDBDOAOOL FDHLFJJDABH(EDBDBDOAOOL GGJNHHDMGON, EDBDBDOAOOL OFKHNADCPNJ)
	{
		return default(EDBDBDOAOOL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67D2E30", Offset = "0x67D1630", VA = "0x1867D2E30")]
	public static EDBDBDOAOOL IKACJOLFJPE((Vector3, Quaternion, float) MLKNGAFFKGE)
	{
		return default(EDBDBDOAOOL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67D2E50", Offset = "0x67D1650", VA = "0x1867D2E50")]
	public static EDBDBDOAOOL IKACJOLFJPE(Matrix4x4 AODGAKEHHMD)
	{
		return default(EDBDBDOAOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67D31E0", Offset = "0x67D19E0", VA = "0x1867D31E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x67D2C00", Offset = "0x67D1400", VA = "0x1867D2C00")]
	public EDBDBDOAOOL IJNEPKLOBBK(Matrix4x4 MCHMJHAODPL)
	{
		return default(EDBDBDOAOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x67D2FD0", Offset = "0x67D17D0", VA = "0x1867D2FD0")]
	public static EDBDBDOAOOL JOCNHPIBOOC(Vector3 GBKEBGLIOFD)
	{
		return default(EDBDBDOAOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67D3040", Offset = "0x67D1840", VA = "0x1867D3040")]
	public readonly AELAMIEJJIB NHOICCHEMHB()
	{
		return default(AELAMIEJJIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PJEPFCNFBBP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x67ED5D0", Offset = "0x67EBDD0", VA = "0x1867ED5D0")]
	public static EDBDBDOAOOL PCDKDFGFFPE([In] this AELAMIEJJIB EGJINJKGIAK)
	{
		return default(EDBDBDOAOOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class LLJMDBIFIKK : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x67ED200", Offset = "0x67EBA00", VA = "0x1867ED200", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67EC940", Offset = "0x67EB140", VA = "0x1867EC940")]
	private void AOJFKOOBLCE(Dictionary<Guid, Guid> EDJGPIFEDDM, IICPCKBDFBA PIBBMDDOFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67ED1A0", Offset = "0x67EB9A0", VA = "0x1867ED1A0")]
	private void AOJFKOOBLCE(Dictionary<Guid, Guid> EDJGPIFEDDM, JAAEHLLFNBP BLPJGPALENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67ECF20", Offset = "0x67EB720", VA = "0x1867ECF20")]
	private void AOJFKOOBLCE(Dictionary<Guid, Guid> EDJGPIFEDDM, NPAHKMNGJEF DOCGKKCBKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public LLJMDBIFIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class HGMPKJNOJKK : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67F17B0", Offset = "0x67EFFB0", VA = "0x1867F17B0", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public HGMPKJNOJKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class DLAKEJDGFDC : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67EE960", Offset = "0x67ED160", VA = "0x1867EE960", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public DLAKEJDGFDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class NLPMOAMOGKP : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67F28B0", Offset = "0x67F10B0", VA = "0x1867F28B0", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NLPMOAMOGKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class FJOGABAKKAN : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x67EEC70", Offset = "0x67ED470", VA = "0x1867EEC70", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public FJOGABAKKAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class KKBELKLLDCH : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x67F2530", Offset = "0x67F0D30", VA = "0x1867F2530", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KKBELKLLDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class NOIMPMNKBAL : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x67F2A00", Offset = "0x67F1200", VA = "0x1867F2A00", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NOIMPMNKBAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class OEIECBIHGJD : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x67F2B90", Offset = "0x67F1390", VA = "0x1867F2B90", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public OEIECBIHGJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GLLNIIGNLOI : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67EF070", Offset = "0x67ED870", VA = "0x1867EF070", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public GLLNIIGNLOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class EBFFHOPPHBF : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67EEAC0", Offset = "0x67ED2C0", VA = "0x1867EEAC0", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public EBFFHOPPHBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class AMFGPNBONKH : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67ED700", Offset = "0x67EBF00", VA = "0x1867ED700", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public AMFGPNBONKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OFFMKIEIIFK : BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly NEPMGLFEHBI OCEFNCGGKJM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67F2C80", Offset = "0x67F1480", VA = "0x1867F2C80", Slot = "4")]
	public void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public OFFMKIEIIFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HJFJIPGFDID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public NLENJFNFFEI MBDJOBPGDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public MBKKCGPDFGI MKPMGAPGGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public Dictionary<int, int> LMDEKIAOEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<Guid, Guid> JHBEOIAEFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public MGMNADEMONL LLNLLPNOPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool CDAFJEIOFEF;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface BCDICGGMNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBIGLKCFIBK(NIBOBNEPIBM LKFCLBHJCGN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DEDLAKIHHHA
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly BCDICGGMNFJ[] NNMGAGJNFCK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67EDA90", Offset = "0x67EC290", VA = "0x1867EDA90")]
	public static void INHMGIMIDHL(FHCGEGKCGMN MLKNGAFFKGE, Dictionary<Guid, Guid> DLOBHKFJDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x67ED800", Offset = "0x67EC000", VA = "0x1867ED800")]
	public static void HJGFANACNAF(FHCGEGKCGMN? MLKNGAFFKGE, HJDEGOELPNH GDIFFCDGAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x67EDD20", Offset = "0x67EC520", VA = "0x1867EDD20")]
	public static void IPMCDKBNEGN(FHCGEGKCGMN? MLKNGAFFKGE, HJDEGOELPNH MMPGNFKEKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67EDFA0", Offset = "0x67EC7A0", VA = "0x1867EDFA0")]
	public static void KHKIIOMLHAI(NIBOBNEPIBM LKFCLBHJCGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NIBOBNEPIBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public NLENJFNFFEI BPJFEEHFLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public FHCGEGKCGMN FJLLLIBFOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public Dictionary<int, int> LMDEKIAOEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public Dictionary<Guid, Guid> JHBEOIAEFJF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x67F2810", Offset = "0x67F1010", VA = "0x1867F2810")]
	public Guid ANBKNGNONNE(Guid PGOHCHKMLGH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MGMNADEMONL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int PLFPHNIMIED, [Out] Guid BIDEJBPPALF);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class GNHMNAFBOMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private readonly HashSet<string> INJIENPOFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private readonly Dictionary<long, int> LENENPCFFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private readonly HashSet<Guid> CLBPOJOPCJG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<string> CENGKLNAHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> HJKCFFNABCI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x67F04A0", Offset = "0x67EECA0", VA = "0x1867F04A0")]
	public static GNHMNAFBOMC KJOGDFHOKCC(JGEEHKGDOJK OLHDNFLDIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x67F03C0", Offset = "0x67EEBC0", VA = "0x1867F03C0")]
	public static GNHMNAFBOMC CBCOJEEKABK(KEIGDMPNBOB OIDLBMGEBNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x67F06E0", Offset = "0x67EEEE0", VA = "0x1867F06E0")]
	public static GNHMNAFBOMC OPIGFEKIJDG(IEnumerable<string> INJIENPOFEG, IDictionary<long, int> OJCIIOCOJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x67F1690", Offset = "0x67EFE90", VA = "0x1867F1690")]
	private GNHMNAFBOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x67F1550", Offset = "0x67EFD50", VA = "0x1867F1550")]
	private GNHMNAFBOMC(IEnumerable<string> INJIENPOFEG, IDictionary<long, int> OJCIIOCOJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x67F0C50", Offset = "0x67EF450", VA = "0x1867F0C50")]
	private void PEKLCGKJDEC(JGEEHKGDOJK OLHDNFLDIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x67F1020", Offset = "0x67EF820", VA = "0x1867F1020")]
	private void PEKLCGKJDEC(KEIGDMPNBOB OIDLBMGEBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67F1210", Offset = "0x67EFA10", VA = "0x1867F1210")]
	private void PEKLCGKJDEC(PPEMLGPHPLC? AHKBBGKKCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x67F0E50", Offset = "0x67EF650", VA = "0x1867F0E50")]
	private void PEKLCGKJDEC(EGMDOGLJGFG? DDLCNKGIKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x67F0860", Offset = "0x67EF060", VA = "0x1867F0860")]
	private void PEKLCGKJDEC(FHCGEGKCGMN? FJLLLIBFOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x67F0430", Offset = "0x67EEC30", VA = "0x1867F0430")]
	private void GFDFOECDEKF(string? JFONOCKPODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x67F0510", Offset = "0x67EED10", VA = "0x1867F0510")]
	private void MBPPEOKKJPP(IKPJBMIDDGN? JMMAOIHBNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x67F05F0", Offset = "0x67EEDF0", VA = "0x1867F05F0")]
	private void MBPPEOKKJPP(ABGMCHMEGHN? JMMAOIHBNIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct GNCACPDKMDH
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private class HMNGABJKJFN : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private readonly IEnumerator<DictionaryEntry> PLIDPKHELGD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry KBLPKKPAKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x67F19E0", Offset = "0x67F01E0", VA = "0x1867F19E0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x67F1AB0", Offset = "0x67F02B0", VA = "0x1867F1AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object JDDKPJKLOJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x67F1B60", Offset = "0x67F0360", VA = "0x1867F1B60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x67F1900", Offset = "0x67F0100", VA = "0x1867F1900", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
		public HMNGABJKJFN(IEnumerator<DictionaryEntry> PLIDPKHELGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x67F1860", Offset = "0x67F0060", VA = "0x1867F1860", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x67F18B0", Offset = "0x67F00B0", VA = "0x1867F18B0", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class NDPBHFGAALE : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xBF3DE0", Offset = "0xBF25E0", VA = "0x180BF3DE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x67F27C0", Offset = "0x67F0FC0", VA = "0x1867F27C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public NDPBHFGAALE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x67F2670", Offset = "0x67F0E70", VA = "0x1867F2670", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x67F2770", Offset = "0x67F0F70", VA = "0x1867F2770", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x67F3380", Offset = "0x67F1B80", VA = "0x1867F3380", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object JOEHGGMHBAA]
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x67F3290", Offset = "0x67F1A90", VA = "0x1867F3290", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x67F3460", Offset = "0x67F1C60", VA = "0x1867F3460", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x67F31D0", Offset = "0x67F19D0", VA = "0x1867F31D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x67F3230", Offset = "0x67F1A30", VA = "0x1867F3230", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x67F3400", Offset = "0x67F1C00", VA = "0x1867F3400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x67F2E90", Offset = "0x67F1690", VA = "0x1867F2E90", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x67F2EF0", Offset = "0x67F16F0", VA = "0x1867F2EF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x67F2F50", Offset = "0x67F1750", VA = "0x1867F2F50", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
		public RoomObjectCounts(Dictionary<int, int> HJIJFGGFOLI, [Optional] Dictionary<int, int> DJOBEDGOJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x67F2DB0", Offset = "0x67F15B0", VA = "0x1867F2DB0")]
		[IteratorStateMachine(typeof(NDPBHFGAALE))]
		private IEnumerator<DictionaryEntry> AKOGEKHHDCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x67F34B0", Offset = "0x67F1CB0", VA = "0x1867F34B0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x67F30D0", Offset = "0x67F18D0", VA = "0x1867F30D0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67F2FB0", Offset = "0x67F17B0", VA = "0x1867F2FB0", Slot = "9")]
		void IDictionary.Add(object JOEHGGMHBAA, object IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67F3010", Offset = "0x67F1810", VA = "0x1867F3010", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67F3070", Offset = "0x67F1870", VA = "0x1867F3070", Slot = "8")]
		bool IDictionary.Contains(object JOEHGGMHBAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x67F3170", Offset = "0x67F1970", VA = "0x1867F3170", Slot = "14")]
		void IDictionary.Remove(object JOEHGGMHBAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x67F2E30", Offset = "0x67F1630", VA = "0x1867F2E30", Slot = "15")]
		void ICollection.CopyTo(Array JAOFFCELONG, int JBDLDJOINOF)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class FMJJPICJDEO : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0xBF3DE0", Offset = "0xBF25E0", VA = "0x180BF3DE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x67EF020", Offset = "0x67ED820", VA = "0x1867EF020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public FMJJPICJDEO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x67EEE90", Offset = "0x67ED690", VA = "0x1867EEE90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x67EEFD0", Offset = "0x67ED7D0", VA = "0x1867EEFD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x67F2250", Offset = "0x67F0A50", VA = "0x1867F2250", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object JOEHGGMHBAA]
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x67F2120", Offset = "0x67F0920", VA = "0x1867F2120", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x67F2300", Offset = "0x67F0B00", VA = "0x1867F2300", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x67F2060", Offset = "0x67F0860", VA = "0x1867F2060", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x67F20C0", Offset = "0x67F08C0", VA = "0x1867F20C0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x67F22A0", Offset = "0x67F0AA0", VA = "0x1867F22A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x67F1CE0", Offset = "0x67F04E0", VA = "0x1867F1CE0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x67F1D40", Offset = "0x67F0540", VA = "0x1867F1D40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x67F1DA0", Offset = "0x67F05A0", VA = "0x1867F1DA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1F26840", Offset = "0x1F25040", VA = "0x181F26840")]
		public Invention(long EGNLNANJFMI, int POAAACAIHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x67F1C10", Offset = "0x67F0410", VA = "0x1867F1C10")]
		[IteratorStateMachine(typeof(FMJJPICJDEO))]
		private IEnumerator<DictionaryEntry> AKOGEKHHDCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x67F2350", Offset = "0x67F0B50", VA = "0x1867F2350", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x67F1F20", Offset = "0x67F0720", VA = "0x1867F1F20", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x67F1E00", Offset = "0x67F0600", VA = "0x1867F1E00", Slot = "9")]
		void IDictionary.Add(object JOEHGGMHBAA, object IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x67F1E60", Offset = "0x67F0660", VA = "0x1867F1E60", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x67F1EC0", Offset = "0x67F06C0", VA = "0x1867F1EC0", Slot = "8")]
		bool IDictionary.Contains(object JOEHGGMHBAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x67F2000", Offset = "0x67F0800", VA = "0x1867F2000", Slot = "14")]
		void IDictionary.Remove(object JOEHGGMHBAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x67F1C80", Offset = "0x67F0480", VA = "0x1867F1C80", Slot = "15")]
		void ICollection.CopyTo(Array JAOFFCELONG, int JBDLDJOINOF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> GLDIOKGDILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly IReadOnlyList<Invention> CHFKJHPOANB;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
	public GNCACPDKMDH(IReadOnlyDictionary<Guid, RoomObjectCounts> KMNDODBLAJI, IReadOnlyList<Invention> PNLPOCNCBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x67EFA00", Offset = "0x67EE200", VA = "0x1867EFA00")]
	public static GNCACPDKMDH KJOGDFHOKCC(JGEEHKGDOJK OLHDNFLDIIE)
	{
		return default(GNCACPDKMDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67EF8E0", Offset = "0x67EE0E0", VA = "0x1867EF8E0")]
	[CompilerGenerated]
	internal static int HJMIPFLPFGO([In] IReadOnlyDictionary<long, int> FICFJMADGNK, long? DMNHJOOHDEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67EF220", Offset = "0x67EDA20", VA = "0x1867EF220")]
	[CompilerGenerated]
	internal static void AEPOHPJFBMB(int HIGBKJPDNIA, [In] PPEMLGPHPLC JMBGGMHEIIN, [In] Dictionary<long, int> FICFJMADGNK, [In] Dictionary<Guid, RoomObjectCounts> KMNDODBLAJI)
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
