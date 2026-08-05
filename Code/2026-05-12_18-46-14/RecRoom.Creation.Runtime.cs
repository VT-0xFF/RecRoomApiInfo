using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Build;
using RecRoom.CircuitsV1.Protobuf;
using RecRoom.Core.Creation;
using RecRoom.DataLayer;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Algorithms;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.ObjectModel.Serialization;
using RecRoom.Persistence;
using RecRoom.Protobuf;
using RecRoom.RendererV1.DataProviders;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98F8080", Offset = "0x98F6A80", VA = "0x1898F8080")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class VQSEWTUPMHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> WLVRQAWYRPR;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> AEFPQWPZPDJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> ZIXEKNYLJXD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> FMSLNTOSIYO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string CBYYCWOMDIE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string EBNYWWFXHPP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string NSDKXEJJTFW;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x98F8310", Offset = "0x98F6D10", VA = "0x1898F8310")]
	public static bool SIPWFNLMEVF(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x98F8280", Offset = "0x98F6C80", VA = "0x1898F8280")]
	public static bool OYRSIBQWNDP(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x98F8410", Offset = "0x98F6E10", VA = "0x1898F8410")]
	public static string WLXCLSCHOIE(Guid a)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DisallowSerialization]
public enum SpawnableToolType
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	RANDOM_PAINTBALL_WEAPON = -2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	INVALID,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	AIR_CANNON,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	AVATAR_ITEM_DISPLAY,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ELEMENT_SNAP_POINT,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LAUNDRY_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_HAMMER,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PAINTBALLSPRAYCAN,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_DISCOVERY_POPUPSHOP,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_ROOM_BOOST_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	WEARABLE_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98F7FC0", Offset = "0x98F69C0", VA = "0x1898F7FC0", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class RVRBFEJWVVI
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid KVHYPBRPXYT;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid BOHMHXRISUO;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid NPMYXJBRXJN;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid ICFLFQGTAOR;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid TWCLCHQWKIV;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid PKHHZDWLKYE;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid QAOOVZBQSTS;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid WSNHTTFLGRG;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid GQYLXUCHZQN;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid INNHWSUUGNM;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid LUVNEDXFSQW;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid VJMXYJMQKRI;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid WMSOIEYVLVV;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid ZNLIJRGOPKW;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid XEZJRSXDLCV;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid GVKRAFDCWYO;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid TWYJPDDVIDP;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid RBCGHXDLXFA;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid XEUIHQEBEPG;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid FXGLSJHXOXL;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid IWXQDKENJUO;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid CPSAABJGMHG;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid GKRCQWDUQJX;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid MLTSKGXSSPR;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid BJSLRECDIVF;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid MYWBQNAEZDH;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid GCOSNRKLIWH;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid EZVARNRHQRT;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid YLNFDONDQIM;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid GKWOQCTFQKJ;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid AQFBWSPGDPA;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid BGWGQGOKXIO;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid ADXVIJGWFSX;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid SFGAMKTTREB;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid OFTVIPOKICA;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid UJFBEFYNMDV;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid XTEEUZIHJLU;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid NHLJJAZPUAI;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid MBAUVEVZRES;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid RDZGUEPWZKI;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid PJEDYSJYOGG;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid OFLDDWHOSMK;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid YWDPHKIZQOY;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid BWTMVNUZNWM;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid NGIIDECVLOC;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid HZXVQFUIMSP;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid HBMVCXUAXEQ;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid UUXOEGBEYNL;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid JQOVOZBZUER;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid EXRQMYASDWZ;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid NISYKHEYOFG;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid OQHVUZRIVXJ;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid TKTAENHCZIO;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid XFGHLKMXLQG;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid IZJIBYHDTVD;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid HAJGZSJUCJX;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid VBSODVROAMD;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid BEMIXZTLEHS;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid QFUUNZVUMKW;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid JSNAYVYLKKP;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid LGICJQHJYWZ;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid NLKFWZRAGYE;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid FDGHIFMLSJP;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid CPQBDBBMPJU;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid YKWDNLIKVNY;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid SLDTNYZFXFP;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid AGWPGFQREFG;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid DFTPSQEGUEE;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid MDJRKRVIAIP;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid GUTYXFNOMTJ;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid TZBWPINLYRE;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid TYTGHUPUOKX;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid LAYICLTTJBK;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid DMAONFJEMKH;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid HIUCRNAQRYO;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid QWMJTSWHHVS;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid KJMLICGVPPF;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid TIXULFUAXYV;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid RMXSDJWEQUF;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid AMEIGYYYLTH;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid LKBXPYHTRBD;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid COZKGRUMZPG;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid HYAIICXUHBX;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid HBCYYEUOGYW;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid HDTPKSHSQYJ;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid IDWONRYCJFQ;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid LERQKONPQCC;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid DUYLBNPDENG;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid WECFDPCDKIH;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid HHFITNEKKWG;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid YFIZIUBBPEC;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid QLGCLCCFPPZ;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid CTLFICATPCL;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid QQFEADZVAMO;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid UVGEFYZAOZE;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid KDLKLXBSSMK;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid NFOZHHOVUOU;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid AUOMAZWCLVE;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid UIXEXJGIBVR;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid DAMHEKNMPOW;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid TXMZPIIQCTE;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid AZZLNSRUVTT;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid OMANOBHXCSK;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid UUCBCPXJQLT;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid JBQLDZAJFHY;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid UTRNICJOXPB;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid IXUJWRXSJXC;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid AUVHOAGLUHU;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid EAAXJADNPMH;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid CLKTSCJESQE;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid QCADJZTZSRD;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid CLVHMPWZLMW;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid ACYRCCRWQXN;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid CMFVHDKUEJO;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid RIAFKSEWZOR;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid NJPXHDGFSAV;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid CBNWVWHRPMU;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid IRQVLSJCLNM;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid WSFFYXDSYMF;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid KQXJKNHLWZC;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid ANXEGKUCQJS;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid AECDOAVZAAB;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid APLUVGEXYSO;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid XDVSNCLSPTA;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid QVCVXKADOZY;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid FLEITQERNIS;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid KAJJNULGTFO;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid ANHMVKDNJXC;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid TEAEHDPKWYA;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid TPMJLIIRGOF;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid RFEWBZCMCVA;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid WBAUJVUZZTG;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid TPSKCTRVLSE;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid UBXSLDZCBZV;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid XZBKVGZQQMI;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid YWFFSBPYKHV;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid YTINLCGUZTP;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid MVJDNKNCGWS;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid MUGZJDORMWU;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid UGBCCOUJCWP;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid PBNLUAQDCQB;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid FLBRKAPPTQQ;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid EVMMUKUAIMS;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid NLRQAUSTJVD;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid KEIQUGFMRLR;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid DRDGHKHXRCP;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid FZZZZNHUVGV;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid DOBLVBVEVPE;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid HINHDKWQWDQ;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid HIIAGECTMSH;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid HICTIXIWDGY;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid HJNPPSSDRIJ;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid HJIISLYGHXA;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid HJDBVFEIYLR;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid HIXUXYKLPAI;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid CPWYRLPRGJA;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid GAGXHRLRQRK;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid CFCTTGLIILD;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid OTQECWARPAB;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid FXNLMJPDTUY;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid ZLJTCMVYYTZ;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid FVLKJICYXJH;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid MZJDXOCHMQJ;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid ECKFTMHXVPI;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid FZQPBRMMVGU;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid DCUENYQZNIB;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid VKQARJFXTYI;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid ZKSATARGEIX;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid ECNPRRBZYKJ;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid NJVDASJOICC;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid RXPGACJEALV;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid EBXUZWUHWCI;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid ECDBXDOFFNR;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid EBNHFJGNDFQ;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid IRFYCUGSPGJ;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid VEICRWKTLOS;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid YOOGDYUQSRF;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid IQQDKZZAMYI;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid EXWFRYXTIPH;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid RSHULPNHLBS;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid XLOZWDJPCLI;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid TBWTSRAMHSP;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid MTIMMDIBSQD;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid IMQSGRCKBTL;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid TARNYEOCTHV;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid BULWFANDOCV;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid IHMTCNMUTGG;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid RVGLSCVKNJT;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid JPZAKGHFWEY;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid JZMKHKPCJZE;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid LBOIFUSBLYU;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid LMZZNDHOXHU;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid SPXXOFDZNZJ;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid ZTFYZFQGLON;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid KYBAIPONGLO;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid DGLOHLBTYKK;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid MVADVBQGAGZ;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid PBXXJLWZZLM;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid NCDBOOLWGHS;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid ECELGTOWUCN;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid MPXEFNQNAPG;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid WDNYZNMNMPJ;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid GXTHPVEETNN;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid YHGPXYWADDY;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid SQNOFKUSZJV;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid EAKMPKKSTNG;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid VHEVDPGRUBE;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid NLBHRCWLSAY;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid ARXTHFNCHYD;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid ZKIXALNUBOK;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid EUVVABBJFOW;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid IIEAKXXNDRP;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid LOWFPOLGHHR;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid YVDWQLZKVXE;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid VCUVBWHQPZB;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid YNKTDHFJZBA;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid OTOQWEEAZOL;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid EOCJOLOJQHZ;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid JLLRIADKONL;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid THGDXXWKTPD;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid KFUOXQAGVNQ;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid JOBIAVROUGM;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid HUIFHUFSTCV;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid DRZSWHKAZOC;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid YCDBZVBMTFV;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid NQRKLPHCHEZ;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid GSFKYXRBXWR;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid OMRXAALGVDC;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid FDDSTIDZNLK;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid RGVWNTNFZFB;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid AGKFWORKNHQ;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid JKVRECUZYEB;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid BLYNXXTGHBI;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid VFVKWWOYWIS;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid GRMBNRQVQKQ;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid YLEUAOLLGJI;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid YKLWGJZZGRO;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid PBPYESCGBBY;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid SQEYYFIVXBL;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid CVRIDGHQAJC;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid MAIKZIXXUFQ;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid HFXNMUEBUGX;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid IJCGUXHOKWC;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid BORAWKWRKAN;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid XPVYXRXKMRR;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid LJLSFYQPUTT;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid QJZYSUJQTPS;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid LHNAAFGYXVX;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid KEILTRSPXRO;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid PFYEZCCVNPS;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid LNYDIGMNDAZ;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid AXNQZRSJVEI;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid WSPSXMFXYQI;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid DODRTDGLADO;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid VMYBKJUKLKE;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid PRFHFPNETVE;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid VWGXITQTCNA;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid RBVERNLWABF;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid ZWSGBCIWWMD;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid OTDADLLDFCQ;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid TOQKCLJMCMX;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid NHBREYMPINY;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid KIELNACGDQK;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid UEKVWXYHGZN;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid XZUHMBOGCMW;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid APRDYQUJPTE;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid DHSAZGKZPWS;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid HJZXDVMIWNK;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid QMPBNPKSVAQ;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid ITOEOHITNGE;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid KVSFXVHUSXG;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid ZLHBKCNVKYR;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid VVDISTBACFX;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid ZJPZXUZLRGO;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid UMZCJLISMFT;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid TRLKYTELPIS;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid AFKHPXUEPRY;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid ILTVSJXUCTP;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid GVSFQSDZKYM;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid YFXYOBABRBI;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid ADCFYVFKYSE;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid WVEBITNAAWH;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid IRJUESHNNUL;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid WFSDPLHYIFJ;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid JKUKSDQFBVQ;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid BPCZUBMAHYY;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid WLFBGKPBCRI;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid XGOAFZZBYFQ;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid ANCCXPKHFIR;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid EKVCVKQZBXV;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid EYVMREMTMGH;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid HUCCGJEVXLC;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid UTTOWSFRIZW;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid YQCRRQGGEIR;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid YRLYFDUSDWZ;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid WREWOEIJLCI;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid QDZNZVLWEBY;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid MHMAKSSWQUR;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid GEWTNFPDJUG;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid RMLVQGWAEXV;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid PBDHJTFBOEE;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid BUGWXYORNXW;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid ASHQZWWRMYW;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid GCXBRWGBGSF;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid YUOVOPUQDHZ;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid GNBMQWNOMWR;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid UOPDLXRNNQA;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid CRXNBQJURYB;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid SQLNGFPTUNX;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid WOYWJLKLTXB;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid YHJEQGFHWPR;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid UWULTVAGBLS;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid AKKQEXTVEZO;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid GHNCIEKHLFY;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid LXHJKREXPME;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid LUWIDXNXJAQ;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid TBYWGYNRUZA;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid AVSEIVSPHSN;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid DTZQETFGILD;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid ODSIJTCHLYW;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid UXQJOPHRQWD;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid TBFHPDRVAWB;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid FJZOQCLLNZR;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid FRWXZBCXDTQ;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid GOXAVEFEIWK;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid SKIGJWZDLWZ;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid CFARGMQIURJ;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid XDMLFIMPBBL;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid WEMWCTPKKXX;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid BFSEFRGMKMC;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid JFCQFNGZJEA;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid NEPQQGIYMAH;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid NUEXHSXXOGR;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid TUNHCKRISVJ;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid CPCHUQSPFVB;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid OPCVLNQBZOY;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid GTHYZUUCXRG;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid QHJJBIIBJKU;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid LLWQNHQALTN;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid ZQJYHGMBUVV;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid TPBGHISITOO;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid MHIRXHBUKQI;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid YNVCCGWFGCJ;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid XLHKJWCJUWF;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid VKTORCPDDQE;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid SMJXFKCNZKJ;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid VLCBUSPFXXL;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid BOKJBDKQOUK;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid MZBOWWEWLPH;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid SAPSOKWZHUP;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid TDEFBFRVKVG;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid OMIWQVXLXRH;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid SEEDKWVDDJM;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid PMLGHGAVIDR;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid MQOHBPZLKIB;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid QSHDFNTYDAT;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid OBUUOFKILKJ;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid SVSVJCSRCGC;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid BYPLXMLIBWO;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid GNZPYLRYNFJ;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid THCDNCXDXTA;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid WLZPQVHLHFO;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid TVJIJAJXLYA;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid NGOLUKWNDXD;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid EHKOZZHZECA;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid OUABTQONDBX;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid FLOFVEKYPZC;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid JRNUSFGNYWB;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid NITPUSQYOAD;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid UMNYNZCOQVK;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid SSFUUTKRJFS;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid CHKVCXAQSHG;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid YVDDGPUPQUY;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid SYWLHBXGFCA;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid XTQCIOKGZTZ;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid NVRLNFFUVDC;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid EZKIXYWFTSR;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid NTIJLQPZCBY;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid GXEXEUSLQFP;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid BJYJIQEWTWE;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid PTZWNPVZCFR;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid LBIFQVKDJEM;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid ASMGEUYDQUH;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid CLCSVWTZPSO;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid FGOEGISOUZZ;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid NYDYGVWFGVP;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid ECNZKZSIAMC;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid RHBBSNLBZEH;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid GEQKFOPMUAS;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid HXLNEWFXATN;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid CQSESRONUUX;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid MWLCFTIURSL;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid EXBMTPGETDP;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid GXKWZXWXVAQ;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid UIFVFJAYUHA;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid APSLGVUBVAF;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid SSOJXMOFMAU;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid SOBPEIIFKPF;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid GSVXGKUCTUB;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid GRKMMTSPRCD;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid MOCKKJPYWVL;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid ELSQQPVHQCQ;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid NWLAXULGWIP;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid DFRNDKSLUZS;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid ODOQTHHLDGA;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid FSIMNATAMNH;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid LBHUHEAOIBV;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid UTIILLSZSNW;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid ZZHMGCNVRBE;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid KGQPDSYIHUC;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid AATTMFIRNXB;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid XTQLEWEFFFS;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid MMTOFPGARXF;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid SOKKUVLRSPR;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid AARPQMPJSKE;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid QMELGQURMEG;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid PBAKDWJSLHC;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid MHFJOCQCFYD;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid HPWDWHZXQUC;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid ZPCNQDTDMGK;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid BCWYMRQICSU;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid QDMKVNPYDAG;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid FOKCBIUIQDS;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid FSPDLKYUWAZ;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid ZEMXIPKWGDN;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid SAJIXMZSMUG;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid VZLPBLNJLPA;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid SAECAGFVDIX;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid RZYVCZLXTXO;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid SBJRJUVFHYZ;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid SBEKMOBHYNQ;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid SAZDPHHKPCH;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid SATWSANNFQY;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid RYYMQRQKYSV;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid RYTFTKWNPHM;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid IWALROKHMVC;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid PTXQULBRLDW;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid KDMVZBFIKZT;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid ACKGEURNXXT;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid AMKSHGNKYJX;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid RDGYEVZNBQH;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid BPRDYUIRFJU;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid KPFFRGGJUJY;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid ZNLUJBLRGAP;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid BBUOQUPECRT;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid JEPRHOKMOBG;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid WPMPBITUAOS;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid HUUHVRMLLPQ;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid KXKTSAMDMWB;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid YUJRLBCAPHW;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid ZKVXCCNSMKY;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid SPZVVGDLAXN;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid ELZOIVNGZDJ;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid IIXQSHKGSEB;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid PYYCLRQRRSZ;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid SBLDFXLMOCW;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid FPHIHKGMMRX;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid FPXCZEOEOZY;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid ZEPRKMTVRUA;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid HWOJAZSJMCZ;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid PHDQHWHDOWU;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid MAYNVXBTORH;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid AEWXGHIZYAF;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid UCGIQHJTKIO;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid KRBPCKIKKTQ;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid VBIRIIMEOBO;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid QMNWCRHUUJO;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid YYFNZMHAIHK;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid GFDIJJOHJKZ;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid NUJHCFACSFC;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid WJGOLPHEEVO;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid GDLVXADMAMR;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid TPOKBEXNURG;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid QERTURFUIYJ;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid YGRGDJXPQKY;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid XVKWXYJEOBW;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid JWGCRGIUOGD;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid IYRAACAYXOM;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid YOCFVTFHVXW;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid ATKIVPKWGWU;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid UBUQAOHNQZQ;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid FSJEACJMDER;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid YQUCQNQTHQV;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid RSUEXTIJQSZ;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid XQWKNYDEDHT;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid ZIAUQUIQAVX;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid JDECLSQBVFZ;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid OPNKXTCBCGU;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid AUEXOIGDVHF;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid FQGAJJNAFKJ;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid SDMYJIQVFDG;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid WARZLACUGFI;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid XGTZBXVECJJ;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid ZMDWCBGINPC;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid GEMMVMURZQZ;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid YYDDUMXPUPJ;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid SYOHIZNKTMW;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid BADLLDAHICG;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid YJMYYGAIDSW;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid IHCBMESVZMG;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid KASNSRJNYFO;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid HWDONPYFYUL;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid DCKGBVIIGUB;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid SHAKHGIMHAA;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid TJQDNVTBUMH;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid ILISNUMZOKE;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid HCKZNBBEVVX;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid FYEQCAKGXUA;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid PROABGNALBH;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid NXJBAWTMDZU;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid QOKCUKCLZJF;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid FVXCUKWCBMT;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid SDVNAFCJPFO;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid JCJRJVYZFIC;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid CWKEMDRSFIU;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid QSNIBBIHCAF;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid DXHOYZWIFUE;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid CQEHTXYZUKJ;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid MTAESNQONLB;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid IEZAZWEXYXU;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid PGPZCBJIMDO;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid PGVFZIDFVOX;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid RHWAGLZRSZP;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid HOCWLOTAYUP;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid OAWTYAZZKXC;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid BYFXBTVATXA;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid IQVZYYVAHUM;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid FLRRVSGSQCJ;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid GQGLERPAIGU;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid NCDWHVWLJFX;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid FDGBMKVWQWA;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid KGSRGUIDNXY;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid TXURWMKDYPN;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid GJPBCAEGQUI;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid SFBNJPROMPU;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid QUHKYFGYEPU;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid LJCCAMOVVFB;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid EMPEMOYYWBZ;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid EVDPZPUNTUU;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid ECZLNYVPGPQ;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid CSUGQBWJLBH;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid HVIESHODUQJ;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid NIQDFIUIQFU;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid KXYYEHDBTOU;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid NQIUGWTZQBO;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid SSAEAUSUPHW;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid LEKVJLUGARG;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid ZOJRNYAIMYZ;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid PXSCTPBMPXP;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid MUNEQRFMROW;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid TXZSANWCJZB;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid IMALXRMVUIL;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid RQJNWZGJFXM;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid LSQAPWMULHB;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid NDHWVGAUEPO;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid CSOAEIYFLYG;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid XMBPJWZEUMH;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid QVNEYJQXRTX;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid WCWEFPQUQQR;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid YYUGZZLAKVT;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid DUQXIZUPQLP;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid NXLZGIDMDSL;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid LGOLGGOFRRO;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid HPMISDLSREJ;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid IPVGAZJAHLC;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid BJRCKBYUJEC;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid NYQSDKINKNM;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid VYWUTPJJFFY;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid QXXTFSVMNED;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid UEJZHUHYFLU;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid MJRHQAEPELD;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid TRWBAOILPPR;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid TSBHXVCIZBA;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid TSGOVBWGIMJ;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid OOGWDNUJUCA;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid EALDNHJFMUQ;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid EBAYFBQXPCR;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid NYLXYPIQFMV;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid ZVOUAPVLUUV;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid NVKGTSIYECR;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid MLITAMOOIHQ;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid DAYYZSMAXHJ;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid TUUYJAPDLPX;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid TUUCGURUPKC;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid VLXZBHDCGOQ;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid TSRIZBZZWQV;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid MNJSPIIAPLT;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid DTLJBBJDVMZ;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid HCUZUCJUGKL;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid LGVHFUWQIJE;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid RRJKRYGXAAK;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid LPRVTPWHKRV;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid GEIZFUUHGNH;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid BVGNSDNMSCI;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid ZCBQVTRMFIN;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid WXMZIJWKVJB;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid OEWPAMXSTJD;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid MQIWRWTLJXN;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid RVDTXIRMKQU;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid RTZMQEYXZYP;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid QRPWQIQBMDM;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid QFXMWPXUYPY;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid RZYGIYIVFQI;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid ARISLODQGCF;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid AHDMYHSTTKH;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid SCUMKMBENUP;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid QKVRVSRGJNV;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid MNPHXYICLBT;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid BWFHIAEREUB;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid AZAZHYQIEDH;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid JVDJBCMXCCG;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid XFLNDGTPBPR;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid TUZYVGAXSFT;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid NMBEERAADWO;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid HGFNVSIQSTP;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid LYZRVCOSIMF;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid HZAZBTVFFPZ;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid TVBJZASHCRX;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid BJXIMVUUDAX;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid ETGJKZRHJGH;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid EEAKWHAUIBU;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid FUOBXMFJWJP;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid ZINEGNSQLUT;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid PMGEVVVDSVH;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid JYFXVKOKQOO;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid YEPXQCMXGBK;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid YQNJLLXSQCC;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid HVEAHIIAQYD;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid JYUGUZZSHYE;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid JRKLIZQWNLV;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid PSFSSESMPEA;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid VVVCUNUGDNV;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid JWNNLLGFFFB;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid VMCAKRQCMJT;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid CHGBXQZJLES;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid VVVJNMVJZKP;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid SCAVCLCVIXF;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid FOIDTPBMCLU;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid KHMJIBTRZGG;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid RSNCDIWYPHP;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid NKPVZCQCNQM;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid IHNMIULFTZL;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid GNAMJDIOJSM;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid JFHIYHAUTDT;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid DSPVJRVTUJV;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid OHRNROUNQKC;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid YUFUCXSCMGC;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid WHILNCBMWJN;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid EAYYOZDUBTQ;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid MLUBZDTMDOC;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid FACJLFTEQIF;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid ONKEBLJCYAO;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid SXWUTGTLUJJ;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid DWPVZRDZIRH;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid SPCMUWBIEME;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid PCFIRHUKOGK;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid NIFNGIPVQVZ;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> YMZWZWLRGJN;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> OJUDJZCRIID;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> ACIEYLWLWAW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x98F8230", Offset = "0x98F6C30", VA = "0x1898F8230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> JNPPXSWUGMC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x98F81E0", Offset = "0x98F6BE0", VA = "0x1898F81E0")]
			get
			{
				return null;
			}
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ZIAOBTHZBOX
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98FC040", Offset = "0x98FAA40", VA = "0x1898FC040")]
		public static bool CJUKGNXWHFT(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x98FC070", Offset = "0x98FAA70", VA = "0x1898FC070")]
		private static bool CJUKGNXWHFT(MERFDKTLKAK a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface QMJDOPILLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(UERRNXNKTMZ data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, FSGRHONWUQJ circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly UESRNTRQLCK Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<FDPQDCZIFNA> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<FDPQDCZIFNA> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<MHARATWVONH> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<TOXCFTIABCD>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool EVRHZLSQJLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98F8100", Offset = "0x98F6B00", VA = "0x1898F8100")]
		public R1CreateTemplateParams(UESRNTRQLCK circuits, IEnumerable<FDPQDCZIFNA> rootData, IReadOnlyList<FDPQDCZIFNA> allPersistableData, Id32<MHARATWVONH> sourceGraphId, IReadOnlyList<Id128<TOXCFTIABCD>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly UESRNTRQLCK Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<FDPQDCZIFNA> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<MHARATWVONH> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<TOXCFTIABCD>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98F8170", Offset = "0x98F6B70", VA = "0x1898F8170")]
		public R2CreateTemplateParams(UESRNTRQLCK circuits, Id32<MHARATWVONH> sourceGraphId, IReadOnlyList<Id128<TOXCFTIABCD>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<FDPQDCZIFNA> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ZZJIDZYREMB : XJKGWJSBQPR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid ILJNSJGVPQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> GAEGCDSSMCW;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x64F3FA0", Offset = "0x64F29A0", VA = "0x1864F3FA0")]
		private ZZJIDZYREMB(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x98FC690", Offset = "0x98FB090", VA = "0x1898FC690")]
		public static ZZJIDZYREMB New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98FC870", Offset = "0x98FB270", VA = "0x1898FC870")]
		private static Dictionary<Guid, Guid> TBOLZRQFMGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98FC500", Offset = "0x98FAF00", VA = "0x1898FC500")]
		public static ZZJIDZYREMB BRBIMPPRCTS(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98FCBA0", Offset = "0x98FB5A0", VA = "0x1898FCBA0")]
		public static ZZJIDZYREMB XOCSNSKYAUF(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x98FC620", Offset = "0x98FB020", VA = "0x1898FC620")]
		public Dictionary<Guid, Guid> LVJZJBICXNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
		public Dictionary<Guid, Guid> CTBXQUIZDDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98FC480", Offset = "0x98FAE80", VA = "0x1898FC480")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98FC920", Offset = "0x98FB320", VA = "0x1898FC920")]
		public void UFSULKQRXKC(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98FC720", Offset = "0x98FB120", VA = "0x1898FC720")]
		public Guid OFLDNDTJLNG([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98FC510", Offset = "0x98FAF10", VA = "0x1898FC510")]
		public Guid DRPWYUNMYYR([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98FC5B0", Offset = "0x98FAFB0", VA = "0x1898FC5B0")]
		public bool HYBBASYPRWW([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98FC5B0", Offset = "0x98FAFB0", VA = "0x1898FC5B0", Slot = "4")]
		private bool OGZHULUJFGK([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface VMRWBGJEDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BCKPEZPHXCO(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZTHCJRSHKEW(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DIGNRBRHMPT
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<ByteString> GetValidRoomCurrencies();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<ByteString> GetValidRoomConsumables();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class KZZGIHWQTTD : VMRWBGJEDFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class HZZHNKFTXXU : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string VUFSVYKOYVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x104AC00", Offset = "0x1049600", VA = "0x18104AC00")]
			[DebuggerHidden]
			public HZZHNKFTXXU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x98F73F0", Offset = "0x98F5DF0", VA = "0x1898F73F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x98F74B0", Offset = "0x98F5EB0", VA = "0x1898F74B0", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x98F7360", Offset = "0x98F5D60", VA = "0x1898F7360", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> WXHIMBXTBKY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x98F7360", Offset = "0x98F5D60", VA = "0x1898F7360", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? QURTCEIXZTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? TMMBEEBCWYP;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> SQJXKFPRQRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x98F7860", Offset = "0x98F6260", VA = "0x1898F7860")]
			[IteratorStateMachine(typeof(HZZHNKFTXXU))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? QKSNLWJJPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool ZWKLZEUFJQT
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool BWMCIDQFFKW
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> TBYROHEQLTL(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool CIANOURVBDV(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98F78C0", Offset = "0x98F62C0", VA = "0x1898F78C0")]
		public void NDTKVZQOUOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1057720", Offset = "0x1056120", VA = "0x181057720")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98F74F0", Offset = "0x98F5EF0", VA = "0x1898F74F0", Slot = "4")]
		public bool BCKPEZPHXCO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98F7E70", Offset = "0x98F6870", VA = "0x1898F7E70", Slot = "5")]
		public bool ZTHCJRSHKEW(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98F77A0", Offset = "0x98F61A0", VA = "0x1898F77A0")]
		private bool MFXURSKXVKK(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98F7CF0", Offset = "0x98F66F0", VA = "0x1898F7CF0")]
		protected List<Guid> OCSJHMJFXWX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected KZZGIHWQTTD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class FQYSGZCFFXL
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OOGQAUXPEDU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public UESRNTRQLCK CPUZKTLJPPY;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public OOGQAUXPEDU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x99034D0", Offset = "0x9901ED0", VA = "0x1899034D0")]
			internal Id32<ZGLOWXIDQQC> ZAFHDOJBAXS((Id32<MHARATWVONH> GraphId, Id32<TOXCFTIABCD> NodeId) i)
			{
				return default(Id32<ZGLOWXIDQQC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int IJAAQICSYMK = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<ZGLOWXIDQQC>, QIBMHMHCRIU> NUDCLPUIDQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long SUNFZNZWERW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long ZXQEYMGDFOV;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<ZGLOWXIDQQC, int?> XBAQZFOARTW;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long XIKWSUECPLE;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long ADTNXDVCVIU
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x98E9B20", Offset = "0x98E8520", VA = "0x1898E9B20")]
		public static FQYSGZCFFXL CYYYUZUIIAI(UESRNTRQLCK a, Id128<MHARATWVONH> b, [Optional] FQYSGZCFFXL c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98E9780", Offset = "0x98E8180", VA = "0x1898E9780")]
		public static (long, long) AKNQIXNNTNI(UESRNTRQLCK a, Id32<MHARATWVONH> b, Id32<TOXCFTIABCD> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98EA190", Offset = "0x98E8B90", VA = "0x1898EA190")]
		public static long QDDPNWXYTUR([In] ReadOnlySpan<Id32<ZGLOWXIDQQC>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x98EA060", Offset = "0x98E8A60", VA = "0x1898EA060")]
		private static long FJUSANTKTPQ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x98F72E0", Offset = "0x98F5CE0", VA = "0x1898F72E0")]
		public FQYSGZCFFXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class QIBMHMHCRIU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xED2460", Offset = "0xED0E60", VA = "0x180ED2460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long RHJFPNZPGVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xE26CF0", Offset = "0xE256F0", VA = "0x180E26CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x940E5F0", Offset = "0x940CFF0", VA = "0x18940E5F0")]
		public QIBMHMHCRIU(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class OHCNZHBPPQU
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> NYDNTMGLGJV;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class WVCOGWMZMPX
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class TQHDKICUXUA : IEnumerable<FDPQDCZIFNA>, IEnumerable, IEnumerator<FDPQDCZIFNA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private FDPQDCZIFNA AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData EFNPDMQNTZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData UVSIJMCTNKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams HEIWCCWJBQF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams PADEVGDNFTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int OTWUEUFXKSW;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private FDPQDCZIFNA ABHSMOYZDSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x104AC00", Offset = "0x1049600", VA = "0x18104AC00")]
			[DebuggerHidden]
			public TQHDKICUXUA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x99097F0", Offset = "0x99081F0", VA = "0x1899097F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9909900", Offset = "0x9908300", VA = "0x189909900", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9909690", Offset = "0x9908090", VA = "0x189909690", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FDPQDCZIFNA> OBLEPTSJTMG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9909690", Offset = "0x9908090", VA = "0x189909690", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x990DB00", Offset = "0x990C500", VA = "0x18990DB00")]
		public static SpawnableTemplateData UFIEVNGDWWO([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x990DC80", Offset = "0x990C680", VA = "0x18990DC80")]
		public static SpawnableTemplateData UFIEVNGDWWO([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x990D040", Offset = "0x990BA40", VA = "0x18990D040")]
		private static HashSet<Id128<HNRIOQRDTCX>> NTZYZJOWLEA(IReadOnlyList<FDPQDCZIFNA> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x990D3E0", Offset = "0x990BDE0", VA = "0x18990D3E0")]
		private static void QJDWAQLHZDP(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x990B100", Offset = "0x9909B00", VA = "0x18990B100")]
		public static Result<ZZJIDZYREMB, TryCloneTemplateError> GUNWUEEVDNG(SpawnableTemplateData a, SpawnTemplateParams b, ZZJIDZYREMB? srcRemapper, bool c)
		{
			return default(Result<ZZJIDZYREMB, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x990AF80", Offset = "0x9909980", VA = "0x18990AF80")]
		[IteratorStateMachine(typeof(TQHDKICUXUA))]
		private static IEnumerable<FDPQDCZIFNA> CVVJRSJMZIV(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x990B090", Offset = "0x9909A90", VA = "0x18990B090")]
		private static void FJSJAYFXVNM(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x990C9B0", Offset = "0x990B3B0", VA = "0x18990C9B0")]
		private static bool LOLDRFHXBLP(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x990E2C0", Offset = "0x990CCC0", VA = "0x18990E2C0")]
		private static Dictionary<Guid, MERFDKTLKAK> ZCHGEFUCYFX(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x990DA70", Offset = "0x990C470", VA = "0x18990DA70")]
		private static void SZIZAWJVDHN(bool a, FDPQDCZIFNA b, ZZJIDZYREMB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x990C720", Offset = "0x990B120", VA = "0x18990C720")]
		private static void JBSWTGZEDVJ(FDPQDCZIFNA a, Guid b, SpawnTransformData? c, Dictionary<Guid, MERFDKTLKAK> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x990DE10", Offset = "0x990C810", VA = "0x18990DE10")]
		private static void VJVYHNLJEKC(IEnumerable<FDPQDCZIFNA> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public UESRNTRQLCK circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public DIGNRBRHMPT roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public QMJDOPILLMD circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<MHARATWVONH> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public RIIXPDQVYHB globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<FDPQDCZIFNA> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public WQCTSYRQZAZ photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Matrix4x4 AKLQENCIAHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9908F80", Offset = "0x9907980", VA = "0x189908F80")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS GFNMYWMTDVB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9909400", Offset = "0x9907E00", VA = "0x189909400")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16E9780", Offset = "0x16E8180", VA = "0x1816E9780")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9909440", Offset = "0x9907E40", VA = "0x189909440")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9909080", Offset = "0x9907A80", VA = "0x189909080")]
		public static SpawnTransformData LBYJJASWXJH(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9909510", Offset = "0x9907F10", VA = "0x189909510")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9909530", Offset = "0x9907F30", VA = "0x189909530")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9909300", Offset = "0x9907D00", VA = "0x189909300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9908D70", Offset = "0x9907770", VA = "0x189908D70")]
		public SpawnTransformData DESLEKBJOGR(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9909390", Offset = "0x9907D90", VA = "0x189909390")]
		public static SpawnTransformData WDYHYUJSZCX(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9908CE0", Offset = "0x99076E0", VA = "0x189908CE0")]
		public readonly CircuitsRigidTransform CGRZOTYPNFV()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private readonly LLLHSATKLGS _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x19B2B90", Offset = "0x19B1590", VA = "0x1819B2B90")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, LLLHSATKLGS innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9909B60", Offset = "0x9908560", VA = "0x189909B60")]
		public JIGWDPLYNFJ QLIJHQWUZXG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9909940", Offset = "0x9908340", VA = "0x189909940")]
		public static Result<ZZJIDZYREMB, TryCloneTemplateError> New(KYDFNMOZMCS<None> innerError)
		{
			return default(Result<ZZJIDZYREMB, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9909AB0", Offset = "0x99084B0", VA = "0x189909AB0")]
		public static Result<ZZJIDZYREMB, TryCloneTemplateError> New(JIGWDPLYNFJ innerError)
		{
			return default(Result<ZZJIDZYREMB, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99099F0", Offset = "0x99083F0", VA = "0x1899099F0")]
		public static Result<ZZJIDZYREMB, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<ZZJIDZYREMB, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DDZEBPHWLLI : IDisposable, TABQIUCZZYP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> NXKYIIPAFRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float MPLGYKXTYQB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags ADXQLHXVAYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD07B10", VA = "0x180D09110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD18F30", Offset = "0xD17930", VA = "0x180D18F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LVXSMDPFUNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x98FE880", Offset = "0x98FD280", VA = "0x1898FE880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GCFYFDZKBHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x98FE070", Offset = "0x98FCA70", VA = "0x1898FE070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> MTWDOSBUXTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD11E10", Offset = "0xD10810", VA = "0x180D11E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int OHJVCOEKWPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9900550", Offset = "0x98FEF50", VA = "0x189900550", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KATYVKGKNDA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x98FDF30", Offset = "0x98FC930", VA = "0x1898FDF30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9900770", Offset = "0x98FF170", VA = "0x189900770")]
		public DDZEBPHWLLI(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x98FE920", Offset = "0x98FD320", VA = "0x1898FE920", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x98FEE70", Offset = "0x98FD870", VA = "0x1898FEE70")]
		public Vector3 IXSIYMSJCMD(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9900590", Offset = "0x98FEF90", VA = "0x189900590", Slot = "6")]
		public Quaternion YPCCYIQUZXC(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x98FEC80", Offset = "0x98FD680", VA = "0x1898FEC80", Slot = "5")]
		public Vector3 GOSSPWOFFWJ(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9900390", Offset = "0x98FED90", VA = "0x189900390", Slot = "7")]
		public float QFTPXSNDQJC(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x98FFAB0", Offset = "0x98FE4B0", VA = "0x1898FFAB0")]
		public void NOTETZZATMS(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x98FF340", Offset = "0x98FDD40", VA = "0x1898FF340")]
		private bool MAKPQQQXNEG(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99003F0", Offset = "0x98FEDF0", VA = "0x1899003F0")]
		public void UBKWYUSAMSC(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x98FE890", Offset = "0x98FD290", VA = "0x1898FE890")]
		public void DKDUTJVSSSJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x98FED20", Offset = "0x98FD720", VA = "0x1898FED20")]
		public void IJCWYUFRTHC(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x98FE980", Offset = "0x98FD380", VA = "0x1898FE980")]
		public void FCGHBXMRWQQ(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x98FEB30", Offset = "0x98FD530", VA = "0x1898FEB30")]
		public void FJDXESAVDZQ(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x98FDDD0", Offset = "0x98FC7D0", VA = "0x1898FDDD0")]
		public void BIEQAVKPLNH(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x98FE080", Offset = "0x98FCA80", VA = "0x1898FE080")]
		public static Quaternion CLYNYKYCHYD(Quaternion a, int b, float c, TABQIUCZZYP d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x98FF3A0", Offset = "0x98FDDA0", VA = "0x1898FF3A0")]
		public Bounds MQMIIRVRYUN(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x98FFA50", Offset = "0x98FE450", VA = "0x1898FFA50", Slot = "10")]
		public virtual void MYSNEZOFDDB(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x99006C0", Offset = "0x98FF0C0", VA = "0x1899006C0")]
		public NativeList<CurvePointData> ZLZOFSFMFRP(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x98FD9D0", Offset = "0x98FC3D0", VA = "0x1898FD9D0")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x98FD910", Offset = "0x98FC310", VA = "0x1898FD910")]
		public Quaternion PODAEHFDQSK(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x98FD480", Offset = "0x98FBE80", VA = "0x1898FD480")]
		public CurvePoint HINWBMTEXHU(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x98FD770", Offset = "0x98FC170", VA = "0x1898FD770")]
		public HNJSMWUDRMB IKOCOWODPCI(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class LGJYZQRQXCX : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9901F80", Offset = "0x9900980", VA = "0x189901F80", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9901720", Offset = "0x9900120", VA = "0x189901720")]
		private void EVMEWDRMPQC(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x99016C0", Offset = "0x99000C0", VA = "0x1899016C0")]
		private void EVMEWDRMPQC(Dictionary<Guid, Guid> a, CBWSBYYJVNX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9901D00", Offset = "0x9900700", VA = "0x189901D00")]
		private void EVMEWDRMPQC(Dictionary<Guid, Guid> a, ICDIQLYXHJE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public LGJYZQRQXCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class ZSYKJWXGCOG : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x990E9C0", Offset = "0x990D3C0", VA = "0x18990E9C0", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public ZSYKJWXGCOG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class YFONTTYZWYD : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x990E6B0", Offset = "0x990D0B0", VA = "0x18990E6B0", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public YFONTTYZWYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class BHXKUMQLCUD : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x98FCF80", Offset = "0x98FB980", VA = "0x1898FCF80", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public BHXKUMQLCUD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class QAVNUIPHEIF : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x99082A0", Offset = "0x9906CA0", VA = "0x1899082A0", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public QAVNUIPHEIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class IZOSXLMFMNQ : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9900B30", Offset = "0x98FF530", VA = "0x189900B30", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public IZOSXLMFMNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class FNVBPGOUQQC : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x99009A0", Offset = "0x98FF3A0", VA = "0x1899009A0", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public FNVBPGOUQQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class ANFHJCJWPYJ : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x98FCE90", Offset = "0x98FB890", VA = "0x1898FCE90", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public ANFHJCJWPYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class NKCTQPZPIOD : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9903110", Offset = "0x9901B10", VA = "0x189903110", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public NKCTQPZPIOD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class DXODJFXNSLJ : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x99007F0", Offset = "0x98FF1F0", VA = "0x1899007F0", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public DXODJFXNSLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class WVCXTLYCUSZ : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x990E5B0", Offset = "0x990CFB0", VA = "0x18990E5B0", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public WVCXTLYCUSZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class LEMSIFDVIUY : ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly JHSNGUFCOAS DHWYBMYSAMD;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x99015A0", Offset = "0x98FFFA0", VA = "0x1899015A0", Slot = "4")]
		public void SYPLTZOJYAB(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public LEMSIFDVIUY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public WQCTSYRQZAZ photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface ZAFHKGEPKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SYPLTZOJYAB(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class MZMAEBYXUOR
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly ZAFHKGEPKAQ[] AGGTERRZKCP;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x99023F0", Offset = "0x9900DF0", VA = "0x1899023F0")]
		public static void WXGYIZVJVBQ(FDPQDCZIFNA a, ZZJIDZYREMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9902670", Offset = "0x9901070", VA = "0x189902670")]
		public static void XZECVKHAXVS(FDPQDCZIFNA? data, ZZJIDZYREMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9902900", Offset = "0x9901300", VA = "0x189902900")]
		public static void YXRLDWFZYOS(FDPQDCZIFNA? data, ZZJIDZYREMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9902000", Offset = "0x9900A00", VA = "0x189902000")]
		public static void CJUKGNXWHFT(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public FDPQDCZIFNA viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x99035A0", Offset = "0x9901FA0", VA = "0x1899035A0")]
		public Guid WEZOMIVWLLN(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface WQCTSYRQZAZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> TQCQKQJZHOM;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> JXZYIKBCDAC;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> ODKHUZHGXMM;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker YOLSRFPVZVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> JZHARAWBPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> HUWOAZORYSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> QYNHUOTXJXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> UKOYEIMHNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> KLKWVWWDMSK;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> QDMISCFUWNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> YLUMISAWAAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCD0", Offset = "0xD0B6D0", VA = "0x180D0CCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> ZLOVRHXCZDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> UUNBRDZNRAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9904800", Offset = "0x9903200", VA = "0x189904800")]
		public static void NHLZOLCAPVI(SpawnableTemplateData a, DAKRNVFKEOK b, ZZJIDZYREMB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9904230", Offset = "0x9902C30", VA = "0x189904230")]
		public static PersistedRoomDataReferences JDXNHQALGVI(PersistedRoomData a, DAKRNVFKEOK? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9904430", Offset = "0x9902E30", VA = "0x189904430")]
		public static PersistedRoomDataReferences LECVRAVVREZ(SpawnableTemplateData a, DAKRNVFKEOK? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x99044B0", Offset = "0x9902EB0", VA = "0x1899044B0")]
		public static PersistedRoomDataReferences LOPWPPMHGRL(UXWZRHWNBAR a, FHBZFHNEJOP b, DAKRNVFKEOK? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9907A40", Offset = "0x9906440", VA = "0x189907A40")]
		public static PersistedRoomDataReferences UZLBMDLIJFM(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9908140", Offset = "0x9906B40", VA = "0x189908140")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9907F70", Offset = "0x9906970", VA = "0x189907F70")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9907420", Offset = "0x9905E20", VA = "0x189907420")]
		private void SXCHVPGTVVZ(PersistedRoomData a, DAKRNVFKEOK? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9906150", Offset = "0x9904B50", VA = "0x189906150")]
		private void SXCHVPGTVVZ(SpawnableTemplateData a, DAKRNVFKEOK? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9903850", Offset = "0x9902250", VA = "0x189903850")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9906A40", Offset = "0x9905440", VA = "0x189906A40")]
		private void SXCHVPGTVVZ(UXWZRHWNBAR? a, DAKRNVFKEOK? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x99063E0", Offset = "0x9904DE0", VA = "0x1899063E0")]
		private void SXCHVPGTVVZ(FHBZFHNEJOP? a, DAKRNVFKEOK? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9906860", Offset = "0x9905260", VA = "0x189906860")]
		private void SXCHVPGTVVZ(YAEAJYCCXGL? a, DAKRNVFKEOK? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9904030", Offset = "0x9902A30", VA = "0x189904030")]
		private static bool IGWNFMDQMZO(YAEAJYCCXGL a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9903DF0", Offset = "0x99027F0", VA = "0x189903DF0")]
		private static bool FZQFEXXHZFC(YAEAJYCCXGL a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9905850", Offset = "0x9904250", VA = "0x189905850")]
		private static void NHLZOLCAPVI(FHBZFHNEJOP? root, DAKRNVFKEOK a, ZZJIDZYREMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9904570", Offset = "0x9902F70", VA = "0x189904570")]
		private static void NHLZOLCAPVI(YAEAJYCCXGL? customProperties, DAKRNVFKEOK a, ZZJIDZYREMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9905D60", Offset = "0x9904760", VA = "0x189905D60")]
		private static void NHLZOLCAPVI(UXWZRHWNBAR? root, DAKRNVFKEOK a, ZZJIDZYREMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9905200", Offset = "0x9903C00", VA = "0x189905200")]
		private static void NHLZOLCAPVI(CircuitsV2.Protobuf.CircuitNodeData? node, DAKRNVFKEOK a, ZZJIDZYREMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x99076C0", Offset = "0x99060C0", VA = "0x1899076C0")]
		private void SXCHVPGTVVZ(CircuitsV2.Protobuf.CircuitNodeData? a, DAKRNVFKEOK? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9903640", Offset = "0x9902040", VA = "0x189903640")]
		private void EKKBNNIDNBJ(Guid? a, DAKRNVFKEOK? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9906460", Offset = "0x9904E60", VA = "0x189906460")]
		private void SXCHVPGTVVZ(FDPQDCZIFNA? a, DAKRNVFKEOK? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9905920", Offset = "0x9904320", VA = "0x189905920")]
		private static void NHLZOLCAPVI(FDPQDCZIFNA? viewData, DAKRNVFKEOK a, ZZJIDZYREMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x99060E0", Offset = "0x9904AE0", VA = "0x1899060E0")]
		private void NKCPCCBDLQW(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9904310", Offset = "0x9902D10", VA = "0x189904310")]
		private void JNGVPZIGSDE(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x99043E0", Offset = "0x9902DE0", VA = "0x1899043E0")]
		private void JNGVPZIGSDE(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x99042B0", Offset = "0x9902CB0", VA = "0x1899042B0")]
		private void JNGVPZIGSDE(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class CDDAHPPYVFL : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> RQWTEPKHNMS;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x98FD260", Offset = "0x98FBC60", VA = "0x1898FD260", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x98FD320", Offset = "0x98FBD20", VA = "0x1898FD320", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x98FD3D0", Offset = "0x98FBDD0", VA = "0x1898FD3D0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x98FD180", Offset = "0x98FBB80", VA = "0x1898FD180", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
			public CDDAHPPYVFL(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x98FD0E0", Offset = "0x98FBAE0", VA = "0x1898FD0E0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x98FD130", Offset = "0x98FBB30", VA = "0x1898FD130", Slot = "9")]
			public void Reset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			[CompilerGenerated]
			private sealed class KNOWBZIIFVN : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int KPYKIUTJAWU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry AGGTFEUSTML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts AFKVCRAYCVS;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry IBWBKURBRZN
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xDA3550", Offset = "0xDA1F50", VA = "0x180DA3550", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object KXFWSOWDLDQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x9901510", Offset = "0x98FFF10", VA = "0x189901510", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
				[DebuggerHidden]
				public KNOWBZIIFVN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
				[DebuggerHidden]
				private void EAMCGMHRBWN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x9901410", Offset = "0x98FFE10", VA = "0x189901410", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x9901560", Offset = "0x98FFF60", VA = "0x189901560", Slot = "8")]
				[DebuggerHidden]
				private void VVBIBJOVTIU()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private ICollection XNIZCXTAIDV
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x99086F0", Offset = "0x99070F0", VA = "0x1899086F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x99089A0", Offset = "0x99073A0", VA = "0x1899089A0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x9908A80", Offset = "0x9907480", VA = "0x189908A80", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool AXOIPYJQWVA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x9908B10", Offset = "0x9907510", VA = "0x189908B10", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool MXSXMUXLPEB
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x99086A0", Offset = "0x99070A0", VA = "0x1899086A0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection FQBPORZWJOR
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x9908AC0", Offset = "0x99074C0", VA = "0x189908AC0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int CVHLTDRDEBQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x9908830", Offset = "0x9907230", VA = "0x189908830", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool KLTQFTJCNBD
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x99084C0", Offset = "0x9906EC0", VA = "0x1899084C0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object YSEXEHTWYBK
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x9908510", Offset = "0x9906F10", VA = "0x189908510", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1104FC0", Offset = "0x11039C0", VA = "0x181104FC0")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x99087C0", Offset = "0x99071C0", VA = "0x1899087C0")]
			[IteratorStateMachine(typeof(KNOWBZIIFVN))]
			private IEnumerator<DictionaryEntry> GUFLZURVKQK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9908560", Offset = "0x9906F60", VA = "0x189908560", Slot = "19")]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9908880", Offset = "0x9907280", VA = "0x189908880", Slot = "13")]
			private IDictionaryEnumerator KMOCNTZGIJV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9908950", Offset = "0x9907350", VA = "0x189908950", Slot = "9")]
			private void QBSBIEYFVOW(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x9908B60", Offset = "0x9907560", VA = "0x189908B60", Slot = "10")]
			private void YCSQPHXWZOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9908600", Offset = "0x9907000", VA = "0x189908600", Slot = "8")]
			private bool DNCNGJYKFOC(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9908770", Offset = "0x9907170", VA = "0x189908770", Slot = "14")]
			private void GNMSGNTGPET(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x9908650", Offset = "0x9907050", VA = "0x189908650", Slot = "15")]
			private void DQTWYIAJUTJ(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class ZLIYNHLQTGR : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int KPYKIUTJAWU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry AGGTFEUSTML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention AFKVCRAYCVS;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry IBWBKURBRZN
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xDA3550", Offset = "0xDA1F50", VA = "0x180DA3550", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object KXFWSOWDLDQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x990E930", Offset = "0x990D330", VA = "0x18990E930", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
				[DebuggerHidden]
				public ZLIYNHLQTGR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
				[DebuggerHidden]
				private void EAMCGMHRBWN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x990E810", Offset = "0x990D210", VA = "0x18990E810", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x990E980", Offset = "0x990D380", VA = "0x18990E980", Slot = "8")]
				[DebuggerHidden]
				private void VVBIBJOVTIU()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ICollection XNIZCXTAIDV
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x9900E90", Offset = "0x98FF890", VA = "0x189900E90", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x9901100", Offset = "0x98FFB00", VA = "0x189901100", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x9901210", Offset = "0x98FFC10", VA = "0x189901210", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool AXOIPYJQWVA
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x99012A0", Offset = "0x98FFCA0", VA = "0x1899012A0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool MXSXMUXLPEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x9900E40", Offset = "0x98FF840", VA = "0x189900E40", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection FQBPORZWJOR
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x9901250", Offset = "0x98FFC50", VA = "0x189901250", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int CVHLTDRDEBQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x9900F90", Offset = "0x98FF990", VA = "0x189900F90", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool KLTQFTJCNBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x9900C70", Offset = "0x98FF670", VA = "0x189900C70", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object YSEXEHTWYBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x9900CC0", Offset = "0x98FF6C0", VA = "0x189900CC0", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B84290", Offset = "0x2B82C90", VA = "0x182B84290")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9900F30", Offset = "0x98FF930", VA = "0x189900F30")]
			[IteratorStateMachine(typeof(ZLIYNHLQTGR))]
			private IEnumerator<DictionaryEntry> GUFLZURVKQK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9900D10", Offset = "0x98FF710", VA = "0x189900D10", Slot = "19")]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9900FE0", Offset = "0x98FF9E0", VA = "0x189900FE0", Slot = "13")]
			private IDictionaryEnumerator KMOCNTZGIJV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x99010B0", Offset = "0x98FFAB0", VA = "0x1899010B0", Slot = "9")]
			private void QBSBIEYFVOW(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x99012F0", Offset = "0x98FFCF0", VA = "0x1899012F0", Slot = "10")]
			private void YCSQPHXWZOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9900DA0", Offset = "0x98FF7A0", VA = "0x189900DA0", Slot = "8")]
			private bool DNCNGJYKFOC(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9900EE0", Offset = "0x98FF8E0", VA = "0x189900EE0", Slot = "14")]
			private void GNMSGNTGPET(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9900DF0", Offset = "0x98FF7F0", VA = "0x189900DF0", Slot = "15")]
			private void DQTWYIAJUTJ(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1104FC0", Offset = "0x11039C0", VA = "0x181104FC0")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x990A570", Offset = "0x9908F70", VA = "0x18990A570")]
		public static UgcRoomSaveStatsDetailed JDXNHQALGVI(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9909DC0", Offset = "0x99087C0", VA = "0x189909DC0")]
		[CompilerGenerated]
		internal static int CMZCFWFIZEE([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9909EE0", Offset = "0x99088E0", VA = "0x189909EE0")]
		[CompilerGenerated]
		internal static void IZTLHORPIXK(int a, [In] UXWZRHWNBAR graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		ParticleVfx,
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		ConsumableItem
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class DAKRNVFKEOK
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid CNMAWWVMMDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> YLUMISAWAAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind DPDMCSHWOIO;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x990AF20", Offset = "0x9909920", VA = "0x18990AF20")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly ZZJIDZYREMB TTZEVUGMCSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> IUKKVPVQKBD;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public ZZJIDZYREMB QAXIFJOZSFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x98FDA50", Offset = "0x98FC450", VA = "0x1898FDA50")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x98FDC50", Offset = "0x98FC650", VA = "0x1898FDC50")]
		public bool XYRUBONMFBR(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x98FDD40", Offset = "0x98FC740", VA = "0x1898FDD40")]
		public DAKRNVFKEOK()
		{
		}
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
