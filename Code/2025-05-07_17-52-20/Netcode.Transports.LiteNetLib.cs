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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, FGDAGALKDON
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum KJFPIICOPBK
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
		private NetworkManager INFDPAGNKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool HBEFFHMCKIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, MNEMGBAJIJH> HMFJPMNJGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CPNPKLEEMCO AGLDMAELEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch KFHIKDMCIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] DMFJMMGBNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private KJFPIICOPBK HBFKMEIGNOL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong OKOAGGNMHLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MAFIGLIJNAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC520", Offset = "0x6ECB520", VA = "0x186ECC520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBAF0", Offset = "0x6ECAAF0", VA = "0x186ECBAF0")]
		public void RecRoom_SetEncryptionInfo(ulong HGNOFEMICKA, byte[] OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBAD0", Offset = "0x6ECAAD0", VA = "0x186ECBAD0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB980", Offset = "0x6ECA980", VA = "0x186ECB980")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC420", Offset = "0x6ECB420", VA = "0x186ECC420")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBC10", Offset = "0x6ECAC10", VA = "0x186ECBC10", Slot = "6")]
		public override void Send(ulong GMGHHBHDHEG, ArraySegment<byte> APDBNIMCPID, NetworkDelivery FHGCPGFOBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBA90", Offset = "0x6ECAA90", VA = "0x186ECBA90", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong GMGHHBHDHEG, [Out] ArraySegment<byte> DGHLABNPIEC, [Out] float HKLECHOBMHF)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBF00", Offset = "0x6ECAF00", VA = "0x186ECBF00", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC340", Offset = "0x6ECB340", VA = "0x186ECC340", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB1F0", Offset = "0x6ECA1F0", VA = "0x186ECB1F0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong GMGHHBHDHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB100", Offset = "0x6ECA100", VA = "0x186ECB100", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB510", Offset = "0x6ECA510", VA = "0x186ECB510", Slot = "13")]
		public override ulong GetCurrentRtt(ulong GMGHHBHDHEG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBE90", Offset = "0x6ECAE90", VA = "0x186ECBE90", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB5B0", Offset = "0x6ECA5B0", VA = "0x186ECB5B0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager INFDPAGNKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB8B0", Offset = "0x6ECA8B0", VA = "0x186ECB8B0")]
		private NAAOLECOJPN OFANACBMEAO(NetworkDelivery MLCOGCMJLBB)
		{
			return default(NAAOLECOJPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB7F0", Offset = "0x6ECA7F0", VA = "0x186ECB7F0", Slot = "16")]
		private void OENCMONFKAL(MNEMGBAJIJH MNFIBPMCHAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB440", Offset = "0x6ECA440", VA = "0x186ECB440", Slot = "17")]
		private void GIGIIJCENJA(MNEMGBAJIJH MNFIBPMCHAA, LAIOFOJOKKD DIGGJHFMOIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "18")]
		private void KOAPCBECMJJ(IPEndPoint KKNOGDEEABI, SocketError LEKIFMHNDHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6ECAEF0", Offset = "0x6EC9EF0", VA = "0x186ECAEF0", Slot = "19")]
		private void ALACBJIFHOC(MNEMGBAJIJH MNFIBPMCHAA, PCJBEMBIPHI HBMFONPEIJC, byte LMKBIAOABBJ, NAAOLECOJPN ENEPCCBENPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB360", Offset = "0x6ECA360", VA = "0x186ECB360")]
		private void GCANFNCJHNI(int CFNMLMNHCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "20")]
		private void JOJNDKEDLOP(IPEndPoint ONGBEKHKLMA, PCJBEMBIPHI HBMFONPEIJC, LOMACBPPNPL OAOFDBDEHAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "21")]
		private void MJEHIEOGOJE(MNEMGBAJIJH MNFIBPMCHAA, int LGGKLAOJGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB300", Offset = "0x6ECA300", VA = "0x186ECB300", Slot = "22")]
		private void EHHGIELBNOG(FIDNDDKHCPB HOOJNAMGGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB7C0", Offset = "0x6ECA7C0", VA = "0x186ECB7C0")]
		private ulong KDOADLCPABC(MNEMGBAJIJH MNFIBPMCHAA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBA70", Offset = "0x6ECAA70", VA = "0x186ECBA70")]
		private static int PFHCPOCNDFA(float EPOJNFBFHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC440", Offset = "0x6ECB440", VA = "0x186ECC440")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class EDLAECGIMAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly MNEMGBAJIJH MOPGLPDDJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly ConcurrentQueue<FIFOBIGMFLH> JLDAMPIGKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int OODPPEIFJFL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4C20", Offset = "0x6EC3C20", VA = "0x186EC4C20")]
	protected EDLAECGIMAF(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4B80", Offset = "0x6EC3B80", VA = "0x186EC4B80")]
	public void OGAHDHCDJIF(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4B00", Offset = "0x6EC3B00", VA = "0x186EC4B00")]
	protected void MJCFJPHJHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4BE0", Offset = "0x6EC3BE0", VA = "0x186EC4BE0")]
	public bool OJPFABFICIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool IGPNBIJNGKA();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool LDNIGPACMDM(FIFOBIGMFLH AHEHGOPPDFG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum FINEKIACOJD
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
public class FIDNDDKHCPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CPNPKLEEMCO MDMBNHEDAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int CBNGDJBAOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal EEGAKGINIBB MCPGKMOCFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly IPEndPoint EOEKAAKHGEP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal FINEKIACOJD CIJAJIIDNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA18A40", Offset = "0xA17A40", VA = "0x180A18A40")]
		[CompilerGenerated]
		get
		{
			return default(FINEKIACOJD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD541A0", Offset = "0xD531A0", VA = "0x180D541A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5610", Offset = "0x6EC4610", VA = "0x186EC5610")]
	internal void BNEFOBIOFJK(EEGAKGINIBB GOJPAMDHFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EC56D0", Offset = "0x6EC46D0", VA = "0x186EC56D0")]
	private bool MLMJPCNBNOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5700", Offset = "0x6EC4700", VA = "0x186EC5700")]
	internal FIDNDDKHCPB(IPEndPoint ONGBEKHKLMA, EEGAKGINIBB LBHFDFODEKG, CPNPKLEEMCO LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5670", Offset = "0x6EC4670", VA = "0x186EC5670")]
	public MNEMGBAJIJH IKGNGPJBLBP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LOMACBPPNPL
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum PHMOOHPGGNH
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
public struct LAIOFOJOKKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public PHMOOHPGGNH CPOKHNFGIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public SocketError OAOHMKDLBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public PCJBEMBIPHI ILNFHILHDCE;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FGDAGALKDON
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJGCIIKENEA(MNEMGBAJIJH MNFIBPMCHAA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLKMEHOFBKB(MNEMGBAJIJH MNFIBPMCHAA, LAIOFOJOKKD DIGGJHFMOIO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKPCODNBJBM(IPEndPoint KKNOGDEEABI, SocketError LEKIFMHNDHN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void POINHKNCAEM(MNEMGBAJIJH MNFIBPMCHAA, PCJBEMBIPHI HBMFONPEIJC, byte LMKBIAOABBJ, NAAOLECOJPN ENEPCCBENPP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ALEJKIDAOIJ(IPEndPoint ONGBEKHKLMA, PCJBEMBIPHI HBMFONPEIJC, LOMACBPPNPL OAOFDBDEHAG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LMCFPEGLCOC(MNEMGBAJIJH MNFIBPMCHAA, int LGGKLAOJGAK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHBEDDFKHLJ(FIDNDDKHCPB HOOJNAMGGBC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JKADCIHCIKD
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKKOKKLHDIA(MNEMGBAJIJH MNFIBPMCHAA, object GCLNNHGNABG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KDEJFNPDGCD
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGKHAMJMOPC(MGLNOHNAOEM AHEHGOPPDFG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NDHCAHKDKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGBNEAMAKPC(MNEMGBAJIJH MNFIBPMCHAA, IPEndPoint EBBEBEPLEHF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class EEGAKGINIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const int FPCCGOIMBCN = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly long NENIGKKGMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte NGHAIMJPLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly byte[] AFKENCKFGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly ACLDEKFAJGB HCNIDPKECHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly int BICLPLOEMPI;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5120", Offset = "0x6EC4120", VA = "0x186EC5120")]
	private EEGAKGINIBB(long OJHCAODIBFH, byte AEAABDJMLPB, int GOGGPBKDKBC, byte[] DJBBMLKFGDN, ACLDEKFAJGB APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6EC50C0", Offset = "0x6EC40C0", VA = "0x186EC50C0")]
	public static int NJEDNCDCGMM(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4EA0", Offset = "0x6EC3EA0", VA = "0x186EC4EA0")]
	public static EEGAKGINIBB ECDODHDJHDC(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4CC0", Offset = "0x6EC3CC0", VA = "0x186EC4CC0")]
	public static FIFOBIGMFLH DOJIAKEFFIK(KLILFFCJMEE JPFGPPEMEDD, SocketAddress HBAECDPKDCL, long MIMJNJHAEKK, int GOGGPBKDKBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class BLNPLOGBMCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly long NENIGKKGMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly byte NGHAIMJPLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly int BICLPLOEMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool BAEGDLDIPGL;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6EBCB30", Offset = "0x6EBBB30", VA = "0x186EBCB30")]
	private BLNPLOGBMCI(long OJHCAODIBFH, byte AEAABDJMLPB, int CGKJHPJNJFE, bool JOICNGLCKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC9E0", Offset = "0x6EBB9E0", VA = "0x186EBC9E0")]
	public static BLNPLOGBMCI ECDODHDJHDC(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC7F0", Offset = "0x6EBB7F0", VA = "0x186EBC7F0")]
	public static FIFOBIGMFLH DOJIAKEFFIK(long MIMJNJHAEKK, byte NDOBFGLFBOD, int HAECKMHOENN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC8E0", Offset = "0x6EBB8E0", VA = "0x186EBC8E0")]
	public static FIFOBIGMFLH ECANOMPJKAI(MNEMGBAJIJH MNFIBPMCHAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GHINCNAMPOD
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OCEMBADNJOB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPMOBHFLIEC(IPEndPoint MABIJJDFFMN, IPEndPoint ONGBEKHKLMA, string EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFCDIMIAABD(IPEndPoint OFOCINKLMPP, GHINCNAMPOD MLCOGCMJLBB, string EJJDDFFADPC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MJKNNLAIOLG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct LJOKHEPAFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IPEndPoint PPGBPMLFGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint EOEKAAKHGEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string IOEHGJLONAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct OLDGLOAOELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint NKLGJEKNDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public GHINCNAMPOD KFIKOGBAHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string IOEHGJLONAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class NHFEBNMBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint AFPOOIIDKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string IOEHGJLONAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NHFEBNMBJJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class JBCNMHHEGHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint AFPOOIIDKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint EHPNFGNMAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string IOEHGJLONAP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JBCNMHHEGHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class ECKFIAKFHIC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IOEHGJLONAP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HFAFNHKHPMO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1F0", Offset = "0x9F91F0", VA = "0x1809FA1F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ECKFIAKFHIC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly CPNPKLEEMCO PMPBGMKPGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ConcurrentQueue<LJOKHEPAFFJ> DGBDHLFJEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ConcurrentQueue<OLDGLOAOELL> IOOMKCGDBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ACLDEKFAJGB HLMMKCAEHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly KLILFFCJMEE LAJJLKHFJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FFJNGFDJPPP LIEMJKMJIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private OCEMBADNJOB NLAMDCIIOLF;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public const int BOBPNAGGBAL = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool NGOLPDIFFGE;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEA10", Offset = "0x6ECDA10", VA = "0x186ECEA10")]
	internal MJKNNLAIOLG(CPNPKLEEMCO KDGMKMCIFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE6F0", Offset = "0x6ECD6F0", VA = "0x186ECE6F0")]
	internal void HIOLPNEGBHI(IPEndPoint COJOMIFMAHK, FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3912EB0", Offset = "0x3911EB0", VA = "0x183912EB0")]
	private void KJNJFNLADEB<T>(T AHEHGOPPDFG, IPEndPoint FCPOJLOEIEO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE560", Offset = "0x6ECD560", VA = "0x186ECE560")]
	private void BPMOBHFLIEC(NHFEBNMBJJB EOFLOFDELEP, IPEndPoint COJOMIFMAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE400", Offset = "0x6ECD400", VA = "0x186ECE400")]
	private void BHJPHCCPGED(JBCNMHHEGHC EOFLOFDELEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE870", Offset = "0x6ECD870", VA = "0x186ECE870")]
	private void KIACGNJDAMK(ECKFIAKFHIC EOFLOFDELEP, IPEndPoint COJOMIFMAHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum NAAOLECOJPN : byte
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
public enum LPBJFKOBPDM : long
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FPDEAHADKCL
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal static readonly int[] PGMIJJCAMKI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly int IFJPJDPGGEE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly int GMNOHAMIFMF;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DBBGMPAHMGB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4AF0", Offset = "0x6EC3AF0", VA = "0x186EC4AF0")]
	public DBBGMPAHMGB(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MMAGIPPPDDP : DBBGMPAHMGB
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4AF0", Offset = "0x6EC3AF0", VA = "0x186EC4AF0")]
	public MMAGIPPPDDP(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KAGMBFHKPLL
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
public interface FBMELOFCGOF
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKIKAKJPIDP(KAGMBFHKPLL GIPBFCLFIAF, string ANKDPLMACBD, params object[] ODJGLJIHJOP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class HJIIGIEHONK
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static FBMELOFCGOF OKKKLCKJJGE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly object HJBHAMIBPNE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7350", Offset = "0x6EC6350", VA = "0x186EC7350")]
	private static void EFAOPIDIALB(KAGMBFHKPLL OPMIFCIPGGP, string ANKDPLMACBD, params object[] ODJGLJIHJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7580", Offset = "0x6EC6580", VA = "0x186EC7580")]
	internal static void FIKJIKNLJKJ(string ANKDPLMACBD, params object[] ODJGLJIHJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6EC75E0", Offset = "0x6EC65E0", VA = "0x186EC75E0")]
	internal static void KGMFHKFNMGK(string ANKDPLMACBD, params object[] ODJGLJIHJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7640", Offset = "0x6EC6640", VA = "0x186EC7640")]
	internal static void OFENLCFMGBI(string ANKDPLMACBD, params object[] ODJGLJIHJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum EEBGGGOLOIC
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PCJBEMBIPHI : ACLDEKFAJGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private FIFOBIGMFLH JKAFKKEJILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CPNPKLEEMCO CMJMEGFPJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LJDFJCLOMPJ JDFCEEDBKBA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED34E0", Offset = "0x6ED24E0", VA = "0x186ED34E0")]
	internal PCJBEMBIPHI(CPNPKLEEMCO PAKPDHLKNJE, LJDFJCLOMPJ DOHIDBPJPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3470", Offset = "0x6ED2470", VA = "0x186ED3470")]
	internal void PKAFLAIKAEK(FIFOBIGMFLH AHEHGOPPDFG, int NKKLBAMEPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED33C0", Offset = "0x6ED23C0", VA = "0x186ED33C0")]
	internal void IIIJEPCDNFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3440", Offset = "0x6ED2440", VA = "0x186ED3440")]
	public void KEOEKDADFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class LJDFJCLOMPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum KEJGBPFBNCM
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
	public LJDFJCLOMPJ ACAGEKDEDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public KEJGBPFBNCM KFIKOGBAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public MNEMGBAJIJH MOPGLPDDJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public IPEndPoint EOEKAAKHGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object NCNBKJJHLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int JJGJNKLMNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SocketError MAOIEOGFFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public PHMOOHPGGNH DCEOBMGIPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public FIDNDDKHCPB ECHKAMHFGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NAAOLECOJPN NJJNDOHLDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte KFOAOMHNAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly PCJBEMBIPHI GECLNJIHINI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA840", Offset = "0x6EC9840", VA = "0x186ECA840")]
	public LJDFJCLOMPJ(CPNPKLEEMCO PAKPDHLKNJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CPNPKLEEMCO : IEnumerable<MNEMGBAJIJH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class NGMLHAPIHMI : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2F30", Offset = "0x6ED1F30", VA = "0x186ED2F30", Slot = "4")]
		public bool Equals(IPEndPoint CEJAAIDLEPA, IPEndPoint IMNDAJIDDFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4062190", Offset = "0x4061190", VA = "0x184062190", Slot = "5")]
		public int GetHashCode(IPEndPoint BOMDCGFKGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NGMLHAPIHMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct LLCOJNMEKPH : IEnumerator<MNEMGBAJIJH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly MNEMGBAJIJH JFAHBIHKLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private MNEMGBAJIJH LECKMMLLKOI;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MNEMGBAJIJH FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD7C960", Offset = "0xD7B960", VA = "0x180D7C960", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD7C960", Offset = "0xD7B960", VA = "0x180D7C960", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x19C7190", Offset = "0x19C6190", VA = "0x1819C7190")]
		public LLCOJNMEKPH(MNEMGBAJIJH NOOBIPOJNNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6ECA8E0", Offset = "0x6EC98E0", VA = "0x186ECA8E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6ECA930", Offset = "0x6EC9930", VA = "0x186ECA930", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Thread FJHDFGAEDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool JIPODFNLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool LNGAENCJFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private DHEBMGADODK DHAJCDMMGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AutoResetEvent JNJDNLEPNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Queue<LJDFJCLOMPJ> GAICPDMIDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<LJDFJCLOMPJ> PEIIPGLIJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private LJDFJCLOMPJ CMABDENGFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly FGDAGALKDON DMIABODAMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly JKADCIHCIKD NPODIHMDIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly KDEJFNPDGCD PLFJBPEDEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly NDHCAHKDKGD AFFHHECADDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Dictionary<IPEndPoint, MNEMGBAJIJH> KKAOJDEKCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, FIDNDDKHCPB> DAFLJJGELGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, EMMCFEEBFFD> FLILJIONIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ReaderWriterLockSlim ODCBKBECEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private MNEMGBAJIJH KGPCPGEPMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int DIOBJENPECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly List<MNEMGBAJIJH> CBKDHFBBLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private MNEMGBAJIJH[] HAODCNHHKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly GHCLBHLCCLF KHNAMHAFAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int BEHHDEEPINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private ConcurrentQueue<int> MGNCIJOAFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private byte JPHMOBAFKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly object BFLFKNPIGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool DJNHPCOPFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool CAKBOIBFDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int DJEBPJCBJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int NCFCNNCJPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int CADJKMHMNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CGKALBFLKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool EKOCFPLLNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool COCHDEGEEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int LJIKOMOPPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int GGPCFKIEIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int BBFGOKKOGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool NGOLPDIFFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool BMDEMKFDMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF6")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool PIHGCCAALGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF7")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool IGIPKGJDOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int OKAEGJLNIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int CMCGFHAHCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool BHLAICMPAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly HNCAAPNAFHF FBMJEKKAMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool GIPOJJNKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly MJKNNLAIOLG PNJKAEJCOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool KCKHENHACBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public EEBGGGOLOIC NKGFPCBJEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int FNENHFDNEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool PLBFLIMOCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x135")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool IJCPMINIOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x136")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool BKGLOHDJPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x137")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool GMDMFKBMMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private FIFOBIGMFLH PGMNAODNGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int POHNMHGDHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object AIJFBFMHBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private FIFOBIGMFLH DKEINKDHFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int ONBHELGMGJK;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const int HIDCOCAKADN = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private const int PKDOCANABIJ = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private BAGLJBFNJGF KONJKGEHANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private BAGLJBFNJGF HDDCECEKJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Thread CEHIJONNFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Thread EOPPDHJBAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IPEndPoint PNHLHGGFPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private IPEndPoint ONKLBEFJFNB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[ThreadStatic]
	private static byte[] FOBOGBAMGKG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[ThreadStatic]
	private static byte[] OLLGJGGIIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<NLGPHPHHFME, IPEndPoint> PDPJFIFPDKA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly IPAddress KHCKNAGCICK;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly bool BJLDJGJOKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public int AHMKHHBKDHB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FGHDFINEAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x142F470", Offset = "0x142E470", VA = "0x18142F470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A270", Offset = "0x1E29270", VA = "0x181E2A270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GDEIFOBJPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x15385B0", Offset = "0x15375B0", VA = "0x1815385B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A310", Offset = "0x1E29310", VA = "0x181E2A310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte HAGAOMCNAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xF34DA0", Offset = "0xF33DA0", VA = "0x180F34DA0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PGIEEFDNANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6EC0790", Offset = "0x6EBF790", VA = "0x186EC0790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short BMJOLJECHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6EC27B0", Offset = "0x6EC17B0", VA = "0x186EC27B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE9D0", Offset = "0x6EBD9D0", VA = "0x186EBE9D0")]
	public void BPAHDNMIAGA(IPEndPoint KKNOGDEEABI, byte[] OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EBCE70", Offset = "0x6EBBE70", VA = "0x186EBCE70")]
	public void ANPOONCFBLN(IPEndPoint KKNOGDEEABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1130", Offset = "0x6EC0130", VA = "0x186EC1130")]
	private bool HJIGNFFCIGB(IPEndPoint KKNOGDEEABI, [Out] MNEMGBAJIJH MNFIBPMCHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1740", Offset = "0x6EC0740", VA = "0x186EC1740")]
	private void IMFJNFAPPFO(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3770", Offset = "0x6EC2770", VA = "0x186EC3770")]
	private void MOEFNNJAADP(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBED70", Offset = "0x6EBDD70", VA = "0x186EBED70")]
	private void DEGJOOMPJIN(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4490", Offset = "0x6EC3490", VA = "0x186EC4490")]
	public CPNPKLEEMCO(FGDAGALKDON LPLPDJPCKCO, [Optional] GHCLBHLCCLF JPEOIOHLJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2580", Offset = "0x6EC1580", VA = "0x186EC2580")]
	internal void JHAJONFLLBB(MNEMGBAJIJH KLPODKEJFAN, int LGGKLAOJGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0910", Offset = "0x6EBF910", VA = "0x186EC0910")]
	internal void HBOLKHDKFME(MNEMGBAJIJH KLPODKEJFAN, object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1440", Offset = "0x6EC0440", VA = "0x186EC1440")]
	internal void HPIDLACOLOD(MNEMGBAJIJH MNFIBPMCHAA, PHMOOHPGGNH DKBCGBFNIGO, SocketError CIMEBBDHLON, FIFOBIGMFLH NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6EBD140", Offset = "0x6EBC140", VA = "0x186EBD140")]
	private void BFEPDBANIDB(MNEMGBAJIJH MNFIBPMCHAA, PHMOOHPGGNH DKBCGBFNIGO, SocketError CIMEBBDHLON, bool ECOALLGHBMI, byte[] APDBNIMCPID, int IPAELMFFKOA, int JAALIADHHOC, FIFOBIGMFLH NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3390", Offset = "0x6EC2390", VA = "0x186EC3390")]
	private void MNCCMHIPNHG(LJDFJCLOMPJ.KEJGBPFBNCM MLCOGCMJLBB, [Optional] MNEMGBAJIJH MNFIBPMCHAA, [Optional] IPEndPoint ONGBEKHKLMA, SocketError LELALGHIBFL = SocketError.Success, int LGGKLAOJGAK = 0, PHMOOHPGGNH JPBCGMMGHCE = PHMOOHPGGNH.ConnectionFailed, [Optional] FIDNDDKHCPB NDDJIHPKIOC, NAAOLECOJPN ENEPCCBENPP = NAAOLECOJPN.Unreliable, byte LMKBIAOABBJ = 0, [Optional] FIFOBIGMFLH OCKPFDJIOGF, [Optional] object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0960", Offset = "0x6EBF960", VA = "0x186EC0960")]
	private void HGJPKNDBGCL(LJDFJCLOMPJ DOHIDBPJPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3B30", Offset = "0x6EC2B30", VA = "0x186EC3B30")]
	internal void PIMDOGGPBLA(LJDFJCLOMPJ DOHIDBPJPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3F60", Offset = "0x6EC2F60", VA = "0x186EC3F60")]
	private void PJHFHHDOHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3C40", Offset = "0x6EC2C40", VA = "0x186EC3C40")]
	private void PJBLKOMEIDI(int PHKGBBDCCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF040", Offset = "0x6EBE040", VA = "0x186EBF040")]
	internal MNEMGBAJIJH EFIGKMDNLBB(FIDNDDKHCPB HOOJNAMGGBC, byte[] ABPGKFCFHHH, int IPAELMFFKOA, int DDGBDMFPMAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2500", Offset = "0x6EC1500", VA = "0x186EC2500")]
	private int JGMPFJDJHIB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2B50", Offset = "0x6EC1B50", VA = "0x186EC2B50")]
	private void MCDIOJBNFJL(IPEndPoint ONGBEKHKLMA, MNEMGBAJIJH OOFAPNLCPNO, EEGAKGINIBB MBFHPOPDIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EBD5E0", Offset = "0x6EBC5E0", VA = "0x186EBD5E0")]
	private void BNAGGJOGKLG(FIFOBIGMFLH AHEHGOPPDFG, IPEndPoint ONGBEKHKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2870", Offset = "0x6EC1870", VA = "0x186EC2870")]
	internal void LFLOPPHDNEB(FIFOBIGMFLH AHEHGOPPDFG, NAAOLECOJPN OAKFMPLKGOM, byte LMKBIAOABBJ, int NKKLBAMEPIK, MNEMGBAJIJH KLPODKEJFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6EC24D0", Offset = "0x6EC14D0", VA = "0x186EC24D0")]
	public bool JDIKNMDACEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC24E0", Offset = "0x6EC14E0", VA = "0x186EC24E0")]
	public bool JDIKNMDACEI(IPAddress KLAJEDKMENO, IPAddress CNENKFNNIHC, int JHMPKACOBFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1C80", Offset = "0x6EC0C80", VA = "0x186EC1C80")]
	public bool JDIKNMDACEI(int JHMPKACOBFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3980", Offset = "0x6EC2980", VA = "0x186EC3980")]
	public void NOJLCHEGFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC01F0", Offset = "0x6EBF1F0", VA = "0x186EC01F0")]
	public MNEMGBAJIJH GGPPMIKMDOH(string OAHKGLFKJGM, int JHMPKACOBFK, string OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC06B0", Offset = "0x6EBF6B0", VA = "0x186EC06B0")]
	public MNEMGBAJIJH GGPPMIKMDOH(string OAHKGLFKJGM, int JHMPKACOBFK, KLILFFCJMEE HHDFMOPIDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6EC02D0", Offset = "0x6EBF2D0", VA = "0x186EC02D0")]
	public MNEMGBAJIJH GGPPMIKMDOH(IPEndPoint FCPOJLOEIEO, KLILFFCJMEE HHDFMOPIDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF660", Offset = "0x6EBE660", VA = "0x186EBF660")]
	public void EJJCFNDELCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF670", Offset = "0x6EBE670", VA = "0x186EBF670")]
	public void EJJCFNDELCF(bool IAFHCGGNMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6EBD090", Offset = "0x6EBC090", VA = "0x186EBD090")]
	public void BAHAPIFFHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6EBCFC0", Offset = "0x6EBBFC0", VA = "0x186EBCFC0")]
	public void BAHAPIFFHNH(byte[] APDBNIMCPID, int IPAELMFFKOA, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6EBD5A0", Offset = "0x6EBC5A0", VA = "0x186EBD5A0")]
	public void BFEPDBANIDB(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6EBD560", Offset = "0x6EBC560", VA = "0x186EBD560")]
	public void BFEPDBANIDB(MNEMGBAJIJH MNFIBPMCHAA, byte[] APDBNIMCPID, int IPAELMFFKOA, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6EC42B0", Offset = "0x6EC32B0", VA = "0x186EC42B0", Slot = "4")]
	private IEnumerator<MNEMGBAJIJH> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4340", Offset = "0x6EC3340", VA = "0x186EC4340", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1B90", Offset = "0x6EC0B90", VA = "0x186EC1B90")]
	private FIFOBIGMFLH IOEGFBNNMOL(LHMBLOPDOMI LLPAKFGNDOB, int CFNMLMNHCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1AB0", Offset = "0x6EC0AB0", VA = "0x186EC1AB0")]
	private FIFOBIGMFLH IOEGFBNNMOL(LHMBLOPDOMI LLPAKFGNDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBCC20", Offset = "0x6EBBC20", VA = "0x186EBCC20")]
	internal FIFOBIGMFLH ACIDLGIDADA(int CFNMLMNHCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC11D0", Offset = "0x6EC01D0", VA = "0x186EC11D0")]
	internal void HKMDKOMIFJG(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC43D0", Offset = "0x6EC33D0", VA = "0x186EC43D0")]
	static CPNPKLEEMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x142F470", Offset = "0x142E470", VA = "0x18142F470")]
	private bool DJLLMFIFBBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6EBEBF0", Offset = "0x6EBDBF0", VA = "0x186EBEBF0")]
	private void CFLKLMLFENB(IPEndPoint LNANBGJCPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6EC07B0", Offset = "0x6EBF7B0", VA = "0x186EC07B0")]
	private void GPGBBIAGGPA(IPEndPoint LNANBGJCPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6EC37D0", Offset = "0x6EC27D0", VA = "0x186EC37D0")]
	private bool NELGALJFKCN(SocketException APEPCFJIAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1A90", Offset = "0x6EC0A90", VA = "0x186EC1A90")]
	private void INPJNMKCDFN(DHEBMGADODK KDGMKMCIFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1480", Offset = "0x6EC0480", VA = "0x186EC1480")]
	private void IEONLDINICE(BAGLJBFNJGF KDGMKMCIFMH, EndPoint KPCJMIFNEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3000", Offset = "0x6EC2000", VA = "0x186EC3000")]
	private void MKGBKACPBBM(object IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1D00", Offset = "0x6EC0D00", VA = "0x186EC1D00")]
	public bool JDIKNMDACEI(IPAddress KLAJEDKMENO, IPAddress CNENKFNNIHC, int JHMPKACOBFK, bool ECFDLJPMDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2750", Offset = "0x6EC1750", VA = "0x186EC2750")]
	internal int KIEAPMPIKDB(FIFOBIGMFLH AHEHGOPPDFG, IPEndPoint ONGBEKHKLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6EC01B0", Offset = "0x6EBF1B0", VA = "0x186EC01B0")]
	internal int FHOECFGGKEK(FIFOBIGMFLH AHEHGOPPDFG, IPEndPoint ONGBEKHKLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF9D0", Offset = "0x6EBE9D0", VA = "0x186EBF9D0")]
	internal int FHOECFGGKEK(byte[] NAAMEAFIHJI, int IPAELMFFKOA, int DDGBDMFPMAI, IPEndPoint ONGBEKHKLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6EC25D0", Offset = "0x6EC15D0", VA = "0x186EC25D0")]
	internal void JOCOPDBIBCI(bool ALLMELONOMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum LHMBLOPDOMI : byte
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
internal sealed class FIFOBIGMFLH
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int FFAHMKIJLKO;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int[] FMJNECOBKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public byte[] KECGNKFEGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public int EOMGDLMNCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public object NCNBKJJHLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public FIFOBIGMFLH ACAGEKDEDPM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LHMBLOPDOMI CAKAJDAKFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EC59F0", Offset = "0x6EC49F0", VA = "0x186EC59F0")]
		get
		{
			return default(LHMBLOPDOMI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5C20", Offset = "0x6EC4C20", VA = "0x186EC5C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte NGHAIMJPLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5A60", Offset = "0x6EC4A60", VA = "0x186EC5A60")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6EC58E0", Offset = "0x6EC48E0", VA = "0x186EC58E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort GHONMMDKFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5BC0", Offset = "0x6EC4BC0", VA = "0x186EC5BC0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5830", Offset = "0x6EC4830", VA = "0x186EC5830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HMOBCCPJMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5B90", Offset = "0x6EC4B90", VA = "0x186EC5B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PDONOMLLNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5C60", Offset = "0x6EC4C60", VA = "0x186EC5C60")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5920", Offset = "0x6EC4920", VA = "0x186EC5920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort BLHJJJHCMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5770", Offset = "0x6EC4770", VA = "0x186EC5770")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5950", Offset = "0x6EC4950", VA = "0x186EC5950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort IEDOBBGHACA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5990", Offset = "0x6EC4990", VA = "0x186EC5990")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5A20", Offset = "0x6EC4A20", VA = "0x186EC5A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JJCCPCNDPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6EC57D0", Offset = "0x6EC47D0", VA = "0x186EC57D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6EC58A0", Offset = "0x6EC48A0", VA = "0x186EC58A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5D90", Offset = "0x6EC4D90", VA = "0x186EC5D90")]
	static FIFOBIGMFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5870", Offset = "0x6EC4870", VA = "0x186EC5870")]
	public void HGPKIFNFPMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6070", Offset = "0x6EC5070", VA = "0x186EC6070")]
	public FIFOBIGMFLH(int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EC60E0", Offset = "0x6EC50E0", VA = "0x186EC60E0")]
	public FIFOBIGMFLH(LHMBLOPDOMI LLPAKFGNDOB, int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5C90", Offset = "0x6EC4C90", VA = "0x186EC5C90")]
	public static int PEOMJCJPHLO(LHMBLOPDOMI LLPAKFGNDOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5D00", Offset = "0x6EC4D00", VA = "0x186EC5D00")]
	public int PEOMJCJPHLO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5A90", Offset = "0x6EC4A90", VA = "0x186EC5A90")]
	public bool NHFGNGLOMIB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum AFFBCOPKCJL : byte
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
internal enum DFDLCALOMGG
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
internal enum NBKIIFFAKJI
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum EMEHFHAECKE
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class MNEMGBAJIJH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class BJBMKLFKAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FIFOBIGMFLH[] CADEJEOHADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int EONOCJPFHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int JGFOENNNDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public byte PDONOMLLNIF;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BJBMKLFKAKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void MAEKNNEHFGC(ulong CDGMGNFIEME, int CKJPBMDKJMI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int HDLNJBBDLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int KBOIEFDPNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int OEEBCDPHAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double EGDIIKDCDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int PEMEJBHGIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int ILNIKDMMINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int DPKGICBBPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Stopwatch EJPKIHHBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int LJJFFMLIAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private long CHAMCCMKAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly object FPKANKAHKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	internal MNEMGBAJIJH OIPDGMJHIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	internal MNEMGBAJIJH ELPABGJMJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Queue<FIFOBIGMFLH> LDDJFKHBALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly ConcurrentQueue<EDLAECGIMAF> EOHJBEOHPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly EDLAECGIMAF[] HPACCJGHDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int OONCNCNKDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int PCKNMMPJEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool HKJGLBIFJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int POPPIBLANCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int AGIOEOCMEBN;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private const int EPCDPEFPAIL = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const int ONBPAMAGCEE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly object MJFLOCNPIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int DLEADBCFKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<ushort, BJBMKLFKAKE> LBNJCBKOLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly Dictionary<ushort, ushort> JJLIPNKAHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly FIFOBIGMFLH EKLALILIHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int PJGOIGLBDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int HHBAKPEEKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IPEndPoint HPJFIPHKBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int FBGMJILJELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int LFFAJMFIIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private long PABNIMJHDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private byte CNJCPAIAHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private AFFBCOPKCJL NCKACNBOGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private FIFOBIGMFLH IAJBILHMMOM;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const int LOAHMIHJEON = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int OCIIABGKENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly FIFOBIGMFLH FPJPHCHGJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly FIFOBIGMFLH MHPAEIJFPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly FIFOBIGMFLH AAOALOMMGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly FIFOBIGMFLH EIKNKIKNEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private LPBJFKOBPDM BDOMMGDHNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly CPNPKLEEMCO MJINOHIOJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly int OJLJBFKDCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public object ACJOIMALHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly HNCAAPNAFHF FBMJEKKAMOJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte LMKJBCOMLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D750", Offset = "0xA8C750", VA = "0x180A8D750")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6ED13D0", Offset = "0x6ED03D0", VA = "0x186ED13D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint OKADKMEDLAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xCAABF0", Offset = "0xCA9BF0", VA = "0x180CAABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AFFBCOPKCJL DDKAOOEDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB83390", Offset = "0xB82390", VA = "0x180B83390")]
		get
		{
			return default(AFFBCOPKCJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long MIILGEADAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4B0", Offset = "0x9FB4B0", VA = "0x1809FC4B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GAPLLKDOPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1538580", Offset = "0x1537580", VA = "0x181538580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A0B0", Offset = "0x1E290B0", VA = "0x181E2A0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int JLDGMNFKLLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6ED21D0", Offset = "0x6ED11D0", VA = "0x186ED21D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KABACJKKHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA00120", Offset = "0x9FF120", VA = "0x180A00120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double OBJHCHNMJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E7A5D0", Offset = "0x4E795D0", VA = "0x184E7A5D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MAEKNNEHFGC ELFKAOCMBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6ED04A0", Offset = "0x6ECF4A0", VA = "0x186ED04A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1480", Offset = "0x6ED0480", VA = "0x186ED1480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2760", Offset = "0x6ED1760", VA = "0x186ED2760")]
	internal MNEMGBAJIJH(CPNPKLEEMCO BGECOGBLKLN, IPEndPoint ONGBEKHKLMA, int HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFFA0", Offset = "0x6ECEFA0", VA = "0x186ECFFA0")]
	internal void FMNJPFPBAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2580", Offset = "0x6ED1580", VA = "0x186ED2580")]
	internal void OHDHIKLJPAP(IPEndPoint AAOKNDOKKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6ED24F0", Offset = "0x6ED14F0", VA = "0x186ED24F0")]
	internal void OAKPLDMJFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF450", Offset = "0x6ECE450", VA = "0x186ECF450")]
	private void ELODPCIEJLL(int EPCCHLBJDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF410", Offset = "0x6ECE410", VA = "0x186ECF410")]
	private void ECBMMPLFCDO(int JIPEDJPBMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6ED25B0", Offset = "0x6ED15B0", VA = "0x186ED25B0")]
	private EDLAECGIMAF PPLIFKAMFOH(byte JDCGPDDDLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2BC0", Offset = "0x6ED1BC0", VA = "0x186ED2BC0")]
	internal MNEMGBAJIJH(CPNPKLEEMCO BGECOGBLKLN, IPEndPoint ONGBEKHKLMA, int HJPLNJNIFLL, byte NDOBFGLFBOD, KLILFFCJMEE JPFGPPEMEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2D50", Offset = "0x6ED1D50", VA = "0x186ED2D50")]
	internal MNEMGBAJIJH(CPNPKLEEMCO BGECOGBLKLN, FIDNDDKHCPB HOOJNAMGGBC, int HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6ED24A0", Offset = "0x6ED14A0", VA = "0x186ED24A0")]
	internal void NFHLFBEIBDO(EEGAKGINIBB AHNNAOEGCIK, byte[] APDBNIMCPID, int IPAELMFFKOA, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2150", Offset = "0x6ED1150", VA = "0x186ED2150")]
	internal bool MEHLAMJJOAF(BLNPLOGBMCI AHEHGOPPDFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1530", Offset = "0x6ED0530", VA = "0x186ED1530")]
	public void KJNJFNLADEB(byte[] APDBNIMCPID, int IPAELMFFKOA, int DDGBDMFPMAI, NAAOLECOJPN BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6ED05A0", Offset = "0x6ECF5A0", VA = "0x186ED05A0")]
	private void IBENKGBIKDL(byte[] APDBNIMCPID, int IPAELMFFKOA, int DDGBDMFPMAI, byte LMKBIAOABBJ, NAAOLECOJPN ENEPCCBENPP, object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0550", Offset = "0x6ECF550", VA = "0x186ED0550")]
	public void HJEEFCHPPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF520", Offset = "0x6ECE520", VA = "0x186ECF520")]
	internal NBKIIFFAKJI FFGLBJFOAHE(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return default(NBKIIFFAKJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1C20", Offset = "0x6ED0C20", VA = "0x186ED1C20")]
	internal void LEBEGPKLPPJ(EDLAECGIMAF DHLCHOOBMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1C80", Offset = "0x6ED0C80", VA = "0x186ED1C80")]
	internal EMEHFHAECKE MBEJPJGMKMC(byte[] APDBNIMCPID, int IPAELMFFKOA, int DDGBDMFPMAI, bool ECOALLGHBMI)
	{
		return default(EMEHFHAECKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEE60", Offset = "0x6ECDE60", VA = "0x186ECEE60")]
	private void ANIHKIKAIMN(int NBIGABKFGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF600", Offset = "0x6ECE600", VA = "0x186ECF600")]
	internal void FJFHBMPHFPD(NAAOLECOJPN OAKFMPLKGOM, FIFOBIGMFLH NOOBIPOJNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEEA0", Offset = "0x6ECDEA0", VA = "0x186ECEEA0")]
	private void CKABBPDGNAH(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFFC0", Offset = "0x6ECEFC0", VA = "0x186ECFFC0")]
	private void GFJOBHOGBDM(int CJIPMCGKHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1F90", Offset = "0x6ED0F90", VA = "0x186ED1F90")]
	internal DFDLCALOMGG MCDIOJBNFJL(EEGAKGINIBB MBFHPOPDIMB)
	{
		return default(DFDLCALOMGG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1560", Offset = "0x6ED0560", VA = "0x186ED1560")]
	internal void LDNIGPACMDM(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0350", Offset = "0x6ECF350", VA = "0x186ED0350")]
	private void GGIHAHLCINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6ED11C0", Offset = "0x6ED01C0", VA = "0x186ED11C0")]
	internal void IMLENGBMCAB(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0B00", Offset = "0x6ECFB00", VA = "0x186ED0B00")]
	internal void IEKHBJGOAKB(int CJIPMCGKHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6ED21E0", Offset = "0x6ED11E0", VA = "0x186ED21E0")]
	internal void NBFDADAMCJP(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HNCAAPNAFHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long CKLJMBMKCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long MOKPHMFDFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long KMCIIKAKLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long LKFNCFAEDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long MINGCFAFKIF;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long OIMADODPFEH;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static long CEAOKLJNCDL;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static long KDMIINDAGNL;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long PENKLONCAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long NLPPGHCJKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private long KMFFCJLFGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private long KOCOFJNBMLL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long PFEFNCOELEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6EC7A80", Offset = "0x6EC6A80", VA = "0x186EC7A80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long AONGIGGGAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EC77C0", Offset = "0x6EC67C0", VA = "0x186EC77C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long BODMBAPLPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6EC7840", Offset = "0x6EC6840", VA = "0x186EC7840")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long LHHNBOBGAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EC7A90", Offset = "0x6EC6A90", VA = "0x186EC7A90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MAOGMECFNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EC77D0", Offset = "0x6EC67D0", VA = "0x186EC77D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long OLPEGHGBCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6EC7BA0", Offset = "0x6EC6BA0", VA = "0x186EC7BA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long DEEPOIIHBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6EC7BB0", Offset = "0x6EC6BB0", VA = "0x186EC7BB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long LEHNGAIJCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6EC78D0", Offset = "0x6EC68D0", VA = "0x186EC78D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private LPBJFKOBPDM DCFCGIEDENP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6EC77B0", Offset = "0x6EC67B0", VA = "0x186EC77B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double CPJIALNJIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6EC77E0", Offset = "0x6EC67E0", VA = "0x186EC77E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EC79D0", Offset = "0x6EC69D0", VA = "0x186EC79D0")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7AA0", Offset = "0x6EC6AA0", VA = "0x186EC7AA0")]
	public void NBEFHODHMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7980", Offset = "0x6EC6980", VA = "0x186EC7980")]
	public void KGHHDJLFHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7910", Offset = "0x6EC6910", VA = "0x186EC7910")]
	public void JGODLOCDPAF(long OMHADDJBDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7A10", Offset = "0x6EC6A10", VA = "0x186EC7A10")]
	public void LLJBEGKNGLA(long IHFIGKEJCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7750", Offset = "0x6EC6750", VA = "0x186EC7750")]
	public void ACNMJNNHPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7850", Offset = "0x6EC6850", VA = "0x186EC7850")]
	public void GOMHNFNEPIO(long DIDEMGEMCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7BF0", Offset = "0x6EC6BF0", VA = "0x186EC7BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7B00", Offset = "0x6EC6B00", VA = "0x186EC7B00")]
	public void NLLCNINMFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HNCAAPNAFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LLKOMFIKMHC
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly List<string> NPHLGFODBFO;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6ECAC10", Offset = "0x6EC9C10", VA = "0x186ECAC10")]
	public static IPEndPoint LDEHPPCKEIO(string EBJOIPCLPEB, int JHMPKACOBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECAA40", Offset = "0x6EC9A40", VA = "0x186ECAA40")]
	public static IPAddress FLDILIICJJI(string EBJOIPCLPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA9B0", Offset = "0x6EC99B0", VA = "0x186ECA9B0")]
	public static IPAddress FLDILIICJJI(string EBJOIPCLPEB, AddressFamily PCHCGGAMAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA980", Offset = "0x6EC9980", VA = "0x186ECA980")]
	internal static int FGJFKHNIJNL(int COJHHFHLPJN, int DPCDDDOIHML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x38F9220", Offset = "0x38F8220", VA = "0x1838F9220")]
	internal static T[] HFADEKCDOLB<T>(int JAALIADHHOC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LIHOJPBMNFF : EDLAECGIMAF
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct JEHDGPJLLGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private FIFOBIGMFLH JKAFKKEJILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private long BEAOBKPBJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private bool BCGLLCIBDOP;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6EC8890", Offset = "0x6EC7890", VA = "0x186EC8890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6EC87B0", Offset = "0x6EC77B0", VA = "0x186EC87B0")]
		public void EEBICEODLFH(FIFOBIGMFLH AHEHGOPPDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6EC8820", Offset = "0x6EC7820", VA = "0x186EC8820")]
		public bool OKLEDCPAABL(long DBEFOCGFFJA, MNEMGBAJIJH MNFIBPMCHAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6EC87D0", Offset = "0x6EC77D0", VA = "0x186EC87D0")]
		public bool INBDHNEFJBE(MNEMGBAJIJH MNFIBPMCHAA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly FIFOBIGMFLH LCNCCAADBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly JEHDGPJLLGL[] CABIKIBCFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly FIFOBIGMFLH[] JAPHCPOGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly bool[] DCKAPNMKCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int LCBEIAFPHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int DMLHFKHKGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int CBOJJBELAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int FOFIHCNHMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool LDNAFPLHJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly NAAOLECOJPN BHPGEJGPELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly bool NKGFKJIMFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly int GLOHKHHKDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly byte MLAPBHAJPMP;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA670", Offset = "0x6EC9670", VA = "0x186ECA670")]
	public LIHOJPBMNFF(MNEMGBAJIJH MNFIBPMCHAA, bool HJHBOHCCPCE, byte HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9780", Offset = "0x6EC8780", VA = "0x186EC9780")]
	private void GEGBLNOIBCA(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9B40", Offset = "0x6EC8B40", VA = "0x186EC9B40", Slot = "4")]
	protected override bool IGPNBIJNGKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA010", Offset = "0x6EC9010", VA = "0x186ECA010", Slot = "5")]
	public override bool LDNIGPACMDM(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FPIGKKCOBOG : EDLAECGIMAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int AGIBLFKGCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private ushort DMLHFKHKGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly bool EGKEBFNEMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private FIFOBIGMFLH CLEJPBMNCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly FIFOBIGMFLH HNNGAAAFEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool CMGMOOBAPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly byte MLAPBHAJPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private long GABHDJGNMEF;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6A70", Offset = "0x6EC5A70", VA = "0x186EC6A70")]
	public FPIGKKCOBOG(MNEMGBAJIJH MNFIBPMCHAA, bool JOJACDFCNNL, byte HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6EC62D0", Offset = "0x6EC52D0", VA = "0x186EC62D0", Slot = "4")]
	protected override bool IGPNBIJNGKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6790", Offset = "0x6EC5790", VA = "0x186EC6790", Slot = "5")]
	public override bool LDNIGPACMDM(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BGOBFPLBLNC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct KNNPGDNAOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public ulong KMJDLOFKBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public double CHIPJDEFICC;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct MBICMCMFHHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int KIGMHEMIFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float DDDCHKPAODE;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB440", Offset = "0x6EBA440", VA = "0x186EBB440")]
	private static void LAEEFCPGCNO(byte[] IIGKBHIENFB, int LLPAIMMACAP, ulong APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC770", Offset = "0x6EBB770", VA = "0x186EBC770")]
	private static void LAEEFCPGCNO(byte[] IIGKBHIENFB, int LLPAIMMACAP, int APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC690", Offset = "0x6EBB690", VA = "0x186EBC690")]
	public static void LAEEFCPGCNO(byte[] IIGKBHIENFB, int LLPAIMMACAP, short APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC6D0", Offset = "0x6EBB6D0", VA = "0x186EBC6D0")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, double OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC6F0", Offset = "0x6EBB6F0", VA = "0x186EBC6F0")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC690", Offset = "0x6EBB690", VA = "0x186EBC690")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, short OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC690", Offset = "0x6EBB690", VA = "0x186EBC690")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, ushort OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC770", Offset = "0x6EBB770", VA = "0x186EBC770")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC770", Offset = "0x6EBB770", VA = "0x186EBC770")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, uint OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC7E0", Offset = "0x6EBB7E0", VA = "0x186EBC7E0")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC7E0", Offset = "0x6EBB7E0", VA = "0x186EBC7E0")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, ulong OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class ACLDEKFAJGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] NKKMPKCKMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int IJCKAFFAOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected int BEHNNKOLECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int MEMDMLBIFJL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] KECGNKFEGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FELJFFDJELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BMLHABEFLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6EBBA90", Offset = "0x6EBAA90", VA = "0x186EBBA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BDENHAPMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2670AE0", Offset = "0x266FAE0", VA = "0x182670AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int HFJBLKHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC060", Offset = "0x6EBB060", VA = "0x186EBC060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC5B0", Offset = "0x6EBB5B0", VA = "0x186EBC5B0")]
	public void PKAFLAIKAEK(byte[] NEKLMLONNIM, int LLPAIMMACAP, int DFDEPGDGEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public ACLDEKFAJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC630", Offset = "0x6EBB630", VA = "0x186EBC630")]
	public ACLDEKFAJGB(byte[] NEKLMLONNIM, int LLPAIMMACAP, int DFDEPGDGEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBD70", Offset = "0x6EBAD70", VA = "0x186EBBD70")]
	public IPEndPoint ILNDIMFDPDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBE60", Offset = "0x6EBAE60", VA = "0x186EBBE60")]
	public byte KDOLPCFNLEM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBE60", Offset = "0x6EBAE60", VA = "0x186EBBE60")]
	public sbyte JCHDNEDGLCD()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3F63670", Offset = "0x3F62670", VA = "0x183F63670")]
	public T[] HABPIGJFOBL<T>(ushort CFNMLMNHCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC360", Offset = "0x6EBB360", VA = "0x186EBC360")]
	public bool[] NLBBHBGODCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBD30", Offset = "0x6EBAD30", VA = "0x186EBBD30")]
	public ushort[] IGOCBLBIFEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBCB0", Offset = "0x6EBACB0", VA = "0x186EBBCB0")]
	public short[] HMDKPCNNPAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBB10", Offset = "0x6EBAB10", VA = "0x186EBBB10")]
	public int[] BIJMGOELPBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC4C0", Offset = "0x6EBB4C0", VA = "0x186EBC4C0")]
	public uint[] OKHFFECFEDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC5F0", Offset = "0x6EBB5F0", VA = "0x186EBC5F0")]
	public float[] PMBGKOEBCEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC480", Offset = "0x6EBB480", VA = "0x186EBC480")]
	public double[] OIHBBCOOJAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC320", Offset = "0x6EBB320", VA = "0x186EBC320")]
	public long[] NCILLJILGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBC70", Offset = "0x6EBAC70", VA = "0x186EBBC70")]
	public ulong[] FIADKFKLPPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBEA0", Offset = "0x6EBAEA0", VA = "0x186EBBEA0")]
	public string[] JDHHMEFDMFO(int FPENKDACOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC500", Offset = "0x6EBB500", VA = "0x186EBC500")]
	public bool OKLGNCIFKBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBB50", Offset = "0x6EBAB50", VA = "0x186EBBB50")]
	public char PJHMBNFGOLD()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBB50", Offset = "0x6EBAB50", VA = "0x186EBBB50")]
	public ushort BOOKEMDKMBK()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC070", Offset = "0x6EBB070", VA = "0x186EBC070")]
	public short KGCHLIEALCC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBAA0", Offset = "0x6EBAAA0", VA = "0x186EBBAA0")]
	public long BDDFBMHAGNG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC540", Offset = "0x6EBB540", VA = "0x186EBC540")]
	public ulong OKPEOLMGEEH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC3A0", Offset = "0x6EBB3A0", VA = "0x186EBC3A0")]
	public int NNOIHJGKKGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBA20", Offset = "0x6EBAA20", VA = "0x186EBBA20")]
	public uint AIEPONGFOKD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBBC0", Offset = "0x6EBABC0", VA = "0x186EBBBC0")]
	public float EPIJGHEEOEF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC410", Offset = "0x6EBB410", VA = "0x186EBC410")]
	public double OEBAMKJHEOC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC0E0", Offset = "0x6EBB0E0", VA = "0x186EBC0E0")]
	public string LEEDJCCMEMN(int HOMPFMAAAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBFF0", Offset = "0x6EBAFF0", VA = "0x186EBBFF0")]
	public ArraySegment<byte> JEMLOKALEOO(int JAALIADHHOC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBCF0", Offset = "0x6EBACF0", VA = "0x186EBBCF0")]
	public sbyte[] ICMDNKLJNCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBC30", Offset = "0x6EBAC30", VA = "0x186EBBC30")]
	public byte[] FFMCBMNCEFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBE40", Offset = "0x6EBAE40", VA = "0x186EBBE40")]
	public void INBDHNEFJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KLILFFCJMEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected byte[] NKKMPKCKMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int IJCKAFFAOEG;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private const int FHNHMHEOJGN = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly bool MJFBCJCOHGC;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public static readonly UTF8Encoding EOGADGHCPKF;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const int PPNCDNBIDOM = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly byte[] OBHGGBNOHFI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] HCNIDPKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9700", Offset = "0x6EC8700", VA = "0x186EC9700")]
	public KLILFFCJMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9660", Offset = "0x6EC8660", VA = "0x186EC9660")]
	public KLILFFCJMEE(bool HELGPCHNBKA, int IEJFHANCGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC94C0", Offset = "0x6EC84C0", VA = "0x186EC94C0")]
	public static KLILFFCJMEE IFOLFJOHHKB(string OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9530", Offset = "0x6EC8530", VA = "0x186EC9530")]
	public void MCPGKJAPPDF(int IPMBIEKIIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xD09540", Offset = "0xD08540", VA = "0x180D09540")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8E80", Offset = "0x6EC7E80", VA = "0x186EC8E80")]
	public void EJBPHCOOKGN(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8D70", Offset = "0x6EC7D70", VA = "0x186EC8D70")]
	public void EJBPHCOOKGN(double OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8DC0", Offset = "0x6EC7DC0", VA = "0x186EC8DC0")]
	public void EJBPHCOOKGN(long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8DC0", Offset = "0x6EC7DC0", VA = "0x186EC8DC0")]
	public void EJBPHCOOKGN(ulong OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8CE0", Offset = "0x6EC7CE0", VA = "0x186EC8CE0")]
	public void EJBPHCOOKGN(int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8CE0", Offset = "0x6EC7CE0", VA = "0x186EC8CE0")]
	public void EJBPHCOOKGN(uint OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8C70", Offset = "0x6EC7C70", VA = "0x186EC8C70")]
	public void EJBPHCOOKGN(char OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8C70", Offset = "0x6EC7C70", VA = "0x186EC8C70")]
	public void EJBPHCOOKGN(ushort OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8C70", Offset = "0x6EC7C70", VA = "0x186EC8C70")]
	public void EJBPHCOOKGN(short OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8C10", Offset = "0x6EC7C10", VA = "0x186EC8C10")]
	public void EJBPHCOOKGN(sbyte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8C10", Offset = "0x6EC7C10", VA = "0x186EC8C10")]
	public void EJBPHCOOKGN(byte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8E10", Offset = "0x6EC7E10", VA = "0x186EC8E10")]
	public void EJBPHCOOKGN(byte[] APDBNIMCPID, int LLPAIMMACAP, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8F90", Offset = "0x6EC7F90", VA = "0x186EC8F90")]
	public void HIELJGNKHGH(sbyte[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8F90", Offset = "0x6EC7F90", VA = "0x186EC8F90")]
	public void LLKDGFHPINH(byte[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8F30", Offset = "0x6EC7F30", VA = "0x186EC8F30")]
	public void EJBPHCOOKGN(bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC93E0", Offset = "0x6EC83E0", VA = "0x186EC93E0")]
	public void HDMKBIAMEJD(Array OGAMHOMMEAC, int NLELKCNHPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9140", Offset = "0x6EC8140", VA = "0x186EC9140")]
	public void HDMKBIAMEJD(float[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9220", Offset = "0x6EC8220", VA = "0x186EC9220")]
	public void HDMKBIAMEJD(double[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9220", Offset = "0x6EC8220", VA = "0x186EC9220")]
	public void HDMKBIAMEJD(long[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9220", Offset = "0x6EC8220", VA = "0x186EC9220")]
	public void HDMKBIAMEJD(ulong[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9140", Offset = "0x6EC8140", VA = "0x186EC9140")]
	public void HDMKBIAMEJD(int[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9140", Offset = "0x6EC8140", VA = "0x186EC9140")]
	public void HDMKBIAMEJD(uint[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9300", Offset = "0x6EC8300", VA = "0x186EC9300")]
	public void HDMKBIAMEJD(ushort[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9300", Offset = "0x6EC8300", VA = "0x186EC9300")]
	public void HDMKBIAMEJD(short[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8F90", Offset = "0x6EC7F90", VA = "0x186EC8F90")]
	public void HDMKBIAMEJD(bool[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9070", Offset = "0x6EC8070", VA = "0x186EC9070")]
	public void HDMKBIAMEJD(string[] OHLIHBDBKCE, int HNGHABGOFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8B40", Offset = "0x6EC7B40", VA = "0x186EC8B40")]
	public void EJBPHCOOKGN(IPEndPoint KKNOGDEEABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8F20", Offset = "0x6EC7F20", VA = "0x186EC8F20")]
	public void EJBPHCOOKGN(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8930", Offset = "0x6EC7930", VA = "0x186EC8930")]
	public void EJBPHCOOKGN(string OHLIHBDBKCE, int HOMPFMAAAKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FFJNGFDJPPP
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class MHAALFFLDDK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly ulong OJLJBFKDCDP;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5332F00", Offset = "0x5331F00", VA = "0x185332F00")]
		static MHAALFFLDDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void FICGHPHEFEC(ACLDEKFAJGB HBMFONPEIJC, object GCLNNHGNABG);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CGHFDOLODCF<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public FFJNGFDJPPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CGHFDOLODCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x67CD910", Offset = "0x67CC910", VA = "0x1867CD910")]
		internal void MCICNKPFIKO(ACLDEKFAJGB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NPKPOMGDMAD<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public FFJNGFDJPPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NPKPOMGDMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x54085B0", Offset = "0x54075B0", VA = "0x1854085B0")]
		internal void MCICNKPFIKO(ACLDEKFAJGB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly CECIMCGPMEH MMFBJIOIHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<ulong, FICGHPHEFEC> PFNDPFEAACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly KLILFFCJMEE OGJIJLPMHLF;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5490", Offset = "0x6EC4490", VA = "0x186EC5490")]
	public FFJNGFDJPPP(int FPENKDACOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x35D0E70", Offset = "0x35CFE70", VA = "0x1835D0E70", Slot = "4")]
	protected virtual ulong KLJNHBBKJDH<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5310", Offset = "0x6EC4310", VA = "0x186EC5310", Slot = "5")]
	protected virtual FICGHPHEFEC GPNPJEKEJDD(ACLDEKFAJGB HBMFONPEIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x383E6F0", Offset = "0x383D6F0", VA = "0x18383E6F0", Slot = "6")]
	protected virtual void NEOKLKGMFCA<T>(KLILFFCJMEE NFOCFJIIPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5290", Offset = "0x6EC4290", VA = "0x186EC5290")]
	public void FCBKJKOPIOJ(ACLDEKFAJGB HBMFONPEIJC, object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x383E2C0", Offset = "0x383D2C0", VA = "0x18383E2C0")]
	public void FOKICFNDJFF<T>(KLILFFCJMEE NFOCFJIIPHM, T AHEHGOPPDFG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5440", Offset = "0x6EC4440", VA = "0x186EC5440")]
	public void JHDHAEDMIAC(ACLDEKFAJGB HBMFONPEIJC, object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x383E530", Offset = "0x383D530", VA = "0x18383E530")]
	public void LJEEGOGEEFF<T>(Action<T> FBKOCJAFGDK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x383E370", Offset = "0x383D370", VA = "0x18383E370")]
	public void LJEEGOGEEFF<T, TUserData>(Action<T, TUserData> FBKOCJAFGDK) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class MFLMOIMJJGI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4AF0", Offset = "0x6EC3AF0", VA = "0x186EC4AF0")]
	public MFLMOIMJJGI(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JEFPCMEJIHK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8750", Offset = "0x6EC7750", VA = "0x186EC8750")]
	public JEFPCMEJIHK(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class CECIMCGPMEH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum KBKFPBKLBHI
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class FICPEACKDPK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public KBKFPBKLBHI KFIKOGBAHMD;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x496AE10", Offset = "0x4969E10", VA = "0x18496AE10", Slot = "4")]
		public virtual void EEBICEODLFH(MethodInfo LPHMBJGAFFB, MethodInfo JABKAHKJHKJ, KBKFPBKLBHI MLCOGCMJLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void AFIGADGINFD(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void HBJPNBOOPNK(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		protected FICPEACKDPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class OIBCPFLEDFF<TClass, TProperty> : FICPEACKDPK<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, TProperty> PMCBFDOFIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, TProperty> GMCKFOHLOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		protected Func<TClass, TProperty[]> KJGCAAKDEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Action<TClass, TProperty[]> GDALJKAKKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Func<TClass, List<TProperty>> CADLNFPKKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Action<TClass, List<TProperty>> IJIIPEKLEIL;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5526A30", Offset = "0x5525A30", VA = "0x185526A30", Slot = "7")]
		public override void JKKGILIGMEE(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5524DB0", Offset = "0x5523DB0", VA = "0x185524DB0", Slot = "8")]
		public override void GOPCFKFAPID(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x551F4F0", Offset = "0x551E4F0", VA = "0x18551F4F0", Slot = "9")]
		public override void AFIGADGINFD(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x55260F0", Offset = "0x55250F0", VA = "0x1855260F0", Slot = "10")]
		public override void HBJPNBOOPNK(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5526DB0", Offset = "0x5525DB0", VA = "0x185526DB0")]
		protected TProperty[] MKNKEENANCC(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x55261D0", Offset = "0x55251D0", VA = "0x1855261D0")]
		protected TProperty[] JHGMBCFPNMH(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5522890", Offset = "0x5521890", VA = "0x185522890", Slot = "4")]
		public override void EEBICEODLFH(MethodInfo LPHMBJGAFFB, MethodInfo JABKAHKJHKJ, KBKFPBKLBHI MLCOGCMJLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4E22700", Offset = "0x4E21700", VA = "0x184E22700")]
		protected OIBCPFLEDFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class EIEGKCPGDPM<TClass, TProperty> : OIBCPFLEDFF<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void GOMOCDLAPPK(ACLDEKFAJGB NFFBJCCKPJF, [Out] TProperty NIPNOJNPKEB);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void BBKBIACKOEB(KLILFFCJMEE NJMPEFLBAHN, TProperty NIPNOJNPKEB);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x44DFD50", Offset = "0x44DED50", VA = "0x1844DFD50", Slot = "5")]
		public override void NPNJAONMOHB(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x44DF8B0", Offset = "0x44DE8B0", VA = "0x1844DF8B0", Slot = "6")]
		public override void FOKICFNDJFF(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x44DFB30", Offset = "0x44DEB30", VA = "0x1844DFB30", Slot = "7")]
		public override void JKKGILIGMEE(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x44DF9B0", Offset = "0x44DE9B0", VA = "0x1844DF9B0", Slot = "8")]
		public override void GOPCFKFAPID(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x44DFDF0", Offset = "0x44DEDF0", VA = "0x1844DFDF0")]
		protected EIEGKCPGDPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class BFCCLDNJAMC<T> : OIBCPFLEDFF<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x61C0360", Offset = "0x61BF360", VA = "0x1861C0360", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x552FFF0", Offset = "0x552EFF0", VA = "0x18552FFF0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x61C02E0", Offset = "0x61BF2E0", VA = "0x1861C02E0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x495CA10", Offset = "0x495BA10", VA = "0x18495CA10", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public BFCCLDNJAMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class OLOIBDPEIHM<T> : OIBCPFLEDFF<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x55300E0", Offset = "0x552F0E0", VA = "0x1855300E0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x552FFF0", Offset = "0x552EFF0", VA = "0x18552FFF0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5530060", Offset = "0x552F060", VA = "0x185530060", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x495CA10", Offset = "0x495BA10", VA = "0x18495CA10", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public OLOIBDPEIHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class BLGEBMAAAEM<T> : OIBCPFLEDFF<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x63AC220", Offset = "0x63AB220", VA = "0x1863AC220", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4BEE970", Offset = "0x4BED970", VA = "0x184BEE970", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x63AC1A0", Offset = "0x63AB1A0", VA = "0x1863AC1A0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4BEE9E0", Offset = "0x4BED9E0", VA = "0x184BEE9E0", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public BLGEBMAAAEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class ICDODKENFAG<T> : OIBCPFLEDFF<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4BEEAD0", Offset = "0x4BEDAD0", VA = "0x184BEEAD0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4BEE970", Offset = "0x4BED970", VA = "0x184BEE970", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4BEEA50", Offset = "0x4BEDA50", VA = "0x184BEEA50", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4BEE9E0", Offset = "0x4BED9E0", VA = "0x184BEE9E0", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public ICDODKENFAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class OBLMGODLKEA<T> : OIBCPFLEDFF<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x550C6D0", Offset = "0x550B6D0", VA = "0x18550C6D0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x44B8870", Offset = "0x44B7870", VA = "0x1844B8870", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x550C650", Offset = "0x550B650", VA = "0x18550C650", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x44B88E0", Offset = "0x44B78E0", VA = "0x1844B88E0", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public OBLMGODLKEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class ECDFMDIHJNJ<T> : OIBCPFLEDFF<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x44B89D0", Offset = "0x44B79D0", VA = "0x1844B89D0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x44B8870", Offset = "0x44B7870", VA = "0x1844B8870", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x44B8950", Offset = "0x44B7950", VA = "0x1844B8950", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x44B88E0", Offset = "0x44B78E0", VA = "0x1844B88E0", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public ECDFMDIHJNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class NNMADAFAGCN<T> : OIBCPFLEDFF<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5303320", Offset = "0x5302320", VA = "0x185303320", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x53031C0", Offset = "0x53021C0", VA = "0x1853031C0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x53F7AC0", Offset = "0x53F6AC0", VA = "0x1853F7AC0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5303230", Offset = "0x5302230", VA = "0x185303230", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public NNMADAFAGCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MADHDLBOLNF<T> : OIBCPFLEDFF<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5303320", Offset = "0x5302320", VA = "0x185303320", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x53031C0", Offset = "0x53021C0", VA = "0x1853031C0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x53032A0", Offset = "0x53022A0", VA = "0x1853032A0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5303230", Offset = "0x5302230", VA = "0x185303230", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public MADHDLBOLNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FDOKNLAGHAE<T> : OIBCPFLEDFF<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x495CB00", Offset = "0x495BB00", VA = "0x18495CB00", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x495C9A0", Offset = "0x495B9A0", VA = "0x18495C9A0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x495CA80", Offset = "0x495BA80", VA = "0x18495CA80", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x495CA10", Offset = "0x495BA10", VA = "0x18495CA10", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public FDOKNLAGHAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MCLEJDLJJGN<T> : OIBCPFLEDFF<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5307810", Offset = "0x5306810", VA = "0x185307810", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5307720", Offset = "0x5306720", VA = "0x185307720", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5307790", Offset = "0x5306790", VA = "0x185307790", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x44B88E0", Offset = "0x44B78E0", VA = "0x1844B88E0", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public MCLEJDLJJGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class BACJNONJMCA<T> : OIBCPFLEDFF<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x60C35F0", Offset = "0x60C25F0", VA = "0x1860C35F0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x60C3500", Offset = "0x60C2500", VA = "0x1860C3500", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x60C3570", Offset = "0x60C2570", VA = "0x1860C3570", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5303230", Offset = "0x5302230", VA = "0x185303230", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
		public BACJNONJMCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class CJAJDIOBCOA<T> : EIEGKCPGDPM<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x67D9720", Offset = "0x67D8720", VA = "0x1867D9720", Slot = "12")]
		protected override void BBKBIACKOEB(KLILFFCJMEE NJMPEFLBAHN, char NIPNOJNPKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x67D9750", Offset = "0x67D8750", VA = "0x1867D9750", Slot = "11")]
		protected override void GOMOCDLAPPK(ACLDEKFAJGB NFFBJCCKPJF, [Out] char NIPNOJNPKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4487280", Offset = "0x4486280", VA = "0x184487280")]
		public CJAJDIOBCOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class DEABLIJNJBP<T> : EIEGKCPGDPM<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A554F0", Offset = "0x6A544F0", VA = "0x186A554F0", Slot = "12")]
		protected override void BBKBIACKOEB(KLILFFCJMEE NJMPEFLBAHN, IPEndPoint NIPNOJNPKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A55520", Offset = "0x6A54520", VA = "0x186A55520", Slot = "11")]
		protected override void GOMOCDLAPPK(ACLDEKFAJGB NFFBJCCKPJF, [Out] IPEndPoint NIPNOJNPKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4487280", Offset = "0x4486280", VA = "0x184487280")]
		public DEABLIJNJBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class OFEGNGPPKBJ<T> : OIBCPFLEDFF<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly int JPEKCEGENCI;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5513980", Offset = "0x5512980", VA = "0x185513980")]
		public OFEGNGPPKBJ(int HOMPFMAAAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5513900", Offset = "0x5512900", VA = "0x185513900", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5513780", Offset = "0x5512780", VA = "0x185513780", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5513880", Offset = "0x5512880", VA = "0x185513880", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5513800", Offset = "0x5512800", VA = "0x185513800", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class DGAGGLCLPCH<T> : FICPEACKDPK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected readonly PropertyInfo CAKAJDAKFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected readonly Type GGGLMMJGBNH;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B320", Offset = "0x6A5A320", VA = "0x186A5B320")]
		public DGAGGLCLPCH(PropertyInfo LLPAKFGNDOB, Type APCIGGMPPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B260", Offset = "0x6A5A260", VA = "0x186A5B260", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B090", Offset = "0x6A5A090", VA = "0x186A5B090", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B200", Offset = "0x6A5A200", VA = "0x186A5B200", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B140", Offset = "0x6A5A140", VA = "0x186A5B140", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B030", Offset = "0x6A5A030", VA = "0x186A5B030", Slot = "9")]
		public override void AFIGADGINFD(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B1A0", Offset = "0x6A5A1A0", VA = "0x186A5B1A0", Slot = "10")]
		public override void HBJPNBOOPNK(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class CCMAELFOFKD<T> : DGAGGLCLPCH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x44EC8E0", Offset = "0x44EB8E0", VA = "0x1844EC8E0")]
		public CCMAELFOFKD(PropertyInfo LLPAKFGNDOB, Type APCIGGMPPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x67A4530", Offset = "0x67A3530", VA = "0x1867A4530", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x67A4480", Offset = "0x67A3480", VA = "0x1867A4480", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class JFPONCJHBHP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static JFPONCJHBHP<T> MLIJHBGBMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly FICPEACKDPK<T>[] PPCMEEJADKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly int LAMMGHLLNOO;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4E31020", Offset = "0x4E30020", VA = "0x184E31020")]
		public JFPONCJHBHP(List<FICPEACKDPK<T>> LENNAEIKDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4E30EC0", Offset = "0x4E2FEC0", VA = "0x184E30EC0")]
		public void FOKICFNDJFF(T BOMDCGFKGKF, KLILFFCJMEE NFOCFJIIPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4E30F70", Offset = "0x4E2FF70", VA = "0x184E30F70")]
		public void NPNJAONMOHB(T BOMDCGFKGKF, ACLDEKFAJGB HBMFONPEIJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class PALJOIHNFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FICPEACKDPK<T> PHDCGNDDLGA<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private KLILFFCJMEE ODGBCAIMOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int GEIECBLLDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Dictionary<Type, PALJOIHNFIB> FDMHENHMLDI;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6EBCB80", Offset = "0x6EBBB80", VA = "0x186EBCB80")]
	public CECIMCGPMEH(int FPENKDACOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x36337A0", Offset = "0x36327A0", VA = "0x1836337A0")]
	private JFPONCJHBHP<T> FBNMPNBIACB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x36336E0", Offset = "0x36326E0", VA = "0x1836336E0")]
	public void AMBIAOGNIIF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3633640", Offset = "0x3632640", VA = "0x183633640")]
	public bool AKDPGDCBDMI<T>(ACLDEKFAJGB HBMFONPEIJC, T FCPOJLOEIEO) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3633710", Offset = "0x3632710", VA = "0x183633710")]
	public void DFNAEDFOBIJ<T>(KLILFFCJMEE NFOCFJIIPHM, T BOMDCGFKGKF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MGLNOHNAOEM
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static readonly DateTime NPBKOMJGEJM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] LBLPOKKCLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BEDOOOCGJIF JFPPOAEFHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDEF0", Offset = "0x6ECCEF0", VA = "0x186ECDEF0")]
		get
		{
			return default(BEDOOOCGJIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int OPDMJMAFFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDA30", Offset = "0x6ECCA30", VA = "0x186ECDA30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD180", Offset = "0x6ECC180", VA = "0x186ECD180")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HMHJGICCAKJ KFOHGIONJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDFA0", Offset = "0x6ECCFA0", VA = "0x186ECDFA0")]
		get
		{
			return default(HMHJGICCAKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDD20", Offset = "0x6ECCD20", VA = "0x186ECDD20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int PDKMNKMHDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDC60", Offset = "0x6ECCC60", VA = "0x186ECDC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint HCKJCGHKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDF20", Offset = "0x6ECCF20", VA = "0x186ECDF20")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? HFOMCAOKHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD400", Offset = "0x6ECC400", VA = "0x186ECD400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? LGHFINAJBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD830", Offset = "0x6ECC830", VA = "0x186ECD830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? KIHGFADODFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD430", Offset = "0x6ECC430", VA = "0x186ECD430")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD460", Offset = "0x6ECC460", VA = "0x186ECD460")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? BGFGJDMCKLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xDB9A10", Offset = "0xDB8A10", VA = "0x180DB9A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE0E0", Offset = "0x6ECD0E0", VA = "0x186ECE0E0")]
	public MGLNOHNAOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE030", Offset = "0x6ECD030", VA = "0x186ECE030")]
	internal MGLNOHNAOEM(byte[] ACDPPDBEDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6ECD060", Offset = "0x6ECC060", VA = "0x186ECD060")]
	public static MGLNOHNAOEM AAAJLHGFOPO(byte[] ACDPPDBEDDM, DateTime PCOOEIKIJDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6ECDA60", Offset = "0x6ECCA60", VA = "0x186ECDA60")]
	internal void FLJEDLENCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6ECD220", Offset = "0x6ECC220", VA = "0x186ECD220")]
	private void BLHKICOMAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6ECD630", Offset = "0x6ECC630", VA = "0x186ECD630")]
	private DateTime? DOPHFEIIJBF(int LLPAIMMACAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6ECD860", Offset = "0x6ECC860", VA = "0x186ECD860")]
	private void FJJCPDBCNNO(int LLPAIMMACAP, DateTime? OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6ECDD60", Offset = "0x6ECCD60", VA = "0x186ECDD60")]
	private ulong JOCGMIPKDII(int LLPAIMMACAP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6ECDE30", Offset = "0x6ECCE30", VA = "0x186ECDE30")]
	private void MILHLMLLDDM(int LLPAIMMACAP, ulong OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6ECDC90", Offset = "0x6ECCC90", VA = "0x186ECDC90")]
	private uint GHMJLCIMINB(int LLPAIMMACAP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D86E10", Offset = "0x6D85E10", VA = "0x186D86E10")]
	private static uint APHBGOANIHL(uint CEJAAIDLEPA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6ECD1C0", Offset = "0x6ECC1C0", VA = "0x186ECD1C0")]
	private static ulong APHBGOANIHL(ulong CEJAAIDLEPA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum BEDOOOCGJIF
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
public enum HMHJGICCAKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EMMCFEEBFFD
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private const int CHKHDBOIDAJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private const int LJAOACGEFOJ = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public const int KEKIPALHPBN = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly IPEndPoint HNIFBABHJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private int OFFOIFIGADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private int BGOBLMIMOBL;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool IDBBOCFBMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5190", Offset = "0x6EC4190", VA = "0x186EC5190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EC51A0", Offset = "0x6EC41A0", VA = "0x186EC51A0")]
	public bool KJNJFNLADEB(BAGLJBFNJGF KDGMKMCIFMH, int EPGNCELGAFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class GFKEDKKKNJN : BAGLJBFNJGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Socket KDGMKMCIFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly CPNPKLEEMCO BGECOGBLKLN;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short BMJOLJECHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6EC6C80", Offset = "0x6EC5C80", VA = "0x186EC6C80", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int LELOHOILPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6EC6B70", Offset = "0x6EC5B70", VA = "0x186EC6B70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint PPGBPMLFGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EC6B50", Offset = "0x6EC5B50", VA = "0x186EC6B50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily EPINNJMMOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x508E4F0", Offset = "0x508D4F0", VA = "0x18508E4F0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EC72A0", Offset = "0x6EC62A0", VA = "0x186EC72A0")]
	public GFKEDKKKNJN(AddressFamily PCHCGGAMAFI, CPNPKLEEMCO BGECOGBLKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6CE0", Offset = "0x6EC5CE0", VA = "0x186EC6CE0", Slot = "8")]
	public bool NGJEKGJIPEE(IPEndPoint KKNOGDEEABI, EEBGGGOLOIC AJJNOOFEAGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6CA0", Offset = "0x6EC5CA0", VA = "0x186EC6CA0", Slot = "9")]
	public int MKEBHJOCNAD(byte[] IIGKBHIENFB, int LLPAIMMACAP, int CFNMLMNHCMF, IPEndPoint ONGBEKHKLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6B90", Offset = "0x6EC5B90", VA = "0x186EC6B90", Slot = "10")]
	public int JHBDFCKMJJE(byte[] IIGKBHIENFB, EndPoint DDMINIOLAFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6B30", Offset = "0x6EC5B30", VA = "0x186EC6B30", Slot = "11")]
	public void FCKEIMJBABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface BAGLJBFNJGF
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short BMJOLJECHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int LELOHOILPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint PPGBPMLFGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily EPINNJMMOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NGJEKGJIPEE(IPEndPoint KKNOGDEEABI, EEBGGGOLOIC AJJNOOFEAGO);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int MKEBHJOCNAD(byte[] IIGKBHIENFB, int LLPAIMMACAP, int CFNMLMNHCMF, IPEndPoint ONGBEKHKLMA);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JHBDFCKMJJE(byte[] IIGKBHIENFB, EndPoint ONGBEKHKLMA);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCKEIMJBABB();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct NLGPHPHHFME : IEquatable<NLGPHPHHFME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly long KJOAJIMGDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly long FOLHBLINHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly long OCFKLNCEEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly int BLNAGIEECCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int POGOGNMLACM;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3090", Offset = "0x6ED2090", VA = "0x186ED3090")]
	public NLGPHPHHFME(byte[] OAHKGLFKJGM, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3150", Offset = "0x6ED2150", VA = "0x186ED3150")]
	public NLGPHPHHFME(Span<byte> OAHKGLFKJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA18A40", Offset = "0xA17A40", VA = "0x180A18A40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3050", Offset = "0x6ED2050", VA = "0x186ED3050", Slot = "4")]
	public bool Equals(NLGPHPHHFME MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2FA0", Offset = "0x6ED1FA0", VA = "0x186ED2FA0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class HMDPLABGOOG : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly byte[] NKIEADOCCCI;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class DHEBMGADODK
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal delegate void HJGKPJENNGP(IPEndPoint OAHKGLFKJGM, Span<byte> APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string IGHGEFPKIBI = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private const int PMNLCEDMBDM = 16;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const int DKICIKDOBHO = 28;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static Dictionary<NLGPHPHHFME, IPEndPoint> MFHIMPBLBOB;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static HJGKPJENNGP OCLILGKIPFK;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	internal void MDMFKNIKNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	internal void GHJCCOHKAHH(IPEndPoint ONGBEKHKLMA, Span<byte> APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class GHCLBHLCCLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly int PGIEEFDNANL;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
	protected GHCLBHLCCLF(int JEKPMGBMHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PPKMIPFAKGE(IPEndPoint KKNOGDEEABI, byte[] APDBNIMCPID, int LLPAIMMACAP, int DDGBDMFPMAI);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void OCOFPDBDCLD(IPEndPoint KKNOGDEEABI, byte[] APDBNIMCPID, int LLPAIMMACAP, int DDGBDMFPMAI);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class MBPLOODLPEC : GHCLBHLCCLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private byte[] OEHHKNIGGMI;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly RandomNumberGenerator AADEIIDDJGO;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x27B9E40", Offset = "0x27B8E40", VA = "0x1827B9E40")]
	public MBPLOODLPEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC540", Offset = "0x6ECB540", VA = "0x186ECC540")]
	public void EPHKCCCEEKN(IPEndPoint KKNOGDEEABI, byte[] OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC6F0", Offset = "0x6ECB6F0", VA = "0x186ECC6F0")]
	public void NPGPANJNBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCB40", Offset = "0x6ECBB40", VA = "0x186ECCB40", Slot = "4")]
	public override void PPKMIPFAKGE(IPEndPoint KKNOGDEEABI, byte[] APDBNIMCPID, int LLPAIMMACAP, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC7D0", Offset = "0x6ECB7D0", VA = "0x186ECC7D0", Slot = "5")]
	public override void OCOFPDBDCLD(IPEndPoint KKNOGDEEABI, byte[] APDBNIMCPID, int LLPAIMMACAP, int DDGBDMFPMAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[BurstCompile]
internal struct IEPDMLCNLAG
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void IDJGPIPLOJF([NoAlias] byte* AEMKAEBHHHG, [NoAlias] byte* OEHHKNIGGMI, [NoAlias] byte* LPKBKPJLCHH, int DDGBDMFPMAI);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class ICMDLEGNNBA
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3820", Offset = "0x6ED2820", VA = "0x186ED3820")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3950", Offset = "0x6ED2950", VA = "0x186ED3950")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3770", Offset = "0x6ED2770", VA = "0x186ED3770")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3530", Offset = "0x6ED2530", VA = "0x186ED3530")]
		public unsafe static void CIBKKMOJDEC([NoAlias] byte* AEMKAEBHHHG, [NoAlias] byte* OEHHKNIGGMI, [NoAlias] byte* LPKBKPJLCHH, int DDGBDMFPMAI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private unsafe fixed uint OEHHKNIGGMI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private unsafe fixed uint LPKBKPJLCHH[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private unsafe fixed uint IELCOCFINCG[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint DEBDINHOJAD[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint KFNNPFMPJDG[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint LJMLAANGMFF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint EMMHKNGHPAJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private uint OEDMOGDPDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint NBMDAEPHDMM[8];

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC80B0", Offset = "0x6EC70B0", VA = "0x186EC80B0")]
	private void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC86B0", Offset = "0x6EC76B0", VA = "0x186EC86B0")]
	private uint OHAFHKMDDGO(uint IINHKHEMEHJ, int KIEHMFJADIM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB8D0", Offset = "0x6EBA8D0", VA = "0x186EBB8D0")]
	private void GKMDCPLEKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB6C0", Offset = "0x6EBA6C0", VA = "0x186EBB6C0")]
	private void FGDLINCEICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB630", Offset = "0x6EBA630", VA = "0x186EBB630")]
	private void ECPDFLBMGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB530", Offset = "0x6EBA530", VA = "0x186EBB530")]
	private void BKFLKGMKJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8650", Offset = "0x6EC7650", VA = "0x186EC8650")]
	private void ODDCEAALNOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8230", Offset = "0x6EC7230", VA = "0x186EC8230")]
	private unsafe void NPNJIJAKJCO(byte* AEMKAEBHHHG, uint* OEHHKNIGGMI, uint* LPKBKPJLCHH, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7F50", Offset = "0x6EC6F50", VA = "0x186EC7F50")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void KFLJIPNFFLD([NoAlias] byte* AEMKAEBHHHG, [NoAlias] byte* OEHHKNIGGMI, [NoAlias] byte* LPKBKPJLCHH, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7FD0", Offset = "0x6EC6FD0", VA = "0x186EC7FD0")]
	public static void KFLJIPNFFLD(Span<byte> AEMKAEBHHHG, Span<byte> OEHHKNIGGMI, Span<byte> LPKBKPJLCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8130", Offset = "0x6EC7130", VA = "0x186EC8130")]
	public static void NGLOFJCKIOM(Span<byte> AEMKAEBHHHG, Span<byte> OEHHKNIGGMI, Span<byte> LPKBKPJLCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6EC86E0", Offset = "0x6EC76E0", VA = "0x186EC86E0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void OJDFAKBPPBJ([NoAlias] byte* AEMKAEBHHHG, [NoAlias] byte* OEHHKNIGGMI, [NoAlias] byte* LPKBKPJLCHH, int DDGBDMFPMAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3BB0", Offset = "0x6ED2BB0", VA = "0x186ED3BB0")]
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
