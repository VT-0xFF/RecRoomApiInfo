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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82AFD90", Offset = "0x82AE790", VA = "0x1882AFD90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MWUWWOABIQM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> AFKEXLXWHMG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> UIYIMXGXLWM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> PCMWXCKSBHS;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> NAPKPKMDJQB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string VKZRCVCLZFN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string VMRCDXDEULA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string FREPVTTBFJB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82AC730", Offset = "0x82AB130", VA = "0x1882AC730")]
	public static bool KZBRFMBJOJU(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82AC020", Offset = "0x82AAA20", VA = "0x1882AC020")]
	public static bool AHTIFOCENZE(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82AC0B0", Offset = "0x82AAAB0", VA = "0x1882AC0B0")]
	public static string EBDCGXQMZLH(Guid a)
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
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	AVATAR_ITEM_DISPLAY,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	ELEMENT_SNAP_POINT,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LAUNDRY_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_HAMMER,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PAINTBALLSPRAYCAN,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_DISCOVERY_POPUPSHOP,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_ROOM_BOOST_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WEARABLE_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
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
		[Cpp2IlInjected.Address(RVA = "0x82ABF60", Offset = "0x82AA960", VA = "0x1882ABF60", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class UBXFRDZWIXH
	{
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static readonly Guid OZLDSSZBMYK;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid TIQXRWFNKRF;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid UTQOTJYIBFY;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid FXPGCJEMJWM;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid EOWLNSFVNLW;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid UQFRQORCMML;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid VMKDFQHOBUH;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid HEQTRFGVYIU;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid DUCKZKPLUCZ;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid RPUTBGKFERZ;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid ZQXODKIOWZN;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid BRSWJJRFACU;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid CBFPKOBDDCL;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid GOZKBAPKIEI;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid ILMMCGAETNN;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid SHZWTRFAFEY;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid NOWMENKLIGN;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid ZKHMXBZIFRL;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid QJTWRYBBXIQ;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid WPYFLXZJANL;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid PWXMYSNQHPD;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid PEPJHODELWK;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid UWSYGUPJVOW;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid GLOIUIIGHMI;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid HZVTTCEZIDA;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid LRDGCHLJWJO;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid DVZUBRXTBNE;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid WUTYFOWWIZN;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid LAJJNCIJCDE;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid OYBJZNLGPKX;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid YMVDLIAQFEH;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid LTPQXKSRVIY;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid IWJCWANZXQS;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid VKOHTUOVHEH;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid HVATULCNKVA;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid WMFZYZXHLRD;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid GMWXHPEUNVN;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid OKIDLTOFPOH;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid JRPPZWSMSWF;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid VTFWXNVBLPN;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid ZTFNQVWBOPT;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid ZXTHQMLJFGL;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid IGGMQXPIGZV;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid QSPCOJJZFRX;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid YBXKNGUHSUA;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid WANJUDTOCZL;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid GSHBIYUWFJE;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid TMPUBMALIHA;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid KWSJAJTVWAK;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid ULPWFONCPTL;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid FQMWJEOQXQY;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid CZKCPUNEFLP;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid CZNMNXVLKSP;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid QMCSZCWKGGU;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid OJONBUHZRAA;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid CWWEYSPTZJS;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid VVLXDLASXAN;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid IWWJMDHTQJD;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid EWERHGWYLFI;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid DCCQLKUTNCQ;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid LFDNCSTQPLT;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid LQUXJNKKETS;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid GRHGXEARVWH;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid VCUWTADKGSL;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid SXGQXKABXGQ;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid PDNXWACNTZF;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid NLAJIGNLDOL;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid KHQGXXHUXEA;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid TZPMUIGUORC;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid LRLATILLABB;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid MYXUIXBBLSW;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid KXEZHGOCZAB;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid TGTGKGKSOLS;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid QHMOVLFXTCP;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid XBCJQHFODPP;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid XVMQGXRXHAQ;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid TQQHRRWVIBE;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid QDPEGXXOKFY;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid YVLEIWKJBII;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid ELXGAFRCBRK;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid KQQMUCQYYLT;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid WDJDSBUBVAQ;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid AWGDONHIWNX;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid ERIQQYIKOFC;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid BIVIMMZIAPT;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid LVBILEFLJHF;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid EEPLUVLPIUV;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid TMRFNIXECJM;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid LRTPEUTLKKH;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid YLKUDUJKDDH;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid KCUQXKZJJPS;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid NFFAOYEZHOY;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid AYUMCKNRVFJ;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid QTGFHMVMDBX;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid GRVIIUYTXZF;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid YQQNRYNFUIT;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid DDZZISSKZCT;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid XQRSCWOZPEG;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid IEIMJTKESUN;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid DVUSTUTNXOV;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid PDYPUPQFWQG;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid TJUDWUTXJIB;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid LDHBBGBPNZO;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid WZHQCECKRDT;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid LDROVTPKGWG;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid KBIFJOEARLZ;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid FYUDHANDTDN;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid RYYOQVLZNWY;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid JLTXHEFXLUX;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid PULNBFECLZG;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid JMELBRTSERP;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid ZGQKFPRQJVE;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid JOFCAHKRVBB;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid ZCDSNYXLRWA;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid NDFVMTIPTLY;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid WXLPHNOQJNR;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid OJJNYSSWNTF;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid BVTDCTQLMGW;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid UNEYYLPQRCV;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid OPEPSVMBQJH;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid XIYEAVXIWRI;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid XFDGBPWMIBP;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid LVUENVALREF;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid JROWVSQZJOP;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid LYTVOYQCWUX;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid SYRFZLQQUET;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid FRJWHTESQRF;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid HHIPFTTAUWP;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid XPRKNFGZMCY;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid RVVSTBWXFFV;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid WLNRIOMLMEP;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid LCCUDLQNTOP;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid CZKQXMFOYGC;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid EKPONHJQRJP;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid RQXVPZJEEQK;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid PETVBBVTYHG;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid TAPOIXVDXPB;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid HZAXYPNVXOR;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid VVVWKCRLEIC;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid YLDFMJGDEHS;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid MIIZEDRIZCZ;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid UIQIOEJBJGD;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid MVNSZQPEXXA;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid MMPRJKFGVUM;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid ADQDCKULDJG;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid BQOYATECNVE;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid UFEDYJOEFQD;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid PANQTRSRKET;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid PASXQYMOTQC;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid PAYEOFGMDBL;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid PBDLLMAJMMU;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid PBISISUGVYD;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid PBNZFZOEFJM;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid PBTGDGIBOUV;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid UATWQQTJIWV;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid PHAZRYRMUCB;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid SIOVLFVQMTS;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid EQXWAETPKUU;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid WHXXZXOZCYP;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid MDMIVLYVZNI;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid UXLADZBHYUA;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid ZAHDHUZDYYI;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid QJUZUVXRMGL;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid BLVURQXELUR;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid SAMRBQTYUOC;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid ILCZRZMKYJP;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid ERPYKJJQLEM;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid IZHZICAOKIU;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid SGMMYPTXYCN;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid HWJXBMOFYYE;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid IZXTZWIGMQV;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid IZSNCPOJDFM;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid IYSEQHSWIAT;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid IQCTPLTJHKO;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid HHYBQUHKMGL;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid QHKNNJGAYGS;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid IPXMSEZLXZF;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid VSHPRZEDZGY;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid BTOMTHETGDL;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid VIQTJSTYPOZ;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid BVOXFDKCMRC;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid IDPIQTGVAOG;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid RHMCTMDUYLW;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid UHJAHVAYCLM;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid NQMNIFNLFIQ;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid JJJKJMLEHOP;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid ZFIUBOEHJIK;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid KSHQGMUYFCB;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid PUXTIBPGLSZ;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid XJQJLNFVWSR;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid YBRVWUNVTON;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid JHAMFHFIOYM;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid RJEHPWSEDVW;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid RHBDSDUDIWT;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid FCVSGHGWETZ;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid PHKEGDRHXVQ;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid EZWSHLAOCQJ;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid JXIVEDAKPMN;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid JSASRBGRFWE;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid KJVYQOODCUF;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid YVMYUFTPAFU;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid HCQFUSIHAYY;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid FNIXYWHMAUF;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid SJMVWQTAYRA;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid DZGEONDNTGJ;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid YUZQKHOQPRP;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid DMYAOOXPWQH;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid FQJUGATAQLI;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid BRZNSMABGUR;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid FYXXATAWHCV;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid DEUIFUSXDJI;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid YTBWJLYNWZU;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid HXWXYIZZLYV;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid WMKAJNEOOOI;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid DJOIDVCFHVD;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid IXXQZUSXBHU;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid NHQYPBUIGRC;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid CLMVPFWPTDY;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid TEXGHSVKVUI;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid LGRIBMSSUFT;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid WDGCYBUXMRV;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid NVNURXNVRUQ;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid MNVCZZZKCEX;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid EYJSRQBTWJO;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid GHVAVTWOSCO;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid UXVEPFHNQKU;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid FIRFJSGYUDJ;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid FIBGFQSXMEX;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid OEQHOMRAUAS;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid XCWOHUZARZB;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid RUKHMSUJLPM;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid PZJGGRFMCTX;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid EKAMQBMZRSD;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid IESBVPMEWNP;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid HZBMVQUMLRN;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid HFXTVCPWFDJ;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid GKSJJZWBVKL;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid LPGGIESOJTY;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid NOVTWKIGGMT;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid CMDCGDIATZV;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid YTMTZOOBVSU;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid DYVKLZEGSUJ;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid QAMFCCOSQMQ;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid OSDDVAYANJK;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid UQZQRYMZZXS;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid SXUEIZDWLPN;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid MEOUZALINBC;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid IXUMYFOMQBL;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid XLJOAGGHPFD;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid KRWDOKGPHCK;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid VTZQJRGDFBZ;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid CPFGBBKSMSB;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid GTQAISQGDNZ;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid OGESOJIXVJZ;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid NVZEHLXYJKZ;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid RVKPACNVEBX;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid PGDGYNGFKZA;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid DYKQHSPUQTU;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid RTABKIHMTHZ;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid PJHVCMTHXPI;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid RRFQURFGIBL;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid ZTKNZBIUWIP;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid LUHEBQBCAZS;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid UTYXMNTTDJP;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid BTWNPFYCRMR;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid ZCABMDYIGUB;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid LXQNLCLOABX;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid PUBJQDPLRLR;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid BXKWMCVVGNJ;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid LELEKOGXRJL;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid CXLTWFTKGFW;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid YSBISABOXZQ;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid FPSFTHIDEJP;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid VWJKRIVEXKW;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid EZBURXOZIGT;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid BWBISRHGBTL;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid COGIJIRLAEW;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid UDYGJKFRNEZ;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid GFIKSAIIQED;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid EPRVRXATJZZ;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid HDZGCZFJBZU;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid MSQNBGTMAOU;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid SMJNZRGZWTE;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid WOCEFYLFWQH;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid IRPKRJPQORF;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid OQCFMZINGHL;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid KODLDAIFRQT;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid UUWDHPRFKAU;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid MPPTXCLBUTO;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid BQOWGNYAIRK;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid OGDSLXELXUJ;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid SADKYTXDBXX;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid AKJKBERYFYG;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid ZPVLVTFTFXG;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid JYISEZEPKWP;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid OFMIZOXCQCL;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid JBOAPZVEDVI;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid TSTMCLOQRTV;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid EMBMZWRVOIO;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid NHRWMVYOSQH;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid QXCMZFOSUMN;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid FTUHEXSSGJF;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid ZLOBXIGAFJQ;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid UKRUMRGUJLM;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid SMRFFIUFVSY;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid RPFZZQRZUSB;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid WIBJLUHZWSI;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid QKHVYPDQCAQ;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid QHGZSCZMIKA;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid PGIPRLIQXWY;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid WYAHVUMGCXZ;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid FKDHXLEEPUX;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid YEOQWODHYPB;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid PQFMXXSMMOT;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid DICEEEBHSQB;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid AGVBQJIEPAX;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid TMRMESPTCFO;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid ERCQYWGMNYI;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid ERXTTSKJUGR;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid FVUQKVKRZMG;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid MCOSVMVAXSW;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid LUCKUTLBUGS;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid BDFBLKZEFSV;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid MJYCBMFMRIN;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid HGGCSJKPTLS;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid UVTSJWNOGCC;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid ITDPQWXACSE;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid TYHWKUSRPQG;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid TKEXWYPWCNP;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid UKSGBTFGOSD;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid GNNTUHXCANI;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid BJQKXNIIEGW;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid PJNOQPJNPBO;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid YKLTKCJMXHA;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid CZSXKZWUGGL;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid VOIHWWLOPZV;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid WIDQBNJTZXJ;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid RYVMFGCRUZA;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid HBMYEQHGIRC;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid OETJSLSZBSF;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid EQEAOJBFJGV;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid TZYNUONXKFM;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid DDJSUMHDVEG;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid QQRFXYWMAML;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid CDVIKKHWZRC;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid NUVRXHTMXME;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid SXSACBOCDXZ;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid KDHYOLRJFFW;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid WIUWNFMCGIS;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid ZJLWLGKBMEN;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid NNCXRVDOTSE;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid FBYFAJNEVWD;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid QSBADZYJQFY;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid DICDXPXCZIK;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid EMFMQFZZUNK;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid VYUWXEVADMO;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid BIMSZDZMUZZ;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid YORXNYXYSXF;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid VQFQBABPIOE;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid UFFYLFYFTXR;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid DAXPDJMKKEF;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid WYPUTTLBELP;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid QZJQNWJDCBU;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid HIHUKMAFNUJ;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid VXPRDGEEIHE;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid EOIXJGWVLVB;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid HLXXLSQBNRQ;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid SLGDPYSWECM;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid KFDEQJTWNFP;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid NNYKAPMXYJR;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid ZHVORVCMTWZ;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid SUFXEFNTIOZ;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid EBSRQIRCKGD;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid BJCYKRVPGVS;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid LAVTBPGKJLD;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid FYBQDHZAJHY;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid ZIZNGEVCTUV;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid OTCWFSXWUIK;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid QLCJLZZOPLN;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid HFXEPZAUWMM;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid XONFTUNVBYB;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid PUMYDKPPQBE;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid LALVQEVNSGJ;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid HXAWYRMCBXS;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid AOIEOJGURPY;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid EPSFWPDGJXJ;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid ZSRADFHQHHC;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid WLYZRXGKSVX;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid WPGUXGHVGWK;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid HWZLJKNTLKQ;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid RVHGZDCCKCE;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid POOSKVMPWAC;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid IKEBPRCLAQD;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid CLKXHMZEIWV;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid TMWNNLXUGKI;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid BXCGUDWXNAF;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid TWTTRXCECHS;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid QERUZHDBFLE;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid ZXFLTFGBCBK;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid GEXBLRNAHYC;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid GQOIHEVJPVX;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid GGEFREEGEZE;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid DWVNPOTSCJV;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid DKHEPOLSZLN;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid EENGFMIITNC;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid JCLAEFDXATS;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid PNGUOFEEISR;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid XSSVTJPESLV;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid NWQIWCEMXZR;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid VXLVMJEWLEW;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid IUGDCHVDRWF;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid QXUQOMWINJU;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid DIVKLCEGLDO;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid KSAXSHJMUJX;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid XEXFQJUBTXJ;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid TMOYLIISMHZ;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid DBLWMQTZEZK;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid HTAVLESDCUJ;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid FOMTJCZSRTD;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid KASYZPLCOFV;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid LUIIMKHHCSZ;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid OSKFMWXMJJH;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid EIUYETIKMXY;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid ARBUNMNTHQO;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid CKXDQCUBJTJ;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid UZLMPHLOMNH;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid CLCKNJNYTES;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid CLHRKQHWCQB;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid CLMYHXBTMBK;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid CLSFFDVQVMT;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid CLXMCKPOEYC;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid CMCSZRJLOJL;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid CMHZWYDIXUU;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid CMNGUEXGHGD;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid ZIQHGVOISUJ;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid QCBBPRDZGNJ;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid HFVDPMBEDEO;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid OTZDNSCSZTY;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid BKPVUTOTDRI;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid XREHIIKXOWG;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid XYPDFLNRFZR;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid MYPESCOKZXN;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid PVEPSQQAGMW;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid VZUBENBLIHC;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid DFHGJMQYXCJ;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid WCWUHAOMRUZ;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid MJIEGFEZNHX;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid NLWAUEKQFGC;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid UXJYYYHSZMF;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid CWGGIKTSFOD;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid LFGLRQZEVFQ;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid OENCUKFXECW;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid FTVLEJHMRUQ;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid COHHWJJPFNQ;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid VCVUHAEZMSX;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid ONTJEXMXDCM;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid ONDONDFFAUL;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid VYBNKOIQRRN;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid REVEFRQPYUI;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid KFPASNSFTXN;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid QQJAHSHKQEK;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid ZZFUOFGAOQQ;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid UNQHDOIVMRJ;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid XXPFHHWIWFT;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid RMQCUWMCAOP;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid URNVSHHUXJZ;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid QGXTQHMIQJD;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid VTTTFGZPOAW;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid GCUJCEKPUJZ;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid YNUGQFQCQYR;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid ZMEYKOOGNPI;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid AAQDGCYABXJ;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid GMKUSAJWVSE;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid KZHFLHREVZR;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid MCQNBHFFCPZ;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid PBGOQGGNCNO;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid TBQIJLMPORR;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid FRHVGZGPTEF;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid BLJEMTFDHAJ;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid FKLDJMDMCVD;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid NZWCITCXSNW;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid UIGMJHMUETG;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid ECWSDOWEZJC;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid WTHSDWBVUGY;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid JCSHBYBDTUK;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid HJPGWOZCQSW;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid AHLTGYRKDXZ;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid SZMDCOPMOOE;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid OYJKERQRKPS;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid JGFPOILDTYP;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid ZEQMDJMQRYN;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid TGKAANXQWGK;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid PYPXXDYFJZN;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid ILZGBFYQFOC;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid HMHQQHDVCGW;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid TCKVKTXIPHV;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid HDQXLDNWBWX;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid OVLWGDKOOPD;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid YBGGIGZYWLT;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid GWVTWAPFVTX;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid FIJVEFSOLFU;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid HYCXPRTLEBG;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid JUJZSYCMCMT;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid MKPOPCQQXQM;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid KCJDMTXLSNV;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid KRQKYZKLGTC;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid CAJYZLBPZWV;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid XYQPJFWZJHS;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid ROZNSQLIENZ;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid PLOVLIYKHOC;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid KVTIBEBFPSO;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid MPVTBBNPTJD;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid UCVJFEXZCNB;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid SCGUBEYTVXX;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid DVGHXYOHAAK;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid AUGLWMFSJDD;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid QHDUHVHEPRE;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid UKTEMEDBVKM;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid STXJRATTPSX;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid BVINGZBTWRD;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid BVDGJSHWNFU;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid GDPDGNBSPRO;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid KRXVVGLYZDE;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid AYUBQHFUSLP;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid AIXBCQNRZBD;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid VDZWTMFCKOV;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid OIVNWJLVBSM;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid FOVPLWXHSHJ;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid SGBAJIGDCLO;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid KMAARUUONPP;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid BAKXHIFXQMT;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid JZFLLMFEBFK;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid LJHWPAQZRMB;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid HLYBBEQDBPH;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid YADCSBOWBXH;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid RTNQJFFTAMA;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid EJGFFLRTNVW;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid IPQNCDTNEWV;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid ZMJSEWEOTIN;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid UHUQQRHCMOC;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid ASVMIOETKIA;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid RMZIVECKGJV;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid AVYNYGWOTAF;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid IUIVBIYWSZZ;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid VTRETJDGHSB;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid WFZFYQLFHAP;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid FZEBGEHBCIM;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid VDGPURFWUGA;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid QRILWYDCRNX;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid IACZLVWGGFS;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid FEVPFBGTEJI;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid ZSVURZZHYKN;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid ZSHWJAWSKVG;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid QDXREIAASLR;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid EHXCINNOFSV;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid GFLYLRCNICK;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid WXGJLWASQIE;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid UHFAOXFBNBM;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid XHNRCMQNLIM;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid CVXAZXGJNDW;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid CBOEODMFWKU;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid NBVUEGGGMIR;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid YPBUVXJNXTO;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid WRPCSSOMRAF;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid NNRNASGDLOR;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid HPPPKELLKVJ;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid OFUWRNHJNGT;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid GURGPEGNOQY;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid VZNHPLSQSIF;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid LGVVNKSDTRC;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid IEPNGYJJAOW;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid IEKGJRPLRDN;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid IEEZMKVOHSE;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid MEROENCEASN;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid GMCTENNQDKF;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid GLMYMTFYBCE;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid TEAEQWGTYOG;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid ZUWUPAAHZGM;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid WVPUDDNRMDU;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid PUMGOBCBZHF;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid OXXTMWNWSGG;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid DKTDLXBWYRG;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid OIDDXUSUNHH;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid SVOIVFIYROR;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid PIZFVVKZSOM;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid PKYRNKAHHZY;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid LUFPKJETKUM;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid ETJZPZUAPRE;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid FINOKOMNXLR;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid MOCESXPPKZD;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid HCIQBSIKZOA;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid VQBXFHTOHAG;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid TFOVJIXJKED;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid WOOYQEAITGK;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid IPPMEERLRQS;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid SSTTTILNRJW;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid OESNWTSMJII;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid HWGNXCKDAXF;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid QQXKDFMHYQG;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid ABDQNTRMJZH;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid VXKACLFPLAP;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid UKBQZVYAJTD;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid BJCFFROKDPC;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid QUXCUJZMEXO;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid ODXILSORHDU;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid HYZZUGCDGAM;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid PAAIHFNTDQU;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid CZKIOXQJFAW;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid QBOJRQAMMGG;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid LCSPFYEGZRN;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid GRPJQIRCKSI;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid JWJRLUYRQJG;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid GGOHFIRPKSJ;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid IBWTPEGYVTI;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid MXYEBCDRUMW;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid QLBZITJJMQA;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid PDRJBPOPWKM;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid FEFDNZPIVMC;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid VQXDKEXFIPC;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid SGTRDWOVUQZ;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid OALOIXYYXSI;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid YRTSHURXBSY;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid FRKRUJUNWUI;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid WBMWPHAQCEN;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid VVRRTKXGKEL;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid UDEETEIWQEJ;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid OCCKRTEFTNQ;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid PGFGMQKRROB;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid RQXYKXZFINY;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid SJLELABXEYL;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid LUSNUUYJBUM;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid GGYVPIZEHUE;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid JGENOGCRFEW;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid RYLTBSCMBHR;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid UWYXRWFSFDU;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid GLOCWRGPCVW;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid PKLCAGLYQTP;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid ERLSIMITCOB;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid EYAEPJSQWAU;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid SZSKJWNPGCB;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid IBAZCUYZDLA;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid XPRNLXURSKR;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid IXFIGLOWAWS;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid UNSULHSJWZY;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid EGQJGEACQQV;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid DFBNJSFNJVF;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid XZYVTLTGHLY;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid THTQYSZHTBZ;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid PNTSCFZWREL;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid SYHZCXGGQGM;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid LKVPNLVOMIB;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid ECIIFRERZOY;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid EVLZCNCLBNM;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid BITBYNUMZYR;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid UPOPXLZRXJL;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid FWNMDQOCQFQ;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private static readonly Dictionary<Guid, SpawnableToolType> MFDBJFTIXZQ;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private static readonly Dictionary<SpawnableToolType, Guid> VQKMIMTRIKW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> JTGHWXRWQZT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x82B0900", Offset = "0x82AF300", VA = "0x1882B0900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> UYWMZWCAZLH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x82B0950", Offset = "0x82AF350", VA = "0x1882B0950")]
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
	public static class YCYTACAJELY
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82B09A0", Offset = "0x82AF3A0", VA = "0x1882B09A0")]
		public static bool DNUESRIQEDS(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82B09D0", Offset = "0x82AF3D0", VA = "0x1882B09D0")]
		private static bool DNUESRIQEDS(PHAWDGNAYSX a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PERULDTRTJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(ZYJHEVRJQQW data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, DARUJDYGQNE circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public readonly UPTKEAZFDLV Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public readonly IEnumerable<WSAKIWWEIUX> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly IReadOnlyList<WSAKIWWEIUX> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly Id32<HGNGXYZABBE> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<Id128<XEUKGISKBDU>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ELBNKHLNBUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE10", Offset = "0x82AE810", VA = "0x1882AFE10")]
		public R1CreateTemplateParams(UPTKEAZFDLV circuits, IEnumerable<WSAKIWWEIUX> rootData, IReadOnlyList<WSAKIWWEIUX> allPersistableData, Id32<HGNGXYZABBE> sourceGraphId, IReadOnlyList<Id128<XEUKGISKBDU>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly UPTKEAZFDLV Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly IReadOnlyList<WSAKIWWEIUX> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly Id32<HGNGXYZABBE> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<Id128<XEUKGISKBDU>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE80", Offset = "0x82AE880", VA = "0x1882AFE80")]
		public R2CreateTemplateParams(UPTKEAZFDLV circuits, Id32<HGNGXYZABBE> sourceGraphId, IReadOnlyList<Id128<XEUKGISKBDU>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<WSAKIWWEIUX> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class RAJPFOGCWRY : XCRALKIEVUM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly Guid MJHPCWYKLIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private readonly Dictionary<Guid, Guid> DTUDOWZGJJV;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4DA7520", Offset = "0x4DA5F20", VA = "0x184DA7520")]
		private RAJPFOGCWRY(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82B0420", Offset = "0x82AEE20", VA = "0x1882B0420")]
		public static RAJPFOGCWRY New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82B0010", Offset = "0x82AEA10", VA = "0x1882B0010")]
		private static Dictionary<Guid, Guid> GGQUPIKRDYU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82B0670", Offset = "0x82AF070", VA = "0x1882B0670")]
		public static RAJPFOGCWRY WOFMVASARNB(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82B0130", Offset = "0x82AEB30", VA = "0x1882B0130")]
		public static RAJPFOGCWRY NPJKEQGICHO(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82B00C0", Offset = "0x82AEAC0", VA = "0x1882B00C0")]
		public Dictionary<Guid, Guid> GJKALOCFHPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
		public Dictionary<Guid, Guid> PJXXUOQGFEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82AFEF0", Offset = "0x82AE8F0", VA = "0x1882AFEF0")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82B0680", Offset = "0x82AF080", VA = "0x1882B0680")]
		public void ZWPNKGICLSF(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82B0520", Offset = "0x82AEF20", VA = "0x1882B0520")]
		public Guid WBOGLLBWUYB([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF70", Offset = "0x82AE970", VA = "0x1882AFF70")]
		public Guid FMLNTWQXOXG([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82B04B0", Offset = "0x82AEEB0", VA = "0x1882B04B0")]
		public bool TBYYERUYQJH([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82B04B0", Offset = "0x82AEEB0", VA = "0x1882B04B0", Slot = "4")]
		private bool SYTUQQIGOWL([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface GIGMMNCOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool GFGEPPFHVZP(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DPNLINQGVRL(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MESUBFAAZJQ
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
	public abstract class YYDZZQZFIMQ : GIGMMNCOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FWZZESUDYQF : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			private string YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string ZZKHVIGFZGO
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
			[DebuggerHidden]
			public FWZZESUDYQF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x829E280", Offset = "0x829CC80", VA = "0x18829E280", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x829E340", Offset = "0x829CD40", VA = "0x18829E340", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x829E1F0", Offset = "0x829CBF0", VA = "0x18829E1F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> DIANHCHXSWJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x829E1F0", Offset = "0x829CBF0", VA = "0x18829E1F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private Dictionary<string, HashSet<Guid>>? GNQKGMMVVKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		protected Dictionary<string, string>? ACPNQWMCUZS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> FBXKKFFHALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x82B1650", Offset = "0x82B0050", VA = "0x1882B1650")]
			[IteratorStateMachine(typeof(FWZZESUDYQF))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? EIMFIWDPHPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool RXIWECQKLXS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool PIYTVOQQHOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> YIYXWWWYUFQ(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool XJVTVBIWPHQ(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82B0EB0", Offset = "0x82AF8B0", VA = "0x1882B0EB0")]
		public void FOZJISIOTIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD5FF40", Offset = "0xD5E940", VA = "0x180D5FF40")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82B12E0", Offset = "0x82AFCE0", VA = "0x1882B12E0", Slot = "4")]
		public bool GFGEPPFHVZP(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82B0DE0", Offset = "0x82AF7E0", VA = "0x1882B0DE0", Slot = "5")]
		public bool DPNLINQGVRL(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82B1590", Offset = "0x82AFF90", VA = "0x1882B1590")]
		private bool KNGYTNKFBAL(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82B16B0", Offset = "0x82B00B0", VA = "0x1882B16B0")]
		protected List<Guid> WUAEFQKXXCC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected YYDZZQZFIMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class LAKEWRNBFNG
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CKKPNCYLFCX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			public UPTKEAZFDLV UKCBHQFXGQJ;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CKKPNCYLFCX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x82B4E70", Offset = "0x82B3870", VA = "0x1882B4E70")]
			internal Id32<HKRBMAIBFCN> DBBURCBVYXN((Id32<HGNGXYZABBE> GraphId, Id32<XEUKGISKBDU> NodeId) i)
			{
				return default(Id32<HKRBMAIBFCN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private const int OILXSRUUDSP = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly Dictionary<Id32<HKRBMAIBFCN>, RYVHSJDINNX> AQYUSJWCJWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private long GQOWXAXFCYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private long MVWIOJWOJQE;

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private static readonly ReadOnlyIdArray<HKRBMAIBFCN, int?> JVFKHNESBOT;

		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private static readonly long BMIBGYOVKUZ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long UZODTNHZOXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x829E840", Offset = "0x829D240", VA = "0x18829E840")]
		public static LAKEWRNBFNG XOIRBDEFJTP(UPTKEAZFDLV a, Id128<HGNGXYZABBE> b, [Optional] LAKEWRNBFNG c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x829E4A0", Offset = "0x829CEA0", VA = "0x18829E4A0")]
		public static (long, long) NGHFRDKJUQF(UPTKEAZFDLV a, Id32<HGNGXYZABBE> b, Id32<XEUKGISKBDU> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x829E380", Offset = "0x829CD80", VA = "0x18829E380")]
		public static long IEXQSGTUXJU([In] ReadOnlySpan<Id32<HKRBMAIBFCN>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x829ED80", Offset = "0x829D780", VA = "0x18829ED80")]
		private static long YWBOQELRUZR()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82ABEE0", Offset = "0x82AA8E0", VA = "0x1882ABEE0")]
		public LAKEWRNBFNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class RYVHSJDINNX
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long BURAIOONOSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7DE51E0", Offset = "0x7DE3BE0", VA = "0x187DE51E0")]
		public RYVHSJDINNX(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class NWSBGNERQGJ
	{
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public static readonly HashSet<SpawnableToolType> SVVBPRHLDBW;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class BNTMAQENHRA
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class NUJUAIVRLOB : IEnumerable<WSAKIWWEIUX>, IEnumerable, IEnumerator<WSAKIWWEIUX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			private WSAKIWWEIUX YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private SpawnableTemplateData SRJZJPBRYZC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public SpawnableTemplateData YGWPRLSDGPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnTemplateParams VPVIYTRYCEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnTemplateParams NTOELCPHQSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private int WKECKAKFPAL;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private WSAKIWWEIUX LGQTKBNWGLE
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
			[DebuggerHidden]
			public NUJUAIVRLOB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x82B70F0", Offset = "0x82B5AF0", VA = "0x1882B70F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x82B7200", Offset = "0x82B5C00", VA = "0x1882B7200", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x82B6F90", Offset = "0x82B5990", VA = "0x1882B6F90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<WSAKIWWEIUX> IULGMHUMUVH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x82B6F90", Offset = "0x82B5990", VA = "0x1882B6F90", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82B23F0", Offset = "0x82B0DF0", VA = "0x1882B23F0")]
		public static SpawnableTemplateData PTZQLFLIKUR([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x82B2570", Offset = "0x82B0F70", VA = "0x1882B2570")]
		public static SpawnableTemplateData PTZQLFLIKUR([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82B18B0", Offset = "0x82B02B0", VA = "0x1882B18B0")]
		private static HashSet<Id128<EYUKRRPOQNQ>> BMSDVEDBAXR(IReadOnlyList<WSAKIWWEIUX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x82B3E00", Offset = "0x82B2800", VA = "0x1882B3E00")]
		private static void XPVHARWTJDG(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x82B2810", Offset = "0x82B1210", VA = "0x1882B2810")]
		public static Result<RAJPFOGCWRY, TryCloneTemplateError> VOOQYHQIJUT(SpawnableTemplateData a, SpawnTemplateParams b, RAJPFOGCWRY? srcRemapper, bool c)
		{
			return default(Result<RAJPFOGCWRY, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82B2700", Offset = "0x82B1100", VA = "0x1882B2700")]
		[IteratorStateMachine(typeof(NUJUAIVRLOB))]
		private static IEnumerable<WSAKIWWEIUX> REYPOYRJHJW(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82B46F0", Offset = "0x82B30F0", VA = "0x1882B46F0")]
		private static void YNQGZKSMDGL(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82B4760", Offset = "0x82B3160", VA = "0x1882B4760")]
		private static bool ZIITZJMPXAW(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82B2100", Offset = "0x82B0B00", VA = "0x1882B2100")]
		private static Dictionary<Guid, PHAWDGNAYSX> LWNJHSQMSCW(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x82B4DE0", Offset = "0x82B37E0", VA = "0x1882B4DE0")]
		private static void ZNTZXJIWNBS(bool a, WSAKIWWEIUX b, RAJPFOGCWRY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x82B4460", Offset = "0x82B2E60", VA = "0x1882B4460")]
		private static void XXQZKVNZENS(WSAKIWWEIUX a, Guid b, SpawnTransformData? c, Dictionary<Guid, PHAWDGNAYSX> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82B1C50", Offset = "0x82B0650", VA = "0x1882B1C50")]
		private static void KLDFWRAABPD(IEnumerable<WSAKIWWEIUX> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public UPTKEAZFDLV circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public MESUBFAAZJQ roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public PERULDTRTJA circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public Id128<HGNGXYZABBE> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public VIGUMLGGXIU globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public List<WSAKIWWEIUX> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public IONOOXYWMRQ photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Matrix4x4 GJOSHKOMLSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x82BE490", Offset = "0x82BCE90", VA = "0x1882BE490")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS KCEYHMFMZEM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x82BE590", Offset = "0x82BCF90", VA = "0x1882BE590")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x14088B0", Offset = "0x14072B0", VA = "0x1814088B0")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x82BE660", Offset = "0x82BD060", VA = "0x1882BE660")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x82BDF00", Offset = "0x82BC900", VA = "0x1882BDF00")]
		public static SpawnTransformData EMEWGMGRQFM(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82BE730", Offset = "0x82BD130", VA = "0x1882BE730")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x82BE750", Offset = "0x82BD150", VA = "0x1882BE750")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x82BE5D0", Offset = "0x82BCFD0", VA = "0x1882BE5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82BE280", Offset = "0x82BCC80", VA = "0x1882BE280")]
		public SpawnTransformData OLARYJJQFLS(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82BE210", Offset = "0x82BCC10", VA = "0x1882BE210")]
		public static SpawnTransformData MHAPKLONTDK(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82BE180", Offset = "0x82BCB80", VA = "0x1882BE180")]
		public readonly CircuitsRigidTransform GUYFLGDZLAQ()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private readonly PWKRFVXRRZL _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x16C88D0", Offset = "0x16C72D0", VA = "0x1816C88D0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, PWKRFVXRRZL innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x82BEA80", Offset = "0x82BD480", VA = "0x1882BEA80")]
		public QJQTDEDCOEW GESWHWGDQSZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82BEC60", Offset = "0x82BD660", VA = "0x1882BEC60")]
		public static Result<RAJPFOGCWRY, TryCloneTemplateError> New(LXRZMIAKYUD<None> innerError)
		{
			return default(Result<RAJPFOGCWRY, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82BEBB0", Offset = "0x82BD5B0", VA = "0x1882BEBB0")]
		public static Result<RAJPFOGCWRY, TryCloneTemplateError> New(QJQTDEDCOEW innerError)
		{
			return default(Result<RAJPFOGCWRY, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x82BEAF0", Offset = "0x82BD4F0", VA = "0x1882BEAF0")]
		public static Result<RAJPFOGCWRY, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<RAJPFOGCWRY, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class UUSJAQPECVF : IDisposable, ZJPAUBPLCZE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private NativeList<CurvePointData> GWBXQBHATWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private float IJXJHTJCGMC;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags ZZNUELXOKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool XQPJDUADRLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x82C0E00", Offset = "0x82BF800", VA = "0x1882C0E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IMDNOUKVTWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x82C0B50", Offset = "0x82BF550", VA = "0x1882C0B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> JLIDTIJPHOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int OCGEBHOGAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x82BFC20", Offset = "0x82BE620", VA = "0x1882BFC20", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float QDARRPGKIZB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x82BFA40", Offset = "0x82BE440", VA = "0x1882BFA40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82C18A0", Offset = "0x82C02A0", VA = "0x1882C18A0")]
		public UUSJAQPECVF(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82BF030", Offset = "0x82BDA30", VA = "0x1882BF030", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x82C0680", Offset = "0x82BF080", VA = "0x1882C0680")]
		public Vector3 QQYLHLJXHNY(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x82BEF00", Offset = "0x82BD900", VA = "0x1882BEF00", Slot = "6")]
		public Quaternion CRRZGVSYWLV(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82BFB80", Offset = "0x82BE580", VA = "0x1882BFB80", Slot = "5")]
		public Vector3 HUZKXMZZBAC(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82C16F0", Offset = "0x82C00F0", VA = "0x1882C16F0", Slot = "7")]
		public float YZCVUBKJGIH(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x82C0E10", Offset = "0x82BF810", VA = "0x1882C0E10")]
		public void YTVZICHZSBT(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x82BFE20", Offset = "0x82BE820", VA = "0x1882BFE20")]
		private bool QDKJLDWVKIV(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82C0C10", Offset = "0x82BF610", VA = "0x1882C0C10")]
		public void TJVSTWRETCT(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x82C0D70", Offset = "0x82BF770", VA = "0x1882C0D70")]
		public void VDYHKRBTAJU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82BF8F0", Offset = "0x82BE2F0", VA = "0x1882BF8F0")]
		public void HAYQFAGRHED(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x82BF740", Offset = "0x82BE140", VA = "0x1882BF740")]
		public void GVYIEMUELRZ(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x82C1750", Offset = "0x82C0150", VA = "0x1882C1750")]
		public void ZARIJZWTQRL(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x82BFC60", Offset = "0x82BE660", VA = "0x1882BFC60")]
		public void LFXGGCVUIWM(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x82BFE80", Offset = "0x82BE880", VA = "0x1882BFE80")]
		public static Quaternion QEAOUURPHCO(Quaternion a, int b, float c, ZJPAUBPLCZE d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x82BF090", Offset = "0x82BDA90", VA = "0x1882BF090")]
		public Bounds EFFCSQHEIRA(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x82BFDC0", Offset = "0x82BE7C0", VA = "0x1882BFDC0", Slot = "10")]
		public virtual void NRHNAFRDKVE(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x82C0B60", Offset = "0x82BF560", VA = "0x1882C0B60")]
		public NativeList<CurvePointData> ROPHQPBGRTU(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x82B5490", Offset = "0x82B3E90", VA = "0x1882B5490")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x82B53D0", Offset = "0x82B3DD0", VA = "0x1882B53D0")]
		public Quaternion KUSOYILMOHZ(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x82B4F40", Offset = "0x82B3940", VA = "0x1882B4F40")]
		public CurvePoint DKIUUCHDCUD(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x82B5230", Offset = "0x82B3C30", VA = "0x1882B5230")]
		public OKKDAZNQVJM DXJIOEVWQVB(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class HZHEICTIQXC : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x82B6060", Offset = "0x82B4A60", VA = "0x1882B6060", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x82B57B0", Offset = "0x82B41B0", VA = "0x1882B57B0")]
		private void DPDOXFFPVET(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82B5D80", Offset = "0x82B4780", VA = "0x1882B5D80")]
		private void DPDOXFFPVET(Dictionary<Guid, Guid> a, QRJEWWEOFIY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x82B5DE0", Offset = "0x82B47E0", VA = "0x1882B5DE0")]
		private void DPDOXFFPVET(Dictionary<Guid, Guid> a, YUMCJSGYKON b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public HZHEICTIQXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class TRHZNIDEZHL : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x82BE9D0", Offset = "0x82BD3D0", VA = "0x1882BE9D0", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TRHZNIDEZHL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class ENWPMWTWRFQ : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x82B5650", Offset = "0x82B4050", VA = "0x1882B5650", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ENWPMWTWRFQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class ZVWFQVNFLZG : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x82C32B0", Offset = "0x82C1CB0", VA = "0x1882C32B0", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ZVWFQVNFLZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class JTYNAKIQTVQ : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x82B6A30", Offset = "0x82B5430", VA = "0x1882B6A30", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public JTYNAKIQTVQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class DPGPWLMFKML : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x82B5510", Offset = "0x82B3F10", VA = "0x1882B5510", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public DPGPWLMFKML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class YSUAVNZFGOZ : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x82C2F70", Offset = "0x82C1970", VA = "0x1882C2F70", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public YSUAVNZFGOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class RMTIQQFVPQG : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x82BD240", Offset = "0x82BBC40", VA = "0x1882BD240", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RMTIQQFVPQG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class JJWBCGOSNDC : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x82B6880", Offset = "0x82B5280", VA = "0x1882B6880", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public JJWBCGOSNDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class KYHZLFSSEPC : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x82B6C50", Offset = "0x82B5650", VA = "0x1882B6C50", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KYHZLFSSEPC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class VQAVUWYVMEU : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x82C2AF0", Offset = "0x82C14F0", VA = "0x1882C2AF0", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public VQAVUWYVMEU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class TRDLGACNAIH : CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public static readonly IDGZGBMDVMR ECPQCCLNMLO;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x82BE8B0", Offset = "0x82BD2B0", VA = "0x1882BE8B0", Slot = "4")]
		public void FFSPBZBSBNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TRDLGACNAIH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public IONOOXYWMRQ photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface CURMLNPOETN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FFSPBZBSBNQ(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class OENQEWGHENC
	{
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private static readonly CURMLNPOETN[] FKEELFAQPMI;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x82B7D20", Offset = "0x82B6720", VA = "0x1882B7D20")]
		public static void QZPXVOCRXIN(WSAKIWWEIUX a, RAJPFOGCWRY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x82B7450", Offset = "0x82B5E50", VA = "0x1882B7450")]
		public static void BSTMCBVLGGF(WSAKIWWEIUX? data, RAJPFOGCWRY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x82B7AB0", Offset = "0x82B64B0", VA = "0x1882B7AB0")]
		public static void KLTKVQZOETB(WSAKIWWEIUX? data, RAJPFOGCWRY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82B76E0", Offset = "0x82B60E0", VA = "0x1882B76E0")]
		public static void DNUESRIQEDS(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public WSAKIWWEIUX viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x82B8540", Offset = "0x82B6F40", VA = "0x1882B8540")]
		public Guid GZPOHQDFXQK(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface IONOOXYWMRQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private static readonly HashSet<Guid> UHPDDSCVNBH;

		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private static readonly HashSet<Guid> XWBJWDWIRPB;

		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> FQIVFWVKCZB;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly ProfilerMarker ABLXUZQLQCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private readonly HashSet<string> VQANPOGBZTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private readonly Dictionary<long, int> SALRTXYYMGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<Guid> ZZHZAFEARVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly HashSet<Guid> RJWYZSGNBDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> KLCIIQHOLGT;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> NKZOBUCHKZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> SMQBCXTQVVV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> VROTYDGNWQR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> KOZJSLATCFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x82B9110", Offset = "0x82B7B10", VA = "0x1882B9110")]
		public static void HLFSDKYJPBF(SpawnableTemplateData a, WOZCGQTUZEF b, RAJPFOGCWRY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x82BAC80", Offset = "0x82B9680", VA = "0x1882BAC80")]
		public static PersistedRoomDataReferences IWAJXLQOPAL(PersistedRoomData a, WOZCGQTUZEF? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x82BAD00", Offset = "0x82B9700", VA = "0x1882BAD00")]
		public static PersistedRoomDataReferences NBKZSYHJKMQ(SpawnableTemplateData a, WOZCGQTUZEF? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x82BAD80", Offset = "0x82B9780", VA = "0x1882BAD80")]
		public static PersistedRoomDataReferences NDCTELYPNJA(BESXCZTRGHM a, YHYOXUWAOOG b, WOZCGQTUZEF? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x82B85E0", Offset = "0x82B6FE0", VA = "0x1882B85E0")]
		public static PersistedRoomDataReferences ADQDSCBFXVN(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x82BD0E0", Offset = "0x82BBAE0", VA = "0x1882BD0E0")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x82BCF10", Offset = "0x82BB910", VA = "0x1882BCF10")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x82BC360", Offset = "0x82BAD60", VA = "0x1882BC360")]
		private void XXYLAFGWCLI(PersistedRoomData a, WOZCGQTUZEF? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x82BC0D0", Offset = "0x82BAAD0", VA = "0x1882BC0D0")]
		private void XXYLAFGWCLI(SpawnableTemplateData a, WOZCGQTUZEF? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x82B8B70", Offset = "0x82B7570", VA = "0x1882B8B70")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x82BB2F0", Offset = "0x82B9CF0", VA = "0x1882BB2F0")]
		private void XXYLAFGWCLI(BESXCZTRGHM? a, WOZCGQTUZEF? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x82BBCD0", Offset = "0x82BA6D0", VA = "0x1882BBCD0")]
		private void XXYLAFGWCLI(YHYOXUWAOOG? a, WOZCGQTUZEF? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x82BCA00", Offset = "0x82BB400", VA = "0x1882BCA00")]
		private void XXYLAFGWCLI(GAVVCQRDZKG? a, WOZCGQTUZEF? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x82BB080", Offset = "0x82B9A80", VA = "0x1882BB080")]
		private static bool UKZBJIXYNRH(GAVVCQRDZKG a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x82BAE40", Offset = "0x82B9840", VA = "0x1882BAE40")]
		private static bool PSHUZPOOAHF(GAVVCQRDZKG a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x82BA920", Offset = "0x82B9320", VA = "0x1882BA920")]
		private static void HLFSDKYJPBF(YHYOXUWAOOG? root, WOZCGQTUZEF a, RAJPFOGCWRY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x82BA9F0", Offset = "0x82B93F0", VA = "0x1882BA9F0")]
		private static void HLFSDKYJPBF(GAVVCQRDZKG? customProperties, WOZCGQTUZEF a, RAJPFOGCWRY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x82B9F40", Offset = "0x82B8940", VA = "0x1882B9F40")]
		private static void HLFSDKYJPBF(BESXCZTRGHM? root, WOZCGQTUZEF a, RAJPFOGCWRY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x82BA2D0", Offset = "0x82B8CD0", VA = "0x1882BA2D0")]
		private static void HLFSDKYJPBF(CircuitsV2.Protobuf.CircuitNodeData? node, WOZCGQTUZEF a, RAJPFOGCWRY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x82BBD50", Offset = "0x82BA750", VA = "0x1882BBD50")]
		private void XXYLAFGWCLI(CircuitsV2.Protobuf.CircuitNodeData? a, WOZCGQTUZEF? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x82B87E0", Offset = "0x82B71E0", VA = "0x1882B87E0")]
		private void CJXJAZJDRYS(Guid? a, WOZCGQTUZEF? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x82BC600", Offset = "0x82BB000", VA = "0x1882BC600")]
		private void XXYLAFGWCLI(WSAKIWWEIUX? a, WOZCGQTUZEF? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x82B9B00", Offset = "0x82B8500", VA = "0x1882B9B00")]
		private static void HLFSDKYJPBF(WSAKIWWEIUX? viewData, WOZCGQTUZEF a, RAJPFOGCWRY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x82BB280", Offset = "0x82B9C80", VA = "0x1882BB280")]
		private void XFLCTDTGTHV(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x82B8AA0", Offset = "0x82B74A0", VA = "0x1882B8AA0")]
		private void ELNKXLEZEPX(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x82B89F0", Offset = "0x82B73F0", VA = "0x1882B89F0")]
		private void ELNKXLEZEPX(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x82B8A40", Offset = "0x82B7440", VA = "0x1882B8A40")]
		private void ELNKXLEZEPX(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class SJPTOTGQHGM : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			private readonly IEnumerator<DictionaryEntry> KOZNDAOKBSV;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x82BDCD0", Offset = "0x82BC6D0", VA = "0x1882BDCD0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x82BDDA0", Offset = "0x82BC7A0", VA = "0x1882BDDA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x82BDE50", Offset = "0x82BC850", VA = "0x1882BDE50", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x82BDBF0", Offset = "0x82BC5F0", VA = "0x1882BDBF0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
			public SJPTOTGQHGM(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x82BDB50", Offset = "0x82BC550", VA = "0x1882BDB50", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x82BDBA0", Offset = "0x82BC5A0", VA = "0x1882BDBA0", Slot = "9")]
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
			private sealed class LHTKMTHWQPY : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000591")]
				private int ILQFHFJYACP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000592")]
				private DictionaryEntry YDRMGGSTAGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				public RoomObjectCounts VIXLAPAPYNX;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry SAZHMVQJDRK
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object IDRIDRBRWXH
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x82B6F00", Offset = "0x82B5900", VA = "0x1882B6F00", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
				[DebuggerHidden]
				public LHTKMTHWQPY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x82B6E00", Offset = "0x82B5800", VA = "0x1882B6E00", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x82B6F50", Offset = "0x82B5950", VA = "0x1882B6F50", Slot = "8")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x400058F")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private ICollection SEPHLLTPQLY
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x82BD5E0", Offset = "0x82BBFE0", VA = "0x1882BD5E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x82BD6B0", Offset = "0x82BC0B0", VA = "0x1882BD6B0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x82BD790", Offset = "0x82BC190", VA = "0x1882BD790", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool VYBEXTNXGWF
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x82BD4A0", Offset = "0x82BBEA0", VA = "0x1882BD4A0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool YXVNKXQQIPS
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x82BD450", Offset = "0x82BBE50", VA = "0x1882BD450", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection MDEWTAECKDS
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x82BD9D0", Offset = "0x82BC3D0", VA = "0x1882BD9D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int HBCMYDWDBCJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x82BD540", Offset = "0x82BBF40", VA = "0x1882BD540", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool XULZVEAAXZK
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x82BD590", Offset = "0x82BBF90", VA = "0x1882BD590", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object YDFXFNOGBSJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x82BD400", Offset = "0x82BBE00", VA = "0x1882BD400", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xE2A700", Offset = "0xE29100", VA = "0x180E2A700")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x82BD7D0", Offset = "0x82BC1D0", VA = "0x1882BD7D0")]
			[IteratorStateMachine(typeof(LHTKMTHWQPY))]
			private IEnumerator<DictionaryEntry> TUDMKUWKQWR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x82BD8E0", Offset = "0x82BC2E0", VA = "0x1882BD8E0", Slot = "19")]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x82BD330", Offset = "0x82BBD30", VA = "0x1882BD330", Slot = "13")]
			private IDictionaryEnumerator DYFVBGHVSUQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x82BD4F0", Offset = "0x82BBEF0", VA = "0x1882BD4F0", Slot = "9")]
			private void GFLHLMKCTEF(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x82BD840", Offset = "0x82BC240", VA = "0x1882BD840", Slot = "10")]
			private void UGUPZATVOAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x82BD890", Offset = "0x82BC290", VA = "0x1882BD890", Slot = "8")]
			private bool ULTDAIOODDF(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x82BD660", Offset = "0x82BC060", VA = "0x1882BD660", Slot = "14")]
			private void SJXZUVWIIAW(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x82BD980", Offset = "0x82BC380", VA = "0x1882BD980", Slot = "15")]
			private void YIWXJRALZBE(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class ZNQWRYQVGDU : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000597")]
				private int ILQFHFJYACP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000598")]
				private DictionaryEntry YDRMGGSTAGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				public Invention VIXLAPAPYNX;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry SAZHMVQJDRK
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object IDRIDRBRWXH
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x82C3220", Offset = "0x82C1C20", VA = "0x1882C3220", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
				[DebuggerHidden]
				public ZNQWRYQVGDU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x82C3100", Offset = "0x82C1B00", VA = "0x1882C3100", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x82C3270", Offset = "0x82C1C70", VA = "0x1882C3270", Slot = "8")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x4000596")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ICollection SEPHLLTPQLY
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x82B6390", Offset = "0x82B4D90", VA = "0x1882B6390", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x82B6430", Offset = "0x82B4E30", VA = "0x1882B6430", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x82B6540", Offset = "0x82B4F40", VA = "0x1882B6540", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool VYBEXTNXGWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x82B6250", Offset = "0x82B4C50", VA = "0x1882B6250", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool YXVNKXQQIPS
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x82B6200", Offset = "0x82B4C00", VA = "0x1882B6200", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection MDEWTAECKDS
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x82B6760", Offset = "0x82B5160", VA = "0x1882B6760", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int HBCMYDWDBCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x82B62F0", Offset = "0x82B4CF0", VA = "0x1882B62F0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool XULZVEAAXZK
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x82B6340", Offset = "0x82B4D40", VA = "0x1882B6340", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object YDFXFNOGBSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x82B61B0", Offset = "0x82B4BB0", VA = "0x1882B61B0", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28B5840", Offset = "0x28B4240", VA = "0x1828B5840")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x82B6580", Offset = "0x82B4F80", VA = "0x1882B6580")]
			[IteratorStateMachine(typeof(ZNQWRYQVGDU))]
			private IEnumerator<DictionaryEntry> TUDMKUWKQWR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x82B6680", Offset = "0x82B5080", VA = "0x1882B6680", Slot = "19")]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x82B60E0", Offset = "0x82B4AE0", VA = "0x1882B60E0", Slot = "13")]
			private IDictionaryEnumerator DYFVBGHVSUQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x82B62A0", Offset = "0x82B4CA0", VA = "0x1882B62A0", Slot = "9")]
			private void GFLHLMKCTEF(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x82B65E0", Offset = "0x82B4FE0", VA = "0x1882B65E0", Slot = "10")]
			private void UGUPZATVOAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x82B6630", Offset = "0x82B5030", VA = "0x1882B6630", Slot = "8")]
			private bool ULTDAIOODDF(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x82B63E0", Offset = "0x82B4DE0", VA = "0x1882B63E0", Slot = "14")]
			private void SJXZUVWIIAW(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x82B6710", Offset = "0x82B5110", VA = "0x1882B6710", Slot = "15")]
			private void YIWXJRALZBE(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xE2A700", Offset = "0xE29100", VA = "0x180E2A700")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x82C1FC0", Offset = "0x82C09C0", VA = "0x1882C1FC0")]
		public static UgcRoomSaveStatsDetailed IWAJXLQOPAL(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x82C2970", Offset = "0x82C1370", VA = "0x1882C2970")]
		[CompilerGenerated]
		internal static int ZDTZLCBLIYJ([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x82C1920", Offset = "0x82C0320", VA = "0x1882C1920")]
		[CompilerGenerated]
		internal static void BRCWMFRGAZX(int a, [In] BESXCZTRGHM graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		ParticleVfx,
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		ConsumableItem
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class WOZCGQTUZEF
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public readonly Guid YCQCVFVMUJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public readonly IReadOnlyList<Guid> SMQBCXTQVVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly UnitySubAssetKind FAURZZYQYPT;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x82C2A90", Offset = "0x82C1490", VA = "0x1882C2A90")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private readonly RAJPFOGCWRY NSCRNCQSZJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private readonly Dictionary<Guid, UnitySubAsset> RJZDEOSRFEK;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public RAJPFOGCWRY LKAASAAROIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x82C2BF0", Offset = "0x82C15F0", VA = "0x1882C2BF0")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x82C2DF0", Offset = "0x82C17F0", VA = "0x1882C2DF0")]
		public bool RHVOSWLYXZM(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x82C2EE0", Offset = "0x82C18E0", VA = "0x1882C2EE0")]
		public WOZCGQTUZEF()
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
