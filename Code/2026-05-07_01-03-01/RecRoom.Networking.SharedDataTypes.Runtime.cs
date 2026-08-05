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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ZRTQZBBTDLW : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte PECELIWJFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public RRNetworkDelivery TBZFDJIVGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public BJJNNDTQGRE HGWYUKBZNFU;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x41207B0", Offset = "0x411F1B0", VA = "0x1841207B0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public ZRTQZBBTDLW()
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
		[Cpp2IlInjected.Address(RVA = "0x37CBFA0", Offset = "0x37CA9A0", VA = "0x1837CBFA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37CBD80", Offset = "0x37CA780", VA = "0x1837CBD80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E2A6F0", Offset = "0x3E290F0", VA = "0x183E2A6F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F67140", Offset = "0x3F65B40", VA = "0x183F67140", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C09310", Offset = "0x3C07D10", VA = "0x183C09310", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BA34E0", Offset = "0x3BA1EE0", VA = "0x183BA34E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CFA7E0", Offset = "0x3CF91E0", VA = "0x183CFA7E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EF64F0", Offset = "0x3EF4EF0", VA = "0x183EF64F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EF6670", Offset = "0x3EF5070", VA = "0x183EF6670", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D4EA00", Offset = "0x3D4D400", VA = "0x183D4EA00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D4E760", Offset = "0x3D4D160", VA = "0x183D4E760", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DBDDA0", Offset = "0x3DBC7A0", VA = "0x183DBDDA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F14850", Offset = "0x3F13250", VA = "0x183F14850", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class RYVCIIOUZLU
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
		private sealed class LMVJXCNVKCS<a, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public SerializedType ZADNHVNIISJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Func<a, b> XIKGWXCAFQW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Func<b, a> QSRDCJVJMGH;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public LMVJXCNVKCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x69468D0", Offset = "0x69452D0", VA = "0x1869468D0")]
			internal void GYQJGVCHXWJ(object a, FastBufferWriter b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6945D90", Offset = "0x6944790", VA = "0x186945D90")]
			internal object GYLCJOIKOLA(FastBufferReader a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class KSZKICSFMPF<a, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public SerializedType ZZDXJGDYHHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Func<a, b> XIKGWXCAFQW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Func<b, a> QSRDCJVJMGH;

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public KSZKICSFMPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6843D60", Offset = "0x6842760", VA = "0x186843D60")]
			internal void DACTSZNRKDR(object a, FastBufferWriter b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6843120", Offset = "0x6841B20", VA = "0x186843120")]
			internal object CZXMVSTUASI(FastBufferReader a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly Dictionary<Type, SerializedType> WNIHZQYBSIS;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly Dictionary<SerializedType, Type> CGDTHSRGMMM;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly Dictionary<SerializedType, SerializeMethod> DNWARTOMASC;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly Dictionary<SerializedType, DeserializeMethod> TGUJOEFNMTB;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly Dictionary<SerializedType, SerializedType> ZHVBBCOINEK;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly Dictionary<SerializedType, Type> THVDPGEEIFW;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99772E0", Offset = "0x9975CE0", VA = "0x1899772E0")]
		static RYVCIIOUZLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9976510", Offset = "0x9974F10", VA = "0x189976510")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9976B10", Offset = "0x9975510", VA = "0x189976B10")]
		public static void XQIXCNAGDPI(object a, FastBufferWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9972280", Offset = "0x9970C80", VA = "0x189972280")]
		public static object Deserialize(FastBufferReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3ED42A0", Offset = "0x3ED2CA0", VA = "0x183ED42A0")]
		public static void FDJJCSKQNEJ<a, b>(SerializedType a, Func<a, b> b, Func<b, a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3F70", Offset = "0x3ED2970", VA = "0x183ED3F70")]
		private static void DULCUHIHHRZ<c, d>(SerializedType a, Func<c, d> b, Func<d, c> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9972A80", Offset = "0x9971480", VA = "0x189972A80")]
		private static void FDJJCSKQNEJ(Type a, SerializedType b, SerializeMethod c, DeserializeMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9972E10", Offset = "0x9971810", VA = "0x189972E10")]
		private static void FSOZXCLADYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3940", Offset = "0x3ED2340", VA = "0x183ED3940")]
		private static void BYMMBQMTODM<e>(SerializedType a) where e : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3940", Offset = "0x3ED2340", VA = "0x183ED3940")]
		private static void IJTARNLKZEC<T, T>(SerializedType a) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3940", Offset = "0x3ED2340", VA = "0x183ED3940")]
		private static void VWIZYBJOKVN<T, T>(SerializedType a) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9971C30", Offset = "0x9970630", VA = "0x189971C30")]
		private static void DIJQDPKNCFT(object a, Type b, FastBufferWriter c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99762B0", Offset = "0x9974CB0", VA = "0x1899762B0")]
		private static object PIGOVABYHPO(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99763E0", Offset = "0x9974DE0", VA = "0x1899763E0")]
		private static object PWTSQZDCSVJ(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9972650", Offset = "0x9971050", VA = "0x189972650")]
		private static object ELLIMRVBZIG(FastBufferReader a, Func<Type, int, IList> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5270", Offset = "0x3ED3C70", VA = "0x183ED5270")]
		public static void GLUDFPUHSGS<f, g, h>(object a, FastBufferWriter b) where f : Dictionary<g, h>, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5B00", Offset = "0x3ED4500", VA = "0x183ED5B00")]
		public static object JMJVLRDGJOT<i, j, k>(FastBufferReader a) where i : Dictionary<j, k>, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99771A0", Offset = "0x9975BA0", VA = "0x1899771A0")]
		private static void ZTEVFKMCKDV(object a, FastBufferWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99770E0", Offset = "0x9975AE0", VA = "0x1899770E0")]
		private static object YZYAQBYRDES(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99769E0", Offset = "0x99753E0", VA = "0x1899769E0")]
		private static object UHQCPRIHUEU(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9976680", Offset = "0x9975080", VA = "0x189976680")]
		private static void TGTJFUTNPLD(object a, FastBufferWriter b)
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
	public static class NRBCKYXWUJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9971B60", Offset = "0x9970560", VA = "0x189971B60")]
		public static NetworkDelivery IJFCIWIRFZH(this RRNetworkDelivery a)
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
	public class BJJNNDTQGRE : INetworkSerializable
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly BJJNNDTQGRE KLCPKUHGTRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public RpcCacheOption PLJDNKGDIYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public byte LMEOWBUWFWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int[] RXEXVRWEKET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public RRReceiverGroup UIKBSPFNPQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
		public byte HWIMJFZAXVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public MTMXSKHTATL HJOHHTAGMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int LKLIKLYQFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public object NDLJDJKDPDK;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3724FC0", Offset = "0x37239C0", VA = "0x183724FC0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9971A80", Offset = "0x9970480", VA = "0x189971A80")]
		public BJJNNDTQGRE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class MTMXSKHTATL
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly MTMXSKHTATL KLCPKUHGTRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public byte OIWYRKTSXZO;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public const byte PMEFTWBQDZS = 1;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public const byte RBHIKKYAKTH = 2;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public const byte VNQELMPSTDG = 4;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public const byte LFKVCSNWXZE = 8;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xFC1AA0", Offset = "0xFC04A0", VA = "0x180FC1AA0")]
		public MTMXSKHTATL(byte a)
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
		[Cpp2IlInjected.Address(RVA = "0x1357A00", Offset = "0x1356400", VA = "0x181357A00")]
		public Quaternion QKYUHBRSXDL()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1357A00", Offset = "0x1356400", VA = "0x181357A00")]
		public static PseudoCircuitsQuat FKTBZXGPLRW(Quaternion a)
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
		[Cpp2IlInjected.Address(RVA = "0x1D70920", Offset = "0x1D6F320", VA = "0x181D70920")]
		public Vector3 YDUPKBJCJKD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1D70920", Offset = "0x1D6F320", VA = "0x181D70920")]
		public static PseudoCircuitsVec3 FTYCDMIUVXO(Vector3 a)
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
		[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
		public string MGEZFEMFCQJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x10DEEF0", Offset = "0x10DD8F0", VA = "0x1810DEEF0")]
		public static PsuedoCV2RecNetImageWrapper HTSJLFZSULU(string a)
		{
			return default(PsuedoCV2RecNetImageWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class NELJXLQBMYY : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int VEKNTLQXIDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public byte PECELIWJFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int HCVIRNYRRGN;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D460", Offset = "0x3D1BE60", VA = "0x183D1D460", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public NELJXLQBMYY()
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
