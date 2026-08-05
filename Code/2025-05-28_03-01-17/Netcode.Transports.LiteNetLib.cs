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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, GAKBGANBAEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum EFJPBPGIFKG
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
		private NetworkManager ANKFKNIJBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool DNKMEKLHLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, OADDMODKIPC> MHINLCDKOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PNOJAHGJGMP AEGJCADAHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch LKILDGBLAJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] HLDIGJFBGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EFJPBPGIFKG LGJGBAFNEIM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int HNHKICBCCAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6FECEB0", Offset = "0x6FEBCB0", VA = "0x186FECEB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong CFOPPPHJMCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IEHEJGNJPBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6FECE90", Offset = "0x6FEBC90", VA = "0x186FECE90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC480", Offset = "0x6FEB280", VA = "0x186FEC480")]
		public void RecRoom_SetEncryptionInfo(ulong DLPPBABIEFL, byte[] MAKJJJECHHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC460", Offset = "0x6FEB260", VA = "0x186FEC460")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC330", Offset = "0x6FEB130", VA = "0x186FEC330")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FECD90", Offset = "0x6FEBB90", VA = "0x186FECD90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC5A0", Offset = "0x6FEB3A0", VA = "0x186FEC5A0", Slot = "6")]
		public override void Send(ulong EMKNGKOPAPH, ArraySegment<byte> FFEMKICJPKP, NetworkDelivery LKECOOENBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC420", Offset = "0x6FEB220", VA = "0x186FEC420", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong EMKNGKOPAPH, [Out] ArraySegment<byte> DKEBGKJJPPO, [Out] float IPEFHDEIPCI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC890", Offset = "0x6FEB690", VA = "0x186FEC890", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FECBB0", Offset = "0x6FEB9B0", VA = "0x186FECBB0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB9A0", Offset = "0x6FEA7A0", VA = "0x186FEB9A0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong EMKNGKOPAPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB8B0", Offset = "0x6FEA6B0", VA = "0x186FEB8B0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBBF0", Offset = "0x6FEA9F0", VA = "0x186FEBBF0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong EMKNGKOPAPH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC820", Offset = "0x6FEB620", VA = "0x186FEC820", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBE20", Offset = "0x6FEAC20", VA = "0x186FEBE20", Slot = "15")]
		public override void Initialize([Optional] NetworkManager ANKFKNIJBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC030", Offset = "0x6FEAE30", VA = "0x186FEC030")]
		private PEKNJKOFEDH KDFOPCEOKHM(NetworkDelivery AAFMBEEMJAC)
		{
			return default(PEKNJKOFEDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBC90", Offset = "0x6FEAA90", VA = "0x186FEBC90", Slot = "16")]
		private void HEDAMOGNPFK(OADDMODKIPC MKLMGGKDBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBD50", Offset = "0x6FEAB50", VA = "0x186FEBD50", Slot = "17")]
		private void ILBAPNCLCNI(OADDMODKIPC MKLMGGKDBLL, BHAONIGHBPP DFJADOIBLEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "18")]
		private void ICBAJNOKJHG(IPEndPoint IOAJJGFAGCE, SocketError DHMMAHDEKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC120", Offset = "0x6FEAF20", VA = "0x186FEC120", Slot = "19")]
		private void NKHMBBLIGJL(OADDMODKIPC MKLMGGKDBLL, LHODEHBLEPK JFLBMHOJFED, byte GPBBAJELILC, PEKNJKOFEDH KAKOKCBEDPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBAB0", Offset = "0x6FEA8B0", VA = "0x186FEBAB0")]
		private void EKLHBNBOJFP(int ACINDEOBNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "20")]
		private void LFGEOFIDPOD(IPEndPoint HGHNKNJEODJ, LHODEHBLEPK JFLBMHOJFED, IFDLMILNBEP IDKJLFNOBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "21")]
		private void NIGEPHFBGOK(OADDMODKIPC MKLMGGKDBLL, int GKCADDHHKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBB90", Offset = "0x6FEA990", VA = "0x186FEBB90", Slot = "22")]
		private void FKBAHDEIJIA(NNMEILAJGIC OHDJLNAKLPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB880", Offset = "0x6FEA680", VA = "0x186FEB880")]
		private ulong CMAPLHAGHIL(OADDMODKIPC MKLMGGKDBLL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC100", Offset = "0x6FEAF00", VA = "0x186FEC100")]
		private static int MADMPIFCKCO(float POHFDNBLLPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FECDB0", Offset = "0x6FEBBB0", VA = "0x186FECDB0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class CNKEDIGAPKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly OADDMODKIPC DEGEKDFOJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<BBBPAMGEEOG> BFEGEIMOCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int CGFEBKIADGG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GOIACFLLEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5D40", Offset = "0x6FE4B40", VA = "0x186FE5D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5E10", Offset = "0x6FE4C10", VA = "0x186FE5E10")]
	protected CNKEDIGAPKB(OADDMODKIPC MKLMGGKDBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5CA0", Offset = "0x6FE4AA0", VA = "0x186FE5CA0")]
	public void KIPCIMMGFOO(BBBPAMGEEOG HMMDBBEAMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5D90", Offset = "0x6FE4B90", VA = "0x186FE5D90")]
	protected void OHIBGEEOGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5D00", Offset = "0x6FE4B00", VA = "0x186FE5D00")]
	public bool LCMGGDMHGBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool FPIIGKAKDJK();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool EDGBBKACLJM(BBBPAMGEEOG HMMDBBEAMNI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum EEJFBBAKOKG
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
public class NNMEILAJGIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly PNOJAHGJGMP FGGJCNGBOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int CCBNODIGDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal KAGODBOBBID HPCBKNDOLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint GKALOKJLMDE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal EEJFBBAKOKG IBGOAACNDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA31A00", Offset = "0xA30800", VA = "0x180A31A00")]
		[CompilerGenerated]
		get
		{
			return default(EEJFBBAKOKG);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xD8DB90", Offset = "0xD8C990", VA = "0x180D8DB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6FED4F0", Offset = "0x6FEC2F0", VA = "0x186FED4F0")]
	internal void OAGCNGGKNGC(KAGODBOBBID MDOFLECOFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6FED460", Offset = "0x6FEC260", VA = "0x186FED460")]
	private bool EFCHMGLGOGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6FED550", Offset = "0x6FEC350", VA = "0x186FED550")]
	internal NNMEILAJGIC(IPEndPoint HGHNKNJEODJ, KAGODBOBBID HDLBHAJPNCL, PNOJAHGJGMP FACIPJMCLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FED490", Offset = "0x6FEC290", VA = "0x186FED490")]
	public OADDMODKIPC FMJCMJGAEEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IFDLMILNBEP
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum NMBHELEPEEI
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
public struct BHAONIGHBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NMBHELEPEEI ECPJIBMFHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError EONGCEDOPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public LHODEHBLEPK NDMNDGAOAAP;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GAKBGANBAEP
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGGGAGILLGO(OADDMODKIPC MKLMGGKDBLL);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLJGKPCBBMA(OADDMODKIPC MKLMGGKDBLL, BHAONIGHBPP DFJADOIBLEP);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHEIEONACJB(IPEndPoint IOAJJGFAGCE, SocketError DHMMAHDEKAJ);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BAHECGGJEJL(OADDMODKIPC MKLMGGKDBLL, LHODEHBLEPK JFLBMHOJFED, byte GPBBAJELILC, PEKNJKOFEDH KAKOKCBEDPO);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GAFGJOKNDEL(IPEndPoint HGHNKNJEODJ, LHODEHBLEPK JFLBMHOJFED, IFDLMILNBEP IDKJLFNOBOG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FECOPPGCKKK(OADDMODKIPC MKLMGGKDBLL, int GKCADDHHKDP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JKIMEFLCEJF(NNMEILAJGIC OHDJLNAKLPC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CALEELALMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INGPJOKJECE(OADDMODKIPC MKLMGGKDBLL, object BLHCIGPBGBI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BFCHOOBHGBF
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMCOCAOHCPG(GPEPDGEFGDN HMMDBBEAMNI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ECHALNJOCID
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFLNNLHPCJL(OADDMODKIPC MKLMGGKDBLL, IPEndPoint KACFNHPLAGF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class KAGODBOBBID
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int IPICPPOEFFM = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long KMIMFFGHLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte NBDNMKHFECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] CNMEPOKEBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly EEKDFBBOCIK NOKLNLDMACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int EIJOPCFJOOE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB540", Offset = "0x6FEA340", VA = "0x186FEB540")]
	private KAGODBOBBID(long LGHBKONAEJN, byte OADIANKHJEP, int CBBNAACPEGP, byte[] CFAFAJPDDID, EEKDFBBOCIK FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB4E0", Offset = "0x6FEA2E0", VA = "0x186FEB4E0")]
	public static int NLKACFFHJKH(BBBPAMGEEOG HMMDBBEAMNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB2C0", Offset = "0x6FEA0C0", VA = "0x186FEB2C0")]
	public static KAGODBOBBID JBPIACJPJBM(BBBPAMGEEOG HMMDBBEAMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB0E0", Offset = "0x6FE9EE0", VA = "0x186FEB0E0")]
	public static BBBPAMGEEOG GIKDEDNGHLF(EJPLMILLDOF HENHIEINLKB, SocketAddress LADPFIOIPOM, long GGBKJMCLNDB, int CBBNAACPEGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class HAFDMHLAJNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long KMIMFFGHLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte NBDNMKHFECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int EIJOPCFJOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool NLACANNBFJL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB020", Offset = "0x6FE9E20", VA = "0x186FEB020")]
	private HAFDMHLAJNO(long LGHBKONAEJN, byte OADIANKHJEP, int KBKMJGFBOAJ, bool MGKJHENOAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAED0", Offset = "0x6FE9CD0", VA = "0x186FEAED0")]
	public static HAFDMHLAJNO JBPIACJPJBM(BBBPAMGEEOG HMMDBBEAMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FEADE0", Offset = "0x6FE9BE0", VA = "0x186FEADE0")]
	public static BBBPAMGEEOG GIKDEDNGHLF(long GGBKJMCLNDB, byte OJIPKOKNCPH, int NMJOGKIKCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FEACE0", Offset = "0x6FE9AE0", VA = "0x186FEACE0")]
	public static BBBPAMGEEOG ANBODIAGJHE(OADDMODKIPC MKLMGGKDBLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum JCILPOJIDFE
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KMHLFBLKOCN
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFMLGFJKJKD(IPEndPoint NNIJKAGKFLF, IPEndPoint HGHNKNJEODJ, string JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMBIGPDIGCH(IPEndPoint NAPLLLIKBJJ, JCILPOJIDFE AAFMBEEMJAC, string JLFLGDNCANL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class ANCHPGJNEDC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct MNGHDBMEKFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint BAEOILMIFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint GKALOKJLMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string CCBEJILEEIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct DPCJOCJJNFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint GKMIPCNECKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public JCILPOJIDFE KDNIOMEAELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string CCBEJILEEIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class LELPMFJPPNA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint JOJAJMIJLNI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string CCBEJILEEIP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LELPMFJPPNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class BGBFOLEHCAE
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint JOJAJMIJLNI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint FJEOHAOHNED
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string CCBEJILEEIP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BGBFOLEHCAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class PPLDEMIMPFF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string CCBEJILEEIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool JCIFGMIGBPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA0B690", Offset = "0xA0A490", VA = "0x180A0B690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PPLDEMIMPFF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PNOJAHGJGMP EFIIFMENLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<MNGHDBMEKFJ> GFLNOCNBEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<DPCJOCJJNFM> CNPOFFABJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly EEKDFBBOCIK JBHEBHEKFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly EJPLMILLDOF KNLGPELJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly GDDHJBGKJIL BOODMNKICHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private KMHLFBLKOCN MGKFAMJIOCD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int CEGLPONLLOP = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool DINDPMJANLH;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6FE42D0", Offset = "0x6FE30D0", VA = "0x186FE42D0")]
	internal ANCHPGJNEDC(PNOJAHGJGMP POHDKHBEDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6FE4150", Offset = "0x6FE2F50", VA = "0x186FE4150")]
	internal void POKIDPKIKHN(IPEndPoint JCNAEDIGJJK, BBBPAMGEEOG HMMDBBEAMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x414CFF0", Offset = "0x414BDF0", VA = "0x18414CFF0")]
	private void ODFOIKANOLH<T>(T HMMDBBEAMNI, IPEndPoint GDCDKMJLKDH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3FC0", Offset = "0x6FE2DC0", VA = "0x186FE3FC0")]
	private void KFMLGFJKJKD(LELPMFJPPNA NKLCJOAMGPJ, IPEndPoint JCNAEDIGJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3E60", Offset = "0x6FE2C60", VA = "0x186FE3E60")]
	private void CLJMDJEFMIH(BGBFOLEHCAE NKLCJOAMGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3CC0", Offset = "0x6FE2AC0", VA = "0x186FE3CC0")]
	private void CCOPNLEBCEN(PPLDEMIMPFF NKLCJOAMGPJ, IPEndPoint JCNAEDIGJJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum PEKNJKOFEDH : byte
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
public enum EOINIKKCDJN : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BBJELDBGBJI
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] CPGFOMPBPEN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int HBMKIDCLMHL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int JAPFMGGLFAF;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MGAOOLJICEA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5EB0", Offset = "0x6FE4CB0", VA = "0x186FE5EB0")]
	public MGAOOLJICEA(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DDMIJPCPJAO : MGAOOLJICEA
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5EB0", Offset = "0x6FE4CB0", VA = "0x186FE5EB0")]
	public DDMIJPCPJAO(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum JOIFBKHCEAB
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
public interface BAKCHAPIEOB
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHBOFMFMECI(JOIFBKHCEAB NPFMNOCCCFP, string DOABHODDFNN, params object[] AOGFOJGFMAN);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class GKGOBFCAIGD
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static BAKCHAPIEOB GBLEBDIIFIA;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object DJFLKJBFKMA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8530", Offset = "0x6FE7330", VA = "0x186FE8530")]
	private static void GMOONCKLLHL(JOIFBKHCEAB CBLFJPNFEMF, string DOABHODDFNN, params object[] AOGFOJGFMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE84D0", Offset = "0x6FE72D0", VA = "0x186FE84D0")]
	internal static void CBAEHDPHIKK(string DOABHODDFNN, params object[] AOGFOJGFMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8760", Offset = "0x6FE7560", VA = "0x186FE8760")]
	internal static void JJEFOBNFCHK(string DOABHODDFNN, params object[] AOGFOJGFMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8470", Offset = "0x6FE7270", VA = "0x186FE8470")]
	internal static void AHJMBEPGDLC(string DOABHODDFNN, params object[] AOGFOJGFMAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum MLAMFPBFJHM
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LHODEHBLEPK : EEKDFBBOCIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private BBBPAMGEEOG FABBIOEOELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly PNOJAHGJGMP GOAGAAMFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly ADCBFDIAFCA BPHJABGDALI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB7D0", Offset = "0x6FEA5D0", VA = "0x186FEB7D0")]
	internal LHODEHBLEPK(PNOJAHGJGMP HBNPNMJNNHB, ADCBFDIAFCA OHHADODJICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB760", Offset = "0x6FEA560", VA = "0x186FEB760")]
	internal void IKCKEPCLOOB(BBBPAMGEEOG HMMDBBEAMNI, int LNLOMOBIJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB6E0", Offset = "0x6FEA4E0", VA = "0x186FEB6E0")]
	internal void IEPKPLIIBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB6B0", Offset = "0x6FEA4B0", VA = "0x186FEB6B0")]
	public void EAHALGEJGKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class ADCBFDIAFCA
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum MCPLCELBBJO
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
	public ADCBFDIAFCA MKDDBDEOMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public MCPLCELBBJO KDNIOMEAELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public OADDMODKIPC DEGEKDFOJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint GKALOKJLMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object BAMDAIDGFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int BOJKCJICNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError JFHCABOAJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NMBHELEPEEI HHCAPFIDGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NNMEILAJGIC CGMLHKIFPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public PEKNJKOFEDH BLOMMGEHKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte IEEHACFMPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly LHODEHBLEPK BIBAEOKIFOA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3400", Offset = "0x6FE2200", VA = "0x186FE3400")]
	public ADCBFDIAFCA(PNOJAHGJGMP HBNPNMJNNHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PNOJAHGJGMP : IEnumerable<OADDMODKIPC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class JOPKLNBENNP : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB070", Offset = "0x6FE9E70", VA = "0x186FEB070", Slot = "4")]
		public bool Equals(IPEndPoint AJEEBBBAOKG, IPEndPoint GJPKMHAOJHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6B42670", Offset = "0x6B41470", VA = "0x186B42670", Slot = "5")]
		public int GetHashCode(IPEndPoint GLEBGNJJOHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JOPKLNBENNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct GCJOAKLBLAI : IEnumerator<OADDMODKIPC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly OADDMODKIPC APLFKJGBOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private OADDMODKIPC JMDNJBCODDN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public OADDMODKIPC CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xDB93E0", Offset = "0xDB81E0", VA = "0x180DB93E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xDB93E0", Offset = "0xDB81E0", VA = "0x180DB93E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1A5EA00", Offset = "0x1A5D800", VA = "0x181A5EA00")]
		public GCJOAKLBLAI(OADDMODKIPC PJEGPPLKFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8050", Offset = "0x6FE6E50", VA = "0x186FE8050", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FE80A0", Offset = "0x6FE6EA0", VA = "0x186FE80A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread ODJAFMOFNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool KPJCNAMILLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool DBHLLMEIPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private GFHOMLIIOML GGEHBFJLFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent JBPNMLKAFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<ADCBFDIAFCA> BNJFDENKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<ADCBFDIAFCA> AMABDJNENMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private ADCBFDIAFCA COLGAMMMDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly GAKBGANBAEP PNLLDCLIHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CALEELALMFA LLEKFODGOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly BFCHOOBHGBF JFGDOOPGBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly ECHALNJOCID KKMGAFBCABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, OADDMODKIPC> PBGAGFEHJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, NNMEILAJGIC> AMMDJEBIGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, LANAOBJHGNA> LKAIOECKDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim CJKMHCMIBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private OADDMODKIPC MHFKJJHEFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int AHEIBGHGAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<OADDMODKIPC> LCKMEBNIBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private OADDMODKIPC[] DDENPEEEMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly AGFBEGEHJJM CKEMILHBJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int MJLMHKAFLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> LCLCLDFJEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte GJLNJKPALGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object KLLEDHMFNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool BPAFFKLEDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool BAFANFIAJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CPPLJDMHFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int BBOEKMCGJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int IACGMKFPOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int PIDLBBNDBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool MFOOIAOPIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool OJECPKNADKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int EFHHEMPDDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int KNIIHKDMBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int KGJFIGCLIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool DINDPMJANLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool NFDAJBPDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool LNBOGODHHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool CAKGBCKPGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int NJCIPOIJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int JIAJHHPNCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool AMBFDOBLDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly OBHDMCAMGOA ALKLAFKLMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool GBHHPODGNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly ANCHPGJNEDC HKJGCEHFLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool OMOLKKLCHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public MLAMFPBFJHM DOIEJNGJFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int DLJMIKFNCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool HJFJOKMAPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool KDBIFHDNFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool PACEAPNDCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool AOFNHFNPKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private BBBPAMGEEOG IDNJGBDMION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int JNKEHBAGOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object OGKMFOKKNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private BBBPAMGEEOG PABOBLHJIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int JGNPNCHEIGH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int PAALDHCICED = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int LFDLINCKCHG = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private JDFLNHICKHN EJKCMFFJIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private JDFLNHICKHN FGGNIDOPFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread ICJEKHCPFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread PCOHLHIBHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint KOGLMOEOGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint KHMBPCNJDBE;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] IHHBELLNDNO;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] AENPNNPJPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<MPOLMDDNEEP, IPEndPoint> KMMEDHNMEHE;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress LPGOOOIDCKG;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool LMFANHLKNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int HKJIKDANENG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MAJDLHIOFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xACBB50", Offset = "0xACA950", VA = "0x180ACBB50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAC9970", Offset = "0xAC8770", VA = "0x180AC9970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AMPOEBLOCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x15C3260", Offset = "0x15C2060", VA = "0x1815C3260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1EAF7D0", Offset = "0x1EAE5D0", VA = "0x181EAF7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte MLBEPGFINJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xF871F0", Offset = "0xF85FF0", VA = "0x180F871F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JHMIIFEIIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9BD0", Offset = "0x6FF89D0", VA = "0x186FF9BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short HJCDLOJEEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5260", Offset = "0x6FF4060", VA = "0x186FF5260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OADDMODKIPC.CGALJMLLLHG IDOCBPHOFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5660", Offset = "0x6FF4460", VA = "0x186FF5660")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9AD0", Offset = "0x6FF88D0", VA = "0x186FF9AD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA4F0", Offset = "0x6FF92F0", VA = "0x186FFA4F0")]
	public void NNKEHPFOAMF(IPEndPoint IOAJJGFAGCE, byte[] MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAA60", Offset = "0x6FF9860", VA = "0x186FFAA60")]
	public void OMOEKIMAGGA(IPEndPoint IOAJJGFAGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6FFABB0", Offset = "0x6FF99B0", VA = "0x186FFABB0")]
	private bool PNHEPMBFFGA(IPEndPoint IOAJJGFAGCE, [Out] OADDMODKIPC MKLMGGKDBLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6F70", Offset = "0x6FF5D70", VA = "0x186FF6F70")]
	private void HEOIBLCGCDB(OADDMODKIPC MKLMGGKDBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5600", Offset = "0x6FF4400", VA = "0x186FF5600")]
	private void DCLFDGBJEKK(OADDMODKIPC MKLMGGKDBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4F90", Offset = "0x6FF3D90", VA = "0x186FF4F90")]
	private void CCKAAFEBFNF(OADDMODKIPC MKLMGGKDBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAE30", Offset = "0x6FF9C30", VA = "0x186FFAE30")]
	public PNOJAHGJGMP(GAKBGANBAEP FACIPJMCLNC, [Optional] AGFBEGEHJJM PHJAAPDFFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9B80", Offset = "0x6FF8980", VA = "0x186FF9B80")]
	internal void KNIPFFOFBMK(OADDMODKIPC NCMIFACNBAF, int GKCADDHHKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6380", Offset = "0x6FF5180", VA = "0x186FF6380")]
	internal void FAJOLJHMFGB(OADDMODKIPC NCMIFACNBAF, object BLHCIGPBGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5710", Offset = "0x6FF4510", VA = "0x186FF5710")]
	internal void DEDGDBANNEO(OADDMODKIPC MKLMGGKDBLL, NMBHELEPEEI KLOPBEMIGAO, SocketError LJDNFDNLGID, BBBPAMGEEOG FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6FF65C0", Offset = "0x6FF53C0", VA = "0x186FF65C0")]
	private void GHDKLONCBJB(OADDMODKIPC MKLMGGKDBLL, NMBHELEPEEI KLOPBEMIGAO, SocketError LJDNFDNLGID, bool PGBCKJJIOAA, byte[] FFEMKICJPKP, int GNMMLFONKNO, int ALFGNAHPKIG, BBBPAMGEEOG FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7430", Offset = "0x6FF6230", VA = "0x186FF7430")]
	private void HMJCKCACJLA(ADCBFDIAFCA.MCPLCELBBJO AAFMBEEMJAC, [Optional] OADDMODKIPC MKLMGGKDBLL, [Optional] IPEndPoint HGHNKNJEODJ, SocketError DMDAMPNBMKA = SocketError.Success, int GKCADDHHKDP = 0, NMBHELEPEEI NJGNEAFGKEI = NMBHELEPEEI.ConnectionFailed, [Optional] NNMEILAJGIC IHDLDAGOOGG, PEKNJKOFEDH KAKOKCBEDPO = PEKNJKOFEDH.Unreliable, byte GPBBAJELILC = 0, [Optional] BBBPAMGEEOG JEDKFHGHOCL, [Optional] object BLHCIGPBGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4580", Offset = "0x6FF3380", VA = "0x186FF4580")]
	private void CBIIGOGJLDG(ADCBFDIAFCA OHHADODJICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6FF34A0", Offset = "0x6FF22A0", VA = "0x186FF34A0")]
	internal void AMCDBCDHBCO(ADCBFDIAFCA OHHADODJICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA710", Offset = "0x6FF9510", VA = "0x186FFA710")]
	private void OIKPFDLHFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7990", Offset = "0x6FF6790", VA = "0x186FF7990")]
	private void IGGHCIGNJIK(int IPJOCDEIKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9D70", Offset = "0x6FF8B70", VA = "0x186FF9D70")]
	internal OADDMODKIPC MPDDEJPBLAC(NNMEILAJGIC OHDJLNAKLPC, byte[] PDHDMGNIPBE, int GNMMLFONKNO, int NPCJGIOCILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6300", Offset = "0x6FF5100", VA = "0x186FF6300")]
	private int EOHBIHMIMOM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7CB0", Offset = "0x6FF6AB0", VA = "0x186FF7CB0")]
	private void JBPNJLBKLCN(IPEndPoint HGHNKNJEODJ, OADDMODKIPC BJLDKECGCGD, KAGODBOBBID IMDLBNNHCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8160", Offset = "0x6FF6F60", VA = "0x186FF8160")]
	private void JOLDMEAHBCG(BBBPAMGEEOG HMMDBBEAMNI, IPEndPoint HGHNKNJEODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5320", Offset = "0x6FF4120", VA = "0x186FF5320")]
	internal void CMNBPDMNFPE(BBBPAMGEEOG HMMDBBEAMNI, PEKNJKOFEDH KAHHHPDDBEL, byte GPBBAJELILC, int LNLOMOBIJDI, OADDMODKIPC NCMIFACNBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4570", Offset = "0x6FF3370", VA = "0x186FF4570")]
	public bool CBHIJBFDGNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3D00", Offset = "0x6FF2B00", VA = "0x186FF3D00")]
	public bool CBHIJBFDGNG(IPAddress HLMLHJCHCCG, IPAddress LFMAEMAGIMJ, int MEEODCLEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6FF44F0", Offset = "0x6FF32F0", VA = "0x186FF44F0")]
	public bool CBHIJBFDGNG(int MEEODCLEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3B50", Offset = "0x6FF2950", VA = "0x186FF3B50")]
	public void BMOGOCJKMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3A70", Offset = "0x6FF2870", VA = "0x186FF3A70")]
	public OADDMODKIPC APEMMFGODAP(string EIANDFAKKKJ, int MEEODCLEJBF, string MAKJJJECHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6FF35B0", Offset = "0x6FF23B0", VA = "0x186FF35B0")]
	public OADDMODKIPC APEMMFGODAP(string EIANDFAKKKJ, int MEEODCLEJBF, EJPLMILLDOF NHGLLABMMAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3690", Offset = "0x6FF2490", VA = "0x186FF3690")]
	public OADDMODKIPC APEMMFGODAP(IPEndPoint GDCDKMJLKDH, EJPLMILLDOF NHGLLABMMAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6F60", Offset = "0x6FF5D60", VA = "0x186FF6F60")]
	public void GNIOHOLOONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6C00", Offset = "0x6FF5A00", VA = "0x186FF6C00")]
	public void GNIOHOLOONN(bool HKNAHJAFOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9CC0", Offset = "0x6FF8AC0", VA = "0x186FF9CC0")]
	public void LKKONKFPPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9BF0", Offset = "0x6FF89F0", VA = "0x186FF9BF0")]
	public void LKKONKFPPCH(byte[] FFEMKICJPKP, int GNMMLFONKNO, int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6A10", Offset = "0x6FF5810", VA = "0x186FF6A10")]
	public void GHDKLONCBJB(OADDMODKIPC MKLMGGKDBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF69D0", Offset = "0x6FF57D0", VA = "0x186FF69D0")]
	public void GHDKLONCBJB(OADDMODKIPC MKLMGGKDBLL, byte[] FFEMKICJPKP, int GNMMLFONKNO, int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAC50", Offset = "0x6FF9A50", VA = "0x186FFAC50", Slot = "4")]
	private IEnumerator<OADDMODKIPC> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6FFACE0", Offset = "0x6FF9AE0", VA = "0x186FFACE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6FF64B0", Offset = "0x6FF52B0", VA = "0x186FF64B0")]
	private BBBPAMGEEOG FKMGHEMFPJO(CMMHJGGHCJE FEMKAJANBPA, int ACINDEOBNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6FF63D0", Offset = "0x6FF51D0", VA = "0x186FF63D0")]
	private BBBPAMGEEOG FKMGHEMFPJO(CMMHJGGHCJE FEMKAJANBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4D40", Offset = "0x6FF3B40", VA = "0x186FF4D40")]
	internal BBBPAMGEEOG CCHMAEMEEBB(int ACINDEOBNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9590", Offset = "0x6FF8390", VA = "0x186FF9590")]
	internal void KBBJFNALGLN(BBBPAMGEEOG HMMDBBEAMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAD70", Offset = "0x6FF9B70", VA = "0x186FFAD70")]
	static PNOJAHGJGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xACBB50", Offset = "0xACA950", VA = "0x180ACBB50")]
	private bool JOMBMMHEOJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7810", Offset = "0x6FF6610", VA = "0x186FF7810")]
	private void HNFLACKAGLJ(IPEndPoint IMAADAJJGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA390", Offset = "0x6FF9190", VA = "0x186FFA390")]
	private void NCIPHJMGBEO(IPEndPoint IMAADAJJGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6A50", Offset = "0x6FF5850", VA = "0x186FF6A50")]
	private bool GIILIDDIKKA(SocketException HELNJIPKBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF65A0", Offset = "0x6FF53A0", VA = "0x186FF65A0")]
	private void GGFALFCKACA(GFHOMLIIOML POHDKHBEDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9800", Offset = "0x6FF8600", VA = "0x186FF9800")]
	private void KFPCKJBIMBF(JDFLNHICKHN POHDKHBEDBF, EndPoint FJLKAKLOHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5750", Offset = "0x6FF4550", VA = "0x186FF5750")]
	private void DNNIJLFPNJK(object JNOIIIFBOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3D20", Offset = "0x6FF2B20", VA = "0x186FF3D20")]
	public bool CBHIJBFDGNG(IPAddress HLMLHJCHCCG, IPAddress LFMAEMAGIMJ, int MEEODCLEJBF, bool GAKHHOFJPJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9530", Offset = "0x6FF8330", VA = "0x186FF9530")]
	internal int JPEKMOLFAAN(BBBPAMGEEOG HMMDBBEAMNI, IPEndPoint HGHNKNJEODJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5AE0", Offset = "0x6FF48E0", VA = "0x186FF5AE0")]
	internal int ECKBIOFODJC(BBBPAMGEEOG HMMDBBEAMNI, IPEndPoint HGHNKNJEODJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5B20", Offset = "0x6FF4920", VA = "0x186FF5B20")]
	internal int ECKBIOFODJC(byte[] NJJDPBHNDPA, int GNMMLFONKNO, int NPCJGIOCILE, IPEndPoint HGHNKNJEODJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF72B0", Offset = "0x6FF60B0", VA = "0x186FF72B0")]
	internal void HLDCFMBBGOB(bool JHNJEMPBBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum CMMHJGGHCJE : byte
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
internal sealed class BBBPAMGEEOG
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int BGEMDPLIDHJ;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] GPNCPLLDDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] HACIHGIOEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int KBBILNDKGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object BAMDAIDGFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public BBBPAMGEEOG MKDDBDEOMNP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public CMMHJGGHCJE KPNBGJGPCHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4AD0", Offset = "0x6FE38D0", VA = "0x186FE4AD0")]
		get
		{
			return default(CMMHJGGHCJE);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4990", Offset = "0x6FE3790", VA = "0x186FE4990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte NBDNMKHFECF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4C30", Offset = "0x6FE3A30", VA = "0x186FE4C30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4D00", Offset = "0x6FE3B00", VA = "0x186FE4D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort AGKDCDKFGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4CA0", Offset = "0x6FE3AA0", VA = "0x186FE4CA0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4B00", Offset = "0x6FE3900", VA = "0x186FE4B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OIELAEAKFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4920", Offset = "0x6FE3720", VA = "0x186FE4920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte KBINPEOPDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4C00", Offset = "0x6FE3A00", VA = "0x186FE4C00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FE48F0", Offset = "0x6FE36F0", VA = "0x186FE48F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort BGILEJLFOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4BA0", Offset = "0x6FE39A0", VA = "0x186FE4BA0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4780", Offset = "0x6FE3580", VA = "0x186FE4780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort AEKDIHDLILE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4B40", Offset = "0x6FE3940", VA = "0x186FE4B40")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4C60", Offset = "0x6FE3A60", VA = "0x186FE4C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort APEMCCBLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4720", Offset = "0x6FE3520", VA = "0x186FE4720")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4950", Offset = "0x6FE3750", VA = "0x186FE4950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FE4D40", Offset = "0x6FE3B40", VA = "0x186FE4D40")]
	static BBBPAMGEEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FE47C0", Offset = "0x6FE35C0", VA = "0x186FE47C0")]
	public void EAINLOJOMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5130", Offset = "0x6FE3F30", VA = "0x186FE5130")]
	public BBBPAMGEEOG(int ACINDEOBNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5020", Offset = "0x6FE3E20", VA = "0x186FE5020")]
	public BBBPAMGEEOG(CMMHJGGHCJE FEMKAJANBPA, int ACINDEOBNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FE47F0", Offset = "0x6FE35F0", VA = "0x186FE47F0")]
	public static int ELJCMGNGDOI(CMMHJGGHCJE FEMKAJANBPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FE4860", Offset = "0x6FE3660", VA = "0x186FE4860")]
	public int ELJCMGNGDOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FE49D0", Offset = "0x6FE37D0", VA = "0x186FE49D0")]
	public bool IJIPFNIKMEA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum DKPNCIMAKLH : byte
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
internal enum MKKPOKPHDIB
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
internal enum NFGKNGODNJH
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum PLPLEDMFMLG
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OADDMODKIPC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class KIEMEJJNMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public BBBPAMGEEOG[] EIOAEDIIILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int HBDILGCJKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int BFACJNJKNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte KBINPEOPDKH;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KIEMEJJNMBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void CGALJMLLLHG(ulong LGFEHDJJBFO, int MOOEJAHELMP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int KDHLAGJEBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int FGKKNNMCMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int DGIGMCAHKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double AFPGJJPHAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int BKGGPKKGFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int LMKMGCAHIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int FCLCCCJDMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch ILLEIMLFBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int BCNMOFBGEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long HHJPGDKPAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object JCIMHKCOALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal OADDMODKIPC GFEOOCNMION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal OADDMODKIPC KDAEIMPAPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<BBBPAMGEEOG> MBGLLIHOLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<CNKEDIGAPKB> NLMACGLDDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly CNKEDIGAPKB[] GFMKILKJJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int FLPGECJMGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int KACJFHMKKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool GDGAMEGBOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int IFPEIPPNHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int FOFGINAEEEM;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int HLFHIIBODPG = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int OPGCJKAHFBE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object FLBGMMJFNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int PHIHIPKCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, KIEMEJJNMBA> FCHHGFKANNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> JBLNJLKMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly BBBPAMGEEOG CFOFMIKOJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int BAHKPBFLPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int MOBPAEPLBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint LBIKDIJBMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int ALACDLHOADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int IHBINJBKGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long KIPNPFOCIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte OGLFDKDAHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private DKPNCIMAKLH DCCLOOKPPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private BBBPAMGEEOG JKNBCFCNGCD;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int NNDHAAKJDKP = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int HHMIMMNGHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly BBBPAMGEEOG IEADIDHLNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly BBBPAMGEEOG LDANAADKJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly BBBPAMGEEOG PCLKBDNKMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly BBBPAMGEEOG FGGNMOHFGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private EOINIKKCDJN GJCNEMIPLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly PNOJAHGJGMP PFGFAFGFBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int OCNPBLDHFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object IFIMJEFENMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly OBHDMCAMGOA ALKLAFKLMAN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte OGEBOABEFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xADD9D0", Offset = "0xADC7D0", VA = "0x180ADD9D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FED5C0", Offset = "0x6FEC3C0", VA = "0x186FED5C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint LCEHAEJPHHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xCE6EA0", Offset = "0xCE5CA0", VA = "0x180CE6EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public DKPNCIMAKLH IMHHODMNCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xBB27A0", Offset = "0xBB15A0", VA = "0x180BB27A0")]
		get
		{
			return default(DKPNCIMAKLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long HMNHJLIMBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0BBF0", Offset = "0xA0A9F0", VA = "0x180A0BBF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KKCAJIDOHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x15C3260", Offset = "0x15C2060", VA = "0x1815C3260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1EAF7D0", Offset = "0x1EAE5D0", VA = "0x181EAF7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int EPEIAODGODO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDB70", Offset = "0x6FEC970", VA = "0x186FEDB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int EBPIALCFIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xC15DC0", Offset = "0xC14BC0", VA = "0x180C15DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double HNGHCBILKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x54B0300", Offset = "0x54AF100", VA = "0x1854B0300")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CGALJMLLLHG IDOCBPHOFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FED8E0", Offset = "0x6FEC6E0", VA = "0x186FED8E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF720", Offset = "0x6FEE520", VA = "0x186FEF720")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1180", Offset = "0x6FEFF80", VA = "0x186FF1180")]
	internal OADDMODKIPC(PNOJAHGJGMP COKCKIEBHCL, IPEndPoint HGHNKNJEODJ, int FONJFDCCINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6FEFD30", Offset = "0x6FEEB30", VA = "0x186FEFD30")]
	internal void LJIOCAGPCGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6FEED50", Offset = "0x6FEDB50", VA = "0x186FEED50")]
	internal void HOLBNJNCCNC(IPEndPoint NGPHNBJANDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDAE0", Offset = "0x6FEC8E0", VA = "0x186FEDAE0")]
	internal void DMLJHDKAKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEF40", Offset = "0x6FEDD40", VA = "0x186FEEF40")]
	private void JIBKBHOFHHD(int ACGAFLHKFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEC30", Offset = "0x6FEDA30", VA = "0x186FEEC30")]
	private void GOLMIEAOLAO(int NJLPEAKLDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FED7D0", Offset = "0x6FEC5D0", VA = "0x186FED7D0")]
	public int BOLGBABAPGJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FED6B0", Offset = "0x6FEC4B0", VA = "0x186FED6B0")]
	public int BOLGBABAPGJ(byte GPBBAJELILC, bool FAMBLPDPINF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0C10", Offset = "0x6FEFA10", VA = "0x186FF0C10")]
	private CNKEDIGAPKB OCKJDOPLKOB(byte KILCKNBNPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF17C0", Offset = "0x6FF05C0", VA = "0x186FF17C0")]
	internal OADDMODKIPC(PNOJAHGJGMP COKCKIEBHCL, IPEndPoint HGHNKNJEODJ, int FONJFDCCINO, byte OJIPKOKNCPH, EJPLMILLDOF HENHIEINLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF15E0", Offset = "0x6FF03E0", VA = "0x186FF15E0")]
	internal OADDMODKIPC(PNOJAHGJGMP COKCKIEBHCL, NNMEILAJGIC OHDJLNAKLPC, int FONJFDCCINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE2C0", Offset = "0x6FED0C0", VA = "0x186FEE2C0")]
	internal void FNAFKNIEKCD(KAGODBOBBID GHJKMGFLLDA, byte[] FFEMKICJPKP, int GNMMLFONKNO, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE240", Offset = "0x6FED040", VA = "0x186FEE240")]
	internal bool EJHJEOOLLEE(HAFDMHLAJNO HMMDBBEAMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0DC0", Offset = "0x6FEFBC0", VA = "0x186FF0DC0")]
	public void ODFOIKANOLH(byte[] FFEMKICJPKP, int GNMMLFONKNO, int NPCJGIOCILE, PEKNJKOFEDH FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE620", Offset = "0x6FED420", VA = "0x186FEE620")]
	private void GCIEGDEOKPE(byte[] FFEMKICJPKP, int GNMMLFONKNO, int NPCJGIOCILE, byte GPBBAJELILC, PEKNJKOFEDH KAKOKCBEDPO, object BLHCIGPBGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF6D0", Offset = "0x6FEE4D0", VA = "0x186FEF6D0")]
	public void KAIHEAGEBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEC70", Offset = "0x6FEDA70", VA = "0x186FEEC70")]
	internal NFGKNGODNJH HMHAMFODOHA(BBBPAMGEEOG HMMDBBEAMNI)
	{
		return default(NFGKNGODNJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FF06E0", Offset = "0x6FEF4E0", VA = "0x186FF06E0")]
	internal void MDPAOCEFHDH(CNKEDIGAPKB ONKHCNLCBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE310", Offset = "0x6FED110", VA = "0x186FEE310")]
	internal PLPLEDMFMLG GAEEBAFDLKE(byte[] FFEMKICJPKP, int GNMMLFONKNO, int NPCJGIOCILE, bool PGBCKJJIOAA)
	{
		return default(PLPLEDMFMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FED670", Offset = "0x6FEC470", VA = "0x186FED670")]
	private void BNKPIPIIMBC(int NANPCNENDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FEFD50", Offset = "0x6FEEB50", VA = "0x186FEFD50")]
	internal void MAGLEIELJKN(PEKNJKOFEDH KAHHHPDDBEL, BBBPAMGEEOG PJEGPPLKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF7D0", Offset = "0x6FEE5D0", VA = "0x186FEF7D0")]
	private void KMLGIIGLCOC(BBBPAMGEEOG HMMDBBEAMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0DF0", Offset = "0x6FEFBF0", VA = "0x186FF0DF0")]
	private void PMGNBMDKJHD(int GNNOPFAGLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FEED80", Offset = "0x6FEDB80", VA = "0x186FEED80")]
	internal MKKPOKPHDIB JBPNJLBKLCN(KAGODBOBBID IMDLBNNHCOP)
	{
		return default(MKKPOKPHDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDB80", Offset = "0x6FEC980", VA = "0x186FEDB80")]
	internal void EDGBBKACLJM(BBBPAMGEEOG HMMDBBEAMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FED990", Offset = "0x6FEC790", VA = "0x186FED990")]
	private void DDLNDLEFOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0740", Offset = "0x6FEF540", VA = "0x186FF0740")]
	internal void MFOFIDPDHEE(BBBPAMGEEOG HMMDBBEAMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF010", Offset = "0x6FEDE10", VA = "0x186FEF010")]
	internal void JPEBABACHJL(int GNNOPFAGLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0950", Offset = "0x6FEF750", VA = "0x186FF0950")]
	internal void NEHKIHOLNLG(BBBPAMGEEOG HMMDBBEAMNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class OBHDMCAMGOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long AGOIJJDGEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long APKGEIJABKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long ILOEFLIHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long EEGDNKADOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long MDBFPEDGBMF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long HLNDDCKANBC;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long KNDAKAIFJJB;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long HFOCGHNJFGE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long IKDOFLPEKAO;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long FDELHKPKGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long NDALKAMKLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long LBMKLMHBGOJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long EEEDJAEKEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AF0", Offset = "0x6FF08F0", VA = "0x186FF1AF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long AMODIMKJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AE0", Offset = "0x6FF08E0", VA = "0x186FF1AE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long DCJAPCLLNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1C70", Offset = "0x6FF0A70", VA = "0x186FF1C70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long LHFAOEIJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1C80", Offset = "0x6FF0A80", VA = "0x186FF1C80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long PNFLBDLCCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1B00", Offset = "0x6FF0900", VA = "0x186FF1B00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long IACECKCMPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1BE0", Offset = "0x6FF09E0", VA = "0x186FF1BE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long DNNAFEHLANF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1D00", Offset = "0x6FF0B00", VA = "0x186FF1D00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long NNFBLPEADDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1950", Offset = "0x6FF0750", VA = "0x186FF1950")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private EOINIKKCDJN FPFBLOIIIBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AD0", Offset = "0x6FF08D0", VA = "0x186FF1AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double KIKABHLMMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1D40", Offset = "0x6FF0B40", VA = "0x186FF1D40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1990", Offset = "0x6FF0790", VA = "0x186FF1990")]
	public void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1A70", Offset = "0x6FF0870", VA = "0x186FF1A70")]
	public void AOJJKOAKEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1DA0", Offset = "0x6FF0BA0", VA = "0x186FF1DA0")]
	public void ONEHDGEMNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1C90", Offset = "0x6FF0A90", VA = "0x186FF1C90")]
	public void NCANHALKDIP(long MOPGPCKEEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1B70", Offset = "0x6FF0970", VA = "0x186FF1B70")]
	public void ILGDMIFHHLH(long OGELJLOHNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1B10", Offset = "0x6FF0910", VA = "0x186FF1B10")]
	public void HALGLJNHGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1BF0", Offset = "0x6FF09F0", VA = "0x186FF1BF0")]
	public void KMKBPHPFGDE(long PDHGIFPMMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1DF0", Offset = "0x6FF0BF0", VA = "0x186FF1DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FF19D0", Offset = "0x6FF07D0", VA = "0x186FF19D0")]
	public void AOABBLCLDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OBHDMCAMGOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class EHGECJJAMOE
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> IFOFFGPGCEC;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6B30", Offset = "0x6FE5930", VA = "0x186FE6B30")]
	public static IPEndPoint ABMHIJOPGBJ(string DOKAOMCFGLG, int MEEODCLEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6D80", Offset = "0x6FE5B80", VA = "0x186FE6D80")]
	public static IPAddress LJONKABHDHL(string DOKAOMCFGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6F50", Offset = "0x6FE5D50", VA = "0x186FE6F50")]
	public static IPAddress LJONKABHDHL(string DOKAOMCFGLG, AddressFamily EFBADNBKHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6FE0", Offset = "0x6FE5DE0", VA = "0x186FE6FE0")]
	internal static int MJIIHEOEEJN(int FCFNDAEALCP, int POFCEEFGJMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x37774E0", Offset = "0x37762E0", VA = "0x1837774E0")]
	internal static T[] GJCACFBGCCL<T>(int ALFGNAHPKIG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class GLANGGLDFJD : CNKEDIGAPKB
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct BJNCEABHMLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private BBBPAMGEEOG FABBIOEOELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long IJIMMNIACJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool KECBLPFCGHN;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5360", Offset = "0x6FE4160", VA = "0x186FE5360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE52D0", Offset = "0x6FE40D0", VA = "0x186FE52D0")]
		public void HLJFBNEKAGO(BBBPAMGEEOG HMMDBBEAMNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE52F0", Offset = "0x6FE40F0", VA = "0x186FE52F0")]
		public bool LHBHIKPELKI(long KODMODKKFAD, OADDMODKIPC MKLMGGKDBLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5280", Offset = "0x6FE4080", VA = "0x186FE5280")]
		public bool CCLJDABAPHP(OADDMODKIPC MKLMGGKDBLL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly BBBPAMGEEOG JEIIGGKJBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly BJNCEABHMLD[] MGFCPIJDOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly BBBPAMGEEOG[] LHDIDINDAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] DFFMKDMOMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int DIGJNOLNAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int KPCGDOJENFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int GGMDGBBEJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int PLGMKLCALPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool OACHKDPHKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly PEKNJKOFEDH LJOFJHMDNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool CPNHJDMEPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int GPHFFHGAOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte AFOJKCHNHMJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EBGGLDPPBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9760", Offset = "0x6FE8560", VA = "0x186FE9760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9770", Offset = "0x6FE8570", VA = "0x186FE9770")]
	public GLANGGLDFJD(OADDMODKIPC MKLMGGKDBLL, bool FAMBLPDPINF, byte FONJFDCCINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8ED0", Offset = "0x6FE7CD0", VA = "0x186FE8ED0")]
	private void FDDILPCOOEK(BBBPAMGEEOG HMMDBBEAMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9290", Offset = "0x6FE8090", VA = "0x186FE9290", Slot = "4")]
	protected override bool FPIIGKAKDJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8870", Offset = "0x6FE7670", VA = "0x186FE8870", Slot = "5")]
	public override bool EDGBBKACLJM(BBBPAMGEEOG HMMDBBEAMNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class PNGCBHDAGHI : CNKEDIGAPKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int OJFAOIMGECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort KPCGDOJENFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool HLOIOODDGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private BBBPAMGEEOG BILDKAKNFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly BBBPAMGEEOG HEHFJDLDICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool LNAAAANFGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte AFOJKCHNHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long LEOECIIDMBB;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6FF33E0", Offset = "0x6FF21E0", VA = "0x186FF33E0")]
	public PNGCBHDAGHI(OADDMODKIPC MKLMGGKDBLL, bool MKDDHLMBJAL, byte FONJFDCCINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2F20", Offset = "0x6FF1D20", VA = "0x186FF2F20", Slot = "4")]
	protected override bool FPIIGKAKDJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2C40", Offset = "0x6FF1A40", VA = "0x186FF2C40", Slot = "5")]
	public override bool EDGBBKACLJM(BBBPAMGEEOG HMMDBBEAMNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class GACDCAPNACE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct HGPHGNPNJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong JPKMABAIANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double JEJLMDPIOAI;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct PJCGNGCDLAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int OGKGCALFNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float BNKKCEOFBKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3310", Offset = "0x6FE2110", VA = "0x186FE3310")]
	private static void DEDNNNGFGGC(byte[] GLBDCBGACGO, int PPPFIBNDOMK, ulong FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7EF0", Offset = "0x6FE6CF0", VA = "0x186FE7EF0")]
	private static void DEDNNNGFGGC(byte[] GLBDCBGACGO, int PPPFIBNDOMK, int FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7F80", Offset = "0x6FE6D80", VA = "0x186FE7F80")]
	public static void DEDNNNGFGGC(byte[] GLBDCBGACGO, int PPPFIBNDOMK, short FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7F60", Offset = "0x6FE6D60", VA = "0x186FE7F60")]
	public static void DEADKLEDGOC(byte[] HNAKMABCJKP, int AJOJFAFFHHF, double OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7FC0", Offset = "0x6FE6DC0", VA = "0x186FE7FC0")]
	public static void DEADKLEDGOC(byte[] HNAKMABCJKP, int AJOJFAFFHHF, float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7F80", Offset = "0x6FE6D80", VA = "0x186FE7F80")]
	public static void DEADKLEDGOC(byte[] HNAKMABCJKP, int AJOJFAFFHHF, short OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7F80", Offset = "0x6FE6D80", VA = "0x186FE7F80")]
	public static void DEADKLEDGOC(byte[] HNAKMABCJKP, int AJOJFAFFHHF, ushort OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7EF0", Offset = "0x6FE6CF0", VA = "0x186FE7EF0")]
	public static void DEADKLEDGOC(byte[] HNAKMABCJKP, int AJOJFAFFHHF, int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7EF0", Offset = "0x6FE6CF0", VA = "0x186FE7EF0")]
	public static void DEADKLEDGOC(byte[] HNAKMABCJKP, int AJOJFAFFHHF, uint OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8040", Offset = "0x6FE6E40", VA = "0x186FE8040")]
	public static void DEADKLEDGOC(byte[] HNAKMABCJKP, int AJOJFAFFHHF, long OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8040", Offset = "0x6FE6E40", VA = "0x186FE8040")]
	public static void DEADKLEDGOC(byte[] HNAKMABCJKP, int AJOJFAFFHHF, ulong OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EEKDFBBOCIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] CJNIBAPGIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int KPBMDGMCBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int OOGMEKGNDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int IPNLKMIDGNC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] HACIHGIOEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int AEOFNJHIOBF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int MGFALILKKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6400", Offset = "0x6FE5200", VA = "0x186FE6400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FKEBPLMDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2702210", Offset = "0x2701010", VA = "0x182702210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int KPBLCGHHAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6850", Offset = "0x6FE5650", VA = "0x186FE6850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6FE63C0", Offset = "0x6FE51C0", VA = "0x186FE63C0")]
	public void IKCKEPCLOOB(byte[] EEDJPELJDDE, int PPPFIBNDOMK, int FIIJKNAAOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public EEKDFBBOCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6AD0", Offset = "0x6FE58D0", VA = "0x186FE6AD0")]
	public EEKDFBBOCIK(byte[] EEDJPELJDDE, int PPPFIBNDOMK, int FIIJKNAAOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6FE69C0", Offset = "0x6FE57C0", VA = "0x186FE69C0")]
	public IPEndPoint PMKLOBCOOGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6FE60F0", Offset = "0x6FE4EF0", VA = "0x186FE60F0")]
	public byte JIGOCLDFBHD()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6FE60F0", Offset = "0x6FE4EF0", VA = "0x186FE60F0")]
	public sbyte DMGLMABIEGH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x37761F0", Offset = "0x3774FF0", VA = "0x1837761F0")]
	public T[] NDJLIJMDOAK<T>(ushort ACINDEOBNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6220", Offset = "0x6FE5020", VA = "0x186FE6220")]
	public bool[] FKLAEPNGDIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6380", Offset = "0x6FE5180", VA = "0x186FE6380")]
	public ushort[] HFAFGJOPEMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5F70", Offset = "0x6FE4D70", VA = "0x186FE5F70")]
	public short[] BFLIFCKLLOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE67A0", Offset = "0x6FE55A0", VA = "0x186FE67A0")]
	public int[] MFKNPHEAJDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5EC0", Offset = "0x6FE4CC0", VA = "0x186FE5EC0")]
	public uint[] AHNPEAJAKME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE62D0", Offset = "0x6FE50D0", VA = "0x186FE62D0")]
	public float[] GGIJMOCOGIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6A90", Offset = "0x6FE5890", VA = "0x186FE6A90")]
	public double[] POCIPLEDFPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6940", Offset = "0x6FE5740", VA = "0x186FE6940")]
	public long[] OFBFMPCAPOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6170", Offset = "0x6FE4F70", VA = "0x186FE6170")]
	public ulong[] EONOMJGIFIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6650", Offset = "0x6FE5450", VA = "0x186FE6650")]
	public string[] LOELBKHICKA(int HENCCCKDDJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5FB0", Offset = "0x6FE4DB0", VA = "0x186FE5FB0")]
	public bool BLFAHFGOMEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6080", Offset = "0x6FE4E80", VA = "0x186FE6080")]
	public char MBMJONADCLD()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6080", Offset = "0x6FE4E80", VA = "0x186FE6080")]
	public ushort DBONAHNAPBM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5F00", Offset = "0x6FE4D00", VA = "0x186FE5F00")]
	public short APBGHEOFGPI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6310", Offset = "0x6FE5110", VA = "0x186FE6310")]
	public long GJJHPLCBPII()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6FE61B0", Offset = "0x6FE4FB0", VA = "0x186FE61B0")]
	public ulong FGJFBJCODAO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6860", Offset = "0x6FE5660", VA = "0x186FE6860")]
	public int NOJNFBAMCMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6260", Offset = "0x6FE5060", VA = "0x186FE6260")]
	public uint GAACKHKCJMG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE67E0", Offset = "0x6FE55E0", VA = "0x186FE67E0")]
	public float MJNEICEGALO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6010", Offset = "0x6FE4E10", VA = "0x186FE6010")]
	public double CNHCBNGKNIG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6410", Offset = "0x6FE5210", VA = "0x186FE6410")]
	public string KFPCOCNPCHK(int JLMEKGPDJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE68D0", Offset = "0x6FE56D0", VA = "0x186FE68D0")]
	public ArraySegment<byte> OBLMCELOBNK(int ALFGNAHPKIG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6130", Offset = "0x6FE4F30", VA = "0x186FE6130")]
	public sbyte[] EFNHOOKOBDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6980", Offset = "0x6FE5780", VA = "0x186FE6980")]
	public byte[] OINPIMENACJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5FF0", Offset = "0x6FE4DF0", VA = "0x186FE5FF0")]
	public void CCLJDABAPHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class EJPLMILLDOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] CJNIBAPGIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int KPBMDGMCBBN;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int BMFLMKKGLPP = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool MJDABICIPHF;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding JBBPHLKOLFH;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int MNFNDOMCCNM = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] BEPLPIHBPNH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] NOKLNLDMACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7DD0", Offset = "0x6FE6BD0", VA = "0x186FE7DD0")]
	public EJPLMILLDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7E50", Offset = "0x6FE6C50", VA = "0x186FE7E50")]
	public EJPLMILLDOF(bool KKFDLKABHFE, int LDFKMMNMKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7180", Offset = "0x6FE5F80", VA = "0x186FE7180")]
	public static EJPLMILLDOF BJJEBOHCGPP(string OAIIHELJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6FE71F0", Offset = "0x6FE5FF0", VA = "0x186FE71F0")]
	public void NHCJCCEOIJA(int ENHAFBAANHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x277B620", Offset = "0x277A420", VA = "0x18277B620")]
	public void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE78D0", Offset = "0x6FE66D0", VA = "0x186FE78D0")]
	public void OIPPMONBIDL(float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7CF0", Offset = "0x6FE6AF0", VA = "0x186FE7CF0")]
	public void OIPPMONBIDL(double OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7740", Offset = "0x6FE6540", VA = "0x186FE7740")]
	public void OIPPMONBIDL(long OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7740", Offset = "0x6FE6540", VA = "0x186FE7740")]
	public void OIPPMONBIDL(ulong OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7B80", Offset = "0x6FE6980", VA = "0x186FE7B80")]
	public void OIPPMONBIDL(int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7B80", Offset = "0x6FE6980", VA = "0x186FE7B80")]
	public void OIPPMONBIDL(uint OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7C70", Offset = "0x6FE6A70", VA = "0x186FE7C70")]
	public void OIPPMONBIDL(char OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7C70", Offset = "0x6FE6A70", VA = "0x186FE7C70")]
	public void OIPPMONBIDL(ushort OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7C70", Offset = "0x6FE6A70", VA = "0x186FE7C70")]
	public void OIPPMONBIDL(short OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6FE76E0", Offset = "0x6FE64E0", VA = "0x186FE76E0")]
	public void OIPPMONBIDL(sbyte OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6FE76E0", Offset = "0x6FE64E0", VA = "0x186FE76E0")]
	public void OIPPMONBIDL(byte OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7860", Offset = "0x6FE6660", VA = "0x186FE7860")]
	public void OIPPMONBIDL(byte[] FFEMKICJPKP, int PPPFIBNDOMK, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6FE70A0", Offset = "0x6FE5EA0", VA = "0x186FE70A0")]
	public void AKNHMFHJJFE(sbyte[] FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6FE70A0", Offset = "0x6FE5EA0", VA = "0x186FE70A0")]
	public void MBHOBNEOAFK(byte[] FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7C10", Offset = "0x6FE6A10", VA = "0x186FE7C10")]
	public void OIPPMONBIDL(bool OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7600", Offset = "0x6FE6400", VA = "0x186FE7600")]
	public void OAEEPDMCEKE(Array OJFFBOCDIFN, int PCAODIAAGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7520", Offset = "0x6FE6320", VA = "0x186FE7520")]
	public void OAEEPDMCEKE(float[] OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7370", Offset = "0x6FE6170", VA = "0x186FE7370")]
	public void OAEEPDMCEKE(double[] OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7370", Offset = "0x6FE6170", VA = "0x186FE7370")]
	public void OAEEPDMCEKE(long[] OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7370", Offset = "0x6FE6170", VA = "0x186FE7370")]
	public void OAEEPDMCEKE(ulong[] OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7520", Offset = "0x6FE6320", VA = "0x186FE7520")]
	public void OAEEPDMCEKE(int[] OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7520", Offset = "0x6FE6320", VA = "0x186FE7520")]
	public void OAEEPDMCEKE(uint[] OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7290", Offset = "0x6FE6090", VA = "0x186FE7290")]
	public void OAEEPDMCEKE(ushort[] OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7290", Offset = "0x6FE6090", VA = "0x186FE7290")]
	public void OAEEPDMCEKE(short[] OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6FE70A0", Offset = "0x6FE5EA0", VA = "0x186FE70A0")]
	public void OAEEPDMCEKE(bool[] OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7450", Offset = "0x6FE6250", VA = "0x186FE7450")]
	public void OAEEPDMCEKE(string[] OAIIHELJHLG, int HOBBICEPBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7790", Offset = "0x6FE6590", VA = "0x186FE7790")]
	public void OIPPMONBIDL(IPEndPoint IOAJJGFAGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7CE0", Offset = "0x6FE6AE0", VA = "0x186FE7CE0")]
	public void OIPPMONBIDL(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7970", Offset = "0x6FE6770", VA = "0x186FE7970")]
	public void OIPPMONBIDL(string OAIIHELJHLG, int JLMEKGPDJJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class GDDHJBGKJIL
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class IFMGEOGJJPI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong OCNPBLDHFMO;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4D33C40", Offset = "0x4D32A40", VA = "0x184D33C40")]
		static IFMGEOGJJPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void PPCOMGLEPFE(EEKDFBBOCIK JFLBMHOJFED, object BLHCIGPBGBI);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ICKGPJONHJL<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public GDDHJBGKJIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ICKGPJONHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4D2B9D0", Offset = "0x4D2A7D0", VA = "0x184D2B9D0")]
		internal void GPBHFNLKLIB(EEKDFBBOCIK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class KFAJIACJCPE<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public GDDHJBGKJIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KFAJIACJCPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x50A3970", Offset = "0x50A2770", VA = "0x1850A3970")]
		internal void GPBHFNLKLIB(EEKDFBBOCIK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly BPOLEINNBGP FEIINGGMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, PPCOMGLEPFE> BCLBLFPBMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly EJPLMILLDOF JGBJBJJIOPM;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6FE82F0", Offset = "0x6FE70F0", VA = "0x186FE82F0")]
	public GDDHJBGKJIL(int HENCCCKDDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3708340", Offset = "0x3707140", VA = "0x183708340", Slot = "4")]
	protected virtual ulong FPLNJDHGCMG<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE81C0", Offset = "0x6FE6FC0", VA = "0x186FE81C0", Slot = "5")]
	protected virtual PPCOMGLEPFE MGGJJBPCEKP(EEKDFBBOCIK JFLBMHOJFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x39021F0", Offset = "0x3900FF0", VA = "0x1839021F0", Slot = "6")]
	protected virtual void NDDPACMNOCI<T>(EJPLMILLDOF KMFJBCLMGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8140", Offset = "0x6FE6F40", VA = "0x186FE8140")]
	public void GGIAOFDMHEG(EEKDFBBOCIK JFLBMHOJFED, object BLHCIGPBGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3902140", Offset = "0x3900F40", VA = "0x183902140")]
	public void KNLEDDADFAC<T>(EJPLMILLDOF KMFJBCLMGLE, T HMMDBBEAMNI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE80F0", Offset = "0x6FE6EF0", VA = "0x186FE80F0")]
	public void ANCNMMALPNK(EEKDFBBOCIK JFLBMHOJFED, object BLHCIGPBGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3901F80", Offset = "0x3900D80", VA = "0x183901F80")]
	public void EKGJCBJMHEA<T>(Action<T> MPNLFHKFFJM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3901DC0", Offset = "0x3900BC0", VA = "0x183901DC0")]
	public void EKGJCBJMHEA<T, TUserData>(Action<T, TUserData> MPNLFHKFFJM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FIKDEECGMMM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5EB0", Offset = "0x6FE4CB0", VA = "0x186FE5EB0")]
	public FIKDEECGMMM(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class LLGNLCKIJBI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB820", Offset = "0x6FEA620", VA = "0x186FEB820")]
	public LLGNLCKIJBI(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class BPOLEINNBGP
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum ANIFJPJKNOE
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class HMLIKMIMJBI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public ANIFJPJKNOE KDNIOMEAELB;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4C54B70", Offset = "0x4C53970", VA = "0x184C54B70", Slot = "4")]
		public virtual void HLJFBNEKAGO(MethodInfo ABJCFCKJNJK, MethodInfo LKDEPJBPIGO, ANIFJPJKNOE AAFMBEEMJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KNKJOPBDIDC(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void KCJMLFOKNAF(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		protected HMLIKMIMJBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class HMAPHOJEICE<TClass, TProperty> : HMLIKMIMJBI<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> DEKDACEHFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> FCHCBJPKIHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> FECKDNGNEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> OLOKFMDJHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> NPEBDEOPBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> NMGGIDFPINF;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4C4CD60", Offset = "0x4C4BB60", VA = "0x184C4CD60", Slot = "7")]
		public override void MPJOPLILFMF(TClass DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4C4A950", Offset = "0x4C49750", VA = "0x184C4A950", Slot = "8")]
		public override void JBGCIDJMIKG(TClass DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4C4C8D0", Offset = "0x4C4B6D0", VA = "0x184C4C8D0", Slot = "9")]
		public override void KNKJOPBDIDC(TClass DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4C4BAD0", Offset = "0x4C4A8D0", VA = "0x184C4BAD0", Slot = "10")]
		public override void KCJMLFOKNAF(TClass DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4C4C9B0", Offset = "0x4C4B7B0", VA = "0x184C4C9B0")]
		protected TProperty[] LCHLGEGAMPJ(TClass DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4C45DF0", Offset = "0x4C44BF0", VA = "0x184C45DF0")]
		protected TProperty[] GCOIODKHLJI(TClass DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4C4A1F0", Offset = "0x4C48FF0", VA = "0x184C4A1F0", Slot = "4")]
		public override void HLJFBNEKAGO(MethodInfo ABJCFCKJNJK, MethodInfo LKDEPJBPIGO, ANIFJPJKNOE AAFMBEEMJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4C4D620", Offset = "0x4C4C420", VA = "0x184C4D620")]
		protected HMAPHOJEICE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class AGIFBIFMIDG<TClass, TProperty> : HMAPHOJEICE<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void IDNKMGEFLKF(EEKDFBBOCIK JGFHGJBECJA, [Out] TProperty AOENOBOMBLC);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void BBIEJOGOKIC(EJPLMILLDOF OHGAFHDMJBG, TProperty AOENOBOMBLC);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F4F0", Offset = "0x4C8E2F0", VA = "0x184C8F4F0", Slot = "5")]
		public override void DCFINHBGJDA(TClass DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F710", Offset = "0x4C8E510", VA = "0x184C8F710", Slot = "6")]
		public override void KNLEDDADFAC(TClass DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F8D0", Offset = "0x4C8E6D0", VA = "0x184C8F8D0", Slot = "7")]
		public override void MPJOPLILFMF(TClass DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F590", Offset = "0x4C8E390", VA = "0x184C8F590", Slot = "8")]
		public override void JBGCIDJMIKG(TClass DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F990", Offset = "0x4C8E790", VA = "0x184C8F990")]
		protected AGIFBIFMIDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class NBLNMFNCNFB<T> : HMAPHOJEICE<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x546E3E0", Offset = "0x546D1E0", VA = "0x18546E3E0", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x45D41A0", Offset = "0x45D2FA0", VA = "0x1845D41A0", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x546E460", Offset = "0x546D260", VA = "0x18546E460", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x45D4130", Offset = "0x45D2F30", VA = "0x1845D4130", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public NBLNMFNCNFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class ECDEPLBMDKB<T> : HMAPHOJEICE<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x45D40B0", Offset = "0x45D2EB0", VA = "0x1845D40B0", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x45D41A0", Offset = "0x45D2FA0", VA = "0x1845D41A0", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x45D4210", Offset = "0x45D3010", VA = "0x1845D4210", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x45D4130", Offset = "0x45D2F30", VA = "0x1845D4130", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public ECDEPLBMDKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class JLOHONGKPPI<T> : HMAPHOJEICE<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1360", Offset = "0x4FD0160", VA = "0x184FD1360", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1450", Offset = "0x4FD0250", VA = "0x184FD1450", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4FD14C0", Offset = "0x4FD02C0", VA = "0x184FD14C0", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4FD13E0", Offset = "0x4FD01E0", VA = "0x184FD13E0", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public JLOHONGKPPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NLBCMCDPMEK<T> : HMAPHOJEICE<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x54CF020", Offset = "0x54CDE20", VA = "0x1854CF020", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1450", Offset = "0x4FD0250", VA = "0x184FD1450", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x54CF0A0", Offset = "0x54CDEA0", VA = "0x1854CF0A0", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4FD13E0", Offset = "0x4FD01E0", VA = "0x184FD13E0", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public NLBCMCDPMEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class LMLCACMLMGJ<T> : HMAPHOJEICE<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x51AC430", Offset = "0x51AB230", VA = "0x1851AC430", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4C55CD0", Offset = "0x4C54AD0", VA = "0x184C55CD0", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x51AC4B0", Offset = "0x51AB2B0", VA = "0x1851AC4B0", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4C55C60", Offset = "0x4C54A60", VA = "0x184C55C60", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public LMLCACMLMGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class HPAMMDKIGII<T> : HMAPHOJEICE<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4C55BE0", Offset = "0x4C549E0", VA = "0x184C55BE0", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4C55CD0", Offset = "0x4C54AD0", VA = "0x184C55CD0", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4C55D40", Offset = "0x4C54B40", VA = "0x184C55D40", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4C55C60", Offset = "0x4C54A60", VA = "0x184C55C60", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public HPAMMDKIGII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class CGDBEKIFNBF<T> : HMAPHOJEICE<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8B20", Offset = "0x4BA7920", VA = "0x184BA8B20", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8C10", Offset = "0x4BA7A10", VA = "0x184BA8C10", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x66314D0", Offset = "0x66302D0", VA = "0x1866314D0", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8BA0", Offset = "0x4BA79A0", VA = "0x184BA8BA0", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public CGDBEKIFNBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class AFJIPGCJAAH<T> : HMAPHOJEICE<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8B20", Offset = "0x4BA7920", VA = "0x184BA8B20", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8C10", Offset = "0x4BA7A10", VA = "0x184BA8C10", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8C80", Offset = "0x4BA7A80", VA = "0x184BA8C80", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8BA0", Offset = "0x4BA79A0", VA = "0x184BA8BA0", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public AFJIPGCJAAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class AOCDAJNIPBG<T> : HMAPHOJEICE<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4E9C2F0", Offset = "0x4E9B0F0", VA = "0x184E9C2F0", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E9C370", Offset = "0x4E9B170", VA = "0x184E9C370", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4E9C3E0", Offset = "0x4E9B1E0", VA = "0x184E9C3E0", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x45D4130", Offset = "0x45D2F30", VA = "0x1845D4130", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public AOCDAJNIPBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class NKDDHOGJBCD<T> : HMAPHOJEICE<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x54C8D00", Offset = "0x54C7B00", VA = "0x1854C8D00", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x54C8D80", Offset = "0x54C7B80", VA = "0x1854C8D80", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x54C8DF0", Offset = "0x54C7BF0", VA = "0x1854C8DF0", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4C55C60", Offset = "0x4C54A60", VA = "0x184C55C60", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public NKDDHOGJBCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class GEFOLMLJNEC<T> : HMAPHOJEICE<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4BBE290", Offset = "0x4BBD090", VA = "0x184BBE290", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4BBE310", Offset = "0x4BBD110", VA = "0x184BBE310", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4BBE380", Offset = "0x4BBD180", VA = "0x184BBE380", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8BA0", Offset = "0x4BA79A0", VA = "0x184BA8BA0", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x45D4290", Offset = "0x45D3090", VA = "0x1845D4290")]
		public GEFOLMLJNEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ICCKNHHOOJN<T> : AGIFBIFMIDG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4D28640", Offset = "0x4D27440", VA = "0x184D28640", Slot = "12")]
		protected override void BBIEJOGOKIC(EJPLMILLDOF OHGAFHDMJBG, char AOENOBOMBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4D28670", Offset = "0x4D27470", VA = "0x184D28670", Slot = "11")]
		protected override void IDNKMGEFLKF(EEKDFBBOCIK JGFHGJBECJA, [Out] char AOENOBOMBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4592CE0", Offset = "0x4591AE0", VA = "0x184592CE0")]
		public ICCKNHHOOJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class AAABHCPHJAK<T> : AGIFBIFMIDG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4B5A740", Offset = "0x4B59540", VA = "0x184B5A740", Slot = "12")]
		protected override void BBIEJOGOKIC(EJPLMILLDOF OHGAFHDMJBG, IPEndPoint AOENOBOMBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B5A770", Offset = "0x4B59570", VA = "0x184B5A770", Slot = "11")]
		protected override void IDNKMGEFLKF(EEKDFBBOCIK JGFHGJBECJA, [Out] IPEndPoint AOENOBOMBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4592CE0", Offset = "0x4591AE0", VA = "0x184592CE0")]
		public AAABHCPHJAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class EAOLANCMJML<T> : HMAPHOJEICE<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int BAIJOCLLENG;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x45C2390", Offset = "0x45C1190", VA = "0x1845C2390")]
		public EAOLANCMJML(int JLMEKGPDJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x45C2190", Offset = "0x45C0F90", VA = "0x1845C2190", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x45C2290", Offset = "0x45C1090", VA = "0x1845C2290", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x45C2310", Offset = "0x45C1110", VA = "0x1845C2310", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x45C2210", Offset = "0x45C1010", VA = "0x1845C2210", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class FODBAFNNLFF<T> : HMLIKMIMJBI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo KPNBGJGPCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type BCFLCKDGBMB;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4ADAC40", Offset = "0x4AD9A40", VA = "0x184ADAC40")]
		public FODBAFNNLFF(PropertyInfo FEMKAJANBPA, Type LIAGCGCENFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA950", Offset = "0x4AD9750", VA = "0x184ADA950", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4ADAB30", Offset = "0x4AD9930", VA = "0x184ADAB30", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4ADABE0", Offset = "0x4AD99E0", VA = "0x184ADABE0", Slot = "7")]
		public override void MPJOPLILFMF(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4ADAA10", Offset = "0x4AD9810", VA = "0x184ADAA10", Slot = "8")]
		public override void JBGCIDJMIKG(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4ADAAD0", Offset = "0x4AD98D0", VA = "0x184ADAAD0", Slot = "9")]
		public override void KNKJOPBDIDC(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4ADAA70", Offset = "0x4AD9870", VA = "0x184ADAA70", Slot = "10")]
		public override void KCJMLFOKNAF(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class DAEJLBNIMEL<T> : FODBAFNNLFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x45D9DD0", Offset = "0x45D8BD0", VA = "0x1845D9DD0")]
		public DAEJLBNIMEL(PropertyInfo FEMKAJANBPA, Type LIAGCGCENFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2A20", Offset = "0x6AE1820", VA = "0x186AE2A20", Slot = "5")]
		public override void DCFINHBGJDA(T DJMPODPDCIK, EEKDFBBOCIK JGFHGJBECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2AE0", Offset = "0x6AE18E0", VA = "0x186AE2AE0", Slot = "6")]
		public override void KNLEDDADFAC(T DJMPODPDCIK, EJPLMILLDOF OHGAFHDMJBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class JJJOMOOOLJP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static JJJOMOOOLJP<T> ICOFMPPJNFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly HMLIKMIMJBI<T>[] LBJDALOHCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int ICCLHOLAGJJ;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4FBFD40", Offset = "0x4FBEB40", VA = "0x184FBFD40")]
		public JJJOMOOOLJP(List<HMLIKMIMJBI<T>> CGNEBHHGDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4FBFC90", Offset = "0x4FBEA90", VA = "0x184FBFC90")]
		public void KNLEDDADFAC(T GLEBGNJJOHG, EJPLMILLDOF KMFJBCLMGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4FBFBE0", Offset = "0x4FBE9E0", VA = "0x184FBFBE0")]
		public void DCFINHBGJDA(T GLEBGNJJOHG, EEKDFBBOCIK JFLBMHOJFED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class JLMNCBKFMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract HMLIKMIMJBI<T> MBFFDPKOBBN<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private EJPLMILLDOF JMOPAMHKMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int NOGOODDHOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, JLMNCBKFMAP> POLMGEMJAGL;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5400", Offset = "0x6FE4200", VA = "0x186FE5400")]
	public BPOLEINNBGP(int HENCCCKDDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x36A9C80", Offset = "0x36A8A80", VA = "0x1836A9C80")]
	private JJJOMOOOLJP<T> BLLHBDMEBHI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x36A6260", Offset = "0x36A5060", VA = "0x1836A6260")]
	public void KEMEJJLNDFN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x36AAE40", Offset = "0x36A9C40", VA = "0x1836AAE40")]
	public bool LGDBIGPAFJK<T>(EEKDFBBOCIK JFLBMHOJFED, T GDCDKMJLKDH) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x36AADB0", Offset = "0x36A9BB0", VA = "0x1836AADB0")]
	public void KIDMEGDOMCG<T>(EJPLMILLDOF KMFJBCLMGLE, T GLEBGNJJOHG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class GPEPDGEFGDN
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime CPMNICNEAAM;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] IFLDEJOGFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public MHPDDDGEONH EEPHDNOODMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA680", Offset = "0x6FE9480", VA = "0x186FEA680")]
		get
		{
			return default(MHPDDDGEONH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HKGEPGJNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9BC0", Offset = "0x6FE89C0", VA = "0x186FE9BC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA080", Offset = "0x6FE8E80", VA = "0x186FEA080")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BNIIKCHGCMH DNGIHJBBHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9E30", Offset = "0x6FE8C30", VA = "0x186FE9E30")]
		get
		{
			return default(BNIIKCHGCMH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9BF0", Offset = "0x6FE89F0", VA = "0x186FE9BF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int CNOGKBPBHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA210", Offset = "0x6FE9010", VA = "0x186FEA210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint PPHJALONBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9940", Offset = "0x6FE8740", VA = "0x186FE9940")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? BIBNEPPFHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA470", Offset = "0x6FE9270", VA = "0x186FEA470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? CJDAHCKPKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA050", Offset = "0x6FE8E50", VA = "0x186FEA050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? JBGKHFKPJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA880", Offset = "0x6FE9680", VA = "0x186FEA880")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA6B0", Offset = "0x6FE94B0", VA = "0x186FEA6B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? AIONGBBHJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xC2D3D0", Offset = "0xC2C1D0", VA = "0x180C2D3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xDF46D0", Offset = "0xDF34D0", VA = "0x180DF46D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA910", Offset = "0x6FE9710", VA = "0x186FEA910")]
	public GPEPDGEFGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAC30", Offset = "0x6FE9A30", VA = "0x186FEAC30")]
	internal GPEPDGEFGDN(byte[] HNAKMABCJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9F30", Offset = "0x6FE8D30", VA = "0x186FE9F30")]
	public static GPEPDGEFGDN FLEEFEINPOE(byte[] HNAKMABCJKP, DateTime BDAIPDHNDEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FE99C0", Offset = "0x6FE87C0", VA = "0x186FE99C0")]
	internal void AGDJMFKLBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA4A0", Offset = "0x6FE92A0", VA = "0x186FEA4A0")]
	private void LHJOPPCDBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9C30", Offset = "0x6FE8A30", VA = "0x186FE9C30")]
	private DateTime? BLLJPELENAH(int PPPFIBNDOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA240", Offset = "0x6FE9040", VA = "0x186FEA240")]
	private void KAEEMKHLGLK(int PPPFIBNDOMK, DateTime? OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9E60", Offset = "0x6FE8C60", VA = "0x186FE9E60")]
	private ulong DLCIALEELMJ(int PPPFIBNDOMK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA150", Offset = "0x6FE8F50", VA = "0x186FEA150")]
	private void HBJJHDHLPPI(int PPPFIBNDOMK, ulong OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA0C0", Offset = "0x6FE8EC0", VA = "0x186FEA0C0")]
	private uint GOCFECFJNEI(int PPPFIBNDOMK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EAEBC0", Offset = "0x6EAD9C0", VA = "0x186EAEBC0")]
	private static uint KEAFAMDKNPE(uint AJEEBBBAOKG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA410", Offset = "0x6FE9210", VA = "0x186FEA410")]
	private static ulong KEAFAMDKNPE(ulong AJEEBBBAOKG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum MHPDDDGEONH
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
public enum BNIIKCHGCMH
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class LANAOBJHGNA
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int IMMKGNBKPPC = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int ICHPKKJDELE = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int FLGAENAKBHK = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint CMKPHGNPNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int NAFLNBALNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int IACGMCPJIFK;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ODJJIJEPAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB5B0", Offset = "0x6FEA3B0", VA = "0x186FEB5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB5C0", Offset = "0x6FEA3C0", VA = "0x186FEB5C0")]
	public bool ODFOIKANOLH(JDFLNHICKHN POHDKHBEDBF, int CKLBNPGGJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class AKIEMEGGCBG : JDFLNHICKHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket POHDKHBEDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly PNOJAHGJGMP COKCKIEBHCL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short HJCDLOJEEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3A60", Offset = "0x6FE2860", VA = "0x186FE3A60", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int KAKHEBBAPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3BF0", Offset = "0x6FE29F0", VA = "0x186FE3BF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint BAEOILMIFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3A80", Offset = "0x6FE2880", VA = "0x186FE3A80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily IKDANHFMMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5135FD0", Offset = "0x5134DD0", VA = "0x185135FD0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3C10", Offset = "0x6FE2A10", VA = "0x186FE3C10")]
	public AKIEMEGGCBG(AddressFamily EFBADNBKHHC, PNOJAHGJGMP COKCKIEBHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6FE34A0", Offset = "0x6FE22A0", VA = "0x186FE34A0", Slot = "8")]
	public bool BIBPDLBMMMP(IPEndPoint IOAJJGFAGCE, MLAMFPBFJHM BEIPMCJMNBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3AA0", Offset = "0x6FE28A0", VA = "0x186FE3AA0", Slot = "9")]
	public int JLELFMFAECD(byte[] GLBDCBGACGO, int PPPFIBNDOMK, int ACINDEOBNPO, IPEndPoint HGHNKNJEODJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3B00", Offset = "0x6FE2900", VA = "0x186FE3B00", Slot = "10")]
	public int OHINDIPODLN(byte[] GLBDCBGACGO, EndPoint MCFMNIDKKOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3AE0", Offset = "0x6FE28E0", VA = "0x186FE3AE0", Slot = "11")]
	public void MJLBKEDMFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface JDFLNHICKHN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short HJCDLOJEEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int KAKHEBBAPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint BAEOILMIFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily IKDANHFMMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BIBPDLBMMMP(IPEndPoint IOAJJGFAGCE, MLAMFPBFJHM BEIPMCJMNBO);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int JLELFMFAECD(byte[] GLBDCBGACGO, int PPPFIBNDOMK, int ACINDEOBNPO, IPEndPoint HGHNKNJEODJ);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OHINDIPODLN(byte[] GLBDCBGACGO, EndPoint HGHNKNJEODJ);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MJLBKEDMFJG();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct MPOLMDDNEEP : IEquatable<MPOLMDDNEEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long KPPOEKICCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long EKFLLEMDACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long ODMBCAHNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int MGPICOHFCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int ENBCILGAPFH;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6FED130", Offset = "0x6FEBF30", VA = "0x186FED130")]
	public MPOLMDDNEEP(byte[] EIANDFAKKKJ, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6FED1F0", Offset = "0x6FEBFF0", VA = "0x186FED1F0")]
	public MPOLMDDNEEP(Span<byte> EIANDFAKKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA31A00", Offset = "0xA30800", VA = "0x180A31A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6FED040", Offset = "0x6FEBE40", VA = "0x186FED040", Slot = "4")]
	public bool Equals(MPOLMDDNEEP HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6FED080", Offset = "0x6FEBE80", VA = "0x186FED080", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class JDCHPHIMHPD : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] HKAHINNMEFF;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GFHOMLIIOML
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void MEFCJKCHGOC(IPEndPoint EIANDFAKKKJ, Span<byte> FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string IIHBIABBFGP = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int HJDEJJGMCEM = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int ALFEJKDJHDM = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static Dictionary<MPOLMDDNEEP, IPEndPoint> OFJGKNGEHIN;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static MEFCJKCHGOC AKBKHCEALHB;

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	internal void DNMFKMBPDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	internal void HEDEAIFGHPP(IPEndPoint HGHNKNJEODJ, Span<byte> FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class AGFBEGEHJJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly int JHMIIFEIIJI;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
	protected AGFBEGEHJJM(int GIOCAPLPPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FFDDGGEDLII(IPEndPoint IOAJJGFAGCE, byte[] FFEMKICJPKP, int PPPFIBNDOMK, int NPCJGIOCILE);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void MMLDPCOFIML(IPEndPoint IOAJJGFAGCE, byte[] FFEMKICJPKP, int PPPFIBNDOMK, int NPCJGIOCILE);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class PJMJLOCJKCO : AGFBEGEHJJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private byte[] MAKJJJECHHB;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly RandomNumberGenerator HPBEOODBMPG;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x284F5A0", Offset = "0x284E3A0", VA = "0x18284F5A0")]
	public PJMJLOCJKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6FF25E0", Offset = "0x6FF13E0", VA = "0x186FF25E0")]
	public void LBGDBLFMPIG(IPEndPoint IOAJJGFAGCE, byte[] MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2B00", Offset = "0x6FF1900", VA = "0x186FF2B00")]
	public void NJBOIFIHPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2130", Offset = "0x6FF0F30", VA = "0x186FF2130", Slot = "4")]
	public override void FFDDGGEDLII(IPEndPoint IOAJJGFAGCE, byte[] FFEMKICJPKP, int PPPFIBNDOMK, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2790", Offset = "0x6FF1590", VA = "0x186FF2790", Slot = "5")]
	public override void MMLDPCOFIML(IPEndPoint IOAJJGFAGCE, byte[] FFEMKICJPKP, int PPPFIBNDOMK, int NPCJGIOCILE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct CAJENKLEJND
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void BFHCPGNMONP([NoAlias] byte* CIAGNOIANDP, [NoAlias] byte* MAKJJJECHHB, [NoAlias] byte* CEOFMGCLCIA, int NPCJGIOCILE);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class JBEFGFFFNJM
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB880", Offset = "0x6FFA680", VA = "0x186FFB880")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB720", Offset = "0x6FFA520", VA = "0x186FFB720")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6FFBBF0", Offset = "0x6FFA9F0", VA = "0x186FFBBF0")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB9B0", Offset = "0x6FFA7B0", VA = "0x186FFB9B0")]
		public unsafe static void HDKOJPGLKCE([NoAlias] byte* CIAGNOIANDP, [NoAlias] byte* MAKJJJECHHB, [NoAlias] byte* CEOFMGCLCIA, int NPCJGIOCILE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint MAKJJJECHHB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint CEOFMGCLCIA[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint KGEEABNIHPE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint BEEDGDNOMIO[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint KCALKKOFHEF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint KPFHBPHEBDP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint EAOJMDICDMK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private uint GJCAOEGOFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint CLMGFBJCLOK[8];

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6FE54A0", Offset = "0x6FE42A0", VA = "0x186FE54A0")]
	private void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5A40", Offset = "0x6FE4840", VA = "0x186FE5A40")]
	private uint ENJBGCLCILI(uint LCFJFNFOMKB, int OGDNKKDHKAM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2E20", Offset = "0x6FE1C20", VA = "0x186FE2E20")]
	private void DOILPDAGLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3060", Offset = "0x6FE1E60", VA = "0x186FE3060")]
	private void NBNPDHFDJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2FD0", Offset = "0x6FE1DD0", VA = "0x186FE2FD0")]
	private void KACJPDKAEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2ED0", Offset = "0x6FE1CD0", VA = "0x186FE2ED0")]
	private void HAPJDGDADID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5A70", Offset = "0x6FE4870", VA = "0x186FE5A70")]
	private void GFPMCAPPMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5520", Offset = "0x6FE4320", VA = "0x186FE5520")]
	private unsafe void BIJBCHPBINM(byte* CIAGNOIANDP, uint* MAKJJJECHHB, uint* CEOFMGCLCIA, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5AD0", Offset = "0x6FE48D0", VA = "0x186FE5AD0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void MNJFCDNJBOM([NoAlias] byte* CIAGNOIANDP, [NoAlias] byte* MAKJJJECHHB, [NoAlias] byte* CEOFMGCLCIA, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5B50", Offset = "0x6FE4950", VA = "0x186FE5B50")]
	public static void MNJFCDNJBOM(Span<byte> CIAGNOIANDP, Span<byte> MAKJJJECHHB, Span<byte> CEOFMGCLCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5940", Offset = "0x6FE4740", VA = "0x186FE5940")]
	public static void EBNPOBMDOGP(Span<byte> CIAGNOIANDP, Span<byte> MAKJJJECHHB, Span<byte> CEOFMGCLCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5C30", Offset = "0x6FE4A30", VA = "0x186FE5C30")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void NNMIHHDGALO([NoAlias] byte* CIAGNOIANDP, [NoAlias] byte* MAKJJJECHHB, [NoAlias] byte* CEOFMGCLCIA, int NPCJGIOCILE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBCA0", Offset = "0x6FFAAA0", VA = "0x186FFBCA0")]
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
