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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LJAFOGKIINJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum MGNKFGKIKKI
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
		private NetworkManager OGJEKIBPJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool ILMIFNBLOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, OKPFJGLILJO> BBDDNABBFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DJHMOAKFJMI FMJPBHFOADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch CNOIAJCIDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] OKJAEHOEFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MGNKFGKIKKI JLAFJMEDCDL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int GEKLGDKEHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x76A06E0", Offset = "0x769F0E0", VA = "0x1876A06E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ELFDGGBDNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IDNKFOBCHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x76A06C0", Offset = "0x769F0C0", VA = "0x1876A06C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x769FCB0", Offset = "0x769E6B0", VA = "0x18769FCB0")]
		public void RecRoom_SetEncryptionInfo(ulong HEMLJILMKLI, byte[] HPFHOBCPNEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x769FC90", Offset = "0x769E690", VA = "0x18769FC90")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x769FB60", Offset = "0x769E560", VA = "0x18769FB60")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76A05C0", Offset = "0x769EFC0", VA = "0x1876A05C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x769FDD0", Offset = "0x769E7D0", VA = "0x18769FDD0", Slot = "6")]
		public override void Send(ulong KAJNACGJJJD, ArraySegment<byte> BLPDDGCLNPE, NetworkDelivery PENGKCJDFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x769FC50", Offset = "0x769E650", VA = "0x18769FC50", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong KAJNACGJJJD, [Out] ArraySegment<byte> IHHGLEDNONA, [Out] float GINCCCDHJKP)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x76A00C0", Offset = "0x769EAC0", VA = "0x1876A00C0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x76A03E0", Offset = "0x769EDE0", VA = "0x1876A03E0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x769F410", Offset = "0x769DE10", VA = "0x18769F410", Slot = "11")]
		public override void DisconnectRemoteClient(ulong KAJNACGJJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x769F320", Offset = "0x769DD20", VA = "0x18769F320", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x769F720", Offset = "0x769E120", VA = "0x18769F720", Slot = "13")]
		public override ulong GetCurrentRtt(ulong KAJNACGJJJD)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x76A0050", Offset = "0x769EA50", VA = "0x1876A0050", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x769F890", Offset = "0x769E290", VA = "0x18769F890", Slot = "15")]
		public override void Initialize([Optional] NetworkManager OGJEKIBPJFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x769F650", Offset = "0x769E050", VA = "0x18769F650")]
		private KOABPJNJFKJ FMKAFNNIIFB(NetworkDelivery DGNODDPLLPC)
		{
			return default(KOABPJNJFKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x769FAA0", Offset = "0x769E4A0", VA = "0x18769FAA0", Slot = "16")]
		private void MLAAKOMBGCG(OKPFJGLILJO KCMNHDPHHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x769F7C0", Offset = "0x769E1C0", VA = "0x18769F7C0", Slot = "17")]
		private void ICHAFGOFCBL(OKPFJGLILJO KCMNHDPHHON, DMCPHPGNGKC GGKGMOKEEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "18")]
		private void CGNCKFFNIFC(IPEndPoint DNGINKCMEFD, SocketError EHFDAHMENHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x769F110", Offset = "0x769DB10", VA = "0x18769F110", Slot = "19")]
		private void BBELKHPMFLL(OKPFJGLILJO KCMNHDPHHON, NEEEHIOGPAB DIKMKPGIBMB, byte FDNDBIPMJIG, KOABPJNJFKJ PBGHCGIKOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x769F520", Offset = "0x769DF20", VA = "0x18769F520")]
		private void EBFMPGFCJMJ(int BCAJFCGHDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "20")]
		private void HIPFDHOCCAM(IPEndPoint FIAGCGPPMLJ, NEEEHIOGPAB DIKMKPGIBMB, JFABGKGMKOI KBDOPBEDCNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "21")]
		private void LENCFIJJGFC(OKPFJGLILJO KCMNHDPHHON, int MIJFOALHIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x769F0B0", Offset = "0x769DAB0", VA = "0x18769F0B0", Slot = "22")]
		private void AMNAACDKJJG(IACEHDGCLFN KGHMNJMLIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x769F620", Offset = "0x769E020", VA = "0x18769F620")]
		private ulong ELBBENOLOOB(OKPFJGLILJO KCMNHDPHHON)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x769F600", Offset = "0x769E000", VA = "0x18769F600")]
		private ulong ELBBENOLOOB(ulong KAJNACGJJJD)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x769F090", Offset = "0x769DA90", VA = "0x18769F090")]
		private static int AFOBIHMDPBC(float JHMKMDEDCJN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x76A05E0", Offset = "0x769EFE0", VA = "0x1876A05E0")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x769F060", Offset = "0x769DA60", VA = "0x18769F060")]
		[CompilerGenerated]
		private void BNAOHANNLCK(ulong ILBGFMOANMC, int CIKDINHKCED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x769F060", Offset = "0x769DA60", VA = "0x18769F060")]
		[CompilerGenerated]
		private void ABELFBJKLGN(ulong ILBGFMOANMC, int CIKDINHKCED)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class MHAPMNKJMBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly OKPFJGLILJO NFHPPNLFDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<IEDPMPBOGBC> AHJLPJAGLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int EGFACPFIAIO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PFCFCCDDJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x76A0990", Offset = "0x769F390", VA = "0x1876A0990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76A09E0", Offset = "0x769F3E0", VA = "0x1876A09E0")]
	protected MHAPMNKJMBG(OKPFJGLILJO KCMNHDPHHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x76A0930", Offset = "0x769F330", VA = "0x1876A0930")]
	public void HOLOEGAMPNH(IEDPMPBOGBC FCGCBCBMMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76A08B0", Offset = "0x769F2B0", VA = "0x1876A08B0")]
	protected void GJABIJICNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76A0870", Offset = "0x769F270", VA = "0x1876A0870")]
	public bool DCBPIGCDPFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool GEPGCCJALCK();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool JOAPHEIMCIF(IEDPMPBOGBC FCGCBCBMMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum PIFKJJHHNEL
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
public class IACEHDGCLFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly DJHMOAKFJMI FKLFJOIEFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int FLBOGFCOOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal LJMBCGINBKG OILDFJJGAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint OPEALJCBFCM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal PIFKJJHHNEL ECLPEGKCLEL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
		[CompilerGenerated]
		get
		{
			return default(PIFKJJHHNEL);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x769B7A0", Offset = "0x769A1A0", VA = "0x18769B7A0")]
	internal void CHNKFJLHCLO(LJMBCGINBKG CFCOMMNNNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x769B800", Offset = "0x769A200", VA = "0x18769B800")]
	private bool KNIFHOGBMLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x769B890", Offset = "0x769A290", VA = "0x18769B890")]
	internal IACEHDGCLFN(IPEndPoint FIAGCGPPMLJ, LJMBCGINBKG LLPDPPGMBOG, DJHMOAKFJMI MBFPBKDOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x769B830", Offset = "0x769A230", VA = "0x18769B830")]
	public OKPFJGLILJO LLEHAKDEJOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JFABGKGMKOI
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum IONFBFHBNLJ
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
public struct DMCPHPGNGKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public IONFBFHBNLJ IOLDCNDGIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError DMGLMIICJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NEEEHIOGPAB LKBMEKFHFFN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LJAFOGKIINJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBGLCIIEIHJ(OKPFJGLILJO KCMNHDPHHON);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GACDOJOLGDL(OKPFJGLILJO KCMNHDPHHON, DMCPHPGNGKC GGKGMOKEEND);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFEOCMMOMPI(IPEndPoint DNGINKCMEFD, SocketError EHFDAHMENHG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDEPODADJMF(OKPFJGLILJO KCMNHDPHHON, NEEEHIOGPAB DIKMKPGIBMB, byte FDNDBIPMJIG, KOABPJNJFKJ PBGHCGIKOEB);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHAEDOFNJKB(IPEndPoint FIAGCGPPMLJ, NEEEHIOGPAB DIKMKPGIBMB, JFABGKGMKOI KBDOPBEDCNH);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EMKLPNKFIBG(OKPFJGLILJO KCMNHDPHHON, int MIJFOALHIGK);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMFGPMBHOGJ(IACEHDGCLFN KGHMNJMLIBE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JLPEKPKMEDJ
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNGELNMKGLL(OKPFJGLILJO KCMNHDPHHON, object PNNAGAOBHKH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DMOMACCGBFB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEKNNNPOCAM(BPCCGCDOJEK FCGCBCBMMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DLHHFBBFNMH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJHMFJPEONC(OKPFJGLILJO KCMNHDPHHON, IPEndPoint FMEEAMICAHM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LJMBCGINBKG
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int ILGIHGDBMCK = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long KLOGGEFDDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte HPEAKFKLBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] KEGDJBBGFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IMGBCLHPFOC AMLFHELBNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int GLMCOHCNGNK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x769EFF0", Offset = "0x769D9F0", VA = "0x18769EFF0")]
	private LJMBCGINBKG(long NHNGDEMCGNN, byte BJNMCKLIHBE, int EFILDLEHGNL, byte[] LCFCMLMFMJP, IMGBCLHPFOC BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x769EF90", Offset = "0x769D990", VA = "0x18769EF90")]
	public static int ODBKANPGANL(IEDPMPBOGBC FCGCBCBMMCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x769EB90", Offset = "0x769D590", VA = "0x18769EB90")]
	public static LJMBCGINBKG BHIIOHBPAAO(IEDPMPBOGBC FCGCBCBMMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x769EDB0", Offset = "0x769D7B0", VA = "0x18769EDB0")]
	public static IEDPMPBOGBC CDKCMLHBHKI(BCFDIDMCMBH MJEKPGHLKLF, SocketAddress ADLADBINNFO, long MKLOLEBJPKC, int EFILDLEHGNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class HLOKAFODDHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long KLOGGEFDDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte HPEAKFKLBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int GLMCOHCNGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool DMCHFJHKDEI;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x769B750", Offset = "0x769A150", VA = "0x18769B750")]
	private HLOKAFODDHB(long NHNGDEMCGNN, byte BJNMCKLIHBE, int JMIFPKDDEJC, bool OCFKBFPGOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x769B410", Offset = "0x7699E10", VA = "0x18769B410")]
	public static HLOKAFODDHB BHIIOHBPAAO(IEDPMPBOGBC FCGCBCBMMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x769B560", Offset = "0x7699F60", VA = "0x18769B560")]
	public static IEDPMPBOGBC CDKCMLHBHKI(long MKLOLEBJPKC, byte HCJAGKJADPO, int HGNECOIHCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x769B650", Offset = "0x769A050", VA = "0x18769B650")]
	public static IEDPMPBOGBC GHECJDNOGMD(OKPFJGLILJO KCMNHDPHHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum NLFGHJPFKIB
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HAOGLKACFDC
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGDCLBNIBHJ(IPEndPoint DONBMFCKCBI, IPEndPoint FIAGCGPPMLJ, string MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPKKBMFPMDL(IPEndPoint OMLMCFBFNBA, NLFGHJPFKIB DGNODDPLLPC, string MFKHKDDANII);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class JNKLPCDJIEC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct EIOOJDKAFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint CKFAGKKHGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint OPEALJCBFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string EBOBALABOOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct MKHOMMMOGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint PNCBFIIIKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NLFGHJPFKIB EMHLKEMKMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string EBOBALABOOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class LONMIJOCGKC
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint PPFAEFNDLOP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string EBOBALABOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LONMIJOCGKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class ECHCJKPLODG
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint PPFAEFNDLOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint MEBFMKAMHFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string EBOBALABOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ECHCJKPLODG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class BNOOKAHIDFL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string EBOBALABOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NBLFEDLNAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB2B80", Offset = "0xAB1580", VA = "0x180AB2B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BNOOKAHIDFL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DJHMOAKFJMI HKLJBLHMCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<EIOOJDKAFFI> AOJGGHBGFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<MKHOMMMOGJP> AILAGIPFNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly IMGBCLHPFOC JAPLMPPFNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly BCFDIDMCMBH BPAFEDNKALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly HJCFMKEBGPM DNIJEJCBPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HAOGLKACFDC DBDFJBBAGEL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int PLFPIDPALCF = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool LGFHNLIMCBC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x769E740", Offset = "0x769D140", VA = "0x18769E740")]
	internal JNKLPCDJIEC(DJHMOAKFJMI CNGGNHCPPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x769E5C0", Offset = "0x769CFC0", VA = "0x18769E5C0")]
	internal void PCHPCFALAEL(IPEndPoint BKOGOBOJEFJ, IEDPMPBOGBC FCGCBCBMMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E2A050", Offset = "0x3E28A50", VA = "0x183E2A050")]
	private void DNKNDAIHBMF<T>(T FCGCBCBMMCB, IPEndPoint JFBLIPHGGPK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x769E2D0", Offset = "0x769CCD0", VA = "0x18769E2D0")]
	private void GGDCLBNIBHJ(LONMIJOCGKC BHJHMJLOOIL, IPEndPoint BKOGOBOJEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x769E460", Offset = "0x769CE60", VA = "0x18769E460")]
	private void LJDNEHKMKJE(ECHCJKPLODG BHJHMJLOOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x769E140", Offset = "0x769CB40", VA = "0x18769E140")]
	private void DNHKDBPNKCE(BNOOKAHIDFL BHJHMJLOOIL, IPEndPoint BKOGOBOJEFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum KOABPJNJFKJ : byte
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
public enum LIMHPEGGMHG : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JCJKDCGJEPN
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] KPCAAECLILI;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int EJEACFJOAML;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int KMBDHKDAGEA;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MCDEPNFABAF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x768E370", Offset = "0x768CD70", VA = "0x18768E370")]
	public MCDEPNFABAF(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AAJPMMGJFOP : MCDEPNFABAF
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x768E370", Offset = "0x768CD70", VA = "0x18768E370")]
	public AAJPMMGJFOP(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum HLNLNMKEKPN
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
public interface OCKEMMOCJJK
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHPPFELNOKN(HLNLNMKEKPN DNGOCJHAHHH, string KKIOLBHBACC, params object[] ALHCDLPBNNA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class JJBJLCCKKPB
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static OCKEMMOCJJK GKCBHFAPEFN;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object FAJFCHHJCIF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x769DE00", Offset = "0x769C800", VA = "0x18769DE00")]
	private static void HNEEIKPKIPE(HLNLNMKEKPN JPAMPADBIMG, string KKIOLBHBACC, params object[] ALHCDLPBNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x769DD40", Offset = "0x769C740", VA = "0x18769DD40")]
	internal static void CFLJIGGADFE(string KKIOLBHBACC, params object[] ALHCDLPBNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x769DDA0", Offset = "0x769C7A0", VA = "0x18769DDA0")]
	internal static void GPFIFJKLFOL(string KKIOLBHBACC, params object[] ALHCDLPBNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x769E030", Offset = "0x769CA30", VA = "0x18769E030")]
	internal static void IJLHFPBGBFE(string KKIOLBHBACC, params object[] ALHCDLPBNNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum PAIPMAJJOAK
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NEEEHIOGPAB : IMGBCLHPFOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private IEDPMPBOGBC OAEKLLEGINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly DJHMOAKFJMI ADBCJOOFGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly BFNINGIAAFP OCGBNLGIOOK;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76A0BA0", Offset = "0x769F5A0", VA = "0x1876A0BA0")]
	internal NEEEHIOGPAB(DJHMOAKFJMI KFMMGFEJHFC, BFNINGIAAFP BHNDPEOGHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x76A0B30", Offset = "0x769F530", VA = "0x1876A0B30")]
	internal void OCHFINBBLJK(IEDPMPBOGBC FCGCBCBMMCB, int MFOJNJCFBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x76A0AB0", Offset = "0x769F4B0", VA = "0x1876A0AB0")]
	internal void LAGGFKHJCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x76A0A80", Offset = "0x769F480", VA = "0x1876A0A80")]
	public void KGKCAFFMBLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class BFNINGIAAFP
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum KLDBAFDMKAD
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
	public BFNINGIAAFP BPADAMHNFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public KLDBAFDMKAD EMHLKEMKMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public OKPFJGLILJO NFHPPNLFDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint OPEALJCBFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object MJMBHIIJPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int MOPOLICHJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError IHAEEELDGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public IONFBFHBNLJ DPDMMCGILPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public IACEHDGCLFN JDPCFONIOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public KOABPJNJFKJ MAOEDPLICJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte MGOMPCMDAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly NEEEHIOGPAB BNDFLDDBCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x768F1D0", Offset = "0x768DBD0", VA = "0x18768F1D0")]
	public BFNINGIAAFP(DJHMOAKFJMI KFMMGFEJHFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DJHMOAKFJMI : IEnumerable<OKPFJGLILJO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class HAMLGEGNIED : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x769B020", Offset = "0x7699A20", VA = "0x18769B020", Slot = "4")]
		public bool Equals(IPEndPoint FKPKEFAKAOE, IPEndPoint KEEMKILMOML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4692600", Offset = "0x4691000", VA = "0x184692600", Slot = "5")]
		public int GetHashCode(IPEndPoint PMNHIPACJLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HAMLGEGNIED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct OBNNKDCHCAO : IEnumerator<OKPFJGLILJO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly OKPFJGLILJO JGNKPAMOOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private OKPFJGLILJO KLJOPGJMIBJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public OKPFJGLILJO IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB51470", Offset = "0xB4FE70", VA = "0x180B51470", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB51470", Offset = "0xB4FE70", VA = "0x180B51470", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D46120", Offset = "0x1D44B20", VA = "0x181D46120")]
		public OBNNKDCHCAO(OKPFJGLILJO BNAMGIMJGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x76A13F0", Offset = "0x769FDF0", VA = "0x1876A13F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x76A1440", Offset = "0x769FE40", VA = "0x1876A1440", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread FLKAOABFHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool LIAFANFBHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool BGDIJJGDKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private ELKPAHLKFLP MOFFDGHEPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent BNIEDEIDCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<BFNINGIAAFP> LBIICNFCBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<BFNINGIAAFP> NCOLDIFCIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private BFNINGIAAFP DAINMMLNGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly LJAFOGKIINJ OPLGOLNEMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly JLPEKPKMEDJ FDLBHACKKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly DMOMACCGBFB HEKELGJDNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly DLHHFBBFNMH BPANNBEIOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, OKPFJGLILJO> PEMPFLMAFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, IACEHDGCLFN> BEAPBOAKLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, BPHNNNGJPAF> IKBFAACNNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim OBAMOCEPJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private OKPFJGLILJO BDGNGJFOHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int GBGKINMIBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<OKPFJGLILJO> JABFEILBMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private OKPFJGLILJO[] NALPBNAHPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly EDIAFENCNIJ JHEAJBMCELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int FACBHFCJDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> OBILDBDIMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte LMOLJEPMMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object FPBMIHEOJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool FLGNDIHAGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool IEDHIPAAKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int LNCEPMNIAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int PIGKPLGBAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int FJABNKPJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int CAJHDCACPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool CHJGCBEGLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool FILKGJOGOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int PBCDAJCPPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int FBLIJLHJNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int PJIEDGGBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool LGFHNLIMCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool CHKGKCMCBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool MDAPJNMAFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool AFOKODFGIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int BKBEFPGLGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int AAHOFJKPHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool AJLCHAIEHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly PHBGEIDACGD AGCOBJOJHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool AOLCJDBDNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly JNKLPCDJIEC OAMFNAONLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool JLENIFDOLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public PAIPMAJJOAK FKNOGKNDCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int ELMMMHCEGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool CNDFBBACPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool IBPIPHEPECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool LDHHLMDNCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool BKNFNOKALFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IEDPMPBOGBC OAMAMAOOEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int HDGPBPGMJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object MLPFIIBNBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private IEDPMPBOGBC IMHBDENBMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int LFABJMPHOML;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int MKKEJHHEPPI = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int JAPIMACBLFP = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private GIGCJDNLLPE DHBPAMHBMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private GIGCJDNLLPE BIINIHELLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread MFBCCMNLPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread JDFHENLFKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint EOGEDLKCJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint JOLDFFHNPNI;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] AFCJHLFJLME;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] BPDGMAJAHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<OFIAICAFKOE, IPEndPoint> IKOHAALOKLC;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress MFBKAOMLKEP;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool PDPJCHICFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int CHGFCGNJGJB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GDGPOPAPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC31490", Offset = "0xC2FE90", VA = "0x180C31490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC32C60", Offset = "0xC31660", VA = "0x180C32C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int COMLBHKGEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1882E90", Offset = "0x1881890", VA = "0x181882E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x22FD6C0", Offset = "0x22FC0C0", VA = "0x1822FD6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte DGKKFLHIJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10E8B30", Offset = "0x10E7530", VA = "0x1810E8B30")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PNLFKAGJMCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x76966F0", Offset = "0x76950F0", VA = "0x1876966F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short FIPJHPDMIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7691F20", Offset = "0x7690920", VA = "0x187691F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OKPFJGLILJO.KBKGMGLBGBE NDOJOPOBFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7691A90", Offset = "0x7690490", VA = "0x187691A90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7691420", Offset = "0x768FE20", VA = "0x187691420")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7696890", Offset = "0x7695290", VA = "0x187696890")]
	public void MABFMHMAIIE(IPEndPoint DNGINKCMEFD, byte[] HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7697600", Offset = "0x7696000", VA = "0x187697600")]
	public void MNMCINGBPMC(IPEndPoint DNGINKCMEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7693E50", Offset = "0x7692850", VA = "0x187693E50")]
	private bool FHPMLOJOMGP(IPEndPoint DNGINKCMEFD, [Out] OKPFJGLILJO KCMNHDPHHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7691BE0", Offset = "0x76905E0", VA = "0x187691BE0")]
	private void DBFHOIENBCN(OKPFJGLILJO KCMNHDPHHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7691B80", Offset = "0x7690580", VA = "0x187691B80")]
	private void CKABGOCLLEO(OKPFJGLILJO KCMNHDPHHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x76914D0", Offset = "0x768FED0", VA = "0x1876914D0")]
	private void BFNPFHJFHMA(OKPFJGLILJO KCMNHDPHHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7698770", Offset = "0x7697170", VA = "0x187698770")]
	public DJHMOAKFJMI(LJAFOGKIINJ MBFPBKDOJPD, [Optional] EDIAFENCNIJ HEHJHKFIEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76952B0", Offset = "0x7693CB0", VA = "0x1876952B0")]
	internal void GMJOENGCJCF(OKPFJGLILJO FMLJCGNHFFB, int MIJFOALHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7694960", Offset = "0x7693360", VA = "0x187694960")]
	internal void GAEABLJAEJF(OKPFJGLILJO FMLJCGNHFFB, object PNNAGAOBHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7691B40", Offset = "0x7690540", VA = "0x187691B40")]
	internal void CJPEFIMLIIK(OKPFJGLILJO KCMNHDPHHON, IONFBFHBNLJ LJPPNNLHGCJ, SocketError IOPLMKLLBEF, IEDPMPBOGBC PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x76977D0", Offset = "0x76961D0", VA = "0x1876977D0")]
	private void NBPHODEPLHF(OKPFJGLILJO KCMNHDPHHON, IONFBFHBNLJ LJPPNNLHGCJ, SocketError IOPLMKLLBEF, bool KEJIJALNLAM, byte[] BLPDDGCLNPE, int NPCHJIPLCII, int MHMCOJIKNCI, IEDPMPBOGBC PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7691FE0", Offset = "0x76909E0", VA = "0x187691FE0")]
	private void DHJEGGBGIAN(BFNINGIAAFP.KLDBAFDMKAD DGNODDPLLPC, [Optional] OKPFJGLILJO KCMNHDPHHON, [Optional] IPEndPoint FIAGCGPPMLJ, SocketError NGDAMNDJLIJ = SocketError.Success, int MIJFOALHIGK = 0, IONFBFHBNLJ LPCNHKPFNJA = IONFBFHBNLJ.ConnectionFailed, [Optional] IACEHDGCLFN KBLDEONDJHL, KOABPJNJFKJ PBGHCGIKOEB = KOABPJNJFKJ.Unreliable, byte FDNDBIPMJIG = 0, [Optional] IEDPMPBOGBC AOHENOEGGON, [Optional] object PNNAGAOBHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x76941C0", Offset = "0x7692BC0", VA = "0x1876941C0")]
	private void FPBJHHIGEPM(BFNINGIAAFP BHNDPEOGHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7697BE0", Offset = "0x76965E0", VA = "0x187697BE0")]
	internal void NEDLGDLAANO(BFNINGIAAFP BHNDPEOGHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7693B00", Offset = "0x7692500", VA = "0x187693B00")]
	private void EPAEJPHBHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7698020", Offset = "0x7696A20", VA = "0x187698020")]
	private void OPBABHLFNFM(int MMFOBCLFABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7690E00", Offset = "0x768F800", VA = "0x187690E00")]
	internal OKPFJGLILJO AANGNENHELM(IACEHDGCLFN KGHMNJMLIBE, byte[] HEGNKJOLPAM, int NPCHJIPLCII, int AJDEGEPLAEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x76949B0", Offset = "0x76933B0", VA = "0x1876949B0")]
	private int GEDCPKOHPDC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7695840", Offset = "0x7694240", VA = "0x187695840")]
	private void HOGOOOEMONA(IPEndPoint FIAGCGPPMLJ, OKPFJGLILJO GNEIKKLLHLF, LJMBCGINBKG CHNIJCEIFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7692730", Offset = "0x7691130", VA = "0x187692730")]
	private void EMMFOOKJCEE(IEDPMPBOGBC FCGCBCBMMCB, IPEndPoint FIAGCGPPMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7695E70", Offset = "0x7694870", VA = "0x187695E70")]
	internal void IHDAKJANBMC(IEDPMPBOGBC FCGCBCBMMCB, KOABPJNJFKJ PECFHCNLPEO, byte FDNDBIPMJIG, int MFOJNJCFBEL, OKPFJGLILJO FMLJCGNHFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x76952A0", Offset = "0x7693CA0", VA = "0x1876952A0")]
	public bool GLFALCCJJDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7695280", Offset = "0x7693C80", VA = "0x187695280")]
	public bool GLFALCCJJDG(IPAddress FLGHCFCPKJF, IPAddress GJECNDIIELP, int CEMFFJBJJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7695200", Offset = "0x7693C00", VA = "0x187695200")]
	public bool GLFALCCJJDG(int CEMFFJBJJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7695300", Offset = "0x7693D00", VA = "0x187695300")]
	public void GOMEOJBBBAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7696230", Offset = "0x7694C30", VA = "0x187696230")]
	public OKPFJGLILJO IODAEJNKHNE(string MDKBLKNBANL, int CEMFFJBJJJG, string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7696150", Offset = "0x7694B50", VA = "0x187696150")]
	public OKPFJGLILJO IODAEJNKHNE(string MDKBLKNBANL, int CEMFFJBJJJG, BCFDIDMCMBH JMKMGNCEHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7696310", Offset = "0x7694D10", VA = "0x187696310")]
	public OKPFJGLILJO IODAEJNKHNE(IPEndPoint JFBLIPHGGPK, BCFDIDMCMBH JMKMGNCEHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76923C0", Offset = "0x7690DC0", VA = "0x1876923C0")]
	public void ECGOBBCGDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76923D0", Offset = "0x7690DD0", VA = "0x1876923D0")]
	public void ECGOBBCGDJE(bool GDJLJJJPIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7695CF0", Offset = "0x76946F0", VA = "0x187695CF0")]
	public void ICDHAGBAEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7695DA0", Offset = "0x76947A0", VA = "0x187695DA0")]
	public void ICDHAGBAEDH(byte[] BLPDDGCLNPE, int NPCHJIPLCII, int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7697790", Offset = "0x7696190", VA = "0x187697790")]
	public void NBPHODEPLHF(OKPFJGLILJO KCMNHDPHHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7697750", Offset = "0x7696150", VA = "0x187697750")]
	public void NBPHODEPLHF(OKPFJGLILJO KCMNHDPHHON, byte[] BLPDDGCLNPE, int NPCHJIPLCII, int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7698590", Offset = "0x7696F90", VA = "0x187698590", Slot = "4")]
	private IEnumerator<OKPFJGLILJO> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7698620", Offset = "0x7697020", VA = "0x187698620", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7696C10", Offset = "0x7695610", VA = "0x187696C10")]
	private IEDPMPBOGBC MLOLHKCGJCK(JJGNGGGGOLI ELEBIIGLBPL, int BCAJFCGHDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7696D00", Offset = "0x7695700", VA = "0x187696D00")]
	private IEDPMPBOGBC MLOLHKCGJCK(JJGNGGGGOLI ELEBIIGLBPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7698340", Offset = "0x7696D40", VA = "0x187698340")]
	internal IEDPMPBOGBC POFKDMGEIDE(int BCAJFCGHDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x76917C0", Offset = "0x76901C0", VA = "0x1876917C0")]
	internal void BKPDHMJOIOI(IEDPMPBOGBC FCGCBCBMMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x76986B0", Offset = "0x76970B0", VA = "0x1876986B0")]
	static DJHMOAKFJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xC31490", Offset = "0xC2FE90", VA = "0x180C31490")]
	private bool HEAIIMNKJNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7696710", Offset = "0x7695110", VA = "0x187696710")]
	private void LGLAIFHPDBK(IPEndPoint MENKDBLLABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7696AB0", Offset = "0x76954B0", VA = "0x187696AB0")]
	private void MJLFEIAOLPB(IPEndPoint MENKDBLLABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7697E70", Offset = "0x7696870", VA = "0x187697E70")]
	private bool OJALHPMEIJH(SocketException JOEMCJLBOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x76917A0", Offset = "0x76901A0", VA = "0x1876917A0")]
	private void BIMIIIALMMM(ELKPAHLKFLP CNGGNHCPPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7693EF0", Offset = "0x76928F0", VA = "0x187693EF0")]
	private void FIOFEAFCAPM(GIGCJDNLLPE CNGGNHCPPML, EndPoint MFGDFKIKGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x76954B0", Offset = "0x7693EB0", VA = "0x1876954B0")]
	private void HIMOHMMMPGP(object IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7694A30", Offset = "0x7693430", VA = "0x187694A30")]
	public bool GLFALCCJJDG(IPAddress FLGHCFCPKJF, IPAddress GJECNDIIELP, int CEMFFJBJJJG, bool HDICBFPPAGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7691A30", Offset = "0x7690430", VA = "0x187691A30")]
	internal int BPCFIMOIDGB(IEDPMPBOGBC FCGCBCBMMCB, IPEndPoint FIAGCGPPMLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7696DE0", Offset = "0x76957E0", VA = "0x187696DE0")]
	internal int MNAMBPEOFIA(IEDPMPBOGBC FCGCBCBMMCB, IPEndPoint FIAGCGPPMLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7696E20", Offset = "0x7695820", VA = "0x187696E20")]
	internal int MNAMBPEOFIA(byte[] JEBOHIALEMJ, int NPCHJIPLCII, int AJDEGEPLAEO, IPEndPoint FIAGCGPPMLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7697CF0", Offset = "0x76966F0", VA = "0x187697CF0")]
	internal void OGDKEJCEIBM(bool EEPPPLDPIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum JJGNGGGGOLI : byte
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
internal sealed class IEDPMPBOGBC
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int EJPBDDKECHE;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] PPDJEJBIBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] FNIOKBMKPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int BFHNMDFMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object MJMBHIIJPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public IEDPMPBOGBC BPADAMHNFHG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public JJGNGGGGOLI PPFHHPOBDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x769BB40", Offset = "0x769A540", VA = "0x18769BB40")]
		get
		{
			return default(JJGNGGGGOLI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x769BA60", Offset = "0x769A460", VA = "0x18769BA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte HPEAKFKLBBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x769BCC0", Offset = "0x769A6C0", VA = "0x18769BCC0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x769BE20", Offset = "0x769A820", VA = "0x18769BE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort JNFABFBEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x769BE60", Offset = "0x769A860", VA = "0x18769BE60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x769BAA0", Offset = "0x769A4A0", VA = "0x18769BAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GGNBIACLBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x769BEC0", Offset = "0x769A8C0", VA = "0x18769BEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte IBKGNENGKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x769BEF0", Offset = "0x769A8F0", VA = "0x18769BEF0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x769BB70", Offset = "0x769A570", VA = "0x18769BB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort CKPLJGBKAII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x769BC60", Offset = "0x769A660", VA = "0x18769BC60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x769BC20", Offset = "0x769A620", VA = "0x18769BC20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort NBFOPGFMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x769BAE0", Offset = "0x769A4E0", VA = "0x18769BAE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x769BBA0", Offset = "0x769A5A0", VA = "0x18769BBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort AOADNOHBMPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x769BA00", Offset = "0x769A400", VA = "0x18769BA00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x769BBE0", Offset = "0x769A5E0", VA = "0x18769BBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x769BF20", Offset = "0x769A920", VA = "0x18769BF20")]
	static IEDPMPBOGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x769BDF0", Offset = "0x769A7F0", VA = "0x18769BDF0")]
	public void LBKKBDPGCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x769C310", Offset = "0x769AD10", VA = "0x18769C310")]
	public IEDPMPBOGBC(int BCAJFCGHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x769C200", Offset = "0x769AC00", VA = "0x18769C200")]
	public IEDPMPBOGBC(JJGNGGGGOLI ELEBIIGLBPL, int BCAJFCGHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x769B900", Offset = "0x769A300", VA = "0x18769B900")]
	public static int AEGHLHDCPII(JJGNGGGGOLI ELEBIIGLBPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x769B970", Offset = "0x769A370", VA = "0x18769B970")]
	public int AEGHLHDCPII()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x769BCF0", Offset = "0x769A6F0", VA = "0x18769BCF0")]
	public bool KOAGOKFONIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum JNHFELIGEGK : byte
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
internal enum IMEPDCKEOAA
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
internal enum KACADEELFDB
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum DCPICHHFILC
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OKPFJGLILJO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class LGHLMCDLAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEDPMPBOGBC[] GBJABPLPCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int NFFEBJOIDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int OIIPLOKKLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte IBKGNENGKFA;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LGHLMCDLAFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void KBKGMGLBGBE(ulong ILBGFMOANMC, int CIKDINHKCED);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int DMMBPHICPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int HIIOFKDELEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int EMAJNLJBCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double EGMBDLKNAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int ENBDABGABBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int AGDHMDLBNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int LFKGJAKCADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch MGKPBLLLCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int CPNFFBMGAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long DOPJPFNFHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object LMFKFHNGKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal OKPFJGLILJO CLLBJNPENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal OKPFJGLILJO GJMPMFHFGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<IEDPMPBOGBC> OOHCHENCKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<MHAPMNKJMBG> IOKEENDFIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly MHAPMNKJMBG[] KDFLAIFOFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int GMONHKKCFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int DMFGHPBEEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool LPIIDBADKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int DAPBJEPABFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int ALBOBJBICIA;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int GPBGPDFGNDM = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int KBFPMDHHINI = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object KDLBPPGOBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int JNCAFFKEEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, LGHLMCDLAFF> JAOIAKNOOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> IPLEGICGHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly IEDPMPBOGBC JGDCGIAIBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int DLDKABJMMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int DNJEHCHJLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint MFGCDOGMIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int KFONGLNKAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int PKPDGKFIPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long OFBEECFLAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte MGMJHLIABFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JNHFELIGEGK PGBJPBNIGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private IEDPMPBOGBC NEICBHICADO;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int FCHHIPDIEML = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int OMLEGNEMDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly IEDPMPBOGBC EAMBBJHGLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly IEDPMPBOGBC OCGGBHMBKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly IEDPMPBOGBC JFJOAFPNPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly IEDPMPBOGBC KGHDEBPNGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private LIMHPEGGMHG DPNOGEECLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly DJHMOAKFJMI JNOAHKEMNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int BKICOPKGOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object BFCLHODIKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly PHBGEIDACGD AGCOBJOJHMG;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte EDILMCHFBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB79850", Offset = "0xB78250", VA = "0x180B79850")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x76A4F40", Offset = "0x76A3940", VA = "0x1876A4F40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint IPPKKJKECLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB795C0", Offset = "0xB77FC0", VA = "0x180B795C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public JNHFELIGEGK MJKPIIEIICB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB79630", Offset = "0xB78030", VA = "0x180B79630")]
		get
		{
			return default(JNHFELIGEGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long ACOBMCJKAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xAB94F0", Offset = "0xAB7EF0", VA = "0x180AB94F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int NLANPCIPFEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1882E90", Offset = "0x1881890", VA = "0x181882E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x22FD6C0", Offset = "0x22FC0C0", VA = "0x1822FD6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int OKGNNIMPDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x76A3C40", Offset = "0x76A2640", VA = "0x1876A3C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int KOMPLCECCKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double LDPODDFEICF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A99D10", Offset = "0x2A98710", VA = "0x182A99D10")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KBKGMGLBGBE NDOJOPOBFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F90", Offset = "0x76A0990", VA = "0x1876A1F90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x76A1EC0", Offset = "0x76A08C0", VA = "0x1876A1EC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x76A5470", Offset = "0x76A3E70", VA = "0x1876A5470")]
	internal OKPFJGLILJO(DJHMOAKFJMI BFFBDJAHOLH, IPEndPoint FIAGCGPPMLJ, int NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A0970", VA = "0x1876A1F70")]
	internal void BOIGPNAMCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x76A3C50", Offset = "0x76A2650", VA = "0x1876A3C50")]
	internal void IGICMGNMIGK(IPEndPoint OJCGNHCJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x76A53E0", Offset = "0x76A3DE0", VA = "0x1876A53E0")]
	internal void PFMEJEAMANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x76A2D80", Offset = "0x76A1780", VA = "0x1876A2D80")]
	private void EACHNDEJCKF(int IMKAMJOCKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x76A3A40", Offset = "0x76A2440", VA = "0x1876A3A40")]
	private void GIHHMCDJFID(int IFOPLHDAEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x76A4D10", Offset = "0x76A3710", VA = "0x1876A4D10")]
	public int LBKKPJOCLPF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x76A4E20", Offset = "0x76A3820", VA = "0x1876A4E20")]
	public int LBKKPJOCLPF(byte FDNDBIPMJIG, bool NONKLNCLEEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x76A4600", Offset = "0x76A3000", VA = "0x1876A4600")]
	private MHAPMNKJMBG KKMKHLBKFIB(byte HBDKIKFKCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x76A58D0", Offset = "0x76A42D0", VA = "0x1876A58D0")]
	internal OKPFJGLILJO(DJHMOAKFJMI BFFBDJAHOLH, IPEndPoint FIAGCGPPMLJ, int NMAIBBDGPCD, byte HCJAGKJADPO, BCFDIDMCMBH MJEKPGHLKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x76A5A60", Offset = "0x76A4460", VA = "0x1876A5A60")]
	internal OKPFJGLILJO(DJHMOAKFJMI BFFBDJAHOLH, IACEHDGCLFN KGHMNJMLIBE, int NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x76A3EB0", Offset = "0x76A28B0", VA = "0x1876A3EB0")]
	internal void JFAOAENLFFM(LJMBCGINBKG KPNGGMHKNOG, byte[] BLPDDGCLNPE, int NPCHJIPLCII, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x76A29C0", Offset = "0x76A13C0", VA = "0x1876A29C0")]
	internal bool DHFGIHPGJAH(HLOKAFODDHB FCGCBCBMMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x76A2D50", Offset = "0x76A1750", VA = "0x1876A2D50")]
	public void DNKNDAIHBMF(byte[] BLPDDGCLNPE, int NPCHJIPLCII, int AJDEGEPLAEO, KOABPJNJFKJ ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x76A18B0", Offset = "0x76A02B0", VA = "0x1876A18B0")]
	private void ABDBNJNLOGL(byte[] BLPDDGCLNPE, int NPCHJIPLCII, int AJDEGEPLAEO, byte FDNDBIPMJIG, KOABPJNJFKJ PBGHCGIKOEB, object PNNAGAOBHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x76A3060", Offset = "0x76A1A60", VA = "0x1876A3060")]
	public void FJIMPEDAFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x76A3C80", Offset = "0x76A2680", VA = "0x1876A3C80")]
	internal KACADEELFDB INBLDFNCION(IEDPMPBOGBC FCGCBCBMMCB)
	{
		return default(KACADEELFDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x76A5380", Offset = "0x76A3D80", VA = "0x1876A5380")]
	internal void OBOOMFENIED(MHAPMNKJMBG FLIDFJKDJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x76A2A40", Offset = "0x76A1440", VA = "0x1876A2A40")]
	internal DCPICHHFILC DNACAEELEFC(byte[] BLPDDGCLNPE, int NPCHJIPLCII, int AJDEGEPLAEO, bool KEJIJALNLAM)
	{
		return default(DCPICHHFILC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x76A45C0", Offset = "0x76A2FC0", VA = "0x1876A45C0")]
	private void KIOEOINHAOK(int OMCEADIPHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x76A30B0", Offset = "0x76A1AB0", VA = "0x1876A30B0")]
	internal void FMBJFGIFLND(KOABPJNJFKJ PECFHCNLPEO, IEDPMPBOGBC BNAMGIMJGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x76A47B0", Offset = "0x76A31B0", VA = "0x1876A47B0")]
	private void KOBIKJFJCLD(IEDPMPBOGBC FCGCBCBMMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x76A4FF0", Offset = "0x76A39F0", VA = "0x1876A4FF0")]
	private void MFJBHPIPFLL(int LHPALOIPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x76A3A80", Offset = "0x76A2480", VA = "0x1876A3A80")]
	internal IMEPDCKEOAA HOGOOOEMONA(LJMBCGINBKG CHNIJCEIFHL)
	{
		return default(IMEPDCKEOAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x76A3F00", Offset = "0x76A2900", VA = "0x1876A3F00")]
	internal void JOAPHEIMCIF(IEDPMPBOGBC FCGCBCBMMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x76A3D60", Offset = "0x76A2760", VA = "0x1876A3D60")]
	private void JAKMPNPKNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x76A2E50", Offset = "0x76A1850", VA = "0x1876A2E50")]
	internal void EFNFADLNPIA(IEDPMPBOGBC FCGCBCBMMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x76A2040", Offset = "0x76A0A40", VA = "0x1876A2040")]
	internal void DBIPLKHEHMB(int LHPALOIPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x76A2700", Offset = "0x76A1100", VA = "0x1876A2700")]
	internal void DEKCFMFABEL(IEDPMPBOGBC FCGCBCBMMCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class PHBGEIDACGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long ANKHNCLJBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long HHCPHCOBGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long GHDBIFIJBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long DIBEMCMOHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long NLAMEMFODFJ;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long ABGBILIAFEF;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long BLGKGGOFHAC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long OPHOICBAKMF;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long JJOAOPNAOKD;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long ILEPFONMHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long EFHIMHOEFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long PFGNCHLEGOK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long PAJNFCNAEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x76A5F70", Offset = "0x76A4970", VA = "0x1876A5F70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long KNCINENDMMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x76A5E50", Offset = "0x76A4850", VA = "0x1876A5E50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long PMNAJECIIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x76A5DA0", Offset = "0x76A47A0", VA = "0x1876A5DA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long AIPFNOPEGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x76A5E60", Offset = "0x76A4860", VA = "0x1876A5E60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long DHGGGILABDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x76A5C40", Offset = "0x76A4640", VA = "0x1876A5C40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long PEHMHGNAPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x76A5EB0", Offset = "0x76A48B0", VA = "0x1876A5EB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long IGBFHFLIIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x76A5E10", Offset = "0x76A4810", VA = "0x1876A5E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long CFAPLFFCMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x76A5E70", Offset = "0x76A4870", VA = "0x1876A5E70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private LIMHPEGGMHG CFFBBPHOLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1408920", Offset = "0x1407320", VA = "0x181408920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double JOHCHCNAGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x76A5DB0", Offset = "0x76A47B0", VA = "0x1876A5DB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x76A5F80", Offset = "0x76A4980", VA = "0x1876A5F80")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x76A5F10", Offset = "0x76A4910", VA = "0x1876A5F10")]
	public void MGJMJBOMOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x76A5EC0", Offset = "0x76A48C0", VA = "0x1876A5EC0")]
	public void LMKCIJLOLAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x76A6060", Offset = "0x76A4A60", VA = "0x1876A6060")]
	public void PPEJNDMBGAA(long KLLILGLHLKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x76A5CB0", Offset = "0x76A46B0", VA = "0x1876A5CB0")]
	public void CPGGLHCFLCN(long EEPLAMJGPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x76A5C50", Offset = "0x76A4650", VA = "0x1876A5C50")]
	public void BGDPDGJDPAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x76A5D20", Offset = "0x76A4720", VA = "0x1876A5D20")]
	public void DEEDCMJGOFK(long NHBLIILOIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x76A60D0", Offset = "0x76A4AD0", VA = "0x1876A60D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x76A5FC0", Offset = "0x76A49C0", VA = "0x1876A5FC0")]
	public void PAPOJPEPHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PHBGEIDACGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class BKCFCJEPFPM
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> HLABMGOOBBL;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x768F2A0", Offset = "0x768DCA0", VA = "0x18768F2A0")]
	public static IPEndPoint LPCKIMPGMJC(string AHFMAMJNPJK, int CEMFFJBJJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x768F580", Offset = "0x768DF80", VA = "0x18768F580")]
	public static IPAddress MHDJGFCJPCI(string AHFMAMJNPJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x768F4F0", Offset = "0x768DEF0", VA = "0x18768F4F0")]
	public static IPAddress MHDJGFCJPCI(string AHFMAMJNPJK, AddressFamily IBGGDKOPBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x768F270", Offset = "0x768DC70", VA = "0x18768F270")]
	internal static int CPEDCMBOKHH(int HNKACHCGHOD, int PIDIALJEEHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3B2D6A0", Offset = "0x3B2C0A0", VA = "0x183B2D6A0")]
	internal static T[] GECKJEHOMJJ<T>(int MHMCOJIKNCI) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class GFONBKDAIFD : MHAPMNKJMBG
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct CCJLNDABADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEDPMPBOGBC OAEKLLEGINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long CMONLHFNGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool IOEFOELBFEM;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7690D60", Offset = "0x768F760", VA = "0x187690D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7690D40", Offset = "0x768F740", VA = "0x187690D40")]
		public void LHEJPJMHOBO(IEDPMPBOGBC FCGCBCBMMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7690C80", Offset = "0x768F680", VA = "0x187690C80")]
		public bool CCCLFAIGGOM(long JODOCMCKKFN, OKPFJGLILJO KCMNHDPHHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7690CF0", Offset = "0x768F6F0", VA = "0x187690CF0")]
		public bool EMMOLKMNHIK(OKPFJGLILJO KCMNHDPHHON)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly IEDPMPBOGBC HMKDDMAHJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly CCJLNDABADF[] LFCADCCNDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly IEDPMPBOGBC[] POAJDDNGDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] ALFGGBGGKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int ANFEHKOBNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int LHIOCAOMPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int JFPPAPHBCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int NLKNKBJONKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool GJGEEJBAIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly KOABPJNJFKJ NADIHJJCDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool PPBBGJPIFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int AHDGAJEIIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte NFGFHJEGJDG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int ICIMEBEMKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x769AE40", Offset = "0x7699840", VA = "0x18769AE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x769AE50", Offset = "0x7699850", VA = "0x18769AE50")]
	public GFONBKDAIFD(OKPFJGLILJO KCMNHDPHHON, bool NONKLNCLEEG, byte NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7699F50", Offset = "0x7698950", VA = "0x187699F50")]
	private void EKJAHOIKAAG(IEDPMPBOGBC FCGCBCBMMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x769A310", Offset = "0x7698D10", VA = "0x18769A310", Slot = "4")]
	protected override bool GEPGCCJALCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x769A7E0", Offset = "0x76991E0", VA = "0x18769A7E0", Slot = "5")]
	public override bool JOAPHEIMCIF(IEDPMPBOGBC FCGCBCBMMCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class GBPGBFLGCPD : MHAPMNKJMBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int LFECLLCMOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort LHIOCAOMPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool LODNACKINLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private IEDPMPBOGBC LJMAPJJACAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly IEDPMPBOGBC KLKBBNENHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool AGBBPHOAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte NFGFHJEGJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long FLDIAFIAGKA;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7699E90", Offset = "0x7698890", VA = "0x187699E90")]
	public GBPGBFLGCPD(OKPFJGLILJO KCMNHDPHHON, bool MEDCIFFHKLC, byte NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x76996F0", Offset = "0x76980F0", VA = "0x1876996F0", Slot = "4")]
	protected override bool GEPGCCJALCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7699BB0", Offset = "0x76985B0", VA = "0x187699BB0", Slot = "5")]
	public override bool JOAPHEIMCIF(IEDPMPBOGBC FCGCBCBMMCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class IPLPMEALEFI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct HGOAMHMCBPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong HOIGFPFHONE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double FPHMLKOGNHM;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct FECIODLKFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int CBGIJCMJDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float DCNJGLCEFCE;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x768DE30", Offset = "0x768C830", VA = "0x18768DE30")]
	private static void DLKPGNNJPGK(byte[] FPGJFOLEKAK, int JBCPGNDLJHB, ulong BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x769CFF0", Offset = "0x769B9F0", VA = "0x18769CFF0")]
	private static void DLKPGNNJPGK(byte[] FPGJFOLEKAK, int JBCPGNDLJHB, int BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x769D110", Offset = "0x769BB10", VA = "0x18769D110")]
	public static void DLKPGNNJPGK(byte[] FPGJFOLEKAK, int JBCPGNDLJHB, short BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x769D060", Offset = "0x769BA60", VA = "0x18769D060")]
	public static void DIAJGAJCGKI(byte[] BNICMFHPCJC, int MHADOGLMBLF, double KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x769D090", Offset = "0x769BA90", VA = "0x18769D090")]
	public static void DIAJGAJCGKI(byte[] BNICMFHPCJC, int MHADOGLMBLF, float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x769D110", Offset = "0x769BB10", VA = "0x18769D110")]
	public static void DIAJGAJCGKI(byte[] BNICMFHPCJC, int MHADOGLMBLF, short KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x769D110", Offset = "0x769BB10", VA = "0x18769D110")]
	public static void DIAJGAJCGKI(byte[] BNICMFHPCJC, int MHADOGLMBLF, ushort KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x769CFF0", Offset = "0x769B9F0", VA = "0x18769CFF0")]
	public static void DIAJGAJCGKI(byte[] BNICMFHPCJC, int MHADOGLMBLF, int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x769CFF0", Offset = "0x769B9F0", VA = "0x18769CFF0")]
	public static void DIAJGAJCGKI(byte[] BNICMFHPCJC, int MHADOGLMBLF, uint KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x769D080", Offset = "0x769BA80", VA = "0x18769D080")]
	public static void DIAJGAJCGKI(byte[] BNICMFHPCJC, int MHADOGLMBLF, long KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x769D080", Offset = "0x769BA80", VA = "0x18769D080")]
	public static void DIAJGAJCGKI(byte[] BNICMFHPCJC, int MHADOGLMBLF, ulong KMAFNKGMDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class IMGBCLHPFOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] CPMOFDFKMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int FDFKLCIEKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int NJCCBICCMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int ACDDBELKPIN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] FNIOKBMKPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int KCOGOGFDEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int EIDGECHJIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x769CC80", Offset = "0x769B680", VA = "0x18769CC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LHODJCOPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x29FB1E0", Offset = "0x29F9BE0", VA = "0x1829FB1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BDDNPNDOJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x769CED0", Offset = "0x769B8D0", VA = "0x18769CED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x769CC40", Offset = "0x769B640", VA = "0x18769CC40")]
	public void OCHFINBBLJK(byte[] PBOCDEMNFLD, int JBCPGNDLJHB, int OFAGCDELFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IMGBCLHPFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x769CF90", Offset = "0x769B990", VA = "0x18769CF90")]
	public IMGBCLHPFOC(byte[] PBOCDEMNFLD, int JBCPGNDLJHB, int OFAGCDELFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x769C470", Offset = "0x769AE70", VA = "0x18769C470")]
	public IPEndPoint CJPHMFELKPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x769C3F0", Offset = "0x769ADF0", VA = "0x18769C3F0")]
	public byte NJIAONMEAIM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x769C3F0", Offset = "0x769ADF0", VA = "0x18769C3F0")]
	public sbyte BBCIHBEPHGC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD040", Offset = "0x3DFBA40", VA = "0x183DFD040")]
	public T[] BHMCFHPPBOJ<T>(ushort BCAJFCGHDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x769C8E0", Offset = "0x769B2E0", VA = "0x18769C8E0")]
	public bool[] LBALGHELNEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x769C7C0", Offset = "0x769B1C0", VA = "0x18769C7C0")]
	public ushort[] KIDONPAJMPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x769C740", Offset = "0x769B140", VA = "0x18769C740")]
	public short[] IMOOGHGPKCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x769CF50", Offset = "0x769B950", VA = "0x18769CF50")]
	public int[] PKEIGDELLPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x769C700", Offset = "0x769B100", VA = "0x18769C700")]
	public uint[] IIMIIDPAJII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x769C780", Offset = "0x769B180", VA = "0x18769C780")]
	public float[] INFIHJDIMBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x769C430", Offset = "0x769AE30", VA = "0x18769C430")]
	public double[] CDELHCIDIIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x769CB90", Offset = "0x769B590", VA = "0x18769CB90")]
	public long[] NLHFCOHBHOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x769C540", Offset = "0x769AF40", VA = "0x18769C540")]
	public ulong[] DCFIJJNKEGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x769C990", Offset = "0x769B390", VA = "0x18769C990")]
	public string[] MIIJKGGCHLO(int CLOAEJAHLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x769CAE0", Offset = "0x769B4E0", VA = "0x18769CAE0")]
	public bool MNLLJDJONLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x769C920", Offset = "0x769B320", VA = "0x18769C920")]
	public char LGDEJBOIKJK()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x769C920", Offset = "0x769B320", VA = "0x18769C920")]
	public ushort NMLKAHNNKAF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x769C580", Offset = "0x769AF80", VA = "0x18769C580")]
	public short DHMJDBICLEI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x769CBD0", Offset = "0x769B5D0", VA = "0x18769CBD0")]
	public long OBILMEDGFHB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x769C650", Offset = "0x769B050", VA = "0x18769C650")]
	public ulong HGBKPDHCCON()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x769C380", Offset = "0x769AD80", VA = "0x18769C380")]
	public int ADKFKLHDKCO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x769CEE0", Offset = "0x769B8E0", VA = "0x18769CEE0")]
	public uint PDDHGAHFJKN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x769CB20", Offset = "0x769B520", VA = "0x18769CB20")]
	public float NAANBCKCMPE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x769C800", Offset = "0x769B200", VA = "0x18769C800")]
	public double KLPFIKBKKKJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x769CC90", Offset = "0x769B690", VA = "0x18769CC90")]
	public string PBDJEFHBIMG(int HCJFIGIPJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x769C870", Offset = "0x769B270", VA = "0x18769C870")]
	public ArraySegment<byte> KNFMHEHOPOI(int MHMCOJIKNCI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x769C610", Offset = "0x769B010", VA = "0x18769C610")]
	public sbyte[] FECCJDDBCBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x769C6C0", Offset = "0x769B0C0", VA = "0x18769C6C0")]
	public byte[] HOAIDGGMBKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x769C5F0", Offset = "0x769AFF0", VA = "0x18769C5F0")]
	public void EMMOLKMNHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BCFDIDMCMBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] CPMOFDFKMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int FDFKLCIEKGG;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int FMKGCABBJLI = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool LAOJFPKCMCL;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding FHLIGJKFPHO;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int BKFLGCIPCDE = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] LOIDDJNFMMD;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] AMLFHELBNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x768F0B0", Offset = "0x768DAB0", VA = "0x18768F0B0")]
	public BCFDIDMCMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x768F130", Offset = "0x768DB30", VA = "0x18768F130")]
	public BCFDIDMCMBH(bool KMPNEIKAFFA, int BDFAMINMJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x768EFB0", Offset = "0x768D9B0", VA = "0x18768EFB0")]
	public static BCFDIDMCMBH KNDMBFMMLME(string KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x768E380", Offset = "0x768CD80", VA = "0x18768E380")]
	public void AHMIPLFLEPK(int DCGNAGFNNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2A748D0", Offset = "0x2A732D0", VA = "0x182A748D0")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x768E950", Offset = "0x768D350", VA = "0x18768E950")]
	public void HDGLNLNLHEG(float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x768EAB0", Offset = "0x768D4B0", VA = "0x18768EAB0")]
	public void HDGLNLNLHEG(double KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x768EA60", Offset = "0x768D460", VA = "0x18768EA60")]
	public void HDGLNLNLHEG(long KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x768EA60", Offset = "0x768D460", VA = "0x18768EA60")]
	public void HDGLNLNLHEG(ulong KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x768ECB0", Offset = "0x768D6B0", VA = "0x18768ECB0")]
	public void HDGLNLNLHEG(int KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x768ECB0", Offset = "0x768D6B0", VA = "0x18768ECB0")]
	public void HDGLNLNLHEG(uint KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x768EB00", Offset = "0x768D500", VA = "0x18768EB00")]
	public void HDGLNLNLHEG(char KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x768EB00", Offset = "0x768D500", VA = "0x18768EB00")]
	public void HDGLNLNLHEG(ushort KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x768EB00", Offset = "0x768D500", VA = "0x18768EB00")]
	public void HDGLNLNLHEG(short KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x768E9F0", Offset = "0x768D3F0", VA = "0x18768E9F0")]
	public void HDGLNLNLHEG(sbyte KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x768E9F0", Offset = "0x768D3F0", VA = "0x18768E9F0")]
	public void HDGLNLNLHEG(byte KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x768EB70", Offset = "0x768D570", VA = "0x18768EB70")]
	public void HDGLNLNLHEG(byte[] BLPDDGCLNPE, int JBCPGNDLJHB, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x768E420", Offset = "0x768CE20", VA = "0x18768E420")]
	public void MFPHCFPNFLP(sbyte[] BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x768E420", Offset = "0x768CE20", VA = "0x18768E420")]
	public void DEFKOBFADGD(byte[] BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x768ED40", Offset = "0x768D740", VA = "0x18768ED40")]
	public void HDGLNLNLHEG(bool KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x768E5E0", Offset = "0x768CFE0", VA = "0x18768E5E0")]
	public void FHOEKIGLIAL(Array IIHNJOKLOOP, int GOKGFKEOCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x768E500", Offset = "0x768CF00", VA = "0x18768E500")]
	public void FHOEKIGLIAL(float[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x768E6C0", Offset = "0x768D0C0", VA = "0x18768E6C0")]
	public void FHOEKIGLIAL(double[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x768E6C0", Offset = "0x768D0C0", VA = "0x18768E6C0")]
	public void FHOEKIGLIAL(long[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x768E6C0", Offset = "0x768D0C0", VA = "0x18768E6C0")]
	public void FHOEKIGLIAL(ulong[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x768E500", Offset = "0x768CF00", VA = "0x18768E500")]
	public void FHOEKIGLIAL(int[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x768E500", Offset = "0x768CF00", VA = "0x18768E500")]
	public void FHOEKIGLIAL(uint[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x768E870", Offset = "0x768D270", VA = "0x18768E870")]
	public void FHOEKIGLIAL(ushort[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x768E870", Offset = "0x768D270", VA = "0x18768E870")]
	public void FHOEKIGLIAL(short[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x768E420", Offset = "0x768CE20", VA = "0x18768E420")]
	public void FHOEKIGLIAL(bool[] KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x768E7A0", Offset = "0x768D1A0", VA = "0x18768E7A0")]
	public void FHOEKIGLIAL(string[] KMAFNKGMDCF, int NGHOOJMBNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x768EBE0", Offset = "0x768D5E0", VA = "0x18768EBE0")]
	public void HDGLNLNLHEG(IPEndPoint DNGINKCMEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x768EA50", Offset = "0x768D450", VA = "0x18768EA50")]
	public void HDGLNLNLHEG(string KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x768EDA0", Offset = "0x768D7A0", VA = "0x18768EDA0")]
	public void HDGLNLNLHEG(string KMAFNKGMDCF, int HCJFIGIPJBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class HJCFMKEBGPM
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class NIPIGCGEGPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong BKICOPKGOOC;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5A5FAB0", Offset = "0x5A5E4B0", VA = "0x185A5FAB0")]
		static NIPIGCGEGPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void CLFBIOLONDM(IMGBCLHPFOC DIKMKPGIBMB, object PNNAGAOBHKH);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OCGPGOHECCE<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public HJCFMKEBGPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OCGPGOHECCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x5B9C700", Offset = "0x5B9B100", VA = "0x185B9C700")]
		internal void HHILIMEJFII(IMGBCLHPFOC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CBNGOBAAAJH<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public HJCFMKEBGPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CBNGOBAAAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF99C0", Offset = "0x6BF83C0", VA = "0x186BF99C0")]
		internal void HHILIMEJFII(IMGBCLHPFOC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly FFCIFNJBHAK AKCLHGKBMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, CLFBIOLONDM> PPAPGFEHEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly BCFDIDMCMBH DCBOOBICENJ;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x769B290", Offset = "0x7699C90", VA = "0x18769B290")]
	public HJCFMKEBGPM(int CLOAEJAHLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3B84BD0", Offset = "0x3B835D0", VA = "0x183B84BD0", Slot = "4")]
	protected virtual ulong OFMBKNEAOEA<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x769B110", Offset = "0x7699B10", VA = "0x18769B110", Slot = "5")]
	protected virtual CLFBIOLONDM JGNJGGBLGLH(IMGBCLHPFOC DIKMKPGIBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC7B0", Offset = "0x3DCB1B0", VA = "0x183DCC7B0", Slot = "6")]
	protected virtual void OJMPFPJHLKE<T>(BCFDIDMCMBH EAPDKLFLMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x769B090", Offset = "0x7699A90", VA = "0x18769B090")]
	public void AAPLGLBEGIH(IMGBCLHPFOC DIKMKPGIBMB, object PNNAGAOBHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC720", Offset = "0x3DCB120", VA = "0x183DCC720")]
	public void MGCEPLPNMLJ<T>(BCFDIDMCMBH EAPDKLFLMNB, T FCGCBCBMMCB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x769B240", Offset = "0x7699C40", VA = "0x18769B240")]
	public void KELIKLEHDMF(IMGBCLHPFOC DIKMKPGIBMB, object PNNAGAOBHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC5A0", Offset = "0x3DCAFA0", VA = "0x183DCC5A0")]
	public void EBLOBMCPNJA<T>(Action<T> NMHPAOLBIHJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC420", Offset = "0x3DCAE20", VA = "0x183DCC420")]
	public void EBLOBMCPNJA<T, TUserData>(Action<T, TUserData> NMHPAOLBIHJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PBJGPLCMLCP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x768E370", Offset = "0x768CD70", VA = "0x18768E370")]
	public PBJGPLCMLCP(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class DMFLAKOMMID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7698DD0", Offset = "0x76977D0", VA = "0x187698DD0")]
	public DMFLAKOMMID(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class FFCIFNJBHAK
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum DKKHLEAHAEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class FBFKBJGNFLN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public DKKHLEAHAEE EMHLKEMKMPE;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4FAC560", Offset = "0x4FAAF60", VA = "0x184FAC560", Slot = "4")]
		public virtual void LHEJPJMHOBO(MethodInfo JBIMOIGCMBF, MethodInfo LBFMEOMIKGP, DKKHLEAHAEE DGNODDPLLPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KAIFLACECEA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void LCNDBHPKFFD(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		protected FBFKBJGNFLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class PEBEDBBJFJL<TClass, TProperty> : FBFKBJGNFLN<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> MCILEPLAMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> CEKGNAHKOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> DIEJFNHCLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> BKAIONNGENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> MJGDKBHHDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> HMJMPMIGHKA;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B280", Offset = "0x5C99C80", VA = "0x185C9B280", Slot = "7")]
		public override void KPPNBGAJDNH(TClass MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5C99A70", Offset = "0x5C98470", VA = "0x185C99A70", Slot = "8")]
		public override void ECMMACFGBAO(TClass MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5C99ED0", Offset = "0x5C988D0", VA = "0x185C99ED0", Slot = "9")]
		public override void KAIFLACECEA(TClass MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B980", Offset = "0x5C9A380", VA = "0x185C9B980", Slot = "10")]
		public override void LCNDBHPKFFD(TClass MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0C20", Offset = "0x5C9F620", VA = "0x185CA0C20")]
		protected TProperty[] NFMHCDLGNHE(TClass MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5C9AA30", Offset = "0x5C99430", VA = "0x185C9AA30")]
		protected TProperty[] KDEGLBBECDJ(TClass MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5C9E3E0", Offset = "0x5C9CDE0", VA = "0x185C9E3E0", Slot = "4")]
		public override void LHEJPJMHOBO(MethodInfo JBIMOIGCMBF, MethodInfo LBFMEOMIKGP, DKKHLEAHAEE DGNODDPLLPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0D10", Offset = "0x5C9F710", VA = "0x185CA0D10")]
		protected PEBEDBBJFJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class OOFEAJGPCNG<TClass, TProperty> : PEBEDBBJFJL<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void GNOLCKEBMOG(IMGBCLHPFOC OLMEHKPIJHD, [Out] TProperty OPOCCNFJIPA);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void PEIOHIPKHHA(BCFDIDMCMBH LIPBKGAOLBA, TProperty OPOCCNFJIPA);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5F20", Offset = "0x5BD4920", VA = "0x185BD5F20", Slot = "5")]
		public override void NDHDDMEPDIA(TClass MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5E40", Offset = "0x5BD4840", VA = "0x185BD5E40", Slot = "6")]
		public override void MGCEPLPNMLJ(TClass MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5DA0", Offset = "0x5BD47A0", VA = "0x185BD5DA0", Slot = "7")]
		public override void KPPNBGAJDNH(TClass MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5C60", Offset = "0x5BD4660", VA = "0x185BD5C60", Slot = "8")]
		public override void ECMMACFGBAO(TClass MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x52EF700", Offset = "0x52EE100", VA = "0x1852EF700")]
		protected OOFEAJGPCNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class OLCMOMDKIHF<T> : PEBEDBBJFJL<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5BC0630", Offset = "0x5BBF030", VA = "0x185BC0630", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5BC05D0", Offset = "0x5BBEFD0", VA = "0x185BC05D0", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5BC0570", Offset = "0x5BBEF70", VA = "0x185BC0570", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5649FD0", Offset = "0x56489D0", VA = "0x185649FD0", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public OLCMOMDKIHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class PNILFKGMMGF<T> : PEBEDBBJFJL<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6CA0", Offset = "0x5CC56A0", VA = "0x185CC6CA0", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5BC05D0", Offset = "0x5BBEFD0", VA = "0x185BC05D0", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6C40", Offset = "0x5CC5640", VA = "0x185CC6C40", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5649FD0", Offset = "0x56489D0", VA = "0x185649FD0", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public PNILFKGMMGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class OILKFCNFIPH<T> : PEBEDBBJFJL<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5BB59D0", Offset = "0x5BB43D0", VA = "0x185BB59D0", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x512FDF0", Offset = "0x512E7F0", VA = "0x18512FDF0", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5BB5970", Offset = "0x5BB4370", VA = "0x185BB5970", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x512FD30", Offset = "0x512E730", VA = "0x18512FD30", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public OILKFCNFIPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GJLNDKGLLGH<T> : PEBEDBBJFJL<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x512FE50", Offset = "0x512E850", VA = "0x18512FE50", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x512FDF0", Offset = "0x512E7F0", VA = "0x18512FDF0", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x512FD90", Offset = "0x512E790", VA = "0x18512FD90", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x512FD30", Offset = "0x512E730", VA = "0x18512FD30", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public GJLNDKGLLGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class EDJDBCMCLPL<T> : PEBEDBBJFJL<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4AFEB50", Offset = "0x4AFD550", VA = "0x184AFEB50", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4AFEAF0", Offset = "0x4AFD4F0", VA = "0x184AFEAF0", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4AFEA90", Offset = "0x4AFD490", VA = "0x184AFEA90", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4AFEA30", Offset = "0x4AFD430", VA = "0x184AFEA30", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public EDJDBCMCLPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class IJNIGBOIMKF<T> : PEBEDBBJFJL<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x52F0AA0", Offset = "0x52EF4A0", VA = "0x1852F0AA0", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4AFEAF0", Offset = "0x4AFD4F0", VA = "0x184AFEAF0", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x52F0A40", Offset = "0x52EF440", VA = "0x1852F0A40", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4AFEA30", Offset = "0x4AFD430", VA = "0x184AFEA30", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public IJNIGBOIMKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class EKDDCIJLCHL<T> : PEBEDBBJFJL<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4B2F4F0", Offset = "0x4B2DEF0", VA = "0x184B2F4F0", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4B2F490", Offset = "0x4B2DE90", VA = "0x184B2F490", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4B2F430", Offset = "0x4B2DE30", VA = "0x184B2F430", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4B2F3D0", Offset = "0x4B2DDD0", VA = "0x184B2F3D0", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public EKDDCIJLCHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class MNCHEEKJKNJ<T> : PEBEDBBJFJL<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4B2F4F0", Offset = "0x4B2DEF0", VA = "0x184B2F4F0", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4B2F490", Offset = "0x4B2DE90", VA = "0x184B2F490", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x59F21A0", Offset = "0x59F0BA0", VA = "0x1859F21A0", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4B2F3D0", Offset = "0x4B2DDD0", VA = "0x184B2F3D0", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public MNCHEEKJKNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class KDFJCLHPLHE<T> : PEBEDBBJFJL<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x564A0F0", Offset = "0x5648AF0", VA = "0x18564A0F0", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x564A090", Offset = "0x5648A90", VA = "0x18564A090", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x564A030", Offset = "0x5648A30", VA = "0x18564A030", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5649FD0", Offset = "0x56489D0", VA = "0x185649FD0", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public KDFJCLHPLHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class HPFIEHEDLBK<T> : PEBEDBBJFJL<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5220A30", Offset = "0x521F430", VA = "0x185220A30", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x52209D0", Offset = "0x521F3D0", VA = "0x1852209D0", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5220970", Offset = "0x521F370", VA = "0x185220970", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4AFEA30", Offset = "0x4AFD430", VA = "0x184AFEA30", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public HPFIEHEDLBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class OFHMIAIEJHD<T> : PEBEDBBJFJL<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5BAC140", Offset = "0x5BAAB40", VA = "0x185BAC140", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5BAC0E0", Offset = "0x5BAAAE0", VA = "0x185BAC0E0", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5BAC080", Offset = "0x5BAAA80", VA = "0x185BAC080", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4B2F3D0", Offset = "0x4B2DDD0", VA = "0x184B2F3D0", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
		public OFHMIAIEJHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class HAMOLDBHECB<T> : OOFEAJGPCNG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x518A560", Offset = "0x5188F60", VA = "0x18518A560", Slot = "12")]
		protected override void PEIOHIPKHHA(BCFDIDMCMBH LIPBKGAOLBA, char OPOCCNFJIPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x518A530", Offset = "0x5188F30", VA = "0x18518A530", Slot = "11")]
		protected override void GNOLCKEBMOG(IMGBCLHPFOC OLMEHKPIJHD, [Out] char OPOCCNFJIPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x45C5A90", Offset = "0x45C4490", VA = "0x1845C5A90")]
		public HAMOLDBHECB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class EFOMGJLOIFK<T> : OOFEAJGPCNG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4B0DA60", Offset = "0x4B0C460", VA = "0x184B0DA60", Slot = "12")]
		protected override void PEIOHIPKHHA(BCFDIDMCMBH LIPBKGAOLBA, IPEndPoint OPOCCNFJIPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B0DA20", Offset = "0x4B0C420", VA = "0x184B0DA20", Slot = "11")]
		protected override void GNOLCKEBMOG(IMGBCLHPFOC OLMEHKPIJHD, [Out] IPEndPoint OPOCCNFJIPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x45C5A90", Offset = "0x45C4490", VA = "0x1845C5A90")]
		public EFOMGJLOIFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class NNPEMHIFOMM<T> : PEBEDBBJFJL<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int IFLFODIJCEJ;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5A69150", Offset = "0x5A67B50", VA = "0x185A69150")]
		public NNPEMHIFOMM(int HCJFIGIPJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5A690E0", Offset = "0x5A67AE0", VA = "0x185A690E0", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5A69070", Offset = "0x5A67A70", VA = "0x185A69070", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5A69000", Offset = "0x5A67A00", VA = "0x185A69000", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5A68F90", Offset = "0x5A67990", VA = "0x185A68F90", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class EGKCMHLHLFI<T> : FBFKBJGNFLN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo PPFHHPOBDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type KOHNOJFBACP;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4B11580", Offset = "0x4B0FF80", VA = "0x184B11580")]
		public EGKCMHLHLFI(PropertyInfo ELEBIIGLBPL, Type DMAMNNDEICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4B114C0", Offset = "0x4B0FEC0", VA = "0x184B114C0", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4B11410", Offset = "0x4B0FE10", VA = "0x184B11410", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4B11350", Offset = "0x4B0FD50", VA = "0x184B11350", Slot = "7")]
		public override void KPPNBGAJDNH(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4B11290", Offset = "0x4B0FC90", VA = "0x184B11290", Slot = "8")]
		public override void ECMMACFGBAO(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4B112F0", Offset = "0x4B0FCF0", VA = "0x184B112F0", Slot = "9")]
		public override void KAIFLACECEA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4B113B0", Offset = "0x4B0FDB0", VA = "0x184B113B0", Slot = "10")]
		public override void LCNDBHPKFFD(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class JODMMAGINML<T> : EGKCMHLHLFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4689B60", Offset = "0x4688560", VA = "0x184689B60")]
		public JODMMAGINML(PropertyInfo ELEBIIGLBPL, Type DMAMNNDEICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x554CDF0", Offset = "0x554B7F0", VA = "0x18554CDF0", Slot = "5")]
		public override void NDHDDMEPDIA(T MKAAOFIDAAN, IMGBCLHPFOC OLMEHKPIJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x554CD40", Offset = "0x554B740", VA = "0x18554CD40", Slot = "6")]
		public override void MGCEPLPNMLJ(T MKAAOFIDAAN, BCFDIDMCMBH LIPBKGAOLBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class HDLPMDGDPMI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static HDLPMDGDPMI<T> FLGHCDNLMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly FBFKBJGNFLN<T>[] ILMPPHFLBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int CLPLNJLHCGD;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x51A2190", Offset = "0x51A0B90", VA = "0x1851A2190")]
		public HDLPMDGDPMI(List<FBFKBJGNFLN<T>> JIPHFBLJCCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x51A2030", Offset = "0x51A0A30", VA = "0x1851A2030")]
		public void MGCEPLPNMLJ(T PMNHIPACJLN, BCFDIDMCMBH EAPDKLFLMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x51A20E0", Offset = "0x51A0AE0", VA = "0x1851A20E0")]
		public void NDHDDMEPDIA(T PMNHIPACJLN, IMGBCLHPFOC DIKMKPGIBMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class DBKALGLAAID
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FBFKBJGNFLN<T> GFFPJLNAMHB<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private BCFDIDMCMBH EIAPDIBLIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int HJKGMDAKPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, DBKALGLAAID> KLDPLIGEHEI;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7699650", Offset = "0x7698050", VA = "0x187699650")]
	public FFCIFNJBHAK(int CLOAEJAHLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3D69390", Offset = "0x3D67D90", VA = "0x183D69390")]
	private HDLPMDGDPMI<T> AOIFODPLHGN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x32D2C60", Offset = "0x32D1660", VA = "0x1832D2C60")]
	public void NFFNLBFBLBL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A2C0", Offset = "0x3D68CC0", VA = "0x183D6A2C0")]
	public bool LEOAOCFGODA<T>(IMGBCLHPFOC DIKMKPGIBMB, T JFBLIPHGGPK) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A260", Offset = "0x3D68C60", VA = "0x183D6A260")]
	public void GCGCKFHBJPB<T>(BCFDIDMCMBH EAPDKLFLMNB, T PMNHIPACJLN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class BPCCGCDOJEK
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime DEGCPPMBJHN;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] KCCMIEENPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public MNCJKCKBBPJ FOFMBODKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x768F810", Offset = "0x768E210", VA = "0x18768F810")]
		get
		{
			return default(MNCJKCKBBPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int NJJEJHFIEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x768FCC0", Offset = "0x768E6C0", VA = "0x18768FCC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x768FBA0", Offset = "0x768E5A0", VA = "0x18768FBA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public MFKKEHGDCGK ALNCFHODKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x768F8A0", Offset = "0x768E2A0", VA = "0x18768F8A0")]
		get
		{
			return default(MFKKEHGDCGK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7690510", Offset = "0x768EF10", VA = "0x187690510")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int GDDNALFBNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x768FEC0", Offset = "0x768E8C0", VA = "0x18768FEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint GCLANAKPHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x768FBE0", Offset = "0x768E5E0", VA = "0x18768FBE0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? BKOMAFNJMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x768F7E0", Offset = "0x768E1E0", VA = "0x18768F7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? EDCHALHAHII
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x768FC60", Offset = "0x768E660", VA = "0x18768FC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? LCCOBOKHPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x768FC90", Offset = "0x768E690", VA = "0x18768FC90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768E6F0", VA = "0x18768FCF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? ICCFCNLDEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7690860", Offset = "0x768F260", VA = "0x187690860")]
	public BPCCGCDOJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x76907B0", Offset = "0x768F1B0", VA = "0x1876907B0")]
	internal BPCCGCDOJEK(byte[] BNICMFHPCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x768FF80", Offset = "0x768E980", VA = "0x18768FF80")]
	public static BPCCGCDOJEK MHHICHFDKFP(byte[] BNICMFHPCJC, DateTime IIPHIJGFMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7690550", Offset = "0x768EF50", VA = "0x187690550")]
	internal void PALGCMBBJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x76900A0", Offset = "0x768EAA0", VA = "0x1876900A0")]
	private void NDGKBILJJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x768F8D0", Offset = "0x768E2D0", VA = "0x18768F8D0")]
	private DateTime? EANMLONJLMK(int JBCPGNDLJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7690280", Offset = "0x768EC80", VA = "0x187690280")]
	private void NFEAGAPMIIJ(int JBCPGNDLJHB, DateTime? KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x768FAD0", Offset = "0x768E4D0", VA = "0x18768FAD0")]
	private ulong EKHJPGPPBHO(int JBCPGNDLJHB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7690450", Offset = "0x768EE50", VA = "0x187690450")]
	private void NMMHPFJFGIA(int JBCPGNDLJHB, ulong KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x768FEF0", Offset = "0x768E8F0", VA = "0x18768FEF0")]
	private uint LPKJKONIFMN(int JBCPGNDLJHB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7559650", Offset = "0x7558050", VA = "0x187559650")]
	private static uint BCDAMOIAHMO(uint FKPKEFAKAOE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x768F840", Offset = "0x768E240", VA = "0x18768F840")]
	private static ulong BCDAMOIAHMO(ulong FKPKEFAKAOE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum MNCJKCKBBPJ
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
public enum MFKKEHGDCGK
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class BPHNNNGJPAF
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int FLJCIBALANC = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int OEHJLMBGHFK = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int JGJHEPOCMAJ = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint LIMOLKJIDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int EBMFGNKPHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int AGKOMAONEIA;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MGCAMMMDLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7690C70", Offset = "0x768F670", VA = "0x187690C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7690B80", Offset = "0x768F580", VA = "0x187690B80")]
	public bool DNKNDAIHBMF(GIGCJDNLLPE CNGGNHCPPML, int LKKNOPLOOPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class EKHJFJMFDLI : GIGCJDNLLPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket CNGGNHCPPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly DJHMOAKFJMI BFFBDJAHOLH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short FIPJHPDMIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7698E50", Offset = "0x7697850", VA = "0x187698E50", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int MJLIHJCFNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7698E30", Offset = "0x7697830", VA = "0x187698E30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint CKFAGKKHGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7699560", Offset = "0x7697F60", VA = "0x187699560", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily FOPBHGAFJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x32A8A40", Offset = "0x32A7440", VA = "0x1832A8A40", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x76995A0", Offset = "0x7697FA0", VA = "0x1876995A0")]
	public EKHJFJMFDLI(AddressFamily IBGGDKOPBMH, DJHMOAKFJMI BFFBDJAHOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7698FA0", Offset = "0x76979A0", VA = "0x187698FA0", Slot = "8")]
	public bool IAPEHFKIOKF(IPEndPoint DNGINKCMEFD, PAIPMAJJOAK GCMECHFBHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7698F60", Offset = "0x7697960", VA = "0x187698F60", Slot = "9")]
	public int FGLIAALAMPF(byte[] FPGJFOLEKAK, int JBCPGNDLJHB, int BCAJFCGHDKI, IPEndPoint FIAGCGPPMLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7698E70", Offset = "0x7697870", VA = "0x187698E70", Slot = "10")]
	public int DJLFIODPNEI(byte[] FPGJFOLEKAK, EndPoint JBGLLAHBCID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7699580", Offset = "0x7697F80", VA = "0x187699580", Slot = "11")]
	public void NJINDLCNMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface GIGCJDNLLPE
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short FIPJHPDMIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int MJLIHJCFNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint CKFAGKKHGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily FOPBHGAFJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IAPEHFKIOKF(IPEndPoint DNGINKCMEFD, PAIPMAJJOAK GCMECHFBHPN);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int FGLIAALAMPF(byte[] FPGJFOLEKAK, int JBCPGNDLJHB, int BCAJFCGHDKI, IPEndPoint FIAGCGPPMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DJLFIODPNEI(byte[] FPGJFOLEKAK, EndPoint FIAGCGPPMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NJINDLCNMIH();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct OFIAICAFKOE : IEquatable<OFIAICAFKOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long GKKAOALDCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long AKHHPFHMJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long CCOJBEABFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int DKIJFPKBKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int OBDHPFLIHBB;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x76A1580", Offset = "0x769FF80", VA = "0x1876A1580")]
	public OFIAICAFKOE(byte[] MDKBLKNBANL, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x76A1640", Offset = "0x76A0040", VA = "0x1876A1640")]
	public OFIAICAFKOE(Span<byte> MDKBLKNBANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x76A1540", Offset = "0x769FF40", VA = "0x1876A1540", Slot = "4")]
	public bool Equals(OFIAICAFKOE GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x76A1490", Offset = "0x769FE90", VA = "0x1876A1490", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class FHGGHCDOMEI : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] CKGPMPFBDBO;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ELKPAHLKFLP
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void MDOGGAKKDOG(IPEndPoint MDKBLKNBANL, Span<byte> BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string BAGLACOHFKO = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int BIIKHAHFMKK = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int BOKOFIEOFEH = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int LEHLPKMDMKJ = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<OFIAICAFKOE, IPEndPoint> BEPNDHJKBFB;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static MDOGGAKKDOG MFCJMJPGJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int CNCDNCKBCDD;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	internal void FAFKPJKFKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	internal void NALKDECCCJO(IPEndPoint FIAGCGPPMLJ, Span<byte> BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class EDIAFENCNIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int PNLFKAGJMCF;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
	protected EDIAFENCNIJ(int KALEJCMMENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KJJFNPMNGHD(IPEndPoint DNGINKCMEFD, byte[] BLPDDGCLNPE, int JBCPGNDLJHB, int AJDEGEPLAEO);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void FGHIPKLFHLJ(IPEndPoint DNGINKCMEFD, byte[] BLPDDGCLNPE, int JBCPGNDLJHB, int AJDEGEPLAEO);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class JFPNGIKNHEA : EDIAFENCNIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] HPFHOBCPNEF;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator BGAEHEJHHEP;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B4E0", Offset = "0x2B79EE0", VA = "0x182B7B4E0")]
	public JFPNGIKNHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x769D230", Offset = "0x769BC30", VA = "0x18769D230")]
	public void BJIKCGAGFJO(IPEndPoint DNGINKCMEFD, byte[] HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x769D750", Offset = "0x769C150", VA = "0x18769D750")]
	public void FMDHGIIJKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x769D830", Offset = "0x769C230", VA = "0x18769D830", Slot = "4")]
	public override void KJJFNPMNGHD(IPEndPoint DNGINKCMEFD, byte[] BLPDDGCLNPE, int JBCPGNDLJHB, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x769D3E0", Offset = "0x769BDE0", VA = "0x18769D3E0", Slot = "5")]
	public override void FGHIPKLFHLJ(IPEndPoint DNGINKCMEFD, byte[] BLPDDGCLNPE, int JBCPGNDLJHB, int AJDEGEPLAEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct NFPDAMHEBLK
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void DGBJHECOFJN([NoAlias] byte* GHHKDMGGMLF, [NoAlias] byte* HPFHOBCPNEF, [NoAlias] byte* GANNLKLDPAF, int AJDEGEPLAEO);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class NIFEPHGMHCD
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x76A6990", Offset = "0x76A5390", VA = "0x1876A6990")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x76A6AC0", Offset = "0x76A54C0", VA = "0x1876A6AC0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x76A66A0", Offset = "0x76A50A0", VA = "0x1876A66A0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x76A6750", Offset = "0x76A5150", VA = "0x1876A6750")]
		public unsafe static void KDMGDDCNHFD([NoAlias] byte* GHHKDMGGMLF, [NoAlias] byte* HPFHOBCPNEF, [NoAlias] byte* GANNLKLDPAF, int AJDEGEPLAEO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint HPFHOBCPNEF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint GANNLKLDPAF[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint NMHBMBGEJEE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint GKAPIKHBLNH[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint ALIOAKABMJE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint DAOKEHBBINJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint JIGNGCLDIFA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint LKLAGNGJAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint AMANNJNDJGG[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x76A1200", Offset = "0x769FC00", VA = "0x1876A1200")]
	private void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x76A0BF0", Offset = "0x769F5F0", VA = "0x1876A0BF0")]
	private uint FFPGMGJPKGI(uint FEBGNHCBECK, int DDEIHHFHHME)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x768DF20", Offset = "0x768C920", VA = "0x18768DF20")]
	private void DPOJIHCMKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x768E0D0", Offset = "0x768CAD0", VA = "0x18768E0D0")]
	private void JHICPCGLKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x768E2E0", Offset = "0x768CCE0", VA = "0x18768E2E0")]
	private void LOCMEPHDHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x768DFD0", Offset = "0x768C9D0", VA = "0x18768DFD0")]
	private void IBEPDDIPJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x76A11A0", Offset = "0x769FBA0", VA = "0x1876A11A0")]
	private void IDFFJBENOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x76A0C20", Offset = "0x769F620", VA = "0x1876A0C20")]
	private unsafe void GCLCMELOOLI(byte* GHHKDMGGMLF, uint* HPFHOBCPNEF, uint* GANNLKLDPAF, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x76A1040", Offset = "0x769FA40", VA = "0x1876A1040")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void HLOKAEIHHGD([NoAlias] byte* GHHKDMGGMLF, [NoAlias] byte* HPFHOBCPNEF, [NoAlias] byte* GANNLKLDPAF, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x76A10C0", Offset = "0x769FAC0", VA = "0x1876A10C0")]
	public static void HLOKAEIHHGD(Span<byte> GHHKDMGGMLF, Span<byte> HPFHOBCPNEF, Span<byte> GANNLKLDPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x76A1280", Offset = "0x769FC80", VA = "0x1876A1280")]
	public static void PDDDJFLDNFC(Span<byte> GHHKDMGGMLF, Span<byte> HPFHOBCPNEF, Span<byte> GANNLKLDPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x76A1380", Offset = "0x769FD80", VA = "0x1876A1380")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void PHEBODBLGNE([NoAlias] byte* GHHKDMGGMLF, [NoAlias] byte* HPFHOBCPNEF, [NoAlias] byte* GANNLKLDPAF, int AJDEGEPLAEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C20", Offset = "0x76A5620", VA = "0x1876A6C20")]
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
