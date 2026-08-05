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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LCIBKPGHPAK
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum HIGOAJDMIOA
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
		private NetworkManager GCMHBOBLOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, OHMMOELPGAP> BKIIDAIGBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BFMCHHNJFNN GLBNMEIDCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] CJGEGNEHIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HIGOAJDMIOA NHBHOMGKIDB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong KLDEJDKJBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool BPGAFALDDJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x61D4910", Offset = "0x61D3D10", VA = "0x1861D4910", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61D3EA0", Offset = "0x61D32A0", VA = "0x1861D3EA0")]
		public void RecRoom_SetEncryptionInfo(ulong FGCAPOOHHEF, byte[] OEOMDKHBDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61D3E80", Offset = "0x61D3280", VA = "0x1861D3E80")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61D3D50", Offset = "0x61D3150", VA = "0x1861D3D50")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x61D4810", Offset = "0x61D3C10", VA = "0x1861D4810")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61D3FC0", Offset = "0x61D33C0", VA = "0x1861D3FC0", Slot = "6")]
		public override void Send(ulong IGGOHFNFHAE, ArraySegment<byte> AIKOCCMKKAE, NetworkDelivery KOLPDGGOFHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61D3E40", Offset = "0x61D3240", VA = "0x1861D3E40", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong IGGOHFNFHAE, [Out] ArraySegment<byte> GKKLHKCNNPG, [Out] float LCFOCMCJOLI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61D42B0", Offset = "0x61D36B0", VA = "0x1861D42B0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61D4730", Offset = "0x61D3B30", VA = "0x1861D4730", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61D3390", Offset = "0x61D2790", VA = "0x1861D3390", Slot = "10")]
		public override void DisconnectRemoteClient(ulong IGGOHFNFHAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61D3240", Offset = "0x61D2640", VA = "0x1861D3240", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61D3600", Offset = "0x61D2A00", VA = "0x1861D3600", Slot = "12")]
		public override ulong GetCurrentRtt(ulong IGGOHFNFHAE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61D4240", Offset = "0x61D3640", VA = "0x1861D4240", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x61D37F0", Offset = "0x61D2BF0", VA = "0x1861D37F0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager GCMHBOBLOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61D3A70", Offset = "0x61D2E70", VA = "0x1861D3A70")]
		private FCPFDDPCNGP NDHNKINPENL(NetworkDelivery DPOLEDLIAMP)
		{
			return default(FCPFDDPCNGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x61D39B0", Offset = "0x61D2DB0", VA = "0x1861D39B0", Slot = "15")]
		private void JIPEGPOHIIO(OHMMOELPGAP NNCLGFMMJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61D36A0", Offset = "0x61D2AA0", VA = "0x1861D36A0", Slot = "16")]
		private void HEHBBFGCACN(OHMMOELPGAP NNCLGFMMJBP, FMJHOOMIBKN MAGFKCMMHGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "17")]
		private void EANBOHECFIK(IPEndPoint ALJAJODDKLH, SocketError DHPGFMGOOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61D3B40", Offset = "0x61D2F40", VA = "0x1861D3B40", Slot = "18")]
		private void NLLMMPDHNOM(OHMMOELPGAP NNCLGFMMJBP, LJHMKDGDJKI GDCGEJPDKCM, byte BGCAKPPJKAN, FCPFDDPCNGP DBICFGMKGIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61D3520", Offset = "0x61D2920", VA = "0x1861D3520")]
		private void GKBKFPKCBMK(int IKJKAFPPDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "19")]
		private void FIOBDPMMDAN(IPEndPoint DDALIMJJHPK, LJHMKDGDJKI GDCGEJPDKCM, OAFJLPBLGCN OFDCHCKKEPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "20")]
		private void EHJEFBEJEOD(OHMMOELPGAP NNCLGFMMJBP, int OMGPHLKGCJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61D3760", Offset = "0x61D2B60", VA = "0x1861D3760", Slot = "21")]
		private void HEHIAHGKABL(NNNPGGBAIFF BCGNIJHEBIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x61D37C0", Offset = "0x61D2BC0", VA = "0x1861D37C0")]
		private ulong HJBIFINNCEK(OHMMOELPGAP NNCLGFMMJBP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61D3500", Offset = "0x61D2900", VA = "0x1861D3500")]
		private static int FDNCHJOHLKG(float FBMABEBEKJJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x61D4830", Offset = "0x61D3C30", VA = "0x1861D4830")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class LGLOPPIOPBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly OHMMOELPGAP NNNPKBDMEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<NJKCLFDPCAA> LPHGKHABFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int NIBBECCDKDD;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61D1E60", Offset = "0x61D1260", VA = "0x1861D1E60")]
	protected LGLOPPIOPBN(OHMMOELPGAP NNCLGFMMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61D1D40", Offset = "0x61D1140", VA = "0x1861D1D40")]
	public void BMNDCLCJPPL(NJKCLFDPCAA HLOGFEOOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61D1DA0", Offset = "0x61D11A0", VA = "0x1861D1DA0")]
	protected void IDKHCEDEKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61D1E20", Offset = "0x61D1220", VA = "0x1861D1E20")]
	public bool JIBLDPBOKCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool PEGGPOCMGAI();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool CPPBEMKLIKA(NJKCLFDPCAA HLOGFEOOFOM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum PJBKIMEJJLJ
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
public class NNNPGGBAIFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BFMCHHNJFNN IFOAGELCKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int LEMELOPNBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal NAADIMFFKDO HAMBIKGPABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint KMCLLFICHGC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PJBKIMEJJLJ ECALPEPLJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D10", Offset = "0x8D1110", VA = "0x1808D1D10")]
		[CompilerGenerated]
		get
		{
			return default(PJBKIMEJJLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDAFFF0", Offset = "0xDAF3F0", VA = "0x180DAFFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61D7790", Offset = "0x61D6B90", VA = "0x1861D7790")]
	internal void BDEKECDCNNI(NAADIMFFKDO KMMCAAPFLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61D7850", Offset = "0x61D6C50", VA = "0x1861D7850")]
	private bool FLGNNHCLLGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61D7880", Offset = "0x61D6C80", VA = "0x1861D7880")]
	internal NNNPGGBAIFF(IPEndPoint DDALIMJJHPK, NAADIMFFKDO PODFGLCHPGF, BFMCHHNJFNN EBILIAAEOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61D77F0", Offset = "0x61D6BF0", VA = "0x1861D77F0")]
	public OHMMOELPGAP DAPNFMBODHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OAFJLPBLGCN
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum KEBFCAEBACE
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
public struct FMJHOOMIBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public KEBFCAEBACE KNGGCIIIHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError AKLDLMMAELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public LJHMKDGDJKI INNGMPBAILJ;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LCIBKPGHPAK
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPCCLLIDMBJ(OHMMOELPGAP NNCLGFMMJBP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKELJGENAOF(OHMMOELPGAP NNCLGFMMJBP, FMJHOOMIBKN MAGFKCMMHGJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMKONPCIIEN(IPEndPoint ALJAJODDKLH, SocketError DHPGFMGOOEA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBPECONNFPB(OHMMOELPGAP NNCLGFMMJBP, LJHMKDGDJKI GDCGEJPDKCM, byte BGCAKPPJKAN, FCPFDDPCNGP DBICFGMKGIA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDIHJELNAON(IPEndPoint DDALIMJJHPK, LJHMKDGDJKI GDCGEJPDKCM, OAFJLPBLGCN OFDCHCKKEPN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GOLDECOLAAM(OHMMOELPGAP NNCLGFMMJBP, int OMGPHLKGCJA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CEKIPMLCHJG(NNNPGGBAIFF BCGNIJHEBIO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OKFDGPMCLFD
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHKKINPIDOM(OHMMOELPGAP NNCLGFMMJBP, object JAGMJGLHONC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface COKBINBDDFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPGECEEDEBO(AEFIFGGAPEI HLOGFEOOFOM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EIFGCMJFONB
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMNDCENHEHM(OHMMOELPGAP NNCLGFMMJBP, IPEndPoint OMNMCFDBPJI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NAADIMFFKDO
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int GHFOMMDOJBI = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long NJKJLJAMKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte FJJGMKFFODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] FPDLDPMBGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly MLGLHECOPLA LMIMGNACAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int IEGOLJIMOGH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61D59F0", Offset = "0x61D4DF0", VA = "0x1861D59F0")]
	private NAADIMFFKDO(long DJFLLFOFLEF, byte LHIBAKCJPGL, int IMMJHCFALCP, byte[] LPCMKENIIEE, MLGLHECOPLA AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61D5990", Offset = "0x61D4D90", VA = "0x1861D5990")]
	public static int OOCMAOFFBJE(NJKCLFDPCAA HLOGFEOOFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61D5590", Offset = "0x61D4990", VA = "0x1861D5590")]
	public static NAADIMFFKDO GBOEDIOPHLI(NJKCLFDPCAA HLOGFEOOFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61D57B0", Offset = "0x61D4BB0", VA = "0x1861D57B0")]
	public static NJKCLFDPCAA OCAMLOPGMKM(ELECNCNEJHM BPHKJOHFADP, SocketAddress LFFHEDJFALK, long PJHJGIDCPKK, int IMMJHCFALCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class KLKCKLKDPCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long NJKJLJAMKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte FJJGMKFFODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int IEGOLJIMOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool OMPJIGDPNLK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x61D1CF0", Offset = "0x61D10F0", VA = "0x1861D1CF0")]
	private KLKCKLKDPCJ(long DJFLLFOFLEF, byte LHIBAKCJPGL, int ACOHNLGMEBO, bool NBIBEMNALJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61D19B0", Offset = "0x61D0DB0", VA = "0x1861D19B0")]
	public static KLKCKLKDPCJ GBOEDIOPHLI(NJKCLFDPCAA HLOGFEOOFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61D1C00", Offset = "0x61D1000", VA = "0x1861D1C00")]
	public static NJKCLFDPCAA OCAMLOPGMKM(long PJHJGIDCPKK, byte EAKGDKLGEAM, int BNLJMCEMCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61D1B00", Offset = "0x61D0F00", VA = "0x1861D1B00")]
	public static NJKCLFDPCAA KCKBKGKOIFB(OHMMOELPGAP NNCLGFMMJBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum JLNBMJFGHHP
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LKHFFBIBLCN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMMKAPELELE(IPEndPoint OHIPIKHOHJF, IPEndPoint DDALIMJJHPK, string ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKGPEFPIDDN(IPEndPoint MHHDBKPLFFN, JLNBMJFGHHP DPOLEDLIAMP, string ABHFNNFMPHA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EKFJDLJFIIO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct DGOLKEAFCAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint MNGICPEDLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint KMCLLFICHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string ALNILDJDLKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KNBGDGKHBCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint GOMKMIFBHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JLNBMJFGHHP NKDPEDOOFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string ALNILDJDLKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class FOKMNJKFFEM
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint BNDBLLGFGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ALNILDJDLKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FOKMNJKFFEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class HNKLDPBGHKF
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint BNDBLLGFGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint GJNOPPNFNEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string ALNILDJDLKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HNKLDPBGHKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HGOONMMHCLL
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ALNILDJDLKH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool INCOEJLBKLG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xB47470", Offset = "0xB46870", VA = "0x180B47470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8B6D60", Offset = "0x8B6160", VA = "0x1808B6D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HGOONMMHCLL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly BFMCHHNJFNN ADDJANOAHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<DGOLKEAFCAP> IBFIMIPOLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<KNBGDGKHBCM> FAFOKCPGKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly MLGLHECOPLA NLMLEAICPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ELECNCNEJHM CMEJNAHDNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JDDKGDPMGPG LDIPFCJPBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private LKHFFBIBLCN GEOOKMCDEMH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int HFMGFBIGEPH = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool AOKFJKHOIPE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61CF170", Offset = "0x61CE570", VA = "0x1861CF170")]
	internal EKFJDLJFIIO(BFMCHHNJFNN LPLAOGMLDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61CEE90", Offset = "0x61CE290", VA = "0x1861CEE90")]
	internal void KAHEEPLOBDN(IPEndPoint CHEHLCHOFGH, NJKCLFDPCAA HLOGFEOOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1730", Offset = "0x2CD0B30", VA = "0x182CD1730")]
	private void JNPGEMLJJHB<T>(T HLOGFEOOFOM, IPEndPoint KDGMCPCFIID) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61CEB70", Offset = "0x61CDF70", VA = "0x1861CEB70")]
	private void AMMKAPELELE(FOKMNJKFFEM IMHCDEJCNKD, IPEndPoint CHEHLCHOFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61CF010", Offset = "0x61CE410", VA = "0x1861CF010")]
	private void OCOKNBDLDPJ(HNKLDPBGHKF IMHCDEJCNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x61CED00", Offset = "0x61CE100", VA = "0x1861CED00")]
	private void EIPHMONKFGJ(HGOONMMHCLL IMHCDEJCNKD, IPEndPoint CHEHLCHOFGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum FCPFDDPCNGP : byte
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
public enum AAIOHDMJCIH : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KEEDKLINNBE
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] ICMGPGAEOMD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int IBAOEFLPKJF;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int EMHLBENOLLI;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HCBKKONGLDB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61CF5C0", Offset = "0x61CE9C0", VA = "0x1861CF5C0")]
	public HCBKKONGLDB(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EKNIHDJEGCM : HCBKKONGLDB
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61CF5C0", Offset = "0x61CE9C0", VA = "0x1861CF5C0")]
	public EKNIHDJEGCM(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DAJAJAKHPJA
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
public interface NNMHOMHIIIE
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LENMEMHHDCB(DAJAJAKHPJA NPGFALIGDDG, string CKEJEIFKOJA, params object[] CJLBFJEOAOD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class EENLAPONDOA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NNMHOMHIIIE MCEKOHPIOOJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object MFIBAKNIMMF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61CE7D0", Offset = "0x61CDBD0", VA = "0x1861CE7D0")]
	private static void DKCNKKBBNGK(DAJAJAKHPJA ACFKCIMJODD, string CKEJEIFKOJA, params object[] CJLBFJEOAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x61CE770", Offset = "0x61CDB70", VA = "0x1861CE770")]
	internal static void CAKDIMJLAKN(string CKEJEIFKOJA, params object[] CJLBFJEOAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61CEA00", Offset = "0x61CDE00", VA = "0x1861CEA00")]
	internal static void GEHJJHBOEME(string CKEJEIFKOJA, params object[] CJLBFJEOAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61CEA60", Offset = "0x61CDE60", VA = "0x1861CEA60")]
	internal static void PBABHFALDJF(string CKEJEIFKOJA, params object[] CJLBFJEOAOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum DJHBGAEDAFO
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LJHMKDGDJKI : MLGLHECOPLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NJKCLFDPCAA AECLIJMCEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BFMCHHNJFNN OOJKHEEDEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly KDNDCHFLMKF HFPLFGBBBHI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61D3180", Offset = "0x61D2580", VA = "0x1861D3180")]
	internal LJHMKDGDJKI(BFMCHHNJFNN BLMJILKGBHG, KDNDCHFLMKF OEPCBMIJALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61D3110", Offset = "0x61D2510", VA = "0x1861D3110")]
	internal void PPNBOBKEHFH(NJKCLFDPCAA HLOGFEOOFOM, int CAFGBJCMDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61D3060", Offset = "0x61D2460", VA = "0x1861D3060")]
	internal void GAGAHAKCIDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61D30E0", Offset = "0x61D24E0", VA = "0x1861D30E0")]
	public void LJMOPGONALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class KDNDCHFLMKF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum CPEOGPCNNFK
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
	public KDNDCHFLMKF NMKLPFBIAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public CPEOGPCNNFK NKDPEDOOFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public OHMMOELPGAP NNNPKBDMEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint KMCLLFICHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object AMOAOJFAGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int MCCCBNMBMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError FJKLJIGNJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public KEBFCAEBACE GKEIOJPCLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NNNPGGBAIFF JJGMFOAJABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FCPFDDPCNGP GJNNEPHLCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte IJENELLIKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly LJHMKDGDJKI NPJLNHIGGPP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61D1840", Offset = "0x61D0C40", VA = "0x1861D1840")]
	public KDNDCHFLMKF(BFMCHHNJFNN BLMJILKGBHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BFMCHHNJFNN : IEnumerable<OHMMOELPGAP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class LMDEFBEEFMP : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x61D31D0", Offset = "0x61D25D0", VA = "0x1861D31D0", Slot = "4")]
		public bool Equals(IPEndPoint LBEGFJJGJFP, IPEndPoint GAMIAAAKNPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB3B0", Offset = "0x5CDA7B0", VA = "0x185CDB3B0", Slot = "5")]
		public int GetHashCode(IPEndPoint FMAFBHGACNM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LMDEFBEEFMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct LGPODFICEBI : IEnumerator<OHMMOELPGAP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly OHMMOELPGAP JNOPCNGMPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private OHMMOELPGAP FBNOOIENNCK;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OHMMOELPGAP GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x92A850", Offset = "0x929C50", VA = "0x18092A850", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x92A850", Offset = "0x929C50", VA = "0x18092A850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x13CCAD0", Offset = "0x13CBED0", VA = "0x1813CCAD0")]
		public LGPODFICEBI(OHMMOELPGAP KKPMNJCHLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61D1F00", Offset = "0x61D1300", VA = "0x1861D1F00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61D1F50", Offset = "0x61D1350", VA = "0x1861D1F50", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread JEHNEJFMAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool OKAGDOALDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent BFJGAFNDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<KDNDCHFLMKF> ELNPFBMKKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<KDNDCHFLMKF> AJMIEPOAMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private KDNDCHFLMKF GEENHGIAAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LCIBKPGHPAK GBBMCFCAEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly OKFDGPMCLFD PHOJMNNPJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly COKBINBDDFJ MDLOCDOKDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly EIFGCMJFONB OPLOMEJCIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, OHMMOELPGAP> LLBJCEIEFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, NNNPGGBAIFF> NPJIPDJBIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, IAKBKOEAMLG> CDJCEKBFFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim ILPCJHHCNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private OHMMOELPGAP MMJOIGCOAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int EKHKHLGHAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<OHMMOELPGAP> JDNEELDLPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private OHMMOELPGAP[] KBLEAAKDBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly MBHMFEEIGPJ PHCCEKGOMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int HECFAPHEEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> NKFJLDIPJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte KMICDALHLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object HLAHNCBLALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool IBCIBGMJGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool NKIJPHMCKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int IEFCGBBMGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int MIBMBEKILLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int JMNEHJNBHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int OBBBGAAPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool NKPGAGOFKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool ODIOAPEJKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int AMIHNAGMFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int DDIHFFOOJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int PLJPEDCLBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool AOKFJKHOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool EFFDNCDGKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool KKFHENKKNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool NDNPIJJMLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int EJDKJDLFFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int IGOPHHIAMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool PGCDIGDANHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly NJGMAIEPLOP LHAKKIEKDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool JIIBPKAIAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly EKFJDLJFIIO ICCGHBJDKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool EOAPGGODEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public DJHBGAEDAFO LFFDLIIKPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int PMMPFDBLHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool ALCLIOAKPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool ELFAJFODLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool KLOPKOCGJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool IBNBACAIIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NJKCLFDPCAA EAAJMDPIJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int AGDPOEOGILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object JELHPEHOBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private NJKCLFDPCAA KCEGAIAPFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int PAICDNLFAEM;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int MHCMFKOMGIB = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int CCPFNHIKKOC = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private JCANIEADAHE INHIHLDCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private JCANIEADAHE BLKKANOAFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread HBGBDEJFPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread EFHBELKHBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint LKPIGLGCBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint GPEMEKDBGEF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] ENMPIDNFEFO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] MONJOCAOJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<CBMKHJPHDIN, IPEndPoint> CGAOOBMMJDN;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress DAIHLLIBNAP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool JFOCNGPMJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int NJPHFMKBODE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NANOJHJIDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xEBA790", Offset = "0xEB9B90", VA = "0x180EBA790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xF63D40", Offset = "0xF63140", VA = "0x180F63D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KLDNEJDCEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x197C180", Offset = "0x197B580", VA = "0x18197C180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1CBD810", Offset = "0x1CBCC10", VA = "0x181CBD810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte GGDLBONMDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xCC0E90", Offset = "0xCC0290", VA = "0x180CC0E90")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AGMJMNCMIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61CA320", Offset = "0x61C9720", VA = "0x1861CA320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short LGMDCNLNHLF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x61CCA40", Offset = "0x61CBE40", VA = "0x1861CCA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61C90E0", Offset = "0x61C84E0", VA = "0x1861C90E0")]
	public void JIKLMANOFKG(IPEndPoint ALJAJODDKLH, byte[] OEOMDKHBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61C7150", Offset = "0x61C6550", VA = "0x1861C7150")]
	public void EINAMGFNDJG(IPEndPoint ALJAJODDKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x61CA340", Offset = "0x61C9740", VA = "0x1861CA340")]
	private bool MLCAOGELALK(IPEndPoint ALJAJODDKLH, [Out] OHMMOELPGAP NNCLGFMMJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61C9380", Offset = "0x61C8780", VA = "0x1861C9380")]
	private void KGGACGPPJCI(OHMMOELPGAP NNCLGFMMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61CC6B0", Offset = "0x61CBAB0", VA = "0x1861CC6B0")]
	private void OIOAPICIBIL(OHMMOELPGAP NNCLGFMMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61C8E70", Offset = "0x61C8270", VA = "0x1861C8E70")]
	private void JBKNMPAIJBP(OHMMOELPGAP NNCLGFMMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61CCEE0", Offset = "0x61CC2E0", VA = "0x1861CCEE0")]
	public BFMCHHNJFNN(LCIBKPGHPAK EBILIAAEOFI, [Optional] MBHMFEEIGPJ LJGAGDPHFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61C7100", Offset = "0x61C6500", VA = "0x1861C7100")]
	internal void EICCOHJCIEC(OHMMOELPGAP MEGMOIJGBJP, int OMGPHLKGCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61CCCB0", Offset = "0x61CC0B0", VA = "0x1861CCCB0")]
	internal void PKAFIGOAKJH(OHMMOELPGAP MEGMOIJGBJP, object JAGMJGLHONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61C7410", Offset = "0x61C6810", VA = "0x1861C7410")]
	internal void FKCIPBHEPDA(OHMMOELPGAP NNCLGFMMJBP, KEBFCAEBACE ENJPANJMAJE, SocketError CCOEPBNNHFG, NJKCLFDPCAA COLIBJAKAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61C8CC0", Offset = "0x61C80C0", VA = "0x1861C8CC0")]
	private void IPFHIGIOGMG(OHMMOELPGAP NNCLGFMMJBP, KEBFCAEBACE ENJPANJMAJE, SocketError CCOEPBNNHFG, bool MALABKOONDB, byte[] AIKOCCMKKAE, int IJLPKFECKFC, int HMELIAGANNM, NJKCLFDPCAA COLIBJAKAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61C8080", Offset = "0x61C7480", VA = "0x1861C8080")]
	private void GKDAMLJJHIL(KDNDCHFLMKF.CPEOGPCNNFK DPOLEDLIAMP, [Optional] OHMMOELPGAP NNCLGFMMJBP, [Optional] IPEndPoint DDALIMJJHPK, SocketError MHEFEIGPGPO = SocketError.Success, int OMGPHLKGCJA = 0, KEBFCAEBACE CFLPJAEBPLL = KEBFCAEBACE.ConnectionFailed, [Optional] NNNPGGBAIFF AKPGBPOAHFG, FCPFDDPCNGP DBICFGMKGIA = FCPFDDPCNGP.Unreliable, byte BGCAKPPJKAN = 0, [Optional] NJKCLFDPCAA LADNABFLLHN, [Optional] object JAGMJGLHONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61CB700", Offset = "0x61CAB00", VA = "0x1861CB700")]
	private void NNJKJGDFGLB(KDNDCHFLMKF OEPCBMIJALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x61C8B00", Offset = "0x61C7F00", VA = "0x1861C8B00")]
	internal void IKELAIIBDOG(KDNDCHFLMKF OEPCBMIJALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61CC700", Offset = "0x61CBB00", VA = "0x1861CC700")]
	private void PBHMOCBECLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61C8460", Offset = "0x61C7860", VA = "0x1861C8460")]
	private void HHDOLNHCCFJ(int DCOLHOCHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61C9D00", Offset = "0x61C9100", VA = "0x1861C9D00")]
	internal OHMMOELPGAP MDGPNHNCGIE(NNNPGGBAIFF BCGNIJHEBIO, byte[] FAOECCHMGPJ, int IJLPKFECKFC, int LOKMFEIHLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61C9300", Offset = "0x61C8700", VA = "0x1861C9300")]
	private int KCEHIJLLPGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x61C9770", Offset = "0x61C8B70", VA = "0x1861C9770")]
	private void KLPODMOEEEO(IPEndPoint DDALIMJJHPK, OHMMOELPGAP GNAEGFFJAEH, NAADIMFFKDO EIKCDJOFKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61CA700", Offset = "0x61C9B00", VA = "0x1861CA700")]
	private void NEKENFKICMG(NJKCLFDPCAA HLOGFEOOFOM, IPEndPoint DDALIMJJHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61C7DA0", Offset = "0x61C71A0", VA = "0x1861C7DA0")]
	internal void FPOABHBNJHE(NJKCLFDPCAA HLOGFEOOFOM, FCPFDDPCNGP MDLLEGDNLAI, byte BGCAKPPJKAN, int CAFGBJCMDCC, OHMMOELPGAP MEGMOIJGBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61C7D30", Offset = "0x61C7130", VA = "0x1861C7D30")]
	public bool FMHCNCBOPAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61C7560", Offset = "0x61C6960", VA = "0x1861C7560")]
	public bool FMHCNCBOPAE(IPAddress CPGJCMBPADJ, IPAddress GMOHILHAEAI, int IMFOKHINEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61C74E0", Offset = "0x61C68E0", VA = "0x1861C74E0")]
	public bool FMHCNCBOPAE(int IMFOKHINEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61CCB00", Offset = "0x61CBF00", VA = "0x1861CCB00")]
	public void PJEGJIHBCGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61C66D0", Offset = "0x61C5AD0", VA = "0x1861C66D0")]
	public OHMMOELPGAP DBMCMKDGMLO(string CJGJMOGBHAJ, int IMFOKHINEEP, string OEOMDKHBDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61C65F0", Offset = "0x61C59F0", VA = "0x1861C65F0")]
	public OHMMOELPGAP DBMCMKDGMLO(string CJGJMOGBHAJ, int IMFOKHINEEP, ELECNCNEJHM HBAIILCJNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61C67B0", Offset = "0x61C5BB0", VA = "0x1861C67B0")]
	public OHMMOELPGAP DBMCMKDGMLO(IPEndPoint KDGMCPCFIID, ELECNCNEJHM HBAIILCJNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61C6DA0", Offset = "0x61C61A0", VA = "0x1861C6DA0")]
	public void DNCJCAMKJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61C6DB0", Offset = "0x61C61B0", VA = "0x1861C6DB0")]
	public void DNCJCAMKJIF(bool GFCMBLBIPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x61C6B80", Offset = "0x61C5F80", VA = "0x1861C6B80")]
	public void DGLAFGHCEAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61C6C80", Offset = "0x61C6080", VA = "0x1861C6C80")]
	public void DGLAFGHCEAI(byte[] AIKOCCMKKAE, int IJLPKFECKFC, int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61C8C10", Offset = "0x61C8010", VA = "0x1861C8C10")]
	public void IPFHIGIOGMG(OHMMOELPGAP NNCLGFMMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61C8DB0", Offset = "0x61C81B0", VA = "0x1861C8DB0")]
	public void IPFHIGIOGMG(OHMMOELPGAP NNCLGFMMJBP, byte[] AIKOCCMKKAE, int IJLPKFECKFC, int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61CCD00", Offset = "0x61CC100", VA = "0x1861CCD00", Slot = "4")]
	private IEnumerator<OHMMOELPGAP> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61CCD90", Offset = "0x61CC190", VA = "0x1861CCD90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61CBF80", Offset = "0x61CB380", VA = "0x1861CBF80")]
	private NJKCLFDPCAA NNOGPCHAHNN(NKNJAKGKOIP ECJEGOAKEPN, int IKJKAFPPDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61CBEA0", Offset = "0x61CB2A0", VA = "0x1861CBEA0")]
	private NJKCLFDPCAA NNOGPCHAHNN(NKNJAKGKOIP ECJEGOAKEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61CB4C0", Offset = "0x61CA8C0", VA = "0x1861CB4C0")]
	internal NJKCLFDPCAA NNIOMLNNLCA(int IKJKAFPPDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61C6390", Offset = "0x61C5790", VA = "0x1861C6390")]
	internal void CDHMAGHIEAB(NJKCLFDPCAA HLOGFEOOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x61CCE20", Offset = "0x61CC220", VA = "0x1861CCE20")]
	static BFMCHHNJFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xEBA790", Offset = "0xEB9B90", VA = "0x180EBA790")]
	private bool CADCNCOFEFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61C9660", Offset = "0x61C8A60", VA = "0x1861C9660")]
	private void KIJPDAOHIMK(IPEndPoint HJLFMCFCELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61C9C00", Offset = "0x61C9000", VA = "0x1861C9C00")]
	private void MAPJIIOFIGE(IPEndPoint HJLFMCFCELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61C61E0", Offset = "0x61C55E0", VA = "0x1861C61E0")]
	private bool AHMGBKNPBDC(SocketException DMFMNMKKLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61CA3D0", Offset = "0x61C97D0", VA = "0x1861CA3D0")]
	private void MMNOKDMDNLL(JCANIEADAHE LPLAOGMLDED, EndPoint EJAKPAEOHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x61C8780", Offset = "0x61C7B80", VA = "0x1861C8780")]
	private void HKMPENHOGOF(object NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x61C7580", Offset = "0x61C6980", VA = "0x1861C7580")]
	public bool FMHCNCBOPAE(IPAddress CPGJCMBPADJ, IPAddress GMOHILHAEAI, int IMFOKHINEEP, bool IEJGKOILBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61CA6A0", Offset = "0x61C9AA0", VA = "0x1861CA6A0")]
	internal int MPJHJHAPPIP(NJKCLFDPCAA HLOGFEOOFOM, IPEndPoint DDALIMJJHPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61CC670", Offset = "0x61CBA70", VA = "0x1861CC670")]
	internal int NOCGNCOCCML(NJKCLFDPCAA HLOGFEOOFOM, IPEndPoint DDALIMJJHPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61CC060", Offset = "0x61CB460", VA = "0x1861CC060")]
	internal int NOCGNCOCCML(byte[] MOKGCFCFCPE, int IJLPKFECKFC, int LOKMFEIHLAN, IPEndPoint DDALIMJJHPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61C72A0", Offset = "0x61C66A0", VA = "0x1861C72A0")]
	internal void EODPJFEEIHB(bool BGMFEFNEACM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum NKNJAKGKOIP : byte
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
internal sealed class NJKCLFDPCAA
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int HDJMLKHJENM;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] IGLHMPIFKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] IPMJCACOGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int GDNEEEAIONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object AMOAOJFAGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NJKCLFDPCAA NMKLPFBIAMC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NKNJAKGKOIP DIJOBJDPGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x61D6E30", Offset = "0x61D6230", VA = "0x1861D6E30")]
		get
		{
			return default(NKNJAKGKOIP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x61D7030", Offset = "0x61D6430", VA = "0x1861D7030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte FJJGMKFFODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x61D70B0", Offset = "0x61D64B0", VA = "0x1861D70B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x61D7270", Offset = "0x61D6670", VA = "0x1861D7270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort FHKEJNAFBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x61D6FD0", Offset = "0x61D63D0", VA = "0x1861D6FD0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x61D6D90", Offset = "0x61D6190", VA = "0x1861D6D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AELDDIPMJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x61D70E0", Offset = "0x61D64E0", VA = "0x1861D70E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte IIDHNMCOOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x61D6DD0", Offset = "0x61D61D0", VA = "0x1861D6DD0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x61D6E00", Offset = "0x61D6200", VA = "0x1861D6E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort ENNNEHHKKHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x61D7110", Offset = "0x61D6510", VA = "0x1861D7110")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61D7070", Offset = "0x61D6470", VA = "0x1861D7070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort FHACHBPMJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x61D72B0", Offset = "0x61D66B0", VA = "0x1861D72B0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x61D7310", Offset = "0x61D6710", VA = "0x1861D7310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort PONMIDJGKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x61D6D30", Offset = "0x61D6130", VA = "0x1861D6D30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x61D6F90", Offset = "0x61D6390", VA = "0x1861D6F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61D7350", Offset = "0x61D6750", VA = "0x1861D7350")]
	static NJKCLFDPCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61D6F60", Offset = "0x61D6360", VA = "0x1861D6F60")]
	public void HJKGEAECEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61D7720", Offset = "0x61D6B20", VA = "0x1861D7720")]
	public NJKCLFDPCAA(int IKJKAFPPDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61D7610", Offset = "0x61D6A10", VA = "0x1861D7610")]
	public NJKCLFDPCAA(NKNJAKGKOIP ECJEGOAKEPN, int IKJKAFPPDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61D7170", Offset = "0x61D6570", VA = "0x1861D7170")]
	public static int NKCOLHOMGFP(NKNJAKGKOIP ECJEGOAKEPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61D71E0", Offset = "0x61D65E0", VA = "0x1861D71E0")]
	public int NKCOLHOMGFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x61D6E60", Offset = "0x61D6260", VA = "0x1861D6E60")]
	public bool HCKJAKDJBDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum OHMELKJFGHE : byte
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
internal enum MHEAJOMBECD
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
internal enum DIGABBDOBEK
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum ENDJODHDMGB
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class OHMMOELPGAP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class PMLGCLGPBBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NJKCLFDPCAA[] LFOAPILDMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int LMDBGFCBLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int IECJCLPCBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte IIDHNMCOOJF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public PMLGCLGPBBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void IJLKJMDIPGL(ulong FHDGOMGDPOJ, int DOGOCKCAMDP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int HGJOEDCAOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int MIFCAAAPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int LLIFCLPICLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double BIJAKJEAKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int CNPGHKHEDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int OJOOLHNGDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int FEMOFBCNIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch NJDLGELBAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int DLNDAKHNKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long IDJKKIOLCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object BIGOKMBMIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal OHMMOELPGAP HHFMGPOFFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal OHMMOELPGAP FJIBFNIPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<NJKCLFDPCAA> PMPMFHKOJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<LGLOPPIOPBN> PHLOBIPEPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly LGLOPPIOPBN[] PHKMDIJMKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int KAEKJEEBGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int APCOPIHABOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool IPHPONLNJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int EDKFLEAHLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int KMEOLBBHLNP;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int EOFOPDICKOP = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int NIBBEHPFCKE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object GACEMGLDNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int AFLDJENGFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, PMLGCLGPBBE> KDEHPEFPGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> NHFMNLDLLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly NJKCLFDPCAA MGBFKELJKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int EKAJFAAMCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int BJAGNGEDGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint KAIEDNOJJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int IPJBKAOIOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int JNOEABCEPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long EOBOFFAOPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte DPJFCKKCDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private OHMELKJFGHE IDFPBLCNMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NJKCLFDPCAA JGJGDGOBHOO;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int JNKNGNBJMIL = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int OEEEDHKEMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly NJKCLFDPCAA BFKEKGICJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly NJKCLFDPCAA BIKHMGIMBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly NJKCLFDPCAA CIKFEDAPILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly NJKCLFDPCAA BLHIPGHJBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private AAIOHDMJCIH PNEDCMKFNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly BFMCHHNJFNN FCENEKBOHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int DMJALGAFDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object HCCHPKLKBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly NJGMAIEPLOP LHAKKIEKDIJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte KGFKJABNMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB7F890", Offset = "0xB7EC90", VA = "0x180B7F890")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x61D98B0", Offset = "0x61D8CB0", VA = "0x1861D98B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint MECEMOLAPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x907440", Offset = "0x906840", VA = "0x180907440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OHMELKJFGHE HEMOJOBAIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x161D080", Offset = "0x161C480", VA = "0x18161D080")]
		get
		{
			return default(OHMELKJFGHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long BNGKGKPOKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B2350", Offset = "0x8B1750", VA = "0x1808B2350")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JEPABKKLHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xFA5AE0", Offset = "0xFA4EE0", VA = "0x180FA5AE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x18B4ED0", Offset = "0x18B42D0", VA = "0x1818B4ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int JANBEPLFFME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x61DAB10", Offset = "0x61D9F10", VA = "0x1861DAB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HPLOCOGOOPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B9060", Offset = "0x8B8460", VA = "0x1808B9060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double KINJOCJPFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5A7CCD0", Offset = "0x5A7C0D0", VA = "0x185A7CCD0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IJLKJMDIPGL CHPPDODNCMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x61DAB20", Offset = "0x61D9F20", VA = "0x1861DAB20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x61DA020", Offset = "0x61D9420", VA = "0x1861DA020")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61DB840", Offset = "0x61DAC40", VA = "0x1861DB840")]
	internal OHMMOELPGAP(BFMCHHNJFNN NAMCBLOEDBE, IPEndPoint DDALIMJJHPK, int NKPCGMJMEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x61D9960", Offset = "0x61D8D60", VA = "0x1861D9960")]
	internal void IBEPKINPIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x61D84D0", Offset = "0x61D78D0", VA = "0x1861D84D0")]
	internal void BNEEKFMKELH(IPEndPoint LPPPONMMFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x61D80B0", Offset = "0x61D74B0", VA = "0x1861D80B0")]
	internal void BIFGFKECAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x61D9630", Offset = "0x61D8A30", VA = "0x1861D9630")]
	private void GDNBKEGAIAO(int HCPPKAMBPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x61DAAD0", Offset = "0x61D9ED0", VA = "0x1861DAAD0")]
	private void OEGBHKAGLNC(int MBBIOEKAGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x61D9700", Offset = "0x61D8B00", VA = "0x1861D9700")]
	private LGLOPPIOPBN HKJEECJHEAA(byte JJOEPDKNLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x61DB6B0", Offset = "0x61DAAB0", VA = "0x1861DB6B0")]
	internal OHMMOELPGAP(BFMCHHNJFNN NAMCBLOEDBE, IPEndPoint DDALIMJJHPK, int NKPCGMJMEIE, byte EAKGDKLGEAM, ELECNCNEJHM BPHKJOHFADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x61DB4D0", Offset = "0x61DA8D0", VA = "0x1861DB4D0")]
	internal OHMMOELPGAP(BFMCHHNJFNN NAMCBLOEDBE, NNNPGGBAIFF BCGNIJHEBIO, int NKPCGMJMEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x61D8500", Offset = "0x61D7900", VA = "0x1861D8500")]
	internal void CIFFHIEADCK(NAADIMFFKDO CKNOMOFDPEE, byte[] AIKOCCMKKAE, int IJLPKFECKFC, int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x61D9D00", Offset = "0x61D9100", VA = "0x1861D9D00")]
	internal bool KABDGAHDCFM(KLKCKLKDPCJ HLOGFEOOFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x61D9C90", Offset = "0x61D9090", VA = "0x1861D9C90")]
	public void JNPGEMLJJHB(byte[] AIKOCCMKKAE, int IJLPKFECKFC, int LOKMFEIHLAN, FCPFDDPCNGP ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x61D90D0", Offset = "0x61D84D0", VA = "0x1861D90D0")]
	private void GCJIBCHEAOC(byte[] AIKOCCMKKAE, int IJLPKFECKFC, int LOKMFEIHLAN, byte BGCAKPPJKAN, FCPFDDPCNGP DBICFGMKGIA, object JAGMJGLHONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x61D8ED0", Offset = "0x61D82D0", VA = "0x1861D8ED0")]
	public void EHLPAKNNHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x61D9D80", Offset = "0x61D9180", VA = "0x1861D9D80")]
	internal DIGABBDOBEK KHLIECPOJEG(NJKCLFDPCAA HLOGFEOOFOM)
	{
		return default(DIGABBDOBEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x61DA0D0", Offset = "0x61D94D0", VA = "0x1861DA0D0")]
	internal void OAHLBBHDHPF(LGLOPPIOPBN CCNBJCBHBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x61D9980", Offset = "0x61D8D80", VA = "0x1861D9980")]
	internal ENDJODHDMGB IEILJNJELGN(byte[] AIKOCCMKKAE, int IJLPKFECKFC, int LOKMFEIHLAN, bool MALABKOONDB)
	{
		return default(ENDJODHDMGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x61D9CC0", Offset = "0x61D90C0", VA = "0x1861D9CC0")]
	private void JOGAODBJKEN(int BJDNNOBPPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x61DA130", Offset = "0x61D9530", VA = "0x1861DA130")]
	internal void OCFJOAKFOMH(FCPFDDPCNGP MDLLEGDNLAI, NJKCLFDPCAA KKPMNJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61D7950", Offset = "0x61D6D50", VA = "0x1861D7950")]
	private void AFFMDNANAJF(NJKCLFDPCAA HLOGFEOOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x61D8140", Offset = "0x61D7540", VA = "0x1861D8140")]
	private void BLDIAGIBFFM(int KDDKBBMEFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x61D9E60", Offset = "0x61D9260", VA = "0x1861D9E60")]
	internal MHEAJOMBECD KLPODMOEEEO(NAADIMFFKDO EIKCDJOFKKO)
	{
		return default(MHEAJOMBECD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x61D8810", Offset = "0x61D7C10", VA = "0x1861D8810")]
	internal void CPPBEMKLIKA(NJKCLFDPCAA HLOGFEOOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x61D8F80", Offset = "0x61D8380", VA = "0x1861D8F80")]
	private void EJOFIIELDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x61D7EB0", Offset = "0x61D72B0", VA = "0x1861D7EB0")]
	internal void ALOLHOJOLFF(NJKCLFDPCAA HLOGFEOOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x61DABD0", Offset = "0x61D9FD0", VA = "0x1861DABD0")]
	internal void PPNDJIMKPLE(int KDDKBBMEFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61D8550", Offset = "0x61D7950", VA = "0x1861D8550")]
	internal void CKPJDJLELHM(NJKCLFDPCAA HLOGFEOOFOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class NJGMAIEPLOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long EKLNOJPNBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long GFHKOHOCNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long DIJFPKGMOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long MNCJECOEFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long LONNOCNMHNH;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long ENBGALPCHMD;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long FGMMJJIPIHD;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long DAHJBNCBEHO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long PFGJGIHPGFB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long ONIKFCJLKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long LAINPLKDDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long HNMNKMOOLEK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long OGEHNAPCDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x61D6620", Offset = "0x61D5A20", VA = "0x1861D6620")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long OHGJLCGMCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x61D6870", Offset = "0x61D5C70", VA = "0x1861D6870")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long BBLLBHALCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61D6920", Offset = "0x61D5D20", VA = "0x1861D6920")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long EIIENNHKMLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61D6910", Offset = "0x61D5D10", VA = "0x1861D6910")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long AFNLKIIPDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x61D6630", Offset = "0x61D5A30", VA = "0x1861D6630")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long DDHCOEJEHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61D67C0", Offset = "0x61D5BC0", VA = "0x1861D67C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long IIOOHMPOKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x61D68D0", Offset = "0x61D5CD0", VA = "0x1861D68D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long CLFPOJCJMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61D6830", Offset = "0x61D5C30", VA = "0x1861D6830")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private AAIOHDMJCIH HPMELKNHJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61D67B0", Offset = "0x61D5BB0", VA = "0x1861D67B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double CDLMDOJCIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61D6930", Offset = "0x61D5D30", VA = "0x1861D6930")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x61D6990", Offset = "0x61D5D90", VA = "0x1861D6990")]
	public void PGLAGHNEHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x61D67D0", Offset = "0x61D5BD0", VA = "0x1861D67D0")]
	public void LDDGLBEGABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x61D6880", Offset = "0x61D5C80", VA = "0x1861D6880")]
	public void NOACNEANPNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x61D65C0", Offset = "0x61D59C0", VA = "0x1861D65C0")]
	public void DFBAJLHEOFH(long EIKCNIEKABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x61D6560", Offset = "0x61D5960", VA = "0x1861D6560")]
	public void AENJMEPDKME(long HHDCLOMNGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x61D6750", Offset = "0x61D5B50", VA = "0x1861D6750")]
	public void FPNMBAKHGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x61D6640", Offset = "0x61D5A40", VA = "0x1861D6640")]
	public void FHCPKAGMHJA(long LHMPKIJMKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x61D69D0", Offset = "0x61D5DD0", VA = "0x1861D69D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x61D66B0", Offset = "0x61D5AB0", VA = "0x1861D66B0")]
	public void FLFEPKODPCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public NJGMAIEPLOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HPEMHMLMCNN
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> HPDHMPCALPK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x61D08C0", Offset = "0x61CFCC0", VA = "0x1861D08C0")]
	public static IPEndPoint MHBLDDINFPI(string PGEGOBACKGK, int IMFOKHINEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x61D06F0", Offset = "0x61CFAF0", VA = "0x1861D06F0")]
	public static IPAddress CHMAGCEFJBB(string PGEGOBACKGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x61D0660", Offset = "0x61CFA60", VA = "0x1861D0660")]
	public static IPAddress CHMAGCEFJBB(string PGEGOBACKGK, AddressFamily PFEGCEIAGDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x61D0630", Offset = "0x61CFA30", VA = "0x1861D0630")]
	internal static int AMFBPEPLOGL(int EEOJOFIJKKH, int APPGEEMEONO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2E7CC60", Offset = "0x2E7C060", VA = "0x182E7CC60")]
	internal static T[] GJFMGGAMNPL<T>(int HMELIAGANNM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LIOADIDGHBL : LGLOPPIOPBN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct HGHGPDFBDJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private NJKCLFDPCAA AECLIJMCEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long FAHMFKPBPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool NPAJMDJMFAF;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61D0590", Offset = "0x61CF990", VA = "0x1861D0590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61D0520", Offset = "0x61CF920", VA = "0x1861D0520")]
		public void IPNPHEKPPLJ(NJKCLFDPCAA HLOGFEOOFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x61D04B0", Offset = "0x61CF8B0", VA = "0x1861D04B0")]
		public bool DMOPAOEAFDP(long PJEMIDEDIMJ, OHMMOELPGAP NNCLGFMMJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x61D0540", Offset = "0x61CF940", VA = "0x1861D0540")]
		public bool KMNEPMPOIBK(OHMMOELPGAP NNCLGFMMJBP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly NJKCLFDPCAA EKADAPLNCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly HGHGPDFBDJN[] GENGHLCPDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly NJKCLFDPCAA[] GIEEAJDIACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] DCHJCHKIFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int JIMKEOFIIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int BKGDKJBBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int HONPNHHBMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int HHAEHMNCEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool NFFFDFLJMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly FCPFDDPCNGP MJBPKHIEOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool PADKBMEBJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int OHHOFNOJJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte NKNGCBFKAPL;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x61D2E90", Offset = "0x61D2290", VA = "0x1861D2E90")]
	public LIOADIDGHBL(OHMMOELPGAP NNCLGFMMJBP, bool KKHHKIBNKIH, byte NKPCGMJMEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x61D2AD0", Offset = "0x61D1ED0", VA = "0x1861D2AD0")]
	private void PILEIEEFCED(NJKCLFDPCAA HLOGFEOOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x61D2600", Offset = "0x61D1A00", VA = "0x1861D2600", Slot = "4")]
	protected override bool PEGGPOCMGAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x61D1FA0", Offset = "0x61D13A0", VA = "0x1861D1FA0", Slot = "5")]
	public override bool CPPBEMKLIKA(NJKCLFDPCAA HLOGFEOOFOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BMGCJANMLMH : LGLOPPIOPBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int IDDBJLNEPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort BKGDKJBBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool CEALDBIGCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NJKCLFDPCAA HLIHILJHHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly NJKCLFDPCAA FLNCLGFKBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool IMEIOONIBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte NKNGCBFKAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long COJKENKFAJM;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x61CDCD0", Offset = "0x61CD0D0", VA = "0x1861CDCD0")]
	public BMGCJANMLMH(OHMMOELPGAP NNCLGFMMJBP, bool EJJDJJMKJLK, byte NKPCGMJMEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x61CD810", Offset = "0x61CCC10", VA = "0x1861CD810", Slot = "4")]
	protected override bool PEGGPOCMGAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x61CD530", Offset = "0x61CC930", VA = "0x1861CD530", Slot = "5")]
	public override bool CPPBEMKLIKA(NJKCLFDPCAA HLOGFEOOFOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OJCHPDFMOJK
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct JONNEIPDOBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong JIIGGPPLMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double FFHEJJBFPHB;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct LAJDBCEKMPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int CGKGIDOBLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float JMBFFEGBENA;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x61C4D50", Offset = "0x61C4150", VA = "0x1861C4D50")]
	private static void IKIHFDJDKJA(byte[] PCJDGFHBJBI, int OLMEFNCLGNG, ulong AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x61DBC90", Offset = "0x61DB090", VA = "0x1861DBC90")]
	private static void IKIHFDJDKJA(byte[] PCJDGFHBJBI, int OLMEFNCLGNG, int AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x61DBD00", Offset = "0x61DB100", VA = "0x1861DBD00")]
	public static void IKIHFDJDKJA(byte[] PCJDGFHBJBI, int OLMEFNCLGNG, short AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x61DBDD0", Offset = "0x61DB1D0", VA = "0x1861DBDD0")]
	public static void JADLKCBGJNB(byte[] FAHBHOHHIKE, int PGAHHGFJKBL, double EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61DBD40", Offset = "0x61DB140", VA = "0x1861DBD40")]
	public static void JADLKCBGJNB(byte[] FAHBHOHHIKE, int PGAHHGFJKBL, float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x61DBD00", Offset = "0x61DB100", VA = "0x1861DBD00")]
	public static void JADLKCBGJNB(byte[] FAHBHOHHIKE, int PGAHHGFJKBL, short EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61DBD00", Offset = "0x61DB100", VA = "0x1861DBD00")]
	public static void JADLKCBGJNB(byte[] FAHBHOHHIKE, int PGAHHGFJKBL, ushort EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x61DBC90", Offset = "0x61DB090", VA = "0x1861DBC90")]
	public static void JADLKCBGJNB(byte[] FAHBHOHHIKE, int PGAHHGFJKBL, int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x61DBC90", Offset = "0x61DB090", VA = "0x1861DBC90")]
	public static void JADLKCBGJNB(byte[] FAHBHOHHIKE, int PGAHHGFJKBL, uint EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x61DBDC0", Offset = "0x61DB1C0", VA = "0x1861DBDC0")]
	public static void JADLKCBGJNB(byte[] FAHBHOHHIKE, int PGAHHGFJKBL, long EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x61DBDC0", Offset = "0x61DB1C0", VA = "0x1861DBDC0")]
	public static void JADLKCBGJNB(byte[] FAHBHOHHIKE, int PGAHHGFJKBL, ulong EEPLCHCGAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MLGLHECOPLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] BLMNPNBLJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int ELIPDFFNOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int JLDCDDBHMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int JMFDEDCELIO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] IPMJCACOGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int PJCJGJELLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BFFKFMCEOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61D4B80", Offset = "0x61D3F80", VA = "0x1861D4B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool EDJCAGAPBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x212B680", Offset = "0x212AA80", VA = "0x18212B680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NHBFFGDBLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x61D5210", Offset = "0x61D4610", VA = "0x1861D5210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61D54F0", Offset = "0x61D48F0", VA = "0x1861D54F0")]
	public void PPNBOBKEHFH(byte[] GHEAAGKLGOO, int OLMEFNCLGNG, int OLDGBJEGGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public MLGLHECOPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61D5530", Offset = "0x61D4930", VA = "0x1861D5530")]
	public MLGLHECOPLA(byte[] GHEAAGKLGOO, int OLMEFNCLGNG, int OLDGBJEGGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61D53E0", Offset = "0x61D47E0", VA = "0x1861D53E0")]
	public IPEndPoint OFAFAJCDOMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x61D49A0", Offset = "0x61D3DA0", VA = "0x1861D49A0")]
	public byte AAPGLMMDPLH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x61D49A0", Offset = "0x61D3DA0", VA = "0x1861D49A0")]
	public sbyte BELBDHELBMF()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2F39DF0", Offset = "0x2F391F0", VA = "0x182F39DF0")]
	public T[] OMDGMCEFKCC<T>(ushort IKJKAFPPDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x61D5050", Offset = "0x61D4450", VA = "0x1861D5050")]
	public bool[] JBEHLAAINOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x61D4B90", Offset = "0x61D3F90", VA = "0x1861D4B90")]
	public ushort[] DOPGBHPPMMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61D49E0", Offset = "0x61D3DE0", VA = "0x1861D49E0")]
	public short[] AJBMKBJLOJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x61D51D0", Offset = "0x61D45D0", VA = "0x1861D51D0")]
	public int[] LPPEMINOAIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x61D4CF0", Offset = "0x61D40F0", VA = "0x1861D4CF0")]
	public uint[] GBBKDPPJKIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x61D5100", Offset = "0x61D4500", VA = "0x1861D5100")]
	public float[] JIEANFNLPLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x61D4B00", Offset = "0x61D3F00", VA = "0x1861D4B00")]
	public double[] DEKHACLNIAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x61D4F60", Offset = "0x61D4360", VA = "0x1861D4F60")]
	public long[] HGEFENCHGIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x61D4C40", Offset = "0x61D4040", VA = "0x1861D4C40")]
	public ulong[] EJNNPGJFHNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x61D5220", Offset = "0x61D4620", VA = "0x1861D5220")]
	public string[] NGHEHDIGOHA(int ODGNJFMAPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x61D5010", Offset = "0x61D4410", VA = "0x1861D5010")]
	public bool IGKEAHOPEFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x61D4930", Offset = "0x61D3D30", VA = "0x1861D4930")]
	public char AAJFOJILNCE()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x61D4930", Offset = "0x61D3D30", VA = "0x1861D4930")]
	public ushort PILBKLGDGPL()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x61D4A90", Offset = "0x61D3E90", VA = "0x1861D4A90")]
	public short BHBILBHOFAH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61D4FA0", Offset = "0x61D43A0", VA = "0x1861D4FA0")]
	public long HHBCOACCAGI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x61D4C80", Offset = "0x61D4080", VA = "0x1861D4C80")]
	public ulong EKFLEDDNPAH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x61D5370", Offset = "0x61D4770", VA = "0x1861D5370")]
	public int OCMGAPNIPHI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x61D5160", Offset = "0x61D4560", VA = "0x1861D5160")]
	public uint LHGFDHAPHOC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x61D4BD0", Offset = "0x61D3FD0", VA = "0x1861D4BD0")]
	public float EHMDBDCPHAN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x61D5090", Offset = "0x61D4490", VA = "0x1861D5090")]
	public double JFNHGLDAEFA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x61D4D30", Offset = "0x61D4130", VA = "0x1861D4D30")]
	public string GEJGPAHCLKD(int EOANMDEAJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x61D4A20", Offset = "0x61D3E20", VA = "0x1861D4A20")]
	public ArraySegment<byte> AJLNLLJIHAC(int HMELIAGANNM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x61D54B0", Offset = "0x61D48B0", VA = "0x1861D54B0")]
	public sbyte[] PNDEMMABKLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x61D4B40", Offset = "0x61D3F40", VA = "0x1861D4B40")]
	public byte[] DICIINDNLID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x61D5140", Offset = "0x61D4540", VA = "0x1861D5140")]
	public void KMNEPMPOIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ELECNCNEJHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] BLMNPNBLJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int ELIPDFFNOFM;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int OAGKEDLFJIB = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool OMOCKDJIEFM;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding JBNCKAGBDAG;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int JHJAEACHGOB = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] IBLBLMCENKH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] LMIMGNACAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x61D0390", Offset = "0x61CF790", VA = "0x1861D0390")]
	public ELECNCNEJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x61D02F0", Offset = "0x61CF6F0", VA = "0x1861D02F0")]
	public ELECNCNEJHM(bool NCIHCLBOEOJ, int INBNAGEDMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x61CFCD0", Offset = "0x61CF0D0", VA = "0x1861CFCD0")]
	public static ELECNCNEJHM FGCKJLAGPNH(string EEPLCHCGAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x61CF5D0", Offset = "0x61CE9D0", VA = "0x1861CF5D0")]
	public void AAKJPDNKIHG(int BAGLADIDOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x21A4850", Offset = "0x21A3C50", VA = "0x1821A4850")]
	public void PGLAGHNEHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x61CFBD0", Offset = "0x61CEFD0", VA = "0x1861CFBD0")]
	public void BKBIEKCNABH(float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x61CFC80", Offset = "0x61CF080", VA = "0x1861CFC80")]
	public void BKBIEKCNABH(double EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x61CF8A0", Offset = "0x61CECA0", VA = "0x1861CF8A0")]
	public void BKBIEKCNABH(long EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x61CF8A0", Offset = "0x61CECA0", VA = "0x1861CF8A0")]
	public void BKBIEKCNABH(ulong EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x61CF740", Offset = "0x61CEB40", VA = "0x1861CF740")]
	public void BKBIEKCNABH(int EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x61CF740", Offset = "0x61CEB40", VA = "0x1861CF740")]
	public void BKBIEKCNABH(uint EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x61CF830", Offset = "0x61CEC30", VA = "0x1861CF830")]
	public void BKBIEKCNABH(char EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x61CF830", Offset = "0x61CEC30", VA = "0x1861CF830")]
	public void BKBIEKCNABH(ushort EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x61CF830", Offset = "0x61CEC30", VA = "0x1861CF830")]
	public void BKBIEKCNABH(short EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x61CF6E0", Offset = "0x61CEAE0", VA = "0x1861CF6E0")]
	public void BKBIEKCNABH(sbyte EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x61CF6E0", Offset = "0x61CEAE0", VA = "0x1861CF6E0")]
	public void BKBIEKCNABH(byte EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x61CF670", Offset = "0x61CEA70", VA = "0x1861CF670")]
	public void BKBIEKCNABH(byte[] AIKOCCMKKAE, int OLMEFNCLGNG, int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x61CFD40", Offset = "0x61CF140", VA = "0x1861CFD40")]
	public void MIKCGIEFBOM(sbyte[] AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x61CFD40", Offset = "0x61CF140", VA = "0x1861CFD40")]
	public void MCBELLMILGL(byte[] AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x61CF7D0", Offset = "0x61CEBD0", VA = "0x1861CF7D0")]
	public void BKBIEKCNABH(bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x61D0190", Offset = "0x61CF590", VA = "0x1861D0190")]
	public void KOODHFBMNDJ(Array INLJCEHKFEE, int AJNGKJFBOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x61CFFD0", Offset = "0x61CF3D0", VA = "0x1861CFFD0")]
	public void KOODHFBMNDJ(float[] EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x61CFE20", Offset = "0x61CF220", VA = "0x1861CFE20")]
	public void KOODHFBMNDJ(double[] EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x61CFE20", Offset = "0x61CF220", VA = "0x1861CFE20")]
	public void KOODHFBMNDJ(long[] EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x61CFE20", Offset = "0x61CF220", VA = "0x1861CFE20")]
	public void KOODHFBMNDJ(ulong[] EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x61CFFD0", Offset = "0x61CF3D0", VA = "0x1861CFFD0")]
	public void KOODHFBMNDJ(int[] EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x61CFFD0", Offset = "0x61CF3D0", VA = "0x1861CFFD0")]
	public void KOODHFBMNDJ(uint[] EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x61D00B0", Offset = "0x61CF4B0", VA = "0x1861D00B0")]
	public void KOODHFBMNDJ(ushort[] EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x61D00B0", Offset = "0x61CF4B0", VA = "0x1861D00B0")]
	public void KOODHFBMNDJ(short[] EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x61CFD40", Offset = "0x61CF140", VA = "0x1861CFD40")]
	public void KOODHFBMNDJ(bool[] EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x61CFF00", Offset = "0x61CF300", VA = "0x1861CFF00")]
	public void KOODHFBMNDJ(string[] EEPLCHCGAIN, int AECLICAHMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x61CF8F0", Offset = "0x61CECF0", VA = "0x1861CF8F0")]
	public void BKBIEKCNABH(IPEndPoint ALJAJODDKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x61CFC70", Offset = "0x61CF070", VA = "0x1861CFC70")]
	public void BKBIEKCNABH(string EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x61CF9C0", Offset = "0x61CEDC0", VA = "0x1861CF9C0")]
	public void BKBIEKCNABH(string EEPLCHCGAIN, int EOANMDEAJKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JDDKGDPMGPG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class LJOFABMJFLL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong DMJALGAFDNO;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x45BA6F0", Offset = "0x45B9AF0", VA = "0x1845BA6F0")]
		static LJOFABMJFLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void PEOGLGCHKHM(MLGLHECOPLA GDCGEJPDKCM, object JAGMJGLHONC);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class ANMLALFFDLF<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public JDDKGDPMGPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public ANMLALFFDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x40D5320", Offset = "0x40D4720", VA = "0x1840D5320")]
		internal void KKEIODHCBMN(MLGLHECOPLA reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BLMNIHIPJKD<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public JDDKGDPMGPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BLMNIHIPJKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5280B80", Offset = "0x527FF80", VA = "0x185280B80")]
		internal void KKEIODHCBMN(MLGLHECOPLA reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly FCIANMPIPOB PHPPAAGPCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, PEOGLGCHKHM> MBNFIDDEKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly ELECNCNEJHM OJGECMFDFBC;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x61D0EA0", Offset = "0x61D02A0", VA = "0x1861D0EA0")]
	public JDDKGDPMGPG(int ODGNJFMAPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9170", Offset = "0x2BE8570", VA = "0x182BE9170", Slot = "4")]
	protected virtual ulong MDLDHGICKDD<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x61D0D20", Offset = "0x61D0120", VA = "0x1861D0D20", Slot = "5")]
	protected virtual PEOGLGCHKHM JNAPAAAIIIB(MLGLHECOPLA GDCGEJPDKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1630", Offset = "0x2EB0A30", VA = "0x182EB1630", Slot = "6")]
	protected virtual void HBIKOFPHMDG<T>(ELECNCNEJHM HOKCJMCABPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x61D0CA0", Offset = "0x61D00A0", VA = "0x1861D0CA0")]
	public void GDLHKGNDPBI(MLGLHECOPLA GDCGEJPDKCM, object JAGMJGLHONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1580", Offset = "0x2EB0980", VA = "0x182EB1580")]
	public void DPGCHBPIEOI<T>(ELECNCNEJHM HOKCJMCABPI, T HLOGFEOOFOM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x61D0E50", Offset = "0x61D0250", VA = "0x1861D0E50")]
	public void OLDBCPAHMBO(MLGLHECOPLA GDCGEJPDKCM, object JAGMJGLHONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1860", Offset = "0x2EB0C60", VA = "0x182EB1860")]
	public void OAKPJJKLGGH<T>(Action<T> PMJLOLPPOIN) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2EB16A0", Offset = "0x2EB0AA0", VA = "0x182EB16A0")]
	public void OAKPJJKLGGH<T, TUserData>(Action<T, TUserData> PMJLOLPPOIN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HMJPMJDCEIA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x61CF5C0", Offset = "0x61CE9C0", VA = "0x1861CF5C0")]
	public HMJPMJDCEIA(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class OBICOJGHGKG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x61D78F0", Offset = "0x61D6CF0", VA = "0x1861D78F0")]
	public OBICOJGHGKG(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FCIANMPIPOB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum LCCJOJNEMEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class CGOMOPDAIPI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public LCCJOJNEMEE NKDPEDOOFIH;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5881AE0", Offset = "0x5880EE0", VA = "0x185881AE0", Slot = "4")]
		public virtual void IPNPHEKPPLJ(MethodInfo BDIIFDDHNNJ, MethodInfo DMFHICNBFOJ, LCCJOJNEMEE DPOLEDLIAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void JJCNCNGFJAM(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void BLPNBGHGHBN(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		protected CGOMOPDAIPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class FLPFMNFLHFE<TClass, TProperty> : CGOMOPDAIPI<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> LKBAGFIDOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> LADEMJJFAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> KLJFBCJIGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> OJLLGGNGPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> JJBKMCCJBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> IFIHKDIPDFE;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3F586C0", Offset = "0x3F57AC0", VA = "0x183F586C0", Slot = "7")]
		public override void IACGNIHKAFG(TClass GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F579A0", Offset = "0x3F56DA0", VA = "0x183F579A0", Slot = "8")]
		public override void EBMCIMDLGDG(TClass GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E2F0", Offset = "0x3F5D6F0", VA = "0x183F5E2F0", Slot = "9")]
		public override void JJCNCNGFJAM(TClass GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3F571C0", Offset = "0x3F565C0", VA = "0x183F571C0", Slot = "10")]
		public override void BLPNBGHGHBN(TClass GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E530", Offset = "0x3F5D930", VA = "0x183F5E530")]
		protected TProperty[] NMKPIIICLOK(TClass GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E4B0", Offset = "0x3F5D8B0", VA = "0x183F5E4B0")]
		protected TProperty[] KGPGONLNPIM(TClass GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B670", Offset = "0x3F5AA70", VA = "0x183F5B670", Slot = "4")]
		public override void IPNPHEKPPLJ(MethodInfo BDIIFDDHNNJ, MethodInfo DMFHICNBFOJ, LCCJOJNEMEE DPOLEDLIAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E640", Offset = "0x3F5DA40", VA = "0x183F5E640")]
		protected FLPFMNFLHFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class ONNDLBMLMMC<TClass, TProperty> : FLPFMNFLHFE<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void KLAFEAIKJNK(MLGLHECOPLA BHJLLDMOPFC, [Out] TProperty CLBFKLGDOCF);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void KNFCFHEEMGM(ELECNCNEJHM PNJGKAECJEF, TProperty CLBFKLGDOCF);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4A1C0C0", Offset = "0x4A1B4C0", VA = "0x184A1C0C0", Slot = "5")]
		public override void OKBDMFOHPEL(TClass GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4A1BC00", Offset = "0x4A1B000", VA = "0x184A1BC00", Slot = "6")]
		public override void DPGCHBPIEOI(TClass GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4A1BEA0", Offset = "0x4A1B2A0", VA = "0x184A1BEA0", Slot = "7")]
		public override void IACGNIHKAFG(TClass GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4A1BD20", Offset = "0x4A1B120", VA = "0x184A1BD20", Slot = "8")]
		public override void EBMCIMDLGDG(TClass GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x426C960", Offset = "0x426BD60", VA = "0x18426C960")]
		protected ONNDLBMLMMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class LFPIEICNGJD<T> : FLPFMNFLHFE<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x459FC60", Offset = "0x459F060", VA = "0x18459FC60", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA100", Offset = "0x3BA9500", VA = "0x183BAA100", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x459FBE0", Offset = "0x459EFE0", VA = "0x18459FBE0", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA170", Offset = "0x3BA9570", VA = "0x183BAA170", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public LFPIEICNGJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class EMLMOOKOHMG<T> : FLPFMNFLHFE<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA260", Offset = "0x3BA9660", VA = "0x183BAA260", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA100", Offset = "0x3BA9500", VA = "0x183BAA100", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA1E0", Offset = "0x3BA95E0", VA = "0x183BAA1E0", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA170", Offset = "0x3BA9570", VA = "0x183BAA170", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public EMLMOOKOHMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class CONABBFIOOD<T> : FLPFMNFLHFE<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5A7C4F0", Offset = "0x5A7B8F0", VA = "0x185A7C4F0", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4808F10", Offset = "0x4808310", VA = "0x184808F10", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5A7C470", Offset = "0x5A7B870", VA = "0x185A7C470", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4808F80", Offset = "0x4808380", VA = "0x184808F80", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public CONABBFIOOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class MLAJHPMMKHI<T> : FLPFMNFLHFE<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4809070", Offset = "0x4808470", VA = "0x184809070", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4808F10", Offset = "0x4808310", VA = "0x184808F10", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4808FF0", Offset = "0x48083F0", VA = "0x184808FF0", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4808F80", Offset = "0x4808380", VA = "0x184808F80", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public MLAJHPMMKHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class IPKNAIAGKEC<T> : FLPFMNFLHFE<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4267EB0", Offset = "0x42672B0", VA = "0x184267EB0", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4267DC0", Offset = "0x42671C0", VA = "0x184267DC0", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4267E30", Offset = "0x4267230", VA = "0x184267E30", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x40938F0", Offset = "0x4092CF0", VA = "0x1840938F0", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public IPKNAIAGKEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class PDBOBMHAEOE<T> : FLPFMNFLHFE<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4AD6A80", Offset = "0x4AD5E80", VA = "0x184AD6A80", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4267DC0", Offset = "0x42671C0", VA = "0x184267DC0", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4AD6A00", Offset = "0x4AD5E00", VA = "0x184AD6A00", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x40938F0", Offset = "0x4092CF0", VA = "0x1840938F0", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public PDBOBMHAEOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class MALOLHGOAJK<T> : FLPFMNFLHFE<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4175940", Offset = "0x4174D40", VA = "0x184175940", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4175850", Offset = "0x4174C50", VA = "0x184175850", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x47B2F80", Offset = "0x47B2380", VA = "0x1847B2F80", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x40B22A0", Offset = "0x40B16A0", VA = "0x1840B22A0", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public MALOLHGOAJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class HNOHCMLKDBH<T> : FLPFMNFLHFE<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4175940", Offset = "0x4174D40", VA = "0x184175940", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4175850", Offset = "0x4174C50", VA = "0x184175850", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x41758C0", Offset = "0x4174CC0", VA = "0x1841758C0", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x40B22A0", Offset = "0x40B16A0", VA = "0x1840B22A0", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public HNOHCMLKDBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class AAPPFKHFMMN<T> : FLPFMNFLHFE<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3FCACD0", Offset = "0x3FCA0D0", VA = "0x183FCACD0", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3FCABE0", Offset = "0x3FC9FE0", VA = "0x183FCABE0", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3FCAC50", Offset = "0x3FCA050", VA = "0x183FCAC50", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA170", Offset = "0x3BA9570", VA = "0x183BAA170", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public AAPPFKHFMMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class GGBAOJELPAO<T> : FLPFMNFLHFE<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x40939E0", Offset = "0x4092DE0", VA = "0x1840939E0", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4093880", Offset = "0x4092C80", VA = "0x184093880", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4093960", Offset = "0x4092D60", VA = "0x184093960", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x40938F0", Offset = "0x4092CF0", VA = "0x1840938F0", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public GGBAOJELPAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class GIKDAOPLPGJ<T> : FLPFMNFLHFE<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x40B2390", Offset = "0x40B1790", VA = "0x1840B2390", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x40B2230", Offset = "0x40B1630", VA = "0x1840B2230", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x40B2310", Offset = "0x40B1710", VA = "0x1840B2310", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x40B22A0", Offset = "0x40B16A0", VA = "0x1840B22A0", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D950", Offset = "0x3B5CD50", VA = "0x183B5D950")]
		public GIKDAOPLPGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class CCJAMOGKKDC<T> : ONNDLBMLMMC<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x548CE60", Offset = "0x548C260", VA = "0x18548CE60", Slot = "12")]
		protected override void KNFCFHEEMGM(ELECNCNEJHM PNJGKAECJEF, char CLBFKLGDOCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x548CE30", Offset = "0x548C230", VA = "0x18548CE30", Slot = "11")]
		protected override void KLAFEAIKJNK(MLGLHECOPLA BHJLLDMOPFC, [Out] char CLBFKLGDOCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B9D470", Offset = "0x3B9C870", VA = "0x183B9D470")]
		public CCJAMOGKKDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class BKCMCDPMOOF<T> : ONNDLBMLMMC<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5274550", Offset = "0x5273950", VA = "0x185274550", Slot = "12")]
		protected override void KNFCFHEEMGM(ELECNCNEJHM PNJGKAECJEF, IPEndPoint CLBFKLGDOCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5274510", Offset = "0x5273910", VA = "0x185274510", Slot = "11")]
		protected override void KLAFEAIKJNK(MLGLHECOPLA BHJLLDMOPFC, [Out] IPEndPoint CLBFKLGDOCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3B9D470", Offset = "0x3B9C870", VA = "0x183B9D470")]
		public BKCMCDPMOOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CGILHCODKAL<T> : FLPFMNFLHFE<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int MJDIBHLIADI;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5881670", Offset = "0x5880A70", VA = "0x185881670")]
		public CGILHCODKAL(int EOANMDEAJKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x58815F0", Offset = "0x58809F0", VA = "0x1858815F0", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5881470", Offset = "0x5880870", VA = "0x185881470", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5881570", Offset = "0x5880970", VA = "0x185881570", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x58814F0", Offset = "0x58808F0", VA = "0x1858814F0", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class HFFBMCFHBMM<T> : CGOMOPDAIPI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo DIJOBJDPGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type BCLGIKBKCOK;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4159AA0", Offset = "0x4158EA0", VA = "0x184159AA0")]
		public HFFBMCFHBMM(PropertyInfo ECJEGOAKEPN, Type PGGBCACLDOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x41599E0", Offset = "0x4158DE0", VA = "0x1841599E0", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4159810", Offset = "0x4158C10", VA = "0x184159810", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4159920", Offset = "0x4158D20", VA = "0x184159920", Slot = "7")]
		public override void IACGNIHKAFG(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x41598C0", Offset = "0x4158CC0", VA = "0x1841598C0", Slot = "8")]
		public override void EBMCIMDLGDG(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4159980", Offset = "0x4158D80", VA = "0x184159980", Slot = "9")]
		public override void JJCNCNGFJAM(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x41597B0", Offset = "0x4158BB0", VA = "0x1841597B0", Slot = "10")]
		public override void BLPNBGHGHBN(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class INONCFODKJH<T> : HFFBMCFHBMM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4090C80", Offset = "0x4090080", VA = "0x184090C80")]
		public INONCFODKJH(PropertyInfo ECJEGOAKEPN, Type PGGBCACLDOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x42611F0", Offset = "0x42605F0", VA = "0x1842611F0", Slot = "5")]
		public override void OKBDMFOHPEL(T GHPIMNJDLLO, MLGLHECOPLA BHJLLDMOPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4261140", Offset = "0x4260540", VA = "0x184261140", Slot = "6")]
		public override void DPGCHBPIEOI(T GHPIMNJDLLO, ELECNCNEJHM PNJGKAECJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class GFJOOLKOHFA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static GFJOOLKOHFA<T> GJPJBBHLIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly CGOMOPDAIPI<T>[] DJNHPOICPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int CIEPCJAFCKA;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4092C90", Offset = "0x4092090", VA = "0x184092C90")]
		public GFJOOLKOHFA(List<CGOMOPDAIPI<T>> DPHOOEPAFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4092B30", Offset = "0x4091F30", VA = "0x184092B30")]
		public void DPGCHBPIEOI(T FMAFBHGACNM, ELECNCNEJHM HOKCJMCABPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4092BE0", Offset = "0x4091FE0", VA = "0x184092BE0")]
		public void OKBDMFOHPEL(T FMAFBHGACNM, MLGLHECOPLA GDCGEJPDKCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class GKKPHFOEBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract CGOMOPDAIPI<T> CADKKGPFCDD<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private ELECNCNEJHM BLCEGBMEFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int DHBELAMHODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, GKKPHFOEBDJ> ALOIMGHHGPB;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x61D0410", Offset = "0x61CF810", VA = "0x1861D0410")]
	public FCIANMPIPOB(int ODGNJFMAPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D4E0", Offset = "0x2E2C8E0", VA = "0x182E2D4E0")]
	private GFJOOLKOHFA<T> KJDLIFJPKPO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2E2E600", Offset = "0x2E2DA00", VA = "0x182E2E600")]
	public void MHJHNBDIMHP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D3B0", Offset = "0x2E2C7B0", VA = "0x182E2D3B0")]
	public bool AJCCBGLJAMD<T>(MLGLHECOPLA GDCGEJPDKCM, T KDGMCPCFIID) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D450", Offset = "0x2E2C850", VA = "0x182E2D450")]
	public void IFDLICGNEEM<T>(ELECNCNEJHM HOKCJMCABPI, T FMAFBHGACNM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class AEFIFGGAPEI
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime MGHMEKICLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] MOJBFCJHECB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LBIINKECPEJ JLBLIMGILBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x61C5540", Offset = "0x61C4940", VA = "0x1861C5540")]
		get
		{
			return default(LBIINKECPEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int IGFJAOCCEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x61C4F90", Offset = "0x61C4390", VA = "0x1861C4F90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x61C5910", Offset = "0x61C4D10", VA = "0x1861C5910")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PIAGJPHDFLC JNCKMHILAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x61C4F60", Offset = "0x61C4360", VA = "0x1861C4F60")]
		get
		{
			return default(PIAGJPHDFLC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x61C5640", Offset = "0x61C4A40", VA = "0x1861C5640")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int FEDCKABFIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x61C5680", Offset = "0x61C4A80", VA = "0x1861C5680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint IEIEPOHOEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x61C5980", Offset = "0x61C4D80", VA = "0x1861C5980")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? IDOMMJELIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x61C5450", Offset = "0x61C4850", VA = "0x1861C5450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? IOLECBBJMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x61C5880", Offset = "0x61C4C80", VA = "0x1861C5880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? KFFMCMFDMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x61C5950", Offset = "0x61C4D50", VA = "0x1861C5950")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x61C56B0", Offset = "0x61C4AB0", VA = "0x1861C56B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? JPBIFGNKEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9220B0", Offset = "0x9214B0", VA = "0x1809220B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9221D0", Offset = "0x9215D0", VA = "0x1809221D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x61C5EC0", Offset = "0x61C52C0", VA = "0x1861C5EC0")]
	public AEFIFGGAPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x61C5E10", Offset = "0x61C5210", VA = "0x1861C5E10")]
	internal AEFIFGGAPEI(byte[] FAHBHOHHIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x61C4E40", Offset = "0x61C4240", VA = "0x1861C4E40")]
	public static AEFIFGGAPEI BNHLHDAMPMK(byte[] FAHBHOHHIKE, DateTime AKFJEHNPJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x61C5050", Offset = "0x61C4450", VA = "0x1861C5050")]
	internal void FDDKFFDGNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x61C5BD0", Offset = "0x61C4FD0", VA = "0x1861C5BD0")]
	private void OIKGKEEBKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x61C5250", Offset = "0x61C4650", VA = "0x1861C5250")]
	private DateTime? FMJNPLNPPHB(int OLMEFNCLGNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x61C5A00", Offset = "0x61C4E00", VA = "0x1861C5A00")]
	private void NBCCPBLDPPE(int OLMEFNCLGNG, DateTime? EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x61C5570", Offset = "0x61C4970", VA = "0x1861C5570")]
	private ulong IGDIOFHMGGB(int OLMEFNCLGNG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x61C5480", Offset = "0x61C4880", VA = "0x1861C5480")]
	private void HCCOMCNPBEI(int OLMEFNCLGNG, ulong EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x61C4FC0", Offset = "0x61C43C0", VA = "0x1861C4FC0")]
	private uint FAOAABJDOID(int OLMEFNCLGNG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6099F50", Offset = "0x6099350", VA = "0x186099F50")]
	private static uint LDBDMPPCOMA(uint LBEGFJJGJFP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x61C58B0", Offset = "0x61C4CB0", VA = "0x1861C58B0")]
	private static ulong LDBDMPPCOMA(ulong LBEGFJJGJFP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum LBIINKECPEJ
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
public enum PIAGJPHDFLC
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class IAKBKOEAMLG
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int PJHEJAIKPLB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int CJNNFBAFJBB = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int CBOIGPMBCEG = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint PKJNELAMGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int GDGLEOGKKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int NJGKLIEBNAM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CLJEPBJELPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x61D0BA0", Offset = "0x61CFFA0", VA = "0x1861D0BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x61D0BB0", Offset = "0x61CFFB0", VA = "0x1861D0BB0")]
	public bool JNPGEMLJJHB(JCANIEADAHE LPLAOGMLDED, int EBOOIPGOPKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class KBDBKMDPCFA : JCANIEADAHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket LPLAOGMLDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly BFMCHHNJFNN NAMCBLOEDBE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short LGMDCNLNHLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x61D1770", Offset = "0x61D0B70", VA = "0x1861D1770", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int CDCEDKBPIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x61D16D0", Offset = "0x61D0AD0", VA = "0x1861D16D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint MNGICPEDLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x61D1730", Offset = "0x61D0B30", VA = "0x1861D1730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily MBIODHEMNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4566A70", Offset = "0x4565E70", VA = "0x184566A70", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x61D1790", Offset = "0x61D0B90", VA = "0x1861D1790")]
	public KBDBKMDPCFA(AddressFamily PFEGCEIAGDF, BFMCHHNJFNN NAMCBLOEDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x61D1110", Offset = "0x61D0510", VA = "0x1861D1110", Slot = "8")]
	public bool DPKNHEAIJKF(IPEndPoint ALJAJODDKLH, DJHBGAEDAFO HELDCEHLGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x61D16F0", Offset = "0x61D0AF0", VA = "0x1861D16F0", Slot = "9")]
	public int LJJAPGLDDMA(byte[] PCJDGFHBJBI, int OLMEFNCLGNG, int IKJKAFPPDBP, IPEndPoint DDALIMJJHPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x61D1020", Offset = "0x61D0420", VA = "0x1861D1020", Slot = "10")]
	public int ACFMPKAPKOO(byte[] PCJDGFHBJBI, EndPoint FBJOHEGNBKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x61D1750", Offset = "0x61D0B50", VA = "0x1861D1750", Slot = "11")]
	public void PDILACFMDKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface JCANIEADAHE
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short LGMDCNLNHLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int CDCEDKBPIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint MNGICPEDLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily MBIODHEMNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DPKNHEAIJKF(IPEndPoint ALJAJODDKLH, DJHBGAEDAFO HELDCEHLGMK);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int LJJAPGLDDMA(byte[] PCJDGFHBJBI, int OLMEFNCLGNG, int IKJKAFPPDBP, IPEndPoint DDALIMJJHPK);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int ACFMPKAPKOO(byte[] PCJDGFHBJBI, EndPoint DDALIMJJHPK);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PDILACFMDKN();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct CBMKHJPHDIN : IEquatable<CBMKHJPHDIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long MLJHFJIMAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long CCCMMBNJNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long BJLKDGPGEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int JHLNDNIIBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int IHJGGIMNAJB;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x61CDE80", Offset = "0x61CD280", VA = "0x1861CDE80")]
	public CBMKHJPHDIN(byte[] CJGJMOGBHAJ, int BAFIGEAOBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8D1D10", Offset = "0x8D1110", VA = "0x1808D1D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x61CDD90", Offset = "0x61CD190", VA = "0x1861CDD90", Slot = "4")]
	public bool Equals(CBMKHJPHDIN KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x61CDDD0", Offset = "0x61CD1D0", VA = "0x1861CDDD0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class NCCEFDCOPPP : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] MJEACELCLAG;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class MBHMFEEIGPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int AGMJMNCMIMB;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
	protected MBHMFEEIGPJ(int MEIENNCJGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NMOKOBMIJOJ(IPEndPoint ALJAJODDKLH, byte[] AIKOCCMKKAE, int OLMEFNCLGNG, int LOKMFEIHLAN);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void IABLAFABBHI(IPEndPoint ALJAJODDKLH, byte[] AIKOCCMKKAE, int OLMEFNCLGNG, int LOKMFEIHLAN);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NBCINGFDKAO : MBHMFEEIGPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] OEOMDKHBDFI;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator OHMBANPMKOA;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2246560", Offset = "0x2245960", VA = "0x182246560")]
	public NBCINGFDKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x61D5A60", Offset = "0x61D4E60", VA = "0x1861D5A60")]
	public void DMMNGCCNLJJ(IPEndPoint ALJAJODDKLH, byte[] OEOMDKHBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x61D5C10", Offset = "0x61D5010", VA = "0x1861D5C10")]
	public void EGHBKJDCNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x61D6050", Offset = "0x61D5450", VA = "0x1861D6050", Slot = "4")]
	public override void NMOKOBMIJOJ(IPEndPoint ALJAJODDKLH, byte[] AIKOCCMKKAE, int OLMEFNCLGNG, int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x61D5CF0", Offset = "0x61D50F0", VA = "0x1861D5CF0", Slot = "5")]
	public override void IABLAFABBHI(IPEndPoint ALJAJODDKLH, byte[] AIKOCCMKKAE, int OLMEFNCLGNG, int LOKMFEIHLAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct CPLDMLDGKBF
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void LFOFIKOCCEI([NoAlias] byte* IAEIPCGBMMK, [NoAlias] byte* OEOMDKHBDFI, [NoAlias] byte* JHOCNIMBAHM, int LOKMFEIHLAN);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class OLIEINEMNOH
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr JDABNBBFOJL;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr NNNLJJJMNGE;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x61DC310", Offset = "0x61DB710", VA = "0x1861DC310")]
		[BurstDiscard]
		private static void PBLHKMKKOGN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x61DBF90", Offset = "0x61DB390", VA = "0x1861DBF90")]
		private static IntPtr NCBKMEMAKNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x61DBEF0", Offset = "0x61DB2F0", VA = "0x1861DBEF0")]
		public static void JCBDBOOMOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		public static void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x61DC0E0", Offset = "0x61DB4E0", VA = "0x1861DC0E0")]
		public unsafe static void NCEDFJEFMFN([NoAlias] byte* IAEIPCGBMMK, [NoAlias] byte* OEOMDKHBDFI, [NoAlias] byte* JHOCNIMBAHM, int LOKMFEIHLAN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint OEOMDKHBDFI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint JHOCNIMBAHM[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint IBEEMGGDNFB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint IGFNJDMCHJH[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint FLNNACPJOOC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint LBMLBNKDCBA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint FNAIEEAGABN[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint MLDDHCFMHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint KIFGAHEKIFP[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x61CE6F0", Offset = "0x61CDAF0", VA = "0x1861CE6F0")]
	private void PGLAGHNEHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x61CE660", Offset = "0x61CDA60", VA = "0x1861CE660")]
	private uint KEIKMGNDEAD(uint IFLBFOHFIEP, int AJPJBGAKCNB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x61C4C00", Offset = "0x61C4000", VA = "0x1861C4C00")]
	private void LPHHANKFFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x61C4960", Offset = "0x61C3D60", VA = "0x1861C4960")]
	private void HNKOBIDAIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x61C4B70", Offset = "0x61C3F70", VA = "0x1861C4B70")]
	private void JJHBPNJODLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x61C4860", Offset = "0x61C3C60", VA = "0x1861C4860")]
	private void EFKLMGKOKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x61CE690", Offset = "0x61CDA90", VA = "0x1861CE690")]
	private void LAAMPPDAILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x61CE240", Offset = "0x61CD640", VA = "0x1861CE240")]
	private unsafe void IDLILLOFKJO(byte* IAEIPCGBMMK, uint* OEOMDKHBDFI, uint* JHOCNIMBAHM, int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x61CE0E0", Offset = "0x61CD4E0", VA = "0x1861CE0E0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void FEFDPPEJJBI([NoAlias] byte* IAEIPCGBMMK, [NoAlias] byte* OEOMDKHBDFI, [NoAlias] byte* JHOCNIMBAHM, int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x61CE160", Offset = "0x61CD560", VA = "0x1861CE160")]
	public static void FEFDPPEJJBI(Span<byte> IAEIPCGBMMK, Span<byte> OEOMDKHBDFI, Span<byte> JHOCNIMBAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x61CDF70", Offset = "0x61CD370", VA = "0x1861CDF70")]
	public static void BBKFEBKBLPD(Span<byte> IAEIPCGBMMK, Span<byte> OEOMDKHBDFI, Span<byte> JHOCNIMBAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x61CE070", Offset = "0x61CD470", VA = "0x1861CE070")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DPJLIGHEJGE([NoAlias] byte* IAEIPCGBMMK, [NoAlias] byte* OEOMDKHBDFI, [NoAlias] byte* JHOCNIMBAHM, int LOKMFEIHLAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x61DC430", Offset = "0x61DB830", VA = "0x1861DC430")]
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
