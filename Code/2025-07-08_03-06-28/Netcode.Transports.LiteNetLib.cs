using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, DANJCKOBNED
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum CAOJJPIPDAN
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			Server,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Client
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Tooltip("The port to listen on (if server) or connect to (if client)")]
		public ushort Port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Tooltip("The address to connect to as client; ignored if server")]
		public string Address;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Tooltip("Interval between ping packets used for detecting latency and checking connection, in seconds")]
		public float PingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Tooltip("Maximum duration for a connection to survive without receiving packets, in seconds")]
		public float DisconnectTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Tooltip("Delay between connection attempts, in seconds")]
		public float ReconnectDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Tooltip("Maximum connection attempts before client stops and reports a disconnection")]
		public int MaxConnectAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Tooltip("Size of default buffer for decoding incoming packets, in bytes")]
		public int MessageBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Tooltip("Simulated chance for a packet to be \"lost\", from 0 (no simulation) to 100 percent")]
		public int SimulatePacketLossChance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Tooltip("Simulated minimum additional latency for packets in milliseconds (0 for no simulation)")]
		public int SimulateMinLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Tooltip("Simulated maximum additional latency for packets in milliseconds (0 for no simulation")]
		public int SimulateMaxLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NetworkManager ENFMAKKMJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool ADECLJHDFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, FBMALIKLNCJ> ABEIMEKKEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LINJHPCDDKM OFLCAHLDNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch DOMDPABKCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] DOCIOLEPGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CAOJJPIPDAN DLHEELFKGMM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int DDGJBOCBJKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x72D1290", Offset = "0x72D0090", VA = "0x1872D1290")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong IBKHPKNCBOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool EPMABMHEINC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x72D1270", Offset = "0x72D0070", VA = "0x1872D1270", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72D0860", Offset = "0x72CF660", VA = "0x1872D0860")]
		public void RecRoom_SetEncryptionInfo(ulong HDJJMKMOJBH, byte[] MAHBBBBCDEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72D0840", Offset = "0x72CF640", VA = "0x1872D0840")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72D0710", Offset = "0x72CF510", VA = "0x1872D0710")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72D1170", Offset = "0x72CFF70", VA = "0x1872D1170")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72D0980", Offset = "0x72CF780", VA = "0x1872D0980", Slot = "6")]
		public override void Send(ulong KLGOHLFABCA, ArraySegment<byte> BOIPFNOKGBJ, NetworkDelivery JHLLEFBBDIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72D0800", Offset = "0x72CF600", VA = "0x1872D0800", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong KLGOHLFABCA, [Out] ArraySegment<byte> OFCPJKNFOPJ, [Out] float KGMNOMKJOPI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72D0C70", Offset = "0x72CFA70", VA = "0x1872D0C70", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72D0F90", Offset = "0x72CFD90", VA = "0x1872D0F90", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72CFE20", Offset = "0x72CEC20", VA = "0x1872CFE20", Slot = "11")]
		public override void DisconnectRemoteClient(ulong KLGOHLFABCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72CFD30", Offset = "0x72CEB30", VA = "0x1872CFD30", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72CFF30", Offset = "0x72CED30", VA = "0x1872CFF30", Slot = "13")]
		public override ulong GetCurrentRtt(ulong KLGOHLFABCA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72D0C00", Offset = "0x72CFA00", VA = "0x1872D0C00", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72D0200", Offset = "0x72CF000", VA = "0x1872D0200", Slot = "15")]
		public override void Initialize([Optional] NetworkManager ENFMAKKMJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72D0410", Offset = "0x72CF210", VA = "0x1872D0410")]
		private DHAHIIKHGDB KMHKLFEKGPI(NetworkDelivery DGPNPBEKOOD)
		{
			return default(DHAHIIKHGDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72D05F0", Offset = "0x72CF3F0", VA = "0x1872D05F0", Slot = "16")]
		private void NJBHMOFKFJN(FBMALIKLNCJ OJALPHNBPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72CFC60", Offset = "0x72CEA60", VA = "0x1872CFC60", Slot = "17")]
		private void CHBGGJMILMO(FBMALIKLNCJ OJALPHNBPCK, LKNJIGCMGEF FPPOBAEPJMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "18")]
		private void LMKDJDEBOOA(IPEndPoint INPLPAFLMAP, SocketError GEIKNNFIHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72CFFD0", Offset = "0x72CEDD0", VA = "0x1872CFFD0", Slot = "19")]
		private void HJLEMMGKDAM(FBMALIKLNCJ OJALPHNBPCK, LFGHLOAPEBM DGMHJDFFMEI, byte ALPONJBGGGD, DHAHIIKHGDB LGLPNNEKFJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72D04E0", Offset = "0x72CF2E0", VA = "0x1872D04E0")]
		private void KOKEJLMIOIN(int DFCCCGNJINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "20")]
		private void FKFLMHHOMND(IPEndPoint OADGDMJJNMM, LFGHLOAPEBM DGMHJDFFMEI, MKPMMEPOLPM IKGGDIGKPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "21")]
		private void GHEDGLPFLNI(FBMALIKLNCJ OJALPHNBPCK, int DNIGNFJGKEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72D06B0", Offset = "0x72CF4B0", VA = "0x1872D06B0", Slot = "22")]
		private void ODCJLNAFBJG(BDJLCELOABP OHNONCFAIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72CFC30", Offset = "0x72CEA30", VA = "0x1872CFC30")]
		private ulong BGHKIANHMOK(FBMALIKLNCJ OJALPHNBPCK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72CFC10", Offset = "0x72CEA10", VA = "0x1872CFC10")]
		private ulong BGHKIANHMOK(ulong KLGOHLFABCA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72D01E0", Offset = "0x72CEFE0", VA = "0x1872D01E0")]
		private static int IKELIJBGNEO(float JMOMPNOKIIJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72D1190", Offset = "0x72CFF90", VA = "0x1872D1190")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72D05C0", Offset = "0x72CF3C0", VA = "0x1872D05C0")]
		[CompilerGenerated]
		private void NOGFDDDENKJ(ulong NIFKACMABIF, int HEKOKNGCFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72D05C0", Offset = "0x72CF3C0", VA = "0x1872D05C0")]
		[CompilerGenerated]
		private void LNFDFEFKMBL(ulong NIFKACMABIF, int HEKOKNGCFAG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class CDELGMMONAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly FBMALIKLNCJ JDNGKONNGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<FKMDPMBAJBI> AKLIOHNHMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int OLBCIFJHACN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ADBMNNJIOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72BBE70", Offset = "0x72BAC70", VA = "0x1872BBE70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72BBF80", Offset = "0x72BAD80", VA = "0x1872BBF80")]
	protected CDELGMMONAJ(FBMALIKLNCJ OJALPHNBPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72BBE10", Offset = "0x72BAC10", VA = "0x1872BBE10")]
	public void CKCGLGGIIMF(FKMDPMBAJBI PMOFLFIBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72BBEC0", Offset = "0x72BACC0", VA = "0x1872BBEC0")]
	protected void INKBCMEOBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72BBF40", Offset = "0x72BAD40", VA = "0x1872BBF40")]
	public bool LDLMHBBIEDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool ANLGNJPOJOC();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool HCLNGIMLIEP(FKMDPMBAJBI PMOFLFIBNJE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum PADNLHDPPHM
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BDJLCELOABP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly LINJHPCDDKM OAMJHOPGEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int LLKANGPODOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal OEGNOEICAAH IFCMCFHKLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint LLJEHKNJDIB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal PADNLHDPPHM PCINKEMPDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA80B80", Offset = "0xA7F980", VA = "0x180A80B80")]
		[CompilerGenerated]
		get
		{
			return default(PADNLHDPPHM);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE78700", Offset = "0xE77500", VA = "0x180E78700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72BB8C0", Offset = "0x72BA6C0", VA = "0x1872BB8C0")]
	internal void GKAKGKCMGCB(OEGNOEICAAH OGNBOPBMODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72BB890", Offset = "0x72BA690", VA = "0x1872BB890")]
	private bool EPMKOGNNNPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72BB980", Offset = "0x72BA780", VA = "0x1872BB980")]
	internal BDJLCELOABP(IPEndPoint OADGDMJJNMM, OEGNOEICAAH JALJGMDGEMI, LINJHPCDDKM KBACIIPKKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72BB920", Offset = "0x72BA720", VA = "0x1872BB920")]
	public FBMALIKLNCJ OHOANICCJEF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MKPMMEPOLPM
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum LINNGFEAACP
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LKNJIGCMGEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public LINNGFEAACP LBMAJEFHCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError JPJDJHNJMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public LFGHLOAPEBM DFHOCGBJPDH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DANJCKOBNED
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADPHNGMNPAE(FBMALIKLNCJ OJALPHNBPCK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHIGCPHHGIK(FBMALIKLNCJ OJALPHNBPCK, LKNJIGCMGEF FPPOBAEPJMG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGIKKDOFMKF(IPEndPoint INPLPAFLMAP, SocketError GEIKNNFIHIN);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPENPADAPEG(FBMALIKLNCJ OJALPHNBPCK, LFGHLOAPEBM DGMHJDFFMEI, byte ALPONJBGGGD, DHAHIIKHGDB LGLPNNEKFJJ);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKAHGDKPFOD(IPEndPoint OADGDMJJNMM, LFGHLOAPEBM DGMHJDFFMEI, MKPMMEPOLPM IKGGDIGKPEC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIGCADLFPAE(FBMALIKLNCJ OJALPHNBPCK, int DNIGNFJGKEM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJIJPDNGGNE(BDJLCELOABP OHNONCFAIKH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FPOPNIGLJPE
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIKFCMCAHEA(FBMALIKLNCJ OJALPHNBPCK, object PDLPCFHCPCF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHBNPKMEGHG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DINMACMMNFJ(INDMOPOMHDM PMOFLFIBNJE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BHDPGMJLDNO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJFHFKGFOIA(FBMALIKLNCJ OJALPHNBPCK, IPEndPoint LDMIEPDJGKF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class OEGNOEICAAH
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int NGEBKIMNCKD = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long NCNNMGEFCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte MKACPPMFBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] PJGPOACDBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly NEKODMMOJNC HBHDBEHHINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int MOALMNIIMDI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72D2A80", Offset = "0x72D1880", VA = "0x1872D2A80")]
	private OEGNOEICAAH(long OJOKCMIBMPO, byte OIIHHIANJOL, int OPKFGAAECNB, byte[] AGKLDBECJLE, NEKODMMOJNC BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72D2620", Offset = "0x72D1420", VA = "0x1872D2620")]
	public static int FNBHBDLKDLC(FKMDPMBAJBI PMOFLFIBNJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72D2680", Offset = "0x72D1480", VA = "0x1872D2680")]
	public static OEGNOEICAAH HCDGDACGILB(FKMDPMBAJBI PMOFLFIBNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72D28A0", Offset = "0x72D16A0", VA = "0x1872D28A0")]
	public static FKMDPMBAJBI KLHCPGOEBDG(JCCNOMGAOJM JGDAAHGKDLA, SocketAddress BMBKOBMKOML, long IEHAHIJNALL, int OPKFGAAECNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class MEHMFPPMFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long NCNNMGEFCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte MKACPPMFBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int MOALMNIIMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool LPMHDLHLJON;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72D1760", Offset = "0x72D0560", VA = "0x1872D1760")]
	private MEHMFPPMFHA(long OJOKCMIBMPO, byte OIIHHIANJOL, int DLPKGHINOLG, bool DGNBIKNCNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72D1420", Offset = "0x72D0220", VA = "0x1872D1420")]
	public static MEHMFPPMFHA HCDGDACGILB(FKMDPMBAJBI PMOFLFIBNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72D1570", Offset = "0x72D0370", VA = "0x1872D1570")]
	public static FKMDPMBAJBI KLHCPGOEBDG(long IEHAHIJNALL, byte MPHJGENFEOP, int OHDHAPMIHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72D1660", Offset = "0x72D0460", VA = "0x1872D1660")]
	public static FKMDPMBAJBI OOCBHDJCMML(FBMALIKLNCJ OJALPHNBPCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum CDBPCJJCMGL
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FGNOOIKENBG
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIABPACIALB(IPEndPoint BNELNCJMPNF, IPEndPoint OADGDMJJNMM, string OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAJBNEJENJP(IPEndPoint PCJJHONONFI, CDBPCJJCMGL DGPNPBEKOOD, string OCGDLEBGIMO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KLBICLHMNII
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct LMHFBIOHNPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint OLKAMBGBADJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint LLJEHKNJDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string CJNIBOMEOPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct JCCCHAOCAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint AEAPDDHLPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CDBPCJJCMGL KICDHMJGHJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string CJNIBOMEOPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class PHAFMEABOBE
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint JEMEFOKDDGK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string CJNIBOMEOPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PHAFMEABOBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class AMJMDLMABIB
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint JEMEFOKDDGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint IGGNLJCEIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string CJNIBOMEOPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AMJMDLMABIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class CGBFDNIGCMF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string CJNIBOMEOPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool OPGAAKCNLHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAA5A0", Offset = "0xAA93A0", VA = "0x180AAA5A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA5AE90", Offset = "0xA59C90", VA = "0x180A5AE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CGBFDNIGCMF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly LINJHPCDDKM NHILEMKMFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<LMHFBIOHNPP> GHKJADHMDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<JCCCHAOCAMA> IMJCBNNBCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NEKODMMOJNC HOEMINBBHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly JCCNOMGAOJM LGDGGDAEFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly BMHHECMBCJL OHHNJBDNNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private FGNOOIKENBG FHGKMNONGGD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int EOGFCFPFCGF = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool FCJBMFODJDE;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72C7570", Offset = "0x72C6370", VA = "0x1872C7570")]
	internal KLBICLHMNII(LINJHPCDDKM MIHMKABLMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72C7290", Offset = "0x72C6090", VA = "0x1872C7290")]
	internal void LAEENONNPEH(IPEndPoint PPAJPANPDIL, FKMDPMBAJBI PMOFLFIBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C44380", Offset = "0x3C43180", VA = "0x183C44380")]
	private void EACNAGEECPA<T>(T PMOFLFIBNJE, IPEndPoint IMBAOPHEODM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72C6F70", Offset = "0x72C5D70", VA = "0x1872C6F70")]
	private void EIABPACIALB(PHAFMEABOBE EEGBEKPHEAJ, IPEndPoint PPAJPANPDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72C7410", Offset = "0x72C6210", VA = "0x1872C7410")]
	private void LDIIMEBBCLH(AMJMDLMABIB EEGBEKPHEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72C7100", Offset = "0x72C5F00", VA = "0x1872C7100")]
	private void HMCFAOKGINM(CGBFDNIGCMF EEGBEKPHEAJ, IPEndPoint PPAJPANPDIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum DHAHIIKHGDB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum BHAODPMENNM : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class LNHKKDJDNFO
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] PGOILMCGHDE;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int MMNIBJGCCGP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int GMAJAFMMGJG;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GHEEEEJPAGO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72BDE20", Offset = "0x72BCC20", VA = "0x1872BDE20")]
	public GHEEEEJPAGO(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MHEHCEBPPIJ : GHEEEEJPAGO
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72BDE20", Offset = "0x72BCC20", VA = "0x1872BDE20")]
	public MHEHCEBPPIJ(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum IOCCPBOHJKC
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OHABPKMJOMF
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHFEPPNGDLD(IOCCPBOHJKC IMNDNPEIBOP, string JFJICNCOLKA, params object[] ENDEOBGIMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DGGAPIPPAMD
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static OHABPKMJOMF AMIGKEPFDCC;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object MCCJOKBAGLA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72BDAA0", Offset = "0x72BC8A0", VA = "0x1872BDAA0")]
	private static void PAHIFLGAHHA(IOCCPBOHJKC IKJONFOBABH, string JFJICNCOLKA, params object[] ENDEOBGIMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72BDA40", Offset = "0x72BC840", VA = "0x1872BDA40")]
	internal static void KOGHPDFBIHK(string JFJICNCOLKA, params object[] ENDEOBGIMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72BD980", Offset = "0x72BC780", VA = "0x1872BD980")]
	internal static void FAHPEDHDEFD(string JFJICNCOLKA, params object[] ENDEOBGIMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72BD9E0", Offset = "0x72BC7E0", VA = "0x1872BD9E0")]
	internal static void IACMCHJCABK(string JFJICNCOLKA, params object[] ENDEOBGIMGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum PJEHFHIECHO
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LFGHLOAPEBM : NEKODMMOJNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private FKMDPMBAJBI DKBIJEGICGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly LINJHPCDDKM IBKLGHNMDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly CBIIGMPOGND CGPMCNNFGGG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72C7AE0", Offset = "0x72C68E0", VA = "0x1872C7AE0")]
	internal LFGHLOAPEBM(LINJHPCDDKM HEJIJKOGOJP, CBIIGMPOGND CCJDFKPDEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72C79F0", Offset = "0x72C67F0", VA = "0x1872C79F0")]
	internal void EEOLDDKKGGO(FKMDPMBAJBI PMOFLFIBNJE, int GIHKNBJAJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x72C7A60", Offset = "0x72C6860", VA = "0x1872C7A60")]
	internal void ONBMFKNKMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x72C79C0", Offset = "0x72C67C0", VA = "0x1872C79C0")]
	public void COJIBIKNJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class CBIIGMPOGND
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum JFNAHGCIFBA
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public CBIIGMPOGND CPHACEBIHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public JFNAHGCIFBA KICDHMJGHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public FBMALIKLNCJ JDNGKONNGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint LLJEHKNJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object DHKLDCDAGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int DCIMMMGIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError NCMGDHLDJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public LINNGFEAACP MJONCGACHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public BDJLCELOABP KFAEDOPOBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public DHAHIIKHGDB GNCHCBDADGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte COCDIJEFLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly LFGHLOAPEBM CGACIAEFCPL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x72BBD70", Offset = "0x72BAB70", VA = "0x1872BBD70")]
	public CBIIGMPOGND(LINJHPCDDKM HEJIJKOGOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LINJHPCDDKM : IEnumerable<FBMALIKLNCJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class CJLBNJMOKLJ : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72BC840", Offset = "0x72BB640", VA = "0x1872BC840", Slot = "4")]
		public bool Equals(IPEndPoint DHOMBGCEEAK, IPEndPoint EDBCCDDDLPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D620", Offset = "0x6E2C420", VA = "0x186E2D620", Slot = "5")]
		public int GetHashCode(IPEndPoint MKPNGAKJFMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CJLBNJMOKLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct MJGPGKFNFBH : IEnumerator<FBMALIKLNCJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly FBMALIKLNCJ PBMOCKHCBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private FBMALIKLNCJ GIKOGMDBGJO;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public FBMALIKLNCJ BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAE3600", Offset = "0xAE2400", VA = "0x180AE3600", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAE3600", Offset = "0xAE2400", VA = "0x180AE3600", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D5C0", Offset = "0x1C1C3C0", VA = "0x181C1D5C0")]
		public MJGPGKFNFBH(FBMALIKLNCJ JEDAAEHCPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72D17B0", Offset = "0x72D05B0", VA = "0x1872D17B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72D1800", Offset = "0x72D0600", VA = "0x1872D1800", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread JNNHKDIILKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool NAPBMFJEAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool MPLCDCKODAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private NDILENHOCDJ MLEBOMELIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent PBLJCDCALND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<CBIIGMPOGND> AIMCJABAFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<CBIIGMPOGND> DFKOFAEICDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private CBIIGMPOGND ABEMCODGCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly DANJCKOBNED CDFKCNGAJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FPOPNIGLJPE AKJEOFHHMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly JHBNPKMEGHG NKEHPENKDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly BHDPGMJLDNO NNBGJPFGJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, FBMALIKLNCJ> ABFLGIGJEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, BDJLCELOABP> HNGAGKNGDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, NBFJOBFGLLA> FPLHLAJJLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim MFEFICCPOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private FBMALIKLNCJ GGEFGDNEBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int NDDDHCJCLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<FBMALIKLNCJ> FADEEDCIDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private FBMALIKLNCJ[] EKEHOBABJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly CIHAJJCMMGN JCFELPHFMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int KOLFNJPNEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> BIIELBPMKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte PJLMENGJIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object DOFGALOKNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool JNPHIFKGMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool EGACIFFACFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CEGOIAKHJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int GBFGCCJGKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int KJKCOALMGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int IECHBDMKGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool ANPGKOPBLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool CBDELPGKBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int LJIEBCDDDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int ANPELJHMKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int KGFEHNLFABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool FCJBMFODJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool DEACPOCMFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool LNKDGDFNKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool INAPNGBIJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int JFBLFECFHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int BBDEBOBMADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool JHHOCECEACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly HNHJAIHAEGG MOFGMIBPJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool CMMLNMCHJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly KLBICLHMNII BNEBLOFDGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool BPELLMBCDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public PJEHFHIECHO KKEGDDNEBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int PIOKHADEBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool JOCIGJAGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool JJFINAOAMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool EFEGDLOJPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool DIKAIFBKGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private FKMDPMBAJBI DEOOMEBOFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int AJAMKMGLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object AJCFGOAKELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private FKMDPMBAJBI AODLNHHOFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int FMPCIFMJBID;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int MBLEGPMBEDB = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int IIMOGICNAGI = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AJAPJFBIIMH GOIJLJJEOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AJAPJFBIIMH GLPCNHHPDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread NPIBHDLKPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread OBNIALHLAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint CHFJHICGICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint AOLKEJEOIOB;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] NDKMEGMDOAH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] GJAMDKLBFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<GGHOOEIGHOC, IPEndPoint> ONAGONOEDAL;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress APLHOCGIJHC;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool BAOLLGCGONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int GPJHGEPEAGD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool HNHHLPMALBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBABE80", Offset = "0xBAAC80", VA = "0x180BABE80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBADE80", Offset = "0xBACC80", VA = "0x180BADE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PNDLHAADMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1757000", Offset = "0x1755E00", VA = "0x181757000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x20659A0", Offset = "0x20647A0", VA = "0x1820659A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte GKIOIGJLBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1027E10", Offset = "0x1026C10", VA = "0x181027E10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AKHAODMBMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72CC000", Offset = "0x72CAE00", VA = "0x1872CC000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short LNMKMHNLECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72CE730", Offset = "0x72CD530", VA = "0x1872CE730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FBMALIKLNCJ.IOEFAGLKKNE NGJINPEMKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72CA340", Offset = "0x72C9140", VA = "0x1872CA340")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72C7B30", Offset = "0x72C6930", VA = "0x1872C7B30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72CB220", Offset = "0x72CA020", VA = "0x1872CB220")]
	public void FOAPNFDCHPO(IPEndPoint INPLPAFLMAP, byte[] MAHBBBBCDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x72CAD60", Offset = "0x72C9B60", VA = "0x1872CAD60")]
	public void FILLPBBHODG(IPEndPoint INPLPAFLMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72CA410", Offset = "0x72C9210", VA = "0x1872CA410")]
	private bool EONFLIBBLJP(IPEndPoint INPLPAFLMAP, [Out] FBMALIKLNCJ OJALPHNBPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72CCB70", Offset = "0x72CB970", VA = "0x1872CCB70")]
	private void JLKJEHIONMB(FBMALIKLNCJ OJALPHNBPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x72CD280", Offset = "0x72CC080", VA = "0x1872CD280")]
	private void KBGNPCNBNJP(FBMALIKLNCJ OJALPHNBPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72CA020", Offset = "0x72C8E20", VA = "0x1872CA020")]
	private void DEOFINNDKOM(FBMALIKLNCJ OJALPHNBPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72CF4D0", Offset = "0x72CE2D0", VA = "0x1872CF4D0")]
	public LINJHPCDDKM(DANJCKOBNED KBACIIPKKOA, [Optional] CIHAJJCMMGN ANAPNPGPMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72CA2F0", Offset = "0x72C90F0", VA = "0x1872CA2F0")]
	internal void DFOPDMELHAO(FBMALIKLNCJ LPAINLMLLNM, int DNIGNFJGKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x72CC290", Offset = "0x72CB090", VA = "0x1872CC290")]
	internal void ILGJHPILFMO(FBMALIKLNCJ LPAINLMLLNM, object PDLPCFHCPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72CD2E0", Offset = "0x72CC0E0", VA = "0x1872CD2E0")]
	internal void KHAOJEIBEMM(FBMALIKLNCJ OJALPHNBPCK, LINNGFEAACP EGLDLGDMAJN, SocketError PHOHJJIIJGM, FKMDPMBAJBI IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72CD3A0", Offset = "0x72CC1A0", VA = "0x1872CD3A0")]
	private void KMOPKEBLINB(FBMALIKLNCJ OJALPHNBPCK, LINNGFEAACP EGLDLGDMAJN, SocketError PHOHJJIIJGM, bool ADJOPEHJOFG, byte[] BOIPFNOKGBJ, int DKBLEPBOJIC, int LJEIHABMGGI, FKMDPMBAJBI IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72CE350", Offset = "0x72CD150", VA = "0x1872CE350")]
	private void NEANGMFLJKM(CBIIGMPOGND.JFNAHGCIFBA DGPNPBEKOOD, [Optional] FBMALIKLNCJ OJALPHNBPCK, [Optional] IPEndPoint OADGDMJJNMM, SocketError PKDKDIFALGO = SocketError.Success, int DNIGNFJGKEM = 0, LINNGFEAACP JDHHOKDICEK = LINNGFEAACP.ConnectionFailed, [Optional] BDJLCELOABP HEGKFKDNBHP, DHAHIIKHGDB LGLPNNEKFJJ = DHAHIIKHGDB.Unreliable, byte ALPONJBGGGD = 0, [Optional] FKMDPMBAJBI OHEPKKJCKLO, [Optional] object PDLPCFHCPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x72CA5C0", Offset = "0x72C93C0", VA = "0x1872CA5C0")]
	private void FHHIPIOOAJJ(CBIIGMPOGND CCJDFKPDEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72CA4B0", Offset = "0x72C92B0", VA = "0x1872CA4B0")]
	internal void FCPJLBAJNNN(CBIIGMPOGND CCJDFKPDEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x72CDCD0", Offset = "0x72CCAD0", VA = "0x1872CDCD0")]
	private void MKEHJJMCIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x72CBB60", Offset = "0x72CA960", VA = "0x1872CBB60")]
	private void HBJGMEGLJGM(int JHAABGLDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72C8FD0", Offset = "0x72C7DD0", VA = "0x1872C8FD0")]
	internal FBMALIKLNCJ BBEAEPGNDHI(BDJLCELOABP OHNONCFAIKH, byte[] GLIHPGIPDEH, int DKBLEPBOJIC, int IDFEOHMGIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72CC670", Offset = "0x72CB470", VA = "0x1872CC670")]
	private int IMEGDCBNHAF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72CD820", Offset = "0x72CC620", VA = "0x1872CD820")]
	private void MGFGJEEMJIB(IPEndPoint OADGDMJJNMM, FBMALIKLNCJ PJBAEHNKFNK, OEGNOEICAAH INFNJKMFOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72C7BE0", Offset = "0x72C69E0", VA = "0x1872C7BE0")]
	private void AJEFGKCIIID(FKMDPMBAJBI PMOFLFIBNJE, IPEndPoint OADGDMJJNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72CE7F0", Offset = "0x72CD5F0", VA = "0x1872CE7F0")]
	internal void NKECBBLOGDK(FKMDPMBAJBI PMOFLFIBNJE, DHAHIIKHGDB MNDHCKEIOBG, byte ALPONJBGGGD, int GIHKNBJAJLB, FBMALIKLNCJ LPAINLMLLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72C9E40", Offset = "0x72C8C40", VA = "0x1872C9E40")]
	public bool BCBLGFMJHPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72C9E50", Offset = "0x72C8C50", VA = "0x1872C9E50")]
	public bool BCBLGFMJHPB(IPAddress MCBNEKIPFOA, IPAddress HLOMEFFEKKI, int DEGLCNGNLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72C9DC0", Offset = "0x72C8BC0", VA = "0x1872C9DC0")]
	public bool BCBLGFMJHPB(int DEGLCNGNLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x72C9E70", Offset = "0x72C8C70", VA = "0x1872C9E70")]
	public void BCHELDJICDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x72CB440", Offset = "0x72CA240", VA = "0x1872CB440")]
	public FBMALIKLNCJ FPLNMAMJNDE(string GJENNMCNOND, int DEGLCNGNLDF, string MAHBBBBCDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x72CB900", Offset = "0x72CA700", VA = "0x1872CB900")]
	public FBMALIKLNCJ FPLNMAMJNDE(string GJENNMCNOND, int DEGLCNGNLDF, JCCNOMGAOJM NACBKLCLBAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x72CB520", Offset = "0x72CA320", VA = "0x1872CB520")]
	public FBMALIKLNCJ FPLNMAMJNDE(IPEndPoint IMBAOPHEODM, JCCNOMGAOJM NACBKLCLBAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x72CB210", Offset = "0x72CA010", VA = "0x1872CB210")]
	public void FLFOOBGGHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x72CAEB0", Offset = "0x72C9CB0", VA = "0x1872CAEB0")]
	public void FLFOOBGGHHJ(bool HCGGABOJJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x72CD1D0", Offset = "0x72CBFD0", VA = "0x1872CD1D0")]
	public void JOKHMLPNOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x72CD100", Offset = "0x72CBF00", VA = "0x1872CD100")]
	public void JOKHMLPNOGC(byte[] BOIPFNOKGBJ, int DKBLEPBOJIC, int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x72CD360", Offset = "0x72CC160", VA = "0x1872CD360")]
	public void KMOPKEBLINB(FBMALIKLNCJ OJALPHNBPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x72CD320", Offset = "0x72CC120", VA = "0x1872CD320")]
	public void KMOPKEBLINB(FBMALIKLNCJ OJALPHNBPCK, byte[] BOIPFNOKGBJ, int DKBLEPBOJIC, int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x72CF2F0", Offset = "0x72CE0F0", VA = "0x1872CF2F0", Slot = "4")]
	private IEnumerator<FBMALIKLNCJ> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x72CF380", Offset = "0x72CE180", VA = "0x1872CF380", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x72CE100", Offset = "0x72CCF00", VA = "0x1872CE100")]
	private FKMDPMBAJBI MMAKBPDDBAP(MHDAKOBLOCG DAGPCGHBFAL, int DFCCCGNJINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x72CE020", Offset = "0x72CCE20", VA = "0x1872CE020")]
	private FKMDPMBAJBI MMAKBPDDBAP(MHDAKOBLOCG DAGPCGHBFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x72CCEB0", Offset = "0x72CBCB0", VA = "0x1872CCEB0")]
	internal FKMDPMBAJBI JNGNMLIIAPO(int DFCCCGNJINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x72CC020", Offset = "0x72CAE20", VA = "0x1872CC020")]
	internal void IKFCDDNCFNK(FKMDPMBAJBI PMOFLFIBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x72CF410", Offset = "0x72CE210", VA = "0x1872CF410")]
	static LINJHPCDDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xBABE80", Offset = "0xBAAC80", VA = "0x180BABE80")]
	private bool CCKFJFKMOIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x72CBE80", Offset = "0x72CAC80", VA = "0x1872CBE80")]
	private void HIBGCPFGFDL(IPEndPoint ADJIAONJCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x72CE1F0", Offset = "0x72CCFF0", VA = "0x1872CE1F0")]
	private void MPCGMHPONPF(IPEndPoint ADJIAONJCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72CC9C0", Offset = "0x72CB7C0", VA = "0x1872CC9C0")]
	private bool JCGNMINNICH(SocketException KHPHCONHPBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72CA3F0", Offset = "0x72C91F0", VA = "0x1872CA3F0")]
	private void DPPMCNIENPH(NDILENHOCDJ MIHMKABLMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x72CC6F0", Offset = "0x72CB4F0", VA = "0x1872CC6F0")]
	private void JAEHFMJLHID(AJAPJFBIIMH MIHMKABLMFC, EndPoint NFMGCHEOHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x72CC2E0", Offset = "0x72CB0E0", VA = "0x1872CC2E0")]
	private void ILLDMONGHAK(object EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x72C95F0", Offset = "0x72C83F0", VA = "0x1872C95F0")]
	public bool BCBLGFMJHPB(IPAddress MCBNEKIPFOA, IPAddress HLOMEFFEKKI, int DEGLCNGNLDF, bool NHNFFEPIDKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72CD7C0", Offset = "0x72CC5C0", VA = "0x1872CD7C0")]
	internal int LNCELJEMJHJ(FKMDPMBAJBI PMOFLFIBNJE, IPEndPoint OADGDMJJNMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x72CF2B0", Offset = "0x72CE0B0", VA = "0x1872CF2B0")]
	internal int OBEDHPHHNHI(FKMDPMBAJBI PMOFLFIBNJE, IPEndPoint OADGDMJJNMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x72CEAD0", Offset = "0x72CD8D0", VA = "0x1872CEAD0")]
	internal int OBEDHPHHNHI(byte[] IIHOFBLPONF, int DKBLEPBOJIC, int IDFEOHMGIAF, IPEndPoint OADGDMJJNMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72CB9E0", Offset = "0x72CA7E0", VA = "0x1872CB9E0")]
	internal void GKEBKLJLLAF(bool EFGGFEHNMOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum MHDAKOBLOCG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class FKMDPMBAJBI
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int EDEHEMBFOFM;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] DACBAGPBIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] LLJJMIKAKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int FEILDOFOPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object DHKLDCDAGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public FKMDPMBAJBI CPHACEBIHDG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MHDAKOBLOCG EOFJPGCPGON
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72C2420", Offset = "0x72C1220", VA = "0x1872C2420")]
		get
		{
			return default(MHDAKOBLOCG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72C21E0", Offset = "0x72C0FE0", VA = "0x1872C21E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte MKACPPMFBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72C2450", Offset = "0x72C1250", VA = "0x1872C2450")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x72C23A0", Offset = "0x72C11A0", VA = "0x1872C23A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort FMFDNJBFLBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72C2300", Offset = "0x72C1100", VA = "0x1872C2300")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72C22C0", Offset = "0x72C10C0", VA = "0x1872C22C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OLDOMGCKIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72C2580", Offset = "0x72C1380", VA = "0x1872C2580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte NJDAFLBOJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72C25B0", Offset = "0x72C13B0", VA = "0x1872C25B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72C26E0", Offset = "0x72C14E0", VA = "0x1872C26E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort MANLIOHEPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72C27A0", Offset = "0x72C15A0", VA = "0x1872C27A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72C2360", Offset = "0x72C1160", VA = "0x1872C2360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort CJJEFBLAELH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72C2710", Offset = "0x72C1510", VA = "0x1872C2710")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x72C2220", Offset = "0x72C1020", VA = "0x1872C2220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort MGBGFMOLJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72C2260", Offset = "0x72C1060", VA = "0x1872C2260")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72C23E0", Offset = "0x72C11E0", VA = "0x1872C23E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x72C2800", Offset = "0x72C1600", VA = "0x1872C2800")]
	static FKMDPMBAJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x72C2770", Offset = "0x72C1570", VA = "0x1872C2770")]
	public void NMGOGAJCMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x72C2BF0", Offset = "0x72C19F0", VA = "0x1872C2BF0")]
	public FKMDPMBAJBI(int DFCCCGNJINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x72C2AE0", Offset = "0x72C18E0", VA = "0x1872C2AE0")]
	public FKMDPMBAJBI(MHDAKOBLOCG DAGPCGHBFAL, int DFCCCGNJINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x72C2670", Offset = "0x72C1470", VA = "0x1872C2670")]
	public static int LJLCFNPGMLG(MHDAKOBLOCG DAGPCGHBFAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x72C25E0", Offset = "0x72C13E0", VA = "0x1872C25E0")]
	public int LJLCFNPGMLG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x72C2480", Offset = "0x72C1280", VA = "0x1872C2480")]
	public bool JLCEAKHEPPG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum LOLLEBIANJK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum CJHGNELHKOE
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum NDHCFDMPPLC
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum PKAIDHBMIDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FBMALIKLNCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class IIMMGEDMLPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FKMDPMBAJBI[] HLGKOBCHFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int BBIDJALBMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int PIEAFKCKJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte NJDAFLBOJNE;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IIMMGEDMLPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void IOEFAGLKKNE(ulong NIFKACMABIF, int HEKOKNGCFAG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int MDILONGCFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int MELGKIFLMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int OBHFPHEILDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double ENOBMHFFOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int PMHIJKCLICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int DOOLKHDDDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int EOEDIKNBLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch FOGOMPEBEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int DENFPOGPPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long EOOBNHEKMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object JKKHDACIHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal FBMALIKLNCJ GBFNHCDFNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal FBMALIKLNCJ HOJNEFCOPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<FKMDPMBAJBI> NMGDMBEBBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<CDELGMMONAJ> LIKDLONHFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly CDELGMMONAJ[] HNCKDFKIIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int JIFLGHGBKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int FFDDBPEHNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool NCEGLDHHGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int CPLCGLHBFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int AGJDOAMHBFF;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int AABIBKDJLHP = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int HIICIICDEGO = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object CEKBPMJNKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int NCALJONIKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, IIMMGEDMLPI> APHIGOKNFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> HPPDCLFOFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly FKMDPMBAJBI GOLGCIIPEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int PMECNJNNAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int DABIKKGEOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint DDBMHMPKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int CEGIFOKJFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int NFOKDGDIMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long NIAFOAPEBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte KEOLLHOKHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private LOLLEBIANJK OJIFPOCHCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private FKMDPMBAJBI LMONHNBOACB;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int OEAIPIHGNHL = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int CEHDPLIIJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly FKMDPMBAJBI OBNPHCGJIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly FKMDPMBAJBI EOMOBMBBKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly FKMDPMBAJBI DDBHMEKDPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly FKMDPMBAJBI AKDCDNFLAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private BHAODPMENNM IKMACDJJMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly LINJHPCDDKM AHNKAHKHLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int ACHEFDKJDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object IFKGNKKGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly HNHJAIHAEGG MOFGMIBPJHG;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte HHCIECNJMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB0E520", Offset = "0xB0D320", VA = "0x180B0E520")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72C1960", Offset = "0x72C0760", VA = "0x1872C1960")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint LIPGOCEEIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB0E460", Offset = "0xB0D260", VA = "0x180B0E460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public LOLLEBIANJK LILLHMPHEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB0E4C0", Offset = "0xB0D2C0", VA = "0x180B0E4C0")]
		get
		{
			return default(LOLLEBIANJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long OKBCCDNOGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA65C40", Offset = "0xA64A40", VA = "0x180A65C40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BPCACAHGBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1757000", Offset = "0x1755E00", VA = "0x181757000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x20659A0", Offset = "0x20647A0", VA = "0x1820659A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int MPINNNJFGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x72BE230", Offset = "0x72BD030", VA = "0x1872BE230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int DHEBCFOONKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCFF240", Offset = "0xCFE040", VA = "0x180CFF240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double PKBOBGAMNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4F1D9F0", Offset = "0x4F1C7F0", VA = "0x184F1D9F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event IOEFAGLKKNE NGJINPEMKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72BE780", Offset = "0x72BD580", VA = "0x1872BE780")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x72BDE30", Offset = "0x72BCC30", VA = "0x1872BDE30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72C1BF0", Offset = "0x72C09F0", VA = "0x1872C1BF0")]
	internal FBMALIKLNCJ(LINJHPCDDKM COIANAEOLDO, IPEndPoint OADGDMJJNMM, int PPPFBKMGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72C18F0", Offset = "0x72C06F0", VA = "0x1872C18F0")]
	internal void MKHLDKBJBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72BE750", Offset = "0x72BD550", VA = "0x1872BE750")]
	internal void DJDGJOKKNJB(IPEndPoint COEDDNHHBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x72C1130", Offset = "0x72BFF30", VA = "0x1872C1130")]
	internal void LILNLJBKKGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72BE830", Offset = "0x72BD630", VA = "0x1872BE830")]
	private void DPKFPHDFKFI(int ALKAGPEGIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72BDEE0", Offset = "0x72BCCE0", VA = "0x1872BDEE0")]
	private void ANCLJAIPKJL(int FCPPOLLMJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72C0E20", Offset = "0x72BFC20", VA = "0x1872C0E20")]
	public int KDHJLAFOLOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72C0F30", Offset = "0x72BFD30", VA = "0x1872C0F30")]
	public int KDHJLAFOLOL(byte ALPONJBGGGD, bool PMJAFBAEFBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72BE5A0", Offset = "0x72BD3A0", VA = "0x1872BE5A0")]
	private CDELGMMONAJ BHKCCJAONPG(byte BLFNDPNNLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72C2050", Offset = "0x72C0E50", VA = "0x1872C2050")]
	internal FBMALIKLNCJ(LINJHPCDDKM COIANAEOLDO, IPEndPoint OADGDMJJNMM, int PPPFBKMGIMA, byte MPHJGENFEOP, JCCNOMGAOJM JGDAAHGKDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x72C1A10", Offset = "0x72C0810", VA = "0x1872C1A10")]
	internal FBMALIKLNCJ(LINJHPCDDKM COIANAEOLDO, BDJLCELOABP OHNONCFAIKH, int PPPFBKMGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72C1910", Offset = "0x72C0710", VA = "0x1872C1910")]
	internal void NOIBAHKGNGC(OEGNOEICAAH NALJOLEMJLL, byte[] BOIPFNOKGBJ, int DKBLEPBOJIC, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x72C1050", Offset = "0x72BFE50", VA = "0x1872C1050")]
	internal bool KICKBBHDAGO(MEHMFPPMFHA PMOFLFIBNJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72BE900", Offset = "0x72BD700", VA = "0x1872BE900")]
	public void EACNAGEECPA(byte[] BOIPFNOKGBJ, int DKBLEPBOJIC, int IDFEOHMGIAF, DHAHIIKHGDB LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72C0430", Offset = "0x72BF230", VA = "0x1872C0430")]
	private void IBLBFKCJNPN(byte[] BOIPFNOKGBJ, int DKBLEPBOJIC, int IDFEOHMGIAF, byte ALPONJBGGGD, DHAHIIKHGDB LGLPNNEKFJJ, object PDLPCFHCPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72C0DD0", Offset = "0x72BFBD0", VA = "0x1872C0DD0")]
	public void JCGEKJAIEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72BE930", Offset = "0x72BD730", VA = "0x1872BE930")]
	internal NDHCFDMPPLC EFHNNAMCHIM(FKMDPMBAJBI PMOFLFIBNJE)
	{
		return default(NDHCFDMPPLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72C10D0", Offset = "0x72BFED0", VA = "0x1872C10D0")]
	internal void LECKJIMGOAM(CDELGMMONAJ IIPHFNCJNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x72BDF20", Offset = "0x72BCD20", VA = "0x1872BDF20")]
	internal PKAIDHBMIDJ BAIFCPFAHAC(byte[] BOIPFNOKGBJ, int DKBLEPBOJIC, int IDFEOHMGIAF, bool ADJOPEHJOFG)
	{
		return default(PKAIDHBMIDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72BFD30", Offset = "0x72BEB30", VA = "0x1872BFD30")]
	private void GHLPPNGOAIE(int LGIDEMBDPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72BECD0", Offset = "0x72BDAD0", VA = "0x1872BECD0")]
	internal void FFDANIBDJPG(DHAHIIKHGDB MNDHCKEIOBG, FKMDPMBAJBI JEDAAEHCPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x72C11C0", Offset = "0x72BFFC0", VA = "0x1872C11C0")]
	private void LNGNLFEGKGL(FKMDPMBAJBI PMOFLFIBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x72C0A40", Offset = "0x72BF840", VA = "0x1872C0A40")]
	private void IEPAMMNKPPE(int GJELOGAKDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x72C1730", Offset = "0x72C0530", VA = "0x1872C1730")]
	internal CJHGNELHKOE MGFGJEEMJIB(OEGNOEICAAH INFNJKMFOGN)
	{
		return default(CJHGNELHKOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x72BFD70", Offset = "0x72BEB70", VA = "0x1872BFD70")]
	internal void HCLNGIMLIEP(FKMDPMBAJBI PMOFLFIBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x72BE450", Offset = "0x72BD250", VA = "0x1872BE450")]
	private void BFGCMECLDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x72BE240", Offset = "0x72BD040", VA = "0x1872BE240")]
	internal void BBEBOEABJMH(FKMDPMBAJBI PMOFLFIBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x72BF670", Offset = "0x72BE470", VA = "0x1872BF670")]
	internal void FLCGEBIGNJN(int GJELOGAKDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x72BEA10", Offset = "0x72BD810", VA = "0x1872BEA10")]
	internal void EGPCGEIDGBM(FKMDPMBAJBI PMOFLFIBNJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class HNHJAIHAEGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long BFHFPLKKHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long JLGMENFGEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long CCJMNMFOAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long JGMGKFAKPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long MKOEOIPPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long PHLELIEGIKH;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long JHKBBCKODII;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long PLJNDKPFHIM;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long LACJMAJHCMB;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long NLALKENBFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long CDPOJEDJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long OLNLEEGNGOG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long AHDCOGFHONC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x72C3BA0", Offset = "0x72C29A0", VA = "0x1872C3BA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long LLDNCLNMMOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72C3E50", Offset = "0x72C2C50", VA = "0x1872C3E50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MDHLDECKGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x72C3DF0", Offset = "0x72C2BF0", VA = "0x1872C3DF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long IDHHEPAMMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x72C3E70", Offset = "0x72C2C70", VA = "0x1872C3E70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long EKNNIIBPMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x72C3E00", Offset = "0x72C2C00", VA = "0x1872C3E00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long MMPMDLDBGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x72C3E60", Offset = "0x72C2C60", VA = "0x1872C3E60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long CGGPMOBBCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x72C3C20", Offset = "0x72C2A20", VA = "0x1872C3C20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long PJBPJANKDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72C3E10", Offset = "0x72C2C10", VA = "0x1872C3E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private BHAODPMENNM EOPMHFBDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x72C3E80", Offset = "0x72C2C80", VA = "0x1872C3E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double IMIAAABEOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x72C3FA0", Offset = "0x72C2DA0", VA = "0x1872C3FA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x72C4000", Offset = "0x72C2E00", VA = "0x1872C4000")]
	public void PLDNCIPNLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x72C3E90", Offset = "0x72C2C90", VA = "0x1872C3E90")]
	public void MNHAHBFFPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x72C3EF0", Offset = "0x72C2CF0", VA = "0x1872C3EF0")]
	public void OIHCIFILMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x72C3BB0", Offset = "0x72C29B0", VA = "0x1872C3BB0")]
	public void CNJLPOIOMIC(long HAIMJBNFCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x72C3D80", Offset = "0x72C2B80", VA = "0x1872C3D80")]
	public void IKODDAINGBE(long FIEECMJFILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x72C3F40", Offset = "0x72C2D40", VA = "0x1872C3F40")]
	public void PFEFGBGFJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x72C3C60", Offset = "0x72C2A60", VA = "0x1872C3C60")]
	public void GNEPPPLNOKD(long CKPNNHACODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72C4040", Offset = "0x72C2E40", VA = "0x1872C4040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x72C3CE0", Offset = "0x72C2AE0", VA = "0x1872C3CE0")]
	public void HCGMEGLOGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public HNHJAIHAEGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class PBIOPECCKAD
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> EKBEBBMEEPJ;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x72D32F0", Offset = "0x72D20F0", VA = "0x1872D32F0")]
	public static IPEndPoint GEIJINFAFGC(string APKGEOLKPNC, int DEGLCNGNLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x72D3540", Offset = "0x72D2340", VA = "0x1872D3540")]
	public static IPAddress JLHMIHLPDDD(string APKGEOLKPNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x72D3710", Offset = "0x72D2510", VA = "0x1872D3710")]
	public static IPAddress JLHMIHLPDDD(string APKGEOLKPNC, AddressFamily CIJHJIFALKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x72D37A0", Offset = "0x72D25A0", VA = "0x1872D37A0")]
	internal static int KFHOFFAOOIN(int IOOPKFBDEFK, int NKLFIDDLENK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3D54C00", Offset = "0x3D53A00", VA = "0x183D54C00")]
	internal static T[] BEPIOHKCPGH<T>(int LJEIHABMGGI) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class DDLEPMLCPCJ : CDELGMMONAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct JFHNDIOGJFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private FKMDPMBAJBI DKBIJEGICGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long CLEDPFKIHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool DLICAPMINND;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x72C6ED0", Offset = "0x72C5CD0", VA = "0x1872C6ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x72C6EB0", Offset = "0x72C5CB0", VA = "0x1872C6EB0")]
		public void ONJHMMKMDOB(FKMDPMBAJBI PMOFLFIBNJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72C6DF0", Offset = "0x72C5BF0", VA = "0x1872C6DF0")]
		public bool IEBNDKJIMCP(long EHLBOFFMJME, FBMALIKLNCJ OJALPHNBPCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x72C6E60", Offset = "0x72C5C60", VA = "0x1872C6E60")]
		public bool MKDKKBLDFOH(FBMALIKLNCJ OJALPHNBPCK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly FKMDPMBAJBI IBJGCOJFFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly JFHNDIOGJFJ[] NLIBKCOHHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly FKMDPMBAJBI[] AKLKMDGAOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] FAIJECPGOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int BJLAABBGJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int HCMDHJAIIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int HCPIIGOFJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int EFPNAFNBPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool DCNFGMPIPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly DHAHIIKHGDB HLJMJNMCIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool JPLMFPEKEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int GLNJJMNDAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte ONGMCCMNHJF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GIHMKHEEOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x72BC8B0", Offset = "0x72BB6B0", VA = "0x1872BC8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x72BD7B0", Offset = "0x72BC5B0", VA = "0x1872BD7B0")]
	public DDLEPMLCPCJ(FBMALIKLNCJ OJALPHNBPCK, bool PMJAFBAEFBK, byte PPPFBKMGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x72BCD90", Offset = "0x72BBB90", VA = "0x1872BCD90")]
	private void DMEBAJMJHMA(FKMDPMBAJBI PMOFLFIBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x72BC8C0", Offset = "0x72BB6C0", VA = "0x1872BC8C0", Slot = "4")]
	protected override bool ANLGNJPOJOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x72BD150", Offset = "0x72BBF50", VA = "0x1872BD150", Slot = "5")]
	public override bool HCLNGIMLIEP(FKMDPMBAJBI PMOFLFIBNJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class JEIPEGPFBIH : CDELGMMONAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int FLGJJMLMMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort HCMDHJAIIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool EJPNHMIGOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private FKMDPMBAJBI BNHMHIIOFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly FKMDPMBAJBI MMAJPBODIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool EAONOFMMLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte ONGMCCMNHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long BGJCMGAEPHM;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x72C6D30", Offset = "0x72C5B30", VA = "0x1872C6D30")]
	public JEIPEGPFBIH(FBMALIKLNCJ OJALPHNBPCK, bool MCOLDCAIODJ, byte PPPFBKMGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x72C6590", Offset = "0x72C5390", VA = "0x1872C6590", Slot = "4")]
	protected override bool ANLGNJPOJOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x72C6A50", Offset = "0x72C5850", VA = "0x1872C6A50", Slot = "5")]
	public override bool HCLNGIMLIEP(FKMDPMBAJBI PMOFLFIBNJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AOFFNGKBALB
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct FPNCPNBOHEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong CGOFIFKLKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double DJKMBIHAOGF;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct PIAHKAMDPKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int JDIPBKBCAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float FOODFHIANCI;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x72BB150", Offset = "0x72B9F50", VA = "0x1872BB150")]
	private static void OHLDOGPLIEI(byte[] NHMENHDBHGG, int DOBKAGHAEBK, ulong BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x72BB800", Offset = "0x72BA600", VA = "0x1872BB800")]
	private static void OHLDOGPLIEI(byte[] NHMENHDBHGG, int DOBKAGHAEBK, int BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72BB730", Offset = "0x72BA530", VA = "0x1872BB730")]
	public static void OHLDOGPLIEI(byte[] NHMENHDBHGG, int DOBKAGHAEBK, short BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72BB870", Offset = "0x72BA670", VA = "0x1872BB870")]
	public static void COIGEMPCEEB(byte[] JMAPKDPGDHP, int HBNCFIPENFO, double BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72BB770", Offset = "0x72BA570", VA = "0x1872BB770")]
	public static void COIGEMPCEEB(byte[] JMAPKDPGDHP, int HBNCFIPENFO, float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72BB730", Offset = "0x72BA530", VA = "0x1872BB730")]
	public static void COIGEMPCEEB(byte[] JMAPKDPGDHP, int HBNCFIPENFO, short BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72BB730", Offset = "0x72BA530", VA = "0x1872BB730")]
	public static void COIGEMPCEEB(byte[] JMAPKDPGDHP, int HBNCFIPENFO, ushort BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72BB800", Offset = "0x72BA600", VA = "0x1872BB800")]
	public static void COIGEMPCEEB(byte[] JMAPKDPGDHP, int HBNCFIPENFO, int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72BB800", Offset = "0x72BA600", VA = "0x1872BB800")]
	public static void COIGEMPCEEB(byte[] JMAPKDPGDHP, int HBNCFIPENFO, uint BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x72BB7F0", Offset = "0x72BA5F0", VA = "0x1872BB7F0")]
	public static void COIGEMPCEEB(byte[] JMAPKDPGDHP, int HBNCFIPENFO, long BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x72BB7F0", Offset = "0x72BA5F0", VA = "0x1872BB7F0")]
	public static void COIGEMPCEEB(byte[] JMAPKDPGDHP, int HBNCFIPENFO, ulong BNECONOIKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NEKODMMOJNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] GBOEMEDAOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int KOFHMMCBHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int MEOCHOMBIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int CFMKAAIGJJE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] LLJJMIKAKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FABANHGKMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int CBDNIAHJJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x72D2550", Offset = "0x72D1350", VA = "0x1872D2550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CDAEKOAGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x289C790", Offset = "0x289B590", VA = "0x18289C790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FOLHMJJCKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x72D24C0", Offset = "0x72D12C0", VA = "0x1872D24C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x72D1D70", Offset = "0x72D0B70", VA = "0x1872D1D70")]
	public void EEOLDDKKGGO(byte[] PBOOMELBCNJ, int DOBKAGHAEBK, int OFILDDOHJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public NEKODMMOJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x72D2560", Offset = "0x72D1360", VA = "0x1872D2560")]
	public NEKODMMOJNC(byte[] PBOOMELBCNJ, int DOBKAGHAEBK, int OFILDDOHJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x72D1F50", Offset = "0x72D0D50", VA = "0x1872D1F50")]
	public IPEndPoint ILEBEBAAJCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x72D1CB0", Offset = "0x72D0AB0", VA = "0x1872D1CB0")]
	public byte DHPOPHHAHJF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x72D1CB0", Offset = "0x72D0AB0", VA = "0x1872D1CB0")]
	public sbyte FPJNDNDIFJB()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3D00E70", Offset = "0x3CFFC70", VA = "0x183D00E70")]
	public T[] FHFPHLLBINH<T>(ushort DFCCCGNJINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x72D1C70", Offset = "0x72D0A70", VA = "0x1872D1C70")]
	public bool[] CLPLAPEPJKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x72D2510", Offset = "0x72D1310", VA = "0x1872D2510")]
	public ushort[] PHIPIMFKDJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72D1D30", Offset = "0x72D0B30", VA = "0x1872D1D30")]
	public short[] EEGJHPEMBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72D1E60", Offset = "0x72D0C60", VA = "0x1872D1E60")]
	public int[] HAIOJMLLNOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x72D1CF0", Offset = "0x72D0AF0", VA = "0x1872D1CF0")]
	public uint[] EBPOLBMPKAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x72D1AA0", Offset = "0x72D08A0", VA = "0x1872D1AA0")]
	public float[] ABFGPHJAGCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x72D1F10", Offset = "0x72D0D10", VA = "0x1872D1F10")]
	public double[] IKGJBABOIEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x72D1E20", Offset = "0x72D0C20", VA = "0x1872D1E20")]
	public long[] HAEFDGJMFHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x72D2020", Offset = "0x72D0E20", VA = "0x1872D2020")]
	public ulong[] IMCNIDIOOJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x72D1950", Offset = "0x72D0750", VA = "0x1872D1950")]
	public string[] AAAPFCBOBFP(int KMHILEPMLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x72D24D0", Offset = "0x72D12D0", VA = "0x1872D24D0")]
	public bool NENKLJHDJED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x72D1DB0", Offset = "0x72D0BB0", VA = "0x1872D1DB0")]
	public char KKEBEJOFJKK()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x72D1DB0", Offset = "0x72D0BB0", VA = "0x1872D1DB0")]
	public ushort EHKGCBMJICO()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x72D1B90", Offset = "0x72D0990", VA = "0x1872D1B90")]
	public short BCIDNNGHAJH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x72D2180", Offset = "0x72D0F80", VA = "0x1872D2180")]
	public long LKKPCLAEMFC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x72D1EA0", Offset = "0x72D0CA0", VA = "0x1872D1EA0")]
	public ulong HIFOGKBOENN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x72D2450", Offset = "0x72D1250", VA = "0x1872D2450")]
	public int MKKMJKKDMJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x72D1C00", Offset = "0x72D0A00", VA = "0x1872D1C00")]
	public uint CHAJFHMOAIE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x72D2060", Offset = "0x72D0E60", VA = "0x1872D2060")]
	public float IPCPEDBIDLF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x72D1B20", Offset = "0x72D0920", VA = "0x1872D1B20")]
	public double ALOEJLGBAKE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x72D21F0", Offset = "0x72D0FF0", VA = "0x1872D21F0")]
	public string MEPOCCEKCCJ(int CGLFLAMIPMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x72D20D0", Offset = "0x72D0ED0", VA = "0x1872D20D0")]
	public ArraySegment<byte> JLKGJLNPJOL(int LJEIHABMGGI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x72D1AE0", Offset = "0x72D08E0", VA = "0x1872D1AE0")]
	public sbyte[] ADDEIAADKJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x72D2140", Offset = "0x72D0F40", VA = "0x1872D2140")]
	public byte[] LFNBJLJLEJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x72D2430", Offset = "0x72D1230", VA = "0x1872D2430")]
	public void MKDKKBLDFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JCCNOMGAOJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] GBOEMEDAOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int KOFHMMCBHCM;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int NGIEBNIOCFO = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool FFJPOIMCKCE;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding IDLOCCICNEH;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int JHPGOBIONKL = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] KBJIFFBHEBE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] HBHDBEHHINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x72C6510", Offset = "0x72C5310", VA = "0x1872C6510")]
	public JCCNOMGAOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x72C6470", Offset = "0x72C5270", VA = "0x1872C6470")]
	public JCCNOMGAOJM(bool PJEDFJIIKGE, int EIHFOGFNHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x72C6370", Offset = "0x72C5170", VA = "0x1872C6370")]
	public static JCCNOMGAOJM HMCFMOMMAJM(string BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x72C62D0", Offset = "0x72C50D0", VA = "0x1872C62D0")]
	public void DFBCGHPGNEB(int HGDAFHHJFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2916060", Offset = "0x2914E60", VA = "0x182916060")]
	public void PLDNCIPNLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x72C5EE0", Offset = "0x72C4CE0", VA = "0x1872C5EE0")]
	public void APFNBPJNEAL(float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x72C5D90", Offset = "0x72C4B90", VA = "0x1872C5D90")]
	public void APFNBPJNEAL(double BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x72C5CE0", Offset = "0x72C4AE0", VA = "0x1872C5CE0")]
	public void APFNBPJNEAL(long BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x72C5CE0", Offset = "0x72C4AE0", VA = "0x1872C5CE0")]
	public void APFNBPJNEAL(ulong BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x72C5DE0", Offset = "0x72C4BE0", VA = "0x1872C5DE0")]
	public void APFNBPJNEAL(int BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x72C5DE0", Offset = "0x72C4BE0", VA = "0x1872C5DE0")]
	public void APFNBPJNEAL(uint BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x72C5C70", Offset = "0x72C4A70", VA = "0x1872C5C70")]
	public void APFNBPJNEAL(char BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x72C5C70", Offset = "0x72C4A70", VA = "0x1872C5C70")]
	public void APFNBPJNEAL(ushort BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x72C5C70", Offset = "0x72C4A70", VA = "0x1872C5C70")]
	public void APFNBPJNEAL(short BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x72C5D30", Offset = "0x72C4B30", VA = "0x1872C5D30")]
	public void APFNBPJNEAL(sbyte BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x72C5D30", Offset = "0x72C4B30", VA = "0x1872C5D30")]
	public void APFNBPJNEAL(byte BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x72C5E70", Offset = "0x72C4C70", VA = "0x1872C5E70")]
	public void APFNBPJNEAL(byte[] BOIPFNOKGBJ, int DOBKAGHAEBK, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x72C5B90", Offset = "0x72C4990", VA = "0x1872C5B90")]
	public void PLCOFNCPKOK(sbyte[] BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x72C5B90", Offset = "0x72C4990", VA = "0x1872C5B90")]
	public void NJKMDFGDIPC(byte[] BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x72C6260", Offset = "0x72C5060", VA = "0x1872C6260")]
	public void APFNBPJNEAL(bool BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x72C5820", Offset = "0x72C4620", VA = "0x1872C5820")]
	public void AILBKACBIFN(Array LPNHFNADNJM, int EGBODIDOACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x72C59E0", Offset = "0x72C47E0", VA = "0x1872C59E0")]
	public void AILBKACBIFN(float[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x72C5740", Offset = "0x72C4540", VA = "0x1872C5740")]
	public void AILBKACBIFN(double[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x72C5740", Offset = "0x72C4540", VA = "0x1872C5740")]
	public void AILBKACBIFN(long[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x72C5740", Offset = "0x72C4540", VA = "0x1872C5740")]
	public void AILBKACBIFN(ulong[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x72C59E0", Offset = "0x72C47E0", VA = "0x1872C59E0")]
	public void AILBKACBIFN(int[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x72C59E0", Offset = "0x72C47E0", VA = "0x1872C59E0")]
	public void AILBKACBIFN(uint[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72C5900", Offset = "0x72C4700", VA = "0x1872C5900")]
	public void AILBKACBIFN(ushort[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x72C5900", Offset = "0x72C4700", VA = "0x1872C5900")]
	public void AILBKACBIFN(short[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72C5B90", Offset = "0x72C4990", VA = "0x1872C5B90")]
	public void AILBKACBIFN(bool[] BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72C5AC0", Offset = "0x72C48C0", VA = "0x1872C5AC0")]
	public void AILBKACBIFN(string[] BNECONOIKOE, int DBBHAFLJBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72C5F80", Offset = "0x72C4D80", VA = "0x1872C5F80")]
	public void APFNBPJNEAL(IPEndPoint INPLPAFLMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x72C62C0", Offset = "0x72C50C0", VA = "0x1872C62C0")]
	public void APFNBPJNEAL(string BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x72C6050", Offset = "0x72C4E50", VA = "0x1872C6050")]
	public void APFNBPJNEAL(string BNECONOIKOE, int CGLFLAMIPMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BMHHECMBCJL
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class FHPHELDLHGO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong ACHEFDKJDFN;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4CB09B0", Offset = "0x4CAF7B0", VA = "0x184CB09B0")]
		static FHPHELDLHGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void NJCKKIPKEKL(NEKODMMOJNC DGMHJDFFMEI, object PDLPCFHCPCF);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FBEBEGGIMCG<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public BMHHECMBCJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FBEBEGGIMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4C92660", Offset = "0x4C91460", VA = "0x184C92660")]
		internal void DPDHKCEIECL(NEKODMMOJNC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class JFHGDDCBKDC<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public BMHHECMBCJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JFHGDDCBKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x51A4150", Offset = "0x51A2F50", VA = "0x1851A4150")]
		internal void DPDHKCEIECL(NEKODMMOJNC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly EPHAPOOAAND CJHPEGFMPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, NJCKKIPKEKL> FNBONNCNIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly JCCNOMGAOJM FNJPBPJEHOL;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x72BBBF0", Offset = "0x72BA9F0", VA = "0x1872BBBF0")]
	public BMHHECMBCJL(int KMHILEPMLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x393C780", Offset = "0x393B580", VA = "0x18393C780", Slot = "4")]
	protected virtual ulong LBMIKJFMMMI<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x72BBA40", Offset = "0x72BA840", VA = "0x1872BBA40", Slot = "5")]
	protected virtual NJCKKIPKEKL BIBFGILPCCN(NEKODMMOJNC DGMHJDFFMEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x393C380", Offset = "0x393B180", VA = "0x18393C380", Slot = "6")]
	protected virtual void DHKHJMNCNGF<T>(JCCNOMGAOJM JAIJDFCBLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x72BBB70", Offset = "0x72BA970", VA = "0x1872BBB70")]
	public void JHGCECOMCOF(NEKODMMOJNC DGMHJDFFMEI, object PDLPCFHCPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x393C6F0", Offset = "0x393B4F0", VA = "0x18393C6F0")]
	public void HFOAKAKOEPN<T>(JCCNOMGAOJM JAIJDFCBLCH, T PMOFLFIBNJE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x72BB9F0", Offset = "0x72BA7F0", VA = "0x1872BB9F0")]
	public void BCIOBELDFEB(NEKODMMOJNC DGMHJDFFMEI, object PDLPCFHCPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x393C570", Offset = "0x393B370", VA = "0x18393C570")]
	public void GEHHCODHHDB<T>(Action<T> FDHCCOBKKEM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x393C3F0", Offset = "0x393B1F0", VA = "0x18393C3F0")]
	public void GEHHCODHHDB<T, TUserData>(Action<T, TUserData> FDHCCOBKKEM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EPNJJCAPJIO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x72BDE20", Offset = "0x72BCC20", VA = "0x1872BDE20")]
	public EPNJJCAPJIO(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NKLPJEJLIGG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x72D25C0", Offset = "0x72D13C0", VA = "0x1872D25C0")]
	public NKLPJEJLIGG(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class EPHAPOOAAND
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum AKBJAAFFFKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class MKBNDMDGJPA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AKBJAAFFFKG KICDHMJGHJC;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x567C270", Offset = "0x567B070", VA = "0x18567C270", Slot = "4")]
		public virtual void ONJHMMKMDOB(MethodInfo DOEKHLFHFAC, MethodInfo DCBCBONGIBN, AKBJAAFFFKG DGPNPBEKOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void EFKELAGNMNA(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void ILPFCOLEIEO(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		protected MKBNDMDGJPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class BPJIJPFJFDC<TClass, TProperty> : MKBNDMDGJPA<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> NPEANAMFMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> NEPHCNDNIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> LJAIIHMICMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> KEHLBJADDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> POFHKBDCHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> MOHJKBBFFCI;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x634D600", Offset = "0x634C400", VA = "0x18634D600", Slot = "7")]
		public override void NLPAEFGIMNF(TClass MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x634C720", Offset = "0x634B520", VA = "0x18634C720", Slot = "8")]
		public override void KDODNBDFLOF(TClass MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x634ACC0", Offset = "0x6349AC0", VA = "0x18634ACC0", Slot = "9")]
		public override void EFKELAGNMNA(TClass MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x634BC80", Offset = "0x634AA80", VA = "0x18634BC80", Slot = "10")]
		public override void ILPFCOLEIEO(TClass MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x634C380", Offset = "0x634B180", VA = "0x18634C380")]
		protected TProperty[] JFIBLGIAJJI(TClass MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x634DB40", Offset = "0x634C940", VA = "0x18634DB40")]
		protected TProperty[] OJDCOHGLHKN(TClass MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x634F2B0", Offset = "0x634E0B0", VA = "0x18634F2B0", Slot = "4")]
		public override void ONJHMMKMDOB(MethodInfo DOEKHLFHFAC, MethodInfo DCBCBONGIBN, AKBJAAFFFKG DGPNPBEKOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6352670", Offset = "0x6351470", VA = "0x186352670")]
		protected BPJIJPFJFDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class OLGLJOIHEKF<TClass, TProperty> : BPJIJPFJFDC<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void JDGGJNOOMCH(NEKODMMOJNC GCOEALJJGEI, [Out] TProperty OKNDAMKBEJM);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void FEBLOJHOHFO(JCCNOMGAOJM DIBMLEMJLNN, TProperty OKNDAMKBEJM);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5865B50", Offset = "0x5864950", VA = "0x185865B50", Slot = "5")]
		public override void JEJBOKHGDOH(TClass MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x58659F0", Offset = "0x58647F0", VA = "0x1858659F0", Slot = "6")]
		public override void HFOAKAKOEPN(TClass MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5865DB0", Offset = "0x5864BB0", VA = "0x185865DB0", Slot = "7")]
		public override void NLPAEFGIMNF(TClass MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5865C70", Offset = "0x5864A70", VA = "0x185865C70", Slot = "8")]
		public override void KDODNBDFLOF(TClass MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x480B1E0", Offset = "0x4809FE0", VA = "0x18480B1E0")]
		protected OLGLJOIHEKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class NMEGECAPLBH<T> : BPJIJPFJFDC<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x570C370", Offset = "0x570B170", VA = "0x18570C370", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x570C310", Offset = "0x570B110", VA = "0x18570C310", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x570C440", Offset = "0x570B240", VA = "0x18570C440", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x570C3E0", Offset = "0x570B1E0", VA = "0x18570C3E0", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public NMEGECAPLBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class BEOOAMEHBNJ<T> : BPJIJPFJFDC<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6252480", Offset = "0x6251280", VA = "0x186252480", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x570C310", Offset = "0x570B110", VA = "0x18570C310", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x62524F0", Offset = "0x62512F0", VA = "0x1862524F0", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x570C3E0", Offset = "0x570B1E0", VA = "0x18570C3E0", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public BEOOAMEHBNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class MCDEDFGCILG<T> : BPJIJPFJFDC<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x56517F0", Offset = "0x56505F0", VA = "0x1856517F0", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5651790", Offset = "0x5650590", VA = "0x185651790", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x56518C0", Offset = "0x56506C0", VA = "0x1856518C0", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5651860", Offset = "0x5650660", VA = "0x185651860", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public MCDEDFGCILG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NGHAHMEGNOD<T> : BPJIJPFJFDC<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x56E2520", Offset = "0x56E1320", VA = "0x1856E2520", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x5651790", Offset = "0x5650590", VA = "0x185651790", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x56E2590", Offset = "0x56E1390", VA = "0x1856E2590", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x5651860", Offset = "0x5650660", VA = "0x185651860", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public NGHAHMEGNOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OINHKGDGHJE<T> : BPJIJPFJFDC<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x585BF50", Offset = "0x585AD50", VA = "0x18585BF50", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x585BEF0", Offset = "0x585ACF0", VA = "0x18585BEF0", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x585BFC0", Offset = "0x585ADC0", VA = "0x18585BFC0", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4E14470", Offset = "0x4E13270", VA = "0x184E14470", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public OINHKGDGHJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class BPIHFICMLKC<T> : BPJIJPFJFDC<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x634ABE0", Offset = "0x63499E0", VA = "0x18634ABE0", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x585BEF0", Offset = "0x585ACF0", VA = "0x18585BEF0", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x634AC50", Offset = "0x6349A50", VA = "0x18634AC50", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E14470", Offset = "0x4E13270", VA = "0x184E14470", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public BPIHFICMLKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class NJCKCJBELCA<T> : BPJIJPFJFDC<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x56CCE30", Offset = "0x56CBC30", VA = "0x1856CCE30", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x56CCDD0", Offset = "0x56CBBD0", VA = "0x1856CCDD0", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x56F3580", Offset = "0x56F2380", VA = "0x1856F3580", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x56CCEA0", Offset = "0x56CBCA0", VA = "0x1856CCEA0", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public NJCKCJBELCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class NAHHOBNAALJ<T> : BPJIJPFJFDC<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x56CCE30", Offset = "0x56CBC30", VA = "0x1856CCE30", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x56CCDD0", Offset = "0x56CBBD0", VA = "0x1856CCDD0", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x56CCF00", Offset = "0x56CBD00", VA = "0x1856CCF00", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x56CCEA0", Offset = "0x56CBCA0", VA = "0x1856CCEA0", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public NAHHOBNAALJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class PHOGBMOBMLD<T> : BPJIJPFJFDC<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x598B3D0", Offset = "0x598A1D0", VA = "0x18598B3D0", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x598B370", Offset = "0x598A170", VA = "0x18598B370", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x598B440", Offset = "0x598A240", VA = "0x18598B440", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x570C3E0", Offset = "0x570B1E0", VA = "0x18570C3E0", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public PHOGBMOBMLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class HCKJKMAAAGN<T> : BPJIJPFJFDC<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4E14400", Offset = "0x4E13200", VA = "0x184E14400", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4E143A0", Offset = "0x4E131A0", VA = "0x184E143A0", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4E144D0", Offset = "0x4E132D0", VA = "0x184E144D0", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4E14470", Offset = "0x4E13270", VA = "0x184E14470", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public HCKJKMAAAGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class PPJPNLCKJMA<T> : BPJIJPFJFDC<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x59D0A60", Offset = "0x59CF860", VA = "0x1859D0A60", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x59D0A00", Offset = "0x59CF800", VA = "0x1859D0A00", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x59D0AD0", Offset = "0x59CF8D0", VA = "0x1859D0AD0", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x56CCEA0", Offset = "0x56CBCA0", VA = "0x1856CCEA0", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x47F8210", Offset = "0x47F7010", VA = "0x1847F8210")]
		public PPJPNLCKJMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class DAFNLJOIILP<T> : OLGLJOIHEKF<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AAA0", Offset = "0x6D998A0", VA = "0x186D9AAA0", Slot = "12")]
		protected override void FEBLOJHOHFO(JCCNOMGAOJM DIBMLEMJLNN, char OKNDAMKBEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AAD0", Offset = "0x6D998D0", VA = "0x186D9AAD0", Slot = "11")]
		protected override void JDGGJNOOMCH(NEKODMMOJNC GCOEALJJGEI, [Out] char OKNDAMKBEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x47D2410", Offset = "0x47D1210", VA = "0x1847D2410")]
		public DAFNLJOIILP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CCBBFMNOODE<T> : OLGLJOIHEKF<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6707FE0", Offset = "0x6706DE0", VA = "0x186707FE0", Slot = "12")]
		protected override void FEBLOJHOHFO(JCCNOMGAOJM DIBMLEMJLNN, IPEndPoint OKNDAMKBEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6708010", Offset = "0x6706E10", VA = "0x186708010", Slot = "11")]
		protected override void JDGGJNOOMCH(NEKODMMOJNC GCOEALJJGEI, [Out] IPEndPoint OKNDAMKBEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x47D2410", Offset = "0x47D1210", VA = "0x1847D2410")]
		public CCBBFMNOODE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class BPGDMKNBBHB<T> : BPJIJPFJFDC<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int MDNIFKJCPNI;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x634A320", Offset = "0x6349120", VA = "0x18634A320")]
		public BPGDMKNBBHB(int CGLFLAMIPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x634A1D0", Offset = "0x6348FD0", VA = "0x18634A1D0", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x634A160", Offset = "0x6348F60", VA = "0x18634A160", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x634A2B0", Offset = "0x63490B0", VA = "0x18634A2B0", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x634A240", Offset = "0x6349040", VA = "0x18634A240", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class EBMEJLCFJKO<T> : MKBNDMDGJPA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo EOFJPGCPGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type KDKHOOOPAPL;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4801550", Offset = "0x4800350", VA = "0x184801550")]
		public EBMEJLCFJKO(PropertyInfo DAGPCGHBFAL, Type HFJOIMKHIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x48013D0", Offset = "0x48001D0", VA = "0x1848013D0", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x48012C0", Offset = "0x48000C0", VA = "0x1848012C0", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x48014F0", Offset = "0x48002F0", VA = "0x1848014F0", Slot = "7")]
		public override void NLPAEFGIMNF(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4801490", Offset = "0x4800290", VA = "0x184801490", Slot = "8")]
		public override void KDODNBDFLOF(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4801260", Offset = "0x4800060", VA = "0x184801260", Slot = "9")]
		public override void EFKELAGNMNA(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4801370", Offset = "0x4800170", VA = "0x184801370", Slot = "10")]
		public override void ILPFCOLEIEO(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class PHFILAHAIBC<T> : EBMEJLCFJKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4CC0D90", Offset = "0x4CBFB90", VA = "0x184CC0D90")]
		public PHFILAHAIBC(PropertyInfo DAGPCGHBFAL, Type HFJOIMKHIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x598A6C0", Offset = "0x59894C0", VA = "0x18598A6C0", Slot = "5")]
		public override void JEJBOKHGDOH(T MEJAGLLLNFN, NEKODMMOJNC GCOEALJJGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x598A610", Offset = "0x5989410", VA = "0x18598A610", Slot = "6")]
		public override void HFOAKAKOEPN(T MEJAGLLLNFN, JCCNOMGAOJM DIBMLEMJLNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class GBHEAANFABB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static GBHEAANFABB<T> ODAOEPEFKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly MKBNDMDGJPA<T>[] JECEDJKBCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int MFGMCLOJDAP;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4D72950", Offset = "0x4D71750", VA = "0x184D72950")]
		public GBHEAANFABB(List<MKBNDMDGJPA<T>> MJDGIONCIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4D727F0", Offset = "0x4D715F0", VA = "0x184D727F0")]
		public void HFOAKAKOEPN(T MKPNGAKJFMP, JCCNOMGAOJM JAIJDFCBLCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4D728A0", Offset = "0x4D716A0", VA = "0x184D728A0")]
		public void JEJBOKHGDOH(T MKPNGAKJFMP, NEKODMMOJNC DGMHJDFFMEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class MHHICEEKFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract MKBNDMDGJPA<T> LHCLHJGACJJ<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private JCCNOMGAOJM KBLEMLHBPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int PMGBOHKHLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, MHHICEEKFFI> GOFAIKCCMCN;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x72BDD80", Offset = "0x72BCB80", VA = "0x1872BDD80")]
	public EPHAPOOAAND(int KMHILEPMLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3A1F360", Offset = "0x3A1E160", VA = "0x183A1F360")]
	private GBHEAANFABB<T> EHLEEFHEPDM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3934C10", Offset = "0x3933A10", VA = "0x183934C10")]
	public void HIMDKAKGPHI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3A20250", Offset = "0x3A1F050", VA = "0x183A20250")]
	public bool KIDJPDKJMHF<T>(NEKODMMOJNC DGMHJDFFMEI, T IMBAOPHEODM) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3A202D0", Offset = "0x3A1F0D0", VA = "0x183A202D0")]
	public void NEJFHFKCOKJ<T>(JCCNOMGAOJM JAIJDFCBLCH, T MKPNGAKJFMP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class INDMOPOMHDM
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime GOBJNIIFHBB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] FMGPPHOIPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BAIJEEACLMP GHNFEIEBGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x72C5130", Offset = "0x72C3F30", VA = "0x1872C5130")]
		get
		{
			return default(BAIJEEACLMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int INOHAAHCJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x72C4E10", Offset = "0x72C3C10", VA = "0x1872C4E10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x72C4F20", Offset = "0x72C3D20", VA = "0x1872C4F20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HLGCHFJGPLH KIOHFGMLJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x72C4DE0", Offset = "0x72C3BE0", VA = "0x1872C4DE0")]
		get
		{
			return default(HLGCHFJGPLH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x72C46A0", Offset = "0x72C34A0", VA = "0x1872C46A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int OMHIOKFBBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x72C4670", Offset = "0x72C3470", VA = "0x1872C4670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint KGAFBMICJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x72C4E40", Offset = "0x72C3C40", VA = "0x1872C4E40")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? FDKGLAFBNHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x72C52E0", Offset = "0x72C40E0", VA = "0x1872C52E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? GCDFKGJEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x72C4EF0", Offset = "0x72C3CF0", VA = "0x1872C4EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? KLLBPCAONGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x72C4EC0", Offset = "0x72C3CC0", VA = "0x1872C4EC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x72C4F60", Offset = "0x72C3D60", VA = "0x1872C4F60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? BIJJJGAEDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xD16990", Offset = "0xD15790", VA = "0x180D16990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xEFA5B0", Offset = "0xEF93B0", VA = "0x180EFA5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x72C5420", Offset = "0x72C4220", VA = "0x1872C5420")]
	public INDMOPOMHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72C5370", Offset = "0x72C4170", VA = "0x1872C5370")]
	internal INDMOPOMHDM(byte[] JMAPKDPGDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x72C51C0", Offset = "0x72C3FC0", VA = "0x1872C51C0")]
	public static INDMOPOMHDM NCHJLKNLMDA(byte[] JMAPKDPGDHP, DateTime CEAEJHNGIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x72C4BE0", Offset = "0x72C39E0", VA = "0x1872C4BE0")]
	internal void FDMFDGHDLCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x72C46E0", Offset = "0x72C34E0", VA = "0x1872C46E0")]
	private void DHHIKBKHNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x72C4470", Offset = "0x72C3270", VA = "0x1872C4470")]
	private DateTime? CABODAKICJF(int DOBKAGHAEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x72C4950", Offset = "0x72C3750", VA = "0x1872C4950")]
	private void DOMOFKLLOPG(int DOBKAGHAEBK, DateTime? BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x72C43A0", Offset = "0x72C31A0", VA = "0x1872C43A0")]
	private ulong BBMJNLAPKGO(int DOBKAGHAEBK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x72C4B20", Offset = "0x72C3920", VA = "0x1872C4B20")]
	private void EJMBKPBDOMF(int DOBKAGHAEBK, ulong BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x72C48C0", Offset = "0x72C36C0", VA = "0x1872C48C0")]
	private uint DHNJAJILOFK(int DOBKAGHAEBK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7186A90", Offset = "0x7185890", VA = "0x187186A90")]
	private static uint MNIHNPIFCCP(uint DHOMBGCEEAK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x72C5160", Offset = "0x72C3F60", VA = "0x1872C5160")]
	private static ulong MNIHNPIFCCP(ulong DHOMBGCEEAK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum BAIJEEACLMP
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum HLGCHFJGPLH
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class NBFJOBFGLLA
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int OEICHGOIOLM = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int LJLNGMOLICA = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int KGHFLMJNEEP = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint MJDIOGGIIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int BNPHCNEOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int GHGIBHAPKDO;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JPFNDNDHFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x72D1940", Offset = "0x72D0740", VA = "0x1872D1940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x72D1850", Offset = "0x72D0650", VA = "0x1872D1850")]
	public bool EACNAGEECPA(AJAPJFBIIMH MIHMKABLMFC, int GJEILCNCAPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class CIJKMLACFKN : AJAPJFBIIMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket MIHMKABLMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly LINJHPCDDKM COIANAEOLDO;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short LNMKMHNLECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x72BC710", Offset = "0x72BB510", VA = "0x1872BC710", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BKHBNPMLCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x72BC6F0", Offset = "0x72BB4F0", VA = "0x1872BC6F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint OLKAMBGBADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x72BC770", Offset = "0x72BB570", VA = "0x1872BC770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily HBMNGNNNALF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x53CD080", Offset = "0x53CBE80", VA = "0x1853CD080", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x72BC790", Offset = "0x72BB590", VA = "0x1872BC790")]
	public CIJKMLACFKN(AddressFamily CIJHJIFALKK, LINJHPCDDKM COIANAEOLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x72BC040", Offset = "0x72BAE40", VA = "0x1872BC040", Slot = "8")]
	public bool FNOBLEAJLBG(IPEndPoint INPLPAFLMAP, PJEHFHIECHO JOKBCPIPMMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x72BC730", Offset = "0x72BB530", VA = "0x1872BC730", Slot = "9")]
	public int PJAOLDKJNOI(byte[] NHMENHDBHGG, int DOBKAGHAEBK, int DFCCCGNJINK, IPEndPoint OADGDMJJNMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x72BC600", Offset = "0x72BB400", VA = "0x1872BC600", Slot = "10")]
	public int HBALALHJJKF(byte[] NHMENHDBHGG, EndPoint CFLDHLKFCGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x72BC020", Offset = "0x72BAE20", VA = "0x1872BC020", Slot = "11")]
	public void CBNONNLPHPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface AJAPJFBIIMH
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short LNMKMHNLECE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int BKHBNPMLCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint OLKAMBGBADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily HBMNGNNNALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FNOBLEAJLBG(IPEndPoint INPLPAFLMAP, PJEHFHIECHO JOKBCPIPMMM);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int PJAOLDKJNOI(byte[] NHMENHDBHGG, int DOBKAGHAEBK, int DFCCCGNJINK, IPEndPoint OADGDMJJNMM);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HBALALHJJKF(byte[] NHMENHDBHGG, EndPoint OADGDMJJNMM);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CBNONNLPHPB();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct GGHOOEIGHOC : IEquatable<GGHOOEIGHOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long GMNEJJPBDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long GPJKJDOMHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long KPMMKCLADHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int LGINDHDKNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int CEKEFFHJALL;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x72C3AE0", Offset = "0x72C28E0", VA = "0x1872C3AE0")]
	public GGHOOEIGHOC(byte[] GJENNMCNOND, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x72C3870", Offset = "0x72C2670", VA = "0x1872C3870")]
	public GGHOOEIGHOC(Span<byte> GJENNMCNOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA80B80", Offset = "0xA7F980", VA = "0x180A80B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x72C3780", Offset = "0x72C2580", VA = "0x1872C3780", Slot = "4")]
	public bool Equals(GGHOOEIGHOC LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x72C37C0", Offset = "0x72C25C0", VA = "0x1872C37C0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class CGCJGIFHODG : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] CFPINIJCMEM;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NDILENHOCDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void BDFKLKKFMPE(IPEndPoint GJENNMCNOND, Span<byte> BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string ODPDCLKLKKM = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int KDJMDCDAMNJ = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int HNLPEGJPCJI = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int EJMKFCBOHGE = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<GGHOOEIGHOC, IPEndPoint> BAPMKKNILBJ;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static BDFKLKKFMPE LPAHHMBLEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int JDBDNGLCDLE;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	internal void OLOBBIDKGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	internal void CNJKOMDJFIB(IPEndPoint OADGDMJJNMM, Span<byte> BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class CIHAJJCMMGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int AKHAODMBMKC;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
	protected CIHAJJCMMGN(int BLEFBAIPNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IAKBBDDAFON(IPEndPoint INPLPAFLMAP, byte[] BOIPFNOKGBJ, int DOBKAGHAEBK, int IDFEOHMGIAF);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void KHEOFKOLKEF(IPEndPoint INPLPAFLMAP, byte[] BOIPFNOKGBJ, int DOBKAGHAEBK, int IDFEOHMGIAF);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class FONGCOBFCKJ : CIHAJJCMMGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] MAHBBBBCDEL;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator EHMGLJNLIFM;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x29F3870", Offset = "0x29F2670", VA = "0x1829F3870")]
	public FONGCOBFCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x72C3200", Offset = "0x72C2000", VA = "0x1872C3200")]
	public void JJHENOIOPBJ(IPEndPoint INPLPAFLMAP, byte[] MAHBBBBCDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x72C3120", Offset = "0x72C1F20", VA = "0x1872C3120")]
	public void IDNHIIBEMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x72C2C60", Offset = "0x72C1A60", VA = "0x1872C2C60", Slot = "4")]
	public override void IAKBBDDAFON(IPEndPoint INPLPAFLMAP, byte[] BOIPFNOKGBJ, int DOBKAGHAEBK, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x72C33B0", Offset = "0x72C21B0", VA = "0x1872C33B0", Slot = "5")]
	public override void KHEOFKOLKEF(IPEndPoint INPLPAFLMAP, byte[] BOIPFNOKGBJ, int DOBKAGHAEBK, int IDFEOHMGIAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct OJCCEDCEMML
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void KKAKAPEOFLP([NoAlias] byte* BDMJJKDLLBI, [NoAlias] byte* MAHBBBBCDEL, [NoAlias] byte* MCEEPLDJBEM, int IDFEOHMGIAF);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class HDIJAPIFPIC
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr DEKJCIHBLKN;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr NCKJPIGNJIF;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x72D3C30", Offset = "0x72D2A30", VA = "0x1872D3C30")]
		[BurstDiscard]
		private static void KNOJPCMNAPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x72D3E10", Offset = "0x72D2C10", VA = "0x1872D3E10")]
		private static IntPtr NHALIAMEHAB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x72D3D60", Offset = "0x72D2B60", VA = "0x1872D3D60")]
		public static void LODCLJFHCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		public static void DGPDNICIDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x72D39F0", Offset = "0x72D27F0", VA = "0x1872D39F0")]
		public unsafe static void BOBFGEKALDJ([NoAlias] byte* BDMJJKDLLBI, [NoAlias] byte* MAHBBBBCDEL, [NoAlias] byte* MCEEPLDJBEM, int IDFEOHMGIAF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint MAHBBBBCDEL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint MCEEPLDJBEM[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint FPPIMDNJNHM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint KCNHAGBACBJ[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint LODKAAIBFPD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint NHJGCOHGMDE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint COPHHKGCALJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint COPMEOHICPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint JOBOJKEGCOM[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x72D3270", Offset = "0x72D2070", VA = "0x1872D3270")]
	private void PLDNCIPNLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x72D3240", Offset = "0x72D2040", VA = "0x1872D3240")]
	private uint PIGPGKCIBCC(uint FPJNLHKNPEA, int PFLKMNEADFH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x72BB680", Offset = "0x72BA480", VA = "0x1872BB680")]
	private void LBIJFDDHMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x72BB370", Offset = "0x72BA170", VA = "0x1872BB370")]
	private void GANKLMHNIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x72BB2E0", Offset = "0x72BA0E0", VA = "0x1872BB2E0")]
	private void FKEBKMHOCCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x72BB580", Offset = "0x72BA380", VA = "0x1872BB580")]
	private void GPDHKGIMNMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x72D2F10", Offset = "0x72D1D10", VA = "0x1872D2F10")]
	private void GEKKBDIJFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x72D2AF0", Offset = "0x72D18F0", VA = "0x1872D2AF0")]
	private unsafe void AMOIFOLBGAO(byte* BDMJJKDLLBI, uint* MAHBBBBCDEL, uint* MCEEPLDJBEM, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x72D30E0", Offset = "0x72D1EE0", VA = "0x1872D30E0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void PGJJIDCHKAB([NoAlias] byte* BDMJJKDLLBI, [NoAlias] byte* MAHBBBBCDEL, [NoAlias] byte* MCEEPLDJBEM, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x72D3160", Offset = "0x72D1F60", VA = "0x1872D3160")]
	public static void PGJJIDCHKAB(Span<byte> BDMJJKDLLBI, Span<byte> MAHBBBBCDEL, Span<byte> MCEEPLDJBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x72D2FE0", Offset = "0x72D1DE0", VA = "0x1872D2FE0")]
	public static void NCAGPKHOHOE(Span<byte> BDMJJKDLLBI, Span<byte> MAHBBBBCDEL, Span<byte> MCEEPLDJBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x72D2F70", Offset = "0x72D1D70", VA = "0x1872D2F70")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void IJFLEFHHFMJ([NoAlias] byte* BDMJJKDLLBI, [NoAlias] byte* MAHBBBBCDEL, [NoAlias] byte* MCEEPLDJBEM, int IDFEOHMGIAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x72D4070", Offset = "0x72D2E70", VA = "0x1872D4070")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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
