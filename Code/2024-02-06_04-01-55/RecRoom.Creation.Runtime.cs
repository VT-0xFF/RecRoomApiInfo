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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x60481C0", Offset = "0x60475C0", VA = "0x1860481C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OHIODCJNJOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> MPBPAEHLLOK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> FOJIJDDOKFD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string PDCDFNOJNHF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string KHCNPGLGLEN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string NHDFBBMBPOH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60488C0", Offset = "0x6047CC0", VA = "0x1860488C0")]
	public static bool LPCEILEOPJL(Guid IDEFBDLOFAN, int FAOPANECBII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6048240", Offset = "0x6047640", VA = "0x186048240")]
	public static string GGMAMFICHID(Guid LHLNCEHJAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MKHAKDCHCFO]
public enum ONLCIIDNGBH
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
public static class BLPCJHANOJL
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid BNLFLLDFHGG;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid MFPGEPFAOMB;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid KLAIHPJJPMN;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid BBCFKAMDNKC;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid POGHMDDMGNK;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid BBHCBFLFFIE;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid KJONKKNCIOK;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid BECKLOAACGN;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid KJPCNPDDONM;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid KNLPBBBADJG;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid AMCCDCKKPBJ;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid LABKLPDHIHP;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid IBBPJMJFIIK;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid IJBAABLKLJH;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid BPFBMBGMGHN;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid NIOLPPEINMM;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid LBIIBHCMNDF;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid BLJCCBBNEKK;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid BHPJHMAAOBP;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid EOLIDAJKPMM;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid HIHEPNAEDMN;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid OLPPOCCMMEM;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid AHIENNIKIOK;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid JJBOODAMEFH;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid NDLEAIKMPDF;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid GKOLMHLAIFM;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid APBHJPFMICE;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid PLJGCCDGIKD;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid DBCPDHEKJLC;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid DOJCAAKBADA;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid LEMHLKCCEGP;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid JEOJMCEAGIB;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid BLIDFJFGKCG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid MJGCCEAIPEF;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid FMJNBBHNCAP;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid KCGNLHOIFFJ;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid GNDKGAPAKKH;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid BAIDAFMLGJI;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid LKICOEKHCOH;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid MLLOKPEKCMK;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid JEEPMBJLAKA;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid PFKFLFCLPDK;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid ABBKHCEEGLE;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid HPINFOCPACH;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid JGECFHABGMB;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid OGIAIKNNMAA;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid JFJNKLAMGDB;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid BAOBKGHLKIE;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid OPBJGIPIPIG;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid HNOAJBMGPJN;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid DCGGGNAOIFO;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid NOPMBKPNNJE;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid EKLNHDJEHAC;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid IKKEIGBAOKN;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid BMDPHEEMFBA;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid OKHIAKGLIEG;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid EHPGBEPGJAH;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid CGNGJFOOJLB;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid EOMANOKINCI;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid GMPKJOAJHHE;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid IPDJAKCGDHN;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid INPIAEIFKLG;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid EAEIHLHINLM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid KHEIFADDMHE;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid JEICPEILMAO;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid JINJGKCFFHB;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid ACAEJPENKGC;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid AJDGGFICLGD;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid LNCELKAIBLE;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid CAMFJOGFKIP;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid HDFAFEDMDCN;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid HIHOFEOFPEO;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid OKKHNDHFKCP;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid DAPKNPFNOAA;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid LNLOACMACIG;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid EMBDCJDGJMG;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid EBAFOLEIDOK;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid PDKJGNOHBIH;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid NAKCOEFLINI;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid KOCLMHODMFC;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid KECBMNDNPDK;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid DFGKDLFFAEK;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid NFDFEDPNPNP;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid GPALPBAOEGN;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid HBHIOEMIAGA;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid EPBMKJAGCEJ;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid NPHLALIFDJB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid ANAPBPAKGKL;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid JFFBCLOKHGD;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid GJLDGEKNFPJ;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid MNHELMODOND;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid DFBICLEAOOM;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid FAAPIJLDPIL;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid MCLOFMJIADM;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid PDNLMGGIFLD;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid DMIFFLLOJIE;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid BLEEPENOHCJ;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid CGLBHNMDBPI;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid DJCEPNEGBCD;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid ENBOGCPEPLC;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid LHNCCCFJHMG;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid HOPHCELKNEH;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CGFBJDKOJEP;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid GIANCPJBLJP;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid PIKMHGLKABL;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid HMPEFIIGMGM;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid LHBONKKEPNH;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid JJONHFOOPCC;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid LBNCHAOGDEN;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid KOFGEELNPIP;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EALGAJKAHDJ;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid HNAPIDBLMGN;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid KEMIJIOOEDN;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid BEKHEDEAMHK;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid BLCOGCDAPAK;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid INLKBAIALDO;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid LNCDKCNNPJG;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid JNGACPFNMGL;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid HPLBMAGFPLG;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid GPGNEMCCBBM;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid HBPLDIOOIEB;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid KDJNCEMAHBA;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid HLPKMEADMKA;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid BMLNEAIGAKO;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid HLPFDPAEGCC;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid MFMDMOELFKA;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid BMIFENFAMBI;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid PEFKOFFBFJL;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid PJPPMAHBLEF;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid GMCIFHHMPLM;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid HENCMGBLDHO;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid BLLLOAENLEB;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid OKJBAPNFGFO;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid GBGOHFNELJP;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid CEFJLPIAGIG;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid CLPBFGLGJFL;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid ICOIABJMDGG;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid HFJPHDNBDMK;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid BJODPEEFFOO;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid HDNPLDHIMAB;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid DEKNMFJHHLK;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid INLMKJADKKE;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid HOAGIPHFLBL;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid FGEGLFGAGAK;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid EDDHINPLNCH;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid IMFOKLIGEFB;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid PMKFLHJEHCP;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid NIFKAELHEJH;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid MOKOOHBDDLL;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DGELBLMJGJP;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid IBBKBDPFECB;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid KOMAPAFHPIO;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid LPGHIPBCDJA;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid HLMACKPHIKB;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid PDGBGNIMECB;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid ABDKIBOOIHD;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid LJJCGHFFCCM;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JJFPBBEHMAJ;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid FKDKKKLMJLM;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid OEKAHIIALGJ;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid KCJBKEEAEAK;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid JPNNOKGEGBM;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid IBDOHKIDMGJ;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid LKAGEADCNKF;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid HAECFNFFFGC;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid INFIGEHDIGJ;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid COGLJCKPDDC;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid NOENCLGJILH;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid PNIDIIJFOOM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid FIECJADPJMB;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid OIDKNPGGNAH;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid GJMKDOGBOBH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid OCGMHPBBGEB;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid CFKNCMBBGKK;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid IBKIPOJDPPB;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid AMDBKMMHNOM;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid DJJIDNGKCLN;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid NMGAKAMEODB;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid MDLBFAOLIJH;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid ODGJIIJHHOH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid INDJABGOEKM;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid IGAAOAGGMEF;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid NFGDBDHLKOD;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid GILFADCPIKE;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid AOGJEAFEIEF;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid GPJINKHMMOA;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid LFLPFAPBMGO;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid DFPFOHOGKAL;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid CAMMPDNHJAI;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid KHGFAGBDMMK;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid JGCOJIKNGIG;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid DKPFNMCGJMP;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid JJEECBKDIIP;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid CAKLBBOGABL;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid NLMAJAAKBHE;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid PLNJHEPJOCI;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid ACCHPKGKBGP;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid EHAKHGFPFLI;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid NDMIPNLKEAK;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid PIPIHGHOEJK;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JAMDAEDFEGL;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid HLMCDBFJIOG;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid BOPCNCFBGGH;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid CKAIGNKBGIH;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid EKCBKKKJCKC;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid HKNMKMCLLIJ;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid HCKKFIJMOGN;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid JLFHNEDNPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid IOGNGGFBFNG;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid FNIHEGHMBJL;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid KAHKJMPHKBN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid JLFJEDONJJB;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid LLNMCHBBOGL;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MCEJLBFGFLB;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid JBGAGHINEOM;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid IKIANIBHDOM;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid MPMAKNEDGMC;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid JHECOKDNNFN;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid LCCFOGKCPBE;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid BBDIAEAHADG;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid LOCDEGEGPGM;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid LNHGLMDOLEB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid EBKDGDAGCEB;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid GFPLFHPDODG;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid HJPAAMCOBPM;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid DEHMNIPBFEK;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid FPNAAINNDJC;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid JLCEDBPLGPG;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid LFNBEIPHDBK;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid PKKADFPHKNH;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid NDLCMNIBBJE;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid BDNKCOCNEMD;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid PJFAKBHHAPA;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid GHILJIJBAPJ;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid BACEDLHDOED;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid PNGHLJIFIFE;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid EOLCONDEBPI;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid ALDNFIMDMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid KJBHLAGAHJI;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid KOEHBEBEKOG;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid AFHDOFGJECB;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid OGOJMFLGPJO;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid CCPAOACOMOK;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid DJMAPIDCDGN;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid IIFKFLDIEMM;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid HFMKBEPHJAI;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid OLBAEBLAPKD;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid AFEJFJPOICB;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid ANKOBONJFMI;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid KAICLBMOJJI;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid KJFCPHAMKAG;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid IADFMJIOMKL;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid CDIEOACPLCF;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid BDHGEKMJAOL;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid DDCIMNKNMMG;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid OMCAPICEJPD;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid BNKAHPCBNMC;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid BKCPFFPALKO;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid AKKAHJJEPIK;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid KAHGAGFINAD;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid HPGADOAFJJE;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid MECFKOBCKEI;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid LAMAPIKPOKF;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid GGMBFOGJPJF;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid PDGBONLKKHC;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid ILEKBBGMDNC;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid FGBEDJKJGKO;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid LLFPENHGJLE;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid IPLIDGBCOHA;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid NFJIHCLKIPK;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid LCNIGPABNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid LNNNPLPJHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid KAPMAOJBGJL;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid DCGJCDOLIAH;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid PJHAGKEIELA;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid ACHHPIANGDN;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid PIIJPICBHEF;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid OIEIFGOJMLB;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid LHNJOPCACHG;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid HOOIBAMGJCM;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid BGMMGJMONOB;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid NEOFHPGCBMN;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid JKDIMOILBHM;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid DABMBJFFOPB;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid HCLPCHJIDEF;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid LECJABICGKC;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid JAPAHILOEOF;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid NKDFDOBCGPO;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid OEHCFFBFHCP;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid MHAAEPNCBOC;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid KGGPGGAABAK;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid EHAIHJCNFMK;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid GFKHDLGECHM;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid IOGNLIOEBIC;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid PFABPJNBLKD;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid PHDHFHLOEFK;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid GFLAHPKPNOH;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid LLBPKDEHEII;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid DKDBOGNODHP;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid JLCOFGNIDLN;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid OPJCJMANBDN;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid NICGANNKHOP;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid PMAGMJJLFFA;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid AMMIODPMHIO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid JKBJNGNAGIJ;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid FEDKCBOAHCG;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid HLCKAOFIOGP;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid AMFKLJCOPKG;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid NNAEBCINILI;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid NIGHBKJOPAH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid BCCJKCIICPE;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid FGGLONFCPHH;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid AEGJDKKMDJL;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid KGPIKEFOPHL;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid HHMCCNBFOCF;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid PKECIEMIBML;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid GPPLFMDHLFP;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid HEFECBJONGC;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid EFCJJBJBIGM;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid FGEJDANBGFP;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid DNKPIMKFDID;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid OBECKNJOCCL;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid EGMBIGGBIBG;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid ALKOCKEONON;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid MJAGEBEKJMB;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid HEHOFJBKHMA;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid EEBLOIAEADI;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid IGIMFFODGLC;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid NMPEEFLBBPL;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid MPIDBLLCENB;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid PJDNKDJEBKL;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid CIJKODGLLGI;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid EPHIMHBKEGL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid AJDPIFNJNAK;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid CIHHEIIKNHA;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid AKJLMFENEDB;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid MIDNADDOGPF;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid OIKLJGNAEFJ;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid KGKONGDCFPI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid MFBPPJMCHJH;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid FKBBADIHDHF;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid EEIAPFJKCKB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid IKJPJGNLLDH;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid FJPGMMIFBIH;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid CCCFKICHKBE;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid IBDNBNGIKAG;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid IPCPKBOAAEC;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid LOCOBGHMBOA;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid HBKKDGLCEGL;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid OJPEBJBHDBO;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid ANJAFHOGOCB;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid GNDGNKEPCJP;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid HOIPLFLDOKG;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid GLFLIHEDOJJ;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid MNPDLKCBIFI;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid DHJGBKDFDOI;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid OEEFICOLNDE;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid GKNPJDINEOP;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid EFAFNOPEEFJ;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid BDBFKOGIONJ;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid BFJJCHJOIJB;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid KHNKMEAPILN;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid MOICOHJALJH;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid MKANHCFBLFC;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid EBKEJHHJPDO;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid MEPNFLBBCJC;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid FIJBGELCDNL;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid LHLMCPOMGPK;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid JMCKKJGBJDH;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid DCBFMFNHPEK;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid AGKEKEPFMOD;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid GBJFPGOKJDG;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid FHMBEODHBFH;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid LFFJDILCMHH;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid CHOMINFHHPI;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid NHNEBINGACK;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid LGDOAFMFDII;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid FHDMJLCBGDE;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid OPJCGHHPOHA;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid MLAMKLMEDED;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid PHBNANHLAKF;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid GEBEECLOMPC;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid LACLLCJNALE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid KCOEDMLMICM;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid INJKJBAKAKE;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid HHJJCIHMJNC;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid LLJCPMIGJDD;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid CGMHGNMNMPM;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid AACLDEGFMAJ;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid JKHNJOFBPAF;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid KJFJAJDBNOA;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid JFKLOBLHGOJ;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid IBLMJDHLHNE;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid MOBJIAJOBJG;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid HPLCNOJNEEO;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid ANKDLKCJBMP;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid OEGBAOCPOCL;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid KKBLLLFPKAM;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid IGDCEGGACBI;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid BBJNFLNLIDA;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid JLBGCMMIHME;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid APPNHCKEACF;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid KELGLEPLOOJ;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid OGDJLJFNKJG;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid CPPHBOGHHOH;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid BKOFKGIPKKM;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid PIAGENELGPK;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid NLNLLMNDOCC;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid IDHBGAACPNH;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid MOHGKLGOODK;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid FGHPGMFGEDP;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid FAGLMBILNBP;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid GGMPOOKOGJF;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid PHOPKKGACDG;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid FGJIABJECOM;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid DDHMOBGCLBD;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid GCJIMBAODII;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid CNKFHOKFEAL;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid OEBHKDDDAGA;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid BJMHLJHOPMA;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid FFHPCCCNIBD;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid AHMNMNANJFL;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid GAAEJNOMHNM;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid INAABOJJDGI;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid BMBAEMDOKPL;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HIDOGBEADKP;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid AOCOHDHFBEJ;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid CFOKMCMFBNE;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid AIAPMIAFODA;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid LAINHDAADPI;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid FFNKFEFLJAB;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid ACCAIMFGCCC;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid BNGJGJHBHJC;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid ACIDGGPGPHG;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid KBIDNHDAMNF;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid AOPIPBAEGFH;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid FECCJCLGFNP;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid BCAAMMJCIPN;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid ILGDHNAJJJI;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid CEBOIAEOBIL;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid AHNAHOHINJC;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid IKBMDOMFODM;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid FFIMEPBIPON;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid CHDKNLBGJJL;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid MHLPGMGLNMA;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid EMCAFHMLGBI;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid CINGKKNJMEK;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid HPPMDPADHDB;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid PMECAOCADFI;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid CPNBNLNNCGH;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid CBHMFKALIOL;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid FIJPMKMEONC;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid CBEJMLNGMCC;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid FIHNPLHIGKL;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid HCBFIHABGPM;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid NKEODHMJONC;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid GGLINOGLFBI;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid NGMEOLDDGMN;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid FOICHHOGICH;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid JBJKGHHCEKD;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid GFOFEFOKGIA;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid EAHFGCEKDNF;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid JHGAKEBPACJ;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid OIIPBEMMIOO;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid INPLPOCIOEF;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid BDHOJPENMEH;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid JPIGMBNEKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid ADPHFLEIDOL;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid LLCPCEDLNMA;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid MGLJIBJCMEA;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid FFLJIBOJDNK;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid LCLIJKGIPFA;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid ABIGBAGLCBG;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid ONIHHBFGBKA;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid JPADAFAMHDE;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid NHMHKHOFJOL;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid CLFPLJLDIEE;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid KGBNGPNFPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid IGGDDNNCPNB;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid LCCEKNJALGI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid FMPEPHPIMID;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid LFOCGBIJEKB;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid HCPMINGDHFB;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid AGLKEBKFNNI;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid MHALFEELLEB;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid FKJPDKDGHEI;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid OCJLBHCIMNI;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid HGEHHAJDBKL;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid PNMCFIJIKKC;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid EAACCAPMJLC;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid MMIECNGOIJN;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid GJPHOKHAONA;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid EBNOMCDEMBC;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid OAJDGBLBDKA;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid LFDBPMIPDLG;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid ADIHMHBIPEM;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid DKLFFMONNNE;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid FNKBNDDIAOB;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid IKKHGIHCOEM;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid GFHMAJJLKEK;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid NFOANGDDFOO;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid NCMJNEDLJEE;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid ENCEEMOILJP;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid JIHGCNCGOKE;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid PEBJKPNIDFC;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid DPHCDELCCNC;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid LMNLIBCCNKF;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid JNPMKOLDNDH;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid MMOCMEOAGIE;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid CNBLLLJHPDM;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid CFFDFACKGDE;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JPCJPAPFLNC;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid OPICNLHBGKL;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid HELPNPJAMCD;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid PKALIEOKPBN;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid ADNJIMDMNAL;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid CDIKOHGOGBD;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid KOBDOCOBADC;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid GCNJLAGNEHK;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid CJKAGILFAHE;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid OJOJJDJNBCO;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid FLGMNIFIBAF;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid LFADHCAHKHB;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid CMKOHDNGDFC;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid JADJIPKPPJK;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid IDMMFNCANGM;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid NFAHJCFAPDA;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid PJPDLEDLEJO;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid FFHKAMDPIAB;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid KOOPPDHAOOB;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid BAKMMMPAHCI;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid CJPNNDGJDCM;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid IOJGHMLEIAB;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid HKLFKEEGDLD;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid JILMEPAMEAO;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid MDEBKDGKEJC;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid MANONOKKLDO;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid EGINMIFIFHO;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid EELNACGANPN;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid BMGEADEPDPF;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid EMPKJIDDPBG;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid OFIBGOGLMPK;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid DFPHNJPIOPG;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid LIFMCCBEGOI;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid KOHPMABKJFE;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid OMIKEFCJFEN;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid HHKFLIAEABH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid JDELCFOCJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid LCIDPPDHAJA;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid PHJFGLJNPFL;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid DHBBLLKDGDC;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid LODPCPPNNHB;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid NJDACOHJDDL;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid BGKHNIFDMCL;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid BCIMJBIMIAK;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid HCBJJHKEMED;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid EOOBGHAMLIJ;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid HOGGECIEBHE;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid PKECBNKIODC;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid CPBKOBKOFJJ;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid JGLOLACNABI;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid OBCPFNADGND;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid LJNPGCJHPIB;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid PLLKFDIIICN;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid KEBLNJIMKBI;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid LJHHDGGPOIL;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid IOIMINPHCDL;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid LJMKMMIAGOF;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid MGOMGGALFKB;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid KNJBMPDMPEP;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid KPCBFJHDENP;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid PBDMGAIAPPN;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid LGDGLCOMCPJ;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid JNALHAIPHEE;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid LGFNODIKMAI;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid ABKJFECHKKL;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid CAOKCBBOJKE;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid MNHCCEBDLAE;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid IEJDAJGNBJL;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DMLLFOFNOKH;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid AAEINBCJHLH;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid DNAKNNNEONC;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid LAHKPPLFDHF;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid DKDNALNFHLM;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid POLPENEDDFB;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private static readonly Dictionary<Guid, ONLCIIDNGBH> HEKJIJLCNEC;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Dictionary<ONLCIIDNGBH, Guid> ABDMHABCAJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, ONLCIIDNGBH> BCFEFGJNHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6040180", Offset = "0x603F580", VA = "0x186040180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<ONLCIIDNGBH, Guid> BLGCEJMGCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6040120", Offset = "0x603F520", VA = "0x186040120")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LEAIJDEOEBJ
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6046CA0", Offset = "0x60460A0", VA = "0x186046CA0")]
	public static bool MHICDPCOBPD(HOMEHAHJNDB KDIOOKGFEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60468F0", Offset = "0x6045CF0", VA = "0x1860468F0")]
	private static bool MHICDPCOBPD(NIPPJOJFABO GBEIAENCKNB, HOMEHAHJNDB KDIOOKGFEGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CECNDPPOMJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly NDNKDDKCJKI CJIIDADEMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly IEnumerable<NNPHGGCALLP> BFEAMKENOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<NNPHGGCALLP> DEGAJLMGOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly LELHOHFMKKF<BBFMEDFDBAF> JGNHEDHBFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly IReadOnlyList<BKCFLNKEACJ<FFAKLMOHHBO>> IKPMDBKKKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly ByteString NPGGKEJIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public readonly HOBGOGOHCNM GHDLLAMCNGH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60401E0", Offset = "0x603F5E0", VA = "0x1860401E0")]
	public CECNDPPOMJB(NDNKDDKCJKI LJIHLGEBFGP, IEnumerable<NNPHGGCALLP> IEOLFELCNDG, IReadOnlyList<NNPHGGCALLP> MOLJPEMKJLG, LELHOHFMKKF<BBFMEDFDBAF> MDECBDDNKHJ, IReadOnlyList<BKCFLNKEACJ<FFAKLMOHHBO>> JJLINLDAFNI, ByteString PFMGGANHINB, HOBGOGOHCNM BLGGHFNDNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KAICKKPBFCD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(KGFMINPMMJJ ALPLHOOHPEL, [Out] Dictionary<int, int> FMMFAKFAMEA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CJNEFIJDHPE FGIFDILPFDJ, OKCGNIIMGLG HIFHGLECODM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KPFFOBEEFPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public readonly Guid GLEHCILIOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly Dictionary<Guid, Guid> BKADBCAFJGJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> CKJEEIEPCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x33E4760", Offset = "0x33E3B60", VA = "0x1833E4760")]
	private KPFFOBEEFPP([In] Guid JGLALEKBJEG, Dictionary<Guid, Guid> LCEGAEECPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60463C0", Offset = "0x60457C0", VA = "0x1860463C0")]
	public static KPFFOBEEFPP GJKMCKHILNE(IReadOnlyDictionary<Guid, Guid> EFDPDMLFCAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60463D0", Offset = "0x60457D0", VA = "0x1860463D0")]
	public static KPFFOBEEFPP JDIKGJIJDAJ(IEnumerable<KeyValuePair<Guid, Guid>> EFDPDMLFCAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6046200", Offset = "0x6045600", VA = "0x186046200")]
	private static Dictionary<Guid, Guid> CGJECFNICGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60462B0", Offset = "0x60456B0", VA = "0x1860462B0")]
	public Guid DDCBHGPHPGH([In] Guid LHLNCEHJAOH, bool CLMJMAEMBPE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6046780", Offset = "0x6045B80", VA = "0x186046780")]
	public bool PAKDOKCNDHD([In] Guid FNOGEAGAPLC, [Out] Guid JAACFCMEKHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NJMDDMJLJHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DPGNIFMCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCEFODEMOAF(ByteString PKHNCMEKMEL, KPFFOBEEFPP NENCJDPPEOC, [In] PHCICLADBII NACHNKKCIPF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BNDIMMLMBGO
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
public sealed class GGFBACNGECD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> NIBJCJIJHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> EGCBNKGENPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4380", Offset = "0x7A3780", VA = "0x1807A4380")]
	public GGFBACNGECD(IReadOnlyDictionary<Guid, Guid> CKICEFGFDMG, IReadOnlyDictionary<Guid, Guid> OHILDNPCMCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EHFFMIGLHJK
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6044590", Offset = "0x6043990", VA = "0x186044590")]
	public static JHNBPBOJGJI KDABPKOBFLG([In] CECNDPPOMJB DPKCKCCLNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6043F30", Offset = "0x6043330", VA = "0x186043F30")]
	private static void KBOKHEKALLF(JHNBPBOJGJI OMIHIPCFLLJ, [In] CECNDPPOMJB IBCABPEKGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60428B0", Offset = "0x6041CB0", VA = "0x1860428B0")]
	public static bool JJKLBCDCGEH(JHNBPBOJGJI OMIHIPCFLLJ, KFFELPNGJDE ODEKLDKAHJC, KPFFOBEEFPP? ILBPLHJHFBM, [Out] GGFBACNGECD? LCEGAEECPJK, [Out] string? FHHKCHCDKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6044770", Offset = "0x6043B70", VA = "0x186044770")]
	private static void PPAGFBNGEDD(JHNBPBOJGJI OMIHIPCFLLJ, KPFFOBEEFPP? KHHHFGFABJI, KFFELPNGJDE ODEKLDKAHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6044700", Offset = "0x6043B00", VA = "0x186044700")]
	private static void PCKALNBDKLJ(JHNBPBOJGJI OMIHIPCFLLJ, KFFELPNGJDE ODEKLDKAHJC, IReadOnlyCollection<ByteString>? HOPOPBKELEM, IReadOnlyCollection<ByteString>? JADHFIEHGNC, IReadOnlyCollection<ByteString>? NCKNEJGOICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6041750", Offset = "0x6040B50", VA = "0x186041750")]
	private static bool ANAJHFIDPPN(JHNBPBOJGJI OMIHIPCFLLJ, CJNEFIJDHPE FGIFDILPFDJ, KFFELPNGJDE ODEKLDKAHJC, [Out] string FHHKCHCDKKO, [Out] Dictionary<int, int> FMMFAKFAMEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6042120", Offset = "0x6041520", VA = "0x186042120")]
	private static Dictionary<Guid, NIPPJOJFABO> GLDHIDGJJOD(JHNBPBOJGJI OMIHIPCFLLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6041DF0", Offset = "0x60411F0", VA = "0x186041DF0")]
	private static void EEJAMBILCOB(bool NFCGAIKCBFN, NNPHGGCALLP EJHCKIEAIIN, Dictionary<Guid, Guid> KMCFOLFMLNI, KPFFOBEEFPP LHELDMBCAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6041E90", Offset = "0x6041290", VA = "0x186041E90")]
	private static void EPOGLEOECEK(NNPHGGCALLP EJHCKIEAIIN, Guid LFEEPKLOHLO, KONBGNPMDBB? BIKCFCHGAOL, Dictionary<Guid, NIPPJOJFABO> NJCACFGLFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6042400", Offset = "0x6041800", VA = "0x186042400")]
	private static void HLJKAMPHGFE(IEnumerable<NNPHGGCALLP> KFEDDHDGPKH, IReadOnlyCollection<ByteString> HOPOPBKELEM, IReadOnlyCollection<ByteString> JADHFIEHGNC, IReadOnlyCollection<ByteString> NCKNEJGOICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KFFELPNGJDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public bool NFCGAIKCBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public HOBGOGOHCNM BLGGHFNDNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public KONBGNPMDBB? BIKCFCHGAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public KONBGNPMDBB? KPOCEFFGNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public NDNKDDKCJKI HHGNJGMEJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public BNDIMMLMBGO NLELAKPJBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public KAICKKPBFCD CFIPJEFBPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public NJMDDMJLJHH EOGNHBEGKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public BKCFLNKEACJ<BBFMEDFDBAF> ILNNOMGCBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public ODCDFBLDLJG GDCKEGHOEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public List<NNPHGGCALLP> CFKPLBJCJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public Dictionary<string, object> OLMKHDAIGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public AEJKGFGHNKP BPIOHHEJKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public bool CCIGLMNPDEA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LGMPDPIGLGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6045940", Offset = "0x6044D40", VA = "0x186045940")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KONBGNPMDBB
{
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private const float KJFELCGNHHB = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Vector3 BEBKKMFGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Quaternion IKFFGJBHBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public float LFBOEHOBPJC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 GCEHNMAJNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6045A60", Offset = "0x6044E60", VA = "0x186045A60")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PHCICLADBII GCMBJJKPLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6045A20", Offset = "0x6044E20", VA = "0x186045A20")]
		get
		{
			return default(PHCICLADBII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x935F30", Offset = "0x935330", VA = "0x180935F30")]
	public KONBGNPMDBB(Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC, float LFBOEHOBPJC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6045F80", Offset = "0x6045380", VA = "0x186045F80")]
	public static KONBGNPMDBB NCOGIFBLIII(KONBGNPMDBB EMDODFFCGEF, KONBGNPMDBB MCDFFMIMPMP)
	{
		return default(KONBGNPMDBB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6045D40", Offset = "0x6045140", VA = "0x186045D40")]
	public static KONBGNPMDBB JPANIEAALPM((Vector3, Quaternion, float) ALPLHOOHPEL)
	{
		return default(KONBGNPMDBB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6045BE0", Offset = "0x6044FE0", VA = "0x186045BE0")]
	public static KONBGNPMDBB JPANIEAALPM(Matrix4x4 NLLKEIABAFB)
	{
		return default(KONBGNPMDBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6045D60", Offset = "0x6045160", VA = "0x186045D60")]
	public KONBGNPMDBB MGKGKCFKDEM(Matrix4x4 NPBNAACKOLN)
	{
		return default(KONBGNPMDBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6045B70", Offset = "0x6044F70", VA = "0x186045B70")]
	public static KONBGNPMDBB GPBMBANFGAJ(Vector3 BEBKKMFGLCG)
	{
		return default(KONBGNPMDBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6045990", Offset = "0x6044D90", VA = "0x186045990")]
	public readonly DFENHDHDBNN CELIJHCKJBO()
	{
		return default(DFENHDHDBNN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KBFGPNLIOBL
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60458B0", Offset = "0x6044CB0", VA = "0x1860458B0")]
	public static KONBGNPMDBB HEKPNNNJEOF([In] this DFENHDHDBNN LOMPFKEACIP)
	{
		return default(KONBGNPMDBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class JJJEKOECFHJ : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60455D0", Offset = "0x60449D0", VA = "0x1860455D0", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6044D10", Offset = "0x6044110", VA = "0x186044D10")]
	private void GGNJLCMCOPH(Dictionary<Guid, Guid> DPAKPCOIBJF, MOHKLPKPILE ONCAMPPOALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6045570", Offset = "0x6044970", VA = "0x186045570")]
	private void GGNJLCMCOPH(Dictionary<Guid, Guid> DPAKPCOIBJF, NBNCHIHDOEN KEPDMGGCJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60452F0", Offset = "0x60446F0", VA = "0x1860452F0")]
	private void GGNJLCMCOPH(Dictionary<Guid, Guid> DPAKPCOIBJF, NAIMLICBFDK AAIJDDICIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public JJJEKOECFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class JPGJLNLHFFK : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6045810", Offset = "0x6044C10", VA = "0x186045810", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public JPGJLNLHFFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class BDNONNBFFID : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x603FCF0", Offset = "0x603F0F0", VA = "0x18603FCF0", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public BDNONNBFFID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class OMCANMKONKM : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x60493A0", Offset = "0x60487A0", VA = "0x1860493A0", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public OMCANMKONKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class FGHPGODFAHP : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6044A00", Offset = "0x6043E00", VA = "0x186044A00", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public FGHPGODFAHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class AKLOAMNALND : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x603FBB0", Offset = "0x603EFB0", VA = "0x18603FBB0", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public AKLOAMNALND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class BLLILEABMGA : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x603FF80", Offset = "0x603F380", VA = "0x18603FF80", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public BLLILEABMGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class GJFNCNBKNJN : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6044C20", Offset = "0x6044020", VA = "0x186044C20", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public GJFNCNBKNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class JJPOLIFHPFB : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6045650", Offset = "0x6044A50", VA = "0x186045650", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public JJPOLIFHPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class DGOGNPFGIHO : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6041590", Offset = "0x6040990", VA = "0x186041590", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public DGOGNPFGIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class LBECBPFPNIK : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60467F0", Offset = "0x6045BF0", VA = "0x1860467F0", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public LBECBPFPNIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class BJJEPOCGALL : AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly LINLMJAFJKF LGKLAJNPNBB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x603FE50", Offset = "0x603F250", VA = "0x18603FE50", Slot = "4")]
	public void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public BJJEPOCGALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HOMEHAHJNDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public CJNEFIJDHPE MCCNLGBAILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public BIHIIEFHAJK NKGHCHFFGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public Dictionary<int, int> ODELFOPOLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public Dictionary<Guid, Guid> JNPHFMHNDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public AEJKGFGHNKP BPIOHHEJKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public bool LFIJAELPCCM;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AOAAMODOKON
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDCDEHDGINP(DEMDKMHENMM HGOBOEOOLIH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class COIBKKEIPLM
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private static readonly AOAAMODOKON[] DEKOBBGGDNK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x60408B0", Offset = "0x603FCB0", VA = "0x1860408B0")]
	public static void LJOOIGPLAJJ(NNPHGGCALLP ALPLHOOHPEL, Dictionary<Guid, Guid> FPAFCBGCBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6040550", Offset = "0x603F950", VA = "0x186040550")]
	public static void KOIHGILFJFG(NNPHGGCALLP? ALPLHOOHPEL, KPFFOBEEFPP IPPEKMCOPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6040270", Offset = "0x603F670", VA = "0x186040270")]
	public static void ANKPOCIICCH(NNPHGGCALLP? ALPLHOOHPEL, KPFFOBEEFPP LHELDMBCAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6040B40", Offset = "0x603FF40", VA = "0x186040B40")]
	public static void MHICDPCOBPD(DEMDKMHENMM HGOBOEOOLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct DEMDKMHENMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public CJNEFIJDHPE CADLONMIODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public NNPHGGCALLP EJHCKIEAIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public Dictionary<int, int> ODELFOPOLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public Dictionary<Guid, Guid> JNPHFMHNDIF;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60414E0", Offset = "0x60408E0", VA = "0x1860414E0")]
	public Guid HPGPBCGBJNA(Guid LHLNCEHJAOH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface AEJKGFGHNKP
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int FFLIGEBNMLP, [Out] Guid AJDAKMMEOLO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MHBFHPLIPAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly HashSet<string> FLFBONIGODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Dictionary<long, int> GCDAIJHJFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly HashSet<Guid> MOCEBGHJENM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> OPBHCEFCOII
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> JEKJEABONLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6047B30", Offset = "0x6046F30", VA = "0x186047B30")]
	public static MHBFHPLIPAE DILHLKPJHEF(NLMALJAJAJA FOIDNCOOLGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6047EF0", Offset = "0x60472F0", VA = "0x186047EF0")]
	public static MHBFHPLIPAE PCLJMAFEPKF(JHNBPBOJGJI DLDCEADIBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6047D70", Offset = "0x6047170", VA = "0x186047D70")]
	public static MHBFHPLIPAE OFOANAACOBE(IEnumerable<string> FLFBONIGODL, IDictionary<long, int> HLENKKMAKHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60480A0", Offset = "0x60474A0", VA = "0x1860480A0")]
	private MHBFHPLIPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6047F60", Offset = "0x6047360", VA = "0x186047F60")]
	private MHBFHPLIPAE(IEnumerable<string> FLFBONIGODL, IDictionary<long, int> HLENKKMAKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6047930", Offset = "0x6046D30", VA = "0x186047930")]
	private void DDFCALBFJDG(NLMALJAJAJA FOIDNCOOLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60472A0", Offset = "0x60466A0", VA = "0x1860472A0")]
	private void DDFCALBFJDG(JHNBPBOJGJI DLDCEADIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6047490", Offset = "0x6046890", VA = "0x186047490")]
	private void DDFCALBFJDG(FBILDKAPPGD? DHHBNGOGOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6046D40", Offset = "0x6046140", VA = "0x186046D40")]
	private void DDFCALBFJDG(ODNLFDFALBH? DKBEBHEBAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6046EB0", Offset = "0x60462B0", VA = "0x186046EB0")]
	private void DDFCALBFJDG(NNPHGGCALLP? EJHCKIEAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6046CD0", Offset = "0x60460D0", VA = "0x186046CD0")]
	private void AHKCEEHJOBD(string? OADMPLLOFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6047C90", Offset = "0x6047090", VA = "0x186047C90")]
	private void FLIKDOCHAII(DKAFJHNJEIH? HFPIPEKPGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6047BA0", Offset = "0x6046FA0", VA = "0x186047BA0")]
	private void FLIKDOCHAII(JDELCCNOJMJ? HFPIPEKPGHO)
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
