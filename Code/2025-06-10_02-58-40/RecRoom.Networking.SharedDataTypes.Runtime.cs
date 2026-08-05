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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BANEKFENMCJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte LOPHFGBHALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public BMEOONJFDHA BINKGNMDOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public FLEPBPAFMND FMJMKAGOECJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3787A30", Offset = "0x3786C30", VA = "0x183787A30", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public BANEKFENMCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LJGKGDCKBLE : byte
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
public struct PBAJBEBHKBE : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Vector2 IMEAKGLMLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Vector2 JFBGMAPACGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector2 CGENGDHJCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector2 IGCJHJBDOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Vector2 DFAIOGLOMJO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3BC3A00", Offset = "0x3BC2C00", VA = "0x183BC3A00", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct FOGIDDCLMFE : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public byte AABBJBKFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte DOPJEDPBCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int LIOACKIDDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Vector3 CECHGNICGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Quaternion KJMIGAMAAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float EGBGAHKKAGA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39F0500", Offset = "0x39EF700", VA = "0x1839F0500", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JAKCHPPOKNG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool JIMFNDCAFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector3 JCHDHELBFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Quaternion FODPIPCFDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float BIHKMGFMOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool NHCOCKFBFNE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A61BB0", Offset = "0x3A60DB0", VA = "0x183A61BB0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DEEFIMACPCJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public string KJIOHKMJAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int CMDFFDAPDIB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3857CF0", Offset = "0x3856EF0", VA = "0x183857CF0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LKKDNIEGFPK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string[] DEBMOGKLBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int ALOMAPLLBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int GKBDGKBJDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool NIEOFLHJIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool LFGHJPOHIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool JBPEFFIDDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool FGLFEBKEGJO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3ACBDD0", Offset = "0x3ACAFD0", VA = "0x183ACBDD0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BHMFFILHBLC : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public string GBOCGPJOEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string EFCACCFAJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IPOLCLBGGCC DJIBFNKBFIK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x378D940", Offset = "0x378CB40", VA = "0x18378D940", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PDHHMAIEJCI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool JPDJJAKCOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public JJBHDAGGEGO JCFOMPGDMKN;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4370", Offset = "0x3BC3570", VA = "0x183BC4370", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JJBHDAGGEGO : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum BJCHMDIJFDH : byte
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
	public BJCHMDIJFDH KFNKFAPJJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public ulong KDKKOEPGIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ulong NIKGICANEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DFOJPDEMLFA[] IKCPNKKGAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public IPOLCLBGGCC NGOAOMBJPIM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A67EF0", Offset = "0x3A670F0", VA = "0x183A67EF0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct DFOJPDEMLFA : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum BJBGNLJNKAA : byte
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
	public BJBGNLJNKAA KFNKFAPJJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public ulong JFOBNAKMELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public string GBOCGPJOEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int LJKLNEIKJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public string EFCACCFAJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public IPOLCLBGGCC JJBNOECJECH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3858750", Offset = "0x3857950", VA = "0x183858750", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OPHMFCCKBFG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public ulong NAGGAHMCKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public JJBHDAGGEGO FEPDACBIEOD;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0FD0", Offset = "0x3BC01D0", VA = "0x183BC0FD0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IPOLCLBGGCC : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Dictionary<object, object> LFLEGEJLLKE;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A51680", Offset = "0x3A50880", VA = "0x183A51680", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ADPKGALCCKO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum CBGCGCICABG : byte
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
	private delegate void IOOEOKHPDCN(object CAIGHLKIDBF, FastBufferWriter HLPFOKGJOHH);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private delegate object HMPJIPBKCNK(FastBufferReader GBOEOLHFKIL);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NAMKJJEAMHH<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CBGCGCICABG serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NAMKJJEAMHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x546FBF0", Offset = "0x546EDF0", VA = "0x18546FBF0")]
		internal void JLADDLAJNNB(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x546F480", Offset = "0x546E680", VA = "0x18546F480")]
		internal object CIFEEDCADFC(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class AGJIOJACBGP<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CBGCGCICABG serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AGJIOJACBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4F24390", Offset = "0x4F23590", VA = "0x184F24390")]
		internal void NGLLPDEOMNO(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4F23B30", Offset = "0x4F22D30", VA = "0x184F23B30")]
		internal object MGOIDHLBJHC(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Dictionary<Type, CBGCGCICABG> AKIFHLCABPJ;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Dictionary<CBGCGCICABG, Type> KKFEJGHFOMA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Dictionary<CBGCGCICABG, IOOEOKHPDCN> OFBIIJHBKPC;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Dictionary<CBGCGCICABG, HMPJIPBKCNK> EJBJMBPHEOL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Dictionary<CBGCGCICABG, CBGCGCICABG> CJDIJJIOBNB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Dictionary<CBGCGCICABG, Type> PHONIIIGNNI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F220", Offset = "0x7D9E420", VA = "0x187D9F220")]
	static ADPKGALCCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DBC0", Offset = "0x7D9CDC0", VA = "0x187D9DBC0")]
	public static void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DD10", Offset = "0x7D9CF10", VA = "0x187D9DD10")]
	public static void ELKKKBEIKKA(object CAIGHLKIDBF, FastBufferWriter HLPFOKGJOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A610", Offset = "0x7D99810", VA = "0x187D9A610")]
	public static object BHIBMPPAILM(FastBufferReader GBOEOLHFKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2F9F4F0", Offset = "0x2F9E6F0", VA = "0x182F9F4F0")]
	public static void JGLKMJCHNBJ<TType, TNetworkType>(CBGCGCICABG ABDCMLNJMPM, Func<TType, TNetworkType> JBHNNAAEILF, Func<TNetworkType, TType> EJOEHELHGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1160", Offset = "0x2FA0360", VA = "0x182FA1160")]
	private static void JNEFOLAJNJG<TType, TNetworkType>(CBGCGCICABG ABDCMLNJMPM, Func<TType, TNetworkType> JBHNNAAEILF, Func<TNetworkType, TType> EJOEHELHGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E4A0", Offset = "0x7D9D6A0", VA = "0x187D9E4A0")]
	private static void JGLKMJCHNBJ(Type GDHKDBJPDLG, CBGCGCICABG ABDCMLNJMPM, IOOEOKHPDCN DLOOGJDDHNE, HMPJIPBKCNK EBEENNIHIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A9D0", Offset = "0x7D99BD0", VA = "0x187D9A9D0")]
	private static void BOKMNEPDPIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F994E0", Offset = "0x2F986E0", VA = "0x182F994E0")]
	private static void CBFMPPAPIAA<T>(CBGCGCICABG ABDCMLNJMPM) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2F9AA50", Offset = "0x2F99C50", VA = "0x182F9AA50")]
	private static void EOIPEJLPCNJ<T, T>(CBGCGCICABG ABDCMLNJMPM) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CF10", Offset = "0x2F9C110", VA = "0x182F9CF10")]
	private static void FKMFHCKJBEJ<T, T>(CBGCGCICABG ABDCMLNJMPM) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D550", Offset = "0x7D9C750", VA = "0x187D9D550")]
	private static void DJKKJALKPBG(object KJIOHKMJAPE, Type PBOMDHONPGE, FastBufferWriter HLPFOKGJOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A4E0", Offset = "0x7D996E0", VA = "0x187D9A4E0")]
	private static object ACEHAIPJPNC(FastBufferReader GBOEOLHFKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E820", Offset = "0x7D9DA20", VA = "0x187D9E820")]
	private static object JHHFOOOFCOC(FastBufferReader GBOEOLHFKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9EDF0", Offset = "0x7D9DFF0", VA = "0x187D9EDF0")]
	private static object NMAICIIEFCM(FastBufferReader GBOEOLHFKIL, Func<Type, int, IList> JIGEBIJNNOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA21F0", Offset = "0x2FA13F0", VA = "0x182FA21F0")]
	public static void MIBDEDJEOCD<T, TKey, TValue>(object KJIOHKMJAPE, FastBufferWriter HLPFOKGJOHH) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2F9F0C0", Offset = "0x2F9E2C0", VA = "0x182F9F0C0")]
	public static object GCCGEBLAAIJ<T, TKey, TValue>(FastBufferReader GBOEOLHFKIL) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E950", Offset = "0x7D9DB50", VA = "0x187D9E950")]
	private static void KIDDPBAKJMF(object KJIOHKMJAPE, FastBufferWriter HLPFOKGJOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E2C0", Offset = "0x7D9D4C0", VA = "0x187D9E2C0")]
	private static object HCPPEKNDIKE(FastBufferReader GBOEOLHFKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E380", Offset = "0x7D9D580", VA = "0x187D9E380")]
	private static object HHLCMGMBCCG(FastBufferReader GBOEOLHFKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D9EAA0", Offset = "0x7D9DCA0", VA = "0x187D9EAA0")]
	private static void MMACGKBIELO(object JHMBOBHDCNC, FastBufferWriter HLPFOKGJOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum DFOLGABGJMH : byte
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
public enum BMEOONJFDHA : byte
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
public static class BPEDOOJAAFJ
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F4A0", Offset = "0x7D9E6A0", VA = "0x187D9F4A0")]
	public static NetworkDelivery NADNLFBFNMO(this BMEOONJFDHA MGJKDIAKPJG)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum PGOMHILEHFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	All,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FLEPBPAFMND : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly FLEPBPAFMND LGHIFDBIJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public DFOLGABGJMH DLOGFNIKHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte MOMGKDEIIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int[] DHDBEACPPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public PGOMHILEHFJ DIBMEGIGDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte FPNLPONBGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public PHEBPMCACCF HLDOJAOKGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public int FIKDPMGNHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public object NINKGCJMFEB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x39EDB40", Offset = "0x39ECD40", VA = "0x1839EDB40", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F690", Offset = "0x7D9E890", VA = "0x187D9F690")]
	public FLEPBPAFMND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PHEBPMCACCF
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly PHEBPMCACCF LGHIFDBIJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte FGPBKDHGBAG;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const byte IAHNPLFEGEH = 1;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const byte ICAKHGGJMMN = 2;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const byte IJMLALEHCKG = 4;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const byte PBDEBGHICMJ = 8;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xC4D3D0", Offset = "0xC4C5D0", VA = "0x180C4D3D0")]
	public PHEBPMCACCF(byte PLGDKHNINAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FDKAECCGAPA : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F580", Offset = "0x7D9E780", VA = "0x187D9F580")]
	public FDKAECCGAPA(IDictionary<object, object> MGGGOEHGEIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum HDBEEGENJDI
{

}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum DIAIOFKFPFA : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FAEMPFMNFHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float HGCMPGNMMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float PIALGICKFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float AKEKIBJOPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float MPPBNBGNIHH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1196770", Offset = "0x1195970", VA = "0x181196770")]
	public Quaternion MJPKKDOEJDF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1196770", Offset = "0x1195970", VA = "0x181196770")]
	public static FAEMPFMNFHE FFGPMDECPKC(Quaternion AJFGNJLKIEL)
	{
		return default(FAEMPFMNFHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JPGHBFCOGMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float HGCMPGNMMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float PIALGICKFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float AKEKIBJOPCD;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1AE5FF0", Offset = "0x1AE51F0", VA = "0x181AE5FF0")]
	public Vector3 HLIHNOHLPHE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1AE5FF0", Offset = "0x1AE51F0", VA = "0x181AE5FF0")]
	public static JPGHBFCOGMO DFGMKHIPNIE(Vector3 GDBIDLINMAG)
	{
		return default(JPGHBFCOGMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PLKKMHOFOBG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int GAAMFLLIJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte LOPHFGBHALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public int OAENOIOJFPJ;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3BCDA60", Offset = "0x3BCCC60", VA = "0x183BCDA60", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPPBECKMJNH) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PLKKMHOFOBG()
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
