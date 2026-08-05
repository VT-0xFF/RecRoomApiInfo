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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class JTPSDUZNMZR : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte JTPTDWKYJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public RRNetworkDelivery YOHFKTYBJVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public QBWHSXSYUOT WNUGAAMBKNT;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x39B3F50", Offset = "0x39B2D50", VA = "0x1839B3F50", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public JTPSDUZNMZR()
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
		RR_BroadcastChatData = 111
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct BroadcastVoiceData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x36CEC20", Offset = "0x36CDA20", VA = "0x1836CEC20", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct BroadcastMessageData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public short Emote;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int MessageType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int AccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public string PlayerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public string Message;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x36CEA00", Offset = "0x36CD800", VA = "0x1836CEA00", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct QuadControlPointNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector2 northEastCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector2 northWestCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Vector2 southWestCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Vector2 southEastCorner;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C278F0", Offset = "0x3C266F0", VA = "0x183C278F0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct ToolHolderInfoNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public byte holderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public byte equipmentSlotType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int viewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float relativeScale;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D49E10", Offset = "0x3D48C10", VA = "0x183D49E10", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct LegacyToolCleanupImplSettingsOverridesNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool dataExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public bool useDefaultVisualEffects;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x39F76E0", Offset = "0x39F64E0", VA = "0x1839F76E0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct IndexMapPairNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3999BC0", Offset = "0x39989C0", VA = "0x183999BC0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct ManagedUGCStorefrontDataNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public string[] carousels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int featuredCarouselRowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int featuredCarouselColumnCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool isThisRoomStorefront;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isBackgroundHidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public bool isSynced;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8FB0", Offset = "0x3AB7DB0", VA = "0x183AB8FB0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct RoomJoinRequest : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public string platformId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public SerializableDictionary PlayerProperties;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0CE0", Offset = "0x3CDFAE0", VA = "0x183CE0CE0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct RoomJoinResponse : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool Success;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NetworkedRoomData roomData;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0E60", Offset = "0x3CDFC60", VA = "0x183CE0E60", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			MasterClient = 1,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			Players = 2,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Properties = 4,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			PreviousMasterClient = 8,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			MasterClientChange = 9
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public RoomDataFields dataFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ulong masterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public ulong previousMasterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NetworkedPlayerData[] players;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public SerializableDictionary roomProperties;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B04A00", Offset = "0x3B03800", VA = "0x183B04A00", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Name = 1,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			AccountId = 2,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			PlatformId = 4,
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			Properties = 8,
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			IsBroadcasted = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			All = 0xF
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public PlayerDataFields dataFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ulong clientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public string platformId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public SerializableDictionary playerProperties;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3B04760", Offset = "0x3B03560", VA = "0x183B04760", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct PlayerLeftData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public ulong leftClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NetworkedRoomData roomDataUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3BB35A0", Offset = "0x3BB23A0", VA = "0x183BB35A0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct SerializableDictionary : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Dictionary<object, object> Value;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7B30", Offset = "0x3CF6930", VA = "0x183CF7B30", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class QBZRYWRIZUN
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum SerializedType : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			Null,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Object,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			Array,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			List,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			Bool,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Byte,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			SByte,
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			Char,
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Short,
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			UShort,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Int,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			UInt,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			Long,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			ULong,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Float,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Double,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			String,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Vector2,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Vector3,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Vector3Int,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			Vector4,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			Quaternion,
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			Color,
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			Color32,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			ByteArray,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			SByteArray,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			CharArray,
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			ShortArray,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			UShortArray,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			IntArray,
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			UIntArray,
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			LongArray,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			ULongArray,
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			FloatArray,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			DoubleArray,
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			Vector2Array,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			Vector3Array,
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			Vector3IntArray,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			Vector4Array,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			QuaternionArray,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			ColorArray,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			Color32Array,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			Guid,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			ViewId,
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			ObjectNetworkId,
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			UncompressedQauternion,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			QuadControlPoint,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			ToolHolderInfo,
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			LegacyToolCleanupImplSettingOverrides,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			StringIndexedMapPair,
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			ByteReadOnlyMemory,
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			ManagedUGCStorefrontData,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			Dictionary,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			PhotonHashtable,
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
		private sealed class FTMITORADFR<a, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public SerializedType YTZJDCTFLTQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Func<a, b> AXUAUXISOXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Func<b, a> LRKVIRNRGJQ;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public FTMITORADFR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x505EF40", Offset = "0x505DD40", VA = "0x18505EF40")]
			internal void CYYWISACUXY(object a, FastBufferWriter b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x505F550", Offset = "0x505E350", VA = "0x18505F550")]
			internal object CZEDFYUAEJH(FastBufferReader a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EHDSUTXKUKW<a, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public SerializedType CDKUGRGMTUJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Func<a, b> AXUAUXISOXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public Func<b, a> LRKVIRNRGJQ;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EHDSUTXKUKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4959100", Offset = "0x4957F00", VA = "0x184959100")]
			internal void RRTLIWIFMDK(object a, FastBufferWriter b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x4959660", Offset = "0x4958460", VA = "0x184959660")]
			internal object RRYSGDCCVOT(FastBufferReader a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Dictionary<Type, SerializedType> BYEDIYADBUF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly Dictionary<SerializedType, Type> IRWFGIIVJBB;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly Dictionary<SerializedType, SerializeMethod> QXPABUWYVZX;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly Dictionary<SerializedType, DeserializeMethod> GWEZHNADEWI;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly Dictionary<SerializedType, SerializedType> DQWXEOHDRCJ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly Dictionary<SerializedType, Type> HRKZIZIGGQH;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86D4C00", Offset = "0x86D3A00", VA = "0x1886D4C00")]
		static QBZRYWRIZUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86D3E70", Offset = "0x86D2C70", VA = "0x1886D3E70")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86D43F0", Offset = "0x86D31F0", VA = "0x1886D43F0")]
		public static void VVUFAYMMXPR(object a, FastBufferWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86CF790", Offset = "0x86CE590", VA = "0x1886CF790")]
		public static object Deserialize(FastBufferReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3C20570", Offset = "0x3C1F370", VA = "0x183C20570")]
		public static void QBDWXJYREZY<a, b>(SerializedType a, Func<a, b> b, Func<b, a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FF60", Offset = "0x3C1ED60", VA = "0x183C1FF60")]
		private static void BJQLPVREAQA<c, d>(SerializedType a, Func<c, d> b, Func<d, c> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86D05D0", Offset = "0x86CF3D0", VA = "0x1886D05D0")]
		private static void QBDWXJYREZY(Type a, SerializedType b, SerializeMethod c, DeserializeMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86D0940", Offset = "0x86CF740", VA = "0x1886D0940")]
		private static void QWQWCIJGVMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C20280", Offset = "0x3C1F080", VA = "0x183C20280")]
		private static void ISELIPGQMIL<e>(SerializedType a) where e : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3C20280", Offset = "0x3C1F080", VA = "0x183C20280")]
		private static void KDPYSYNFALR<T, T>(SerializedType a) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C20280", Offset = "0x3C1F080", VA = "0x183C20280")]
		private static void MUQCTGAZXNO<T, T>(SerializedType a) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86CFC00", Offset = "0x86CEA00", VA = "0x1886CFC00")]
		private static void JFKRAKYSJCS(object a, Type b, FastBufferWriter c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86D49B0", Offset = "0x86D37B0", VA = "0x1886D49B0")]
		private static object WECGOLXGAJB(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86D3D50", Offset = "0x86D2B50", VA = "0x1886D3D50")]
		private static object RZMFFZRFBJA(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86D3FC0", Offset = "0x86D2DC0", VA = "0x1886D3FC0")]
		private static object TJERNNOPLCN(FastBufferReader a, Func<Type, int, IList> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C21C90", Offset = "0x3C20A90", VA = "0x183C21C90")]
		public static void YHOWFRCRQID<f, g, h>(object a, FastBufferWriter b) where f : Dictionary<g, h>, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C213A0", Offset = "0x3C201A0", VA = "0x183C213A0")]
		public static object WGSNLFXDQIW<i, j, k>(FastBufferReader a) where i : Dictionary<j, k>, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86CF640", Offset = "0x86CE440", VA = "0x1886CF640")]
		private static void DSVTMFFKEPQ(object a, FastBufferWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86CFB40", Offset = "0x86CE940", VA = "0x1886CFB40")]
		private static object IEOMMXQCDJV(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86D4AD0", Offset = "0x86D38D0", VA = "0x1886D4AD0")]
		private static object WODNAKVOWUV(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86D0270", Offset = "0x86CF070", VA = "0x1886D0270")]
		private static void NNXJOYXFGJS(object a, FastBufferWriter b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum NetworkSynchronizationType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		NetworkTransform,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		PlayerAvatarData,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		FullBodyPuppetData,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		AvatarSkeletonData,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		ControlDeckData,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		RCCarData,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		GroundVehicleData,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		NetworkEnemyHeadRotationData,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		RoomieAIAudio,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		GameAIAudio,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Invalid
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum RpcCacheOption : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		DoNotCache = 0,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		AddToRoomCache = 4,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		AddToRoomCacheGlobal = 5,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		RemoveFromRoomCache = 6,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		RemoveFromRoomCacheForActorsLeft = 7
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum RRNetworkDelivery : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Unreliable,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		UnreliableUnsequenced,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		Reliable,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		ReliableUnsequenced
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class THYVAYTNZWZ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86D4E40", Offset = "0x86D3C40", VA = "0x1886D4E40")]
		public static NetworkDelivery DHKTOLFMGJW(this RRNetworkDelivery a)
		{
			return default(NetworkDelivery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum RRReceiverGroup : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		Others,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		All,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		MasterClient
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class QBWHSXSYUOT : INetworkSerializable
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly QBWHSXSYUOT GUTFKAZYITC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public RpcCacheOption VEWMXBELMUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public byte GCNKNBKMIRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int[] DGHGINGKISE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public RRReceiverGroup MPIKYMSKONR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
		public byte FRIALJTXUUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public LRPNFNPKGRM ZISGPBWJHQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int XSISSGIZSXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public object VLGALSOFDJP;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3C1F9B0", Offset = "0x3C1E7B0", VA = "0x183C1F9B0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x86CF5D0", Offset = "0x86CE3D0", VA = "0x1886CF5D0")]
		public QBWHSXSYUOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class LRPNFNPKGRM
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly LRPNFNPKGRM GUTFKAZYITC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public byte TFRBFSBZYFJ;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public const byte ZNCQTUPQKXJ = 1;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public const byte ARPZJDDSJIA = 2;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public const byte MIGJXVXKBEJ = 4;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public const byte UIVXZELKYSF = 8;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD542C0", Offset = "0xD530C0", VA = "0x180D542C0")]
		public LRPNFNPKGRM(byte a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class PseudoPhotonHashTable : Dictionary<object, object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86CF4D0", Offset = "0x86CE2D0", VA = "0x1886CF4D0")]
		public PseudoPhotonHashTable(IDictionary<object, object> dictionary)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum PseudoViewId
	{

	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum PseudoObjectNetworkId : uint
	{

	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct PseudoCircuitsQuat
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public float z;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public float w;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x134EC70", Offset = "0x134DA70", VA = "0x18134EC70")]
		public Quaternion CLAPEEDTBUW()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x134EC70", Offset = "0x134DA70", VA = "0x18134EC70")]
		public static PseudoCircuitsQuat QNDXHLEFAPN(Quaternion a)
		{
			return default(PseudoCircuitsQuat);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct PseudoCircuitsVec3
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public float z;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1D38970", Offset = "0x1D37770", VA = "0x181D38970")]
		public Vector3 CXKSGYZFXSG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1D38970", Offset = "0x1D37770", VA = "0x181D38970")]
		public static PseudoCircuitsVec3 ISATVPZZAER(Vector3 a)
		{
			return default(PseudoCircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public struct PsuedoCV2RecNetImageWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public string imageName;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
		public string CHRGXQDOFYA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x14CA840", Offset = "0x14C9640", VA = "0x1814CA840")]
		public static PsuedoCV2RecNetImageWrapper UKQZHLCYSWP(string a)
		{
			return default(PsuedoCV2RecNetImageWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class OADCZVADLNF : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int LSDYWPOKPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public byte JTPTDWKYJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int XGARBZOEMRC;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3B062C0", Offset = "0x3B050C0", VA = "0x183B062C0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public OADCZVADLNF()
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
