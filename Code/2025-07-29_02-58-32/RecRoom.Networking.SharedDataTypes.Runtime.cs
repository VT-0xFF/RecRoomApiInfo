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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LBCJLIDGCEB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte CLKNLOMDMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public DLFBKNHNOAP FOALAGHEDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public LFCPHBACBIP LLJEGKPMCOP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D38AA0", Offset = "0x3D374A0", VA = "0x183D38AA0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LBCJLIDGCEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NCNLNLPHDON : byte
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
public struct JDBAKHGDDJJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Vector2 EKBNCIHBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector2 EJLANJOIKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector2 LCEOKHBGNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Vector2 MLAJLBJBKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Vector2 PEHBAMKMGCH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3CF48D0", Offset = "0x3CF32D0", VA = "0x183CF48D0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct EFDIOBFOPMH : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte ALEFBCCDPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public byte LKFJFLADCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int JBPOBPLEADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Vector3 AHFMAPLJEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Quaternion MCFJIBPNDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float KEAILFFMBJF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3ADFA10", Offset = "0x3ADE410", VA = "0x183ADFA10", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HALJAAINHMM : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public bool EKBGHKEPFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 GDEEHHOMKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion IEBOBJIHNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float JPGBGDKOAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool GAFGNOKILMC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C79930", Offset = "0x3C78330", VA = "0x183C79930", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GNBLJIBBGBD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string PDKJBMPOMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int FILGHJLFKAL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C76010", Offset = "0x3C74A10", VA = "0x183C76010", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EODNOGDLPBE : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string[] OJCCMCEOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int IKPJDLAGFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public int BHCHJHLDLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool BIFFOLMKDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool MHFHBFLCMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool IKNDNACEPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool PNHPOGILKAF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9290", Offset = "0x3AE7C90", VA = "0x183AE9290", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MMIDDAGPOJA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string FLBFBHGDBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string JLONGOFLFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public ICJCPAMFLDL OCJMBNKFKIJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFA30", Offset = "0x3DAE430", VA = "0x183DAFA30", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LJNOGMMBMEA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool INJIMBANEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public ENFHBKAGJMK OBPEHAFILEK;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D47060", Offset = "0x3D45A60", VA = "0x183D47060", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ENFHBKAGJMK : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum GJLDDBFLNII : byte
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
	public GJLDDBFLNII FNKOMGMNJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ulong JOCHNADMHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ulong DIBMAAGFAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public COCGOHAIADK[] LMLHHCEIECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public ICJCPAMFLDL IMHMKCHEJAJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6A00", Offset = "0x3AE5400", VA = "0x183AE6A00", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct COCGOHAIADK : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum BFHDIJOILPA : byte
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
	public BFHDIJOILPA FNKOMGMNJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public ulong CDBGILBOAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public string FLBFBHGDBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int LHPHKGMDHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public string JLONGOFLFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public ICJCPAMFLDL PHMFMDFHLBJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E2C0", Offset = "0x3A6CCC0", VA = "0x183A6E2C0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JEOGDABPJNJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public ulong IAOINMGPFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public ENFHBKAGJMK MPCEMCIIDDE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA730", Offset = "0x3CF9130", VA = "0x183CFA730", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ICJCPAMFLDL : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Dictionary<object, object> BHKLFFIKDPE;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CA9720", Offset = "0x3CA8120", VA = "0x183CA9720", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GJBLCLLCNLG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum JHGJAHODGFL : byte
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
	private delegate void KDKJNNEKGPD(object GPCDCFCPGFK, FastBufferWriter ADMHNJGGGLG);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private delegate object GMEHLOHNLEH(FastBufferReader IOMONBOBJAC);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FMOJDKDNDPI<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public JHGJAHODGFL serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FMOJDKDNDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4E332D0", Offset = "0x4E31CD0", VA = "0x184E332D0")]
		internal void KEGHNIPDHPK(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4E33B80", Offset = "0x4E32580", VA = "0x184E33B80")]
		internal object PGGMLENHGJN(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class KHEHCPIAMMN<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public JHGJAHODGFL serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KHEHCPIAMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x54F35F0", Offset = "0x54F1FF0", VA = "0x1854F35F0")]
		internal void HLPNFGMHCIG(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x54F3000", Offset = "0x54F1A00", VA = "0x1854F3000")]
		internal object CIMHHHAMNIH(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Dictionary<Type, JHGJAHODGFL> CDFEFMKJLMK;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Dictionary<JHGJAHODGFL, Type> CHFOHCMLGAH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Dictionary<JHGJAHODGFL, KDKJNNEKGPD> IFNBELJHKPG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Dictionary<JHGJAHODGFL, GMEHLOHNLEH> BOLMKOFECKI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Dictionary<JHGJAHODGFL, JHGJAHODGFL> FCEKCMHFILN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Dictionary<JHGJAHODGFL, Type> LCPABOBECDD;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84528D0", Offset = "0x84512D0", VA = "0x1884528D0")]
	static GJBLCLLCNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x844D880", Offset = "0x844C280", VA = "0x18844D880")]
	public static void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x844D9F0", Offset = "0x844C3F0", VA = "0x18844D9F0")]
	public static void AGNKEKDJGCC(object GPCDCFCPGFK, FastBufferWriter ADMHNJGGGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8451B80", Offset = "0x8450580", VA = "0x188451B80")]
	public static object JBBKNKCPLNK(FastBufferReader IOMONBOBJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E880", Offset = "0x3C6D280", VA = "0x183C6E880")]
	public static void LEOGIJPLHCE<TType, TNetworkType>(JHGJAHODGFL LHCKDGCJCBH, Func<TType, TNetworkType> IHEMHPMGCFD, Func<TNetworkType, TType> EOKCELFKODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D7A0", Offset = "0x3C6C1A0", VA = "0x183C6D7A0")]
	private static void JGMGGCDKEIG<TType, TNetworkType>(JHGJAHODGFL LHCKDGCJCBH, Func<TType, TNetworkType> IHEMHPMGCFD, Func<TNetworkType, TType> EOKCELFKODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84520A0", Offset = "0x8450AA0", VA = "0x1884520A0")]
	private static void LEOGIJPLHCE(Type AEOGKDPPBBE, JHGJAHODGFL LHCKDGCJCBH, KDKJNNEKGPD OEHGOAAMAGD, GMEHLOHNLEH ECDMFPEMGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x844EC50", Offset = "0x844D650", VA = "0x18844EC50")]
	private static void HAJJCPJEBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C6BDA0", Offset = "0x3C6A7A0", VA = "0x183C6BDA0")]
	private static void FALIJNHJEFL<T>(JHGJAHODGFL LHCKDGCJCBH) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C69820", Offset = "0x3C68220", VA = "0x183C69820")]
	private static void DLIEGEOIEPN<T, T>(JHGJAHODGFL LHCKDGCJCBH) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C70AE0", Offset = "0x3C6F4E0", VA = "0x183C70AE0")]
	private static void POLGBFEEDEG<T, T>(JHGJAHODGFL LHCKDGCJCBH) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x844E5D0", Offset = "0x844CFD0", VA = "0x18844E5D0")]
	private static void GJKADCAOOCJ(object PDKJBMPOMNC, Type FANAAMLKIBG, FastBufferWriter ADMHNJGGGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x844DFA0", Offset = "0x844C9A0", VA = "0x18844DFA0")]
	private static object BDFPLPFDHHP(FastBufferReader IOMONBOBJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8451F60", Offset = "0x8450960", VA = "0x188451F60")]
	private static object JNBOFFBMFGL(FastBufferReader IOMONBOBJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x844E0E0", Offset = "0x844CAE0", VA = "0x18844E0E0")]
	private static object BHMGJODCKJI(FastBufferReader IOMONBOBJAC, Func<Type, int, IList> JEKIBMPMPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C70540", Offset = "0x3C6EF40", VA = "0x183C70540")]
	public static void MLAIMDFFKMH<T, TKey, TValue>(object PDKJBMPOMNC, FastBufferWriter ADMHNJGGGLG) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D380", Offset = "0x3C6BD80", VA = "0x183C6D380")]
	public static object FMJBEGFKONI<T, TKey, TValue>(FastBufferReader IOMONBOBJAC) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8452440", Offset = "0x8450E40", VA = "0x188452440")]
	private static void NIPAELJLKII(object PDKJBMPOMNC, FastBufferWriter ADMHNJGGGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x844E510", Offset = "0x844CF10", VA = "0x18844E510")]
	private static object FMGMPEBEMKM(FastBufferReader IOMONBOBJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8451A60", Offset = "0x8450460", VA = "0x188451A60")]
	private static object IBJCHAHHHIG(FastBufferReader IOMONBOBJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8452580", Offset = "0x8450F80", VA = "0x188452580")]
	private static void NJGKABKGKJF(object DAHCIIGJBGH, FastBufferWriter ADMHNJGGGLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum IMKFKJGKAJH : byte
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
public enum DLFBKNHNOAP : byte
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
public static class EDIEHPALGME
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x844D7A0", Offset = "0x844C1A0", VA = "0x18844D7A0")]
	public static NetworkDelivery DILGLPGJLAG(this DLFBKNHNOAP CIANMJKIBMC)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum NDNMKNGFGLE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	All,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LFCPHBACBIP : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly LFCPHBACBIP MDAKIDAOHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public IMKFKJGKAJH OENLHNONJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte NCJELAHCLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public int[] PLFICOEHAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public NDNMKNGFGLE FPGKECMFNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte ICDDDECJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public BEHDLKDMHIG CDDIDIGFHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int FIHNKIBBKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public object AIFCOOPPKMP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3D220", Offset = "0x3D3BC20", VA = "0x183D3D220", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8452C40", Offset = "0x8451640", VA = "0x188452C40")]
	public LFCPHBACBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BEHDLKDMHIG
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly BEHDLKDMHIG MDAKIDAOHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public byte EAFPKGBABBP;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const byte CLAKGABJFJL = 1;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const byte KGHKIGDJAOA = 2;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const byte OFNPHOAEHOB = 4;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const byte HHFPLPBCDLJ = 8;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xD20EF0", Offset = "0xD1F8F0", VA = "0x180D20EF0")]
	public BEHDLKDMHIG(byte HLPAKACNFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AFLPDCFHMHG : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x844D6D0", Offset = "0x844C0D0", VA = "0x18844D6D0")]
	public AFLPDCFHMHG(IDictionary<object, object> JAGEKIFCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum MBJEIPNJNLO
{

}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum BLKNDKFKHNE : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DOAHDNPKODA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float IECENJOJFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float OFOCBNJJIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float KBPKNDAKOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float CINPCLDHBLP;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x12F33E0", Offset = "0x12F1DE0", VA = "0x1812F33E0")]
	public Quaternion AIMCNOGDNND()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x12F33E0", Offset = "0x12F1DE0", VA = "0x1812F33E0")]
	public static DOAHDNPKODA CMHFAECIOHI(Quaternion HBBIEGGHMGM)
	{
		return default(DOAHDNPKODA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct EKHGCBCDDHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float IECENJOJFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float OFOCBNJJIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public float KBPKNDAKOHF;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1C7DE00", Offset = "0x1C7C800", VA = "0x181C7DE00")]
	public Vector3 EKJHBHFCNIC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1C7DE00", Offset = "0x1C7C800", VA = "0x181C7DE00")]
	public static EKHGCBCDDHI DBOACFGHBCM(Vector3 GNACDKLHCEH)
	{
		return default(EKHGCBCDDHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EFCALPGIKJN : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public int JJCKPAPKIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte CLKNLOMDMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int DJOGOIHHKGI;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF8C0", Offset = "0x3ADE2C0", VA = "0x183ADF8C0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> OEPNAGFCALD) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EFCALPGIKJN()
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
