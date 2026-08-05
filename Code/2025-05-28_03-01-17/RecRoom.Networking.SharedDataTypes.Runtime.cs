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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JBGCDNJHNIL : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte MBAEHNCHIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public LADNPKPOAGM JJDOHGCHDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public EEKDOOHAAOB OMKEIHJAAPE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3983740", Offset = "0x3982540", VA = "0x183983740", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JBGCDNJHNIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PDFODABGHNA : byte
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
	RR_NetworkSynchronization = 27,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RR_NetworkInstantiate = 28,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	RR_BulkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	DO_NOT_USE = 30,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	RR_Destroy = 31,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	RR_BulkDestroy = 32,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	RR_TransferOwnership = 33,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	RR_OwnershipUpdate = 34,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	RR_RPC = 35,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	RR_Leave = 106
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GJCFDPPADNA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Vector2 MOHNDIPBIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Vector2 INDAEFCDJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector2 EICGFDLIFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector2 HMNEHPFFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Vector2 LHNGCFCHNOO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3906A30", Offset = "0x3905830", VA = "0x183906A30", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KIPMLKCIEOH : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public byte BKEDAFAAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte FLEIJCCDEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int EMPDJGGGCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Vector3 PFHHEPHFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Quaternion ODLAIJALNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float BAMFJBEJEBO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39D6FD0", Offset = "0x39D5DD0", VA = "0x1839D6FD0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PLHDMONKAHJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool KOGHOOICGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector3 IMPLDPKOJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Quaternion MEPKHADFMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float GJEGAGBEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool HELLFIOEGFD;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B205E0", Offset = "0x3B1F3E0", VA = "0x183B205E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NGILLBFJBPK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public string OAIIHELJHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int GLAOLHCPLLG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8A50", Offset = "0x3AA7850", VA = "0x183AA8A50", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CHDPGLFIFHC : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string[] JNCLHLKFFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int HLJCDCFCCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int HMCELLELIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool LFHCOFNNOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool IDOIEOCANJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool PEFDDLGIKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool NGEIKKDMCEO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x370B770", Offset = "0x370A570", VA = "0x18370B770", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HHGMEPKIOAC : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public string IHGFMOMOADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string IGCBLBHFHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public BBPFGDAAJCA FLNDMNOAAOG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x391EE10", Offset = "0x391DC10", VA = "0x18391EE10", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DBCCBDGONOL : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool LGKACBKCCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public KIMLEDBMBPM MLFFBNNKHKH;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3753140", Offset = "0x3751F40", VA = "0x183753140", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KIMLEDBMBPM : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum LIELEDKMFGM : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		MasterClient = 1,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Players = 2,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Properties = 4,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PreviousMasterClient = 8,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		MasterClientChange = 9
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public LIELEDKMFGM GPENNOEBAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public ulong FHLACDFMOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ulong NAINEIGGELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NNCLHMJNLHK[] LDEBMHMKINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public BBPFGDAAJCA EOBGKFJJJLB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x39D6DC0", Offset = "0x39D5BC0", VA = "0x1839D6DC0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NNCLHMJNLHK : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum NCBJJIBGNJH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Name = 1,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		AccountId = 2,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PlatformId = 4,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Properties = 8,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		All = 0xF
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NCBJJIBGNJH GPENNOEBAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public ulong EMKNGKOPAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public string IHGFMOMOADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int OEBMJHLGKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public string IGCBLBHFHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public BBPFGDAAJCA AJOEANDKGPP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA390", Offset = "0x3AC9190", VA = "0x183ACA390", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EJKOPFOBPGE : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public ulong AHPHCFNAAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public KIMLEDBMBPM KDEAOODANAB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3777C40", Offset = "0x3776A40", VA = "0x183777C40", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BBPFGDAAJCA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Dictionary<object, object> COJGBJGNJFM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3693910", Offset = "0x3692710", VA = "0x183693910", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GOACHJPKIBN
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum GBPDKBFJGJL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Null,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Object,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		List,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Byte,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		SByte,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Char,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Short,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		UShort,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		UInt,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Long,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		ULong,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Double,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Vector2,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Vector3,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Vector3Int,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Vector4,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Quaternion,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Color32,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		ByteArray,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		SByteArray,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		CharArray,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		ShortArray,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		UShortArray,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		IntArray,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		UIntArray,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		LongArray,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		ULongArray,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		FloatArray,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		DoubleArray,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Vector2Array,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Vector3Array,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Vector3IntArray,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Vector4Array,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		QuaternionArray,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		ColorArray,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Color32Array,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Guid,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		ViewId,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		ObjectNetworkId,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		UncompressedQauternion,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		QuadControlPoint,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		ToolHolderInfo,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		LegacyToolCleanupImplSettingOverrides,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		StringIndexedMapPair,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		ByteReadOnlyMemory,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		ManagedUGCStorefrontData,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		Dictionary,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		PhotonHashtable,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		RoomJoinRequest,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		RoomJoinResponse,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		IntDictionary,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		StringDictionary,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		CircuitsVec3,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		CircuitsQuat
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private delegate void FLJOLFMHCOP(object FFEMKICJPKP, FastBufferWriter KMFJBCLMGLE);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private delegate object GJCFPFBFEIC(FastBufferReader JFLBMHOJFED);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class JLOLHJLCNPO<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public GBPDKBFJGJL serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JLOLHJLCNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1B60", Offset = "0x4FD0960", VA = "0x184FD1B60")]
		internal void BLLBJFJPAIA(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1CD0", Offset = "0x4FD0AD0", VA = "0x184FD1CD0")]
		internal object FMFKJMENPCL(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BNKMEENEJEJ<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public GBPDKBFJGJL serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BNKMEENEJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x61778E0", Offset = "0x61766E0", VA = "0x1861778E0")]
		internal void MEBDFCFAHHM(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6176E70", Offset = "0x6175C70", VA = "0x186176E70")]
		internal object FIPEKACAKEB(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Dictionary<Type, GBPDKBFJGJL> POLMGEMJAGL;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Dictionary<GBPDKBFJGJL, Type> CGNAOJJPMML;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Dictionary<GBPDKBFJGJL, FLJOLFMHCOP> KJEKIMLHOHE;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Dictionary<GBPDKBFJGJL, GJCFPFBFEIC> BLDGNDFAHGP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Dictionary<GBPDKBFJGJL, GBPDKBFJGJL> GFBNIAJMKPG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Dictionary<GBPDKBFJGJL, Type> DLCLAEBALEJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7EE7960", Offset = "0x7EE6760", VA = "0x187EE7960")]
	static GOACHJPKIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7EE5730", Offset = "0x7EE4530", VA = "0x187EE5730")]
	public static void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6890", Offset = "0x7EE5690", VA = "0x187EE6890")]
	public static void KIDMEGDOMCG(object FFEMKICJPKP, FastBufferWriter KMFJBCLMGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6F80", Offset = "0x7EE5D80", VA = "0x187EE6F80")]
	public static object LGDBIGPAFJK(FastBufferReader JFLBMHOJFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39100B0", Offset = "0x390EEB0", VA = "0x1839100B0")]
	public static void OCNLPBEHAFE<TType, TNetworkType>(GBPDKBFJGJL PIOOKGPMLNH, Func<TType, TNetworkType> OLBFGHLPMFC, Func<TNetworkType, TType> KPPBJHPJMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3908D40", Offset = "0x3907B40", VA = "0x183908D40")]
	private static void HEOBBFJEHPH<TType, TNetworkType>(GBPDKBFJGJL PIOOKGPMLNH, Func<TType, TNetworkType> OLBFGHLPMFC, Func<TNetworkType, TType> KPPBJHPJMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7EE7360", Offset = "0x7EE6160", VA = "0x187EE7360")]
	private static void OCNLPBEHAFE(Type AAFMBEEMJAC, GBPDKBFJGJL PIOOKGPMLNH, FLJOLFMHCOP LJHFKGLDJOP, GJCFPFBFEIC OPEELMBGNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7EE2920", Offset = "0x7EE1720", VA = "0x187EE2920")]
	private static void AMJPOCOPHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x390C3F0", Offset = "0x390B1F0", VA = "0x18390C3F0")]
	private static void IGIBAPMELPH<T>(GBPDKBFJGJL PIOOKGPMLNH) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3909E70", Offset = "0x3908C70", VA = "0x183909E70")]
	private static void IDDBJPICKLL<T, T>(GBPDKBFJGJL PIOOKGPMLNH) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x390DE50", Offset = "0x390CC50", VA = "0x18390DE50")]
	private static void LHIIEHLFINO<T, T>(GBPDKBFJGJL PIOOKGPMLNH) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE58A0", Offset = "0x7EE46A0", VA = "0x187EE58A0")]
	private static void CGKDCJODJCF(object OAIIHELJHLG, Type DBCOPINAGKK, FastBufferWriter KMFJBCLMGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE5F10", Offset = "0x7EE4D10", VA = "0x187EE5F10")]
	private static object CMOJFBCFGAD(FastBufferReader JFLBMHOJFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE7820", Offset = "0x7EE6620", VA = "0x187EE7820")]
	private static object OKOIMLAEEHK(FastBufferReader JFLBMHOJFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6050", Offset = "0x7EE4E50", VA = "0x187EE6050")]
	private static object DPFCLOOGKAD(FastBufferReader JFLBMHOJFED, Func<Type, int, IList> IPBPDGOKPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3908760", Offset = "0x3907560", VA = "0x183908760")]
	public static void FPLOELFJPLI<T, TKey, TValue>(object OAIIHELJHLG, FastBufferWriter KMFJBCLMGLE) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x390D9D0", Offset = "0x390C7D0", VA = "0x18390D9D0")]
	public static object JBNNNECJKHH<T, TKey, TValue>(FastBufferReader JFLBMHOJFED) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6E40", Offset = "0x7EE5C40", VA = "0x187EE6E40")]
	private static void KNAEGFNGLDG(object OAIIHELJHLG, FastBufferWriter KMFJBCLMGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6480", Offset = "0x7EE5280", VA = "0x187EE6480")]
	private static object EHGDOMJEAIM(FastBufferReader JFLBMHOJFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EE7700", Offset = "0x7EE6500", VA = "0x187EE7700")]
	private static object OEJHBFCECLP(FastBufferReader JFLBMHOJFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6540", Offset = "0x7EE5340", VA = "0x187EE6540")]
	private static void HDLOLHFOGEF(object OJGHKHPIHDD, FastBufferWriter KMFJBCLMGLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum GFNNCIDMKDA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DoNotCache = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	AddToRoomCacheGlobal = 5,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	RemoveFromRoomCache = 6,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	RemoveFromRoomCacheForActorsLeft = 7
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum LADNPKPOAGM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	UnreliableUnsequenced,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Reliable,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	ReliableUnsequenced
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class IJPHJCEHJIN
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE7C00", Offset = "0x7EE6A00", VA = "0x187EE7C00")]
	public static NetworkDelivery OJLHBNLIDMM(this LADNPKPOAGM IOOKGGHFBDC)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum OBDGHCFNBCK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	All,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EEKDOOHAAOB : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly EEKDOOHAAOB OOIHKAJEMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public GFNNCIDMKDA ODJAGNNGIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte IIJLGGOCBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int[] FFGNOJCAJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public OBDGHCFNBCK JOENPEJAKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte ECMJKCPBKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public MBHFKOMGNKG OFHDAECOOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public int NIFGFOPEBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public object EKLAMEOGDHN;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3776C70", Offset = "0x3775A70", VA = "0x183776C70", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE28B0", Offset = "0x7EE16B0", VA = "0x187EE28B0")]
	public EEKDOOHAAOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MBHFKOMGNKG
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly MBHFKOMGNKG OOIHKAJEMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte JALPJGCGAOB;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const byte GFHMDKCCJCF = 1;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const byte FKCGCBDBELL = 2;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const byte EGEIHPCCPMH = 4;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const byte IDGFOBOJOIH = 8;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xC14920", Offset = "0xC13720", VA = "0x180C14920")]
	public MBHFKOMGNKG(byte MIOHKHDDBKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AIIKCJGJNJJ : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7EE2790", Offset = "0x7EE1590", VA = "0x187EE2790")]
	public AIIKCJGJNJJ(IDictionary<object, object> HLNAGBKDKBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum IGMNBDNBJLO
{

}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum LNLHEBMFCFA : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CHFKLJDPEAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float AJEEBBBAOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float GJPKMHAOJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float ECFKHEFHOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float OHGAFHDMJBG;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1193850", Offset = "0x1192650", VA = "0x181193850")]
	public Quaternion MJGPKODDGGH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1193850", Offset = "0x1192650", VA = "0x181193850")]
	public static CHFKLJDPEAM FAGHELNGHMA(Quaternion OBPEBIFMJHH)
	{
		return default(CHFKLJDPEAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct NIDDOFBFMBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float AJEEBBBAOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float GJPKMHAOJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float ECFKHEFHOMB;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1A5EE10", Offset = "0x1A5DC10", VA = "0x181A5EE10")]
	public Vector3 HMLMBJHGKDP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1A5EE10", Offset = "0x1A5DC10", VA = "0x181A5EE10")]
	public static NIDDOFBFMBH GBEPMEEOOPJ(Vector3 MKILIJAMMDM)
	{
		return default(NIDDOFBFMBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LGJKHNBLPDM : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int MOEIMEDBNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte MBAEHNCHIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public int GEMIKGFHNEG;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x39E9770", Offset = "0x39E8570", VA = "0x1839E9770", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> NLHBNAANHME) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LGJKHNBLPDM()
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
