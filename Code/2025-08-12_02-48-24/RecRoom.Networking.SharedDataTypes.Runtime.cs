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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PONNCGLKLOI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte NPHNNCCKHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public JHMEBNDKBLP CGGOCMAJGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public CHACOCKEPKK IDKAAADHAGO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F2D0", Offset = "0x3F6D8D0", VA = "0x183F6F2D0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public PONNCGLKLOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DNHDGLKNEJA : byte
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
public enum OMJLOBHDODH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	VoiceInput,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Emote
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NKHNFCJCMAJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public OMJLOBHDODH GNNJIEAEGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public byte[] DAJAOHIJHHL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3F184E0", Offset = "0x3F16AE0", VA = "0x183F184E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct ADAPBJBFEMI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public Vector2 KOPJEFOFJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector2 DNEBBHPOLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector2 CBHFMEHDEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Vector2 KBFKOGKJBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Vector2 BIIOBMPKNCD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32A5040", Offset = "0x32A3640", VA = "0x1832A5040", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EBFJFCAJNDK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public byte OLFKAENJPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte NNOFCOMDBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int KBEDHBMNMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Vector3 LHFBMPAOFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Quaternion IOLHEIDKEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float IOLFBIAGGHE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C07080", Offset = "0x3C05680", VA = "0x183C07080", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NENFCPOFKPB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool GEJHLIJMIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector3 AEDFHMKGLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Quaternion IOCPNAEAJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float OKDCHLACJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public bool MMDFGDCEEJH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3F0CA70", Offset = "0x3F0B070", VA = "0x183F0CA70", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct ELDFMIACKAG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string FKMNCAKIOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int LEPAEEGOBDO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C11860", Offset = "0x3C0FE60", VA = "0x183C11860", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EDGNKAALKBK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public string[] JOOLCNPHDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int DECHJLPPHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int JPPGPCMJFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool JJDKOALABGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool ILGPOHOAFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool ECDIKDBOIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool ONGCLAJECLH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C08D20", Offset = "0x3C07320", VA = "0x183C08D20", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JFDBBHJALLJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public string DJFMCHMDHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public string BPLGLOFHDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IMNJCEOHFPA GNFOAHJDCOF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E34A60", Offset = "0x3E33060", VA = "0x183E34A60", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MCIFDBJFBHL : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool DBIJHINPEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public OHHCCJHOCGC CPLJEEOPGOB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E9AD70", Offset = "0x3E99370", VA = "0x183E9AD70", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct OHHCCJHOCGC : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum CNCIAHPAIGO : byte
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
	public CNCIAHPAIGO GMHHNOIDECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public ulong JEEHOKCHIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public ulong DNCHIOILIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GAEFICFDNAP[] BDOGEKFMNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public IMNJCEOHFPA BLMOCKDKKGO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F51790", Offset = "0x3F4FD90", VA = "0x183F51790", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GAEFICFDNAP : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Flags]
	public enum PLACKOGKGBG : byte
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
	public PLACKOGKGBG GMHHNOIDECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public ulong AFJLFPJABFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string DJFMCHMDHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int PPFHIIIBKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public string BPLGLOFHDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IMNJCEOHFPA LPALMIEHHEP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3D973E0", Offset = "0x3D959E0", VA = "0x183D973E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LPJJPFPFAPM : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public ulong JPAFCELCPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public OHHCCJHOCGC EBHOEJMNOHM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E8ACC0", Offset = "0x3E892C0", VA = "0x183E8ACC0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IMNJCEOHFPA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Dictionary<object, object> FAGODIAEODP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3E15810", Offset = "0x3E13E10", VA = "0x183E15810", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DJCLEILAFDN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum BADGCHECKLF : byte
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
		BroadcastData,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		CV2RecNetImageWrapper
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private delegate void AJFBKANBLOE(object DAJAOHIJHHL, FastBufferWriter ENKMBIEHHDM);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private delegate object MIMOFKKNIBC(FastBufferReader EMPLJNKCONI);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GAMAAAKPKEJ<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public BADGCHECKLF serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GAMAAAKPKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4FD29A0", Offset = "0x4FD0FA0", VA = "0x184FD29A0")]
		internal void PEMKLHGIIJL(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4FD26A0", Offset = "0x4FD0CA0", VA = "0x184FD26A0")]
		internal object OPMPLIOKGEJ(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EJEIFOCGHGI<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public BADGCHECKLF serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EJEIFOCGHGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4A83460", Offset = "0x4A81A60", VA = "0x184A83460")]
		internal void OHPPLAKLPLK(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4A82ED0", Offset = "0x4A814D0", VA = "0x184A82ED0")]
		internal object IHEFEALMKFP(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly Dictionary<Type, BADGCHECKLF> FCEBNNBNKKO;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<BADGCHECKLF, Type> PGPGAOIIKFF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Dictionary<BADGCHECKLF, AJFBKANBLOE> PDFOHNHOLOI;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Dictionary<BADGCHECKLF, MIMOFKKNIBC> CJFJLLHEGBP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<BADGCHECKLF, BADGCHECKLF> HMCDBICLKNG;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Dictionary<BADGCHECKLF, Type> PICCJBJJIAG;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85AF8E0", Offset = "0x85ADEE0", VA = "0x1885AF8E0")]
	static DJCLEILAFDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85AB990", Offset = "0x85A9F90", VA = "0x1885AB990")]
	public static void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85AADA0", Offset = "0x85A93A0", VA = "0x1885AADA0")]
	public static void CAELEDFILEL(object DAJAOHIJHHL, FastBufferWriter ENKMBIEHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85AF3E0", Offset = "0x85AD9E0", VA = "0x1885AF3E0")]
	public static object KJBCLIOBDIC(FastBufferReader EMPLJNKCONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0170", Offset = "0x3BDE770", VA = "0x183BE0170")]
	public static void IPPAKHPFJFF<TType, TNetworkType>(BADGCHECKLF EBKDIIAMLAD, Func<TType, TNetworkType> IFIOFCHJBJH, Func<TNetworkType, TType> IFBIPFBLMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BE23D0", Offset = "0x3BE09D0", VA = "0x183BE23D0")]
	private static void LDCHJFLMFAE<TType, TNetworkType>(BADGCHECKLF EBKDIIAMLAD, Func<TType, TNetworkType> IFIOFCHJBJH, Func<TNetworkType, TType> IFBIPFBLMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85ABE50", Offset = "0x85AA450", VA = "0x1885ABE50")]
	private static void IPPAKHPFJFF(Type EHLAHNIAPLD, BADGCHECKLF EBKDIIAMLAD, AJFBKANBLOE BNOOJMIBCJD, MIMOFKKNIBC JEDCNKGCKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85AC1F0", Offset = "0x85AA7F0", VA = "0x1885AC1F0")]
	private static void JCMGBHHEOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBEC0", Offset = "0x3BDA4C0", VA = "0x183BDBEC0")]
	private static void CGCPKFPMHJG<T>(BADGCHECKLF EBKDIIAMLAD) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD7C0", Offset = "0x3BDBDC0", VA = "0x183BDD7C0")]
	private static void FGBAIOMBEIL<T, T>(BADGCHECKLF EBKDIIAMLAD) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD9C60", Offset = "0x3BD8260", VA = "0x183BD9C60")]
	private static void CCEDPFCPGDG<T, T>(BADGCHECKLF EBKDIIAMLAD) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85AA750", Offset = "0x85A8D50", VA = "0x1885AA750")]
	private static void BGKPOIOMAMH(object FKMNCAKIOFK, Type MCCNLLIKKME, FastBufferWriter ENKMBIEHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85AF160", Offset = "0x85AD760", VA = "0x1885AF160")]
	private static object JJEGIOHENIA(FastBufferReader EMPLJNKCONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85AF2A0", Offset = "0x85AD8A0", VA = "0x1885AF2A0")]
	private static object JNKDNHKAGDL(FastBufferReader EMPLJNKCONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85AB410", Offset = "0x85A9A10", VA = "0x1885AB410")]
	private static object EFHJAOKOLDB(FastBufferReader EMPLJNKCONI, Func<Type, int, IList> ADHHBCIGKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1E30", Offset = "0x3BE0430", VA = "0x183BE1E30")]
	public static void JPOEKIFHFON<T, TKey, TValue>(object FKMNCAKIOFK, FastBufferWriter ENKMBIEHHDM) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3BDFD40", Offset = "0x3BDE340", VA = "0x183BDFD40")]
	public static object IMPPBMJFBEM<T, TKey, TValue>(FastBufferReader EMPLJNKCONI) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x85AB840", Offset = "0x85A9E40", VA = "0x1885AB840")]
	private static void FDKPNHBOOBN(object FKMNCAKIOFK, FastBufferWriter ENKMBIEHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x85AB350", Offset = "0x85A9950", VA = "0x1885AB350")]
	private static object EALBCKPIBEC(FastBufferReader EMPLJNKCONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85AF7C0", Offset = "0x85ADDC0", VA = "0x1885AF7C0")]
	private static object OKJAFLLPPPA(FastBufferReader EMPLJNKCONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85ABB00", Offset = "0x85AA100", VA = "0x1885ABB00")]
	private static void IOAHKPGANMJ(object BIHMAKMFGAM, FastBufferWriter ENKMBIEHHDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum ICEAPJCMCDK : byte
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
public enum DIFLOFIPONG : byte
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
public enum JHMEBNDKBLP : byte
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
public static class CCFKHOCFPAI
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x85AA530", Offset = "0x85A8B30", VA = "0x1885AA530")]
	public static NetworkDelivery NOHAPBAADEO(this JHMEBNDKBLP IBMKCMANABA)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum OBAKMALAJPE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	All,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CHACOCKEPKK : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly CHACOCKEPKK COLNIIHALMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public DIFLOFIPONG IDLCDHEAJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte EMHHPLOCGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public int[] PCOEJHKEBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public OBAKMALAJPE CACLBLPAOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte JKDIFIMICBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public DNALNLJFLKF BFLFFCKFOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public int EEBIIBCAHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public object JCFLPLJDCLH;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3B84320", Offset = "0x3B82920", VA = "0x183B84320", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x85AA6E0", Offset = "0x85A8CE0", VA = "0x1885AA6E0")]
	public CHACOCKEPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DNALNLJFLKF
{
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static readonly DNALNLJFLKF COLNIIHALMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte MBLKGNLBPJG;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public const byte CJAKCOAHOLM = 1;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public const byte BLAGCLIEIKI = 2;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public const byte PEOEJIEPAPB = 4;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public const byte IGFILOLIDHD = 8;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD41060", Offset = "0xD3F660", VA = "0x180D41060")]
	public DNALNLJFLKF(byte MEEAJHANFII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LFNPLCNHICO : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x85AFC00", Offset = "0x85AE200", VA = "0x1885AFC00")]
	public LFNPLCNHICO(IDictionary<object, object> KMJJPAEMNAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum JEKDILCKEEM
{

}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum IAABAEIKEJM : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct BLCMDBEPMNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public float POMPNNDHCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public float JLAHKMCOIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float GFIJDJGEMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float EDHBJBGECMO;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x13218D0", Offset = "0x131FED0", VA = "0x1813218D0")]
	public Quaternion GHBGICOMIFN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x13218D0", Offset = "0x131FED0", VA = "0x1813218D0")]
	public static BLCMDBEPMNM ENMJFAAPPPB(Quaternion ODOMLFJMHPJ)
	{
		return default(BLCMDBEPMNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct ILKECBIDEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float POMPNNDHCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public float JLAHKMCOIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float GFIJDJGEMLL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6C40", Offset = "0x1CE5240", VA = "0x181CE6C40")]
	public Vector3 IOFGDOLFJBB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6C40", Offset = "0x1CE5240", VA = "0x181CE6C40")]
	public static ILKECBIDEDF FHIEBOEHOCN(Vector3 HBEFPIDCACJ)
	{
		return default(ILKECBIDEDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct LPBLBLGDLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public string IFCAGKLINAN;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
	public string IOLFLHEMCGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1485C10", Offset = "0x1484210", VA = "0x181485C10")]
	public static LPBLBLGDLDI BINFBEBMMKA(string HCNDMPDFLKD)
	{
		return default(LPBLBLGDLDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NGILDCFCPCC : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public int HBAPKPNGAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public byte NPHNNCCKHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public int IHOGNOIAEPP;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3F12D20", Offset = "0x3F11320", VA = "0x183F12D20", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KLAOHOGIDJA) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NGILDCFCPCC()
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
