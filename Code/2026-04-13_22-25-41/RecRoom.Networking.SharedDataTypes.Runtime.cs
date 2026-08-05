using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Netcode;
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class FTDYTNQZMKA : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte ASZIVIAOFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public RRNetworkDelivery LNNMVNEOBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public SVLVGVMSMLM UVOILKRMEXA;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE970", Offset = "0x3ABD370", VA = "0x183ABE970", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public FTDYTNQZMKA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum NetworkEventCode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		OMSendPacket = 4,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		RR_OutOfBandMessage = 5,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		RR_FastForwardMarker = 6,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		RR_SelfJoinMarker = 7,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		RR_DebugOp = 10,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		RR_CachedEvent = 11,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		RRRoomRequestEvent = 20,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		RRRoomRequestFailedResponseEvent = 21,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		RRBufferedRoomEvent = 22,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		RRClearBufferedRoomEvent = 23,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		RR_CreationOp = 24,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		RR_CreationOpResponse = 25,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		RR_CreationOp_Unchecked = 26,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		RR_MasterLockBlockComplete = 27,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		RR_NetworkSynchronization = 28,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		RR_NetworkInstantiate = 29,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		DO_NOT_USE = 30,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		RR_BulkInstantiate = 31,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		RR_Destroy = 32,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		RR_BulkDestroy = 33,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		RR_TransferOwnership = 34,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		RR_OwnershipUpdate = 35,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		RR_RPC = 36,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		RR_JoinRequest = 100,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		RR_JoinResponse = 101,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		RR_RoomUpdate = 102,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		RR_PlayerUpdate = 103,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		RR_RemotePlayerJoined = 104,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		RR_RemotePlayerLeft = 105,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		RR_Leave = 106,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		RR_StartBroadcast = 107,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		RR_StopBroadcast = 108,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		RR_ScreenShareData = 109,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		RR_BroadcastVoiceData = 110,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		RR_BroadcastChatData = 111,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		RR_GameServerDebug = 112
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct BroadcastVoiceData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public byte[] data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x37CAE40", Offset = "0x37C9840", VA = "0x1837CAE40", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct BroadcastMessageData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public short Emote;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int MessageType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int AccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public string PlayerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public string Message;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x37CAC20", Offset = "0x37C9620", VA = "0x1837CAC20", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct QuadControlPointNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector2 northEastCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Vector2 northWestCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Vector2 southWestCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector2 southEastCorner;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C390", Offset = "0x3E3AD90", VA = "0x183E3C390", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct ToolHolderInfoNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public byte holderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte equipmentSlotType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int viewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float relativeScale;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D120", Offset = "0x3F7BB20", VA = "0x183F7D120", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct LegacyToolCleanupImplSettingsOverridesNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool dataExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public bool useDefaultVisualEffects;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA6D0", Offset = "0x3BF90D0", VA = "0x183BFA6D0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct IndexMapPairNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B98960", Offset = "0x3B97360", VA = "0x183B98960", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct ManagedUGCStorefrontDataNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public string[] carousels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int featuredCarouselRowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int featuredCarouselColumnCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isThisRoomStorefront;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public bool isBackgroundHidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public bool isSynced;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D021E0", Offset = "0x3D00BE0", VA = "0x183D021E0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct RoomJoinRequest : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string platformId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public SerializableDictionary PlayerProperties;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9610", Offset = "0x3EF8010", VA = "0x183EF9610", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct RoomJoinResponse : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool Success;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NetworkedRoomData roomData;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9790", Offset = "0x3EF8190", VA = "0x183EF9790", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct NetworkedRoomData : INetworkSerializable
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[Flags]
		public enum RoomDataFields : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			MasterClient = 1,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Players = 2,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			Properties = 4,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			PreviousMasterClient = 8,
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			MasterClientChange = 9
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public RoomDataFields dataFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public ulong masterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ulong previousMasterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NetworkedPlayerData[] players;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public SerializableDictionary roomProperties;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E030", Offset = "0x3D7CA30", VA = "0x183D7E030", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct NetworkedPlayerData : INetworkSerializable
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[Flags]
		public enum PlayerDataFields : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			Name = 1,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			AccountId = 2,
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			PlatformId = 4,
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			Properties = 8,
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			IsBroadcasted = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			All = 0xF
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public PlayerDataFields dataFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public ulong clientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public string platformId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public SerializableDictionary playerProperties;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DD90", Offset = "0x3D7C790", VA = "0x183D7DD90", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct PlayerLeftData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public ulong leftClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NetworkedRoomData roomDataUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3DCEC20", Offset = "0x3DCD620", VA = "0x183DCEC20", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct SerializableDictionary : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Dictionary<object, object> Value;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3F10D00", Offset = "0x3F0F700", VA = "0x183F10D00", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class CUEYUKONOHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum SerializedType : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Null,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			Object,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			Array,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			List,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Bool,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Byte,
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			SByte,
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Char,
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			Short,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			UShort,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			Int,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			UInt,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Long,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			ULong,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Float,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Double,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			String,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Vector2,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Vector3,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			Vector3Int,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			Vector4,
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			Quaternion,
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			Color,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			Color32,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			ByteArray,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			SByteArray,
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			CharArray,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			ShortArray,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			UShortArray,
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			IntArray,
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			UIntArray,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			LongArray,
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			ULongArray,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			FloatArray,
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			DoubleArray,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			Vector2Array,
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			Vector3Array,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			Vector3IntArray,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			Vector4Array,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			QuaternionArray,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			ColorArray,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			Color32Array,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			Guid,
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			ViewId,
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			ObjectNetworkId,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			UncompressedQauternion,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			QuadControlPoint,
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			ToolHolderInfo,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			LegacyToolCleanupImplSettingOverrides,
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			StringIndexedMapPair,
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			ByteReadOnlyMemory,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			ManagedUGCStorefrontData,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			Dictionary,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			RoomJoinRequest,
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			RoomJoinResponse,
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			IntDictionary,
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			StringDictionary,
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			CircuitsVec3,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			CircuitsQuat,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			CV2RecNetImageWrapper,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			BroadcastVoiceData,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			BroadcastChatData
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void SerializeMethod(object data, FastBufferWriter writer);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object DeserializeMethod(FastBufferReader reader);

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class RYDHKEUGCOG<a, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public SerializedType AFOSVCJJLVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Func<a, b> ZGFPAUGXZEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Func<b, a> JCBPUDMUJOX;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public RYDHKEUGCOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x769F750", Offset = "0x769E150", VA = "0x18769F750")]
			internal void CRANKGKEQLX(object a, FastBufferWriter b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x769EB20", Offset = "0x769D520", VA = "0x18769EB20")]
			internal object CQVGMZQHHAO(FastBufferReader a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JJOOJTOLEST<a, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public SerializedType BLZMDFTPERQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Func<a, b> ZGFPAUGXZEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Func<b, a> JCBPUDMUJOX;

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public JJOOJTOLEST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x66883F0", Offset = "0x6686DF0", VA = "0x1866883F0")]
			internal void CQIOKHRVOKX(object a, FastBufferWriter b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6688000", Offset = "0x6686A00", VA = "0x186688000")]
			internal object CQDHNAXYEZO(FastBufferReader a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly Dictionary<Type, SerializedType> EAMJUHEOJOG;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly Dictionary<SerializedType, Type> LLQFDRPVDHO;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly Dictionary<SerializedType, SerializeMethod> YEPVXQMOHGK;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly Dictionary<SerializedType, DeserializeMethod> CSBMJRTMFXZ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly Dictionary<SerializedType, SerializedType> YUCIFKBOGFY;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly Dictionary<SerializedType, Type> BQYSNDTFCDO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x998FC60", Offset = "0x998E660", VA = "0x18998FC60")]
		static CUEYUKONOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x998F790", Offset = "0x998E190", VA = "0x18998F790")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x998AD00", Offset = "0x9989700", VA = "0x18998AD00")]
		public static void GHRXOLGFAHI(object a, FastBufferWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x998A5A0", Offset = "0x9988FA0", VA = "0x18998A5A0")]
		public static object Deserialize(FastBufferReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37E12E0", Offset = "0x37DFCE0", VA = "0x1837E12E0")]
		public static void FCSTTCXZTZT<a, b>(SerializedType a, Func<a, b> b, Func<b, a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37E3550", Offset = "0x37E1F50", VA = "0x1837E3550")]
		private static void WEGCWFYWUHN<c, d>(SerializedType a, Func<c, d> b, Func<d, c> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x998A970", Offset = "0x9989370", VA = "0x18998A970")]
		private static void FCSTTCXZTZT(Type a, SerializedType b, SerializeMethod c, DeserializeMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x998B980", Offset = "0x998A380", VA = "0x18998B980")]
		private static void NDKNUULEVDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x37E2F20", Offset = "0x37E1920", VA = "0x1837E2F20")]
		private static void UPIDQFJKHEC<e>(SerializedType a) where e : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37E2F20", Offset = "0x37E1920", VA = "0x1837E2F20")]
		private static void QSYGUBYUOXE<T, T>(SerializedType a) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37E2F20", Offset = "0x37E1920", VA = "0x1837E2F20")]
		private static void WOYCBVXYAML<T, T>(SerializedType a) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x998EF50", Offset = "0x998D950", VA = "0x18998EF50")]
		private static void NQJCNCCSBKB(object a, Type b, FastBufferWriter c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x998F5A0", Offset = "0x998DFA0", VA = "0x18998F5A0")]
		private static object OQBVUIMYQLG(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x998EE20", Offset = "0x998D820", VA = "0x18998EE20")]
		private static object NKEOHHBPFJJ(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x998B2D0", Offset = "0x9989CD0", VA = "0x18998B2D0")]
		private static object HIUMSQRVOAW(FastBufferReader a, Func<Type, int, IList> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37E2A20", Offset = "0x37E1420", VA = "0x1837E2A20")]
		public static void MSKWMSCXRZE<f, g, h>(object a, FastBufferWriter b) where f : Dictionary<g, h>, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x37E2130", Offset = "0x37E0B30", VA = "0x1837E2130")]
		public static object KBDKYLGAIEX<i, j, k>(FastBufferReader a) where i : Dictionary<j, k>, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x998B700", Offset = "0x998A100", VA = "0x18998B700")]
		private static void JOCKZKDAWLZ(object a, FastBufferWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x998F6D0", Offset = "0x998E0D0", VA = "0x18998F6D0")]
		private static object PYLJBAVFZPA(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x998B850", Offset = "0x998A250", VA = "0x18998B850")]
		private static object KNHMPLLJLOQ(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x998F900", Offset = "0x998E300", VA = "0x18998F900")]
		private static void VVAEDXSYRCJ(object a, FastBufferWriter b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum NetworkSynchronizationType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		NetworkTransform,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		PlayerAvatarData,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		FullBodyPuppetData,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		AvatarSkeletonData,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		ControlDeckData,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		RCCarData,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		GroundVehicleData,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		NetworkEnemyHeadRotationData,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		RoomieAIAudio,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		GameAIAudio,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Invalid
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum RpcCacheOption : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		DoNotCache = 0,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		AddToRoomCache = 4,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		AddToRoomCacheGlobal = 5,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		RemoveFromRoomCache = 6,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		RemoveFromRoomCacheForActorsLeft = 7
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum RRNetworkDelivery : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Unreliable,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		UnreliableUnsequenced,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Reliable,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		ReliableUnsequenced
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class FXYGHQIMQNG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x998FED0", Offset = "0x998E8D0", VA = "0x18998FED0")]
		public static NetworkDelivery ZCDOISQZRSB(this RRNetworkDelivery a)
		{
			return default(NetworkDelivery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum RRReceiverGroup : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		Others,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		All,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		MasterClient
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SVLVGVMSMLM : INetworkSerializable
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly SVLVGVMSMLM FYIBPTBKDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public RpcCacheOption IIPTHVBCJRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public byte JGCCFXZXCOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int[] SSFIRORNVRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public RRReceiverGroup FLQTCSHRWYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
		public byte TBDAALNBDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public VWNMYAWJSZL ZLTOQQNHIHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int HOGCLEZZYKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public object WFVFKLBWOEQ;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3F09B50", Offset = "0x3F08550", VA = "0x183F09B50", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9990060", Offset = "0x998EA60", VA = "0x189990060")]
		public SVLVGVMSMLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class VWNMYAWJSZL
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly VWNMYAWJSZL FYIBPTBKDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public byte MSRBPBMCVMM;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public const byte CJFAHBKUFDK = 1;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public const byte VZVXFBRUZKB = 2;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public const byte BUGLPBYDWKY = 4;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public const byte ELDNDNJKHHM = 8;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xFE13B0", Offset = "0xFDFDB0", VA = "0x180FE13B0")]
		public VWNMYAWJSZL(byte a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum PseudoViewId
	{

	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum PseudoObjectNetworkId : uint
	{

	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct PseudoCircuitsQuat
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public float z;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public float w;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370500", VA = "0x181371B00")]
		public Quaternion IUBHVKSSLPP()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370500", VA = "0x181371B00")]
		public static PseudoCircuitsQuat NPLHDJLPVJS(Quaternion a)
		{
			return default(PseudoCircuitsQuat);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct PseudoCircuitsVec3
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public float z;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B430", Offset = "0x1D79E30", VA = "0x181D7B430")]
		public Vector3 KMIHQOWSLOX()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B430", Offset = "0x1D79E30", VA = "0x181D7B430")]
		public static PseudoCircuitsVec3 EPCQTPNAMQE(Vector3 a)
		{
			return default(PseudoCircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct PsuedoCV2RecNetImageWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public string imageName;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6A90", VA = "0x180EC8090")]
		public string CNAUGUHMPQB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x10CD690", Offset = "0x10CC090", VA = "0x1810CD690")]
		public static PsuedoCV2RecNetImageWrapper AVBPWTHRSUG(string a)
		{
			return default(PsuedoCV2RecNetImageWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class BGBUDUBTCLW : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int QASTTDNKIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public byte ASZIVIAOFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int SZTBRXXLFHX;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x37221B0", Offset = "0x3720BB0", VA = "0x1837221B0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public BGBUDUBTCLW()
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
