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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JMIHKPNKCAO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte HBPCGFIFDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public CANGACEEHHC CJMGOJJEPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ACKMCIEAMDG CPJAFEGAABB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D76170", Offset = "0x3D74F70", VA = "0x183D76170", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JMIHKPNKCAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KMINDLMAEAO : byte
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
public enum LCPBCFILJHD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	VoiceInput,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Emote
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct JFGGJIMOAMK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public LCPBCFILJHD OBIGNCNHICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public byte[] KANAIIDGHCH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D69F40", Offset = "0x3D68D40", VA = "0x183D69F40", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NDPHHHJINCO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public Vector2 BOPNBJFLGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector2 NCGLCIPHEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector2 MJNDFDBAKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Vector2 CNONHJNBCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Vector2 OHOHMFAEHLG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3E73190", Offset = "0x3E71F90", VA = "0x183E73190", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FABMDGNHHBA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public byte ELOCBHHJLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte AKIOIOPPIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int IAAFAPENNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Vector3 OBBBPEHENBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Quaternion LAPDLKCLKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float FPMOELKIAAJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9950", Offset = "0x3CD8750", VA = "0x183CD9950", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GDEDMCDOBHH : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool ICKKADNIBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector3 JONEPNABAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Quaternion NIALEBCNBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float MNDABBGPMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public bool BEDEANFILPF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CF47C0", Offset = "0x3CF35C0", VA = "0x183CF47C0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NLOOOLEDNCG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string HGMAIPELJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int JJJJBEGKNIN;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E77A50", Offset = "0x3E76850", VA = "0x183E77A50", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LHDKAPJNLGO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public string[] FNGFCEPILHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int PKBKJDDCDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int BNPAKGOKCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool KPAOCJGLBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool CCKAPDJDEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool HPHHJJMHCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool MLJPMNPOLLA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1C20", Offset = "0x3DC0A20", VA = "0x183DC1C20", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ICDGMMMDNJD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public string PFLDDMDPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public string NAAAHLBNOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public COCNKDNOCBF LDINENILDPL;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D44EB0", Offset = "0x3D43CB0", VA = "0x183D44EB0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct GLCGNLJOLCA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool PNPKBINCNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public HPEJEBFCEAJ OEACCCPPJMI;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D01820", Offset = "0x3D00620", VA = "0x183D01820", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HPEJEBFCEAJ : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum PFNGHIFBPIF : byte
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
	public PFNGHIFBPIF IEGHAAHFIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public ulong PAGHBKLPONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public ulong LIKEAJOOHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public EOOPFPMGBNE[] PJDNCKGNPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public COCNKDNOCBF HCFECFODOOB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E060", Offset = "0x3D2CE60", VA = "0x183D2E060", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EOOPFPMGBNE : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Flags]
	public enum GBICFNFCPOM : byte
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
	public GBICFNFCPOM IEGHAAHFIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public ulong KDPNMEKECKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string PFLDDMDPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int OCHPGIEAOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public string NAAAHLBNOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public COCNKDNOCBF JPHLGLJLHMP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B85B50", Offset = "0x3B84950", VA = "0x183B85B50", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct AFNGKGLDHFL : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public ulong CIINLLLLBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public HPEJEBFCEAJ OOLHLPEPEPM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x32503E0", Offset = "0x324F1E0", VA = "0x1832503E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct COCNKDNOCBF : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Dictionary<object, object> DDHBFJGPDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3B14690", Offset = "0x3B13490", VA = "0x183B14690", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HEJJBHKHOOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum FGBHOLGNFBL : byte
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
	private delegate void AMCNABOBDHP(object KANAIIDGHCH, FastBufferWriter AOOOLDFNADH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private delegate object EPOJGPCIFDO(FastBufferReader CCOEJPOOOPD);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PLFHFIKEMHE<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public FGBHOLGNFBL serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PLFHFIKEMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5C09680", Offset = "0x5C08480", VA = "0x185C09680")]
		internal void JGENHFMNADE(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5C09DC0", Offset = "0x5C08BC0", VA = "0x185C09DC0")]
		internal object OFKMNFJOCGI(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PJKKCGBCBDG<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public FGBHOLGNFBL serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PJKKCGBCBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5C01500", Offset = "0x5C00300", VA = "0x185C01500")]
		internal void DPNJBBLIODO(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5C01F30", Offset = "0x5C00D30", VA = "0x185C01F30")]
		internal object PKHAMGGJGME(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly Dictionary<Type, FGBHOLGNFBL> DDLDEBCEMAE;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<FGBHOLGNFBL, Type> CJMFPBFIELA;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Dictionary<FGBHOLGNFBL, AMCNABOBDHP> PMEGCAIBPEN;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Dictionary<FGBHOLGNFBL, EPOJGPCIFDO> GCMAMPDHHEF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<FGBHOLGNFBL, FGBHOLGNFBL> CGIINKJPFKE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Dictionary<FGBHOLGNFBL, Type> LMHNJJGCIPM;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84D5530", Offset = "0x84D4330", VA = "0x1884D5530")]
	static HEJJBHKHOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x84D44D0", Offset = "0x84D32D0", VA = "0x1884D44D0")]
	public static void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x84D4BC0", Offset = "0x84D39C0", VA = "0x1884D4BC0")]
	public static void OFACCHGGJAP(object KANAIIDGHCH, FastBufferWriter AOOOLDFNADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84D5170", Offset = "0x84D3F70", VA = "0x1884D5170")]
	public static object PPEAGMPJINO(FastBufferReader CCOEJPOOOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D10D90", Offset = "0x3D0FB90", VA = "0x183D10D90")]
	public static void HLGIDDGNLLD<TType, TNetworkType>(FGBHOLGNFBL ENKENIHECEP, Func<TType, TNetworkType> EMKDDDMALOG, Func<TNetworkType, TType> EKIGDHAOKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B6E0", Offset = "0x3D0A4E0", VA = "0x183D0B6E0")]
	private static void BCFFLDAAANB<TType, TNetworkType>(FGBHOLGNFBL ENKENIHECEP, Func<TType, TNetworkType> EMKDDDMALOG, Func<TNetworkType, TType> EKIGDHAOKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84D4150", Offset = "0x84D2F50", VA = "0x1884D4150")]
	private static void HLGIDDGNLLD(Type ADGMECOLKNH, FGBHOLGNFBL ENKENIHECEP, AMCNABOBDHP PLLBFDOHPAF, EPOJGPCIFDO GPNGGAMKEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84D0CE0", Offset = "0x84CFAE0", VA = "0x1884D0CE0")]
	private static void CGLPJCCFEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3D0CAC0", Offset = "0x3D0B8C0", VA = "0x183D0CAC0")]
	private static void BELABHIJKFF<T>(FGBHOLGNFBL ENKENIHECEP) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E8D0", Offset = "0x3D0D6D0", VA = "0x183D0E8D0")]
	private static void EABGIOPNDHE<T, T>(FGBHOLGNFBL ENKENIHECEP) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D12E20", Offset = "0x3D11C20", VA = "0x183D12E20")]
	private static void OANCLEGNCHC<T, T>(FGBHOLGNFBL ENKENIHECEP) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84D39B0", Offset = "0x84D27B0", VA = "0x1884D39B0")]
	private static void EKIIFKOJPMC(object HGMAIPELJHM, Type HKKOEHKPCHM, FastBufferWriter AOOOLDFNADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84D4020", Offset = "0x84D2E20", VA = "0x1884D4020")]
	private static object GEIADDBGOBO(FastBufferReader CCOEJPOOOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84D4620", Offset = "0x84D3420", VA = "0x1884D4620")]
	private static object LENJOCNPKDE(FastBufferReader CCOEJPOOOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84D0770", Offset = "0x84CF570", VA = "0x1884D0770")]
	private static object CEEAOCENBBD(FastBufferReader CCOEJPOOOPD, Func<Type, int, IList> IDHENFKMHDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E340", Offset = "0x3D0D140", VA = "0x183D0E340")]
	public static void BMFHACHMIEE<T, TKey, TValue>(object HGMAIPELJHM, FastBufferWriter AOOOLDFNADH) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D12A00", Offset = "0x3D11800", VA = "0x183D12A00")]
	public static object KANFBINEFHF<T, TKey, TValue>(FastBufferReader CCOEJPOOOPD) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84D0BA0", Offset = "0x84CF9A0", VA = "0x1884D0BA0")]
	private static void CFDMOOBOLIJ(object HGMAIPELJHM, FastBufferWriter AOOOLDFNADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84D06B0", Offset = "0x84CF4B0", VA = "0x1884D06B0")]
	private static object AIEJEKGHPGL(FastBufferReader CCOEJPOOOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84D4750", Offset = "0x84D3550", VA = "0x1884D4750")]
	private static object MGHLBCKNIGF(FastBufferReader CCOEJPOOOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84D4870", Offset = "0x84D3670", VA = "0x1884D4870")]
	private static void MLFHJAPHMAN(object CNLAJIDIBGD, FastBufferWriter AOOOLDFNADH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum ILHIMEBCJKJ : byte
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
public enum GLEJGGGOBBK : byte
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
public enum CANGACEEHHC : byte
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
public static class CKCJEPFBENC
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84D0580", Offset = "0x84CF380", VA = "0x1884D0580")]
	public static NetworkDelivery ONIALKEEKMA(this CANGACEEHHC NJFALMLJKKI)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum KLNCFGICJHD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	All,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ACKMCIEAMDG : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly ACKMCIEAMDG HANIMDCJEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public GLEJGGGOBBK LDBBOMDPFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte HIHPJFLALFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public int[] LENNAKFAPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public KLNCFGICJHD PDHPOGGBKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte GABIGJMAOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public JHIDDOMLIGF GIBDOFHFLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public int OJDNAMEEPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public object BGJIELOELMA;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x32324E0", Offset = "0x32312E0", VA = "0x1832324E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84D0510", Offset = "0x84CF310", VA = "0x1884D0510")]
	public ACKMCIEAMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JHIDDOMLIGF
{
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static readonly JHIDDOMLIGF HANIMDCJEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte CBJKADPLKJI;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public const byte KALBEGAHNPL = 1;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public const byte MIJPODDNDJN = 2;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public const byte EHHJIINGFNJ = 4;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public const byte KHCKEKHMGFG = 8;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD40FA0", Offset = "0xD3FDA0", VA = "0x180D40FA0")]
	public JHIDDOMLIGF(byte NCHGMEDOOBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FHPIJNEACFC : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84D0660", Offset = "0x84CF460", VA = "0x1884D0660")]
	public FHPIJNEACFC(IDictionary<object, object> IMNNEOMDPNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum JGNMKGCKIHE
{

}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum AACADLKEMOF : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct HCCDJIHHPNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public float DBBMOEGPNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public float COFKGIHGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float OONOCAMNEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float GFOPEPPIPGD;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1309510", Offset = "0x1308310", VA = "0x181309510")]
	public Quaternion EGPPGMLPPJG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1309510", Offset = "0x1308310", VA = "0x181309510")]
	public static HCCDJIHHPNA LCFHHFACNIP(Quaternion MBBPLFDPKON)
	{
		return default(HCCDJIHHPNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct DNHDNHGABBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float DBBMOEGPNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public float COFKGIHGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float OONOCAMNEIP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1A50", Offset = "0x1CD0850", VA = "0x181CD1A50")]
	public Vector3 HMACJGIOEBP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1A50", Offset = "0x1CD0850", VA = "0x181CD1A50")]
	public static DNHDNHGABBH FOBPDJJKEEA(Vector3 HKPDNPLBONC)
	{
		return default(DNHDNHGABBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct LKHEJNDBLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public string ECFOLMEBCEO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
	public string BCAOMAFCBPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1487920", Offset = "0x1486720", VA = "0x181487920")]
	public static LKHEJNDBLCD BINEJNPHBJL(string GFOKEGELDEN)
	{
		return default(LKHEJNDBLCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OENEDJHGLIP : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public int NFKDBEEOBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public byte HBPCGFIFDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public int EAFDNJFDBGD;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB05A0", Offset = "0x3EAF3A0", VA = "0x183EB05A0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OJPPMHCIDCJ) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OENEDJHGLIP()
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
