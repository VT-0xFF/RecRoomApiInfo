using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x618C1D0", Offset = "0x618B3D0", VA = "0x18618C1D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FCKJGDEFAAH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> CIPPMLIEIPJ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> HJLEKOGHFOL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> LIMLLNBABIK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string GKAPBKCGBBG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string ABLKLLFALIM;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string EGDFIMNCBGO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61729C0", Offset = "0x6171BC0", VA = "0x1861729C0")]
	public static bool BHHBLPBMAAC(Guid AGONFOPANCO, int PJAFGOBLJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6173140", Offset = "0x6172340", VA = "0x186173140")]
	public static bool HCCAACGOHLP(Guid AGONFOPANCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6172AC0", Offset = "0x6171CC0", VA = "0x186172AC0")]
	public static string DINKIDNIEOJ(Guid IKOKEKHMFKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MEDCLEJEDBP]
public enum LKAEJDFICGP
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
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HGOBAGNALAP
{
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid HFJNIMOPICM;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid BIOIJEEBJGC;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid CDKOCPNBPBB;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid HIDMJLOFJFO;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid PAKEKGPCKBF;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid KGLPFLCHLDJ;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid DBHPHIFFCED;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid BMBPHFPMCKH;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid INDOILLNJMD;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid JEGEGHPDHLN;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid HNNIOILCMBF;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid FFNDPHOPDMB;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid IKIDPAMJDDD;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid AFFAJMEFMDP;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid GKGIJBJFEDJ;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid HHEFDHKGOBD;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid PHJAHCIAJEL;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid IDLFICNCOEB;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid EMBBFOMJCFM;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid HDPACMMDKCB;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid FPPBLCKNFOP;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid OEDNNIDNKNM;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid FGJPBIEMEHM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid AGMAHCDDEPC;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid OEMOLFGFCPP;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid CJHPAGGMHDI;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid IOKFEPMEPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid AOPLCDONPBB;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid HPAOIHDIJIL;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid DDBKDJNODLD;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid NFANFMEKHDF;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid BILCGKJEDDC;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid OIEDPHOFNGO;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid BLCLAJBCJFD;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid JPMKJKLGJHL;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid JPDJBNGPOLC;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid PJGCNHNGJKF;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid ABIBIKNCHBC;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid FOJDFBGNABA;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid ADKNDDPLFIF;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid HJPPHAKKJHE;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid ICJJIEMMHMB;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid NMDOKAKGLAE;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid KCCJHKHCFEF;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid HCGOOFBGOLO;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid DHHOEGJIPBO;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid EOHKOPBPHLK;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid IBLPKBPDCJB;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid IDHGEJAPDDO;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid PIPABADGEAB;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid ELMGOEDGMGN;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid GNMPLPNOHPM;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid FKLOAOBNEKF;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid IOPMGFKFPAI;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid PGHNPOBDKOJ;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid IBGMFMDILBM;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid DHLCGGAOLMA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid ONGHCGBAKML;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid AJPNLIMICOK;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid DMLGGAPFHHF;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid CHMBNKHPAGB;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid AFINLEFKPBP;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid KPJJJEKOILP;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid IEFOPAGDCHH;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid DBNJHGECPDK;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid OGDBKBLOIDG;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid ACMEPADIDHC;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MIGOIFNKLJF;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid MHCICKDLJJK;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid NHJAFOEEJJJ;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid DBOPOKLNBFK;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid KDEMMIJEELE;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid JEPNDKCCCGF;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid PCCFFLLGLAC;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid HEGNMHAIPBL;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid PGCJCGKMFFE;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid DHLLNIHEADH;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid FODKNILBLFJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid EHDMGEFHACN;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid GAOEEMOLEKB;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid HHCLHKEDJDG;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid HCIDHMMJIIJ;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid FHLKGPBBLNJ;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid DICGFDLOJJL;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid JEGLFCCLOFF;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid LPMBAOAEGIC;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid APMAIOFBKOI;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid PIJBLHDNLGM;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid LDCBNMHBFIF;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid MMJKICFMDPH;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid BIJOBNABIPO;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid LFMIMKKJANE;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid PMIOJFKMOPM;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid LFCAHMCDFOH;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid OJOMCHBMIDL;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid EOAIPKCOOCA;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid JLOAMPNHBGB;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid JIJHKADPBGO;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid APBPMPOHHCP;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid JIAECFEPAGL;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid JGJEFPFNMGI;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid BFALBIEOMMK;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid JPPPGDNGBIP;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid JKAAIIFLMKI;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid AKGJIDLGEIO;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid KEGOHMDJFDF;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid BGLLGKLKABL;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid JJFONADGCBL;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid MLLIBNOBCPI;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid AEMADIDOEDC;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid EDKLLJBAGDA;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid JFEAJNDJPAF;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid OLIDDEIKBNC;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid EILFKJBNMOA;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid JEMMLCPCNHG;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid EGKMJPMLBLD;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid AHJDPPKOIMK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JFHIIBHMHCI;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid NMNNFOHHOBE;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid PIMHLEIBNPE;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid DNFKMDCGCHB;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid AKEHPFNAIOH;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid FCAINNJGGMB;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid KHLEANFJADE;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid HOBOLLCJBJJ;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid BODBMMMJDFK;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid BEHNMHJOFME;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid BCGOLOHDDEP;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid DLHAANLINAI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid DLEPHONHHEE;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid CFNHBIALEFF;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid AGMPKJGEHAO;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid HBFFCOHBFAP;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid LDKGJCPNOEM;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid JHEMFCNCOGO;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid EJNGLCEIFKN;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid MPJDBDAJAEE;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid BOABLOEKKJB;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid CGGLPCEPNFB;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid PCAOAGKHNNA;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid POEOAGFMHEH;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid PCCBHJEHPFG;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid BJLIIEJCFFD;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid IEBLPJJIJBB;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid JKFNEGDHCEN;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid CAHMEHMHBHB;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid JCIEFPGNPDK;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid APNHFGJIHNC;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid COBPACONLFN;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid DDDLHDIOBPK;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid PNABFADICJH;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid OECBPFKNMEJ;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid EMDFLBKFBBD;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid OBPKNCCPBMA;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid JLABLDIDIMF;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid JABCMDMENPI;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid GOALJJACNHI;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid KLJAIALCDHN;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid OMPAKCNFNDL;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid GILBKJMKCLA;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HFELMPFFPCO;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid FGPBGNNCOIA;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid CHNBCPHIEMI;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid DCBELMEKGBJ;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid CEFBPIAABAD;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid MGLOCPIGGHL;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid LPADDMJBJBL;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid HGIOGKBIJIG;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid GCHHGDFPFIA;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid GCCILLLANEL;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid IHELPAMOOFE;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid GNBNNGPMPKP;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid GLJCEFHLGHH;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid HLNNMOKNOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid PKJPMKKDPGP;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid OLDKOPBLJNI;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid KOJPGKPEOEP;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid PJLHFCBJDGM;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid PHIENKPALCP;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid GFGIKCKIPFN;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid FDIDKJKCCNA;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid PEEMHCGAHDF;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid GFCECLDINLD;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid LMAFNPIOKMP;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid FMPPEHEECKA;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid BNDPEOFAGMM;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid JOICFKOODKJ;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid NNEMDNFKGFP;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid OKBMBCHGPHB;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid JDBLHLAIFDL;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid CDNMDMDFMFK;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid NLJABHCABMB;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid JOAIPCCMJMB;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid GEJJCJEPLIL;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid MHCCKDHKBKN;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid MIDPJMJCDFK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid FEHDIFAHGBG;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid GBJPHOHILIP;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid NCFNJKONLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid CFBOKDBDEOF;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid JMAHNGOHPCB;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid FPLONCHOADG;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid MEDPKMFJFJJ;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid JKOHMINECEI;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid NBBKGBKBPOK;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid DIEAMJMKOFO;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid ANGGJNEBNFM;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid OLFFJBJGDIA;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid FDNDIJFKAAL;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FBMLPKHFEBG;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid CDMHOKOEKJO;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid PBGEAHHHDEK;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid GAJGGKLEPGG;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid EGPEDOFKJPM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid EJMIPLNLMOE;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid KLOKAMJKFMD;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid CADNGOFLBOC;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid AANJNALLCPB;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid JGGOGDNMNIE;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid NJBCDECJFIP;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid JFKGKCNDKCC;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid FBACHFKELJA;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid NAKNLMEBPGJ;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid PJEIFICNLCD;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid MODFMGBOGCE;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid OBPEICAGIEC;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid NHGFOFBHFBP;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid HEGHDADGHHJ;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid MEOIFPCLCBH;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid IJBBIIKHLJA;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid PFCGIGEBOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid CCPFMLEPLAP;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid PMBKIIAOFKD;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid EDBBMBGDPPC;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid KBLBICFOJKD;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid KKILAJAKMIB;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid AKPINIEADEF;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid PABPGDAIFBO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid BPPNBJFKGKM;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid ILIMCPMNIKK;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid BLHGFGBFKLI;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid ONIIOCOHFLN;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid BFBOOPICPHG;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid JNCKCMJOACO;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid IODGCLHNCJA;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid BPPKKLKBLCF;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid CBLPMGKFEEH;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid LBAMPKGNFGK;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid ANDJOCNJMFG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid HGLIDKDEEPC;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid EEMMBBFIPIF;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid LHNJHKAAPEJ;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid MCLICMFCNEI;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid OKMLBINEONP;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid POFLHKBJMBF;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid NJPLJJNBAHE;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid JCBKAPHLCDI;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid ELJBMIGCMIO;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid BLGFIGBEOAL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid JMNKPPKIEAM;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid NAMEMGKLBFP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid GCNEDGIAHOL;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid EDBDCHAJBPC;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid NGMKBDGDJGB;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid KOODBAKLNED;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid OLJKJEEHKBL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid JGLNPNIDDNH;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid COENBEIEJAD;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid ADDJFAECAGL;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid ONAIGAFAMPI;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid CNGPDEFBPHI;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid HNDPAJNOBEE;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid OLFBFJMAHKI;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid MNHGJJKFIEM;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid OKGKDCCPCIP;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid KMLBNOLPOKB;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid FNLBPHKNKGL;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid KDCJMLMDICI;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid POCCEFNHAKO;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid EFAPDJPLAGO;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid ALDJBGCMFPO;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid NBGLABNOECC;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid AFEBJEBFFNC;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid JLMNKJGIMNA;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid JAOKOIOMBKK;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid DKPDBKFJJKL;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid KGDGIOLPING;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid NBEOCMGDPEO;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid DOFBMHMOLGF;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid JPHDPMMHCCD;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid INJDOODPPHH;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid IPCINHAFDFE;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid DJMJDBNGGNM;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid MIGCGFONGJD;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid HKNGEKMOFOK;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid CBLHPICLKLP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid PBDPMIOBPCD;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid GPHPKPBHIHH;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid BOFBNPKEMKO;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid IALNELNHECC;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid IFIKAMDIHOH;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid BALNNBJECFP;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid HFEPOPEPLDN;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid FAKHBIFHBGK;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid CGMDDHMKPDF;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid ILCJLOJAPHE;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid NFLFEDMJLNG;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid LACKPJDDGKG;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid AGJLBNHJOPB;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid CMGDNCNIKCN;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid EIDOKHPCJLL;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid NGCGNJKHGEC;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid KNKKEKMABIL;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid GMMDMJKAFHM;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid APKJDHMLINE;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid MNLOBBHNFEF;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid JIDPDNEENAC;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid MLKFBJLCBEC;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid POKHKNBHFCN;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid MKKADJPKANE;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid GAJGHGPHJDC;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid JMMJIPPHAIH;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid PJBCLLGEGAA;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid LAJBIOFAKIB;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid KBKGOIBOIKD;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid FINCFLOJHKO;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid BNONDFBEPPH;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid HCMAODEGCEE;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid CBPOLAINJLE;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid GLLGGIOCGCM;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid HGMOHHNAHBF;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid EIEHFIICJPB;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid DLDENONBBEE;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid KDONPPMOKAO;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid HAEFPIKDOEG;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid FCAMIIJANGA;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid HNKNGIGCDDB;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid HFEGPIFILKN;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid EGBJGCEFBCM;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid ECHFJAOIGEC;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LPGBJJDBBPP;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid CMJJIKEHJOL;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid OGNOACHEIHB;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid FOPJMEINOKM;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid BAEDHPHHMKB;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid FGOPMJDECNM;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid KEOAKPGDDLI;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid AFNLKBENDNJ;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid IIEJIEJHFDG;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid DFJNJMAEECP;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid IFBIJKNHHAJ;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid AGIHNEBIPNJ;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid JHNEIEIAOGA;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid JFAMLDENOOE;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid MDELBKLECGJ;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid CBBLPNNODCP;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid LHCIHEJFIKI;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid CAMMMMCLFOC;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid OHKJLBEDDBA;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid BELOMOENHBP;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid NNKPDDICAPC;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid IPBOMHLPHOG;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid KKMBMPFMFDG;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid FFCHDMDCLGN;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid PKBIGKGPJMF;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid FCGPGPCODCJ;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid CMHJPIHIBMM;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid JAFKEHEMFAL;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid CMCJAEOKKHD;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid LLLKDLEENKF;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid IIOIMCANAAN;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid CCMMGCDLMIL;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid KEONAGJGDNB;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid LHJOINDLJDH;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid EKHKPNJDFBH;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid PLAAEGOOAMD;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid HJFOLNEOHGK;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid BDENDPLLBCN;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid BOHOAKBINCG;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid GJAKNAHMNBE;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid CEJEPELOIDI;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid IELBIFPOGCE;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid EMGMAFHLOJD;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid FCOAPPFNHDL;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid EGJAGNFEPID;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid NKAFIHKOBMB;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid MCKHILODKPO;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid PNMMGEJFADH;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid BLCBPCMHPCF;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid JEFOEIABFAJ;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid EAFGIEHMNMC;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid OFEMAMLAFII;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid ADIAOKLELOF;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid PLFJPBNBJLO;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid AGGILAHGHPB;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid CHGCFGBKNLH;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid KDEJOMJKBJC;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid KFIOOJCHCGC;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid OFPMNJBIHGN;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid LDLPGCKBHOO;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid HKOGJOOGLKG;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid PCPKANFKHHD;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid LEKBACCLOHJ;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid GJMKICHIDPD;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid OMEAMABLJOI;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid KKAEBJBCOBC;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid AGONGMJHPPD;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid PCHJFCDJNDL;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid OIJAGINNKLG;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid HHOKAIFENHO;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid EJLJHFPMDBO;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid DKCGMGMIJGB;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid OMKIDPLGLJJ;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid IDBIFFAECPD;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid FKOEMLCFAOB;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid AAKCKNLNFFN;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid ADFICKKIEFB;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid OJOPIFCIMDA;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid GNPMFBJGPMM;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LBFHPKILCBK;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid NHJHLDGAIKB;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid IOELDJJDFJK;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid NFAMDLAFCGH;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid BGMGHLKOCDG;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid GGAMNLGCCKI;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid FOMBAHLGLPO;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid OJNMCJOIPBD;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid MKKONIABIIA;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid PPLAAPDGDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid OHFPJLJAHPE;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid APIEPFAKAGE;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid MLGMEMDHFPG;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid KNLONEJICCP;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid NAGDJEMKLDA;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid IKMLGDMOGOC;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid NIKJPOKOCPL;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid AMAILAGPNII;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid AFFACMMNLNA;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid CHPPGJAKGKG;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid AGMGNFAOFID;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid GJDDFDBMOHH;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MHNAEHFEOEE;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid NDJJDDDJLNI;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid OLEOMKFFCLI;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid FFEMODKJAEI;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid OIONFEFIBEO;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid FPGGLBOBFMI;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid EKBKIKIOFHM;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid HDLOPIOMBCF;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid CNFAFKKEPFG;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid CKKCLFALNNN;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid DBDBDKJMIBL;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid DFFMBIAFKHC;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid OAIEDBCPJGL;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid OMMEHFIAKMC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid MHPLHFNDKHJ;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid JAJEABHAAFE;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid CLCKGLBGMHD;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid EBJBJFCNFIF;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid BGAFHOHCEDM;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid LFFGGDFHDFL;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid LPHEGBKGPIL;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid AJEKMNGFJOG;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid IJAKEJNAMBA;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid JLMHJIKNFNG;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid FJLKAJMOJAO;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid MLDLKDJNAGO;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid BJACBLJENNM;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid PIFGIKPDGOC;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid CFHHCIDEOEH;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid PLBLIMOMNBC;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid ALHNIAEOEFE;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid KHMFCABHJBD;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid NOAGGFHCJKI;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid KJHMJHJBBHF;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid PMCCEEFAFAN;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid EDFAKMAFPPC;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OIEFAEBHDAH;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid CNMAAJLLFAC;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid KPPOPFOHNCE;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid CKDLOAGFJDC;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid EILLKLFKCFG;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid IHFOMANBFBF;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid DFOBCIIMMLJ;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid BGFDLOEIJEP;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid AGJMBHHPFJM;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid CEOLADOACHF;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid KJLLKLNCMAN;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid HHJCKFJDAEE;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid NCJIFNFKKMC;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid OLFBEHNCOFE;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid FBHDGHAECEJ;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid COJIDMEEMOH;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid KNALFGADDMB;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid CMOOOGEEKJL;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid MKDDKHAOIGJ;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PBELKEJKJOA;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid FFFIDMKEEID;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid LPHMMCCCIPO;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid HFKIFDNLBIM;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid KOBBDAIOMHA;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid DBPJPBMBADB;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid OMCKOANHDIN;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid CGLBMNKFNIO;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid PKBLOAMDAMB;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid FDHBPOJINCP;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid MKMNPJHHMEP;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid ICKIBNLMEPO;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid GJPHOKMLIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid JGNIMNGGHDN;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid MHEINHCMJGK;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid HGDABDJKKMC;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid HCKMFHEGAPE;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid EEOFHLIICDJ;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid DKHHGJKFPJO;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid CBADOBJLNNN;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid EKEDPHPJINH;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid KONFDAJMIFH;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid KPBLIKNJPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid JBGKHMPEDGK;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid GFIBENAMMMD;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid EBILBJIGHHM;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid LHPDLNAKLHM;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid EBMBLAMJCEA;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid JACHLJMCMNL;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid IIBAIDPJJFK;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid COCGKCPLEFN;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid EAMDBOKNIGF;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid NNKPIECNNLG;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MHNBDHJABCF;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid HCCKGDBBLDA;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid ENPGNNFKJJN;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid LMOBNJMIHOI;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid JHOFOEHECHM;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid HMPFHCNECED;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid LLDDJHIJLOM;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid JBKCDGDOENO;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid LGIPNGMOJAL;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid HLGIHLAOKNM;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid BGNACNMKJAD;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid EMCDBFOLPNO;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid MOOPLFOIPBB;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid KEHHKPAEBDB;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KGALGNDBGEK;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid FBEPMDLGENC;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid CLILMNFOIOD;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid OAIOLPDAHIH;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid HJMLADKHLFI;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid IMANMIJDEGA;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid AEBHNACOMCA;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid MFKOKCEHKBH;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid GAOBGKOHHAJ;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid LBLFBBNMKEP;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid PHIOLGIEMJE;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid BMLOHCBNFIH;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid INBHLHAFOGK;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid GIKEBNPDOCA;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid FILLOABECCE;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid GDOIFMNCMNJ;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid KPADCOCKIFP;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid LKLOHIFDKAD;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid EIDLBAABLAE;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid MKNCCOAFEKI;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid PPDKNNADCLJ;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid HAAGCHOFDJA;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid JPPGKPDPEHJ;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid GGMKFBLBPKK;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid NDNGAOOEHCM;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid OKBFDJMAOLL;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid MOFCJECEDMC;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid ACOHPPKIENL;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid BDLCHHNNNCG;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid MOHLFEGNPEC;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid FAPNCGJDNBC;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid AKANJKJIEAM;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid AGGEGDIBHII;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid LJMGJAFDGHI;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid BDMMNMPCKAP;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid IJOOOFAIFOD;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid CHLHPGCGHEM;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid NDKNNDKNMNJ;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid INCPIJPBCHD;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid OHJLKMOBIPE;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid KGLOGIFCIAL;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid PJDEAPAJLLC;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid OCPOMGNBEOI;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid BJHBLAIBAPC;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid FCCPLPIHJAI;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid CDKJHECDFCE;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid CLIPONNHLPC;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid JGDOAGHLKAE;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid COBIKGEOBJD;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid GLAHHLEKPON;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid NOIOAFLFNAE;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid CHBADOLMAON;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid GILLEPICCHA;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid DGNOJALEBFE;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid DNLDCFNBMMC;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid HEANJMDHIKE;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid DICMMBHNKMD;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid COEBLBGLJGE;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid IOBIDAINFDG;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid LOKECLPCJEP;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid GKMOOOCAKPL;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid IKCJCADEDKN;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid OKBONBAEAJP;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid NHIPKHFGFPE;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid FKJGBCKIPKO;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid KDBBKNMKKBD;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid FALNHKDHLFA;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid NBBCJMENNOI;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid PABEMONACPN;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid HPHIILBAJKM;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid LDKGENOPHLA;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid EHKOEAOCFAF;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid BDHPEBHELOM;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid HBIMFAEDDIM;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid HEHFPHGBJOK;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid OJHBAPJECIB;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid FOHGAHJAJCF;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid FGKJINMEMDN;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid FPFCNLDEAGB;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid MHHEINPJLLH;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid BJABPLNPDPI;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private static readonly Dictionary<Guid, LKAEJDFICGP> IKGELIGBNPL;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private static readonly Dictionary<LKAEJDFICGP, Guid> BKBBJENOJGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, LKAEJDFICGP> ELEIFCBILPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6173F00", Offset = "0x6173100", VA = "0x186173F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<LKAEJDFICGP, Guid> IPKINJIMBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6173EB0", Offset = "0x61730B0", VA = "0x186173EB0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MEPOMIEOECF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x618BBB0", Offset = "0x618ADB0", VA = "0x18618BBB0")]
	public static bool MFMHOBPJNJD(NIJENKMDMAI ALEDHJHCNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x618B800", Offset = "0x618AA00", VA = "0x18618B800")]
	private static bool MFMHOBPJNJD(NNLPGEPCFOF BGFJJEOBCAB, NIJENKMDMAI ALEDHJHCNHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JBBIIAPGHIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public readonly AAJEDNIHHDO HEAAADOPOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public readonly IEnumerable<EEMANFFCIOG> MCCFPKNFMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly IReadOnlyList<EEMANFFCIOG> APCKKIFJMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly EIPPGFCFCGI<LOIIILALBLN> AHMPLFEDHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<BCFHHBLPOPP<FKGCAMGPCBC>> AHACMJDDBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly ByteString OMAOJGLOPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly OPJOCFHFLLA EHGCJGGPPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly bool EBEIMLPJPGC;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6177230", Offset = "0x6176430", VA = "0x186177230")]
	public JBBIIAPGHIO(AAJEDNIHHDO DBMIJAJELPG, IEnumerable<EEMANFFCIOG> PJICPHGJFFE, IReadOnlyList<EEMANFFCIOG> EKNFJNCBMGJ, EIPPGFCFCGI<LOIIILALBLN> GPAAICGCEIL, IReadOnlyList<BCFHHBLPOPP<FKGCAMGPCBC>> LBAFPHNFFDO, ByteString EFLKNBOMMAO, OPJOCFHFLLA FGFPNMCDCBP, bool OLEMMEGLKMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OEMFDJPICBB
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(ANJHMDMMFJH FODGEDCJIDC, [Out] Dictionary<int, int> NBLIFNIMEKC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(ADGDLBLFAGN OEPDFMOAJEO, DBKLPGNABPH MGAHHGNDDED);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NINELNLICPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly Guid LGMEHBOKFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private readonly Dictionary<Guid, Guid> PAPEHHMEANF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> EEIKAIGMCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36AE270", Offset = "0x36AD470", VA = "0x1836AE270")]
	private NINELNLICPK([In] Guid NAICHLCHJBJ, Dictionary<Guid, Guid> OECCJONKKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x618BC50", Offset = "0x618AE50", VA = "0x18618BC50")]
	public static NINELNLICPK GHNALICEFFH(IReadOnlyDictionary<Guid, Guid> JNALPCOIMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x618BE20", Offset = "0x618B020", VA = "0x18618BE20")]
	public static NINELNLICPK IIDACBHGFII(IEnumerable<KeyValuePair<Guid, Guid>> JNALPCOIMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x618BD70", Offset = "0x618AF70", VA = "0x18618BD70")]
	private static Dictionary<Guid, Guid> HLMNMADLHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x618BC60", Offset = "0x618AE60", VA = "0x18618BC60")]
	public Guid HJKMIENEDAL([In] Guid IKOKEKHMFKH, bool IJHOFPEJCCJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x618BBE0", Offset = "0x618ADE0", VA = "0x18618BBE0")]
	public bool EHJNDPFOPCD([In] Guid JNIKIHKLGAD, [Out] Guid IIMAPLONOBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EBEMAELDIDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JDLAAFJNJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKMADFBDLGL(ByteString NBPNGOIAHPG, NINELNLICPK HOGMGOPALOG, [In] UniformTRS BGLCPHDPOHM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HIPBKEEIMPD
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
public class LFCLFAEAHFH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1380DC0", Offset = "0x137FFC0", VA = "0x181380DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EHPBFCKLNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xEAF0D0", Offset = "0xEAE2D0", VA = "0x180EAF0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long HMPNICGHDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61774D0", Offset = "0x61766D0", VA = "0x1861774D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E90B20", Offset = "0x5E8FD20", VA = "0x185E90B20")]
	public LFCLFAEAHFH(long KIGJDGACGDD, long FFNONNEDLAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LNECKFHMMBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private Dictionary<Guid, LFCLFAEAHFH> HIILNFJIKFC;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static Dictionary<Guid, int> ABOILHOMLMP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long NNKAHDPOHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xEAF0D0", Offset = "0xEAE2D0", VA = "0x180EAF0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long OICAIAEHJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xF26B70", Offset = "0xF25D70", VA = "0x180F26B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61774F0", Offset = "0x61766F0", VA = "0x1861774F0")]
	public static LNECKFHMMBF IPGIEOBEIDH(AAJEDNIHHDO LPLKMECEEFP, BCFHHBLPOPP<LOIIILALBLN> HMLDOHHDHFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6177B50", Offset = "0x6176D50", VA = "0x186177B50")]
	private void OIAKKGBIJFL(NKPBMKEEPNC CLKPBALPCKM, long FBCNMDJDIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x618B770", Offset = "0x618A970", VA = "0x18618B770")]
	public LNECKFHMMBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LEBKPDHFNPM
{
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly HashSet<LKAEJDFICGP> HFIGIJGALOC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LNFNCOALMPF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> HNHIKKDAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> CPAFDBCGKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
	public LNFNCOALMPF(IReadOnlyDictionary<Guid, Guid> CPPALFEFHNJ, IReadOnlyDictionary<Guid, Guid> OINMDFGJAMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JANDBCHPABN
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6175710", Offset = "0x6174910", VA = "0x186175710")]
	public static PGFFFNCNGHF LFKPLFOOMCJ([In] JBBIIAPGHIO LDMEJMNDBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6174DD0", Offset = "0x6173FD0", VA = "0x186174DD0")]
	private static void IOPFBHHKHKF(PGFFFNCNGHF MGKEFFKGNEB, [In] JBBIIAPGHIO MCPGBKFLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6175B90", Offset = "0x6174D90", VA = "0x186175B90")]
	public static bool OIMOBIJMJFK(PGFFFNCNGHF MGKEFFKGNEB, BBHNPNLOLIA PCDAKKFIGAL, NINELNLICPK? HLNBDKCANBB, [Out] LNFNCOALMPF? OECCJONKKLF, [Out] string? BKDLFDLOKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6174690", Offset = "0x6173890", VA = "0x186174690")]
	private static void FEMDBLGOANF(PGFFFNCNGHF MGKEFFKGNEB, NINELNLICPK? JAGBPPCBHNI, BBHNPNLOLIA PCDAKKFIGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6175B20", Offset = "0x6174D20", VA = "0x186175B20")]
	private static void MFGEFHCPBFF(PGFFFNCNGHF MGKEFFKGNEB, BBHNPNLOLIA PCDAKKFIGAL, IReadOnlyCollection<ByteString>? IHAGBCEBEPO, IReadOnlyCollection<ByteString>? OCOENMIMGPM, IReadOnlyCollection<ByteString>? IGFMLBDFNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6173F50", Offset = "0x6173150", VA = "0x186173F50")]
	private static bool AOACIBEMEAM(PGFFFNCNGHF MGKEFFKGNEB, ADGDLBLFAGN OEPDFMOAJEO, BBHNPNLOLIA PCDAKKFIGAL, [Out] string BKDLFDLOKJH, [Out] Dictionary<int, int> NBLIFNIMEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6175430", Offset = "0x6174630", VA = "0x186175430")]
	private static Dictionary<Guid, NNLPGEPCFOF> JMIFPPHIFBI(PGFFFNCNGHF MGKEFFKGNEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61745F0", Offset = "0x61737F0", VA = "0x1861745F0")]
	private static void BEMHIIHMFNH(bool FBNLBKJPACF, EEMANFFCIOG BDCBKPHIOMI, Dictionary<Guid, Guid> OHDCGEJMHBC, NINELNLICPK IIHKONLMPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6175890", Offset = "0x6174A90", VA = "0x186175890")]
	private static void LIPDPMJEEHE(EEMANFFCIOG BDCBKPHIOMI, Guid GCKBLHFPCPF, CGPFPGPKCCI? JPAEKMLDMBM, Dictionary<Guid, NNLPGEPCFOF> JHBCGFPPAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6174920", Offset = "0x6173B20", VA = "0x186174920")]
	private static void GJKGAGPJBEA(IEnumerable<EEMANFFCIOG> EOLCDJMMJIP, IReadOnlyCollection<ByteString> IHAGBCEBEPO, IReadOnlyCollection<ByteString> OCOENMIMGPM, IReadOnlyCollection<ByteString> IGFMLBDFNKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BBHNPNLOLIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public bool FBNLBKJPACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public OPJOCFHFLLA FGFPNMCDCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public CGPFPGPKCCI? JPAEKMLDMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public CGPFPGPKCCI? JGKOBLJKJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public AAJEDNIHHDO CHKENCEIODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public HIPBKEEIMPD KGLMFMCJJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public OEMFDJPICBB MLFFGDFDPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public EBEMAELDIDI PAGGFCPKOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public BCFHHBLPOPP<LOIIILALBLN> PPIHACGMDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public NNAAFNOPBFN KFJFHDEGFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public List<EEMANFFCIOG> CNIPDGLBEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public Dictionary<string, object> BDCNCLAMLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public LOKFGNAAFGH KGEOHMJJIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool OALFBPAAFHL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool JGIKIAPJCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6171F10", Offset = "0x6171110", VA = "0x186171F10")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CGPFPGPKCCI
{
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private const float PNHBOIHCONF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public Vector3 DHMMMGDKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public Quaternion HBCECKEGCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public float EKCHLHLGOBO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 JNKFHJLOPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6172180", Offset = "0x6171380", VA = "0x186172180")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS DBCJJFMKOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6172290", Offset = "0x6171490", VA = "0x186172290")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x9EC7F0", Offset = "0x9EB9F0", VA = "0x1809EC7F0")]
	public CGPFPGPKCCI(Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH, float EKCHLHLGOBO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6172860", Offset = "0x6171A60", VA = "0x186172860")]
	public CGPFPGPKCCI(UniformTRS NHKHAOAICJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6172360", Offset = "0x6171560", VA = "0x186172360")]
	public static CGPFPGPKCCI LEOMECCNMAI(CGPFPGPKCCI BHNONFFBKHO, CGPFPGPKCCI NKGDACMCKHJ)
	{
		return default(CGPFPGPKCCI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6172740", Offset = "0x6171940", VA = "0x186172740")]
	public static CGPFPGPKCCI LOOIAEAGNBK((Vector3, Quaternion, float) FODGEDCJIDC)
	{
		return default(CGPFPGPKCCI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61725E0", Offset = "0x61717E0", VA = "0x1861725E0")]
	public static CGPFPGPKCCI LOOIAEAGNBK(Matrix4x4 FEAAHMGJJJE)
	{
		return default(CGPFPGPKCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61727D0", Offset = "0x61719D0", VA = "0x1861727D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6171F60", Offset = "0x6171160", VA = "0x186171F60")]
	public CGPFPGPKCCI AKKMCILJEJM(Matrix4x4 GCDMIBEHAIO)
	{
		return default(CGPFPGPKCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6172760", Offset = "0x6171960", VA = "0x186172760")]
	public static CGPFPGPKCCI NAJHODBOGIJ(Vector3 DHMMMGDKPCG)
	{
		return default(CGPFPGPKCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61722D0", Offset = "0x61714D0", VA = "0x1861722D0")]
	public readonly LHGJHELBJFO KCBECFILEBP()
	{
		return default(LHGJHELBJFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DNDPECHFAOI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6172930", Offset = "0x6171B30", VA = "0x186172930")]
	public static CGPFPGPKCCI JACOFBIDJED([In] this LHGJHELBJFO KNKOEEEKHDK)
	{
		return default(CGPFPGPKCCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class OLIHEKMLBFL : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x618CB10", Offset = "0x618BD10", VA = "0x18618CB10", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x618C250", Offset = "0x618B450", VA = "0x18618C250")]
	private void AHKPDIEFHGJ(Dictionary<Guid, Guid> KPFHOMPJMDJ, KBBFGEKGBBF NHCFIOLHDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x618CAB0", Offset = "0x618BCB0", VA = "0x18618CAB0")]
	private void AHKPDIEFHGJ(Dictionary<Guid, Guid> KPFHOMPJMDJ, DLOBCIFMEED AMHBFCMAMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x618C830", Offset = "0x618BA30", VA = "0x18618C830")]
	private void AHKPDIEFHGJ(Dictionary<Guid, Guid> KPFHOMPJMDJ, HOGIAAEINJP PGGAHHKFOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public OLIHEKMLBFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class EJHFOHHEHLC : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x618E4E0", Offset = "0x618D6E0", VA = "0x18618E4E0", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EJHFOHHEHLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class LACBGDBIBIH : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x618F920", Offset = "0x618EB20", VA = "0x18618F920", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LACBGDBIBIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class OOGIKAHNGKG : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x618FF80", Offset = "0x618F180", VA = "0x18618FF80", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public OOGIKAHNGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class OOCIGMIICBG : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x618FD60", Offset = "0x618EF60", VA = "0x18618FD60", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public OOCIGMIICBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class EBNBHPCPEGA : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x618E3A0", Offset = "0x618D5A0", VA = "0x18618E3A0", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EBNBHPCPEGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class DFELMKGFIJA : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x618E210", Offset = "0x618D410", VA = "0x18618E210", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public DFELMKGFIJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class DBEEJILFCBN : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x618E120", Offset = "0x618D320", VA = "0x18618E120", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public DBEEJILFCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GMEIEFJOMFF : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x618E630", Offset = "0x618D830", VA = "0x18618E630", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GMEIEFJOMFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class MMDKHLAOIMN : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x618FBB0", Offset = "0x618EDB0", VA = "0x18618FBB0", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MMDKHLAOIMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class AEJKIEOAMKH : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x618CC30", Offset = "0x618BE30", VA = "0x18618CC30", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public AEJKIEOAMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MEEILADHPML : FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly IKPENMLDIJD BFKKLKICKEM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x618FA80", Offset = "0x618EC80", VA = "0x18618FA80", Slot = "4")]
	public void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MEEILADHPML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct NIJENKMDMAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public ADGDLBLFAGN LOGOABBJBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public FJEMDPAGDJJ GLCNMDHEMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public Dictionary<int, int> BLLLNNLKHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public Dictionary<Guid, Guid> HLCMOBHHJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public LOKFGNAAFGH KGEOHMJJIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public bool NJHOMAGMEKE;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FNBLOMFBGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMLAICDGDLM(FPIEFHAHDIJ BEHJFMEIICE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class IKOAFMJDLLH
{
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly FNBLOMFBGMN[] CEAJDLDMCFL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x618E7E0", Offset = "0x618D9E0", VA = "0x18618E7E0")]
	public static void EFHAAJIACPB(EEMANFFCIOG FODGEDCJIDC, Dictionary<Guid, Guid> LBEALMFFCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x618EA70", Offset = "0x618DC70", VA = "0x18618EA70")]
	public static void LAEPIPACLEL(EEMANFFCIOG? FODGEDCJIDC, NINELNLICPK ABPDAMAOCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x618ED00", Offset = "0x618DF00", VA = "0x18618ED00")]
	public static void LEPBHJDGACC(EEMANFFCIOG? FODGEDCJIDC, NINELNLICPK IIHKONLMPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x618EF80", Offset = "0x618E180", VA = "0x18618EF80")]
	public static void MFMHOBPJNJD(FPIEFHAHDIJ BEHJFMEIICE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FPIEFHAHDIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public ADGDLBLFAGN MKFPHBMEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public EEMANFFCIOG BDCBKPHIOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Dictionary<int, int> BLLLNNLKHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Dictionary<Guid, Guid> HLCMOBHHJKC;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x618E590", Offset = "0x618D790", VA = "0x18618E590")]
	public Guid DANGLMAAKNK(Guid IKOKEKHMFKH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LOKFGNAAFGH
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int ILAICKMJGFH, [Out] Guid BMOOKNBDABI);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class BMLAADAJJOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private readonly HashSet<string> DOACIPOKGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private readonly Dictionary<long, int> JIMEDPGOANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private readonly HashSet<Guid> LFCADCDPFPP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<string> OIIMLLENOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> HCBHOKHLIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x618D160", Offset = "0x618C360", VA = "0x18618D160")]
	public static BMLAADAJJOP GGHHJAFDGJJ(LJKOKHIIAPB JENPAMGBIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x618D0F0", Offset = "0x618C2F0", VA = "0x18618D0F0")]
	public static BMLAADAJJOP GFAINGAMFCO(PGFFFNCNGHF DMBGMCLIICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x618CD30", Offset = "0x618BF30", VA = "0x18618CD30")]
	public static BMLAADAJJOP AHALBBHDBMF(IEnumerable<string> DOACIPOKGNO, IDictionary<long, int> EPLLFNOGGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x618DEC0", Offset = "0x618D0C0", VA = "0x18618DEC0")]
	private BMLAADAJJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x618DFE0", Offset = "0x618D1E0", VA = "0x18618DFE0")]
	private BMLAADAJJOP(IEnumerable<string> DOACIPOKGNO, IDictionary<long, int> EPLLFNOGGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x618DAF0", Offset = "0x618CCF0", VA = "0x18618DAF0")]
	private void JMPBJEBHKOI(LJKOKHIIAPB JENPAMGBIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x618D900", Offset = "0x618CB00", VA = "0x18618D900")]
	private void JMPBJEBHKOI(PGFFFNCNGHF DMBGMCLIICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x618D5C0", Offset = "0x618C7C0", VA = "0x18618D5C0")]
	private void JMPBJEBHKOI(NIPPBJMNOKA? MIAAKEAGJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x618DCF0", Offset = "0x618CEF0", VA = "0x18618DCF0")]
	private void JMPBJEBHKOI(LPOODDAHIAM? CLKPBALPCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x618D1D0", Offset = "0x618C3D0", VA = "0x18618D1D0")]
	private void JMPBJEBHKOI(EEMANFFCIOG? BDCBKPHIOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x618D080", Offset = "0x618C280", VA = "0x18618D080")]
	private void DBOPDPPEDHF(string? MLCDFCGDKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x618CFA0", Offset = "0x618C1A0", VA = "0x18618CFA0")]
	private void AKBNEFEJJLL(AJPDLHEBEKD? CONAADOHGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x618CEB0", Offset = "0x618C0B0", VA = "0x18618CEB0")]
	private void AKBNEFEJJLL(GAANOKALBFC? CONAADOHGBG)
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
