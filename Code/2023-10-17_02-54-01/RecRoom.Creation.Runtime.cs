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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C9DBA0", Offset = "0x5C9C3A0", VA = "0x185C9DBA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BKBIMJKLFHE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> GBHILGOJFIK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> JALLCBFELEH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C95A50", Offset = "0x5C94250", VA = "0x185C95A50")]
	public static bool PKLCGOAHFPD(Guid JMKGNEDNECF, int KJGNMJDFOMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LDMOCPKBGGG]
public enum LHBJMFGBLPD
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
public static class JIEDELOIOMJ
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly Guid OMGKKMPAFHI;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly Guid IAFGEDHNGDK;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly Guid FHKBAIOHOFH;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly Guid GBIOFEEFCDC;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly Guid KKIGAONFPFM;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly Guid CMEGLAMIIAK;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly Guid DLKGGMAIGNN;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid FNPDIFHELBB;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid MBNIGMOANCA;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid PEEAOLAOKLN;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid INNKPOGBIMO;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid NHLPPLOBKOI;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid CPIDDDJNEBI;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid INCMJLHPOJF;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid LEMDIJNDLND;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid EHFENDIHMAP;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid DEAEKPHJKAM;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid EGJNMEEELME;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid NFFKPPKFGBF;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid EMGLDKFDKFE;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid HCGMKKOIFDL;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid PENDIANJIIM;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid IHOPCDILCBN;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid HDIOOPCHGNB;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid BMFMADLKHOD;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid JDLEFAGHBFG;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid HNEGMMOOJFC;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid HFHBHDDFIEI;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid LHPGIJMOCPJ;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid HKONAANENBL;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid CCODMLHLJCA;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid JJOGIHKDGOI;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid FFFMJOJEEDP;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid LGDEICCDGJH;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid HIBOIOPBKAE;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid PDFMCJFNOJH;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid JKPLMLJEMIG;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid FNNCECKIMJM;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid CKKOPECKHGI;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid BBDCCAEKNHG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid BBIJGINEDIL;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid IMFDMHKAGGK;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid HCOGFPFHGML;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid PKBJLKOAKAG;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid JEMHABBDFFO;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid IGOAMPKDDLN;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid HDEBIIIDGAC;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid HNMNJDDLALK;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid CANIBNALNOI;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid FFDMAFAPLPC;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid IKAGNLJOPME;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid BPGJBNIBCNJ;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid HJMPKHKFIOC;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid CDLNDIMMKOB;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid EBAJCHDOCPK;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid IOKCDOMPBIH;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid IPHLBJOMCPM;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid AOMIGLIFNPJ;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid CLBLPIILGCB;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid KDJHDJBOKEA;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid EDLIOICGPJH;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid DCHPHNCAJIM;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid GJCIONCPKAJ;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid DBHIJMLCLPO;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid AIPMOBKNMNI;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid MPBDJJGLMHC;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid LNMIMOIPMOP;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid PNBJBHLNOAC;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid KJHONPMOMLO;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid DEJNGPNNCHP;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid MAIONEGAFFB;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid NDLNCCOOENO;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid JFGEBNODOED;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid HGJFLOLLHJE;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid LKJLKGIBFNE;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid GFDLAINNIED;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid MAPNDDLJCPH;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid PANNOCEHHAC;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid IEOLGLFIEOG;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid BBLFFDFKFIP;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid NNAHOKBMNCD;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid LCCCKLHONPF;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid HMJHNDKMLLP;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid DOBHJILEGKN;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid BBDGEJGBNHK;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid BINDBNDCKPH;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid MDCOJBPCMOJ;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid HPHCGHHIIPC;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid BCGBFPGGJJG;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid OAJOFANPACC;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid FJKMMMKLGFB;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid EENPBLBBAMB;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid CADICOAGMLC;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid KIEELHIMLGB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid KFGDNMDNPCK;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid GNDKGGHHFJF;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid NOIHPGCBBGK;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid CCJNCNECDDC;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid HMOLKBOAAHP;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid DMOOKPLIAKH;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid PIFKJPBPJHC;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid FONFHEEOMKA;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid OJNPPIGBKDM;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid MHOJEGNGFIM;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid LGDEMOFFBDE;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid CLJJKMDCPDP;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid OFMKBKMGBGO;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid GDKPJNNFABN;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid IAJINADMFGH;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid IIILKBPMKHK;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid AGCLHAJFAMK;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid KMGIGHEJEKP;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid GHPOBCHKPMM;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid POJDDAFOFAK;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid LENLPGFECJF;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid HPNPGFMLAJI;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid KCJGOCNOEOL;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid DILMNJPJIJA;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid FCPELEOLOFA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid PLCNHMOJILI;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid MNEFPBLFINH;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid EMCBFJPNGHF;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid IFGPJBBMHNH;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid LCGACIHKCMK;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid BBOMFBGMMFC;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid GKIKBKJFIHK;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid PHLGGFGFNCF;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid JCLCPKECIEG;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid MCJLBFGDIJJ;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid KBJCOLGNFFO;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid IPCNMBIEAMG;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid LAGMCCNNDHI;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid GNMCOBICCHG;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid ONKCIHDJPDH;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MEGKBPBGIOO;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid PMKHABLKNKF;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid IKHNMCJJMLD;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid CFMJJIPGCNE;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid APKCPPJENBG;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid AGMNNGEBKEC;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid LCHBMIMIKMM;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid GCEHHKAEPGD;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid HCLIGEPHPHK;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid MBGMNBBCHMG;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid KNNFHOJKFEL;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid KFDCNHDHNCF;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid HDADNPONKKN;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid NICMCKMJDAL;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid OONBELDEMPG;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid PDJEMJLCPEI;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid ALNOCBBCJAN;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid OCONCBNJAGA;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid GBJMELGEKLA;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid CBKBBLOFHKK;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid OLFOJBKNFAM;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid BLKKCEAKIIC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid CJDGHENEOKB;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid NFAPKKLAPNP;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid FOEAMPLEFIK;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid FFMMLNIPGJE;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid ADAHFFCCCAM;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid LOGBNAFAKBP;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid OHOLMFCFGBJ;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid IIGEPGBBLJA;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid NLKCNHFFKED;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid FCNIKPEAPLN;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid CEBNHEGCJMA;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid OKHGJJIABPE;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid GFFEDFHAPCD;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid JOCKPDNALHP;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid BEFKFFOCLLI;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid EENDDIPKLII;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid PGIFNAJDMFN;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid BHFFHLGMMHB;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid IONDBALOMDL;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid JAOPIGLCPJI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid FCIDGAODABN;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid IEJIOJIOADO;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid HHBDEBIJCKN;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid EIBLHCPGKHE;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid FIIKLDFIIEB;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid MHFDFPONMNB;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid LNBMEKFGCPD;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid IDBGECFKJAC;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid IDMCADAEIMO;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid MDMPLNBFECI;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid IHEPCHJFBEP;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid JLBMFJEPBAL;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid FFCOJIKLDPA;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid IFACCJHHFBI;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid MGHCJOJNEBG;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid DIMHGJDCJBJ;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid CGDGJIMAPAC;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid EJNCNLDGHGI;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid NCHMADDKKOM;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid PDBGJEEEICF;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid KAEFJPCKBNO;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid BGNFHPIKBKE;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid KNKFFHGOEDI;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid BPLLNOALKGE;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid FMDFNPNEBKA;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid GHBNFKBLOEG;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid KHOPMHBEFBC;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid AGKDGLGEPAP;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid LEHMJDCJGIH;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid PNIFAGDBPII;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid HKOLINEGCKG;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JCGLMPFIMIF;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid KMJBKIHMNLP;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid EGPALKBKKKE;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid KJBAILLALGA;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid MINIBOFLFJL;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid PPLLIHPCBHF;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid FCBLNMMLEBP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid EGMLLBCHLHD;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid HKKKOFBLJJB;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid FMEAHJHPAJP;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid GDKNBKEFBBI;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid BDIPBDJPJAH;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid MMJHKLMFMOH;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid IGNJAJAAHPC;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid ALPGKOCODPI;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid LKMCOOLONKB;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid DKODCBMIJAG;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid FHBGCMNHNHD;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid OMJBNAANKEO;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid OLBMIOOHIIN;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid JOCPEMJEAJP;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid NNIMCCAGFLC;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid BPHNKJHMBIJ;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid IEAPBALHGIP;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid HIKDBBAKIMB;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid LJAEOINCLPI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid BGJFLPIJPEK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid CDGACGNMNHE;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid MLKPMCICGCN;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid MAOGDGDPFOL;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid GFBHGIGKOOI;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid COKCKLADFBA;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid OOJDFOMGAPI;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid FBKFAMACJMB;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid JOGBHBIPCJA;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid NNPMGAEKNHO;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid OEKFCFNHPOI;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid ELNJOHNNCAN;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid JBJPBFCDCPP;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid MLADBBBPLFE;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid EFGAANJMMKC;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid EONNNIBLHMM;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid LLHGKCHLADJ;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid HCOACPEMNIK;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid INHJODLACAF;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid AMLOGKDPDBF;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid LFHFCLKKIJI;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid MLDPPCPFHOJ;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid OFHCIIGOLAK;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid APMJGDDPFJP;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid BFNHGNLMPGE;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid MJNJAOGIPHM;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid DMPIJECLPGN;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid HGINMCJLEGN;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid LLFAKMDKGDJ;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid NEONFLEPEIN;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid IJEIBCPNJOG;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid GOMFBOKNFIJ;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid OLJFPAGNDGF;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid LEPLGCPKHAP;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid NOFPJGHMHIJ;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid BPPFONKOKBF;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DFGDIEJPKCD;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid INAGDLGKPPD;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid LCBMDCHOIEG;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid PCAOLAGMOIC;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid OOEGFJNADHG;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid HNLHFBNJGGD;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid IGKFJCLOEJL;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid EPKDABGJJPD;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid DDDGBGBNKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid NEPPDEFEBCF;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid PIKBJKNEHCO;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid LPDOAILHCHF;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid PEKMMKNBLEE;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid ENPCJLGNIKP;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid MKLFJBPLKFC;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid HCNLJJPKDCL;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid GJBECFHGFAE;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid HHGMHEAAHIB;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid PODAKBHAFMC;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid PICHFHLDNPH;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid ADKEINPBAEL;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KLDLDKGNEIJ;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid OIGLAAPHGFP;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid KOAEHLMBJJB;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid GNJPMHINMHE;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid CEOLODEJAJE;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid BPCGNPILGCO;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid LNAKKOIHFOA;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid FOHKBFPECAO;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid AKMDKANJAID;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid AELCDIDLFHG;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid EHIEICPNEHO;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid GBIEABFNOBI;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid BPLKKALFBLL;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid BMIEDENCANI;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid LCCECPCHKGJ;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid EGFDBGBPLIP;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid KBPGEEECJCF;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid GOFKHBCANEI;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid JKLNCOLBNJA;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid NOFOPKEKCNF;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid HJHCBIFLCNC;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid NFDLEGBLHNI;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid BGNCGEKBPDK;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid LKPPOLCFFKK;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid DCJEONPKMFG;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid IKBNCLNLEJA;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid MADPODDEKPC;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid PAGFNIMMCAO;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid LMKJKBMMBFE;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid DCGPOHJNDDB;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid NDJMHPHMJHP;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid HIEIHMABGFN;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid GCAJEIHIOPB;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid OAIFOLAAFNJ;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid GANPOPHFIIA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid GENAIFCOCKB;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid GAGOIBPCAKN;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid PPJLHOHNCJD;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid MAMFCCABOGM;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid OCFGDJBAEED;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid BFJHBIIDBGC;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid IAPECOIEINF;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid LOLNNEFOACC;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid OFFHADOEHAP;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid AOMJKODBDLA;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid CIGAOBNEACC;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid MIKDPEJNIDD;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid IECCBKDMLEC;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid ENKMKMHLMEF;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid KDPKNDMAKPC;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid JDIAALKNJJN;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid NHKHILGKJMJ;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid GOABOJLNGBJ;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid BBLPLKOMEFD;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid MJPBFMDGFMM;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid MEPDGKHNGOH;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid LNLKLEFFHFP;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid NFLEDOFPIIO;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid JKIIMEIIACF;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid MGIKHAEJOGC;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid FHGNPNKCMLD;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid ELDJBJECJHE;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid MDPMHHAJPHI;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid LEPOFPCOIHK;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid GBIKBNOEPLD;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid AKBFPGJACFE;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid ELEMHKJKJOK;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid ANCGGDMIEAA;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid EOFIDCMGILG;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid FCHFLJHCDDN;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid GIFGBNALKDH;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid PIHBLAMDLNK;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid KGKMBPBNINE;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid BJKJKODKOLN;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid CBDNMHLFGKI;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid KMNFFBPEFNO;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid JCJGPELNKAE;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid NMBHNHDGNME;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid DECIPAGOJDP;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid PJJLGPPNNKI;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid DBCDOJKHEEN;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid JFNFBNIEJPN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid MEIHPPBIEIN;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid DAGCOCOPBHN;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid KGADENGCIKL;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid IJLHFIDALIH;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid GPNCCCJOGCM;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BNBBKKMFKHM;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid BBAIFEJOAIA;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid AJBKFDKNPBM;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid CGMLACPINMJ;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid EMGLGFAKFKE;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid BFKNCKDBGIK;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid FOBJJIHDFKI;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid HGCHCIHGHFD;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid JAAMHAHODLF;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid MEIKOBONFPM;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid IFANEPOFOML;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid CKCENPCHJFE;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid APDOLFAOHIL;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid PNALOHKHLCK;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid OONHDOKGFAA;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid LGDLHCHLCMI;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid PGOOMAGGJEE;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid PLALDNKPPOP;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid PNKEPHMNONE;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid KAOPKELBBOB;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid POLJAEEOHDH;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid PJJMOGELEHD;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid IAGKDFMKNHB;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid GHCHJJCOOHM;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid JFIFDGMFFIM;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid HEOMMFBHBIF;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid PECHAECLELM;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid BDJOJOKFDMD;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid NAPFEDHLKOK;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid MKPILHPKILI;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid CCIOKBOOIOB;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid IFJLKIDOHLK;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid OAKMBGDKNJB;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid ONDIBDJBPPJ;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid GIIIHGJEKDG;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid MHGKJIMBHKH;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid ADEDPJMAAOJ;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid MGJFMHNPDAL;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid DNFIBOEFNCE;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid BJGJGKCACEH;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid LPPCOIKLDJA;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid NJJMFAKJGDC;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid CJPKKAPCCMD;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid ANNGKLGCILB;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid AFJELFOCFOE;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid GMCOCOCBOAH;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid OIEILFCGBAJ;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid MLLEFLNCOPO;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid KDEIGGONLMM;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid MIEKDBADBJA;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid CBACMBDPLIO;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid DODKMBFJHEK;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid ODNFHGKFFNJ;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid PHPFGJNLPHF;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid KGCGGGGBNBI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid IMABBNKBGMK;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid IHGDGOIMLNN;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid EPFEKDLIOOD;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid HBBDLJCMCLH;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid FCIHCMIFJKK;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid JDFMFDDJCJI;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid EMLLAIIEDOD;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid ADHPKPLHADC;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid HONCGCHOPOB;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid ICAPPCPIHPA;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid PDIGPDPNLON;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid KJKFMGDDLBK;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid KGOKKCAPBAF;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid CJBDGNEFGNI;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid MNGJMKBNOGF;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid KOGJNEEIJFG;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid JEONMBMLCLH;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid FOOFFCFFENG;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid FFHFMOPDPDB;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid AHLCFODDMMA;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid HNHAMDLGJEL;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid KDFMDCPMGGO;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid CFFDMAKNBBH;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid CHIABEGJPKH;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid FJFPKMHLLGE;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid HJCDMCLKEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid GMNPEBNLDOH;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid AIDPJGDFJFF;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid NKEHIDCNMLE;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid OHBBJHOIAMK;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid JHIEIDHCGEA;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid BPPPFOLMJHN;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid KHEBIBLGEOH;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid KGDPHJNNKGP;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid MDPFPGMFBNN;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid FBNLLDBKFKF;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid IPKEGCCIFKG;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid ALLCBMHFKHI;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid AHIBJECCHLD;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid HKJAOPMEJEB;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid DGBNGGPIDHH;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid JAAMOHELPGC;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid LOIJHHKNFBN;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid IKCPEGLBEPN;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid PJBKCDPCKII;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid BNCCKPGACLE;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid OADMKNCKJDP;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid GNFFHFFBKAI;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid KGHHMFHGHJJ;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid MPCOPBGFNCC;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid IKAJDODIOPH;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid GOMADPLFJDK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid HNODOLCJKBO;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid FHONECHBOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid IDAGMLPMLKM;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid GLEOEODDIJL;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid KLCKFHAGHON;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid PMAIDLHBEMA;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid JOJOOAEIADN;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid LNCOBMIELKK;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid IHPEDKCMMCC;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid MAOGFKCNBME;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid MEKAPHFKCAH;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid ALPOJHHNEDJ;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid OJDNBOLPJIB;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid BAOLJMHDIOF;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid FNBEJHFPKFJ;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid FBBAOFNEANI;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid ECDPOLFPCBP;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid BIIIIBHJGIK;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid BLEANCEMJID;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid BBEPNPFDOFN;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid ACNCLACODIH;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid IEOFCCJNOPP;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid ODPGKABKOGG;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid OHBPMMOJIFE;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid MGFLHMPMDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid BLAPKAFIMJL;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid CCJEICNOIHH;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid LICJOIKICMI;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid JFELAPFOAHI;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid AFMCBBNJILN;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid BMEDOKBAKCE;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid NIIHFKGCPPF;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid DMKOBHNNELP;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid HPCKEJIHKOG;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid FDMJGAELLAH;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid KOEPOCLOOFN;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid OLHEGENONGE;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid CFBNNDGNNAE;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid BIHGCLKEIHC;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid ENNHMJKLPBC;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid HNLCMKGPJKG;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid OFJIKGJJFPA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid CFGDDNBFCHM;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid NDFEAMOLLMA;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid NDDDKKBMEEE;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid BPJAMBBKOIL;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid GKFJDFPCAFE;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid AMEIPCIAMNE;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid EHHEIHOKBCF;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid LEDEFHJPGOF;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid FGGEBGGKDEN;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid NBNGODOHEKD;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid BPIJFIPFEFM;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid GGDAPAFPGGN;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid APPDHOODHJB;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid BLGFBIEFMMB;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid BEJNMMGKJNF;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid PDJOACAGJOM;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid FBFPHFGPEPD;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid IDBLAFGHLLL;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid PDFNMCNHOIH;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid NOBIFLHFDMD;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid BLDMBIFGDAP;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid IKPEPDDDIHG;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid DIMDICJMBAD;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MNINLMGCDBP;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid DPFPEOOEEEL;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid JDCMOINGLDF;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid JPCGCEBLJPL;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid DALNHCKHIOD;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid GAOFAAOOHGG;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid KCACPGGAHBK;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid EPMGGDOKFAO;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid CFKKNJAHANB;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid JPIDCLLHJAO;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid HGNKGPFGHOO;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid NDMPFBLPNAH;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid GJCEMHAMPIB;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid HKEAEPEGBMO;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid JPBAMINFOBF;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid PKPOBHDMCLI;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid IKEIAMKOCKE;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid LBPKJDPBOLE;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid GOMIDCMJJAA;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid CJCNHKOKFEL;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid LBDPHDGLAPD;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid FIEENCIOLFM;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid MBMAGLCJBLN;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid KKFHLHDGOOL;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid FBBLBJIBMMA;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid EMAIDJAINEB;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid EPPHLFMBAJC;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid AFCLKIKCEDD;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid HGEFGGLPEHJ;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid AHJGIMJHCFD;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid GECNLODNMMC;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid HEDDFAMCDOJ;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private static readonly Dictionary<Guid, LHBJMFGBLPD> KAGGEMPNLOO;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private static readonly Dictionary<LHBJMFGBLPD, Guid> KANMCEINNOP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, LHBJMFGBLPD> JNONOAIIPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B820", Offset = "0x5C9A020", VA = "0x185C9B820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<LHBJMFGBLPD, Guid> IOKIOFBJIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B880", Offset = "0x5C9A080", VA = "0x185C9B880")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ECOELAHIHHA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C96950", Offset = "0x5C95150", VA = "0x185C96950")]
	public static bool KBPPEIIEIID(ALMPFPLJGJI GHMIHPMGKAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C965A0", Offset = "0x5C94DA0", VA = "0x185C965A0")]
	private static bool KBPPEIIEIID(FENGFLGKFGN PBLOIICNEMP, ALMPFPLJGJI GHMIHPMGKAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct LMAHGKHIDLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public readonly CLINDLPGIOG CPJODMMJCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public readonly IEnumerable<KAGLGJLPIBC> EBLLBLJEFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public readonly IReadOnlyList<KAGLGJLPIBC> LEMJCGGOHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public readonly IReadOnlyList<OKMFLAIJCBC<IKFKOGPAMKO>> PLNLKKBIANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public readonly ByteString FMAALOOOLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public readonly HPPICHAHICC NFKPBAPLDFG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C4D0", Offset = "0x5C9ACD0", VA = "0x185C9C4D0")]
	public LMAHGKHIDLC(CLINDLPGIOG GLGEJEDMGLM, IEnumerable<KAGLGJLPIBC> IGHNNKNKLIG, IReadOnlyList<KAGLGJLPIBC> JOMFJKLHFOD, IReadOnlyList<OKMFLAIJCBC<IKFKOGPAMKO>> ANDJDPPJKKK, ByteString DNGDFHLKPJJ, HPPICHAHICC PMLPBMNHCPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JBOIOACADID
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(IOKFHEHHMPP AELCABDCBDD, [Out] Dictionary<int, int> PKDFPEHBGGA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(EDLKHAAMHBP LIDBAAEHMKH, DAPBBKGNCIO BHGLBFFKFFK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PGAMCPMNOPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public readonly Guid HJMNHMFJINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private readonly Dictionary<Guid, Guid> HGKFOCHNLPI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> GNDAOMDIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x315F2C0", Offset = "0x315DAC0", VA = "0x18315F2C0")]
	private PGAMCPMNOPP([In] Guid GEPOLGPIEPB, Dictionary<Guid, Guid> LJDGNOMEJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DF20", Offset = "0x5C9C720", VA = "0x185C9DF20")]
	public static PGAMCPMNOPP EHNAHKLIBMB(IReadOnlyDictionary<Guid, Guid> KGHOJOCILBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DF30", Offset = "0x5C9C730", VA = "0x185C9DF30")]
	public static PGAMCPMNOPP EIAKALCFOND(IEnumerable<KeyValuePair<Guid, Guid>> KGHOJOCILBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DE70", Offset = "0x5C9C670", VA = "0x185C9DE70")]
	private static Dictionary<Guid, Guid> BECCEKPEHHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DD60", Offset = "0x5C9C560", VA = "0x185C9DD60")]
	public Guid BDJGGLGJGPH([In] Guid OJPOLEONBAO, bool CNBONFLGPHC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C9E2E0", Offset = "0x5C9CAE0", VA = "0x185C9E2E0")]
	public bool MOFMNNLLIIN([In] Guid NENKFFLNHCE, [Out] Guid CJCNLNJOBGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FMIBKOHPHLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CFNCBLLJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFKIHJFLILM(ByteString KDMODAMJKPD, PGAMCPMNOPP AHNNMFMENJG, [In] DDNODGNMOKA KDNAJFNCADC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HFBLMAICAHL
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
public sealed class GBIGBLCPECG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> PDHIPHLDNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> JIPMKEHIEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	public GBIGBLCPECG(IReadOnlyDictionary<Guid, Guid> ECBHCENGCGG, IReadOnlyDictionary<Guid, Guid> PKKENEOPLME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GOMDOLBPGNG
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C98910", Offset = "0x5C97110", VA = "0x185C98910")]
	public static DOFEDNDHOFO AHANGMHEMON([In] LMAHGKHIDLC LFLILIBGHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C99080", Offset = "0x5C97880", VA = "0x185C99080")]
	private static void EPGPCCGOFJM(DOFEDNDHOFO HCIGAEGIJAF, [In] LMAHGKHIDLC MFNBICCKMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C9A530", Offset = "0x5C98D30", VA = "0x185C9A530")]
	public static bool NPOKFEEKAJD(DOFEDNDHOFO HCIGAEGIJAF, NDELLACINLJ IEEHJECKKEF, [Out] GBIGBLCPECG? LJDGNOMEJHH, [Out] string? HLPKEEDLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C98A80", Offset = "0x5C97280", VA = "0x185C98A80")]
	private static void BFKMCMJCKKH(DOFEDNDHOFO HCIGAEGIJAF, PGAMCPMNOPP? DIAADMDGPBA, NDELLACINLJ IEEHJECKKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C99D80", Offset = "0x5C98580", VA = "0x185C99D80")]
	private static void FMFHHHPOFJJ(DOFEDNDHOFO HCIGAEGIJAF, NDELLACINLJ IEEHJECKKEF, IReadOnlyCollection<ByteString>? JPJNLDEPNCG, IReadOnlyCollection<ByteString>? MBBNBLLCBPC, IReadOnlyCollection<ByteString>? BFPEHGHMFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C996E0", Offset = "0x5C97EE0", VA = "0x185C996E0")]
	private static bool FECONDCJJGL(DOFEDNDHOFO HCIGAEGIJAF, EDLKHAAMHBP LIDBAAEHMKH, NDELLACINLJ IEEHJECKKEF, [Out] string HLPKEEDLIBL, [Out] Dictionary<int, int> PKDFPEHBGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C98DA0", Offset = "0x5C975A0", VA = "0x185C98DA0")]
	private static Dictionary<Guid, FENGFLGKFGN> BNHBPLEKDBF(DOFEDNDHOFO HCIGAEGIJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C98D10", Offset = "0x5C97510", VA = "0x185C98D10")]
	private static void BLNPJFNEJAB(bool PDNJGMCGCMG, KAGLGJLPIBC CDHDPJPOJHJ, Dictionary<Guid, Guid> MLPDHEOKJGJ, PGAMCPMNOPP ABBINEEKBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C99DF0", Offset = "0x5C985F0", VA = "0x185C99DF0")]
	private static void NFEIHMCKBOF(KAGLGJLPIBC CDHDPJPOJHJ, Guid KFAAFAPONMP, LAJBLHJKDGJ? BIHCCGDMLKP, Dictionary<Guid, FENGFLGKFGN> DNDIPKDPFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C9A080", Offset = "0x5C98880", VA = "0x185C9A080")]
	private static void NNLIDBHAMHJ(IEnumerable<KAGLGJLPIBC> EKDBBDBILPO, IReadOnlyCollection<ByteString> JPJNLDEPNCG, IReadOnlyCollection<ByteString> MBBNBLLCBPC, IReadOnlyCollection<ByteString> BFPEHGHMFHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NDELLACINLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public bool PDNJGMCGCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public HPPICHAHICC PMLPBMNHCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public LAJBLHJKDGJ? BIHCCGDMLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public LAJBLHJKDGJ? GIDIKOLLPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public CLINDLPGIOG DPNBPMDEGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public HFBLMAICAHL KDCOEFPJBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public JBOIOACADID NKOAMAFLIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public FMIBKOHPHLF IHAFAPDKOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public OKMFLAIJCBC<PEKCPKJHMHE> HMHCHMJBAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public MCLBNDOONCF DGDCOOLFOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public List<KAGLGJLPIBC> BJFEBMJOBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public Dictionary<string, object> DOIGIKFFHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public IIJHMGIKGPD GJKNJDDEAGM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DGMKDHOIBPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5C9DB50", Offset = "0x5C9C350", VA = "0x185C9DB50")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LAJBLHJKDGJ
{
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private const float MHIFENOHOBK = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public Vector3 MCLBBPPAHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public Quaternion OHMBDAJNEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public float DCPNEEKOHBH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 NDJHCGJNBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5C9C140", Offset = "0x5C9A940", VA = "0x185C9C140")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DDNODGNMOKA GADDIAGIKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5C9BC60", Offset = "0x5C9A460", VA = "0x185C9BC60")]
		get
		{
			return default(DDNODGNMOKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86B240", Offset = "0x869A40", VA = "0x18086B240")]
	public LAJBLHJKDGJ(Vector3 MCLBBPPAHAP, Quaternion OHMBDAJNEIJ, float DCPNEEKOHBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C250", Offset = "0x5C9AA50", VA = "0x185C9C250")]
	public static LAJBLHJKDGJ OBMJFHJEEJJ(LAJBLHJKDGJ OBIIIBPBMLD, LAJBLHJKDGJ MAFABKFNKJG)
	{
		return default(LAJBLHJKDGJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BE00", Offset = "0x5C9A600", VA = "0x185C9BE00")]
	public static LAJBLHJKDGJ FEBAGKLNOCP((Vector3, Quaternion, float) AELCABDCBDD)
	{
		return default(LAJBLHJKDGJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BCA0", Offset = "0x5C9A4A0", VA = "0x185C9BCA0")]
	public static LAJBLHJKDGJ FEBAGKLNOCP(Matrix4x4 EEBJABCLBGL)
	{
		return default(LAJBLHJKDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BF20", Offset = "0x5C9A720", VA = "0x185C9BF20")]
	public LAJBLHJKDGJ KCKOIBHHKAP(Matrix4x4 CPMBJLDHCID)
	{
		return default(LAJBLHJKDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BE20", Offset = "0x5C9A620", VA = "0x185C9BE20")]
	public static LAJBLHJKDGJ JBEEABJCJNF(Vector3 MCLBBPPAHAP)
	{
		return default(LAJBLHJKDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BE90", Offset = "0x5C9A690", VA = "0x185C9BE90")]
	public readonly ICGPIDNEGNK JGHKBEHOEIB()
	{
		return default(ICGPIDNEGNK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JPEIMEDHGBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BA30", Offset = "0x5C9A230", VA = "0x185C9BA30")]
	public static LAJBLHJKDGJ NIACPALDAEN([In] this ICGPIDNEGNK AFFJMIFONEM)
	{
		return default(LAJBLHJKDGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GFDNLAJDCAN : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5C97FD0", Offset = "0x5C967D0", VA = "0x185C97FD0", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5C980B0", Offset = "0x5C968B0", VA = "0x185C980B0")]
	private void PHLHMPHCOEH(Dictionary<Guid, Guid> MGINCAGOOGM, HJLFCFBKPLK PNLLKLLAFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C98050", Offset = "0x5C96850", VA = "0x185C98050")]
	private void PHLHMPHCOEH(Dictionary<Guid, Guid> MGINCAGOOGM, GIGDHCIPBBG HMHNKFGODCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5C98690", Offset = "0x5C96E90", VA = "0x185C98690")]
	private void PHLHMPHCOEH(Dictionary<Guid, Guid> MGINCAGOOGM, HMHPGLNBJAM DCMFEJBFPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GFDNLAJDCAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class MKMOCCDAFPI : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C930", Offset = "0x5C9B130", VA = "0x185C9C930", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MKMOCCDAFPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class EJDOCLCEJDH : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5C96980", Offset = "0x5C95180", VA = "0x185C96980", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public EJDOCLCEJDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class JNCLEOCNDEG : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5C9B8E0", Offset = "0x5C9A0E0", VA = "0x185C9B8E0", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JNCLEOCNDEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class MAFOMBAJOHK : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C550", Offset = "0x5C9AD50", VA = "0x185C9C550", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MAFOMBAJOHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class PCIJBACPAGK : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DC20", Offset = "0x5C9C420", VA = "0x185C9DC20", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PCIJBACPAGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class KIMLIMJDBGF : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5C9BAC0", Offset = "0x5C9A2C0", VA = "0x185C9BAC0", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public KIMLIMJDBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class MKOJAHHDMEI : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C9D0", Offset = "0x5C9B1D0", VA = "0x185C9C9D0", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MKOJAHHDMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class DPEBBANFLJB : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5C963E0", Offset = "0x5C94BE0", VA = "0x185C963E0", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DPEBBANFLJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class MFEDOJMEADL : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C770", Offset = "0x5C9AF70", VA = "0x185C9C770", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MFEDOJMEADL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class NBCOILELGHN : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C9DA50", Offset = "0x5C9C250", VA = "0x185C9DA50", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NBCOILELGHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class ALLNBJFMBFN : KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly System.Random DCFNFJMCHPG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C95920", Offset = "0x5C94120", VA = "0x185C95920", Slot = "4")]
	public void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ALLNBJFMBFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ALMPFPLJGJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public EDLKHAAMHBP IFOEKNINMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public DAPCOGCKAGD JNHGJJILHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public Dictionary<int, int> EPJHCCNNDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Dictionary<Guid, Guid> MOLINLDEHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public IIJHMGIKGPD GJKNJDDEAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public bool GNKGFOJBFBA;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KCGIHGHOKCP
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFOHNGKPAKH(DHOCCCKFFCD CHPIFMHNEAF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MNGJMCCMGOB
{
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private static readonly KCGIHGHOKCP[] CBNHEJKCHFA;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5C9CAC0", Offset = "0x5C9B2C0", VA = "0x185C9CAC0")]
	public static void JDODNGBLDJI(KAGLGJLPIBC AELCABDCBDD, Dictionary<Guid, Guid> FMONHFDMDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D120", Offset = "0x5C9B920", VA = "0x185C9D120")]
	public static void NNOKDELHPPK(KAGLGJLPIBC? AELCABDCBDD, PGAMCPMNOPP ABBINEEKBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5C9CD50", Offset = "0x5C9B550", VA = "0x185C9CD50")]
	public static void KBPPEIIEIID(DHOCCCKFFCD CHPIFMHNEAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct DHOCCCKFFCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public EDLKHAAMHBP DCDCKMPPEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public KAGLGJLPIBC CDHDPJPOJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Dictionary<int, int> EPJHCCNNDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Dictionary<Guid, Guid> MOLINLDEHHD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C96330", Offset = "0x5C94B30", VA = "0x185C96330")]
	public Guid PBOBJKNOAAC(Guid OJPOLEONBAO)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface IIJHMGIKGPD
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BPNCIGMMAGF, [Out] Guid ABHGBGKANGC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FEEMIECDKBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private readonly HashSet<string> CEKMCCHBKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private readonly Dictionary<long, int> ADMLFFEIGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private readonly HashSet<Guid> JDKGADLBLKH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> EKEHEBAHIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> DEGDHCJMHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5C96B50", Offset = "0x5C95350", VA = "0x185C96B50")]
	public static FEEMIECDKBL JKDDLMMJJDC(OGBHGJIPJCE KAGMDCLCJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5C96AE0", Offset = "0x5C952E0", VA = "0x185C96AE0")]
	public static FEEMIECDKBL IOBFIOMHIOG(DOFEDNDHOFO JGKDOOCILMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C96E00", Offset = "0x5C95600", VA = "0x185C96E00")]
	public static FEEMIECDKBL OKEBBGFDNIH(IEnumerable<string> CEKMCCHBKLH, IDictionary<long, int> HKAKEJGALBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5C97EB0", Offset = "0x5C966B0", VA = "0x185C97EB0")]
	private FEEMIECDKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5C97D70", Offset = "0x5C96570", VA = "0x185C97D70")]
	private FEEMIECDKBL(IEnumerable<string> CEKMCCHBKLH, IDictionary<long, int> HKAKEJGALBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5C97810", Offset = "0x5C96010", VA = "0x185C97810")]
	private void PJEKNPFEFFI(OGBHGJIPJCE KAGMDCLCJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C97B80", Offset = "0x5C96380", VA = "0x185C97B80")]
	private void PJEKNPFEFFI(DOFEDNDHOFO JGKDOOCILMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C97370", Offset = "0x5C95B70", VA = "0x185C97370")]
	private void PJEKNPFEFFI(GBCIKKIPJHE? DIPDOFGLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5C97A10", Offset = "0x5C96210", VA = "0x185C97A10")]
	private void PJEKNPFEFFI(EAIADKNGDME? GIJABPPCKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5C96F80", Offset = "0x5C95780", VA = "0x185C96F80")]
	private void PJEKNPFEFFI(KAGLGJLPIBC? CDHDPJPOJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5C96D90", Offset = "0x5C95590", VA = "0x185C96D90")]
	private void MINADJKBEBF(string? JBIDMEOBOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5C96BC0", Offset = "0x5C953C0", VA = "0x185C96BC0")]
	private void KBKNEJNPHDK(JIBLCEOEPHI? CDODLOFHADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5C96CA0", Offset = "0x5C954A0", VA = "0x185C96CA0")]
	private void KBKNEJNPHDK(KOHKJBMKAAK? CDODLOFHADI)
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
