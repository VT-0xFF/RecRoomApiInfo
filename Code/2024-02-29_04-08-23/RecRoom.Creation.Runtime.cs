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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F9C3B0", Offset = "0x5F9B1B0", VA = "0x185F9C3B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CKLNMJOOKNL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> ONEEOHFHJFB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> NBFFOHBPFJM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string NBNLPDDCBGL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string EJMDOJBIPGN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string ELCMBFJIGHE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F95C90", Offset = "0x5F94A90", VA = "0x185F95C90")]
	public static bool ODJBPDDLDNL(Guid IKLJAPPHCNC, int PGBCLCKJEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F95610", Offset = "0x5F94410", VA = "0x185F95610")]
	public static string NLBNCLIFBOD(Guid FANIDECOFDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GBDPOLCIJGB]
public enum MNBINKJPLMI
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
public static class EGOJKMHFFAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid JJMDBEOFDID;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid LALEFNBPPMC;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid FCDIAIDLMKP;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid GBGIEEBPBNN;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid LNCGONGCKEI;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid HBIEPGNKPJA;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid BNCIHJELJGP;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid HMCKPEFKGGE;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid EPJLBBKKMPG;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid IJBNKNGHIBO;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid AAFBABFJLNP;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid POBLCMANLDE;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid GBIOIFMAJIA;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid MPCFMPNPIPM;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid EODOJNKFKDH;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid OOFMCFBOKFI;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid GPJKEAMLMDM;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid HCPPBLJEBFL;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid PBNAEGOILFP;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid KKLLDOHAPNG;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid OHHONJPPIIN;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid PEEKEJEECKG;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid HKBAKCCEAMA;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid KMFJJBMDDAC;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid MEOAANODDOB;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid HLPBMIBKJPG;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid BFLEFIOFHMH;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid FIOMMABAFBI;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid JFAHKOKOLPD;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid FIFPLDFIAKM;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid FILEILKCGNB;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid NPHONJDGFLB;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid PIFHNBNJBAB;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid FGODIKHHEBM;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid GMJJILGFJIA;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid IMIOLMOANEH;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid DOBDDGFIJGN;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid AENPOPOAALO;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid FOCPKEBPJGO;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid KMKOMCLLNCP;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid KKGCOCMPLCN;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid ILFOEHLKGNM;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid BLGJDBHELOF;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid JAOGBKJPNJD;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid CECJJHAKAOP;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid AEKCGOKILFE;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid DFHBBFACBFB;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid FBMHIBAMONF;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid EDNCKBPAHAB;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid FJAAKDOIBHH;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid DBLPOOENMJI;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid PIAPACGLBCL;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid CMKCNCENJDH;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid NFBDEEBMGCO;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid LBIKOBCCEEL;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid FMKIDNFOMJC;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid NEKEHPIGBNF;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid NKGOOKOBPDE;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid LCPCODFNLHG;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid ECBIDGHLDCJ;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid MJNBKGNANLP;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid PEAEJIIAGBL;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid LHPJPFKKNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid JIIPJIPAJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid ODHEEGIGBOA;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid LOOODOELNCH;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid ANOBMIPFPJH;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid HJNPOLBLLMB;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid FGKFDHBGAHM;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid IJOGNOACJMJ;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid EDEPIDEHIPB;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid CJHIMKIJPKP;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid CNGAKMGGHHA;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid OANBBPGBEBD;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid HMBNOECNJAL;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid HMJIECAEIAI;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid CLPFLIHNKMJ;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid DPMIJJAFMFL;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid EJEPEDIHEPL;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid JCDNCIGHMBA;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid JJGADKNODIK;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid DBCEIICDMNG;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid IBPLBAAIJED;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid JDEFPJEIJGM;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid OLPMMGDILHI;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid HLPBKAOAKLL;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid GHGNGCJJDPD;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid CBFDOPBPEKE;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid HIPNEAPPNJL;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid GPOIPFGGDCB;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid LGBFEIJHIHH;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid NDENKDLPGAL;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid HPIGHDJCJLE;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid MJILGNCMOND;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid LKBBNIDHFOF;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid IHACFHBHPGE;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid CEHOKLPCNBA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid NIOGIMIMGIB;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid JFPELDDJKAD;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid HCBJNPKCJNL;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid NFLAELKKOEM;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid IOAGIDLLFKB;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid EFJJJCFGMLO;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid ECMCACOGKMP;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid LCOPPBFBIAF;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid NLOEIACFCHN;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid CKKFBPBNCBI;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid PBNFFDNDLED;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid OLKMPJHEJBP;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid OFKJNPPPOIB;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid PHCOIJHEAPD;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid JCBAHLIKMBC;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid MDDBDMGGEDO;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid MHBBCDIKMHF;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid ACPOFCHNMJE;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid GHFHHDKNAMH;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid GDGMLMCODJN;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid CLOBBDNLFMN;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid IACOOPDOBFF;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid JHOBIMANGKB;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid MJINOFCJCAO;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid AJEKJOJHHKL;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid MEEODFKDDHE;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid DFGADDKKFOJ;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid NLBLGHEPBPM;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid LIPHHCIONFH;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid NDPEJCOGHMI;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid OHJDBMFANBK;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid GKGINGPMGMD;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid BLFFOOLHANF;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid HEBDMPPFHPA;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid CKCIKKANHKJ;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid AKGAHMILMGO;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid IAPLHCLIJEF;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid PDIPBGBLOMH;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid GLNABJIIHKL;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid KBMIEHCJHAI;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid NDACFOOHAJH;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid PGFNALHGKJH;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid NAKKDKPHAKP;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid NPGGHIBCNKH;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid JBKMIILGCGH;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid APMMEGMOKHL;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid GIJNAPBMAEA;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid IDGHOLJHJPB;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid PLDOIJONOBH;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid HOJBMIILCKG;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid GAIAMCBGDNO;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid FIEJPNHLGFI;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid AONJALNKEAH;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid BNBBANJNNNH;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid IHPEIFHPFGH;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid EAOHMEIECIO;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid JOEFGFLNKOJ;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid MOOFDANNPGL;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid JFOHACDPDOI;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid EEDHHBIPICI;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid GGGLPFICJLK;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid HBEJDPJNDBG;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid MHHOELDJJJP;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid CMLDJHCCABN;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FKEDEKAIOHO;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid AGPILJKINLF;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid NJECHFHAIPO;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid MCBMIBABHAF;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid OOCIJNAMMMM;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid PAPPMKLMAOG;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid JADPNOFKGIH;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid NNLGEHOOOJA;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid NBPLLLEPJGN;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid HFAHKOGMLNN;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid MLMIBDPLGFB;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid NDOPHBEOOAO;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid HEMJGKCCIFH;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid GPGDICDIPBE;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid FPIIGLNKAAA;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid HOPLIOMAMDD;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid NKOFHJPHOAJ;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid HHICNDAHIAA;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid IGEILOPFKAC;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid FEHKPGJCMEH;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid BDIPHGGIPKE;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid LAIABHIAHAF;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid NEKCLKPCFAA;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid MHPGCDCIFLF;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid DOOMJGADEME;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid BGBIIAPDKGH;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid MFDNNINFMAI;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid LCFPLMHHCMA;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid ALFLEIFPIAE;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid HOJKODLEAOI;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid DFDFOANGFKO;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid CKAEPFMFNMA;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid IHDGHHAAKGI;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid MCAACIEOKIF;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid JLLHMOHCDNC;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid PHILMIPHMLF;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid KHKGOEKHBGD;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid GEEKOMPGLDM;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid KCAIOGLBMKA;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid IPJHCGGGDMG;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid AOECKPLMEAA;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid HCAOPDOMIBK;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid PPPAAPAABJI;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid KHHKOPHDPBJ;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid LKHNBDLBHDL;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid PJIFGBNBCEM;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid KBMJHNFOIPD;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid JHJDKIOKFFC;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid GMMPNPJGFJD;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid HMNJNFCJHLN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid HCCJOLPEGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid AAPEJANHICC;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid ILGHHOFFGKD;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid LBLKNJDDCMO;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid NIFKPNMGDBN;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FDDFAGNLDIB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid OACKPFCKHCL;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid HCPJIMOKHHM;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid EEBJALJCEKA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid OOGOFPNHFJD;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid EDMHFEHLMOM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid LHNMAHJDAJM;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid NLJMLOMDIKP;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid FGPJDCPBBAA;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid AOMIOAJFGAI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid DLDGFIDPGPE;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid BPOJEMPDAOA;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid POIPBPJGEHF;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid BFLCNGHMNJO;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid BNDENABALNA;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid DNAPAOMNNBM;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid KKMCPPHJBNC;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid OFCHJBCCLGL;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid JHHENCGEMGJ;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid MCDGJOIGNLK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid DBDJGDGNJCK;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid MFDBFFHPEFE;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid GPEACKBOBNA;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid FIDBFHKPNNE;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid INACMJJANPI;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid CBBNBJFGJCO;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid DNFMFEDAHND;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid MNPCLECCAPH;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid ODNPICIIJEP;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid DHHPEOCGEKN;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid OFFFHMFPHMB;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid BFGPNAPPBFN;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid CIADCGINFJH;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid LNJMKPJLFMI;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid EIBJMPHAKOK;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid OOPHCNCFHPC;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid AHPMDMMALMC;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid JKNAJBEGLBO;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid MPNKNNGICHG;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid CKJBIDBNDJO;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid CLEIKAINIDM;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid PMFDCCIGHPF;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid JDAINCAPBFJ;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid IFDMMIEPAJP;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid KPMHHMMOKEB;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid EHKDOKENPLK;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid OFLIEJNGHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid APIAEICKILJ;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid CEFDEEFBCDJ;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid GAKJOLLGBNO;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid CHEILLNFJBD;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid DHNPGFPBPMI;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid FNKJBINPNGD;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid MCDLLLDEEKO;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid FDNMLJPMHNF;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid AOPAKFNBHIF;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid JMHKOFIGCOG;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid MEEAGFIOPAF;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid DHDCOGMBKND;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid AOOPHPOLIMO;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid NHNINLFGPGM;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid BFHPHOKKBFN;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid CAOAALPOJHP;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid JJEEMILNPNF;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid EAABMKNANKN;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid PPPEDNHBCFH;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid PLJFIDGFLBO;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid BHKICGHFMNA;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid JOBCLCIEINM;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid NFJLFJHGKMK;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid JGLGHFDHGHE;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid GPECMAMCEAO;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid PEDDOLCONMG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid OGKCLKDNGFK;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid GGKBEOEJEMJ;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid NLGCIHAEGBE;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid IBODIEHCCOG;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid EACCKKBJMOP;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid NLMGOHEJGIL;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FBKADFFOBBN;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid GGPCEPGEIGG;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid FPFCFICJIAA;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid NPFCOECGDAA;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid LMEFFFDDFEB;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid FLEMPNNKHPA;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid JFHHDLFGCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid OMEPADHFMBD;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid BCAKKBAAGIM;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid BODGEIODLNA;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid AEGLAGGHCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid FBCFODPHOGJ;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid PELGKDLGBLP;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid BLGGKILFBOA;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid INFFCKBMJAH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid OBGPIHPCGON;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid MLBKLDJEDJH;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid MPBBPKMCDOJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid KIFAFFMMJJG;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid PNGGEDCCMCP;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid CNIKHFAJMAG;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MLIOGGOJGLA;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid LDPFNLJADDA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid DAMFFFCHFLD;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid ILHDAMJDCBL;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid IFAMPKNEMGC;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid BNJIKMGAOLF;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid FLBFCBMFADP;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid HCOIFMFFEGN;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid BKGHLCBIFBG;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid FIEBHLHBJGN;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid NHGPPJBNABN;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid NBKBNGDHBFF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid EPPHNCFPKOF;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid OAGOONIONJM;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid DCJEKOGBIOI;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid LPDCECHKGJD;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid JEHJJBALIAN;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid CAJFPJDIAEF;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid COOJGLIHKKA;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid JBBMBEAIGBN;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid GCCNIHPNLGJ;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid KDJJDJMBOPK;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid AHNPDFMCDOC;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid POLGDIGCKBE;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid CBPFPFDGMNF;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid GBIPMEODAHE;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid NPGFHIAGHPI;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid DJCKFDHBKFP;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid GGGHGKCHDBO;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid INCJAOCEAAO;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid GBKMHOOPHON;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid BOJOACKKMNC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid KNLLFAJDJAL;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid CDNAEIJJKKC;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid OFKDCDKGKKL;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid LANJJFHIGCI;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid PENCCLFOPDP;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid BPOBHDKJIAM;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid DFMIDDPPJFG;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid EKBIOHNKOJF;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid HLLLHJHPNKD;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid MCPMHKCHALD;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid MFJCOEPKOCL;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid NJKNBGNEMHL;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid MPMODPLEDBM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid MFNEJEAAGMB;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid FNFELHJFNBO;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HDAJIDNNJLE;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid KEGOJLDFNLN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid LJCMBFOJIJB;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid FOCGBGHFJOA;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid EEBKPLJKNNL;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid HNKNCBBCJIJ;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid PKFKBFKMPBG;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid JMJDACNMJOO;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid PEHMCIEKIGD;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid MOPNMADMBHE;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid ILLLGBKDNHK;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid DMEOOGPIEGO;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid GJMBIGPEJBA;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid EPCDNDDNIOH;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid BINFMBBFKCE;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid KEBAIDNBFIN;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid HOEPNBEGCCD;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid INKANJAGEPK;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid POBLOKKNJOD;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid DHGPLOGABPE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid FFOLKGEDFKI;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid AFNFLLGDKKD;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid CLNPLBPBDGO;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid GGEMFHNLJBF;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid COEIKAHFGPF;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid GCDPDGOJEOK;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid MBECKMOGDCA;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid PCKKGBHPMJK;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid HDOHKNFJKID;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid APNKCJPGEAB;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid GEHJJMGDELE;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid DEFNHGBBLLP;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid JIHKILBOHID;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid BNKMCFIGEKF;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid LBOLOKNPDOO;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid EJBECCKFCDI;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid GDFCJKGGHGP;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid MKLDEJCJDJM;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid ACAJMNAKGFP;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid NNGOHPOIOIJ;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid EIBMBNPCHBJ;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid PIPFDPKFBBB;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid EABILKGPOMJ;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid NGABGPJHEHJ;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid BBNPMMEOINN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid BPKMKPPPPLF;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid OGBEAHKNFDO;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid PIGMCPNCFND;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid NKIAIBLJBGG;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid GFDEILBLAPD;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid DMODEPNMGHB;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid HDHAPHOPFGI;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid OPMGGNNLBPN;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid GBOOOGNCJHO;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid GIEOPJNCPEG;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid FKPPNPLDGCD;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid JMIONIBFFIN;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid HPHLFIECBBM;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid EMPCAGALKEF;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid DHHENADECFK;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid KNFFGGNCDJI;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid LNPGHGBIJAL;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid JOFHEAPIIAC;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid NBJJLFMPEOB;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid HKIGGPPOPGM;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid BHHGLCDINIO;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid PFFLJKGIKAD;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid LOAAHKGKHOD;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid ILJNNHBHHNB;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid DHIEIMCJFPM;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid EACMGLPMBMP;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid DNAHICFNCJE;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid CBECIFLOBBH;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid NJHNBDNGHNE;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid OKODCPMBDDE;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid EEHNNJGMIOA;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid NOKIJIENAFL;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid EHOFLNHBMPF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid FEOHBIAJEMP;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid HNONGFKMPGI;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid NNJMMCOLPOA;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid FJICFGFIMNM;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid AEMKFDKCEGE;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid JIDMLEFGPLG;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid KELBDFNAHAD;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid MGIBEPPHCJJ;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid NOOKBKGLPBB;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid NDHPHJMFKBD;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid JCCDBKINBKE;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid DKNELFGIEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid LPJAOLJOKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid PEIJAMPAJBC;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid OEPAOGOGOOJ;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid CKNMCADIFCJ;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid FMHPAHKAELK;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid FMBOGGICJOK;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid ILPPOLNJNKM;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid IGHKEPENDEC;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid JDDGOCGDEIL;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid BMMMEGGPCOE;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid BCABFJHACLD;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid ICPFJMJIGLH;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid KJMANCGLCEN;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid PNANPOIKPBN;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid PJGFNGIGIBD;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid AAGAJIGBJPA;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid LFKJHPCCDKD;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid APNMDDNJGGH;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid CIFFKGECAEL;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid HKHJMIPIEFD;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid MFIBEJJMAKK;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid DGMHOEEFKOE;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid HGIKAHCLCLF;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid HBOFCCGPEAN;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid IMPNFNOLOND;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid PIHONEEEIEJ;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid AEJNOMDBMMI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid IMMDCEDAGHP;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MEGEMLGGEIH;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid KMKAIMGOPDK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid EGIPMDELKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid OFPPIFJDFDF;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid BGAMNDOPJNL;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid NKJPCDFFNMK;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid MDKFGPGDELC;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid MJHHACBIHCM;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid IPCMCKDDACD;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid LLGEKIOPAHA;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid FAKELACCEEO;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid MACGPHAOCIA;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid DBOANGAAOGE;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid DFDGKGJIGEI;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid KGDGAKGJDBG;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid JFELNHKOCMG;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid IIFMJMMJOKE;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid PMJEMCOHKMD;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid FHLABBKBCKP;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid KPNGMMAPPFM;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid KGCICHLADCL;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid NMIAGPCCGOF;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid DECLCJIHPKJ;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid GGPIPDCEHMD;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid DMLINPPLBBN;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid LHHIEAPJLMJ;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CBBFKHJOADI;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid GPMIJGNKAJI;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid EIPHGHIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid GJEELEPDNOA;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JELBOPPCHHN;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid AHEFLGDEIJN;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid OBNJAFILCHF;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid LHBGMENIGLO;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid LJLCHOMDMCE;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid KLLHDLGFJHI;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid PJPPLNEADLD;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid HMBBOBIGIDG;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid ANELEMEIFBE;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid GJFDPEDJBGK;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid DCDCMDNKHAB;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid CBGKHBNCKPM;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HJIOLCHMFGP;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid KMNNPLOPBHL;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid CKAIPMIDFLO;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid CCPAADHDNIM;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid IOAOGMJCMOG;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LKPKMLMMCHO;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid BOGLDPPEIBG;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid FJIOPFONJKE;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid MPABHEOOCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid BGDNAONIIHD;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid JHIDBLPBGKH;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid LEMMPDEEBKJ;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid KOADPFIPPLH;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid BBLECHKMDFJ;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid NIKEOHEJPEP;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid OBJDAOEMFOA;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid KHCIPKODIOO;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid EKIGJGOLIMA;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid HIOFDNILINL;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid GMAEJJOGOHN;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid CKPCOHDAGMF;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid HGANPENKKCO;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid EMBKCGPOCCF;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid MAJCFKBNHBH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid ECOCLPJHEOL;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid IEDNKBKPKGH;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid DCMMKPOKPDB;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid OIKBEMFLLOA;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid GKNFLAECFLA;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid DGKCHJGBEIM;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid NHNMFJBFDLN;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid PAOKCLCEENB;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid DHAAKGLAPFL;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid OLMCNJJGGGG;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid CDCEMLLMNFK;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid EADALPACCDB;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid AEFDGBPHCEK;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid OMKCDBHFGPI;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid KKGPFIOGGGI;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid IGGILPEHBFP;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid NGMHBOJOKPC;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid CEMNDECDDIF;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid CFPODHIAPOM;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid ABKOPIDMANF;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid OPNMLAPIAAH;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid HNLEJPKKNKK;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid IADGNJABPDL;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid EGGOLOOLDME;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid HGIGKCCMGMJ;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid NJLFMHILPKH;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid EKNPOPDLMFI;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid AGNKHMCJDOJ;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid FNBMHGKDNLE;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid DONLNIOCONM;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid MCKEILNDIMK;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid PBDNAKMIDGG;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid OPMOKPMENLP;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid OICODJADOPB;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid GEJIDIDINAN;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid DMJDOHEDBKB;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid HKDFFCBKLEI;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid BEAAEKJCKAN;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private static readonly Dictionary<Guid, MNBINKJPLMI> AAKOPFKGDPH;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Dictionary<MNBINKJPLMI, Guid> LIADEOAFFBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, MNBINKJPLMI> PIAADDOGAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F96EA0", Offset = "0x5F95CA0", VA = "0x185F96EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<MNBINKJPLMI, Guid> NHMHBIOLHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F96E40", Offset = "0x5F95C40", VA = "0x185F96E40")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DECCIGEHBGE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F96770", Offset = "0x5F95570", VA = "0x185F96770")]
	public static bool GDFGPJKDHHB(MIFLIMCCCEJ FFKFKPFEAIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F967A0", Offset = "0x5F955A0", VA = "0x185F967A0")]
	private static bool GDFGPJKDHHB(NACHLOGOMCG ECIIMDOKNPG, MIFLIMCCCEJ FFKFKPFEAIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct IAPKLNGHPPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly BFJFPHMLDHE DKBCCLDNOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly IEnumerable<OBGGKDBBBAO> NHODOBEJMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<OBGGKDBBBAO> OGMIANDFOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly HIGDJMOGOKB<IAFEEIBLHGA> APDNGHCMHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly IReadOnlyList<ANCACCNALNI<HBKIGHMDJGP>> IIDBHIHJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly ByteString LOKEAKBMJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public readonly IBEALKOKILB DACIEMFFDKH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AF10", Offset = "0x5F99D10", VA = "0x185F9AF10")]
	public IAPKLNGHPPE(BFJFPHMLDHE BOMIMJDMIOK, IEnumerable<OBGGKDBBBAO> HHFGPPAPFJC, IReadOnlyList<OBGGKDBBBAO> EGOPKOPNILJ, HIGDJMOGOKB<IAFEEIBLHGA> CIGDLOFJFDP, IReadOnlyList<ANCACCNALNI<HBKIGHMDJGP>> ONJKKCLOIFM, ByteString OMMHMGLAECO, IBEALKOKILB JMEHKNKFECL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MGCPHNENOAP
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(CCANFGBNJOA OMHIFBJFAGA, [Out] Dictionary<int, int> OMFGAMIJACJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CHJKKBHBLDL OEEHEEEGFLJ, HAFAKPJONAO CKEKKGKBMIF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KBIJGOEDBPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public readonly Guid ACLOFPOFPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly Dictionary<Guid, Guid> JHDCPCNDIFI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> OIIFNKDGOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x34EC8E0", Offset = "0x34EB6E0", VA = "0x1834EC8E0")]
	private KBIJGOEDBPI([In] Guid EJGGCEGMKHO, Dictionary<Guid, Guid> LILPLEEGKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BD10", Offset = "0x5F9AB10", VA = "0x185F9BD10")]
	public static KBIJGOEDBPI JMJFDJPAKHL(IReadOnlyDictionary<Guid, Guid> OIPGFJMEHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BE30", Offset = "0x5F9AC30", VA = "0x185F9BE30")]
	public static KBIJGOEDBPI PGMDKBNHOHL(IEnumerable<KeyValuePair<Guid, Guid>> OIPGFJMEHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BC60", Offset = "0x5F9AA60", VA = "0x185F9BC60")]
	private static Dictionary<Guid, Guid> GJEJPIEHPEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BD20", Offset = "0x5F9AB20", VA = "0x185F9BD20")]
	public Guid MNLMGEOMNIP([In] Guid FANIDECOFDM, bool HILLBCAGBDD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BBF0", Offset = "0x5F9A9F0", VA = "0x185F9BBF0")]
	public bool FKGICEGPKBE([In] Guid DGIBOINMLED, [Out] Guid NMKLCPBAPDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CHKEAFHHEBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CJCOPDMOHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CINNELLPCMC(ByteString CBOHHFCFEEA, KBIJGOEDBPI DDNJNCNOFGK, [In] PBAJPJIMDKJ OIKEPCBCMPK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NIPELHMCNHN
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
public sealed class PKBKJDMCFDA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> NFAJKAOHPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> LODDHJOFAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
	public PKBKJDMCFDA(IReadOnlyDictionary<Guid, Guid> BIFADDGMBLK, IReadOnlyDictionary<Guid, Guid> OLDHEAHDEMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FDCBPMIAIMC
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9ACA0", Offset = "0x5F99AA0", VA = "0x185F9ACA0")]
	public static OMJHNCFCJCD MOKBIOPDPEG([In] IAPKLNGHPPE CNBBHADMOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F994C0", Offset = "0x5F982C0", VA = "0x185F994C0")]
	private static void DJGBBNMINOO(OMJHNCFCJCD MGJPEODJFEE, [In] IAPKLNGHPPE NDJDMJICABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F97B60", Offset = "0x5F96960", VA = "0x185F97B60")]
	public static bool BIBAKIPCDFE(OMJHNCFCJCD MGJPEODJFEE, LAAGEDLPEKK IFAIMBAFGIL, KBIJGOEDBPI? CLNLGOCKFAE, [Out] PKBKJDMCFDA? LILPLEEGKGO, [Out] string? OLGJDMIGDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A670", Offset = "0x5F99470", VA = "0x185F9A670")]
	private static void FIAGHDADLGP(OMJHNCFCJCD MGJPEODJFEE, KBIJGOEDBPI? MKDNFAOKBDC, LAAGEDLPEKK IFAIMBAFGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A9A0", Offset = "0x5F997A0", VA = "0x185F9A9A0")]
	private static void JMEJJMKJPOH(OMJHNCFCJCD MGJPEODJFEE, LAAGEDLPEKK IFAIMBAFGIL, IReadOnlyCollection<ByteString>? FGOJIEEGJEC, IReadOnlyCollection<ByteString>? EFKJCCPBFDB, IReadOnlyCollection<ByteString>? MELCBGELMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F99FD0", Offset = "0x5F98DD0", VA = "0x185F99FD0")]
	private static bool EGGCDBKNEBP(OMJHNCFCJCD MGJPEODJFEE, CHJKKBHBLDL OEEHEEEGFLJ, LAAGEDLPEKK IFAIMBAFGIL, [Out] string OLGJDMIGDKI, [Out] Dictionary<int, int> OMFGAMIJACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F991E0", Offset = "0x5F97FE0", VA = "0x185F991E0")]
	private static Dictionary<Guid, NACHLOGOMCG> DBHBLHEBCDB(OMJHNCFCJCD MGJPEODJFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A900", Offset = "0x5F99700", VA = "0x185F9A900")]
	private static void HKPFJMOFHBF(bool IIKDFCPKJLA, OBGGKDBBBAO BKFACKEMDIF, Dictionary<Guid, Guid> MGBNMGOBOAG, KBIJGOEDBPI CADGJAIBMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AA10", Offset = "0x5F99810", VA = "0x185F9AA10")]
	private static void LOEKIJIMDMB(OBGGKDBBBAO BKFACKEMDIF, Guid LIINBPDEMJL, IEBNJJDDDHC? APHFJCDKEBG, Dictionary<Guid, NACHLOGOMCG> ABHDMKKHDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F99B20", Offset = "0x5F98920", VA = "0x185F99B20")]
	private static void DKCGNOLFDHA(IEnumerable<OBGGKDBBBAO> HFGPKNKOOLP, IReadOnlyCollection<ByteString> FGOJIEEGJEC, IReadOnlyCollection<ByteString> EFKJCCPBFDB, IReadOnlyCollection<ByteString> MELCBGELMKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LAAGEDLPEKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public bool IIKDFCPKJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public IBEALKOKILB JMEHKNKFECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public IEBNJJDDDHC? APHFJCDKEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public IEBNJJDDDHC? FGJFEFKCMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public BFJFPHMLDHE IOPHAEPPIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public NIPELHMCNHN EIBGOJEBJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public MGCPHNENOAP CHBCFCGPDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public CHKEAFHHEBO NEHMLIBOIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public ANCACCNALNI<IAFEEIBLHGA> CLELGMGCPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public MPOMNDOPLNE MCDPNACBIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public List<OBGGKDBBBAO> ABHKIAEANHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public Dictionary<string, object> BKJOGDIPMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public CEBDHFBFDGD CHHJEOPPKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public bool DBFHMDOAHHG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GCMFFGHJLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C1E0", Offset = "0x5F9AFE0", VA = "0x185F9C1E0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IEBNJJDDDHC
{
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private const float KKDMLAKJDCJ = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Vector3 JCOIMLJCHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Quaternion GJMDICOFEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public float NANBGKEHFBG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 JGKMGJLNPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B660", Offset = "0x5F9A460", VA = "0x185F9B660")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PBAJPJIMDKJ AFKNCIFEBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B990", Offset = "0x5F9A790", VA = "0x185F9B990")]
		get
		{
			return default(PBAJPJIMDKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x948D20", Offset = "0x947B20", VA = "0x180948D20")]
	public IEBNJJDDDHC(Vector3 JCOIMLJCHFJ, Quaternion GJMDICOFEBG, float NANBGKEHFBG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B160", Offset = "0x5F99F60", VA = "0x185F9B160")]
	public static IEBNJJDDDHC ANOPOGNDNPA(IEBNJJDDDHC AJKCELPHOFC, IEBNJJDDDHC JAPICPLHPHA)
	{
		return default(IEBNJJDDDHC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B3E0", Offset = "0x5F9A1E0", VA = "0x185F9B3E0")]
	public static IEBNJJDDDHC EADAJIFKEOK((Vector3, Quaternion, float) OMHIFBJFAGA)
	{
		return default(IEBNJJDDDHC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B400", Offset = "0x5F9A200", VA = "0x185F9B400")]
	public static IEBNJJDDDHC EADAJIFKEOK(Matrix4x4 EEHLKGFBENA)
	{
		return default(IEBNJJDDDHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B770", Offset = "0x5F9A570", VA = "0x185F9B770")]
	public IEBNJJDDDHC LLHBABKEJDF(Matrix4x4 PFIKOEBPDGA)
	{
		return default(IEBNJJDDDHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B5F0", Offset = "0x5F9A3F0", VA = "0x185F9B5F0")]
	public static IEBNJJDDDHC JMAMOCIFJOM(Vector3 JCOIMLJCHFJ)
	{
		return default(IEBNJJDDDHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B560", Offset = "0x5F9A360", VA = "0x185F9B560")]
	public readonly HOBJMOMMPME GBKPOLNADNG()
	{
		return default(HOBJMOMMPME);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MENBEBOGBJL
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C230", Offset = "0x5F9B030", VA = "0x185F9C230")]
	public static IEBNJJDDDHC KCLBCLADLPB([In] this HOBJMOMMPME CNFBJPGPBBJ)
	{
		return default(IEBNJJDDDHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class ENJKONKOALI : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F97870", Offset = "0x5F96670", VA = "0x185F97870", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F96FB0", Offset = "0x5F95DB0", VA = "0x185F96FB0")]
	private void GHODNKGOHNE(Dictionary<Guid, Guid> PDLLEPLCIBP, CBMIJBECKFA FIBHEHLHMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F97810", Offset = "0x5F96610", VA = "0x185F97810")]
	private void GHODNKGOHNE(Dictionary<Guid, Guid> PDLLEPLCIBP, CFCJLAGOKHH IPJOFLNNMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F97590", Offset = "0x5F96390", VA = "0x185F97590")]
	private void GHODNKGOHNE(Dictionary<Guid, Guid> PDLLEPLCIBP, CLNNNBGBNHI HJLCHGNFOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public ENJKONKOALI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class PCHEKALAMDK : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C430", Offset = "0x5F9B230", VA = "0x185F9C430", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public PCHEKALAMDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class PGBGFPJNJJE : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C4D0", Offset = "0x5F9B2D0", VA = "0x185F9C4D0", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public PGBGFPJNJJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class DHOFPIMKAGF : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F96CF0", Offset = "0x5F95AF0", VA = "0x185F96CF0", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public DHOFPIMKAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class JIEKJMDFKKE : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B9D0", Offset = "0x5F9A7D0", VA = "0x185F9B9D0", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JIEKJMDFKKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class EOAMEABLEFB : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F978F0", Offset = "0x5F966F0", VA = "0x185F978F0", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EOAMEABLEFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class DFIOPHPBFIK : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5F96B50", Offset = "0x5F95950", VA = "0x185F96B50", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public DFIOPHPBFIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class NILFDMOCPHJ : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C2C0", Offset = "0x5F9B0C0", VA = "0x185F9C2C0", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public NILFDMOCPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class BJKAILLAIEC : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F941E0", Offset = "0x5F92FE0", VA = "0x185F941E0", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public BJKAILLAIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class IBADHJOLPPN : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AFA0", Offset = "0x5F99DA0", VA = "0x185F9AFA0", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public IBADHJOLPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class FLICLFBLMJO : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AE10", Offset = "0x5F99C10", VA = "0x185F9AE10", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public FLICLFBLMJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class FBBBMMIAJAH : OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly FCCGPMHEFMC PGLFFJLGOAK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5F97A30", Offset = "0x5F96830", VA = "0x185F97A30", Slot = "4")]
	public void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public FBBBMMIAJAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MIFLIMCCCEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public CHJKKBHBLDL ILCLKBNEPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public IJKINIBHBHA PANCIOGCFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public Dictionary<int, int> CHFFCDEAACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public Dictionary<Guid, Guid> GEBMCBFKNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public CEBDHFBFDGD CHHJEOPPKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public bool NLDBEEDMOMA;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OCMKHBNGCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFOOBMNOLNA(EIKLIBEIIEM MPNGIEEAIIF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BKFECLDJMFP
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private static readonly OCMKHBNGCMM[] IPPAEMEEPMO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F943A0", Offset = "0x5F931A0", VA = "0x185F943A0")]
	public static void DOIMKFPMIKD(OBGGKDBBBAO OMHIFBJFAGA, Dictionary<Guid, Guid> LLJFKEGIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5F94CE0", Offset = "0x5F93AE0", VA = "0x185F94CE0")]
	public static void OMNBGICDMDJ(OBGGKDBBBAO? OMHIFBJFAGA, KBIJGOEDBPI JGFCLEODEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F94A00", Offset = "0x5F93800", VA = "0x185F94A00")]
	public static void IJJLCEFOGMM(OBGGKDBBBAO? OMHIFBJFAGA, KBIJGOEDBPI CADGJAIBMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F94630", Offset = "0x5F93430", VA = "0x185F94630")]
	public static void GDFGPJKDHHB(EIKLIBEIIEM MPNGIEEAIIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct EIKLIBEIIEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public CHJKKBHBLDL KMFDEIPBDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public OBGGKDBBBAO BKFACKEMDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public Dictionary<int, int> CHFFCDEAACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public Dictionary<Guid, Guid> GEBMCBFKNFK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F96F00", Offset = "0x5F95D00", VA = "0x185F96F00")]
	public Guid OFPPIEIBBDJ(Guid FANIDECOFDM)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface CEBDHFBFDGD
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int EDDNGIOLOLF, [Out] Guid OHLCNGNNMLO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class AGMIIJHAKOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly HashSet<string> HJKHMHOMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Dictionary<long, int> FJGCNMADDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly HashSet<Guid> EJEJNPHAEAN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> ACJKHAEHOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> IAEGOBKIOED
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F93D90", Offset = "0x5F92B90", VA = "0x185F93D90")]
	public static AGMIIJHAKOF KLDIHJPFMNN(LBFMLKMCDDP JJGMEBEMOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F92EC0", Offset = "0x5F91CC0", VA = "0x185F92EC0")]
	public static AGMIIJHAKOF FDEOKJDAMJD(OMJHNCFCJCD GIGJGJGMAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F93E00", Offset = "0x5F92C00", VA = "0x185F93E00")]
	public static AGMIIJHAKOF NAGGHBNHNNL(IEnumerable<string> HJKHMHOMAKK, IDictionary<long, int> OMGJEHJJGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5F93F80", Offset = "0x5F92D80", VA = "0x185F93F80")]
	private AGMIIJHAKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F940A0", Offset = "0x5F92EA0", VA = "0x185F940A0")]
	private AGMIIJHAKOF(IEnumerable<string> HJKHMHOMAKK, IDictionary<long, int> OMGJEHJJGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F937A0", Offset = "0x5F925A0", VA = "0x185F937A0")]
	private void KJEALMHEIBE(LBFMLKMCDDP JJGMEBEMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5F935B0", Offset = "0x5F923B0", VA = "0x185F935B0")]
	private void KJEALMHEIBE(OMJHNCFCJCD GIGJGJGMAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F92FA0", Offset = "0x5F91DA0", VA = "0x185F92FA0")]
	private void KJEALMHEIBE(FJIKMMJKKDA? ADCDJFADKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F93440", Offset = "0x5F92240", VA = "0x185F93440")]
	private void KJEALMHEIBE(OKOIBNGPCCE? ACNLHBNEANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F939A0", Offset = "0x5F927A0", VA = "0x185F939A0")]
	private void KJEALMHEIBE(OBGGKDBBBAO? BKFACKEMDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5F92F30", Offset = "0x5F91D30", VA = "0x185F92F30")]
	private void HOOKMMENINI(string? DADFIHCEECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5F92CF0", Offset = "0x5F91AF0", VA = "0x185F92CF0")]
	private void CKIHJOPHDCA(LDKHOKDDDAC? DEPJOLKAHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5F92DD0", Offset = "0x5F91BD0", VA = "0x185F92DD0")]
	private void CKIHJOPHDCA(KBPBJBDMELO? DEPJOLKAHGO)
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
