using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F96A90", Offset = "0x5F95890", VA = "0x185F96A90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LCFGMIMDAEI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> GMFIKOOEGGO;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> PGBFBAOOCEF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string FDGBPIDFIOJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string OFNDDFKLGBI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string PFBKJNKIFNG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F95250", Offset = "0x5F94050", VA = "0x185F95250")]
	public static bool AHKLNGKMDAO(Guid LKNGJKKKCOB, int FPMIAPNICBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F95350", Offset = "0x5F94150", VA = "0x185F95350")]
	public static string MODLJMFJOKA(Guid FILMEIPENDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BLELLEAINJL]
public enum PDNIGGANKNP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	COSTUME_DUMMY_OM,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IFFCGEDCACM
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid GHDLPEDFOCK;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid GHBLIPMIEEL;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid OPIBHBLGFFH;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid KMINMNCDEKL;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid MKNDBGMKEFM;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid IHAIDFMOLFK;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid DNEPHINNHID;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid HOPBPJNDMOP;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid DJENOIGLMKG;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid ABNJOIJOFHL;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid EKFPKCEGNON;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid MMGFGHIGOOK;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid EFMHFALCEHB;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid HINNMCAEJBD;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid JNNGKGNADKM;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid BIINKGJCGLB;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid GNGNMLCMPEJ;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid DGIOHHKMLKD;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid COOLJLIONFK;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid JGDGEPBCGKB;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid FIPOIMGOPHM;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid OJFDFCEJHPA;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid LKDGILGLPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid CDBGHLJOPBA;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid OODAGLBGDJP;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid EFECOILILFI;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid CHFMDLFCLHN;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid MNKHOLIGCOH;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid NBJANNJFMND;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid KLICHLBMPEM;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid HKPBJEOLDNB;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid IJOIIBLFGEH;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid ANLGEKBGFMF;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid PLNKLFACBFN;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid PENNIOIBHND;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid DNOAKCCDEEM;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid EMMHLBJIDIP;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid GPINBNGCIMN;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid IOEDLHLOGED;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid JPIBDKMIPDE;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid NGAMBKNJKKI;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid DILNBHDHFAI;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid CKLGIOPBNHN;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid OPFDANCFCAF;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid NAADFGIONNC;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid BPKILCLHAPC;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid FCJHHFEJPKP;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid LAOKFIKDFPN;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid JNPDCHJEJJE;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid BDANMAPIMBP;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid JACABDNNLCC;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid HDPMDJCKCPI;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid AEMBPHJKDPN;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid BLNPKMJHDBA;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid PCNNPEDENHK;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid JBHFOFOBKNM;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid PBPPDGOKEGP;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid OGDHPGHPGMG;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid HHJLNMJMJNB;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid HMAIJMMOEFG;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid BGDPAEBHHED;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid CEABIPHAJIN;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid EPEGJFKKBFC;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid KMGOCDHHEHM;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid BPBLLNJEIHF;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid GJNCLOJEBKJ;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid IEOLKFPACFE;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid BPFMAGPKJKF;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid GCOFNNLOOCO;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid CPOJGCKIPPH;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid GJGCCHKIOFN;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid KBGIHIIFEGL;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid LADCGKNCJNF;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid ANGFJHEGIJG;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid IELGEAJBCFB;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid HJMJLMHEJCB;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid HAOMNBCNHNB;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid LHJHLCEJJNB;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid GMPPAILGCDI;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid DFKOCMIOACI;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid NCHAKBLJGGK;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid ICBHIIGJGEC;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid JLKCOMNINDJ;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid KOGNANBBEPC;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid ILNNALMKMBC;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid GLKNPOMJFFM;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid OGGJAGDHNAI;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid HOGDOOLMBIG;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid FPINLMHAKJK;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid DIDGFAGKODC;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid LOCOEHDEHIB;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid KJEFLOOBCHP;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid CDDILBJHLIJ;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid PKCHJKHEIBM;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid HEHLLNOIILE;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid FBKNJODCNGG;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid KKPLEECIHKM;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid FIAGACAGFNB;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid CHIKIOJOFCM;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid MLJAMCOBDOB;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid IIJGILHIMEP;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid NJKNNONOPKM;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid LCJPLBPAGEN;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid BFMCHKDPLDO;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid EPONHEKBBBA;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid AJLOJIIKKCE;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid NBMGELGKLMH;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MJOLBIJEBFP;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid NDKLKCBKABO;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid GOECGDBAGKL;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid PLJDINLIJMJ;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid PPPLCHBHOBH;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid ECECNBAOHGC;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid MOLOBMEKAPB;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid OKEOEJJJENH;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid OCCBFMKCKDH;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid BBGHKEOOHGP;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid MNMHLLBDMOH;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid DFMHAPDNFDC;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid LBFOKGLCGJF;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid OKCFIAKMNFL;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid EPJCMNKPJGD;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid MNNIGFHPBOD;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid PBHBKHCMHDE;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid OKJMNLFNHNL;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KEDFECJAPLJ;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid DCLNFNGMNBC;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid INGPHEBOIHC;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid MOJIHHMIDHC;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid GGCOHLOBKAI;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid GNLFHOKGNPI;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid PJPGBJEKCIP;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid AGMAJAINFOC;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid NAAMDJNKCED;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid BLIFAMKABGO;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid CIAPNDKKKJO;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid BHNOJLMAMKI;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid AJMPEDGIFMC;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid LHOKJBGEDNB;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid DOEEIAIIMFN;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid MLOBPIABGOE;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid FMPDOCOAILO;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid NFCDMLCGCCH;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid NPKLPEJDGGB;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid GBJNLFIBHJC;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid PINBHENEKHG;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid MDAGJFPCBMI;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid CGBDEEBKCFA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid HKJOLCAFAMN;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid KIEHNAANMFE;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid OKMANHHNFBI;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid CEJCPIDCDKD;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid LBCBMLOBIOG;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid PAAPEOJNCEP;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid EJBLBKHJEHF;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid EPCDMFKNAGK;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid GNIBKFLJNNN;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid LCPCNAGIIFG;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid JIKMGEJPIGM;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid CAJPGOGMFIH;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid NJLDDCBDJEI;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid PMDNOACBMOG;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid OFEKDKLDNBK;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid GGOEDFHGLDA;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid HNEEJEGAJJN;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid NJCBHAANIOA;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid MNPHBFHBLJL;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid FIPFAPIOCJN;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid IIFPGODJBLL;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid JPHPHBANHJL;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid ABGBBBIGELF;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid PNGIPCDKDNA;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid FBINNEJHIKH;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid GFIAECNFLJI;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid FHAFCHLJDHM;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid NJLONHMHADE;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid PCBPMFJGAGN;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid JEOAEFPBEDH;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid DKILEODHBFF;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid DPEGIEBDLCD;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid IPAIFPKHPBP;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid FHLMDMNINDD;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid FJKFMGGAIKD;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid EOJJJKGLEFO;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid MLKKECKDLCL;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid EGOLDOJKNPH;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid IEINNEONJMM;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid HGLLCKICKPN;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid LAPKAFJGLGJ;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid IOIEHDNIBGP;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid EIGDHJCOOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid KFKAAOBEOFG;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid OCGKLEGEIED;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid FNILPEPEHAM;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid DALLJHHKDOG;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid NFGPFLJKMBK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid KMDOIGMAOIA;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid EHDHDNONGCH;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid OBKPKJFLPLO;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid BOJHMCKIIKA;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid PNIIJBGGAIH;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid GPODFOAPGHC;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid APOKBGLCHFL;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid FOOOABDLKCL;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid LCFBDNEAOIG;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid MKBPHOKJAGI;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid ILCAMJHBFEB;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid MAINHDLPLKH;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid AGCACIOAGBC;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid GJIOMDFECFJ;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid FLCPKPANNGL;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid OMAOKJEBHPC;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid HPIGKGINBAH;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid ENCGBLMKPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid KBKCMCJFFGC;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid CCMMOMKPOIC;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid NNGCPJEBDCD;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid IJIIKAGCHAA;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid BDONJOIBBLL;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid OPGMANACLLM;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid IGJFNMGOEFD;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid GIAFOBDAPDG;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid ODGLOMOEMBF;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid IPLBEOHMDOF;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid LLDHOEEDAAH;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid FGPJPJOJDGI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid EMOBFNOIKNK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid JELMNLHNHAI;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid EBONHAEFBHF;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid IPPJCALBAOA;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid CGLAMPNNHDK;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid NFMMGEKKEIA;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid JNAIDPBFBAA;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid PLCHKBOAGML;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid ABOFCFADIKH;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid MAEGFNCNIDM;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid AAIDPHABOAL;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid BGEPKEMEFBC;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid KDEJJHIAFLD;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid OJJNCGPINPM;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid OAHDFHKEBDG;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid NEPLJLPFGHD;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid BLLJOHHJEBB;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid CPHNFEOBDLH;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid CHCFMIMGMFN;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid DMCCIGEICLG;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid AOLIEPIFJGC;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid FKFCDAJMEAI;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid BLKHFDDFFHK;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid ELJHOENELLK;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid DDFGAPAOKMB;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid ODEILBMBFFO;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid KKAMBDMCCMH;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid NKDOCPJMJFK;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid IJINPCMBNCD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid PNOBJPFKDFG;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid CIOIEEJLHCG;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid JPKFMKPOMEI;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid PHCMHIOCKBA;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid CLGEDHCCFEK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid DADGBBDCKFJ;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid AAJABLBJJOA;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid JINKEMFGALN;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid PIFKJHGMAPA;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid KJDJDDLEPLJ;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid KKMMDIPLALE;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid CPPDDHKNLEN;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid ADCLHKBDPPD;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid KNEFPEHLKPC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid NBLPACPAILB;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid PAIJFFGJHAB;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid KIAIJFGKNOC;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid AEEPMAMCLHC;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid GCFJLCPIIEE;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid BMDDPPGLHCJ;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid LGFGALNMGHE;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid JLPNPHKNHCL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid KJFBLOOEAOI;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid BANCHNFGAIF;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid OIAIACMOOOC;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid LIEPGMLMLAE;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid PPKFAGFFODD;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid GNGJFDFEJNJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KEOGFDMGOPG;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid PCEDOALCHNI;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid CLOCPIFCCBL;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid KDPHFEMGBLN;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid JHMCCBKENGD;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid NBLOLMENKGF;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid GNFFJAEIIIH;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid NEFIAGIABBN;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid KNDPPEMLCKH;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid NCAFDONBGPF;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid LJMBGNKIMEL;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid AEAGKABKBMH;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid JEMMFAAOKBC;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid JKBGKHFONFK;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid HPEKEPCPGBI;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid EJFCDDOHENO;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid ODHOFLGHEHJ;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid ANOIDBCOCDM;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid CIJMKLBPBDO;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid POAKIPAOFIK;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid OBOEAJIKOEN;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid DOKIFPKFJOM;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid MKBIEJOHFOA;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid ANGLJKAPIFO;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid IEIJBADHFCF;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid BMLIBODCNPG;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid EFMINOFNEHM;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid PJPJMOILPOE;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid BBDOEFIBDFA;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid NFNGCKBALHO;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid AIENFJIJJGD;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid BMLMFJKKAIH;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid EGJMJKCNBPI;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid LCNPGEKKABG;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid KANIPLBNGFK;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid IJKFJOAKGGP;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid NEENBKAMKJE;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid CBFLMGCOCJN;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid HAEOFFLIMHB;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid ELOAKPEPICC;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid MFECLLIFMMI;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid HHBOKIMMOEP;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid GPPFBCGAGGO;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid PNEFBDGINPI;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid GHFOKDCPFCD;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid BGIEAGEPCHL;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid PJLEDHNOIHF;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid FDJJBFHABOI;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid NELKJOHJEPH;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid FEHPCGKPPDL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid CNFMGOOGNMH;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid DCDGPFOHJEC;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid HEHGINGEJCN;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid GOJELKCNKNK;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid PGGIODKEOGM;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid LKNNJGNDPGA;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid LIBANMNCDOB;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid EEBJPJPIDNC;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid DOIDIEJLFLK;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid MFLBNALKFDH;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid GBFEODHGFDD;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid DCONFGLIOJO;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid FOBHAKEIDKE;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid JICPMAPNILD;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AJGJOOOKLFF;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid LMJKDAJFMNE;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid JJMNHONPGBN;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid ICHHMMHPDMF;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid IMMOAPCCNAO;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid FCPBMIIPFHF;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LPMOOHJKNCF;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid BOGDAMEHLKD;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid NPCNLIDOPAN;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid CBMNMHNJLCM;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid FDDGOEFLEGG;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid KCGEJGLHFLG;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid LEMDDAENEKB;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid JMCFGKCLMAG;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid GAENLJEKBMB;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid FDGDHFEMFMG;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HHMGGFEALCK;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid PJFJNPBNDFK;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid IKFIBBFDHCG;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid HFDMBBHLIMD;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid GEJIIHJJNHC;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid IDLIIIBLMDK;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid DLNKGHPJPEG;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BHNIGBLOLFI;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid GJKALJGBIPG;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid AFDEFKOGKJA;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid DKKOPDKDDDI;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid BAFBCNJNOOM;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid BOJGIKHGDCC;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid AEDHDBDACMI;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid CNEEOMJBLBO;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid GKKJGDOFNPE;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid DCBMIPNGHEM;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid EAKPDMMEING;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid MCFNIHHPKMP;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid OJIEAEKBFOH;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid FAPJKGFHEAN;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid KADCMENBFAJ;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid JCCBBOGOOOL;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid NNCNKMMHBLC;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid LHBJMLAJJLK;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid GDFNFAOMEOG;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid KKAODBBDFPE;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid FCMHDJLODAP;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid CAOKJDHNLKB;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid CBAFDCIBJLI;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid IOPKECLNFPA;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid FHGIPPBLNAB;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid NCHEAFEEMKI;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid HODIEEKHDKE;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid KECEILPBMAA;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid CEGDNIDIOHE;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid BPELBNGEPKH;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid NMMAAIPACFC;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid DDFJGBGBBPN;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid ENACJBAPMAI;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid DIOPDCPCDEO;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid KKLMJCDCGLF;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid HLCKPAAFIDE;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid CLANOLDBLCO;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid DCJNFLHGLPM;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid GHPJKGOMPEG;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid PDEHNIKNFKF;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid DFFKGLPBBNL;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid HHPJLKBBIJG;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid MGEMHLCBAPH;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid MBJDEGPBNDN;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid KKCFGIAALMO;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid CFEPKNGIFAN;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid HBNLAJJDHJD;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid IAMADOLFLKN;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid AGOOGGGLNLE;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid PAOKOCPNEDF;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid GDEPEKLMLGO;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid HONAMGAKAFC;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid POOJEMNPGKN;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid EHEAMOJKBLL;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid LOEEMMDFCCI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HGPOHBMEHBA;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid CNOAENINCIE;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid NMPNKKMEFPI;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid BIHLPNHBLJD;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid EPHEABCCHJP;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid FHFDOFGOFFJ;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid FDKIFJJCOBE;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid FOMIIEMBBJI;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid CMHALPCCLDN;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid HFBBIMJBMHB;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid DDMGMFFNNJE;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid KJNBGFKHBHN;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid CNDIMBNNDIK;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid BGFJLGJCBAA;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid OIDIBFMMHHJ;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid CMMNPEHKJDE;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid HBJOAGIJIGE;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid OMPFGPMDPDH;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid MNENECPKPAE;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid IGJBDJNCBHK;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid GIHCBBLNPBM;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid FMINCLBJOHH;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid GIAGOCKINCP;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid CLIGCFOHAFK;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid NOHLOPBDPLO;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid NBMGHNHOFJA;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid LOCFCBLKPNO;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid BIICKIPJJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid PGDCKHLJMGD;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid JMJHHEPEDLC;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid CNDCLJDCJKI;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid DDHLAEEAAHD;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid IDABGNMJIFH;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid GMPKKMEIIPM;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid JBHCGBNNBCJ;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid JOFKOIKAPPL;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid OMCDHHJIJLI;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid IMAIDGLEFHD;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid NCJNEPHOMIB;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid LPKFBMCGMAL;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid IIGCLOHCLHM;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid OFNIENPELFP;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid HCOBILJAGCC;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid NPJLJGKAHDG;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid PPCGAOAHONG;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EIMPKCKAOEI;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid NKBDMGDGAIC;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid PAPMDDPMJLD;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid JKAMEMFADEP;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid HPBKNOHBKGO;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid OMEFCKHMLMM;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid CFCCEBGNMKM;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid HCAOMCDFLAO;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid CDDNLMDFLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid NMNNFJMKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid EAGOJBMEDPI;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid HJJALKOFIEA;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid OLIOMHFIEMP;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid BBHGLNBNMNN;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid FBHEBPFIBJF;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid KDDLFBHADMC;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid PMDHMOEEGNB;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid IMJGIADKNPH;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid JDPNDECMKMN;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid OEAPIFAFAPK;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid MFKKAMIBHHC;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid EBKNHAPNFND;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid EABHPNNOFOE;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid OFJOMEGMAHI;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid EFMAPFEHOKO;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid DAAJKCAEALI;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid BGGGDKOGLDA;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid FMJEKLPLMCO;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid DAJKDJLGGCO;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid JNCPALPCBLF;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid DJBDNHCFLBI;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid JEEEFLKKLOK;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid HBNPHAPEEPG;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid ELKEHKOBHLO;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid IJFLGKPBAFB;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid IMFIPBENHEL;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid GJKLCOJAEMD;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid EHLBFNHJHFJ;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid EKONHBBFKJH;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid BBDHOIMELIF;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid ABMINCGLFFM;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JPGJECEMOMG;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid LHMMPNCEMOH;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid BGPHCKEIBAH;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid JMABHBKAPOD;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid AJEGAICOKPB;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid POPELGMOCHB;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid DGEIBBKFLGI;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid MCAJGAGBPHH;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid NJJAIKGKLKL;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid IHBBHGAAOAE;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid IHABEJABGJO;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid NKIMKAJDDHF;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid DPPIDFDDAKL;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid CENBCLMCGJE;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid LAIEBMEAGIN;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid FEHKLBGBAIH;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid ICLCMMGINHP;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid CFDOBCPJHBP;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid GGBJLLOFDOE;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid HGPGAHPJAAK;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid HFMDAFKHIOF;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid DLPEGPBFGMB;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid EIEADCCJBMA;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid NMJFCPBPPCK;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid LIDKMNPCBNC;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid BKKMJNCCLKC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid IODFICPFLBP;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid GNJKODMCABC;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid NDGEEDIIGEF;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid PGKJDKHDAIB;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid OAOOGFNKCPA;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid NIKJLFJKHEF;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid LMEIHHDNGCG;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid NJCMNONMMAO;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid JHONAJFDOCG;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid GDBLCPNJHCI;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid FBBKDHHDGIG;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid OIPDLKDPPBA;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid GEJFICIHGDF;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FDFHJMJGDFL;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid HCLMECPJJBJ;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid ENDIIHHIJLN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid JHOMOONADKP;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid JNMFKHFHDOJ;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid GAPNECDKDGG;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid EKEBLEGKNBL;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid EDNBLKNHAFJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid JMFMFFOLIIM;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid APJMILKMDOM;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid EOECFMGGGHN;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid EOCCEMIEMHN;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid EAHHGMJOABN;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid LFIKAKGABEO;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid DCEINNOFDGI;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid DJKMJJJDGGG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid NKGPCHMJOHH;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid MGLGOMOBBCO;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid CEBJEFJKHAL;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid LNKGHAOGMFI;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid GBMAJANOOJK;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid BADJOHCNOEJ;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid AMHAOBJLKLF;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid ABNLMBEOLEB;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid JICENMOMAHC;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid KGGMLDCFJDC;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid MJLDJLMJLLO;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid BLHNHKOLIDG;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid MMKEPLBCBHL;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid NIKJOIFJCAM;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid DAAOMLKADMP;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid LFGAKKILEEJ;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid JKMFOJBGBFA;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid PPGNLKAHFCH;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid OMFOOKFNDFB;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private static readonly Dictionary<Guid, PDNIGGANKNP> ILIEGNMPHGK;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Dictionary<PDNIGGANKNP, Guid> IPLNDOEHCHD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, PDNIGGANKNP> EOHNNCFBPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F934F0", Offset = "0x5F922F0", VA = "0x185F934F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<PDNIGGANKNP, Guid> DMIFCIGHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F93550", Offset = "0x5F92350", VA = "0x185F93550")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LAIFHLDGDKF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F94E70", Offset = "0x5F93C70", VA = "0x185F94E70")]
	public static bool BIOGBAOIGIG(HPJIIHPBCGA BCMFCBJDIGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F94EA0", Offset = "0x5F93CA0", VA = "0x185F94EA0")]
	private static bool BIOGBAOIGIG(KKNMECIDDAF NPMDFMNNIKO, HPJIIHPBCGA BCMFCBJDIGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct NHFCBMBBHDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly BAOPOFKCACI KCGMDMNFBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly IEnumerable<LNCMOCFNOHJ> MCPMOEINNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<LNCMOCFNOHJ> GECNAGBKAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly APKOFFGFFFK<KDBDGIHKNNN> MIHJKDCDLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly IReadOnlyList<PHLKLNCGIBD<FBIIPPBHJDJ>> APBOBFJKANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly ByteString PLBBGKOFDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public readonly MGGPMNDAJFC MGKFBDPAKFF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5F96410", Offset = "0x5F95210", VA = "0x185F96410")]
	public NHFCBMBBHDG(BAOPOFKCACI JANFECGHBJG, IEnumerable<LNCMOCFNOHJ> MDGDANKKFLP, IReadOnlyList<LNCMOCFNOHJ> NOHEHFLJNOA, APKOFFGFFFK<KDBDGIHKNNN> JOHAHLOGLFF, IReadOnlyList<PHLKLNCGIBD<FBIIPPBHJDJ>> HFINOJBDAAL, ByteString MMHOOMACOOG, MGGPMNDAJFC FALNCAAPMMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HHDDMHNBDFB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(CBNOCIHDLEI HKPHNGEBIED, [Out] Dictionary<int, int> ALAGCJEHCJC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(OCOIPGLFIJM EFODFMENBML, KMOOOBAMPCO NDFJNAIFMBK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NKEAODIIPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public readonly Guid PDHGCDFNGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly Dictionary<Guid, Guid> KFEAJJOKEEM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> AGKDJJLJHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x336F520", Offset = "0x336E320", VA = "0x18336F520")]
	private NKEAODIIPEJ([In] Guid EHPBICIBGCI, Dictionary<Guid, Guid> IBGBAJALAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F968C0", Offset = "0x5F956C0", VA = "0x185F968C0")]
	public static NKEAODIIPEJ KIABKLCMFNA(IReadOnlyDictionary<Guid, Guid> NDBHLDAEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F96510", Offset = "0x5F95310", VA = "0x185F96510")]
	public static NKEAODIIPEJ JNNNGKHALFC(IEnumerable<KeyValuePair<Guid, Guid>> NDBHLDAEEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F968D0", Offset = "0x5F956D0", VA = "0x185F968D0")]
	private static Dictionary<Guid, Guid> KMIMEGJBBLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F96980", Offset = "0x5F95780", VA = "0x185F96980")]
	public Guid PMDALGPDDII([In] Guid FILMEIPENDI, bool NFMELLMDKKH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F964A0", Offset = "0x5F952A0", VA = "0x185F964A0")]
	public bool BPKJJJLKEDB([In] Guid JDEPDKNELPP, [Out] Guid JLHJFFKNGLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DLAIOMKIPPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CPKLFKPMELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HONCKFFEJNK(ByteString MEFCHKNPKLC, NKEAODIIPEJ PAINKIKIBBE, [In] CKJMKKGECDL AIJJLLKFKFN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface COFHPCBOCMB
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class GIMPONAMEPM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> BAFFDIBPINB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> FMHDLIFOEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x79B830", Offset = "0x79A630", VA = "0x18079B830")]
	public GIMPONAMEPM(IReadOnlyDictionary<Guid, Guid> GKFDGAEEJHB, IReadOnlyDictionary<Guid, Guid> GIIMPFCLAPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CPAFAAIGCID
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F840", Offset = "0x5F8E640", VA = "0x185F8F840")]
	public static CPODBJFHCFL KOMGBNJLCPG([In] NHFCBMBBHDG NJNOGCBDIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F170", Offset = "0x5F8DF70", VA = "0x185F8F170")]
	private static void DOHGIKMLPJD(CPODBJFHCFL KHDIALLCACJ, [In] NHFCBMBBHDG GKINIDHMKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F90850", Offset = "0x5F8F650", VA = "0x185F90850")]
	public static bool PFCEAMEJPKD(CPODBJFHCFL KHDIALLCACJ, OCJFCHLLFBA KFJNGALHDGO, NKEAODIIPEJ? CDBENKEIDMK, [Out] GIMPONAMEPM? IBGBAJALAAG, [Out] string? NGPMDAJFCLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F905C0", Offset = "0x5F8F3C0", VA = "0x185F905C0")]
	private static void NDGLJKJFJEK(CPODBJFHCFL KHDIALLCACJ, NKEAODIIPEJ? HGGBOECLJBH, OCJFCHLLFBA KFJNGALHDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F7D0", Offset = "0x5F8E5D0", VA = "0x185F8F7D0")]
	private static void GOFLKKCFNMM(CPODBJFHCFL KHDIALLCACJ, OCJFCHLLFBA KFJNGALHDGO, IReadOnlyCollection<ByteString>? CFOCJFOPBDK, IReadOnlyCollection<ByteString>? EINLIFAHDGF, IReadOnlyCollection<ByteString>? LNKFNMGJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FC90", Offset = "0x5F8EA90", VA = "0x185F8FC90")]
	private static bool MLGIPGNPLPF(CPODBJFHCFL KHDIALLCACJ, OCOIPGLFIJM EFODFMENBML, OCJFCHLLFBA KFJNGALHDGO, [Out] string NGPMDAJFCLG, [Out] Dictionary<int, int> ALAGCJEHCJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F9B0", Offset = "0x5F8E7B0", VA = "0x185F8F9B0")]
	private static Dictionary<Guid, KKNMECIDDAF> LKBEOAAPGMC(CPODBJFHCFL KHDIALLCACJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F0D0", Offset = "0x5F8DED0", VA = "0x185F8F0D0")]
	private static void AHCOHDIIGAA(bool OHNKJBJOAAO, LNCMOCFNOHJ NGMNPKFFGCP, Dictionary<Guid, Guid> LIDHCGENFPH, NKEAODIIPEJ KGLIFPEDMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F90330", Offset = "0x5F8F130", VA = "0x185F90330")]
	private static void MMMGMLOAHNB(LNCMOCFNOHJ NGMNPKFFGCP, Guid EPBEGMAOAIJ, OAAFCNKPMKL? NMCGAILLBBE, Dictionary<Guid, KKNMECIDDAF> GINMJLJKJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EC20", Offset = "0x5F8DA20", VA = "0x185F8EC20")]
	private static void AFGDBGJKFEF(IEnumerable<LNCMOCFNOHJ> PNONKLJILMD, IReadOnlyCollection<ByteString> CFOCJFOPBDK, IReadOnlyCollection<ByteString> EINLIFAHDGF, IReadOnlyCollection<ByteString> LNKFNMGJJFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OCJFCHLLFBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public bool OHNKJBJOAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public MGGPMNDAJFC FALNCAAPMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public OAAFCNKPMKL? NMCGAILLBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public OAAFCNKPMKL? KKEAFJHPECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public BAOPOFKCACI NEPAAOBFOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public COFHPCBOCMB HLHGBKLCMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public HHDDMHNBDFB LFOOMHGJFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public DLAIOMKIPPN PGILGFCPFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public PHLKLNCGIBD<KDBDGIHKNNN> POCKHFMLABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public FBPKJKBPHMB CPPEFFDLHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public List<LNCMOCFNOHJ> FHDBMPCEKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public Dictionary<string, object> BIBADDBFGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public NDBAANIDGAO OHAMDPOJLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public bool PILFKHPKBIP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CIGPBJKHCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F97380", Offset = "0x5F96180", VA = "0x185F97380")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OAAFCNKPMKL
{
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private const float EMFDPMJDGCI = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Vector3 MHFADBEELBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Quaternion NJBEEEBFFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public float OPIINMIIKCC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 PFHCOMEIMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F97270", Offset = "0x5F96070", VA = "0x185F97270")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CKJMKKGECDL EAGOGONAMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F97230", Offset = "0x5F96030", VA = "0x185F97230")]
		get
		{
			return default(CKJMKKGECDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x92FFF0", Offset = "0x92EDF0", VA = "0x18092FFF0")]
	public OAAFCNKPMKL(Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP, float OPIINMIIKCC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F96E30", Offset = "0x5F95C30", VA = "0x185F96E30")]
	public static OAAFCNKPMKL GIKACNDOGEP(OAAFCNKPMKL GEFCENNBDFI, OAAFCNKPMKL NPAEBDHCACA)
	{
		return default(OAAFCNKPMKL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F970B0", Offset = "0x5F95EB0", VA = "0x185F970B0")]
	public static OAAFCNKPMKL GMMJAEFOFKB((Vector3, Quaternion, float) HKPHNGEBIED)
	{
		return default(OAAFCNKPMKL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F970D0", Offset = "0x5F95ED0", VA = "0x185F970D0")]
	public static OAAFCNKPMKL GMMJAEFOFKB(Matrix4x4 JNHHMDNCHJB)
	{
		return default(OAAFCNKPMKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F96B10", Offset = "0x5F95910", VA = "0x185F96B10")]
	public OAAFCNKPMKL DHNOPPDAKIM(Matrix4x4 OKMCACLMLOF)
	{
		return default(OAAFCNKPMKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F96D30", Offset = "0x5F95B30", VA = "0x185F96D30")]
	public static OAAFCNKPMKL ECAAPLNFKEG(Vector3 MHFADBEELBD)
	{
		return default(OAAFCNKPMKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F96DA0", Offset = "0x5F95BA0", VA = "0x185F96DA0")]
	public readonly MHALHOHPEDG FICNJKNMNMJ()
	{
		return default(MHALHOHPEDG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LOJBBDLNEAC
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F96380", Offset = "0x5F95180", VA = "0x185F96380")]
	public static OAAFCNKPMKL CFALPKPMCKM([In] this MHALHOHPEDG OJFDNDCDDBK)
	{
		return default(OAAFCNKPMKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CKNEOALOMDC : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EA00", Offset = "0x5F8D800", VA = "0x185F8EA00", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E420", Offset = "0x5F8D220", VA = "0x185F8E420")]
	private void DGHIGHKJGFK(Dictionary<Guid, Guid> HCOMDCKAOFN, HPPACJNJBOM CGJMPIHLKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E3C0", Offset = "0x5F8D1C0", VA = "0x185F8E3C0")]
	private void DGHIGHKJGFK(Dictionary<Guid, Guid> HCOMDCKAOFN, KGGPIMICDJD CKOLFBGKDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E140", Offset = "0x5F8CF40", VA = "0x185F8E140")]
	private void DGHIGHKJGFK(Dictionary<Guid, Guid> HCOMDCKAOFN, AENCHPMGEDN CFAGJGFPDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public CKNEOALOMDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HAPPHEACCJO : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F92090", Offset = "0x5F90E90", VA = "0x185F92090", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public HAPPHEACCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class BMPDJAJAFCH : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F8DFE0", Offset = "0x5F8CDE0", VA = "0x185F8DFE0", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public BMPDJAJAFCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class HDLNMCFLMDA : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F92130", Offset = "0x5F90F30", VA = "0x185F92130", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public HDLNMCFLMDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class PELKMIKNEFA : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F973D0", Offset = "0x5F961D0", VA = "0x185F973D0", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public PELKMIKNEFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class PGFAIEOLDPB : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F975F0", Offset = "0x5F963F0", VA = "0x185F975F0", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public PGFAIEOLDPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class COAGJIFMLHG : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EA80", Offset = "0x5F8D880", VA = "0x185F8EA80", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public COAGJIFMLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class KIDFLDDGECJ : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5F94CD0", Offset = "0x5F93AD0", VA = "0x185F94CD0", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public KIDFLDDGECJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class PNGIODAMHKE : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F97730", Offset = "0x5F96530", VA = "0x185F97730", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public PNGIODAMHKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class DMHJDCEHKHC : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F91ED0", Offset = "0x5F90CD0", VA = "0x185F91ED0", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public DMHJDCEHKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class IJKEBJNAHJI : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5F935B0", Offset = "0x5F923B0", VA = "0x185F935B0", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public IJKEBJNAHJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class JPCOJNPACNE : PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly EDDMFPAADKE OIDEMJBEMEP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5F94BA0", Offset = "0x5F939A0", VA = "0x185F94BA0", Slot = "4")]
	public void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public JPCOJNPACNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HPJIIHPBCGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public OCOIPGLFIJM ECDEHLGBDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public LDKKDCNOIHB NPDNAHIKMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public Dictionary<int, int> CMMCBEFFHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public Dictionary<Guid, Guid> OHBKENNAKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public NDBAANIDGAO OHAMDPOJLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public bool DHNLBCIJHGE;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PHNFDLKGGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOEMPNCGCAG(KJDNFDEBNIN JDEPHLAANOD);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IAMOHEBNNEA
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private static readonly PHNFDLKGGHK[] EJDMNLDHEIG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F929B0", Offset = "0x5F917B0", VA = "0x185F929B0")]
	public static void GMLALEHPPCH(LNCMOCFNOHJ HKPHNGEBIED, Dictionary<Guid, Guid> KCHCFHIHDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5F92650", Offset = "0x5F91450", VA = "0x185F92650")]
	public static void DCOGGMDAHPB(LNCMOCFNOHJ? HKPHNGEBIED, NKEAODIIPEJ DCILIOFHOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F92C40", Offset = "0x5F91A40", VA = "0x185F92C40")]
	public static void NLPHPAPKIEB(LNCMOCFNOHJ? HKPHNGEBIED, NKEAODIIPEJ KGLIFPEDMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F92280", Offset = "0x5F91080", VA = "0x185F92280")]
	public static void BIOGBAOIGIG(KJDNFDEBNIN JDEPHLAANOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KJDNFDEBNIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public OCOIPGLFIJM NHOCOHFNBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public LNCMOCFNOHJ NGMNPKFFGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public Dictionary<int, int> CMMCBEFFHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public Dictionary<Guid, Guid> OHBKENNAKFN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F94DC0", Offset = "0x5F93BC0", VA = "0x185F94DC0")]
	public Guid EHMLHNFMGHA(Guid FILMEIPENDI)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface NDBAANIDGAO
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int HFDNAMHIPJH, [Out] Guid NLGHOPLEMLN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JCPEACAOGAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly HashSet<string> IKCJGBGDDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Dictionary<long, int> AEBDJFHHMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly HashSet<Guid> JLMAKNGEIEN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> IEEHPJMIMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> HHPICGHBDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F93960", Offset = "0x5F92760", VA = "0x185F93960")]
	public static JCPEACAOGAA EMNPOLNGAPA(NAGNHACOKFH CPKEOAPOOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F93880", Offset = "0x5F92680", VA = "0x185F93880")]
	public static JCPEACAOGAA DENALGCDIDK(CPODBJFHCFL FFEPEHAOIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F947C0", Offset = "0x5F935C0", VA = "0x185F947C0")]
	public static JCPEACAOGAA PMOBMJGGFIH(IEnumerable<string> IKCJGBGDDNN, IDictionary<long, int> IEIMNOLCAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5F94940", Offset = "0x5F93740", VA = "0x185F94940")]
	private JCPEACAOGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F94A60", Offset = "0x5F93860", VA = "0x185F94A60")]
	private JCPEACAOGAA(IEnumerable<string> IKCJGBGDDNN, IDictionary<long, int> IEIMNOLCAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F93DC0", Offset = "0x5F92BC0", VA = "0x185F93DC0")]
	private void LEMHMBICPHN(NAGNHACOKFH CPKEOAPOOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5F94460", Offset = "0x5F93260", VA = "0x185F94460")]
	private void LEMHMBICPHN(CPODBJFHCFL FFEPEHAOIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F93FC0", Offset = "0x5F92DC0", VA = "0x185F93FC0")]
	private void LEMHMBICPHN(NONBIMHOGCO? BPBPHOELENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F94650", Offset = "0x5F93450", VA = "0x185F94650")]
	private void LEMHMBICPHN(DFPLDAOMHKC? NJDCNMOJCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F939D0", Offset = "0x5F927D0", VA = "0x185F939D0")]
	private void LEMHMBICPHN(LNCMOCFNOHJ? NGMNPKFFGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5F938F0", Offset = "0x5F926F0", VA = "0x185F938F0")]
	private void EKLMBHJKLHG(string? GGJPMOIFGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5F937A0", Offset = "0x5F925A0", VA = "0x185F937A0")]
	private void CJDPEGHLMKL(ENNJALLPLNA? OKOPFHCKLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5F936B0", Offset = "0x5F924B0", VA = "0x185F936B0")]
	private void CJDPEGHLMKL(PADIOMKNGIN? OKOPFHCKLEL)
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
