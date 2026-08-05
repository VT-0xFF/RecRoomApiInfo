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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x62DAA30", Offset = "0x62D9430", VA = "0x1862DAA30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HHHPJGIJPHK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> KCFOMGLEJPN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> OFPKOEDPIMI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> HLPNBHPOHHM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string EAIFFBCFKCH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string LKMDMIPBFCB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string OIEEMMCLBFC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62D85C0", Offset = "0x62D6FC0", VA = "0x1862D85C0")]
	public static bool MGIJMBDBCMD(Guid EILHDLLFNFA, int DNGPLPBJJLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x62D8D90", Offset = "0x62D7790", VA = "0x1862D8D90")]
	public static bool NJFPLJFBAEL(Guid EILHDLLFNFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62D86C0", Offset = "0x62D70C0", VA = "0x1862D86C0")]
	public static string MHELFMDJELD(Guid JHOGCCPFJGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AMBCIHIKGDL]
public enum ENGMNDNJOAM
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
public static class EDNGIPONDEE
{
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid LNMOFOGPPLP;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid CACFJLDHFNJ;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid KJOGGBJDBFD;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid NPGOGGJIHOP;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid KOMFBMNAIMG;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid HMPMMNHHJMH;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid ABCKMDDDDIH;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid BOILEJDKFNN;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid PJCNPKOFAHP;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid LKFKENNMLGD;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid AJGAIHNPGDF;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid BKHKKCPCPLB;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid IOFBIHDNBMG;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid FAFHMBJAKGC;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid GNBMJOGCPEA;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid FHCIKBMDBHC;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid AACAILDLNJE;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid CPPGIOPLFLH;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid FLJNNMCHIMN;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid DLLFKMBPAIL;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid KJKOPFNPFLH;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid PLOBMLNKCPB;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid GCIDMEJIGHM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid IDKAKFOEELD;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid PCELFKLNEHD;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid GFLALLJILIG;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid HDPJLPHCKAB;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid HCHICCMIKKB;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid ELMHINBGAEL;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid FAHHCFIIJLD;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid JFEMMEJHPNH;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid NPDCNNJEPKC;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid LKNOIOGAMPI;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid GOCEGBHFEED;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid NCHHHJJMJOL;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid IKLJANHJHPB;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid DBBHCMNEEPD;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid PJMCHDFOKLO;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HLMGNNLMEJF;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid BGDEDJECCCF;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid GHOJAHLOIOP;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid CIMKJIOJFOH;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid PEKOCGLLPPG;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid AGCCCBHFOHF;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid PHEEIJKIEBI;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid KDDOPJEHJCP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid KIJKIEMJPBE;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid AGBNNKGBGML;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid EEIJBEFGDKM;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid FNEBCKJLEPA;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid DJJNKMECPGM;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid FPCPKGIKMBD;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid FIFLODPEAMN;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid KHIBDOCPKMD;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid GNLKJLPHJBO;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid NNCOBCCOGFI;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid DJCKEGHFAGN;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid NPOADBGADJC;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid JIOGCEHGNKP;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid NOGHAODIHIH;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid ODEJDIIENNN;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid GNCDBOBHNAJ;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid PJLDABNPGNL;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid JPFOPCPMPIN;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid ABNJIEMNOPG;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid DALFJIANCHM;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid MBHNNMEKOIK;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid JCDJFPMFKHD;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid JHMMPCHEDPB;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid CHCFMKBJFBO;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid FEHLMMLNPPK;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid GOAFLILJOEE;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid ILCIJCAPECB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid KJHFACEOKCJ;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid PCHBPJMNOFJ;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid ADFENEMEBFD;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid DACLPANIHKI;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid BKCPKMPJMAP;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid GOPPIMBFPFL;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid LCAPJKDDHIF;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid DPLPFLMIDOG;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid FOIEHBOJFDB;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid MAFAJDFLHFA;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid HMDLNLOLFEN;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid NHKIIFBDOED;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid NFGOHIFNFPJ;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid NPJLJJIPAFB;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid KFOEDKNPOAH;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid AFGIPLOPNLI;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid JGICHFJIHGG;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid AAJLMMMDNGJ;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid PDJFHJJNPGO;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid EBKIBGCNICL;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid OHCMHBDJCCJ;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid CMCCLMKMGLL;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid KNGLJAIIBNK;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid ICNGGBEAMHB;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid DALELHBDDJI;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid PHDDMJBHEKJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid GKHIJFOGBJJ;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid CKAPFEDIDHO;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid KJEIMIBNAOL;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid LNPNKLMBGCJ;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid JFDHEGMHDAL;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid MJMGNFHCLIP;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid BMGLOEONALG;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid GKNLPKNNCCM;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid GLNJAJCDNDJ;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid LCHEAFJFLLO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid GEOBMGFAFMP;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid DFPNJEJHMDO;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid BINPEFMGJBP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid HBHHFEFIOEM;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid OILGBBAMGJK;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid JNNDIIIDFJE;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid PFJCMCCNANL;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid DLODAOBKNFM;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid KMCPEDEPJGG;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid JJMGMAFCCAH;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid NCINGANLMNI;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid CAKLKGBPFAD;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid PJBKGHNFAGJ;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid AIEMNLEAFGN;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid BPPDFOPCPDG;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid MGMAFHADPMK;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid LKCCENLLABD;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid EPDFLGOCDHF;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid FJGDBIBPJGJ;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid MPGOEDHGNLA;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid IPIFONEOACB;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid GFFOCBDAHKC;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid JONBNCMDPAI;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid FBDMNLJABFL;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid JLIIILJIGBO;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid BJLGBGCPNNF;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid PEKNEBPPDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid APPFAELJGLA;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid ENJHHNOAADO;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid OOPPNAOIDDO;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid CNHMFHDPJOF;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid NFGDKCLEHIP;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid ADOEEJJNLEI;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid HBHNIFLHCAF;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid EEOOLLMJCNN;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid ICNJIJGIDFO;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid IKGCGAKEIME;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid MJCJLHPPGFJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid FCLPNEEDGAE;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid LCGMFOOMALE;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid MANNECGMJDA;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid PFAGKBJAFHE;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid CCLDEHDDJML;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid PHCNBNPKGFM;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid BELEHDDMJCF;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid DMIMPFNLHOP;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid AIEPDDAJBJH;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid AFALLBEFNFO;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid JOFFNAOEFGL;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid ECPMLKBGGJD;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid AGBLEPKLIFO;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid NCDJPGIEPDF;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid PKDJLFCPGGM;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid CAFPBNNGIBJ;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid FDBHDBMCDEP;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid FAPIDCCMMKI;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid FPDBDLIAILK;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid BFOGEOJIBAP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid EMMKJBFHFBF;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid DGLNNDOBEKH;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid POAJHKPEMOA;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid OJMINENFIDO;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid NFNDGFHLJMD;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid MJOKAJNPBBP;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid IKCGLMAODMF;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid CNIACBGEKNE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid PLLNPBOMENA;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid JKPGHJCIMJN;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid DALBGBMHEDL;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid HCIGKAKHBDL;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid OPKGKMOMDEJ;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid CPEHKMCKANE;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid GNJIGMPDEBF;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid OBKNLIKIGDF;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid IGNPKKDGALB;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid BKHABAJENEH;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid GLOLACHBFAP;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid AMPPMKEKAIL;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid JHPBOGHKFIG;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid HKONNJJKBCC;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid AOCOIMFEFAM;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid CDNLLJNPPKM;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid HOEJNPFEJIL;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid NAFJGDMAIFL;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid GHNFGDHLFGC;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid IMOGDJPGLOP;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid JHALKGBMFHI;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid BDIPOBGCLIC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid KDDAFFJKGMP;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid MLKGJOFIOMP;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid CPOCOHLGCOE;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid AGGNNNNDINL;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid HEMAHDAGDFG;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid MCBNPEBIOIA;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid DINDFPLNCKA;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid ONEAANPGGLM;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid JFCNDFMEOGB;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid BFBPOCOEKEG;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid MDHBDMBNMCL;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid BFAGJJOELJB;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid IGFADKAHLKI;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid CCMKCGJINJP;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid BBCGAJPODHH;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid IKBOICAGEPK;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid JAGBKFDJAIP;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid PPOHIIEPIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid OGGCDEJGJMD;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid LMJGPGJFDJJ;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CAKHBJAJHKF;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid DIMPMDHHOEK;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid GFNCALICFKJ;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid NLNNLECFBJA;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid NDGKFCHHCHH;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid NBGBCDGFNLJ;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid GBHLEGPFGNH;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid JMPHCJFCOLF;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid FAMKOBNFIJN;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid JGCHDPCLGKL;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid BKMMJLOIMFL;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid KEKNIJGGOJD;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid BFBCPGCKOOC;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid CMMGCOJFGHI;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid OKOGAPKOIGF;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid FICILGGKBHD;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid ENHPNBJKKGH;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid BKAHDKMJAIA;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid COPPDAGOABI;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid FALOHLGAJCP;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid NCENPLKKBJC;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid LBJDNGIKFAF;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid KIIEDPAAIBP;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid GMACBOCHHED;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid HLEAKKBJLLI;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid OFHDDMNLHJJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KKEJAGELFEB;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid JFPPJKJKAHG;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid HELDNJEFOAK;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid FNMMGKMCHHI;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid PLNFNHBGFKG;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid NJMLBMOGGAB;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid OLHDMHKCCPG;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid MKDGJFEEFBD;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid LLKJOLKOJAF;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid FAPEPAJOLAH;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid BIBOOKFPPEA;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid CJHMBENILGK;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid DCJNJKGNMOM;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid PEEHKPDFMDK;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid NLEODOEGHGM;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid KKHJEMNAJOF;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid NGMOJEKNNEB;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid OOCINBKJMAH;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid OGIJIDOLHML;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid BENAKPNNHHF;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid IKMAPDLAEJK;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid HKIBPFHMBII;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid IHOACDNNDFN;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid FLMEOKMMIGA;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid MJLLAJAFNKA;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid NMAKAMFNBBF;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid ACDMPLMCCMF;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid DIDKBOJANAC;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid NIPKPIHIFNI;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid FPNBBMMMPPN;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid OKPPPCCKHED;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid FIALDPCNEGF;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid HHDCHMMPBFO;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid JFJCMFDFLNK;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid GCLMCJBCHMI;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid NFKOCCGOPLL;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid BGKKHALHFCN;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid NAFKFLEAOIH;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid KPAKNJCFJHP;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid NAIBPBHNDOB;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid INGKINKCHKN;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid MMMJPNLOEND;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid KLKEOGMDFJG;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid KIIHBPPNEMC;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid LPCOJJBMBJE;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid AAGDGNPFBKN;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid JPFDBKGGHEL;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid GEBCIEKJMOK;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid GMIILNKJEFM;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid HHBNPJELFKD;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid OHCDFMMJKCL;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid EAIPHIFKPJE;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid IDAMCFEBFAN;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid NOOOMMPBHFC;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid OJMOCBHOCFC;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid NBGLBHPNEMI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid NGCEDCCNNBN;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid DFAGJPLINCN;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid OEEGPKJKALK;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid EMEECLIMIDM;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid MGNCFMABFJO;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid EMPMDFPJLND;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid HKIHHODMFMA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid OMKANEDKIAH;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AMCPFANHPFH;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid JJJJLIJJFGB;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid NGCEPIBNJFP;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid DKBPJPENPGE;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid DDADGBEDPKC;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid EEMLKAPDECF;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid OKJLOGDKIKI;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid EKJHBMMLFMI;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid OMANLAHICFD;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid KKAFALJFMGE;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid PFPCPBCDBJM;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid GOFMFEFJMOA;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid GJPOKCCCABL;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid AIIJJDCFJAF;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid MCKMJBDIDCG;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid GFIGMPBLNHL;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid KLBHPGAJEJH;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid OIJBLLIMDEJ;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid PGNEAMENCDH;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid EIMILPDMPCO;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid PJJFGKKIIMH;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid IEMBLDFHHNF;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid BFKIKKPKFPJ;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid LFHOIKNCKDO;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid PDNLFMAEHBD;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid LNCALHMONMI;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid KMEBADBPBEI;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid MKAKJMHLJJJ;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid NIICJPJMKEE;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid AJECKJPIJJL;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid CEDDJNHAHGF;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid IMINEIDDMJD;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid JJMAAEJMGPK;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid EDDIFAHOCGJ;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid NNKDANDIBGG;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid PDJMMIILKHB;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid CNDEMELKEJJ;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid HFAOFLPGHLJ;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid PFNFMINFJPG;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid GKJNDKLKFEN;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid ELIEIDMGOEF;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid EJNHFNJDMHN;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid IJEIGOJCDOH;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid CBLJAHKNGJI;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid CJOOKEGEMEJ;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid NCMLGIBHEBJ;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid POOOHEMDDBP;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid MLBNEEEMAEB;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid BBIPHBGIDIO;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid ODCKOIFLMPJ;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid KJDJLEMCNFL;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid BMFCNFBOHCB;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid MMFIFNKODLI;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid FAEABOCGMAB;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid HEMIOJKNGLA;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid JGBKPFDGIOH;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid AGLHJABCAPF;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid MJKLDHBGOEG;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid LFKJEAEIKMA;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid HMFAGAPHAPK;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid MOAIMNNHMBA;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid AHHDCJKNMDM;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid LOFDADFGJEA;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid KFFPOIEJDDI;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid AKPAMJLJNJM;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid LKNGLJKFANK;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid NMBIEELMBOB;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid KAIIDCCGKOF;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid FGABDKFIDKC;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid IMAHFMBAPNN;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid LFEBNBGHLKI;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid AHMNMNFMKHI;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid HNGCKJIJKNG;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BBGPKKIDPHG;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid KLDALBILBOA;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid GAFHMDAIMIH;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid GDCFOPIMGHA;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid EOPGMHFEIDJ;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid OLNBMIGGEHB;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid DONHIHAKPEE;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid FIKKEGMAEMP;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid DLEBCIIFAAD;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid FHCPJLLPHOI;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid PPAMKCOIJIP;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid LJDADFBMOEK;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid LAFJFPHKDIC;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid CPOOCGJCJEF;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid LLKKPBKCKEI;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid BDNOKDBKPEF;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid PHFHNKHBOLP;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid AICGPMHBIDB;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid NKNAEJBEODH;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid GLNKFGDNGLD;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid IFCPFHFAJNG;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid IKGPCAKGKLD;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid HIPBGJEFEJL;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid JMONENAKOMC;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid HGPIMNPKHGM;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid FCBKILJFAGC;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid KOPDFIFBHHP;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid DNKJAIFAPEO;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid ODMOABKCMDB;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid JIIMOONFBFP;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid NHJJMNFAKPH;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid HCMNAKMKDCM;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid PEEIOAKLKFE;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid AGJKPMDINNF;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid EIOOFMFAFCG;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid DADGENCHLFF;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid JIIAFAHFGIJ;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid KOCBDLDINOM;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid PCPOCDAHKLI;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid EKFFGMKHKLB;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid OFPHFMGIDCN;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid BJHCCKDFIDG;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid DLBNIPPFLLP;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid APNOFAAOIKD;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid LDJNLNIACGG;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid EKKAKHEENFK;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid LAFGIHFPKIF;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid HHNFEBCICJI;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid EALCOCNOKNE;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid BDOMDMMFICA;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid CHCEMHIKDBP;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid EPOHNMDMKCO;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid IHPCBFAAGPC;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid DHKAAEPMAAN;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid FAAPOFINCKN;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid JPMBNAEEDAJ;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid KIHKHPALIOP;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid DBGBGJNPCEH;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid CPFNCBMGBOE;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid JLPIAGBLCJD;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid GOOHIOHKBIA;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid BJGFMOAAHNA;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid MFHHOEMBLLA;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid GGFDJJCDINN;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid NKOFLJDLBHH;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid BPABNBNNDPB;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid NJHCHGKDHDB;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid OMOOGHLKIDE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid IABOAFIDKCP;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid ELEKPPDFLMK;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid LAGPNMDMJIN;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid JPJEONKBAKG;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid LEEBNENKGJG;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid LDIFKCOGNCN;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid NHCIGFFBOBC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid DIDIPIMFNBF;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid NDOHKAHBKOI;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid KAHAFDCJGAN;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid EMBNMFLDFHM;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid LPHEPHGNLOI;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid IIKLMLOEFHD;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid KINKIPKDKNH;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid COJGMMIIEEJ;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid EEJNMHAONJF;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid KGOHJHKHFEN;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid NHKPBNFDBFE;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid OKKAKGMCFPE;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid EBIDDBIPECM;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid HOJFKKEJNLN;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid IMJHEFFJOJI;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid BNBEDNEANML;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid PPJGPGHCAAE;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid HLONJJCFIAM;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid EODBCFDOHPI;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid AEBJCFOJDEI;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid HGDNMKBDJAD;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid HCDOAPMDIEA;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid CPNEFLGJMJH;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid AALHLCHHNBD;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid KKMOJEHEFPO;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid FNIEHBPMGDI;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid MOEJEANJPNC;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid DHJBIMOHHEE;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid CNNMAABOIAA;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid OBAIDCODNNM;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid JPNCCPIPAJK;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid KPLHOMHMMJF;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid OMHOPDPDGOB;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid KALDAFFAHCG;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid PGBECBAJOMN;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid MINPCALNOIP;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid EHHJGJALEKD;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid OBGLEMLLAGL;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid KLIFOHCLMBO;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid GOOOFFODBJO;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid LICOJCFABLJ;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid POKCLKCIKMG;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid IFHFIDABBGH;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid JLPCMGIBHJP;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid NKNEJPFADNI;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid NFIBDFALONI;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid HDHEOFPNPPC;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid PPLLIDFBEGJ;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid FDLDBAGIJBI;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid AOHPMIMLNMK;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid KBKDLGIFNJG;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid GMAGGMPPGAH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid MMOEBMHNFDA;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid DMNEGJIMGAL;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid KJDMMNEALKB;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid CKAOBBPNBGB;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid EAIHOGEBNBG;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid IHINANBCCML;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid INMOHKDGKFK;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid HJENHJOEMFH;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid EHAGLLBGCEE;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid ALFHJPEAOBM;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid IADALENNLGL;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid PNNKDCHKAHH;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid DCHFCLAIBJG;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid EDNDCECPPJC;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid CEEOPEMEONO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid ICOFONDNEKI;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid CJKONLONIGP;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid MMECBKNFNBN;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid FCGPABEPOBF;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid MKPACJHGLJF;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid LCGJJDLIJBN;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid DCEIOHKKEPP;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MBNAMMCLIFC;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid NLHDEAJIPDC;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid KIDIKFGMPNG;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid IDBGFIIJCHJ;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid BMIPPCAANLL;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid LAHALAELJJN;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid PIEPDJCFNDB;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid EFGBOGEPJNO;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid CDPMFNAPPDL;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid FGNOLADBGLO;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid CHNPMEEDFPG;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid HLLHAGIDJHH;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid JJPLBHIIBLD;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid BDILHIJLBFM;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid HJKEIDPNFBP;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid IGPDMNOLOHI;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid ICNBCAFMCOG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid BIEFNNFDLCH;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid NPIOJHEOIOI;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid OJEKGCPIEAH;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid EEPMGCDKEOF;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid BJACGCGJDDA;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid KNIGAAGLOHP;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid NHJPLOCIENH;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid KLBAJFAHDEK;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid LGKLCBNCBCN;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid NCOBCJHBACC;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid LMLMBLCCKDG;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid HGOHIOLFBDL;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid FPKPCNGFCEI;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid NOMFLPKMFBP;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid NNGJEJOCGAI;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid JHGPKPMHHAA;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid NHFFIGOFFMB;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid GGKKHCNNGID;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid INHBDPOOHHO;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid NAMGNLJJAJD;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid DCFBPKFLEHH;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid JGLCLCIDKDP;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid OLEFDADMDGD;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid FFNJHGMPFLP;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid OJKHNMNGLIJ;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid ANFCPMJNMLI;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid FILFCGBCBGH;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid EKJJCHFNMPI;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid FHMDNKAMGGD;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid GBGFPFFIMND;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid BPJLBCMKNBG;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid BALMBEDMNNN;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid HJAGBAAIJHE;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid BNICNDCKNJB;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid ILLBIODKILC;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid OPILGDEPOKP;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid AKFCFDCEECC;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid HBAGPMLGKHG;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid GECNLHPBOOM;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid ACJKKGDMCPN;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid INEPCNADDID;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid JIBDDAMHKDC;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid GIIAMECDHMM;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid KHAPEJBKBGH;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid MKJPDAJJEOD;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid OCGDICJBKID;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid BINGFEPNLBN;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid AALMFMBHOGI;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid JGCHCDOACHM;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid JFLKGOMFLNJ;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid NKIDOKJNGDO;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid IMFHPFLEHCG;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid NLMKAAILACO;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid CJBMCMBDFHH;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid DIMFONKILMJ;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid LPLABPAJDAG;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid FKOLBAAOGCK;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid LBDOMEJPIIL;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid OFGDCKDLKGF;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid HOILPFLNDFJ;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid KCKJJJOBPFN;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid ADOLAJEKLBM;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid DAJGENHONKF;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid CDCNCCAFEDG;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid MJCPENLBNGD;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid MFDCCJFOPMN;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid CKBCNCAKJOJ;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid MEONMPPDNGD;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid HEFEIAACPPH;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid EIFMAIDDJCI;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid JHLOHKOKIGE;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid IDKBEFIGOBJ;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid DFCNKPMOBFM;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid CJDIFCJCBJB;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid ONKKFMGMAHL;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid OAMILEGNEPN;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid HCACJHPKNBA;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid CNAINPMICMK;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private static readonly Dictionary<Guid, ENGMNDNJOAM> LHGDBKOAADI;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private static readonly Dictionary<ENGMNDNJOAM, Guid> OGKGNNEMIFD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, ENGMNDNJOAM> AICJLDNMHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62BFDF0", Offset = "0x62BE7F0", VA = "0x1862BFDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<ENGMNDNJOAM, Guid> JKOMIHNLOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62BFE50", Offset = "0x62BE850", VA = "0x1862BFE50")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JPDKFAHHODD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62DA650", Offset = "0x62D9050", VA = "0x1862DA650")]
	public static bool OKLIDDDDPBM(DMDLLGEPKMI NFJPKBKOIBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62DA680", Offset = "0x62D9080", VA = "0x1862DA680")]
	private static bool OKLIDDDDPBM(JMLJJOAAIHO DCIMIGOEEFD, DMDLLGEPKMI NFJPKBKOIBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct AILCEFABCCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public readonly MFPBKKFPNCD OKPCPCNGNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public readonly IEnumerable<FDEHGBEEAOL> LHLNOFFBAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly IReadOnlyList<FDEHGBEEAOL> CEFBAJGMELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly BOLDNJBHEHG<ADBOOFMFKMC> KIPIJJDDELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<CPNCACFPDBL<APJKLHNMCKH>> PFFJJKAMHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly ByteString BGEOMNENOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly OFKGLIOOCPC AOBGFLMKDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly bool PCLAFMLMFKK;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62BFCD0", Offset = "0x62BE6D0", VA = "0x1862BFCD0")]
	public AILCEFABCCK(MFPBKKFPNCD NCMHOFNMCEO, IEnumerable<FDEHGBEEAOL> EHICCJEFNJM, IReadOnlyList<FDEHGBEEAOL> IKIMHIDKGHH, BOLDNJBHEHG<ADBOOFMFKMC> EJKIICCFDEN, IReadOnlyList<CPNCACFPDBL<APJKLHNMCKH>> BELNJBLNJFC, ByteString JFCCLJNOLPA, OFKGLIOOCPC CEBHCOHGLMJ, bool OIGOCAMJGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ICCLKAILDOP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(CDJELMHBOIO ABDLEBPKDKC, [Out] Dictionary<int, int> PFLPNHCIJEI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(HGKEIGHFNGL LEAPDOGNBFM, AGEFDIPGCFM LNBJKBEAIFP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GIKNCLCGGDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly Guid EIMAHAKFMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private readonly Dictionary<Guid, Guid> GPMHNDLCLFN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> KLDKABGEIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36E89B0", Offset = "0x36E73B0", VA = "0x1836E89B0")]
	private GIKNCLCGGDG([In] Guid NNMMMIFCNGN, Dictionary<Guid, Guid> MBICBNLFOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62D8200", Offset = "0x62D6C00", VA = "0x1862D8200")]
	public static GIKNCLCGGDG KMJCCMPDJFH(IReadOnlyDictionary<Guid, Guid> FBCIPKMAIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62D8210", Offset = "0x62D6C10", VA = "0x1862D8210")]
	public static GIKNCLCGGDG LJONGICDCDI(IEnumerable<KeyValuePair<Guid, Guid>> FBCIPKMAIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62D8150", Offset = "0x62D6B50", VA = "0x1862D8150")]
	private static Dictionary<Guid, Guid> IDIENJBIEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62D8040", Offset = "0x62D6A40", VA = "0x1862D8040")]
	public Guid FODMFNOINIM([In] Guid JHOGCCPFJGM, bool FJLBHGBKLMG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x62D7FD0", Offset = "0x62D69D0", VA = "0x1862D7FD0")]
	public bool ENLFDGIMKGF([In] Guid MCGNHGLIJDN, [Out] Guid KIOCEAGPMEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface INAPBDDLCKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NKDNPGBEGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIBHLHEFCGJ(ByteString KDBHEHGNFHP, GIKNCLCGGDG GBDJEHKEDAH, [In] UniformTRS HADCMDAADKP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AFJMIBOIBLI
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
public class JOOHFBOEKEO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x13A19C0", Offset = "0x13A03C0", VA = "0x1813A19C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long HMKBPNNCEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xEC86E0", Offset = "0xEC70E0", VA = "0x180EC86E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long OMNFBBHIOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x62DA630", Offset = "0x62D9030", VA = "0x1862DA630")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC030", Offset = "0x5FCAA30", VA = "0x185FCC030")]
	public JOOHFBOEKEO(long GBACAOOHJGH, long BFNACMDKKEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FNKDNJBJJKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private Dictionary<Guid, JOOHFBOEKEO> GHHEJGLFDNO;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static Dictionary<Guid, int> DFOHCENPEDO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long GPIBJMPOFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xEC86E0", Offset = "0xEC70E0", VA = "0x180EC86E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long FLDKOFHCNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xF407B0", Offset = "0xF3F1B0", VA = "0x180F407B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62C09F0", Offset = "0x62BF3F0", VA = "0x1862C09F0")]
	public static FNKDNJBJJKL FMDPFHAFCEG(MFPBKKFPNCD HJMAIMGDFCD, CPNCACFPDBL<ADBOOFMFKMC> BDEMDJEPOCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62C1050", Offset = "0x62BFA50", VA = "0x1862C1050")]
	private void KONCOANMFME(GDLGGGHHOIM KDIAAEPKAII, long DMKCLNKFOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62D4C70", Offset = "0x62D3670", VA = "0x1862D4C70")]
	public FNKDNJBJJKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EIFNNOKBHMO
{
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly HashSet<ENGMNDNJOAM> NDGLNJDGNML;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JLIGOJFPMNO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> NKGCPHIFGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> PKHCGGHMFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D18F0", Offset = "0x7D02F0", VA = "0x1807D18F0")]
	public JLIGOJFPMNO(IReadOnlyDictionary<Guid, Guid> GKLKCLDFCCF, IReadOnlyDictionary<Guid, Guid> EONDGMEJKBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GHPFPAHFEFI
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62D7E50", Offset = "0x62D6850", VA = "0x1862D7E50")]
	public static FBCMLFDDFIA ODMMHNJDCPJ([In] AILCEFABCCK OBDJFLFAPBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62D7510", Offset = "0x62D5F10", VA = "0x1862D7510")]
	private static void NHOBHOJCAPE(FBCMLFDDFIA JKHMOLAKMJK, [In] AILCEFABCCK EDHOIEMOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62D4D00", Offset = "0x62D3700", VA = "0x1862D4D00")]
	public static bool CAMPCKBCOJH(FBCMLFDDFIA JKHMOLAKMJK, JFINBGLDLGL OLCBALLDMDI, GIKNCLCGGDG? JBMPMLGMCLM, [Out] JLIGOJFPMNO? MBICBNLFOLI, [Out] string? MBGOEMJAPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62D68E0", Offset = "0x62D52E0", VA = "0x1862D68E0")]
	private static void HMJFPDJIJAM(FBCMLFDDFIA JKHMOLAKMJK, GIKNCLCGGDG? GAGFIMNOBMN, JFINBGLDLGL OLCBALLDMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62D6E10", Offset = "0x62D5810", VA = "0x1862D6E10")]
	private static void KOFMPCGBJCF(FBCMLFDDFIA JKHMOLAKMJK, JFINBGLDLGL OLCBALLDMDI, IReadOnlyCollection<ByteString>? BCFLDHDDDPB, IReadOnlyCollection<ByteString>? KFFMFNFBDOC, IReadOnlyCollection<ByteString>? NHNANNEMMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62D6E80", Offset = "0x62D5880", VA = "0x1862D6E80")]
	private static bool MMENBAFJEJN(FBCMLFDDFIA JKHMOLAKMJK, HGKEIGHFNGL LEAPDOGNBFM, JFINBGLDLGL OLCBALLDMDI, [Out] string MBGOEMJAPEP, [Out] Dictionary<int, int> PFLPNHCIJEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x62D7B70", Offset = "0x62D6570", VA = "0x1862D7B70")]
	private static Dictionary<Guid, JMLJJOAAIHO> OCFBODJJNBB(FBCMLFDDFIA JKHMOLAKMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62D6840", Offset = "0x62D5240", VA = "0x1862D6840")]
	private static void EGOFFJDPLFM(bool IIBPIEKKDHO, FDEHGBEEAOL FLLKCMLDGED, Dictionary<Guid, Guid> HDPHMNCANOG, GIKNCLCGGDG LDPNOLADLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62D6B80", Offset = "0x62D5580", VA = "0x1862D6B80")]
	private static void IPBBOIGLPFP(FDEHGBEEAOL FLLKCMLDGED, Guid OKCGLJFNOJB, HMNPLJHNMLH? POJALCCJJIC, Dictionary<Guid, JMLJJOAAIHO> GNBFJKDELOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62D6390", Offset = "0x62D4D90", VA = "0x1862D6390")]
	private static void DKEBJPFIBBK(IEnumerable<FDEHGBEEAOL> IJBCPNNJNJC, IReadOnlyCollection<ByteString> BCFLDHDDDPB, IReadOnlyCollection<ByteString> KFFMFNFBDOC, IReadOnlyCollection<ByteString> NHNANNEMMJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JFINBGLDLGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public bool IIBPIEKKDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public OFKGLIOOCPC CEBHCOHGLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public HMNPLJHNMLH? POJALCCJJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public HMNPLJHNMLH? OGEOEHOOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public MFPBKKFPNCD HFLLGEBACAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public AFJMIBOIBLI ECMFDAKPIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public ICCLKAILDOP OGMNEGGMOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public INAPBDDLCKA LMFPIKENNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public CPNCACFPDBL<ADBOOFMFKMC> CFCGACFOOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public HMJNJCIKJKO IIAJGLGBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public List<FDEHGBEEAOL> OMAGDKFAOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public Dictionary<string, object> PLICBMICKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public DLDHELHPDPE IHKBEHDEDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool AAFNICHOMPH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KAJJAOCIBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x62DA5E0", Offset = "0x62D8FE0", VA = "0x1862DA5E0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HMNPLJHNMLH
{
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private const float EFHEBKEFAJK = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public Vector3 DGOJEOCFHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public Quaternion DMBBOEJIOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public float LFNFJOFKAIK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 CDMPBPJLJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62D9F30", Offset = "0x62D8930", VA = "0x1862D9F30")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS FCFAGCPDCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62DA1C0", Offset = "0x62D8BC0", VA = "0x1862DA1C0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x9F3970", Offset = "0x9F2370", VA = "0x1809F3970")]
	public HMNPLJHNMLH(Vector3 DGOJEOCFHHN, Quaternion DMBBOEJIOJM, float LFNFJOFKAIK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62DA510", Offset = "0x62D8F10", VA = "0x1862DA510")]
	public HMNPLJHNMLH(UniformTRS FCJGEGPNHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x62DA200", Offset = "0x62D8C00", VA = "0x1862DA200")]
	public static HMNPLJHNMLH OONDDHPCBCP(HMNPLJHNMLH HHJLJBMAMDD, HMNPLJHNMLH FBCBPKCLHIH)
	{
		return default(HMNPLJHNMLH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x62DA040", Offset = "0x62D8A40", VA = "0x1862DA040")]
	public static HMNPLJHNMLH KHGGPLGKNCG((Vector3, Quaternion, float) ABDLEBPKDKC)
	{
		return default(HMNPLJHNMLH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62DA060", Offset = "0x62D8A60", VA = "0x1862DA060")]
	public static HMNPLJHNMLH KHGGPLGKNCG(Matrix4x4 DKJDKDGBGOC)
	{
		return default(HMNPLJHNMLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62DA480", Offset = "0x62D8E80", VA = "0x1862DA480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62D9CA0", Offset = "0x62D86A0", VA = "0x1862D9CA0")]
	public HMNPLJHNMLH GPOOMNCENCC(Matrix4x4 OEIDOHJNAOK)
	{
		return default(HMNPLJHNMLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62D9EC0", Offset = "0x62D88C0", VA = "0x1862D9EC0")]
	public static HMNPLJHNMLH KADDPGEBBPK(Vector3 DGOJEOCFHHN)
	{
		return default(HMNPLJHNMLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62D9C10", Offset = "0x62D8610", VA = "0x1862D9C10")]
	public readonly EJIJEHCDMIF ABKPILCJOKN()
	{
		return default(EJIJEHCDMIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class APPMJOPIFPE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62BFD60", Offset = "0x62BE760", VA = "0x1862BFD60")]
	public static HMNPLJHNMLH PLKIPCAEHFG([In] this EJIJEHCDMIF CMJEIEIDHIK)
	{
		return default(HMNPLJHNMLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class FDEMPENNMMJ : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x62C0970", Offset = "0x62BF370", VA = "0x1862C0970", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62C03A0", Offset = "0x62BEDA0", VA = "0x1862C03A0")]
	private void CLPOLLCDPIF(Dictionary<Guid, Guid> ILMJFBMOJLA, LAAHJHEFODK GDFHLFPAOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x62C0340", Offset = "0x62BED40", VA = "0x1862C0340")]
	private void CLPOLLCDPIF(Dictionary<Guid, Guid> ILMJFBMOJLA, BBMOEOOOMLC MKGMBBPGLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x62C00C0", Offset = "0x62BEAC0", VA = "0x1862C00C0")]
	private void CLPOLLCDPIF(Dictionary<Guid, Guid> ILMJFBMOJLA, GEBEPJAPHOF CNNGGDKECKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FDEMPENNMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class FMHCCFPFOGP : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x62DD660", Offset = "0x62DC060", VA = "0x1862DD660", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FMHCCFPFOGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class KNPCBKEFMPI : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x62DD960", Offset = "0x62DC360", VA = "0x1862DD960", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public KNPCBKEFMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class GGNECLGGNEJ : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62DD710", Offset = "0x62DC110", VA = "0x1862DD710", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public GGNECLGGNEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class ENLNFBPKHII : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62DD2A0", Offset = "0x62DBCA0", VA = "0x1862DD2A0", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public ENLNFBPKHII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class EMIHCMCLOMC : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x62DD160", Offset = "0x62DBB60", VA = "0x1862DD160", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public EMIHCMCLOMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class FGPBODCOIMA : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x62DD4C0", Offset = "0x62DBEC0", VA = "0x1862DD4C0", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FGPBODCOIMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class CMBHFKPMDIP : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x62DD070", Offset = "0x62DBA70", VA = "0x1862DD070", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public CMBHFKPMDIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class MCJJFPNGHNK : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62DDAC0", Offset = "0x62DC4C0", VA = "0x1862DDAC0", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public MCJJFPNGHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OLNCKDLNMPI : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62DDC80", Offset = "0x62DC680", VA = "0x1862DDC80", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public OLNCKDLNMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class JMONAIEGDKO : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x62DD860", Offset = "0x62DC260", VA = "0x1862DD860", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public JMONAIEGDKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class ONIOEECDLLI : HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly KFAKDNFNLPJ PGOJGGBENPH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x62DDE40", Offset = "0x62DC840", VA = "0x1862DDE40", Slot = "4")]
	public void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public ONIOEECDLLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct DMDLLGEPKMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public HGKEIGHFNGL LHMJGBJEDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public KPHOIPKOKCK BECIDIEKNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public Dictionary<int, int> KKNKDCMBBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public Dictionary<Guid, Guid> NMKMDFJHABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public DLDHELHPDPE IHKBEHDEDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public bool NHCOKFHAEJP;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HLOCHIADPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJEDADGKGCC(PBCOMOMJFPC IIBKMIEDGJB);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BIAMKEHLBGP
{
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly HLOCHIADPMC[] FGDPLIEIGKC;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x62DADF0", Offset = "0x62D97F0", VA = "0x1862DADF0")]
	public static void IOOLDODFEMG(FDEHGBEEAOL ABDLEBPKDKC, Dictionary<Guid, Guid> EDBIFLNCPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x62DAB60", Offset = "0x62D9560", VA = "0x1862DAB60")]
	public static void DPNBKEKGPKC(FDEHGBEEAOL? ABDLEBPKDKC, GIKNCLCGGDG JLCHFFEMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62DB450", Offset = "0x62D9E50", VA = "0x1862DB450")]
	public static void OLALGCLLGNJ(FDEHGBEEAOL? ABDLEBPKDKC, GIKNCLCGGDG LDPNOLADLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x62DB080", Offset = "0x62D9A80", VA = "0x1862DB080")]
	public static void OKLIDDDDPBM(PBCOMOMJFPC IIBKMIEDGJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct PBCOMOMJFPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public HGKEIGHFNGL JGANEOCEGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public FDEHGBEEAOL FLLKCMLDGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Dictionary<int, int> KKNKDCMBBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Dictionary<Guid, Guid> NMKMDFJHABG;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62DDF70", Offset = "0x62DC970", VA = "0x1862DDF70")]
	public Guid NJMJIPFNDPM(Guid JHOGCCPFJGM)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DLDHELHPDPE
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int CIOAOLGOEEC, [Out] Guid CDMHFPELFMO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class CIAPJDNGACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private readonly HashSet<string> KNMLALGDMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private readonly Dictionary<long, int> FMDCICBFCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private readonly HashSet<Guid> LHACPNOEKNI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<string> MBBCCNEBKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> EGGDEELDBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62DC0D0", Offset = "0x62DAAD0", VA = "0x1862DC0D0")]
	public static CIAPJDNGACL MECBHCMDBFP(KDPHGEEOLAK GOGGOGGMFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x62DBFF0", Offset = "0x62DA9F0", VA = "0x1862DBFF0")]
	public static CIAPJDNGACL JCAHHAPIPNK(FBCMLFDDFIA PBFJJENNECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x62DBE70", Offset = "0x62DA870", VA = "0x1862DBE70")]
	public static CIAPJDNGACL FHJOHDKADFI(IEnumerable<string> KNMLALGDMKG, IDictionary<long, int> NJAKIBDEOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x62DCE10", Offset = "0x62DB810", VA = "0x1862DCE10")]
	private CIAPJDNGACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x62DCF30", Offset = "0x62DB930", VA = "0x1862DCF30")]
	private CIAPJDNGACL(IEnumerable<string> KNMLALGDMKG, IDictionary<long, int> NJAKIBDEOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x62DCA30", Offset = "0x62DB430", VA = "0x1862DCA30")]
	private void PPMJCLOOHKE(KDPHGEEOLAK GOGGOGGMFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x62DCC20", Offset = "0x62DB620", VA = "0x1862DCC20")]
	private void PPMJCLOOHKE(FBCMLFDDFIA PBFJJENNECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62DC140", Offset = "0x62DAB40", VA = "0x1862DC140")]
	private void PPMJCLOOHKE(CIAKKFHNFNK? AKBOHBAKCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x62DC860", Offset = "0x62DB260", VA = "0x1862DC860")]
	private void PPMJCLOOHKE(CPDENFKGNHP? KDIAAEPKAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x62DC470", Offset = "0x62DAE70", VA = "0x1862DC470")]
	private void PPMJCLOOHKE(FDEHGBEEAOL? FLLKCMLDGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x62DC060", Offset = "0x62DAA60", VA = "0x1862DC060")]
	private void LEDFEBAAGKK(string? ACJJDLDBCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62DBCA0", Offset = "0x62DA6A0", VA = "0x1862DBCA0")]
	private void AMHFJNBEEGD(LPLPDOALCAL? LIPBANIMKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x62DBD80", Offset = "0x62DA780", VA = "0x1862DBD80")]
	private void AMHFJNBEEGD(CJOHFBJKJMG? LIPBANIMKPF)
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
