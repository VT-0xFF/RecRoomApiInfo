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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F93C50", Offset = "0x5F92650", VA = "0x185F93C50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PMANFOPNIKI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> EJECFFIAHIG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> GGDJGLOFPKE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string IMMEOIPDBIM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string BPEIBEKDACD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string MIFNCKMCMKH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F95100", Offset = "0x5F93B00", VA = "0x185F95100")]
	public static bool ALDMOBLMDBE(Guid LAHJDPIOAPO, int FMFOGKLPHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F95200", Offset = "0x5F93C00", VA = "0x185F95200")]
	public static string DACLBJPCDDE(Guid DMMBGEACBPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PEKKGBJPOLJ]
public enum JFBGBEKPPKB
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
public static class HEOHFLCHOHD
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid MGLNMIOKFKE;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid CCDMHKMGLGK;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid AGELIGOAMIL;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid AKGFEJBMIDK;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid FHFGNCDLNCG;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid KIOHPLEMCFF;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid OBLCCGCLJFG;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid KJDHCIMIPNM;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid FEEGAAICPCH;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid INDLPGFFMMM;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid MEOJKCFBLDK;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid MFCCPDDLHND;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid OLMICNKFCDG;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid MMEOCIOLDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid EIFFJNCKKOO;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid EBEFCPFPLJB;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid GHEMIGDAHLM;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid FBGOIKLCIAB;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid MMKDMOLGCDO;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid KMJLLLPFBCJ;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid ABLDDDMIBLP;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid CANGNEHDNEA;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid DEJKJOCOCFL;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid KIGOOMOEFAA;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid JMDMOKFLFID;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid PNEBNGMIBPG;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid PKHPJNJFPCG;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid FMJKCHNGBON;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid PEDCHGGDDLC;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid PDAGGPFHCLK;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid CILOMNCCAEG;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid CLLFKOCAJAE;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid GBPACGIJCLO;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid HBHBOAELKMC;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid NINCKHJAKLE;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid OKOHENNCABA;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid FLCGCANFDNI;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid NLIELKJBIPP;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid DKONIMEPIAE;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid FLINGMGINEJ;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid MLHAPNMFPML;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid LNLKAOJMBMM;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid KGKMHPJNPNM;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid ABDGJEPEAMM;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid HHBODFNLNMA;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid KKIDANAKPHO;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid DOIIFMLCCCN;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid PNEOGLKFJMO;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid LHCLEJGFKIK;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid CACHFMOFLMO;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid MKFDKMBIDDL;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid IBJBMAOPCLF;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid ACDFOIHFCNH;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid BKKMKHOMGLO;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid JAAPJJHGNEA;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid FDJOAIKMBGG;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid OMBINODCHAI;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid DOGPBMBEGEP;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid BEPCPPNPPHN;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid KBGFHFHNEDI;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid LCHNPGBFONH;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid NGPHNPPNDID;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid JIFNBMEMMGA;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid PLBEIGOEJJB;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid CCLJAMJMCGA;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid BHMBIDJPBEL;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid NNNHNPINMDJ;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid GLAKKLODEBB;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid PGOFGPGHFJL;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid BADBFBHBGAD;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid KPKANHICHEO;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid OAFIGGKBKNH;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid MAAKDOJODGA;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid CMIABLKPOEM;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid GIJOECOHGOI;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid FIOOJHEMCFF;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid AKBMEBGLOKK;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid JODEONCLOOD;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid GAJEGMLFFKA;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid DDGEAIPNJGF;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid CBFAOPJJPGP;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid ELPNIKIPAIB;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid LENOANOOEKK;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid NBBIJHMNKCH;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid JPMDBLELBIF;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid DMCMOPNNGNM;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid MDGIGLMMCMM;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid CEIEODGCLEK;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid DCAMLGDFKIE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid IKLDOBIENGP;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid ONNGKDECJBK;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid BIOMFANHNHJ;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid LOALNBPBFEF;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid FKGDACBOANF;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid KPACAIBHFPJ;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid DLHPAKIJPKC;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid CDLGELKOJOL;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid BDHIPPKANIL;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid CCOAPEGBNED;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid KJJDPGJFHEC;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid EAEFCFIHCMB;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid DFJEBBFCEJL;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid OCDMMEDPOEH;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid HMIAPGOFGDJ;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid MPBBNKMDBJM;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid CGKOJFEPGKB;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid DIEFFCIOPOL;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid EFCMJCGIPPA;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid BGHONNDGCAD;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid PHCDOJOLNAL;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EEDPNJDIKGD;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid PEGGFFPPKNK;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid OCGBBALFJDI;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid PEPFABNCPEB;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid HNCCOMLDNED;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid AKHKCIJBECB;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid BONEECHBNAD;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid EDKOAJCEAFP;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid GBILKBIKMKK;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid PGABIMKKDFP;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid FKKLMAKPFMC;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid ALONALCDHAF;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid PFKEPMIKKNJ;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid INHKJBDMFKB;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid HBGDFOJGMKH;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid IJAAHNELFNH;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid IFFOBKEOGGI;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid DPCKMHOGEHP;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid AAJEEMFMDJE;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid EOIJMNEEAGC;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid GKIIJAMPPML;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid BKMPOHNBEGM;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid AJDHNOGLEDG;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid AIEHPIGMOBC;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid HJHPOPOPLPF;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid EAPHEFNBAJM;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid CBLANIMHDBK;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid BDNDGJLMHMF;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid KJKOLFNKBFA;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid NKPLBHICGJB;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid ELKJJKOAMJA;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid GCGMJPHGOEM;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid ELLLMGOBOAD;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid IGHLGKLKMMM;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid IJMCMPFHBJJ;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid BNBKEBDNADP;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid PBLKDEBACGJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid FNBCAJECCBH;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid LLDJJDCPNJC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid KPELOODHOIM;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid GIOOGHMOFLI;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid DMNJIGNLENI;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid JPJPBDFEMKM;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid EDBNMFFAPJF;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid PBBKLCEKHFP;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid OCPHAMDBFGF;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid DLLOLNHFHFM;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid FNMKBFHLFMC;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid BDHDEAPIPAL;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid IDFBGFAEHHO;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid BOECPKDPDMJ;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid PKMFAFHEGEM;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid DFOKAHJJEOA;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid GHDAIKCHABI;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid JLOPPKFLMOA;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid ALKJOKMLMGK;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid BHCLHGEIKCD;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid EPENMDJILBJ;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid HPACEODIAKK;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid FBLFDECKKME;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid NPJDMLAIJBB;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid JKCPFFIEFKD;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid LMIKLDFODIP;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid CDEBCDNGHIC;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid DPBEGLOGOKA;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid KPKEKBGBPMC;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid KNBHJNKBMLH;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid OOKAKFOMDFM;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid AEAKJDGKOHK;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid KFIMCJBNOOM;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid LIIIMPILEAP;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid NCAIJCPGKBF;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid LNMMGBLHDGA;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid BBDNHNEHHHP;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid JDMLFPKDNAE;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid GAAGNDKMGNH;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid HJAJCKHGPFH;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid ELKIDFBFKKL;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid JKMCBOJMEPP;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid DBDGFGBDJMC;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid IGMIHDOCLCH;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid LMBOLJBLAEE;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid CBIDPCKBFGK;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid NJBJMDPMPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid MGGMKPAODHM;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid AIINOFMODNM;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid HLLJLDKLFMG;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid JKEMICEFLPN;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid AFDABIBGOCO;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid BEMABEFNHAH;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid IGCPGFCKGAG;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid CFFEGPFLJCD;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid ACPDLDJJDJI;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid BPAGAEEIHHH;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid JBKAFBHMAFP;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid PLGLEHHDADF;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid NLHCDIJHGGN;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid ALOKIMFOEOE;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid KADDLJOCEAJ;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid DBNMBFMIBOB;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid GEECAJPBMJO;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid KFJIHNJPPKO;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid PIEKJFIOCNC;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid HAENNICLJGP;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid FIPOLCHAMIJ;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid FMLPEJBNDPI;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid MBANHMCEGMF;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid ALMIDIHMEKF;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid KKGGJOAJHON;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid JGLPIECDKHN;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid JNIHOLACAMO;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid PHEHHIHAPKL;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid ENCACDJBPEP;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid DJIPLHENKHM;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid EGGBNGHFKEG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid NJMBFEAIDCG;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid AKDPPAIAMED;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid FIMANHPBNPE;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid CGOMEGIJLED;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid LEFCLKLCCAN;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid BMMEAEIJAGL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid DEOGCCKLFFB;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid GHBGOOJIONA;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid AFHOCGFIIDF;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid KDHGJBGMMNP;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid IMJOOINPPHN;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid DMFCOLOFFJO;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid NKNPJEIIGCE;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid OPLMECGFJLO;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid JCBLAJIHPGP;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid APHKLOLDOFD;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid JGFBLDIACPC;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid FFFBKEAAMKF;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid OKJPHDFMOMM;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid OMDBKKPLNKD;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid MAEIPMPMELG;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid LMMDFPHDGHF;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid MDEHLPDFKND;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid ILGOPNKHLJC;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid EEPDADPJHJG;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid MOAOJLENDDJ;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid FHAPJGLAOCJ;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid DLJHOHIJLLH;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid LOPNEKKKDBN;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid CDKHFLHAFPI;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid JJEKMLGKODG;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid PKPKPKDKEJC;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid IIMGEAHCOKM;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid BGDOBCFEMLD;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid DIGMHLIKMFG;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid MFEEIDGPJCH;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid JNNJMGLFFBL;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid NFKOCKDMKGK;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid JBNDOACHPAE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid NKANPJLPAKI;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid CDMCIMONHOA;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid AGMFBJIAHHE;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid PEEEGAPCKII;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid DNLJCKHDANM;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid MFBHDBGEFEK;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid ELNJIGLHNEA;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid IJLLDAKJBDP;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid PBKPPIKHAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid JAKKAIJNLPG;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid OHNFPDKGAAF;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid OMPKFFLLMDG;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid DKMENOJEJHD;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid FEEEKNBNPJG;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid HMLGMMNBJHF;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid HJJKEKEMMMG;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid ELEECABJMLE;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid HMKOLFNOJFC;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid MPPCFNECCGA;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid GOADCBCNDNI;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid CKLOGGDLHDO;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid GFKMGFMHCKA;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid NNAIONJOKHE;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid CPJDHPFBCNL;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid BLALFNEOEJD;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid OMLMPEPJLGI;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid KCMMMMDBNHP;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid AJEIJKAELBP;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid ENCMBHGIHJL;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid KOCCFIGDKIB;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid NFJIIFHPCNJ;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid ABAGEBLMDHG;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid NOAPEJCAFJP;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid PNLPJMINFGD;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid MGCPJHGNECH;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid KNOKFJHIEPH;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid JBIIIGIKPGD;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid JJOEFCLFALI;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid LPJEFCLGOLP;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid CDBIFOAACGA;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid PGBEADBFMND;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid MMJHHBMPKPI;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid PCDBNJDHIBM;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid DOKLPMIJKFN;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid OGCLGBHKLPF;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid EDAOJECDFKH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid OMKGJACFGHK;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid BEHFMFNFLFI;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid PNLIGCEOOEC;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid DKFGCIOOFAF;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid FNFNPMIFDOK;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid HFJHMLEDIBD;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid HDKFDCOLGON;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid DMPMLLHCBDL;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid GANMCDNIDOO;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid COHHEFLOLME;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid CMNLKMKNKHD;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid NBKCAIHMBCN;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid PMDMLCNIKAD;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid LFOOFOHPPGL;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid AKLFFDPADBD;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid NDHIBJIOLBK;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid MNIIBMOGOLI;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid ALKNNPNBJFA;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid LFKBLGBIIAD;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid EKNICMPDNIG;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid HIJJFEGKOPL;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid OMJHCDNDHIO;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid KPBNPKEJDJH;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid CMLHCJGDNFP;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid CDJBIMEIMKH;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid HEMFOGBEBEJ;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid DFIMPMHMHDG;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid JPKBFEBEODN;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid EAKDKELENDD;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid PDHDHDKAKLG;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid PMAPBFNMOHP;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid EKLPGLIIIDP;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid IHFNCPAKLCN;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid HGBNPBJGLPB;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid NJFODNNHJAC;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid MJDOMNGBEMK;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid ODEGBINJCIL;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid DPCMCFNFOAD;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid EIHONMKHCCN;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid LEJHILFEBHK;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid KJOLOABLAOH;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid GBMKHINCMCB;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid AKIHDKMECCO;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid OLNHMNONDKG;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid NDACBDCAIFM;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid MMAOLLKKIDC;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid ALGEDNENBMP;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid NFLDDFEBMOP;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid MCPKKACBLFA;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid JBPMOPGBKIL;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid ADEDIEMOGKF;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid JLDLMIGGDIE;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid KBOENBGJFEM;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid JFBILCPOFGL;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid HPNBPKHDMIB;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid JFMOGKLDJID;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid GIGOFOPFODP;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid BAMHGJKNPGI;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid FDLLFEAJFPJ;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid EPLPCKFCKJC;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid HLIMLHMBDJJ;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid CBDDECAKLHF;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid OBFJFFKBFAF;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid IJMHPDBLLFH;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid AOONKIODOCO;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid NMPOKLACDIB;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid LBGHKGEDHMA;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid KIHCBGAPBKN;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid LOOBIBOKJDD;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid PDFMMALCNNM;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid HCKKPAFPODK;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid LBMAPJNDGAI;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid CFCCKKOBLFJ;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid MLJODOBIINH;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid HOEALKGDPOK;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid KPKPBIPDADH;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid BPPFDOMAHJA;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid CNPOCJNCJIL;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid OJGOLBCPPLB;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid IEGLFELOONE;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid CHCMIHEKEDG;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid PGGFALPIHNI;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid DHHGLOHJLAP;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid BHLDGBEDLFK;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid HFDCHIIJHPG;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid ENPEJOMKBLK;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid ENDPHJCMJAL;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid CAFOHJNCCFO;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid JBCJBPIPIFO;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid FNCMGLDIFJA;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid FGCIDIIKEGE;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid FPIILENIAGI;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid CBDCIMJEKCA;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid CPCKGOGKDIG;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid LOJKELHIDOE;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid EOHJPAPHOBF;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid PKJCBPGNLJJ;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid CIILFBAMAON;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid FFBPEPLOPBN;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid EIEDFNKEGHD;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid GGOHPLAHMKD;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid KGJLFAGIKBG;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid GJKFJNDIEDF;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid HDANLEJJFKJ;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid PCAEHIAELJD;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid FLKMGJHJENC;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid HMNMEOONNOE;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid MFPIDFFOPCO;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid KKNPHINFLCK;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid AIDFCNCJNNP;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid OFDBBMKGIHM;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid PPGEHJKEJIM;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid DPGHHMHIGLF;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid EEKNNPCKOII;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid BBNMFNELCHG;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid OGKJHCNACMC;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid EIPPJOHGEOO;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid FIPALPLBMMH;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid OGFHBGLDAGB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid IDKHAALOGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid KNLGCNLCCAM;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid KLODIOOOEHH;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid AKKLEFKIHCO;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid EFPDHCAIEKN;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid JOCNFDDGGEO;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid MJPKCKADCOA;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid PAEIJHLGECJ;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid MDOGINCAKJA;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid IJCPKHACFOA;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid OFMPFCLPAMG;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid APHBPBJMKLI;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid IJIBNHKDCJB;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid LDAAKNAFBCC;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid DOGDGKHHHPM;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid IPFACOMJNBL;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid JCBCAPNOJKM;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid MBKMOAOGJPH;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid DECGEKCPEDK;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid NMJLANPFELG;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid FMJABGIHPAC;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid DKHLEGMDFHM;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid AHGODLEHAHE;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid MJJDGEGNCEF;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid AIMNDIMEBPI;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid PJCMDCFKMNH;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid AMIHFDHOEGL;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid PMDDAGFOMLJ;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid INCDGBKCGMA;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid JICLDHNNDLH;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid CJGIEDAMMAC;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid LDPNJAAHEFD;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid BJNGHKJIKIM;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid MDCAJLMMHOB;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid PJFDEODEICI;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid MFMAIJHBLOA;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid KMGKJEMILNF;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MEBJCKDIEFC;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid HELGDMJCPHH;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid GMBLCKPJIOK;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid EAAFAGIPNMB;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid LKPFCOOBHOP;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid GDAGMBBIGOB;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid FOFJBPCFEHH;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid ACHLNFEIMLM;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid CJODFJFPLOB;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DKDEBPLOCGK;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid OLFDNEHJKHD;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid GGMBLKPBHKN;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid BNJFPHNIANM;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid EAPFKBMJNHO;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid KJNFFGNPBNP;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid KEEKLDKFPMN;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid EBCFHGDPGLO;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid LPBGFEJMBNB;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid GGCMGNCCBOF;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid EMLOEDBKOGF;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid GKAHKGFGMJC;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid AOKIKGCHPDE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid KDCMDDOIDGH;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid KHFNOPGLGDK;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid DHJLFFAKLKL;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid AMGEKOFKFLF;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid CPHEBIODJEI;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid BFBOKGJPGON;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid GIFMPNCPLFJ;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid BCLDFDGMBIC;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid GGOALBPBBKO;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid IOCCFFACFKN;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid MPHGOPDDFMD;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid NBDPPHJIPOO;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid HCHGOLCIPHA;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid PGICGEEAGBI;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid POCDPIABFKM;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid MCGOACGDLKE;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid HEOICHICPAB;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid GILKJMLGHKE;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid NMMBPFPCFFL;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid INEIBGFOGBI;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid BOOGLODBOAJ;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid GPFABGDCIFL;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid GBIKJJOCENC;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JHDKFJBLIMH;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid GGNBHLOCOCK;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MIDNOHJFOAI;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid KMEOEPCPMBB;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid PABAMCJKDKL;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid JBKPOPMMEFA;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OKHFJKPGIPP;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid IKDHALPMNBK;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid FDFBOKJNOGM;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid MHBPNDPJBIH;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid JKJFPHDODMJ;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid MDDKOBBNHBD;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid CDCLDCMBNIE;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid PNBDHLMMHKO;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid FENDJNKOCJK;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid DFNMADAJOFJ;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid LKLBBFDNJIH;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid GBDNAANIOIE;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid ODFCEJACGBF;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid EOHAGCLJJEB;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid OLGNLFOGCOB;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid IAHMFAELGIC;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid EIKIEHDCNGI;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid NDBNEJPMGFB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid LJHNPELGFEO;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PJLLHKKJFMK;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid OGFEBKDEBMA;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid DOFCOKMPDLI;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid EDFEELIPIDC;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid JIAJOLHDGCH;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid APJBKALGLNA;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid FKOGOGKACCK;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid EKEHBIGBCMC;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid BOFFEHDOJLE;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid IGMHPPIEPLC;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid DHELHGBEBDH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid CAEIPHEJCEO;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid AMDGCPNPMBN;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid ELCMJMNMMOG;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid MAMAIMBICLH;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid ENMHNACJBCP;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid MPEOLIFHFBI;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid HFIAOJPBIBN;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid CCCEPENFDCL;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid ELPALLLHAHG;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid PBDEBCJJELN;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid HLMNBKMMAGG;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid IMMIALLGOGJ;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid BJNFHDCAJBO;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid CNCNBIJNFMO;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid PNGLIEKPLJC;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid NKMLIBHCKFB;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid GEBEKNIGGON;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid KIAEMMFHDBG;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid LHDEAPKCMBK;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid LPOCGEGHOBG;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid OHOFOGCAKNJ;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid EJCIBAICMEG;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MJAOEDMAMKF;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid HAGDFFAKEHC;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid HCBKIIEKGDL;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid OIIAFBHJDDF;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid FBEKAEDDBJK;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid LAEHEMOIIHK;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid ACDMJAMMJOL;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid NPBKGGJKNEO;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid MGGHKAGILJL;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid CABBOFBLMEH;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid GAAEMEODDOF;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid AJCKAGCKBKF;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid HLGOJHANFDI;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid EODKFGCKPJF;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid NIDCDFDKPEL;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid IBIFIEDJBLJ;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private static readonly Dictionary<Guid, JFBGBEKPPKB> OGDBMBDEHHJ;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Dictionary<JFBGBEKPPKB, Guid> DMIKDHCEHKO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, JFBGBEKPPKB> GHGBKBPAODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EB40", Offset = "0x5F8D540", VA = "0x185F8EB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<JFBGBEKPPKB, Guid> CCOCCKLOHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EBA0", Offset = "0x5F8D5A0", VA = "0x185F8EBA0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CKKOKDDCGJA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F8CDD0", Offset = "0x5F8B7D0", VA = "0x185F8CDD0")]
	public static bool HHDGNNHIGGP(HKOMIGIDLOL BKCOHLMNCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F8CE00", Offset = "0x5F8B800", VA = "0x185F8CE00")]
	private static bool HHDGNNHIGGP(PKMEOFONBKI AKBGHNHAADP, HKOMIGIDLOL BKCOHLMNCHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FACMDALLOIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly BGIJKMLLKNA GHFPIGMOJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly IEnumerable<PHABHFKCGBH> CIPOFHILINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<PHABHFKCGBH> EKOGFPEOGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly MCAPNBAEEIC<MBMBMNGOCDB> FAMLEENHFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly IReadOnlyList<MGJIBFHGOAL<CKBGJLLPGGO>> IFJGMJBPEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly ByteString AABMFINHFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public readonly GJJCDLGBBHC BDGOHHOIJNI;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5F8D350", Offset = "0x5F8BD50", VA = "0x185F8D350")]
	public FACMDALLOIG(BGIJKMLLKNA MNFGDCIDDNH, IEnumerable<PHABHFKCGBH> PFPFMAHGBOE, IReadOnlyList<PHABHFKCGBH> BGPCAIKJEMD, MCAPNBAEEIC<MBMBMNGOCDB> BIKADDMOOJE, IReadOnlyList<MGJIBFHGOAL<CKBGJLLPGGO>> MNIMCKDOLHC, ByteString BKFEAPJPEAL, GJJCDLGBBHC HJFFHCFOPIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KFDCIHNBFCH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(NEJALDJDOFN OBAHLGOPPIK, [Out] Dictionary<int, int> IFOPHGHBPKA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(NOMIJAPGJOC PAENBNGMHPJ, KNKACEAFFBI KLDCCLJCJHE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LAOPEBKFABG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public readonly Guid KNDKJHEDHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly Dictionary<Guid, Guid> PNHPOBNMFND;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> LOAPGPEMBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3353B30", Offset = "0x3352530", VA = "0x183353B30")]
	private LAOPEBKFABG([In] Guid OMJLKAJHPED, Dictionary<Guid, Guid> COAFDOFMOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F924B0", Offset = "0x5F90EB0", VA = "0x185F924B0")]
	public static LAOPEBKFABG MAALNFIKLPK(IReadOnlyDictionary<Guid, Guid> FBCLPEBHDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F926F0", Offset = "0x5F910F0", VA = "0x185F926F0")]
	public static LAOPEBKFABG PMLEGLMAEGG(IEnumerable<KeyValuePair<Guid, Guid>> FBCLPEBHDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F92640", Offset = "0x5F91040", VA = "0x185F92640")]
	private static Dictionary<Guid, Guid> ONDEPHIIBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F92530", Offset = "0x5F90F30", VA = "0x185F92530")]
	public Guid NKNIEGCPFHM([In] Guid DMMBGEACBPP, bool JJPPECABDDC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F924C0", Offset = "0x5F90EC0", VA = "0x185F924C0")]
	public bool MNBLCJFPOJC([In] Guid KABOEEEDCAB, [Out] Guid DFKFOLHFPGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HKNPPENCNLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LFHJKBIDOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCJJDHFPDEL(ByteString HANEBMPJCCB, LAOPEBKFABG MPFBJAEPMIP, [In] KFHJLEAABEB LOLAPAAOGOH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IBGLPMLNNIJ
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
public sealed class KNKAKGIBIHK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> KNNPJBHOBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> MFLPOPJKPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x797640", Offset = "0x796040", VA = "0x180797640")]
	public KNKAKGIBIHK(IReadOnlyDictionary<Guid, Guid> KIOHIPEJCPF, IReadOnlyDictionary<Guid, Guid> GCDDBDJCBCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JKJAHCFPKID
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F020", Offset = "0x5F8DA20", VA = "0x185F8F020")]
	public static EKOBPEMJIDJ AEJBPIHDPEC([In] FACMDALLOIG KFODOHLCGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F90310", Offset = "0x5F8ED10", VA = "0x185F90310")]
	private static void MKNOPEHBIIE(EKOBPEMJIDJ IGANDLHFMKD, [In] FACMDALLOIG BBHJOJDKLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F90C50", Offset = "0x5F8F650", VA = "0x185F90C50")]
	public static bool PLBGHDIHLEJ(EKOBPEMJIDJ IGANDLHFMKD, GKACCPNKLOM FFGCJJCMKJB, LAOPEBKFABG? NDMDCHBNLLA, [Out] KNKAKGIBIHK? COAFDOFMOLB, [Out] string? BNFACNGELAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F8D0", Offset = "0x5F8E2D0", VA = "0x185F8F8D0")]
	private static void FLGBGCPHBCL(EKOBPEMJIDJ IGANDLHFMKD, LAOPEBKFABG? JNGAKPCPKJN, GKACCPNKLOM FFGCJJCMKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F90200", Offset = "0x5F8EC00", VA = "0x185F90200")]
	private static void JCGJNNODELA(EKOBPEMJIDJ IGANDLHFMKD, GKACCPNKLOM FFGCJJCMKJB, IReadOnlyCollection<ByteString>? ECGKCOBGMFO, IReadOnlyCollection<ByteString>? AMACCIAKGGD, IReadOnlyCollection<ByteString>? BIEMMJGEKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FB60", Offset = "0x5F8E560", VA = "0x185F8FB60")]
	private static bool IOJECPOMELM(EKOBPEMJIDJ IGANDLHFMKD, NOMIJAPGJOC PAENBNGMHPJ, GKACCPNKLOM FFGCJJCMKJB, [Out] string BNFACNGELAB, [Out] Dictionary<int, int> IFOPHGHBPKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F90970", Offset = "0x5F8F370", VA = "0x185F90970")]
	private static Dictionary<Guid, PKMEOFONBKI> OMNNCLFGBIN(EKOBPEMJIDJ IGANDLHFMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F90270", Offset = "0x5F8EC70", VA = "0x185F90270")]
	private static void LGFCCMECGEN(bool BDCFEBKCKHF, PHABHFKCGBH JEKLEDBKIMJ, Dictionary<Guid, Guid> HFLMPKACJAM, LAOPEBKFABG DEAEFDFJAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F640", Offset = "0x5F8E040", VA = "0x185F8F640")]
	private static void DEJELCABLOD(PHABHFKCGBH JEKLEDBKIMJ, Guid DFBLFKJNKAE, NAOAAMDGACH? JAKBPIGDIFM, Dictionary<Guid, PKMEOFONBKI> GLPDDIPDBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F190", Offset = "0x5F8DB90", VA = "0x185F8F190")]
	private static void ANDIGMKHHHA(IEnumerable<PHABHFKCGBH> BFMLGPMMCHH, IReadOnlyCollection<ByteString> ECGKCOBGMFO, IReadOnlyCollection<ByteString> AMACCIAKGGD, IReadOnlyCollection<ByteString> BIEMMJGEKDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GKACCPNKLOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public bool BDCFEBKCKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public GJJCDLGBBHC HJFFHCFOPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public NAOAAMDGACH? JAKBPIGDIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public NAOAAMDGACH? IOKCBMIFDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public BGIJKMLLKNA NKGPOLGHEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public IBGLPMLNNIJ GHPIIFDLFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public KFDCIHNBFCH JEILHCPOJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public HKNPPENCNLM MPLGOFAFIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public MGJIBFHGOAL<MBMBMNGOCDB> KNMJLJCDPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public AFBACJDBDCF FMHJAMGDKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public List<PHABHFKCGBH> HKHGOEEADCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public Dictionary<string, object> MJNDKOINGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public FMLEHMMEDOI BOGLHOMEHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public bool PCBBJGHBEKE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LHFEDHBCFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EAF0", Offset = "0x5F8D4F0", VA = "0x185F8EAF0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NAOAAMDGACH
{
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private const float JCELKKOMFAJ = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Vector3 CJONGNPPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Quaternion KPKKBKKOGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public float EFPGCAMCJII;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 AGAIHJHKBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F93670", Offset = "0x5F92070", VA = "0x185F93670")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KFHJLEAABEB KICDMFANGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F93810", Offset = "0x5F92210", VA = "0x185F93810")]
		get
		{
			return default(KFHJLEAABEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x9332D0", Offset = "0x931CD0", VA = "0x1809332D0")]
	public NAOAAMDGACH(Vector3 CJONGNPPIAD, Quaternion KPKKBKKOGOG, float EFPGCAMCJII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F939D0", Offset = "0x5F923D0", VA = "0x185F939D0")]
	public static NAOAAMDGACH MPPGBACHKFK(NAOAAMDGACH CDMOGOKIPKH, NAOAAMDGACH KNNNMEFCPHM)
	{
		return default(NAOAAMDGACH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F93850", Offset = "0x5F92250", VA = "0x185F93850")]
	public static NAOAAMDGACH LODPGCNHAMK((Vector3, Quaternion, float) OBAHLGOPPIK)
	{
		return default(NAOAAMDGACH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F93870", Offset = "0x5F92270", VA = "0x185F93870")]
	public static NAOAAMDGACH LODPGCNHAMK(Matrix4x4 NOOKFOJOPEJ)
	{
		return default(NAOAAMDGACH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F933E0", Offset = "0x5F91DE0", VA = "0x185F933E0")]
	public NAOAAMDGACH DEGCMINILEN(Matrix4x4 BDCAJJAMFEO)
	{
		return default(NAOAAMDGACH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F93600", Offset = "0x5F92000", VA = "0x185F93600")]
	public static NAOAAMDGACH DOJKHCDHNNA(Vector3 CJONGNPPIAD)
	{
		return default(NAOAAMDGACH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F93780", Offset = "0x5F92180", VA = "0x185F93780")]
	public readonly PBOFBJCIFJE ECGPPPGLCOG()
	{
		return default(PBOFBJCIFJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BNBPBHHCKKG
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F8CC40", Offset = "0x5F8B640", VA = "0x185F8CC40")]
	public static NAOAAMDGACH NINHLEDPDFP([In] this PBOFBJCIFJE JFFAAHPEFOB)
	{
		return default(NAOAAMDGACH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MAOGDENFIMC : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F93360", Offset = "0x5F91D60", VA = "0x185F93360", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F92AA0", Offset = "0x5F914A0", VA = "0x185F92AA0")]
	private void DEEKHAADCDA(Dictionary<Guid, Guid> OABHCJJCGBJ, MOFDJGMGAFE BNKOKBHKFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F93300", Offset = "0x5F91D00", VA = "0x185F93300")]
	private void DEEKHAADCDA(Dictionary<Guid, Guid> OABHCJJCGBJ, ALDHPKOGGHP GFIABMAFFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F93080", Offset = "0x5F91A80", VA = "0x185F93080")]
	private void DEEKHAADCDA(Dictionary<Guid, Guid> OABHCJJCGBJ, IKBPIFLFILD MNHAIPCCEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public MAOGDENFIMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class JLDOLHPBBKP : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F922D0", Offset = "0x5F90CD0", VA = "0x185F922D0", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JLDOLHPBBKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class ALGCDBHGHIJ : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F8CAE0", Offset = "0x5F8B4E0", VA = "0x185F8CAE0", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public ALGCDBHGHIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class IDBPLMKDJBN : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EC00", Offset = "0x5F8D600", VA = "0x185F8EC00", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IDBPLMKDJBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class IKPBGIILJEC : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EE00", Offset = "0x5F8D800", VA = "0x185F8EE00", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IKPBGIILJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class JMBKAOHELCA : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F92370", Offset = "0x5F90D70", VA = "0x185F92370", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JMBKAOHELCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class DCCBLGMDEJM : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5F8D1B0", Offset = "0x5F8BBB0", VA = "0x185F8D1B0", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public DCCBLGMDEJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class FLEPMGJBKII : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E8D0", Offset = "0x5F8D2D0", VA = "0x185F8E8D0", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public FLEPMGJBKII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class OEFHFDJMOEP : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F93CD0", Offset = "0x5F926D0", VA = "0x185F93CD0", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public OEFHFDJMOEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class AEJOANIGHIN : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F8C920", Offset = "0x5F8B320", VA = "0x185F8C920", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public AEJOANIGHIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class CAOOOBEKNJI : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5F8CCD0", Offset = "0x5F8B6D0", VA = "0x185F8CCD0", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public CAOOOBEKNJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GJOOKLPFPOJ : KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly System.Random DLALIBOMNIJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E9C0", Offset = "0x5F8D3C0", VA = "0x185F8E9C0", Slot = "4")]
	public void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public GJOOKLPFPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HKOMIGIDLOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public NOMIJAPGJOC BKOLDLDNEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public BJPCJECLFAA NNMCIKEGDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public Dictionary<int, int> PHJLHKDMJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public Dictionary<Guid, Guid> CBKHKMDHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public FMLEHMMEDOI BOGLHOMEHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public bool PLEJPFAFEGC;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KNGPICKCHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPMKPMAMLEF(IIANICCGCFD DOLJIHFAGFH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PFEGBDOGLBF
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private static readonly KNGPICKCHCK[] IKNLFFKIKDL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F941F0", Offset = "0x5F92BF0", VA = "0x185F941F0")]
	public static void FEMCPKBIBIA(PHABHFKCGBH OBAHLGOPPIK, Dictionary<Guid, Guid> FHLDFMGBKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5F93E90", Offset = "0x5F92890", VA = "0x185F93E90")]
	public static void DOBAJELIDOC(PHABHFKCGBH? OBAHLGOPPIK, LAOPEBKFABG OBALLGEBFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F94850", Offset = "0x5F93250", VA = "0x185F94850")]
	public static void OOKFFOJPBOF(PHABHFKCGBH? OBAHLGOPPIK, LAOPEBKFABG DEAEFDFJAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F94480", Offset = "0x5F92E80", VA = "0x185F94480")]
	public static void HHDGNNHIGGP(IIANICCGCFD DOLJIHFAGFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct IIANICCGCFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public NOMIJAPGJOC DGPFNCJMOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public PHABHFKCGBH JEKLEDBKIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public Dictionary<int, int> PHJLHKDMJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public Dictionary<Guid, Guid> CBKHKMDHNJP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F8ED50", Offset = "0x5F8D750", VA = "0x185F8ED50")]
	public Guid NFAIKKLCHCN(Guid DMMBGEACBPP)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FMLEHMMEDOI
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int MNCLDMCDBCD, [Out] Guid KGEAPJKPINC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FIFJEBPDPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly HashSet<string> MPMOAEPGPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Dictionary<long, int> IHJHCPOBOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly HashSet<Guid> OCLMNFKBPOE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> IKFDCFKPPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> PKJIFBAANMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E3C0", Offset = "0x5F8CDC0", VA = "0x185F8E3C0")]
	public static FIFJEBPDPDH HHNHLDNJMDM(IIJFOAGLFOC JIPHHKDPFBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E350", Offset = "0x5F8CD50", VA = "0x185F8E350")]
	public static FIFJEBPDPDH FLMLOPNNJAA(EKOBPEMJIDJ AJPJGJAHPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F8D3E0", Offset = "0x5F8BDE0", VA = "0x185F8D3E0")]
	public static FIFJEBPDPDH CACDGCNONOF(IEnumerable<string> MPMOAEPGPBC, IDictionary<long, int> PIMKJGFOMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E7B0", Offset = "0x5F8D1B0", VA = "0x185F8E7B0")]
	private FIFJEBPDPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E670", Offset = "0x5F8D070", VA = "0x185F8E670")]
	private FIFJEBPDPDH(IEnumerable<string> MPMOAEPGPBC, IDictionary<long, int> PIMKJGFOMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F8D950", Offset = "0x5F8C350", VA = "0x185F8D950")]
	private void CDALKOLIFNE(IIJFOAGLFOC JIPHHKDPFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5F8DB50", Offset = "0x5F8C550", VA = "0x185F8DB50")]
	private void CDALKOLIFNE(EKOBPEMJIDJ AJPJGJAHPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F8DEB0", Offset = "0x5F8C8B0", VA = "0x185F8DEB0")]
	private void CDALKOLIFNE(DLGMEEELNNH? AJBLHMMPNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F8DD40", Offset = "0x5F8C740", VA = "0x185F8DD40")]
	private void CDALKOLIFNE(NPNKFOGMGBB? NADDHKKGBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F8D560", Offset = "0x5F8BF60", VA = "0x185F8D560")]
	private void CDALKOLIFNE(PHABHFKCGBH? JEKLEDBKIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E600", Offset = "0x5F8D000", VA = "0x185F8E600")]
	private void IJPFIFFGKHA(string? OKCMOIDDGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E520", Offset = "0x5F8CF20", VA = "0x185F8E520")]
	private void IIGIGHAMIDH(OBGJNEBADMP? EOPPCEINKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E430", Offset = "0x5F8CE30", VA = "0x185F8E430")]
	private void IIGIGHAMIDH(FNKCOEEKBDH? EOPPCEINKDI)
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
