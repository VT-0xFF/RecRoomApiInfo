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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MLCDGMHGOED : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte KFIKILGMAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public AMEAJDBKGJJ JCLHPGDODDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public OEINLGFEHLC GJCCLLIHDBI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D592C0", Offset = "0x3D57EC0", VA = "0x183D592C0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MLCDGMHGOED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum ONBBBLPBCJA : byte
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
public struct MOFJFGADCMA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Vector2 DDFJOOKJOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector2 DOONHFGELHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector2 NFOCPOAOAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Vector2 MJMLLIGBAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Vector2 FOGFLAPFHDP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D5B880", Offset = "0x3D5A480", VA = "0x183D5B880", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NAADKEJNIGH : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte IJJIHMEOMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public byte KHEJMNPCKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int ECLEFOAKJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Vector3 IDJEELMAACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Quaternion KGEHBNLCJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float EANJNAPLMIO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3DBCBF0", Offset = "0x3DBB7F0", VA = "0x183DBCBF0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct OEIOLIGJGJK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public bool JOIEMNEFAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 COLBAOBOGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion BFDIJLLKGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float GOMONLIGLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool LNEEBHPIOND;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6DC0", Offset = "0x3DF59C0", VA = "0x183DF6DC0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NLEDEOHMAFP : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string BKMPCFIAHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int LCCBBMBENOH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9D10", Offset = "0x3DC8910", VA = "0x183DC9D10", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FKHOENIHOGO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string[] OMPIOCFDGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int KHOMKHFLOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public int AEAHHCHIGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool OCMACEJHIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool EHGOEAEJJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool LIJLDHJAPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool BAOKEHHNGLH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C28E40", Offset = "0x3C27A40", VA = "0x183C28E40", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DAOHBINFAHO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string BKILENEPEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string AGKOEFEPFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public INFFDEAFKLG KJEAHOJIABD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C4B0", Offset = "0x3A7B0B0", VA = "0x183A7C4B0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OJANLOGINIG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool MJOKIILGEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public CBALBJIFOPF NBKNOAMHHFE;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E00C60", Offset = "0x3DFF860", VA = "0x183E00C60", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CBALBJIFOPF : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum CHDFHOJNIAJ : byte
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
	public CHDFHOJNIAJ ILLLKGKIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ulong EHBBMKLJLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ulong EIMMECBNABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public FIGOKPAPAHP[] BJAEPIMLFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public INFFDEAFKLG BDIHOAKFMLA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A306F0", Offset = "0x3A2F2F0", VA = "0x183A306F0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FIGOKPAPAHP : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum PNAHGONCILD : byte
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
	public PNAHGONCILD ILLLKGKIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public ulong DNMDEMHKFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public string BKILENEPEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int IOIEACLIHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public string AGKOEFEPFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public INFFDEAFKLG OGKEDJLCLBJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C27E30", Offset = "0x3C26A30", VA = "0x183C27E30", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NIGACIMDHFM : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public ulong LLHMABFBBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public CBALBJIFOPF BIANANOKKOE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8A60", Offset = "0x3DC7660", VA = "0x183DC8A60", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct INFFDEAFKLG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Dictionary<object, object> AHLMJDKCEID;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CAEC70", Offset = "0x3CAD870", VA = "0x183CAEC70", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JONENKNKKEC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum BAPNIAJKELK : byte
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
	private delegate void DLBNGNPHOHM(object CBCNBAPLLJM, FastBufferWriter HDDCOPOMJML);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private delegate object ILLAHFPIGPD(FastBufferReader NOIAIJBDKGG);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CGJLPEAFJLI<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BAPNIAJKELK serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CGJLPEAFJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6B6B620", Offset = "0x6B6A220", VA = "0x186B6B620")]
		internal void CMHOHBHEDCI(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C030", Offset = "0x6B6AC30", VA = "0x186B6C030")]
		internal object OIPNCNKGBLJ(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EPOEIGBKGPB<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public BAPNIAJKELK serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public EPOEIGBKGPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4903370", Offset = "0x4901F70", VA = "0x184903370")]
		internal void EPENEDOPIHF(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4902C00", Offset = "0x4901800", VA = "0x184902C00")]
		internal object BMGPKAIGOCO(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Dictionary<Type, BAPNIAJKELK> DINGBMPFBKO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Dictionary<BAPNIAJKELK, Type> DMABJGBILEB;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Dictionary<BAPNIAJKELK, DLBNGNPHOHM> NFGALOHFPAK;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Dictionary<BAPNIAJKELK, ILLAHFPIGPD> EPAMHAFJPMC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Dictionary<BAPNIAJKELK, BAPNIAJKELK> OMEGPNHPCAL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Dictionary<BAPNIAJKELK, Type> NKBNOCCHEIB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82490B0", Offset = "0x8247CB0", VA = "0x1882490B0")]
	static JONENKNKKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8248110", Offset = "0x8246D10", VA = "0x188248110")]
	public static void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8248B00", Offset = "0x8247700", VA = "0x188248B00")]
	public static void PBHGMJKEMBG(object CBCNBAPLLJM, FastBufferWriter HDDCOPOMJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8244F20", Offset = "0x8243B20", VA = "0x188244F20")]
	public static object GLDNKJDIMCO(FastBufferReader NOIAIJBDKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3CCFA70", Offset = "0x3CCE670", VA = "0x183CCFA70")]
	public static void BHDGCPNDDLB<TType, TNetworkType>(BAPNIAJKELK AMMMGEJJKKE, Func<TType, TNetworkType> KPLBKCBPBAP, Func<TNetworkType, TType> GHNCPHFGKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3CD68D0", Offset = "0x3CD54D0", VA = "0x183CD68D0")]
	private static void NDAFIENODBD<TType, TNetworkType>(BAPNIAJKELK AMMMGEJJKKE, Func<TType, TNetworkType> KPLBKCBPBAP, Func<TNetworkType, TType> GHNCPHFGKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8244050", Offset = "0x8242C50", VA = "0x188244050")]
	private static void BHDGCPNDDLB(Type MDCDODCGNEK, BAPNIAJKELK AMMMGEJJKKE, DLBNGNPHOHM MGJIICOOFOK, ILLAHFPIGPD PKEGAMEFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8245300", Offset = "0x8243F00", VA = "0x188245300")]
	private static void GMMPCLAICBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CD79B0", Offset = "0x3CD65B0", VA = "0x183CD79B0")]
	private static void NDFALNLJEEJ<T>(BAPNIAJKELK AMMMGEJJKKE) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1CC0", Offset = "0x3CD08C0", VA = "0x183CD1CC0")]
	private static void DIIMOHELBGN<T, T>(BAPNIAJKELK AMMMGEJJKKE) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4670", Offset = "0x3CD3270", VA = "0x183CD4670")]
	private static void MJFNOKNBMIG<T, T>(BAPNIAJKELK AMMMGEJJKKE) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8248280", Offset = "0x8246E80", VA = "0x188248280")]
	private static void IEENNIHGKCE(object BKMPCFIAHIG, Type LDDADBFCAAP, FastBufferWriter HDDCOPOMJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8248900", Offset = "0x8247500", VA = "0x188248900")]
	private static object IGFAICFKLGD(FastBufferReader NOIAIJBDKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82449B0", Offset = "0x82435B0", VA = "0x1882449B0")]
	private static object FCMOPDCOIAE(FastBufferReader NOIAIJBDKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8244AF0", Offset = "0x82436F0", VA = "0x188244AF0")]
	private static object GJPBKOEBEBJ(FastBufferReader NOIAIJBDKGG, Func<Type, int, IList> EABIJIFEHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1730", Offset = "0x3CD0330", VA = "0x183CD1730")]
	public static void CEEDDKJKJPN<T, TKey, TValue>(object BKMPCFIAHIG, FastBufferWriter HDDCOPOMJML) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4240", Offset = "0x3CD2E40", VA = "0x183CD4240")]
	public static object KGGFJCKPHPL<T, TKey, TValue>(FastBufferReader NOIAIJBDKGG) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8244860", Offset = "0x8243460", VA = "0x188244860")]
	private static void DNDOAEDAFME(object BKMPCFIAHIG, FastBufferWriter HDDCOPOMJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8248A40", Offset = "0x8247640", VA = "0x188248A40")]
	private static object MMKCHIGBHBG(FastBufferReader NOIAIJBDKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8244740", Offset = "0x8243340", VA = "0x188244740")]
	private static object CPGIMLEAEEK(FastBufferReader NOIAIJBDKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82443F0", Offset = "0x8242FF0", VA = "0x1882443F0")]
	private static void CIDMMIIOMJK(object NFGNMIBGLMH, FastBufferWriter HDDCOPOMJML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum MOEJDFAPMAA : byte
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
public enum AMEAJDBKGJJ : byte
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
public static class MJCGIJAFKNG
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82493A0", Offset = "0x8247FA0", VA = "0x1882493A0")]
	public static NetworkDelivery HOFKPECNBMF(this AMEAJDBKGJJ EJDEMOBNIHM)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum NDJAPIKMHHC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	All,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OEINLGFEHLC : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly OEINLGFEHLC JOFMPALJJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public MOEJDFAPMAA OCEMLCDKHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte EOKBMMNLIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public int[] OHKGBDFKGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public NDJAPIKMHHC LPPDPEGEMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte LLJHAHBDIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public POPOJCBCLIF NMFGPHGCGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int FIDJDBFCHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public object KOBJMAOMOJA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6B80", Offset = "0x3DF5780", VA = "0x183DF6B80", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8249550", Offset = "0x8248150", VA = "0x188249550")]
	public OEINLGFEHLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class POPOJCBCLIF
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly POPOJCBCLIF JOFMPALJJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public byte JBHNONLKKOK;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const byte EMEKKKGBEJB = 1;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const byte CHBMCLPJNAB = 2;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const byte AMJONCBHCDL = 4;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const byte PNFAPHBDMAD = 8;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xCEBBC0", Offset = "0xCEA7C0", VA = "0x180CEBBC0")]
	public POPOJCBCLIF(byte EDPHAEAOHEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LPMCIIJIIJK : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8249350", Offset = "0x8247F50", VA = "0x188249350")]
	public LPMCIIJIIJK(IDictionary<object, object> ELIABFCDDBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum MDOIIAFDLNB
{

}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum OFAJMBBKPPA : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NMCODMKMFJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float LGCEHLADNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float LFHMHCKODDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float COPINMEDHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float PBIHGFKMLJE;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x12A4870", Offset = "0x12A3470", VA = "0x1812A4870")]
	public Quaternion MAGLCMMFOIN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x12A4870", Offset = "0x12A3470", VA = "0x1812A4870")]
	public static NMCODMKMFJE OHDCLBJOOCG(Quaternion LOMHBMJKKFE)
	{
		return default(NMCODMKMFJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FDMFHMMEMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float LGCEHLADNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float LFHMHCKODDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public float COPINMEDHAK;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1C3D8F0", Offset = "0x1C3C4F0", VA = "0x181C3D8F0")]
	public Vector3 APGBHIPEPFD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1C3D8F0", Offset = "0x1C3C4F0", VA = "0x181C3D8F0")]
	public static FDMFHMMEMDB DICKCMOAKMP(Vector3 HIFGOIHBOBM)
	{
		return default(FDMFHMMEMDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GNPDKGNJCEO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public int JAENEMDKOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte KFIKILGMAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int AJJDBBDHLCL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3C4EFD0", Offset = "0x3C4DBD0", VA = "0x183C4EFD0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> JKAPPJFLKGP) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GNPDKGNJCEO()
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
