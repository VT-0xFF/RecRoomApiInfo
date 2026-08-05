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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DCAHEGJEMAH : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte HMLBDPPEDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public OFKCPCBBNAB JFGFKIAFDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public CIJKFJMOGHC EFACDAOJMFO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C204E0", Offset = "0x3C1EAE0", VA = "0x183C204E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DCAHEGJEMAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PHKNCGEAODL : byte
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
public struct JFPJJFAJAJJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte[] CDDIADBJAOB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3E54150", Offset = "0x3E52750", VA = "0x183E54150", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PEPHBMEJLLK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public short ONEOEAFIEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int KIBPGNDPPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int EGEHJHGMCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public string IOILFNHNIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public string ADPDLDMDHJJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3F8CC10", Offset = "0x3F8B210", VA = "0x183F8CC10", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IHKNGOALPKO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector2 FFDMBCJMMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector2 LLIPKNIEPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Vector2 GHCGGBKGDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Vector2 MACMCPDOIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Vector2 BGAFDJGEHBL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3E20720", Offset = "0x3E1ED20", VA = "0x183E20720", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FHDALEFHKEF : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte BCJGFGJDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public byte LFFOOIADFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int JCBIELMJFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Vector3 LCJCICAHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Quaternion DKBCGKBLKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float HBIPODDMGDL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0190", Offset = "0x3DBE790", VA = "0x183DC0190", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OIDIJHDJMDO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool OGHJMPLLCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 GDEKJEBPHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion JJIKKLJGABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float IHIOJAIDJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool IAFNADLIHFK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D260", Offset = "0x3F7B860", VA = "0x183F7D260", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MMJCIPEOBMI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public string KOPHBHGIACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int PMIGBJGNLLP;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3EDAF30", Offset = "0x3ED9530", VA = "0x183EDAF30", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GFCPAOMDMPN : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public string[] MEPJPLBBNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int OJIPKLIAHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public int MNEKAANLKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool BELDAHDDDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool LAMOPPNLOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool EHGAKGFIEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool GJLPPBOBGNE;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9F90", Offset = "0x3DD8590", VA = "0x183DD9F90", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MDINLPHHEIE : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public string NDIENANOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public string NKPKMMDJHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public LAJMFDHOPDI POPECCNLJGN;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBF30", Offset = "0x3ECA530", VA = "0x183ECBF30", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DEICMDNBGDC : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool PIAPNNBENJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public DIGAFHBKOAE PGEPJKBFLOM;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C23970", Offset = "0x3C21F70", VA = "0x183C23970", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct DIGAFHBKOAE : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum ENEPBDFKJMG : byte
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
	public ENEPBDFKJMG BPDGBDDMPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public ulong OIFMJLAHCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public ulong DMKHMGNEBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public EKAAHKPONCN[] HIDALADGNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public LAJMFDHOPDI OPCLNAABOAB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C390", Offset = "0x3C2A990", VA = "0x183C2C390", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EKAAHKPONCN : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Flags]
	public enum IHDEJPPAHIB : byte
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
	public IHDEJPPAHIB BPDGBDDMPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public ulong NCJELIFCHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public string NDIENANOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int NODOENPBIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public string NKPKMMDJHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public LAJMFDHOPDI ICEIHADNEMG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C60FA0", Offset = "0x3C5F5A0", VA = "0x183C60FA0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PAPGABEPMAP : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public ulong OBDLNJMDMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public DIGAFHBKOAE LAHNGHHAHLK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3F8A2B0", Offset = "0x3F888B0", VA = "0x183F8A2B0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LAJMFDHOPDI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Dictionary<object, object> CECIKJNPCJO;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3420", Offset = "0x3EB1A20", VA = "0x183EB3420", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class INOIEIDBDJK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum ILCBAKENHGK : byte
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
	private delegate void OJOALPIDBEE(object CDDIADBJAOB, FastBufferWriter CKPHLHCIFLA);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private delegate object CHKJMLLDAJI(FastBufferReader KLIAOPJFDOK);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AFOLFKIPMPK<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public ILCBAKENHGK serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AFOLFKIPMPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x540D230", Offset = "0x540B830", VA = "0x18540D230")]
		internal void BMIJPIBIDMC(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x540DDD0", Offset = "0x540C3D0", VA = "0x18540DDD0")]
		internal object HHODMMFGHNG(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KGKDEFIEHLO<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ILCBAKENHGK serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KGKDEFIEHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x55EA0D0", Offset = "0x55E86D0", VA = "0x1855EA0D0")]
		internal void IFHOPCAFGFI(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x55E96E0", Offset = "0x55E7CE0", VA = "0x1855E96E0")]
		internal object GNNOHIOLBDE(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, ILCBAKENHGK> IIIAGMDPNFA;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Dictionary<ILCBAKENHGK, Type> KMAHECNHKIG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Dictionary<ILCBAKENHGK, OJOALPIDBEE> JLMCGEEIILD;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<ILCBAKENHGK, CHKJMLLDAJI> DDBALLPAANN;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Dictionary<ILCBAKENHGK, ILCBAKENHGK> JINGGDJOGEP;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly Dictionary<ILCBAKENHGK, Type> OPDNPAJODHC;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x864ED50", Offset = "0x864D350", VA = "0x18864ED50")]
	static INOIEIDBDJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x864E140", Offset = "0x864C740", VA = "0x18864E140")]
	public static void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8649CE0", Offset = "0x86482E0", VA = "0x188649CE0")]
	public static void ANHNANMIGBP(object CDDIADBJAOB, FastBufferWriter CKPHLHCIFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x864E490", Offset = "0x864CA90", VA = "0x18864E490")]
	public static object LPNJIHLFELG(FastBufferReader KLIAOPJFDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3E2B670", Offset = "0x3E29C70", VA = "0x183E2B670")]
	public static void NAKAILKBDMN<TType, TNetworkType>(ILCBAKENHGK HHEBLMHCIJP, Func<TType, TNetworkType> AINMEBKIDBB, Func<TNetworkType, TType> LJIJLDKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E27F80", Offset = "0x3E26580", VA = "0x183E27F80")]
	private static void HELLFLCEJEO<TType, TNetworkType>(ILCBAKENHGK HHEBLMHCIJP, Func<TType, TNetworkType> AINMEBKIDBB, Func<TNetworkType, TType> LJIJLDKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x864E9B0", Offset = "0x864CFB0", VA = "0x18864E9B0")]
	private static void NAKAILKBDMN(Type GPEIAHGICNA, ILCBAKENHGK HHEBLMHCIJP, OJOALPIDBEE HDHFEGACKHC, CHKJMLLDAJI NFIEEDHCMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x864AE70", Offset = "0x8649470", VA = "0x18864AE70")]
	private static void CPIKADMNFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E2F8B0", Offset = "0x3E2DEB0", VA = "0x183E2F8B0")]
	private static void PPKKEHDIAEB<T>(ILCBAKENHGK HHEBLMHCIJP) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D330", Offset = "0x3E2B930", VA = "0x183E2D330")]
	private static void OBGCMBCJJJA<T, T>(ILCBAKENHGK HHEBLMHCIJP) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E293C0", Offset = "0x3E279C0", VA = "0x183E293C0")]
	private static void JIDCJCPKPBG<T, T>(ILCBAKENHGK HHEBLMHCIJP) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x864A6C0", Offset = "0x8648CC0", VA = "0x18864A6C0")]
	private static void CFNPBLMNECE(object KOPHBHGIACG, Type NJLCGBCMDCE, FastBufferWriter CKPHLHCIFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x864E870", Offset = "0x864CE70", VA = "0x18864E870")]
	private static object MHIKIAJAEID(FastBufferReader KLIAOPJFDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x864AD30", Offset = "0x8649330", VA = "0x18864AD30")]
	private static object COPICFABBEE(FastBufferReader KLIAOPJFDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x864A290", Offset = "0x8648890", VA = "0x18864A290")]
	private static object BGAEBFNLJDB(FastBufferReader KLIAOPJFDOK, Func<Type, int, IList> PKDIGOJFFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3E275C0", Offset = "0x3E25BC0", VA = "0x183E275C0")]
	public static void ACJFGPFBHBG<T, TKey, TValue>(object KOPHBHGIACG, FastBufferWriter CKPHLHCIFLA) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E27B60", Offset = "0x3E26160", VA = "0x183E27B60")]
	public static object DPDEIMLLCOH<T, TKey, TValue>(FastBufferReader KLIAOPJFDOK) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8649BA0", Offset = "0x86481A0", VA = "0x188649BA0")]
	private static void ALIELBOKJHD(object KOPHBHGIACG, FastBufferWriter CKPHLHCIFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x864E3D0", Offset = "0x864C9D0", VA = "0x18864E3D0")]
	private static object LAINJHDMEGA(FastBufferReader KLIAOPJFDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x864E2B0", Offset = "0x864C8B0", VA = "0x18864E2B0")]
	private static object JINAFJEAFEB(FastBufferReader KLIAOPJFDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x864DDF0", Offset = "0x864C3F0", VA = "0x18864DDF0")]
	private static void JANOMCDFOOD(object CAOLIPOOLHD, FastBufferWriter CKPHLHCIFLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NHOKMCPMOJE : byte
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
public enum DIAEAGCMBLG : byte
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
public enum OFKCPCBBNAB : byte
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
public static class NPJKAMNKDHC
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x864F040", Offset = "0x864D640", VA = "0x18864F040")]
	public static NetworkDelivery PPALENAKIIK(this OFKCPCBBNAB FPFOMDIHBKG)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum JNFCMDLKPFG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	All,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CIJKFJMOGHC : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static readonly CIJKFJMOGHC DKABDBMACEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public DIAEAGCMBLG AFHOCPMLAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte COFKIJNDKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public int[] KGAOEEGKHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public JNFCMDLKPFG NHLNDJDIHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte DDEHEGFKJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public DDIFDFMCMNN PODDMBBDFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public int DKNMKGJGMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public object KGHCIONOFHO;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE760", Offset = "0x3BDCD60", VA = "0x183BDE760", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8649AB0", Offset = "0x86480B0", VA = "0x188649AB0")]
	public CIJKFJMOGHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DDIFDFMCMNN
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly DDIFDFMCMNN DKABDBMACEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte IMIIJICMOPE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public const byte CJNGMHJHHCH = 1;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public const byte DFAFBKMMIEA = 2;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public const byte CCFINHLPCPI = 4;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public const byte PKHGJBCBCGD = 8;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xD67760", Offset = "0xD65D60", VA = "0x180D67760")]
	public DDIFDFMCMNN(byte DMEBGOOOAEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LGAJCCGEJAG : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x864EFF0", Offset = "0x864D5F0", VA = "0x18864EFF0")]
	public LGAJCCGEJAG(IDictionary<object, object> LLNAAJAADDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum DCJCBBDPGNI
{

}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum JGKAACIPOKI : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct LIJPDEKDGIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float GBNAKFLHCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float ODEKEFJCIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float CNCKLOHMBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public float KCJIIGKAPGH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x134DC00", Offset = "0x134C200", VA = "0x18134DC00")]
	public Quaternion CPMOFMOIKPP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x134DC00", Offset = "0x134C200", VA = "0x18134DC00")]
	public static LIJPDEKDGIM ILKJOPGHIMD(Quaternion IMEJDEHIFOF)
	{
		return default(LIJPDEKDGIM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct BGPOMPCOOCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float GBNAKFLHCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float ODEKEFJCIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public float CNCKLOHMBJK;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C540", Offset = "0x1D6AB40", VA = "0x181D6C540")]
	public Vector3 GJGCLMLBOJF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C540", Offset = "0x1D6AB40", VA = "0x181D6C540")]
	public static BGPOMPCOOCN EGKFGDKOEFC(Vector3 EEAAMJNCGFH)
	{
		return default(BGPOMPCOOCN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct AHMAMEGBENN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public string IPHPNMCAICN;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
	public string JFNBCPLLACI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x14B91A0", Offset = "0x14B77A0", VA = "0x1814B91A0")]
	public static AHMAMEGBENN BALGHPGBDEP(string GKBEIEANHKN)
	{
		return default(AHMAMEGBENN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LKDLAEOFGDK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public int CAJEHHIJFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte HMLBDPPEDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int FGDJOPOONMN;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3EBAC70", Offset = "0x3EB9270", VA = "0x183EBAC70", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> CLMFOECLAFP) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LKDLAEOFGDK()
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
