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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HIMNFKOAHMF : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte MHNKCPFADGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public OIBNCNMBLDO MEBDBAJJJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public NDFFKECCNKF HKBNNNEGIHI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C797E0", Offset = "0x3C787E0", VA = "0x183C797E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HIMNFKOAHMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NILCDNBAPNO : byte
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
public struct OMFLKHHDEFK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Vector2 MADKGCPLBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector2 IKNDGPBHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector2 GDAKJHMLGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Vector2 HPHDOPMOPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Vector2 EDAKNNEOFJP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3E28BE0", Offset = "0x3E27BE0", VA = "0x183E28BE0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct INMLHJKALIJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte DDPBPEGBOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public byte JOAEIMLCIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int FKHACEBFNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Vector3 ACIPKJDGIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Quaternion INKBIHGIPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float CJAAGMHEONG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE5D0", Offset = "0x3CCD5D0", VA = "0x183CCE5D0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NIFNCCNPKOB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public bool MOAEMDKPLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 GKANPAILENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion MMKPIDNBBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float NBGNFJAHIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool IMNKHPJHMLI;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4A60", Offset = "0x3DF3A60", VA = "0x183DF4A60", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GOOBKAPMPKO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string IOALKPFEKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int HLGKMAPOEBE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C66080", Offset = "0x3C65080", VA = "0x183C66080", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KNEAEBNAOCK : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string[] FJFJIMEJFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int FAGMFJIHJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public int ALFAEJEIFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool KEONJMAMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool BFPKFONCIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool PHEOOAJAJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool FELLNAAFJEM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D22FF0", Offset = "0x3D21FF0", VA = "0x183D22FF0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FHJNNGKCIPB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string HJLBILHBIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string JPDDBGDJFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LGIGIHLJAPI HHPDBABFJMJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C3E740", Offset = "0x3C3D740", VA = "0x183C3E740", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OPGKNONENAJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool MIFAEMCECOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public OCKHMGFANHD IANLOKBOBGO;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E306E0", Offset = "0x3E2F6E0", VA = "0x183E306E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OCKHMGFANHD : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum JIHACJLNFKE : byte
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
	public JIHACJLNFKE CJCJHPGELJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ulong BIBFIHOLJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ulong CHIABMGGHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EECOLELLELP[] PPNBLMHHDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public LGIGIHLJAPI KAGCICLEEEE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E226F0", Offset = "0x3E216F0", VA = "0x183E226F0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EECOLELLELP : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum FMEPBLGLEHD : byte
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
	public FMEPBLGLEHD CJCJHPGELJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public ulong AEOGCMBMFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public string HJLBILHBIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int ADMJEODDOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public string JPDDBGDJFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public LGIGIHLJAPI IBFKOCCIHAH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4CE0", Offset = "0x3AC3CE0", VA = "0x183AC4CE0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EAKJGHCMEFB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public ulong FKNIBEEOGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public OCKHMGFANHD FMAPGLGGDDA;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6FA0", Offset = "0x3AB5FA0", VA = "0x183AB6FA0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LGIGIHLJAPI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Dictionary<object, object> BDJLGAHJNPH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D52150", Offset = "0x3D51150", VA = "0x183D52150", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EGBGHCHPCHF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum LLOHCFOAIOA : byte
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
	private delegate void EFJIOMPEFOO(object INCJDDLACNP, FastBufferWriter NMCAGOGLPLD);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private delegate object PCEKNCHNDEJ(FastBufferReader AMPJMGIAGBB);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class MHOKNNFJHLB<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LLOHCFOAIOA serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MHOKNNFJHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x56D6670", Offset = "0x56D5670", VA = "0x1856D6670")]
		internal void CDNBLDDHAOL(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x56D70C0", Offset = "0x56D60C0", VA = "0x1856D70C0")]
		internal object NKIBAILFFHK(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class APEAPONFKLP<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public LLOHCFOAIOA serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public APEAPONFKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5370D00", Offset = "0x536FD00", VA = "0x185370D00")]
		internal void PIDMPJMBBAB(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x53702C0", Offset = "0x536F2C0", VA = "0x1853702C0")]
		internal object JOKNNBHGJBN(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Dictionary<Type, LLOHCFOAIOA> KHIMINBOCEF;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Dictionary<LLOHCFOAIOA, Type> KGOHBIGODBE;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Dictionary<LLOHCFOAIOA, EFJIOMPEFOO> OEFKPMMJNKP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Dictionary<LLOHCFOAIOA, PCEKNCHNDEJ> LFNMAKKCBHG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Dictionary<LLOHCFOAIOA, LLOHCFOAIOA> IIPNDFADPBO;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Dictionary<LLOHCFOAIOA, Type> GNOJPMOFLDN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82BFFD0", Offset = "0x82BEFD0", VA = "0x1882BFFD0")]
	static EGBGHCHPCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82BAF70", Offset = "0x82B9F70", VA = "0x1882BAF70")]
	public static void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82BE570", Offset = "0x82BD570", VA = "0x1882BE570")]
	public static void FBGBLPHHDGN(object INCJDDLACNP, FastBufferWriter NMCAGOGLPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82BEF50", Offset = "0x82BDF50", VA = "0x1882BEF50")]
	public static object LABNBGADOBH(FastBufferReader AMPJMGIAGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3ACBCD0", Offset = "0x3ACACD0", VA = "0x183ACBCD0")]
	public static void NJBKBANOODI<TType, TNetworkType>(LLOHCFOAIOA HLAEFHJOFPO, Func<TType, TNetworkType> POJBFPHKFBM, Func<TNetworkType, TType> ILMJNJLAKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7FD0", Offset = "0x3AC6FD0", VA = "0x183AC7FD0")]
	private static void ECJJNIJKCDL<TType, TNetworkType>(LLOHCFOAIOA HLAEFHJOFPO, Func<TType, TNetworkType> POJBFPHKFBM, Func<TNetworkType, TType> ILMJNJLAKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82BFC30", Offset = "0x82BEC30", VA = "0x1882BFC30")]
	private static void NJBKBANOODI(Type BJLNCBFOGNL, LLOHCFOAIOA HLAEFHJOFPO, EFJIOMPEFOO GBKDOIBNHMD, PCEKNCHNDEJ MKNFBBKELIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82BB760", Offset = "0x82BA760", VA = "0x1882BB760")]
	private static void EJDJMIIOEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD990", Offset = "0x3ACC990", VA = "0x183ACD990")]
	private static void NOPFINMHGJJ<T>(LLOHCFOAIOA HLAEFHJOFPO) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5A50", Offset = "0x3AC4A50", VA = "0x183AC5A50")]
	private static void DININLCFHIO<T, T>(LLOHCFOAIOA HLAEFHJOFPO) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9640", Offset = "0x3AC8640", VA = "0x183AC9640")]
	private static void HNDCKEENGDD<T, T>(LLOHCFOAIOA HLAEFHJOFPO) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82BF330", Offset = "0x82BE330", VA = "0x1882BF330")]
	private static void LPCFBEMEOBD(object IOALKPFEKEK, Type JNHLMOEAJGN, FastBufferWriter NMCAGOGLPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82BF9B0", Offset = "0x82BE9B0", VA = "0x1882BF9B0")]
	private static object MOAJLAHLHMI(FastBufferReader AMPJMGIAGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82BFAF0", Offset = "0x82BEAF0", VA = "0x1882BFAF0")]
	private static object NAGPNHILKFC(FastBufferReader AMPJMGIAGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82BEB20", Offset = "0x82BDB20", VA = "0x1882BEB20")]
	private static object KFGEGHGGPML(FastBufferReader AMPJMGIAGBB, Func<Type, int, IList> FJGDGLJOMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3AC90B0", Offset = "0x3AC80B0", VA = "0x183AC90B0")]
	public static void HDGNHJGNEBL<T, TKey, TValue>(object IOALKPFEKEK, FastBufferWriter NMCAGOGLPLD) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3ACB8A0", Offset = "0x3ACA8A0", VA = "0x183ACB8A0")]
	public static object KPFBLHOLDGB<T, TKey, TValue>(FastBufferReader AMPJMGIAGBB) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82BB200", Offset = "0x82BA200", VA = "0x1882BB200")]
	private static void BNPCCPPPEIM(object IOALKPFEKEK, FastBufferWriter NMCAGOGLPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82BB6A0", Offset = "0x82BA6A0", VA = "0x1882BB6A0")]
	private static object DMOADNMJAKD(FastBufferReader AMPJMGIAGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82BB0E0", Offset = "0x82BA0E0", VA = "0x1882BB0E0")]
	private static object AKFEOIHHKNH(FastBufferReader AMPJMGIAGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82BB350", Offset = "0x82BA350", VA = "0x1882BB350")]
	private static void CEDNEGEFCFN(object DFGJHNEFDFM, FastBufferWriter NMCAGOGLPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum JKPDADGJJHJ : byte
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
public enum OIBNCNMBLDO : byte
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
public static class MMAOFBILANA
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82C02F0", Offset = "0x82BF2F0", VA = "0x1882C02F0")]
	public static NetworkDelivery EHKADBKKGIC(this OIBNCNMBLDO CCLLCJFBEHB)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum BCHPAGDHGAK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	All,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NDFFKECCNKF : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly NDFFKECCNKF HPFHFAKCNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public JKPDADGJJHJ KNMFHMPPGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte EDOJDNLHMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public int[] HAIBMNBBCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public BCHPAGDHGAK BFNIIJOINGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte IGACHJGNMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public IMKOKPLKIMP AIEMKEDAOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int HKPMNJBHOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public object PEKBFHOCGBI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0370", Offset = "0x3DEF370", VA = "0x183DF0370", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82C04A0", Offset = "0x82BF4A0", VA = "0x1882C04A0")]
	public NDFFKECCNKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IMKOKPLKIMP
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly IMKOKPLKIMP HPFHFAKCNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public byte EHKDLIAPALP;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const byte CNAPJOLBPEG = 1;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const byte OEBCHCFPPAO = 2;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const byte LFGFHALMBDP = 4;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const byte GCOPGFMMGGL = 8;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xCEC940", Offset = "0xCEB940", VA = "0x180CEC940")]
	public IMKOKPLKIMP(byte DCKCFFGJHEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ADFJPOBHAPN : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x82BAF20", Offset = "0x82B9F20", VA = "0x1882BAF20")]
	public ADFJPOBHAPN(IDictionary<object, object> PBIFPLDBICK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum OJOANGJANMJ
{

}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum LHHFPPPCBFI : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NDOLBLMBJHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float OEFDFBLCHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float GDBEEAKMPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float MJLJNEFHIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float PGMOKNOMMMJ;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1297560", Offset = "0x1296560", VA = "0x181297560")]
	public Quaternion CPAKAJKGKJE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1297560", Offset = "0x1296560", VA = "0x181297560")]
	public static NDOLBLMBJHP NPNGHLHKNHB(Quaternion FGHGAOJONGN)
	{
		return default(NDOLBLMBJHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HGIAHIDGBGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float OEFDFBLCHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float GDBEEAKMPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public float MJLJNEFHIOB;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1C45DA0", Offset = "0x1C44DA0", VA = "0x181C45DA0")]
	public Vector3 FDHOFOLJFJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1C45DA0", Offset = "0x1C44DA0", VA = "0x181C45DA0")]
	public static HGIAHIDGBGH IBFMDAOILFO(Vector3 BBIMFOAPMAH)
	{
		return default(HGIAHIDGBGH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EAHGNMFNBDI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public int KABDCFNOJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte MHNKCPFADGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int NKKMNGFPDOJ;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6E50", Offset = "0x3AB5E50", VA = "0x183AB6E50", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> EPFLIAPJNOD) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public EAHGNMFNBDI()
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
