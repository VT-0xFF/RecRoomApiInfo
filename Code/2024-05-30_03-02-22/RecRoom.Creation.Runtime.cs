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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6397660", Offset = "0x6396860", VA = "0x186397660")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CDCHCOBBLIC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> PBMLBOABPKC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> PHOFNPLEHNL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> KPLNFOFKOJI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string ICBHANNALLC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string GOHPIPPIGBN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string DKLAPGJOPJC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63809E0", Offset = "0x637FBE0", VA = "0x1863809E0")]
	public static bool MNKMAMJDOHH(Guid IAEHNIMHCIC, int COFOLFBLEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6380280", Offset = "0x637F480", VA = "0x186380280")]
	public static bool GADNJHCIOMM(Guid IAEHNIMHCIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6380310", Offset = "0x637F510", VA = "0x186380310")]
	public static string KFMKILAACJH(Guid LDJEJDDHHLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AGKGPLEJHPL]
public enum OPNBDEMFPJB
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
public static class BJJOGLBHAJH
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid CKFJGEFNCHO;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid LONCPCMHBLJ;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid HDJNKOKKFHL;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid ECJNIKFPDPF;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid KDCCJHCDOOL;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid PLHNCFEJEPM;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid JEDLKBGEPOF;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid PPACBLNPODH;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid NNIIPIAMIIF;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid LNMJOEHOEOE;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid KMMNKDMDONC;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid ONACOPIAECI;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid DOOHBDIAGGH;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid MOJOBMBDLCO;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid FFNEEGLLECG;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid KLDEJKINAAF;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid KJPPIMDNDMP;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid BEILJBHFLJJ;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid AMNPLMFHANA;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid JPEMAHPNDPD;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid OEFJFGPDPJE;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid PFBDONHKBNH;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid IAGEGEKANDC;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid FOCHCOGHJFA;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid AFJKHOMDECI;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid CNDAGPELHNO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid CJPIPAJKKEO;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid GNLCMKHCKPC;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid NFBKFEMMDPC;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid CINGNBAFMIO;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid OCGFKLPCNCD;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid CDJMAIPNFKN;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid KDEFHLEJFAM;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid DPDKFEELEBD;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid LEMEELGBHPD;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid KPFPCNHFIDM;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid MJONEFJEHPL;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid GGCCILDHFHD;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid KPHJPGDHDAB;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid JDNFNKMNGHL;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid JBIBODODNPN;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid CNAGDLBLGJD;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid BOEDFBMJNCH;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid KONJNBPFKPP;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid ENDAJCLFHAA;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid CNJNOPDMOBB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid ECGJHNNJOAL;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid FEHHLDBJFGA;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid COKFEHLNGBP;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid NCCNAGALOHF;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid LCLBBNPKKMO;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid IHGEMOGPAHC;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid HKBPNAHPPHA;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid DGPAPPNMGJA;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid LPKDEEHAKNG;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid DPFFJJOMHLE;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid DPADNJLKMCD;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid KOEFMDJMENC;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid NGHAGINNKIL;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid JHJMPGPMKKB;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid LBKMNBMPCEC;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CCJCOPCHPCC;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid PKCMIAGOAIL;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid EBCLDGKBDDC;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid CGFMBOBCOFL;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid LCPDNJDFFMH;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MBEOHOOAEMH;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid LFFMFHIMOOM;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid JMAFOPGLEOK;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid POCBFJHAKLK;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid GJDHPCBOMGA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid HNCACOLIHCH;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid JPBIGBKCJGK;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid PCFIDJJNGFO;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid AIPOKILEKMG;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid GEBBKHLIHLF;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid FGOFAAEFLAC;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid LGLLEFPLNGM;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid CMFJABJJLCF;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid PCLFAACKLNC;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid KAMGHCJCMGP;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid ANCJMIEDMDN;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid OEFJMNMNDCE;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid OCDACMNHEEE;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid DBGCOEHFPEK;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid MPEJEOJFCFB;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid LELEOLHGLEL;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid CEAGAAFPLCN;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid AJALLOFBOOJ;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid FEBGLFCHKMA;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid POMLJLGPGOE;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid KKCMKABGLMM;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid IAJMKDDDOLN;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid IDMGGDPJEMA;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid FMLCEDAKEOJ;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid KFBOPKHGEFK;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid NBIKLEPDDPF;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid HAMMKPJIJOJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid FNHAKBGPCAM;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid KLMPCJAKPOB;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid DOGBDGNEFIF;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid MENCOOOPJJO;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid AGBAMJPJKPF;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid CDMEDBGFOBG;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid PBKCMCDKCEK;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid GJPEGMOKAEE;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid EBHCMCODLJF;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid KBFDFCILIJO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DDFGOGCNMND;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid NHEDGOADAPO;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid FEAFKIOIKLI;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid OGBLOFMPNJP;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid BLAGNMEJJIA;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid MIAIIIKFHIH;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid IADDPLBLLGH;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid ECAPMLFDFHL;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid KIBACBCOPNM;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid LODEHBEEGEO;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid NMEAHOEKOAI;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid DCPIHHAFEAJ;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FEIMFNOLJIA;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid KFOJHHGFMFI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid GPGGAGIPPCD;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid GKAEMBACFJE;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid LDNIOOBMOPL;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid NIDCPCOLKOH;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid LFPLNHMHHAE;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid IDBJEONCOMF;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid LEHKEMNLIOC;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid IINHMBFNCHA;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid MCPJKBCPDBP;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid IEBCMBCIHGI;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid MECNKPJMANE;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid HFHKCOCJHCH;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid EIPBMNKKELL;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid JKFCBHBJGKH;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid ADNFKHOFJOE;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid CHPDHJHFFEC;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid NMAHGJBLJDM;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid GHEGFJMMABO;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid DOKKJGFLNNN;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid CAJELHGNMLK;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid PLLCHGJGKFA;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid BBHMCMJCAJM;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid AKCDKCJKNJN;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid MCLPOMJIFAG;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid KLMHCCEOFIP;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid PAMMPKLJNMK;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid DMFGDFJHCIL;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid BNKEAJOHNII;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid CJMDNOHOOHK;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid GOLHFMCIEBE;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid EDFNBFDCELI;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid FKHDJHEPFON;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid BEBDHLFONKB;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid HMLDJFKBJIE;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid NKDEPBLAPKF;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid PPCIGENDIBH;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid PJLCKCHFNKL;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid BJHELMMBPHM;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid OJMFJNDBDPM;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid IFMAIAMMFGE;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid NIBJJFBBCGA;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid HKGJKHGOBEG;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid CNDFANDOHKF;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid ODFEJGBKEMJ;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid LEKKNLKEING;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid DMLNCHECAMF;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid AHHCCBAGPGE;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid OLFCOBOBFBG;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid EFGHJADJING;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid DMHIDJAMAGP;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid KIBGKCKCCBB;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid EKKLFEPMODD;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid OBNILFFOJDA;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid ENHBIPOCCDH;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid DAMMMNEFKPK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid KNFICEAKGBA;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid BGBKHIAHLLA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid ECOEEGLIGIP;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid GDOMODOBMNK;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid HFJMKGFCNLN;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid ICLKMJFKMKH;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid JOIFDMOLOAL;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid NJJOMANKPPN;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid IFBBDPEOPEF;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid CJIKGNIFGAH;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid CLHLDAFEBNC;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid JDLCBAFFMFF;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid NPOPOAMGPKB;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid BODBJJOPKDD;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid ENKIMDFOEOE;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid AKOKDDPEAOI;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid NGICFFEJMIF;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid AHGMICIPGAM;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid HAOAFPDACGE;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid DJMPNJEFDHO;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid DLNMJMOPGMP;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid GFPJELJKDDB;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid JALCDKBAGLM;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid DGDBMHMJKHK;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid NEOCNPBHILM;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid IGLNBGMAPKB;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid MKIEJJJBGPN;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid MPDFAEGPLCG;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid IAHAGHGJMDE;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid LJIAKBGBAJJ;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid CJAGKDHFNEI;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FNHGBCDMOGF;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid MDGBNBCNKLC;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid JDLMNKFNOID;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid FDKCLHKBCDN;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid MPFPEAOHIAO;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid KDPJGBGLAFD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid PLNAPHPPDJM;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid OHJIJLHNIJL;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid HDLKCMCOPHP;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid KKCNLGAFOCK;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid AIGHBFLALIA;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid IHFPJJILDIP;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid FACOJLOHNCE;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid CIAIDFJIGPN;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid GFEAEANJGLO;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid HHJPMGGGKNK;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid MPKJKPOBCIC;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid ILLOCJGELGE;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid NPPKOCGIHLP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid PDMNLDPCBMH;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid AKCNDIAADHE;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid IDPJPBFGMDN;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid MGPGPMDNING;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid MBMLEJBDJLJ;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid LMLHCANLLFL;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid NHCJOKDHCAB;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid IMAIODLNNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid HJMAIJNCHLM;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid CJNGLHPPJOB;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid NKGPJDEDDFF;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid DFAHIFKDGCE;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid GLBALGBKAAB;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid LMAHKGHCLCD;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid JMGECDJIMIJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid FMMPMGGGMOH;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid GCGKJKNELCC;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid IJJJOEHDOAA;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid OJKPADFBBOG;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid IBIEMPKOEPB;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid KEPMJGOLPBL;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid FDEMCJFJILD;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid MCJGBLNJMND;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid JOAILDDGDIN;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid JKHJBMEJPMD;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid BACHLBJJFDB;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid ACMKHPEMGEM;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid IEIMFDIPCOP;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid FBGAOOAKHJG;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid PIBNJJDEPGH;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid FFDKFMLMIMG;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid LELBLDHODMP;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid PHAEGPKPBJL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid IBNBJNPGGEH;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid INGDFAOAAAN;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid BOMKEHCACDC;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid HNMLLOJEEPG;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid FEEJMDOFHAF;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid GINKMNFAKDH;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid EMCCLCMEEDN;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid OEOOAGIMMAM;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid HGBPGKABEKG;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid PCNMNMLLFIM;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid FGJILKGHHFE;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid BGNNPENKMJG;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid BFKGLDGGILC;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid HMFHEBNCABG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid AOMDGIFPALH;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid CGNHPOMNKLA;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid OHDHBHMPDEA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid IAPHEIFDJMP;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid OKLGGBFDGKO;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid PKLIKKOHJNO;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid FOOGEDNHGLA;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid NPDPBFKHFNP;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid HOGLNIICCNH;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid CNFNEELHOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid GLJOGJIJIGO;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid GJCLALKAJCJ;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid BKODLIDBFHD;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid JFDPCCKKLNM;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid GEAAPLEMAGC;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid PCMDPNJKCKC;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid KEIINAGPPOB;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid NNODIFAPJPF;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid OAEMCKLOKAE;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid OJKGDCEMBGC;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid NEMDEBJGFGG;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid BNEMPPGEMJH;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid NINPAGJEPEN;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid OJBCGODPIOE;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid GOKACOBFNAO;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid KDFIGNKLFGC;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid CJPCKJIIGPF;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid KNLIMNECGKE;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid AAAOIOCACKJ;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid HIIOBELFHAH;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid GEAJNAJEJMC;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid IPEOFFCANPB;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid HHIHBMEOJEH;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid KNDPKPKNJFE;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid MPAMKFLGEJC;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid NDKHMBGAAMM;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid HDDGPAOIJDP;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid GOBMNJIKBDO;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid OHLHLKGNJHK;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid ACDFEKJEKPJ;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid FIGFDIHCFIM;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid HAHJGBFPHJP;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid ECCPDIMGCBK;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid PGDLJBICFHD;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid IPJFHFBBGBJ;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid BCPMAGBFGPP;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid CBMLHDLDAFM;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid PHGAKLPJDFG;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HMLDCGAGGBK;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid ABLGPMONFJD;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid NBHPAJGMOBN;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid AHCFAJDLLKG;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JNBNCCNFPBM;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid LHJAEGDJLMD;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid MGBFGPEOHHP;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid IBDHHJHDFLC;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid FIBFFPICHOP;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid ENKIFNKHNNN;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid DEOCBBLEPAJ;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid FCAIOPAMDOK;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid INOEBEJIAME;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid KKDFKDJPDCI;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid JIECKAFKLGB;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid HMEJLJENMAB;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid PICPPDCPMBB;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid DEMGMCCLCEO;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid JNFLAJBCIBO;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid CDJIBBADAMP;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid OCIBDBEPLDO;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid CKHIOHJLLCP;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid HHEABLLIJHC;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid HFIGNIGIOPH;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid CJMPOMAAMEJ;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid KGFFAPBHMBM;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid JGCKINNDLON;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid HJCAIFLEEIL;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid LHFMPNBGBAK;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid AKOAEJHNNAH;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid AJBGJIFFMCA;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid IMBDJICIKKF;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid LIALNAMGAEF;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid CBCEFBCBEOO;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid DNNPLGLPNAD;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid JHIILPMNGPO;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid EKDHOCDPOHC;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid GEFDNKHAHHE;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid CDDBBIKINIK;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid NJLNFJPAOJP;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid ICOMACIGHAD;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EJNBBLGBMMA;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid JMCKPBCODGC;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid FDLIJLLAGNE;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid DOBFMAEINOJ;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid PLGNEHMBCGH;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid GNPBIAICOLH;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid MAGKEEBAHEN;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid JICDAGICJBH;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid JLAKIDNAODJ;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid HLOIJBBLNCI;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid HKOLJDAKAFN;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid FLLAJCPGAGB;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid MAEIMIBCLNP;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid AONAGGGFAFO;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid IJPAEOMEBIH;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid HIJIHBLCKEA;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid KKOKBOEDJNP;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid NDDHNJJKFCD;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid PKELJLPDNOC;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid JDPKAKMJPHK;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid OFFGGIIMMJH;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HGLMHMDGDAJ;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid BMFAGMIHPHM;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid GCIBFBLANCE;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid GDEKBMDMMAP;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid NECCPNNNAHA;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid AEDPHPAAOON;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid KLMLLHEOGAK;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid KKIGHAKLCCM;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid PPKCNKEOIPI;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid EMHAFGBACEB;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid LFFHEDFAEJC;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid IEKBDMKKALL;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid LDEKLDOFNBI;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid CMMKHMIPENC;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid ABCPJJBIAAE;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid EEAHAAGIMKN;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid JGLGLNNKKOJ;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid CELFJAJIBMI;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid HLKMJGLNGGE;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid FJFOLMIBGBB;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid HHLCACLHOCG;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid GLIBILFNKMK;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid KDCDKMLENCA;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid GCGAEDCPHCO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid ILCHOAPPGNO;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid NDDMNALMNME;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid HNHEFAOOEID;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid FAJHHKJMJIO;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid NOKOMNECJJL;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid CJMOKHBEKOB;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid KNOGPPIIPPE;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid EEACGMDOHDM;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid NNHJIPHAEHC;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid LGLCJJIADIF;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid OFFLFKFPAKI;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid HEDBLDOPADA;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid PJMJLKEDNIA;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid CFHFPDFFOLA;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GEGJEJDPIJI;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid JFMDFAOBFDB;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid DFAKMIBJMKN;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid POAJFAEKLOC;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid CIHJONPNJBM;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid NEPGOOJLDMJ;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid CJOAFGDONCL;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid ACDHNMGJEMK;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid ECAPNGAKEIB;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid IILFKNNCAMM;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid HPMADDABLLB;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid ABAPEAPMAPO;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid PMCFMBJHGNK;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid MDJGMIAKNOO;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid CLFKFNHFONC;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid MNJKHKAFCJL;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid NNNIJDGONAA;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid NBFKGCIADAO;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid IKEEELNKFIA;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid CDIGJDMGOBB;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid MJMFEOCHLHF;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid IJKFAKPNGHP;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid PLFIAILCGPD;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid BFHKPCHNCDK;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid CCFGCHFBJOC;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid MFJOHKEBPMH;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid IHNIOJANNIJ;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid FNMHGDDLOIG;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid IKDCGAAMDDK;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid CEEICAGDKDN;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid EPOHFOBBPNJ;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid OKLOIMDLPFB;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid BDLOLMDJCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid JDLDGDPPDLF;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid LPLDOANKJEJ;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid AODMDFJLECJ;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid LBGIOEHONHJ;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid NDGLHLJDHCI;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid AABJFFFLKPD;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid FDLJADGKHFO;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid DLGEFODBHAP;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid MMLFKOOKMFJ;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid NDCMCIDKDLE;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid JKENGIGADEH;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid EKGKKMJFMAE;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid AGCOFONOEDH;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid FOCOAPJHLDL;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid EIGHHHNNKLG;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid IKDLKGPCNAD;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid EPCMBCKLBAN;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid FIIOCAFENBE;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid FCOAIJFEGNF;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid JNGAIGNOMON;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid KFELNIPIMIA;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid NAPDDBGCHAL;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid LALOIEFECDA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid DLJNLKNHJBA;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid BKAINMICCIP;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid IEOFAHMKLBA;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid OOFNMEIGELG;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid JKAEOGDAJHF;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid AKLGLJMGDKP;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid DJDDIENKIFM;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid AGMLBELPCOE;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid MHHEDEEJBJE;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid PEPKLDEGEPN;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid MFCJALFCEBP;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid NBKCJKEEFGK;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid CNMKLIPLMCM;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid OGFMNDEEJOD;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid LHEIKMLGLID;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid JDMIGJHDFFI;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid BDAANKGJFNC;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid GNICOPKJNAK;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid KLBHCMNMDML;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid AHPBDHPNKLC;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid FNGFDPKIENA;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid PNMKFHDNBNC;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid EDHEODANPIL;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid HNKLGOHNPKM;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid FDKNJPKBMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid JHHJAEOIBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid CCGGGOABMPP;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid POMOAAPJJFO;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid PNBDGKPNPGG;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid MHCGAGBMOBL;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid HMPLDMODOGK;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid BHHENIKBCPO;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid FIMFPJGONMN;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid OLGPLLGPMGD;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid KOCGLEKFION;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid BKPPLBIICHJ;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid IKOCHEMPFIN;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid BNJKJGHHPKF;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid LGJDLHLFJEM;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid MGOACCFFPBB;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid BJAKLBKIIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid EGDJEFJPDAE;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid KHLKIMPKMIL;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid KCNOJGJAFDI;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid GODACDDGPNN;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid FHBLHEDCKDI;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid AMCCKPNNBKG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid FFCCBOGMBCF;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid JGDECIBABLP;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid GCGFIJBPEII;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MKMGJDKHDLO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid BMDPMDIPOMO;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid CPFBHBAEMLN;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid BIINJJPJOPM;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid NDMFPMNHKFK;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid MLKAHEIBCLC;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid AJPEKOFFKED;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid ICAKOKNFAFA;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid PJCILIGOIAO;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid IDCGAOBPIBM;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DJGBLLFJMHN;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid FBNOGAHHGAP;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid IPFEDFJEMFG;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid ABHFJDMFBED;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid MAMKJEKEMHI;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid KFMHFCBPALK;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid IHGJMAIBJDN;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid LOAJOLHOIGM;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid HKHNOMLPNOJ;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid DBHILAGPFJA;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid IIDEIJILPLN;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid EALAICKMEEG;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid KACNHPDKAHJ;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid GCBIOLGHIOB;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid AKNPPCLNPNM;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid JBFBKLBEKEM;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid PCOJHGANLKA;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid AGHAIACHEPF;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid MBCINJJFPNP;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid IMFMNCKMHCC;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid OJFBGOADLAN;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid GIAHLKNECNO;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid PKGNPMIDOOK;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid PICMHFPNIAA;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid BJDINGIKOII;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid JOKBLKAMIDM;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid CMFAPENFLJI;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid INPBGCNFIHM;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid BNHKOEPCDJI;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid EAMPCMACLJO;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid ADKLABFBHGN;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid JNHAIEGECAN;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid CGNJHJCCJDL;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid IBAGEEGEHEC;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid MPPOCIFOKKP;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid CBPANAKCIBB;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid NBGGFDAENPM;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid JHBCGBLDNMP;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid DNGOBHOLBOB;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid OCHBKCDPHJM;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid IJLLJMOIMJB;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid MCIMFMMIAEH;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid LHNPNMCHLEH;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid KPFOCGJGFNP;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid IGBDFNMFPLN;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid FJMPLHLOIPJ;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid MFDJBIODNNC;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid KKJKAPGADED;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid PJDEKOGGCPO;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid FLCCKJNMKBH;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid LJDKIPNNFHE;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid BHABNIEAGFM;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid CBEKOCKCINI;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid BOAEOGDOOCO;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid KJCMNHNKAOM;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid FEKJJGGFPEI;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid NMFMANHBBLD;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid NPKPHBEKCFK;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid MNGGOOPBENB;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid KBHAGJIOCNC;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid KKOPMLOOMJK;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid PFBICBIJBHC;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid EADMAACOHEC;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid EBJILPINHMC;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid NFIDFPDHDNN;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid MMHCJAAFFJH;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid LIFDMBKJNEH;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid MCCPLHCCCNF;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid CAMIDKODMKI;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid CBNBHBDPJLE;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid PDKCFJPNHME;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid LDINAHNINBL;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid KFDOGIEJNKA;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid EDMDOEICKFH;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid GNFOCFNEGPK;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid FOCNHDIEIGB;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid ALJEAKIGFNI;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid EHEJPLHPBOP;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid DHJLNKNMDNJ;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid HGPNAJOPLFK;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid EDHGJLLHLPF;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid LLEIPHDDJHO;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid IDBHJLMKHKE;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid LPMFABLAKIP;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid GAEMHBIBEKE;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid JFEJDJMABKO;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid NLIDBLNELHL;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, OPNBDEMFPJB> FPNBPCNFDAG;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<OPNBDEMFPJB, Guid> MBHHGHMAIJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, OPNBDEMFPJB> GMKBNNFJAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6380220", Offset = "0x637F420", VA = "0x186380220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<OPNBDEMFPJB, Guid> FGMBEAIKNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x63801C0", Offset = "0x637F3C0", VA = "0x1863801C0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KAFPNCOMCIA
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6396830", Offset = "0x6395A30", VA = "0x186396830")]
	public static bool IOEPLLGIACE(PNGAPBBKAOG GNIJKCHLKAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6396860", Offset = "0x6395A60", VA = "0x186396860")]
	private static bool IOEPLLGIACE(FJAIIEHHBAP FDAEAIELBEG, PNGAPBBKAOG GNIJKCHLKAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct LIGBCMKKJCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly NDLIJJKABHI ANGDHJNMONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<LGJHLMJIKKC> NPPJIPEFCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<LGJHLMJIKKC> AAOLOPNGFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly MKMFEDEKPBJ<OAAIMIGIBKP> COIGHHPMHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<BEGCOIKGLLD<HLKKEFMLJPC>> PFPJNJPJPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString IPBIAEPHFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly IFKBNFIBGIM JNODGLMKBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool KLDCNFKLLGH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x63975D0", Offset = "0x63967D0", VA = "0x1863975D0")]
	public LIGBCMKKJCE(NDLIJJKABHI HFBMNCFDIMF, IEnumerable<LGJHLMJIKKC> DHDPONDIBPB, IReadOnlyList<LGJHLMJIKKC> HOAJEPCIFHB, MKMFEDEKPBJ<OAAIMIGIBKP> OEJDKLDJELC, IReadOnlyList<BEGCOIKGLLD<HLKKEFMLJPC>> LAPAKIBBANA, ByteString EAFEDCCJCHJ, IFKBNFIBGIM CKJPEKGOHNI, bool HFMKIDLEJPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IINELFHGIHF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(OBLKLLEJGGJ JLJKEBMIIPF, [Out] Dictionary<int, int> CCCLMOJOAAJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(JKIJPMDGEPB AMDIPIENIPL, AIAGACEIPHD DBIBFJCGEJK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BGMBJOJIOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid DIKHCDGKJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> AJNNPLDADKA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> FFFMIHPONND
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3741E10", Offset = "0x3741010", VA = "0x183741E10")]
	private BGMBJOJIOOI([In] Guid HEHHKLNLPGL, Dictionary<Guid, Guid> ONBMHENPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x637CEF0", Offset = "0x637C0F0", VA = "0x18637CEF0")]
	public static BGMBJOJIOOI DHOJEFOFBOJ(IReadOnlyDictionary<Guid, Guid> ABMCLPHFHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x637C910", Offset = "0x637BB10", VA = "0x18637C910")]
	public static BGMBJOJIOOI AFCBLFBIJIL(IEnumerable<KeyValuePair<Guid, Guid>> ABMCLPHFHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x637CDD0", Offset = "0x637BFD0", VA = "0x18637CDD0")]
	private static Dictionary<Guid, Guid> CDHMMMOOAPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x637CCC0", Offset = "0x637BEC0", VA = "0x18637CCC0")]
	public Guid AOAMADOBKJA([In] Guid LDJEJDDHHLO, bool MJEBJHNKPPD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x637CE80", Offset = "0x637C080", VA = "0x18637CE80")]
	public bool CEOIOGAJFND([In] Guid IFAFPBGLEJO, [Out] Guid HOLHOJNAMBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HHPNJABBIFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EHNLPDCDCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHPADLGFHBL(ByteString FENHJHOBMAI, BGMBJOJIOOI ACAELCKGLND, [In] UniformTRS AEMIKFJOGNP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JIOBOFCKDNF
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
public class OHOFELJGNEK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x142DE70", Offset = "0x142D070", VA = "0x18142DE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long CIFAKBDIKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF4D170", Offset = "0xF4C370", VA = "0x180F4D170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long DCHKNHOKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63976E0", Offset = "0x63968E0", VA = "0x1863976E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6099490", Offset = "0x6098690", VA = "0x186099490")]
	public OHOFELJGNEK(long BIFLOKBJAPK, long FHMFEMGCAIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IELPIGKPHKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, OHOFELJGNEK> CICCOMFLFII;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> FOHHBMJHOCJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long DDLECPFMFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF4D170", Offset = "0xF4C370", VA = "0x180F4D170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long KGPLPLEHNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xFAC1D0", Offset = "0xFAB3D0", VA = "0x180FAC1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6381B60", Offset = "0x6380D60", VA = "0x186381B60")]
	public static IELPIGKPHKM HMDBDFEIMIE(NDLIJJKABHI AEGFJCJEFJB, BEGCOIKGLLD<OAAIMIGIBKP> GMHBIOIHBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63821C0", Offset = "0x63813C0", VA = "0x1863821C0")]
	private void HONJCNPCGEL(OFFHOBPALPP BKOKOKIHONK, long HIBNHCOHOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6395DD0", Offset = "0x6394FD0", VA = "0x186395DD0")]
	public IELPIGKPHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CFDJCNGAIBJ
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<OPNBDEMFPJB> PEJIJKNKBDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NMHEKAOGNJP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> BBDMFCPIIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> KCNJCBDDLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D1780", Offset = "0x7D0980", VA = "0x1807D1780")]
	public NMHEKAOGNJP(IReadOnlyDictionary<Guid, Guid> PEJHLOIPJNB, IReadOnlyDictionary<Guid, Guid> OEMPHCJEGLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BJCNDMBIOON
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x637F730", Offset = "0x637E930", VA = "0x18637F730")]
	public static CJEPGONLMBH LLOEDBNIPMJ([In] LIGBCMKKJCE LLHCMALKBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x637D6F0", Offset = "0x637C8F0", VA = "0x18637D6F0")]
	private static void EFHIKKLEAFE(CJEPGONLMBH OHMCBPGKFIF, [In] LIGBCMKKJCE IFIHIPGIEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x637DD50", Offset = "0x637CF50", VA = "0x18637DD50")]
	public static bool EIEDNENDDPC(CJEPGONLMBH OHMCBPGKFIF, GLPKPLIIHPP BMMCOEGIAHI, BGMBJOJIOOI? DDGJFANMPLJ, [Out] NMHEKAOGNJP? ONBMHENPKAK, [Out] string? KFNIFKKFLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x637D3B0", Offset = "0x637C5B0", VA = "0x18637D3B0")]
	private static void CPPDGLFJMCM(CJEPGONLMBH OHMCBPGKFIF, BGMBJOJIOOI? LOEMGPHEPMG, GLPKPLIIHPP BMMCOEGIAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x637F6C0", Offset = "0x637E8C0", VA = "0x18637F6C0")]
	private static void KJNDMCAENIN(CJEPGONLMBH OHMCBPGKFIF, GLPKPLIIHPP BMMCOEGIAHI, IReadOnlyCollection<ByteString>? LHFBGPCIJHO, IReadOnlyCollection<ByteString>? HPFPABDNCBM, IReadOnlyCollection<ByteString>? LEINCHNFFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x637F8A0", Offset = "0x637EAA0", VA = "0x18637F8A0")]
	private static bool MGFGFNGGLFI(CJEPGONLMBH OHMCBPGKFIF, JKIJPMDGEPB AMDIPIENIPL, GLPKPLIIHPP BMMCOEGIAHI, [Out] string KFNIFKKFLAO, [Out] Dictionary<int, int> CCCLMOJOAAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x637F3E0", Offset = "0x637E5E0", VA = "0x18637F3E0")]
	private static Dictionary<Guid, FJAIIEHHBAP> JDOILPGKLAA(CJEPGONLMBH OHMCBPGKFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x637D650", Offset = "0x637C850", VA = "0x18637D650")]
	private static void DENOMBMGBAI(bool CCNCODLECON, LGJHLMJIKKC IBNFDGDHACD, Dictionary<Guid, Guid> BLOHMDFNHMJ, BGMBJOJIOOI IBKAJECPLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x637FF30", Offset = "0x637F130", VA = "0x18637FF30")]
	private static void MNCLANGGMCG(LGJHLMJIKKC IBNFDGDHACD, Guid CFKCFJLBADO, JHKFHEDIMMD? EEFKAFPKMEB, Dictionary<Guid, FJAIIEHHBAP> NFOLNANLHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x637CF00", Offset = "0x637C100", VA = "0x18637CF00")]
	private static void CGLHGGFEFEH(IEnumerable<LGJHLMJIKKC> OBLNNLJKDHL, IReadOnlyCollection<ByteString> LHFBGPCIJHO, IReadOnlyCollection<ByteString> HPFPABDNCBM, IReadOnlyCollection<ByteString> LEINCHNFFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GLPKPLIIHPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool CCNCODLECON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public IFKBNFIBGIM CKJPEKGOHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public JHKFHEDIMMD? EEFKAFPKMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public JHKFHEDIMMD? PHCHBNPJKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public NDLIJJKABHI JHMCFMLLIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public JIOBOFCKDNF LLGMJJGEAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public IINELFHGIHF NCNNIGDCJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public HHPNJABBIFP HMPMEGCKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public BEGCOIKGLLD<OAAIMIGIBKP> JGGMOOCEJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public DHMCDHEHAEA HAHIBAGHFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<LGJHLMJIKKC> NAHHBAMHJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> AAGKKJMHBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public LONGKLLCLNI OHBIIPMHLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool MHHMHIHIIHB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool MNIDBBPCOCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6381B10", Offset = "0x6380D10", VA = "0x186381B10")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct JHKFHEDIMMD
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float EJHLOPMFFCP = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 CAOOPLKANIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion JCCMNAMJFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float MGKBJKPBCFA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 MIEIAFKKHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6396550", Offset = "0x6395750", VA = "0x186396550")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS KLEEEOOJOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6395E60", Offset = "0x6395060", VA = "0x186395E60")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xA67C60", Offset = "0xA66E60", VA = "0x180A67C60")]
	public JHKFHEDIMMD(Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM, float MGKBJKPBCFA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6396760", Offset = "0x6395960", VA = "0x186396760")]
	public JHKFHEDIMMD(UniformTRS DFBLKGLDCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63960C0", Offset = "0x63952C0", VA = "0x1863960C0")]
	public static JHKFHEDIMMD FJGNAHEHJKB(JHKFHEDIMMD BGILIGANMHA, JHKFHEDIMMD CHFDDNFMDKA)
	{
		return default(JHKFHEDIMMD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63963D0", Offset = "0x63955D0", VA = "0x1863963D0")]
	public static JHKFHEDIMMD LOFAPGLBJHK((Vector3, Quaternion, float) JLJKEBMIIPF)
	{
		return default(JHKFHEDIMMD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63963F0", Offset = "0x63955F0", VA = "0x1863963F0")]
	public static JHKFHEDIMMD LOFAPGLBJHK(Matrix4x4 EKNONJGCKND)
	{
		return default(JHKFHEDIMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x63966D0", Offset = "0x63958D0", VA = "0x1863966D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6395EA0", Offset = "0x63950A0", VA = "0x186395EA0")]
	public JHKFHEDIMMD FENBBBOEGAB(Matrix4x4 HANHCEFMJDD)
	{
		return default(JHKFHEDIMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6396660", Offset = "0x6395860", VA = "0x186396660")]
	public static JHKFHEDIMMD POFJNIAMJAK(Vector3 CAOOPLKANIG)
	{
		return default(JHKFHEDIMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6396340", Offset = "0x6395540", VA = "0x186396340")]
	public readonly LJEFFADCIED IDCLKKPHHHJ()
	{
		return default(LJEFFADCIED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KGPNHHFCKOK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6396C10", Offset = "0x6395E10", VA = "0x186396C10")]
	public static JHKFHEDIMMD NLDDGCLECBD([In] this LJEFFADCIED CJKIBFNGPNM)
	{
		return default(JHKFHEDIMMD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class LAJCOJMKFFF : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6396CA0", Offset = "0x6395EA0", VA = "0x186396CA0", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6397000", Offset = "0x6396200", VA = "0x186397000")]
	private void KLEFLFEDFFG(Dictionary<Guid, Guid> OALGKMDBFDE, ICOPIEIECDN CKKLCBODOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6396FA0", Offset = "0x63961A0", VA = "0x186396FA0")]
	private void KLEFLFEDFFG(Dictionary<Guid, Guid> OALGKMDBFDE, HHMOCALKMPL MDKOHKFJMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6396D20", Offset = "0x6395F20", VA = "0x186396D20")]
	private void KLEFLFEDFFG(Dictionary<Guid, Guid> OALGKMDBFDE, LLPGLFFOEED GIHMDNFDGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public LAJCOJMKFFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class NGLPNJMFPDL : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x639B880", Offset = "0x639AA80", VA = "0x18639B880", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public NGLPNJMFPDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class AJPCCCAGAHC : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x63977B0", Offset = "0x63969B0", VA = "0x1863977B0", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public AJPCCCAGAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class HBDJDOANEMP : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x63994A0", Offset = "0x63986A0", VA = "0x1863994A0", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public HBDJDOANEMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class GOCCFOEBLJJ : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6399280", Offset = "0x6398480", VA = "0x186399280", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public GOCCFOEBLJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class BAOICPJPBKJ : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6397A00", Offset = "0x6396C00", VA = "0x186397A00", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public BAOICPJPBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class BMADJANOCIB : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6398F00", Offset = "0x6398100", VA = "0x186398F00", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public BMADJANOCIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class AKMCEDGNDHC : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6397910", Offset = "0x6396B10", VA = "0x186397910", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public AKMCEDGNDHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class PCCFGHMONJN : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x639CBA0", Offset = "0x639BDA0", VA = "0x18639CBA0", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public PCCFGHMONJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class JGNANLGNDOJ : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x639A460", Offset = "0x6399660", VA = "0x18639A460", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public JGNANLGNDOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class KINHGDFHKMN : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x639A620", Offset = "0x6399820", VA = "0x18639A620", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public KINHGDFHKMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PHLFJAOPIAA : IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly POCKFNGHGME NNKFOMLBOGD;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x639CD60", Offset = "0x639BF60", VA = "0x18639CD60", Slot = "4")]
	public void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public PHLFJAOPIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct PNGAPBBKAOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public JKIJPMDGEPB DHGBHLPPCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public ELINHHFBIHF BFHJCOEGNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public Dictionary<int, int> MPAMLNKCNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<Guid, Guid> JMJGDAIOOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public LONGKLLCLNI OHBIIPMHLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool GFMDIJNCLKB;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface IGGNPFPFDKC
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGLDIMOEICN(PAKJEENDAIO JEKKHPLHJNL);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LEDJJOLHAHH
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly IGGNPFPFDKC[] CGOKHEJCAEG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x639A9B0", Offset = "0x6399BB0", VA = "0x18639A9B0")]
	public static void ECOMKFCNIFE(LGJHLMJIKKC JLJKEBMIIPF, Dictionary<Guid, Guid> GBKOBIGNMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x639A720", Offset = "0x6399920", VA = "0x18639A720")]
	public static void AOMCGFOGKAD(LGJHLMJIKKC? JLJKEBMIIPF, BGMBJOJIOOI MBIKKBKIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x639B010", Offset = "0x639A210", VA = "0x18639B010")]
	public static void PHCIOAANGMD(LGJHLMJIKKC? JLJKEBMIIPF, BGMBJOJIOOI IBKAJECPLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x639AC40", Offset = "0x6399E40", VA = "0x18639AC40")]
	public static void IOEPLLGIACE(PAKJEENDAIO JEKKHPLHJNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct PAKJEENDAIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public JKIJPMDGEPB JIJAAPLNFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public LGJHLMJIKKC IBNFDGDHACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public Dictionary<int, int> MPAMLNKCNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public Dictionary<Guid, Guid> JMJGDAIOOBJ;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x639CAF0", Offset = "0x639BCF0", VA = "0x18639CAF0")]
	public Guid KCBMMDJHCGK(Guid LDJEJDDHHLO)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LONGKLLCLNI
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KKILEDNKMCP, [Out] Guid FCCCPNMPLKH);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class BHNBIEEINJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private readonly HashSet<string> BKDHNJKICDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private readonly Dictionary<long, int> CFLEPDHFIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private readonly HashSet<Guid> MABHMJFDGDC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<string> BENEBOIMOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> NGNCAMPMHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6398C30", Offset = "0x6397E30", VA = "0x186398C30")]
	public static BHNBIEEINJM POFMBFEDLHH(CFOBPFOOGBO LOOHIDPGHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6398800", Offset = "0x6397A00", VA = "0x186398800")]
	public static BHNBIEEINJM DIAPNFGLJME(CJEPGONLMBH IGMAIGFBBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6398870", Offset = "0x6397A70", VA = "0x186398870")]
	public static BHNBIEEINJM KDEDDPOJLPI(IEnumerable<string> BKDHNJKICDD, IDictionary<long, int> DHDHLFNLBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6398CA0", Offset = "0x6397EA0", VA = "0x186398CA0")]
	private BHNBIEEINJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6398DC0", Offset = "0x6397FC0", VA = "0x186398DC0")]
	private BHNBIEEINJM(IEnumerable<string> BKDHNJKICDD, IDictionary<long, int> DHDHLFNLBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6397F30", Offset = "0x6397130", VA = "0x186397F30")]
	private void BANIFGIJKBJ(CFOBPFOOGBO LOOHIDPGHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6398120", Offset = "0x6397320", VA = "0x186398120")]
	private void BANIFGIJKBJ(CJEPGONLMBH IGMAIGFBBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x63984E0", Offset = "0x63976E0", VA = "0x1863984E0")]
	private void BANIFGIJKBJ(HOALBFJDPGL? LNOFAKNEFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6398310", Offset = "0x6397510", VA = "0x186398310")]
	private void BANIFGIJKBJ(DDJCFECNACM? BKOKOKIHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6397B40", Offset = "0x6396D40", VA = "0x186397B40")]
	private void BANIFGIJKBJ(LGJHLMJIKKC? IBNFDGDHACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6398BC0", Offset = "0x6397DC0", VA = "0x186398BC0")]
	private void OHFAFMFCMCK(string? CMBHAPDNCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x63989F0", Offset = "0x6397BF0", VA = "0x1863989F0")]
	private void NAOJPLMIKNJ(GLKKLFPDMNO? GNPNFFDBBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6398AD0", Offset = "0x6397CD0", VA = "0x186398AD0")]
	private void NAOJPLMIKNJ(AALGLCECNKK? GNPNFFDBBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct OBLFHDKFPIA
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private class IPFABCIJINI : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private readonly IEnumerator<DictionaryEntry> NBJLILNDAJO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry MHOOABAGNHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6399910", Offset = "0x6398B10", VA = "0x186399910", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x63999D0", Offset = "0x6398BD0", VA = "0x1863999D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object OGADOHBOMGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6399A80", Offset = "0x6398C80", VA = "0x186399A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6399830", Offset = "0x6398A30", VA = "0x186399830", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
		public IPFABCIJINI(IEnumerator<DictionaryEntry> NBJLILNDAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6399790", Offset = "0x6398990", VA = "0x186399790", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x63997E0", Offset = "0x63989E0", VA = "0x1863997E0", Slot = "9")]
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
		private sealed class HONINJDAJHE : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xB7FD30", Offset = "0xB7EF30", VA = "0x180B7FD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6399740", Offset = "0x6398940", VA = "0x186399740", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public HONINJDAJHE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x63995F0", Offset = "0x63987F0", VA = "0x1863995F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x63996F0", Offset = "0x63988F0", VA = "0x1863996F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x639D460", Offset = "0x639C660", VA = "0x18639D460", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object MNOIAMGNLNL]
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x639D370", Offset = "0x639C570", VA = "0x18639D370", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x639D550", Offset = "0x639C750", VA = "0x18639D550", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x639D2B0", Offset = "0x639C4B0", VA = "0x18639D2B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x639D310", Offset = "0x639C510", VA = "0x18639D310", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x639D4F0", Offset = "0x639C6F0", VA = "0x18639D4F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x639CF70", Offset = "0x639C170", VA = "0x18639CF70", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x639CFD0", Offset = "0x639C1D0", VA = "0x18639CFD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x639D030", Offset = "0x639C230", VA = "0x18639D030", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9FB690", Offset = "0x9FA890", VA = "0x1809FB690")]
		public RoomObjectCounts(Dictionary<int, int> HDCAAGLAGFN, [Optional] Dictionary<int, int> JBAEGMOFPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x639CE90", Offset = "0x639C090", VA = "0x18639CE90")]
		[IteratorStateMachine(typeof(HONINJDAJHE))]
		private IEnumerator<DictionaryEntry> OBIMMLBANBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x639D5A0", Offset = "0x639C7A0", VA = "0x18639D5A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x639D1B0", Offset = "0x639C3B0", VA = "0x18639D1B0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x639D090", Offset = "0x639C290", VA = "0x18639D090", Slot = "9")]
		void IDictionary.Add(object MNOIAMGNLNL, object HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x639D0F0", Offset = "0x639C2F0", VA = "0x18639D0F0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x639D150", Offset = "0x639C350", VA = "0x18639D150", Slot = "8")]
		bool IDictionary.Contains(object MNOIAMGNLNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x639D250", Offset = "0x639C450", VA = "0x18639D250", Slot = "14")]
		void IDictionary.Remove(object MNOIAMGNLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x639CF10", Offset = "0x639C110", VA = "0x18639CF10", Slot = "15")]
		void ICollection.CopyTo(Array HPGKNFECNHG, int PMNHOLIPOMJ)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class FGMDGGBIAMB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xB7FD30", Offset = "0xB7EF30", VA = "0x180B7FD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6399230", Offset = "0x6398430", VA = "0x186399230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public FGMDGGBIAMB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x63990A0", Offset = "0x63982A0", VA = "0x1863990A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x63991E0", Offset = "0x63983E0", VA = "0x1863991E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x639A170", Offset = "0x6399370", VA = "0x18639A170", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object MNOIAMGNLNL]
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x639A040", Offset = "0x6399240", VA = "0x18639A040", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x639A220", Offset = "0x6399420", VA = "0x18639A220", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6399F80", Offset = "0x6399180", VA = "0x186399F80", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6399FE0", Offset = "0x63991E0", VA = "0x186399FE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x639A1C0", Offset = "0x63993C0", VA = "0x18639A1C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6399C00", Offset = "0x6398E00", VA = "0x186399C00", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6399C60", Offset = "0x6398E60", VA = "0x186399C60", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6399CC0", Offset = "0x6398EC0", VA = "0x186399CC0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1EAA090", Offset = "0x1EA9290", VA = "0x181EAA090")]
		public Invention(long IFAFPBGLEJO, int BIFLOKBJAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6399B30", Offset = "0x6398D30", VA = "0x186399B30")]
		[IteratorStateMachine(typeof(FGMDGGBIAMB))]
		private IEnumerator<DictionaryEntry> OBIMMLBANBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x639A270", Offset = "0x6399470", VA = "0x18639A270", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6399E40", Offset = "0x6399040", VA = "0x186399E40", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6399D20", Offset = "0x6398F20", VA = "0x186399D20", Slot = "9")]
		void IDictionary.Add(object MNOIAMGNLNL, object HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6399D80", Offset = "0x6398F80", VA = "0x186399D80", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6399DE0", Offset = "0x6398FE0", VA = "0x186399DE0", Slot = "8")]
		bool IDictionary.Contains(object MNOIAMGNLNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6399F20", Offset = "0x6399120", VA = "0x186399F20", Slot = "14")]
		void IDictionary.Remove(object MNOIAMGNLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6399BA0", Offset = "0x6398DA0", VA = "0x186399BA0", Slot = "15")]
		void ICollection.CopyTo(Array HPGKNFECNHG, int PMNHOLIPOMJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> PDHFPEJNGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly IReadOnlyList<Invention> AHAOJBMEMHG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9FB690", Offset = "0x9FA890", VA = "0x1809FB690")]
	public OBLFHDKFPIA(IReadOnlyDictionary<Guid, RoomObjectCounts> CIMBJGENNBL, IReadOnlyList<Invention> KPOMDJGIBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x639C100", Offset = "0x639B300", VA = "0x18639C100")]
	public static OBLFHDKFPIA POFMBFEDLHH(CFOBPFOOGBO LOOHIDPGHKP)
	{
		return default(OBLFHDKFPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x639BFE0", Offset = "0x639B1E0", VA = "0x18639BFE0")]
	[CompilerGenerated]
	internal static int NMNJAEFMKHO([In] IReadOnlyDictionary<long, int> OFNEGHOHCKD, long? DABNDFOCNLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x639B930", Offset = "0x639AB30", VA = "0x18639B930")]
	[CompilerGenerated]
	internal static void AKNCANEIMOG(int CBICHODEEHK, [In] HOALBFJDPGL ELGGNGKOEPD, [In] Dictionary<long, int> OFNEGHOHCKD, [In] Dictionary<Guid, RoomObjectCounts> CIMBJGENNBL)
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
