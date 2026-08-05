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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, FDAODOLCIKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum PIIMJDBOAND
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
		private NetworkManager NALAKLLKMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, PCFEONONJMA> JNCPNHPHEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LHINCEBFGAE GMEGIBMEDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] OLONLMABHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PIIMJDBOAND MCANNMHNOEB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong EMGPBGCNJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool AJDLECKNMPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5CFA120", Offset = "0x5CF8B20", VA = "0x185CFA120", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9680", Offset = "0x5CF8080", VA = "0x185CF9680")]
		public void RecRoom_SetEncryptionInfo(ulong MNEGAEOGJMK, byte[] LDDEKIBHION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9660", Offset = "0x5CF8060", VA = "0x185CF9660")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CF93F0", Offset = "0x5CF7DF0", VA = "0x185CF93F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CFA020", Offset = "0x5CF8A20", VA = "0x185CFA020")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9820", Offset = "0x5CF8220", VA = "0x185CF9820", Slot = "6")]
		public override void Send(ulong MBFLFICGBAG, ArraySegment<byte> EEOBDBMOHPL, NetworkDelivery DLMOJOPCJLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9620", Offset = "0x5CF8020", VA = "0x185CF9620", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong MBFLFICGBAG, [Out] ArraySegment<byte> NBBCEJPPPCO, [Out] float JPGEJHEJMDB)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9B10", Offset = "0x5CF8510", VA = "0x185CF9B10", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9F40", Offset = "0x5CF8940", VA = "0x185CF9F40", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8D20", Offset = "0x5CF7720", VA = "0x185CF8D20", Slot = "10")]
		public override void DisconnectRemoteClient(ulong MBFLFICGBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8BD0", Offset = "0x5CF75D0", VA = "0x185CF8BD0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8E90", Offset = "0x5CF7890", VA = "0x185CF8E90", Slot = "12")]
		public override ulong GetCurrentRtt(ulong MBFLFICGBAG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9AA0", Offset = "0x5CF84A0", VA = "0x185CF9AA0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9120", Offset = "0x5CF7B20", VA = "0x185CF9120", Slot = "14")]
		public override void Initialize([Optional] NetworkManager NALAKLLKMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9050", Offset = "0x5CF7A50", VA = "0x185CF9050")]
		private BCBPMHJHGJO ILCOGEDOPJC(NetworkDelivery ADDOHDGDFOD)
		{
			return default(BCBPMHJHGJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8F90", Offset = "0x5CF7990", VA = "0x185CF8F90", Slot = "15")]
		private void IGNFIGFBJCE(PCFEONONJMA KNHDIEBDFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CF94E0", Offset = "0x5CF7EE0", VA = "0x185CF94E0", Slot = "16")]
		private void PCGFHEHEMEB(PCFEONONJMA KNHDIEBDFFN, HDMJJOMFJJF LPJIHDHPAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "17")]
		private void AKOPEHNPMDN(IPEndPoint BILAFPOFCHL, SocketError LNJJBOKNMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CF89C0", Offset = "0x5CF73C0", VA = "0x185CF89C0", Slot = "18")]
		private void DDCCFHJHFNM(PCFEONONJMA KNHDIEBDFFN, OCNOOOEAALH DGAMLJBEAIK, byte LHOMMMHLFNM, BCBPMHJHGJO OODJIOMAMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9310", Offset = "0x5CF7D10", VA = "0x185CF9310")]
		private void LECLFMMHDKI(int BKEGNEKBPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "19")]
		private void HKFDOCOHIPJ(IPEndPoint IPBPKKCDEIC, OCNOOOEAALH DGAMLJBEAIK, OOHCMENCMJE DALKHOJAJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "20")]
		private void NBNDFEBDKCI(PCFEONONJMA KNHDIEBDFFN, int KHFILPONJHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8F30", Offset = "0x5CF7930", VA = "0x185CF8F30", Slot = "21")]
		private void HGODJPCIOJA(IDMOFBADEMG BJLMEIJMPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF92E0", Offset = "0x5CF7CE0", VA = "0x185CF92E0")]
		private ulong JGJCOGPHCMG(PCFEONONJMA KNHDIEBDFFN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF89A0", Offset = "0x5CF73A0", VA = "0x185CF89A0")]
		private static int ACNOPJJHCOE(float PBLACMAEFME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CFA040", Offset = "0x5CF8A40", VA = "0x185CFA040")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class ABMOMLFNBOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly PCFEONONJMA DNAHGDDPMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<HDEPEHPEMBJ> CLEHHPBHCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int PLKBCFAEMHJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE92A0", Offset = "0x5CE7CA0", VA = "0x185CE92A0")]
	protected ABMOMLFNBOL(PCFEONONJMA KNHDIEBDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE91C0", Offset = "0x5CE7BC0", VA = "0x185CE91C0")]
	public void IEFENDGCEEC(HDEPEHPEMBJ OCFPBCNHKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9220", Offset = "0x5CE7C20", VA = "0x185CE9220")]
	protected void PILOAEFOEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9180", Offset = "0x5CE7B80", VA = "0x185CE9180")]
	public bool EIDANHDMLIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool BILHFBFEGFE();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool MJINIEHDOIA(HDEPEHPEMBJ OCFPBCNHKDK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum INKBNHDKNEE
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
public class IDMOFBADEMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LHINCEBFGAE JAMJDFBCBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int JDFICENMMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal LMGONFMAMJM FBIPOKOMKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint NAIPPBKIPND;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal INKBNHDKNEE CFEOOMKAPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x874E20", Offset = "0x873820", VA = "0x180874E20")]
		[CompilerGenerated]
		get
		{
			return default(INKBNHDKNEE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC6230", Offset = "0xAC4C30", VA = "0x180AC6230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF060", Offset = "0x5CEDA60", VA = "0x185CEF060")]
	internal void JHBFMHANBPK(LMGONFMAMJM MPNFMCECPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF030", Offset = "0x5CEDA30", VA = "0x185CEF030")]
	private bool DGBAFEKKCOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF0C0", Offset = "0x5CEDAC0", VA = "0x185CEF0C0")]
	internal IDMOFBADEMG(IPEndPoint IPBPKKCDEIC, LMGONFMAMJM HJHFPMHCNKG, LHINCEBFGAE EHOKAKKEOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEFD0", Offset = "0x5CED9D0", VA = "0x185CEEFD0")]
	public PCFEONONJMA CJBNILJGJCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OOHCMENCMJE
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum PMOGEAOCLFE
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
public struct HDMJJOMFJJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public PMOGEAOCLFE KIANJPGADMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError ONFKFMBEFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OCNOOOEAALH AMJOMLHHBKI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FDAODOLCIKI
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFKCFOCJAOL(PCFEONONJMA KNHDIEBDFFN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBJHPNMMDPP(PCFEONONJMA KNHDIEBDFFN, HDMJJOMFJJF LPJIHDHPAIM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLMGEMIMALF(IPEndPoint BILAFPOFCHL, SocketError LNJJBOKNMIO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAENMEGGODA(PCFEONONJMA KNHDIEBDFFN, OCNOOOEAALH DGAMLJBEAIK, byte LHOMMMHLFNM, BCBPMHJHGJO OODJIOMAMFN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NAEDIOCOHOM(IPEndPoint IPBPKKCDEIC, OCNOOOEAALH DGAMLJBEAIK, OOHCMENCMJE DALKHOJAJJD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLCPPLLKAFP(PCFEONONJMA KNHDIEBDFFN, int KHFILPONJHP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MJPMHLJHPNO(IDMOFBADEMG BJLMEIJMPBN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PDCJBMAJAFN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHGMEDBDJEM(PCFEONONJMA KNHDIEBDFFN, object KFFELFHDPEN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LAKFHMKIDGD
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKCEAFPDMKJ(CGFJHNNCECM OCFPBCNHKDK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JECBJIGDGON
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHBMMAJCFCC(PCFEONONJMA KNHDIEBDFFN, IPEndPoint CKLNPOIJJON);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LMGONFMAMJM
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int NDLBMJJABCB = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long AGLILOEKPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte CCKMEFEAHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] PDMFHJHJFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly KOMLIFNACNM MAOHOGCCNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int FHKBMMBJIBO;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CF88D0", Offset = "0x5CF72D0", VA = "0x185CF88D0")]
	private LMGONFMAMJM(long DHPGFIPALCH, byte BLLHLFBENIP, int IDEOIAGJPJE, byte[] ACAIJDBCPHK, KOMLIFNACNM EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8650", Offset = "0x5CF7050", VA = "0x185CF8650")]
	public static int NAMAIEPICKO(HDEPEHPEMBJ OCFPBCNHKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CF86B0", Offset = "0x5CF70B0", VA = "0x185CF86B0")]
	public static LMGONFMAMJM OCBKDLLODHD(HDEPEHPEMBJ OCFPBCNHKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8470", Offset = "0x5CF6E70", VA = "0x185CF8470")]
	public static HDEPEHPEMBJ EGLAIJJJHOJ(JCIOBEOLKNM DPMPHFMNOLO, SocketAddress IMBEHFDOIDH, long LOAHBELGNBO, int IDEOIAGJPJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HCBNIPPMDMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long AGLILOEKPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte CCKMEFEAHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int FHKBMMBJIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool JGFBJEGJKJH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE500", Offset = "0x5CECF00", VA = "0x185CEE500")]
	private HCBNIPPMDMB(long DHPGFIPALCH, byte BLLHLFBENIP, int AKPMIOKNPLH, bool PNKPPCDOGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE3B0", Offset = "0x5CECDB0", VA = "0x185CEE3B0")]
	public static HCBNIPPMDMB OCBKDLLODHD(HDEPEHPEMBJ OCFPBCNHKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE1C0", Offset = "0x5CECBC0", VA = "0x185CEE1C0")]
	public static HDEPEHPEMBJ EGLAIJJJHOJ(long LOAHBELGNBO, byte LNFLPIEFDDL, int LGAGFJBJIFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE2B0", Offset = "0x5CECCB0", VA = "0x185CEE2B0")]
	public static HDEPEHPEMBJ FBNJJDHAOOM(PCFEONONJMA KNHDIEBDFFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum APKPBPNMDOA
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KKMKJLBHHCA
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKFABKPHKMF(IPEndPoint PCODMBGOEHF, IPEndPoint IPBPKKCDEIC, string JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJAPHGCOAEL(IPEndPoint NPFEPPBNLIB, APKPBPNMDOA ADDOHDGDFOD, string JCIFCENKMKP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class AEGOAAJFKAC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct AALNHKMMBEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint NFBHDKFDOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint NAIPPBKIPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string JEHCHCJLNHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct BHFEIFPKKAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint JPCIKLMKALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public APKPBPNMDOA PNFBJLDEHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string JEHCHCJLNHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class GMABPDDGCMD
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint ADEHNEFCOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string JEHCHCJLNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GMABPDDGCMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class HDJDDBFODKD
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint ADEHNEFCOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint GNCOJAGMLIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string JEHCHCJLNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HDJDDBFODKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class MAEKKPAOPNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JEHCHCJLNHB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HDBLIMHBDEN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x915D70", Offset = "0x914770", VA = "0x180915D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x85AA60", Offset = "0x859460", VA = "0x18085AA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MAEKKPAOPNC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LHINCEBFGAE HFINMFKIOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<AALNHKMMBEJ> LKFLHFFEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<BHFEIFPKKAA> CAOOOMCODJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly KOMLIFNACNM EGFHEEAINBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JCIOBEOLKNM CPJILBJJGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly BIOBBLMOKGK FCFAFENPINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private KKMKJLBHHCA KKBNCHCIOKH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int LLDOBKIEPMP = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool EKEDFODOALF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9910", Offset = "0x5CE8310", VA = "0x185CE9910")]
	internal AEGOAAJFKAC(LHINCEBFGAE ABODMHMOFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE94D0", Offset = "0x5CE7ED0", VA = "0x185CE94D0")]
	internal void EIIIPMNOKDI(IPEndPoint FNJPBDDPBEP, HDEPEHPEMBJ OCFPBCNHKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x31D65D0", Offset = "0x31D4FD0", VA = "0x1831D65D0")]
	private void NCADDMBHPKC<T>(T OCFPBCNHKDK, IPEndPoint PIBCCEDJCCL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9630", Offset = "0x5CE8030", VA = "0x185CE9630")]
	private void OKFABKPHKMF(GMABPDDGCMD OHBODFBAPCP, IPEndPoint FNJPBDDPBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CE97B0", Offset = "0x5CE81B0", VA = "0x185CE97B0")]
	private void PEMCAPGPNBK(HDJDDBFODKD OHBODFBAPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9340", Offset = "0x5CE7D40", VA = "0x185CE9340")]
	private void BJAIGMGIDPL(MAEKKPAOPNC OHBODFBAPCP, IPEndPoint FNJPBDDPBEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BCBPMHJHGJO : byte
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
public enum MKEGCLBNFNC : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FFPHELLCFBL
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] KPEJFPOEGCE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int FKIOMEFBGML;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int IPOPHDDNBAP;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ENOJCLEGBLL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC2F0", Offset = "0x5CEACF0", VA = "0x185CEC2F0")]
	public ENOJCLEGBLL(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MBJPOPOFJJJ : ENOJCLEGBLL
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC2F0", Offset = "0x5CEACF0", VA = "0x185CEC2F0")]
	public MBJPOPOFJJJ(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum ACBCCIKBENH
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
public interface FEOEHLOIBMG
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDDCMIPANIA(ACBCCIKBENH KIIBEDOPJOG, string OHOJCGMAAGM, params object[] BKANBMHGIEE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class ECHKPPPLLCC
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static FEOEHLOIBMG BGCJBFOAHHO;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object CAJKOGNGNOO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBF10", Offset = "0x5CEA910", VA = "0x185CEBF10")]
	private static void KLBEPOFFJNA(ACBCCIKBENH FDNDFCMKAHG, string OHOJCGMAAGM, params object[] BKANBMHGIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBDF0", Offset = "0x5CEA7F0", VA = "0x185CEBDF0")]
	internal static void GOJAAFDIHBF(string OHOJCGMAAGM, params object[] BKANBMHGIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBE50", Offset = "0x5CEA850", VA = "0x185CEBE50")]
	internal static void HNPPEEBKCAH(string OHOJCGMAAGM, params object[] BKANBMHGIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBEB0", Offset = "0x5CEA8B0", VA = "0x185CEBEB0")]
	internal static void JPGFEGAMNJI(string OHOJCGMAAGM, params object[] BKANBMHGIEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HBPOMBPNDAI
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OCNOOOEAALH : KOMLIFNACNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HDEPEHPEMBJ OGOMHOFCCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LHINCEBFGAE EDDHMHEAMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GIEADFMDGEB APEDAOLDOKB;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA3C0", Offset = "0x5CF8DC0", VA = "0x185CFA3C0")]
	internal OCNOOOEAALH(LHINCEBFGAE KNCHPAAMIFB, GIEADFMDGEB JHEBABABGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA320", Offset = "0x5CF8D20", VA = "0x185CFA320")]
	internal void HAOJKPBJENB(HDEPEHPEMBJ OCFPBCNHKDK, int BFNBOCNIBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA2A0", Offset = "0x5CF8CA0", VA = "0x185CFA2A0")]
	internal void DJKAMNLBNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA390", Offset = "0x5CF8D90", VA = "0x185CFA390")]
	public void JHKPGBCEFKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class GIEADFMDGEB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum BIHOFOPGEAH
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
	public GIEADFMDGEB FIFIAJBOHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public BIHOFOPGEAH PNFBJLDEHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public PCFEONONJMA DNAHGDDPMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint NAIPPBKIPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object ABEEAMLMKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int ONFKFJLNPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError HHKEHGACGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public PMOGEAOCLFE GLGHIGINDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IDMOFBADEMG CGAKNBIOMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public BCBPMHJHGJO PABLLBNGLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte KCONHMHJGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly OCNOOOEAALH OABOBGGIIJC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CED740", Offset = "0x5CEC140", VA = "0x185CED740")]
	public GIEADFMDGEB(LHINCEBFGAE KNCHPAAMIFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LHINCEBFGAE : IEnumerable<PCFEONONJMA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class COCPPMEHAGM : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBD80", Offset = "0x5CEA780", VA = "0x185CEBD80", Slot = "4")]
		public bool Equals(IPEndPoint PHDMOAMCFBE, IPEndPoint CPHIHAJIIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x57E1CC0", Offset = "0x57E06C0", VA = "0x1857E1CC0", Slot = "5")]
		public int GetHashCode(IPEndPoint GKHPLGCJCPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public COCPPMEHAGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct BDNLHMLLKNB : IEnumerator<PCFEONONJMA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly PCFEONONJMA ELOPLMKGLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private PCFEONONJMA OBMDPJPCNDD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PCFEONONJMA NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x10C8CA0", Offset = "0x10C76A0", VA = "0x1810C8CA0")]
		public BDNLHMLLKNB(PCFEONONJMA HINJMLAPBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9D60", Offset = "0x5CE8760", VA = "0x185CE9D60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9DB0", Offset = "0x5CE87B0", VA = "0x185CE9DB0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread AOOEGAIGLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool MAAEJBLNDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent POKAFIAEGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<GIEADFMDGEB> DBNPDIKBGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<GIEADFMDGEB> OLKMEHJLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GIEADFMDGEB DJPNAIGMINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FDAODOLCIKI OJOKGHBFPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly PDCJBMAJAFN JPFKHAOIONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly LAKFHMKIDGD MDPPECOOAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JECBJIGDGON BMBOICIEGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, PCFEONONJMA> BJONFGCNPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, IDMOFBADEMG> JJPAFPBDOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, EHCHCMMIFAI> IMDKCLOHFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim IICHIJCKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private PCFEONONJMA EJPMMBPLBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int LEECKDKBJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<PCFEONONJMA> KFHGNBNDFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private PCFEONONJMA[] AHKKNDJIMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly BLPABKCEMJB HICOKMBONGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int ACNIAGHNBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> JIIIIOGLAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte DIIDBICCEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object OGHAGDKBDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool PCFJPCBIDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool OGDBDAMGANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int BLPMNKNGAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int HLLIJINAOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int JCPBEFKFCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int PPBGCMMFGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool DHLBJDPEODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool LMHLDCAINGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int AODPEPMKHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int FEJNKOGGOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int MLIFKEKIGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool EKEDFODOALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool AOKGPKMKLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool ONNCAIBONAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool KMFBBJNGJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int PHLBJJGJFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int OINLIMOLMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool CEIBNDLMCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly IJFLFHCMIDP MBDPKCOLAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool AIBOPCDFCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly AEGOAAJFKAC CMCHDIFBBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool PMIIMKCHBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public HBPOMBPNDAI FFAJLCPOMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int NKPCEEMOPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KANLBNCLNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool NLGINNKCDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool KMIEDHFFHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool MPHEMFJCNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private HDEPEHPEMBJ GHOIEDMLBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int LDAKDJPALLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object JNKHMACADLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HDEPEHPEMBJ MEIFHBFJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int DLKOGEDPFHB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int BMKEMKNGEHD = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int FFKMEGOCOJB = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private DLFILPFHNCM MCNNBIGGGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private DLFILPFHNCM LEICBJILMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread IOKHCNJDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread NHCKGPHKFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint NLABNOEABIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint ONJKDNOPPNO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] HMCNFPJHKNB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] GGEBEOFEPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<GKAPICKDMII, IPEndPoint> CMPPHPENEGJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress NMBKMGKDPAE;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool NECGDKDFFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int CLEFOJFKOEH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IGJHMIFOAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xBC80B0", Offset = "0xBC6AB0", VA = "0x180BC80B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC77610", Offset = "0xC76010", VA = "0x180C77610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CDCDFOMBINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14C3B60", Offset = "0x14C2560", VA = "0x1814C3B60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x17EEB70", Offset = "0x17ED570", VA = "0x1817EEB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte OOJONJKEFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA310F0", Offset = "0xA2FAF0", VA = "0x180A310F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CNODBMDDHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1D70", Offset = "0x5CF0770", VA = "0x185CF1D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short ALOKHNBJANP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2480", Offset = "0x5CF0E80", VA = "0x185CF2480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2860", Offset = "0x5CF1260", VA = "0x185CF2860")]
	public void DFKINIAJEDJ(IPEndPoint BILAFPOFCHL, byte[] LDDEKIBHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5330", Offset = "0x5CF3D30", VA = "0x185CF5330")]
	public void KIMCNJHGFEJ(IPEndPoint BILAFPOFCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CF41C0", Offset = "0x5CF2BC0", VA = "0x185CF41C0")]
	private bool HJEPDMKFGKD(IPEndPoint BILAFPOFCHL, [Out] PCFEONONJMA KNHDIEBDFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6310", Offset = "0x5CF4D10", VA = "0x185CF6310")]
	private void MJKMGADAMBI(PCFEONONJMA KNHDIEBDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4480", Offset = "0x5CF2E80", VA = "0x185CF4480")]
	private void ICFFGJLMINI(PCFEONONJMA KNHDIEBDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CF65D0", Offset = "0x5CF4FD0", VA = "0x185CF65D0")]
	private void MOGEBFAJMHK(PCFEONONJMA KNHDIEBDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7E20", Offset = "0x5CF6820", VA = "0x185CF7E20")]
	public LHINCEBFGAE(FDAODOLCIKI EHOKAKKEOJP, [Optional] BLPABKCEMJB MHHIBAEAFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1450", Offset = "0x5CEFE50", VA = "0x185CF1450")]
	internal void AENHFBMIPAP(PCFEONONJMA AKPBENPHGKN, int KHFILPONJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4170", Offset = "0x5CF2B70", VA = "0x185CF4170")]
	internal void GLPJHHDBDGM(PCFEONONJMA AKPBENPHGKN, object KFFELFHDPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF40A0", Offset = "0x5CF2AA0", VA = "0x185CF40A0")]
	internal void GLOBFHPBBEG(PCFEONONJMA KNHDIEBDFFN, PMOGEAOCLFE GDIKEMIFDHP, SocketError MNGOKPLJLNK, HDEPEHPEMBJ ECOHBDCBECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2120", Offset = "0x5CF0B20", VA = "0x185CF2120")]
	private void CEBGFPNNDKL(PCFEONONJMA KNHDIEBDFFN, PMOGEAOCLFE GDIKEMIFDHP, SocketError MNGOKPLJLNK, bool JFKDELALDJD, byte[] EEOBDBMOHPL, int BPFHAJJBCKE, int OHELHAFFKFF, HDEPEHPEMBJ ECOHBDCBECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6D70", Offset = "0x5CF5770", VA = "0x185CF6D70")]
	private void OCEIPKPLKIO(GIEADFMDGEB.BIHOFOPGEAH ADDOHDGDFOD, [Optional] PCFEONONJMA KNHDIEBDFFN, [Optional] IPEndPoint IPBPKKCDEIC, SocketError OKEIDPHGIFB = SocketError.Success, int KHFILPONJHP = 0, PMOGEAOCLFE HMIIFKLLHGB = PMOGEAOCLFE.ConnectionFailed, [Optional] IDMOFBADEMG ADANKDHKOEE, BCBPMHJHGJO OODJIOMAMFN = BCBPMHJHGJO.Unreliable, byte LHOMMMHLFNM = 0, [Optional] HDEPEHPEMBJ OENHBCBAFAD, [Optional] object KFFELFHDPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7490", Offset = "0x5CF5E90", VA = "0x185CF7490")]
	private void PMJOKLAIOAO(GIEADFMDGEB JHEBABABGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1350", Offset = "0x5CEFD50", VA = "0x185CF1350")]
	internal void ABGHFCKIDOO(GIEADFMDGEB JHEBABABGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CF14A0", Offset = "0x5CEFEA0", VA = "0x185CF14A0")]
	private void ALKDCHKELFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2540", Offset = "0x5CF0F40", VA = "0x185CF2540")]
	private void DDDEGKCPONA(int ALCAOPPELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CF48E0", Offset = "0x5CF32E0", VA = "0x185CF48E0")]
	internal PCFEONONJMA JFNHBKFLAIM(IDMOFBADEMG BJLMEIJMPBN, byte[] CJPCMEONNOH, int BPFHAJJBCKE, int NDKEFFPEPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CF44D0", Offset = "0x5CF2ED0", VA = "0x185CF44D0")]
	private int IGOMKNPGNOG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6910", Offset = "0x5CF5310", VA = "0x185CF6910")]
	private void NMKCANJKNCP(IPEndPoint IPBPKKCDEIC, PCFEONONJMA EFJFALOLGMO, LMGONFMAMJM LINPECNMDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5480", Offset = "0x5CF3E80", VA = "0x185CF5480")]
	private void LPGBEFHGEME(HDEPEHPEMBJ OCFPBCNHKDK, IPEndPoint IPBPKKCDEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4F00", Offset = "0x5CF3900", VA = "0x185CF4F00")]
	internal void KDHMABOLLNB(HDEPEHPEMBJ OCFPBCNHKDK, BCBPMHJHGJO JLNNJCFCNCN, byte LHOMMMHLFNM, int BFNBOCNIBBA, PCFEONONJMA AKPBENPHGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5CF39F0", Offset = "0x5CF23F0", VA = "0x185CF39F0")]
	public bool FNEPMCHENFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3220", Offset = "0x5CF1C20", VA = "0x185CF3220")]
	public bool FNEPMCHENFK(IPAddress KJKODNHCLIB, IPAddress JDICPDJFJNL, int EFFIPLGIFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3A00", Offset = "0x5CF2400", VA = "0x185CF3A00")]
	public bool FNEPMCHENFK(int EFFIPLGIFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3A80", Offset = "0x5CF2480", VA = "0x185CF3A80")]
	public void FNFNOAHMFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF17E0", Offset = "0x5CF01E0", VA = "0x185CF17E0")]
	public PCFEONONJMA ALNDIJPFCFF(string JPMGDOMJOOJ, int EFFIPLGIFEM, string LDDEKIBHION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1C90", Offset = "0x5CF0690", VA = "0x185CF1C90")]
	public PCFEONONJMA ALNDIJPFCFF(string JPMGDOMJOOJ, int EFFIPLGIFEM, JCIOBEOLKNM IFCEOHHPMEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF18C0", Offset = "0x5CF02C0", VA = "0x185CF18C0")]
	public PCFEONONJMA ALNDIJPFCFF(IPEndPoint PIBCCEDJCCL, JCIOBEOLKNM IFCEOHHPMEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7130", Offset = "0x5CF5B30", VA = "0x185CF7130")]
	public void PMGKHCNMCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7140", Offset = "0x5CF5B40", VA = "0x185CF7140")]
	public void PMGKHCNMCBL(bool NOKAEJMBMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3E80", Offset = "0x5CF2880", VA = "0x185CF3E80")]
	public void GIIKKEMPEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3F80", Offset = "0x5CF2980", VA = "0x185CF3F80")]
	public void GIIKKEMPEBL(byte[] EEOBDBMOHPL, int BPFHAJJBCKE, int OHELHAFFKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2200", Offset = "0x5CF0C00", VA = "0x185CF2200")]
	public void CEBGFPNNDKL(PCFEONONJMA KNHDIEBDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2060", Offset = "0x5CF0A60", VA = "0x185CF2060")]
	public void CEBGFPNNDKL(PCFEONONJMA KNHDIEBDFFN, byte[] EEOBDBMOHPL, int BPFHAJJBCKE, int OHELHAFFKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7C40", Offset = "0x5CF6640", VA = "0x185CF7C40", Slot = "4")]
	private IEnumerator<PCFEONONJMA> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7CD0", Offset = "0x5CF66D0", VA = "0x185CF7CD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2390", Offset = "0x5CF0D90", VA = "0x185CF2390")]
	private HDEPEHPEMBJ CGHGKHENPEB(ENDCKDBDPGJ DDHAIBOKNCF, int BKEGNEKBPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5CF22B0", Offset = "0x5CF0CB0", VA = "0x185CF22B0")]
	private HDEPEHPEMBJ CGHGKHENPEB(ENDCKDBDPGJ DDHAIBOKNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4250", Offset = "0x5CF2C50", VA = "0x185CF4250")]
	internal HDEPEHPEMBJ HMAJHHJBHJK(int BKEGNEKBPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3C20", Offset = "0x5CF2620", VA = "0x185CF3C20")]
	internal void GCGEDHEADNE(HDEPEHPEMBJ OCFPBCNHKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7D60", Offset = "0x5CF6760", VA = "0x185CF7D60")]
	static LHINCEBFGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBC80B0", Offset = "0xBC6AB0", VA = "0x180BC80B0")]
	private bool MJEGBBCINFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6820", Offset = "0x5CF5220", VA = "0x185CF6820")]
	private void NGJJOBNAKLC(IPEndPoint DHLGCCBFDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5CF61D0", Offset = "0x5CF4BD0", VA = "0x185CF61D0")]
	private void MDJBGMPPJDI(IPEndPoint DHLGCCBFDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2A80", Offset = "0x5CF1480", VA = "0x185CF2A80")]
	private bool DGEAJDJPADA(SocketException JKHACPOPJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1D90", Offset = "0x5CF0790", VA = "0x185CF1D90")]
	private void BIKEONOAIME(DLFILPFHNCM ABODMHMOFAO, EndPoint KACELFCJDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4550", Offset = "0x5CF2F50", VA = "0x185CF4550")]
	private void JBFNABLJJFP(object FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3240", Offset = "0x5CF1C40", VA = "0x185CF3240")]
	public bool FNEPMCHENFK(IPAddress KJKODNHCLIB, IPAddress JDICPDJFJNL, int EFFIPLGIFEM, bool KMAJKINIMLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5CF62B0", Offset = "0x5CF4CB0", VA = "0x185CF62B0")]
	internal int MFLPPAPBKKC(HDEPEHPEMBJ OCFPBCNHKDK, IPEndPoint IPBPKKCDEIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5CF31E0", Offset = "0x5CF1BE0", VA = "0x185CF31E0")]
	internal int DHOCDBIFIFF(HDEPEHPEMBJ OCFPBCNHKDK, IPEndPoint IPBPKKCDEIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2C20", Offset = "0x5CF1620", VA = "0x185CF2C20")]
	internal int DHOCDBIFIFF(byte[] BDCMABOIIFF, int BPFHAJJBCKE, int NDKEFFPEPII, IPEndPoint IPBPKKCDEIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5CF51C0", Offset = "0x5CF3BC0", VA = "0x185CF51C0")]
	internal void KIBAJNDEBMK(bool KPIBKOJOEEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum ENDCKDBDPGJ : byte
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
internal sealed class HDEPEHPEMBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int CMIKMOLBCFL;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] MCLMLKKMFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] OFJACFFDPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int DLJBGHKKEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object ABEEAMLMKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public HDEPEHPEMBJ FIFIAJBOHJL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public ENDCKDBDPGJ EKBEIPMFHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE860", Offset = "0x5CED260", VA = "0x185CEE860")]
		get
		{
			return default(ENDCKDBDPGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE610", Offset = "0x5CED010", VA = "0x185CEE610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte CCKMEFEAHND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5CEEAD0", Offset = "0x5CED4D0", VA = "0x185CEEAD0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5CEEA30", Offset = "0x5CED430", VA = "0x185CEEA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort AOALANKPNHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE550", Offset = "0x5CECF50", VA = "0x185CEE550")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE7B0", Offset = "0x5CED1B0", VA = "0x185CEE7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IKBLOLBLEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE5E0", Offset = "0x5CECFE0", VA = "0x185CEE5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HKPAGFOGLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE7F0", Offset = "0x5CED1F0", VA = "0x185CEE7F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE5B0", Offset = "0x5CECFB0", VA = "0x185CEE5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort HEENLNAEEED
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE9D0", Offset = "0x5CED3D0", VA = "0x185CEE9D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5CEEB30", Offset = "0x5CED530", VA = "0x185CEEB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort LLLBFOFPICB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE650", Offset = "0x5CED050", VA = "0x185CEE650")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE890", Offset = "0x5CED290", VA = "0x185CEE890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort GJIONHNPBDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5CEEA70", Offset = "0x5CED470", VA = "0x185CEEA70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE820", Offset = "0x5CED220", VA = "0x185CEE820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEB70", Offset = "0x5CED570", VA = "0x185CEEB70")]
	static HDEPEHPEMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEB00", Offset = "0x5CED500", VA = "0x185CEEB00")]
	public void OBPAIOLHACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEF60", Offset = "0x5CED960", VA = "0x185CEEF60")]
	public HDEPEHPEMBJ(int BKEGNEKBPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEE50", Offset = "0x5CED850", VA = "0x185CEEE50")]
	public HDEPEHPEMBJ(ENDCKDBDPGJ DDHAIBOKNCF, int BKEGNEKBPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE6B0", Offset = "0x5CED0B0", VA = "0x185CEE6B0")]
	public static int HHFPIMGLDBN(ENDCKDBDPGJ DDHAIBOKNCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE720", Offset = "0x5CED120", VA = "0x185CEE720")]
	public int HHFPIMGLDBN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE8D0", Offset = "0x5CED2D0", VA = "0x185CEE8D0")]
	public bool LANNDPAIHGO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum LPFIMJFFKIH : byte
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
internal enum DLGLELDECOJ
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
internal enum CCKMMKEAPAA
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum ILNOHMGMHOG
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PCFEONONJMA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class BGKLNKFCAKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public HDEPEHPEMBJ[] AJAIDKFMPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int NAOEAPAJNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int BFNKIIBNINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte HKPAGFOGLEC;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public BGKLNKFCAKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void FBKBMILHKKH(ulong GANGMPNOMDA, int GBLMJKPPKPO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int JHOIIBLAEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int MHFBEOHKMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int IDKABNIIFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double MCNNNMBGMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int IJCCAMDPOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int CPCDHABCKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int PKCJOMAKPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch BGLNJEHJCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int JGMJBOJONKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long EDINGBCAJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object FJPODLOENJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal PCFEONONJMA FEKNMDKGFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal PCFEONONJMA IBANJMAEMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<HDEPEHPEMBJ> NAKPJHPDENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<ABMOMLFNBOL> CLKHAPHMMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly ABMOMLFNBOL[] IFODCINIHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int CLAONKGHBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int HCGMCNLBMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool GBENAIADFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int PNOIMLPHFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int APKHMCPLNDO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int MKFMFLBMNMM = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int OPNFJHCFEPO = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object DEELEOAGBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int LNPJCPIEHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, BGKLNKFCAKP> CGGMDJBOCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> LCGJNKLACED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly HDEPEHPEMBJ NHPEJFJHECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int KNBHAGMGPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int MCHPHKJJCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint ODFEPLBIIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int FLOCOBLHJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int NHHBBDNLLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long NCMIKKLEEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte PAGFOFLCGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private LPFIMJFFKIH INIFAODLNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private HDEPEHPEMBJ OPBNFCOKMID;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int ABIDPIHFHJM = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int GFOLHKCFHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly HDEPEHPEMBJ BKLOAKCMDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly HDEPEHPEMBJ MMOGJBFHKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly HDEPEHPEMBJ GGGEKABAAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly HDEPEHPEMBJ MAIDFJFKFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private MKEGCLBNFNC OCHJNGAMNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly LHINCEBFGAE ADNIKDLDPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int FOBLAHOCEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object BPGPIEGDDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly IJFLFHCMIDP MBDPKCOLAED;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte CEEHICMCDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC0B410", Offset = "0xC09E10", VA = "0x180C0B410")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC930", Offset = "0x5CFB330", VA = "0x185CFC930")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint KBCDJEDODKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BB850", Offset = "0x8BA250", VA = "0x1808BB850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LPFIMJFFKIH CEGOHMNNGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x12F9F10", Offset = "0x12F8910", VA = "0x1812F9F10")]
		get
		{
			return default(LPFIMJFFKIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long BGMPJFAGGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x859FD0", VA = "0x18085B5D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CBEDHLLBGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCD9630", Offset = "0xCD8030", VA = "0x180CD9630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15C8900", Offset = "0x15C7300", VA = "0x1815C8900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NKCEKDCJIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5CFEAD0", Offset = "0x5CFD4D0", VA = "0x185CFEAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int CEKJDOALBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85C460", Offset = "0x85AE60", VA = "0x18085C460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double ABDJBEGBELI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A5A120", Offset = "0x1A58B20", VA = "0x181A5A120")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FBKBMILHKKH NHNFCFKIIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDBB0", Offset = "0x5CFC5B0", VA = "0x185CFDBB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5CFEA20", Offset = "0x5CFD420", VA = "0x185CFEA20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEFD0", Offset = "0x5CFD9D0", VA = "0x185CFEFD0")]
	internal PCFEONONJMA(LHINCEBFGAE INAKIDHOAPG, IPEndPoint IPBPKKCDEIC, int OBDGAAHPMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE2E0", Offset = "0x5CFCCE0", VA = "0x185CFE2E0")]
	internal void LNOMGJMOKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEDC0", Offset = "0x5CFD7C0", VA = "0x185CFEDC0")]
	internal void PLLHFGHAAGC(IPEndPoint IAHGENKHALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC9E0", Offset = "0x5CFB3E0", VA = "0x185CFC9E0")]
	internal void DJBPLGPIFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC860", Offset = "0x5CFB260", VA = "0x185CFC860")]
	private void DCKONAIBKBM(int DHLJIOGGIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD7D0", Offset = "0x5CFC1D0", VA = "0x185CFD7D0")]
	private void GGGLAIOMKNE(int EMPHNJIJDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC000", Offset = "0x5CFAA00", VA = "0x185CFC000")]
	private ABMOMLFNBOL AHFHMOAPGFO(byte OPBNGFFAEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF430", Offset = "0x5CFDE30", VA = "0x185CFF430")]
	internal PCFEONONJMA(LHINCEBFGAE INAKIDHOAPG, IPEndPoint IPBPKKCDEIC, int OBDGAAHPMCD, byte LNFLPIEFDDL, JCIOBEOLKNM DPMPHFMNOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEDF0", Offset = "0x5CFD7F0", VA = "0x185CFEDF0")]
	internal PCFEONONJMA(LHINCEBFGAE INAKIDHOAPG, IDMOFBADEMG BJLMEIJMPBN, int OBDGAAHPMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDCC0", Offset = "0x5CFC6C0", VA = "0x185CFDCC0")]
	internal void IFBOFLAEFGD(LMGONFMAMJM ENDLHCBPODA, byte[] EEOBDBMOHPL, int BPFHAJJBCKE, int NDKEFFPEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE260", Offset = "0x5CFCC60", VA = "0x185CFE260")]
	internal bool LBGGMMCPDHE(HCBNIPPMDMB OCFPBCNHKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE9F0", Offset = "0x5CFD3F0", VA = "0x185CFE9F0")]
	public void NCADDMBHPKC(byte[] EEOBDBMOHPL, int BPFHAJJBCKE, int NDKEFFPEPII, BCBPMHJHGJO FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDD10", Offset = "0x5CFC710", VA = "0x185CFDD10")]
	private void IKEGIOIJLGP(byte[] EEOBDBMOHPL, int BPFHAJJBCKE, int NDKEFFPEPII, byte LHOMMMHLFNM, BCBPMHJHGJO OODJIOMAMFN, object KFFELFHDPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD410", Offset = "0x5CFBE10", VA = "0x185CFD410")]
	public void FEAOLAEOEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDAD0", Offset = "0x5CFC4D0", VA = "0x185CFDAD0")]
	internal CCKMMKEAPAA HEPGECJICFA(HDEPEHPEMBJ OCFPBCNHKDK)
	{
		return default(CCKMMKEAPAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDC60", Offset = "0x5CFC660", VA = "0x185CFDC60")]
	internal void IDHMGCGACLB(ABMOMLFNBOL NKOKIBDIAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD4C0", Offset = "0x5CFBEC0", VA = "0x185CFD4C0")]
	internal ILNOHMGMHOG GDOFFJHGOIB(byte[] EEOBDBMOHPL, int BPFHAJJBCKE, int NDKEFFPEPII, bool JFKDELALDJD)
	{
		return default(ILNOHMGMHOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE9B0", Offset = "0x5CFD3B0", VA = "0x185CFE9B0")]
	private void NADKJAJFMCO(int APANIKMFBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCA70", Offset = "0x5CFB470", VA = "0x185CFCA70")]
	internal void DKMCOFPGPBD(BCBPMHJHGJO JLNNJCFCNCN, HDEPEHPEMBJ HINJMLAPBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBAA0", Offset = "0x5CFA4A0", VA = "0x185CFBAA0")]
	private void AGBONKKDCOL(HDEPEHPEMBJ OCFPBCNHKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB720", Offset = "0x5CFA120", VA = "0x185CFB720")]
	private void AEOKCNOPEAB(int ECCGJGJKLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEC00", Offset = "0x5CFD600", VA = "0x185CFEC00")]
	internal DLGLELDECOJ NMKCANJKNCP(LMGONFMAMJM LINPECNMDLJ)
	{
		return default(DLGLELDECOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE300", Offset = "0x5CFCD00", VA = "0x185CFE300")]
	internal void MJINIEHDOIA(HDEPEHPEMBJ OCFPBCNHKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEAE0", Offset = "0x5CFD4E0", VA = "0x185CFEAE0")]
	private void NMIOFDDMBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB550", Offset = "0x5CF9F50", VA = "0x185CFB550")]
	internal void ACPDOONFNDO(HDEPEHPEMBJ OCFPBCNHKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC1B0", Offset = "0x5CFABB0", VA = "0x185CFC1B0")]
	internal void AIFEINMMINP(int ECCGJGJKLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD810", Offset = "0x5CFC210", VA = "0x185CFD810")]
	internal void HDIKHBBEKEM(HDEPEHPEMBJ OCFPBCNHKDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class IJFLFHCMIDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long KKDMAPCIBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long CKPGHGAELGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long ALOHFGPKHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long IIACFFJIDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long KDIIEDJKFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long JAPFEPIGCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long EBEMJPLNPOJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long NLNJLDFEFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF330", Offset = "0x5CEDD30", VA = "0x185CEF330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long HBKLNJIKIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF160", Offset = "0x5CEDB60", VA = "0x185CEF160")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long NNEKCOMDBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF320", Offset = "0x5CEDD20", VA = "0x185CEF320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long ILLJLOCALBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF350", Offset = "0x5CEDD50", VA = "0x185CEF350")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long HBINGHAOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF1F0", Offset = "0x5CEDBF0", VA = "0x185CEF1F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long HOFPILHIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF200", Offset = "0x5CEDC00", VA = "0x185CEF200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MKEGCLBNFNC CGJJIMGKOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF1D0", Offset = "0x5CEDBD0", VA = "0x185CEF1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double KHDNKLJDCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF170", Offset = "0x5CEDB70", VA = "0x185CEF170")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF210", Offset = "0x5CEDC10", VA = "0x185CEF210")]
	public void GLMNPCAHJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF130", Offset = "0x5CEDB30", VA = "0x185CEF130")]
	public void DAFJMPKNAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF1E0", Offset = "0x5CEDBE0", VA = "0x185CEF1E0")]
	public void GADDDMALEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF340", Offset = "0x5CEDD40", VA = "0x185CEF340")]
	public void MCHPCNNLNLN(long OBMFCGFPFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF270", Offset = "0x5CEDC70", VA = "0x185CEF270")]
	public void JBKMDMANBBA(long EBMADPPHMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF360", Offset = "0x5CEDD60", VA = "0x185CEF360")]
	public void ONDEFDCGKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF390", Offset = "0x5CEDD90", VA = "0x185CEF390")]
	public void PCBKFDPGKGA(long EEPANAKDHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF3D0", Offset = "0x5CEDDD0", VA = "0x185CEF3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF280", Offset = "0x5CEDC80", VA = "0x185CEF280")]
	public void JNMJMDIBONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public IJFLFHCMIDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PMENDKCAHNK
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> MOFEALKGFGA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF5C0", Offset = "0x5CFDFC0", VA = "0x185CFF5C0")]
	public static IPEndPoint HMDADLKFPLN(string BCEABONDNDE, int EFFIPLGIFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF840", Offset = "0x5CFE240", VA = "0x185CFF840")]
	public static IPAddress OIIDLGBNPKG(string BCEABONDNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFA10", Offset = "0x5CFE410", VA = "0x185CFFA10")]
	public static IPAddress OIIDLGBNPKG(string BCEABONDNDE, AddressFamily LAKFMCFBMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF810", Offset = "0x5CFE210", VA = "0x185CFF810")]
	internal static int OGLKHCOEOJL(int DKAOANMFKDA, int MFKOMMEOBKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6FA0", Offset = "0x2CF59A0", VA = "0x182CF6FA0")]
	internal static T[] ICIIMEKEJEK<T>(int OHELHAFFKFF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PCDBHGPAAIL : ABMOMLFNBOL
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct KOGLLMEOMHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private HDEPEHPEMBJ OGOMHOFCCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long HINANJIBFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool ECCBMIBKIII;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0660", Offset = "0x5CEF060", VA = "0x185CF0660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5CF05D0", Offset = "0x5CEEFD0", VA = "0x185CF05D0")]
		public void GKMPMEFLHAB(HDEPEHPEMBJ OCFPBCNHKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5CF05F0", Offset = "0x5CEEFF0", VA = "0x185CF05F0")]
		public bool JMHHJBHDFLD(long FPCNFFLPKFI, PCFEONONJMA KNHDIEBDFFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0580", Offset = "0x5CEEF80", VA = "0x185CF0580")]
		public bool EIMPLACCFNH(PCFEONONJMA KNHDIEBDFFN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly HDEPEHPEMBJ DEIFADLMPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly KOGLLMEOMHG[] BHFJFBHGJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly HDEPEHPEMBJ[] IMJMFGPAIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] EPAOLGNNNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int POANEADJDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int KFEDAFFDHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int KEHLEDMLLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int KKJHHCMLMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool PCLHPBMCELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly BCBPMHJHGJO ELAHNOEAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool HMOEOAGHPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int ENLBADHODPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte KGNENAFMIDN;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB380", Offset = "0x5CF9D80", VA = "0x185CFB380")]
	public PCDBHGPAAIL(PCFEONONJMA KNHDIEBDFFN, bool KMFLLABFCNH, byte OBDGAAHPMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA960", Offset = "0x5CF9360", VA = "0x185CFA960")]
	private void ILBOEHABJNM(HDEPEHPEMBJ OCFPBCNHKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA4B0", Offset = "0x5CF8EB0", VA = "0x185CFA4B0", Slot = "4")]
	protected override bool BILHFBFEGFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAD20", Offset = "0x5CF9720", VA = "0x185CFAD20", Slot = "5")]
	public override bool MJINIEHDOIA(HDEPEHPEMBJ OCFPBCNHKDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class CDNNMKOBBBO : ABMOMLFNBOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int HJMFMABOCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort KFEDAFFDHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool CGOBJCJFGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private HDEPEHPEMBJ DHAPIJFGNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly HDEPEHPEMBJ IJHMPEAHEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool BDEBDGLDIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte KGNENAFMIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long KKHCCCDCJDF;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA930", Offset = "0x5CE9330", VA = "0x185CEA930")]
	public CDNNMKOBBBO(PCFEONONJMA KNHDIEBDFFN, bool BBIPLHAOHAE, byte OBDGAAHPMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA180", Offset = "0x5CE8B80", VA = "0x185CEA180", Slot = "4")]
	protected override bool BILHFBFEGFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA620", Offset = "0x5CE9020", VA = "0x185CEA620", Slot = "5")]
	public override bool MJINIEHDOIA(HDEPEHPEMBJ OCFPBCNHKDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MKMPFDMMKJE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct GFMDENMIIHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong PNGBBCFHODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double KNCBEAAADAD;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct JFKIGLBGKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int NMDDBJAHLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float DANLMMCCKHG;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9090", Offset = "0x5CE7A90", VA = "0x185CE9090")]
	private static void CLNLPBJIKOK(byte[] BLNHMFAPOOE, int LJEHDHLGGJA, ulong EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA180", Offset = "0x5CF8B80", VA = "0x185CFA180")]
	private static void CLNLPBJIKOK(byte[] BLNHMFAPOOE, int LJEHDHLGGJA, int EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA140", Offset = "0x5CF8B40", VA = "0x185CFA140")]
	public static void CLNLPBJIKOK(byte[] BLNHMFAPOOE, int LJEHDHLGGJA, short EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA280", Offset = "0x5CF8C80", VA = "0x185CFA280")]
	public static void IMHDDOOFJCI(byte[] KKELJOOMKNM, int PFNBAEBFNFJ, double DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA200", Offset = "0x5CF8C00", VA = "0x185CFA200")]
	public static void IMHDDOOFJCI(byte[] KKELJOOMKNM, int PFNBAEBFNFJ, float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA140", Offset = "0x5CF8B40", VA = "0x185CFA140")]
	public static void IMHDDOOFJCI(byte[] KKELJOOMKNM, int PFNBAEBFNFJ, short DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA140", Offset = "0x5CF8B40", VA = "0x185CFA140")]
	public static void IMHDDOOFJCI(byte[] KKELJOOMKNM, int PFNBAEBFNFJ, ushort DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA180", Offset = "0x5CF8B80", VA = "0x185CFA180")]
	public static void IMHDDOOFJCI(byte[] KKELJOOMKNM, int PFNBAEBFNFJ, int DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA180", Offset = "0x5CF8B80", VA = "0x185CFA180")]
	public static void IMHDDOOFJCI(byte[] KKELJOOMKNM, int PFNBAEBFNFJ, uint DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA1F0", Offset = "0x5CF8BF0", VA = "0x185CFA1F0")]
	public static void IMHDDOOFJCI(byte[] KKELJOOMKNM, int PFNBAEBFNFJ, long DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA1F0", Offset = "0x5CF8BF0", VA = "0x185CFA1F0")]
	public static void IMHDDOOFJCI(byte[] KKELJOOMKNM, int PFNBAEBFNFJ, ulong DBOBEHLEAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KOMLIFNACNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] JFGMNOKNMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int MDGNFDLPNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int NNINBPCEMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int KEPOGBFLMAN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] OFJACFFDPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int IIFOBPAHLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int IJGEKAAPKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1100", Offset = "0x5CEFB00", VA = "0x185CF1100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PJPEDABAFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1EA6FF0", Offset = "0x1EA59F0", VA = "0x181EA6FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NJEDMNONPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0C00", Offset = "0x5CEF600", VA = "0x185CF0C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0E70", Offset = "0x5CEF870", VA = "0x185CF0E70")]
	public void HAOJKPBJENB(byte[] LBIKMBJEOGO, int LJEHDHLGGJA, int KBCKNANMOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public KOMLIFNACNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5CF12F0", Offset = "0x5CEFCF0", VA = "0x185CF12F0")]
	public KOMLIFNACNM(byte[] LBIKMBJEOGO, int LJEHDHLGGJA, int KBCKNANMOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0D40", Offset = "0x5CEF740", VA = "0x185CF0D40")]
	public IPEndPoint EBLABMMOKHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0900", Offset = "0x5CEF300", VA = "0x185CF0900")]
	public byte BFNALBNJHMB()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0900", Offset = "0x5CEF300", VA = "0x185CF0900")]
	public sbyte KMBADMAGKAM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEE00", Offset = "0x2BBD800", VA = "0x182BBEE00")]
	public T[] LPIFJJHOLPB<T>(ushort BKEGNEKBPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0940", Offset = "0x5CEF340", VA = "0x185CF0940")]
	public bool[] BGAFDFDJGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0FD0", Offset = "0x5CEF9D0", VA = "0x185CF0FD0")]
	public ushort[] IIEEBOMKEIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0850", Offset = "0x5CEF250", VA = "0x185CF0850")]
	public short[] AILOGJDDINE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1240", Offset = "0x5CEFC40", VA = "0x185CF1240")]
	public int[] PJJAAJDCFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1050", Offset = "0x5CEFA50", VA = "0x185CF1050")]
	public uint[] JKNJFELHBLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1180", Offset = "0x5CEFB80", VA = "0x185CF1180")]
	public float[] ODAFPCKAGLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1200", Offset = "0x5CEFC00", VA = "0x185CF1200")]
	public double[] PCNNBEALOHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0980", Offset = "0x5CEF380", VA = "0x185CF0980")]
	public long[] CGCAAELIMNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5CF11C0", Offset = "0x5CEFBC0", VA = "0x185CF11C0")]
	public ulong[] OLCCDCGODAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0C10", Offset = "0x5CEF610", VA = "0x185CF0C10")]
	public string[] EAEEEANLLLC(int LAPHCBOIDJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0F90", Offset = "0x5CEF990", VA = "0x185CF0F90")]
	public bool HKNNKBBNINJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0890", Offset = "0x5CEF290", VA = "0x185CF0890")]
	public char PDPIBMICFHO()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0890", Offset = "0x5CEF290", VA = "0x185CF0890")]
	public ushort BDAAKFOBMFB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0770", Offset = "0x5CEF170", VA = "0x185CF0770")]
	public short ADMLKEMLFCL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0700", Offset = "0x5CEF100", VA = "0x185CF0700")]
	public long AAJDIKCLLDH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0F20", Offset = "0x5CEF920", VA = "0x185CF0F20")]
	public ulong HGKBEJENBPO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1280", Offset = "0x5CEFC80", VA = "0x185CF1280")]
	public int PJNOHNHNKKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1110", Offset = "0x5CEFB10", VA = "0x185CF1110")]
	public uint NFBODEHECHF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1090", Offset = "0x5CEFA90", VA = "0x185CF1090")]
	public float KLBFIIBNANM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF07E0", Offset = "0x5CEF1E0", VA = "0x185CF07E0")]
	public double AFNDGCOKJAC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5CF09C0", Offset = "0x5CEF3C0", VA = "0x185CF09C0")]
	public string CIIFJGJOKBG(int CEBCLCHGCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0EB0", Offset = "0x5CEF8B0", VA = "0x185CF0EB0")]
	public ArraySegment<byte> HFBICFJMAIE(int OHELHAFFKFF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0E30", Offset = "0x5CEF830", VA = "0x185CF0E30")]
	public sbyte[] FLAOJHIPPAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1010", Offset = "0x5CEFA10", VA = "0x185CF1010")]
	public byte[] JGFHNGLCEOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0E10", Offset = "0x5CEF810", VA = "0x185CF0E10")]
	public void EIMPLACCFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JCIOBEOLKNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] JFGMNOKNMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int MDGNFDLPNJK;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int JJGPPKPGEHJ = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool CPODKFOBJME;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding HEJLCPDACFA;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int JPJHFHMICHO = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] PLLDJBENIAB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] MAOHOGCCNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NBLIGAPNOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0460", Offset = "0x5CEEE60", VA = "0x185CF0460")]
	public JCIOBEOLKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5CF04E0", Offset = "0x5CEEEE0", VA = "0x185CF04E0")]
	public JCIOBEOLKNM(bool CFDBBLDDJKD, int FPGJHPPIALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0360", Offset = "0x5CEED60", VA = "0x185CF0360")]
	public static JCIOBEOLKNM OPJFKMJOBFP(string DBOBEHLEAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF02C0", Offset = "0x5CEECC0", VA = "0x185CF02C0")]
	public void NIPEEFLOKAJ(int JOAMDNFKLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F20E50", Offset = "0x1F1F850", VA = "0x181F20E50")]
	public void GLMNPCAHJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFDD0", Offset = "0x5CEE7D0", VA = "0x185CEFDD0")]
	public void NFCEOJHCMMN(float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFC60", Offset = "0x5CEE660", VA = "0x185CEFC60")]
	public void NFCEOJHCMMN(double DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFD80", Offset = "0x5CEE780", VA = "0x185CEFD80")]
	public void NFCEOJHCMMN(long DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFD80", Offset = "0x5CEE780", VA = "0x185CEFD80")]
	public void NFCEOJHCMMN(ulong DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFEF0", Offset = "0x5CEE8F0", VA = "0x185CEFEF0")]
	public void NFCEOJHCMMN(int DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFEF0", Offset = "0x5CEE8F0", VA = "0x185CEFEF0")]
	public void NFCEOJHCMMN(uint DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFCB0", Offset = "0x5CEE6B0", VA = "0x185CEFCB0")]
	public void NFCEOJHCMMN(char DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFCB0", Offset = "0x5CEE6B0", VA = "0x185CEFCB0")]
	public void NFCEOJHCMMN(ushort DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFCB0", Offset = "0x5CEE6B0", VA = "0x185CEFCB0")]
	public void NFCEOJHCMMN(short DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFD20", Offset = "0x5CEE720", VA = "0x185CEFD20")]
	public void NFCEOJHCMMN(sbyte DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFD20", Offset = "0x5CEE720", VA = "0x185CEFD20")]
	public void NFCEOJHCMMN(byte DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFE80", Offset = "0x5CEE880", VA = "0x185CEFE80")]
	public void NFCEOJHCMMN(byte[] EEOBDBMOHPL, int LJEHDHLGGJA, int NDKEFFPEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF730", Offset = "0x5CEE130", VA = "0x185CEF730")]
	public void APBFEPNPMEK(sbyte[] EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF730", Offset = "0x5CEE130", VA = "0x185CEF730")]
	public void OIDBGAOAFGA(byte[] EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0260", Offset = "0x5CEEC60", VA = "0x185CF0260")]
	public void NFCEOJHCMMN(bool DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFB80", Offset = "0x5CEE580", VA = "0x185CEFB80")]
	public void ELNOLFBAIBA(Array ENACPDLGNMP, int BFMKEEJBOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFAA0", Offset = "0x5CEE4A0", VA = "0x185CEFAA0")]
	public void ELNOLFBAIBA(float[] DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF810", Offset = "0x5CEE210", VA = "0x185CEF810")]
	public void ELNOLFBAIBA(double[] DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF810", Offset = "0x5CEE210", VA = "0x185CEF810")]
	public void ELNOLFBAIBA(long[] DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF810", Offset = "0x5CEE210", VA = "0x185CEF810")]
	public void ELNOLFBAIBA(ulong[] DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFAA0", Offset = "0x5CEE4A0", VA = "0x185CEFAA0")]
	public void ELNOLFBAIBA(int[] DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFAA0", Offset = "0x5CEE4A0", VA = "0x185CEFAA0")]
	public void ELNOLFBAIBA(uint[] DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF9C0", Offset = "0x5CEE3C0", VA = "0x185CEF9C0")]
	public void ELNOLFBAIBA(ushort[] DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF9C0", Offset = "0x5CEE3C0", VA = "0x185CEF9C0")]
	public void ELNOLFBAIBA(short[] DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF730", Offset = "0x5CEE130", VA = "0x185CEF730")]
	public void ELNOLFBAIBA(bool[] DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF8F0", Offset = "0x5CEE2F0", VA = "0x185CEF8F0")]
	public void ELNOLFBAIBA(string[] DBOBEHLEAAE, int ELLILMGKBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFF80", Offset = "0x5CEE980", VA = "0x185CEFF80")]
	public void NFCEOJHCMMN(IPEndPoint BILAFPOFCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFE70", Offset = "0x5CEE870", VA = "0x185CEFE70")]
	public void NFCEOJHCMMN(string DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0050", Offset = "0x5CEEA50", VA = "0x185CF0050")]
	public void NFCEOJHCMMN(string DBOBEHLEAAE, int CEBCLCHGCPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BIOBBLMOKGK
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class EJAPPLNOMHH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong FOBLAHOCEHK;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x38668C0", Offset = "0x38652C0", VA = "0x1838668C0")]
		static EJAPPLNOMHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void BABFLKIGMDN(KOMLIFNACNM DGAMLJBEAIK, object KFFELFHDPEN);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CPHPNKPNNJP<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public BIOBBLMOKGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public CPHPNKPNNJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x534F2D0", Offset = "0x534DCD0", VA = "0x18534F2D0")]
		internal void PDBEHFONCLP(KOMLIFNACNM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DKIFKACHNDJ<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public BIOBBLMOKGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DKIFKACHNDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x57C5040", Offset = "0x57C3A40", VA = "0x1857C5040")]
		internal void PDBEHFONCLP(KOMLIFNACNM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly OKOBPCKFIOH DAKHDDFELON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, BABFLKIGMDN> MCJFMENMGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly JCIOBEOLKNM CJCGONFLJIC;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA000", Offset = "0x5CE8A00", VA = "0x185CEA000")]
	public BIOBBLMOKGK(int LAPHCBOIDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x28C90F0", Offset = "0x28C7AF0", VA = "0x1828C90F0", Slot = "4")]
	protected virtual ulong JKIOHBGMMME<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9E00", Offset = "0x5CE8800", VA = "0x185CE9E00", Slot = "5")]
	protected virtual BABFLKIGMDN ECHAKEJIIGD(KOMLIFNACNM DGAMLJBEAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x28C9080", Offset = "0x28C7A80", VA = "0x1828C9080", Slot = "6")]
	protected virtual void ICALIKNCFMM<T>(JCIOBEOLKNM AACOMNCLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9F30", Offset = "0x5CE8930", VA = "0x185CE9F30")]
	public void GGMJHKHKLMA(KOMLIFNACNM DGAMLJBEAIK, object KFFELFHDPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x28C8C50", Offset = "0x28C7650", VA = "0x1828C8C50")]
	public void EKIKMIMNEHM<T>(JCIOBEOLKNM AACOMNCLNFJ, T OCFPBCNHKDK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9FB0", Offset = "0x5CE89B0", VA = "0x185CE9FB0")]
	public void IKDMAJMOOAF(KOMLIFNACNM DGAMLJBEAIK, object KFFELFHDPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x28C8EC0", Offset = "0x28C78C0", VA = "0x1828C8EC0")]
	public void GAEMKMMOOBA<T>(Action<T> NJAIBGHLLKA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x28C8D00", Offset = "0x28C7700", VA = "0x1828C8D00")]
	public void GAEMKMMOOBA<T, TUserData>(Action<T, TUserData> NJAIBGHLLKA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class FFHFFDAFAGM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC2F0", Offset = "0x5CEACF0", VA = "0x185CEC2F0")]
	public FFHFFDAFAGM(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LOHCOIBCOPO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8940", Offset = "0x5CF7340", VA = "0x185CF8940")]
	public LOHCOIBCOPO(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class OKOBPCKFIOH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum OCHEIADDGEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class BMFINJIIFJB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public OCHEIADDGEO PNFBJLDEHGB;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4E28180", Offset = "0x4E26B80", VA = "0x184E28180", Slot = "4")]
		public virtual void GKMPMEFLHAB(MethodInfo FCEMFFNCLPB, MethodInfo GDMNDDOIGCL, OCHEIADDGEO ADDOHDGDFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GCNMPJCILKO(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void CLOMIPNDBCI(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		protected BMFINJIIFJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class JGOOOHICOLJ<TClass, TProperty> : BMFINJIIFJB<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> KNCFDFPEEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> IJPMLEANPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> BOHNHNEOEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> LPEMHJJLPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> MEEDFKCJIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> DNCJAMJIIDE;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x40616B0", Offset = "0x40600B0", VA = "0x1840616B0", Slot = "7")]
		public override void EDFEJAFKAHH(TClass LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4060450", Offset = "0x405EE50", VA = "0x184060450", Slot = "8")]
		public override void AOBNJAHKLNB(TClass LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x40622F0", Offset = "0x4060CF0", VA = "0x1840622F0", Slot = "9")]
		public override void GCNMPJCILKO(TClass LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4060ED0", Offset = "0x405F8D0", VA = "0x184060ED0", Slot = "10")]
		public override void CLOMIPNDBCI(TClass LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4067150", Offset = "0x4065B50", VA = "0x184067150")]
		protected TProperty[] HFGCKNMLGFI(TClass LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4067260", Offset = "0x4065C60", VA = "0x184067260")]
		protected TProperty[] JBEKNNKGBJN(TClass LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4066070", Offset = "0x4064A70", VA = "0x184066070", Slot = "4")]
		public override void GKMPMEFLHAB(MethodInfo FCEMFFNCLPB, MethodInfo GDMNDDOIGCL, OCHEIADDGEO ADDOHDGDFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x40672E0", Offset = "0x4065CE0", VA = "0x1840672E0")]
		protected JGOOOHICOLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class IGACFKNIPKJ<TClass, TProperty> : JGOOOHICOLJ<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void AMOCCOJAJAG(KOMLIFNACNM OFMNIPCGFAG, [Out] TProperty DJFBMOCHJDO);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void IBAMNFIBBDL(JCIOBEOLKNM HOMMGDFGJHF, TProperty DJFBMOCHJDO);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A220", Offset = "0x3E98C20", VA = "0x183E9A220", Slot = "5")]
		public override void LDGCBMDFIJC(TClass LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A1A0", Offset = "0x3E98BA0", VA = "0x183E9A1A0", Slot = "6")]
		public override void EKIKMIMNEHM(TClass LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3E99FA0", Offset = "0x3E989A0", VA = "0x183E99FA0", Slot = "7")]
		public override void EDFEJAFKAHH(TClass LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3E99EE0", Offset = "0x3E988E0", VA = "0x183E99EE0", Slot = "8")]
		public override void AOBNJAHKLNB(TClass LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5430", Offset = "0x3DC3E30", VA = "0x183DC5430")]
		protected IGACFKNIPKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class DNHDNLNFLMB<T> : JGOOOHICOLJ<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x57D16E0", Offset = "0x57D00E0", VA = "0x1857D16E0", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x425B1C0", Offset = "0x4259BC0", VA = "0x18425B1C0", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x57D1660", Offset = "0x57D0060", VA = "0x1857D1660", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6750", Offset = "0x3CD5150", VA = "0x183CD6750", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public DNHDNLNFLMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class LACOGJPLMCC<T> : JGOOOHICOLJ<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x425B230", Offset = "0x4259C30", VA = "0x18425B230", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x425B1C0", Offset = "0x4259BC0", VA = "0x18425B1C0", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x425B140", Offset = "0x4259B40", VA = "0x18425B140", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6750", Offset = "0x3CD5150", VA = "0x183CD6750", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public LACOGJPLMCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class ALLKJEFCJOI<T> : JGOOOHICOLJ<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3E11DF0", Offset = "0x3E107F0", VA = "0x183E11DF0", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3E11D80", Offset = "0x3E10780", VA = "0x183E11D80", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3E11D00", Offset = "0x3E10700", VA = "0x183E11D00", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3E11C90", Offset = "0x3E10690", VA = "0x183E11C90", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public ALLKJEFCJOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class JLHCPFMMBFI<T> : JGOOOHICOLJ<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x40F6930", Offset = "0x40F5330", VA = "0x1840F6930", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3E11D80", Offset = "0x3E10780", VA = "0x183E11D80", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x40F68B0", Offset = "0x40F52B0", VA = "0x1840F68B0", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3E11C90", Offset = "0x3E10690", VA = "0x183E11C90", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public JLHCPFMMBFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class DEAEPPLFHLN<T> : JGOOOHICOLJ<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5766F20", Offset = "0x5765920", VA = "0x185766F20", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x534F1E0", Offset = "0x534DBE0", VA = "0x18534F1E0", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5766EA0", Offset = "0x57658A0", VA = "0x185766EA0", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3DB79D0", Offset = "0x3DB63D0", VA = "0x183DB79D0", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public DEAEPPLFHLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class CPDJLAGNONE<T> : JGOOOHICOLJ<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x534F250", Offset = "0x534DC50", VA = "0x18534F250", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x534F1E0", Offset = "0x534DBE0", VA = "0x18534F1E0", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x534F160", Offset = "0x534DB60", VA = "0x18534F160", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3DB79D0", Offset = "0x3DB63D0", VA = "0x183DB79D0", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public CPDJLAGNONE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class BEOECAKINBO<T> : JGOOOHICOLJ<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4622EB0", Offset = "0x46218B0", VA = "0x184622EB0", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4622E40", Offset = "0x4621840", VA = "0x184622E40", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4DD91C0", Offset = "0x4DD7BC0", VA = "0x184DD91C0", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EADCB0", Offset = "0x3EAC6B0", VA = "0x183EADCB0", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public BEOECAKINBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class OOAJOOPGJGP<T> : JGOOOHICOLJ<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4622EB0", Offset = "0x46218B0", VA = "0x184622EB0", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4622E40", Offset = "0x4621840", VA = "0x184622E40", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4622DC0", Offset = "0x46217C0", VA = "0x184622DC0", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EADCB0", Offset = "0x3EAC6B0", VA = "0x183EADCB0", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public OOAJOOPGJGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class AFGMHNOHFME<T> : JGOOOHICOLJ<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3CD68B0", Offset = "0x3CD52B0", VA = "0x183CD68B0", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6840", Offset = "0x3CD5240", VA = "0x183CD6840", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3CD67C0", Offset = "0x3CD51C0", VA = "0x183CD67C0", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6750", Offset = "0x3CD5150", VA = "0x183CD6750", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public AFGMHNOHFME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class HELODBIJDHM<T> : JGOOOHICOLJ<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7B30", Offset = "0x3DB6530", VA = "0x183DB7B30", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7AC0", Offset = "0x3DB64C0", VA = "0x183DB7AC0", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7A40", Offset = "0x3DB6440", VA = "0x183DB7A40", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3DB79D0", Offset = "0x3DB63D0", VA = "0x183DB79D0", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public HELODBIJDHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class IPEDBLDCKOA<T> : JGOOOHICOLJ<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3EADE10", Offset = "0x3EAC810", VA = "0x183EADE10", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3EADDA0", Offset = "0x3EAC7A0", VA = "0x183EADDA0", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3EADD20", Offset = "0x3EAC720", VA = "0x183EADD20", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3EADCB0", Offset = "0x3EAC6B0", VA = "0x183EADCB0", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6930", Offset = "0x3CD5330", VA = "0x183CD6930")]
		public IPEDBLDCKOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class DGLBFMNEMOF<T> : IGACFKNIPKJ<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x57A10D0", Offset = "0x579FAD0", VA = "0x1857A10D0", Slot = "12")]
		protected override void IBAMNFIBBDL(JCIOBEOLKNM HOMMGDFGJHF, char DJFBMOCHJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x57A10A0", Offset = "0x579FAA0", VA = "0x1857A10A0", Slot = "11")]
		protected override void AMOCCOJAJAG(KOMLIFNACNM OFMNIPCGFAG, [Out] char DJFBMOCHJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7AA0", Offset = "0x3CF64A0", VA = "0x183CF7AA0")]
		public DGLBFMNEMOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class GBCCHKCIKGI<T> : IGACFKNIPKJ<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7A70", Offset = "0x3CF6470", VA = "0x183CF7A70", Slot = "12")]
		protected override void IBAMNFIBBDL(JCIOBEOLKNM HOMMGDFGJHF, IPEndPoint DJFBMOCHJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7A30", Offset = "0x3CF6430", VA = "0x183CF7A30", Slot = "11")]
		protected override void AMOCCOJAJAG(KOMLIFNACNM OFMNIPCGFAG, [Out] IPEndPoint DJFBMOCHJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7AA0", Offset = "0x3CF64A0", VA = "0x183CF7AA0")]
		public GBCCHKCIKGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class MFFEKCAEHEM<T> : JGOOOHICOLJ<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int KMINECLNJAO;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x446E9F0", Offset = "0x446D3F0", VA = "0x18446E9F0")]
		public MFFEKCAEHEM(int CEBCLCHGCPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x446E970", Offset = "0x446D370", VA = "0x18446E970", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x446E8F0", Offset = "0x446D2F0", VA = "0x18446E8F0", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x446E870", Offset = "0x446D270", VA = "0x18446E870", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x446E7F0", Offset = "0x446D1F0", VA = "0x18446E7F0", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class JKHHOBHANGF<T> : BMFINJIIFJB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo EKBEIPMFHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type BJBJABBAGDL;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x40E8900", Offset = "0x40E7300", VA = "0x1840E8900")]
		public JKHHOBHANGF(PropertyInfo DDHAIBOKNCF, Type DFLCEIJAJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x40E8840", Offset = "0x40E7240", VA = "0x1840E8840", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x40E8730", Offset = "0x40E7130", VA = "0x1840E8730", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x40E86D0", Offset = "0x40E70D0", VA = "0x1840E86D0", Slot = "7")]
		public override void EDFEJAFKAHH(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x40E8610", Offset = "0x40E7010", VA = "0x1840E8610", Slot = "8")]
		public override void AOBNJAHKLNB(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x40E87E0", Offset = "0x40E71E0", VA = "0x1840E87E0", Slot = "9")]
		public override void GCNMPJCILKO(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x40E8670", Offset = "0x40E7070", VA = "0x1840E8670", Slot = "10")]
		public override void CLOMIPNDBCI(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class DHHNPOFELMO<T> : JKHHOBHANGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3834160", Offset = "0x3832B60", VA = "0x183834160")]
		public DHHNPOFELMO(PropertyInfo DDHAIBOKNCF, Type DFLCEIJAJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x57BE370", Offset = "0x57BCD70", VA = "0x1857BE370", Slot = "5")]
		public override void LDGCBMDFIJC(T LFFGBPPAMDN, KOMLIFNACNM OFMNIPCGFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x57BE2C0", Offset = "0x57BCCC0", VA = "0x1857BE2C0", Slot = "6")]
		public override void EKIKMIMNEHM(T LFFGBPPAMDN, JCIOBEOLKNM HOMMGDFGJHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class HLJOLCCDPOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static HLJOLCCDPOP<T> OHJMENPNAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly BMFINJIIFJB<T>[] IECHALDLFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int DHMHGDGPEAO;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1820", Offset = "0x3DE0220", VA = "0x183DE1820")]
		public HLJOLCCDPOP(List<BMFINJIIFJB<T>> LIAHDJMBIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3DE16C0", Offset = "0x3DE00C0", VA = "0x183DE16C0")]
		public void EKIKMIMNEHM(T GKHPLGCJCPF, JCIOBEOLKNM AACOMNCLNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1770", Offset = "0x3DE0170", VA = "0x183DE1770")]
		public void LDGCBMDFIJC(T GKHPLGCJCPF, KOMLIFNACNM DGAMLJBEAIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class FCJDIMIDCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract BMFINJIIFJB<T> AMGKFNFCLFC<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private JCIOBEOLKNM KLCDJNJJIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int AEHODGAGBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, FCJDIMIDCBC> INLPKDFIBNP;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA410", Offset = "0x5CF8E10", VA = "0x185CFA410")]
	public OKOBPCKFIOH(int LAPHCBOIDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6750", Offset = "0x2CC5150", VA = "0x182CC6750")]
	private HLJOLCCDPOP<T> DFJEEFNHHMF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x28BEE50", Offset = "0x28BD850", VA = "0x1828BEE50")]
	public void PMAGAGNLFOG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7880", Offset = "0x2CC6280", VA = "0x182CC7880")]
	public bool FIOJCIMJMME<T>(KOMLIFNACNM DGAMLJBEAIK, T PIBCCEDJCCL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7920", Offset = "0x2CC6320", VA = "0x182CC7920")]
	public void KJCBMOAEMAH<T>(JCIOBEOLKNM AACOMNCLNFJ, T GKHPLGCJCPF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CGFJHNNCECM
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime EMMFONGBKKH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] HMPLPNJGGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public OGNNCLACOLG MOMJDBJONEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB750", Offset = "0x5CEA150", VA = "0x185CEB750")]
		get
		{
			return default(OGNNCLACOLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int GMHLEAPPEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB370", Offset = "0x5CE9D70", VA = "0x185CEB370")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB280", Offset = "0x5CE9C80", VA = "0x185CEB280")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KEGMCLFABAM OLNMECBPMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAC10", Offset = "0x5CE9610", VA = "0x185CEAC10")]
		get
		{
			return default(KEGMCLFABAM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAE40", Offset = "0x5CE9840", VA = "0x185CEAE40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int AEDLNDKBLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA9F0", Offset = "0x5CE93F0", VA = "0x185CEA9F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint KKJODAEFHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB2F0", Offset = "0x5CE9CF0", VA = "0x185CEB2F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? IOPJPAMEHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB2C0", Offset = "0x5CE9CC0", VA = "0x185CEB2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? HNKGELBIIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB720", Offset = "0x5CEA120", VA = "0x185CEB720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? HJEAEPINCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAE80", Offset = "0x5CE9880", VA = "0x185CEAE80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB780", Offset = "0x5CEA180", VA = "0x185CEB780")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? FALKEAEJCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC2A030", Offset = "0xC28A30", VA = "0x180C2A030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6F930", Offset = "0xA6E330", VA = "0x180A6F930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB9B0", Offset = "0x5CEA3B0", VA = "0x185CEB9B0")]
	public CGFJHNNCECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBCD0", Offset = "0x5CEA6D0", VA = "0x185CEBCD0")]
	internal CGFJHNNCECM(byte[] KKELJOOMKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB600", Offset = "0x5CEA000", VA = "0x185CEB600")]
	public static CGFJHNNCECM LKEMDEAOGKI(byte[] KKELJOOMKNM, DateTime AFIEBFAHCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAEB0", Offset = "0x5CE98B0", VA = "0x185CEAEB0")]
	internal void EJLIKKNKMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB0B0", Offset = "0x5CE9AB0", VA = "0x185CEB0B0")]
	private void FABEAIJFAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAC40", Offset = "0x5CE9640", VA = "0x185CEAC40")]
	private DateTime? EANAFFLAPAM(int LJEHDHLGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB430", Offset = "0x5CE9E30", VA = "0x185CEB430")]
	private void LGJPFFFKMMP(int LJEHDHLGGJA, DateTime? DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAB40", Offset = "0x5CE9540", VA = "0x185CEAB40")]
	private ulong BPECPMMLLLD(int LJEHDHLGGJA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAA20", Offset = "0x5CE9420", VA = "0x185CEAA20")]
	private void AHFIBKKDPCI(int LJEHDHLGGJA, ulong DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB3A0", Offset = "0x5CE9DA0", VA = "0x185CEB3A0")]
	private uint JGAFGHIALMP(int LJEHDHLGGJA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5BC2A30", Offset = "0x5BC1430", VA = "0x185BC2A30")]
	private static uint BAHFCMKMDNC(uint PHDMOAMCFBE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAAE0", Offset = "0x5CE94E0", VA = "0x185CEAAE0")]
	private static ulong BAHFCMKMDNC(ulong PHDMOAMCFBE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum OGNNCLACOLG
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
public enum KEGMCLFABAM
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EHCHCMMIFAI
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int CCEEAKEDBOI = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int JIDANAJKHGF = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int LENCKCMIFLG = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint FNIKDMLKLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int BIOAHHAGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int IFKFCLGBLFP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MMBGLMJNIOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5CEC1F0", Offset = "0x5CEABF0", VA = "0x185CEC1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC200", Offset = "0x5CEAC00", VA = "0x185CEC200")]
	public bool NCADDMBHPKC(DLFILPFHNCM ABODMHMOFAO, int DIGHAFDHPKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class GHBJLKHHBEM : DLFILPFHNCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket ABODMHMOFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly LHINCEBFGAE INAKIDHOAPG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short ALOKHNBJANP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5CECF20", Offset = "0x5CEB920", VA = "0x185CECF20", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int NDEHACACECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CECF60", Offset = "0x5CEB960", VA = "0x185CECF60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint NFBHDKFDOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5CECF40", Offset = "0x5CEB940", VA = "0x185CECF40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily CHHEJCEGBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x424CED0", Offset = "0x424B8D0", VA = "0x18424CED0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CED690", Offset = "0x5CEC090", VA = "0x185CED690")]
	public GHBJLKHHBEM(AddressFamily LAKFMCFBMOL, LHINCEBFGAE INAKIDHOAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5CECFE0", Offset = "0x5CEB9E0", VA = "0x185CECFE0", Slot = "8")]
	public bool NGGMPBJDGGI(IPEndPoint BILAFPOFCHL, HBPOMBPNDAI MAALHLFNNOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5CECF80", Offset = "0x5CEB980", VA = "0x185CECF80", Slot = "9")]
	public int FFLPBEAIFMC(byte[] BLNHMFAPOOE, int LJEHDHLGGJA, int BKEGNEKBPFA, IPEndPoint IPBPKKCDEIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5CED5A0", Offset = "0x5CEBFA0", VA = "0x185CED5A0", Slot = "10")]
	public int OICCOMJKNDM(byte[] BLNHMFAPOOE, EndPoint BAAMLONJEBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CECFC0", Offset = "0x5CEB9C0", VA = "0x185CECFC0", Slot = "11")]
	public void GOHDNOFEPAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface DLFILPFHNCM
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short ALOKHNBJANP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int NDEHACACECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint NFBHDKFDOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily CHHEJCEGBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NGGMPBJDGGI(IPEndPoint BILAFPOFCHL, HBPOMBPNDAI MAALHLFNNOF);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int FFLPBEAIFMC(byte[] BLNHMFAPOOE, int LJEHDHLGGJA, int BKEGNEKBPFA, IPEndPoint IPBPKKCDEIC);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OICCOMJKNDM(byte[] BLNHMFAPOOE, EndPoint IPBPKKCDEIC);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GOHDNOFEPAD();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct GKAPICKDMII : IEquatable<GKAPICKDMII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long PDGOEEGMAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long IGDILGOODHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long ILELBHMEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int GKHOOHFNCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int ICBNIHGJHBA;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5CED8D0", Offset = "0x5CEC2D0", VA = "0x185CED8D0")]
	public GKAPICKDMII(byte[] JPMGDOMJOOJ, int GFCOFLBPHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x874E20", Offset = "0x873820", VA = "0x180874E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5CED890", Offset = "0x5CEC290", VA = "0x185CED890", Slot = "4")]
	public bool Equals(GKAPICKDMII HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5CED7E0", Offset = "0x5CEC1E0", VA = "0x185CED7E0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class IFEDKIECMGB : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] DNINMKDJBNE;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class BLPABKCEMJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int CNODBMDDHJF;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
	protected BLPABKCEMJB(int CDOOKFOJBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LLEGEBMIGOM(IPEndPoint BILAFPOFCHL, byte[] EEOBDBMOHPL, int LJEHDHLGGJA, int NDKEFFPEPII);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void KDAMCJFBCDK(IPEndPoint BILAFPOFCHL, byte[] EEOBDBMOHPL, int LJEHDHLGGJA, int NDKEFFPEPII);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FOPNECBFEFN : BLPABKCEMJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private byte[] LDDEKIBHION;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator CFKOMHBEOAI;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4C90", Offset = "0x1FC3690", VA = "0x181FC4C90")]
	public FOPNECBFEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC3E0", Offset = "0x5CEADE0", VA = "0x185CEC3E0")]
	public void ANNKELNOIHF(IPEndPoint BILAFPOFCHL, byte[] LDDEKIBHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC590", Offset = "0x5CEAF90", VA = "0x185CEC590")]
	public void EPCHOKMKFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC9E0", Offset = "0x5CEB3E0", VA = "0x185CEC9E0", Slot = "4")]
	public override void LLEGEBMIGOM(IPEndPoint BILAFPOFCHL, byte[] EEOBDBMOHPL, int LJEHDHLGGJA, int NDKEFFPEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC670", Offset = "0x5CEB070", VA = "0x185CEC670", Slot = "5")]
	public override void KDAMCJFBCDK(IPEndPoint BILAFPOFCHL, byte[] EEOBDBMOHPL, int LJEHDHLGGJA, int NDKEFFPEPII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct GPOLCBAIMNJ
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void GDAOLNKBCIC([NoAlias] byte* MDKPFCDHCAO, [NoAlias] byte* LDDEKIBHION, [NoAlias] byte* FOLKELLCFJF, int NDKEFFPEPII);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class NCOJIAMGJPI
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5CFFFD0", Offset = "0x5CFE9D0", VA = "0x185CFFFD0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5CFFE70", Offset = "0x5CFE870", VA = "0x185CFFE70")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5D00100", Offset = "0x5CFEB00", VA = "0x185D00100")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5CFFC30", Offset = "0x5CFE630", VA = "0x185CFFC30")]
		public unsafe static void EDIAJIJOMBB([NoAlias] byte* MDKPFCDHCAO, [NoAlias] byte* LDDEKIBHION, [NoAlias] byte* FOLKELLCFJF, int NDKEFFPEPII)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private unsafe fixed uint LDDEKIBHION[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private unsafe fixed uint FOLKELLCFJF[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private unsafe fixed uint AMPFBBBPONI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private unsafe fixed uint HNABEEEHABJ[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private unsafe fixed uint OKLJINEPPLJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint AENFNLFPMMA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint DAGKAJBJGHE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private uint HDDNIKCNNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint DMNKJLDAGMM[8];

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDB30", Offset = "0x5CEC530", VA = "0x185CEDB30")]
	private void GLMNPCAHJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDBB0", Offset = "0x5CEC5B0", VA = "0x185CEDBB0")]
	private uint IEMEDILKDDC(uint CGDFPKFKHGF, int IOMDNMODICA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8CA0", Offset = "0x5CE76A0", VA = "0x185CE8CA0")]
	private void AJHNMGFJDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8D50", Offset = "0x5CE7750", VA = "0x185CE8D50")]
	private void DFKNHBLAHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8F60", Offset = "0x5CE7960", VA = "0x185CE8F60")]
	private void HOCADLJNOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8BA0", Offset = "0x5CE75A0", VA = "0x185CE8BA0")]
	private void ADMKFJOIDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDBE0", Offset = "0x5CEC5E0", VA = "0x185CEDBE0")]
	private void JEOBDOHGIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDDA0", Offset = "0x5CEC7A0", VA = "0x185CEDDA0")]
	private unsafe void LOJOOBBBMLD(byte* MDKPFCDHCAO, uint* LDDEKIBHION, uint* FOLKELLCFJF, int NDKEFFPEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDC40", Offset = "0x5CEC640", VA = "0x185CEDC40")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void KHJLDDNNFAP([NoAlias] byte* MDKPFCDHCAO, [NoAlias] byte* LDDEKIBHION, [NoAlias] byte* FOLKELLCFJF, int NDKEFFPEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDCC0", Offset = "0x5CEC6C0", VA = "0x185CEDCC0")]
	public static void KHJLDDNNFAP(Span<byte> MDKPFCDHCAO, Span<byte> LDDEKIBHION, Span<byte> FOLKELLCFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDA30", Offset = "0x5CEC430", VA = "0x185CEDA30")]
	public static void CLGLONDAINC(Span<byte> MDKPFCDHCAO, Span<byte> LDDEKIBHION, Span<byte> FOLKELLCFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5CED9C0", Offset = "0x5CEC3C0", VA = "0x185CED9C0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BNAILICDMBO([NoAlias] byte* MDKPFCDHCAO, [NoAlias] byte* LDDEKIBHION, [NoAlias] byte* FOLKELLCFJF, int NDKEFFPEPII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5D001B0", Offset = "0x5CFEBB0", VA = "0x185D001B0")]
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
