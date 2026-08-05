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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C9DB80", Offset = "0x5C9C980", VA = "0x185C9DB80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IGJBGHFCLDK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> OFIIOHLKFJL;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> LGJEJPIFLLL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C966A0", Offset = "0x5C954A0", VA = "0x185C966A0")]
	public static bool LEKPOKKPPDB(Guid FKCMPNIEENM, int ABDHCJBGGHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PGMKAOAANJL]
public enum PDEGLKFDOAG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AODPGNCCMBJ
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly Guid KMEPBDCMKAK;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly Guid FLFEKJNJDBM;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly Guid CNLGIOIOPAG;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly Guid KBKEGJAMEBE;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly Guid POJIGLKEBKO;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly Guid HBKFONPEKBG;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly Guid HDAIDPKMHMM;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid LCIIIMLPCFJ;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid IEODKCAONCP;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid PAHPIKEGNHD;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid MGCLOIFJLLB;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid GFAMDFGKMDB;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid IKIBCGGCGDC;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid FMHBLJPOHFK;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid NFCGHGHJLDJ;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid FIKBPKHBOGM;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid OHJBMKAGCJI;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid LNHFFFCDKHN;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid KKIKNLBLFNI;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid FPBPLHOLGJL;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid CCHNMCADIFG;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid JEGGFFPHJOI;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid BIODMDADOMC;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid FGDHECFLHAF;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid HDNBIMFDDEM;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid AHLDLDIJHPM;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid KEEDJPAHLGA;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid NBHEGNBPEIO;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid KFMLAJLBLAF;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid DABDIKBJFFM;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid NJNHBLCAEJB;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid OHNBKKBHGCI;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid NMPKPAEKEAO;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid CFIOPIPCMKC;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid JIFCCIJPOBN;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid KNJJCOEBNJP;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid LKCJOJDIIKN;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid GOGAPLGHPGG;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid OBBBBIINNOM;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid BEIDFEHJJCL;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid NOPOAMJEGJA;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid MEDOBBFCOOF;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid EODAGOMPIDP;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid LHGMBJKCIKA;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid EIEPIKABJNE;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid MGCKLJFCHOB;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid PODBALOKOJJ;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid HPGKPOHJBLL;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid MKFACPCDDKN;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid EBAHLBOGKKF;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid NAOCNOBNKFH;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid LIBDOBMHCAD;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid DGBMDDHAAMI;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid CAEPECNEMMD;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid JDLJODJKFLK;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid IHLEJAHFFFM;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid JJPJBBCCILD;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid GLMAIFLKOHN;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid DHMDJKMJPGB;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid ALFJPPFBBAA;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid OABMNICMJAP;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid GCKLAHAPOOF;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid KCMIMLGNBOH;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid GDMGILFHJHO;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid NHLFBHPIMNK;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid AFCGPIFIMBE;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid PCNNKJMOEFO;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid JKMPDAHJKFE;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid CFLBNGNFAPF;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid KBKCCMDHCAL;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid PPFDDOGLIDB;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid BAIMFFOHHHI;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid GNHGIDDOPFA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid PIEGIKDBACA;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid IGCKAKJLJLN;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid ALLAFHNHOLE;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid FAHKECAEKAD;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid FAIGOJIFNDB;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid LOFJMNLAHFN;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid LPCNIPEMMPJ;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid MDNGIMEKNGN;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid PAACIHHFFMD;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid IDHKJKICAOM;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid MGMNCMMMGJM;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid LJLJCLBAIAF;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HIILEFMKGJM;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid CFLMJCPGGJJ;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid KDGKFKKAGGJ;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid GLMJJCMBFKO;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid HMGOGKPKEAH;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid NDJPIDMPNDE;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid JMDPJADDKKB;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid OEBKKHMGEIB;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid MHCPGNFMNJD;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid PPMEFMOLLFE;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid CNILECCMCJO;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid JNDDBJHIEMO;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid MDEOEHPNGIJ;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CMHAOMALCBC;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid AGANNDNKKOA;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid NOMGNFNNNIC;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid FHMMHJBBNFJ;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid FDLNENKFJGN;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid NFCFMFBFGFA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid JLMAGCMAOLD;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid KLPHKGJFNAD;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid FOLOLAEOHEJ;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid AMHKNAABNKD;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid AODFLHMECID;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid HKFNIFEKLND;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid NCOIIMOBIDE;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid LDJKKBMNOHO;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid MPLCCLJGOKE;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid IJIMPGEIGGN;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid HBFGCEFPOLF;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid LAJOOKJDPIE;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid INIGJKJMNKL;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EONEGDOLEMC;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid OAHFPNLJIMN;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid DENKOCJLIME;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid PBIBKOPDEKB;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid FMLKJMBHNPL;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid DKMMBOPBGPN;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid EJNMMHMHENP;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid FGCBHJKJLNC;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid PAGNLABBDNM;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid NKFIGJBKAJH;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid MDNALABAJHP;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid BEKMKCMFDKD;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid GEIMKFDFLNN;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid NPEEBMOBEEL;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid LCHMKFCFMAH;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid FPALOKNKOEC;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid BMKCNJBCMAO;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid OIBMLPCHOCC;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid HECODDIDAMG;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid EBEDJBKDBEG;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid DCBOHIEAAFC;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid HGCPMADNGIF;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid OIFPLHLDDNK;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid IINEDMBJFFE;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid NAEIEMLAOFN;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid HCNAMNMFGBL;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid MBPJAPELPLD;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid IPCAKCGFBDO;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid CABBFEFMOLE;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid KLDHFBCDOFE;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid NKDFFAJFKNG;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid FHOLBIFLFKJ;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid EMLGABAJHLE;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid NAKEBFKCEPE;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid IAIGLGGBBBH;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid COIOPOOKBGP;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid NHMMDEMMMGJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid OJAKNCKBKGB;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid NBENLDCFIAI;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid CCBIFBPLDHF;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid KOIKNKCFPIH;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid KNGIAAHBPMN;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid IDIADDELAML;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid DPMCHAGIDCD;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid LOFKNFACMNO;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid GOOPAAFCAIC;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid PMNGAGLOAAK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid FLCHFDMEGPB;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid OOHDKGGBCBK;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid MKPLLOBGJDN;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid NAJILEPJLEI;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FGCDDBECCMK;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid GBHODLLGNOO;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid CPODOIIFPHJ;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid EGGAMGPBNBB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid IECOJPNIOCL;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid GPIDGELOMFI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid EHHEHFJHHOO;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid IHBMAGKJLKM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid KKNODENFMML;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid GKIIEABOIFC;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid DIKKLJOBMCL;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid NACJPGLLNHI;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid DHJNFMBGPOC;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid ABNEKPMMLBK;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid LINBOAIFJNG;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid EHIMIEKIPLD;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid GPJNBFKKBIB;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid AEOOPLPBPCH;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid HIGJIJMJGHH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid MKGMOAFJJOB;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid GDFKJGJCGKK;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid GFDKIOMPBJP;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid BCDAHLKJHGI;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid FHFPAGDKGAM;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid FFPEHECKHLA;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid POGDPMHBAGP;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid BBIPJIDBEKJ;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid CKHGAEOAOGG;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid CNKFIECEEHG;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid NMHPNKOGFAP;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid HKMCEJFHGOF;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid HGHLJEPCNLP;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid HNJDKBMHHIJ;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid DAFCDIFFFKJ;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid MIEOAPAFANC;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid DDNDOENGOJC;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid GMBGJOHDHGM;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid NGFHFKHFLIK;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid PIABIDPKBKG;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid GEHGOIPMFGF;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid EAGOGGDJIJO;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid BDLNJKFJKMO;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid LBCFDCCDMOP;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid JAIAAGCHCOE;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid AKIGGMGKONO;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid HMCAONBGLBK;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid BEDLLDMJLIK;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid NKMGLFPNHGB;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid IJIKOIFBFGM;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid OBMEPBOGLAO;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid ANFIEOHMMPL;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid HBPBFGMBMHK;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid JNELKFLGIEL;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid NOKFEOLDJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid DLCFHIPBFPI;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FLAOPBAPBNH;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid ILFPLLFMKPP;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid JMNELNFJHDJ;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid DGMDMFFOEAA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid MJFNKCEICKK;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid JNHGOEIGDNP;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid HLIEHEOHCNG;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid DOJAPGBPGNN;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid MMJMINACLFB;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid OHHEMFMNAMI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid KEKJFNBPFED;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid NPEOHBBFANP;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid LIGHDDOLBIH;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid KIHAHMMMGEO;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid OJJLCCKOPDL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid PKEJKHOCFMJ;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid MLIFOJOFCLP;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid LICIEIKBOJM;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid JEAKFJDGCAA;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid IGPJOLNLDKK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid AIDCLODMBIM;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid EEEKHNBPBDA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid OJLACPAIAGI;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid KPHBKCKKJFC;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid NJKBGOFHEPL;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid JDJAENECBEG;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid LFCBNDEOBIL;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid BIILMEIMMKF;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid OFGFFALECNC;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid FPDFOCKCCHK;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid OBOGDGEMJFP;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid ELELIIANPMO;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid NKMJEDKJMAH;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid ACOLHIILIJJ;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid CDELIMPDKMD;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid BMIPHLLKOHP;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid BGEKONCINMI;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid BDGHCDDIGAK;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid EJOMGAOHODF;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid JMNDBHFLJMG;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid LBPLBNBHIDC;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid BJEHCDLDAMP;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid HAIKGMBACNB;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid EFMHOEIDBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid HOCPGDEFENA;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid KHEEHPIDANA;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid IGCIPECLCEH;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid HJIPPIJOKAL;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid DLHDDJKBPNN;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid JHMBFCJGBCN;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid JAFNMKEOBFP;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid GIEDHAHCFOI;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid CGKOIEJDCCP;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid FMPOIHFLIJD;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid DEOEEENGDHA;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid AIHEAEEOEGB;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid HKFOPHFOGOI;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid MAFLDNGNJFK;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid LDGDECCFJOJ;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid NLCOMOPDHHF;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid LADENBLAAKI;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid BHJICLCDIEN;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid ABEHLFLJKLF;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid BEHKGEMBKLA;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid FIKMKIIFLED;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid PLFFAAHNLIJ;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid CIABEACENCN;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid EHJHIIFCFIM;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid LJEDGMIGPLO;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid KNCKIJHHDLE;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid LFNGNBLOFDA;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid CEPCPJIHGNM;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid JDPNFGACANA;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid EEJIAMLMIMB;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid EAIEEJBOEAF;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid GKDPOJFONFC;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid POMFPBNPPDF;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid HIMGKGLNNDM;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid CGNPNLKMBGA;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid BCJEFKBDKLI;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid BKCMHBKNLEK;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid IEFNADJHEJN;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid JMGLJIECHAH;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid COLEBNBDAPE;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HMOONGCAGND;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid KAMIHHJDDMD;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid OJAABKANLHF;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid CGKFNPFCMJB;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid AKBNLPMIAAK;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid JCCGNKJAIGO;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid JPENDFKBEED;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid MGGJCDMGFKI;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid DNNFGNMEOKL;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid NOFBFNPNDGH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid KKBCHGFPBGC;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid BEEKDMCCIBJ;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid DCFNNDILLCJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid JEEFJJLAHFO;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid PNADEDCNMEB;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid BGHEMPJEMBN;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid JPLEEFFBIHG;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid FMEOOCLDBHJ;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid ELLBHJPHEDO;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid MBMFAEPNGDJ;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid JNHJIBEBFPK;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid JGPDMBFHBPN;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid IKOGKPFHLPH;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid FOMFOLKLIMP;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid BEDICHEBHJP;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid JMEFDBBENGL;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid KBGIJAFLGIP;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid IMIEOJHBPHM;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid DOMHKGEAFFE;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid LNMFJIOLKNJ;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid IKKNDKCIMOD;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid NKGCHJNMFDF;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid PICOOJCDEIM;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid NPNPGCJMODG;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid OAFKLLDFLED;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid JMDJDGOLBHG;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid DBNBANLJECF;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid PMJIKIJNJPL;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid FAIHLGGDABL;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid CCDONFICMDI;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid KJIMPHMKCLL;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid GDGHBFKGPGB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid GAPEPAJKKNB;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid AACCPDGOKLL;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MHEAGAEHBGP;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid GGNMBHCFCGN;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid GLJIJCIMOMD;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid CHFPBGOPGOH;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid KMKDOAKMJLI;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid MKECOAOLHKO;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid CPEKNMLGHFO;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid FOJLDHIKEMK;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid KOKLOOEGBHI;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid PPNOEIBBAPA;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid CMGHDEGLLBH;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid PNHLMNNHDPD;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid FFIIENBLDNN;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid ABAIOBELKOA;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid LACMLGNPING;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid INNPMJLCOKB;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid NPHIKPLAMMF;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid IJAGPDKMAND;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid HHLKABJMIOD;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid FHAEDDAOGEB;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid AKPJGDJBPMI;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid OICHMDGFOGB;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid MAPBPEMEAGF;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid DJEALINJPNG;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid IPNMPIMIMAL;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid HMIAAHHDHKE;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid DPGFMLFACFH;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid HMGBKLDKELP;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid POOKLCPHHAJ;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid HLJGLBKCJEG;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid JBMGJBEEOAA;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid KDEIEECHCNM;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid CEIBBONBGAP;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid MBPKHGKBKKO;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid KNEPOAKGJAN;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid MDFLHEHJGOC;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid KBGBNIMEIMD;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid BJALJJDNPAC;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid IDIPDCBFJJE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid JHEOJAFPCBH;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid MNEJIGPGHEG;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid GNECDBJKOLN;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid IIELIDPKMJF;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid LBHKPAPPELB;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid FHKKOGMIPOH;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid NIBPFLIOPAD;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid GPBKGDFAEDJ;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid MKKFMEGMEBB;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid COHMCLLLLCF;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid LAGJAKGPODL;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid MBMPKIONJLD;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid KIOJIPANJNG;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid ABJLBFGDNIH;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid MHJEHPFIMCA;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid IPNOMPOIIAI;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid MIMFMCECJBP;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid HIIGOIPNJPM;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid GJOFLGIHLIM;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid PCHLOCABKFI;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid FHIGNJMLODL;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid DKONDOKJIOF;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid BPEAKLOIGKD;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid ABOPLANLJFN;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid PKPOOMCAHJJ;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid AGBLONFPCEK;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid HDHJKCLOCBP;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid KHHLMHDJAHI;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid EGMILGPBHGP;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid CJAJAIMCPOA;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid LGFGCEBCBPL;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid CFNOENNBPOB;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid JBAHJMIINEC;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid FHHGCGMALPD;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid JKGKKPCDJOL;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid NFJKIMKGMEA;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid KGHLDOKEEBI;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid GBIGAMPOFFJ;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid BGJGDLCBMJF;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid ODKDOMMNMGM;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid KFIGLECFBBD;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid APKPMBMBACK;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid GDDANHAIDNC;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid DKJEKGGKJBO;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid NNMFDACIEIE;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid CCPMBBHAGFO;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid KMLPGNBFCGF;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid PILOGKBPPMF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid PHMHNCDFCGF;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid FIAFLCNEDPP;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid DJPDFJPGHMO;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid HIFPJJJJDKN;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid EJFMDNGKENA;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid BNBGBMGLILH;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid NNHGBHHMLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid LLOLNJMJELJ;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid PCBBDMEPBFC;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid PEJDCMHAPBJ;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid BKKMHMPEMGC;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid KGJNDGEKFFO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid MAAKFFHILIO;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid KDHJIFLGNBH;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid OLGBCOPKCJN;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid BHCGKMOGDKH;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid NFFJBJBFLKO;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid FKGBJIKAFII;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid JBMNHJAOELG;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid CGPCABKEFEP;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid BFBDKAMNNMC;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid OJHJHCMIIPJ;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BFFILPLHCEF;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid PBKGCDPMAME;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid MLAIKFEAJEN;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid GJCCMJNDGPP;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid GPFMNNIPLPN;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid ANAGKLDMCOC;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid JGHMIKEHDGA;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid EMJMPHCJLEB;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid NEJLFENKLDJ;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid NIIDFBHODFK;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid MHMHNNNDKAC;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid JGAHMCBLPIA;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid ABDCGNMJLFM;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid GBNOCAFFOJO;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid CEGAPICGLIP;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid EELJANEDKGK;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid HAFEGECJCLD;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid GMKGFGBIIBP;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid BFFDIKKFKKJ;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid KCLHPEMPOHB;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid EDEEGDPHPCP;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid DGLJHPPNHCH;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid NBGBOIIKOPN;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid NFFGJNPPCHJ;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid LIEENJNEDFO;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid BPEJOGNKDGP;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid OIOIAGFFMNL;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid DHAAFEMGBOL;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid EAFPAGCLCDE;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid JEDLFIHOLGG;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid NLJIINPPNIG;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid CGANHLHCDPK;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid KJGFCGIONEF;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid APFKCLLNKPP;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid GJAFBNDNAIO;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid GJLBFEHEJPK;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid ACCFLMAAENA;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid KNNAFIFCONG;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid HDPDIMDAJAM;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid NMCFJIODFCE;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid PGAPKKGLBBC;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid CKMFBBGLNPN;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid DMANDAGEGHE;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid DJGFAIPOFOF;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid ACIMOFMIIIJ;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid KBPIGBHPJNA;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid EPGBPACEJFB;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid AMMJJAPMAPF;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid AMIADBKELNA;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid KJLEEHONPGK;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid MICCNBFDIDI;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid DGMBBKAOFKE;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid ECDIKFMOIEC;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid MDMJBDFHJCH;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid MFDHMLIHPCP;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid OLAGFJJDAAP;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid GAMGNLLHAJK;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid MGIBFAABGFF;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid OBJNNOOFBGD;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid IDEDHBKBAHO;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid GEHDCMFGMIH;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid GDGJKKAANBH;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid JOLGKFACHCO;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid NPGHFOPLNKD;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OJHKMFIAGNA;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid GFPIFBLKGNE;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid GDMOGIJKGEC;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid DOJHIOPKBOB;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid GFPIEGAMOAE;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid PEEEFMOOCNC;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid KDHPCCDJGNM;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid ELDNEJCMBHA;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid EAHPMNINDNM;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid MPAKCPOBCID;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid EKNDFLAAPMH;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid MGKOHOIIGFN;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid CBKBEIHFPKM;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid CACBKCLCOJC;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid MAOLPJILCKH;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid AJMHJFNGPNP;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid HCGOHEKFPCO;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid ENFJJGFGHOO;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid POFFOIJMMAI;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid OLAGMAIPEBF;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid JNJLIMPDBEB;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid LHAEHBGDNEO;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid BNHKCFJLMEE;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid BJAJGCPAKAJ;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid IGPNIEEAFHG;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid EMDFIPAEJHK;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid FEBPLAKPAGD;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid MOHHMCAKFJK;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid BGJDBPDGKND;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid GEHADAMLEMA;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid AMANECFEPID;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BIINFILIKBH;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid FKMKGIGCNGN;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FCAHDFIDCJN;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid PEIKCCFAEBL;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid DFCIFPEMGIN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid MLBMMHKEJIL;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid GJPEJDPPOGB;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid PGDKKKLNLMI;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid NCODCPMOPCN;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid MHDMMMPEKBL;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid HMHOCJFBHEO;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid JCBIIMCGDFN;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid PCKODLENLOP;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid HFNCDCENIEK;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid DENJHFCBDEN;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid DDHJJBILEDN;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid FBCICNKFMBP;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid GPBEENLBEOL;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CPGKPJGGFNM;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid DNKFCCGJAAO;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid KBPADCKEMKG;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid GFLAKGLMGKB;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid AIOCIIGMAJJ;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid ELAFDCFCDIB;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid PNEKKHLBJOF;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid CMKGNMHMMNE;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private static readonly Dictionary<Guid, PDEGLKFDOAG> CEFHOOLFKOI;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private static readonly Dictionary<PDEGLKFDOAG, Guid> DFKPBFKFOCO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, PDEGLKFDOAG> FEENOLLLLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C95D00", Offset = "0x5C94B00", VA = "0x185C95D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<PDEGLKFDOAG, Guid> BJLEMFEAPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C95CA0", Offset = "0x5C94AA0", VA = "0x185C95CA0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OBEGMPKPOAL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DFB0", Offset = "0x5C9CDB0", VA = "0x185C9DFB0")]
	public static bool MOOFAMHFACF(PILHLOILGMB CMAFJBPKIHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DC00", Offset = "0x5C9CA00", VA = "0x185C9DC00")]
	private static bool MOOFAMHFACF(FLKDCLPDLKE AMPANLCHEKM, PILHLOILGMB CMAFJBPKIHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct LIMGLHIBHKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public readonly ENHCAFJFPED LMKOPFMPBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public readonly IEnumerable<MEEBAJFNOLB> LGBFLOCCEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public readonly IReadOnlyList<MEEBAJFNOLB> KDAKCAFKMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public readonly IReadOnlyList<GFAOOEEFFDF<COFJGPIBAKG>> LLDNBLDBGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public readonly ByteString GJGALDNJEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public readonly PBAGCDGOAEH OGJILBGNCEH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BA50", Offset = "0x5C9A850", VA = "0x185C9BA50")]
	public LIMGLHIBHKC(ENHCAFJFPED CAGKEPBHJPO, IEnumerable<MEEBAJFNOLB> PFIMEMPCJMI, IReadOnlyList<MEEBAJFNOLB> FCPNJKKILEJ, IReadOnlyList<GFAOOEEFFDF<COFJGPIBAKG>> BHCONFHELOD, ByteString MOFDIHMCKML, PBAGCDGOAEH BKGBBNIFACI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface INLJMPNBGJK
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(LGPDLDLENNB PFDMLBFKIAP, [Out] Dictionary<int, int> BHIGPEPJGLA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(GBHCGBLPNAE HNCBEBKCMAI, HNCNGAAKMBK OMEPMBMECOK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AMEMNHOCBNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public readonly Guid MAEGOAOBMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private readonly Dictionary<Guid, Guid> LDODNENCJON;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> OPGIDKFJHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x314D290", Offset = "0x314C090", VA = "0x18314D290")]
	private AMEMNHOCBNF([In] Guid OPGHKHBILGF, Dictionary<Guid, Guid> HLBMJMHLLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C956B0", Offset = "0x5C944B0", VA = "0x185C956B0")]
	public static AMEMNHOCBNF HAEFHHOAIBG(IReadOnlyDictionary<Guid, Guid> PPNKHLKOJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C957D0", Offset = "0x5C945D0", VA = "0x185C957D0")]
	public static AMEMNHOCBNF INOEHBPEJJL(IEnumerable<KeyValuePair<Guid, Guid>> PPNKHLKOJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C95BF0", Offset = "0x5C949F0", VA = "0x185C95BF0")]
	private static Dictionary<Guid, Guid> PJGNEINPJED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C956C0", Offset = "0x5C944C0", VA = "0x185C956C0")]
	public Guid IDPAAEDNDJP([In] Guid FGCEIIELPBP, bool HAEHIBDAGLC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C95B80", Offset = "0x5C94980", VA = "0x185C95B80")]
	public bool JDFNKAPPJJO([In] Guid NBHCOBHPFBM, [Out] Guid EBFJPABFMEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PIFPLLEDFBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NBMNKGOJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFHLMHLMFOG(ByteString GHHJLCMBOHI, AMEMNHOCBNF EDDJGOOBPKI, [In] GNMGEBAMPGE EKFLCEPGGEG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IPIFNDJKJMD
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LOMIMBPJHMI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> HGNDLLCIFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> PIAMBBBBNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C0", Offset = "0x7694C0", VA = "0x18076A6C0")]
	public LOMIMBPJHMI(IReadOnlyDictionary<Guid, Guid> MFEBEOHOKEL, IReadOnlyDictionary<Guid, Guid> HMFFDDNDJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KMGDBACLFFN
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C98E40", Offset = "0x5C97C40", VA = "0x185C98E40")]
	public static NMBNEBBLFPD CGAOLGAEGNJ([In] LIMGLHIBHKC EGDAMPDFBAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C9ACB0", Offset = "0x5C99AB0", VA = "0x185C9ACB0")]
	private static void LGBKOBGEHDF(NMBNEBBLFPD EFGICFLGOPJ, [In] LIMGLHIBHKC BOKGJJBFPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C999C0", Offset = "0x5C987C0", VA = "0x185C999C0")]
	public static bool IALKNFNDMJF(NMBNEBBLFPD EFGICFLGOPJ, HDLJIPOLPED ABOELFPNCHN, [Out] LOMIMBPJHMI? HLBMJMHLLOG, [Out] string? OGJCCLJIEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C9B7C0", Offset = "0x5C9A5C0", VA = "0x185C9B7C0")]
	private static void PPGNLEKIDFJ(NMBNEBBLFPD EFGICFLGOPJ, AMEMNHOCBNF? NOIKMIGAMKD, HDLJIPOLPED ABOELFPNCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C98B40", Offset = "0x5C97940", VA = "0x185C98B40")]
	private static void BKPDDKMEONI(NMBNEBBLFPD EFGICFLGOPJ, HDLJIPOLPED ABOELFPNCHN, IReadOnlyCollection<ByteString>? BPAHKHCNKLJ, IReadOnlyCollection<ByteString>? CBDNMNLFOEI, IReadOnlyCollection<ByteString>? MOPNIGKIBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C99040", Offset = "0x5C97E40", VA = "0x185C99040")]
	private static bool DHKKALLJACN(NMBNEBBLFPD EFGICFLGOPJ, GBHCGBLPNAE HNCBEBKCMAI, HDLJIPOLPED ABOELFPNCHN, [Out] string OGJCCLJIEPL, [Out] Dictionary<int, int> BHIGPEPJGLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C996E0", Offset = "0x5C984E0", VA = "0x185C996E0")]
	private static Dictionary<Guid, FLKDCLPDLKE> FDCAGDDAIAF(NMBNEBBLFPD EFGICFLGOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C98FB0", Offset = "0x5C97DB0", VA = "0x185C98FB0")]
	private static void DGBLBJPHLBD(bool APKAALJJFLC, MEEBAJFNOLB CHKCMEOEOJO, Dictionary<Guid, Guid> KOKMIOPFOBD, AMEMNHOCBNF IDAPLEHJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C98BB0", Offset = "0x5C979B0", VA = "0x185C98BB0")]
	private static void BOHDHNGMNEG(MEEBAJFNOLB CHKCMEOEOJO, Guid JCMCPOFBHCB, MMPKILFBKEO? LDDEANBELJO, Dictionary<Guid, FLKDCLPDLKE> JFKIMCIKGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C9B310", Offset = "0x5C9A110", VA = "0x185C9B310")]
	private static void ODMIJLHJMLG(IEnumerable<MEEBAJFNOLB> BGFKFJKOOMK, IReadOnlyCollection<ByteString> BPAHKHCNKLJ, IReadOnlyCollection<ByteString> CBDNMNLFOEI, IReadOnlyCollection<ByteString> MOPNIGKIBLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HDLJIPOLPED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public bool APKAALJJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public PBAGCDGOAEH BKGBBNIFACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public MMPKILFBKEO? LDDEANBELJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public MMPKILFBKEO? GHKFOCIMNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public ENHCAFJFPED MEDEOOEAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public IPIFNDJKJMD AOHKPHFOAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public INLJMPNBGJK HBENDLAEEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public PIFPLLEDFBC KEAHFPJHBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public GFAOOEEFFDF<OHLKKMMGEAJ> HFCFJDOGGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public GLIHNBJPFLK HNCNMNAEBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public List<MEEBAJFNOLB> PIOEAHJFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public Dictionary<string, object> FOKDDHHCOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public HNLEINDDEOD HACNNCGNEOM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BDEBDCALPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5C964C0", Offset = "0x5C952C0", VA = "0x185C964C0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MMPKILFBKEO
{
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private const float LJEJPDJLMFJ = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public Vector3 AILFIIEAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public Quaternion GIBIBDOGOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public float GBJGBGCFEKM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 AABJIBOGLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5C9C120", Offset = "0x5C9AF20", VA = "0x185C9C120")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GNMGEBAMPGE JILOKOPCECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5C9C0E0", Offset = "0x5C9AEE0", VA = "0x185C9C0E0")]
		get
		{
			return default(GNMGEBAMPGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86B4A0", Offset = "0x86A2A0", VA = "0x18086B4A0")]
	public MMPKILFBKEO(Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, float GBJGBGCFEKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BCE0", Offset = "0x5C9AAE0", VA = "0x185C9BCE0")]
	public static MMPKILFBKEO AFMMKFBMODH(MMPKILFBKEO LBLLNFOEKNE, MMPKILFBKEO MLLJMJLBJDA)
	{
		return default(MMPKILFBKEO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BF60", Offset = "0x5C9AD60", VA = "0x185C9BF60")]
	public static MMPKILFBKEO FMKGPFEKDFI((Vector3, Quaternion, float) PFDMLBFKIAP)
	{
		return default(MMPKILFBKEO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BF80", Offset = "0x5C9AD80", VA = "0x185C9BF80")]
	public static MMPKILFBKEO FMKGPFEKDFI(Matrix4x4 CMDCPCAEEKF)
	{
		return default(MMPKILFBKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C2C0", Offset = "0x5C9B0C0", VA = "0x185C9C2C0")]
	public MMPKILFBKEO MJHHBNNOGID(Matrix4x4 GNLAIPIBJPM)
	{
		return default(MMPKILFBKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C4E0", Offset = "0x5C9B2E0", VA = "0x185C9C4E0")]
	public static MMPKILFBKEO MPJPBNKOLFE(Vector3 AILFIIEAPKM)
	{
		return default(MMPKILFBKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C230", Offset = "0x5C9B030", VA = "0x185C9C230")]
	public readonly HIJPHOGDNIB JCINJKAAFPP()
	{
		return default(HIJPHOGDNIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GKLLGJJEDPG
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5C96300", Offset = "0x5C95100", VA = "0x185C96300")]
	public static MMPKILFBKEO MKGLENCMCMI([In] this HIJPHOGDNIB LNKCIHFCLHG)
	{
		return default(MMPKILFBKEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class KELFMFJPBMK : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5C98AC0", Offset = "0x5C978C0", VA = "0x185C98AC0", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5C98200", Offset = "0x5C97000", VA = "0x185C98200")]
	private void LMNLIOPCGGO(Dictionary<Guid, Guid> CACBBHGGLAO, PDJMFDOHOKH INABIFFLADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C987E0", Offset = "0x5C975E0", VA = "0x185C987E0")]
	private void LMNLIOPCGGO(Dictionary<Guid, Guid> CACBBHGGLAO, MLBPPCPOKJJ BEDHOIAKPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5C98840", Offset = "0x5C97640", VA = "0x185C98840")]
	private void LMNLIOPCGGO(Dictionary<Guid, Guid> CACBBHGGLAO, HDCGPMGPPKL EHPLCGIMHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KELFMFJPBMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HFBCMPMIKCH : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5C96510", Offset = "0x5C95310", VA = "0x185C96510", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HFBCMPMIKCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class LKFMEIBNIIB : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BAD0", Offset = "0x5C9A8D0", VA = "0x185C9BAD0", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LKFMEIBNIIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class JMHHODMCOGF : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5C980B0", Offset = "0x5C96EB0", VA = "0x185C980B0", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JMHHODMCOGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class DFPDLGDGGFA : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5C95F20", Offset = "0x5C94D20", VA = "0x185C95F20", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DFPDLGDGGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class NCLINOKKJKM : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C550", Offset = "0x5C9B350", VA = "0x185C9C550", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NCLINOKKJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class JAKEPFAOJLJ : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5C97F10", Offset = "0x5C96D10", VA = "0x185C97F10", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JAKEPFAOJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class HOOCHBJGNJI : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5C965B0", Offset = "0x5C953B0", VA = "0x185C965B0", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HOOCHBJGNJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class BGKKFPFMPNE : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5C95D60", Offset = "0x5C94B60", VA = "0x185C95D60", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BGKKFPFMPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class EHLPMMKLJGD : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5C96140", Offset = "0x5C94F40", VA = "0x185C96140", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public EHLPMMKLJGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class AFLMILHNEKD : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C955B0", Offset = "0x5C943B0", VA = "0x185C955B0", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public AFLMILHNEKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class HAFPNLABIJL : HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly System.Random ANJKLJOGPEP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C96390", Offset = "0x5C95190", VA = "0x185C96390", Slot = "4")]
	public void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HAFPNLABIJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PILHLOILGMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public GBHCGBLPNAE KCPGKFKLEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public GKNIEEPMBMO PGLJPEFEPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public Dictionary<int, int> KHABAAMKAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Dictionary<Guid, Guid> MDLKIAHIJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public HNLEINDDEOD HACNNCGNEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public bool OLAEKCABFGN;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HDAEOKEOAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNEBJBKJEPL(MFGHBNLNNAA GLKNMJBPHLG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IIKGDMFHALF
{
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private static readonly HDAEOKEOAJD[] EBGMBPJJELH;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5C96F80", Offset = "0x5C95D80", VA = "0x185C96F80")]
	public static void FFAMGCLOBJM(MEEBAJFNOLB PFDMLBFKIAP, Dictionary<Guid, Guid> JDGNFIDGPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5C97210", Offset = "0x5C96010", VA = "0x185C97210")]
	public static void LBCMAKDNPBK(MEEBAJFNOLB? PFDMLBFKIAP, AMEMNHOCBNF IDAPLEHJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5C97570", Offset = "0x5C96370", VA = "0x185C97570")]
	public static void MOOFAMHFACF(MFGHBNLNNAA GLKNMJBPHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct MFGHBNLNNAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public GBHCGBLPNAE AGNFMHPLBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public MEEBAJFNOLB CHKCMEOEOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Dictionary<int, int> KHABAAMKAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Dictionary<Guid, Guid> MDLKIAHIJEB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BC30", Offset = "0x5C9AA30", VA = "0x185C9BC30")]
	public Guid BDNHHMPFPCK(Guid FGCEIIELPBP)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HNLEINDDEOD
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int ODGBPFEJKKA, [Out] Guid KNMAOCNMIEI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NKPEKCOEIKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private readonly HashSet<string> HPPKBPJFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private readonly Dictionary<long, int> KAAAEEEMPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private readonly HashSet<Guid> EOLJJOFNPAF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> JCHFAGIIFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> PEMNIHJIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C880", Offset = "0x5C9B680", VA = "0x185C9C880")]
	public static NKPEKCOEIKE DIBCLHLGDCA(BNNAHCBMALA MFKPIJLKLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C690", Offset = "0x5C9B490", VA = "0x185C9C690")]
	public static NKPEKCOEIKE AHNHAEMHLAE(NMBNEBBLFPD HEFFEFIGLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C700", Offset = "0x5C9B500", VA = "0x185C9C700")]
	public static NKPEKCOEIKE CIAFCGGGHPL(IEnumerable<string> HPPKBPJFJFG, IDictionary<long, int> BDFONDNEBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DA60", Offset = "0x5C9C860", VA = "0x185C9DA60")]
	private NKPEKCOEIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D920", Offset = "0x5C9C720", VA = "0x185C9D920")]
	private NKPEKCOEIKE(IEnumerable<string> HPPKBPJFJFG, IDictionary<long, int> BDFONDNEBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5C9CCE0", Offset = "0x5C9BAE0", VA = "0x185C9CCE0")]
	private void JPKPFOCLFCO(BNNAHCBMALA MFKPIJLKLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D4F0", Offset = "0x5C9C2F0", VA = "0x185C9D4F0")]
	private void JPKPFOCLFCO(NMBNEBBLFPD HEFFEFIGLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C9CEE0", Offset = "0x5C9BCE0", VA = "0x185C9CEE0")]
	private void JPKPFOCLFCO(AAMGIFJADMI? JKEBPOPHOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D380", Offset = "0x5C9C180", VA = "0x185C9D380")]
	private void JPKPFOCLFCO(PAHIIAPGBLO? NNLCCKHBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C8F0", Offset = "0x5C9B6F0", VA = "0x185C9C8F0")]
	private void JPKPFOCLFCO(MEEBAJFNOLB? CHKCMEOEOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D8B0", Offset = "0x5C9C6B0", VA = "0x185C9D8B0")]
	private void NNJMFOGMNFG(string? IHAGCAIIJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D6E0", Offset = "0x5C9C4E0", VA = "0x185C9D6E0")]
	private void MJOHPAKIALM(HMFICIEPHGJ? KHJDCNGKOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D7C0", Offset = "0x5C9C5C0", VA = "0x185C9D7C0")]
	private void MJOHPAKIALM(HBJICGBCBNA? KHJDCNGKOLH)
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
