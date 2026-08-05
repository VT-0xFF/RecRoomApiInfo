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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class UDZJAJVDIBL : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte CIYKMMZIDOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public RRNetworkDelivery HSMHTZOQWFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public PZIMWREHPGJ KOILWQHSIBR;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4141EE0", Offset = "0x4140AE0", VA = "0x184141EE0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public UDZJAJVDIBL()
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
		RR_Leave = 106
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct QuadControlPointNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Vector2 northEastCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Vector2 northWestCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Vector2 southWestCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Vector2 southEastCorner;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F0F2E0", Offset = "0x3F0DEE0", VA = "0x183F0F2E0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct ToolHolderInfoNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte holderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public byte equipmentSlotType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int viewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float relativeScale;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x404B990", Offset = "0x404A590", VA = "0x18404B990", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct LegacyToolCleanupImplSettingsOverridesNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public bool dataExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool useDefaultVisualEffects;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3CBBDA0", Offset = "0x3CBA9A0", VA = "0x183CBBDA0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct IndexMapPairNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3C2A9C0", Offset = "0x3C295C0", VA = "0x183C2A9C0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct ManagedUGCStorefrontDataNetworkData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public string[] carousels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int featuredCarouselRowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int featuredCarouselColumnCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public bool isThisRoomStorefront;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool isBackgroundHidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool isSynced;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C0A0", Offset = "0x3D9ACA0", VA = "0x183D9C0A0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct RoomJoinRequest : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public string platformId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public SerializableDictionary PlayerProperties;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2B30", Offset = "0x3FE1730", VA = "0x183FE2B30", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct RoomJoinResponse : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public bool Success;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NetworkedRoomData roomData;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2CB0", Offset = "0x3FE18B0", VA = "0x183FE2CB0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NetworkedRoomData : INetworkSerializable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[Flags]
		public enum RoomDataFields : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			MasterClient = 1,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			Players = 2,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			Properties = 4,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			PreviousMasterClient = 8,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			MasterClientChange = 9
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public RoomDataFields dataFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public ulong masterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public ulong previousMasterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NetworkedPlayerData[] players;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public SerializableDictionary roomProperties;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7170", Offset = "0x3DF5D70", VA = "0x183DF7170", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct NetworkedPlayerData : INetworkSerializable
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[Flags]
		public enum PlayerDataFields : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			Name = 1,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			AccountId = 2,
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			PlatformId = 4,
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			Properties = 8,
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			All = 0xF
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PlayerDataFields dataFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ulong clientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public string platformId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public SerializableDictionary playerProperties;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6ED0", Offset = "0x3DF5AD0", VA = "0x183DF6ED0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct PlayerLeftData : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public ulong leftClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NetworkedRoomData roomDataUpdate;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6020", Offset = "0x3EA4C20", VA = "0x183EA6020", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct SerializableDictionary : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Dictionary<object, object> Value;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3FFB8E0", Offset = "0x3FFA4E0", VA = "0x183FFB8E0", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class NSCTWERZLSH
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum SerializedType : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			Null,
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			Object,
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			Array,
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			List,
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			Bool,
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			Byte,
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			SByte,
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			Char,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			Short,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			UShort,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			Int,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			UInt,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			Long,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			ULong,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			Float,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			Double,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			String,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Vector2,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Vector3,
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			Vector3Int,
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Vector4,
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			Quaternion,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Color,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			Color32,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			ByteArray,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			SByteArray,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			CharArray,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			ShortArray,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			UShortArray,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			IntArray,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			UIntArray,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			LongArray,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			ULongArray,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			FloatArray,
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			DoubleArray,
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			Vector2Array,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			Vector3Array,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Vector3IntArray,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			Vector4Array,
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			QuaternionArray,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			ColorArray,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			Color32Array,
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			Guid,
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			ViewId,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			ObjectNetworkId,
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			UncompressedQauternion,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			QuadControlPoint,
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			ToolHolderInfo,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			LegacyToolCleanupImplSettingOverrides,
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			StringIndexedMapPair,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			ByteReadOnlyMemory,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			ManagedUGCStorefrontData,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			Dictionary,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			PhotonHashtable,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			RoomJoinRequest,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			RoomJoinResponse,
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			IntDictionary,
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			StringDictionary,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			CircuitsVec3,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			CircuitsQuat
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void SerializeMethod(object data, FastBufferWriter writer);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object DeserializeMethod(FastBufferReader reader);

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class JNGAFAARTDL<a, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public SerializedType KOZNZYSFNTK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public Func<a, b> LWCCVIBJJYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public Func<b, a> GKTMFIIRRDG;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public JNGAFAARTDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x567D840", Offset = "0x567C440", VA = "0x18567D840")]
			internal void OJKVCYVOXVG(object a, FastBufferWriter b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x567E090", Offset = "0x567CC90", VA = "0x18567E090")]
			internal object OJQCAFPMHGP(FastBufferReader a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class MLFCHFWCDMY<a, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public SerializedType ANPOFPHDCLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public Func<a, b> LWCCVIBJJYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Func<b, a> GKTMFIIRRDG;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public MLFCHFWCDMY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5EB4660", Offset = "0x5EB3260", VA = "0x185EB4660")]
			internal void DBPZSMCRWDQ(object a, FastBufferWriter b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x5EB55D0", Offset = "0x5EB41D0", VA = "0x185EB55D0")]
			internal object DBVGPSWPFOZ(FastBufferReader a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly Dictionary<Type, SerializedType> YOWAYXJVQDJ;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Dictionary<SerializedType, Type> GNLRRSKFIMB;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly Dictionary<SerializedType, SerializeMethod> DHZYCMUKDXR;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly Dictionary<SerializedType, DeserializeMethod> VWGLQHJBBIW;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Dictionary<SerializedType, SerializedType> ZQWPEDNHGVN;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly Dictionary<SerializedType, Type> XAVNKENFSLH;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B5FDA0", Offset = "0x8B5E9A0", VA = "0x188B5FDA0")]
		static NSCTWERZLSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E750", Offset = "0x8B5D350", VA = "0x188B5E750")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8B5EC20", Offset = "0x8B5D820", VA = "0x188B5EC20")]
		public static void Serialize(object data, FastBufferWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B5DCB0", Offset = "0x8B5C8B0", VA = "0x188B5DCB0")]
		public static object Deserialize(FastBufferReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF240", Offset = "0x3DBDE40", VA = "0x183DBF240")]
		public static void GAYOWDFDBFK<a, b>(SerializedType a, Func<a, b> b, Func<b, a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0330", Offset = "0x3DBEF30", VA = "0x183DC0330")]
		private static void IJKTPIGZMKC<c, d>(SerializedType a, Func<c, d> b, Func<d, c> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E080", Offset = "0x8B5CC80", VA = "0x188B5E080")]
		private static void GAYOWDFDBFK(Type a, SerializedType b, SerializeMethod c, DeserializeMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B5A690", Offset = "0x8B59290", VA = "0x188B5A690")]
		private static void AQQAXHIVULZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFD00", Offset = "0x3DBE900", VA = "0x183DBFD00")]
		private static void WTAXPSQXQBH<e>(SerializedType a) where e : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFD00", Offset = "0x3DBE900", VA = "0x183DBFD00")]
		private static void KOWAQFBFMHT<T, T>(SerializedType a) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFD00", Offset = "0x3DBE900", VA = "0x183DBFD00")]
		private static void HQGCHNWYLEG<T, T>(SerializedType a) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5F1F0", Offset = "0x8B5DDF0", VA = "0x188B5F1F0")]
		private static void VGCNTCMGKQY(object a, Type b, FastBufferWriter c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E560", Offset = "0x8B5D160", VA = "0x188B5E560")]
		private static object LGUSWEJFQWJ(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5FC70", Offset = "0x8B5E870", VA = "0x188B5FC70")]
		private static object ZGEQZYOXLYU(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5F840", Offset = "0x8B5E440", VA = "0x188B5F840")]
		private static object WUCZKSRRUPF(FastBufferReader a, Func<Type, int, IList> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DBED40", Offset = "0x3DBD940", VA = "0x183DBED40")]
		public static void CTBFLCDESHD<f, g, h>(object a, FastBufferWriter b) where f : Dictionary<g, h>, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3DC09F0", Offset = "0x3DBF5F0", VA = "0x183DC09F0")]
		public static object UBJPMOQZZHC<i, j, k>(FastBufferReader a) where i : Dictionary<j, k>, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E410", Offset = "0x8B5D010", VA = "0x188B5E410")]
		private static void JKDJLHKQEIQ(object a, FastBufferWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E690", Offset = "0x8B5D290", VA = "0x188B5E690")]
		private static object ODOFKVIWFVH(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8B5DB80", Offset = "0x8B5C780", VA = "0x188B5DB80")]
		private static object DHPVOXLJOOH(FastBufferReader a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E8C0", Offset = "0x8B5D4C0", VA = "0x188B5E8C0")]
		private static void SXVHVLFLWEC(object a, FastBufferWriter b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum RpcCacheOption : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		DoNotCache = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		AddToRoomCache = 4,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		AddToRoomCacheGlobal = 5,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		RemoveFromRoomCache = 6,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		RemoveFromRoomCacheForActorsLeft = 7
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum RRNetworkDelivery : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Unreliable,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		UnreliableUnsequenced,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Reliable,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		ReliableUnsequenced
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class QPVAXGHEHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8B60190", Offset = "0x8B5ED90", VA = "0x188B60190")]
		public static NetworkDelivery PVMTTQULWLU(this RRNetworkDelivery a)
		{
			return default(NetworkDelivery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum RRReceiverGroup : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Others,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		All,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		MasterClient
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class PZIMWREHPGJ : INetworkSerializable
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly PZIMWREHPGJ ERMGBLVPTJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public RpcCacheOption UWKNCKDMREX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public byte QNSVYTRTMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int[] ITTVGEWINUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public RRReceiverGroup HTRLLIJMAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
		public byte LVJARNRFUAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public XLEDZNUATRS PRVLUBWXPRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int ULQIWMUTAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public object PUVMLJQBDCL;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3E15550", Offset = "0x3E14150", VA = "0x183E15550", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8B600D0", Offset = "0x8B5ECD0", VA = "0x188B600D0")]
		public PZIMWREHPGJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class XLEDZNUATRS
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly XLEDZNUATRS ERMGBLVPTJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public byte WRFPYLPKCHT;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public const byte BEWUNJTYKKF = 1;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public const byte TKXFPIEQUPQ = 2;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public const byte FXAYOIMDDKT = 4;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public const byte CQOVDLNFDOT = 8;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xDC26B0", Offset = "0xDC12B0", VA = "0x180DC26B0")]
		public XLEDZNUATRS(byte a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PseudoPhotonHashTable : Dictionary<object, object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8B60140", Offset = "0x8B5ED40", VA = "0x188B60140")]
		public PseudoPhotonHashTable(IDictionary<object, object> dictionary)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum PseudoViewId
	{

	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum PseudoObjectNetworkId : uint
	{

	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct PseudoCircuitsQuat
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float z;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float w;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1414D40", Offset = "0x1413940", VA = "0x181414D40")]
		public Quaternion ABSRTMWHTTK()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1414D40", Offset = "0x1413940", VA = "0x181414D40")]
		public static PseudoCircuitsQuat FKPNTPAFLFX(Quaternion a)
		{
			return default(PseudoCircuitsQuat);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct PseudoCircuitsVec3
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float z;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2034550", Offset = "0x2033150", VA = "0x182034550")]
		public Vector3 OLMCPLYTGVO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2034550", Offset = "0x2033150", VA = "0x182034550")]
		public static PseudoCircuitsVec3 LXQNCSLBMZR(Vector3 a)
		{
			return default(PseudoCircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class UHYAUUUBPGF : INetworkSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int KYUPNQYBRZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public byte CIYKMMZIDOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int DSGWFOJGIFY;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4142370", Offset = "0x4140F70", VA = "0x184142370", Slot = "4")]
		public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public UHYAUUUBPGF()
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
