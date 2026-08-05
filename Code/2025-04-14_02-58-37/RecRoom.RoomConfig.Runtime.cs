using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GGFGDHGONAM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	EditorOnly,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	TestServersOnly,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ReleasedToProduction
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AGRoomRuntimeConfig : ScriptableObject
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Location
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Header("Scene")]
		public string SceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public string[] RequiredSubSceneNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public string[] LevelRoomSubSceneNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Header("Metadata")]
		public int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GGFGDHGONAM ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool EmptyOnSandboxClone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public bool CustomizationAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public GIJAMHKINOJ SupportedGameMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GameTeamColorSettings GameTeamColorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public PHLKILLMMMD RewardGiftContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int UgcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[JAPMPDKIPPJ]
		public NFBELFLFMEM LocationEnum;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x807E790", Offset = "0x807D190", VA = "0x18807E790")]
		public Location()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Room
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GGFGDHGONAM ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public RoomScene[] Scenes;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public Room()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RoomScene
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string RoomSceneLocationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GGFGDHGONAM ReleaseStatus;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x807F890", Offset = "0x807E290", VA = "0x18807F890")]
		public RoomScene()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	public Location[] Locations;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	public Room[] Rooms;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[JAPMPDKIPPJ]
	public NFBELFLFMEM[] LocationsExcludedFromBuild;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x807E670", Offset = "0x807D070", VA = "0x18807E670")]
	public AGRoomRuntimeConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PNKOIJCOMIC
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static AGRoomRuntimeConfig PHLNCPOAOLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool OIDKLKFOBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x807F110", Offset = "0x807DB10", VA = "0x18807F110")]
	public static bool NGEPGKDAFMJ(string PABGPJFICHJ, [Out] NFBELFLFMEM OINHMALLBOO, [Out] int OKLOMOJNJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x807EDF0", Offset = "0x807D7F0", VA = "0x18807EDF0")]
	public static bool KHOINHBNIMO(NFBELFLFMEM OINHMALLBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x807EC50", Offset = "0x807D650", VA = "0x18807EC50")]
	public static string FNECOOKMELB(NFBELFLFMEM OINHMALLBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x807F600", Offset = "0x807E000", VA = "0x18807F600")]
	public static string[] PNPAECECGJH(NFBELFLFMEM OINHMALLBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x807EAD0", Offset = "0x807D4D0", VA = "0x18807EAD0")]
	public static int DIBCKPBKEKB(NFBELFLFMEM OINHMALLBOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x807EBC0", Offset = "0x807D5C0", VA = "0x18807EBC0")]
	public static string ELLNDBEGJCD(NFBELFLFMEM OINHMALLBOO, int DOAKEFBOPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x807F660", Offset = "0x807E060", VA = "0x18807F660")]
	private static bool PPAOIKAPLBA(string IDGAGDAHNDJ, [Out] AGRoomRuntimeConfig.Location JBPABLJGMIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x807EEF0", Offset = "0x807D8F0", VA = "0x18807EEF0")]
	public static bool NANCDOCHGGF(string IDGAGDAHNDJ, [Out] NFBELFLFMEM OINHMALLBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x807ECB0", Offset = "0x807D6B0", VA = "0x18807ECB0")]
	public static int HDGDNFOGEAB(NFBELFLFMEM OINHMALLBOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x807EA70", Offset = "0x807D470", VA = "0x18807EA70")]
	public static string DDHGBNCBMFJ(NFBELFLFMEM OINHMALLBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x807ED10", Offset = "0x807D710", VA = "0x18807ED10")]
	public static bool HLIINABJKFO(NFBELFLFMEM OINHMALLBOO, GIJAMHKINOJ PBJABDCMONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x807EB40", Offset = "0x807D540", VA = "0x18807EB40")]
	public static bool DNJCONDCMHH(NFBELFLFMEM OINHMALLBOO, [Out] GameTeamColorSettings LEGNCGGOGEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x807ED90", Offset = "0x807D790", VA = "0x18807ED90")]
	public static PHLKILLMMMD IAECDKJOIEO(NFBELFLFMEM OINHMALLBOO)
	{
		return default(PHLKILLMMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x807EE90", Offset = "0x807D890", VA = "0x18807EE90")]
	public static bool MHDPHILLJMA(NFBELFLFMEM OINHMALLBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x807E9D0", Offset = "0x807D3D0", VA = "0x18807E9D0")]
	public static bool DANGKMENKBP(NFBELFLFMEM OINHMALLBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x807F5F0", Offset = "0x807DFF0", VA = "0x18807F5F0")]
	public static int OEGEODHGEMJ(NFBELFLFMEM OINHMALLBOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x807E840", Offset = "0x807D240", VA = "0x18807E840")]
	public static AGRoomRuntimeConfig.Location BOHPEEJDKPF(NFBELFLFMEM OINHMALLBOO)
	{
		return null;
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GameTeamColorSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool TeamOutfitColorEmissionEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float TeamOutfitColorEmissionAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TeamColor[] CustomTeamColors;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x807E6D0", Offset = "0x807D0D0", VA = "0x18807E6D0")]
	public bool BLBBFNNEOAN(NOPMIPIDIAL JIPKJIFNCEB, [Out] Color IFFOAMBAJEI, bool CBKCJPEOBGM = false)
	{
		return default(bool);
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct TeamColor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NOPMIPIDIAL Team;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Color AlternateColor;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NOPMIPIDIAL
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TEAM_1 = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	TEAM_2 = 1,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	TEAM_3 = 2,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	TEAM_4 = 3,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	TEAM_5 = 4,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	TEAM_6 = 5,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	TEAM_7 = 6,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	TEAM_8 = 7,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TEAM_9 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	TEAM_10 = 9,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TEAM_11 = 10,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TEAM_12 = 11,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TEAM_13 = 12,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TEAM_14 = 13,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TEAM_15 = 14,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	TEAM_16 = 15,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	TEAM_17 = 16,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	TEAM_18 = 17,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	TEAM_19 = 18,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	TEAM_20 = 19,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	TEAM_21 = 20,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	TEAM_22 = 21,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	TEAM_23 = 22,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	TEAM_24 = 23,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	TEAM_25 = 24,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	TEAM_26 = 25,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	TEAM_27 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	TEAM_28 = 27,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	TEAM_29 = 28,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	TEAM_30 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	TEAM_31 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	TEAM_32 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	TEAM_33 = 32,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	TEAM_34 = 33,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	TEAM_35 = 34,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	TEAM_36 = 35,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	TEAM_37 = 36,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	TEAM_38 = 37,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	TEAM_39 = 38,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	TEAM_40 = 39,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ANY = -1,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	MAX_VALUE = 39
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum GIJAMHKINOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	MODE_1,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	MODE_2,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	MODE_3,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	MODE_4,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	MODE_5,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	MODE_6,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	MODE_7,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	MODE_8,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	MODE_9,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	MODE_10
}
namespace Cpp2IlInjected;

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
