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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DD1F70", Offset = "0x5DD0B70", VA = "0x185DD1F70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79BE20", Offset = "0x79AA20", VA = "0x18079BE20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EPANNEBGHJA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> IFDFFHMHMLB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> PNEMMHBNJML;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string CBCKEJDAKIG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string PKEFJEKDLAA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string CGHCNJNDBIN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD200", Offset = "0x5DCBE00", VA = "0x185DCD200")]
	public static bool DOGLFKHBDPL(Guid BPNIEKNGPNA, int JJAABDLMADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCB80", Offset = "0x5DCB780", VA = "0x185DCCB80")]
	public static string DKEFGGACFLH(Guid OGCEPACDHOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[EMHMJPLHLDF]
public enum ALMHAIEMNOF
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
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FDACPEHIDFM
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly Guid DKHNDOMKKNN;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid GFCJILBFENL;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid FMOKKMMBPKC;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid ABGIJKAPAON;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid BIAMDJEGGFA;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid OPJDPGHHMEI;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid DFJKKGAFKNB;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid OFIOMNFIJEL;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid OPLCLKNDNEF;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid MFFGDAKDNJC;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid GKDMCOOGPNC;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid CAGNFEDAEAH;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid HMGOFNCIBGK;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid EKPLICJCIAP;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid CPMLNAGNPAG;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid FJNPONHLCDG;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid CLNJJDJNPEF;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid CLLEFPKILKI;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid ECDBNEFHLEI;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid JAEIJICMCNO;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid LOGCMKJBJIG;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid APIBELNNNEF;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid KKKKODNGKKB;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid OLBKLHJLIEF;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid MLDKCCKHFHL;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid IDCKPIAMIFK;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid CLILFBKLICI;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid DLBOCBJLKBE;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid LBJJAKDLELH;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid CFFDDMGFKMK;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid KBFNPDAFKNK;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid ICOPMHFMDGH;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid JHLHEIDGAKI;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid POFOPLMEPBK;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid MDJODCDPMEP;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid EHJECEABJDK;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid LNFIIGDKHNG;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid JHFICAOCKBK;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid LDJHDEJKAKA;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid BAAKPPLEPIB;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid HEFNOAJLLJM;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid ONHENFILBAG;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid HPKGLAOGDCH;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid IHJHAAJNICJ;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid DPAKLEIFCFP;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid LHHDLLHAHHA;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid MCNAFDKMFAH;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid COCGKMLBIGM;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid EPFGADGMCPJ;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid FBEFFIGDHHL;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid OJOMKNHJEJI;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid KHLKBADJPBI;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid DNFGHBALJBL;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid NHAGCPLDKKB;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid OBMAJKJIJJC;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid IJLKHABBHKN;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid OPGCNOEFEIM;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid MLIJIJJOOID;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid HJLGHOEHJMG;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid KJJFIOEEJFN;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid NHJHPEKHBOI;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid KHOEHKPFBDH;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid MCOIKNHMKFL;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid GMIMILGMFBN;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid PODKGBGOOPP;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid PLJHPCMBKCL;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid BALHCMKKFAM;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid GLAHLOBDGBA;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid EPOHGFHDPLH;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid BCIMMKBAPDD;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid AIEEOLNJDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid OPDPFKILAIE;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid EEKGCFJCNGA;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid OPBCBPLMLJI;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid AMFMEPMBHML;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid AFPACHPHCKM;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid JLGKCCECJDH;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid KKOCKKNLDHJ;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid AFKGIHEDCFP;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid LCDFICCEEEO;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid HDLINIPDLCA;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid BNJCGJMKNFE;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid NPOODAEFNCB;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid JMFHBFIMMGI;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid GOOKHJDMFJL;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid KOIPGPNKMEA;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid OLMDFOBNDBJ;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid GJEIPPHECPB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid AMCOBFKEOBK;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid BNBCANGMFOM;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid JMOABLELOAD;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid OKDEPOHOCEH;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid AJLADAIKGCD;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid GKEIDEGCABN;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid MFLGHPJFPKI;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid GCLDFNKAKOJ;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid FPKBDEJMCHP;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid EACKLAPODEE;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid BIJJGKJOANC;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid GOMNHFLJOLA;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid AOKFHCPMCNF;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid AKKIJCJONJA;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid BLLLNNJALHJ;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid ODLLFNGPJDL;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid EMGAFCCEIMK;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid HLOKENPCOCK;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid JKOLBAKAEIK;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid JJNPHKKKDAN;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid OOBHFEABJKP;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid LLHCKCJMCGJ;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid BNOEHLACMIG;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid MNDNEMDCCAL;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid OHHCMHJIEKN;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid DNCIKGGPDOF;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid IHHLNMFJKNB;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid NALIDHKJFMB;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid PLNMHMBFPHB;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid OHHNLGDJGJO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid MOIPKBFPEAO;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid DKIDKOINGGO;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid GGFMNBCBCBL;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid BDGDBMIELKM;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid GHJBMACMJJF;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid HLBDCINIDHF;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid BIEEJAHKLLK;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid KMKLMDAHLBD;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KFCKOMMKGDK;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid HOFHNMPGBHH;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid FEPCOJLOMDA;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid OJBAECMJEPD;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid GLGNPJIAGPM;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid IPJAJJFPBBA;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid MDNNKMGFAHD;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid AGKILKLBAJF;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid NEABPLNGGKD;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid BHGFNMIIHKH;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid GGCNGOJDLNH;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid CHEJNBCFGOF;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid GKGHNOIPEIA;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid FMAPAHIOKOJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid ELDKLBJJAOD;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid NJCCANECLAI;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid AJKBGMNKMFE;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid MDPBKCHGHNA;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid EHENOHLGINA;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid CLKIBOIIPLM;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid LGHNAACHFMK;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid AJHMHLCBPNG;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid HONLCOGEGDI;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid COBPCFLNOBG;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid JNDLMCOFHJI;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid PDJGAOLGONE;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid FAGAJMKHPIO;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid PGMFEBBNBCC;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid MNDMIHLBJCD;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid GPJIFPBHDGB;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid LFLONIHKGMK;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid OOEKMJLNOKB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid OEGNPCCFDNC;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid PDPOCLJGPON;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid BNPLLECGOMK;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid GJKDOOKDJHD;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid BGBOGGJMLFO;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid HHDNAPFJIAN;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid LGGMLEJNJDM;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid OFPHJPKMEGI;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid NFNHALKJBIN;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid AJLNLLNCBDB;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid OFBOGAPBJPJ;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid IDEFAKELGEP;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid ENBHKOBBLFB;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid OMOHBANLIEH;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid AGGKMCKEKNL;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid KKLJHJCDFAB;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid CMOFDIGADHD;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid EFMKHIAEBLF;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid EFGOEDMMBAA;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid CEPCECOAOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid JGGMFOGOCEO;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid BIFEAAMNDHP;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid MECFHKOHBDC;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid CPFIHBCNPDE;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid OCNOGAHCOPC;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid GMFHBPNKLIM;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid MFJBNOHLBCG;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid EKHDADBELEK;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid OKHADAGNICJ;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid OKHHMMAHNOF;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid KFBCFHJPDPI;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid NIAGCPBEOFK;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid LLNMIGMAEPM;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid AFCIOJKOHOA;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid IIFICFJJKMA;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid CJFFHJOPOMG;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid OAEGEEBILFL;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid KKKEELIGCKB;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid FMLCIJGLKDG;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid KEDCCCGIPPD;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid PBDGGCAPHBH;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid BCJLNJCOKFH;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid CAFOKBAILAB;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JBGFKHEMFMG;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid HJAJCFCAEHP;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid PDNKKFJKCOK;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid EBIKPACDJJL;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid EDEDIOMOJEN;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid FBKJKGPBCLB;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid KKODPCGCNCN;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid JGBFBPPPAGN;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid DNFAOGCKHLD;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid AACKGHMPNDO;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid IKMKHDCCPBF;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid EBBCBLPGEAI;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid LECKGMBHJME;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MFALKHKGIEA;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid DKAGGELGCLE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid AIFFJGDAGGA;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid OKPNMNDBBMO;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid IGPFINICKDO;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid EHKHJMEFDGI;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid JHONGKELKLP;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid PPEKEKHCDMD;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid NAKOPOFFCON;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid NDLBOJPKHGI;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid NNKAEIJIOIO;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid GGNIIDCCKML;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid DJGLBELABMK;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid CEOGCANGLEH;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid IJPICPHFLLI;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid LLEFIKPLHDE;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid NOHAOKGNHMO;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid IMJHDNHMLGF;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid DMDNFAKIHEO;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid ANNOEHLBJGP;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid DBDOLDJDHEL;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid OLFOLCPINLG;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid GNEGCMNIPOJ;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid FDOCFMNLNCB;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid BFEBAGIILCF;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid PGJMDNEKLHF;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid KHEAGHBKEPE;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid EMNDBPMCILC;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid LFOFKBCOPJI;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid MEHDCMDGBFL;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid HAMGBNFGKPC;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid KELFFACNPEK;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid CGFLOJNMGEG;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid LFAJOLDOMBM;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid EIMNIILGOBJ;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid DFPHPNOICKC;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid JICDIKDOBCO;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid EIFBBJBFGOJ;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid PHHCILGGNNI;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid JKFLIDEEMKE;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid JKFECOADMHD;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid MKBOBNOFAHE;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid CKIKOGIGIFO;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid NAJDCCEKHFI;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid JKGMBNPGPAF;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid NHGNKKCOFME;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid HNIGGOKKKNK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid JGINLOOJKDE;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid HCGGANBADGI;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid PBLBNEINHDJ;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid ILJEACIHPGE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid KKCIALMNIDF;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid FJCFHMGNIED;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid IECDALHJPKF;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid FIOMFLKAJJP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid KILBBJCKGIG;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid EOLPAMLPOAM;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid ACOJNPFMBDL;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid EALCPGDHBIN;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid JGFENLDOCLF;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid KBMKANEMJDJ;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid FAAPGKIGJIN;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid DGCELEBNPPH;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid PPAHGHLNFDE;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid AIECFKMEMDH;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid DLCAGFIOBBE;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid NGFIDNCIBKG;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid FBOKDLMPMEF;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid IDKFCGHJKGK;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid IKFGBMEBLCP;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid CBGCNIDGFFD;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid OKMDKDBIFBE;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid IDPMMGJOMEM;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid LCNFGFHIHOM;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid DBMCOFDLPPB;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid OGNBAHKBMNL;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid JOGEKODJEMI;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid FCKHNGPALDK;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid BKEBPOIDEAI;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid AMKCFDHJNDH;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid JPJAHOIOCLN;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid HFNHMBMHKLD;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid APJALFDIGPJ;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid BCIFFENMHIA;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid ONCEIKIMKMF;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid JGEOAKDJEHE;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid EDJDGCDBIME;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid BNCIENEEENA;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid NFBIKFIKGCO;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid EOAOMEEHHMC;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid CFNMDKGLFEF;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid HGPMNADCBLM;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid KHAEHKKEADA;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid MHBCFKHODGO;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid BBMEHIMKEBB;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid JFGGOBAHIGB;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid PKLHDNBAGNK;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid OOCDIIFENBH;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid FBGIAOBPEIP;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid JEICOIHCJAD;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid AGIOMMBMECK;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid EILGLMPJELH;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid CHBAGOKGJJK;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid FLBLDMAKGIL;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid DPECFDEHJMJ;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid JBPFMBJOFJO;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid CBEMJGBLFID;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid ICHONHLCPAE;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid AFLLPJMOLOM;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid MCIBPNGGLNG;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid JGOBOFIIEOH;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid LCHIBFHHOFI;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid EALIMGKIANJ;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid FJLENPCEKOB;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid HFBIJJODCMB;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid KPJCPBCMOHD;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid OHCLGDDDPBG;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid GBMJMHBCLAB;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid KHHHNAFINGA;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid OAFMNEJFJBP;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid MFFHDKNBIJJ;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid NKDBMNOCNEE;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid KELNDECFLAG;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid PGAJDPOJALH;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid FKLDFFJPKLO;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid OPKAFIPLPEH;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid IJNGBNAJMHL;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid LDMJMFPGIMO;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid EFPDGNKBGFN;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid FDIBGELCEKC;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid EHNPGMOJPLL;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid HLMEFFIOJNK;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid NCILHHHECIE;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid OLEKKCKJLIN;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid NIGKGJJOCKK;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid BOHGFIEBFPN;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid NCJMPAJAAIC;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid LDKKCHCONKA;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid PAOONGAJKAK;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid PCFHJDPNJAN;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid BKGJFNIFKLN;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid OJDHCPFIOJJ;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid DGELJOOMGGA;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid DONFKPEBLIM;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid NAPKILJGGAB;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid HEOENGBDNBF;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid DNBOPJMDDBH;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid OKFPHPHBGND;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid EJMHMMHEHJJ;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid AIBPHBBAIPC;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HINPPOABPHO;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid AMBKKACBHKI;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid LDINHKJKJLA;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid HEINAAGONKG;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JHOECMEEEEF;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid MAFBEABLEPB;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid NONDMCHMDMC;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BMNNCHNEACK;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid IEDMPHCNPFL;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid IABPOBFGOPG;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid DMJHHILOMKD;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid PPJBHBKBGJP;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid MECMBJBEMPC;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid LHIBHBMDGIF;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid CNHJHDJGBGC;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid DIEINILMFON;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid GILGEDKMMLM;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid CHDHEGMBCEE;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid JAHBJPBIOHJ;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid AGPNMBBLHEL;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid NHMAPJKHDPP;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid OAJNDOFEHGD;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid ODJAEMIDIOO;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid CCOHOMEONFH;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid KIKBGGFGKMF;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid KEPPJFJOAHO;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid ADMAEJDJEFP;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid MGNPEINMKOC;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid IIAMOLECNHM;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid BFPHNOMCFKH;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid MIBBOHEGGEM;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid NBBKFLPBFPO;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FAIANMPIBFL;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid IAAFLBCDMEG;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid MDFINIDCGON;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid JMOFMPCJBDP;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid LILDDKEKNJI;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid FGPKNDAKMGL;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid FCBNCHLCMKE;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid EEOCHBBANHM;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid EFIOMIKMJMN;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid JOMHCFECAGM;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid IMFEJOMIFJF;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid DKPFCHMKEEP;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid PKLBJGLJBDH;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid BCGMBIGGLPE;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid AKCCINNHLGI;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid NBFGGIFMKEC;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid LKDJBCFCMGF;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid IPMKHLBMPBO;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid MBLODBLCHOI;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid GAFFAFDEGJE;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid KAFBALPPLNI;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid AEOOCOGMMNH;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid JNGNHEMOJHG;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid FNFFNNBHICC;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid BKGOBGFAOHJ;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid OKBGFGNNKOA;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid IAMFLBLAMPD;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid GNOHMHGLAOP;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid LLGMMCAODKK;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid EJLHLOCCNMI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid GMCABCNBJPJ;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid MPGNFKDHHHM;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid JBJECFFOHNO;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid CNPMJBIAEPD;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid BCBDGDILLHP;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid KKHMMKFHOOE;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid IKPKLKCDDFO;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid LFFPEAMGIED;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid CFAFOMFEDAK;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid CPKOMEFJECI;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid JEBAMBOFMJK;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid DNHILLMAPMA;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid OJNBCPFEJML;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid DEAJCPFHMPD;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid DAIIBOACMOM;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid CDPPPAEDKLF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid IAEEMFMKOIN;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid EJOIHEFIABF;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid HBKBADECNED;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid GBPHHBEHABN;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid CFHGLAAEKHJ;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid LAMLJJGEIBL;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid LHFCFMMPOMP;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid IPJKNHKIGJO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid KCHEFLCPKGB;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid DKAGHILMCBM;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid IEHNMFHKGDL;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid CJMCMCGAAFD;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid AEOPIEBIOBB;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid OHIGBFIFFOK;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid OEBDGFHMPMG;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid MMOFJOEKOEH;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid IJOBFHGKPJL;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid BOINCJEBGDI;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid DHNFDNFHCEO;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid KLEGENKMGAH;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid LNGLMEHKBLL;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid AEDHFKPBGCL;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GPCFEGONJIC;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid FNHJIKHFHDC;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid GPKENOKIAOK;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid NLGEGIPOGMG;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid MDBMFNIFFIB;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid EFNIJBFLDJA;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid LECEIMCHKEC;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid IOEHBGECDDN;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid IIBICOJKMCM;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid NNLHDLGNBFE;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid CAPIEIADJIN;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid CNLLJEFHFML;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DLCLKHKCEEL;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid MKAGHLOJMPO;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid LOEBGPBCIMI;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid GNGLCLJBAMB;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid ILJPJHIJIMF;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid OBOMDCPAPCK;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid BCEPFBNLICI;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid BDIOILHOEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid GCJEIBHJGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid DODCFOOKBAH;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid EICJELMHNKL;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid EINAKEMOKEN;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid COCNHHHEBIG;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid CJGLNGBNDCO;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid HLCEOPFICIG;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid IDDOJBMABNO;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid NNMFANINLCC;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid JNNKFCFCMIA;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid FENHNAIFIIP;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid CDBLEJABBCB;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid DDPLBABBFKK;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid GJNBFBJACPL;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid OPFBIMLFDDC;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid BGHINDFBGDB;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid MNKJGPCJAPL;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid FHAAMLEFIFI;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid HAKADFBIKJO;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid DFMFFDENFHB;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid KMHLHKHNKOK;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid GEODMIOEFPD;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid OGCFAAOMNNA;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid LBOAPBJEHLC;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid OCBLNOIOKBK;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid PEAIDKPMING;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid GAADFIPJCEP;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid IIDOFLJGNJE;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid FDPMOKPODNL;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid EDBIOAAJBKJ;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid EDHANJFAGPB;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid PGJIGFPIMHK;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid JEPHHGBFINF;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid JMCJCCCIOBJ;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid LGFPCBGEFAN;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid JLJBICHNICH;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid ONIMABIKOHJ;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid GNPHIIIPEHD;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid KPJFKNDLBNE;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid JDFEOAEEBCF;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid GJHCFOAPJIP;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid OCBKOPAIGHJ;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid NAGGHELINGD;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid IJNACCFGOND;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid ONHEJOOOGEP;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid MLHKJAMDPMA;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid IHOPDBECAOI;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid KBELPLJECMH;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid NMFMKAIHPBI;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid AAJIDNPEBNF;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid DNKCJAIMFPD;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid DLNECAAMGMG;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid FICJBMGLMHI;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid GDMKEFEBFEP;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid PGKCICNNAIJ;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid APLLDDBIOHM;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid LMCPKHAMPJI;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid MNPFCJKDNBO;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid GPFAOMCICFP;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid ACHDINLKALL;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid EDCIHJFCOJI;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid IJOEHGPIAJB;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid HMABPLMOBIB;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid IOECPKDNBJH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid IOGEGACMHIP;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid LGNNJINLPHI;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid KEGFEPLLDNB;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FKCIIOAPCPE;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid HIDIHJHBLDB;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid PIJJKAOINMC;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid HCDBJDKCNDN;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid BBNEDKKOPOH;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid FINBLCGOPNM;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid BPIIMJJKJPP;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid JFLLFABLKON;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid KOCPDJIFPNI;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid FDANGCGMFEP;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid KJLEMFPAAKH;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid JNOBFHBOJFN;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid FPJGNGALJEG;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid BFDHHMJLJFH;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid BDAJMPIAACC;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid NJCNOGOLJNM;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid MGECPDEPIIC;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid JGOFKAGPIBI;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid INHLELFMPDJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid GEDAEPAKILI;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid FEBFHKPPHHN;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid DMPEBKPMKPG;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid JNPMNGJDFGB;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid JGBMEFCIPDP;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid BDICKIAEJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid EFNNIFFLMAE;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid IGOBFDEKCCJ;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid GJCFKJBOOAB;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid PBNONNDENAL;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid IPNBMEFJCLB;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid AIACGLBGIJD;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid CGMHAKKIBIG;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid PHPEMLIGDHH;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private static readonly Dictionary<Guid, ALMHAIEMNOF> AKMCMMJNFCP;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private static readonly Dictionary<ALMHAIEMNOF, Guid> BPDGKLJDNLI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, ALMHAIEMNOF> GNEJHNFLEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE4A0", Offset = "0x5DCD0A0", VA = "0x185DCE4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<ALMHAIEMNOF, Guid> CKLPCGHJPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE440", Offset = "0x5DCD040", VA = "0x185DCE440")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CGBNEJNJFCM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC4D0", Offset = "0x5DCB0D0", VA = "0x185DCC4D0")]
	public static bool IKHNJKHJAHA(MMIOCMONAKO MFCBEHKMHPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC500", Offset = "0x5DCB100", VA = "0x185DCC500")]
	private static bool IKHNJKHJAHA(BOAKFLDAEJA EOEGOCMAKNH, MMIOCMONAKO MFCBEHKMHPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ONLCJMDFPCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public readonly INIMOABEJJP OOJPFHFGEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public readonly IEnumerable<CACNBOICLKE> IIFLAMKKLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly IReadOnlyList<CACNBOICLKE> FJHHIIBGFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly LHFCDFCDHLN<GPEIOPOOANP> DNHPFFCNDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<EIBLEIONKKB<KACLKPLDFKI>> LGHLOPBANBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly ByteString PAAPDONPDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly KDKNIAINLHH KKMCJHLBLOD;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5150", Offset = "0x5DD3D50", VA = "0x185DD5150")]
	public ONLCJMDFPCJ(INIMOABEJJP HDNHAJBLGDE, IEnumerable<CACNBOICLKE> EEIOFMIPGON, IReadOnlyList<CACNBOICLKE> LIJJLHNOMNE, LHFCDFCDHLN<GPEIOPOOANP> DIDHAIOGIDC, IReadOnlyList<EIBLEIONKKB<KACLKPLDFKI>> DPLGHNMDNBD, ByteString INPPHOBLMBM, KDKNIAINLHH ANJPONEGGGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FDJHPONJHPB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(GLLAAHOOHKH IGJLGPELHOJ, [Out] Dictionary<int, int> EKJAOOGPBNE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(FACDBLKJAKK HHIHKKBCBKC, GHLHPHKDLHP IHBGBIJLFGF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KALDFPOPGCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly Guid EENMHAEIFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly Dictionary<Guid, Guid> ALBBABOHKHB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> DAEDFCGPLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x33162E0", Offset = "0x3314EE0", VA = "0x1833162E0")]
	private KALDFPOPGCE([In] Guid DLMDIPBDAKM, Dictionary<Guid, Guid> MOPKMHNBGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DD18F0", Offset = "0x5DD04F0", VA = "0x185DD18F0")]
	public static KALDFPOPGCE KLEBDFMCBEE(IReadOnlyDictionary<Guid, Guid> CJEIPGLPILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1900", Offset = "0x5DD0500", VA = "0x185DD1900")]
	public static KALDFPOPGCE LLLLLDFNNFJ(IEnumerable<KeyValuePair<Guid, Guid>> CJEIPGLPILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1CB0", Offset = "0x5DD08B0", VA = "0x185DD1CB0")]
	private static Dictionary<Guid, Guid> OKFKMOCCHGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DD17E0", Offset = "0x5DD03E0", VA = "0x185DD17E0")]
	public Guid GFLHGOCEBCM([In] Guid OGCEPACDHOE, bool NPANAMGABEA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1770", Offset = "0x5DD0370", VA = "0x185DD1770")]
	public bool BEBKAIBNOPJ([In] Guid HLINMGJJNHD, [Out] Guid AEAHJKHDKFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MFDDJCLPCFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CGCCNAIGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFKFFNFOIMD(ByteString KCGANELMDLB, KALDFPOPGCE MGFNLNANPDG, [In] MHCAHIBICII COLKGNBJMOD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ACEHOBLMKEA
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
public sealed class PIDILKBIDEG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> MKPLDMOCIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> LMAGGHNJIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774660", VA = "0x180775A60")]
	public PIDILKBIDEG(IReadOnlyDictionary<Guid, Guid> NJDGBAGAMPD, IReadOnlyDictionary<Guid, Guid> ACOFNAGJPDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OCKMAFELCIO
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2380", Offset = "0x5DD0F80", VA = "0x185DD2380")]
	public static OBIGKLDPJEC CPJBKEOPMKO([In] ONLCJMDFPCJ HJJECIPOAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DD49A0", Offset = "0x5DD35A0", VA = "0x185DD49A0")]
	private static void PMGHJENLFBJ(OBIGKLDPJEC GEMDIOKCEDH, [In] ONLCJMDFPCJ LOKNJJMPBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2780", Offset = "0x5DD1380", VA = "0x185DD2780")]
	public static bool FAAKIHLIICE(OBIGKLDPJEC GEMDIOKCEDH, PLBOCEFKPMC BIAEEIGHIOM, [Out] PIDILKBIDEG? MOPKMHNBGNN, [Out] string? GNLAGDDNMDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DD24F0", Offset = "0x5DD10F0", VA = "0x185DD24F0")]
	private static void EHDINOLBIBO(OBIGKLDPJEC GEMDIOKCEDH, KALDFPOPGCE? MGALAPBIHIL, PLBOCEFKPMC BIAEEIGHIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3DE0", Offset = "0x5DD29E0", VA = "0x185DD3DE0")]
	private static void INGCNKLOIDF(OBIGKLDPJEC GEMDIOKCEDH, PLBOCEFKPMC BIAEEIGHIOM, IReadOnlyCollection<ByteString>? ODMFKONLBJH, IReadOnlyCollection<ByteString>? FHJAICMKEJC, IReadOnlyCollection<ByteString>? KACKHKIKPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3E50", Offset = "0x5DD2A50", VA = "0x185DD3E50")]
	private static bool LANPEJMHBDK(OBIGKLDPJEC GEMDIOKCEDH, FACDBLKJAKK HHIHKKBCBKC, PLBOCEFKPMC BIAEEIGHIOM, [Out] string GNLAGDDNMDN, [Out] Dictionary<int, int> EKJAOOGPBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3B00", Offset = "0x5DD2700", VA = "0x185DD3B00")]
	private static Dictionary<Guid, BOAKFLDAEJA> GALMPMFKMHJ(OBIGKLDPJEC GEMDIOKCEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3A70", Offset = "0x5DD2670", VA = "0x185DD3A70")]
	private static void FLEBPBNHAFE(bool MBGOLHIEBHE, CACNBOICLKE PGJNPMOPLKE, Dictionary<Guid, Guid> KNGIJMMAMLP, KALDFPOPGCE AOIDDOIMCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DD20F0", Offset = "0x5DD0CF0", VA = "0x185DD20F0")]
	private static void AHLMEMBCNJE(CACNBOICLKE PGJNPMOPLKE, Guid NCGEGODEFOE, FAAMINBCHFC? IJMLALJNAMA, Dictionary<Guid, BOAKFLDAEJA> OCAEAPOAJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DD44F0", Offset = "0x5DD30F0", VA = "0x185DD44F0")]
	private static void OGDABKNCMAF(IEnumerable<CACNBOICLKE> EAPCCPHNECC, IReadOnlyCollection<ByteString> ODMFKONLBJH, IReadOnlyCollection<ByteString> FHJAICMKEJC, IReadOnlyCollection<ByteString> KACKHKIKPLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PLBOCEFKPMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public bool MBGOLHIEBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public KDKNIAINLHH ANJPONEGGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public FAAMINBCHFC? IJMLALJNAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public FAAMINBCHFC? KFHNFIPEBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public INIMOABEJJP LNIPFKOIJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public ACEHOBLMKEA PIELKAONPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public FDJHPONJHPB PGIMLFCMOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public MFDDJCLPCFH PFOCALCDGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public EIBLEIONKKB<GPEIOPOOANP> PDCILCJIAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public IOMJFIGGDLJ GNAFFKCNJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public List<CACNBOICLKE> EIHCJLMCAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Dictionary<string, object> ALJNCNKGALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public FNBHCGBOODA GGFJDJKHMCD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JJKALEHFPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD51E0", Offset = "0x5DD3DE0", VA = "0x185DD51E0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FAAMINBCHFC
{
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private const float MGFEJNBCLKD = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Vector3 CFCLFCDKKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public Quaternion HFKFMHAMLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public float JIFOIDNONIC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 OIAMLDCIIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDC80", Offset = "0x5DCC880", VA = "0x185DCDC80")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MHCAHIBICII JKDEPJICBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDBD0", Offset = "0x5DCC7D0", VA = "0x185DCDBD0")]
		get
		{
			return default(MHCAHIBICII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8EE780", Offset = "0x8ED380", VA = "0x1808EE780")]
	public FAAMINBCHFC(Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE, float JIFOIDNONIC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE1C0", Offset = "0x5DCCDC0", VA = "0x185DCE1C0")]
	public static FAAMINBCHFC KIPHKFGHAJN(FAAMINBCHFC HHNAEDAPOHF, FAAMINBCHFC MHDMGPEPEDN)
	{
		return default(FAAMINBCHFC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE1A0", Offset = "0x5DCCDA0", VA = "0x185DCE1A0")]
	public static FAAMINBCHFC JLFJLFEACJM((Vector3, Quaternion, float) IGJLGPELHOJ)
	{
		return default(FAAMINBCHFC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE040", Offset = "0x5DCCC40", VA = "0x185DCE040")]
	public static FAAMINBCHFC JLFJLFEACJM(Matrix4x4 KCGLKGHEFJP)
	{
		return default(FAAMINBCHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDD90", Offset = "0x5DCC990", VA = "0x185DCDD90")]
	public FAAMINBCHFC CCFFMHMKCDE(Matrix4x4 CAHHGMHAMLP)
	{
		return default(FAAMINBCHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDC10", Offset = "0x5DCC810", VA = "0x185DCDC10")]
	public static FAAMINBCHFC BHDFIJECPCH(Vector3 CFCLFCDKKPD)
	{
		return default(FAAMINBCHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDFB0", Offset = "0x5DCCBB0", VA = "0x185DCDFB0")]
	public readonly NLFMFEEBBCD IONEELFNEFA()
	{
		return default(NLFMFEEBBCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FNMAKHDOPGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE500", Offset = "0x5DCD100", VA = "0x185DCE500")]
	public static FAAMINBCHFC BMJHCKCDCHH([In] this NLFMFEEBBCD HHHLENOMLMP)
	{
		return default(FAAMINBCHFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GGGOHKKLBMP : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFE80", Offset = "0x5DCEA80", VA = "0x185DCFE80", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF8A0", Offset = "0x5DCE4A0", VA = "0x185DCF8A0")]
	private void HMNOLMKMKPB(Dictionary<Guid, Guid> FOEKNMHJPDO, LJIINGPGGHB MCOOOGGNLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF840", Offset = "0x5DCE440", VA = "0x185DCF840")]
	private void HMNOLMKMKPB(Dictionary<Guid, Guid> FOEKNMHJPDO, OHJIGEGLPPB LEKIKOILPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF5C0", Offset = "0x5DCE1C0", VA = "0x185DCF5C0")]
	private void HMNOLMKMKPB(Dictionary<Guid, Guid> FOEKNMHJPDO, HEONHGONJAJ BCKHPAAIMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public GGGOHKKLBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GDFOOENLOAH : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE590", Offset = "0x5DCD190", VA = "0x185DCE590", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public GDFOOENLOAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class KGBODJLAHCE : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1D60", Offset = "0x5DD0960", VA = "0x185DD1D60", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public KGBODJLAHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class OGCPIOMMGCJ : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5000", Offset = "0x5DD3C00", VA = "0x185DD5000", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public OGCPIOMMGCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class AFCPOLHDJNO : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC080", Offset = "0x5DCAC80", VA = "0x185DCC080", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public AFCPOLHDJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class CCJLPJKCMIM : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC390", Offset = "0x5DCAF90", VA = "0x185DCC390", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CCJLPJKCMIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class EFALJCLIODG : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC8B0", Offset = "0x5DCB4B0", VA = "0x185DCC8B0", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public EFALJCLIODG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class AIACFKCKIAM : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC2A0", Offset = "0x5DCAEA0", VA = "0x185DCC2A0", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public AIACFKCKIAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class HDGGBMLGAKG : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFF00", Offset = "0x5DCEB00", VA = "0x185DCFF00", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public HDGGBMLGAKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class JHKEPIFAEGJ : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD15B0", Offset = "0x5DD01B0", VA = "0x185DD15B0", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public JHKEPIFAEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class OAFMFGENAJH : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1FF0", Offset = "0x5DD0BF0", VA = "0x185DD1FF0", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public OAFMFGENAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class EMCGKAACACI : OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly System.Random KAICLIIFGJB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCA50", Offset = "0x5DCB650", VA = "0x185DCCA50", Slot = "4")]
	public void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public EMCGKAACACI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MMIOCMONAKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public FACDBLKJAKK DLBBNPMBKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public CHMNIBKOMKA HIEIMGGJBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public Dictionary<int, int> HFLDHAKEBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public Dictionary<Guid, Guid> CGAKMALEDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public FNBHCGBOODA GGFJDJKHMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public bool BIJHKBKHNBN;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OOKPDKKOKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIDMABHEBDC(MHHDDJALGMA ECNMNOCBOON);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GFCOAJGJNHK
{
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private static readonly OOKPDKKOKJG[] LKCOLBGLGEO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE990", Offset = "0x5DCD590", VA = "0x185DCE990")]
	public static void DHCDLCLAAOG(CACNBOICLKE IGJLGPELHOJ, Dictionary<Guid, Guid> GCHPCIPMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE630", Offset = "0x5DCD230", VA = "0x185DCE630")]
	public static void CKLEJGHDFML(CACNBOICLKE? IGJLGPELHOJ, KALDFPOPGCE AOIDDOIMCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEC20", Offset = "0x5DCD820", VA = "0x185DCEC20")]
	public static void IKHNJKHJAHA(MHHDDJALGMA ECNMNOCBOON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct MHHDDJALGMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public FACDBLKJAKK KOBCNPIHOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public CACNBOICLKE PGJNPMOPLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public Dictionary<int, int> HFLDHAKEBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public Dictionary<Guid, Guid> CGAKMALEDKF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1EC0", Offset = "0x5DD0AC0", VA = "0x185DD1EC0")]
	public Guid KFHJDMNBMBF(Guid OGCEPACDHOE)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FNBHCGBOODA
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int DCPKNAAMAOM, [Out] Guid PFHBDKLMFPO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IHOICHPOIFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private readonly HashSet<string> DHPIGAICAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private readonly Dictionary<long, int> DNCGJPLJEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private readonly HashSet<Guid> CIALKDBMLCB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> BCHPFAIHBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> IEJANMNBGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD12E0", Offset = "0x5DCFEE0", VA = "0x185DD12E0")]
	public static IHOICHPOIFG PDGEOHEJGHN(PGCGNLKABHG EMCADPHEHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0290", Offset = "0x5DCEE90", VA = "0x185DD0290")]
	public static IHOICHPOIFG EHGKADDOBMN(OBIGKLDPJEC JFKCMLHIMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0300", Offset = "0x5DCEF00", VA = "0x185DD0300")]
	public static IHOICHPOIFG FCPEKJOOAAM(IEnumerable<string> DHPIGAICAIM, IDictionary<long, int> LOIBEPKFGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1490", Offset = "0x5DD0090", VA = "0x185DD1490")]
	private IHOICHPOIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1350", Offset = "0x5DCFF50", VA = "0x185DD1350")]
	private IHOICHPOIFG(IEnumerable<string> DHPIGAICAIM, IDictionary<long, int> LOIBEPKFGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DD10E0", Offset = "0x5DCFCE0", VA = "0x185DD10E0")]
	private void MCEPLECFNJI(PGCGNLKABHG EMCADPHEHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0EF0", Offset = "0x5DCFAF0", VA = "0x185DD0EF0")]
	private void MCEPLECFNJI(OBIGKLDPJEC JFKCMLHIMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0660", Offset = "0x5DCF260", VA = "0x185DD0660")]
	private void MCEPLECFNJI(OFBKOLABKAC? NMHGPHBIAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DD04F0", Offset = "0x5DCF0F0", VA = "0x185DD04F0")]
	private void MCEPLECFNJI(OBCAEPHLMCI? NIICEONAONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0B00", Offset = "0x5DCF700", VA = "0x185DD0B00")]
	private void MCEPLECFNJI(CACNBOICLKE? PGJNPMOPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0480", Offset = "0x5DCF080", VA = "0x185DD0480")]
	private void JFHFGNHGDBF(string? DILAEIJIPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DD01B0", Offset = "0x5DCEDB0", VA = "0x185DD01B0")]
	private void ABOOICBNJLC(IIHLFAACELP? NCIHJDIOHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DD00C0", Offset = "0x5DCECC0", VA = "0x185DD00C0")]
	private void ABOOICBNJLC(AFPFMAGPMGO? NCIHJDIOHFD)
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
