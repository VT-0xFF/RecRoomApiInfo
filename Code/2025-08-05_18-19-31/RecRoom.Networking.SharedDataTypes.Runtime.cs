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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IEINCBFBOGB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte LFKPJPJPCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public AJOPFBCEGBG AMPJMEOIFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MIAGGALJIMC LGIGGCPNJEJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE530", Offset = "0x3CFD930", VA = "0x183CFE530", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IEINCBFBOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JPFHMCBEHFB : byte
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
	RR_BroadcastData = 109,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	RR_ScreenShareData = 110
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CFADLGMJFCJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	VoiceInput,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Emote
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct IHOJLNMGENF : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public CFADLGMJFCJ PKFOILGCDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public byte[] NGIAGNLBILI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D22D40", Offset = "0x3D22140", VA = "0x183D22D40", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NBHLIGBLKFN : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public Vector2 GHMCFDBPIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector2 AHKCHGEMMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector2 NPBEBEAKCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Vector2 GPBALCCHCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Vector2 ILAHEHGLBNO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3E57CE0", Offset = "0x3E570E0", VA = "0x183E57CE0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct BBPAJICIFNG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public byte DFCCGMBKCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte KNMPGOPNDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int MIMIGBMDBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Vector3 AMANMLHBFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Quaternion HFAPDOPNNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float HHBLDLLBBJD;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D8F0", Offset = "0x3A3CCF0", VA = "0x183A3D8F0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GFOLJPGEGAG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool DFOJCFJHDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector3 IPGNGMJBFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Quaternion JJPOMEGMBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float GACAILCFNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public bool JJCPGPLEPDG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2720", Offset = "0x3CB1B20", VA = "0x183CB2720", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct ODBJMHBJKLJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string CBMEHPPMEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int NOEININIMIL;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E87210", Offset = "0x3E86610", VA = "0x183E87210", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BIIAFLNPHGD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public string[] DPHHILMGIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int JHHCPIOBMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int PCMIGLPMENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool FMDHHFIEEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool ALPKJACKDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool GJJCDLGLMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool GEPMOIHMKHA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A40A00", Offset = "0x3A3FE00", VA = "0x183A40A00", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MCLCKNLMJLD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public string HDNPPEBJPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public string PGDGCMJHHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public LIKKOBEHHGI KANEKGMPNJN;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5A60", Offset = "0x3DE4E60", VA = "0x183DE5A60", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct GFAJBDOMAIG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool KMAEPPNCJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NFEMCBAJGLJ PHIIDLOGBDN;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1DC0", Offset = "0x3CB11C0", VA = "0x183CB1DC0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NFEMCBAJGLJ : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum MAELDNDHIMD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		MasterClient = 1,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Players = 2,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Properties = 4,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PreviousMasterClient = 8,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		MasterClientChange = 9
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public MAELDNDHIMD LMHIMHALOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public ulong NCJPEMHOJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public ulong MKBCMBEFEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public LKMBAEHBCML[] FLFPKJCGOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public LIKKOBEHHGI NEHBMMDHKIH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AA10", Offset = "0x3E59E10", VA = "0x183E5AA10", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LKMBAEHBCML : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Flags]
	public enum NBHKACNHHCI : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Name = 1,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		AccountId = 2,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		PlatformId = 4,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Properties = 8,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		IsBroadcasted = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		All = 0xF
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public NBHKACNHHCI LMHIMHALOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public ulong ICAMGPAGGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string HDNPPEBJPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int MNAACFOHONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public string PGDGCMJHHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public LIKKOBEHHGI CGNEGIGHOOP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3DC7CC0", Offset = "0x3DC70C0", VA = "0x183DC7CC0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CKBBBPNNMEN : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public ulong HAMJIFDCPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NFEMCBAJGLJ OIEOAGMIHCD;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3AABE30", Offset = "0x3AAB230", VA = "0x183AABE30", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LIKKOBEHHGI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Dictionary<object, object> JCMAOCOGHGO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0520", Offset = "0x3DBF920", VA = "0x183DC0520", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LBBACJNENDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum CBKOFOFANFB : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Null,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Object,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		List,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Byte,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		SByte,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Char,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Short,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		UShort,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		UInt,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Long,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		ULong,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Double,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Vector2,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Vector3,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Vector3Int,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Vector4,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Quaternion,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Color32,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		ByteArray,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		SByteArray,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		CharArray,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		ShortArray,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		UShortArray,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		IntArray,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		UIntArray,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		LongArray,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		ULongArray,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		FloatArray,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		DoubleArray,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Vector2Array,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Vector3Array,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Vector3IntArray,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		Vector4Array,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		QuaternionArray,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		ColorArray,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Color32Array,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Guid,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		ViewId,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		ObjectNetworkId,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		UncompressedQauternion,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		QuadControlPoint,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		ToolHolderInfo,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		LegacyToolCleanupImplSettingOverrides,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		StringIndexedMapPair,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		ByteReadOnlyMemory,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		ManagedUGCStorefrontData,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Dictionary,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		PhotonHashtable,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		RoomJoinRequest,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		RoomJoinResponse,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		IntDictionary,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		StringDictionary,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		CircuitsVec3,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		CircuitsQuat,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		BroadcastData
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private delegate void LKCFMFDEINF(object NGIAGNLBILI, FastBufferWriter HNNLPFDFOLO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private delegate object INFBELLMMFM(FastBufferReader BPCOJLPPMNI);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KEPCJLKFEOC<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CBKOFOFANFB serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KEPCJLKFEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5445290", Offset = "0x5444690", VA = "0x185445290")]
		internal void JBIAAKOMJML(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5445CE0", Offset = "0x54450E0", VA = "0x185445CE0")]
		internal object LCJFKLDBMGA(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IGEKIIPJLEJ<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CBKOFOFANFB serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IGEKIIPJLEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x50CDB70", Offset = "0x50CCF70", VA = "0x1850CDB70")]
		internal void MLPNANHFMGC(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x50CE480", Offset = "0x50CD880", VA = "0x1850CE480")]
		internal object PJHCCNKKDGP(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly Dictionary<Type, CBKOFOFANFB> OIOFMKEKPAA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<CBKOFOFANFB, Type> HNAFBCCHHJL;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Dictionary<CBKOFOFANFB, LKCFMFDEINF> DJDHEOKOIPO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Dictionary<CBKOFOFANFB, INFBELLMMFM> HFIFFBAGJFD;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<CBKOFOFANFB, CBKOFOFANFB> HHAPGKFFPKH;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Dictionary<CBKOFOFANFB, Type> JJEBLNKMFKN;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x83F99F0", Offset = "0x83F8DF0", VA = "0x1883F99F0")]
	static LBBACJNENDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x83F4AC0", Offset = "0x83F3EC0", VA = "0x1883F4AC0")]
	public static void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83F4C30", Offset = "0x83F4030", VA = "0x1883F4C30")]
	public static void COFPFOKABJF(object NGIAGNLBILI, FastBufferWriter HNNLPFDFOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x83F5640", Offset = "0x83F4A40", VA = "0x1883F5640")]
	public static object DGFNGGGAAON(FastBufferReader BPCOJLPPMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D94AC0", Offset = "0x3D93EC0", VA = "0x183D94AC0")]
	public static void DDHPLCEPMDO<TType, TNetworkType>(CBKOFOFANFB LIJMNKLGNJH, Func<TType, TNetworkType> KECOPMIJLAJ, Func<TNetworkType, TType> MGNHHHFCEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D98080", Offset = "0x3D97480", VA = "0x183D98080")]
	private static void EKLMFAJOGNE<TType, TNetworkType>(CBKOFOFANFB LIJMNKLGNJH, Func<TType, TNetworkType> KECOPMIJLAJ, Func<TNetworkType, TType> MGNHHHFCEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x83F52A0", Offset = "0x83F46A0", VA = "0x1883F52A0")]
	private static void DDHPLCEPMDO(Type IIHAKBEOLJD, CBKOFOFANFB LIJMNKLGNJH, LKCFMFDEINF ICPDHLMKEOE, INFBELLMMFM HHDFBJNNBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83F5A20", Offset = "0x83F4E20", VA = "0x1883F5A20")]
	private static void GPHJHHEGCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3D96780", Offset = "0x3D95B80", VA = "0x183D96780")]
	private static void EFEDPIDJBEL<T>(CBKOFOFANFB LIJMNKLGNJH) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D92540", Offset = "0x3D91940", VA = "0x183D92540")]
	private static void BHPCAMOLDLG<T, T>(CBKOFOFANFB LIJMNKLGNJH) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D99160", Offset = "0x3D98560", VA = "0x183D99160")]
	private static void GKLNAALELGE<T, T>(CBKOFOFANFB LIJMNKLGNJH) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83F8C80", Offset = "0x83F8080", VA = "0x1883F8C80")]
	private static void HOKCPIEKFPI(object CBMEHPPMEEA, Type KADLGDIHHBH, FastBufferWriter HNNLPFDFOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83F92D0", Offset = "0x83F86D0", VA = "0x1883F92D0")]
	private static object JNMBMCDLPBN(FastBufferReader BPCOJLPPMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83F9410", Offset = "0x83F8810", VA = "0x1883F9410")]
	private static object LLKCDICCFPC(FastBufferReader BPCOJLPPMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83F8850", Offset = "0x83F7C50", VA = "0x1883F8850")]
	private static object HJNNNCKGJAL(FastBufferReader BPCOJLPPMNI, Func<Type, int, IList> ICOOAKNILLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D9B7F0", Offset = "0x3D9ABF0", VA = "0x183D9B7F0")]
	public static void JCIDAGFNLJJ<T, TKey, TValue>(object CBMEHPPMEEA, FastBufferWriter HNNLPFDFOLO) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D9B3C0", Offset = "0x3D9A7C0", VA = "0x183D9B3C0")]
	public static object ICMHALBMMJN<T, TKey, TValue>(FastBufferReader BPCOJLPPMNI) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83F98A0", Offset = "0x83F8CA0", VA = "0x1883F98A0")]
	private static void NIDHHBHMFAL(object CBMEHPPMEEA, FastBufferWriter HNNLPFDFOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83F51E0", Offset = "0x83F45E0", VA = "0x1883F51E0")]
	private static object DBDKMLJNCMM(FastBufferReader BPCOJLPPMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83F49A0", Offset = "0x83F3DA0", VA = "0x1883F49A0")]
	private static object ABNBAAGOALP(FastBufferReader BPCOJLPPMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x83F9550", Offset = "0x83F8950", VA = "0x1883F9550")]
	private static void LONGDPKFCIH(object EKMAOLGBFIO, FastBufferWriter HNNLPFDFOLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KGGCLGEMPKG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	NetworkTransform,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	PlayerAvatarData,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	FullBodyPuppetData,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	AvatarSkeletonData,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	ControlDeckData,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	RCCarData,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	GroundVehicleData,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	NetworkEnemyHeadRotationData,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	RoomieAIAudio,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	GameAIAudio,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Invalid
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum GJABJKJIDKJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	DoNotCache = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	AddToRoomCacheGlobal = 5,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	RemoveFromRoomCache = 6,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	RemoveFromRoomCacheForActorsLeft = 7
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum AJOPFBCEGBG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	UnreliableUnsequenced,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Reliable,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	ReliableUnsequenced
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class OPJHAJANCKL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x83F9E50", Offset = "0x83F9250", VA = "0x1883F9E50")]
	public static NetworkDelivery CHFHFAODGFB(this AJOPFBCEGBG HACPMHGLCFJ)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum EPJJGMOLIOC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	All,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MIAGGALJIMC : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static readonly MIAGGALJIMC BCIBOEFGOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public GJABJKJIDKJ OMACEOJNLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte GJMEEKGKDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public int[] KFLAENHGKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public EPJJGMOLIOC DGKJHJFLIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte KOEDNKELCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public NAEDAEMKEML DOMALHMDIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public int PMKJMHAABMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public object MKIJLGGKBMH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFF20", Offset = "0x3DEF320", VA = "0x183DEFF20", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x83F9D60", Offset = "0x83F9160", VA = "0x1883F9D60")]
	public MIAGGALJIMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NAEDAEMKEML
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static readonly NAEDAEMKEML BCIBOEFGOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte PMIMFHGPLKD;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public const byte OPAILNCMAOL = 1;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public const byte MAHCCEMKCOO = 2;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public const byte MMECJFDAMNG = 4;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public const byte JAECEGMNKOL = 8;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xD0EFA0", Offset = "0xD0E3A0", VA = "0x180D0EFA0")]
	public NAEDAEMKEML(byte HFNHJIKLGHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HNFBHBCFABK : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x83F4950", Offset = "0x83F3D50", VA = "0x1883F4950")]
	public HNFBHBCFABK(IDictionary<object, object> JAIKDDBMDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum MEKHCLLCHGA
{

}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum KCJLLBIJKFB : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct BFIIOJLIFOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float FNBJHADJBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public float MODFPFNICHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public float CACADFINDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public float DJODONHGGOL;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x12DDF40", Offset = "0x12DD340", VA = "0x1812DDF40")]
	public Quaternion DEIGFACELNE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x12DDF40", Offset = "0x12DD340", VA = "0x1812DDF40")]
	public static BFIIOJLIFOK EOBDOHOJAID(Quaternion CGCLGEMEOLK)
	{
		return default(BFIIOJLIFOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct HMBFFFCIECL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float FNBJHADJBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float MODFPFNICHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float CACADFINDPI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1C94CE0", Offset = "0x1C940E0", VA = "0x181C94CE0")]
	public Vector3 AOGAFCKILOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1C94CE0", Offset = "0x1C940E0", VA = "0x181C94CE0")]
	public static HMBFFFCIECL AKDLMGEAOMN(Vector3 NKNLDACEOCJ)
	{
		return default(HMBFFFCIECL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JPFGCFOEMLH : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public int ACCCBHHEBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public byte LFKPJPJPCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public int OMGCBNLPBEO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3D56720", Offset = "0x3D55B20", VA = "0x183D56720", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> GBOEJHCDIGI) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JPFGCFOEMLH()
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
