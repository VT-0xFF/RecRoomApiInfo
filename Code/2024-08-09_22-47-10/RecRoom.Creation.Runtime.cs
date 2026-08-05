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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x688AB00", Offset = "0x6889F00", VA = "0x18688AB00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NLGIJPIBFLM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> GCPOFCOFKFF;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> AHACMJAHNBN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> PPCDBPCNKGH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string JNHCANMNPEN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string DAMAPNAKIIL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string NJIELKBFJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6889350", Offset = "0x6888750", VA = "0x186889350")]
	public static bool JKELEDEOJMO(Guid GNIICFDBCOK, int ADDJNCAMNAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6889B20", Offset = "0x6888F20", VA = "0x186889B20")]
	public static bool NMDKGIMEEIL(Guid GNIICFDBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6889450", Offset = "0x6888850", VA = "0x186889450")]
	public static string KKOEGHBIIFP(Guid HLKHAOEDAIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[IHAGFOIAJNN]
public enum PJIFDLPIBHL
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
public static class JPJJNOIGFML
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid EGJFBFFMJJG;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid OKFOHEIBINN;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid EBAELAHIFIH;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid HDGHGEDFMEA;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid DFBANMELIEJ;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid HHMJOLAHLAH;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid KEHONKNEMDG;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid LEGCGCNBHFN;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid JJGEJELNBPB;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid CFAHAAMELFN;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid CIIFCKBHLEN;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid ANECPNMHIPL;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid AHJOHHGHOLC;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid BHBGJPFEENC;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid GCNHLMDMMGJ;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid LCOJCBAIPFG;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid PPMCEIDFEGM;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid NPBDDDBGCMI;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid CLJEOOLBJKC;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid CANEGEGMFNF;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid GCNILDFKPLE;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid CAFEAKDKBNO;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid LMLIJGPANFM;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid FOALCAIGJFH;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid LAELJDAKLOB;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid FNBMCKKAPJE;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid AEDKMFJFCHN;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid PIHNEDKCPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid FJOLODEHHFP;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid DILIMCEDBIC;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid CCCDNJKNAJA;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid KJGBKEAHNHI;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid CJGMAOIFCOA;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid GKALEKCPLKL;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid IBNJCFKKLBO;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid FOIAHDCCOCK;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid NAAPGIGGGOC;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HADALDNNLDB;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid BAMKNOFLOJJ;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid PNFLGDJPICE;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid JGLCHEIPNNL;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid BHKDBECEJCI;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid JCMFCONGKEM;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid HNNIKILFCNE;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid FAJAKMPKOFJ;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid EBCCAOIHJMM;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid CCFKPDJEBHD;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid FOLMLKDDOIC;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid LHLBOEMOJJN;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid LOBPEMOFFIC;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid IBOFDMELNKB;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid FFJDECKLNLG;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid JEMHKNDPENL;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid KCJOMMOECOH;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid DJGHEFOFOCF;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid LBMDOMCAMPG;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid KJCLMLJMNBJ;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid EABCHCPCAEF;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid DCJEKEOCEJJ;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid CGHCPDBKHLN;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid GFNCMDKOIIH;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid OFDPNHECDOC;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid PLOCKLELLIJ;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid BHEKOIHNDJD;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid FGMJBMCLFOG;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid IANJKJIHKKC;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid DKKGJANOFML;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid DMMHDHFBHED;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid PAFLMHIJJOM;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid FPBAHKBAIBJ;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid LKPKHOKFKCK;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid GCIPFMLKCKP;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid IGEECJODOHC;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid PGJPCHPOBAK;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid DCMLOBFBEKF;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid OADCFLGGGGO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid KLPEKKLIIPL;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid LCGLOGMGEOM;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid NFCCHLJEJKB;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid CGKPELFLLAG;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid NIHCGCINDOK;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid AHEBCJLJGFC;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid JPFBOAKCGGD;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid DDJKMFMHCKC;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid LHICALALOKJ;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid CNHFCHPFGGB;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid DENDDAIFNFF;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid OLBBMONLGFP;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid FKEJAKAFDCE;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid BOBBACFCCLG;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid HGDLFOFHNJK;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid AJPIELEJEGA;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid EBGAFGLAGFB;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid ADLGNABMCIJ;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid LHHCDNDCKKO;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid LHGDCHGKJIK;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid PJNKEJAJAIL;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid IBCFPBPPFFF;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid BIPOEDNMJAK;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid IFLANPADEGO;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid BFPFILEOBFK;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid PAAKGGOHLIF;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid ICACCEBEMOD;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid OMCNEPAEMJH;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid GOHHPDIDDPH;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid NKMDGHAOODB;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid MHGMGFCLCOE;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid JGAIMCNMFBK;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid OBDCKNDJHED;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid OBMIEIKJGLE;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid HKKIFCDPOHC;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid IEPFJFGNOFJ;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid HEEKOGPCNPD;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid PGIOGJNMMPK;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid PHKKCODDHCP;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid KCGPFMNGNLE;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid LAHDGKNGCOH;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid IDAOLCGJLGN;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid KHOOGCFJEOE;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid GAOHLELDNIK;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid GKODPLEBBBH;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid KEPINEODCNI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid KLIEBFNLPPD;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid JGBNDMKANFH;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid KBMNGFONBKJ;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid LHFBFJIHJGD;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid GIEBLLNFKGL;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid FDBOJINFKPP;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid NDNBHKFFCNN;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid EMLIEKMBHDK;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid HLAPKGILDNH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid OJGMPKLCGFH;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid HOGAGANIADO;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid OOKDMLNGPND;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid KLFIHLOHDCO;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid MJAJDPGDLAE;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid ADLIAKPKLCI;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid JBBNJEAHIJD;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid BAJFOABCLBF;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid PKFBCMMBCDP;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid PGGCAIBMJJF;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid PMFFCKEFEEN;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid CEEPOMLFGGO;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid ABCFDENFHPA;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid DPFHBMFFFDI;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid LIEEMPELJAD;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid ICABAEAMGBK;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid HHPLBACDBNN;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid FFOCMAOJIIE;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid KDOBEOAHDDL;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid BLMEDINBDPO;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid OMLLGFDDELL;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid LFKGAOCLKBC;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid DPMKFDOBBLA;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid FMLDOEBABMD;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid ONFFPPPPDNP;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid DIIEKCPAOGC;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid FDMIKDEIBAN;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid PACKOGJHABF;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid MLNOBEKEPAB;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid FLMGDECGEEH;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid FOKIDIMFKLP;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid CBIIAFFBIHF;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid FDGMIPOIEDL;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid AHOHFBHKPKL;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid OPHNCOCMPJG;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid EDMOGKFNLNI;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid JLCBCIHHLLO;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid CMJDILMCOPA;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid NGHIDLAIBNF;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid BKCHMAHHKLI;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid CJEEOBPJOLE;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid FCADONONBKI;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid CDPJGJGPMBE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid DJDNGFALIMM;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid KLFOMCIDAHA;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid NIGIFEEPBBG;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid FOGBAAANFFC;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid IIEDFDEIGMM;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid BAAGPHFKPKJ;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid CPNIDPAKEBM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid PNIEOCACBPC;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid FNKIHFBHJDG;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid BJDPKIOOHFM;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid ENCAIOHFDDI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid AJOJFIHEHEI;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid COPMDKKEEMK;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid ENIMMKJNFFD;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid EOBNLFOIHDJ;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid DCJBAOMMOIK;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid FCJLCMLAABI;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid PBHGDKEBOEL;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid PMCMCBCPHOB;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid MJMAFHFMKDH;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid CCNDPMFGLKH;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid OLFDAIGAEBN;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid DHDNJIOKAPI;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid AOLJPCAAPEC;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid OILCIKNEEOK;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid JHLGCDMFGEG;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid ABKMFHCJLDN;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid NIJPKKJNNAF;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid BGCPLPHCIMO;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid FPPDLEKJOGG;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid IAFENIMLHOF;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid GGCILCLCFKB;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid KGIEFMJDKED;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid LOOFHMFKDIK;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid JJBAMFKNJJJ;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid JMACJHHCJKE;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid NAEDDDGBBGO;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid JEEGLAHBMID;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid ACHPLPAOLKM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid HFAKKAJBNMH;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid EBOKLGCICIM;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid BFJHNOOCKEM;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid LNDIOMDDDBK;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid NEACKEMBDHH;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid MINMGJNFOMP;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid OLJEPHMDAHA;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid FEODLNPKKHD;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid HILEHEKAGHN;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid EJFMLCPLJOM;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid ALJKBHNADAL;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid KFBDIKJKBOO;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid NPBNEOJHGAN;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid DMBEPLCIMHM;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid AMJMMLOLGNI;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid PDBIPBCLHEB;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid IGEJFNCGLAC;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid LBOIEHIDPDJ;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid GADJEBLGIDM;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid HLCFCCPEMMK;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid DBOPCKHCGOH;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid ANKFCDPDJCI;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid OGDIJJGCDBK;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid DOAAHLHNOCI;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid LLEGFGLLINO;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid JEEBFGMJEAO;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid EGDFLKBDEHP;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid ADIFPOOEJOG;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid DKBJHGIBLJI;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid DAHIANJPHAB;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid AMFPNHHANGK;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid CBAJJKMDKIC;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid EONBOHFHLII;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid KIBKGMPOIND;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid GIPEHLFNOMM;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid LPJGNONJBAI;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid CDEHBBEBKBA;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid AJMMLKKNABB;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid BEEIOKBDIIC;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid BLIELKPDOPF;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid LIGLDIEPMOE;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid ELPNFCINPHE;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid FPFJFGHNMDP;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid CDAPCAMAEEL;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid NOIOKIHNJKM;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid PBBKKNGCALE;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid LOEKHNLKFGP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid BAGCDINBNJB;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid BELDPPJNJLG;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid NKFMFOOOLNJ;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid CKHHBKDOBEB;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid KDLKMPKGFMO;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid INKLPAAAOMF;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid ECELIKDIPBG;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid FKJPHEMLFFE;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid DKHBIFCOEHD;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid IGNHELLBCJC;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid IFKEFGIGOON;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid AGHFDMAGNKN;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid JIBFLJNCKEG;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid PKDJHHOGDBN;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid JNEODOFJKPJ;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid GHALNJENGGI;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid GGCPKOKINIE;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid PMIAMGGOCMG;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid PEAPFDOOCGM;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid MCHHGJIJFKA;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid PEECHJIGNAF;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid GGOFHINGCAH;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid AOEHJGPGAGK;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid CONMDBFBFMJ;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid PNDKBFADECP;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid ONCAEAIJHBH;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid ENPGAMDMPBB;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid FDKAFJNDHKL;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid PEHCEFFKIIH;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid AHNODFJFDBA;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid CDANIHIGLOH;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid KHHJKLOPPGA;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid BGFFIAHJGBJ;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid MCPCLJFAPPM;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid CFPLCMFHIHH;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid DLPKEMHICGG;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid MCLODKFHKKO;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid HCKLJMJLHIE;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid PMCNDJHMMBE;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid BPJOICFNNFM;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid LDBADOLJAPO;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid BMKOJPPOMDC;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid IBPLAIEFJGG;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid GDNNNEECPNK;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid EAENMPMCFAJ;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid GEKIGJOCMFH;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid LOFDIHFLGBJ;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid HFAHLDFAOCF;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid KPKEBGLMFBM;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid HODEBIBIBJK;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid HJGDEGCPNKL;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid HKHAHDHDCPL;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LEPOENDDACA;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid OFBBJJOOGHE;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid IMNJJMELDCJ;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid KHCNEDMHBAH;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid OLMNICAJJHE;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid HMJICBPJBGB;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid JGHNKMALFAD;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid DKKOJIJEBNL;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid PCKMIFOLEAI;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid JLOFBGEIIJC;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid EPBCNPKNKOC;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid AFGACABLMBA;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid BHCIEABDCFP;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid LJJIFMDHAIO;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid KILJNDPFIOP;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid HPIKCNNIEDF;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid AJDDIOLABFE;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid KHOJLAHFPEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid OBHMDGFFEHL;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid MCCNLFPKDJK;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid NONCAAEKOPE;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid LCFLLIJBFCD;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid DBELFFDFKPL;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid IDOHICDAJAB;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid PAKNGOJNGJM;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid OOOPLLMGBFA;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid EPLDBEBLKDF;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid PEAGLOFDEAB;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid NPHBBAFCAMN;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid LDDADGFNNGK;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid GMNOHMJEFJD;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid ACHCGCDBNEK;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid BFFPIOMBOJK;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid DOBGOCLEDMJ;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid AINOJJJCEBG;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid LCKHOAMIDLA;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid MELOPAEMIFI;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid FOMNOBJDIGB;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid ALLKEEOLGIG;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid KHNPCFAPPDE;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid OIELODNBOFO;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid HMANPIPOKJN;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid DIIOHAPGBIA;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid MNMOMOFEFNG;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid DHBDFOHEKOO;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid LKCBDNAHEDC;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid IHIKEOGLGCG;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid DJBKJHDMNDD;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid HHNOHFIEGNN;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid JCBBMLPDMEA;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid KCEKLBEHHHH;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid LGCKIDBBNKL;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid HCOPHPOPAFA;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid EKLLLDNLNOF;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid NDGJDLBKBKD;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid DBPGAAIPPAJ;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid GLKEPKFAGJF;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid ABPPNPMENDE;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid DPHFEGJIFNB;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid FPPBIMBGGFJ;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid FNHFAOOECDB;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid LLDCBADBJCC;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid NMOLBKHINKP;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid EJMCECFCNJF;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid CAJFFFHBDDO;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid FKCOMMHGJKO;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid BNDKNHHHADE;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid CGOMIDNPDIH;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid ILNCOBGFIOK;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid AJACNLJEDNE;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid PLEGOAJPANH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid DENFIOKCCEA;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid PPNGMBHFOBJ;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid FEPCMOHFLKM;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid PKCEDKLEBHI;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid NMACEJKCCJK;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid CHONIPJHKBK;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid PLDGEMGKBPF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid PPFDJBKIFLL;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid ODDGAFILICB;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid HKMAKDNEALD;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid FNMJHBPFANI;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid EBPNNFABACD;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid LEILOHACKOI;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid ELMJEIIGOIG;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid LMEAHDMMOFC;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid KLDAIDGIHBJ;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid CHCMNBNHFJN;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid OHOHHJJHEGB;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid AAJDGPIGCOP;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid ALAHMDJCKOA;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid AIDCCEGNLFA;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid LEHONBMKIFG;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid CLIIKCPGKBG;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid CGDPOJBGJNK;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid LEFMJJCDFIO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid IMODLEEOENP;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid FNPBIHNCIMK;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid DNABNKLEACI;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid FJGLBOBKBFL;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid NGJGEONBECE;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid ADOPNIPNBMB;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid BHBKNDMJMIA;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid KMDEDDCLPCO;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid CGKLBCILECJ;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid CJPEPJAOJJD;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid ONFCLIJAPKI;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid JGCFNDAOHLP;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid PALLFFLPACJ;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid NILHBLPEKOB;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid JEELMBNFDBI;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid OMLOJCPHHGI;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid OKJMIJDIKPE;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid JMDDIIBEJPI;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid AEJAALPPPGN;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid ECJBIOGBLHM;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid DBPIFLLMKCI;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid KCJAAPABJFD;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid PCFLOFKNCHL;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid HHPIFCNPCFO;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid IKBKJFGBBDH;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid CDMHKOJGIOE;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DDAGHDOFHDO;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid AKJIEPOLIAG;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid JFMLCKPJJHK;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid CJBPNEDABIA;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid GOJCDPLKHCO;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid DIHHNKMNDEN;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid OHNAJPKJADN;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid NGPNMLIGMPC;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid JMPFKILNBFA;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid FHJNIKHFMJC;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid IHEGENGPMID;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid PHLIBJIECJE;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid JJFADPNMILC;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid JDNMAEEFEGI;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PBFGCHEHGLF;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid CEKHOBMKCKF;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid LGHHKNAIHEF;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid MABPCENEKCL;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid DLFCIMDEHDI;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid HMDDHHIIICC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid MIFKNEELPGE;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MGJGFCJFPOP;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid PMNMHLFGKHG;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid JLMNOGGCPAO;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid HHDHGKPAMFF;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid INBEEICJPDA;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid KBBNBGBDMBF;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid JEAHFIACGLB;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid LLFGANHAHGM;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid GELFCBHBFEK;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid HLEGIKNCNPL;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid FFPKFLONCKB;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid JAPGGHIEHLI;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid BEAKFKJGLKF;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid GGNIJICGJAA;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid JKEJBMEBMFF;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid DAHAGCNGIOH;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid KDJGDPIJEGF;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid DGKJGPLBACF;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid BBJKIOHDNBD;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid BMNHGIDAHAI;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid ALFDJFEOIGI;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid LNCICBFGGDO;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid LMCNAKKGFGB;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid MHJJKNMLGJH;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid KLDDHGBFBOG;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid FNGKFOLKHOH;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid GDDNIMOEIII;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid DEKGGHBJPNK;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid HCKJNGPGJKA;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid HIPICHAHNAK;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid IBOJDDLOHEA;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid MFLPIIBOILB;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LFGKIPPOHEI;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LKMLLAPEPCH;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid HCJIPKAHIEE;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid AABINIJBGJE;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid BBDHJMOPHHI;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid GJILANHENMP;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid JHIHFLIEBBF;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid JNNENABGDNA;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid DPHBFLDLKDK;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid AKLJJNNELPC;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid AIADPAHNIJG;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid MMNHHMMAFLO;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid NELJCEKEKEJ;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid HFONIBKMCBD;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid GBMADEDNBNO;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid POFHDPNFLDD;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid MNDDPJCFJDK;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid CKMDPEPKIIO;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid MJCKBPNNLJO;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid PLGGOAIBMPO;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid HOKGHGPELJA;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid KPDDEBNJPNK;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid LHGAMDDKDHP;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid DJGJCCBBEHM;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid EIMCPNIPPGF;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid FFJGKALFGPB;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid IPJMINELDMA;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid EFJNKCCMIJL;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid PBNBCKPCDIH;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid HNOHJDFPIBB;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid DNMBBCAEKMK;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid BHEOIGKHOKB;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid MMMMCHKJLDK;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid KHJGMKPANPO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid CABAPAAAFID;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid GDJDNNPINLM;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid HBBBHBJJHIK;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid APGNLKDAHDL;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid ILLEAMOHENG;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid FMCJPKKFNIG;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid EGDCPPHODPL;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid JAGGEFCKGOC;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid IJAPODGDELF;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid NPICKABPHEA;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid JCBBEHIOLGG;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid BHPOGFOEBLM;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid MAHMLMBANLE;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid BMHFKJCOCHC;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid EKGJLCCKHLL;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid KJGFKCBOKLF;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid CBFHDKHIFMA;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid NKAAGEECALC;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid DBKGFKPDNKD;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid DLEGMFOPGOD;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid ENCHFNCBKKG;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KMMHPODPGGC;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid KCEOMOOJOIB;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid EJMKHJPFKEA;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid MNMCMOPBJIJ;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid CCPOFPHCNPK;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid OPBFCCODOII;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid MDFJNNFNIKA;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid KFDPKHEKOPC;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid NAPFEEINPCP;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid ODBPIGOAFKI;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid CBDCMEELKNC;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid HEHPIADAMJO;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid GHLGMOLDEDA;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid LHHAGHIHEMM;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid NAAPAGOGBCB;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid GIIHBKLOIIG;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid MAHKHFDNDDH;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid JCMLBMDJPIK;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid CDCDLBIBABN;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid NPGMPFLGIOF;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid KBIJJIAHBHJ;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid CHLKIIKLNDO;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid BLEHGDFBNDG;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid GJHBLMEFEHG;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid PAMHOAHOKFK;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid PJMIKKBPHMH;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid GBMHFBNDCNP;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid PCBPIPIJHMF;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid DCJOODJKHBH;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid CIFHOOCELNL;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid BLILLCGOJOG;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid GAENKLFIFPB;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid DEEKPNFHFGM;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid PKNBHLHKGAE;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid LCLOEEFCOJK;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid HPNMEIHBJNA;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid OHBALBHFHCI;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid MADDOAMFPNP;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid MEEOJDCDNNF;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid KIEKMJPFFKP;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid LGFNJENBJKD;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid EFOOHJLAIGD;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid JIHGNNLNILE;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid NICFBEHLJBJ;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid ICLLMBFKKEE;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid HHFDNJNDHDG;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid JABBHBEEKEF;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid DCPJEHKHFDO;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid KPPOCBIIODA;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid KCDDBBFABCC;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid GMLIGDPJFNJ;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid LDKBAKPPHFJ;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid NELPGHEPIEA;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid OMMDDHGCBBC;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid HEIBBNIMBFN;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid DAIACOIPIMI;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid PGDJAOFKLBL;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid EINBCFDJBBE;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid JNFOBDMNAAD;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid GGFLAJBOJLO;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid OGCAENHEELJ;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid OILLOAAPPKM;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid IEJGDAIHOJJ;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid JCCECJLHDKI;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid DIJMNIENMHG;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid GHIBJMLGJON;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid BONGPJFGHKF;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid EHDOHFMMCCH;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid BIOCLPEDCDO;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid HDIJFMOBNHP;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid EJJGOFGAMFD;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid JDFPMHBPBJC;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid BEGHFLEJKMD;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid BIEPGEFCPAM;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid KDDFDOPBBND;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid MBIODNBIOIM;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid DNCKPCGPILL;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid PLCMLELEHKL;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid PILLCNONOEF;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid CPDFDJGGEKH;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid OAHEHPPDHAH;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid DHMJIKHBOFA;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid HGLNKCCLMDJ;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, PJIFDLPIBHL> MEDLENLNNGO;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<PJIFDLPIBHL, Guid> CNGGCIANMAI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, PJIFDLPIBHL> GLFDMBBCGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6886780", Offset = "0x6885B80", VA = "0x186886780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<PJIFDLPIBHL, Guid> JANNNFGEJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68867E0", Offset = "0x6885BE0", VA = "0x1868867E0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EMLPMPLGANA
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6882CF0", Offset = "0x68820F0", VA = "0x186882CF0")]
	public static bool HAPGPLDACNL(ABGKCPNIDKG EHGCINMPOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6882940", Offset = "0x6881D40", VA = "0x186882940")]
	private static bool HAPGPLDACNL(CGGFLGEONJM CAHNDBICCFN, ABGKCPNIDKG EHGCINMPOLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CMADKPCBHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly LMFKKFCLKJH GDIPCAKLIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<NLJKHDOJKPO> KDIJMCDFJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<NLJKHDOJKPO> AEDOGNBMDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly DFKPAEMPCKH<JJIBBLMHJAE> CPNPMOJBMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<AACPCJLHLFB<CEAIECNFGDF>> KAGHPFANKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString JIEAOEIONNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly OLBNIPCGHEJ GJKLOGBAGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool OGPHBDCOLCP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x686E540", Offset = "0x686D940", VA = "0x18686E540")]
	public CMADKPCBHPA(LMFKKFCLKJH LJGPEPKJCPM, IEnumerable<NLJKHDOJKPO> KNLBLOKDGNG, IReadOnlyList<NLJKHDOJKPO> LECCGIMPNBL, DFKPAEMPCKH<JJIBBLMHJAE> NPNJLHJAGHB, IReadOnlyList<AACPCJLHLFB<CEAIECNFGDF>> GBEBFEBKIDE, ByteString MEEHHAPAPFK, OLBNIPCGHEJ HMODIFGODCL, bool LHBIOLCHJEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BAFPCLFJANE
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(ALHMLDMEFJI LDNEPNAGEGN, [Out] Dictionary<int, int> ALFBLNANEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(IINFOADGGJD LFDCLCJENPE, KHGFEDACFGL DNNOMEDNCDB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FJDIJBHPBEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid HGIDPKHIOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> JGADIFNHCCE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> EAOBHMMMGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x39DED90", Offset = "0x39DE190", VA = "0x1839DED90")]
	private FJDIJBHPBEA([In] Guid CABECADFCLN, Dictionary<Guid, Guid> CNDDPLBFEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6882D90", Offset = "0x6882190", VA = "0x186882D90")]
	public static FJDIJBHPBEA EMGIBEMFCHI(IReadOnlyDictionary<Guid, Guid> OMBKNGFHKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6882E50", Offset = "0x6882250", VA = "0x186882E50")]
	public static FJDIJBHPBEA KLOOPIAELOD(IEnumerable<KeyValuePair<Guid, Guid>> OMBKNGFHKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6882DA0", Offset = "0x68821A0", VA = "0x186882DA0")]
	private static Dictionary<Guid, Guid> GDIHKBFLHJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6883200", Offset = "0x6882600", VA = "0x186883200")]
	public Guid NKACKMOKEJF([In] Guid HLKHAOEDAIN, bool KFJPAFOKGLG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6882D20", Offset = "0x6882120", VA = "0x186882D20")]
	public bool CPKAFCFIHNC([In] Guid GNBDDFJPEIA, [Out] Guid AOKIECAIKDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LMFNPMDGJIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BABCNDCHPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLCLGLEKPEG(ByteString MCPACGHMIFO, FJDIJBHPBEA CFDOPEDLKEI, [In] UniformTRS FDGHGNOPKON);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EKEAKKEBFIK
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
public class BPCIEMIKGKI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x15E2EA0", Offset = "0x15E22A0", VA = "0x1815E2EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DOKLPLILMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1114940", Offset = "0x1113D40", VA = "0x181114940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long HPBLLHDLICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x686D8C0", Offset = "0x686CCC0", VA = "0x18686D8C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x656B730", Offset = "0x656AB30", VA = "0x18656B730")]
	public BPCIEMIKGKI(long MLMABEGDEJH, long PPBHDJJNOIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CMNBKDIDEIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, BPCIEMIKGKI> ILLEFNEFPKP;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> HLFGPEIOCJN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long HGMAPPNFHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1114940", Offset = "0x1113D40", VA = "0x181114940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long KHMHMIFJFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x11622C0", Offset = "0x11616C0", VA = "0x1811622C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x686E8A0", Offset = "0x686DCA0", VA = "0x18686E8A0")]
	public static CMNBKDIDEIE MLJMPCICMFD(LMFKKFCLKJH LAAMGFHGNGJ, AACPCJLHLFB<JJIBBLMHJAE> AFBNDAFBIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x686E5D0", Offset = "0x686D9D0", VA = "0x18686E5D0")]
	private void EMGPPMLKEIH(HNDBDOLBHDL ILPFPPMNEDJ, long HPEMOKLDAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68828B0", Offset = "0x6881CB0", VA = "0x1868828B0")]
	public CMNBKDIDEIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CEEHIPDBJMD
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<PJIFDLPIBHL> BELHBBMGDEG;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LINDOCFBILJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> BMIMIEOIDHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> HGBIAMGNHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85AB00", Offset = "0x859F00", VA = "0x18085AB00")]
	public LINDOCFBILJ(IReadOnlyDictionary<Guid, Guid> KHDMLMCMNLO, IReadOnlyDictionary<Guid, Guid> OEELACDBAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HLGDPODJDKN
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6885590", Offset = "0x6884990", VA = "0x186885590")]
	public static MEMAEPNEFAE HPCGDKNMDJL([In] CMADKPCBHPA NPKNJBDJJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6883310", Offset = "0x6882710", VA = "0x186883310")]
	private static void BIEOHPNHGEC(MEMAEPNEFAE GKDOGDOFDNN, [In] CMADKPCBHPA OPFIJFGCCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6883970", Offset = "0x6882D70", VA = "0x186883970")]
	public static NNKIHJJJOOI<LINDOCFBILJ, NEFOFBKDPNH> BPELJOGGKOI(MEMAEPNEFAE GKDOGDOFDNN, CFLEKPHHOCO KIDCEHBADCF, FJDIJBHPBEA? LHFMNKGECJL)
	{
		return default(NNKIHJJJOOI<LINDOCFBILJ, NEFOFBKDPNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6885E50", Offset = "0x6885250", VA = "0x186885E50")]
	private static void LONJIKIIAHB(MEMAEPNEFAE GKDOGDOFDNN, FJDIJBHPBEA? OLGMBBGAIJD, CFLEKPHHOCO KIDCEHBADCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68851A0", Offset = "0x68845A0", VA = "0x1868851A0")]
	private static void CKOEOPHNLNB(MEMAEPNEFAE GKDOGDOFDNN, CFLEKPHHOCO KIDCEHBADCF, IReadOnlyCollection<ByteString>? EHNBOGFOBIG, IReadOnlyCollection<ByteString>? CLKNCHLAKLF, IReadOnlyCollection<ByteString>? PNDAGMGMPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68860E0", Offset = "0x68854E0", VA = "0x1868860E0")]
	private static bool NFHKDBAPDAE(MEMAEPNEFAE GKDOGDOFDNN, IINFOADGGJD LFDCLCJENPE, CFLEKPHHOCO KIDCEHBADCF, [Out][NotNullWhen(false)] string? ODIFAFDGMDE, [Out] Dictionary<int, int> ALFBLNANEDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68852B0", Offset = "0x68846B0", VA = "0x1868852B0")]
	private static Dictionary<Guid, CGGFLGEONJM> FMPJJCOMHKA(MEMAEPNEFAE GKDOGDOFDNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6885210", Offset = "0x6884610", VA = "0x186885210")]
	private static void EGAMJDLEOLB(bool LKKLPCPCKHF, NLJKHDOJKPO GIHDGAEAPDL, Dictionary<Guid, Guid> GJEFKOBGPCL, FJDIJBHPBEA EINEHICDFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6885BC0", Offset = "0x6884FC0", VA = "0x186885BC0")]
	private static void JMFFLELKJPM(NLJKHDOJKPO GIHDGAEAPDL, Guid EDKMCMEOHCC, CKOLHGLBDMK? FKCKKPGPLAH, Dictionary<Guid, CGGFLGEONJM> OGJBOMKEEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6885710", Offset = "0x6884B10", VA = "0x186885710")]
	private static void JIOHDBBHNAH(IEnumerable<NLJKHDOJKPO> LHMIIEAFKAG, IReadOnlyCollection<ByteString> EHNBOGFOBIG, IReadOnlyCollection<ByteString> CLKNCHLAKLF, IReadOnlyCollection<ByteString> PNDAGMGMPKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct CFLEKPHHOCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool LKKLPCPCKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public OLBNIPCGHEJ HMODIFGODCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public CKOLHGLBDMK? FKCKKPGPLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public CKOLHGLBDMK? FECNDJJLHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public LMFKKFCLKJH JNGHKFPDEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public EKEAKKEBFIK JJKPOHNBPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public BAFPCLFJANE EKMEEPJNHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public LMFNPMDGJIC JIAGGOIIPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public AACPCJLHLFB<JJIBBLMHJAE> DNECKPEOIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public EIOGPKGBPGN LEPGKBBCFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<NLJKHDOJKPO> AGFFOMPKINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> NPJMGNFOFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public HKCDFOKACHO FFCMDAEDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool CJMMEHECNGC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool EHKAFHGIHFD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x686DAF0", Offset = "0x686CEF0", VA = "0x18686DAF0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CKOLHGLBDMK
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float PFGHIJIKDGO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 HBGADHMDPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion MGJIDJKDGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float MFGJMFBCPKM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 CDCBOINPAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x686E200", Offset = "0x686D600", VA = "0x18686E200")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS PKHKAAPBEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x686E3A0", Offset = "0x686D7A0", VA = "0x18686E3A0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xC204C0", Offset = "0xC1F8C0", VA = "0x180C204C0")]
	public CKOLHGLBDMK(Vector3 HBGADHMDPAD, Quaternion MGJIDJKDGAB, float MFGJMFBCPKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x686E470", Offset = "0x686D870", VA = "0x18686E470")]
	public CKOLHGLBDMK(UniformTRS HOKFGOFHIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x686DB40", Offset = "0x686CF40", VA = "0x18686DB40")]
	public static CKOLHGLBDMK CBBOADKAKPG(CKOLHGLBDMK KOBAADDGPBN, CKOLHGLBDMK AGFOECDKLMO)
	{
		return default(CKOLHGLBDMK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x686E060", Offset = "0x686D460", VA = "0x18686E060")]
	public static CKOLHGLBDMK JHFAHDJBNPM((Vector3, Quaternion, float) LDNEPNAGEGN)
	{
		return default(CKOLHGLBDMK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x686E080", Offset = "0x686D480", VA = "0x18686E080")]
	public static CKOLHGLBDMK JHFAHDJBNPM(Matrix4x4 PMCBLPKBOFI)
	{
		return default(CKOLHGLBDMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x686E3E0", Offset = "0x686D7E0", VA = "0x18686E3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x686DDC0", Offset = "0x686D1C0", VA = "0x18686DDC0")]
	public CKOLHGLBDMK EGHPCMOKCFL(Matrix4x4 HDODENDDMOJ)
	{
		return default(CKOLHGLBDMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x686DFF0", Offset = "0x686D3F0", VA = "0x18686DFF0")]
	public static CKOLHGLBDMK HFNAGLIPNFB(Vector3 HBGADHMDPAD)
	{
		return default(CKOLHGLBDMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x686E310", Offset = "0x686D710", VA = "0x18686E310")]
	public readonly PNPKFABMDKF PGCPAMCMKEK()
	{
		return default(PNPKFABMDKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KMOMHAIOFCI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6886840", Offset = "0x6885C40", VA = "0x186886840")]
	public static CKOLHGLBDMK CAMKMILELPC([In] this PNPKFABMDKF ABPJKOBADEP)
	{
		return default(CKOLHGLBDMK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum NPPBAPGBFGC
{
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct NEFOFBKDPNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly MBJEPGLGGGC HFFHCJOOJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private readonly EHALGCGAKNL FDAJNHIMIBL;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xEAD7B0", Offset = "0xEACBB0", VA = "0x180EAD7B0")]
	private NEFOFBKDPNH(MBJEPGLGGGC NDDOEMMEACD, EHALGCGAKNL MCHEGPNIIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68892E0", Offset = "0x68886E0", VA = "0x1868892E0")]
	public FABPBLICAGG NONCFAKLOIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x68890C0", Offset = "0x68884C0", VA = "0x1868890C0")]
	public static NNKIHJJJOOI<LINDOCFBILJ, NEFOFBKDPNH> DDEJLDFANAB(EDGBMDPPHFL<AEFODLADDHH> MCHEGPNIIGL)
	{
		return default(NNKIHJJJOOI<LINDOCFBILJ, NEFOFBKDPNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6889170", Offset = "0x6888570", VA = "0x186889170")]
	public static NNKIHJJJOOI<LINDOCFBILJ, NEFOFBKDPNH> DDEJLDFANAB(FABPBLICAGG MCHEGPNIIGL)
	{
		return default(NNKIHJJJOOI<LINDOCFBILJ, NEFOFBKDPNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6889220", Offset = "0x6888620", VA = "0x186889220")]
	public static NNKIHJJJOOI<LINDOCFBILJ, NEFOFBKDPNH> DDEJLDFANAB(string IBEFIPIDKOG)
	{
		return default(NNKIHJJJOOI<LINDOCFBILJ, NEFOFBKDPNH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MBJEPGLGGGC
{
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MHLNNDGEPGJ : IDisposable, JIPCMEPMELJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private NativeList<CKPHKFFGLGA> KDJOMMLMBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private float PELCBLAJJCA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NCEKBJACAFC LEALCMKIFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0")]
		[CompilerGenerated]
		get
		{
			return default(NCEKBJACAFC);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BINOGONGOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6888F40", Offset = "0x6888340", VA = "0x186888F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool FGHCBFMCDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6887220", Offset = "0x6886620", VA = "0x186887220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<LOPKHIAHIJK> DOBPGDDJKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HKOGKLBOGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6888F50", Offset = "0x6888350", VA = "0x186888F50", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float MGEEFODBLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6887230", Offset = "0x6886630", VA = "0x186887230")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6889030", Offset = "0x6888430", VA = "0x186889030")]
	public MHLNNDGEPGJ(NCEKBJACAFC EMGMDFDPKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6887370", Offset = "0x6886770", VA = "0x186887370", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68887C0", Offset = "0x6887BC0", VA = "0x1868887C0")]
	public Vector3 JLOOLHLLFOK(int NIMLCNCKAOD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6888E70", Offset = "0x6888270", VA = "0x186888E70", Slot = "6")]
	public Quaternion LAKDDBHLDDL(int NIMLCNCKAOD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6888F90", Offset = "0x6888390", VA = "0x186888F90", Slot = "5")]
	public Vector3 OBJBILEEIID(int NIMLCNCKAOD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68871C0", Offset = "0x68865C0", VA = "0x1868871C0", Slot = "7")]
	public float AMMCBENKDGF(int NIMLCNCKAOD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68868D0", Offset = "0x6885CD0", VA = "0x1868868D0")]
	public void AKGKKKJALME(Vector3 HBGADHMDPAD, Quaternion MGJIDJKDGAB, float JHKMHGJCHGK, bool DDHEDHJNINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6888760", Offset = "0x6887B60", VA = "0x186888760")]
	private bool JKJLEOLECMK(int EJDNCKOFACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6887B90", Offset = "0x6886F90", VA = "0x186887B90")]
	public void HHNLGAANIJG(Vector3 HBGADHMDPAD, Quaternion MGJIDJKDGAB, float JHKMHGJCHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6888DE0", Offset = "0x68881E0", VA = "0x186888DE0")]
	public void KKAEEAJENBF(int EJDNCKOFACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6887A40", Offset = "0x6886E40", VA = "0x186887A40")]
	public void HGLHBPHJACE(int EJDNCKOFACJ, Vector3 HBGADHMDPAD, Quaternion MGJIDJKDGAB, float JHKMHGJCHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x68884E0", Offset = "0x68878E0", VA = "0x1868884E0")]
	public void HPMOPKMIOFI(int EJDNCKOFACJ, float3 HBGADHMDPAD, quaternion MGJIDJKDGAB, float JHKMHGJCHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6888C90", Offset = "0x6888090", VA = "0x186888C90")]
	public void KEJHAPDNGKM(int EJDNCKOFACJ, Vector3 HBGADHMDPAD, float JHKMHGJCHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68873D0", Offset = "0x68867D0", VA = "0x1868873D0")]
	public void EFKEMIFEGGG(int EJDNCKOFACJ, Vector3 EKOLOLBNIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6887CF0", Offset = "0x68870F0", VA = "0x186887CF0")]
	public static Quaternion HLFJEEMIKNE(Quaternion JMBDPCHIGAH, int EJDNCKOFACJ, float GMBGPGOBINM, JIPCMEPMELJ AHBGNMGHHAN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6887530", Offset = "0x6886930", VA = "0x186887530")]
	public Bounds ENJFIFBPLGN(Transform HDODENDDMOJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68879D0", Offset = "0x6886DD0", VA = "0x1868879D0", Slot = "10")]
	public virtual void GIEJJAIMAHE(bool MEAJOLPHAPO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6888690", Offset = "0x6887A90", VA = "0x186888690")]
	public NativeList<CKPHKFFGLGA> JJNBGDBNCDC(float MFFDAFMPEEH = 1f)
	{
		return default(NativeList<CKPHKFFGLGA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LOPKHIAHIJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public float3 DJODFMOGEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public float LHCBECNGKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public quaternion GDAAHKDFEBH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x688F9F0", Offset = "0x688EDF0", VA = "0x18688F9F0")]
	public LOPKHIAHIJK(Vector3 DHLCOAONPFN, Quaternion JMBDPCHIGAH, float JHKMHGJCHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x688F630", Offset = "0x688EA30", VA = "0x18688F630")]
	public Quaternion DKNELPCOMFG(Vector3 EOKIIKENLCD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x688F6F0", Offset = "0x688EAF0", VA = "0x18688F6F0")]
	public LOPKHIAHIJK KAOPBCEDHIM(Vector3 NALPFEEBOHO, Vector3 FCJLHEOJCPA, Vector3 GMFPAMFOCKI)
	{
		return default(LOPKHIAHIJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x688F480", Offset = "0x688E880", VA = "0x18688F480")]
	public MOPCPPNBNHI DCMIFMCHDJG(Vector3 EOKIIKENLCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class LBEJKPBPBOO : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x688E790", Offset = "0x688DB90", VA = "0x18688E790", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x688EAF0", Offset = "0x688DEF0", VA = "0x18688EAF0")]
	private void LEOLIJNMCFI(Dictionary<Guid, Guid> EKODDLLPDMC, ANLFABHICNJ LJCGNJLHCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x688EA90", Offset = "0x688DE90", VA = "0x18688EA90")]
	private void LEOLIJNMCFI(Dictionary<Guid, Guid> EKODDLLPDMC, KEEDMGDDOEC JIFOHPAMKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x688E810", Offset = "0x688DC10", VA = "0x18688E810")]
	private void LEOLIJNMCFI(Dictionary<Guid, Guid> EKODDLLPDMC, FCFFEPIMNKK MFOBOFDPFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public LBEJKPBPBOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class ELIHLBFEJLB : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x688C6A0", Offset = "0x688BAA0", VA = "0x18688C6A0", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public ELIHLBFEJLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class BFKBAFPOMOO : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x688AC30", Offset = "0x688A030", VA = "0x18688AC30", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public BFKBAFPOMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class IGMADMCKEPL : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x688DB40", Offset = "0x688CF40", VA = "0x18688DB40", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public IGMADMCKEPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class EJLKDMHPHKP : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x688C480", Offset = "0x688B880", VA = "0x18688C480", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public EJLKDMHPHKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class OOIKOPNLHMA : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x688FFE0", Offset = "0x688F3E0", VA = "0x18688FFE0", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public OOIKOPNLHMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MAFIEOEJBHN : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x688FA70", Offset = "0x688EE70", VA = "0x18688FA70", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public MAFIEOEJBHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EFDNDFFGHFG : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x688C1D0", Offset = "0x688B5D0", VA = "0x18688C1D0", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public EFDNDFFGHFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CBBPNDGCAHM : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x688AD90", Offset = "0x688A190", VA = "0x18688AD90", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public CBBPNDGCAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EIINIMOFMEJ : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x688C2C0", Offset = "0x688B6C0", VA = "0x18688C2C0", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public EIINIMOFMEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class ODGAAEGKNOO : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x688FD40", Offset = "0x688F140", VA = "0x18688FD40", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public ODGAAEGKNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class NLBGAIOLODK : LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public static readonly JIGGCBPNAII NCOGKPPCLIE;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x688FC10", Offset = "0x688F010", VA = "0x18688FC10", Slot = "4")]
	public void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public NLBGAIOLODK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct ABGKCPNIDKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public IINFOADGGJD FKMAFNEMDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public NABHEMBKEEJ LIPLJDHKBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public Dictionary<int, int> MBJCBMIMMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public Dictionary<Guid, Guid> EFCPEBDCHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public HKCDFOKACHO FFCMDAEDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public bool GGNPHHPCMKD;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LAAJLFKMJNA
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JENKKHONLPC(CJAAIHLPOHA CAFFBAMDNEC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PLGPFPFBKEI
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private static readonly LAAJLFKMJNA[] KBBKDNGDPAC;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6890780", Offset = "0x688FB80", VA = "0x186890780")]
	public static void LLMPBNMCAIG(NLJKHDOJKPO LDNEPNAGEGN, Dictionary<Guid, Guid> MNPPLDEBICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6890120", Offset = "0x688F520", VA = "0x186890120")]
	public static void CIIKIDEHLCL(NLJKHDOJKPO? LDNEPNAGEGN, FJDIJBHPBEA KKGMLJPNCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6890A10", Offset = "0x688FE10", VA = "0x186890A10")]
	public static void PJEMNALNKHK(NLJKHDOJKPO? LDNEPNAGEGN, FJDIJBHPBEA EINEHICDFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x68903B0", Offset = "0x688F7B0", VA = "0x1868903B0")]
	public static void HAPGPLDACNL(CJAAIHLPOHA CAFFBAMDNEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct CJAAIHLPOHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public IINFOADGGJD HPABCHCIOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public NLJKHDOJKPO GIHDGAEAPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public Dictionary<int, int> MBJCBMIMMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<Guid, Guid> EFCPEBDCHCG;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x688AF50", Offset = "0x688A350", VA = "0x18688AF50")]
	public Guid GEJGJHNNFEJ(Guid HLKHAOEDAIN)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HKCDFOKACHO
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int PHHFDMFLENM, [Out] Guid ACKDLAIALCJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class EOFFFDGCOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private readonly HashSet<string> FFKOGCCKIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private readonly Dictionary<long, int> DFMHCAOOKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private readonly HashSet<Guid> MAGDCDIEHAA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<string> IAKHJBNFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyDictionary<long, int> OGIADIIHKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x688D870", Offset = "0x688CC70", VA = "0x18688D870")]
	public static EOFFFDGCOBA POHBDHMJGHO(KKLGAOKAOFM AFNMBPMIHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x688C7C0", Offset = "0x688BBC0", VA = "0x18688C7C0")]
	public static EOFFFDGCOBA FDEELFFECLJ(MEMAEPNEFAE BGCFCEOPCFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x688D520", Offset = "0x688C920", VA = "0x18688D520")]
	public static EOFFFDGCOBA NKBKKDIIKEM(IEnumerable<string> FFKOGCCKIOM, IDictionary<long, int> AFEJMDKGOBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x688DA20", Offset = "0x688CE20", VA = "0x18688DA20")]
	private EOFFFDGCOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x688D8E0", Offset = "0x688CCE0", VA = "0x18688D8E0")]
	private EOFFFDGCOBA(IEnumerable<string> FFKOGCCKIOM, IDictionary<long, int> AFEJMDKGOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x688CC20", Offset = "0x688C020", VA = "0x18688CC20")]
	private void FGCHICNCGMD(KKLGAOKAOFM AFNMBPMIHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x688CFF0", Offset = "0x688C3F0", VA = "0x18688CFF0")]
	private void FGCHICNCGMD(MEMAEPNEFAE BGCFCEOPCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x688D1E0", Offset = "0x688C5E0", VA = "0x18688D1E0")]
	private void FGCHICNCGMD(OMDBKFKAJGJ? MILPLABKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x688CE20", Offset = "0x688C220", VA = "0x18688CE20")]
	private void FGCHICNCGMD(ILMHACGNNEB? ILPFPPMNEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x688C830", Offset = "0x688BC30", VA = "0x18688C830")]
	private void FGCHICNCGMD(NLJKHDOJKPO? GIHDGAEAPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x688C750", Offset = "0x688BB50", VA = "0x18688C750")]
	private void EIILKMDFCFE(string? GKFLBKOPECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x688D790", Offset = "0x688CB90", VA = "0x18688D790")]
	private void OKENCLEOFIE(HOFDGFDAJAB? HGANMJFMKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x688D6A0", Offset = "0x688CAA0", VA = "0x18688D6A0")]
	private void OKENCLEOFIE(OEEHPMIPMGO? HGANMJFMKMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct DCMPCGMGMBO
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class LMNEDHCEGKG : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private readonly IEnumerator<DictionaryEntry> EBGPMHNLEJP;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DictionaryEntry IJIEMMHALAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x688F250", Offset = "0x688E650", VA = "0x18688F250", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x688F320", Offset = "0x688E720", VA = "0x18688F320", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object KHLHBLNGCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x688F3D0", Offset = "0x688E7D0", VA = "0x18688F3D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object AKMKAIGAIOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x688F170", Offset = "0x688E570", VA = "0x18688F170", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
		public LMNEDHCEGKG(IEnumerator<DictionaryEntry> EBGPMHNLEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x688F0D0", Offset = "0x688E4D0", VA = "0x18688F0D0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x688F120", Offset = "0x688E520", VA = "0x18688F120", Slot = "9")]
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
		private sealed class OIKOMLOHHPC : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xD2CB60", Offset = "0xD2BF60", VA = "0x180D2CB60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x688FF90", Offset = "0x688F390", VA = "0x18688FF90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
			[DebuggerHidden]
			public OIKOMLOHHPC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x688FE40", Offset = "0x688F240", VA = "0x18688FE40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x688FF40", Offset = "0x688F340", VA = "0x18688FF40", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6891830", Offset = "0x6890C30", VA = "0x186891830", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IDictionary.this[object PEDCMDADFIN]
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6891740", Offset = "0x6890B40", VA = "0x186891740", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6891920", Offset = "0x6890D20", VA = "0x186891920", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6891680", Offset = "0x6890A80", VA = "0x186891680", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x68916E0", Offset = "0x6890AE0", VA = "0x1868916E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x68918C0", Offset = "0x6890CC0", VA = "0x1868918C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6891340", Offset = "0x6890740", VA = "0x186891340", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x68913A0", Offset = "0x68907A0", VA = "0x1868913A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6891400", Offset = "0x6890800", VA = "0x186891400", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xB83E50", Offset = "0xB83250", VA = "0x180B83E50")]
		public RoomObjectCounts(Dictionary<int, int> LOPICCPHOKM, [Optional] Dictionary<int, int> HKBIBLOEOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6891260", Offset = "0x6890660", VA = "0x186891260")]
		[IteratorStateMachine(typeof(OIKOMLOHHPC))]
		private IEnumerator<DictionaryEntry> HLKIEKILIGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6891970", Offset = "0x6890D70", VA = "0x186891970", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6891580", Offset = "0x6890980", VA = "0x186891580", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6891460", Offset = "0x6890860", VA = "0x186891460", Slot = "9")]
		void IDictionary.Add(object PEDCMDADFIN, object OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x68914C0", Offset = "0x68908C0", VA = "0x1868914C0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6891520", Offset = "0x6890920", VA = "0x186891520", Slot = "8")]
		bool IDictionary.Contains(object PEDCMDADFIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6891620", Offset = "0x6890A20", VA = "0x186891620", Slot = "14")]
		void IDictionary.Remove(object PEDCMDADFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68912E0", Offset = "0x68906E0", VA = "0x1868912E0", Slot = "15")]
		void ICollection.CopyTo(Array ELFCOFFIPBP, int AGAGKNBDCIG)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class INHMOEBJCFG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xD2CB60", Offset = "0xD2BF60", VA = "0x180D2CB60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x688DE20", Offset = "0x688D220", VA = "0x18688DE20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
			[DebuggerHidden]
			public INHMOEBJCFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x688DC90", Offset = "0x688D090", VA = "0x18688DC90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x688DDD0", Offset = "0x688D1D0", VA = "0x18688DDD0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x688E4B0", Offset = "0x688D8B0", VA = "0x18688E4B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IDictionary.this[object PEDCMDADFIN]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x688E380", Offset = "0x688D780", VA = "0x18688E380", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x688E560", Offset = "0x688D960", VA = "0x18688E560", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x688E2C0", Offset = "0x688D6C0", VA = "0x18688E2C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x688E320", Offset = "0x688D720", VA = "0x18688E320", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x688E500", Offset = "0x688D900", VA = "0x18688E500", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x688DF40", Offset = "0x688D340", VA = "0x18688DF40", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x688DFA0", Offset = "0x688D3A0", VA = "0x18688DFA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x688E000", Offset = "0x688D400", VA = "0x18688E000", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD620", Offset = "0x1FDCA20", VA = "0x181FDD620")]
		public Invention(long GNBDDFJPEIA, int MLMABEGDEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x688DE70", Offset = "0x688D270", VA = "0x18688DE70")]
		[IteratorStateMachine(typeof(INHMOEBJCFG))]
		private IEnumerator<DictionaryEntry> HLKIEKILIGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x688E5B0", Offset = "0x688D9B0", VA = "0x18688E5B0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x688E180", Offset = "0x688D580", VA = "0x18688E180", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x688E060", Offset = "0x688D460", VA = "0x18688E060", Slot = "9")]
		void IDictionary.Add(object PEDCMDADFIN, object OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x688E0C0", Offset = "0x688D4C0", VA = "0x18688E0C0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x688E120", Offset = "0x688D520", VA = "0x18688E120", Slot = "8")]
		bool IDictionary.Contains(object PEDCMDADFIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x688E260", Offset = "0x688D660", VA = "0x18688E260", Slot = "14")]
		void IDictionary.Remove(object PEDCMDADFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x688DEE0", Offset = "0x688D2E0", VA = "0x18688DEE0", Slot = "15")]
		void ICollection.CopyTo(Array ELFCOFFIPBP, int AGAGKNBDCIG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> ELJINLBIDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public readonly IReadOnlyList<Invention> OFBDBONDBLB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xB83E50", Offset = "0xB83250", VA = "0x180B83E50")]
	public DCMPCGMGMBO(IReadOnlyDictionary<Guid, RoomObjectCounts> OBHLFECDJFB, IReadOnlyList<Invention> CLFNOMLLGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x688B7E0", Offset = "0x688ABE0", VA = "0x18688B7E0")]
	public static DCMPCGMGMBO POHBDHMJGHO(KKLGAOKAOFM AFNMBPMIHMN)
	{
		return default(DCMPCGMGMBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x688B6C0", Offset = "0x688AAC0", VA = "0x18688B6C0")]
	[CompilerGenerated]
	internal static int IDNPFOEJMEG([In] IReadOnlyDictionary<long, int> LCPNNPMBJPD, long? PJGMNABNGMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x688B000", Offset = "0x688A400", VA = "0x18688B000")]
	[CompilerGenerated]
	internal static void EHGEIIJFAAN(int PGMOMLIOOGM, [In] OMDBKFKAJGJ KEPPBIMLNPP, [In] Dictionary<long, int> LCPNNPMBJPD, [In] Dictionary<Guid, RoomObjectCounts> OBHLFECDJFB)
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
