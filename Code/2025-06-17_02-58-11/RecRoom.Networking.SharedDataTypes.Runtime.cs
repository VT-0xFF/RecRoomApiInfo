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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BLJPIIBHLGB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte CFPJABNCACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public JOJLAKAOABL OAANJAJAKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public AIJLKOBFKFM HBEJDBOGDGP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x37F3590", Offset = "0x37F1F90", VA = "0x1837F3590", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public BLJPIIBHLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JNLKMKOKKEO : byte
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
public struct CKEIFOCDFCM : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Vector2 HIJNILBHEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector2 PNIDCILPDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector2 OACFBELBGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Vector2 HDJFPPAEMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Vector2 BMOJBMOGIKN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3856D90", Offset = "0x3855790", VA = "0x183856D90", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HEFNOPMENNJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte NAOPIDKIJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public byte MPBOKICBFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int POHODHGBPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Vector3 GEJHLHLCIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Quaternion BDPCKMPOLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float DLFKEKFKFAL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3A7BB90", Offset = "0x3A7A590", VA = "0x183A7BB90", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct OKFOBALOBDN : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public bool NBCECNBFMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 ANDPKFCEGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion MCCAAFGCCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float MBPLFLMEDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool AOALJODBJLE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3BFD280", Offset = "0x3BFBC80", VA = "0x183BFD280", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EAJPLLGHPGD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string PCDAHJCDHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int MNFHMLCLFEB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38F2D80", Offset = "0x38F1780", VA = "0x1838F2D80", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MBNIKAEEEJD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string[] DGILLOIKABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int KNFEMINIJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public int BPLMFPCGMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool HEAMDLDBPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool LIPAICIEJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool MDKCANMNIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool KLKLIDEGAMK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3B39500", Offset = "0x3B37F00", VA = "0x183B39500", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HIPDABLDLFG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string GBCFHNGPBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string AJACJKJJMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public DPNMAJACIAL JJOEINJJGNJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A85F60", Offset = "0x3A84960", VA = "0x183A85F60", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JDLBCLDNDJG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool PLABGECLEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public MOMALLCJLEE NIAPBNPEIPM;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE600", Offset = "0x3ABD000", VA = "0x183ABE600", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MOMALLCJLEE : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum EIAIOFADGNL : byte
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
	public EIAIOFADGNL LAPKIBEJCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ulong OBGAOBEFDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ulong KJAGENBKHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public HLLAMGAIAAA[] FGNADCJCNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public DPNMAJACIAL JECPEHNJKOD;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C0E0", Offset = "0x3B5AAE0", VA = "0x183B5C0E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HLLAMGAIAAA : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum MJPHIFMIIAI : byte
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
	public MJPHIFMIIAI LAPKIBEJCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public ulong KKNDHFCJJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public string GBCFHNGPBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int LIEFHLCIOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public string AJACJKJJMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public DPNMAJACIAL KLHNPMNCFFF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A8AAA0", Offset = "0x3A894A0", VA = "0x183A8AAA0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NJCONEBGPKO : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public ulong BKFGOOIFAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public MOMALLCJLEE BCLBJMOJGMN;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA3F0", Offset = "0x3BB8DF0", VA = "0x183BBA3F0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DPNMAJACIAL : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Dictionary<object, object> AMCECKEAKLL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x38DCEE0", Offset = "0x38DB8E0", VA = "0x1838DCEE0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MEALGPGPMAA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum GJDKGGGNNJE : byte
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
	private delegate void LAOJBBBOMEN(object HPGIDELCODH, FastBufferWriter EDJIMCINKFD);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private delegate object ILPKHMOOOEK(FastBufferReader LJMOCEGEAFH);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class EGNNFKDONHN<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GJDKGGGNNJE serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EGNNFKDONHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x46977C0", Offset = "0x46961C0", VA = "0x1846977C0")]
		internal void IKOACANNAIM(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4697C30", Offset = "0x4696630", VA = "0x184697C30")]
		internal object ONGDAOIKGOH(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PGONADNJCOI<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public GJDKGGGNNJE serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public PGONADNJCOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x57649D0", Offset = "0x57633D0", VA = "0x1857649D0")]
		internal void KAFMBEHILDG(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5765430", Offset = "0x5763E30", VA = "0x185765430")]
		internal object NHMODPCCPKB(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Dictionary<Type, GJDKGGGNNJE> CGCAIBJCCGK;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Dictionary<GJDKGGGNNJE, Type> GEODLNIECIG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Dictionary<GJDKGGGNNJE, LAOJBBBOMEN> PCDGFODOEOD;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Dictionary<GJDKGGGNNJE, ILPKHMOOOEK> DBAADDIPENN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Dictionary<GJDKGGGNNJE, GJDKGGGNNJE> HEPEBFNAPPI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Dictionary<GJDKGGGNNJE, Type> CGFOHCFHFFG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E92F70", Offset = "0x7E91970", VA = "0x187E92F70")]
	static MEALGPGPMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E8E9C0", Offset = "0x7E8D3C0", VA = "0x187E8E9C0")]
	public static void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E92670", Offset = "0x7E91070", VA = "0x187E92670")]
	public static void PGPOMLMDCHO(object HPGIDELCODH, FastBufferWriter EDJIMCINKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E922B0", Offset = "0x7E90CB0", VA = "0x187E922B0")]
	public static object PGEPBAPICDN(FastBufferReader LJMOCEGEAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B3CBA0", Offset = "0x3B3B5A0", VA = "0x183B3CBA0")]
	public static void GNKGNPCAJGA<TType, TNetworkType>(GJDKGGGNNJE EOFEMMNHDLP, Func<TType, TNetworkType> NHCGBPMDHAI, Func<TNetworkType, TType> NHKKGNNBLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B40F60", Offset = "0x3B3F960", VA = "0x183B40F60")]
	private static void MAFFFCBOBFP<TType, TNetworkType>(GJDKGGGNNJE EOFEMMNHDLP, Func<TType, TNetworkType> NHCGBPMDHAI, Func<TNetworkType, TType> NHKKGNNBLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E91910", Offset = "0x7E90310", VA = "0x187E91910")]
	private static void GNKGNPCAJGA(Type HHCAOFMCNLG, GJDKGGGNNJE EOFEMMNHDLP, LAOJBBBOMEN IOBNLLDKLJF, ILPKHMOOOEK KLEOMDIOLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E8ED90", Offset = "0x7E8D790", VA = "0x187E8ED90")]
	private static void FOOHKJNFJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B41FF0", Offset = "0x3B409F0", VA = "0x183B41FF0")]
	private static void NCFIMABHNNB<T>(GJDKGGGNNJE EOFEMMNHDLP) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B3A6E0", Offset = "0x3B390E0", VA = "0x183B3A6E0")]
	private static void EOMCHGLNEKE<T, T>(GJDKGGGNNJE EOFEMMNHDLP) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B3EDB0", Offset = "0x3B3D7B0", VA = "0x183B3EDB0")]
	private static void KNHPBOBACAA<T, T>(GJDKGGGNNJE EOFEMMNHDLP) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E8E250", Offset = "0x7E8CC50", VA = "0x187E8E250")]
	private static void AAFHOJOFIBK(object PCDAHJCDHHF, Type HHDNBKMKDLM, FastBufferWriter EDJIMCINKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E8EC60", Offset = "0x7E8D660", VA = "0x187E8EC60")]
	private static object FAHPHJKLFPD(FastBufferReader LJMOCEGEAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E91D50", Offset = "0x7E90750", VA = "0x187E91D50")]
	private static object KCJOJBHAJFK(FastBufferReader LJMOCEGEAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E91E80", Offset = "0x7E90880", VA = "0x187E91E80")]
	private static object ONDKOLPGMNC(FastBufferReader LJMOCEGEAFH, Func<Type, int, IList> FEFKHBOEBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B3E810", Offset = "0x3B3D210", VA = "0x183B3E810")]
	public static void KGHGJLLIFDA<T, TKey, TValue>(object PCDAHJCDHHF, FastBufferWriter EDJIMCINKFD) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B3A2B0", Offset = "0x3B38CB0", VA = "0x183B3A2B0")]
	public static object EMODFONDAKE<T, TKey, TValue>(FastBufferReader LJMOCEGEAFH) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E8EB10", Offset = "0x7E8D510", VA = "0x187E8EB10")]
	private static void BLHPPPLJBGB(object PCDAHJCDHHF, FastBufferWriter EDJIMCINKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E91C90", Offset = "0x7E90690", VA = "0x187E91C90")]
	private static object INJGJNIIKMC(FastBufferReader LJMOCEGEAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E8E8A0", Offset = "0x7E8D2A0", VA = "0x187E8E8A0")]
	private static object ADMOIDHENID(FastBufferReader LJMOCEGEAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E92C20", Offset = "0x7E91620", VA = "0x187E92C20")]
	private static void PLLIMPAPDAB(object IKIGJPENHKK, FastBufferWriter EDJIMCINKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum PJHBHKGEEAK : byte
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
public enum JOJLAKAOABL : byte
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
public static class NKINACJFOAK
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7E931F0", Offset = "0x7E91BF0", VA = "0x187E931F0")]
	public static NetworkDelivery HFPGNCAMPOD(this JOJLAKAOABL LCEOOMLIECC)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum CHJMDLMNJLL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	All,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AIJLKOBFKFM : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly AIJLKOBFKFM MCHDAMDLAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public PJHBHKGEEAK AELFLDBMHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte JKLIOCPILDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public int[] CBILEFGNGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public CHJMDLMNJLL LHMCBIMBHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte GMDOJIDENGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public EAJNGKEHNGE MMDLNPCBDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int LAPJAGIMEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public object FAODEMGJJOP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3003520", Offset = "0x3001F20", VA = "0x183003520", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E8E120", Offset = "0x7E8CB20", VA = "0x187E8E120")]
	public AIJLKOBFKFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EAJNGKEHNGE
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly EAJNGKEHNGE MCHDAMDLAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public byte HPAKLCJONBH;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const byte HOMLABBFOMJ = 1;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const byte BKKKONHCLKP = 2;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const byte DJLMGHGBPAM = 4;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const byte NLNDDHJNLBE = 8;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xC80C60", Offset = "0xC7F660", VA = "0x180C80C60")]
	public EAJNGKEHNGE(byte OIEBFFBCJGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FJPDAJLMDBL : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7E8E200", Offset = "0x7E8CC00", VA = "0x187E8E200")]
	public FJPDAJLMDBL(IDictionary<object, object> FHONBPKKLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum FFOGKBCAKFM
{

}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum BPBABNOPOCJ : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct AGHBIAILNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float CBPCNABIALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float CBOHEKOGGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float KJDMNPADKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float KEOEKIBOANH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x11EB8E0", Offset = "0x11EA2E0", VA = "0x1811EB8E0")]
	public Quaternion LLNJOLANJGO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x11EB8E0", Offset = "0x11EA2E0", VA = "0x1811EB8E0")]
	public static AGHBIAILNNK PKLMPHHLJBD(Quaternion GCGGMEIBGPH)
	{
		return default(AGHBIAILNNK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct IDBEAEJFIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float CBPCNABIALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float CBOHEKOGGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public float KJDMNPADKBF;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1B58030", Offset = "0x1B56A30", VA = "0x181B58030")]
	public Vector3 LACAFBIFGFH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1B58030", Offset = "0x1B56A30", VA = "0x181B58030")]
	public static IDBEAEJFIDK EIMEEKDELAB(Vector3 OLBOHDBOEOB)
	{
		return default(IDBEAEJFIDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JHKHBIEFDFJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public int POMLBANDIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte CFPJABNCACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int DAMMFFLKPCG;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6EF0", Offset = "0x3AC58F0", VA = "0x183AC6EF0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> IKCNAPIHBJG) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public JHKHBIEFDFJ()
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
