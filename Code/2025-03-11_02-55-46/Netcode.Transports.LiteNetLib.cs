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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, MCHCCIKABFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum OFIHHPFOAEA
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
		private NetworkManager LNINNBINMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, AKAAEGECHFN> DDAOEAPKMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GDBBCJKLEFH DHKOIOIGKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] HNBFONCHMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OFIHHPFOAEA PDFNPCHCGLM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong MLEIOPPOBHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EEKKILMKDDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6906C80", Offset = "0x6906080", VA = "0x186906C80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6906210", Offset = "0x6905610", VA = "0x186906210")]
		public void RecRoom_SetEncryptionInfo(ulong JEMALKDBFKN, byte[] MCNLCGLNHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69061F0", Offset = "0x69055F0", VA = "0x1869061F0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69060C0", Offset = "0x69054C0", VA = "0x1869060C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6906B80", Offset = "0x6905F80", VA = "0x186906B80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6906330", Offset = "0x6905730", VA = "0x186906330", Slot = "6")]
		public override void Send(ulong FDEPJPODBIC, ArraySegment<byte> MJFOKKFMONL, NetworkDelivery NNBKLOKJNKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69061B0", Offset = "0x69055B0", VA = "0x1869061B0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong FDEPJPODBIC, [Out] ArraySegment<byte> IILBHIALBMC, [Out] float PPFPJOGMOHJ)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6906620", Offset = "0x6905A20", VA = "0x186906620", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6906AA0", Offset = "0x6905EA0", VA = "0x186906AA0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6905760", Offset = "0x6904B60", VA = "0x186905760", Slot = "10")]
		public override void DisconnectRemoteClient(ulong FDEPJPODBIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6905670", Offset = "0x6904A70", VA = "0x186905670", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6905870", Offset = "0x6904C70", VA = "0x186905870", Slot = "12")]
		public override ulong GetCurrentRtt(ulong FDEPJPODBIC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69065B0", Offset = "0x69059B0", VA = "0x1869065B0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6905A10", Offset = "0x6904E10", VA = "0x186905A10", Slot = "14")]
		public override void Initialize([Optional] NetworkManager LNINNBINMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6905CF0", Offset = "0x69050F0", VA = "0x186905CF0")]
		private EONDPOOLJHC MACALGANKGN(NetworkDelivery ANONBNLNHHL)
		{
			return default(EONDPOOLJHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6905DC0", Offset = "0x69051C0", VA = "0x186905DC0", Slot = "15")]
		private void NBNENHPNPED(AKAAEGECHFN FNEEBLECLCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6905BD0", Offset = "0x6904FD0", VA = "0x186905BD0", Slot = "16")]
		private void JBDDKJJDCDP(AKAAEGECHFN FNEEBLECLCI, OFCHJLFJBNA EHOFKGDHCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "17")]
		private void EMLLIEAJNED(IPEndPoint IADNFBHEAGL, SocketError HGCMMEHLNMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6905E80", Offset = "0x6905280", VA = "0x186905E80", Slot = "18")]
		private void NJGNLDEFBOC(AKAAEGECHFN FNEEBLECLCI, PBFABIHFBAF AENCLAHFBDP, byte LJACCMOMMHN, EONDPOOLJHC MBDEMDNBFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6905910", Offset = "0x6904D10", VA = "0x186905910")]
		private void IHCKMNKPFIM(int NBPEDBIONNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "19")]
		private void LMJMDMFFFHB(IPEndPoint BOOCHBMNIOG, PBFABIHFBAF AENCLAHFBDP, OFFMJCDEDPI HFBGBMKLDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "20")]
		private void FCLBAIBAKGE(AKAAEGECHFN FNEEBLECLCI, int OCNHNEKCBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6905C90", Offset = "0x6905090", VA = "0x186905C90", Slot = "21")]
		private void JGMNMJOMOOM(BFNCJDFJEHB NKKKCKHLGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6906090", Offset = "0x6905490", VA = "0x186906090")]
		private ulong NOPKCIAKBOM(AKAAEGECHFN FNEEBLECLCI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69059F0", Offset = "0x6904DF0", VA = "0x1869059F0")]
		private static int ILECCGDOOOM(float JJPFHPNOEHC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6906BA0", Offset = "0x6905FA0", VA = "0x186906BA0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class AJBDENEPDCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly AKAAEGECHFN ACILNFDFIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<KELBPPECJLA> KEFOMLIPDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int NKMJNEICFIJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68F08F0", Offset = "0x68EFCF0", VA = "0x1868F08F0")]
	protected AJBDENEPDCP(AKAAEGECHFN FNEEBLECLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68F0890", Offset = "0x68EFC90", VA = "0x1868F0890")]
	public void JKJMOLCMEKD(KELBPPECJLA ECAHOFJDANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68F07D0", Offset = "0x68EFBD0", VA = "0x1868F07D0")]
	protected void GMOHMAJILHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68F0850", Offset = "0x68EFC50", VA = "0x1868F0850")]
	public bool IKBCHACJGID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool GOJFDANFJNK();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool OKBOPOFBEIJ(KELBPPECJLA ECAHOFJDANA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum ANBKEKCBBKK
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
public class BFNCJDFJEHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GDBBCJKLEFH ECPJFLKCGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int GLEGHLHDDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal CBFKHAFDOBN OEHIOHIHKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint JJALLHDEHML;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal ANBKEKCBBKK BPBOPAKJOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98E180", Offset = "0x98D580", VA = "0x18098E180")]
		[CompilerGenerated]
		get
		{
			return default(ANBKEKCBBKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC4FCA0", Offset = "0xC4F0A0", VA = "0x180C4FCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68F4A10", Offset = "0x68F3E10", VA = "0x1868F4A10")]
	internal void CDKHCJPOOHI(CBFKHAFDOBN OFJHEGMOENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68F4A70", Offset = "0x68F3E70", VA = "0x1868F4A70")]
	private bool LEFPEKNOKIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68F4B00", Offset = "0x68F3F00", VA = "0x1868F4B00")]
	internal BFNCJDFJEHB(IPEndPoint BOOCHBMNIOG, CBFKHAFDOBN AEBMGLCIIEN, GDBBCJKLEFH PEPKMEKLMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68F4AA0", Offset = "0x68F3EA0", VA = "0x1868F4AA0")]
	public AKAAEGECHFN NKKKNHOIJLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OFFMJCDEDPI
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NBMFHBKMMGG
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
public struct OFCHJLFJBNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NBMFHBKMMGG OCMDOHLDOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError PEOKBIHADKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public PBFABIHFBAF PJJGPMGAOCJ;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MCHCCIKABFG
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGIIPEBJLAL(AKAAEGECHFN FNEEBLECLCI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBFEDNLBBAJ(AKAAEGECHFN FNEEBLECLCI, OFCHJLFJBNA EHOFKGDHCHD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBMHKFFBMOF(IPEndPoint IADNFBHEAGL, SocketError HGCMMEHLNMH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFNJDOHFMCC(AKAAEGECHFN FNEEBLECLCI, PBFABIHFBAF AENCLAHFBDP, byte LJACCMOMMHN, EONDPOOLJHC MBDEMDNBFLP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void INCKOJJBPHE(IPEndPoint BOOCHBMNIOG, PBFABIHFBAF AENCLAHFBDP, OFFMJCDEDPI HFBGBMKLDKC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEJMBBBEOGM(AKAAEGECHFN FNEEBLECLCI, int OCNHNEKCBAL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OIOMGAMDNII(BFNCJDFJEHB NKKKCKHLGCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PJOEOLHFFCN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMJABKOJHDI(AKAAEGECHFN FNEEBLECLCI, object IPLCJOBGMMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HPNPHBBOGKI
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJHOFJIDFJL(KAKHDFCNOMB ECAHOFJDANA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ANFHFKLAJMK
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICNAICAKHFN(AKAAEGECHFN FNEEBLECLCI, IPEndPoint JOMNFLGCKLB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class CBFKHAFDOBN
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int BJHCELOLIOD = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long CNIDIANHJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte BGNPIBPBIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] EDBEFHHMJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly FKHHLNFMBKN IDIBBHDGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int BFDNJEAFBIC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68F5070", Offset = "0x68F4470", VA = "0x1868F5070")]
	private CBFKHAFDOBN(long EOKCJNDPAEO, byte KBJJCPHMNLF, int DKAEPFAKBGE, byte[] FNIGIACGEOJ, FKHHLNFMBKN MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68F5010", Offset = "0x68F4410", VA = "0x1868F5010")]
	public static int MHDMDIKIJGB(KELBPPECJLA ECAHOFJDANA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68F4DF0", Offset = "0x68F41F0", VA = "0x1868F4DF0")]
	public static CBFKHAFDOBN DGLKDOCHMHG(KELBPPECJLA ECAHOFJDANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x68F4C10", Offset = "0x68F4010", VA = "0x1868F4C10")]
	public static KELBPPECJLA BJCDKBCFOBM(LIMMLOBFBKC GGJDBPGDMEF, SocketAddress CKPMPECEPPD, long DANIHNKJLEB, int DKAEPFAKBGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class KCJHOHKJCAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long CNIDIANHJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte BGNPIBPBIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int BFDNJEAFBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool NOGBIPJMEDF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x69030B0", Offset = "0x69024B0", VA = "0x1869030B0")]
	private KCJHOHKJCAJ(long EOKCJNDPAEO, byte KBJJCPHMNLF, int IFBPANDPHCJ, bool KOFHEFFFPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6902F60", Offset = "0x6902360", VA = "0x186902F60")]
	public static KCJHOHKJCAJ DGLKDOCHMHG(KELBPPECJLA ECAHOFJDANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6902E70", Offset = "0x6902270", VA = "0x186902E70")]
	public static KELBPPECJLA BJCDKBCFOBM(long DANIHNKJLEB, byte DHJMAMCFLKM, int CFEFBMGNDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6902D70", Offset = "0x6902170", VA = "0x186902D70")]
	public static KELBPPECJLA AIHGLIMCGJP(AKAAEGECHFN FNEEBLECLCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum DEBHPBNGNPB
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NJKCMBGDPBF
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHNKPNCIPAC(IPEndPoint MECHFIFNMHN, IPEndPoint BOOCHBMNIOG, string OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOMBJGOGJGL(IPEndPoint ALALIJJHEAG, DEBHPBNGNPB ANONBNLNHHL, string OCDOGNMJENC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class LKDCBBJFHBN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct INHPLADDKMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint FIMEDMOLMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint JJALLHDEHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string FIOEPLBHCNF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct PHHKDGHHKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint LDFIBEFKHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DEBHPBNGNPB ELLKCGJJEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string FIOEPLBHCNF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class KMNMDFILKEL
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint ENNMHFPIKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string FIOEPLBHCNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KMNMDFILKEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class PFOEHMGFCEI
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint ENNMHFPIKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint FBKMNCDABLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FIOEPLBHCNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PFOEHMGFCEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class GDMKDGDMOCI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FIOEPLBHCNF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BBGCMOBICFE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xC02DE0", Offset = "0xC021E0", VA = "0x180C02DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x970B00", Offset = "0x96FF00", VA = "0x180970B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GDMKDGDMOCI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GDBBCJKLEFH ADHECFPIIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<INHPLADDKMF> IGANDMENNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<PHHKDGHHKBN> NFNFHFMKOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FKHHLNFMBKN BNOJKBJJMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly LIMMLOBFBKC GOGFOCEHEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DENKONMECIE OBLODDCHCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NJKCMBGDPBF JNMCIEBOANB;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int ADANHKAJFOH = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool FILINDPJOLE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6905040", Offset = "0x6904440", VA = "0x186905040")]
	internal LKDCBBJFHBN(GDBBCJKLEFH EKGDICLADEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6904A40", Offset = "0x6903E40", VA = "0x186904A40")]
	internal void AJPKPFFALAF(IPEndPoint GDKMDAFGDLC, KELBPPECJLA ECAHOFJDANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x359D1D0", Offset = "0x359C5D0", VA = "0x18359D1D0")]
	private void LPJNLMJAAPM<T>(T ECAHOFJDANA, IPEndPoint GACPILKGIFM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6904D20", Offset = "0x6904120", VA = "0x186904D20")]
	private void EHNKPNCIPAC(KMNMDFILKEL HIGLCDMLMMO, IPEndPoint GDKMDAFGDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6904BC0", Offset = "0x6903FC0", VA = "0x186904BC0")]
	private void DKJDFCCFPMN(PFOEHMGFCEI HIGLCDMLMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6904EB0", Offset = "0x69042B0", VA = "0x186904EB0")]
	private void PAADDOEOKNB(GDMKDGDMOCI HIGLCDMLMMO, IPEndPoint GDKMDAFGDLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EONDPOOLJHC : byte
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
public enum KCAJGABADJO : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FFDIPJGIIEF
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] LDALAOCNDDK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int EBHOHCELGNL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int HCEAIGLFLAP;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IMBLEHOAPKF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68F5560", Offset = "0x68F4960", VA = "0x1868F5560")]
	public IMBLEHOAPKF(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DKHEEHCBOFC : IMBLEHOAPKF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x68F5560", Offset = "0x68F4960", VA = "0x1868F5560")]
	public DKHEEHCBOFC(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum JMGGBFGLEOG
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
public interface PKANDMDNHJK
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPNCDABAOHD(JMGGBFGLEOG IFGMNLMDLGE, string KDFEGOCHHNF, params object[] BKIADHLGJLK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class HFOHACCAPEL
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static PKANDMDNHJK KMAALDLGLNB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object PBFDPBHBKJI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68FECE0", Offset = "0x68FE0E0", VA = "0x1868FECE0")]
	private static void OPKCOPKKMFK(JMGGBFGLEOG KOCABAOIMMK, string KDFEGOCHHNF, params object[] BKIADHLGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x68FEC80", Offset = "0x68FE080", VA = "0x1868FEC80")]
	internal static void MFGIFAOJAJE(string KDFEGOCHHNF, params object[] BKIADHLGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x68FEBC0", Offset = "0x68FDFC0", VA = "0x1868FEBC0")]
	internal static void BMINDEMIKAI(string KDFEGOCHHNF, params object[] BKIADHLGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x68FEC20", Offset = "0x68FE020", VA = "0x1868FEC20")]
	internal static void GFOADEHJCOL(string KDFEGOCHHNF, params object[] BKIADHLGJLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum LIOPJFNHPAP
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PBFABIHFBAF : FKHHLNFMBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private KELBPPECJLA IIFNJOCLLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GDBBCJKLEFH FPLHJOPAKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly BKGMAJDIGBK LGCHCFDCEEB;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6907AB0", Offset = "0x6906EB0", VA = "0x186907AB0")]
	internal PBFABIHFBAF(GDBBCJKLEFH FDIJEKJEAKE, BKGMAJDIGBK ENFFEBBPLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6907A10", Offset = "0x6906E10", VA = "0x186907A10")]
	internal void JKLAPCLBKLO(KELBPPECJLA ECAHOFJDANA, int CKCAIOOMAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6907990", Offset = "0x6906D90", VA = "0x186907990")]
	internal void FKAPHLHDDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6907A80", Offset = "0x6906E80", VA = "0x186907A80")]
	public void KEGENEKCOLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class BKGMAJDIGBK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum AFLLIIGHODJ
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
	public BKGMAJDIGBK FCHLGGLFBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public AFLLIIGHODJ ELLKCGJJEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public AKAAEGECHFN ACILNFDFIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint JJALLHDEHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object BDNOHPGHBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int HLJKPDFLNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError BCCKFDGHCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NBMFHBKMMGG EKKBOLKFKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public BFNCJDFJEHB PEBKJLFJCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public EONDPOOLJHC DBFLOLHLBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte ECDNFFOJJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly PBFABIHFBAF KHFIKDPHDIM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68F4B70", Offset = "0x68F3F70", VA = "0x1868F4B70")]
	public BKGMAJDIGBK(GDBBCJKLEFH FDIJEKJEAKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GDBBCJKLEFH : IEnumerable<AKAAEGECHFN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class JJGGDFABEIF : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6901960", Offset = "0x6900D60", VA = "0x186901960", Slot = "4")]
		public bool Equals(IPEndPoint COMHOHNLIIN, IPEndPoint PJGBAACMKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6423920", Offset = "0x6422D20", VA = "0x186423920", Slot = "5")]
		public int GetHashCode(IPEndPoint NBAMGPFDMIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JJGGDFABEIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct KMFEKMKOLGB : IEnumerator<AKAAEGECHFN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly AKAAEGECHFN MEJCDDHJOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private AKAAEGECHFN FMHGAMMKBKC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AKAAEGECHFN ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xCA47E0", Offset = "0xCA3BE0", VA = "0x180CA47E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xCA47E0", Offset = "0xCA3BE0", VA = "0x180CA47E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1818130", Offset = "0x1817530", VA = "0x181818130")]
		public KMFEKMKOLGB(AKAAEGECHFN FEPAKEBFLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6903B60", Offset = "0x6902F60", VA = "0x186903B60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6903BB0", Offset = "0x6902FB0", VA = "0x186903BB0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread IGOELLGFMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool GAEEDPEJHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent BPFKCEIFGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<BKGMAJDIGBK> IFKKEMHJDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<BKGMAJDIGBK> IHGLPNLAOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private BKGMAJDIGBK KNNJADMLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MCHCCIKABFG BKFCOGNEGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly PJOEOLHFFCN LGMNFPLIPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly HPNPHBBOGKI EHDPKPJFOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ANFHFKLAJMK DMHPJADJPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, AKAAEGECHFN> LNLCGNPPPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, BFNCJDFJEHB> IIJJKOKFFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, DFDACAGJNBE> FDEOKJOEOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim JPBFFLJIKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AKAAEGECHFN PIEMGMJLHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int OMHHPOIIGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<AKAAEGECHFN> NEDCPJCJIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AKAAEGECHFN[] NLCLMADPMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly LMOMEJOBNAO GDPIOAODOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int LLLBDEBPIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> JNGNHKBBPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte MLPCKAMJNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object MBMCACKGFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool NPGNPJBMJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool AFNEDGNOMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int AJNMNAFOHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int ONMOBBKOOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int IMNFPFOGAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int IMPAEAAMBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool NLANPPCGFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool NEGDFMKGMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int OGHKLGDAMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HGMFAGFHFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int CGEGIIDJJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool FILINDPJOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool IKILIFABPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool FCPNHKJNLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool MEIHFNEJFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int CBEFILLCNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int JPBAEEMMGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool AOCFDFDJDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly GGAFODHEOBM DHHMBAHHBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool HNBKMMHNHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly LKDCBBJFHBN NBAPKIEBOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool GGIKPJNGMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public LIOPJFNHPAP GILFCKDJGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int NBNMHBFKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool NMNBAABAGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool BOANDELBEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool KIMJNFKEEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool NINMCKFBCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private KELBPPECJLA KHNFEFAKEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int BLAODHKFNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object FMJJKDLDCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private KELBPPECJLA EMBKLJDPDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int KBMBFIMJBLA;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int DHBELNKHMND = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int DLEKIHAOMDF = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private LCFIHAJJHNN JFPLFEFFILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private LCFIHAJJHNN JKGFHHEBDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread GNIFNFDCALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread AMIDNPECMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint KJGDKAHAELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint NKDKCNIBEGF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] ELJJAHDPKEF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] HJNBNDGLOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<LPDOCPFBBLF, IPEndPoint> HKCFPONDKGH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress MBDICFNDKAN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool COKPKEOOMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int HKJLIPIAHAC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EKLAEMJFOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x133EF20", Offset = "0x133E320", VA = "0x18133EF20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x133FD10", Offset = "0x133F110", VA = "0x18133FD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BMMIPOMAJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x212CF00", Offset = "0x212C300", VA = "0x18212CF00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x212CF60", Offset = "0x212C360", VA = "0x18212CF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte MAHGNJHJNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB77A60", Offset = "0xB76E60", VA = "0x180B77A60")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DCIINMJCLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68FD980", Offset = "0x68FCD80", VA = "0x1868FD980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short NEODCPKJLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x68FAB00", Offset = "0x68F9F00", VA = "0x1868FAB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68FCC50", Offset = "0x68FC050", VA = "0x1868FCC50")]
	public void NKNCOMECPHM(IPEndPoint IADNFBHEAGL, byte[] MCNLCGLNHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68F8C40", Offset = "0x68F8040", VA = "0x1868F8C40")]
	public void EAHHHJIGLCF(IPEndPoint IADNFBHEAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68F8BB0", Offset = "0x68F7FB0", VA = "0x1868F8BB0")]
	private bool DFJEMDBBEOG(IPEndPoint IADNFBHEAGL, [Out] AKAAEGECHFN FNEEBLECLCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68FABC0", Offset = "0x68F9FC0", VA = "0x1868FABC0")]
	private void IFDJKOMLHGB(AKAAEGECHFN FNEEBLECLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x68F7220", Offset = "0x68F6620", VA = "0x1868F7220")]
	private void ALCLJCFOIDB(AKAAEGECHFN FNEEBLECLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x68F6FB0", Offset = "0x68F63B0", VA = "0x1868F6FB0")]
	private void AJNCLFOCEJL(AKAAEGECHFN FNEEBLECLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68FDDC0", Offset = "0x68FD1C0", VA = "0x1868FDDC0")]
	public GDBBCJKLEFH(MCHCCIKABFG PEPKMEKLMFB, [Optional] LMOMEJOBNAO NEEHFOJCBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x68FCA50", Offset = "0x68FBE50", VA = "0x1868FCA50")]
	internal void MHHPLPFCDGJ(AKAAEGECHFN HDLPHOKLCEC, int OCNHNEKCBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x68F86B0", Offset = "0x68F7AB0", VA = "0x1868F86B0")]
	internal void BNMDACHPNCA(AKAAEGECHFN HDLPHOKLCEC, object IPLCJOBGMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x68FAAC0", Offset = "0x68F9EC0", VA = "0x1868FAAC0")]
	internal void HNOOFEHBLHI(AKAAEGECHFN FNEEBLECLCI, NBMFHBKMMGG BBAJBLJIPLG, SocketError OICBFLBBENM, KELBPPECJLA CDDCIHICHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x68F9810", Offset = "0x68F8C10", VA = "0x1868F9810")]
	private void FAOBIGOJMEI(AKAAEGECHFN FNEEBLECLCI, NBMFHBKMMGG BBAJBLJIPLG, SocketError OICBFLBBENM, bool JLJMBNIAGMB, byte[] MJFOKKFMONL, int BGLOMHIAAIH, int LOHPPDCIAAL, KELBPPECJLA CDDCIHICHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68FB5A0", Offset = "0x68FA9A0", VA = "0x1868FB5A0")]
	private void JIMLIEOIIKF(BKGMAJDIGBK.AFLLIIGHODJ ANONBNLNHHL, [Optional] AKAAEGECHFN FNEEBLECLCI, [Optional] IPEndPoint BOOCHBMNIOG, SocketError AOFMJKALGDK = SocketError.Success, int OCNHNEKCBAL = 0, NBMFHBKMMGG GDDEMIEDJDI = NBMFHBKMMGG.ConnectionFailed, [Optional] BFNCJDFJEHB PMPNALGGEOM, EONDPOOLJHC MBDEMDNBFLP = EONDPOOLJHC.Unreliable, byte LJACCMOMMHN = 0, [Optional] KELBPPECJLA GMALDFPCMJG, [Optional] object IPLCJOBGMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68FB980", Offset = "0x68FAD80", VA = "0x1868FB980")]
	private void JOKOAJDFCGE(BKGMAJDIGBK ENFFEBBPLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x68FC120", Offset = "0x68FB520", VA = "0x1868FC120")]
	internal void KFOCBAEKMPM(BKGMAJDIGBK ENFFEBBPLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x68F9F70", Offset = "0x68F9370", VA = "0x1868F9F70")]
	private void FMDFMPEBCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x68FC730", Offset = "0x68FBB30", VA = "0x1868FC730")]
	private void LOMNJCFHLHC(int BPDBIIAGDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68F6990", Offset = "0x68F5D90", VA = "0x1868F6990")]
	internal AKAAEGECHFN ABMOHPBCLNN(BFNCJDFJEHB NKKKCKHLGCJ, byte[] FIOCAIIAFDL, int BGLOMHIAAIH, int EHCAJIFPCLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68F8630", Offset = "0x68F7A30", VA = "0x1868F8630")]
	private int BBIHJOHFNJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x68F8700", Offset = "0x68F7B00", VA = "0x1868F8700")]
	private void DCAPIAPFGAL(IPEndPoint BOOCHBMNIOG, AKAAEGECHFN OIKLBJKMNAN, CBFKHAFDOBN NNELAMBHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68F7270", Offset = "0x68F6670", VA = "0x1868F7270")]
	private void BAEEEEJBJBJ(KELBPPECJLA ECAHOFJDANA, IPEndPoint BOOCHBMNIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68FD0D0", Offset = "0x68FC4D0", VA = "0x1868FD0D0")]
	internal void OGMBCONJBIA(KELBPPECJLA ECAHOFJDANA, EONDPOOLJHC LJPBPAJBILD, byte LJACCMOMMHN, int CKCAIOOMAJI, AKAAEGECHFN HDLPHOKLCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68F8FD0", Offset = "0x68F83D0", VA = "0x1868F8FD0")]
	public bool EDANEBCOOOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x68F97F0", Offset = "0x68F8BF0", VA = "0x1868F97F0")]
	public bool EDANEBCOOOB(IPAddress KHHANMBCGIG, IPAddress NAPGFINMAAG, int NFLKFIGLIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x68F8F50", Offset = "0x68F8350", VA = "0x1868F8F50")]
	public bool EDANEBCOOOB(int NFLKFIGLIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x68FCAA0", Offset = "0x68FBEA0", VA = "0x1868FCAA0")]
	public void MIKEMHPCBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x68FAFB0", Offset = "0x68FA3B0", VA = "0x1868FAFB0")]
	public AKAAEGECHFN JAHPKNFPHLE(string LABPDJANKHN, int NFLKFIGLIHM, string MCNLCGLNHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x68FB090", Offset = "0x68FA490", VA = "0x1868FB090")]
	public AKAAEGECHFN JAHPKNFPHLE(string LABPDJANKHN, int NFLKFIGLIHM, LIMMLOBFBKC LMEAGEAHAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x68FB170", Offset = "0x68FA570", VA = "0x1868FB170")]
	public AKAAEGECHFN JAHPKNFPHLE(IPEndPoint GACPILKGIFM, LIMMLOBFBKC LMEAGEAHAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x68FD3B0", Offset = "0x68FC7B0", VA = "0x1868FD3B0")]
	public void OLLPJMBNIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x68FD3C0", Offset = "0x68FC7C0", VA = "0x1868FD3C0")]
	public void OLLPJMBNIFG(bool BIHAIIAOIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x68FD710", Offset = "0x68FCB10", VA = "0x1868FD710")]
	public void PMNHFCEKADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68FD7C0", Offset = "0x68FCBC0", VA = "0x1868FD7C0")]
	public void PMNHFCEKADI(byte[] MJFOKKFMONL, int BGLOMHIAAIH, int LOHPPDCIAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68F9C60", Offset = "0x68F9060", VA = "0x1868F9C60")]
	public void FAOBIGOJMEI(AKAAEGECHFN FNEEBLECLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x68F9C20", Offset = "0x68F9020", VA = "0x1868F9C20")]
	public void FAOBIGOJMEI(AKAAEGECHFN FNEEBLECLCI, byte[] MJFOKKFMONL, int BGLOMHIAAIH, int LOHPPDCIAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x68FDBE0", Offset = "0x68FCFE0", VA = "0x1868FDBE0", Slot = "4")]
	private IEnumerator<AKAAEGECHFN> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x68FDC70", Offset = "0x68FD070", VA = "0x1868FDC70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x68F8D90", Offset = "0x68F8190", VA = "0x1868F8D90")]
	private KELBPPECJLA ECLONDGEBAP(AHCPAAIGPKI MFGHKKFEKII, int NBPEDBIONNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68F8E70", Offset = "0x68F8270", VA = "0x1868F8E70")]
	private KELBPPECJLA ECLONDGEBAP(AHCPAAIGPKI MFGHKKFEKII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x68FD9A0", Offset = "0x68FCDA0", VA = "0x1868FD9A0")]
	internal KELBPPECJLA POJBLPOEGJI(int NBPEDBIONNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x68FCE70", Offset = "0x68FC270", VA = "0x1868FCE70")]
	internal void OBFIAKNEEAE(KELBPPECJLA ECAHOFJDANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x68FDD00", Offset = "0x68FD100", VA = "0x1868FDD00")]
	static GDBBCJKLEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x133EF20", Offset = "0x133E320", VA = "0x18133EF20")]
	private bool IAOPLPEJDKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x68FAEA0", Offset = "0x68FA2A0", VA = "0x1868FAEA0")]
	private void ILIIIAJIEBE(IPEndPoint CJODJGBCBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x68FD880", Offset = "0x68FCC80", VA = "0x1868FD880")]
	private void PNFECBEIHDK(IPEndPoint CJODJGBCBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x68FA910", Offset = "0x68F9D10", VA = "0x1868FA910")]
	private bool HKLPBDGBAPI(SocketException BOKONMFPKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x68F9CA0", Offset = "0x68F90A0", VA = "0x1868F9CA0")]
	private void FINCPBIHJJG(LCFIHAJJHNN EKGDICLADEC, EndPoint IEOGDMLLKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x68FC3A0", Offset = "0x68FB7A0", VA = "0x1868FC3A0")]
	private void LCANAAMLFPM(object MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x68F9040", Offset = "0x68F8440", VA = "0x1868F9040")]
	public bool EDANEBCOOOB(IPAddress KHHANMBCGIG, IPAddress NAPGFINMAAG, int NFLKFIGLIHM, bool DDBJAEBBKFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x68FB540", Offset = "0x68FA940", VA = "0x1868FB540")]
	internal int JHGKIFDNHND(KELBPPECJLA ECAHOFJDANA, IPEndPoint BOOCHBMNIOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x68FA8D0", Offset = "0x68F9CD0", VA = "0x1868FA8D0")]
	internal int FOGGFKFEIDO(KELBPPECJLA ECAHOFJDANA, IPEndPoint BOOCHBMNIOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x68FA2B0", Offset = "0x68F96B0", VA = "0x1868FA2B0")]
	internal int FOGGFKFEIDO(byte[] LPIFIOEEOGF, int BGLOMHIAAIH, int EHCAJIFPCLL, IPEndPoint BOOCHBMNIOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x68FC230", Offset = "0x68FB630", VA = "0x1868FC230")]
	internal void KPNDNBLOPOI(bool GADMECGKFAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum AHCPAAIGPKI : byte
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
internal sealed class KELBPPECJLA
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int ODEINHJEIKF;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] KGLODEJMDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] FCMBABNFLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int KHIDBOMGENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object BDNOHPGHBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public KELBPPECJLA FCHLGGLFBHJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AHCPAAIGPKI IKHHAMAKPAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6903270", Offset = "0x6902670", VA = "0x186903270")]
		get
		{
			return default(AHCPAAIGPKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x69035D0", Offset = "0x69029D0", VA = "0x1869035D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte BGNPIBPBIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6903540", Offset = "0x6902940", VA = "0x186903540")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6903130", Offset = "0x6902530", VA = "0x186903130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort NGKMIIFIDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6903610", Offset = "0x6902A10", VA = "0x186903610")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6903200", Offset = "0x6902600", VA = "0x186903200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JKGFKKKOFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6903670", Offset = "0x6902A70", VA = "0x186903670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte JHAOIEJFOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6903240", Offset = "0x6902640", VA = "0x186903240")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6903100", Offset = "0x6902500", VA = "0x186903100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort FMMHIHNMLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6903170", Offset = "0x6902570", VA = "0x186903170")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69036A0", Offset = "0x6902AA0", VA = "0x1869036A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort ABBPLCHMOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6903570", Offset = "0x6902970", VA = "0x186903570")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x69036E0", Offset = "0x6902AE0", VA = "0x1869036E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JGJPKAPDDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x69034E0", Offset = "0x69028E0", VA = "0x1869034E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69032A0", Offset = "0x69026A0", VA = "0x1869032A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6903720", Offset = "0x6902B20", VA = "0x186903720")]
	static KELBPPECJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69031D0", Offset = "0x69025D0", VA = "0x1869031D0")]
	public void DGFOAIHNGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x69039E0", Offset = "0x6902DE0", VA = "0x1869039E0")]
	public KELBPPECJLA(int NBPEDBIONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6903A50", Offset = "0x6902E50", VA = "0x186903A50")]
	public KELBPPECJLA(AHCPAAIGPKI MFGHKKFEKII, int NBPEDBIONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6903370", Offset = "0x6902770", VA = "0x186903370")]
	public static int IDBDMOMOFBC(AHCPAAIGPKI MFGHKKFEKII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x69032E0", Offset = "0x69026E0", VA = "0x1869032E0")]
	public int IDBDMOMOFBC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x69033E0", Offset = "0x69027E0", VA = "0x1869033E0")]
	public bool JCPLINIPPFD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum PJOGOAFKCOI : byte
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
internal enum HMPGCNODICA
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
internal enum PLGOCAJAJAP
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum HMPMINBHNJP
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class AKAAEGECHFN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class INOKGAHMMPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public KELBPPECJLA[] IJAJJHOBOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int NOPGNBPJPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int PFKPKIKKEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte JHAOIEJFOEG;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public INOKGAHMMPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void GIMHOGCJPKK(ulong GKBNPKBCJPM, int NEOKNBBIDEP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int GNKNKNGJBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int ECONNOGOBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int DLKOOPCIKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double CJMGOOCBHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int OFHKMGKNLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int PBDFDDOLHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int PGOIKOJLBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch KIPAOFCGEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int MCOLKCIAJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long ACMCPBCBFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object DFHKLNIPJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal AKAAEGECHFN OCGIKDAKEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal AKAAEGECHFN LAFAKAFOKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<KELBPPECJLA> GHCFJDPKAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<AJBDENEPDCP> ACDBPKNIFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly AJBDENEPDCP[] GCDHHFOBMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int NENHLAONICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int LBEGFJGHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool CJHMNABJNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int DDHKGPENCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int OCLJJMKILKK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int EGANENOPOJF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int PFOJIICFDGL = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object MJPBCDKHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int INLLAPFBMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, INOKGAHMMPO> EBFHFKJGCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> GAPPPEJHHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly KELBPPECJLA GDEJHMOHCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int DIEKPPHFOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int KOECEDPINBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint GKFMDHKNOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int EGIMEKFCDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int PJLJFGOAGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long GBHIGNNMJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte FKLKOMABJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private PJOGOAFKCOI IIMCBJDEKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private KELBPPECJLA AJFEPAIIDEM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int BKGLILDHGPB = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int PCCMPPMNNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly KELBPPECJLA BLBMLAABJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly KELBPPECJLA EIECGBBNGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly KELBPPECJLA KEPCKKNGGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly KELBPPECJLA LDEDNKEAJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private KCAJGABADJO KFOEJAECHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly GDBBCJKLEFH JJDEDMPDBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int MHHGANKHAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object FEIEDJDADNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly GGAFODHEOBM DHHMBAHHBGA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte OAKOKPALKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA98750", Offset = "0xA97B50", VA = "0x180A98750")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x68F0990", Offset = "0x68EFD90", VA = "0x1868F0990")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint PAPABNPGLEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xBC63B0", Offset = "0xBC57B0", VA = "0x180BC63B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PJOGOAFKCOI KFKIIJAGNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA98770", Offset = "0xA97B70", VA = "0x180A98770")]
		get
		{
			return default(PJOGOAFKCOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long OGNMMDPKEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9744F0", Offset = "0x9738F0", VA = "0x1809744F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MNJKAILBOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x13B3230", Offset = "0x13B2630", VA = "0x1813B3230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C6FB20", Offset = "0x1C6EF20", VA = "0x181C6FB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DIKKIBHJDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x68F1720", Offset = "0x68F0B20", VA = "0x1868F1720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EJOBBHPEJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x975090", Offset = "0x974490", VA = "0x180975090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double LGGGLJBFIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x49F8D00", Offset = "0x49F8100", VA = "0x1849F8D00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event GIMHOGCJPKK BLGJGNJGMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x68F3310", Offset = "0x68F2710", VA = "0x1868F3310")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68F3A80", Offset = "0x68F2E80", VA = "0x1868F3A80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x68F4250", Offset = "0x68F3650", VA = "0x1868F4250")]
	internal AKAAEGECHFN(GDBBCJKLEFH GAIDDKLDGMP, IPEndPoint BOOCHBMNIOG, int NNKBGKICBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x68F4230", Offset = "0x68F3630", VA = "0x1868F4230")]
	internal void PFIJNMHAEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x68F22B0", Offset = "0x68F16B0", VA = "0x1868F22B0")]
	internal void KHFHGOMKFEC(IPEndPoint MJDDAENJGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x68F3280", Offset = "0x68F2680", VA = "0x1868F3280")]
	internal void NMNBNBIEHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x68F2E20", Offset = "0x68F2220", VA = "0x1868F2E20")]
	private void NLMNMCGIKIN(int GCMLFJBCCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68F41F0", Offset = "0x68F35F0", VA = "0x1868F41F0")]
	private void PFDALABNMOK(int FBLADODHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68F2B90", Offset = "0x68F1F90", VA = "0x1868F2B90")]
	private AJBDENEPDCP MOHDDCKCHBJ(byte HHHJLAPJJLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x68F4880", Offset = "0x68F3C80", VA = "0x1868F4880")]
	internal AKAAEGECHFN(GDBBCJKLEFH GAIDDKLDGMP, IPEndPoint BOOCHBMNIOG, int NNKBGKICBEC, byte DHJMAMCFLKM, LIMMLOBFBKC GGJDBPGDMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68F46A0", Offset = "0x68F3AA0", VA = "0x1868F46A0")]
	internal AKAAEGECHFN(GDBBCJKLEFH GAIDDKLDGMP, BFNCJDFJEHB NKKKCKHLGCJ, int NNKBGKICBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x68F2060", Offset = "0x68F1460", VA = "0x1868F2060")]
	internal void IFGAPIKDCDH(CBFKHAFDOBN JOJDEODFCBF, byte[] MJFOKKFMONL, int BGLOMHIAAIH, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68F1F90", Offset = "0x68F1390", VA = "0x1868F1F90")]
	internal bool HBHLMIBFBGP(KCJHOHKJCAJ ECAHOFJDANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68F2340", Offset = "0x68F1740", VA = "0x1868F2340")]
	public void LPJNLMJAAPM(byte[] MJFOKKFMONL, int BGLOMHIAAIH, int EHCAJIFPCLL, EONDPOOLJHC OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68F2630", Offset = "0x68F1A30", VA = "0x1868F2630")]
	private void MIGPDCFOOCN(byte[] MJFOKKFMONL, int BGLOMHIAAIH, int EHCAJIFPCLL, byte LJACCMOMMHN, EONDPOOLJHC MBDEMDNBFLP, object IPLCJOBGMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x68F2010", Offset = "0x68F1410", VA = "0x1868F2010")]
	public void HMKDLEAGODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68F2D40", Offset = "0x68F2140", VA = "0x1868F2D40")]
	internal PLGOCAJAJAP NCEBOHADKDE(KELBPPECJLA ECAHOFJDANA)
	{
		return default(PLGOCAJAJAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68F22E0", Offset = "0x68F16E0", VA = "0x1868F22E0")]
	internal void LMGNHGNCNFJ(AJBDENEPDCP CPNIDACNAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68F1C80", Offset = "0x68F1080", VA = "0x1868F1C80")]
	internal HMPMINBHNJP GPHPKALMMCP(byte[] MJFOKKFMONL, int BGLOMHIAAIH, int EHCAJIFPCLL, bool JLJMBNIAGMB)
	{
		return default(HMPMINBHNJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68F0D50", Offset = "0x68F0150", VA = "0x1868F0D50")]
	private void DENEECEPNNO(int PGJIHPGNPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68F0D90", Offset = "0x68F0190", VA = "0x1868F0D90")]
	internal void DIBFACOOHLG(EONDPOOLJHC LJPBPAJBILD, KELBPPECJLA FEPAKEBFLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x68F1730", Offset = "0x68F0B30", VA = "0x1868F1730")]
	private void EKIFCFAHBCF(KELBPPECJLA ECAHOFJDANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x68F2EF0", Offset = "0x68F22F0", VA = "0x1868F2EF0")]
	private void NMLPGMKBJBL(int JHAIOFABKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68F0B90", Offset = "0x68EFF90", VA = "0x1868F0B90")]
	internal HMPGCNODICA DCAPIAPFGAL(CBFKHAFDOBN NNELAMBHEOP)
	{
		return default(HMPGCNODICA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x68F33C0", Offset = "0x68F27C0", VA = "0x1868F33C0")]
	internal void OKBOPOFBEIJ(KELBPPECJLA ECAHOFJDANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x68F0A40", Offset = "0x68EFE40", VA = "0x1868F0A40")]
	private void DAJNIPGJALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x68F20B0", Offset = "0x68F14B0", VA = "0x1868F20B0")]
	internal void ILMCIMFLIGK(KELBPPECJLA ECAHOFJDANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x68F3B30", Offset = "0x68F2F30", VA = "0x1868F3B30")]
	internal void PCKKFECIKBA(int JHAIOFABKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68F2370", Offset = "0x68F1770", VA = "0x1868F2370")]
	internal void MEIKOMABBEM(KELBPPECJLA ECAHOFJDANA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class GGAFODHEOBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long PIFPPLGHFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long JLFMJICFMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long DOGEBEECKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long LDBEFELDECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long HBNCMDLJMPC;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long GFBAOGILHJK;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long GIADFJMLKMH;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long LJNINJDOGPL;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long DFLNJAKCGMM;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long HAPHDEPADDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long ALINCGJDIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long BNFIBCJHAOA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long JIOGOLJAGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x68FE720", Offset = "0x68FDB20", VA = "0x1868FE720")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long OHNOELCGOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x68FE5F0", Offset = "0x68FD9F0", VA = "0x1868FE5F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long KBBEBEHKJLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x68FE810", Offset = "0x68FDC10", VA = "0x1868FE810")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long MPKMCIPNLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x68FE410", Offset = "0x68FD810", VA = "0x1868FE410")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long OGDBMOJDHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x68FE6A0", Offset = "0x68FDAA0", VA = "0x1868FE6A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long HIHBCAPFFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x68FE790", Offset = "0x68FDB90", VA = "0x1868FE790")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long BAJJEGJAPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x68FE4D0", Offset = "0x68FD8D0", VA = "0x1868FE4D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long KEHOKJOHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x68FE510", Offset = "0x68FD910", VA = "0x1868FE510")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private KCAJGABADJO GCLGJKPDKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x68FE7A0", Offset = "0x68FDBA0", VA = "0x1868FE7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double GMFOEBKLEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x68FE7B0", Offset = "0x68FDBB0", VA = "0x1868FE7B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x68FE600", Offset = "0x68FDA00", VA = "0x1868FE600")]
	public void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x68FE640", Offset = "0x68FDA40", VA = "0x1868FE640")]
	public void HPLJGNIKNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x68FE420", Offset = "0x68FD820", VA = "0x1868FE420")]
	public void BONLDJKBFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x68FE730", Offset = "0x68FDB30", VA = "0x1868FE730")]
	public void NIIBNJAMJKL(long JFAOKGALKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x68FE470", Offset = "0x68FD870", VA = "0x1868FE470")]
	public void CFNHEJEEFOL(long KJIGHOJHKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x68FE820", Offset = "0x68FDC20", VA = "0x1868FE820")]
	public void PLOIBAMFGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x68FE6B0", Offset = "0x68FDAB0", VA = "0x1868FE6B0")]
	public void KAKLMFODPIK(long FLFCCPMFLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x68FE880", Offset = "0x68FDC80", VA = "0x1868FE880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x68FE550", Offset = "0x68FD950", VA = "0x1868FE550")]
	public void FINPGMFOLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public GGAFODHEOBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FJGFOIEAGEF
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> ELNHIOEILHP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x68F57F0", Offset = "0x68F4BF0", VA = "0x1868F57F0")]
	public static IPEndPoint LNBCCPAMJAD(string KEHDGKCJHBD, int NFLKFIGLIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x68F5AD0", Offset = "0x68F4ED0", VA = "0x1868F5AD0")]
	public static IPAddress PNBIHDOJDBI(string KEHDGKCJHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x68F5A40", Offset = "0x68F4E40", VA = "0x1868F5A40")]
	public static IPAddress PNBIHDOJDBI(string KEHDGKCJHBD, AddressFamily BMGKIOCHJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x68F57C0", Offset = "0x68F4BC0", VA = "0x1868F57C0")]
	internal static int DABOKBFFMBL(int FNAGMDNMPGI, int DJGKHMLKNDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3481BB0", Offset = "0x3480FB0", VA = "0x183481BB0")]
	internal static T[] GCNKOMLCDMD<T>(int LOHPPDCIAAL) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HIIGJBKEMBH : AJBDENEPDCP
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct EABEEEFPONK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private KELBPPECJLA IIFNJOCLLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long FFOGNFBDPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool HPFGMJIHIOP;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x68F5650", Offset = "0x68F4A50", VA = "0x1868F5650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x68F55C0", Offset = "0x68F49C0", VA = "0x1868F55C0")]
		public void MEKFCHHLHOB(KELBPPECJLA ECAHOFJDANA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x68F55E0", Offset = "0x68F49E0", VA = "0x1868F55E0")]
		public bool OJLLJBPIIAG(long EOIMAGDAGAD, AKAAEGECHFN FNEEBLECLCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x68F5570", Offset = "0x68F4970", VA = "0x1868F5570")]
		public bool JIMFDDOIBMF(AKAAEGECHFN FNEEBLECLCI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly KELBPPECJLA OCDCPDLIOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly EABEEEFPONK[] LMJGGIHDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly KELBPPECJLA[] NIJHDAEAJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] JCKMLICGCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int IEFHINELGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int EGDLDJDAJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int LJOLDJACAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int CJAPNBPJODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool CLIGNGIAHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly EONDPOOLJHC ILPCEKFOFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool MHHBODEDDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int GEFAPDFDKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte KMOCJPOIJBP;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x68FFEB0", Offset = "0x68FF2B0", VA = "0x1868FFEB0")]
	public HIIGJBKEMBH(AKAAEGECHFN FNEEBLECLCI, bool KIIHNCBIEFF, byte NNKBGKICBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x68FF490", Offset = "0x68FE890", VA = "0x1868FF490")]
	private void GONAJJBOHLE(KELBPPECJLA ECAHOFJDANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x68FEFC0", Offset = "0x68FE3C0", VA = "0x1868FEFC0", Slot = "4")]
	protected override bool GOJFDANFJNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x68FF850", Offset = "0x68FEC50", VA = "0x1868FF850", Slot = "5")]
	public override bool OKBOPOFBEIJ(KELBPPECJLA ECAHOFJDANA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class IBKMFLAFEOG : AJBDENEPDCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int CGCEKPEPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort EGDLDJDAJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool KOEJFEKCABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private KELBPPECJLA NDAEHLLALBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly KELBPPECJLA JNDNLKNOBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool ABDCIOPBNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte KMOCJPOIJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long JDFKHJOJJIG;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6900820", Offset = "0x68FFC20", VA = "0x186900820")]
	public IBKMFLAFEOG(AKAAEGECHFN FNEEBLECLCI, bool DIOEBPEGBFM, byte NNKBGKICBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6900080", Offset = "0x68FF480", VA = "0x186900080", Slot = "4")]
	protected override bool GOJFDANFJNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6900540", Offset = "0x68FF940", VA = "0x186900540", Slot = "5")]
	public override bool OKBOPOFBEIJ(KELBPPECJLA ECAHOFJDANA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OMJOEBIAPOO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct JNDAHFHLFBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong GDFOHBICJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double DODILODBMOM;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct CGNLGDJFMJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int HPNPMFIAHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float AMKAFDNJJBN;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x68F06E0", Offset = "0x68EFAE0", VA = "0x1868F06E0")]
	private static void CHJHNDNIPCB(byte[] LMNIHILKKEL, int FGCNBOMLCIC, ulong MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6907850", Offset = "0x6906C50", VA = "0x186907850")]
	private static void CHJHNDNIPCB(byte[] LMNIHILKKEL, int FGCNBOMLCIC, int MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69078C0", Offset = "0x6906CC0", VA = "0x1869078C0")]
	public static void CHJHNDNIPCB(byte[] LMNIHILKKEL, int FGCNBOMLCIC, short MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6907830", Offset = "0x6906C30", VA = "0x186907830")]
	public static void AADDEKIIJBP(byte[] KPLABGDDBEL, int PFCFNJKDJBK, double PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6907910", Offset = "0x6906D10", VA = "0x186907910")]
	public static void AADDEKIIJBP(byte[] KPLABGDDBEL, int PFCFNJKDJBK, float PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x69078C0", Offset = "0x6906CC0", VA = "0x1869078C0")]
	public static void AADDEKIIJBP(byte[] KPLABGDDBEL, int PFCFNJKDJBK, short PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69078C0", Offset = "0x6906CC0", VA = "0x1869078C0")]
	public static void AADDEKIIJBP(byte[] KPLABGDDBEL, int PFCFNJKDJBK, ushort PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6907850", Offset = "0x6906C50", VA = "0x186907850")]
	public static void AADDEKIIJBP(byte[] KPLABGDDBEL, int PFCFNJKDJBK, int PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6907850", Offset = "0x6906C50", VA = "0x186907850")]
	public static void AADDEKIIJBP(byte[] KPLABGDDBEL, int PFCFNJKDJBK, uint PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6907900", Offset = "0x6906D00", VA = "0x186907900")]
	public static void AADDEKIIJBP(byte[] KPLABGDDBEL, int PFCFNJKDJBK, long PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6907900", Offset = "0x6906D00", VA = "0x186907900")]
	public static void AADDEKIIJBP(byte[] KPLABGDDBEL, int PFCFNJKDJBK, ulong PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FKHHLNFMBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] MLAAAKIINKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int COHJMOHAFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int LNNAPBPAHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int HKLEFDNMHGF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] FCMBABNFLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FIHKFJLOMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KCBLIGPMPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x68F5EA0", Offset = "0x68F52A0", VA = "0x1868F5EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FJJDJDFIPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x24BED50", Offset = "0x24BE150", VA = "0x1824BED50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int HNPLEGOHHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x68F6050", Offset = "0x68F5450", VA = "0x1868F6050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x68F6240", Offset = "0x68F5640", VA = "0x1868F6240")]
	public void JKLAPCLBKLO(byte[] IPKJFPCBFNH, int FGCNBOMLCIC, int OEHDNNBNHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public FKHHLNFMBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68F6930", Offset = "0x68F5D30", VA = "0x1868F6930")]
	public FKHHLNFMBKN(byte[] IPKJFPCBFNH, int FGCNBOMLCIC, int OEHDNNBNHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x68F6060", Offset = "0x68F5460", VA = "0x1868F6060")]
	public IPEndPoint IBLGIIOPBOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x68F5FD0", Offset = "0x68F53D0", VA = "0x1868F5FD0")]
	public byte FIIIJFKELNA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x68F5FD0", Offset = "0x68F53D0", VA = "0x1868F5FD0")]
	public sbyte KPECGHDKPJH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3482930", Offset = "0x3481D30", VA = "0x183482930")]
	public T[] JIJNNIHMPOC<T>(ushort NBPEDBIONNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x68F5DA0", Offset = "0x68F51A0", VA = "0x1868F5DA0")]
	public bool[] AEIIGMHBOID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x68F6170", Offset = "0x68F5570", VA = "0x1868F6170")]
	public ushort[] IPKPCOGJMDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68F6670", Offset = "0x68F5A70", VA = "0x1868F6670")]
	public short[] KKGHHFFLNIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x68F5DE0", Offset = "0x68F51E0", VA = "0x1868F5DE0")]
	public int[] AMBMIJPNMEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x68F68F0", Offset = "0x68F5CF0", VA = "0x1868F68F0")]
	public uint[] PNKJMDBLHBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x68F6760", Offset = "0x68F5B60", VA = "0x1868F6760")]
	public float[] MHAJIJMCDII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x68F6720", Offset = "0x68F5B20", VA = "0x1868F6720")]
	public double[] KOOKCCCFJAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x68F6010", Offset = "0x68F5410", VA = "0x1868F6010")]
	public long[] GFGEGHNKKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x68F5F20", Offset = "0x68F5320", VA = "0x1868F5F20")]
	public ulong[] EKDJPDLKCBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x68F6520", Offset = "0x68F5920", VA = "0x1868F6520")]
	public string[] KJGLHFFEPIA(int AHPFBNNLKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x68F5E20", Offset = "0x68F5220", VA = "0x1868F5E20")]
	public bool BHAMJBBMGDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x68F5D30", Offset = "0x68F5130", VA = "0x1868F5D30")]
	public char KEFILDCFEEF()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x68F5D30", Offset = "0x68F5130", VA = "0x1868F5D30")]
	public ushort ADMFJPEGCLH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x68F6280", Offset = "0x68F5680", VA = "0x1868F6280")]
	public short KAICPOKHCKL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x68F5EB0", Offset = "0x68F52B0", VA = "0x1868F5EB0")]
	public long EHNADDFLIME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x68F6880", Offset = "0x68F5C80", VA = "0x1868F6880")]
	public ulong PIKIICCINJN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x68F5F60", Offset = "0x68F5360", VA = "0x1868F5F60")]
	public int FCMAFENCOLN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x68F61B0", Offset = "0x68F55B0", VA = "0x1868F61B0")]
	public uint JDADGNDJAFG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x68F66B0", Offset = "0x68F5AB0", VA = "0x1868F66B0")]
	public float KMBCNAHJMGB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x68F6810", Offset = "0x68F5C10", VA = "0x1868F6810")]
	public double OIJJBPHFJCL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x68F62F0", Offset = "0x68F56F0", VA = "0x1868F62F0")]
	public string KDKFLOPCACE(int BIHHFABMMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x68F67A0", Offset = "0x68F5BA0", VA = "0x1868F67A0")]
	public ArraySegment<byte> MKPEDCIBLEO(int LOHPPDCIAAL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x68F5E60", Offset = "0x68F5260", VA = "0x1868F5E60")]
	public sbyte[] CKGBGGNBLMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x68F6130", Offset = "0x68F5530", VA = "0x1868F6130")]
	public byte[] IMANBKENLGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x68F6220", Offset = "0x68F5620", VA = "0x1868F6220")]
	public void JIMFDDOIBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class LIMMLOBFBKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] MLAAAKIINKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int COHJMOHAFGA;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int DKKOAIKHMGK = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool PLMCAHAJBMA;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding DFCNKAPKJJM;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int FNDLCDMHABK = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] GLGNJKMLLMB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] IDIBBHDGOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int AKPIBKEABKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6904920", Offset = "0x6903D20", VA = "0x186904920")]
	public LIMMLOBFBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69049A0", Offset = "0x6903DA0", VA = "0x1869049A0")]
	public LIMMLOBFBKC(bool MCPFIDADHGG, int FNPGEJMPFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x69041D0", Offset = "0x69035D0", VA = "0x1869041D0")]
	public static LIMMLOBFBKC GOHLIFBBEBB(string PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6903C00", Offset = "0x6903000", VA = "0x186903C00")]
	public void ACIGDODLBGN(int JOAOMHFJHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2537B90", Offset = "0x2536F90", VA = "0x182537B90")]
	public void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6904610", Offset = "0x6903A10", VA = "0x186904610")]
	public void LPEBEEOAIOC(float PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6904700", Offset = "0x6903B00", VA = "0x186904700")]
	public void LPEBEEOAIOC(double PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x69046B0", Offset = "0x6903AB0", VA = "0x1869046B0")]
	public void LPEBEEOAIOC(long PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x69046B0", Offset = "0x6903AB0", VA = "0x1869046B0")]
	public void LPEBEEOAIOC(ulong PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6904580", Offset = "0x6903980", VA = "0x186904580")]
	public void LPEBEEOAIOC(int PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6904580", Offset = "0x6903980", VA = "0x186904580")]
	public void LPEBEEOAIOC(uint PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6904510", Offset = "0x6903910", VA = "0x186904510")]
	public void LPEBEEOAIOC(char PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6904510", Offset = "0x6903910", VA = "0x186904510")]
	public void LPEBEEOAIOC(ushort PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6904510", Offset = "0x6903910", VA = "0x186904510")]
	public void LPEBEEOAIOC(short PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x69044B0", Offset = "0x69038B0", VA = "0x1869044B0")]
	public void LPEBEEOAIOC(sbyte PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x69044B0", Offset = "0x69038B0", VA = "0x1869044B0")]
	public void LPEBEEOAIOC(byte PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6904830", Offset = "0x6903C30", VA = "0x186904830")]
	public void LPEBEEOAIOC(byte[] MJFOKKFMONL, int FGCNBOMLCIC, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6903CA0", Offset = "0x69030A0", VA = "0x186903CA0")]
	public void EDANBINHHOF(sbyte[] MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6903CA0", Offset = "0x69030A0", VA = "0x186903CA0")]
	public void DAKPAMCEELO(byte[] MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6904240", Offset = "0x6903640", VA = "0x186904240")]
	public void LPEBEEOAIOC(bool PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6903E60", Offset = "0x6903260", VA = "0x186903E60")]
	public void GHIJMKBAANC(Array AHLFLADDOCG, int NAIHMELDEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6904020", Offset = "0x6903420", VA = "0x186904020")]
	public void GHIJMKBAANC(float[] PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6903D80", Offset = "0x6903180", VA = "0x186903D80")]
	public void GHIJMKBAANC(double[] PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6903D80", Offset = "0x6903180", VA = "0x186903D80")]
	public void GHIJMKBAANC(long[] PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6903D80", Offset = "0x6903180", VA = "0x186903D80")]
	public void GHIJMKBAANC(ulong[] PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6904020", Offset = "0x6903420", VA = "0x186904020")]
	public void GHIJMKBAANC(int[] PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6904020", Offset = "0x6903420", VA = "0x186904020")]
	public void GHIJMKBAANC(uint[] PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6903F40", Offset = "0x6903340", VA = "0x186903F40")]
	public void GHIJMKBAANC(ushort[] PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6903F40", Offset = "0x6903340", VA = "0x186903F40")]
	public void GHIJMKBAANC(short[] PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6903CA0", Offset = "0x69030A0", VA = "0x186903CA0")]
	public void GHIJMKBAANC(bool[] PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6904100", Offset = "0x6903500", VA = "0x186904100")]
	public void GHIJMKBAANC(string[] PEBNJNGMMHE, int IGMMHDGNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6904750", Offset = "0x6903B50", VA = "0x186904750")]
	public void LPEBEEOAIOC(IPEndPoint IADNFBHEAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6904820", Offset = "0x6903C20", VA = "0x186904820")]
	public void LPEBEEOAIOC(string PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x69042A0", Offset = "0x69036A0", VA = "0x1869042A0")]
	public void LPEBEEOAIOC(string PEBNJNGMMHE, int BIHHFABMMFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DENKONMECIE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class CFGJJHLDHMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong MHHGANKHAMB;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x60725C0", Offset = "0x60719C0", VA = "0x1860725C0")]
		static CFGJJHLDHMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void PHLDCFFNJFC(FKHHLNFMBKN AENCLAHFBDP, object IPLCJOBGMMJ);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LKJLJFAPOBK<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public DENKONMECIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LKJLJFAPOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4C0D2D0", Offset = "0x4C0C6D0", VA = "0x184C0D2D0")]
		internal void BELGPCDCLBO(FKHHLNFMBKN reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OKLAGKCCEDP<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public DENKONMECIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OKLAGKCCEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4FC23C0", Offset = "0x4FC17C0", VA = "0x184FC23C0")]
		internal void BELGPCDCLBO(FKHHLNFMBKN reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly MKLKFCEGMCF DDLPPDHJKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, PHLDCFFNJFC> APADJJPEJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly LIMMLOBFBKC PLBMLCNHANK;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x68F52E0", Offset = "0x68F46E0", VA = "0x1868F52E0")]
	public DENKONMECIE(int AHPFBNNLKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x320F340", Offset = "0x320E740", VA = "0x18320F340", Slot = "4")]
	protected virtual ulong LLNOGEDFBGH<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x68F51B0", Offset = "0x68F45B0", VA = "0x1868F51B0", Slot = "5")]
	protected virtual PHLDCFFNJFC PGILDPMPAOM(FKHHLNFMBKN AENCLAHFBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x32CD8C0", Offset = "0x32CCCC0", VA = "0x1832CD8C0", Slot = "6")]
	protected virtual void AADMPELKDKJ<T>(LIMMLOBFBKC MGKMPBCECKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x68F50E0", Offset = "0x68F44E0", VA = "0x1868F50E0")]
	public void BJBPNCECGEO(FKHHLNFMBKN AENCLAHFBDP, object IPLCJOBGMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x32CDCB0", Offset = "0x32CD0B0", VA = "0x1832CDCB0")]
	public void IJMBEPNCDBE<T>(LIMMLOBFBKC MGKMPBCECKN, T ECAHOFJDANA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x68F5160", Offset = "0x68F4560", VA = "0x1868F5160")]
	public void IABDIFIKOCJ(FKHHLNFMBKN AENCLAHFBDP, object IPLCJOBGMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x32CDAF0", Offset = "0x32CCEF0", VA = "0x1832CDAF0")]
	public void HBOGPNGGLFF<T>(Action<T> MIDAPDGEMON) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x32CD930", Offset = "0x32CCD30", VA = "0x1832CD930")]
	public void HBOGPNGGLFF<T, TUserData>(Action<T, TUserData> MIDAPDGEMON) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class JFFKLFDFECM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x68F5560", Offset = "0x68F4960", VA = "0x1868F5560")]
	public JFFKLFDFECM(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IHAEPGKJKKN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x69008E0", Offset = "0x68FFCE0", VA = "0x1869008E0")]
	public IHAEPGKJKKN(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class MKLKFCEGMCF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum AOLAMFMDNFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class DKJANBHOMLD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AOLAMFMDNFD ELLKCGJJEKP;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6405D70", Offset = "0x6405170", VA = "0x186405D70", Slot = "4")]
		public virtual void MEKFCHHLHOB(MethodInfo AAKHKAKOBME, MethodInfo LHKDJDOLMKK, AOLAMFMDNFD ANONBNLNHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void JFHJBDNDJPO(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void LALNFKFNJCO(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		protected DKJANBHOMLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class KLNDGIOJFCP<TClass, TProperty> : DKJANBHOMLD<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> AFGCNLLPPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> EHENFMEIALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> KKIFELNANMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> FKFGFLLAOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> LCLEFBMCNEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> NJPDDKCJKGG;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4B362F0", Offset = "0x4B356F0", VA = "0x184B362F0", Slot = "7")]
		public override void KHNOFCCNKJB(TClass DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4B36050", Offset = "0x4B35450", VA = "0x184B36050", Slot = "8")]
		public override void HFNIIBMJADN(TClass DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4B36130", Offset = "0x4B35530", VA = "0x184B36130", Slot = "9")]
		public override void JFHJBDNDJPO(TClass DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4B366A0", Offset = "0x4B35AA0", VA = "0x184B366A0", Slot = "10")]
		public override void LALNFKFNJCO(TClass DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4B364B0", Offset = "0x4B358B0", VA = "0x184B364B0")]
		protected TProperty[] KOENDAHIMOD(TClass DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4B35EF0", Offset = "0x4B352F0", VA = "0x184B35EF0")]
		protected TProperty[] EMBMFHDKOCJ(TClass DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4B36780", Offset = "0x4B35B80", VA = "0x184B36780", Slot = "4")]
		public override void MEKFCHHLHOB(MethodInfo AAKHKAKOBME, MethodInfo LHKDJDOLMKK, AOLAMFMDNFD ANONBNLNHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x462CFE0", Offset = "0x462C3E0", VA = "0x18462CFE0")]
		protected KLNDGIOJFCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class DPKOJFIFAKB<TClass, TProperty> : KLNDGIOJFCP<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void PJMFPNEBMDJ(FKHHLNFMBKN NPJNBFDHKLI, [Out] TProperty LLCAOGDINIM);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void HHFIJDADBOC(LIMMLOBFBKC ICNIEKFBNNN, TProperty LLCAOGDINIM);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6414F80", Offset = "0x6414380", VA = "0x186414F80", Slot = "5")]
		public override void DKFKDLDOCOB(TClass DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x64152C0", Offset = "0x64146C0", VA = "0x1864152C0", Slot = "6")]
		public override void IJMBEPNCDBE(TClass DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6415340", Offset = "0x6414740", VA = "0x186415340", Slot = "7")]
		public override void KHNOFCCNKJB(TClass DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6415180", Offset = "0x6414580", VA = "0x186415180", Slot = "8")]
		public override void HFNIIBMJADN(TClass DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4628820", Offset = "0x4627C20", VA = "0x184628820")]
		protected DPKOJFIFAKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class MPINNOMHNNM<T> : KLNDGIOJFCP<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4E24FF0", Offset = "0x4E243F0", VA = "0x184E24FF0", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4E25070", Offset = "0x4E24470", VA = "0x184E25070", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4E250E0", Offset = "0x4E244E0", VA = "0x184E250E0", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x486D6B0", Offset = "0x486CAB0", VA = "0x18486D6B0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public MPINNOMHNNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class DBHNOAPHCJM<T> : KLNDGIOJFCP<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x63E7960", Offset = "0x63E6D60", VA = "0x1863E7960", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4E25070", Offset = "0x4E24470", VA = "0x184E25070", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x63E79E0", Offset = "0x63E6DE0", VA = "0x1863E79E0", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x486D6B0", Offset = "0x486CAB0", VA = "0x18486D6B0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public DBHNOAPHCJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class NBFCOFJOAPN<T> : KLNDGIOJFCP<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4E72BB0", Offset = "0x4E71FB0", VA = "0x184E72BB0", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD200", Offset = "0x4DFC600", VA = "0x184DFD200", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4E72C30", Offset = "0x4E72030", VA = "0x184E72C30", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD190", Offset = "0x4DFC590", VA = "0x184DFD190", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public NBFCOFJOAPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class MFFJKBNFMBC<T> : KLNDGIOJFCP<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD110", Offset = "0x4DFC510", VA = "0x184DFD110", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD200", Offset = "0x4DFC600", VA = "0x184DFD200", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD270", Offset = "0x4DFC670", VA = "0x184DFD270", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD190", Offset = "0x4DFC590", VA = "0x184DFD190", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public MFFJKBNFMBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class ALJPFKHAMGN<T> : KLNDGIOJFCP<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4738820", Offset = "0x4737C20", VA = "0x184738820", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4738910", Offset = "0x4737D10", VA = "0x184738910", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4738980", Offset = "0x4737D80", VA = "0x184738980", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x47388A0", Offset = "0x4737CA0", VA = "0x1847388A0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public ALJPFKHAMGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DGPKOJFLEBP<T> : KLNDGIOJFCP<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x63EDEF0", Offset = "0x63ED2F0", VA = "0x1863EDEF0", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4738910", Offset = "0x4737D10", VA = "0x184738910", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x63EDF70", Offset = "0x63ED370", VA = "0x1863EDF70", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x47388A0", Offset = "0x4737CA0", VA = "0x1847388A0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public DGPKOJFLEBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class BENFKIKLEHF<T> : KLNDGIOJFCP<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8170", Offset = "0x4BF7570", VA = "0x184BF8170", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4BF81F0", Offset = "0x4BF75F0", VA = "0x184BF81F0", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5BA4AD0", Offset = "0x5BA3ED0", VA = "0x185BA4AD0", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x46485B0", Offset = "0x46479B0", VA = "0x1846485B0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public BENFKIKLEHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class LGHAGHAHBKH<T> : KLNDGIOJFCP<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8170", Offset = "0x4BF7570", VA = "0x184BF8170", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4BF81F0", Offset = "0x4BF75F0", VA = "0x184BF81F0", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8260", Offset = "0x4BF7660", VA = "0x184BF8260", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x46485B0", Offset = "0x46479B0", VA = "0x1846485B0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public LGHAGHAHBKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class AOPBOIJKFID<T> : KLNDGIOJFCP<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x486D630", Offset = "0x486CA30", VA = "0x18486D630", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x486D720", Offset = "0x486CB20", VA = "0x18486D720", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x486D790", Offset = "0x486CB90", VA = "0x18486D790", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x486D6B0", Offset = "0x486CAB0", VA = "0x18486D6B0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public AOPBOIJKFID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class CHLJHLCLPIM<T> : KLNDGIOJFCP<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6075FE0", Offset = "0x60753E0", VA = "0x186075FE0", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6076060", Offset = "0x6075460", VA = "0x186076060", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x60760D0", Offset = "0x60754D0", VA = "0x1860760D0", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x47388A0", Offset = "0x4737CA0", VA = "0x1847388A0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public CHLJHLCLPIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class AHEOMPAPADI<T> : KLNDGIOJFCP<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4648530", Offset = "0x4647930", VA = "0x184648530", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4648620", Offset = "0x4647A20", VA = "0x184648620", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4648690", Offset = "0x4647A90", VA = "0x184648690", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x46485B0", Offset = "0x46479B0", VA = "0x1846485B0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4648710", Offset = "0x4647B10", VA = "0x184648710")]
		public AHEOMPAPADI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class ANGAINFNLEJ<T> : DPKOJFIFAKB<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x486CAB0", Offset = "0x486BEB0", VA = "0x18486CAB0", Slot = "12")]
		protected override void HHFIJDADBOC(LIMMLOBFBKC ICNIEKFBNNN, char LLCAOGDINIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x486CAE0", Offset = "0x486BEE0", VA = "0x18486CAE0", Slot = "11")]
		protected override void PJMFPNEBMDJ(FKHHLNFMBKN NPJNBFDHKLI, [Out] char LLCAOGDINIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x40B57F0", Offset = "0x40B4BF0", VA = "0x1840B57F0")]
		public ANGAINFNLEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class BNDNKDIAMHH<T> : DPKOJFIFAKB<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D81BC0", Offset = "0x5D80FC0", VA = "0x185D81BC0", Slot = "12")]
		protected override void HHFIJDADBOC(LIMMLOBFBKC ICNIEKFBNNN, IPEndPoint LLCAOGDINIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D81BF0", Offset = "0x5D80FF0", VA = "0x185D81BF0", Slot = "11")]
		protected override void PJMFPNEBMDJ(FKHHLNFMBKN NPJNBFDHKLI, [Out] IPEndPoint LLCAOGDINIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x40B57F0", Offset = "0x40B4BF0", VA = "0x1840B57F0")]
		public BNDNKDIAMHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class GOFJHPPLJII<T> : KLNDGIOJFCP<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int JHLOPECBMHO;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x46DDD40", Offset = "0x46DD140", VA = "0x1846DDD40")]
		public GOFJHPPLJII(int BIHHFABMMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x46DDB40", Offset = "0x46DCF40", VA = "0x1846DDB40", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x46DDC40", Offset = "0x46DD040", VA = "0x1846DDC40", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x46DDCC0", Offset = "0x46DD0C0", VA = "0x1846DDCC0", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x46DDBC0", Offset = "0x46DCFC0", VA = "0x1846DDBC0", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class DKBPPGIMOFF<T> : DKJANBHOMLD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo IKHHAMAKPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type KPPEHPOAJHH;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6405A80", Offset = "0x6404E80", VA = "0x186405A80")]
		public DKBPPGIMOFF(PropertyInfo MFGHKKFEKII, Type AOONDLPNIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6405790", Offset = "0x6404B90", VA = "0x186405790", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x64058B0", Offset = "0x6404CB0", VA = "0x1864058B0", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x64059C0", Offset = "0x6404DC0", VA = "0x1864059C0", Slot = "7")]
		public override void KHNOFCCNKJB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6405850", Offset = "0x6404C50", VA = "0x186405850", Slot = "8")]
		public override void HFNIIBMJADN(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6405960", Offset = "0x6404D60", VA = "0x186405960", Slot = "9")]
		public override void JFHJBDNDJPO(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6405A20", Offset = "0x6404E20", VA = "0x186405A20", Slot = "10")]
		public override void LALNFKFNJCO(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class FNLEDEKLDFD<T> : DKBPPGIMOFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4123EC0", Offset = "0x41232C0", VA = "0x184123EC0")]
		public FNLEDEKLDFD(PropertyInfo MFGHKKFEKII, Type AOONDLPNIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x45882E0", Offset = "0x45876E0", VA = "0x1845882E0", Slot = "5")]
		public override void DKFKDLDOCOB(T DMCDPFADGIL, FKHHLNFMBKN NPJNBFDHKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x45883A0", Offset = "0x45877A0", VA = "0x1845883A0", Slot = "6")]
		public override void IJMBEPNCDBE(T DMCDPFADGIL, LIMMLOBFBKC ICNIEKFBNNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class HHAIBIIBPKD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static HHAIBIIBPKD<T> AJPLFLPAHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly DKJANBHOMLD<T>[] FGHOLKADBMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int JPICHPAKOJG;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x474B9F0", Offset = "0x474ADF0", VA = "0x18474B9F0")]
		public HHAIBIIBPKD(List<DKJANBHOMLD<T>> ENPHBDJAEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x474B940", Offset = "0x474AD40", VA = "0x18474B940")]
		public void IJMBEPNCDBE(T NBAMGPFDMIB, LIMMLOBFBKC MGKMPBCECKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x474B890", Offset = "0x474AC90", VA = "0x18474B890")]
		public void DKFKDLDOCOB(T NBAMGPFDMIB, FKHHLNFMBKN AENCLAHFBDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class MPCDFAODAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract DKJANBHOMLD<T> FCPELJIOJPN<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private LIMMLOBFBKC CIDBAFJOLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int CNHICLBJHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, MPCDFAODAGL> CNGHCDHIJGC;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6907790", Offset = "0x6906B90", VA = "0x186907790")]
	public MKLKFCEGMCF(int AHPFBNNLKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x35C0F10", Offset = "0x35C0310", VA = "0x1835C0F10")]
	private HHAIBIIBPKD<T> AEACINCKFKA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x327A4F0", Offset = "0x32798F0", VA = "0x18327A4F0")]
	public void ICLMLJMBJAH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x35C20C0", Offset = "0x35C14C0", VA = "0x1835C20C0")]
	public bool NHMCOOCBIHH<T>(FKHHLNFMBKN AENCLAHFBDP, T GACPILKGIFM) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x35C2030", Offset = "0x35C1430", VA = "0x1835C2030")]
	public void EFGCEHNIDJN<T>(LIMMLOBFBKC MGKMPBCECKN, T NBAMGPFDMIB) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KAKHDFCNOMB
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime ABBBEKMCJBG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] INEBAFPBBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CNOJKOMMKNH AKCFLGOHLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6902700", Offset = "0x6901B00", VA = "0x186902700")]
		get
		{
			return default(CNOJKOMMKNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int MJLIOKIPHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x69019D0", Offset = "0x6900DD0", VA = "0x1869019D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6902260", Offset = "0x6901660", VA = "0x186902260")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DEFHDAANAPO OMFDHBOFKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6901C00", Offset = "0x6901000", VA = "0x186901C00")]
		get
		{
			return default(DEFHDAANAPO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6901C30", Offset = "0x6901030", VA = "0x186901C30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int PCEELMGILPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6901D40", Offset = "0x6901140", VA = "0x186901D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint FOBPOJJEBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6901DD0", Offset = "0x69011D0", VA = "0x186901DD0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CEHIKBMHMME
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6901DA0", Offset = "0x69011A0", VA = "0x186901DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? PLIDAAFMPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6902910", Offset = "0x6901D10", VA = "0x186902910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? JIDABKIFPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6901D70", Offset = "0x6901170", VA = "0x186901D70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6902330", Offset = "0x6901730", VA = "0x186902330")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? GPOCAMAMBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAFAF40", Offset = "0xAFA340", VA = "0x180AFAF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xCD5CE0", Offset = "0xCD50E0", VA = "0x180CD5CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6902A50", Offset = "0x6901E50", VA = "0x186902A50")]
	public KAKHDFCNOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x69029A0", Offset = "0x6901DA0", VA = "0x1869029A0")]
	internal KAKHDFCNOMB(byte[] KPLABGDDBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x69027F0", Offset = "0x6901BF0", VA = "0x1869027F0")]
	public static KAKHDFCNOMB PKGPLCDNIAP(byte[] KPLABGDDBEL, DateTime OFCOKGDAHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6902500", Offset = "0x6901900", VA = "0x186902500")]
	internal void NGOCJGCAOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6902080", Offset = "0x6901480", VA = "0x186902080")]
	private void KKNKGFIOHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6901A00", Offset = "0x6900E00", VA = "0x186901A00")]
	private DateTime? BDHFMBAFFAB(int FGCNBOMLCIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6901EB0", Offset = "0x69012B0", VA = "0x186901EB0")]
	private void KIPHOFLKDKK(int FGCNBOMLCIC, DateTime? PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6901C70", Offset = "0x6901070", VA = "0x186901C70")]
	private ulong EAHJOONIDOD(int FGCNBOMLCIC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6902730", Offset = "0x6901B30", VA = "0x186902730")]
	private void NMINGEFMELO(int FGCNBOMLCIC, ulong PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x69022A0", Offset = "0x69016A0", VA = "0x1869022A0")]
	private uint MDGGHCFIGBC(int FGCNBOMLCIC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x67C0030", Offset = "0x67BF430", VA = "0x1867C0030")]
	private static uint KGDIBCLKECD(uint COMHOHNLIIN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6901E50", Offset = "0x6901250", VA = "0x186901E50")]
	private static ulong KGDIBCLKECD(ulong COMHOHNLIIN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum CNOJKOMMKNH
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum DEFHDAANAPO
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class DFDACAGJNBE
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int ODABCEMAMBM = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int NIKOOPNNJFO = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int DOLCENABIOD = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint JKAHOEHNACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int LALPNDOBGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int NGEALOJAOBP;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AMMGBPMGMMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x68F5550", Offset = "0x68F4950", VA = "0x1868F5550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x68F5460", Offset = "0x68F4860", VA = "0x1868F5460")]
	public bool LPJNLMJAAPM(LCFIHAJJHNN EKGDICLADEC, int LLHIMIEALOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class JBDHINDKONE : LCFIHAJJHNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket EKGDICLADEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly GDBBCJKLEFH GAIDDKLDGMP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short NEODCPKJLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x69009C0", Offset = "0x68FFDC0", VA = "0x1869009C0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int GGIOFJLAEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6900FA0", Offset = "0x69003A0", VA = "0x186900FA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint FIMEDMOLMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6900940", Offset = "0x68FFD40", VA = "0x186900940", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily LALDFDHFMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x101E3A0", Offset = "0x101D7A0", VA = "0x18101E3A0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x69010B0", Offset = "0x69004B0", VA = "0x1869010B0")]
	public JBDHINDKONE(AddressFamily BMGKIOCHJNE, GDBBCJKLEFH GAIDDKLDGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x69009E0", Offset = "0x68FFDE0", VA = "0x1869009E0", Slot = "8")]
	public bool JBFKAFGKABL(IPEndPoint IADNFBHEAGL, LIOPJFNHPAP DLIJGEJPHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6900980", Offset = "0x68FFD80", VA = "0x186900980", Slot = "9")]
	public int HLCPCMCDKOF(byte[] LMNIHILKKEL, int FGCNBOMLCIC, int NBPEDBIONNC, IPEndPoint BOOCHBMNIOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6900FC0", Offset = "0x69003C0", VA = "0x186900FC0", Slot = "10")]
	public int OPACIGNBONE(byte[] LMNIHILKKEL, EndPoint MILNCEPNFML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6900960", Offset = "0x68FFD60", VA = "0x186900960", Slot = "11")]
	public void DBLJMGCONFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface LCFIHAJJHNN
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short NEODCPKJLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int GGIOFJLAEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint FIMEDMOLMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily LALDFDHFMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JBFKAFGKABL(IPEndPoint IADNFBHEAGL, LIOPJFNHPAP DLIJGEJPHJK);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int HLCPCMCDKOF(byte[] LMNIHILKKEL, int FGCNBOMLCIC, int NBPEDBIONNC, IPEndPoint BOOCHBMNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OPACIGNBONE(byte[] LMNIHILKKEL, EndPoint BOOCHBMNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DBLJMGCONFP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct LPDOCPFBBLF : IEquatable<LPDOCPFBBLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long LINJPCJEEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long NCKGPMKDCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long PEOKNABKDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int LAEPDLJCDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int LDNPFKJAAFC;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6905580", Offset = "0x6904980", VA = "0x186905580")]
	public LPDOCPFBBLF(byte[] LABPDJANKHN, int FOIIGPLEJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x98E180", Offset = "0x98D580", VA = "0x18098E180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6905490", Offset = "0x6904890", VA = "0x186905490", Slot = "4")]
	public bool Equals(LPDOCPFBBLF MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x69054D0", Offset = "0x69048D0", VA = "0x1869054D0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FHCLKPOJIEI : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] BCKMMNJFLDG;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class LMOMEJOBNAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int DCIINMJCLAI;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
	protected LMOMEJOBNAO(int NFFBIPNFGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BKNLIBFFBEE(IPEndPoint IADNFBHEAGL, byte[] MJFOKKFMONL, int FGCNBOMLCIC, int EHCAJIFPCLL);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void EKCGICMFGAB(IPEndPoint IADNFBHEAGL, byte[] MJFOKKFMONL, int FGCNBOMLCIC, int EHCAJIFPCLL);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MENHBGOGDGA : LMOMEJOBNAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] MCNLCGLNHHO;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator NFIABKADELO;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x25E8060", Offset = "0x25E7460", VA = "0x1825E8060")]
	public MENHBGOGDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6906CA0", Offset = "0x69060A0", VA = "0x186906CA0")]
	public void BKHIPKLNPNI(IPEndPoint IADNFBHEAGL, byte[] MCNLCGLNHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6907660", Offset = "0x6906A60", VA = "0x186907660")]
	public void KENGOMDOJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6906E50", Offset = "0x6906250", VA = "0x186906E50", Slot = "4")]
	public override void BKNLIBFFBEE(IPEndPoint IADNFBHEAGL, byte[] MJFOKKFMONL, int FGCNBOMLCIC, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6907300", Offset = "0x6906700", VA = "0x186907300", Slot = "5")]
	public override void EKCGICMFGAB(IPEndPoint IADNFBHEAGL, byte[] MJFOKKFMONL, int FGCNBOMLCIC, int EHCAJIFPCLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct JCEKGAENNKM
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void IDGBENHNJAC([NoAlias] byte* BPKLGDELKBN, [NoAlias] byte* MCNLCGLNHHO, [NoAlias] byte* FELJCKGBKNJ, int EHCAJIFPCLL);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class JAMEMEGJHCO
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr CNFIKOLPLGM;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr IADLFOHIBJI;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6907D50", Offset = "0x6907150", VA = "0x186907D50")]
		[BurstDiscard]
		private static void DHCJPPCKLEN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6907C00", Offset = "0x6907000", VA = "0x186907C00")]
		private static IntPtr ABLJOGOJPLP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6907E70", Offset = "0x6907270", VA = "0x186907E70")]
		public static void EGGOLOIGEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
		public static void OBBALIPJEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6907F10", Offset = "0x6907310", VA = "0x186907F10")]
		public unsafe static void PLLPMLOMEJL([NoAlias] byte* BPKLGDELKBN, [NoAlias] byte* MCNLCGLNHHO, [NoAlias] byte* FELJCKGBKNJ, int EHCAJIFPCLL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint MCNLCGLNHHO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint FELJCKGBKNJ[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint NMFBHJDKFME[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint INCKJNCDMGF[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint DMFIHMDMOAG[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint FCHBHJODBGL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint PFBGKJHNKHP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint PJICLLPDPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint KJEKHPMLGHP[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x69016F0", Offset = "0x6900AF0", VA = "0x1869016F0")]
	private void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6901930", Offset = "0x6900D30", VA = "0x186901930")]
	private uint MIKPBCAPDIL(uint CKLNAHKPEEA, int PAEGKCHNPLJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x68F01F0", Offset = "0x68EF5F0", VA = "0x1868F01F0")]
	private void BEMMLCOMDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x68F02A0", Offset = "0x68EF6A0", VA = "0x1868F02A0")]
	private void BMDGEOLGJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x68F04B0", Offset = "0x68EF8B0", VA = "0x1868F04B0")]
	private void CPODOHMLCFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x68F0540", Offset = "0x68EF940", VA = "0x1868F0540")]
	private void KAMJDOHPJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x69018D0", Offset = "0x6900CD0", VA = "0x1869018D0")]
	private void MFNKJLEEBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x69011D0", Offset = "0x69005D0", VA = "0x1869011D0")]
	private unsafe void EIPBAEFIMLF(byte* BPKLGDELKBN, uint* MCNLCGLNHHO, uint* FELJCKGBKNJ, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6901850", Offset = "0x6900C50", VA = "0x186901850")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void JLDFALLMHEB([NoAlias] byte* BPKLGDELKBN, [NoAlias] byte* MCNLCGLNHHO, [NoAlias] byte* FELJCKGBKNJ, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6901770", Offset = "0x6900B70", VA = "0x186901770")]
	public static void JLDFALLMHEB(Span<byte> BPKLGDELKBN, Span<byte> MCNLCGLNHHO, Span<byte> FELJCKGBKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x69015F0", Offset = "0x69009F0", VA = "0x1869015F0")]
	public static void FGCHKMCMAAF(Span<byte> BPKLGDELKBN, Span<byte> MCNLCGLNHHO, Span<byte> FELJCKGBKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6901160", Offset = "0x6900560", VA = "0x186901160")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void APMDEJHGHCI([NoAlias] byte* BPKLGDELKBN, [NoAlias] byte* MCNLCGLNHHO, [NoAlias] byte* FELJCKGBKNJ, int EHCAJIFPCLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6908140", Offset = "0x6907540", VA = "0x186908140")]
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
