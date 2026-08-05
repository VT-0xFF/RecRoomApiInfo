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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DBHMBGCFENL : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte NGKALNGDLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GOEJMBMADBN BBALACFBNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MNMNIMLOHNO HKGFCMDCHFB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x38E2390", Offset = "0x38E0F90", VA = "0x1838E2390", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public DBHMBGCFENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MCEPPJNMHID : byte
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
public struct DOJEDOCHIFJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Vector2 MKJDLLMDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector2 OECOOAOFMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector2 BIALOANFMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Vector2 NCLCOFMOIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Vector2 NHPMLKBCPOA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x38EE320", Offset = "0x38ECF20", VA = "0x1838EE320", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NCGHKOJIEMB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte IOLFFLMNEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public byte BBFANBLFNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int AAHKEEEBFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Vector3 OJMBGNDBNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Quaternion NLIEJICFCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float FIBLAIHIHMP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E870", Offset = "0x3C2D470", VA = "0x183C2E870", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct DJLJAOJBILC : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public bool DNCKBGMCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 MICNLECKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion HNIPNOOHHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float JHIGHKLMENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool FEOLNFELEIC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38E8360", Offset = "0x38E6F60", VA = "0x1838E8360", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PEJMPHLGNIP : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string OOHGFGHCOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int EMMACFPOKFB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C826D0", Offset = "0x3C812D0", VA = "0x183C826D0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DLIFHOBFKCG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string[] CKHDJDJHHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int FOGDJDEBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public int NEMOMEEGKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool KHLCCINEBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool KCNBOLLHFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool BBEABHHBLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool IBLKLEIAHOL;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38EC520", Offset = "0x38EB120", VA = "0x1838EC520", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GJAPECIPLGJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string LAOCJKNALFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string AJABDKOHOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public GFBPNOJAIKF FCHEPHMKFEN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B670", Offset = "0x3A9A270", VA = "0x183A9B670", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BBNJHOJDCFD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool BGFIBGHCIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public HNKJGKKNFDK DEELHKGGHPE;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3831780", Offset = "0x3830380", VA = "0x183831780", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HNKJGKKNFDK : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum ABMMAJJGLAF : byte
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
	public ABMMAJJGLAF IINBMEINACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ulong NELPKNNODID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ulong AGKHCOEFJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public KOAKHAOBAJL[] DMAJIBLHNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public GFBPNOJAIKF GDOMFIPLJGF;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD1D0", Offset = "0x3ABBDD0", VA = "0x183ABD1D0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KOAKHAOBAJL : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum EIDIKFBKMNA : byte
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
	public EIDIKFBKMNA IINBMEINACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public ulong KPGHEBOCEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public string LAOCJKNALFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int LOOPKKAOJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public string AJABDKOHOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public GFBPNOJAIKF IBCFGHABMCD;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CCE0", Offset = "0x3B6B8E0", VA = "0x183B6CCE0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PIEGDGOANGF : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public ulong OGHACEACLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public HNKJGKKNFDK NAHNNAPCFCL;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C851D0", Offset = "0x3C83DD0", VA = "0x183C851D0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GFBPNOJAIKF : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Dictionary<object, object> IOOEMCNJEAH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A878C0", Offset = "0x3A864C0", VA = "0x183A878C0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JLAEBKEIBLO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum AIFKGJINHAK : byte
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
	private delegate void KIMFHMOIJPB(object PEDMEJIDLNB, FastBufferWriter JKKEKKKNJIN);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private delegate object COJDBDJJIIN(FastBufferReader EENAIFHJAJK);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OOHAJBAGAEA<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AIFKGJINHAK serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OOHAJBAGAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x56992A0", Offset = "0x5697EA0", VA = "0x1856992A0")]
		internal void ONEHOJCCHOJ(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5698730", Offset = "0x5697330", VA = "0x185698730")]
		internal object GIICLACCNOD(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GPEMHPEDMHA<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AIFKGJINHAK serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GPEMHPEDMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4D3AA90", Offset = "0x4D39690", VA = "0x184D3AA90")]
		internal void OGJPBPCGGFF(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4D3A4D0", Offset = "0x4D390D0", VA = "0x184D3A4D0")]
		internal object JDIJOCJCBEJ(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Dictionary<Type, AIFKGJINHAK> AJMJOBNIKKB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Dictionary<AIFKGJINHAK, Type> FOFFFNBGOOO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Dictionary<AIFKGJINHAK, KIMFHMOIJPB> FLKABJJAPHM;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Dictionary<AIFKGJINHAK, COJDBDJJIIN> KMHHOPCKEDO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Dictionary<AIFKGJINHAK, AIFKGJINHAK> NKLKBGBFBOJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Dictionary<AIFKGJINHAK, Type> KPJEELCDHIB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F10E20", Offset = "0x7F0FA20", VA = "0x187F10E20")]
	static JLAEBKEIBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F10890", Offset = "0x7F0F490", VA = "0x187F10890")]
	public static void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C210", Offset = "0x7F0AE10", VA = "0x187F0C210")]
	public static void BLPDEIDOFHH(object PEDMEJIDLNB, FastBufferWriter JKKEKKKNJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C7C0", Offset = "0x7F0B3C0", VA = "0x187F0C7C0")]
	public static object EBAGJKMAFHO(FastBufferReader EENAIFHJAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B2E200", Offset = "0x3B2CE00", VA = "0x183B2E200")]
	public static void NLNNIBMFEDE<TType, TNetworkType>(AIFKGJINHAK GKCOMPNHHOE, Func<TType, TNetworkType> NPJFNJANBIJ, Func<TNetworkType, TType> GEFGPIGJAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B2D170", Offset = "0x3B2BD70", VA = "0x183B2D170")]
	private static void NAEMCFKOPKD<TType, TNetworkType>(AIFKGJINHAK GKCOMPNHHOE, Func<TType, TNetworkType> NPJFNJANBIJ, Func<TNetworkType, TType> GEFGPIGJAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F109E0", Offset = "0x7F0F5E0", VA = "0x187F109E0")]
	private static void NLNNIBMFEDE(Type OPOPAMPKKGD, AIFKGJINHAK GKCOMPNHHOE, KIMFHMOIJPB DEJHJBBCEHL, COJDBDJJIIN JNCCAMAMCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F0D7A0", Offset = "0x7F0C3A0", VA = "0x187F0D7A0")]
	private static void LHGMLOINBAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B290A0", Offset = "0x3B27CA0", VA = "0x183B290A0")]
	private static void IOFGPEEHLJG<T>(AIFKGJINHAK GKCOMPNHHOE) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B26BE0", Offset = "0x3B257E0", VA = "0x183B26BE0")]
	private static void DPPFNMBOABN<T, T>(AIFKGJINHAK GKCOMPNHHOE) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B2AA30", Offset = "0x3B29630", VA = "0x183B2AA30")]
	private static void KLCEDJHDPON<T, T>(AIFKGJINHAK GKCOMPNHHOE) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F0CFF0", Offset = "0x7F0BBF0", VA = "0x187F0CFF0")]
	private static void KDMOPFAABAJ(object OOHGFGHCOAJ, Type PBLHCAGNECO, FastBufferWriter JKKEKKKNJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0D670", Offset = "0x7F0C270", VA = "0x187F0D670")]
	private static object KKIFNMOJAGE(FastBufferReader EENAIFHJAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C0E0", Offset = "0x7F0ACE0", VA = "0x187F0C0E0")]
	private static object ACJEOMMCAOP(FastBufferReader EENAIFHJAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F10320", Offset = "0x7F0EF20", VA = "0x187F10320")]
	private static object MHFGCAANICP(FastBufferReader EENAIFHJAJK, Func<Type, int, IList> KDIMDKGFHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B2CBE0", Offset = "0x3B2B7E0", VA = "0x183B2CBE0")]
	public static void LEENDKHLKIE<T, TKey, TValue>(object OOHGFGHCOAJ, FastBufferWriter JKKEKKKNJIN) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B2A610", Offset = "0x3B29210", VA = "0x183B2A610")]
	public static object KGMEFPDALGC<T, TKey, TValue>(FastBufferReader EENAIFHJAJK) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F10750", Offset = "0x7F0F350", VA = "0x187F10750")]
	private static void NEJHPECMJED(object OOHGFGHCOAJ, FastBufferWriter JKKEKKKNJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F10D60", Offset = "0x7F0F960", VA = "0x187F10D60")]
	private static object OMJANMHOPPD(FastBufferReader EENAIFHJAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F0CB80", Offset = "0x7F0B780", VA = "0x187F0CB80")]
	private static object FCGBHOAOIAI(FastBufferReader EENAIFHJAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F0CCA0", Offset = "0x7F0B8A0", VA = "0x187F0CCA0")]
	private static void IMHCJGCADEO(object JCOAOOCLABB, FastBufferWriter JKKEKKKNJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum PAENKPGAGKC : byte
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
public enum GOEJMBMADBN : byte
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
public static class PJPAPELIMLG
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F111D0", Offset = "0x7F0FDD0", VA = "0x187F111D0")]
	public static NetworkDelivery NKNGGEJFKFD(this GOEJMBMADBN JEEHEIIIHJN)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum AKNNOPOIAOI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	All,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MNMNIMLOHNO : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly MNMNIMLOHNO DIACPKGMELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public PAENKPGAGKC KFOOLECOEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte LJKGAFAEBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public int[] LAKKHLDKMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public AKNNOPOIAOI AIJGHDAPHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte GNDILLEJAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public IICKDPKLELG MEJMENIFGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int GOEKPIEOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public object MHMLHBGOHIM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB7AF0", Offset = "0x3BB66F0", VA = "0x183BB7AF0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F11160", Offset = "0x7F0FD60", VA = "0x187F11160")]
	public MNMNIMLOHNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IICKDPKLELG
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly IICKDPKLELG DIACPKGMELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public byte EICECONPKHO;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const byte OJOFFBJDEOI = 1;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const byte PFNAMHGMDAM = 2;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const byte ODMHJAKHPHB = 4;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const byte LINICINFFGP = 8;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xC81600", Offset = "0xC80200", VA = "0x180C81600")]
	public IICKDPKLELG(byte KDLPOBNLDPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IJJLJANMBCH : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C090", Offset = "0x7F0AC90", VA = "0x187F0C090")]
	public IJJLJANMBCH(IDictionary<object, object> NJHNNBNFCIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum EOAABFCNMKL
{

}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum EOBBBLBBALJ : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct HANCPAOKLPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float KFGAJBKADFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float FEABMDLFEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float LKCFDBIMIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float GPNALACCLJE;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x11F6000", Offset = "0x11F4C00", VA = "0x1811F6000")]
	public Quaternion MBIKFFDMBBE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x11F6000", Offset = "0x11F4C00", VA = "0x1811F6000")]
	public static HANCPAOKLPE OIAGMNOIDLI(Quaternion CIFFPDDHHGK)
	{
		return default(HANCPAOKLPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct EHMBPPNGFAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float KFGAJBKADFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float FEABMDLFEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public float LKCFDBIMIBE;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1B828C0", Offset = "0x1B814C0", VA = "0x181B828C0")]
	public Vector3 BHEHMCBIPGH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1B828C0", Offset = "0x1B814C0", VA = "0x181B828C0")]
	public static EHMBPPNGFAG LKADBDGKDCI(Vector3 KCDHOIGGOAB)
	{
		return default(EHMBPPNGFAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KMMCPCNEFGG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public int EONPELANKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte NGKALNGDLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int CJPCPLEDDLB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3B6C280", Offset = "0x3B6AE80", VA = "0x183B6C280", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PBIAIHKJAAI) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public KMMCPCNEFGG()
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
