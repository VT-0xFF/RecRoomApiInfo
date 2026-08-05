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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CJGJHMNFINL : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte DHBCHLILMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public IFLICBOELMF MHNPFFMMJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public IKNIODLHFBI HCBOKGBNCDM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x37B8430", Offset = "0x37B6C30", VA = "0x1837B8430", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CJGJHMNFINL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NMKAIANFDNN : byte
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
public struct OJNAHOMIHFJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Vector2 IIAOCOIFEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Vector2 AEPAAHMDBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector2 JIOLCJCPCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector2 JCLEEJJOLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Vector2 BBLFFBCEBLO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B88450", Offset = "0x3B86C50", VA = "0x183B88450", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PLODFABBDKD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public byte CBHLMEDPPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte CJDELIGDMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int HEFGNKGLBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Vector3 CGHFJMHBGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Quaternion LHADJKBBBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float DJLLLJMFFMD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6A50", Offset = "0x3BA5250", VA = "0x183BA6A50", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LHGHEPGILDM : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool AGEMODMDIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector3 BAIEFBENFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Quaternion HBPGIGGIBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float OAPHLLINKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool MJKNCJJIDFP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6CB0", Offset = "0x3AA54B0", VA = "0x183AA6CB0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CLLAJJHBODM : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public string MGONBEDEDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int PNJCJGEIDHG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37BBE50", Offset = "0x37BA650", VA = "0x1837BBE50", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CGCPKMMAAJB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string[] OPKFOLGHFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int EMMCIOLOHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int HIJHALEFGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool EBBCIGDKBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool NFKPBJCIBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool EOEAMFOCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool IHOCMNGFOPK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37B5D10", Offset = "0x37B4510", VA = "0x1837B5D10", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HKFODANEGKC : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public string HPANEBBHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string NHDJIHDOEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public KOMFNPOKGNG FOKHNJHPDNM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A5B0", Offset = "0x3A08DB0", VA = "0x183A0A5B0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NKKONIFNKLA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool BNFFGAJIILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public PIFHADJEHJB JPCNIAHCHAA;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A5B0", Offset = "0x3B48DB0", VA = "0x183B4A5B0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PIFHADJEHJB : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum ECGJPBKHMAM : byte
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
	public ECGJPBKHMAM BIABDGPIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public ulong NHMKOPOILJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ulong JBHEGGDNFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public PCBOKNMLGAK[] MJCNINJFCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public KOMFNPOKGNG LIDGPNKJCLJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3EF0", Offset = "0x3BA26F0", VA = "0x183BA3EF0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct PCBOKNMLGAK : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum EMHGDMDKOOE : byte
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
	public EMHGDMDKOOE BIABDGPIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public ulong MAGIPLDDFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public string HPANEBBHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int DJKBOHPOLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public string NHDJIHDOEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public KOMFNPOKGNG EJKFEAAKCDF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3B99260", Offset = "0x3B97A60", VA = "0x183B99260", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AGDJMPPAMHE : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public ulong CGALKELDPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public PIFHADJEHJB FNJJFNNHAEO;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x41E8FE0", Offset = "0x41E77E0", VA = "0x1841E8FE0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KOMFNPOKGNG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Dictionary<object, object> HDAKFEADKFH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F140", Offset = "0x3A9D940", VA = "0x183A9F140", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OPDLFGINAEK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum ANABNCDMDBF : byte
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
	private delegate void EHLDBLCMICC(object IMINNNCPCJF, FastBufferWriter LFDMHEHCHCC);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private delegate object DECNPNIAOMP(FastBufferReader JEPFPDOKDAD);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IBBIMINDJFH<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ANABNCDMDBF serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IBBIMINDJFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4DDC930", Offset = "0x4DDB130", VA = "0x184DDC930")]
		internal void MDPAJDELDKG(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4DDC610", Offset = "0x4DDAE10", VA = "0x184DDC610")]
		internal object IGJIBBMLBLG(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CCAKFCLJFKD<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ANABNCDMDBF serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CCAKFCLJFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x66895C0", Offset = "0x6687DC0", VA = "0x1866895C0")]
		internal void KCNAMPIGINH(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6689D30", Offset = "0x6688530", VA = "0x186689D30")]
		internal object NMJFBACBFOG(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Dictionary<Type, ANABNCDMDBF> PDMKCMLBPPI;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Dictionary<ANABNCDMDBF, Type> IPEKHDECGIJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Dictionary<ANABNCDMDBF, EHLDBLCMICC> OBGCDIBLHMF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Dictionary<ANABNCDMDBF, DECNPNIAOMP> HJDLMAJINDN;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Dictionary<ANABNCDMDBF, ANABNCDMDBF> PPNAHOCJHKP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Dictionary<ANABNCDMDBF, Type> AHDIGHCFOKP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x80EA370", Offset = "0x80E8B70", VA = "0x1880EA370")]
	static OPDLFGINAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x80E97E0", Offset = "0x80E7FE0", VA = "0x1880E97E0")]
	public static void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x80E8AC0", Offset = "0x80E72C0", VA = "0x1880E8AC0")]
	public static void GJCNJFECIPF(object IMINNNCPCJF, FastBufferWriter LFDMHEHCHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x80E9DB0", Offset = "0x80E85B0", VA = "0x1880E9DB0")]
	public static object OLFGCACBCKJ(FastBufferReader JEPFPDOKDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A410", Offset = "0x3B88C10", VA = "0x183B8A410")]
	public static void BGECMKNMHJL<TType, TNetworkType>(ANABNCDMDBF HHAIIMKCAEJ, Func<TType, TNetworkType> IOBGLAIOHHG, Func<TNetworkType, TType> CEDBKGNFAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B8C6B0", Offset = "0x3B8AEB0", VA = "0x183B8C6B0")]
	private static void MBGDKBKKHDB<TType, TNetworkType>(ANABNCDMDBF HHAIIMKCAEJ, Func<TType, TNetworkType> IOBGLAIOHHG, Func<TNetworkType, TType> CEDBKGNFAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80E8610", Offset = "0x80E6E10", VA = "0x1880E8610")]
	private static void BGECMKNMHJL(Type CEPGAJKBPDM, ANABNCDMDBF HHAIIMKCAEJ, EHLDBLCMICC IAFBKGKIIMP, DECNPNIAOMP MGLMOFCKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80E5A90", Offset = "0x80E4290", VA = "0x1880E5A90")]
	private static void BFLCCHOACKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F940", Offset = "0x3B8E140", VA = "0x183B8F940")]
	private static void NNADPHFMPDB<T>(ANABNCDMDBF HHAIIMKCAEJ) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B91330", Offset = "0x3B8FB30", VA = "0x183B91330")]
	private static void PKKHMILCACK<T, T>(ANABNCDMDBF HHAIIMKCAEJ) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D790", Offset = "0x3B8BF90", VA = "0x183B8D790")]
	private static void NKBPMODJIPK<T, T>(ANABNCDMDBF HHAIIMKCAEJ) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80E9190", Offset = "0x80E7990", VA = "0x1880E9190")]
	private static void JCBEIHHDCLM(object MGONBEDEDON, Type FBJHAGEDEEC, FastBufferWriter LFDMHEHCHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80E8990", Offset = "0x80E7190", VA = "0x1880E8990")]
	private static object DHEPGGEDEJI(FastBufferReader JEPFPDOKDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80E9930", Offset = "0x80E8130", VA = "0x1880E9930")]
	private static object MOCDGIJPNBJ(FastBufferReader JEPFPDOKDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x80E5660", Offset = "0x80E3E60", VA = "0x1880E5660")]
	private static object AJDKLGPBLEI(FastBufferReader JEPFPDOKDAD, Func<Type, int, IList> ILMICIECHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B8C0D0", Offset = "0x3B8A8D0", VA = "0x183B8C0D0")]
	public static void CDGEIMLPMOF<T, TKey, TValue>(object MGONBEDEDON, FastBufferWriter LFDMHEHCHCC) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B90EB0", Offset = "0x3B8F6B0", VA = "0x183B90EB0")]
	public static object PKAKMOOCNDF<T, TKey, TValue>(FastBufferReader JEPFPDOKDAD) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80EA230", Offset = "0x80E8A30", VA = "0x1880EA230")]
	private static void PLAIPANMDMM(object MGONBEDEDON, FastBufferWriter LFDMHEHCHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80EA170", Offset = "0x80E8970", VA = "0x1880EA170")]
	private static object OPCBOJKALDA(FastBufferReader JEPFPDOKDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80E9070", Offset = "0x80E7870", VA = "0x1880E9070")]
	private static object GMDPBGDHFLI(FastBufferReader JEPFPDOKDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80E9A60", Offset = "0x80E8260", VA = "0x1880E9A60")]
	private static void NLAEJCMLGHC(object HBPINLCGMHB, FastBufferWriter LFDMHEHCHCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum GMHJIAHJCPH : byte
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
public enum IFLICBOELMF : byte
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
public static class GAKCNFJADDI
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x80E53E0", Offset = "0x80E3BE0", VA = "0x1880E53E0")]
	public static NetworkDelivery BMCEBELNHMI(this IFLICBOELMF EAPBEEGJNMN)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum ABHHJCOPDAL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	All,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IKNIODLHFBI : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly IKNIODLHFBI JMOEBDABFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public GMHJIAHJCPH FFNGPBKGGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte LGBLCLBAOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int[] NEKLCPKINKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public ABHHJCOPDAL AAHDFBIEFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte LLICCMOLHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public JABMHHHOMAF ILCCPJHABKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public int EKICICEDMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public object HGDLAABJBCA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3A29D20", Offset = "0x3A28520", VA = "0x183A29D20", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x80E5580", Offset = "0x80E3D80", VA = "0x1880E5580")]
	public IKNIODLHFBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JABMHHHOMAF
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly JABMHHHOMAF JMOEBDABFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte JCEECMHNMME;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const byte KKIDLEFMIBJ = 1;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const byte PCONNEAFCDJ = 2;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const byte CLJIPFLJHOH = 4;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const byte MFIEFILOFFL = 8;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xC58B80", Offset = "0xC57380", VA = "0x180C58B80")]
	public JABMHHHOMAF(byte NJENFOJDDOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class CLIDIMPDLIF : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x80E5390", Offset = "0x80E3B90", VA = "0x1880E5390")]
	public CLIDIMPDLIF(IDictionary<object, object> FDLLKGDBNDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum CHAFHKKDNLB
{

}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum FCHKFLKILBA : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct AAMKJEBCHIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float BDGPJOKJNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float HDAFCDJNHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float GJHIHKIOKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float JFOFHMLAJFN;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x11A5480", Offset = "0x11A3C80", VA = "0x1811A5480")]
	public Quaternion DIIJLJNNMBG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x11A5480", Offset = "0x11A3C80", VA = "0x1811A5480")]
	public static AAMKJEBCHIL DIEEKOBHCAC(Quaternion LMAECCBIKKN)
	{
		return default(AAMKJEBCHIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct GIJOMPJHFBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float BDGPJOKJNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float HDAFCDJNHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float GJHIHKIOKLH;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1AF91D0", Offset = "0x1AF79D0", VA = "0x181AF91D0")]
	public Vector3 JBHBLONCGMF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1AF91D0", Offset = "0x1AF79D0", VA = "0x181AF91D0")]
	public static GIJOMPJHFBE IKLCGPAEAEF(Vector3 OGELGKMLIOE)
	{
		return default(GIJOMPJHFBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PEPHKBBODHA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int ILMPBJOINGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte DHBCHLILMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public int PCIAIMFFOED;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3BA1390", Offset = "0x3B9FB90", VA = "0x183BA1390", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> KDNIJMFFINB) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PEPHKBBODHA()
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
