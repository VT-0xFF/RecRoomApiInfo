using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using RecRoom;
using RecRoom.Build;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ReleaseStatus
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
		public ReleaseStatus ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool EmptyOnSandboxClone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public bool CustomizationAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public LegacyGameModeType SupportedGameMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GameTeamColorSettings GameTeamColorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public GiftContext RewardGiftContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int UgcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[AllowSerializationOverride]
		public RoomSceneLocations LocationEnum;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1B98D0", Offset = "0xA1B82D0", VA = "0x18A1B98D0")]
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
		public ReleaseStatus ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public RoomScene[] Scenes;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		public ReleaseStatus ReleaseStatus;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B9980", Offset = "0xA1B8380", VA = "0x18A1B9980")]
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
	[AllowSerializationOverride]
	public RoomSceneLocations[] LocationsExcludedFromBuild;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA1B97B0", Offset = "0xA1B81B0", VA = "0x18A1B97B0")]
	public AGRoomRuntimeConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class XLASZCSOSXZ
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static AGRoomRuntimeConfig EBJVLIWAOQV;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool HVODTUVWJHY
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA1BA3B0", Offset = "0xA1B8DB0", VA = "0x18A1BA3B0")]
	public static bool WHQPZFSBHCX(string a, [Out] RoomSceneLocations b, [Out] int c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9CA0", Offset = "0xA1B86A0", VA = "0x18A1B9CA0")]
	public static bool OAJBEIUNKUQ(RoomSceneLocations a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9F40", Offset = "0xA1B8940", VA = "0x18A1B9F40")]
	public static string QBDCQIZLELW(RoomSceneLocations a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9EE0", Offset = "0xA1B88E0", VA = "0x18A1B9EE0")]
	public static string[] PSFJACLAZZA(RoomSceneLocations a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA1BA340", Offset = "0xA1B8D40", VA = "0x18A1BA340")]
	public static int VARDDATODXS(RoomSceneLocations a)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA1BA9A0", Offset = "0xA1B93A0", VA = "0x18A1BA9A0")]
	public static string ZFATQZROIGI(RoomSceneLocations a, int b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9A50", Offset = "0xA1B8450", VA = "0x18A1B9A50")]
	private static bool JHULPZLZCKL(string a, [Out] AGRoomRuntimeConfig.Location b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA1BA0C0", Offset = "0xA1B8AC0", VA = "0x18A1BA0C0")]
	public static bool UCQPHILKXHC(string a, [Out] RoomSceneLocations b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA1B99F0", Offset = "0xA1B83F0", VA = "0x18A1B99F0")]
	public static int IFBCVXPCLDJ(RoomSceneLocations a)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9990", Offset = "0xA1B8390", VA = "0x18A1B9990")]
	public static string CYUBKKRUKVE(RoomSceneLocations a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA1BA2E0", Offset = "0xA1B8CE0", VA = "0x18A1BA2E0")]
	public static string UCSUASKFCEQ(RoomSceneLocations a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA1BA040", Offset = "0xA1B8A40", VA = "0x18A1BA040")]
	public static bool SGNBMBYIHZU(RoomSceneLocations a, LegacyGameModeType b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xA1BA920", Offset = "0xA1B9320", VA = "0x18A1BA920")]
	public static bool XZMOMNCMWVM(RoomSceneLocations a, [Out] GameTeamColorSettings b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA1BA8C0", Offset = "0xA1B92C0", VA = "0x18A1BA8C0")]
	public static GiftContext XORCEPJVHDS(RoomSceneLocations a)
	{
		return default(GiftContext);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9C40", Offset = "0xA1B8640", VA = "0x18A1B9C40")]
	public static bool NZKHQTXKJWC(RoomSceneLocations a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9FA0", Offset = "0xA1B89A0", VA = "0x18A1B9FA0")]
	public static bool QFMZYNIWIER(RoomSceneLocations a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9C30", Offset = "0xA1B8630", VA = "0x18A1B9C30")]
	public static int MNBHKOYALPH(RoomSceneLocations a)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9D40", Offset = "0xA1B8740", VA = "0x18A1B9D40")]
	public static AGRoomRuntimeConfig.Location OUPNHWXOIBH(RoomSceneLocations a)
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

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xA1B9810", Offset = "0xA1B8210", VA = "0x18A1B9810")]
	public bool WAXZQJSXDDU(GameTeam a, [Out] Color b, bool c = false)
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
	public GameTeam Team;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Color AlternateColor;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GameTeam
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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum LegacyGameModeType
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
