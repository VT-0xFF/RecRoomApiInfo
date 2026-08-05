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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MAFIGLIJNAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5000", Offset = "0x6EA3600", VA = "0x186EA5000", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4580", Offset = "0x6EA2B80", VA = "0x186EA4580")]
		public void RecRoom_SetEncryptionInfo(ulong HGNOFEMICKA, byte[] OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4560", Offset = "0x6EA2B60", VA = "0x186EA4560")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4410", Offset = "0x6EA2A10", VA = "0x186EA4410")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4F00", Offset = "0x6EA3500", VA = "0x186EA4F00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EA46A0", Offset = "0x6EA2CA0", VA = "0x186EA46A0", Slot = "6")]
		public override void Send(ulong GMGHHBHDHEG, ArraySegment<byte> APDBNIMCPID, NetworkDelivery FHGCPGFOBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4520", Offset = "0x6EA2B20", VA = "0x186EA4520", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong GMGHHBHDHEG, [Out] ArraySegment<byte> DGHLABNPIEC, [Out] float HKLECHOBMHF)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4990", Offset = "0x6EA2F90", VA = "0x186EA4990", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4E20", Offset = "0x6EA3420", VA = "0x186EA4E20", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3C80", Offset = "0x6EA2280", VA = "0x186EA3C80", Slot = "11")]
		public override void DisconnectRemoteClient(ulong GMGHHBHDHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3B90", Offset = "0x6EA2190", VA = "0x186EA3B90", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3FA0", Offset = "0x6EA25A0", VA = "0x186EA3FA0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong GMGHHBHDHEG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4920", Offset = "0x6EA2F20", VA = "0x186EA4920", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4040", Offset = "0x6EA2640", VA = "0x186EA4040", Slot = "15")]
		public override void Initialize([Optional] NetworkManager INFDPAGNKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4340", Offset = "0x6EA2940", VA = "0x186EA4340")]
		private NAAOLECOJPN OFANACBMEAO(NetworkDelivery MLCOGCMJLBB)
		{
			return default(NAAOLECOJPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4280", Offset = "0x6EA2880", VA = "0x186EA4280", Slot = "16")]
		private void OENCMONFKAL(MNEMGBAJIJH MNFIBPMCHAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3ED0", Offset = "0x6EA24D0", VA = "0x186EA3ED0", Slot = "17")]
		private void GIGIIJCENJA(MNEMGBAJIJH MNFIBPMCHAA, LAIOFOJOKKD DIGGJHFMOIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "18")]
		private void KOAPCBECMJJ(IPEndPoint KKNOGDEEABI, SocketError LEKIFMHNDHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3980", Offset = "0x6EA1F80", VA = "0x186EA3980", Slot = "19")]
		private void ALACBJIFHOC(MNEMGBAJIJH MNFIBPMCHAA, PCJBEMBIPHI HBMFONPEIJC, byte LMKBIAOABBJ, NAAOLECOJPN ENEPCCBENPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3DF0", Offset = "0x6EA23F0", VA = "0x186EA3DF0")]
		private void GCANFNCJHNI(int CFNMLMNHCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "20")]
		private void JOJNDKEDLOP(IPEndPoint ONGBEKHKLMA, PCJBEMBIPHI HBMFONPEIJC, LOMACBPPNPL OAOFDBDEHAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "21")]
		private void MJEHIEOGOJE(MNEMGBAJIJH MNFIBPMCHAA, int LGGKLAOJGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3D90", Offset = "0x6EA2390", VA = "0x186EA3D90", Slot = "22")]
		private void EHHGIELBNOG(FIDNDDKHCPB HOOJNAMGGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4250", Offset = "0x6EA2850", VA = "0x186EA4250")]
		private ulong KDOADLCPABC(MNEMGBAJIJH MNFIBPMCHAA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4500", Offset = "0x6EA2B00", VA = "0x186EA4500")]
		private static int PFHCPOCNDFA(float EPOJNFBFHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4F20", Offset = "0x6EA3520", VA = "0x186EA4F20")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E9D740", Offset = "0x6E9BD40", VA = "0x186E9D740")]
	protected EDLAECGIMAF(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D6A0", Offset = "0x6E9BCA0", VA = "0x186E9D6A0")]
	public void OGAHDHCDJIF(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D620", Offset = "0x6E9BC20", VA = "0x186E9D620")]
	protected void MJCFJPHJHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D700", Offset = "0x6E9BD00", VA = "0x186E9D700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA12D10", Offset = "0xA11310", VA = "0x180A12D10")]
		[CompilerGenerated]
		get
		{
			return default(FINEKIACOJD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD67020", Offset = "0xD65620", VA = "0x180D67020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E130", Offset = "0x6E9C730", VA = "0x186E9E130")]
	internal void BNEFOBIOFJK(EEGAKGINIBB GOJPAMDHFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E1F0", Offset = "0x6E9C7F0", VA = "0x186E9E1F0")]
	private bool MLMJPCNBNOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E220", Offset = "0x6E9C820", VA = "0x186E9E220")]
	internal FIDNDDKHCPB(IPEndPoint ONGBEKHKLMA, EEGAKGINIBB LBHFDFODEKG, CPNPKLEEMCO LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E190", Offset = "0x6E9C790", VA = "0x186E9E190")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E9DC40", Offset = "0x6E9C240", VA = "0x186E9DC40")]
	private EEGAKGINIBB(long OJHCAODIBFH, byte AEAABDJMLPB, int GOGGPBKDKBC, byte[] DJBBMLKFGDN, ACLDEKFAJGB APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DBE0", Offset = "0x6E9C1E0", VA = "0x186E9DBE0")]
	public static int NJEDNCDCGMM(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D9C0", Offset = "0x6E9BFC0", VA = "0x186E9D9C0")]
	public static EEGAKGINIBB ECDODHDJHDC(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D7E0", Offset = "0x6E9BDE0", VA = "0x186E9D7E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E95620", Offset = "0x6E93C20", VA = "0x186E95620")]
	private BLNPLOGBMCI(long OJHCAODIBFH, byte AEAABDJMLPB, int CGKJHPJNJFE, bool JOICNGLCKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E954D0", Offset = "0x6E93AD0", VA = "0x186E954D0")]
	public static BLNPLOGBMCI ECDODHDJHDC(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E952E0", Offset = "0x6E938E0", VA = "0x186E952E0")]
	public static FIFOBIGMFLH DOJIAKEFFIK(long MIMJNJHAEKK, byte NDOBFGLFBOD, int HAECKMHOENN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E953D0", Offset = "0x6E939D0", VA = "0x186E953D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HFAFNHKHPMO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAB6E90", Offset = "0xAB5490", VA = "0x180AB6E90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9F41E0", Offset = "0x9F27E0", VA = "0x1809F41E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EA74C0", Offset = "0x6EA5AC0", VA = "0x186EA74C0")]
	internal MJKNNLAIOLG(CPNPKLEEMCO KDGMKMCIFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EA71A0", Offset = "0x6EA57A0", VA = "0x186EA71A0")]
	internal void HIOLPNEGBHI(IPEndPoint COJOMIFMAHK, FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x39309A0", Offset = "0x392EFA0", VA = "0x1839309A0")]
	private void KJNJFNLADEB<T>(T AHEHGOPPDFG, IPEndPoint FCPOJLOEIEO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7010", Offset = "0x6EA5610", VA = "0x186EA7010")]
	private void BPMOBHFLIEC(NHFEBNMBJJB EOFLOFDELEP, IPEndPoint COJOMIFMAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6EB0", Offset = "0x6EA54B0", VA = "0x186EA6EB0")]
	private void BHJPHCCPGED(JBCNMHHEGHC EOFLOFDELEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7320", Offset = "0x6EA5920", VA = "0x186EA7320")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E9D610", Offset = "0x6E9BC10", VA = "0x186E9D610")]
	public DBBGMPAHMGB(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MMAGIPPPDDP : DBBGMPAHMGB
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D610", Offset = "0x6E9BC10", VA = "0x186E9D610")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E9FE40", Offset = "0x6E9E440", VA = "0x186E9FE40")]
	private static void EFAOPIDIALB(KAGMBFHKPLL OPMIFCIPGGP, string ANKDPLMACBD, params object[] ODJGLJIHJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0070", Offset = "0x6E9E670", VA = "0x186EA0070")]
	internal static void FIKJIKNLJKJ(string ANKDPLMACBD, params object[] ODJGLJIHJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6EA00D0", Offset = "0x6E9E6D0", VA = "0x186EA00D0")]
	internal static void KGMFHKFNMGK(string ANKDPLMACBD, params object[] ODJGLJIHJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0130", Offset = "0x6E9E730", VA = "0x186EA0130")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EABF40", Offset = "0x6EAA540", VA = "0x186EABF40")]
	internal PCJBEMBIPHI(CPNPKLEEMCO PAKPDHLKNJE, LJDFJCLOMPJ DOHIDBPJPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EABED0", Offset = "0x6EAA4D0", VA = "0x186EABED0")]
	internal void PKAFLAIKAEK(FIFOBIGMFLH AHEHGOPPDFG, int NKKLBAMEPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EABE20", Offset = "0x6EAA420", VA = "0x186EABE20")]
	internal void IIIJEPCDNFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EABEA0", Offset = "0x6EAA4A0", VA = "0x186EABEA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EA32D0", Offset = "0x6EA18D0", VA = "0x186EA32D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EAB990", Offset = "0x6EA9F90", VA = "0x186EAB990", Slot = "4")]
		public bool Equals(IPEndPoint CEJAAIDLEPA, IPEndPoint IMNDAJIDDFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x40A4DA0", Offset = "0x40A33A0", VA = "0x1840A4DA0", Slot = "5")]
		public int GetHashCode(IPEndPoint BOMDCGFKGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x19F4E50", Offset = "0x19F3450", VA = "0x1819F4E50")]
		public LLCOJNMEKPH(MNEMGBAJIJH NOOBIPOJNNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3370", Offset = "0x6EA1970", VA = "0x186EA3370", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6EA33C0", Offset = "0x6EA19C0", VA = "0x186EA33C0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x1460BE0", Offset = "0x145F1E0", VA = "0x181460BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E40370", Offset = "0x1E3E970", VA = "0x181E40370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GDEIFOBJPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1553520", Offset = "0x1551B20", VA = "0x181553520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E40410", Offset = "0x1E3EA10", VA = "0x181E40410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte HAGAOMCNAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xF46350", Offset = "0xF44950", VA = "0x180F46350")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PGIEEFDNANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E99250", Offset = "0x6E97850", VA = "0x186E99250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short BMJOLJECHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B2D0", Offset = "0x6E998D0", VA = "0x186E9B2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E97480", Offset = "0x6E95A80", VA = "0x186E97480")]
	public void BPAHDNMIAGA(IPEndPoint KKNOGDEEABI, byte[] OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E95950", Offset = "0x6E93F50", VA = "0x186E95950")]
	public void ANPOONCFBLN(IPEndPoint KKNOGDEEABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E99C00", Offset = "0x6E98200", VA = "0x186E99C00")]
	private bool HJIGNFFCIGB(IPEndPoint KKNOGDEEABI, [Out] MNEMGBAJIJH MNFIBPMCHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A210", Offset = "0x6E98810", VA = "0x186E9A210")]
	private void IMFJNFAPPFO(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C290", Offset = "0x6E9A890", VA = "0x186E9C290")]
	private void MOEFNNJAADP(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E97820", Offset = "0x6E95E20", VA = "0x186E97820")]
	private void DEGJOOMPJIN(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CFB0", Offset = "0x6E9B5B0", VA = "0x186E9CFB0")]
	public CPNPKLEEMCO(FGDAGALKDON LPLPDJPCKCO, [Optional] GHCLBHLCCLF JPEOIOHLJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B0A0", Offset = "0x6E996A0", VA = "0x186E9B0A0")]
	internal void JHAJONFLLBB(MNEMGBAJIJH KLPODKEJFAN, int LGGKLAOJGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E993E0", Offset = "0x6E979E0", VA = "0x186E993E0")]
	internal void HBOLKHDKFME(MNEMGBAJIJH KLPODKEJFAN, object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E99F00", Offset = "0x6E98500", VA = "0x186E99F00")]
	internal void HPIDLACOLOD(MNEMGBAJIJH MNFIBPMCHAA, PHMOOHPGGNH DKBCGBFNIGO, SocketError CIMEBBDHLON, FIFOBIGMFLH NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E95C20", Offset = "0x6E94220", VA = "0x186E95C20")]
	private void BFEPDBANIDB(MNEMGBAJIJH MNFIBPMCHAA, PHMOOHPGGNH DKBCGBFNIGO, SocketError CIMEBBDHLON, bool ECOALLGHBMI, byte[] APDBNIMCPID, int IPAELMFFKOA, int JAALIADHHOC, FIFOBIGMFLH NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E9BEB0", Offset = "0x6E9A4B0", VA = "0x186E9BEB0")]
	private void MNCCMHIPNHG(LJDFJCLOMPJ.KEJGBPFBNCM MLCOGCMJLBB, [Optional] MNEMGBAJIJH MNFIBPMCHAA, [Optional] IPEndPoint ONGBEKHKLMA, SocketError LELALGHIBFL = SocketError.Success, int LGGKLAOJGAK = 0, PHMOOHPGGNH JPBCGMMGHCE = PHMOOHPGGNH.ConnectionFailed, [Optional] FIDNDDKHCPB NDDJIHPKIOC, NAAOLECOJPN ENEPCCBENPP = NAAOLECOJPN.Unreliable, byte LMKBIAOABBJ = 0, [Optional] FIFOBIGMFLH OCKPFDJIOGF, [Optional] object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E99430", Offset = "0x6E97A30", VA = "0x186E99430")]
	private void HGJPKNDBGCL(LJDFJCLOMPJ DOHIDBPJPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C650", Offset = "0x6E9AC50", VA = "0x186E9C650")]
	internal void PIMDOGGPBLA(LJDFJCLOMPJ DOHIDBPJPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CA80", Offset = "0x6E9B080", VA = "0x186E9CA80")]
	private void PJHFHHDOHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C760", Offset = "0x6E9AD60", VA = "0x186E9C760")]
	private void PJBLKOMEIDI(int PHKGBBDCCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E97B00", Offset = "0x6E96100", VA = "0x186E97B00")]
	internal MNEMGBAJIJH EFIGKMDNLBB(FIDNDDKHCPB HOOJNAMGGBC, byte[] ABPGKFCFHHH, int IPAELMFFKOA, int DDGBDMFPMAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B020", Offset = "0x6E99620", VA = "0x186E9B020")]
	private int JGMPFJDJHIB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B670", Offset = "0x6E99C70", VA = "0x186E9B670")]
	private void MCDIOJBNFJL(IPEndPoint ONGBEKHKLMA, MNEMGBAJIJH OOFAPNLCPNO, EEGAKGINIBB MBFHPOPDIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E960B0", Offset = "0x6E946B0", VA = "0x186E960B0")]
	private void BNAGGJOGKLG(FIFOBIGMFLH AHEHGOPPDFG, IPEndPoint ONGBEKHKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B390", Offset = "0x6E99990", VA = "0x186E9B390")]
	internal void LFLOPPHDNEB(FIFOBIGMFLH AHEHGOPPDFG, NAAOLECOJPN OAKFMPLKGOM, byte LMKBIAOABBJ, int NKKLBAMEPIK, MNEMGBAJIJH KLPODKEJFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9AF90", Offset = "0x6E99590", VA = "0x186E9AF90")]
	public bool JDIKNMDACEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B000", Offset = "0x6E99600", VA = "0x186E9B000")]
	public bool JDIKNMDACEI(IPAddress KLAJEDKMENO, IPAddress CNENKFNNIHC, int JHMPKACOBFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A740", Offset = "0x6E98D40", VA = "0x186E9A740")]
	public bool JDIKNMDACEI(int JHMPKACOBFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C4A0", Offset = "0x6E9AAA0", VA = "0x186E9C4A0")]
	public void NOJLCHEGFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E98CB0", Offset = "0x6E972B0", VA = "0x186E98CB0")]
	public MNEMGBAJIJH GGPPMIKMDOH(string OAHKGLFKJGM, int JHMPKACOBFK, string OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E99170", Offset = "0x6E97770", VA = "0x186E99170")]
	public MNEMGBAJIJH GGPPMIKMDOH(string OAHKGLFKJGM, int JHMPKACOBFK, KLILFFCJMEE HHDFMOPIDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E98D90", Offset = "0x6E97390", VA = "0x186E98D90")]
	public MNEMGBAJIJH GGPPMIKMDOH(IPEndPoint FCPOJLOEIEO, KLILFFCJMEE HHDFMOPIDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E98120", Offset = "0x6E96720", VA = "0x186E98120")]
	public void EJJCFNDELCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E98130", Offset = "0x6E96730", VA = "0x186E98130")]
	public void EJJCFNDELCF(bool IAFHCGGNMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E95B70", Offset = "0x6E94170", VA = "0x186E95B70")]
	public void BAHAPIFFHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E95AA0", Offset = "0x6E940A0", VA = "0x186E95AA0")]
	public void BAHAPIFFHNH(byte[] APDBNIMCPID, int IPAELMFFKOA, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6E96070", Offset = "0x6E94670", VA = "0x186E96070")]
	public void BFEPDBANIDB(MNEMGBAJIJH MNFIBPMCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6E96030", Offset = "0x6E94630", VA = "0x186E96030")]
	public void BFEPDBANIDB(MNEMGBAJIJH MNFIBPMCHAA, byte[] APDBNIMCPID, int IPAELMFFKOA, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CDD0", Offset = "0x6E9B3D0", VA = "0x186E9CDD0", Slot = "4")]
	private IEnumerator<MNEMGBAJIJH> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CE60", Offset = "0x6E9B460", VA = "0x186E9CE60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A660", Offset = "0x6E98C60", VA = "0x186E9A660")]
	private FIFOBIGMFLH IOEGFBNNMOL(LHMBLOPDOMI LLPAKFGNDOB, int CFNMLMNHCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A580", Offset = "0x6E98B80", VA = "0x186E9A580")]
	private FIFOBIGMFLH IOEGFBNNMOL(LHMBLOPDOMI LLPAKFGNDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E95710", Offset = "0x6E93D10", VA = "0x186E95710")]
	internal FIFOBIGMFLH ACIDLGIDADA(int CFNMLMNHCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6E99CA0", Offset = "0x6E982A0", VA = "0x186E99CA0")]
	internal void HKMDKOMIFJG(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CEF0", Offset = "0x6E9B4F0", VA = "0x186E9CEF0")]
	static CPNPKLEEMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1460BE0", Offset = "0x145F1E0", VA = "0x181460BE0")]
	private bool DJLLMFIFBBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6E976A0", Offset = "0x6E95CA0", VA = "0x186E976A0")]
	private void CFLKLMLFENB(IPEndPoint LNANBGJCPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E99270", Offset = "0x6E97870", VA = "0x186E99270")]
	private void GPGBBIAGGPA(IPEndPoint LNANBGJCPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C2F0", Offset = "0x6E9A8F0", VA = "0x186E9C2F0")]
	private bool NELGALJFKCN(SocketException APEPCFJIAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A560", Offset = "0x6E98B60", VA = "0x186E9A560")]
	private void INPJNMKCDFN(DHEBMGADODK KDGMKMCIFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E99F40", Offset = "0x6E98540", VA = "0x186E99F40")]
	private void IEONLDINICE(BAGLJBFNJGF KDGMKMCIFMH, EndPoint KPCJMIFNEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6E9BB20", Offset = "0x6E9A120", VA = "0x186E9BB20")]
	private void MKGBKACPBBM(object IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A7C0", Offset = "0x6E98DC0", VA = "0x186E9A7C0")]
	public bool JDIKNMDACEI(IPAddress KLAJEDKMENO, IPAddress CNENKFNNIHC, int JHMPKACOBFK, bool ECFDLJPMDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B270", Offset = "0x6E99870", VA = "0x186E9B270")]
	internal int KIEAPMPIKDB(FIFOBIGMFLH AHEHGOPPDFG, IPEndPoint ONGBEKHKLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E98C70", Offset = "0x6E97270", VA = "0x186E98C70")]
	internal int FHOECFGGKEK(FIFOBIGMFLH AHEHGOPPDFG, IPEndPoint ONGBEKHKLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6E98490", Offset = "0x6E96A90", VA = "0x186E98490")]
	internal int FHOECFGGKEK(byte[] NAAMEAFIHJI, int IPAELMFFKOA, int DDGBDMFPMAI, IPEndPoint ONGBEKHKLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B0F0", Offset = "0x6E996F0", VA = "0x186E9B0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E9E510", Offset = "0x6E9CB10", VA = "0x186E9E510")]
		get
		{
			return default(LHMBLOPDOMI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E740", Offset = "0x6E9CD40", VA = "0x186E9E740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte NGHAIMJPLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E580", Offset = "0x6E9CB80", VA = "0x186E9E580")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E400", Offset = "0x6E9CA00", VA = "0x186E9E400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort GHONMMDKFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E6E0", Offset = "0x6E9CCE0", VA = "0x186E9E6E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E350", Offset = "0x6E9C950", VA = "0x186E9E350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HMOBCCPJMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E6B0", Offset = "0x6E9CCB0", VA = "0x186E9E6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PDONOMLLNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E780", Offset = "0x6E9CD80", VA = "0x186E9E780")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E440", Offset = "0x6E9CA40", VA = "0x186E9E440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort BLHJJJHCMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E290", Offset = "0x6E9C890", VA = "0x186E9E290")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E470", Offset = "0x6E9CA70", VA = "0x186E9E470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort IEDOBBGHACA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E4B0", Offset = "0x6E9CAB0", VA = "0x186E9E4B0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E540", Offset = "0x6E9CB40", VA = "0x186E9E540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JJCCPCNDPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E2F0", Offset = "0x6E9C8F0", VA = "0x186E9E2F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E3C0", Offset = "0x6E9C9C0", VA = "0x186E9E3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E8B0", Offset = "0x6E9CEB0", VA = "0x186E9E8B0")]
	static FIFOBIGMFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E390", Offset = "0x6E9C990", VA = "0x186E9E390")]
	public void HGPKIFNFPMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EB70", Offset = "0x6E9D170", VA = "0x186E9EB70")]
	public FIFOBIGMFLH(int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EBE0", Offset = "0x6E9D1E0", VA = "0x186E9EBE0")]
	public FIFOBIGMFLH(LHMBLOPDOMI LLPAKFGNDOB, int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E7B0", Offset = "0x6E9CDB0", VA = "0x186E9E7B0")]
	public static int PEOMJCJPHLO(LHMBLOPDOMI LLPAKFGNDOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E820", Offset = "0x6E9CE20", VA = "0x186E9E820")]
	public int PEOMJCJPHLO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E5B0", Offset = "0x6E9CBB0", VA = "0x186E9E5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA1420", Offset = "0xA9FA20", VA = "0x180AA1420")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9E40", Offset = "0x6EA8440", VA = "0x186EA9E40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint OKADKMEDLAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xCC11E0", Offset = "0xCBF7E0", VA = "0x180CC11E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AFFBCOPKCJL DDKAOOEDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB906D0", Offset = "0xB8ECD0", VA = "0x180B906D0")]
		get
		{
			return default(AFFBCOPKCJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long MIILGEADAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F64B0", Offset = "0x9F4AB0", VA = "0x1809F64B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GAPLLKDOPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x15534F0", Offset = "0x1551AF0", VA = "0x1815534F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1E401B0", Offset = "0x1E3E7B0", VA = "0x181E401B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int JLDGMNFKLLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAC40", Offset = "0x6EA9240", VA = "0x186EAAC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KABACJKKHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double OBJHCHNMJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA140", Offset = "0x4EA8740", VA = "0x184EAA140")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MAEKNNEHFGC ELFKAOCMBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8F20", Offset = "0x6EA7520", VA = "0x186EA8F20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9EF0", Offset = "0x6EA84F0", VA = "0x186EA9EF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB1D0", Offset = "0x6EA97D0", VA = "0x186EAB1D0")]
	internal MNEMGBAJIJH(CPNPKLEEMCO BGECOGBLKLN, IPEndPoint ONGBEKHKLMA, int HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8A20", Offset = "0x6EA7020", VA = "0x186EA8A20")]
	internal void FMNJPFPBAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAFF0", Offset = "0x6EA95F0", VA = "0x186EAAFF0")]
	internal void OHDHIKLJPAP(IPEndPoint AAOKNDOKKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAF60", Offset = "0x6EA9560", VA = "0x186EAAF60")]
	internal void OAKPLDMJFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7EE0", Offset = "0x6EA64E0", VA = "0x186EA7EE0")]
	private void ELODPCIEJLL(int EPCCHLBJDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7EA0", Offset = "0x6EA64A0", VA = "0x186EA7EA0")]
	private void ECBMMPLFCDO(int JIPEDJPBMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB020", Offset = "0x6EA9620", VA = "0x186EAB020")]
	private EDLAECGIMAF PPLIFKAMFOH(byte JDCGPDDDLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB620", Offset = "0x6EA9C20", VA = "0x186EAB620")]
	internal MNEMGBAJIJH(CPNPKLEEMCO BGECOGBLKLN, IPEndPoint ONGBEKHKLMA, int HJPLNJNIFLL, byte NDOBFGLFBOD, KLILFFCJMEE JPFGPPEMEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB7B0", Offset = "0x6EA9DB0", VA = "0x186EAB7B0")]
	internal MNEMGBAJIJH(CPNPKLEEMCO BGECOGBLKLN, FIDNDDKHCPB HOOJNAMGGBC, int HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAF10", Offset = "0x6EA9510", VA = "0x186EAAF10")]
	internal void NFHLFBEIBDO(EEGAKGINIBB AHNNAOEGCIK, byte[] APDBNIMCPID, int IPAELMFFKOA, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6EAABC0", Offset = "0x6EA91C0", VA = "0x186EAABC0")]
	internal bool MEHLAMJJOAF(BLNPLOGBMCI AHEHGOPPDFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9FA0", Offset = "0x6EA85A0", VA = "0x186EA9FA0")]
	public void KJNJFNLADEB(byte[] APDBNIMCPID, int IPAELMFFKOA, int DDGBDMFPMAI, NAAOLECOJPN BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9020", Offset = "0x6EA7620", VA = "0x186EA9020")]
	private void IBENKGBIKDL(byte[] APDBNIMCPID, int IPAELMFFKOA, int DDGBDMFPMAI, byte LMKBIAOABBJ, NAAOLECOJPN ENEPCCBENPP, object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8FD0", Offset = "0x6EA75D0", VA = "0x186EA8FD0")]
	public void HJEEFCHPPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7FB0", Offset = "0x6EA65B0", VA = "0x186EA7FB0")]
	internal NBKIIFFAKJI FFGLBJFOAHE(FIFOBIGMFLH AHEHGOPPDFG)
	{
		return default(NBKIIFFAKJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA690", Offset = "0x6EA8C90", VA = "0x186EAA690")]
	internal void LEBEGPKLPPJ(EDLAECGIMAF DHLCHOOBMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA6F0", Offset = "0x6EA8CF0", VA = "0x186EAA6F0")]
	internal EMEHFHAECKE MBEJPJGMKMC(byte[] APDBNIMCPID, int IPAELMFFKOA, int DDGBDMFPMAI, bool ECOALLGHBMI)
	{
		return default(EMEHFHAECKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7910", Offset = "0x6EA5F10", VA = "0x186EA7910")]
	private void ANIHKIKAIMN(int NBIGABKFGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8090", Offset = "0x6EA6690", VA = "0x186EA8090")]
	internal void FJFHBMPHFPD(NAAOLECOJPN OAKFMPLKGOM, FIFOBIGMFLH NOOBIPOJNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7950", Offset = "0x6EA5F50", VA = "0x186EA7950")]
	private void CKABBPDGNAH(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8A40", Offset = "0x6EA7040", VA = "0x186EA8A40")]
	private void GFJOBHOGBDM(int CJIPMCGKHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAA00", Offset = "0x6EA9000", VA = "0x186EAAA00")]
	internal DFDLCALOMGG MCDIOJBNFJL(EEGAKGINIBB MBFHPOPDIMB)
	{
		return default(DFDLCALOMGG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9FD0", Offset = "0x6EA85D0", VA = "0x186EA9FD0")]
	internal void LDNIGPACMDM(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8DD0", Offset = "0x6EA73D0", VA = "0x186EA8DD0")]
	private void GGIHAHLCINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9C40", Offset = "0x6EA8240", VA = "0x186EA9C40")]
	internal void IMLENGBMCAB(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9580", Offset = "0x6EA7B80", VA = "0x186EA9580")]
	internal void IEKHBJGOAKB(int CJIPMCGKHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAC50", Offset = "0x6EA9250", VA = "0x186EAAC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EA0540", Offset = "0x6E9EB40", VA = "0x186EA0540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long AONGIGGGAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EA02B0", Offset = "0x6E9E8B0", VA = "0x186EA02B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long BODMBAPLPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6EA0330", Offset = "0x6E9E930", VA = "0x186EA0330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long LHHNBOBGAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EA0550", Offset = "0x6E9EB50", VA = "0x186EA0550")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MAOGMECFNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EA02C0", Offset = "0x6E9E8C0", VA = "0x186EA02C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long OLPEGHGBCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6EA0660", Offset = "0x6E9EC60", VA = "0x186EA0660")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long DEEPOIIHBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6EA0670", Offset = "0x6E9EC70", VA = "0x186EA0670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long LEHNGAIJCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6EA03B0", Offset = "0x6E9E9B0", VA = "0x186EA03B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private LPBJFKOBPDM DCFCGIEDENP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6EA02A0", Offset = "0x6E9E8A0", VA = "0x186EA02A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double CPJIALNJIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6EA02D0", Offset = "0x6E9E8D0", VA = "0x186EA02D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EA04A0", Offset = "0x6E9EAA0", VA = "0x186EA04A0")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0560", Offset = "0x6E9EB60", VA = "0x186EA0560")]
	public void NBEFHODHMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0450", Offset = "0x6E9EA50", VA = "0x186EA0450")]
	public void KGHHDJLFHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6EA03F0", Offset = "0x6E9E9F0", VA = "0x186EA03F0")]
	public void JGODLOCDPAF(long OMHADDJBDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6EA04E0", Offset = "0x6E9EAE0", VA = "0x186EA04E0")]
	public void LLJBEGKNGLA(long IHFIGKEJCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0240", Offset = "0x6E9E840", VA = "0x186EA0240")]
	public void ACNMJNNHPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0340", Offset = "0x6E9E940", VA = "0x186EA0340")]
	public void GOMHNFNEPIO(long DIDEMGEMCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EA06B0", Offset = "0x6E9ECB0", VA = "0x186EA06B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EA05C0", Offset = "0x6E9EBC0", VA = "0x186EA05C0")]
	public void NLLCNINMFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EA36A0", Offset = "0x6EA1CA0", VA = "0x186EA36A0")]
	public static IPEndPoint LDEHPPCKEIO(string EBJOIPCLPEB, int JHMPKACOBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EA34D0", Offset = "0x6EA1AD0", VA = "0x186EA34D0")]
	public static IPAddress FLDILIICJJI(string EBJOIPCLPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3440", Offset = "0x6EA1A40", VA = "0x186EA3440")]
	public static IPAddress FLDILIICJJI(string EBJOIPCLPEB, AddressFamily PCHCGGAMAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3410", Offset = "0x6EA1A10", VA = "0x186EA3410")]
	internal static int FGJFKHNIJNL(int COJHHFHLPJN, int DPCDDDOIHML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3917430", Offset = "0x3915A30", VA = "0x183917430")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EA1330", Offset = "0x6E9F930", VA = "0x186EA1330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1250", Offset = "0x6E9F850", VA = "0x186EA1250")]
		public void EEBICEODLFH(FIFOBIGMFLH AHEHGOPPDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6EA12C0", Offset = "0x6E9F8C0", VA = "0x186EA12C0")]
		public bool OKLEDCPAABL(long DBEFOCGFFJA, MNEMGBAJIJH MNFIBPMCHAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1270", Offset = "0x6E9F870", VA = "0x186EA1270")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EA3100", Offset = "0x6EA1700", VA = "0x186EA3100")]
	public LIHOJPBMNFF(MNEMGBAJIJH MNFIBPMCHAA, bool HJHBOHCCPCE, byte HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EA2210", Offset = "0x6EA0810", VA = "0x186EA2210")]
	private void GEGBLNOIBCA(FIFOBIGMFLH AHEHGOPPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6EA25D0", Offset = "0x6EA0BD0", VA = "0x186EA25D0", Slot = "4")]
	protected override bool IGPNBIJNGKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6EA2AA0", Offset = "0x6EA10A0", VA = "0x186EA2AA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E9F560", Offset = "0x6E9DB60", VA = "0x186E9F560")]
	public FPIGKKCOBOG(MNEMGBAJIJH MNFIBPMCHAA, bool JOJACDFCNNL, byte HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EDC0", Offset = "0x6E9D3C0", VA = "0x186E9EDC0", Slot = "4")]
	protected override bool IGPNBIJNGKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F280", Offset = "0x6E9D880", VA = "0x186E9F280", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E93F40", Offset = "0x6E92540", VA = "0x186E93F40")]
	private static void LAEEFCPGCNO(byte[] IIGKBHIENFB, int LLPAIMMACAP, ulong APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E95260", Offset = "0x6E93860", VA = "0x186E95260")]
	private static void LAEEFCPGCNO(byte[] IIGKBHIENFB, int LLPAIMMACAP, int APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E95180", Offset = "0x6E93780", VA = "0x186E95180")]
	public static void LAEEFCPGCNO(byte[] IIGKBHIENFB, int LLPAIMMACAP, short APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6E951C0", Offset = "0x6E937C0", VA = "0x186E951C0")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, double OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6E951E0", Offset = "0x6E937E0", VA = "0x186E951E0")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6E95180", Offset = "0x6E93780", VA = "0x186E95180")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, short OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E95180", Offset = "0x6E93780", VA = "0x186E95180")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, ushort OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6E95260", Offset = "0x6E93860", VA = "0x186E95260")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E95260", Offset = "0x6E93860", VA = "0x186E95260")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, uint OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6E952D0", Offset = "0x6E938D0", VA = "0x186E952D0")]
	public static void GIIKIENHIHL(byte[] ACDPPDBEDDM, int NGFMNKONPKM, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E952D0", Offset = "0x6E938D0", VA = "0x186E952D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FELJFFDJELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BMLHABEFLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6E94590", Offset = "0x6E92B90", VA = "0x186E94590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BDENHAPMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2672EC0", Offset = "0x26714C0", VA = "0x182672EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int HFJBLKHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6E94B60", Offset = "0x6E93160", VA = "0x186E94B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E950A0", Offset = "0x6E936A0", VA = "0x186E950A0")]
	public void PKAFLAIKAEK(byte[] NEKLMLONNIM, int LLPAIMMACAP, int DFDEPGDGEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public ACLDEKFAJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E95120", Offset = "0x6E93720", VA = "0x186E95120")]
	public ACLDEKFAJGB(byte[] NEKLMLONNIM, int LLPAIMMACAP, int DFDEPGDGEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E94870", Offset = "0x6E92E70", VA = "0x186E94870")]
	public IPEndPoint ILNDIMFDPDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E94960", Offset = "0x6E92F60", VA = "0x186E94960")]
	public byte KDOLPCFNLEM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6E94960", Offset = "0x6E92F60", VA = "0x186E94960")]
	public sbyte JCHDNEDGLCD()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3FBA510", Offset = "0x3FB8B10", VA = "0x183FBA510")]
	public T[] HABPIGJFOBL<T>(ushort CFNMLMNHCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E94E50", Offset = "0x6E93450", VA = "0x186E94E50")]
	public bool[] NLBBHBGODCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6E94830", Offset = "0x6E92E30", VA = "0x186E94830")]
	public ushort[] IGOCBLBIFEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6E947B0", Offset = "0x6E92DB0", VA = "0x186E947B0")]
	public short[] HMDKPCNNPAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E94610", Offset = "0x6E92C10", VA = "0x186E94610")]
	public int[] BIJMGOELPBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6E94FB0", Offset = "0x6E935B0", VA = "0x186E94FB0")]
	public uint[] OKHFFECFEDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E950E0", Offset = "0x6E936E0", VA = "0x186E950E0")]
	public float[] PMBGKOEBCEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E94F70", Offset = "0x6E93570", VA = "0x186E94F70")]
	public double[] OIHBBCOOJAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E94E10", Offset = "0x6E93410", VA = "0x186E94E10")]
	public long[] NCILLJILGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E94770", Offset = "0x6E92D70", VA = "0x186E94770")]
	public ulong[] FIADKFKLPPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E949A0", Offset = "0x6E92FA0", VA = "0x186E949A0")]
	public string[] JDHHMEFDMFO(int FPENKDACOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E94FF0", Offset = "0x6E935F0", VA = "0x186E94FF0")]
	public bool OKLGNCIFKBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6E94650", Offset = "0x6E92C50", VA = "0x186E94650")]
	public char PJHMBNFGOLD()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E94650", Offset = "0x6E92C50", VA = "0x186E94650")]
	public ushort BOOKEMDKMBK()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6E94B70", Offset = "0x6E93170", VA = "0x186E94B70")]
	public short KGCHLIEALCC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6E945A0", Offset = "0x6E92BA0", VA = "0x186E945A0")]
	public long BDDFBMHAGNG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6E95030", Offset = "0x6E93630", VA = "0x186E95030")]
	public ulong OKPEOLMGEEH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6E94E90", Offset = "0x6E93490", VA = "0x186E94E90")]
	public int NNOIHJGKKGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6E94520", Offset = "0x6E92B20", VA = "0x186E94520")]
	public uint AIEPONGFOKD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E946C0", Offset = "0x6E92CC0", VA = "0x186E946C0")]
	public float EPIJGHEEOEF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E94F00", Offset = "0x6E93500", VA = "0x186E94F00")]
	public double OEBAMKJHEOC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E94BE0", Offset = "0x6E931E0", VA = "0x186E94BE0")]
	public string LEEDJCCMEMN(int HOMPFMAAAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6E94AF0", Offset = "0x6E930F0", VA = "0x186E94AF0")]
	public ArraySegment<byte> JEMLOKALEOO(int JAALIADHHOC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6E947F0", Offset = "0x6E92DF0", VA = "0x186E947F0")]
	public sbyte[] ICMDNKLJNCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6E94730", Offset = "0x6E92D30", VA = "0x186E94730")]
	public byte[] FFMCBMNCEFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6E94940", Offset = "0x6E92F40", VA = "0x186E94940")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA2190", Offset = "0x6EA0790", VA = "0x186EA2190")]
	public KLILFFCJMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA20F0", Offset = "0x6EA06F0", VA = "0x186EA20F0")]
	public KLILFFCJMEE(bool HELGPCHNBKA, int IEJFHANCGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1F60", Offset = "0x6EA0560", VA = "0x186EA1F60")]
	public static KLILFFCJMEE IFOLFJOHHKB(string OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1FD0", Offset = "0x6EA05D0", VA = "0x186EA1FD0")]
	public void MCPGKJAPPDF(int IPMBIEKIIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xD37D30", Offset = "0xD36330", VA = "0x180D37D30")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1920", Offset = "0x6E9FF20", VA = "0x186EA1920")]
	public void EJBPHCOOKGN(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1810", Offset = "0x6E9FE10", VA = "0x186EA1810")]
	public void EJBPHCOOKGN(double OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1860", Offset = "0x6E9FE60", VA = "0x186EA1860")]
	public void EJBPHCOOKGN(long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1860", Offset = "0x6E9FE60", VA = "0x186EA1860")]
	public void EJBPHCOOKGN(ulong OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1780", Offset = "0x6E9FD80", VA = "0x186EA1780")]
	public void EJBPHCOOKGN(int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1780", Offset = "0x6E9FD80", VA = "0x186EA1780")]
	public void EJBPHCOOKGN(uint OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1710", Offset = "0x6E9FD10", VA = "0x186EA1710")]
	public void EJBPHCOOKGN(char OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1710", Offset = "0x6E9FD10", VA = "0x186EA1710")]
	public void EJBPHCOOKGN(ushort OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1710", Offset = "0x6E9FD10", VA = "0x186EA1710")]
	public void EJBPHCOOKGN(short OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6EA16B0", Offset = "0x6E9FCB0", VA = "0x186EA16B0")]
	public void EJBPHCOOKGN(sbyte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA16B0", Offset = "0x6E9FCB0", VA = "0x186EA16B0")]
	public void EJBPHCOOKGN(byte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA18B0", Offset = "0x6E9FEB0", VA = "0x186EA18B0")]
	public void EJBPHCOOKGN(byte[] APDBNIMCPID, int LLPAIMMACAP, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1A30", Offset = "0x6EA0030", VA = "0x186EA1A30")]
	public void HIELJGNKHGH(sbyte[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1A30", Offset = "0x6EA0030", VA = "0x186EA1A30")]
	public void LLKDGFHPINH(byte[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA19D0", Offset = "0x6E9FFD0", VA = "0x186EA19D0")]
	public void EJBPHCOOKGN(bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1E80", Offset = "0x6EA0480", VA = "0x186EA1E80")]
	public void HDMKBIAMEJD(Array OGAMHOMMEAC, int NLELKCNHPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1BE0", Offset = "0x6EA01E0", VA = "0x186EA1BE0")]
	public void HDMKBIAMEJD(float[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1CC0", Offset = "0x6EA02C0", VA = "0x186EA1CC0")]
	public void HDMKBIAMEJD(double[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1CC0", Offset = "0x6EA02C0", VA = "0x186EA1CC0")]
	public void HDMKBIAMEJD(long[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1CC0", Offset = "0x6EA02C0", VA = "0x186EA1CC0")]
	public void HDMKBIAMEJD(ulong[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1BE0", Offset = "0x6EA01E0", VA = "0x186EA1BE0")]
	public void HDMKBIAMEJD(int[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1BE0", Offset = "0x6EA01E0", VA = "0x186EA1BE0")]
	public void HDMKBIAMEJD(uint[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1DA0", Offset = "0x6EA03A0", VA = "0x186EA1DA0")]
	public void HDMKBIAMEJD(ushort[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1DA0", Offset = "0x6EA03A0", VA = "0x186EA1DA0")]
	public void HDMKBIAMEJD(short[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1A30", Offset = "0x6EA0030", VA = "0x186EA1A30")]
	public void HDMKBIAMEJD(bool[] OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1B10", Offset = "0x6EA0110", VA = "0x186EA1B10")]
	public void HDMKBIAMEJD(string[] OHLIHBDBKCE, int HNGHABGOFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA15E0", Offset = "0x6E9FBE0", VA = "0x186EA15E0")]
	public void EJBPHCOOKGN(IPEndPoint KKNOGDEEABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA19C0", Offset = "0x6E9FFC0", VA = "0x186EA19C0")]
	public void EJBPHCOOKGN(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA13D0", Offset = "0x6E9F9D0", VA = "0x186EA13D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5356E30", Offset = "0x5355430", VA = "0x185356E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CGHFDOLODCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x67AB0A0", Offset = "0x67A96A0", VA = "0x1867AB0A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NPKPOMGDMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5426440", Offset = "0x5424A40", VA = "0x185426440")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E9DFB0", Offset = "0x6E9C5B0", VA = "0x186E9DFB0")]
	public FFJNGFDJPPP(int FPENKDACOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x35EE5F0", Offset = "0x35ECBF0", VA = "0x1835EE5F0", Slot = "4")]
	protected virtual ulong KLJNHBBKJDH<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DE30", Offset = "0x6E9C430", VA = "0x186E9DE30", Slot = "5")]
	protected virtual FICGHPHEFEC GPNPJEKEJDD(ACLDEKFAJGB HBMFONPEIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x385D030", Offset = "0x385B630", VA = "0x18385D030", Slot = "6")]
	protected virtual void NEOKLKGMFCA<T>(KLILFFCJMEE NFOCFJIIPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DDB0", Offset = "0x6E9C3B0", VA = "0x186E9DDB0")]
	public void FCBKJKOPIOJ(ACLDEKFAJGB HBMFONPEIJC, object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x385CC00", Offset = "0x385B200", VA = "0x18385CC00")]
	public void FOKICFNDJFF<T>(KLILFFCJMEE NFOCFJIIPHM, T AHEHGOPPDFG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DF60", Offset = "0x6E9C560", VA = "0x186E9DF60")]
	public void JHDHAEDMIAC(ACLDEKFAJGB HBMFONPEIJC, object GCLNNHGNABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x385CE70", Offset = "0x385B470", VA = "0x18385CE70")]
	public void LJEEGOGEEFF<T>(Action<T> FBKOCJAFGDK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x385CCB0", Offset = "0x385B2B0", VA = "0x18385CCB0")]
	public void LJEEGOGEEFF<T, TUserData>(Action<T, TUserData> FBKOCJAFGDK) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class MFLMOIMJJGI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D610", Offset = "0x6E9BC10", VA = "0x186E9D610")]
	public MFLMOIMJJGI(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JEFPCMEJIHK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA11F0", Offset = "0x6E9F7F0", VA = "0x186EA11F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x49AA210", Offset = "0x49A8810", VA = "0x1849AA210", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x553BFD0", Offset = "0x553A5D0", VA = "0x18553BFD0", Slot = "7")]
		public override void JKKGILIGMEE(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x553A510", Offset = "0x5538B10", VA = "0x18553A510", Slot = "8")]
		public override void GOPCFKFAPID(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5535550", Offset = "0x5533B50", VA = "0x185535550", Slot = "9")]
		public override void AFIGADGINFD(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x553B770", Offset = "0x5539D70", VA = "0x18553B770", Slot = "10")]
		public override void HBJPNBOOPNK(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x553C350", Offset = "0x553A950", VA = "0x18553C350")]
		protected TProperty[] MKNKEENANCC(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x553B850", Offset = "0x5539E50", VA = "0x18553B850")]
		protected TProperty[] JHGMBCFPNMH(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5538190", Offset = "0x5536790", VA = "0x185538190", Slot = "4")]
		public override void EEBICEODLFH(MethodInfo LPHMBJGAFFB, MethodInfo JABKAHKJHKJ, KBKFPBKLBHI MLCOGCMJLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4E6B470", Offset = "0x4E69A70", VA = "0x184E6B470")]
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
		[Cpp2IlInjected.Address(RVA = "0x45208C0", Offset = "0x451EEC0", VA = "0x1845208C0", Slot = "5")]
		public override void NPNJAONMOHB(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4520420", Offset = "0x451EA20", VA = "0x184520420", Slot = "6")]
		public override void FOKICFNDJFF(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x45206A0", Offset = "0x451ECA0", VA = "0x1845206A0", Slot = "7")]
		public override void JKKGILIGMEE(TClass LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4520520", Offset = "0x451EB20", VA = "0x184520520", Slot = "8")]
		public override void GOPCFKFAPID(TClass LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4520960", Offset = "0x451EF60", VA = "0x184520960")]
		protected EIEGKCPGDPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class BFCCLDNJAMC<T> : OIBCPFLEDFF<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6236E30", Offset = "0x6235430", VA = "0x186236E30", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5544940", Offset = "0x5542F40", VA = "0x185544940", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6236DB0", Offset = "0x62353B0", VA = "0x186236DB0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x499B440", Offset = "0x4999A40", VA = "0x18499B440", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public BFCCLDNJAMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class OLOIBDPEIHM<T> : OIBCPFLEDFF<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5544A30", Offset = "0x5543030", VA = "0x185544A30", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5544940", Offset = "0x5542F40", VA = "0x185544940", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x55449B0", Offset = "0x5542FB0", VA = "0x1855449B0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x499B440", Offset = "0x4999A40", VA = "0x18499B440", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public OLOIBDPEIHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class BLGEBMAAAEM<T> : OIBCPFLEDFF<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x633C4B0", Offset = "0x633AAB0", VA = "0x18633C4B0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4C24BF0", Offset = "0x4C231F0", VA = "0x184C24BF0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x633C430", Offset = "0x633AA30", VA = "0x18633C430", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4C24C60", Offset = "0x4C23260", VA = "0x184C24C60", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public BLGEBMAAAEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class ICDODKENFAG<T> : OIBCPFLEDFF<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4C24D50", Offset = "0x4C23350", VA = "0x184C24D50", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4C24BF0", Offset = "0x4C231F0", VA = "0x184C24BF0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4C24CD0", Offset = "0x4C232D0", VA = "0x184C24CD0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4C24C60", Offset = "0x4C23260", VA = "0x184C24C60", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public ICDODKENFAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class OBLMGODLKEA<T> : OIBCPFLEDFF<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x55220A0", Offset = "0x55206A0", VA = "0x1855220A0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x44F66B0", Offset = "0x44F4CB0", VA = "0x1844F66B0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5522020", Offset = "0x5520620", VA = "0x185522020", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x44F6720", Offset = "0x44F4D20", VA = "0x1844F6720", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public OBLMGODLKEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class ECDFMDIHJNJ<T> : OIBCPFLEDFF<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x44F6810", Offset = "0x44F4E10", VA = "0x1844F6810", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x44F66B0", Offset = "0x44F4CB0", VA = "0x1844F66B0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x44F6790", Offset = "0x44F4D90", VA = "0x1844F6790", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x44F6720", Offset = "0x44F4D20", VA = "0x1844F6720", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public ECDFMDIHJNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class NNMADAFAGCN<T> : OIBCPFLEDFF<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x532ADF0", Offset = "0x53293F0", VA = "0x18532ADF0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x532AC90", Offset = "0x5329290", VA = "0x18532AC90", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5416250", Offset = "0x5414850", VA = "0x185416250", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x532AD00", Offset = "0x5329300", VA = "0x18532AD00", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public NNMADAFAGCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MADHDLBOLNF<T> : OIBCPFLEDFF<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x532ADF0", Offset = "0x53293F0", VA = "0x18532ADF0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x532AC90", Offset = "0x5329290", VA = "0x18532AC90", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x532AD70", Offset = "0x5329370", VA = "0x18532AD70", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x532AD00", Offset = "0x5329300", VA = "0x18532AD00", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public MADHDLBOLNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FDOKNLAGHAE<T> : OIBCPFLEDFF<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x499B530", Offset = "0x4999B30", VA = "0x18499B530", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x499B3D0", Offset = "0x49999D0", VA = "0x18499B3D0", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x499B4B0", Offset = "0x4999AB0", VA = "0x18499B4B0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x499B440", Offset = "0x4999A40", VA = "0x18499B440", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public FDOKNLAGHAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MCLEJDLJJGN<T> : OIBCPFLEDFF<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x532EC50", Offset = "0x532D250", VA = "0x18532EC50", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x532EB60", Offset = "0x532D160", VA = "0x18532EB60", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x532EBD0", Offset = "0x532D1D0", VA = "0x18532EBD0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x44F6720", Offset = "0x44F4D20", VA = "0x1844F6720", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public MCLEJDLJJGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class BACJNONJMCA<T> : OIBCPFLEDFF<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6054D60", Offset = "0x6053360", VA = "0x186054D60", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6054C70", Offset = "0x6053270", VA = "0x186054C70", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6054CE0", Offset = "0x60532E0", VA = "0x186054CE0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x532AD00", Offset = "0x5329300", VA = "0x18532AD00", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
		public BACJNONJMCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class CJAJDIOBCOA<T> : EIEGKCPGDPM<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x67B6AF0", Offset = "0x67B50F0", VA = "0x1867B6AF0", Slot = "12")]
		protected override void BBKBIACKOEB(KLILFFCJMEE NJMPEFLBAHN, char NIPNOJNPKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x67B6B20", Offset = "0x67B5120", VA = "0x1867B6B20", Slot = "11")]
		protected override void GOMOCDLAPPK(ACLDEKFAJGB NFFBJCCKPJF, [Out] char NIPNOJNPKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x44C62B0", Offset = "0x44C48B0", VA = "0x1844C62B0")]
		public CJAJDIOBCOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class DEABLIJNJBP<T> : EIEGKCPGDPM<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A376D0", Offset = "0x6A35CD0", VA = "0x186A376D0", Slot = "12")]
		protected override void BBKBIACKOEB(KLILFFCJMEE NJMPEFLBAHN, IPEndPoint NIPNOJNPKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A37700", Offset = "0x6A35D00", VA = "0x186A37700", Slot = "11")]
		protected override void GOMOCDLAPPK(ACLDEKFAJGB NFFBJCCKPJF, [Out] IPEndPoint NIPNOJNPKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x44C62B0", Offset = "0x44C48B0", VA = "0x1844C62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5529280", Offset = "0x5527880", VA = "0x185529280")]
		public OFEGNGPPKBJ(int HOMPFMAAAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5529200", Offset = "0x5527800", VA = "0x185529200", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5529080", Offset = "0x5527680", VA = "0x185529080", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5529180", Offset = "0x5527780", VA = "0x185529180", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5529100", Offset = "0x5527700", VA = "0x185529100", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A3C4D0", Offset = "0x6A3AAD0", VA = "0x186A3C4D0")]
		public DGAGGLCLPCH(PropertyInfo LLPAKFGNDOB, Type APCIGGMPPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C410", Offset = "0x6A3AA10", VA = "0x186A3C410", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C240", Offset = "0x6A3A840", VA = "0x186A3C240", Slot = "6")]
		public override void FOKICFNDJFF(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C3B0", Offset = "0x6A3A9B0", VA = "0x186A3C3B0", Slot = "7")]
		public override void JKKGILIGMEE(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C2F0", Offset = "0x6A3A8F0", VA = "0x186A3C2F0", Slot = "8")]
		public override void GOPCFKFAPID(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C1E0", Offset = "0x6A3A7E0", VA = "0x186A3C1E0", Slot = "9")]
		public override void AFIGADGINFD(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C350", Offset = "0x6A3A950", VA = "0x186A3C350", Slot = "10")]
		public override void HBJPNBOOPNK(T LOPBHOFJFCN, KLILFFCJMEE NJMPEFLBAHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class CCMAELFOFKD<T> : DGAGGLCLPCH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4526E80", Offset = "0x4525480", VA = "0x184526E80")]
		public CCMAELFOFKD(PropertyInfo LLPAKFGNDOB, Type APCIGGMPPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x67213F0", Offset = "0x671F9F0", VA = "0x1867213F0", Slot = "5")]
		public override void NPNJAONMOHB(T LOPBHOFJFCN, ACLDEKFAJGB NFFBJCCKPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6721340", Offset = "0x671F940", VA = "0x186721340", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E79C30", Offset = "0x4E78230", VA = "0x184E79C30")]
		public JFPONCJHBHP(List<FICPEACKDPK<T>> LENNAEIKDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4E79AD0", Offset = "0x4E780D0", VA = "0x184E79AD0")]
		public void FOKICFNDJFF(T BOMDCGFKGKF, KLILFFCJMEE NFOCFJIIPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4E79B80", Offset = "0x4E78180", VA = "0x184E79B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E95670", Offset = "0x6E93C70", VA = "0x186E95670")]
	public CECIMCGPMEH(int FPENKDACOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3650550", Offset = "0x364EB50", VA = "0x183650550")]
	private JFPONCJHBHP<T> FBNMPNBIACB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3650490", Offset = "0x364EA90", VA = "0x183650490")]
	public void AMBIAOGNIIF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x36503F0", Offset = "0x364E9F0", VA = "0x1836503F0")]
	public bool AKDPGDCBDMI<T>(ACLDEKFAJGB HBMFONPEIJC, T FCPOJLOEIEO) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x36504C0", Offset = "0x364EAC0", VA = "0x1836504C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EA69A0", Offset = "0x6EA4FA0", VA = "0x186EA69A0")]
		get
		{
			return default(BEDOOOCGJIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int OPDMJMAFFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6EA64E0", Offset = "0x6EA4AE0", VA = "0x186EA64E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5C30", Offset = "0x6EA4230", VA = "0x186EA5C30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HMHJGICCAKJ KFOHGIONJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6A50", Offset = "0x6EA5050", VA = "0x186EA6A50")]
		get
		{
			return default(HMHJGICCAKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6EA67D0", Offset = "0x6EA4DD0", VA = "0x186EA67D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int PDKMNKMHDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6710", Offset = "0x6EA4D10", VA = "0x186EA6710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint HCKJCGHKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6EA69D0", Offset = "0x6EA4FD0", VA = "0x186EA69D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? HFOMCAOKHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5EB0", Offset = "0x6EA44B0", VA = "0x186EA5EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? LGHFINAJBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EA62E0", Offset = "0x6EA48E0", VA = "0x186EA62E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? KIHGFADODFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5EE0", Offset = "0x6EA44E0", VA = "0x186EA5EE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5F10", Offset = "0x6EA4510", VA = "0x186EA5F10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? BGFGJDMCKLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xDCB800", Offset = "0xDC9E00", VA = "0x180DCB800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6B90", Offset = "0x6EA5190", VA = "0x186EA6B90")]
	public MGLNOHNAOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6AE0", Offset = "0x6EA50E0", VA = "0x186EA6AE0")]
	internal MGLNOHNAOEM(byte[] ACDPPDBEDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5B10", Offset = "0x6EA4110", VA = "0x186EA5B10")]
	public static MGLNOHNAOEM AAAJLHGFOPO(byte[] ACDPPDBEDDM, DateTime PCOOEIKIJDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6510", Offset = "0x6EA4B10", VA = "0x186EA6510")]
	internal void FLJEDLENCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5CD0", Offset = "0x6EA42D0", VA = "0x186EA5CD0")]
	private void BLHKICOMAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6EA60E0", Offset = "0x6EA46E0", VA = "0x186EA60E0")]
	private DateTime? DOPHFEIIJBF(int LLPAIMMACAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6310", Offset = "0x6EA4910", VA = "0x186EA6310")]
	private void FJJCPDBCNNO(int LLPAIMMACAP, DateTime? OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6810", Offset = "0x6EA4E10", VA = "0x186EA6810")]
	private ulong JOCGMIPKDII(int LLPAIMMACAP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6EA68E0", Offset = "0x6EA4EE0", VA = "0x186EA68E0")]
	private void MILHLMLLDDM(int LLPAIMMACAP, ulong OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6740", Offset = "0x6EA4D40", VA = "0x186EA6740")]
	private uint GHMJLCIMINB(int LLPAIMMACAP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D60930", Offset = "0x6D5EF30", VA = "0x186D60930")]
	private static uint APHBGOANIHL(uint CEJAAIDLEPA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5C70", Offset = "0x6EA4270", VA = "0x186EA5C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E9DCB0", Offset = "0x6E9C2B0", VA = "0x186E9DCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DCC0", Offset = "0x6E9C2C0", VA = "0x186E9DCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E9F770", Offset = "0x6E9DD70", VA = "0x186E9F770", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int LELOHOILPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F660", Offset = "0x6E9DC60", VA = "0x186E9F660", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint PPGBPMLFGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F640", Offset = "0x6E9DC40", VA = "0x186E9F640", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily EPINNJMMOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x50BDFA0", Offset = "0x50BC5A0", VA = "0x1850BDFA0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E9FD90", Offset = "0x6E9E390", VA = "0x186E9FD90")]
	public GFKEDKKKNJN(AddressFamily PCHCGGAMAFI, CPNPKLEEMCO BGECOGBLKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F7D0", Offset = "0x6E9DDD0", VA = "0x186E9F7D0", Slot = "8")]
	public bool NGJEKGJIPEE(IPEndPoint KKNOGDEEABI, EEBGGGOLOIC AJJNOOFEAGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F790", Offset = "0x6E9DD90", VA = "0x186E9F790", Slot = "9")]
	public int MKEBHJOCNAD(byte[] IIGKBHIENFB, int LLPAIMMACAP, int CFNMLMNHCMF, IPEndPoint ONGBEKHKLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F680", Offset = "0x6E9DC80", VA = "0x186E9F680", Slot = "10")]
	public int JHBDFCKMJJE(byte[] IIGKBHIENFB, EndPoint DDMINIOLAFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F620", Offset = "0x6E9DC20", VA = "0x186E9F620", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EABAF0", Offset = "0x6EAA0F0", VA = "0x186EABAF0")]
	public NLGPHPHHFME(byte[] OAHKGLFKJGM, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6EABBB0", Offset = "0x6EAA1B0", VA = "0x186EABBB0")]
	public NLGPHPHHFME(Span<byte> OAHKGLFKJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA12D10", Offset = "0xA11310", VA = "0x180A12D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6EABAB0", Offset = "0x6EAA0B0", VA = "0x186EABAB0", Slot = "4")]
	public bool Equals(NLGPHPHHFME MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6EABA00", Offset = "0x6EAA000", VA = "0x186EABA00", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	internal void MDMFKNIKNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	internal void GHJCCOHKAHH(IPEndPoint ONGBEKHKLMA, Span<byte> APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x27BA670", Offset = "0x27B8C70", VA = "0x1827BA670")]
	public MBPLOODLPEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5020", Offset = "0x6EA3620", VA = "0x186EA5020")]
	public void EPHKCCCEEKN(IPEndPoint KKNOGDEEABI, byte[] OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6EA51D0", Offset = "0x6EA37D0", VA = "0x186EA51D0")]
	public void NPGPANJNBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5610", Offset = "0x6EA3C10", VA = "0x186EA5610", Slot = "4")]
	public override void PPKMIPFAKGE(IPEndPoint KKNOGDEEABI, byte[] APDBNIMCPID, int LLPAIMMACAP, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA52B0", Offset = "0x6EA38B0", VA = "0x186EA52B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EAC260", Offset = "0x6EAA860", VA = "0x186EAC260")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6EAC380", Offset = "0x6EAA980", VA = "0x186EAC380")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6EAC1C0", Offset = "0x6EAA7C0", VA = "0x186EAC1C0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6EABF90", Offset = "0x6EAA590", VA = "0x186EABF90")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EA0B50", Offset = "0x6E9F150", VA = "0x186EA0B50")]
	private void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1150", Offset = "0x6E9F750", VA = "0x186EA1150")]
	private uint OHAFHKMDDGO(uint IINHKHEMEHJ, int KIEHMFJADIM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6E943D0", Offset = "0x6E929D0", VA = "0x186E943D0")]
	private void GKMDCPLEKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6E941C0", Offset = "0x6E927C0", VA = "0x186E941C0")]
	private void FGDLINCEICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6E94130", Offset = "0x6E92730", VA = "0x186E94130")]
	private void ECPDFLBMGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6E94030", Offset = "0x6E92630", VA = "0x186E94030")]
	private void BKFLKGMKJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6EA10F0", Offset = "0x6E9F6F0", VA = "0x186EA10F0")]
	private void ODDCEAALNOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0CD0", Offset = "0x6E9F2D0", VA = "0x186EA0CD0")]
	private unsafe void NPNJIJAKJCO(byte* AEMKAEBHHHG, uint* OEHHKNIGGMI, uint* LPKBKPJLCHH, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6EA09F0", Offset = "0x6E9EFF0", VA = "0x186EA09F0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void KFLJIPNFFLD([NoAlias] byte* AEMKAEBHHHG, [NoAlias] byte* OEHHKNIGGMI, [NoAlias] byte* LPKBKPJLCHH, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0A70", Offset = "0x6E9F070", VA = "0x186EA0A70")]
	public static void KFLJIPNFFLD(Span<byte> AEMKAEBHHHG, Span<byte> OEHHKNIGGMI, Span<byte> LPKBKPJLCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0BD0", Offset = "0x6E9F1D0", VA = "0x186EA0BD0")]
	public static void NGLOFJCKIOM(Span<byte> AEMKAEBHHHG, Span<byte> OEHHKNIGGMI, Span<byte> LPKBKPJLCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1180", Offset = "0x6E9F780", VA = "0x186EA1180")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void OJDFAKBPPBJ([NoAlias] byte* AEMKAEBHHHG, [NoAlias] byte* OEHHKNIGGMI, [NoAlias] byte* LPKBKPJLCHH, int DDGBDMFPMAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC5D0", Offset = "0x6EAABD0", VA = "0x186EAC5D0")]
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
