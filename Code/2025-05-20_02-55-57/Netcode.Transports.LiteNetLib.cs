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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, JEDJCMIGLIN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum JKFHIKFPPEE
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
		private NetworkManager ENCOOIFGHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool MPHOMHOLCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, AGEOMEIEEFH> KIHFBJJLNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DALOGGGEBEO FOFEAPKOCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch LBCBKJKOFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] IBBEKCGLBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JKFHIKFPPEE MMPHGEOPPJC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong NCEGMFHJPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool BBBCBEBHEBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6F0A5C0", Offset = "0x6F097C0", VA = "0x186F0A5C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F09B40", Offset = "0x6F08D40", VA = "0x186F09B40")]
		public void RecRoom_SetEncryptionInfo(ulong FLNOAIHNDGC, byte[] AGBHGDFILGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F09B20", Offset = "0x6F08D20", VA = "0x186F09B20")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F099F0", Offset = "0x6F08BF0", VA = "0x186F099F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A4C0", Offset = "0x6F096C0", VA = "0x186F0A4C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F09C60", Offset = "0x6F08E60", VA = "0x186F09C60", Slot = "6")]
		public override void Send(ulong IHOGKNBNKOF, ArraySegment<byte> DHAOEHNLNON, NetworkDelivery JHHIEIIIDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F09AE0", Offset = "0x6F08CE0", VA = "0x186F09AE0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong IHOGKNBNKOF, [Out] ArraySegment<byte> MGEJNDCFBJA, [Out] float FCPNOMBGOHF)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F09F50", Offset = "0x6F09150", VA = "0x186F09F50", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A3E0", Offset = "0x6F095E0", VA = "0x186F0A3E0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F09240", Offset = "0x6F08440", VA = "0x186F09240", Slot = "11")]
		public override void DisconnectRemoteClient(ulong IHOGKNBNKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F09150", Offset = "0x6F08350", VA = "0x186F09150", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F09660", Offset = "0x6F08860", VA = "0x186F09660", Slot = "13")]
		public override ulong GetCurrentRtt(ulong IHOGKNBNKOF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F09EE0", Offset = "0x6F090E0", VA = "0x186F09EE0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F097C0", Offset = "0x6F089C0", VA = "0x186F097C0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager ENCOOIFGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F09420", Offset = "0x6F08620", VA = "0x186F09420")]
		private GHHNBKFJHAA EHLAJNKIKJH(NetworkDelivery EDLOHJEBKFM)
		{
			return default(GHHNBKFJHAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F09700", Offset = "0x6F08900", VA = "0x186F09700", Slot = "16")]
		private void IOFJPKGFKOB(AGEOMEIEEFH HNMIOEBGBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F09350", Offset = "0x6F08550", VA = "0x186F09350", Slot = "17")]
		private void EBPHDKCKCEI(AGEOMEIEEFH HNMIOEBGBHK, PCJIHDAOEGO OINENMLCAPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "18")]
		private void BNHAOLJFGNB(IPEndPoint IMKDIDOBHNO, SocketError HEFLGJCOPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F08F40", Offset = "0x6F08140", VA = "0x186F08F40", Slot = "19")]
		private void CBDMEIFPCGP(AGEOMEIEEFH HNMIOEBGBHK, PBCNADLFKGK OHHBENOLPAE, byte NKAEEHLFOBB, GHHNBKFJHAA OKNGPDDIJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F094F0", Offset = "0x6F086F0", VA = "0x186F094F0")]
		private void FDDMFJCPLAK(int JAFKPMJIGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "20")]
		private void GIEPLFDPMNC(IPEndPoint DBCDMFBPKFD, PBCNADLFKGK OHHBENOLPAE, JOOMNGHJHHC EKOBCPAOKFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "21")]
		private void BHCEAOHMCLN(AGEOMEIEEFH HNMIOEBGBHK, int JLIIEPAGDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F095D0", Offset = "0x6F087D0", VA = "0x186F095D0", Slot = "22")]
		private void FJDOPLDBFHO(EJPMBPGNOFL MGALKMHOLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F09630", Offset = "0x6F08830", VA = "0x186F09630")]
		private ulong FLCDFCPFOBO(AGEOMEIEEFH HNMIOEBGBHK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F099D0", Offset = "0x6F08BD0", VA = "0x186F099D0")]
		private static int ONNONMKANME(float ODIBCCLKMAC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A4E0", Offset = "0x6F096E0", VA = "0x186F0A4E0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class GAJKJCOHCAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly AGEOMEIEEFH LMBJLCIEBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly ConcurrentQueue<JABEELLBAPG> ADHMDILGLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int CAEOFNMLGMA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F040B0", Offset = "0x6F032B0", VA = "0x186F040B0")]
	protected GAJKJCOHCAC(AGEOMEIEEFH HNMIOEBGBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F03FD0", Offset = "0x6F031D0", VA = "0x186F03FD0")]
	public void JEKGPONHNJC(JABEELLBAPG BDLILJHJIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F04030", Offset = "0x6F03230", VA = "0x186F04030")]
	protected void KJDHBMLNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F03F90", Offset = "0x6F03190", VA = "0x186F03F90")]
	public bool FOCEONPEBML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool IJBKLEKDGCK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool KPPKBIMBLAN(JABEELLBAPG BDLILJHJIHM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum PJACFJJMEGG
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EJPMBPGNOFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly DALOGGGEBEO JKLKDPJJOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int IGOLKPKEGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal GJFFJMNIHIK HMCMDLCKFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly IPEndPoint OPDGJEEGIJI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PJACFJJMEGG JPOOALJFOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA18BE0", Offset = "0xA17DE0", VA = "0x180A18BE0")]
		[CompilerGenerated]
		get
		{
			return default(PJACFJJMEGG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD6F6E0", Offset = "0xD6E8E0", VA = "0x180D6F6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F03500", Offset = "0x6F02700", VA = "0x186F03500")]
	internal void AEOMIGBCNKD(GJFFJMNIHIK CMHIABPPCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F035C0", Offset = "0x6F027C0", VA = "0x186F035C0")]
	private bool MMNAPAHBJBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F035F0", Offset = "0x6F027F0", VA = "0x186F035F0")]
	internal EJPMBPGNOFL(IPEndPoint DBCDMFBPKFD, GJFFJMNIHIK AJNLFDDGEJJ, DALOGGGEBEO DJBNDMENDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F03560", Offset = "0x6F02760", VA = "0x186F03560")]
	public AGEOMEIEEFH LOLBCKBGOEF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JOOMNGHJHHC
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EPNKPGIPANB
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PCJIHDAOEGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EPNKPGIPANB COGCOGGPKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public SocketError CLKHLCBJCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public PBCNADLFKGK MHCLOMOPJCG;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JEDJCMIGLIN
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDAEGAGIMHM(AGEOMEIEEFH HNMIOEBGBHK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMCDBHPAAPF(AGEOMEIEEFH HNMIOEBGBHK, PCJIHDAOEGO OINENMLCAPM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFENLEAPAIM(IPEndPoint IMKDIDOBHNO, SocketError HEFLGJCOPLF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOGHKAMMNDA(AGEOMEIEEFH HNMIOEBGBHK, PBCNADLFKGK OHHBENOLPAE, byte NKAEEHLFOBB, GHHNBKFJHAA OKNGPDDIJJM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCJBEGDOGNC(IPEndPoint DBCDMFBPKFD, PBCNADLFKGK OHHBENOLPAE, JOOMNGHJHHC EKOBCPAOKFI);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCJMIJHMELC(AGEOMEIEEFH HNMIOEBGBHK, int JLIIEPAGDGJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGJKMJFAGDF(EJPMBPGNOFL MGALKMHOLCM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DENPODNNKNF
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANOAAJILOHK(AGEOMEIEEFH HNMIOEBGBHK, object KJDONDGLCAK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MNDFOHKIILK
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FECMADKJPBG(KMNNAJDEACF BDLILJHJIHM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BJAMOHBIGFA
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNEHOBHNOI(AGEOMEIEEFH HNMIOEBGBHK, IPEndPoint MEKKIDIBJOB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GJFFJMNIHIK
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const int HKAOKFAIAEE = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly long LGMHAOKCHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte GHBJELDAHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly byte[] IAHBLBBBFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly MCPHJFIHPOH ALBEJFPMKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly int MIPIEPBKMOE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F045B0", Offset = "0x6F037B0", VA = "0x186F045B0")]
	private GJFFJMNIHIK(long DCNAKJNPPLH, byte PFGHHLBJJLP, int EANCCIKOAFJ, byte[] JGHFLJHEGCK, MCPHJFIHPOH DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F04150", Offset = "0x6F03350", VA = "0x186F04150")]
	public static int AGLDAHIEPMH(JABEELLBAPG BDLILJHJIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F041B0", Offset = "0x6F033B0", VA = "0x186F041B0")]
	public static GJFFJMNIHIK CLDABKHGMLO(JABEELLBAPG BDLILJHJIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F043D0", Offset = "0x6F035D0", VA = "0x186F043D0")]
	public static JABEELLBAPG MHEFFKKOBGI(NOCBGJOEJIG GDKHIOGLHHC, SocketAddress BLBDIECHDIF, long AIEPLAJIDEP, int EANCCIKOAFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class EENBCJBKBKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly long LGMHAOKCHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly byte GHBJELDAHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly int MIPIEPBKMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool BHKDLPJMBBC;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F034B0", Offset = "0x6F026B0", VA = "0x186F034B0")]
	private EENBCJBKBKJ(long DCNAKJNPPLH, byte PFGHHLBJJLP, int BCKHBCJGNPE, bool OFDPGANBPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F03170", Offset = "0x6F02370", VA = "0x186F03170")]
	public static EENBCJBKBKJ CLDABKHGMLO(JABEELLBAPG BDLILJHJIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F033C0", Offset = "0x6F025C0", VA = "0x186F033C0")]
	public static JABEELLBAPG MHEFFKKOBGI(long AIEPLAJIDEP, byte BCGCFEKALCE, int BMKHIFEENDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F032C0", Offset = "0x6F024C0", VA = "0x186F032C0")]
	public static JABEELLBAPG GEIEIHBLLGN(AGEOMEIEEFH HNMIOEBGBHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NKJFACPAIOM
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AHDECMGBBDK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALMEJEFGBMD(IPEndPoint NFAGEEAKLKO, IPEndPoint DBCDMFBPKFD, string PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KEOLNIDOPMD(IPEndPoint MBDCKFNCGHF, NKJFACPAIOM EDLOHJEBKFM, string PPOILDCNBFL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DJLJDANHOLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct FBLICJMGIGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IPEndPoint JPCJJJOKEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint OPDGJEEGIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string EIFJDLIJOPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct ELDHFDCNNMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint KENPGHBAIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NKJFACPAIOM AFGCMPJBOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string EIFJDLIJOPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class OPNGCEAELNN
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint BKDNADDOKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string EIFJDLIJOPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OPNGCEAELNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class MIBNGGKDHIO
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint BKDNADDOKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint KAKPAAEOJNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string EIFJDLIJOPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MIBNGGKDHIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class CENKIPFGEKF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EIFJDLIJOPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IHHOBACBGEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAACFF0", Offset = "0xAAC1F0", VA = "0x180AACFF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9F8320", Offset = "0x9F7520", VA = "0x1809F8320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CENKIPFGEKF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly DALOGGGEBEO KEKOAEEEMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ConcurrentQueue<FBLICJMGIGG> OIDCOFBKANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ConcurrentQueue<ELDHFDCNNMB> MAHACDBAOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MCPHJFIHPOH HKECDGDBKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NOCBGJOEJIG DDJGOJDDIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly JPPKPBLIEJP MECCHLABCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private AHDECMGBBDK DDHFKEBHINJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public const int PABMKHHGMCB = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool LNBDPNNPLEM;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F02230", Offset = "0x6F01430", VA = "0x186F02230")]
	internal DJLJDANHOLJ(DALOGGGEBEO EEIAAOKGCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F01DB0", Offset = "0x6F00FB0", VA = "0x186F01DB0")]
	internal void IGHIABDIOAL(IPEndPoint GDHPHMDGIMD, JABEELLBAPG BDLILJHJIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x366AD80", Offset = "0x3669F80", VA = "0x18366AD80")]
	private void FOHJPDGGHJE<T>(T BDLILJHJIHM, IPEndPoint PJNHLGGHCLG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F01C20", Offset = "0x6F00E20", VA = "0x186F01C20")]
	private void ALMEJEFGBMD(OPNGCEAELNN GFHALDPAFGJ, IPEndPoint GDHPHMDGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F020D0", Offset = "0x6F012D0", VA = "0x186F020D0")]
	private void NDIFINLJJPI(MIBNGGKDHIO GFHALDPAFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F01F30", Offset = "0x6F01130", VA = "0x186F01F30")]
	private void MKPBMDPKNDE(CENKIPFGEKF GFHALDPAFGJ, IPEndPoint GDHPHMDGIMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum GHHNBKFJHAA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum FGCNIFAAGKK : long
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NLFNIPIHADH
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal static readonly int[] MOJLJOCPEFE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly int FJLAGOBMPOB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly int KLGBJHPFFIH;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DGLOIFNFIPJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9240", Offset = "0x6EF8440", VA = "0x186EF9240")]
	public DGLOIFNFIPJ(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PLLEPLMHCBA : DGLOIFNFIPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9240", Offset = "0x6EF8440", VA = "0x186EF9240")]
	public PLLEPLMHCBA(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KJBOGONGIBH
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FHDGKCDLDNO
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLPHMIBHNPG(KJBOGONGIBH HCIJJPAIIEC, string AKCEGHPGLOG, params object[] EFGHMCKPMHN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class PKKHEAGCAOG
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static FHDGKCDLDNO GDOKOOFMNMA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly object PJDJJJNLHLC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C950", Offset = "0x6F0BB50", VA = "0x186F0C950")]
	private static void LJCKHLAJJBN(KJBOGONGIBH AOLDJMAGDPL, string AKCEGHPGLOG, params object[] EFGHMCKPMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C8F0", Offset = "0x6F0BAF0", VA = "0x186F0C8F0")]
	internal static void HFBKJBMCFPC(string AKCEGHPGLOG, params object[] EFGHMCKPMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C830", Offset = "0x6F0BA30", VA = "0x186F0C830")]
	internal static void BCGGKAJCAHB(string AKCEGHPGLOG, params object[] EFGHMCKPMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C890", Offset = "0x6F0BA90", VA = "0x186F0C890")]
	internal static void BMJOMDBMDNM(string AKCEGHPGLOG, params object[] EFGHMCKPMHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum GMDOMABJLEC
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PBCNADLFKGK : MCPHJFIHPOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private JABEELLBAPG OHNMLKOFIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly DALOGGGEBEO KLAHMPBPCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly CEDKPICIEHG CDNINGCJMHK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C7E0", Offset = "0x6F0B9E0", VA = "0x186F0C7E0")]
	internal PBCNADLFKGK(DALOGGGEBEO MHGFNMBGACA, CEDKPICIEHG ALOIKGNLFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C6F0", Offset = "0x6F0B8F0", VA = "0x186F0C6F0")]
	internal void HIGDBKHGLJD(JABEELLBAPG BDLILJHJIHM, int IPBENGINBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C760", Offset = "0x6F0B960", VA = "0x186F0C760")]
	internal void JJKOOGJMIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C6C0", Offset = "0x6F0B8C0", VA = "0x186F0C6C0")]
	public void CGEFDPIGJIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class CEDKPICIEHG
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum CJGMFCCFKJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public CEDKPICIEHG EIFAEANLFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public CJGMFCCFKJA AFGCMPJBOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public AGEOMEIEEFH LMBJLCIEBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public IPEndPoint OPDGJEEGIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object NFPEDIMNJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int HINBKFCNMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SocketError EDIHBCCGMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public EPNKPGIPANB OGLLLGIOMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public EJPMBPGNOFL PJCECOOHENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public GHHNBKFJHAA OEHOPOKABPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte LANFJNGPBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly PBCNADLFKGK MHDAJLMPKGF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9AE0", Offset = "0x6EF8CE0", VA = "0x186EF9AE0")]
	public CEDKPICIEHG(DALOGGGEBEO MHGFNMBGACA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DALOGGGEBEO : IEnumerable<AGEOMEIEEFH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class CANKGNELKCC : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9A70", Offset = "0x6EF8C70", VA = "0x186EF9A70", Slot = "4")]
		public bool Equals(IPEndPoint CCOLDGJALNH, IPEndPoint JCBKIOEHCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A360", Offset = "0x6A99560", VA = "0x186A9A360", Slot = "5")]
		public int GetHashCode(IPEndPoint DBCLNEGBNLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CANKGNELKCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct CIJELJFNINF : IEnumerator<AGEOMEIEEFH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly AGEOMEIEEFH GBPADNJCEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private AGEOMEIEEFH JABPELFBLDC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AGEOMEIEEFH HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xDAB610", Offset = "0xDAA810", VA = "0x180DAB610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xDAB610", Offset = "0xDAA810", VA = "0x180DAB610", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1A13F00", Offset = "0x1A13100", VA = "0x181A13F00")]
		public CIJELJFNINF(AGEOMEIEEFH OJJILHCFMHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9B80", Offset = "0x6EF8D80", VA = "0x186EF9B80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9BD0", Offset = "0x6EF8DD0", VA = "0x186EF9BD0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Thread MBMPPBHNJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool DICNFAKPDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool NNMKIAJOBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private LBDPCDMCCEP ABEMDBJNICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AutoResetEvent OLNCOLJMOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Queue<CEDKPICIEHG> GNGBDPAMPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<CEDKPICIEHG> DNKBGPLBCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private CEDKPICIEHG KELODLNNNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JEDJCMIGLIN DAMLDHPMAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly DENPODNNKNF MOMNOBPJHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MNDFOHKIILK OHHBINCEADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly BJAMOHBIGFA HKELGIPLLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Dictionary<IPEndPoint, AGEOMEIEEFH> DNONPIPFLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, EJPMBPGNOFL> NDOBKCGOILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, DEDAGCGDEMH> OOBOKOJPGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ReaderWriterLockSlim CAHGHFKPPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private AGEOMEIEEFH BIGBMAOPPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int PDPKIBHAAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly List<AGEOMEIEEFH> KCMPKLPGKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AGEOMEIEEFH[] EEICPDBDILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly KHGBNANGKIJ CEEFODBJEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int JJHHPACKJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private ConcurrentQueue<int> NHHEAHFNPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private byte PDNBFFLPOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly object JEJIKOBAHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool AIPODKFLPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool ECDOFJFJMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int NEKJGNLOKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int DDAIIMDBEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int GLJJOMAOLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int NOPPFIEBEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool OEKEEBDEONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool CMABKKOOFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int HEDCJDFPNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int IOMEPNHHGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int BJAIFGKPPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool LNBDPNNPLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool FGDAGJPCILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF6")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool DPAHAKBOJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF7")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool BMONJBEHMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int LADADILEPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int KIHLAIIBPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool IHCAMHJAKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly FGACCDLEOKG KPFCGMNAEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool PGIAENEIHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly DJLJDANHOLJ GAAIGFHHLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool CNHJIFKGLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public GMDOMABJLEC AHKBOJPFBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int BPCBGLHCGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool APBELDBLFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x135")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool PCGHIEGLKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x136")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool AIHHEGMNGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x137")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool OFHLNMNGCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private JABEELLBAPG KJHFKLBKPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int FJFLEOIBMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object CJBBADMHDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private JABEELLBAPG HPEDEKLBNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int KLKAPGJCNMN;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const int GDDOHPBNINJ = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private const int PNGDIJJEJFF = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private HHJAIHGALKE MNFPGBBABGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private HHJAIHGALKE EDNFPIKLOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Thread KABBPCPMACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Thread EKDOKJMCDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IPEndPoint BNOOFCCJKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private IPEndPoint JBGKJDFMGPI;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[ThreadStatic]
	private static byte[] MMHDNPHEIEF;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[ThreadStatic]
	private static byte[] MDFDNBFMFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<JNLIHPCOCHM, IPEndPoint> NMHHILONFMF;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly IPAddress DEONKFLBJHE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly bool HJIIOPDIFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public int KLANIAKDKCP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FNEBEMGJCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECC0", Offset = "0xA6DEC0", VA = "0x180A6ECC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA6A7E0", Offset = "0xA699E0", VA = "0x180A6A7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CDOKCHCECOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1565F80", Offset = "0x1565180", VA = "0x181565F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E61790", Offset = "0x1E60990", VA = "0x181E61790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte NENDGGMEHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xF50EC0", Offset = "0xF500C0", VA = "0x180F50EC0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AADPCOKKFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB2C0", Offset = "0x6EFA4C0", VA = "0x186EFB2C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short FPOOLEEHFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F00380", Offset = "0x6EFF580", VA = "0x186F00380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA3F0", Offset = "0x6EF95F0", VA = "0x186EFA3F0")]
	public void AECHAOOBLCD(IPEndPoint IMKDIDOBHNO, byte[] AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE0A0", Offset = "0x6EFD2A0", VA = "0x186EFE0A0")]
	public void HNBBOKIKGKJ(IPEndPoint IMKDIDOBHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD780", Offset = "0x6EFC980", VA = "0x186EFD780")]
	private bool GFLNNAOFOMH(IPEndPoint IMKDIDOBHNO, [Out] AGEOMEIEEFH HNMIOEBGBHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE1F0", Offset = "0x6EFD3F0", VA = "0x186EFE1F0")]
	private void HPHMEFFBIMD(AGEOMEIEEFH HNMIOEBGBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB320", Offset = "0x6EFA520", VA = "0x186EFB320")]
	private void BHNDFCPMOLP(AGEOMEIEEFH HNMIOEBGBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F009E0", Offset = "0x6EFFBE0", VA = "0x186F009E0")]
	private void OIMLKPFJGNJ(AGEOMEIEEFH HNMIOEBGBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F014C0", Offset = "0x6F006C0", VA = "0x186F014C0")]
	public DALOGGGEBEO(JEDJCMIGLIN DJBNDMENDGC, [Optional] KHGBNANGKIJ BIFEPCBBEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF8A0", Offset = "0x6EFEAA0", VA = "0x186EFF8A0")]
	internal void MBJJEFAHGKK(AGEOMEIEEFH EKDBDBILCOM, int JLIIEPAGDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB380", Offset = "0x6EFA580", VA = "0x186EFB380")]
	internal void BJKLEDKCCON(AGEOMEIEEFH EKDBDBILCOM, object KJDONDGLCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB2E0", Offset = "0x6EFA4E0", VA = "0x186EFB2E0")]
	internal void BFHCPPGFKHI(AGEOMEIEEFH HNMIOEBGBHK, EPNKPGIPANB BPAILNFLNFH, SocketError PJJAKGJJLPL, JABEELLBAPG ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAE70", Offset = "0x6EFA070", VA = "0x186EFAE70")]
	private void ANKBGKIOKNI(AGEOMEIEEFH HNMIOEBGBHK, EPNKPGIPANB BPAILNFLNFH, SocketError PJJAKGJJLPL, bool LIEHHNOLAGC, byte[] DHAOEHNLNON, int CAECICLJFEI, int KIFHGDECLNI, JABEELLBAPG ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6EFCFF0", Offset = "0x6EFC1F0", VA = "0x186EFCFF0")]
	private void DOLKGJEABGB(CEDKPICIEHG.CJGMFCCFKJA EDLOHJEBKFM, [Optional] AGEOMEIEEFH HNMIOEBGBHK, [Optional] IPEndPoint DBCDMFBPKFD, SocketError KNADPDIBGFF = SocketError.Success, int JLIIEPAGDGJ = 0, EPNKPGIPANB ENJGOJBPMDC = EPNKPGIPANB.ConnectionFailed, [Optional] EJPMBPGNOFL ALMEMJMMJMG, GHHNBKFJHAA OKNGPDDIJJM = GHHNBKFJHAA.Unreliable, byte NKAEEHLFOBB = 0, [Optional] JABEELLBAPG GIMGHFKAIAG, [Optional] object KJDONDGLCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9C20", Offset = "0x6EF8E20", VA = "0x186EF9C20")]
	private void AEBLLDOHHAI(CEDKPICIEHG ALOIKGNLFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE5C0", Offset = "0x6EFD7C0", VA = "0x186EFE5C0")]
	internal void IBABOEMGBEB(CEDKPICIEHG ALOIKGNLFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD820", Offset = "0x6EFCA20", VA = "0x186EFD820")]
	private void GNFEFEAIBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF1A0", Offset = "0x6EFE3A0", VA = "0x186EFF1A0")]
	private void KKLDOHIALIG(int ECOCJLJHHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6EFEB80", Offset = "0x6EFDD80", VA = "0x186EFEB80")]
	internal AGEOMEIEEFH KEKMGAPPKMG(EJPMBPGNOFL MGALKMHOLCM, byte[] LPEBGBKNGDE, int CAECICLJFEI, int LMMGFKFHEJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE540", Offset = "0x6EFD740", VA = "0x186EFE540")]
	private int IAMNPGOJIDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE6D0", Offset = "0x6EFD8D0", VA = "0x186EFE6D0")]
	private void IBPJLJBMIDM(IPEndPoint DBCDMFBPKFD, AGEOMEIEEFH JNHGFFEDFDC, GJFFJMNIHIK HCJGEDOCDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBC20", Offset = "0x6EFAE20", VA = "0x186EFBC20")]
	private void DMCKOGKINDH(JABEELLBAPG BDLILJHJIHM, IPEndPoint DBCDMFBPKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB940", Offset = "0x6EFAB40", VA = "0x186EFB940")]
	internal void DKPHKCHCMKI(JABEELLBAPG BDLILJHJIHM, GHHNBKFJHAA IPBOIENDBHP, byte NKAEEHLFOBB, int IPBENGINBMP, AGEOMEIEEFH EKDBDBILCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F000C0", Offset = "0x6EFF2C0", VA = "0x186F000C0")]
	public bool MBLDJPNEDPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F001B0", Offset = "0x6EFF3B0", VA = "0x186F001B0")]
	public bool MBLDJPNEDPM(IPAddress KBLBIIBNIOB, IPAddress POEEENHNCNB, int AKBKPEPJIKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F00130", Offset = "0x6EFF330", VA = "0x186F00130")]
	public bool MBLDJPNEDPM(int AKBKPEPJIKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F001D0", Offset = "0x6EFF3D0", VA = "0x186F001D0")]
	public void MNMJBCIHMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F00440", Offset = "0x6EFF640", VA = "0x186F00440")]
	public AGEOMEIEEFH NIKDHEEIOJM(string JMDMMDHMCCH, int AKBKPEPJIKB, string AGBHGDFILGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F00900", Offset = "0x6EFFB00", VA = "0x186F00900")]
	public AGEOMEIEEFH NIKDHEEIOJM(string JMDMMDHMCCH, int AKBKPEPJIKB, NOCBGJOEJIG NKFMGPGFGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F00520", Offset = "0x6EFF720", VA = "0x186F00520")]
	public AGEOMEIEEFH NIKDHEEIOJM(IPEndPoint PJNHLGGHCLG, NOCBGJOEJIG NKFMGPGFGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE090", Offset = "0x6EFD290", VA = "0x186EFE090")]
	public void HJEJKDBNPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDD30", Offset = "0x6EFCF30", VA = "0x186EFDD30")]
	public void HJEJKDBNPIP(bool MNLMIIIADMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF4C0", Offset = "0x6EFE6C0", VA = "0x186EFF4C0")]
	public void LABGOBNJLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF570", Offset = "0x6EFE770", VA = "0x186EFF570")]
	public void LABGOBNJLHN(byte[] DHAOEHNLNON, int CAECICLJFEI, int KIFHGDECLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAE30", Offset = "0x6EFA030", VA = "0x186EFAE30")]
	public void ANKBGKIOKNI(AGEOMEIEEFH HNMIOEBGBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB280", Offset = "0x6EFA480", VA = "0x186EFB280")]
	public void ANKBGKIOKNI(AGEOMEIEEFH HNMIOEBGBHK, byte[] DHAOEHNLNON, int CAECICLJFEI, int KIFHGDECLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6F012E0", Offset = "0x6F004E0", VA = "0x186F012E0", Slot = "4")]
	private IEnumerator<AGEOMEIEEFH> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6F01370", Offset = "0x6F00570", VA = "0x186F01370", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDB70", Offset = "0x6EFCD70", VA = "0x186EFDB70")]
	private JABEELLBAPG HBNNFFGPCBN(LAJNAEGNMHA FOCHDHDPJJM, int JAFKPMJIGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDC50", Offset = "0x6EFCE50", VA = "0x186EFDC50")]
	private JABEELLBAPG HBNNFFGPCBN(LAJNAEGNMHA FOCHDHDPJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB550", Offset = "0x6EFA750", VA = "0x186EFB550")]
	internal JABEELLBAPG CJCNMAJBHJF(int JAFKPMJIGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF640", Offset = "0x6EFE840", VA = "0x186EFF640")]
	internal void LMELLLHDDGB(JABEELLBAPG BDLILJHJIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6F01400", Offset = "0x6F00600", VA = "0x186F01400")]
	static DALOGGGEBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ECC0", Offset = "0xA6DEC0", VA = "0x180A6ECC0")]
	private bool BFDEOBNNJEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB3D0", Offset = "0x6EFA5D0", VA = "0x186EFB3D0")]
	private void CGBDGFPBOOB(IPEndPoint BFNCIMFHPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F01110", Offset = "0x6F00310", VA = "0x186F01110")]
	private void PLJPJPCECHB(IPEndPoint BFNCIMFHPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB790", Offset = "0x6EFA990", VA = "0x186EFB790")]
	private bool DJOCDNDFNKO(SocketException MJPFDOAJBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD3D0", Offset = "0x6EFC5D0", VA = "0x186EFD3D0")]
	private void EJOAGAMNEBF(LBDPCDMCCEP EEIAAOKGCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F00CC0", Offset = "0x6EFFEC0", VA = "0x186F00CC0")]
	private void ONOIDDCPJFL(HHJAIHGALKE EEIAAOKGCHG, EndPoint EJAOPFEOBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD3F0", Offset = "0x6EFC5F0", VA = "0x186EFD3F0")]
	private void FCEFDCDKOEN(object HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF8F0", Offset = "0x6EFEAF0", VA = "0x186EFF8F0")]
	public bool MBLDJPNEDPM(IPAddress KBLBIIBNIOB, IPAddress POEEENHNCNB, int AKBKPEPJIKB, bool LBEJGFIIHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F01280", Offset = "0x6F00480", VA = "0x186F01280")]
	internal int PPANJNKIDAO(JABEELLBAPG BDLILJHJIHM, IPEndPoint DBCDMFBPKFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA610", Offset = "0x6EF9810", VA = "0x186EFA610")]
	internal int AGHONIIBPOA(JABEELLBAPG BDLILJHJIHM, IPEndPoint DBCDMFBPKFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA650", Offset = "0x6EF9850", VA = "0x186EFA650")]
	internal int AGHONIIBPOA(byte[] BDAAPBJEHGD, int CAECICLJFEI, int LMMGFKFHEJP, IPEndPoint DBCDMFBPKFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F00F90", Offset = "0x6F00190", VA = "0x186F00F90")]
	internal void PBFFHDLGHLE(bool KACENIBIDMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum LAJNAEGNMHA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class JABEELLBAPG
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int IKHENJEGBFI;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int[] HACONPICGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public byte[] KECBFBFNICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public int LDPBGKCICAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public object NFPEDIMNJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public JABEELLBAPG EIFAEANLFHP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LAJNAEGNMHA ODIKCIDEBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F04FE0", Offset = "0x6F041E0", VA = "0x186F04FE0")]
		get
		{
			return default(LAJNAEGNMHA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F05070", Offset = "0x6F04270", VA = "0x186F05070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte GHBJELDAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F05040", Offset = "0x6F04240", VA = "0x186F05040")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F050E0", Offset = "0x6F042E0", VA = "0x186F050E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort EENJDLMPEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F04F80", Offset = "0x6F04180", VA = "0x186F04F80")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F05330", Offset = "0x6F04530", VA = "0x186F05330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FBBHEFAPBDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F05120", Offset = "0x6F04320", VA = "0x186F05120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte FCKFLLIJGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F05010", Offset = "0x6F04210", VA = "0x186F05010")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F050B0", Offset = "0x6F042B0", VA = "0x186F050B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort NCNONLNLGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F05440", Offset = "0x6F04640", VA = "0x186F05440")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F053D0", Offset = "0x6F045D0", VA = "0x186F053D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort ONABIMBKHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F05190", Offset = "0x6F04390", VA = "0x186F05190")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F052F0", Offset = "0x6F044F0", VA = "0x186F052F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort PCJJDPGDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F05370", Offset = "0x6F04570", VA = "0x186F05370")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F05150", Offset = "0x6F04350", VA = "0x186F05150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F054A0", Offset = "0x6F046A0", VA = "0x186F054A0")]
	static JABEELLBAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F05410", Offset = "0x6F04610", VA = "0x186F05410")]
	public void PCJKLIGNMHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F05870", Offset = "0x6F04A70", VA = "0x186F05870")]
	public JABEELLBAPG(int JAFKPMJIGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F05760", Offset = "0x6F04960", VA = "0x186F05760")]
	public JABEELLBAPG(LAJNAEGNMHA FOCHDHDPJJM, int JAFKPMJIGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F04F10", Offset = "0x6F04110", VA = "0x186F04F10")]
	public static int BEIBAPBLKJL(LAJNAEGNMHA FOCHDHDPJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F04E80", Offset = "0x6F04080", VA = "0x186F04E80")]
	public int BEIBAPBLKJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F051F0", Offset = "0x6F043F0", VA = "0x186F051F0")]
	public bool JPFMFLCNPOK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum CBMPODAGEBG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal enum NHNAFIGDHGE
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum BLHIDIONPIO
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum HLIMNEIPMAB
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class AGEOMEIEEFH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class MAEFKOBGPEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public JABEELLBAPG[] LLJGGIBPCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int JDKFBLDGDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int DPCNCOLHILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public byte FCKFLLIJGBI;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MAEFKOBGPEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void BJNGLBHFKJH(ulong AHBAIPCIPDA, int JKNMFNPDNPK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int PEDIJBPIJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int CJIJIOLCHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int NDGKANPDDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double KLNPAMAABEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int APFOMFFCOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int CEIJPJEPONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int FNJJLHHJMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Stopwatch NFNGCDIADDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int HCKNKAGIDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private long GMHAADEGDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly object KFACADICPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	internal AGEOMEIEEFH AIMIBODKNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	internal AGEOMEIEEFH CFPFEHAKANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Queue<JABEELLBAPG> AEBGNINCKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly ConcurrentQueue<GAJKJCOHCAC> DGCMMAPNCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly GAJKJCOHCAC[] ADOEHONIJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int KICLPMPJNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int KADAKHPGGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool JAGFDILKIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int OEJLECNHBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int EAICBDNGGLH;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private const int KKKOPNAFFEF = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const int JILIAJEGHAI = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly object OPBMKFIEHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int LHFOLIHHNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<ushort, MAEFKOBGPEE> MCFGCCIDOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly Dictionary<ushort, ushort> CLJCBDACPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly JABEELLBAPG LGAHPKADLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int DMIDHGFPKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int KHANLGIPMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IPEndPoint MFMOCBJLBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int OLBGAKODILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int OGOPNFCNDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private long ICFECOHOLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private byte HAIIKIHFHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private CBMPODAGEBG FFDIJNPKEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private JABEELLBAPG AKOOEJDNFPI;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const int KDFAOEAALHO = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int DOHFMCCHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly JABEELLBAPG FBIJPOIHHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly JABEELLBAPG JALHBHGKDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly JABEELLBAPG CBNOKOGMEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly JABEELLBAPG NLPMOGOGMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private FGCNIFAAGKK IGPGHPKDNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly DALOGGGEBEO KOOOGAGPELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly int CCDGCEMKGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public object MAKNAOCMPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly FGACCDLEOKG KPFCGMNAEPJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte DNBALGFEIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4300", Offset = "0xAC3500", VA = "0x180AC4300")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EF52F0", Offset = "0x6EF44F0", VA = "0x186EF52F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint ELGJDEFEFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xCCA9E0", Offset = "0xCC9BE0", VA = "0x180CCA9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CBMPODAGEBG HFPJOHOAMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB98A10", Offset = "0xB97C10", VA = "0x180B98A10")]
		get
		{
			return default(CBMPODAGEBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long LICKMPNDFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F8AC0", Offset = "0x9F7CC0", VA = "0x1809F8AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NKMAAMCMDJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1565F50", Offset = "0x1565150", VA = "0x181565F50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1E61520", Offset = "0x1E60720", VA = "0x181E61520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NBEMMLBNBMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8A70", Offset = "0x6EF7C70", VA = "0x186EF8A70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EADCKHCHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xBFB9D0", Offset = "0xBFABD0", VA = "0x180BFB9D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double CPOMLCLGIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x499DAA0", Offset = "0x499CCA0", VA = "0x18499DAA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event BJNGLBHFKJH LHFMMGHECNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5240", Offset = "0x6EF4440", VA = "0x186EF5240")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8270", Offset = "0x6EF7470", VA = "0x186EF8270")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8A80", Offset = "0x6EF7C80", VA = "0x186EF8A80")]
	internal AGEOMEIEEFH(DALOGGGEBEO PBEEMOPBNPE, IPEndPoint DBCDMFBPKFD, int MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5FF0", Offset = "0x6EF51F0", VA = "0x186EF5FF0")]
	internal void HGABENNKGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5900", Offset = "0x6EF4B00", VA = "0x186EF5900")]
	internal void DLAJAFGBFGD(IPEndPoint HHLGEKHJAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6490", Offset = "0x6EF5690", VA = "0x186EF6490")]
	internal void IHBDLAOGLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5980", Offset = "0x6EF4B80", VA = "0x186EF5980")]
	private void DNMLMEIFFOH(int NLHAGGBCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6BE0", Offset = "0x6EF5DE0", VA = "0x186EF6BE0")]
	private void KCDNPGGIJLK(int ILIEBGEOACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5E40", Offset = "0x6EF5040", VA = "0x186EF5E40")]
	private GAJKJCOHCAC HCNLHLJLGJO(byte DLMCFJOIHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6EF90B0", Offset = "0x6EF82B0", VA = "0x186EF90B0")]
	internal AGEOMEIEEFH(DALOGGGEBEO PBEEMOPBNPE, IPEndPoint DBCDMFBPKFD, int MKHHKDJKLDN, byte BCGCFEKALCE, NOCBGJOEJIG GDKHIOGLHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8ED0", Offset = "0x6EF80D0", VA = "0x186EF8ED0")]
	internal AGEOMEIEEFH(DALOGGGEBEO PBEEMOPBNPE, EJPMBPGNOFL MGALKMHOLCM, int MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5930", Offset = "0x6EF4B30", VA = "0x186EF5930")]
	internal void DNDAJJGFEFF(GJFFJMNIHIK GENIECPGDEH, byte[] DHAOEHNLNON, int CAECICLJFEI, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6EF51C0", Offset = "0x6EF43C0", VA = "0x186EF51C0")]
	internal bool AAKOHLAGBKL(EENBCJBKBKJ BDLILJHJIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5E10", Offset = "0x6EF5010", VA = "0x186EF5E10")]
	public void FOHJPDGGHJE(byte[] DHAOEHNLNON, int CAECICLJFEI, int LMMGFKFHEJP, GHHNBKFJHAA KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6EF53A0", Offset = "0x6EF45A0", VA = "0x186EF53A0")]
	private void DHDFMIIKNIK(byte[] DHAOEHNLNON, int CAECICLJFEI, int LMMGFKFHEJP, byte NKAEEHLFOBB, GHHNBKFJHAA OKNGPDDIJJM, object KJDONDGLCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5DC0", Offset = "0x6EF4FC0", VA = "0x186EF5DC0")]
	public void FMLILAKBEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8150", Offset = "0x6EF7350", VA = "0x186EF8150")]
	internal BLHIDIONPIO LOHLFGOCKIM(JABEELLBAPG BDLILJHJIHM)
	{
		return default(BLHIDIONPIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5D60", Offset = "0x6EF4F60", VA = "0x186EF5D60")]
	internal void FJLPELCGBOL(GAJKJCOHCAC AHONJNIOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5A50", Offset = "0x6EF4C50", VA = "0x186EF5A50")]
	internal HLIMNEIPMAB ELEPAPJIABM(byte[] DHAOEHNLNON, int CAECICLJFEI, int LMMGFKFHEJP, bool LIEHHNOLAGC)
	{
		return default(HLIMNEIPMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8230", Offset = "0x6EF7430", VA = "0x186EF8230")]
	private void NJPKCGEKPPB(int ALIADGFMHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF77C0", Offset = "0x6EF69C0", VA = "0x186EF77C0")]
	internal void LEJOMLMMGEL(GHHNBKFJHAA IPBOIENDBHP, JABEELLBAPG OJJILHCFMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8520", Offset = "0x6EF7720", VA = "0x186EF8520")]
	private void PFNJKOKGLOE(JABEELLBAPG BDLILJHJIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7430", Offset = "0x6EF6630", VA = "0x186EF7430")]
	private void LAIBDLPGCPE(int PNLPAJFPFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6EF62D0", Offset = "0x6EF54D0", VA = "0x186EF62D0")]
	internal NHNAFIGDHGE IBPJLJBMIDM(GJFFJMNIHIK HCJGEDOCDOO)
	{
		return default(NHNAFIGDHGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6D70", Offset = "0x6EF5F70", VA = "0x186EF6D70")]
	internal void KPPKBIMBLAN(JABEELLBAPG BDLILJHJIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6C20", Offset = "0x6EF5E20", VA = "0x186EF6C20")]
	private void KKIKGCFPMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8320", Offset = "0x6EF7520", VA = "0x186EF8320")]
	internal void PDAECFBPMIH(JABEELLBAPG BDLILJHJIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6520", Offset = "0x6EF5720", VA = "0x186EF6520")]
	internal void IOJFMKAPHLJ(int PNLPAJFPFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6010", Offset = "0x6EF5210", VA = "0x186EF6010")]
	internal void HKJKCEPLNOE(JABEELLBAPG BDLILJHJIHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class FGACCDLEOKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long ACPJLDHBHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long KDBNPEHBKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long MNJGHMIPCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long NHGIOGNEEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long DLJMNMMILCF;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long NCGLFOKOFHP;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static long PEFKJEABOEL;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static long HLOGEMDOMCK;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long LIGKLDFOKPF;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long EGDFLOEBLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private long OAMMEGOLCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private long BJCDJMHGEPE;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long NPPAMBMBFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F03950", Offset = "0x6F02B50", VA = "0x186F03950")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long HNHHIPLEPOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F03C20", Offset = "0x6F02E20", VA = "0x186F03C20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long AKBPMJFNEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F03B60", Offset = "0x6F02D60", VA = "0x186F03B60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long OBONBEJHCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F03C30", Offset = "0x6F02E30", VA = "0x186F03C30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long OPPCFJEEMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F03AF0", Offset = "0x6F02CF0", VA = "0x186F03AF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long MOOBEHPNHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F03C10", Offset = "0x6F02E10", VA = "0x186F03C10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long KMFMIFDMOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F03B70", Offset = "0x6F02D70", VA = "0x186F03B70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long IELJLIFHHCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F037E0", Offset = "0x6F029E0", VA = "0x186F037E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private FGCNIFAAGKK BHPHFLLPKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F03C40", Offset = "0x6F02E40", VA = "0x186F03C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double KIFKBJGBPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F03BB0", Offset = "0x6F02DB0", VA = "0x186F03BB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F03820", Offset = "0x6F02A20", VA = "0x186F03820")]
	public void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F039C0", Offset = "0x6F02BC0", VA = "0x186F039C0")]
	public void GGCJNENMMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F03860", Offset = "0x6F02A60", VA = "0x186F03860")]
	public void BGBMDPFNIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F03A90", Offset = "0x6F02C90", VA = "0x186F03A90")]
	public void JDKGGFNHAHP(long EFIIMNCINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F03B00", Offset = "0x6F02D00", VA = "0x186F03B00")]
	public void JOLOOCAKCGN(long PGCOINAOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F03960", Offset = "0x6F02B60", VA = "0x186F03960")]
	public void EGBFOJCNEGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F03A20", Offset = "0x6F02C20", VA = "0x186F03A20")]
	public void HIOCIEOECKI(long DLDFNLLEBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F03C50", Offset = "0x6F02E50", VA = "0x186F03C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F038B0", Offset = "0x6F02AB0", VA = "0x186F038B0")]
	public void BPAPAEHINOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FGACCDLEOKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OAKBPABMDDK
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly List<string> CMECFLDKJJG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C3B0", Offset = "0x6F0B5B0", VA = "0x186F0C3B0")]
	public static IPEndPoint KOBKLDHEOOP(string HIMJAEGODIB, int AKBKPEPJIKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C1E0", Offset = "0x6F0B3E0", VA = "0x186F0C1E0")]
	public static IPAddress GJLIJLBEGIL(string HIMJAEGODIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C150", Offset = "0x6F0B350", VA = "0x186F0C150")]
	public static IPAddress GJLIJLBEGIL(string HIMJAEGODIB, AddressFamily NGOHALIPGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C600", Offset = "0x6F0B800", VA = "0x186F0C600")]
	internal static int LABBLKKGLFF(int IAGFFDGOCDP, int FBLJGIIDEPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x39DE1A0", Offset = "0x39DD3A0", VA = "0x1839DE1A0")]
	internal static T[] NDGAIJFIIEF<T>(int KIFHGDECLNI) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KFHADLFJOIF : GAJKJCOHCAC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct EOMKMCIMLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private JABEELLBAPG OHNMLKOFIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private long FPKNDGADHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private bool GIMOLDGKNFP;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6F03740", Offset = "0x6F02940", VA = "0x186F03740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6F03720", Offset = "0x6F02920", VA = "0x186F03720")]
		public void MNFKMEBPDCG(JABEELLBAPG BDLILJHJIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6F036B0", Offset = "0x6F028B0", VA = "0x186F036B0")]
		public bool HEFFMNKPCBD(long BEBOODADNFJ, AGEOMEIEEFH HNMIOEBGBHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6F03660", Offset = "0x6F02860", VA = "0x186F03660")]
		public bool FKFEALEGJFP(AGEOMEIEEFH HNMIOEBGBHK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly JABEELLBAPG CEBCEKMPKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly EOMKMCIMLDB[] DKOLEAPDPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly JABEELLBAPG[] GAHAMIBEILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly bool[] BLKJALEDKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int DCBBJPNODLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int NKOKEMCAPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int BPADPEGHJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int JBBIEKLEEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool FMNAOKCLCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly GHHNBKFJHAA OJJJGFBHICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly bool KOICCMBEBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly int BKMCJNJJAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly byte DBGDDONMDHH;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F07010", Offset = "0x6F06210", VA = "0x186F07010")]
	public KFHADLFJOIF(AGEOMEIEEFH HNMIOEBGBHK, bool AFHEOIIFBFF, byte MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F06C50", Offset = "0x6F05E50", VA = "0x186F06C50")]
	private void MLPMHCJJIKN(JABEELLBAPG BDLILJHJIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6F06120", Offset = "0x6F05320", VA = "0x186F06120", Slot = "4")]
	protected override bool IJBKLEKDGCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6F065F0", Offset = "0x6F057F0", VA = "0x186F065F0", Slot = "5")]
	public override bool KPPKBIMBLAN(JABEELLBAPG BDLILJHJIHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class KIAGNGNBJDB : GAJKJCOHCAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int MJOMCDFLFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private ushort NKOKEMCAPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly bool COPNBPEFCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private JABEELLBAPG IDPDHJKEBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly JABEELLBAPG AEJBEHGNDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool EDFPAAEFKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly byte DBGDDONMDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private long IFCPAFMALJL;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6F07980", Offset = "0x6F06B80", VA = "0x186F07980")]
	public KIAGNGNBJDB(AGEOMEIEEFH HNMIOEBGBHK, bool FJBJIPAPKLC, byte MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6F071E0", Offset = "0x6F063E0", VA = "0x186F071E0", Slot = "4")]
	protected override bool IJBKLEKDGCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6F076A0", Offset = "0x6F068A0", VA = "0x186F076A0", Slot = "5")]
	public override bool KPPKBIMBLAN(JABEELLBAPG BDLILJHJIHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LMNCGADNFLK
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct NDPDEGECGJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public ulong EPAHNNHMIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public double HIKGJKKMMMP;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct NIEPLKPNIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int IPDKKGPECMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float KKLHGPFJDIO;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5030", Offset = "0x6EF4230", VA = "0x186EF5030")]
	private static void DEDIOCGKELJ(byte[] KKCFCHBPMCG, int OEBFFKLMAPN, ulong DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6F08DE0", Offset = "0x6F07FE0", VA = "0x186F08DE0")]
	private static void DEDIOCGKELJ(byte[] KKCFCHBPMCG, int OEBFFKLMAPN, int DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F08E50", Offset = "0x6F08050", VA = "0x186F08E50")]
	public static void DEDIOCGKELJ(byte[] KKCFCHBPMCG, int OEBFFKLMAPN, short DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6F08EA0", Offset = "0x6F080A0", VA = "0x186F08EA0")]
	public static void CHPJKBKIDDI(byte[] FONJAIMABAP, int AIGLIPKHKOK, double MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6F08EC0", Offset = "0x6F080C0", VA = "0x186F08EC0")]
	public static void CHPJKBKIDDI(byte[] FONJAIMABAP, int AIGLIPKHKOK, float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6F08E50", Offset = "0x6F08050", VA = "0x186F08E50")]
	public static void CHPJKBKIDDI(byte[] FONJAIMABAP, int AIGLIPKHKOK, short MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6F08E50", Offset = "0x6F08050", VA = "0x186F08E50")]
	public static void CHPJKBKIDDI(byte[] FONJAIMABAP, int AIGLIPKHKOK, ushort MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6F08DE0", Offset = "0x6F07FE0", VA = "0x186F08DE0")]
	public static void CHPJKBKIDDI(byte[] FONJAIMABAP, int AIGLIPKHKOK, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6F08DE0", Offset = "0x6F07FE0", VA = "0x186F08DE0")]
	public static void CHPJKBKIDDI(byte[] FONJAIMABAP, int AIGLIPKHKOK, uint MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6F08E90", Offset = "0x6F08090", VA = "0x186F08E90")]
	public static void CHPJKBKIDDI(byte[] FONJAIMABAP, int AIGLIPKHKOK, long MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6F08E90", Offset = "0x6F08090", VA = "0x186F08E90")]
	public static void CHPJKBKIDDI(byte[] FONJAIMABAP, int AIGLIPKHKOK, ulong MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MCPHJFIHPOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] PLFNPOBLMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int FPEDIPALGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected int PPBMFAJHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int JOALCCGIBFC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] KECBFBFNICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int EHJHFCKFLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int FHPEKDCGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AE30", Offset = "0x6F0A030", VA = "0x186F0AE30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool EEALMPMBCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x26A2970", Offset = "0x26A1B70", VA = "0x1826A2970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int LABILEJLKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AD30", Offset = "0x6F09F30", VA = "0x186F0AD30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AD40", Offset = "0x6F09F40", VA = "0x186F0AD40")]
	public void HIGDBKHGLJD(byte[] LJMBANNFBIJ, int OEBFFKLMAPN, int APHPAAMJLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MCPHJFIHPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B1E0", Offset = "0x6F0A3E0", VA = "0x186F0B1E0")]
	public MCPHJFIHPOH(byte[] LJMBANNFBIJ, int OEBFFKLMAPN, int APHPAAMJLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AB10", Offset = "0x6F09D10", VA = "0x186F0AB10")]
	public IPEndPoint EOHPOMNHFNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A5E0", Offset = "0x6F097E0", VA = "0x186F0A5E0")]
	public byte AJLEKDEENFN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A5E0", Offset = "0x6F097E0", VA = "0x186F0A5E0")]
	public sbyte IJDPJECEBNM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x38D6BA0", Offset = "0x38D5DA0", VA = "0x1838D6BA0")]
	public T[] BOPLHPBBDCL<T>(ushort JAFKPMJIGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AA20", Offset = "0x6F09C20", VA = "0x186F0AA20")]
	public bool[] DLBLDHCIJAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AAD0", Offset = "0x6F09CD0", VA = "0x186F0AAD0")]
	public ushort[] EOFOFBIGNIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AE40", Offset = "0x6F0A040", VA = "0x186F0AE40")]
	public short[] LJJLABAANND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6F0ABE0", Offset = "0x6F09DE0", VA = "0x186F0ABE0")]
	public int[] FDDABJOAACE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AE80", Offset = "0x6F0A080", VA = "0x186F0AE80")]
	public uint[] MFHAPMPELCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6F0ADF0", Offset = "0x6F09FF0", VA = "0x186F0ADF0")]
	public float[] JJDPPHNPKCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A820", Offset = "0x6F09A20", VA = "0x186F0A820")]
	public double[] DEDHDLGEKCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B1A0", Offset = "0x6F0A3A0", VA = "0x186F0B1A0")]
	public long[] OOGBNDDHAAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B160", Offset = "0x6F0A360", VA = "0x186F0B160")]
	public ulong[] OMMEBNEKBOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A8D0", Offset = "0x6F09AD0", VA = "0x186F0A8D0")]
	public string[] DHFKEGCOAKJ(int KEEPFCJFCON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0ACF0", Offset = "0x6F09EF0", VA = "0x186F0ACF0")]
	public bool HANPJDENONC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A620", Offset = "0x6F09820", VA = "0x186F0A620")]
	public char OECHMODPOOL()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A620", Offset = "0x6F09820", VA = "0x186F0A620")]
	public ushort BIBAPGHABNN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AD80", Offset = "0x6F09F80", VA = "0x186F0AD80")]
	public short IOBKABILCCB()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AC40", Offset = "0x6F09E40", VA = "0x186F0AC40")]
	public long GGNBNJBBIDD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A7B0", Offset = "0x6F099B0", VA = "0x186F0A7B0")]
	public ulong DACPHILBEGE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AA60", Offset = "0x6F09C60", VA = "0x186F0AA60")]
	public int DPCOCHBIIFH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B0F0", Offset = "0x6F0A2F0", VA = "0x186F0B0F0")]
	public uint OKICHCEJMPH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A690", Offset = "0x6F09890", VA = "0x186F0A690")]
	public float BMCPEPCPNJO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A860", Offset = "0x6F09A60", VA = "0x186F0A860")]
	public double DFJCNMKIFLO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AEC0", Offset = "0x6F0A0C0", VA = "0x186F0AEC0")]
	public string NFNKLDLHFAN(int JKMHCAHCOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A740", Offset = "0x6F09940", VA = "0x186F0A740")]
	public ArraySegment<byte> CONDDCIFHCN(int KIFHGDECLNI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A700", Offset = "0x6F09900", VA = "0x186F0A700")]
	public sbyte[] CCFGGJCCGPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6F0ACB0", Offset = "0x6F09EB0", VA = "0x186F0ACB0")]
	public byte[] GJFECNLNCPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AC20", Offset = "0x6F09E20", VA = "0x186F0AC20")]
	public void FKFEALEGJFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NOCBGJOEJIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected byte[] PLFNPOBLMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int FPEDIPALGCL;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private const int GLKMAKAHJND = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly bool HHOGIPLBFNF;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public static readonly UTF8Encoding DIBEAPBEAMN;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const int ECCCLEAEIKN = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly byte[] HALCKALMBNB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] ALBEJFPMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C0D0", Offset = "0x6F0B2D0", VA = "0x186F0C0D0")]
	public NOCBGJOEJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C030", Offset = "0x6F0B230", VA = "0x186F0C030")]
	public NOCBGJOEJIG(bool CDODODCGBNN, int FGEBALEMGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B3B0", Offset = "0x6F0A5B0", VA = "0x186F0B3B0")]
	public static NOCBGJOEJIG HIKPPIMIIBN(string MLCDCHNOCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B310", Offset = "0x6F0A510", VA = "0x186F0B310")]
	public void BKJCBMICLHJ(int NCANCFPGAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x271B6E0", Offset = "0x271A8E0", VA = "0x18271B6E0")]
	public void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BE30", Offset = "0x6F0B030", VA = "0x186F0BE30")]
	public void PODCJNJEIFH(float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BC80", Offset = "0x6F0AE80", VA = "0x186F0BC80")]
	public void PODCJNJEIFH(double MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BBD0", Offset = "0x6F0ADD0", VA = "0x186F0BBD0")]
	public void PODCJNJEIFH(long MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BBD0", Offset = "0x6F0ADD0", VA = "0x186F0BBD0")]
	public void PODCJNJEIFH(ulong MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BD40", Offset = "0x6F0AF40", VA = "0x186F0BD40")]
	public void PODCJNJEIFH(int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BD40", Offset = "0x6F0AF40", VA = "0x186F0BD40")]
	public void PODCJNJEIFH(uint MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B950", Offset = "0x6F0AB50", VA = "0x186F0B950")]
	public void PODCJNJEIFH(char MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B950", Offset = "0x6F0AB50", VA = "0x186F0B950")]
	public void PODCJNJEIFH(ushort MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B950", Offset = "0x6F0AB50", VA = "0x186F0B950")]
	public void PODCJNJEIFH(short MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BC20", Offset = "0x6F0AE20", VA = "0x186F0BC20")]
	public void PODCJNJEIFH(sbyte MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BC20", Offset = "0x6F0AE20", VA = "0x186F0BC20")]
	public void PODCJNJEIFH(byte MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BCD0", Offset = "0x6F0AED0", VA = "0x186F0BCD0")]
	public void PODCJNJEIFH(byte[] DHAOEHNLNON, int OEBFFKLMAPN, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B870", Offset = "0x6F0AA70", VA = "0x186F0B870")]
	public void LGCBALLCOKB(sbyte[] DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B870", Offset = "0x6F0AA70", VA = "0x186F0B870")]
	public void PANKDOKOBIE(byte[] DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BDD0", Offset = "0x6F0AFD0", VA = "0x186F0BDD0")]
	public void PODCJNJEIFH(bool MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B6B0", Offset = "0x6F0A8B0", VA = "0x186F0B6B0")]
	public void IIPBPMKMHIB(Array ICGIIPJBBDM, int PFFEFIAOMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B790", Offset = "0x6F0A990", VA = "0x186F0B790")]
	public void IIPBPMKMHIB(float[] MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B420", Offset = "0x6F0A620", VA = "0x186F0B420")]
	public void IIPBPMKMHIB(double[] MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B420", Offset = "0x6F0A620", VA = "0x186F0B420")]
	public void IIPBPMKMHIB(long[] MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B420", Offset = "0x6F0A620", VA = "0x186F0B420")]
	public void IIPBPMKMHIB(ulong[] MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B790", Offset = "0x6F0A990", VA = "0x186F0B790")]
	public void IIPBPMKMHIB(int[] MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B790", Offset = "0x6F0A990", VA = "0x186F0B790")]
	public void IIPBPMKMHIB(uint[] MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B5D0", Offset = "0x6F0A7D0", VA = "0x186F0B5D0")]
	public void IIPBPMKMHIB(ushort[] MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B5D0", Offset = "0x6F0A7D0", VA = "0x186F0B5D0")]
	public void IIPBPMKMHIB(short[] MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B870", Offset = "0x6F0AA70", VA = "0x186F0B870")]
	public void IIPBPMKMHIB(bool[] MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B500", Offset = "0x6F0A700", VA = "0x186F0B500")]
	public void IIPBPMKMHIB(string[] MLCDCHNOCFI, int DMBNDNKMOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BED0", Offset = "0x6F0B0D0", VA = "0x186F0BED0")]
	public void PODCJNJEIFH(IPEndPoint IMKDIDOBHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BFA0", Offset = "0x6F0B1A0", VA = "0x186F0BFA0")]
	public void PODCJNJEIFH(string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B9C0", Offset = "0x6F0ABC0", VA = "0x186F0B9C0")]
	public void PODCJNJEIFH(string MLCDCHNOCFI, int JKMHCAHCOEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JPPKPBLIEJP
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class DFDEBNLLMOF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly ulong CCDGCEMKGPH;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6A21060", Offset = "0x6A20260", VA = "0x186A21060")]
		static DFDEBNLLMOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void KMFNILELANI(MCPHJFIHPOH OHHBENOLPAE, object KJDONDGLCAK);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BEFHKILOJBD<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public JPPKPBLIEJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BEFHKILOJBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7EC70", Offset = "0x5E7DE70", VA = "0x185E7EC70")]
		internal void BNDELNKBDGO(MCPHJFIHPOH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HMHOECMPGMA<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public JPPKPBLIEJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HMHOECMPGMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA820", Offset = "0x4BA9A20", VA = "0x184BAA820")]
		internal void BNDELNKBDGO(MCPHJFIHPOH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly JBIPOJJFABA ECBOAFNOLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<ulong, KMFNILELANI> FCIJGMLFKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly NOCBGJOEJIG CKLKJMIHLPP;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6F05FA0", Offset = "0x6F051A0", VA = "0x186F05FA0")]
	public JPPKPBLIEJP(int KEEPFCJFCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x35A75B0", Offset = "0x35A67B0", VA = "0x1835A75B0", Slot = "4")]
	protected virtual ulong IFOIOHPAAHL<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F05E20", Offset = "0x6F05020", VA = "0x186F05E20", Slot = "5")]
	protected virtual KMFNILELANI MHBDLFNGHOA(MCPHJFIHPOH OHHBENOLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x387C3C0", Offset = "0x387B5C0", VA = "0x18387C3C0", Slot = "6")]
	protected virtual void KJEFIGBIBMD<T>(NOCBGJOEJIG GDEDILINNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F05DA0", Offset = "0x6F04FA0", VA = "0x186F05DA0")]
	public void BFEHHMGALJL(MCPHJFIHPOH OHHBENOLPAE, object KJDONDGLCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x387C430", Offset = "0x387B630", VA = "0x18387C430")]
	public void PNPAJCFNCBG<T>(NOCBGJOEJIG GDEDILINNBI, T BDLILJHJIHM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F05F50", Offset = "0x6F05150", VA = "0x186F05F50")]
	public void OGOOMOKDPBH(MCPHJFIHPOH OHHBENOLPAE, object KJDONDGLCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x387C200", Offset = "0x387B400", VA = "0x18387C200")]
	public void IPMPNJGHJBI<T>(Action<T> PDHOJMLGCNK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x387C040", Offset = "0x387B240", VA = "0x18387C040")]
	public void IPMPNJGHJBI<T, TUserData>(Action<T, TUserData> PDHOJMLGCNK) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class AGGOBLFGLIF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9240", Offset = "0x6EF8440", VA = "0x186EF9240")]
	public AGGOBLFGLIF(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HCNKPIFKFOI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6F04E20", Offset = "0x6F04020", VA = "0x186F04E20")]
	public HCNKPIFKFOI(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class JBIPOJJFABA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum KOIICOEMDLK
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class LCHLIHAMBBA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public KOIICOEMDLK AFGCMPJBOON;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x50BE2A0", Offset = "0x50BD4A0", VA = "0x1850BE2A0", Slot = "4")]
		public virtual void MNFKMEBPDCG(MethodInfo MGCKEHFMDMO, MethodInfo BIBMOKMFHJC, KOIICOEMDLK EDLOHJEBKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KJEPGEPIIEO(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void HBFLIGNJDHN(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		protected LCHLIHAMBBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class DAGPGBKBJPN<TClass, TProperty> : LCHLIHAMBBA<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, TProperty> MCJCABFNDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, TProperty> KDIHHBCKIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		protected Func<TClass, TProperty[]> CODLIIDFPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Action<TClass, TProperty[]> PAGLILNPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Func<TClass, List<TProperty>> NMMLAFHAEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Action<TClass, List<TProperty>> HJFFGHPEJCB;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x69C6EF0", Offset = "0x69C60F0", VA = "0x1869C6EF0", Slot = "7")]
		public override void FIIBDFJDKKF(TClass GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x69CDCA0", Offset = "0x69CCEA0", VA = "0x1869CDCA0", Slot = "8")]
		public override void OEHPDNDBOLB(TClass GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x69C8C00", Offset = "0x69C7E00", VA = "0x1869C8C00", Slot = "9")]
		public override void KJEPGEPIIEO(TClass GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x69C8230", Offset = "0x69C7430", VA = "0x1869C8230", Slot = "10")]
		public override void HBFLIGNJDHN(TClass GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x69C8310", Offset = "0x69C7510", VA = "0x1869C8310")]
		protected TProperty[] HCINDCPCPCB(TClass GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x69C8F80", Offset = "0x69C8180", VA = "0x1869C8F80")]
		protected TProperty[] LDOOOHJOIJM(TClass GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x69C9000", Offset = "0x69C8200", VA = "0x1869C9000", Slot = "4")]
		public override void MNFKMEBPDCG(MethodInfo MGCKEHFMDMO, MethodInfo BIBMOKMFHJC, KOIICOEMDLK EDLOHJEBKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4A590C0", Offset = "0x4A582C0", VA = "0x184A590C0")]
		protected DAGPGBKBJPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class HFKCOMPEPJF<TClass, TProperty> : DAGPGBKBJPN<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void MJIIMOBOPML(MCPHJFIHPOH DENDMCHJGLJ, [Out] TProperty KKBMFBBLPCN);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void LMOMILPBNCH(NOCBGJOEJIG CGJLBECCPJC, TProperty KKBMFBBLPCN);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4B222A0", Offset = "0x4B214A0", VA = "0x184B222A0", Slot = "5")]
		public override void CADFNPGIBLB(TClass GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4B226E0", Offset = "0x4B218E0", VA = "0x184B226E0", Slot = "6")]
		public override void PNPAJCFNCBG(TClass GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4B224A0", Offset = "0x4B216A0", VA = "0x184B224A0", Slot = "7")]
		public override void FIIBDFJDKKF(TClass GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4B22620", Offset = "0x4B21820", VA = "0x184B22620", Slot = "8")]
		public override void OEHPDNDBOLB(TClass GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x499BBD0", Offset = "0x499ADD0", VA = "0x18499BBD0")]
		protected HFKCOMPEPJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class GDLBOKDNGMK<T> : DAGPGBKBJPN<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4A52AD0", Offset = "0x4A51CD0", VA = "0x184A52AD0", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4A52C40", Offset = "0x4A51E40", VA = "0x184A52C40", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4A52B50", Offset = "0x4A51D50", VA = "0x184A52B50", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4A52BD0", Offset = "0x4A51DD0", VA = "0x184A52BD0", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public GDLBOKDNGMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class NLFOMIKOOBK<T> : DAGPGBKBJPN<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x53BCB00", Offset = "0x53BBD00", VA = "0x1853BCB00", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4A52C40", Offset = "0x4A51E40", VA = "0x184A52C40", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x53BCB80", Offset = "0x53BBD80", VA = "0x1853BCB80", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4A52BD0", Offset = "0x4A51DD0", VA = "0x184A52BD0", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public NLFOMIKOOBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class OGLEONPJONP<T> : DAGPGBKBJPN<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x55340C0", Offset = "0x55332C0", VA = "0x1855340C0", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4538DA0", Offset = "0x4537FA0", VA = "0x184538DA0", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5534140", Offset = "0x5533340", VA = "0x185534140", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4538D30", Offset = "0x4537F30", VA = "0x184538D30", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public OGLEONPJONP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class EJMJIPCGAIL<T> : DAGPGBKBJPN<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4538C30", Offset = "0x4537E30", VA = "0x184538C30", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4538DA0", Offset = "0x4537FA0", VA = "0x184538DA0", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4538CB0", Offset = "0x4537EB0", VA = "0x184538CB0", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4538D30", Offset = "0x4537F30", VA = "0x184538D30", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public EJMJIPCGAIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class MNAKDFEENJD<T> : DAGPGBKBJPN<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x53253B0", Offset = "0x53245B0", VA = "0x1853253B0", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x49A8CF0", Offset = "0x49A7EF0", VA = "0x1849A8CF0", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5325430", Offset = "0x5324630", VA = "0x185325430", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x49A8C80", Offset = "0x49A7E80", VA = "0x1849A8C80", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public MNAKDFEENJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class FHMLAEKALBK<T> : DAGPGBKBJPN<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x49A8B80", Offset = "0x49A7D80", VA = "0x1849A8B80", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x49A8CF0", Offset = "0x49A7EF0", VA = "0x1849A8CF0", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x49A8C00", Offset = "0x49A7E00", VA = "0x1849A8C00", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x49A8C80", Offset = "0x49A7E80", VA = "0x1849A8C80", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public FHMLAEKALBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CPEJEIOEPMI<T> : DAGPGBKBJPN<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4535DC0", Offset = "0x4534FC0", VA = "0x184535DC0", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4535F30", Offset = "0x4535130", VA = "0x184535F30", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x663F480", Offset = "0x663E680", VA = "0x18663F480", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4535EC0", Offset = "0x45350C0", VA = "0x184535EC0", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public CPEJEIOEPMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class EHGFGFFMAIG<T> : DAGPGBKBJPN<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4535DC0", Offset = "0x4534FC0", VA = "0x184535DC0", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4535F30", Offset = "0x4535130", VA = "0x184535F30", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4535E40", Offset = "0x4535040", VA = "0x184535E40", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4535EC0", Offset = "0x45350C0", VA = "0x184535EC0", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public EHGFGFFMAIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class PAGFHCNHHEJ<T> : DAGPGBKBJPN<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x55F7680", Offset = "0x55F6880", VA = "0x1855F7680", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x55F7780", Offset = "0x55F6980", VA = "0x1855F7780", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x55F7700", Offset = "0x55F6900", VA = "0x1855F7700", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4A52BD0", Offset = "0x4A51DD0", VA = "0x184A52BD0", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public PAGFHCNHHEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MLLKHMAGHHE<T> : DAGPGBKBJPN<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5323C50", Offset = "0x5322E50", VA = "0x185323C50", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5323D50", Offset = "0x5322F50", VA = "0x185323D50", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5323CD0", Offset = "0x5322ED0", VA = "0x185323CD0", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x49A8C80", Offset = "0x49A7E80", VA = "0x1849A8C80", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public MLLKHMAGHHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class JAOGMJJJLDO<T> : DAGPGBKBJPN<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D030", Offset = "0x4E7C230", VA = "0x184E7D030", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D130", Offset = "0x4E7C330", VA = "0x184E7D130", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D0B0", Offset = "0x4E7C2B0", VA = "0x184E7D0B0", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4535EC0", Offset = "0x45350C0", VA = "0x184535EC0", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
		public JAOGMJJJLDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class JAMPBMFHEAJ<T> : HFKCOMPEPJF<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E7CFD0", Offset = "0x4E7C1D0", VA = "0x184E7CFD0", Slot = "12")]
		protected override void LMOMILPBNCH(NOCBGJOEJIG CGJLBECCPJC, char KKBMFBBLPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D000", Offset = "0x4E7C200", VA = "0x184E7D000", Slot = "11")]
		protected override void MJIIMOBOPML(MCPHJFIHPOH DENDMCHJGLJ, [Out] char KKBMFBBLPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x44F4310", Offset = "0x44F3510", VA = "0x1844F4310")]
		public JAMPBMFHEAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class CHEDOALBHPN<T> : HFKCOMPEPJF<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x653BF60", Offset = "0x653B160", VA = "0x18653BF60", Slot = "12")]
		protected override void LMOMILPBNCH(NOCBGJOEJIG CGJLBECCPJC, IPEndPoint KKBMFBBLPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x653BF90", Offset = "0x653B190", VA = "0x18653BF90", Slot = "11")]
		protected override void MJIIMOBOPML(MCPHJFIHPOH DENDMCHJGLJ, [Out] IPEndPoint KKBMFBBLPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x44F4310", Offset = "0x44F3510", VA = "0x1844F4310")]
		public CHEDOALBHPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class NCNFIODBOBN<T> : DAGPGBKBJPN<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly int CFHCEMHCJPJ;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x537BA60", Offset = "0x537AC60", VA = "0x18537BA60")]
		public NCNFIODBOBN(int JKMHCAHCOEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x537B860", Offset = "0x537AA60", VA = "0x18537B860", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x537B9E0", Offset = "0x537ABE0", VA = "0x18537B9E0", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x537B8E0", Offset = "0x537AAE0", VA = "0x18537B8E0", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x537B960", Offset = "0x537AB60", VA = "0x18537B960", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class HFGOADHIBNL<T> : LCHLIHAMBBA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected readonly PropertyInfo ODIKCIDEBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected readonly Type DEIBPOEPLJH;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4B22180", Offset = "0x4B21380", VA = "0x184B22180")]
		public HFGOADHIBNL(PropertyInfo FOCHDHDPJJM, Type OPILNKGFJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4B21E90", Offset = "0x4B21090", VA = "0x184B21E90", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4B220D0", Offset = "0x4B212D0", VA = "0x184B220D0", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B21F50", Offset = "0x4B21150", VA = "0x184B21F50", Slot = "7")]
		public override void FIIBDFJDKKF(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4B22070", Offset = "0x4B21270", VA = "0x184B22070", Slot = "8")]
		public override void OEHPDNDBOLB(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4B22010", Offset = "0x4B21210", VA = "0x184B22010", Slot = "9")]
		public override void KJEPGEPIIEO(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B21FB0", Offset = "0x4B211B0", VA = "0x184B21FB0", Slot = "10")]
		public override void HBFLIGNJDHN(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class DHFAPNOMMNE<T> : HFGOADHIBNL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4EADE10", Offset = "0x4EAD010", VA = "0x184EADE10")]
		public DHFAPNOMMNE(PropertyInfo FOCHDHDPJJM, Type OPILNKGFJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A24D10", Offset = "0x6A23F10", VA = "0x186A24D10", Slot = "5")]
		public override void CADFNPGIBLB(T GBFIACKKFEP, MCPHJFIHPOH DENDMCHJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6A24DD0", Offset = "0x6A23FD0", VA = "0x186A24DD0", Slot = "6")]
		public override void PNPAJCFNCBG(T GBFIACKKFEP, NOCBGJOEJIG CGJLBECCPJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class MFIFLNFHDNJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static MFIFLNFHDNJ<T> NDDGJHHDBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly LCHLIHAMBBA<T>[] JLMOHFDKKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly int GGBBJHIPJGA;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x52DC520", Offset = "0x52DB720", VA = "0x1852DC520")]
		public MFIFLNFHDNJ(List<LCHLIHAMBBA<T>> GGLJPLEJHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x52DC470", Offset = "0x52DB670", VA = "0x1852DC470")]
		public void PNPAJCFNCBG(T DBCLNEGBNLN, NOCBGJOEJIG GDEDILINNBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x52DC3C0", Offset = "0x52DB5C0", VA = "0x1852DC3C0")]
		public void CADFNPGIBLB(T DBCLNEGBNLN, MCPHJFIHPOH OHHBENOLPAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class DODJEEFHAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract LCHLIHAMBBA<T> HKFPFFCEPKK<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private NOCBGJOEJIG DOLMGMPJNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int ADIJFNCONCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Dictionary<Type, DODJEEFHAKK> BMJAMGLDKJA;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6F058E0", Offset = "0x6F04AE0", VA = "0x186F058E0")]
	public JBIPOJJFABA(int KEEPFCJFCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3864470", Offset = "0x3863670", VA = "0x183864470")]
	private MFIFLNFHDNJ<T> MABOJGDDGOL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3673C70", Offset = "0x3672E70", VA = "0x183673C70")]
	public void OOCHIMKFMHO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38643D0", Offset = "0x38635D0", VA = "0x1838643D0")]
	public bool JKAINKAKBPB<T>(MCPHJFIHPOH OHHBENOLPAE, T PJNHLGGHCLG) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3864340", Offset = "0x3863540", VA = "0x183864340")]
	public void CEBCPPBDNIB<T>(NOCBGJOEJIG GDEDILINNBI, T DBCLNEGBNLN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KMNNAJDEACF
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static readonly DateTime HONHPFLIKOC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] OILJIPOEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FDBNFJAKDDP BOBHMKLPIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F08440", Offset = "0x6F07640", VA = "0x186F08440")]
		get
		{
			return default(FDBNFJAKDDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KPNBIKBCPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F084B0", Offset = "0x6F076B0", VA = "0x186F084B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F08470", Offset = "0x6F07670", VA = "0x186F08470")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BKILNFEKJNJ LLEGIEGKNBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F07A40", Offset = "0x6F06C40", VA = "0x186F07A40")]
		get
		{
			return default(BKILNFEKJNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F07EE0", Offset = "0x6F070E0", VA = "0x186F07EE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int DHLOCDFLBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F07D90", Offset = "0x6F06F90", VA = "0x186F07D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint OHALENAKBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F07F20", Offset = "0x6F07120", VA = "0x186F07F20")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? NLBGMIIGPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F07C70", Offset = "0x6F06E70", VA = "0x186F07C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? EOLDCGGKDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F07A70", Offset = "0x6F06C70", VA = "0x186F07A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? KMFFNFLOMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F07CA0", Offset = "0x6F06EA0", VA = "0x186F07CA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F07AA0", Offset = "0x6F06CA0", VA = "0x186F07AA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? LDPLALJIFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xDD6D20", Offset = "0xDD5F20", VA = "0x180DD6D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F08AC0", Offset = "0x6F07CC0", VA = "0x186F08AC0")]
	public KMNNAJDEACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F08A10", Offset = "0x6F07C10", VA = "0x186F08A10")]
	internal KMNNAJDEACF(byte[] FONJAIMABAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F07DC0", Offset = "0x6F06FC0", VA = "0x186F07DC0")]
	public static KMNNAJDEACF FDHDPGDMJEN(byte[] FONJAIMABAP, DateTime MMNAEHKLEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F08750", Offset = "0x6F07950", VA = "0x186F08750")]
	internal void OIJMKAINLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F08570", Offset = "0x6F07770", VA = "0x186F08570")]
	private void NOLLFPBDJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F08240", Offset = "0x6F07440", VA = "0x186F08240")]
	private DateTime? JAPHKOIAIMI(int OEBFFKLMAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F07FA0", Offset = "0x6F071A0", VA = "0x186F07FA0")]
	private void IIPHOOBLMCE(int OEBFFKLMAPN, DateTime? MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F08170", Offset = "0x6F07370", VA = "0x186F08170")]
	private ulong IPFKCCLNKLN(int OEBFFKLMAPN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F07CD0", Offset = "0x6F06ED0", VA = "0x186F07CD0")]
	private void ECJDHCNLEHH(int OEBFFKLMAPN, ulong MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F084E0", Offset = "0x6F076E0", VA = "0x186F084E0")]
	private uint NGJJNNMMCJH(int OEBFFKLMAPN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6DC15D0", Offset = "0x6DC07D0", VA = "0x186DC15D0")]
	private static uint OLPFGLHACOG(uint CCOLDGJALNH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F08950", Offset = "0x6F07B50", VA = "0x186F08950")]
	private static ulong OLPFGLHACOG(ulong CCOLDGJALNH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum FDBNFJAKDDP
{
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum BKILNFEKJNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class DEDAGCGDEMH
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private const int JFAOFBOAGDF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private const int COAJMNBCNBC = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public const int CDJJFFNAIAL = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly IPEndPoint CAIMKPFPCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private int CJFOELHFHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private int FOGKCMHLLEI;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CKMLMCOAIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F01B20", Offset = "0x6F00D20", VA = "0x186F01B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F01B30", Offset = "0x6F00D30", VA = "0x186F01B30")]
	public bool FOHJPDGGHJE(HHJAIHGALKE EEIAAOKGCHG, int ALBGFINLCPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class BONGKHEDKHJ : HHJAIHGALKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Socket EEIAAOKGCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly DALOGGGEBEO PBEEMOPBNPE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short FPOOLEEHFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9980", Offset = "0x6EF8B80", VA = "0x186EF9980", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ECAEHLGOFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6EF99A0", Offset = "0x6EF8BA0", VA = "0x186EF99A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint JPCJJJOKEND
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9920", Offset = "0x6EF8B20", VA = "0x186EF9920", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily AIENAKAOKND
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x50A0C60", Offset = "0x509FE60", VA = "0x1850A0C60", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EF99C0", Offset = "0x6EF8BC0", VA = "0x186EF99C0")]
	public BONGKHEDKHJ(AddressFamily NGOHALIPGNF, DALOGGGEBEO PBEEMOPBNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9360", Offset = "0x6EF8560", VA = "0x186EF9360", Slot = "8")]
	public bool FNJCMKJIHPL(IPEndPoint IMKDIDOBHNO, GMDOMABJLEC MDJPMJNFKLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9940", Offset = "0x6EF8B40", VA = "0x186EF9940", Slot = "9")]
	public int MGJLMFHBKGN(byte[] KKCFCHBPMCG, int OEBFFKLMAPN, int JAFKPMJIGFL, IPEndPoint DBCDMFBPKFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9270", Offset = "0x6EF8470", VA = "0x186EF9270", Slot = "10")]
	public int FBPPCPAHNJO(byte[] KKCFCHBPMCG, EndPoint LJLCIFMNGAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9250", Offset = "0x6EF8450", VA = "0x186EF9250", Slot = "11")]
	public void CAGFIGAIJCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface HHJAIHGALKE
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short FPOOLEEHFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int ECAEHLGOFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint JPCJJJOKEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily AIENAKAOKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FNJCMKJIHPL(IPEndPoint IMKDIDOBHNO, GMDOMABJLEC MDJPMJNFKLE);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int MGJLMFHBKGN(byte[] KKCFCHBPMCG, int OEBFFKLMAPN, int JAFKPMJIGFL, IPEndPoint DBCDMFBPKFD);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FBPPCPAHNJO(byte[] KKCFCHBPMCG, EndPoint DBCDMFBPKFD);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CAGFIGAIJCN();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct JNLIHPCOCHM : IEquatable<JNLIHPCOCHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly long CHLNBCKJBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly long ELHEDDJLKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly long IFMJABMFOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly int MOHCKIMHOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int GCPKFCNADCK;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6F05CE0", Offset = "0x6F04EE0", VA = "0x186F05CE0")]
	public JNLIHPCOCHM(byte[] JMDMMDHMCCH, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6F05A70", Offset = "0x6F04C70", VA = "0x186F05A70")]
	public JNLIHPCOCHM(Span<byte> JMDMMDHMCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA18BE0", Offset = "0xA17DE0", VA = "0x180A18BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6F05A30", Offset = "0x6F04C30", VA = "0x186F05A30", Slot = "4")]
	public bool Equals(JNLIHPCOCHM FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6F05980", Offset = "0x6F04B80", VA = "0x186F05980", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class GCLNJPFAGBN : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly byte[] GDLAHEMANAP;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LBDPCDMCCEP
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal delegate void KKPGAHECKMA(IPEndPoint JMDMMDHMCCH, Span<byte> DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string FNNMDDBHCEI = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private const int KIEEKELKPFK = 16;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const int DEGOAIOECMM = 28;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static Dictionary<JNLIHPCOCHM, IPEndPoint> JHLCCLLLFEF;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static KKPGAHECKMA CBHDBELHFLD;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	internal void KHHCHEKDDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	internal void ACGJGHPLLPC(IPEndPoint DBCDMFBPKFD, Span<byte> DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class KHGBNANGKIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly int AADPCOKKFGE;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
	protected KHGBNANGKIJ(int HCLCGFBNMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void HEMDNKEEBAO(IPEndPoint IMKDIDOBHNO, byte[] DHAOEHNLNON, int OEBFFKLMAPN, int LMMGFKFHEJP);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DMOPFJGLOEG(IPEndPoint IMKDIDOBHNO, byte[] DHAOEHNLNON, int OEBFFKLMAPN, int LMMGFKFHEJP);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class EECGDKFGIHK : KHGBNANGKIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private byte[] AGBHGDFILGO;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly RandomNumberGenerator MPHMGDHLOPM;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x27E85B0", Offset = "0x27E77B0", VA = "0x1827E85B0")]
	public EECGDKFGIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6F02F70", Offset = "0x6F02170", VA = "0x186F02F70")]
	public void MNFIMJHOLFB(IPEndPoint IMKDIDOBHNO, byte[] AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6F02E90", Offset = "0x6F02090", VA = "0x186F02E90")]
	public void LPGDBDHOABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F029E0", Offset = "0x6F01BE0", VA = "0x186F029E0", Slot = "4")]
	public override void HEMDNKEEBAO(IPEndPoint IMKDIDOBHNO, byte[] DHAOEHNLNON, int OEBFFKLMAPN, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F02680", Offset = "0x6F01880", VA = "0x186F02680", Slot = "5")]
	public override void DMOPFJGLOEG(IPEndPoint IMKDIDOBHNO, byte[] DHAOEHNLNON, int OEBFFKLMAPN, int LMMGFKFHEJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[BurstCompile]
internal struct GPDDANFPMED
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void HKFNHNPKONF([NoAlias] byte* DDGCPNECNFC, [NoAlias] byte* AGBHGDFILGO, [NoAlias] byte* LPNHHDDDCIG, int LMMGFKFHEJP);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class POLNKGOMOID
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6F0D000", Offset = "0x6F0C200", VA = "0x186F0D000")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6F0D120", Offset = "0x6F0C320", VA = "0x186F0D120")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CD30", Offset = "0x6F0BF30", VA = "0x186F0CD30")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CDD0", Offset = "0x6F0BFD0", VA = "0x186F0CDD0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] byte* DDGCPNECNFC, [NoAlias] byte* AGBHGDFILGO, [NoAlias] byte* LPNHHDDDCIG, int LMMGFKFHEJP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private unsafe fixed uint AGBHGDFILGO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private unsafe fixed uint LPNHHDDDCIG[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private unsafe fixed uint EFFGLPGNJKF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint CIDBFKJKPCE[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint ABOMNNODBNI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint MFPCBODPKPE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint KALDEGMKMGB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private uint KLHEKBOGFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint POMMAOAOILC[8];

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F04AA0", Offset = "0x6F03CA0", VA = "0x186F04AA0")]
	private void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F04DF0", Offset = "0x6F03FF0", VA = "0x186F04DF0")]
	private uint OOPGGFHPNDE(uint KOBHBJCHIOC, int GOKBGOMFIIG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4D70", Offset = "0x6EF3F70", VA = "0x186EF4D70")]
	private void HFHGANJAKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4E20", Offset = "0x6EF4020", VA = "0x186EF4E20")]
	private void LOFAEILLHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4BE0", Offset = "0x6EF3DE0", VA = "0x186EF4BE0")]
	private void BCOLFCALLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4C70", Offset = "0x6EF3E70", VA = "0x186EF4C70")]
	private void BIADOKHMGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F04A40", Offset = "0x6F03C40", VA = "0x186F04A40")]
	private void AIGBFBCCKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F04620", Offset = "0x6F03820", VA = "0x186F04620")]
	private unsafe void AHHODJLLNPL(byte* DDGCPNECNFC, uint* AGBHGDFILGO, uint* LPNHHDDDCIG, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F04B20", Offset = "0x6F03D20", VA = "0x186F04B20")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void EDPPBJLCABA([NoAlias] byte* DDGCPNECNFC, [NoAlias] byte* AGBHGDFILGO, [NoAlias] byte* LPNHHDDDCIG, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6F04BA0", Offset = "0x6F03DA0", VA = "0x186F04BA0")]
	public static void EDPPBJLCABA(Span<byte> DDGCPNECNFC, Span<byte> AGBHGDFILGO, Span<byte> LPNHHDDDCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6F04C80", Offset = "0x6F03E80", VA = "0x186F04C80")]
	public static void HJCNJBOPCKC(Span<byte> DDGCPNECNFC, Span<byte> AGBHGDFILGO, Span<byte> LPNHHDDDCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6F04D80", Offset = "0x6F03F80", VA = "0x186F04D80")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void JEFOBCHHMAJ([NoAlias] byte* DDGCPNECNFC, [NoAlias] byte* AGBHGDFILGO, [NoAlias] byte* LPNHHDDDCIG, int LMMGFKFHEJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D270", Offset = "0x6F0C470", VA = "0x186F0D270")]
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
