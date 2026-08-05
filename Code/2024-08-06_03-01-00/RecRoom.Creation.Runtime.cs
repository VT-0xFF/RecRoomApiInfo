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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6944950", Offset = "0x6942F50", VA = "0x186944950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AGNEENPINKM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> FNFKHCJLDKD;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> BBNCBBGPNOE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> CKHJMNMPDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string KIINJFBHNKG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string BDNDCKGKCIH;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string EMOPAJPDBFD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6927F90", Offset = "0x6926590", VA = "0x186927F90")]
	public static bool FMIMIPGEBBD(Guid LLFEOFOCJNM, int DJEGKHODMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6928090", Offset = "0x6926690", VA = "0x186928090")]
	public static bool OKEIHINFPKB(Guid LLFEOFOCJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6927910", Offset = "0x6925F10", VA = "0x186927910")]
	public static string DAKCKMFCNBJ(Guid DHEKBCJKGBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LFOJOBBHHBD]
public enum HHAHAFDOCFL
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
public static class LLDAFLLELIK
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid FMOJLMOIDCA;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid GBJMJODMBFJ;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid EAOEHAGMBHC;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid HDOGCJKJBHJ;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid AEIJOACAKCE;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid HEPBPIPPHBP;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid HMJILLEPNGN;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid NGFEIKCJGDH;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid MMKDEOEKEFI;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid GCADNNJEJLD;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid HOADLEDNECJ;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid JKJLMAIEMKD;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid FAJLHEIIKPH;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid CCPKGCIENGO;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid PGOAGFBGOKJ;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid AIBIJIBFLFG;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid FHHJHLDGLGL;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid DCOOAPBPBBH;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid FAGMKDDOLDJ;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid JDDKJPNEIMJ;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid CPCCOFLFPIC;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid DKFCOMAPHHK;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid CFNLIMKNCKJ;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid NIGOLEDCKAC;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid AOHAENMAIIN;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid IPKLANNGICM;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid NLEGOGPIAOO;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid MBKNDLOCEOJ;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid CIOIGOCJGNB;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid NCBGLFMAFJM;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid NHOMMLCCODK;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid HNCAKMBAIKL;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid KHCLNGBBIKK;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid HFPBANDIMAG;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid GACLLMHBDHK;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid EGPJNCILEHN;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid OJAINPNPFOK;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid NJEFECDLEOD;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid EJDDPIPCGKE;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid PDFMFLHKIBH;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid EMOPAIBLPFP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid AFLECPKDFNJ;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid HBHNKIFLJMB;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid GKNMHIOODKF;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid HLBHDCPGLJP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid ABHKCGPEAFJ;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid MHIAOMHFOIL;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid BMMPHKOPOHO;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid JLBGNBOKIKD;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid CHAEHGNAJMA;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid NHBPBFMFNDC;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid OJKECJGACAF;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid EHAFNFIPHKP;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid FMGFBCEHMGG;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid FEKLEGNDDFE;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid PKCDEAMHPIL;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid PAAJFEDNHDF;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid BHICDKPKOHI;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid EHDMMIIHKKK;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid LEIECHBOFCG;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid LLGIPCBJJOF;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid KPDJLIADBPB;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid DOGKFHILCMC;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid BDADACACOAK;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid GFLIKCKEAKD;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid INKKHPJOICI;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MHLOHFKGNBM;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid PDBFPMPBKLH;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid BHEMAIEOGDN;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid DLPIFBKPHGI;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid AOJEHNPPPFA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid BBJNCANJMEJ;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid JGDHNLIOCKA;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid NNPDACNDGJL;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid CKCGIHGDHLA;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid DJLMLNPDNKA;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid PLAOAEEJGFG;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid JDOAEMFDKPD;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid HAHAABJBDOF;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid PAIBGGJKODB;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid MEDMCKMLHHP;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid EDIHAAIIIHI;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid FBBDFNHMCFI;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid JOLEHAIDKJA;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid GALBHGKOBNH;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid BLIFAKIKMIL;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid NOEKBAOKMCC;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid EMNCKIBCMIM;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid NBNFJDOPFND;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid LHGCPMCKFDC;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid JOBEGIOJLAJ;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid NFHDJOPHHHE;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid KLFKDOPFAGD;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid NCMFDJGFGPM;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid HJABFPFKLNJ;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid GPDBNMDEIAJ;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid MGNJPCCFHKJ;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid EAKMCJPMOJB;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid JEMMLBFNEBO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid AHELLCOJJBB;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid DIOJHMMDDOH;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid LBIJCBBEMCD;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid MBHLCLAAACL;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid DAIFAIICIAM;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid OADCJJLLKPF;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid JDGOLKJLDCI;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid EDCIMMEMCLK;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid KJKLMPJLBAL;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid HBBLCBJHILH;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid HDBLDLFFBKI;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid EGKPDMKGBJC;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid FMPKGAENCHC;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid LILPPMEIKAH;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid OPDJGDHMMFA;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid PCACANPMINH;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid MJPKBACAKNJ;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid FMKBACLINBB;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid OMBONOOOJBL;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid AILHPBEIEAI;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid OPFEFGCEPNM;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid CBHKENNIEJF;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid OPMLIGNMJKL;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid CCDKLIDKALK;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid NOMIEKCNAMP;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid IEEPJDBOPKL;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid DBOMFJOHBKI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid FPDCJJKDLJG;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid LGKIEEIGKBF;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid NEEIGKNMHAJ;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid APMKLKFHAAA;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid PNDMHNDMNNP;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid FHABCJEKEAI;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid LODMEICFBMA;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid IKEAMCHJNHG;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid MKMNKMKDODD;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid ACCFCKPLNIN;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid EFHJEDMBEHC;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid ACIDCBNNPBL;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid JKNELKLCIHB;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid CGBOPOMKKMK;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid DABMGBAGPGE;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid CFHFGHGOMAB;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid HACHJEEAHMO;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid GPKNGFMAGPF;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid FILLJCEJDMK;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid GLAJDDGPAIO;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid ELDNDINKABP;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid JGEMOCKANJE;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid GCLFLOCGGCL;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid HLKKJEGIPOA;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid GNLHIMEPKJA;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid EJHDFGKOFML;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid HKBHKOIDOFL;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid KINKDBJAEKI;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid OLEHEKGCALA;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid FPBFILGMPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid IBCHENGCHLD;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid NGKIJMGKCEM;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid KKHCGPELLIF;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid FAOJBPNCDLA;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid JHBCLMOJFJJ;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid MIEDMBNCCPA;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid PIJNOEIBDKA;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid FLCBJFCFIFL;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid KKINLGICACF;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid BJNCBBDPBDN;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid DFMGIEFONLM;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid LPDONGELKEI;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid HNOPDOBFCPE;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid JMKLFHFBFLL;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid IJHJONJMLEA;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid NHEMLPKJJDL;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MIOIAMDHJNP;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid AKGHMPPJLLE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid CADMGJPDLMO;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid OINKDILGDJP;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid AHDIGFCGFLA;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid HMOKEAODLHF;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid NKCLPLMLOFK;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid ILNLKDJGBGN;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid CABDIEKLDFG;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid GPBKBNIOPHL;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid CJLEABDAJGB;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid PAJEFPMCEOJ;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid JMJNLPCLIKO;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid NCENEHJGPEM;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid HHDDNMMAPED;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid OBAPJBEANFC;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid BBLNEGLBCGH;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid MFDAFGMECGL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid JDLPIFJGOIF;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid LEDLKPNHKOJ;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid DPMNLJBDEBH;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid EMDAKMLHNNN;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid MJKDNMLBDGO;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid DFAJCAGPCHH;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid FIJPFKMEEAN;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid IHGGFOOJNOP;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid FAIBANEMBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid LHFBBEDBDMN;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid PEOGPFFHKFK;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid IDPDNGBGEEC;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid FBDNEOCMKKI;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid MMICMCHCJND;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid OGFFHIBPHFO;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid KLHLAKDHABL;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid ENIHDJFLPOB;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid LMHNJJOGGOB;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid MJDIDAPAJCM;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid EAHECIPJINK;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid HCLAOEAOEPB;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid KIKCALMALIG;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid LDFOBFHOGHH;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid DJMDGMPFGKO;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid PEPLBEADLAC;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid JOBLPCEOGCF;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid AIOBFLPLPFC;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid OJNCFAPLEGL;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid DPBPDEIAHKP;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid EOPNEOOCNMN;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid GIOAJLDBNKM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid IMHGICJFMJC;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid ODFKLABEMNE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid MLLGACHDKOI;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid CIIINKDMAPL;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid ALLLMFKBIOL;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid MEHBOCIAPNP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid LJANDNNFGIJ;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid HGEBBIKFNIB;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid OKBPDEEGFHH;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid OLDCKFJLPIE;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid NPFEEPEPHOI;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid GLJMHKEMFIG;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid FABBDJCLONH;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid NJBNFELADIP;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid PLNGDNBABDH;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid NLLCLPALKEL;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid GPNNJMEOOPD;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid KPOEGLBCKJH;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid OPMALDLNGNA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid GJLPJIBJPFA;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid GBIANEGPOIM;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid MOKCJONNOLA;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid FLIPMGLCJPL;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid IAHHICPNPDF;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid EDCIADKOBFP;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid NJCDKLCKJBO;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid OMCMMAPPIGH;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid KICFDJLBHLD;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid CDABFDGHBFD;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid GCDLMLLLGLM;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid ANJCOIBCGGH;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid KIENCGLAPHE;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid KBCNIDGFHFA;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FKKPFFNOCKG;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid HADJALBFNCE;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid BHBBHNJICLH;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid MKGEIACCKLE;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid OFECHKGGDOG;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HDKEAHKBBAP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid CBPHGJPEFBB;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid CJCKKNIEJPM;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid PBPOFGEGLOI;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid CCIOCMAAELE;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid CFHGBPKFBAI;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid AEJLLDNCOGJ;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid OJJJBMNGALO;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid HOIFCLDOAIE;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid CMAMLBCJAPF;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid JNCBGEEHIDO;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid OCEINOBBMCM;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid FBGNPBHDFCG;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid KEFMGBNBLDI;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid KAFAPNNHGLJ;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid LMEEKGGCHGE;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid JNEKDPIICAL;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid JAKEHBGJEBC;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid CCMPPPFILKJ;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid HDIGFAPIPBN;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid EJMGPDGLFEA;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid CJAJLABEOJC;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid PJILDCOHMBK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid JECOGIHLKLP;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid CAGMPMKDFJL;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid MPLEPAHGNFA;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid MCLBFIPHDGD;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid COODPGIPDMB;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid FJLOPBMFCCI;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid JJIALAGFHGI;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid DJGEHBOIDEL;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid DJLDGMKABEG;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid GCGEBNDJHLB;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid FEICEKOEPAC;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid NODCFKOHHGM;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid HCCLDMPDHOJ;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid IMKJIAHFMLA;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid EFBOPLGOAAL;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid GAJFKPCLNFC;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid CMBDANNJLDD;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid MNBFLJILBOE;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid DCGNKEEONDO;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid LAPBIKCKCEC;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid IHAPMCNCHPH;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid BEFJNIAHFKL;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid DJNCINAGJMD;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid KMIFHOCACMM;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid ONNPNFHCPHA;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid KHHPPJIBCLJ;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid CNEBNEMAPOO;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid LAKAEBIJAAL;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid HDLMGLEDBIM;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid EGJFBGLJDCA;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid HEMKDOEGBEG;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid CHMCPMFCLKG;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid KHPILFFCFGG;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid IELDDMJPDDE;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid KHMMLJAKMAI;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid GOCKHDJLAGM;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid OBKLAAAFFGE;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid HLIBLMDFBCB;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid MAPAOHOKFIO;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid LIFPMGIPGLP;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid FDOAAOHIEDJ;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid BOJBOAOKECO;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid EJFEJCPFEKD;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid NHKDKJBHLGH;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid ANGFIHIDPEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid BGMEHCNIGEC;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid AMDJDEOMEPM;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid FMFENJCKHNA;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid KCDPOHAOLLB;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid BNCMEMKHNIC;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid PAGOJHJAFPL;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid HNFCNAMKLCE;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid DBOAFKOBDOM;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid EALLBACJKLG;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid KEBFINOOOLF;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid OEOKMBMMCIH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid AKANLIFJHOA;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid NCAAKJABGIE;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid ONNFLFHMOPF;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid NHPOHJBJLFK;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid IKMKIFDIEED;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid EAFEEMMHIIC;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid IOEDIINDADL;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid MGJKDAHGIOE;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid NIEMBNDOCEE;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid LMFLFOKIENN;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid HPDGOIBFKBM;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid GJIGOPFICBK;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid CNEBECMEBHF;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid GLGHNINHIMO;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid LOJJBCNKCKG;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid FOBDPMOFKNI;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FGHHACDBHHO;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid LCNDMAHHCOL;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid IIMEBAHNNMG;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid ADCBAKMBBLM;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid AOKCIEPHKJE;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid LNANLOGJJKO;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid PGHALFPOOGP;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid HIMOPEMOPJF;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid JEIHDBGGNJN;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EAPIIIEPEOO;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid BMBFHMPJIPB;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid BPLEOGHJHDI;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid GLNEILLEMHH;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EMGPOPIOELE;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid HAJAADBFBAP;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid BEDCADJJCCD;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid AJGCHIIENIO;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid LJLNBAOCAFG;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid PNLCPKPEMBB;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid LGMGJNLKGAF;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid GIABGIOMMNM;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid CDKGGLMNIKC;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid POGDDEAHMFM;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid HFPBGHIIOHE;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid GDKALFAMMDH;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid MKLJNELPPBC;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid GPHNFADNIAO;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid KMMPFGBCFPJ;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid GHJNFGAMLIJ;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid GGHOIECIMDI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid BBPHAHHODFJ;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid MJHKOPGMJFI;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid CALJLGFCPIH;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid MGHHAEIIMDB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid AHOPLGBALLG;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid HAMGJFIMHOM;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid HNBFNHEKOAB;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid MKGMNFLJKHP;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid ECJAEOCEFLA;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid CBFCICLONCH;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid IOIHLHKBCDL;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid GDDFCDOFIDF;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid NCOKAHMIEHE;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid PAPFMAMLDJE;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid CKHNGJCCHGC;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid GIIBMPJLHBK;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid MIFMDGOMKFC;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid ELCFFBFIEJD;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid LLKKCDHOKFH;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid ADPNNOKPJKA;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid DDHAECACFJL;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid KIPEPFIECPL;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid KJBGHBLNAFC;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid BNBPFILNBKB;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid AEFNJABGKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid GAHLICNDIBA;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid ACGPAIBPKII;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid DBGAKLOMNFA;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid DOFNNBPMCJM;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid JKKPDMHLNCB;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid JCIOEMLGGAC;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid DODJCLEGHLF;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid ADKOAHICGAM;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid PIHDKCDJIIA;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid IKCPACGADAC;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid CIFCIEMDGIM;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid JKHGJEGGMDE;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid MBCIOBGDFMH;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid JHDFKCNBHGP;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid IDKNHMDOMFA;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid LBFENNNJKBB;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MEJDJGAOFCE;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid GALNDEBKDMD;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid MKFCJODMJDO;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid LJIJNOPEOIJ;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid BAJOMPJKBHI;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid APDEOIBLHAN;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid PKDKILOACOG;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid DINOIJJCHDM;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid CODKKNNMJGN;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid LDDPNEMLCNL;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid AEPGMOMDJJM;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid NBNNCIEGCKC;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid MNGECOLCNEA;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid NGEEOFIEIBA;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid IFLONDAPEJJ;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid BIPNCOINFBI;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid DGGMJINJMOK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid NLOGLCPHKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid LGIPINAODDA;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid PPANEGEEKBL;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid OLMOMAMJINF;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid GHKGEJNDKGN;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid CHBBFNNJMJM;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid GBKDADAOEDI;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid HJOOANPJPOC;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid KDIDNIAHJIE;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid FLFGHPIMJFN;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid NAAFJNMPPAK;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid ICBHPJMNDAF;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid CKELLFJCAFP;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid IGKOCFBACDD;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid CIFDMINPEDI;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid OMJNOOPJHCG;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid NBGHGKDCFDK;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid BEDKAFIIPPE;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid KNANMKAGBNP;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid IMLJAMCBOCD;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid IGNODAAFJAH;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid KLNOLMBNFKH;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid HBFMFLGCKGK;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid JIDHMEIKFDK;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid OLLDOFKDPAI;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid LCOCPKJDPPO;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid EFKAOGLOECH;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid MIMEMOFHNOI;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid ADPNINMFLPG;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid FLHEGJPGDEF;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid PBPDNGIDLJC;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid MCDPIDMDOGB;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid LOEJNPJJKCH;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid EMAKEINOCLL;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid AHKKDMLPNMI;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid EJCDAPAGMBA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid OODMJNLFIMJ;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid PLJHHCKJOIO;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid JPBAJDEJHOP;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid KKIPADEPBJO;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HILHALMNHGL;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid NBKLEPNJCBK;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid EOHCKEAFAMO;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid EKOAPBGIINM;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid AAMEEHFLAMJ;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid PFDMCENPJLG;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid MAEACKHBNNI;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid ALCJNNAJMMN;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid BDFKJJMIHDE;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid EIGNBFKNLMN;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid KPNDMFMKNIE;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid FJBEJOKMHNI;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid KOOCBDJBMMG;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid IJGBJGEPFBC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid DHOHOJEAEGH;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid PGCEOHIBFAM;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid KHJKGGGKMAM;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid FKEDBNHEJKN;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid CJKBDCEIFKK;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid DMAHPMMFKIO;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid CEGCGAMEENL;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid MAPLAJOCJDO;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid MEGFKLGCIEE;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid DALLALDBDCN;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid CIHBPILNPEB;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid PJIKKNFABEH;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid PIPBIHEBAJL;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid NHLMGHDBPFD;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid LMIACGBCIBB;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid BFKGDCNDDNK;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid DLEGCHHDDKG;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid GHJCOCJLPAF;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid MHLECLPLCMK;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid CAACELFIMEH;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid LIDFNDNGLBK;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid BEGBHDJJDHP;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid JGPLDGOFNJI;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid KIJOAKMLGBI;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid GKOFOLCCDJE;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid FNNDAAHBKDP;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid LCIMOPPCFNJ;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid IIFJMPKOFKD;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid JOHLILPILGH;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid IOOADBMBGNG;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid DBJLILMBOEF;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid LFOCMPBJINL;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid EMGBFDJNPIO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid DCECLKFLEGO;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid PDMBKPJJGHP;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid DFMCEPLENPD;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid FNHKCMNCDOA;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid LFAJKNIDAEK;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid IEGLFGCHABB;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid HECFJGHMCFM;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid AMLCNMNPLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid ODNJJHMNPMP;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid NKHMECGJDON;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid LFLKICMOFGF;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid JNABEBCHBHA;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid AEPLJIGGEIC;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid FIPDMMDOPCD;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid COKMFKGJABH;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid MNDFFCHFKGF;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid LMKKOJCOGFI;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid ICOPMICDEAH;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid EFOCLKNIJML;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid ONBCJEDLDCI;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid KNKFNCELNGE;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid DJCBHCHCGHM;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid GJGLPJBAJPF;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid ADCMBBDFNCO;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid NBDIDNHPCPJ;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid MOJLLMKCOBD;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid KLHCIONFDDC;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid KODIADGMJJF;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid BDAKNINJBFJ;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid LALGEPMNANK;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid PMAGGPCIJFO;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid NINEBKDGNJM;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid ILDIKJGGHNC;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid EADNCFEMPJL;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid EIKEPGBHAJP;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid NIHDKAPILCA;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid ADHBBHGIEKA;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid IGMBJJAAFJP;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid DLLPGDMMJNC;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid DDAFDKHOFOA;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid BJAFMFFGOEE;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid CMIGAABMHFF;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid OJNHCNMIFBM;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid MNNKBPJKPOG;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid BAFIABCBENN;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid NLHIKKOLEKC;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid IOLICECINLI;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid IEINJPGHPLC;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid HKJJNKACMEK;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid APGEHBGDCJP;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid PGHGCJLFBOB;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid LDMCMKJAFPG;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid AHKHLBIGFND;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid GGHNONKJACJ;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid GAMHGHCGCKM;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid MMGCEJPILOH;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid PIDLHLGBKLH;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid HJCLCEFIHKE;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid MNIMDLDAOBC;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid ILMPHJBHHHM;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid JAIPFGPIOKP;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid CKBEALCKMFK;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid GHKNPEIOKME;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid MCMKECFIDCN;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid LBBIJBMGIBF;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid KGEKEICCDKA;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid OEKOMFLAHNM;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid MKCCMOJDNAK;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid DFHALEFPMFO;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid IPKFJGGMPKO;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid PNBDEKOMEHI;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid DELFHNEKMPA;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid IBFGOJFFPGH;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid AJFHANPJKME;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid CHHCACEMFCI;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid JCIBKIADDDL;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid BNPBJANGDIH;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid MBCGMOJCENO;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid EJHNPMNGCDC;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid DAABJPJAFFJ;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid HCIKACONCJA;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid GDEOCILIHGC;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid CJIIGILAFPE;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid HFMIELDBIKN;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid PNEGKDCGLIL;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid BKNHDBMJMHD;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid IJEAJCLDAOK;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid MPFLBMABHHH;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid HJODNEGCKOA;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid IIAEEAMAKFK;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid EFOODLJPDKO;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid LDEEJAEGKDN;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid BGMIONEDGCD;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid EPIGMKLFJOL;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid JHLEGDIGIPA;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid OAGGKKHODPJ;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, HHAHAFDOCFL> BDDKAMLNPMB;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<HHAHAFDOCFL, Guid> MHKAFBLNLKI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, HHAHAFDOCFL> PBJDDGNFNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69413C0", Offset = "0x693F9C0", VA = "0x1869413C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<HHAHAFDOCFL, Guid> JPCIGFFMMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6941410", Offset = "0x693FA10", VA = "0x186941410")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HKPKGICPABJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x692CC80", Offset = "0x692B280", VA = "0x18692CC80")]
	public static bool EDLDKLFNGJA(AOGNCADPKGB JGJILGGHIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x692CCB0", Offset = "0x692B2B0", VA = "0x18692CCB0")]
	private static bool EDLDKLFNGJA(ABLMGCJNBPK OEOKIAMGKMI, AOGNCADPKGB JGJILGGHIDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct MIIEKDADNOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly CPNOGJIOCIL DPBIHFEKJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<LMPEJKGKMKJ> JNOHABDNDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<LMPEJKGKMKJ> ANKPFBHPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> CPPCHMLBLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<DCNLFNFGJNJ<KNLAPOPPMHG>> GCDEGMGNGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString BHLDFPJGJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly JEFLMBNLDAA HMOMCFICOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool AOEILMICEHL;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x69448C0", Offset = "0x6942EC0", VA = "0x1869448C0")]
	public MIIEKDADNOF(CPNOGJIOCIL DKALPGNFKGK, IEnumerable<LMPEJKGKMKJ> BAADLIHJODK, IReadOnlyList<LMPEJKGKMKJ> NDOGAGOBPMI, EJDMOINMPCI<ALFNFGCIOCL> PAENKDMKHKJ, IReadOnlyList<DCNLFNFGJNJ<KNLAPOPPMHG>> NIDCCDHMJGH, ByteString LEEAAHJFEDO, JEFLMBNLDAA AFPGLLGLGDD, bool PHEPCCJOLBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JHEBAPBHJCP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(OGEJNBFEALH JHLEMCFOEMF, [Out] Dictionary<int, int> LNKMEICJIFH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(FDIPOBCALOO FAOLANJHEBC, KNLGDOMAKAF CJIAEGPNEKD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HGLHFDADAEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid PKIKDCILPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> FFEIAHOKAIM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> CEONOCLEFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x39D7EC0", Offset = "0x39D64C0", VA = "0x1839D7EC0")]
	private HGLHFDADAEA([In] Guid KDHAJPHEDJL, Dictionary<Guid, Guid> KMLMEHJDFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x692CB60", Offset = "0x692B160", VA = "0x18692CB60")]
	public static HGLHFDADAEA IFKAGKAGJGG(IReadOnlyDictionary<Guid, Guid> FCPPNLOEMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x692C690", Offset = "0x692AC90", VA = "0x18692C690")]
	public static HGLHFDADAEA EHFPGPPAPKN(IEnumerable<KeyValuePair<Guid, Guid>> FCPPNLOEMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x692CAB0", Offset = "0x692B0B0", VA = "0x18692CAB0")]
	private static Dictionary<Guid, Guid> HJIONEOCCOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x692CB70", Offset = "0x692B170", VA = "0x18692CB70")]
	public Guid NHAOKAOMFLI([In] Guid DHEKBCJKGBC, bool MDNMDBFKPPB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x692CA40", Offset = "0x692B040", VA = "0x18692CA40")]
	public bool GJPGICLCGNM([In] Guid KAGKMEDPMHO, [Out] Guid BLNDAAKAALM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PEENGCIDJAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CJMKHLHLMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIPBOAAMMJI(ByteString PDJMPEHKHJH, HGLHFDADAEA KFIPBHFGPHL, [In] UniformTRS CHDMAIGEIAO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IIDOFMCJNNA
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
public class GMHNAICGMDP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x15D9F30", Offset = "0x15D8530", VA = "0x1815D9F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long CPCLLKEPAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x110DB70", Offset = "0x110C170", VA = "0x18110DB70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long IPGBMIPACIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x692C670", Offset = "0x692AC70", VA = "0x18692C670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x66251A0", Offset = "0x66237A0", VA = "0x1866251A0")]
	public GMHNAICGMDP(long FDDANCOAHOL, long FJLPMHMDLKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KPPJLLDKIMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, GMHNAICGMDP> HPDOHBEHKJJ;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> LAHIPBLEFDF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long GBGAJJHDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x110DB70", Offset = "0x110C170", VA = "0x18110DB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long DGKGFMMPEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1168900", Offset = "0x1166F00", VA = "0x181168900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x692D060", Offset = "0x692B660", VA = "0x18692D060")]
	public static KPPJLLDKIMH FFBCNKNHEKB(CPNOGJIOCIL GIJGGDCBIOA, DCNLFNFGJNJ<ALFNFGCIOCL> NBCAECNBPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x692D6C0", Offset = "0x692BCC0", VA = "0x18692D6C0")]
	private void GEHNEHDEFOC(KOIEKIFGPEJ FNNLHNNHGAD, long CNEPOADNOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6941330", Offset = "0x693F930", VA = "0x186941330")]
	public KPPJLLDKIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CKPJIJNPNAP
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<HHAHAFDOCFL> DOKEJLIEFJD;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HJCLCJDHPNA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> GEENOOGIJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> FNLAEMJCMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86D260", Offset = "0x86B860", VA = "0x18086D260")]
	public HJCLCJDHPNA(IReadOnlyDictionary<Guid, Guid> JEACNHLKBDP, IReadOnlyDictionary<Guid, Guid> MPPNJMOEPOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LLDNEIJNCIG
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6942550", Offset = "0x6940B50", VA = "0x186942550")]
	public static ONCEDLMDIKH JLGGAAIFKID([In] MIIEKDADNOF DCLHFLFCENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6941E80", Offset = "0x6940480", VA = "0x186941E80")]
	private static void FGJIPNJIDLO(ONCEDLMDIKH JJHFAKAGCAF, [In] MIIEKDADNOF NHBPPIPLGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6942760", Offset = "0x6940D60", VA = "0x186942760")]
	public static HHANDHIMCMH<HJCLCJDHPNA, EIJIDOKPFCN> MEDJHBCAJBC(ONCEDLMDIKH JJHFAKAGCAF, OPKAODAEEOG IAJEPNHHKNI, HGLHFDADAEA? OHIEPNPNMDA)
	{
		return default(HHANDHIMCMH<HJCLCJDHPNA, EIJIDOKPFCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6941910", Offset = "0x693FF10", VA = "0x186941910")]
	private static void CBLALJLCIMM(ONCEDLMDIKH JJHFAKAGCAF, HGLHFDADAEA? PNLDBDFAJLN, OPKAODAEEOG IAJEPNHHKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69424E0", Offset = "0x6940AE0", VA = "0x1869424E0")]
	private static void GDNFOKOKBMC(ONCEDLMDIKH JJHFAKAGCAF, OPKAODAEEOG IAJEPNHHKNI, IReadOnlyCollection<ByteString>? LJDKINMLNHM, IReadOnlyCollection<ByteString>? DACHJMBJPMJ, IReadOnlyCollection<ByteString>? AICGGDBAFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6944220", Offset = "0x6942820", VA = "0x186944220")]
	private static bool OMALECMKCII(ONCEDLMDIKH JJHFAKAGCAF, FDIPOBCALOO FAOLANJHEBC, OPKAODAEEOG IAJEPNHHKNI, [Out][NotNullWhen(false)] string? BDGJCBKBDPI, [Out] Dictionary<int, int> LNKMEICJIFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6941BA0", Offset = "0x69401A0", VA = "0x186941BA0")]
	private static Dictionary<Guid, ABLMGCJNBPK> DAHDCOLMJAO(ONCEDLMDIKH JJHFAKAGCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69426C0", Offset = "0x6940CC0", VA = "0x1869426C0")]
	private static void JLMFKMKMIGD(bool IJOJLANDMIP, LMPEJKGKMKJ DKPOEEMNGFI, Dictionary<Guid, Guid> EHPJAFILLDG, HGLHFDADAEA HIHKNCHGEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6943F90", Offset = "0x6942590", VA = "0x186943F90")]
	private static void OFPEBDLDJOP(LMPEJKGKMKJ DKPOEEMNGFI, Guid DPMEGLAAAOC, FFJJMBCHLMF? GCAOCACMBMA, Dictionary<Guid, ABLMGCJNBPK> ILPPEFPMNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6941460", Offset = "0x693FA60", VA = "0x186941460")]
	private static void BFLGNPMHJJK(IEnumerable<LMPEJKGKMKJ> IKAIBAMKLBF, IReadOnlyCollection<ByteString> LJDKINMLNHM, IReadOnlyCollection<ByteString> DACHJMBJPMJ, IReadOnlyCollection<ByteString> AICGGDBAFPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OPKAODAEEOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool IJOJLANDMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public JEFLMBNLDAA AFPGLLGLGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public FFJJMBCHLMF? GCAOCACMBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public FFJJMBCHLMF? OPKEILGHBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public CPNOGJIOCIL PDIBJPLODAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public IIDOFMCJNNA BOGNGAOBDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public JHEBAPBHJCP IJPODKAGEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public PEENGCIDJAH LKHMNLIOKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public DCNLFNFGJNJ<ALFNFGCIOCL> BAJCKFAEJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public GBBDKFNBNCO AEHDNEPCNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<LMPEJKGKMKJ> LNBPKLPDENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> IGDJEHPBEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public IHKNJLFCHDE JHCOPLGNBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool BIMAEHBFJIO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool LDLGHPGIABG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69449D0", Offset = "0x6942FD0", VA = "0x1869449D0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FFJJMBCHLMF
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float HIKIDIPKJJF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 LPBGBJBIAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion CNNBBFFJNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float JAGNHLKKADJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 BNJPHPFKADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x692BEF0", Offset = "0x692A4F0", VA = "0x18692BEF0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS HALFKCNODAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x692C460", Offset = "0x692AA60", VA = "0x18692C460")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xC1D260", Offset = "0xC1B860", VA = "0x180C1D260")]
	public FFJJMBCHLMF(Vector3 LPBGBJBIAOJ, Quaternion CNNBBFFJNHM, float JAGNHLKKADJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x692C5A0", Offset = "0x692ABA0", VA = "0x18692C5A0")]
	public FFJJMBCHLMF(UniformTRS HDMALAOJIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x692BC70", Offset = "0x692A270", VA = "0x18692BC70")]
	public static FFJJMBCHLMF AGKABPGNPCP(FFJJMBCHLMF LPFOFJIMHOE, FFJJMBCHLMF HLAFLADFOKI)
	{
		return default(FFJJMBCHLMF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x692C180", Offset = "0x692A780", VA = "0x18692C180")]
	public static FFJJMBCHLMF IHCIOHJGPAF((Vector3, Quaternion, float) JHLEMCFOEMF)
	{
		return default(FFJJMBCHLMF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x692C000", Offset = "0x692A600", VA = "0x18692C000")]
	public static FFJJMBCHLMF IHCIOHJGPAF(Matrix4x4 HOGBHILGLBN)
	{
		return default(FFJJMBCHLMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x692C510", Offset = "0x692AB10", VA = "0x18692C510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x692C230", Offset = "0x692A830", VA = "0x18692C230")]
	public FFJJMBCHLMF JCPMGEMGHPN(Matrix4x4 OGKACMCCFIL)
	{
		return default(FFJJMBCHLMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x692C4A0", Offset = "0x692AAA0", VA = "0x18692C4A0")]
	public static FFJJMBCHLMF LHOOJLHCJDC(Vector3 LPBGBJBIAOJ)
	{
		return default(FFJJMBCHLMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x692C1A0", Offset = "0x692A7A0", VA = "0x18692C1A0")]
	public readonly BDAFJJCFOBE IPDAJADPCCH()
	{
		return default(BDAFJJCFOBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DAOIDPMFCFE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6929170", Offset = "0x6927770", VA = "0x186929170")]
	public static FFJJMBCHLMF DEEEOFGIEEL([In] this BDAFJJCFOBE ELMHNMGFNPC)
	{
		return default(FFJJMBCHLMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum CIDJNGCHAGH
{
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct EIJIDOKPFCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly AEKNCNGLFMI BDMBDJGJEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private readonly PFOLFPHIKGH ONHKHFHOKGB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xEB3A60", Offset = "0xEB2060", VA = "0x180EB3A60")]
	private EIJIDOKPFCN(AEKNCNGLFMI OHOJHKCPKNF, PFOLFPHIKGH AHOOLPLJDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6929200", Offset = "0x6927800", VA = "0x186929200")]
	public ELBAOFNOHCN DAILAKGFEGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6929270", Offset = "0x6927870", VA = "0x186929270")]
	public static HHANDHIMCMH<HJCLCJDHPNA, EIJIDOKPFCN> NKOJKFHACJH(HPDPDFMMHHG<DHABIOOJNOJ> AHOOLPLJDDO)
	{
		return default(HHANDHIMCMH<HJCLCJDHPNA, EIJIDOKPFCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6929320", Offset = "0x6927920", VA = "0x186929320")]
	public static HHANDHIMCMH<HJCLCJDHPNA, EIJIDOKPFCN> NKOJKFHACJH(ELBAOFNOHCN AHOOLPLJDDO)
	{
		return default(HHANDHIMCMH<HJCLCJDHPNA, EIJIDOKPFCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69293D0", Offset = "0x69279D0", VA = "0x1869293D0")]
	public static HHANDHIMCMH<HJCLCJDHPNA, EIJIDOKPFCN> NKOJKFHACJH(string ANEEOEFFCDJ)
	{
		return default(HHANDHIMCMH<HJCLCJDHPNA, EIJIDOKPFCN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum AEKNCNGLFMI
{
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FAIPCPCKLNE : IDisposable, JFGJDKCBFEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private NativeList<GDLIEPHPIEN> NKEBLIPADAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private float NGPOENHDDAI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NOPGGEKHLCF KIHCELNAGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85D1A0", Offset = "0x85B7A0", VA = "0x18085D1A0")]
		[CompilerGenerated]
		get
		{
			return default(NOPGGEKHLCF);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85F4A0", Offset = "0x85DAA0", VA = "0x18085F4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EFOMPFNBGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6929590", Offset = "0x6927B90", VA = "0x186929590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NPNPJKGODOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69294F0", Offset = "0x6927AF0", VA = "0x1869294F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<PCGJMFHEFEC> JKODFGLCJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EFLNBHGFION
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x692AA20", Offset = "0x6929020", VA = "0x18692AA20", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float ENOFNADBJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x692A1E0", Offset = "0x69287E0", VA = "0x18692A1E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x692BBE0", Offset = "0x692A1E0", VA = "0x18692BBE0")]
	public FAIPCPCKLNE(NOPGGEKHLCF NCGAEKDJMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69297C0", Offset = "0x6927DC0", VA = "0x1869297C0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x692A550", Offset = "0x6928B50", VA = "0x18692A550")]
	public Vector3 IOEPBGDEDEH(int HCFIMDJDENP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69296F0", Offset = "0x6927CF0", VA = "0x1869296F0", Slot = "6")]
	public Quaternion DGBBOJFCCBM(int HCFIMDJDENP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x692AA60", Offset = "0x6929060", VA = "0x18692AA60", Slot = "5")]
	public Vector3 KGGNABPJKHN(int HCFIMDJDENP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x692A110", Offset = "0x6928710", VA = "0x18692A110", Slot = "7")]
	public float FKDMKGDGBOP(int HCFIMDJDENP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6929820", Offset = "0x6927E20", VA = "0x186929820")]
	public void EHNFOKKNIAG(Vector3 LPBGBJBIAOJ, Quaternion CNNBBFFJNHM, float PIBBFIKNNCO, bool LOLFLHMBGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6929490", Offset = "0x6927A90", VA = "0x186929490")]
	private bool AFMGKHHOGOM(int AOKKOCKMAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x692A3F0", Offset = "0x69289F0", VA = "0x18692A3F0")]
	public void IFJCANCAOHI(Vector3 LPBGBJBIAOJ, Quaternion CNNBBFFJNHM, float PIBBFIKNNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6929500", Offset = "0x6927B00", VA = "0x186929500")]
	public void BCFHGPDCIHC(int AOKKOCKMAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69295A0", Offset = "0x6927BA0", VA = "0x1869295A0")]
	public void DBGKIACIOBN(int AOKKOCKMAPC, Vector3 LPBGBJBIAOJ, Quaternion CNNBBFFJNHM, float PIBBFIKNNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x692B8E0", Offset = "0x6929EE0", VA = "0x18692B8E0")]
	public void MACLNKAFCJL(int AOKKOCKMAPC, float3 LPBGBJBIAOJ, quaternion CNNBBFFJNHM, float PIBBFIKNNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x692BA90", Offset = "0x692A090", VA = "0x18692BA90")]
	public void NAIJENIAMFC(int AOKKOCKMAPC, Vector3 LPBGBJBIAOJ, float PIBBFIKNNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x692AF90", Offset = "0x6929590", VA = "0x18692AF90")]
	public void LEFIMJCEKMI(int AOKKOCKMAPC, Vector3 FKPHICIEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x692B0F0", Offset = "0x69296F0", VA = "0x18692B0F0")]
	public static Quaternion LJPBHKGNGBC(Quaternion PCAJHGOJOKB, int AOKKOCKMAPC, float KLNLDEBHCOF, JFGJDKCBFEO MBAEPKDOADF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x692AB00", Offset = "0x6929100", VA = "0x18692AB00")]
	public Bounds KJBBCGNJKOM(Transform OGKACMCCFIL)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x692A170", Offset = "0x6928770", VA = "0x18692A170", Slot = "10")]
	public virtual void FNMDKPAOIBG(bool KHHECCCHNAB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x692A320", Offset = "0x6928920", VA = "0x18692A320")]
	public NativeList<GDLIEPHPIEN> GJNEMOKLFOL(float PHLCPHPEIEM = 1f)
	{
		return default(NativeList<GDLIEPHPIEN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PCGJMFHEFEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public float3 MCOMLLJHBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public float MOCIBMEDIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public quaternion NKEKCKBLHKK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6949E40", Offset = "0x6948440", VA = "0x186949E40")]
	public PCGJMFHEFEC(Vector3 MBNBKCOEPAH, Quaternion PCAJHGOJOKB, float PIBBFIKNNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6949A80", Offset = "0x6948080", VA = "0x186949A80")]
	public Quaternion CBDECJIGDBN(Vector3 MJBOPHFMANN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6949B40", Offset = "0x6948140", VA = "0x186949B40")]
	public PCGJMFHEFEC JECELJBIFFJ(Vector3 ICIINCFCCLK, Vector3 NHFHGHDHFFK, Vector3 GCDENLDEAOI)
	{
		return default(PCGJMFHEFEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69498D0", Offset = "0x6947ED0", VA = "0x1869498D0")]
	public LPFCOEAOFLK ABADNBFNOKN(Vector3 MJBOPHFMANN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class BBGHCOGLFNL : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6945420", Offset = "0x6943A20", VA = "0x186945420", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6944B60", Offset = "0x6943160", VA = "0x186944B60")]
	private void MGKAOIHPPGM(Dictionary<Guid, Guid> LBEJNFKPOAP, HIIEBIFLOGI HGKKPJBFAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69453C0", Offset = "0x69439C0", VA = "0x1869453C0")]
	private void MGKAOIHPPGM(Dictionary<Guid, Guid> LBEJNFKPOAP, JNLODIMEFLM EINBPGDHELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6945140", Offset = "0x6943740", VA = "0x186945140")]
	private void MGKAOIHPPGM(Dictionary<Guid, Guid> LBEJNFKPOAP, OCDMEHBIAIJ AGMIBBEKOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public BBGHCOGLFNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class DBILEPOIMFK : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69457F0", Offset = "0x6943DF0", VA = "0x1869457F0", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DBILEPOIMFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class JOMJIFOJLFD : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6949550", Offset = "0x6947B50", VA = "0x186949550", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public JOMJIFOJLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GAJGPGODCOB : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6946DB0", Offset = "0x69453B0", VA = "0x186946DB0", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public GAJGPGODCOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class KOAKHGLALMD : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69496B0", Offset = "0x6947CB0", VA = "0x1869496B0", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public KOAKHGLALMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class ICDIBENPOFI : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6947530", Offset = "0x6945B30", VA = "0x186947530", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public ICDIBENPOFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class GPEGEIFFMAD : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6946F00", Offset = "0x6945500", VA = "0x186946F00", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public GPEGEIFFMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DPCPOEBEBBL : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x69459D0", Offset = "0x6943FD0", VA = "0x1869459D0", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DPCPOEBEBBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CEKEKOBEIPB : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6945640", Offset = "0x6943C40", VA = "0x186945640", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public CEKEKOBEIPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FLEDOJIDPKI : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6946C00", Offset = "0x6945200", VA = "0x186946C00", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public FLEDOJIDPKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class HDLGDAMHBOP : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6947090", Offset = "0x6945690", VA = "0x186947090", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public HDLGDAMHBOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DOOKFNCJKMO : LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public static readonly LFKDEIHJPNB DPHAMGLPBBK;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69458A0", Offset = "0x6943EA0", VA = "0x1869458A0", Slot = "4")]
	public void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DOOKFNCJKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct AOGNCADPKGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public FDIPOBCALOO PKICDAADPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public GCNJHPDNKDP MDMPJPDCNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public Dictionary<int, int> DIEFOHPDPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public Dictionary<Guid, Guid> KHKCDCNLIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public IHKNJLFCHDE JHCOPLGNBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public bool JDNFGCIGAOK;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LJLDMAFNDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBDKOKFLEBL(AJOAENIACOJ PAHPLOPOBKI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EMHMEDBJDMB
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private static readonly LJLDMAFNDOC[] LEMCFPOHPGP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x69463A0", Offset = "0x69449A0", VA = "0x1869463A0")]
	public static void MKDJGHBGAHL(LMPEJKGKMKJ JHLEMCFOEMF, Dictionary<Guid, Guid> KMKKCGMJGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6946110", Offset = "0x6944710", VA = "0x186946110")]
	public static void KCPEIBHHACH(LMPEJKGKMKJ? JHLEMCFOEMF, HGLHFDADAEA OFHMGHOELJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6945AC0", Offset = "0x69440C0", VA = "0x186945AC0")]
	public static void DIHHPENHOCN(LMPEJKGKMKJ? JHLEMCFOEMF, HGLHFDADAEA HIHKNCHGEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6945D40", Offset = "0x6944340", VA = "0x186945D40")]
	public static void EDLDKLFNGJA(AJOAENIACOJ PAHPLOPOBKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct AJOAENIACOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public FDIPOBCALOO CKHBMPHKJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public LMPEJKGKMKJ DKPOEEMNGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public Dictionary<int, int> DIEFOHPDPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<Guid, Guid> KHKCDCNLIBK;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6944AC0", Offset = "0x69430C0", VA = "0x186944AC0")]
	public Guid MICEENMPCIO(Guid DHEKBCJKGBC)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IHKNJLFCHDE
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BIPPELEBMLA, [Out] Guid NJOACLKMKON);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class INHBEBODAPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private readonly HashSet<string> GBHOKENICHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private readonly Dictionary<long, int> OIKIFIHNFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private readonly HashSet<Guid> GKCLCOIDJLB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<string> AOOGCNAPKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyDictionary<long, int> FDIEJENHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x69478C0", Offset = "0x6945EC0", VA = "0x1869478C0")]
	public static INHBEBODAPG BHCEOBAIOKB(POGNJKLFFHD BMLBCLGKFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6948960", Offset = "0x6946F60", VA = "0x186948960")]
	public static INHBEBODAPG NEGNHOAOPAP(ONCEDLMDIKH AOLEOPPJGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6947930", Offset = "0x6945F30", VA = "0x186947930")]
	public static INHBEBODAPG EDCFLKMMJIO(IEnumerable<string> GBHOKENICHI, IDictionary<long, int> MGOGODCJJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6948B10", Offset = "0x6947110", VA = "0x186948B10")]
	private INHBEBODAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x69489D0", Offset = "0x6946FD0", VA = "0x1869489D0")]
	private INHBEBODAPG(IEnumerable<string> GBHOKENICHI, IDictionary<long, int> MGOGODCJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x69483A0", Offset = "0x69469A0", VA = "0x1869483A0")]
	private void MBEFKEPHFKN(POGNJKLFFHD BMLBCLGKFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69485A0", Offset = "0x6946BA0", VA = "0x1869485A0")]
	private void MBEFKEPHFKN(ONCEDLMDIKH AOLEOPPJGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6948070", Offset = "0x6946670", VA = "0x186948070")]
	private void MBEFKEPHFKN(FGMLKFFJAJM? GOKNAIEAOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6948790", Offset = "0x6946D90", VA = "0x186948790")]
	private void MBEFKEPHFKN(FGMDBFBAEAF? FNNLHNNHGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6947C80", Offset = "0x6946280", VA = "0x186947C80")]
	private void MBEFKEPHFKN(LMPEJKGKMKJ? DKPOEEMNGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6947850", Offset = "0x6945E50", VA = "0x186947850")]
	private void AEFDAODECAC(string? LLNECMGNPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6947AB0", Offset = "0x69460B0", VA = "0x186947AB0")]
	private void IIIPHILIDNF(PCHGAFDBPAC? LPNPPOLJMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6947B90", Offset = "0x6946190", VA = "0x186947B90")]
	private void IIIPHILIDNF(MFCHNMJFHDG? LPNPPOLJMMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct PDLCJGMGGPH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class IAPBICGJKPE : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private readonly IEnumerator<DictionaryEntry> MBPJCHKAHIO;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DictionaryEntry KOHPEMDPKJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6947310", Offset = "0x6945910", VA = "0x186947310", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x69473D0", Offset = "0x69459D0", VA = "0x1869473D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object MDPJKNKDANF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6947480", Offset = "0x6945A80", VA = "0x186947480", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6947230", Offset = "0x6945830", VA = "0x186947230", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
		public IAPBICGJKPE(IEnumerator<DictionaryEntry> MBPJCHKAHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6947190", Offset = "0x6945790", VA = "0x186947190", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69471E0", Offset = "0x69457E0", VA = "0x1869471E0", Slot = "9")]
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
		private sealed class CDNBOKDNLLC : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xD35590", Offset = "0xD33B90", VA = "0x180D35590", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x69455F0", Offset = "0x6943BF0", VA = "0x1869455F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
			[DebuggerHidden]
			public CDNBOKDNLLC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x69454A0", Offset = "0x6943AA0", VA = "0x1869454A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x69455A0", Offset = "0x6943BA0", VA = "0x1869455A0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x694B620", Offset = "0x6949C20", VA = "0x18694B620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IDictionary.this[object MNBFPOFIDHA]
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x694B530", Offset = "0x6949B30", VA = "0x18694B530", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x694B700", Offset = "0x6949D00", VA = "0x18694B700", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x694B470", Offset = "0x6949A70", VA = "0x18694B470", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x694B4D0", Offset = "0x6949AD0", VA = "0x18694B4D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x694B6A0", Offset = "0x6949CA0", VA = "0x18694B6A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x694B130", Offset = "0x6949730", VA = "0x18694B130", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x6949790", VA = "0x18694B190", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x694B1F0", Offset = "0x69497F0", VA = "0x18694B1F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
		public RoomObjectCounts(Dictionary<int, int> GKDLPEGOEGI, [Optional] Dictionary<int, int> KJPJNMJOHLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x694B050", Offset = "0x6949650", VA = "0x18694B050")]
		[IteratorStateMachine(typeof(CDNBOKDNLLC))]
		private IEnumerator<DictionaryEntry> OOCEOILFOHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x694B750", Offset = "0x6949D50", VA = "0x18694B750", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x694B370", Offset = "0x6949970", VA = "0x18694B370", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x694B250", Offset = "0x6949850", VA = "0x18694B250", Slot = "9")]
		void IDictionary.Add(object MNBFPOFIDHA, object FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x694B2B0", Offset = "0x69498B0", VA = "0x18694B2B0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x694B310", Offset = "0x6949910", VA = "0x18694B310", Slot = "8")]
		bool IDictionary.Contains(object MNBFPOFIDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x694B410", Offset = "0x6949A10", VA = "0x18694B410", Slot = "14")]
		void IDictionary.Remove(object MNBFPOFIDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x694B0D0", Offset = "0x69496D0", VA = "0x18694B0D0", Slot = "15")]
		void ICollection.CopyTo(Array NMHOKLPDKBK, int EBDMAJMOJLN)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class IMEEOJPJLGP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xD35590", Offset = "0xD33B90", VA = "0x180D35590", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6947800", Offset = "0x6945E00", VA = "0x186947800", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
			[DebuggerHidden]
			public IMEEOJPJLGP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6947670", Offset = "0x6945C70", VA = "0x186947670", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x69477B0", Offset = "0x6945DB0", VA = "0x1869477B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6949270", Offset = "0x6947870", VA = "0x186949270", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IDictionary.this[object MNBFPOFIDHA]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6949140", Offset = "0x6947740", VA = "0x186949140", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6949320", Offset = "0x6947920", VA = "0x186949320", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6949080", Offset = "0x6947680", VA = "0x186949080", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x69490E0", Offset = "0x69476E0", VA = "0x1869490E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x69492C0", Offset = "0x69478C0", VA = "0x1869492C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6948D00", Offset = "0x6947300", VA = "0x186948D00", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6948D60", Offset = "0x6947360", VA = "0x186948D60", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6948DC0", Offset = "0x69473C0", VA = "0x186948DC0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD9B0", Offset = "0x1FCBFB0", VA = "0x181FCD9B0")]
		public Invention(long KAGKMEDPMHO, int FDDANCOAHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6948C30", Offset = "0x6947230", VA = "0x186948C30")]
		[IteratorStateMachine(typeof(IMEEOJPJLGP))]
		private IEnumerator<DictionaryEntry> OOCEOILFOHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6949370", Offset = "0x6947970", VA = "0x186949370", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6948F40", Offset = "0x6947540", VA = "0x186948F40", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6948E20", Offset = "0x6947420", VA = "0x186948E20", Slot = "9")]
		void IDictionary.Add(object MNBFPOFIDHA, object FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6948E80", Offset = "0x6947480", VA = "0x186948E80", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6948EE0", Offset = "0x69474E0", VA = "0x186948EE0", Slot = "8")]
		bool IDictionary.Contains(object MNBFPOFIDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6949020", Offset = "0x6947620", VA = "0x186949020", Slot = "14")]
		void IDictionary.Remove(object MNBFPOFIDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6948CA0", Offset = "0x69472A0", VA = "0x186948CA0", Slot = "15")]
		void ICollection.CopyTo(Array NMHOKLPDKBK, int EBDMAJMOJLN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> JJFFMLKAADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public readonly IReadOnlyList<Invention> GOPJLFGGMDF;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
	public PDLCJGMGGPH(IReadOnlyDictionary<Guid, RoomObjectCounts> JBJEEOAHJNE, IReadOnlyList<Invention> AKCLODIFMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6949EC0", Offset = "0x69484C0", VA = "0x186949EC0")]
	public static PDLCJGMGGPH BHCEOBAIOKB(POGNJKLFFHD BMLBCLGKFJE)
	{
		return default(PDLCJGMGGPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x694AF30", Offset = "0x6949530", VA = "0x18694AF30")]
	[CompilerGenerated]
	internal static int PNBEIHINBMO([In] IReadOnlyDictionary<long, int> AIDENDODOIE, long? LEGFKEBECGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x694A880", Offset = "0x6948E80", VA = "0x18694A880")]
	[CompilerGenerated]
	internal static void HJCIBCEADEE(int AKMFNDMNEIB, [In] FGMLKFFJAJM BBGKLMGMJNL, [In] Dictionary<long, int> AIDENDODOIE, [In] Dictionary<Guid, RoomObjectCounts> JBJEEOAHJNE)
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
