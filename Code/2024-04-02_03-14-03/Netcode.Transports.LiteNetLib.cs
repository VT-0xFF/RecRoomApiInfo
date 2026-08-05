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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, NMKBEKDKLMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum OJKMLKLGOMN
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Server,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
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
		private NetworkManager JHJIBCFEPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, GHNKACMHPJC> PGPNDKHAIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DGNLPMJNGAJ GMKJLPIJNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] GCMKLOCJLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OJKMLKLGOMN IMBFHOOJKBC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong MKCKCOAAHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MJBFBGKFJKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x55BE960", Offset = "0x55BD560", VA = "0x1855BE960", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x55BDE60", Offset = "0x55BCA60", VA = "0x1855BDE60")]
		public void RecRoom_SetEncryptionInfo(ulong GECMCHHODMO, byte[] CGGNJKGENIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x55BDE40", Offset = "0x55BCA40", VA = "0x1855BDE40")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55BDD10", Offset = "0x55BC910", VA = "0x1855BDD10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x55BE860", Offset = "0x55BD460", VA = "0x1855BE860")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x55BE060", Offset = "0x55BCC60", VA = "0x1855BE060", Slot = "6")]
		public override void Send(ulong GHIHCIOGEGJ, ArraySegment<byte> KOMCCCIEHEA, NetworkDelivery OPBFPDFAFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x55BDE00", Offset = "0x55BCA00", VA = "0x1855BDE00", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong GHIHCIOGEGJ, [Out] ArraySegment<byte> FGGJAKAMDOE, [Out] float ODJBEOJKHOF)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55BE350", Offset = "0x55BCF50", VA = "0x1855BE350", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x55BE780", Offset = "0x55BD380", VA = "0x1855BE780", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x55BD460", Offset = "0x55BC060", VA = "0x1855BD460", Slot = "10")]
		public override void DisconnectRemoteClient(ulong GHIHCIOGEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x55BD310", Offset = "0x55BBF10", VA = "0x1855BD310", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x55BD8C0", Offset = "0x55BC4C0", VA = "0x1855BD8C0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong GHIHCIOGEGJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x55BE2E0", Offset = "0x55BCEE0", VA = "0x1855BE2E0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x55BD960", Offset = "0x55BC560", VA = "0x1855BD960", Slot = "14")]
		public override void Initialize([Optional] NetworkManager JHJIBCFEPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x55BDC40", Offset = "0x55BC840", VA = "0x1855BDC40")]
		private NNKGOPPFPDN OFJDLNFBPHC(NetworkDelivery CJEAJMFMNNJ)
		{
			return default(NNKGOPPFPDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55BDB20", Offset = "0x55BC720", VA = "0x1855BDB20", Slot = "15")]
		private void JCMDOKDCDAL(GHNKACMHPJC MGOIHBMNDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x55BD180", Offset = "0x55BBD80", VA = "0x1855BD180", Slot = "16")]
		private void AAMCOJBGLOE(GHNKACMHPJC MGOIHBMNDNL, BAHLEJKHJLB PCFPOMBCHAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "17")]
		private void CBPAEPBDDFH(IPEndPoint KJIHBJJLPNL, SocketError BNKHAABLGJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x55BD5D0", Offset = "0x55BC1D0", VA = "0x1855BD5D0", Slot = "18")]
		private void EFJNGABMMIC(GHNKACMHPJC MGOIHBMNDNL, HKOPENOIIJF ALHICDKDPIA, byte BCBGAJELAEH, NNKGOPPFPDN LLJBLDAAIMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x55BD7E0", Offset = "0x55BC3E0", VA = "0x1855BD7E0")]
		private void EFLOCDAFAKD(int JKNAAACFMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "19")]
		private void HMEENBDLMIO(IPEndPoint DCGLMHPMIOA, HKOPENOIIJF ALHICDKDPIA, PENLKALPJFL JCHEGHDLGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "20")]
		private void PHFADGOAPGO(GHNKACMHPJC MGOIHBMNDNL, int KMKECCIPFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55BDBE0", Offset = "0x55BC7E0", VA = "0x1855BDBE0", Slot = "21")]
		private void KFBPAJHMBON(KDLMIGMPBPD MLHMNLDOBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55BD2E0", Offset = "0x55BBEE0", VA = "0x1855BD2E0")]
		private ulong DEHALANHGBP(GHNKACMHPJC MGOIHBMNDNL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x55BD2C0", Offset = "0x55BBEC0", VA = "0x1855BD2C0")]
		private static int AHNNFNHECAL(float OPCGAFBMLPL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x55BE880", Offset = "0x55BD480", VA = "0x1855BE880")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class DOFKHEEBGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly GHNKACMHPJC NCCCJFKGAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<IIFCKNAIHNB> HKFLEPEDPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int JLBBKLFEJEE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x55B3550", Offset = "0x55B2150", VA = "0x1855B3550")]
	protected DOFKHEEBGMJ(GHNKACMHPJC MGOIHBMNDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x55B34F0", Offset = "0x55B20F0", VA = "0x1855B34F0")]
	public void MMIGJNBIAFA(IIFCKNAIHNB KJCPBMMMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55B3430", Offset = "0x55B2030", VA = "0x1855B3430")]
	protected void BKFEJHLGGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55B34B0", Offset = "0x55B20B0", VA = "0x1855B34B0")]
	public bool KONDECBIIEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool EPJEODHDGDJ();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool NJPCGFBNHEM(IIFCKNAIHNB KJCPBMMMJFO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum CHLECELJKOO
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KDLMIGMPBPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DGNLPMJNGAJ ABNAGPFMAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int CHDOLAMFFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal NFLBHIBBHOA PDLIMDFMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint DJCPLBEKDIK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CHLECELJKOO FNKNJMLIKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EB0", Offset = "0x7D7AB0", VA = "0x1807D8EB0")]
		[CompilerGenerated]
		get
		{
			return default(CHLECELJKOO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x961710", Offset = "0x960310", VA = "0x180961710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x55BB530", Offset = "0x55BA130", VA = "0x1855BB530")]
	internal void JLHBJGHAABD(NFLBHIBBHOA ADPEKJIILCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x55BB500", Offset = "0x55BA100", VA = "0x1855BB500")]
	private bool ELDNCBBKINL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x55BB590", Offset = "0x55BA190", VA = "0x1855BB590")]
	internal KDLMIGMPBPD(IPEndPoint DCGLMHPMIOA, NFLBHIBBHOA PICCFBONMEE, DGNLPMJNGAJ MCDBBPGADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x55BB4A0", Offset = "0x55BA0A0", VA = "0x1855BB4A0")]
	public GHNKACMHPJC BJCGFOAOLNB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PENLKALPJFL
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OALJCMEANPH
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BAHLEJKHJLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public OALJCMEANPH JPNFLNCGBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError HAEBCCEMNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HKOPENOIIJF FDPMAFHGBPK;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NMKBEKDKLMB
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HODJEKHBOMM(GHNKACMHPJC MGOIHBMNDNL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGINNKPJNHL(GHNKACMHPJC MGOIHBMNDNL, BAHLEJKHJLB PCFPOMBCHAE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGJEJMEHFLK(IPEndPoint KJIHBJJLPNL, SocketError BNKHAABLGJE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGHBHFPCKAM(GHNKACMHPJC MGOIHBMNDNL, HKOPENOIIJF ALHICDKDPIA, byte BCBGAJELAEH, NNKGOPPFPDN LLJBLDAAIMJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJMGAMFJPOJ(IPEndPoint DCGLMHPMIOA, HKOPENOIIJF ALHICDKDPIA, PENLKALPJFL JCHEGHDLGHO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNEOCMANBBB(GHNKACMHPJC MGOIHBMNDNL, int KMKECCIPFLA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLGDBCHFPGE(KDLMIGMPBPD MLHMNLDOBPP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LDHDLKEOPNN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMCBOAHLFFF(GHNKACMHPJC MGOIHBMNDNL, object GFPEKPHBLHB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DLBELCMFEKD
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIOGCMECGCB(AJMKDANDLFC KJCPBMMMJFO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HKJBGDCBPMF
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBPMCLMEPCP(GHNKACMHPJC MGOIHBMNDNL, IPEndPoint MGJNKBIIKJL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NFLBHIBBHOA
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int HMJDFAPIJMN = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long EAGGMACOMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte EEDHGJPFPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] FACKBEGNDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly FKMHLBCMGMM EIIIJBECKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int EIDGLNCMCMB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x55C0050", Offset = "0x55BEC50", VA = "0x1855C0050")]
	private NFLBHIBBHOA(long CEMEMHGEBKK, byte ENMKDDAJCPF, int OJMIDFGBOBJ, byte[] KBJPDOGECPG, FKMHLBCMGMM KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55BFFF0", Offset = "0x55BEBF0", VA = "0x1855BFFF0")]
	public static int LHHDHENOHHM(IIFCKNAIHNB KJCPBMMMJFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x55BFBF0", Offset = "0x55BE7F0", VA = "0x1855BFBF0")]
	public static NFLBHIBBHOA FPINMLEJLIN(IIFCKNAIHNB KJCPBMMMJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x55BFE10", Offset = "0x55BEA10", VA = "0x1855BFE10")]
	public static IIFCKNAIHNB IPHABIIHJDG(GMOGDAOBKNF AOJNCJPFJOD, SocketAddress HOFMMGGCIDG, long MNHOACAINMO, int OJMIDFGBOBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class MGGMJBHMIGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long EAGGMACOMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte EEDHGJPFPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int EIDGLNCMCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool MMEJIELBHNI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x55BECC0", Offset = "0x55BD8C0", VA = "0x1855BECC0")]
	private MGGMJBHMIGO(long CEMEMHGEBKK, byte ENMKDDAJCPF, int GNKKAFADODD, bool NJOJMPHNGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x55BE980", Offset = "0x55BD580", VA = "0x1855BE980")]
	public static MGGMJBHMIGO FPINMLEJLIN(IIFCKNAIHNB KJCPBMMMJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x55BEBD0", Offset = "0x55BD7D0", VA = "0x1855BEBD0")]
	public static IIFCKNAIHNB IPHABIIHJDG(long MNHOACAINMO, byte IOOFPMGKPLM, int GHMFFNDDJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x55BEAD0", Offset = "0x55BD6D0", VA = "0x1855BEAD0")]
	public static IIFCKNAIHNB IBKPPGNFPDC(GHNKACMHPJC MGOIHBMNDNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum INPFEKKPFKM
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OLBHMEHPFKL
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCOLHDPAOEE(IPEndPoint EPLHJOPMGEF, IPEndPoint DCGLMHPMIOA, string DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DINGIOPMDOL(IPEndPoint DEDKHECIALO, INPFEKKPFKM CJEAJMFMNNJ, string DGPOLLDAHJK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class LOJHIKCMJMH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct CILHCGEGIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint KNIAGICJPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint DJCPLBEKDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string HMNPIMLNDBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct LKHMKCGPKCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint GCHCMFBHJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public INPFEKKPFKM LLGILHFCKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string HMNPIMLNDBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class MIHJNACLIPK
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint DGKNKHBANDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string HMNPIMLNDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public MIHJNACLIPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class BNPENEEBAKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint DGKNKHBANDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint EOIKJBMHBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string HMNPIMLNDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BNPENEEBAKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class MKBLCFGMKAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HMNPIMLNDBP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IHEBAMCNBCB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82E0E0", Offset = "0x82CCE0", VA = "0x18082E0E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7B0C70", Offset = "0x7AF870", VA = "0x1807B0C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public MKBLCFGMKAH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DGNLPMJNGAJ MCCFGDOFJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<CILHCGEGIEF> MBLOOBJGBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<LKHMKCGPKCB> JBDCFNNKFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FKMHLBCMGMM PGOEFPHLIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GMOGDAOBKNF MNOKJCGPHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly AHLGHHEHMEG DOLOLGOFDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private OLBHMEHPFKL KLAAAFKACGG;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int LGIKJEKLEMA = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool EDMEOMPPPKH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x55BCD30", Offset = "0x55BB930", VA = "0x1855BCD30")]
	internal LOJHIKCMJMH(DGNLPMJNGAJ HGKFMHHLPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x55BC8A0", Offset = "0x55BB4A0", VA = "0x1855BC8A0")]
	internal void IDBAEMFOKPC(IPEndPoint KLPLDDBBJEN, IIFCKNAIHNB KJCPBMMMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2885380", Offset = "0x2883F80", VA = "0x182885380")]
	private void EEHAOMFFLBP<T>(T KJCPBMMMJFO, IPEndPoint PMKKKDOAOBE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x55BCBA0", Offset = "0x55BB7A0", VA = "0x1855BCBA0")]
	private void LCOLHDPAOEE(MIHJNACLIPK AFGHMIJOMGA, IPEndPoint KLPLDDBBJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x55BC740", Offset = "0x55BB340", VA = "0x1855BC740")]
	private void HPNHGHLDJJM(BNPENEEBAKE AFGHMIJOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x55BCA00", Offset = "0x55BB600", VA = "0x1855BCA00")]
	private void LBIOCGBILMJ(MKBLCFGMKAH AFGHMIJOMGA, IPEndPoint KLPLDDBBJEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum NNKGOPPFPDN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HDHMNELFHLI : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class ANKEDDCLMCP
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] NDABALJKCON;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int PIGNBNKJEJP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int LLNDEDDKNFJ;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EPHEDDMAENJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x55B4250", Offset = "0x55B2E50", VA = "0x1855B4250")]
	public EPHEDDMAENJ(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NMOEBMNJCAD : EPHEDDMAENJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x55B4250", Offset = "0x55B2E50", VA = "0x1855B4250")]
	public NMOEBMNJCAD(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OOMDHJFNOGH
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PDMNHHOLKIE
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNMJBLHBLMB(OOMDHJFNOGH KOKOMCHJGFE, string KCOOFCLDKNM, params object[] PELDJLKMCIK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class OKELLBCKDOH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static PDMNHHOLKIE CHFAPPOHDAK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object BJEEEENKPIG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x55C02E0", Offset = "0x55BEEE0", VA = "0x1855C02E0")]
	private static void OKOONLCIMCO(OOMDHJFNOGH JHIIOGHMGKK, string KCOOFCLDKNM, params object[] PELDJLKMCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x55C01C0", Offset = "0x55BEDC0", VA = "0x1855C01C0")]
	internal static void AIKAGKAGKEK(string KCOOFCLDKNM, params object[] PELDJLKMCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x55C0280", Offset = "0x55BEE80", VA = "0x1855C0280")]
	internal static void JCININCOIIF(string KCOOFCLDKNM, params object[] PELDJLKMCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x55C0220", Offset = "0x55BEE20", VA = "0x1855C0220")]
	internal static void HDCHPGLGINO(string KCOOFCLDKNM, params object[] PELDJLKMCIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum CDBJJLLFGAP
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HKOPENOIIJF : FKMHLBCMGMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private IIFCKNAIHNB LGBHEBEFHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DGNLPMJNGAJ ABIAJDEGKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CHOGBHAFOJO MJHIJCDGMBE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x55BA870", Offset = "0x55B9470", VA = "0x1855BA870")]
	internal HKOPENOIIJF(DGNLPMJNGAJ DFCFBMIMDHA, CHOGBHAFOJO FDALHPGOKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x55BA7D0", Offset = "0x55B93D0", VA = "0x1855BA7D0")]
	internal void JDCGDIHNOJL(IIFCKNAIHNB KJCPBMMMJFO, int FIACAPNBCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x55BA750", Offset = "0x55B9350", VA = "0x1855BA750")]
	internal void DDMHOECLEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x55BA840", Offset = "0x55B9440", VA = "0x1855BA840")]
	public void POHEEJJIAOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class CHOGBHAFOJO
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum NDJICKJIEMO
	{
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public CHOGBHAFOJO DEPMFFDMOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NDJICKJIEMO LLGILHFCKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public GHNKACMHPJC NCCCJFKGAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint DJCPLBEKDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object ANHLIFNCFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int LLOAGIKIEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError ELCNMPECPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public OALJCMEANPH MJCCOJHPBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public KDLMIGMPBPD ICIBJOBGDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NNKGOPPFPDN JDIHDLGKNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte NHHEFCKPGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly HKOPENOIIJF JCIJIBAHENE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55AC240", Offset = "0x55AAE40", VA = "0x1855AC240")]
	public CHOGBHAFOJO(DGNLPMJNGAJ DFCFBMIMDHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DGNLPMJNGAJ : IEnumerable<GHNKACMHPJC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class PGPAMPANGFD : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x55C05C0", Offset = "0x55BF1C0", VA = "0x1855C05C0", Slot = "4")]
		public bool Equals(IPEndPoint KLNIMOGOBLK, IPEndPoint EGCIDIGPDPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5078200", Offset = "0x5076E00", VA = "0x185078200", Slot = "5")]
		public int GetHashCode(IPEndPoint OGGNGHKHHGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PGPAMPANGFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct KKJKHCKNGHJ : IEnumerator<GHNKACMHPJC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly GHNKACMHPJC HFMNLCDDBCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private GHNKACMHPJC MPIIHMLBNNJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GHNKACMHPJC DDCJPGOIIOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9022F0", Offset = "0x900EF0", VA = "0x1809022F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9022F0", Offset = "0x900EF0", VA = "0x1809022F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xF6E6D0", Offset = "0xF6D2D0", VA = "0x180F6E6D0")]
		public KKJKHCKNGHJ(GHNKACMHPJC HLHHCNMEOCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x55BB600", Offset = "0x55BA200", VA = "0x1855BB600", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x55BB650", Offset = "0x55BA250", VA = "0x1855BB650", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread LIIGNEIJBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool ACBPMMCJIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent LFMJGCNCJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<CHOGBHAFOJO> JODBPIIPIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<CHOGBHAFOJO> GBKBEDBFKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private CHOGBHAFOJO PLHCDEMNNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NMKBEKDKLMB JOBNDMFLGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly LDHDLKEOPNN IIFNLIGLBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly DLBELCMFEKD JFGOAFHHMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HKJBGDCBPMF GOKGFICBMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, GHNKACMHPJC> PLNLLHHPDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, KDLMIGMPBPD> KKPINIEDPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, NGPNICOMMGB> JDIFBIKMHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim IFJHKBAIALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private GHNKACMHPJC GCFKKLBKNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int PAJEPDADMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<GHNKACMHPJC> NDBHIMLJMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private GHNKACMHPJC[] EPNMJGHFHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly FCKCGDPKPKG PKENNLLBAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int AHOPDECGPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> GBBLKIFJMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte BLKCFLGIPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object NOIMOLJBKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool AJKBBLLAEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool DFNMMDNDFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int BJDEBOJJOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int APACHILPNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int HPJHPFMFPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int POCHLPODJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool IPEOBGCDLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool ALIKEPGDCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int CFBLDDPMHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int IEFHIJFDOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int KNMHBCNLFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool EDMEOMPPPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool GCHEHLDJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool PDHDGGMNLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool JGNKDOJKMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int MMONDFMLPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int NGFIOMKOGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool BEAHDINPBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly NFGBLPEOAJJ CONMPDJPNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool KGIMOFNNHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly LOJHIKCMJMH COHJADBJEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool ODJPDBCEGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public CDBJJLLFGAP NIJDFFLDKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int HOPIAAOFOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool JDBBBMIPGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool GBBHBKKBMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool MEOCDJNPLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool NDJFLNJCDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private IIFCKNAIHNB KCFAPEDPFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int NNJKAFCHOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object GLBGLFHBOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private IIFCKNAIHNB MMIMLBHMJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int BMIIKOFMPIJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int FJEECBCKIIF = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int ODDGPGLCCCI = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IOEBKIDKJLE LEJCDGDEAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private IOEBKIDKJLE CNNOIPIFPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread GOEJHKEMFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread GJKDCGKDCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint HLNFHHCOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint HIIAICJGNDF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] PJKPMCGOBGM;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] AJLMGEKJIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<GFIFCNOGPHE, IPEndPoint> ODNFHJGKOPD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress MFCAOFCMJGF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool BNPKDFNKAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int DFBHLBNGEHD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JDGKHINGBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E330", Offset = "0xA5CF30", VA = "0x180A5E330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB2AE00", Offset = "0xB29A00", VA = "0x180B2AE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BIGBFFONFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x131AD50", Offset = "0x1319950", VA = "0x18131AD50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x16306D0", Offset = "0x162F2D0", VA = "0x1816306D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte POLJKFNAKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D30", Offset = "0x8C5930", VA = "0x1808C6D30")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IOJHGKLEKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x55AC4B0", Offset = "0x55AB0B0", VA = "0x1855AC4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short GABAPEPOHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x55B0E80", Offset = "0x55AFA80", VA = "0x1855B0E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x55AD9B0", Offset = "0x55AC5B0", VA = "0x1855AD9B0")]
	public void CNONKLDNJHD(IPEndPoint KJIHBJJLPNL, byte[] CGGNJKGENIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55B1C60", Offset = "0x55B0860", VA = "0x1855B1C60")]
	public void NAPLOKHPNLK(IPEndPoint KJIHBJJLPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55AD2A0", Offset = "0x55ABEA0", VA = "0x1855AD2A0")]
	private bool BHBLMFALDCP(IPEndPoint KJIHBJJLPNL, [Out] GHNKACMHPJC MGOIHBMNDNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x55ADDB0", Offset = "0x55AC9B0", VA = "0x1855ADDB0")]
	private void DEAGIOHGDPF(GHNKACMHPJC MGOIHBMNDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x55AC460", Offset = "0x55AB060", VA = "0x1855AC460")]
	private void AEGKGIMOPKE(GHNKACMHPJC MGOIHBMNDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55B0C20", Offset = "0x55AF820", VA = "0x1855B0C20")]
	private void JHCAGBEIGEN(GHNKACMHPJC MGOIHBMNDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x55B2DE0", Offset = "0x55B19E0", VA = "0x1855B2DE0")]
	public DGNLPMJNGAJ(NMKBEKDKLMB MCDBBPGADCI, [Optional] FCKCGDPKPKG MGONEOLBKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x55B1E10", Offset = "0x55B0A10", VA = "0x1855B1E10")]
	internal void OEKELGPOJMO(GHNKACMHPJC JJIIBIIMPNG, int KMKECCIPFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55B2BB0", Offset = "0x55B17B0", VA = "0x1855B2BB0")]
	internal void PPLFADPLKNJ(GHNKACMHPJC JJIIBIIMPNG, object GFPEKPHBLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55B1940", Offset = "0x55B0540", VA = "0x1855B1940")]
	internal void MIFFBHEFHAE(GHNKACMHPJC MGOIHBMNDNL, OALJCMEANPH PBFMPJEICKM, SocketError IBEBONNGBNF, IIFCKNAIHNB JOAOCJCBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55B1A10", Offset = "0x55B0610", VA = "0x1855B1A10")]
	private void MNBPIOOMACD(GHNKACMHPJC MGOIHBMNDNL, OALJCMEANPH PBFMPJEICKM, SocketError IBEBONNGBNF, bool FAAGKOCIKOI, byte[] KOMCCCIEHEA, int ILKNGPHCOGM, int MAJIECOCCAC, IIFCKNAIHNB JOAOCJCBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55B27F0", Offset = "0x55B13F0", VA = "0x1855B27F0")]
	private void PMLJNLCDJLG(CHOGBHAFOJO.NDJICKJIEMO CJEAJMFMNNJ, [Optional] GHNKACMHPJC MGOIHBMNDNL, [Optional] IPEndPoint DCGLMHPMIOA, SocketError OECLKDJBFMA = SocketError.Success, int KMKECCIPFLA = 0, OALJCMEANPH EHMDOAAOCOA = OALJCMEANPH.ConnectionFailed, [Optional] KDLMIGMPBPD KMGAAPIIHPD, NNKGOPPFPDN LLJBLDAAIMJ = NNKGOPPFPDN.Unreliable, byte BCBGAJELAEH = 0, [Optional] IIFCKNAIHNB PMAHAFMLFGG, [Optional] object GFPEKPHBLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55AC810", Offset = "0x55AB410", VA = "0x1855AC810")]
	private void BGCDEDIHGMO(CHOGBHAFOJO FDALHPGOKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55B0460", Offset = "0x55AF060", VA = "0x1855B0460")]
	internal void HBMFCCBNIFB(CHOGBHAFOJO FDALHPGOKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55AC4D0", Offset = "0x55AB0D0", VA = "0x1855AC4D0")]
	private void BAPDKOINENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x55AE070", Offset = "0x55ACC70", VA = "0x1855AE070")]
	private void DKFMNLGPMGM(int MBPJHPFKNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x55AE6B0", Offset = "0x55AD2B0", VA = "0x1855AE6B0")]
	internal GHNKACMHPJC FDODELNIFFC(KDLMIGMPBPD MLHMNLDOBPP, byte[] DLILBAPGFAO, int ILKNGPHCOGM, int GFICJHOBPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x55B18C0", Offset = "0x55B04C0", VA = "0x1855B18C0")]
	private int MBMBKLDIKFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x55B07C0", Offset = "0x55AF3C0", VA = "0x1855B07C0")]
	private void ICDEOJNKACE(IPEndPoint DCGLMHPMIOA, GHNKACMHPJC PHBIHDFKOIE, NFLBHIBBHOA BENOLFKGLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x55AECD0", Offset = "0x55AD8D0", VA = "0x1855AECD0")]
	private void GFHMLFPPKPG(IIFCKNAIHNB KJCPBMMMJFO, IPEndPoint DCGLMHPMIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x55AD330", Offset = "0x55ABF30", VA = "0x1855AD330")]
	internal void BMGNLGKHHIM(IIFCKNAIHNB KJCPBMMMJFO, NNKGOPPFPDN PLOLOAPJJIC, byte BCBGAJELAEH, int FIACAPNBCNA, GHNKACMHPJC JJIIBIIMPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x55AFC10", Offset = "0x55AE810", VA = "0x1855AFC10")]
	public bool GJNOBIEAGDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55AFBF0", Offset = "0x55AE7F0", VA = "0x1855AFBF0")]
	public bool GJNOBIEAGDP(IPAddress MBPBHGMLCDF, IPAddress MKNMOGNLEHI, int IDHDCMJFMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55AFC20", Offset = "0x55AE820", VA = "0x1855AFC20")]
	public bool GJNOBIEAGDP(int IDHDCMJFMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x55B0F40", Offset = "0x55AFB40", VA = "0x1855B0F40")]
	public void KDDDIBOPOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x55B1620", Offset = "0x55B0220", VA = "0x1855B1620")]
	public GHNKACMHPJC LOEOEOGOAMD(string LPBKFPDBJBG, int IDHDCMJFMDO, string CGGNJKGENIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x55B1700", Offset = "0x55B0300", VA = "0x1855B1700")]
	public GHNKACMHPJC LOEOEOGOAMD(string LPBKFPDBJBG, int IDHDCMJFMDO, GMOGDAOBKNF BMFMDDADNAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x55B1250", Offset = "0x55AFE50", VA = "0x1855B1250")]
	public GHNKACMHPJC LOEOEOGOAMD(IPEndPoint PMKKKDOAOBE, GMOGDAOBKNF BMFMDDADNAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x55ADA50", Offset = "0x55AC650", VA = "0x1855ADA50")]
	public void DCPOOINKPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x55ADA60", Offset = "0x55AC660", VA = "0x1855ADA60")]
	public void DCPOOINKPBO(bool OCPNOKNFALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x55AD710", Offset = "0x55AC310", VA = "0x1855AD710")]
	public void CDAKBHDJHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x55AD5F0", Offset = "0x55AC1F0", VA = "0x1855AD5F0")]
	public void CDAKBHDJHBD(byte[] KOMCCCIEHEA, int ILKNGPHCOGM, int MAJIECOCCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x55B1BB0", Offset = "0x55B07B0", VA = "0x1855B1BB0")]
	public void MNBPIOOMACD(GHNKACMHPJC MGOIHBMNDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x55B1AF0", Offset = "0x55B06F0", VA = "0x1855B1AF0")]
	public void MNBPIOOMACD(GHNKACMHPJC MGOIHBMNDNL, byte[] KOMCCCIEHEA, int ILKNGPHCOGM, int MAJIECOCCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x55B2C00", Offset = "0x55B1800", VA = "0x1855B2C00", Slot = "4")]
	private IEnumerator<GHNKACMHPJC> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x55B2C90", Offset = "0x55B1890", VA = "0x1855B2C90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x55AFA20", Offset = "0x55AE620", VA = "0x1855AFA20")]
	private IIFCKNAIHNB GJKGNANHBEI(FLGDIIAHHJN FOGOAFCOGPF, int JKNAAACFMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x55AFB10", Offset = "0x55AE710", VA = "0x1855AFB10")]
	private IIFCKNAIHNB GJKGNANHBEI(FLGDIIAHHJN FOGOAFCOGPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x55AE390", Offset = "0x55ACF90", VA = "0x1855AE390")]
	internal IIFCKNAIHNB EEEDPKLNNIM(int JKNAAACFMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x55B0560", Offset = "0x55AF160", VA = "0x1855B0560")]
	internal void HMDHEGPAPBM(IIFCKNAIHNB KJCPBMMMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x55B2D20", Offset = "0x55B1920", VA = "0x1855B2D20")]
	static DGNLPMJNGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA5E330", Offset = "0xA5CF30", VA = "0x180A5E330")]
	private bool INFBEJKIOHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x55AE5C0", Offset = "0x55AD1C0", VA = "0x1855AE5C0")]
	private void EHPKBMMKIBK(IPEndPoint KECMCEFCMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x55B17E0", Offset = "0x55B03E0", VA = "0x1855B17E0")]
	private void LOPABLICGLH(IPEndPoint KECMCEFCMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x55AD810", Offset = "0x55AC410", VA = "0x1855AD810")]
	private bool CEEEELPGCKO(SocketException BJCOEJJDGCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x55ACFD0", Offset = "0x55ABBD0", VA = "0x1855ACFD0")]
	private void BGONOGJFNEA(IOEBKIDKJLE HGKFMHHLPJH, EndPoint MMEPMKAMIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x55B2460", Offset = "0x55B1060", VA = "0x1855B2460")]
	private void ONOOJOBFEFB(object KAADEKGDAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x55AFCA0", Offset = "0x55AE8A0", VA = "0x1855AFCA0")]
	public bool GJNOBIEAGDP(IPAddress MBPBHGMLCDF, IPAddress MKNMOGNLEHI, int IDHDCMJFMDO, bool CNICDHPGLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x55B1DB0", Offset = "0x55B09B0", VA = "0x1855B1DB0")]
	internal int NHKDMPGIIHG(IIFCKNAIHNB KJCPBMMMJFO, IPEndPoint DCGLMHPMIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x55B1E60", Offset = "0x55B0A60", VA = "0x1855B1E60")]
	internal int ONAMFMNDDNN(IIFCKNAIHNB KJCPBMMMJFO, IPEndPoint DCGLMHPMIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x55B1EA0", Offset = "0x55B0AA0", VA = "0x1855B1EA0")]
	internal int ONAMFMNDDNN(byte[] COECLHOAJJF, int ILKNGPHCOGM, int GFICJHOBPLH, IPEndPoint DCGLMHPMIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x55B10E0", Offset = "0x55AFCE0", VA = "0x1855B10E0")]
	internal void LKBIBMMGGKJ(bool NEFFDGDJGEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum FLGDIIAHHJN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class IIFCKNAIHNB
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int KGEBOEKGECK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] DFIDOIKIEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] CAFGJAIIBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int EDIMMLFINLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object ANHLIFNCFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public IIFCKNAIHNB DEPMFFDMOME;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FLGDIIAHHJN KDCGOEMAANE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x55BA930", Offset = "0x55B9530", VA = "0x1855BA930")]
		get
		{
			return default(FLGDIIAHHJN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x55BAE70", Offset = "0x55B9A70", VA = "0x1855BAE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte EEDHGJPFPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x55BAE10", Offset = "0x55B9A10", VA = "0x1855BAE10")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x55BAD90", Offset = "0x55B9990", VA = "0x1855BAD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort IKLDMPLCHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x55BA9A0", Offset = "0x55B95A0", VA = "0x1855BA9A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x55BA960", Offset = "0x55B9560", VA = "0x1855BA960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NNCPNKBEBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x55BAE40", Offset = "0x55B9A40", VA = "0x1855BAE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HHPIFOOKABB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x55BABA0", Offset = "0x55B97A0", VA = "0x1855BABA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x55BA900", Offset = "0x55B9500", VA = "0x1855BA900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort JIIIPJKJBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x55BAB40", Offset = "0x55B9740", VA = "0x1855BAB40")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x55BA8C0", Offset = "0x55B94C0", VA = "0x1855BA8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort MNIDLNDPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x55BABD0", Offset = "0x55B97D0", VA = "0x1855BABD0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x55BADD0", Offset = "0x55B99D0", VA = "0x1855BADD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort NMJGDGCDKKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x55BAD30", Offset = "0x55B9930", VA = "0x1855BAD30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x55BAA00", Offset = "0x55B9600", VA = "0x1855BAA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x55BAEE0", Offset = "0x55B9AE0", VA = "0x1855BAEE0")]
	static IIFCKNAIHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x55BAEB0", Offset = "0x55B9AB0", VA = "0x1855BAEB0")]
	public void PMBILEJEOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x55BB2D0", Offset = "0x55B9ED0", VA = "0x1855BB2D0")]
	public IIFCKNAIHNB(int JKNAAACFMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x55BB1C0", Offset = "0x55B9DC0", VA = "0x1855BB1C0")]
	public IIFCKNAIHNB(FLGDIIAHHJN FOGOAFCOGPF, int JKNAAACFMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x55BAAD0", Offset = "0x55B96D0", VA = "0x1855BAAD0")]
	public static int DILJEBINOBO(FLGDIIAHHJN FOGOAFCOGPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x55BAA40", Offset = "0x55B9640", VA = "0x1855BAA40")]
	public int DILJEBINOBO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x55BAC30", Offset = "0x55B9830", VA = "0x1855BAC30")]
	public bool FGNMCDPEGJL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum IBKMPLKAEKN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal enum GDFNMCGKOOM
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum IGDMHHKNCPI
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum HFCBJJKFKGB
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GHNKACMHPJC
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class PPMNLPAFOKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public IIFCKNAIHNB[] FHLALMCJBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int AJPPOKPHCGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int ACCIELJJALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte HHPIFOOKABB;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PPMNLPAFOKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void IJKOLAFGJMO(ulong HNFCLDMHDCJ, int BJICLDNGNJP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int BPLGFAALJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int PLCIAJDHPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int BLJKKBOMNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double DDOOJGKBHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int LNDDAGFKFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int GCEJBDEIOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int MADHAIJJAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch IBHOMCPAKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int FJCEJBDENCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long AKAABEPGIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object LHKAODGEENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal GHNKACMHPJC CEIGFFKOEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal GHNKACMHPJC LCCDPNPNNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<IIFCKNAIHNB> LGMAACPEPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<DOFKHEEBGMJ> PLIHLMPFFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly DOFKHEEBGMJ[] EEPHJJMEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int CAJFCCLGLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int AOKFHPPFOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool KDJNAKFEPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int HPEGKNKNDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int CBAPLIMNICK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int KDPJDLJHJJI = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int FJMCKHCPNCE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object IDDJPDDNPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int NIMKOINICFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, PPMNLPAFOKF> DMOMOLODMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> BBIOPGGCJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly IIFCKNAIHNB CEICKPCHPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int PKEGDBCBFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int ADDFDFDPOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint JOFAMEBIPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int JIGOMJIFCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int PEAFADJDMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long DBCCKOCECMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte KOOBGICMAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IBKMPLKAEKN EBFLDCBEKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private IIFCKNAIHNB DAGGPLHCCFA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int IFHCGHACIEO = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int PDEKNAPHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly IIFCKNAIHNB LLCGGKFPDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly IIFCKNAIHNB BDAKIFFOODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly IIFCKNAIHNB FJPHALGDPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly IIFCKNAIHNB CGFGMOKAKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private HDHMNELFHLI FKNLHEPGOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly DGNLPMJNGAJ NGEMCJIGBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int BIEADNMOJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object HPAAPHAOOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly NFGBLPEOAJJ CONMPDJPNAJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte OPCLJFCPPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA0530", Offset = "0xA9F130", VA = "0x180AA0530")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x55B7600", Offset = "0x55B6200", VA = "0x1855B7600")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint FKNJLJNCAOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8F41D0", Offset = "0x8F2DD0", VA = "0x1808F41D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public IBKMPLKAEKN KIKPBPLHPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1639070", Offset = "0x1637C70", VA = "0x181639070")]
		get
		{
			return default(IBKMPLKAEKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long CNOOLECIKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BB890", Offset = "0x7BA490", VA = "0x1807BB890")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JNNBOHLJBAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB6ECF0", Offset = "0xB6D8F0", VA = "0x180B6ECF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x14616D0", Offset = "0x14602D0", VA = "0x1814616D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int GEPCMPANFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x55B5DD0", Offset = "0x55B49D0", VA = "0x1855B5DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int NMONLJBPLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C01C0", Offset = "0x7BEDC0", VA = "0x1807C01C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double CGDLDEMBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1868A30", Offset = "0x1867630", VA = "0x181868A30")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IJKOLAFGJMO PDHPACAHJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x55B5C10", Offset = "0x55B4810", VA = "0x1855B5C10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x55B6480", Offset = "0x55B5080", VA = "0x1855B6480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55B8C80", Offset = "0x55B7880", VA = "0x1855B8C80")]
	internal GHNKACMHPJC(DGNLPMJNGAJ OABMGBACMAI, IPEndPoint DCGLMHPMIOA, int JPCJHDLLDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55B76B0", Offset = "0x55B62B0", VA = "0x1855B76B0")]
	internal void JHBINCFBENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55B6530", Offset = "0x55B5130", VA = "0x1855B6530")]
	internal void GJCGHPCKNID(IPEndPoint DKKNFGIMMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55B6BE0", Offset = "0x55B57E0", VA = "0x1855B6BE0")]
	internal void IECKFPFHBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55B8840", Offset = "0x55B7440", VA = "0x1855B8840")]
	private void NOKEBFGIFBN(int PINBPHCHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55B5260", Offset = "0x55B3E60", VA = "0x1855B5260")]
	private void APNBFCHLEOB(int DDFIFAKBKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55B8690", Offset = "0x55B7290", VA = "0x1855B8690")]
	private DOFKHEEBGMJ NNIJPPFADEK(byte NOBCGKJBAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55B8910", Offset = "0x55B7510", VA = "0x1855B8910")]
	internal GHNKACMHPJC(DGNLPMJNGAJ OABMGBACMAI, IPEndPoint DCGLMHPMIOA, int JPCJHDLLDBJ, byte IOOFPMGKPLM, GMOGDAOBKNF AOJNCJPFJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x55B8AA0", Offset = "0x55B76A0", VA = "0x1855B8AA0")]
	internal GHNKACMHPJC(DGNLPMJNGAJ OABMGBACMAI, KDLMIGMPBPD MLHMNLDOBPP, int JPCJHDLLDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x55B6560", Offset = "0x55B5160", VA = "0x1855B6560")]
	internal void GKNIDCCOMHI(NFLBHIBBHOA IKJIKNJCAME, byte[] KOMCCCIEHEA, int ILKNGPHCOGM, int GFICJHOBPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x55B6B60", Offset = "0x55B5760", VA = "0x1855B6B60")]
	internal bool IDMIAOPHFGG(MGGMJBHMIGO KJCPBMMMJFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x55B5DE0", Offset = "0x55B49E0", VA = "0x1855B5DE0")]
	public void EEHAOMFFLBP(byte[] KOMCCCIEHEA, int ILKNGPHCOGM, int GFICJHOBPLH, NNKGOPPFPDN JAIAHAGCBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x55B5F30", Offset = "0x55B4B30", VA = "0x1855B5F30")]
	private void EPMKJILPBNO(byte[] KOMCCCIEHEA, int ILKNGPHCOGM, int GFICJHOBPLH, byte BCBGAJELAEH, NNKGOPPFPDN LLJBLDAAIMJ, object GFPEKPHBLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x55B5CC0", Offset = "0x55B48C0", VA = "0x1855B5CC0")]
	public void CHAOLJIBKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x55B65B0", Offset = "0x55B51B0", VA = "0x1855B65B0")]
	internal IGDMHHKNCPI HFFPCBNCAEG(IIFCKNAIHNB KJCPBMMMJFO)
	{
		return default(IGDMHHKNCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x55B5D70", Offset = "0x55B4970", VA = "0x1855B5D70")]
	internal void CHBILODGODG(DOFKHEEBGMJ ODJDODAJDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x55B6690", Offset = "0x55B5290", VA = "0x1855B6690")]
	internal HFCBJJKFKGB IBDOIEDDAFC(byte[] KOMCCCIEHEA, int ILKNGPHCOGM, int GFICJHOBPLH, bool FAAGKOCIKOI)
	{
		return default(HFCBJJKFKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x55B7FA0", Offset = "0x55B6BA0", VA = "0x1855B7FA0")]
	private void LJJDLFHICHK(int FDBPMKDDOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x55B6C70", Offset = "0x55B5870", VA = "0x1855B6C70")]
	internal void IMGIOMPBBOK(NNKGOPPFPDN PLOLOAPJJIC, IIFCKNAIHNB HLHHCNMEOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B62D0", VA = "0x1855B76D0")]
	private void LAFHJIJDCJB(IIFCKNAIHNB KJCPBMMMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x55B7C20", Offset = "0x55B6820", VA = "0x1855B7C20")]
	private void LENNCJCKPAI(int HINGOJPJBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x55B69A0", Offset = "0x55B55A0", VA = "0x1855B69A0")]
	internal GDFNMCGKOOM ICDEOJNKACE(NFLBHIBBHOA BENOLFKGLOK)
	{
		return default(GDFNMCGKOOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x55B7FE0", Offset = "0x55B6BE0", VA = "0x1855B7FE0")]
	internal void NJPCGFBNHEM(IIFCKNAIHNB KJCPBMMMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x55B5E10", Offset = "0x55B4A10", VA = "0x1855B5E10")]
	private void EJDGPPOGLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x55B5090", Offset = "0x55B3C90", VA = "0x1855B5090")]
	internal void ABGNCLMLGCC(IIFCKNAIHNB KJCPBMMMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x55B52A0", Offset = "0x55B3EA0", VA = "0x1855B52A0")]
	internal void BBEBOIIGBMN(int HINGOJPJBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x55B5950", Offset = "0x55B4550", VA = "0x1855B5950")]
	internal void BOALJBKEPPL(IIFCKNAIHNB KJCPBMMMJFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class NFGBLPEOAJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long CMNPPEFDLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long FPMAODEHPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long HMNMKCKCGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long ADOBMLMOLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long HCCGOKNDJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long FMBBGKEMMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long KDBEOKPGCEM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long LJJLEBNFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x55BF760", Offset = "0x55BE360", VA = "0x1855BF760")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long HFNJICBBKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x55BF620", Offset = "0x55BE220", VA = "0x1855BF620")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LIKOPLBJGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x55BF710", Offset = "0x55BE310", VA = "0x1855BF710")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long FAOIDEIGCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x55BF7D0", Offset = "0x55BE3D0", VA = "0x1855BF7D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long HEAPCAFLIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x55BF8A0", Offset = "0x55BE4A0", VA = "0x1855BF8A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long BJDCBNGJHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x55BF7E0", Offset = "0x55BE3E0", VA = "0x1855BF7E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private HDHMNELFHLI GBGEHEOKBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3EC0", Offset = "0x1AC2AC0", VA = "0x181AC3EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double JDOLIBEEIED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x55BF820", Offset = "0x55BE420", VA = "0x1855BF820")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x55BF770", Offset = "0x55BE370", VA = "0x1855BF770")]
	public void KEPEANOIAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x55BF7F0", Offset = "0x55BE3F0", VA = "0x1855BF7F0")]
	public void NCAAJBEIAIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x55BF890", Offset = "0x55BE490", VA = "0x1855BF890")]
	public void PCIPFILIEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x55BF880", Offset = "0x55BE480", VA = "0x1855BF880")]
	public void OLONCJOOLDH(long PGHJCAGDBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x55BF750", Offset = "0x55BE350", VA = "0x1855BF750")]
	public void GLDCJJPOKII(long IKJGAAEJJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x55BF720", Offset = "0x55BE320", VA = "0x1855BF720")]
	public void GBNMENICIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x55BF6D0", Offset = "0x55BE2D0", VA = "0x1855BF6D0")]
	public void CLOEHFINNBD(long IMOMBLHFIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x55BF8B0", Offset = "0x55BE4B0", VA = "0x1855BF8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x55BF630", Offset = "0x55BE230", VA = "0x1855BF630")]
	public void BAFEAIAHIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NFGBLPEOAJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PLCIDCHFDEA
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> KPOOKPBNKML;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x55C0890", Offset = "0x55BF490", VA = "0x1855C0890")]
	public static IPEndPoint DJDPKHMCBEJ(string BPHFPMHKNJI, int IDHDCMJFMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x55C06C0", Offset = "0x55BF2C0", VA = "0x1855C06C0")]
	public static IPAddress ADDCGFOIEFK(string BPHFPMHKNJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x55C0630", Offset = "0x55BF230", VA = "0x1855C0630")]
	public static IPAddress ADDCGFOIEFK(string BPHFPMHKNJI, AddressFamily MNEMKCNCCPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x55C0AE0", Offset = "0x55BF6E0", VA = "0x1855C0AE0")]
	internal static int JKFDJMIKDPF(int MENKCHLGBFO, int MHNBGMEGFLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x29522B0", Offset = "0x2950EB0", VA = "0x1829522B0")]
	internal static T[] LBFJDNGHOON<T>(int MAJIECOCCAC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KNPPFCBBFOA : DOFKHEEBGMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct CPFJMHPCIIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private IIFCKNAIHNB LGBHEBEFHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long FPBMGPIJEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool NJIHCKBJMBF;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x55AC3C0", Offset = "0x55AAFC0", VA = "0x1855AC3C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x55AC3A0", Offset = "0x55AAFA0", VA = "0x1855AC3A0")]
		public void IKHOBAFCBDI(IIFCKNAIHNB KJCPBMMMJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x55AC2E0", Offset = "0x55AAEE0", VA = "0x1855AC2E0")]
		public bool BOPEHHNLDJG(long DBFOFDCBJON, GHNKACMHPJC MGOIHBMNDNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x55AC350", Offset = "0x55AAF50", VA = "0x1855AC350")]
		public bool GEDHBEKABPI(GHNKACMHPJC MGOIHBMNDNL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly IIFCKNAIHNB FCFIPAIIACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly CPFJMHPCIIP[] DJNFCLGGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly IIFCKNAIHNB[] FEINADEGKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] ENGNEGDGPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int IJFMDKNDMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int DJOMEAIDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int KIIHAOABAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int BKBNODIPEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool MIIGLKJCOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly NNKGOPPFPDN FCLJFDOKNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool EFAMNKJHIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int FGLCGHGNAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte MJHJHDJHIAL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x55BC570", Offset = "0x55BB170", VA = "0x1855BC570")]
	public KNPPFCBBFOA(GHNKACMHPJC MGOIHBMNDNL, bool AHHOBLOEEAL, byte JPCJHDLLDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x55BC1B0", Offset = "0x55BADB0", VA = "0x1855BC1B0")]
	private void OPLBMENFOHN(IIFCKNAIHNB KJCPBMMMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x55BB6A0", Offset = "0x55BA2A0", VA = "0x1855BB6A0", Slot = "4")]
	protected override bool EPJEODHDGDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x55BBB50", Offset = "0x55BA750", VA = "0x1855BBB50", Slot = "5")]
	public override bool NJPCGFBNHEM(IIFCKNAIHNB KJCPBMMMJFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MGPOCCGJDMJ : DOFKHEEBGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int FCMDCJIFLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort DJOMEAIDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool BGOKPMGGNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private IIFCKNAIHNB EMDIJKGDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly IIFCKNAIHNB BOGCAKGCFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool OIJCIPLOJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte MJHJHDJHIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long JJJBIJDNBKH;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x55BF4C0", Offset = "0x55BE0C0", VA = "0x1855BF4C0")]
	public MGPOCCGJDMJ(GHNKACMHPJC MGOIHBMNDNL, bool KEHJEGJMIAA, byte JPCJHDLLDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x55BED10", Offset = "0x55BD910", VA = "0x1855BED10", Slot = "4")]
	protected override bool EPJEODHDGDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x55BF1B0", Offset = "0x55BDDB0", VA = "0x1855BF1B0", Slot = "5")]
	public override bool NJPCGFBNHEM(IIFCKNAIHNB KJCPBMMMJFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IJAFHPMLFKG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct JPDGEPBJKFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong MDFAKDAADFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double LIIIKPJEOFB;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct MFIMFBFCMCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int MDIMDFGOEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float IPMKPKPJPAL;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x55AA960", Offset = "0x55A9560", VA = "0x1855AA960")]
	private static void PBJOIKCKBNL(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, ulong KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x55BB430", Offset = "0x55BA030", VA = "0x1855BB430")]
	private static void PBJOIKCKBNL(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, int KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x55BB360", Offset = "0x55B9F60", VA = "0x1855BB360")]
	public static void PBJOIKCKBNL(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, short KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x55BB340", Offset = "0x55B9F40", VA = "0x1855BB340")]
	public static void MEIGNIDEJDF(byte[] PJGIELDOKCN, int FAFMJOHFKBE, double BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x55BB3B0", Offset = "0x55B9FB0", VA = "0x1855BB3B0")]
	public static void MEIGNIDEJDF(byte[] PJGIELDOKCN, int FAFMJOHFKBE, float BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x55BB360", Offset = "0x55B9F60", VA = "0x1855BB360")]
	public static void MEIGNIDEJDF(byte[] PJGIELDOKCN, int FAFMJOHFKBE, short BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x55BB360", Offset = "0x55B9F60", VA = "0x1855BB360")]
	public static void MEIGNIDEJDF(byte[] PJGIELDOKCN, int FAFMJOHFKBE, ushort BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x55BB430", Offset = "0x55BA030", VA = "0x1855BB430")]
	public static void MEIGNIDEJDF(byte[] PJGIELDOKCN, int FAFMJOHFKBE, int BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x55BB430", Offset = "0x55BA030", VA = "0x1855BB430")]
	public static void MEIGNIDEJDF(byte[] PJGIELDOKCN, int FAFMJOHFKBE, uint BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x55BB3A0", Offset = "0x55B9FA0", VA = "0x1855BB3A0")]
	public static void MEIGNIDEJDF(byte[] PJGIELDOKCN, int FAFMJOHFKBE, long BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x55BB3A0", Offset = "0x55B9FA0", VA = "0x1855BB3A0")]
	public static void MEIGNIDEJDF(byte[] PJGIELDOKCN, int FAFMJOHFKBE, ulong BLKAHBIJBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FKMHLBCMGMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] GBNALPEDEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int NJEJPCPFKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int BEBECKFJCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int OHMMFBOKHBE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] CAFGJAIIBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int BJFBAECBHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x961750", Offset = "0x960350", VA = "0x180961750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int KGLFODPHKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x55B4C70", Offset = "0x55B3870", VA = "0x1855B4C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CEHEPAINHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1D15550", Offset = "0x1D14150", VA = "0x181D15550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PBKOBKFAJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x55B4720", Offset = "0x55B3320", VA = "0x1855B4720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x55B4AD0", Offset = "0x55B36D0", VA = "0x1855B4AD0")]
	public void JDCGDIHNOJL(byte[] KNENCIBJOEN, int OIAPMOHIBDO, int MLJENADJGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public FKMHLBCMGMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x55B4E50", Offset = "0x55B3A50", VA = "0x1855B4E50")]
	public FKMHLBCMGMM(byte[] KNENCIBJOEN, int OIAPMOHIBDO, int MLJENADJGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x55B4730", Offset = "0x55B3330", VA = "0x1855B4730")]
	public IPEndPoint FMNCMNNGAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x55B4660", Offset = "0x55B3260", VA = "0x1855B4660")]
	public byte DOBAJKEFKMC()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x55B4660", Offset = "0x55B3260", VA = "0x1855B4660")]
	public sbyte IIOMPBINEGE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x27C7B00", Offset = "0x27C6700", VA = "0x1827C7B00")]
	public T[] LNNBGCMIHPL<T>(ushort JKNAAACFMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x55B42A0", Offset = "0x55B2EA0", VA = "0x1855B42A0")]
	public bool[] AIBCEOGDCEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x55B44F0", Offset = "0x55B30F0", VA = "0x1855B44F0")]
	public ushort[] DCIGDJBAIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x55B4260", Offset = "0x55B2E60", VA = "0x1855B4260")]
	public short[] AEIDBBMJKAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x55B4400", Offset = "0x55B3000", VA = "0x1855B4400")]
	public int[] BKINDNLGNLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x55B46A0", Offset = "0x55B32A0", VA = "0x1855B46A0")]
	public uint[] EAEHGGLDIIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x55B4B80", Offset = "0x55B3780", VA = "0x1855B4B80")]
	public float[] LJMIIKONJLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x55B4E10", Offset = "0x55B3A10", VA = "0x1855B4E10")]
	public double[] PIBGFKCKBGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x55B44B0", Offset = "0x55B30B0", VA = "0x1855B44B0")]
	public long[] DAMJEPNHHCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x55B4BC0", Offset = "0x55B37C0", VA = "0x1855B4BC0")]
	public ulong[] LKEEMJEODAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x55B4530", Offset = "0x55B3130", VA = "0x1855B4530")]
	public string[] DKPGOHDNCCM(int ACKNMHOAGFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x55B43C0", Offset = "0x55B2FC0", VA = "0x1855B43C0")]
	public bool BCGPDGPABLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x55B4800", Offset = "0x55B3400", VA = "0x1855B4800")]
	public char FPBPOHKBDLF()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x55B4800", Offset = "0x55B3400", VA = "0x1855B4800")]
	public ushort NEGDEDHIDJK()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x55B4440", Offset = "0x55B3040", VA = "0x1855B4440")]
	public short CHNIJGLGCHO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x55B42E0", Offset = "0x55B2EE0", VA = "0x1855B42E0")]
	public long ANOECBMIADP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x55B4CF0", Offset = "0x55B38F0", VA = "0x1855B4CF0")]
	public ulong PCNDODLIBKM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x55B4B10", Offset = "0x55B3710", VA = "0x1855B4B10")]
	public int KLHFHEEAMFJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x55B4C80", Offset = "0x55B3880", VA = "0x1855B4C80")]
	public uint OLBHDABIFPP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x55B4350", Offset = "0x55B2F50", VA = "0x1855B4350")]
	public float BBGKPOAKHAP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x55B4DA0", Offset = "0x55B39A0", VA = "0x1855B4DA0")]
	public double PGDFNDLDJHM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x55B4890", Offset = "0x55B3490", VA = "0x1855B4890")]
	public string IPFDOEALKCI(int ONLOKNDIICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x55B4C00", Offset = "0x55B3800", VA = "0x1855B4C00")]
	public ArraySegment<byte> OIIBABNDDMP(int MAJIECOCCAC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x55B4D60", Offset = "0x55B3960", VA = "0x1855B4D60")]
	public sbyte[] PEGGHNICPPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x55B46E0", Offset = "0x55B32E0", VA = "0x1855B46E0")]
	public byte[] EEPOLMLHIBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x55B4870", Offset = "0x55B3470", VA = "0x1855B4870")]
	public void GEDHBEKABPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GMOGDAOBKNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] GBNALPEDEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int NJEJPCPFKHI;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int DELHCEOALJN = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool PMIOONNOEHK;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding HMLKFDLFMGM;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int KHFCAJPGING = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] HPHEICMMBMH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] EIIIJBECKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int AMCFPGDCENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B1560", Offset = "0x7B0160", VA = "0x1807B1560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x55B9E10", Offset = "0x55B8A10", VA = "0x1855B9E10")]
	public GMOGDAOBKNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x55B9E90", Offset = "0x55B8A90", VA = "0x1855B9E90")]
	public GMOGDAOBKNF(bool ODODJGNENMG, int NLJACJHMFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x55B9C70", Offset = "0x55B8870", VA = "0x1855B9C70")]
	public static GMOGDAOBKNF HHHDODMMOJC(string BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x55B9CE0", Offset = "0x55B88E0", VA = "0x1855B9CE0")]
	public void IOCBJHMLJHD(int GACFHCOMJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F1B0", Offset = "0x1D8DDB0", VA = "0x181D8F1B0")]
	public void KEPEANOIAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x55B96F0", Offset = "0x55B82F0", VA = "0x1855B96F0")]
	public void BPGCFBCFBHO(float BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x55B96A0", Offset = "0x55B82A0", VA = "0x1855B96A0")]
	public void BPGCFBCFBHO(double BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x55B97A0", Offset = "0x55B83A0", VA = "0x1855B97A0")]
	public void BPGCFBCFBHO(long BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x55B97A0", Offset = "0x55B83A0", VA = "0x1855B97A0")]
	public void BPGCFBCFBHO(ulong BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x55B9610", Offset = "0x55B8210", VA = "0x1855B9610")]
	public void BPGCFBCFBHO(int BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x55B9610", Offset = "0x55B8210", VA = "0x1855B9610")]
	public void BPGCFBCFBHO(uint BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x55B9850", Offset = "0x55B8450", VA = "0x1855B9850")]
	public void BPGCFBCFBHO(char BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x55B9850", Offset = "0x55B8450", VA = "0x1855B9850")]
	public void BPGCFBCFBHO(ushort BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x55B9850", Offset = "0x55B8450", VA = "0x1855B9850")]
	public void BPGCFBCFBHO(short BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x55B97F0", Offset = "0x55B83F0", VA = "0x1855B97F0")]
	public void BPGCFBCFBHO(sbyte BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x55B97F0", Offset = "0x55B83F0", VA = "0x1855B97F0")]
	public void BPGCFBCFBHO(byte BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x55B98C0", Offset = "0x55B84C0", VA = "0x1855B98C0")]
	public void BPGCFBCFBHO(byte[] KOMCCCIEHEA, int OIAPMOHIBDO, int GFICJHOBPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x55B9530", Offset = "0x55B8130", VA = "0x1855B9530")]
	public void EOCOMHPHLJE(sbyte[] KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x55B9530", Offset = "0x55B8130", VA = "0x1855B9530")]
	public void JGIIKBBPNNI(byte[] KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x55B9C10", Offset = "0x55B8810", VA = "0x1855B9C10")]
	public void BPGCFBCFBHO(bool BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x55B9450", Offset = "0x55B8050", VA = "0x1855B9450")]
	public void ABLBFAFPKPG(Array DDMGBNCKGKF, int MBBLJKIFFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x55B91C0", Offset = "0x55B7DC0", VA = "0x1855B91C0")]
	public void ABLBFAFPKPG(float[] BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x55B9370", Offset = "0x55B7F70", VA = "0x1855B9370")]
	public void ABLBFAFPKPG(double[] BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x55B9370", Offset = "0x55B7F70", VA = "0x1855B9370")]
	public void ABLBFAFPKPG(long[] BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x55B9370", Offset = "0x55B7F70", VA = "0x1855B9370")]
	public void ABLBFAFPKPG(ulong[] BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x55B91C0", Offset = "0x55B7DC0", VA = "0x1855B91C0")]
	public void ABLBFAFPKPG(int[] BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x55B91C0", Offset = "0x55B7DC0", VA = "0x1855B91C0")]
	public void ABLBFAFPKPG(uint[] BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x55B90E0", Offset = "0x55B7CE0", VA = "0x1855B90E0")]
	public void ABLBFAFPKPG(ushort[] BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x55B90E0", Offset = "0x55B7CE0", VA = "0x1855B90E0")]
	public void ABLBFAFPKPG(short[] BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x55B9530", Offset = "0x55B8130", VA = "0x1855B9530")]
	public void ABLBFAFPKPG(bool[] BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x55B92A0", Offset = "0x55B7EA0", VA = "0x1855B92A0")]
	public void ABLBFAFPKPG(string[] BLKAHBIJBJO, int KGPHCKFNHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x55B9930", Offset = "0x55B8530", VA = "0x1855B9930")]
	public void BPGCFBCFBHO(IPEndPoint KJIHBJJLPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x55B9790", Offset = "0x55B8390", VA = "0x1855B9790")]
	public void BPGCFBCFBHO(string BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x55B9A00", Offset = "0x55B8600", VA = "0x1855B9A00")]
	public void BPGCFBCFBHO(string BLKAHBIJBJO, int ONLOKNDIICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class AHLGHHEHMEG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class KKHAPKONBMH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong BIEADNMOJNF;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3B73430", Offset = "0x3B72030", VA = "0x183B73430")]
		static KKHAPKONBMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void BEFGIPADIFG(FKMHLBCMGMM ALHICDKDPIA, object GFPEKPHBLHB);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BNHJHDLFLHK<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AHLGHHEHMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BNHJHDLFLHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x47F7C80", Offset = "0x47F6880", VA = "0x1847F7C80")]
		internal void FCCHFHFDNKG(FKMHLBCMGMM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DKBBJFGGPML<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AHLGHHEHMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public DKBBJFGGPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5057E40", Offset = "0x5056A40", VA = "0x185057E40")]
		internal void FCCHFHFDNKG(FKMHLBCMGMM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly NBOIANIFEHD CIGFCAFBMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, BEFGIPADIFG> CDEDLPIJBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly GMOGDAOBKNF FMCOHEHFMDC;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x55AAC50", Offset = "0x55A9850", VA = "0x1855AAC50")]
	public AHLGHHEHMEG(int ACKNMHOAGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x25C87D0", Offset = "0x25C73D0", VA = "0x1825C87D0", Slot = "4")]
	protected virtual ulong JBALEJNDMKH<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x55AAA50", Offset = "0x55A9650", VA = "0x1855AAA50", Slot = "5")]
	protected virtual BEFGIPADIFG ANIOEPDJMNJ(FKMHLBCMGMM ALHICDKDPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C750", Offset = "0x2D9B350", VA = "0x182D9C750", Slot = "6")]
	protected virtual void MEOGLLDKGCK<T>(GMOGDAOBKNF EDIOJDLAEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x55AAB80", Offset = "0x55A9780", VA = "0x1855AAB80")]
	public void BKGPCNPFGFC(FKMHLBCMGMM ALHICDKDPIA, object GFPEKPHBLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C6C0", Offset = "0x2D9B2C0", VA = "0x182D9C6C0")]
	public void FGOOLPMNHAA<T>(GMOGDAOBKNF EDIOJDLAEAK, T KJCPBMMMJFO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x55AAC00", Offset = "0x55A9800", VA = "0x1855AAC00")]
	public void HGCONHLMFJD(FKMHLBCMGMM ALHICDKDPIA, object GFPEKPHBLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C540", Offset = "0x2D9B140", VA = "0x182D9C540")]
	public void DDPKPENDJNE<T>(Action<T> ALNCENPBIPG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C3C0", Offset = "0x2D9AFC0", VA = "0x182D9C3C0")]
	public void DDPKPENDJNE<T, TUserData>(Action<T, TUserData> ALNCENPBIPG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class FOEKGOCFMFK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x55B4250", Offset = "0x55B2E50", VA = "0x1855B4250")]
	public FOEKGOCFMFK(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PPEOOBJEJLD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x55C0BA0", Offset = "0x55BF7A0", VA = "0x1855C0BA0")]
	public PPEOOBJEJLD(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NBOIANIFEHD
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum EGGPDNPOFCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class LFIEAJJNKGO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public EGGPDNPOFCL LLGILHFCKAD;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3C09F30", Offset = "0x3C08B30", VA = "0x183C09F30", Slot = "4")]
		public virtual void IKHOBAFCBDI(MethodInfo AFINOLNJGNK, MethodInfo BNLJNAOKJFP, EGGPDNPOFCL CJEAJMFMNNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GCPCGHLLJHO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void JJHIEAGLPPK(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		protected LFIEAJJNKGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class CHONKCKFGML<TClass, TProperty> : LFIEAJJNKGO<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> FDEFOAHLMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> LMOFBAHOJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> NLNKFDAKOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> GKAMKGEBBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> ANAOEPKJECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> JJDPKCDKPAE;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4BBCFC0", Offset = "0x4BBBBC0", VA = "0x184BBCFC0", Slot = "7")]
		public override void LBBMOLHGMCO(TClass FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB65D0", Offset = "0x4BB51D0", VA = "0x184BB65D0", Slot = "8")]
		public override void ELLODNPOMDE(TClass FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4BB73D0", Offset = "0x4BB5FD0", VA = "0x184BB73D0", Slot = "9")]
		public override void GCPCGHLLJHO(TClass FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4BBCCB0", Offset = "0x4BBB8B0", VA = "0x184BBCCB0", Slot = "10")]
		public override void JJHIEAGLPPK(TClass FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4BB7830", Offset = "0x4BB6430", VA = "0x184BB7830")]
		protected TProperty[] HMFLECFEBCJ(TClass FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4BBCF50", Offset = "0x4BBBB50", VA = "0x184BBCF50")]
		protected TProperty[] KBHONBAMIBN(TClass FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4BB84B0", Offset = "0x4BB70B0", VA = "0x184BB84B0", Slot = "4")]
		public override void IKHOBAFCBDI(MethodInfo AFINOLNJGNK, MethodInfo BNLJNAOKJFP, EGGPDNPOFCL CJEAJMFMNNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3B65CF0", Offset = "0x3B648F0", VA = "0x183B65CF0")]
		protected CHONKCKFGML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class BEJBJBIBOCC<TClass, TProperty> : CHONKCKFGML<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void OGLMAILGDMC(FKMHLBCMGMM GOHLFLJBMIB, [Out] TProperty GJGNJJBMLCO);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void GAOICKHBKDB(GMOGDAOBKNF PCBNIKDPPAI, TProperty GJGNJJBMLCO);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4776700", Offset = "0x4775300", VA = "0x184776700", Slot = "5")]
		public override void KDGBPINGNFE(TClass FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4776610", Offset = "0x4775210", VA = "0x184776610", Slot = "6")]
		public override void FGOOLPMNHAA(TClass FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4776780", Offset = "0x4775380", VA = "0x184776780", Slot = "7")]
		public override void LBBMOLHGMCO(TClass FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4776500", Offset = "0x4775100", VA = "0x184776500", Slot = "8")]
		public override void ELLODNPOMDE(TClass FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x396CE80", Offset = "0x396BA80", VA = "0x18396CE80")]
		protected BEJBJBIBOCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class EDGAKEPHKJF<T> : CHONKCKFGML<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3307260", Offset = "0x3305E60", VA = "0x183307260", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3307200", Offset = "0x3305E00", VA = "0x183307200", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x33072D0", Offset = "0x3305ED0", VA = "0x1833072D0", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x33071A0", Offset = "0x3305DA0", VA = "0x1833071A0", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public EDGAKEPHKJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class LBJLEEPEDKH<T> : CHONKCKFGML<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA570", Offset = "0x3BF9170", VA = "0x183BFA570", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3307200", Offset = "0x3305E00", VA = "0x183307200", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA5E0", Offset = "0x3BF91E0", VA = "0x183BFA5E0", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x33071A0", Offset = "0x3305DA0", VA = "0x1833071A0", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public LBJLEEPEDKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class LLBCMHMBMJK<T> : CHONKCKFGML<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C30540", Offset = "0x3C2F140", VA = "0x183C30540", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C304E0", Offset = "0x3C2F0E0", VA = "0x183C304E0", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C305B0", Offset = "0x3C2F1B0", VA = "0x183C305B0", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C30480", Offset = "0x3C2F080", VA = "0x183C30480", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public LLBCMHMBMJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class NEGAJAKCLPC<T> : CHONKCKFGML<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB3C0", Offset = "0x3EE9FC0", VA = "0x183EEB3C0", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C304E0", Offset = "0x3C2F0E0", VA = "0x183C304E0", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB430", Offset = "0x3EEA030", VA = "0x183EEB430", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3C30480", Offset = "0x3C2F080", VA = "0x183C30480", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public NEGAJAKCLPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class PIPAIBIKNIN<T> : CHONKCKFGML<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4115CB0", Offset = "0x41148B0", VA = "0x184115CB0", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x40F9C10", Offset = "0x40F8810", VA = "0x1840F9C10", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4115D20", Offset = "0x4114920", VA = "0x184115D20", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x40F9BB0", Offset = "0x40F87B0", VA = "0x1840F9BB0", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public PIPAIBIKNIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class PBNJEEACHLE<T> : CHONKCKFGML<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x40F9C70", Offset = "0x40F8870", VA = "0x1840F9C70", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x40F9C10", Offset = "0x40F8810", VA = "0x1840F9C10", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x40F9CE0", Offset = "0x40F88E0", VA = "0x1840F9CE0", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x40F9BB0", Offset = "0x40F87B0", VA = "0x1840F9BB0", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public PBNJEEACHLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class AEHJMAGDOFN<T> : CHONKCKFGML<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3684700", Offset = "0x3683300", VA = "0x183684700", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x36846A0", Offset = "0x36832A0", VA = "0x1836846A0", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x37384A0", Offset = "0x37370A0", VA = "0x1837384A0", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3684640", Offset = "0x3683240", VA = "0x183684640", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public AEHJMAGDOFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class FEHJEBDJLKL<T> : CHONKCKFGML<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3684700", Offset = "0x3683300", VA = "0x183684700", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x36846A0", Offset = "0x36832A0", VA = "0x1836846A0", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3684770", Offset = "0x3683370", VA = "0x183684770", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3684640", Offset = "0x3683240", VA = "0x183684640", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public FEHJEBDJLKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class JOBLFMAEKPJ<T> : CHONKCKFGML<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3B2BA10", Offset = "0x3B2A610", VA = "0x183B2BA10", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B9B0", Offset = "0x3B2A5B0", VA = "0x183B2B9B0", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3B2BA80", Offset = "0x3B2A680", VA = "0x183B2BA80", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x33071A0", Offset = "0x3305DA0", VA = "0x1833071A0", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public JOBLFMAEKPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class BLHEKGGADBK<T> : CHONKCKFGML<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x47F0D10", Offset = "0x47EF910", VA = "0x1847F0D10", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x47F0CB0", Offset = "0x47EF8B0", VA = "0x1847F0CB0", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x47F0D80", Offset = "0x47EF980", VA = "0x1847F0D80", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x40F9BB0", Offset = "0x40F87B0", VA = "0x1840F9BB0", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public BLHEKGGADBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class ACDGBIAFKIO<T> : CHONKCKFGML<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3734510", Offset = "0x3733110", VA = "0x183734510", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x37344B0", Offset = "0x37330B0", VA = "0x1837344B0", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3734580", Offset = "0x3733180", VA = "0x183734580", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3684640", Offset = "0x3683240", VA = "0x183684640", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3307340", Offset = "0x3305F40", VA = "0x183307340")]
		public ACDGBIAFKIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class ODJABJCGPJP<T> : BEJBJBIBOCC<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3FFF060", Offset = "0x3FFDC60", VA = "0x183FFF060", Slot = "12")]
		protected override void GAOICKHBKDB(GMOGDAOBKNF PCBNIKDPPAI, char GJGNJJBMLCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3FFF090", Offset = "0x3FFDC90", VA = "0x183FFF090", Slot = "11")]
		protected override void OGLMAILGDMC(FKMHLBCMGMM GOHLFLJBMIB, [Out] char GJGNJJBMLCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x388D1A0", Offset = "0x388BDA0", VA = "0x18388D1A0")]
		public ODJABJCGPJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class DLLKOJCKGEA<T> : BEJBJBIBOCC<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x505DC40", Offset = "0x505C840", VA = "0x18505DC40", Slot = "12")]
		protected override void GAOICKHBKDB(GMOGDAOBKNF PCBNIKDPPAI, IPEndPoint GJGNJJBMLCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x505DC70", Offset = "0x505C870", VA = "0x18505DC70", Slot = "11")]
		protected override void OGLMAILGDMC(FKMHLBCMGMM GOHLFLJBMIB, [Out] IPEndPoint GJGNJJBMLCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x388D1A0", Offset = "0x388BDA0", VA = "0x18388D1A0")]
		public DLLKOJCKGEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class KHNJKOOBNHL<T> : CHONKCKFGML<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int LLHHKAJFFLL;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3B71FC0", Offset = "0x3B70BC0", VA = "0x183B71FC0")]
		public KHNJKOOBNHL(int ONLOKNDIICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3B71EE0", Offset = "0x3B70AE0", VA = "0x183B71EE0", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3B71E70", Offset = "0x3B70A70", VA = "0x183B71E70", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3B71F50", Offset = "0x3B70B50", VA = "0x183B71F50", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B71E00", Offset = "0x3B70A00", VA = "0x183B71E00", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class FNEDGHHENLD<T> : LFIEAJJNKGO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo KDCGOEMAANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type PLHIMJHAGDB;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x36914A0", Offset = "0x36900A0", VA = "0x1836914A0")]
		public FNEDGHHENLD(PropertyInfo FOGOAFCOGPF, Type MHKDNNGNLAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3691380", Offset = "0x368FF80", VA = "0x183691380", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3691210", Offset = "0x368FE10", VA = "0x183691210", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3691440", Offset = "0x3690040", VA = "0x183691440", Slot = "7")]
		public override void LBBMOLHGMCO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x36911B0", Offset = "0x368FDB0", VA = "0x1836911B0", Slot = "8")]
		public override void ELLODNPOMDE(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x36912C0", Offset = "0x368FEC0", VA = "0x1836912C0", Slot = "9")]
		public override void GCPCGHLLJHO(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3691320", Offset = "0x368FF20", VA = "0x183691320", Slot = "10")]
		public override void JJHIEAGLPPK(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class FHICFLGBOBA<T> : FNEDGHHENLD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3686700", Offset = "0x3685300", VA = "0x183686700")]
		public FHICFLGBOBA(PropertyInfo FOGOAFCOGPF, Type MHKDNNGNLAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x36890F0", Offset = "0x3687CF0", VA = "0x1836890F0", Slot = "5")]
		public override void KDGBPINGNFE(T FBNFHFELLOM, FKMHLBCMGMM GOHLFLJBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3689040", Offset = "0x3687C40", VA = "0x183689040", Slot = "6")]
		public override void FGOOLPMNHAA(T FBNFHFELLOM, GMOGDAOBKNF PCBNIKDPPAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class IAEEJLAKLFB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static IAEEJLAKLFB<T> EJGFFMEDDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly LFIEAJJNKGO<T>[] IFMCAPNJJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int HOILMNEDODN;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3923B90", Offset = "0x3922790", VA = "0x183923B90")]
		public IAEEJLAKLFB(List<LFIEAJJNKGO<T>> ILHECBGIMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3923A30", Offset = "0x3922630", VA = "0x183923A30")]
		public void FGOOLPMNHAA(T OGGNGHKHHGI, GMOGDAOBKNF EDIOJDLAEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3923AE0", Offset = "0x39226E0", VA = "0x183923AE0")]
		public void KDGBPINGNFE(T OGGNGHKHHGI, FKMHLBCMGMM ALHICDKDPIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class HNOJCADKNKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract LFIEAJJNKGO<T> CPPPHMALPOD<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private GMOGDAOBKNF MCIMGEKGBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int PDNMGFFPHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, HNOJCADKNKH> NMIANFBFKDA;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x55BF580", Offset = "0x55BE180", VA = "0x1855BF580")]
	public NBOIANIFEHD(int ACKNMHOAGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2906FE0", Offset = "0x2905BE0", VA = "0x182906FE0")]
	private IAEEJLAKLFB<T> FGCMGPFNGJC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2597250", Offset = "0x2595E50", VA = "0x182597250")]
	public void FAEDNEGPAEK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2906F60", Offset = "0x2905B60", VA = "0x182906F60")]
	public bool DPCADENMEMJ<T>(FKMHLBCMGMM ALHICDKDPIA, T PMKKKDOAOBE) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2907ED0", Offset = "0x2906AD0", VA = "0x182907ED0")]
	public void GAPNIKJAJOO<T>(GMOGDAOBKNF EDIOJDLAEAK, T OGGNGHKHHGI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class AJMKDANDLFC
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime DLJGJAMHKPG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] BKNDHKLLILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public MNJBNBKAHPI EPCEANHMIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x55ABB80", Offset = "0x55AA780", VA = "0x1855ABB80")]
		get
		{
			return default(MNJBNBKAHPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int PHAGNKJAIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x55ABD00", Offset = "0x55AA900", VA = "0x1855ABD00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x55ABB40", Offset = "0x55AA740", VA = "0x1855ABB40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public JMOFMCBNHKE EAEGIAFCPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x55AB740", Offset = "0x55AA340", VA = "0x1855AB740")]
		get
		{
			return default(JMOFMCBNHKE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x55ABC40", Offset = "0x55AA840", VA = "0x1855ABC40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int IOJLJBBIKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x55AB480", Offset = "0x55AA080", VA = "0x1855AB480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint PMMAMFAAODN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x55ABC80", Offset = "0x55AA880", VA = "0x1855ABC80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? OLBDBLHANIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x55AADD0", Offset = "0x55A99D0", VA = "0x1855AADD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? KEIJJHNLENL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x55AAE00", Offset = "0x55A9A00", VA = "0x1855AAE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? OOLALNBEFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x55AB450", Offset = "0x55AA050", VA = "0x1855AB450")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x55AB4B0", Offset = "0x55AA0B0", VA = "0x1855AB4B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? LMLBMFGCGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xADE5B0", Offset = "0xADD1B0", VA = "0x180ADE5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9153C0", Offset = "0x913FC0", VA = "0x1809153C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x55ABE40", Offset = "0x55AAA40", VA = "0x1855ABE40")]
	public AJMKDANDLFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x55ABD90", Offset = "0x55AA990", VA = "0x1855ABD90")]
	internal AJMKDANDLFC(byte[] PJGIELDOKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x55AB130", Offset = "0x55A9D30", VA = "0x1855AB130")]
	public static AJMKDANDLFC EFIBJAHNPHG(byte[] PJGIELDOKCN, DateTime MBGGBOJHHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x55AB770", Offset = "0x55AA370", VA = "0x1855AB770")]
	internal void LLOBMNIPAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x55AAE30", Offset = "0x55A9A30", VA = "0x1855AAE30")]
	private void CCLDANDFDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x55AB250", Offset = "0x55A9E50", VA = "0x1855AB250")]
	private DateTime? EJKHDNFBBBD(int OIAPMOHIBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x55AB970", Offset = "0x55AA570", VA = "0x1855AB970")]
	private void MECAHDJJADA(int OIAPMOHIBDO, DateTime? BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x55AB060", Offset = "0x55A9C60", VA = "0x1855AB060")]
	private ulong DKPEOCCFLBH(int OIAPMOHIBDO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x55AB680", Offset = "0x55AA280", VA = "0x1855AB680")]
	private void KACJJNOHJJI(int OIAPMOHIBDO, ulong BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x55ABBB0", Offset = "0x55AA7B0", VA = "0x1855ABBB0")]
	private uint MOPINBFOOLH(int OIAPMOHIBDO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x548D510", Offset = "0x548C110", VA = "0x18548D510")]
	private static uint DJHGFCDNMMJ(uint KLNIMOGOBLK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x55AB000", Offset = "0x55A9C00", VA = "0x1855AB000")]
	private static ulong DJHGFCDNMMJ(ulong KLNIMOGOBLK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum MNJBNBKAHPI
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum JMOFMCBNHKE
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class NGPNICOMMGB
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int JPPEPGJOEGM = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int JOJKDIBCFJJ = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int CNHPCHCGILK = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint NAPMEDGPHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int AICKOEEFPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int EFDDLGFKOHC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MHJNDHMCBEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x55C01B0", Offset = "0x55BEDB0", VA = "0x1855C01B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x55C00C0", Offset = "0x55BECC0", VA = "0x1855C00C0")]
	public bool EEHAOMFFLBP(IOEBKIDKJLE HGKFMHHLPJH, int EAKAKFEGLBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class HAECFKAINNA : IOEBKIDKJLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket HGKFMHHLPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly DGNLPMJNGAJ OABMGBACMAI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short GABAPEPOHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x55B9FB0", Offset = "0x55B8BB0", VA = "0x1855B9FB0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BGOHMCPJIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x55B9FD0", Offset = "0x55B8BD0", VA = "0x1855B9FD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint KNIAGICJPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x55B9F70", Offset = "0x55B8B70", VA = "0x1855B9F70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily HJLICMJIFAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BEAAB0", Offset = "0x3BE96B0", VA = "0x183BEAAB0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x55BA6A0", Offset = "0x55B92A0", VA = "0x1855BA6A0")]
	public HAECFKAINNA(AddressFamily MNEMKCNCCPP, DGNLPMJNGAJ OABMGBACMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x55B9FF0", Offset = "0x55B8BF0", VA = "0x1855B9FF0", Slot = "8")]
	public bool MOGPKCMDGLN(IPEndPoint KJIHBJJLPNL, CDBJJLLFGAP JAEFDOOJOHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x55B9F30", Offset = "0x55B8B30", VA = "0x1855B9F30", Slot = "9")]
	public int BFPDEGPEKIC(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, int JKNAAACFMKJ, IPEndPoint DCGLMHPMIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x55BA5B0", Offset = "0x55B91B0", VA = "0x1855BA5B0", Slot = "10")]
	public int NIBIDCEHIKI(byte[] KLIMJJKAHFF, EndPoint PFGPDLNOCNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x55B9F90", Offset = "0x55B8B90", VA = "0x1855B9F90", Slot = "11")]
	public void GNMFECOHKKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface IOEBKIDKJLE
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short GABAPEPOHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int BGOHMCPJIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint KNIAGICJPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily HJLICMJIFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MOGPKCMDGLN(IPEndPoint KJIHBJJLPNL, CDBJJLLFGAP JAEFDOOJOHP);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int BFPDEGPEKIC(byte[] KLIMJJKAHFF, int OIAPMOHIBDO, int JKNAAACFMKJ, IPEndPoint DCGLMHPMIOA);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NIBIDCEHIKI(byte[] KLIMJJKAHFF, EndPoint DCGLMHPMIOA);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GNMFECOHKKN();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct GFIFCNOGPHE : IEquatable<GFIFCNOGPHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long IOFKEANBHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long PFIBBEKIMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long JAOMOBJDLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int KLBANPGFLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int LGBLEOLELNM;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x55B4FA0", Offset = "0x55B3BA0", VA = "0x1855B4FA0")]
	public GFIFCNOGPHE(byte[] LPBKFPDBJBG, int BEJCOLIGFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7D8EB0", Offset = "0x7D7AB0", VA = "0x1807D8EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x55B4F60", Offset = "0x55B3B60", VA = "0x1855B4F60", Slot = "4")]
	public bool Equals(GFIFCNOGPHE NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x55B4EB0", Offset = "0x55B3AB0", VA = "0x1855B4EB0", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class AFCMONOGBNH : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] FGDEEFEJCEA;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class FCKCGDPKPKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int IOJHGKLEKMO;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
	protected FCKCGDPKPKG(int JGFBEGDNEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OMILOCPFADA(IPEndPoint KJIHBJJLPNL, byte[] KOMCCCIEHEA, int OIAPMOHIBDO, int GFICJHOBPLH);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void KGFGIOMCENH(IPEndPoint KJIHBJJLPNL, byte[] KOMCCCIEHEA, int OIAPMOHIBDO, int GFICJHOBPLH);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EOPHAJDIOHJ : FCKCGDPKPKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider IEMJMKLPLAI;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator JFEBJLJLPNL;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x55B4230", Offset = "0x55B2E30", VA = "0x1855B4230")]
	public EOPHAJDIOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x55B35F0", Offset = "0x55B21F0", VA = "0x1855B35F0")]
	public void CJJMDELEFOD(IPEndPoint KJIHBJJLPNL, byte[] CGGNJKGENIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x55B3C60", Offset = "0x55B2860", VA = "0x1855B3C60")]
	public void MLPDFMKPDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x55B3BD0", Offset = "0x55B27D0", VA = "0x1855B3BD0")]
	private byte[] LPIBPBNPPFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x55B3D40", Offset = "0x55B2940", VA = "0x1855B3D40", Slot = "4")]
	public override void OMILOCPFADA(IPEndPoint KJIHBJJLPNL, byte[] KOMCCCIEHEA, int OIAPMOHIBDO, int GFICJHOBPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x55B3830", Offset = "0x55B2430", VA = "0x1855B3830", Slot = "5")]
	public override void KGFGIOMCENH(IPEndPoint KJIHBJJLPNL, byte[] KOMCCCIEHEA, int OIAPMOHIBDO, int GFICJHOBPLH)
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
