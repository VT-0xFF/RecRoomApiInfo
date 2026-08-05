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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JEBFHIILEJP : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public byte HJJMMBDOHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public DFHGKHIBBFL GLOPHGLHFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public LAAOOMKIIJB DEDBOEEPODF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3E23050", Offset = "0x3E21A50", VA = "0x183E23050", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JEBFHIILEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CKGOBLHCBGP : byte
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
public struct PEKLLKJMIKD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte[] BLPDDGCLNPE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3F64E60", Offset = "0x3F63860", VA = "0x183F64E60", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HNCDJDOFBFJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public short DCPCMDOGPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int OJKPBNEAAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int NOJMGAAAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public string KAALHHOJNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public string LBGIPDADNFK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9AF0", Offset = "0x3DD84F0", VA = "0x183DD9AF0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KMLOCONGDLI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector2 AFLPBMPBNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector2 OEABECNAIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Vector2 GABNKBOKMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Vector2 NNJLHECGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Vector2 LNKOFCFLHIP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3E5DF60", Offset = "0x3E5C960", VA = "0x183E5DF60", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KPPBGBEPKAN : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte BLJHNKFKCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public byte JABPCPODJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int KKGECNGDNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Vector3 PFFEHHLOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Quaternion EJIAAHNMHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float NPDJEPBEIEP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E69CF0", Offset = "0x3E686F0", VA = "0x183E69CF0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct AGOFFLGFINB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool KJBENAKINMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 AIOBIOOBAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion ECCDGFAJEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float NKLJDLEGOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool IJFHKGMKOLI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x32D6B20", Offset = "0x32D5520", VA = "0x1832D6B20", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GFGFKOILLOB : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public string KMAFNKGMDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int KABGMIEBEFC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DAD3E0", Offset = "0x3DABDE0", VA = "0x183DAD3E0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FBOEILIOPOD : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public string[] FGMLMAHOEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int MMCHGFGIAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public int JNJLPMKEBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool IMMHDOIODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool PMANJMEDLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool CJBINPFGANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool NAHICDLBJPG;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D67D90", Offset = "0x3D66790", VA = "0x183D67D90", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HAPBGMFBDJJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public string IELIBBNCJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public string LCPPOCBPBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public AHALKNGBICG LAHJCJBOHHP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD560", Offset = "0x3DBBF60", VA = "0x183DBD560", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HLDNIJHKHHJ : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool ANDPHKADADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public MBDNFBNELBA KALMEDGIGPJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE7C0", Offset = "0x3DCD1C0", VA = "0x183DCE7C0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MBDNFBNELBA : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum GPENLMELJGH : byte
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
	public GPENLMELJGH CEJBAGGEAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public ulong MGCNNJFGDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public ulong FEGLCMOMHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public EOALOEPEOPM[] BJDGKFAIEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public AHALKNGBICG FEEOBPILJOE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3E87420", Offset = "0x3E85E20", VA = "0x183E87420", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EOALOEPEOPM : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Flags]
	public enum HCAJPKOEIDK : byte
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
	public HCAJPKOEIDK CEJBAGGEAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public ulong KAJNACGJJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public string IELIBBNCJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int KPCCLFNHPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public string LCPPOCBPBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public AHALKNGBICG OJACAPGOHMD;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C14BD0", Offset = "0x3C135D0", VA = "0x183C14BD0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HHFLCHDLCNI : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public ulong AIIFEFIEINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public MBDNFBNELBA DEHEBIEKBPF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBE70", Offset = "0x3DCA870", VA = "0x183DCBE70", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct AHALKNGBICG : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Dictionary<object, object> AFPBILBCKEL;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x32D6D00", Offset = "0x32D5700", VA = "0x1832D6D00", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DPIMOAMCODE
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum PPLKGABJBGE : byte
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
	private delegate void FMEEFOFDNBN(object BLPDDGCLNPE, FastBufferWriter EAPDKLFLMNB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private delegate object IEBBEKHJIMA(FastBufferReader DIKMKPGIBMB);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PEMDOHJNNNH<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public PPLKGABJBGE serverSerializedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PEMDOHJNNNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA1170", Offset = "0x5C9FB70", VA = "0x185CA1170")]
		internal void FJCLGGKDLGI(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA15F0", Offset = "0x5C9FFF0", VA = "0x185CA15F0")]
		internal object KLMKBKJKNAM(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class APBDDDHKMGM<TType, TNetworkType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public PPLKGABJBGE serializedAs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Func<TType, TNetworkType> serialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Func<TNetworkType, TType> deserialize;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public APBDDDHKMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x54E7040", Offset = "0x54E5A40", VA = "0x1854E7040")]
		internal void KPHPEFAJDGM(object o, FastBufferWriter w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x54E6370", Offset = "0x54E4D70", VA = "0x1854E6370")]
		internal object BNNGODMLOPC(FastBufferReader r)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, PPLKGABJBGE> KLDPLIGEHEI;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Dictionary<PPLKGABJBGE, Type> ALHFEEIBHJG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Dictionary<PPLKGABJBGE, FMEEFOFDNBN> LIPNINIPAAH;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<PPLKGABJBGE, IEBBEKHJIMA> IJDOMIGEIKH;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Dictionary<PPLKGABJBGE, PPLKGABJBGE> MEFDICFMLLO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly Dictionary<PPLKGABJBGE, Type> PDFGNNJLMFL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x86447A0", Offset = "0x86431A0", VA = "0x1886447A0")]
	static DPIMOAMCODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8644510", Offset = "0x8642F10", VA = "0x188644510")]
	public static void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x863FF00", Offset = "0x863E900", VA = "0x18863FF00")]
	public static void GCGCKFHBJPB(object BLPDDGCLNPE, FastBufferWriter EAPDKLFLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8643D00", Offset = "0x8642700", VA = "0x188643D00")]
	public static object LEOAOCFGODA(FastBufferReader DIKMKPGIBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD5E0", Offset = "0x3BDBFE0", VA = "0x183BDD5E0")]
	public static void ENJBDMNKCMB<TType, TNetworkType>(PPLKGABJBGE KPLAKHFNHAG, Func<TType, TNetworkType> EMLCPAPNCFC, Func<TNetworkType, TType> AOHDNKDFHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBD80", Offset = "0x3BDA780", VA = "0x183BDBD80")]
	private static void CIJMMGNGKAJ<TType, TNetworkType>(PPLKGABJBGE KPLAKHFNHAG, Func<TType, TNetworkType> EMLCPAPNCFC, Func<TNetworkType, TType> AOHDNKDFHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x863F6D0", Offset = "0x863E0D0", VA = "0x18863F6D0")]
	private static void ENJBDMNKCMB(Type DGNODDPLLPC, PPLKGABJBGE KPLAKHFNHAG, FMEEFOFDNBN PBDBEEANHHD, IEBBEKHJIMA PAKCEHPNGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86404B0", Offset = "0x863EEB0", VA = "0x1886404B0")]
	private static void IHMFBFNDJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF2A0", Offset = "0x3BDDCA0", VA = "0x183BDF2A0")]
	private static void JDLDIEDCGNA<T>(PPLKGABJBGE KPLAKHFNHAG) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE36B0", Offset = "0x3BE20B0", VA = "0x183BE36B0")]
	private static void PKOEKOIDCHA<T, T>(PPLKGABJBGE KPLAKHFNHAG) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0EC0", Offset = "0x3BDF8C0", VA = "0x183BE0EC0")]
	private static void NCPPJIKFNMO<T, T>(PPLKGABJBGE KPLAKHFNHAG) where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86436B0", Offset = "0x86420B0", VA = "0x1886436B0")]
	private static void LDCFEJHKBGI(object KMAFNKGMDCF, Type BMPBOCMBNAG, FastBufferWriter EAPDKLFLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x863FDC0", Offset = "0x863E7C0", VA = "0x18863FDC0")]
	private static object FMDOEGIAMIO(FastBufferReader DIKMKPGIBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8643570", Offset = "0x8641F70", VA = "0x188643570")]
	private static object KBJPAFLIPHO(FastBufferReader DIKMKPGIBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x86440E0", Offset = "0x8642AE0", VA = "0x1886440E0")]
	private static object NEDAIPBPACG(FastBufferReader DIKMKPGIBMB, Func<Type, int, IList> AFJOMIGMCGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3120", Offset = "0x3BE1B20", VA = "0x183BE3120")]
	public static void OIFENCEKOKB<T, TKey, TValue>(object KMAFNKGMDCF, FastBufferWriter EAPDKLFLMNB) where T : Dictionary<TKey, TValue>, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD1C0", Offset = "0x3BDBBC0", VA = "0x183BDD1C0")]
	public static object EENPHKDJODK<T, TKey, TValue>(FastBufferReader DIKMKPGIBMB) where T : Dictionary<TKey, TValue>, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8643430", Offset = "0x8641E30", VA = "0x188643430")]
	private static void JAPIFJHPLAM(object KMAFNKGMDCF, FastBufferWriter EAPDKLFLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x863F610", Offset = "0x863E010", VA = "0x18863F610")]
	private static object DBCBGAOKKGP(FastBufferReader DIKMKPGIBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8644680", Offset = "0x8643080", VA = "0x188644680")]
	private static object OLEJBIIHGJE(FastBufferReader DIKMKPGIBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x863FA70", Offset = "0x863E470", VA = "0x18863FA70")]
	private static void FCNAMCODAJC(object FLHOBJPLFGO, FastBufferWriter EAPDKLFLMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DLCNPCDELOH : byte
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
public enum DOFJGODPLMD : byte
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
public enum DFHGKHIBBFL : byte
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
public static class MJONPDKFIMG
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8644C00", Offset = "0x8643600", VA = "0x188644C00")]
	public static NetworkDelivery PNFEALAPCCH(this DFHGKHIBBFL OHJMOLDLBBB)
	{
		return default(NetworkDelivery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum FBNPBNLHOEB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Others,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	All,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	MasterClient
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LAAOOMKIIJB : INetworkSerializable
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static readonly LAAOOMKIIJB IIDHIFPMCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public DOFJGODPLMD NANOLBMJFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte JMBABEFJNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public int[] DDJIFKCLCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public FBNPBNLHOEB FFFGHHLOBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte MHDFIHHIIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public IOAGKFHABLM KOLLJDCMDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public int MBOAIHNGCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public object MIBGBLHGGGJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3E69F30", Offset = "0x3E68930", VA = "0x183E69F30", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8644B90", Offset = "0x8643590", VA = "0x188644B90")]
	public LAAOOMKIIJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class IOAGKFHABLM
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly IOAGKFHABLM IIDHIFPMCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte ENDAEGODJBA;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public const byte BIPBIGACCGG = 1;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public const byte LKLKCOLBBMF = 2;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public const byte FPNLMKDHJAL = 4;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public const byte MOEFALHEEKB = 8;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xD53B50", Offset = "0xD52550", VA = "0x180D53B50")]
	public IOAGKFHABLM(byte GIMHLACLNIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ONMOHDAFGLI : Dictionary<object, object>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8644CE0", Offset = "0x86436E0", VA = "0x188644CE0")]
	public ONMOHDAFGLI(IDictionary<object, object> DDMHDBLMGFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum GOBKMCKDEHO
{

}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum KNOKGHCBDMJ : uint
{

}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct CPPFHMKDIDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float FKPKEFAKAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float KEEMKILMOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float JLNCPHFMCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public float LIPBKGAOLBA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1358220", Offset = "0x1356C20", VA = "0x181358220")]
	public Quaternion AJCGGHCCOIB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1358220", Offset = "0x1356C20", VA = "0x181358220")]
	public static CPPFHMKDIDA LCPCKKHJFLP(Quaternion CBOIBLPMPEG)
	{
		return default(CPPFHMKDIDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct CALJPKGLCLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float FKPKEFAKAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float KEEMKILMOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public float JLNCPHFMCKO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D67E40", Offset = "0x1D66840", VA = "0x181D67E40")]
	public Vector3 NAGAKEPDCAA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1D67E40", Offset = "0x1D66840", VA = "0x181D67E40")]
	public static CALJPKGLCLP IMKHEHIJOOB(Vector3 JNGAOHODOLH)
	{
		return default(CALJPKGLCLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HLJGBOEAMOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public string CGPNBEBFGEL;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
	public string FJPFJPHEMHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x14C5170", Offset = "0x14C3B70", VA = "0x1814C5170")]
	public static HLJGBOEAMOB EFGEBPJMEFP(string MIILEPFCEHF)
	{
		return default(HLJGBOEAMOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BCDHLDHAHEA : INetworkSerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public int DMAHNMHJCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte HJJMMBDOHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int MPDLGMADCKH;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B245B0", Offset = "0x3B22FB0", VA = "0x183B245B0", Slot = "4")]
	public void NetworkSerialize<T>(BufferSerializer<T> PKOJFJHILAH) where T : IReaderWriter
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BCDHLDHAHEA()
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
